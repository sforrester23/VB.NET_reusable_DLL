Imports System.Collections.ObjectModel
Imports AdventureWorks.DataLayer
Imports AdventureWorks.EntityLayer
Imports Common.Library
Public Class CustomerViewModel
    Inherits ViewModelBase
    Sub New()
        LoadCustomers()
    End Sub

    Public Property Customers As ObservableCollection(Of Customer)
    Public Property Entity As Customer

    'Function LoadCustomer(ByVal customerId As Integer) As Customer
    '    ' Hard-code an entity
    '    Entity = New Customer() With {
    '        .CustomerID = 1,
    '        .FirstName = "Bruce",
    '        .LastName = "Jones",
    '        .CompanyName = "Beach Computer Company"}
    '    Return Entity
    'End Function

    Function LoadCustomers() As ObservableCollection(Of Customer)
        Return LoadCustomers(Nothing)
    End Function

    Function LoadCustomers(ByVal startingFilePath As String) As ObservableCollection(Of Customer)
        ' Create a new instance of the customer manager class
        Dim mgr = New CustomerManager

        Customers = mgr.LoadCustomers(startingFilePath)

        Return Customers
    End Function

End Class
