﻿Imports System.Collections.ObjectModel
Imports System.Configuration
Imports AdventureWorks.EntityLayer
Imports Common.Library

Public Class CustomerManager
    Inherits DataManagerBase

    Function LoadCustomers() As ObservableCollection(Of Customer)
        Return LoadCustomers(Nothing)
    End Function

    Function LoadCustomers(ByVal startingFilePath As String) As ObservableCollection(Of Customer)
        ' Create a new instance of products
        Dim ret = New ObservableCollection(Of Customer)()

        Try
            'Attempt to read from XML File
            Dim doc = MyBase.LoadXElement(
                ConfigurationManager.AppSettings("CustomersFile"),
                startingFilePath)

            Dim customers = From cust In doc.<Customer>
                            Select New Customer With {
                                .CustomerID = Convert.ToInt32(cust.Element("CustomerID").Value),
                                .CompanyName = cust.Element("CompanyName").Value,
                                .FirstName = cust.Element("FirstName").Value,
                                .LastName = cust.Element("LastName").Value
                            }

            ret = New ObservableCollection(Of Customer)(customers.ToList())
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine(ex.ToString())

        End Try

        Return ret
    End Function

    Function LoadCustomeR(ByVal customerId As Integer) As Customer
        Return LoadCustomeR(customerId, Nothing)
    End Function

    Function LoadCustomer(ByVal customerId As Integer, ByVal startingFilePath As String) As Customer
        'Create a new instance of a customer
        Dim ret = New Customer()

        Try
            Dim list = LoadCustomers(startingFilePath)

            If list IsNot Nothing Then
                If list.Count > 0 Then
                    ret = list.FirstOrDefault(Function(p) p.CustomerID = customerId)
                End If
            End If

        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine(ex.ToString())

        End Try

        Return ret
    End Function
End Class
