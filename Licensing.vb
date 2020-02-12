Imports System.Collections.Generic
Imports System.IO
Imports System.Linq
Imports System.Runtime.CompilerServices
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.Security.Cryptography
Imports Eureka.Common.Addons.Eureka.Common.Addons
Imports Sage.Common.Data

Module Licensing
    <Extension()>
    Private Iterator Function ChunksOf(Of item)(items As item(), chunkLength As Integer, Optional padWith As item = Nothing) As IEnumerable(Of item())
        Dim i As Integer = 0
        While i < items.Length
            If i + chunkLength > items.Length - 1 And Not IsNothing(padWith) Then
                Dim lastChunk As item() = Enumerable.Repeat(padWith, chunkLength).ToArray
                Array.Copy(items, i, lastChunk, 0, items.Length - i)
                Yield lastChunk
            Else
                Yield items.Skip(i).Take(chunkLength).ToArray
            End If

            i += chunkLength
        End While
    End Function

    Public Function ComputeLicenseHash(sageAccountNumber As String, licensedAddonName As String, expiryDate As Date) As Byte()
        Dim binaryFormatter As New BinaryFormatter

        Using stream As New MemoryStream
            binaryFormatter.Serialize(stream, sageAccountNumber)
            binaryFormatter.Serialize(stream, licensedAddonName)
            binaryFormatter.Serialize(stream, expiryDate)

            Return stream.ToArray
        End Using
    End Function

    Public Function ComputeLicenseKey(sageAccountNumber As String, licensedAddonName As String, expiryDate As Date) As String
        Dim hash As Byte() = ComputeLicenseHash(sageAccountNumber, licensedAddonName, expiryDate)

        Dim dsa As DSA = DSA.Create
        Dim privateKey As String = File.ReadAllText("id_dsa.xml")
        dsa.FromXmlString(privateKey)

        Using stream As New MemoryStream
            For Each chunk As Byte() In hash.ChunksOf(20)
                stream.Write(dsa.CreateSignature(chunk), 0, 40)
            Next

            Return Convert.ToBase64String(stream.ToArray)
        End Using
    End Function

    <Extension()>
    Public Sub Sign(subscription As EurekaSubscription)
        Dim sageAccounts As New EurekaCustomerSageAccounts()
        sageAccounts.Query.Filters.Add(New Sage.ObjectStore.Filter(EurekaCustomerSageAccount.FIELD_SLCUSTOMERACCOUNT, FilterOperator.Equal, subscription.Customer.SLCustomerAccount))

        If sageAccounts.Count = 1 Then
            subscription.LicenseKey = ComputeLicenseKey(sageAccounts.First.SageAccountNumber, subscription.EurekaCommonAddon.Name, subscription.ExpiryDate)
            Debug.WriteLine(subscription.LicenseKey)
        Else
            Throw New Exception("Unable to sign license")
        End If
    End Sub

    <Extension()>
    Public Sub SignAndUpdate(subscription As EurekaSubscription)
        subscription.Sign()
        subscription.Update()
    End Sub
End Module
