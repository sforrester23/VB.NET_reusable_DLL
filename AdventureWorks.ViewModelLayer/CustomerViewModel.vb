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

    'THIS IS AN OLDER VERSION OF A FUNCTION WE USED IN THE COURSE, IT HAS BEEN UPDATED TO SOMETHING WITH DIFFERENT FUNCTIONALITY BUT THE SAME NAME FOR A LATER COURSE ACTIVITY
    'Function LoadCustomer(ByVal customerId As Integer) As Customer
    '    ' Hard-code an entity
    '    Entity = New Customer() With {
    '        .CustomerID = 1,
    '        .FirstName = "Bruce",
    '        .LastName = "Jones",
    '        .CompanyName = "Beach Computer Company"}
    '    Return Entity
    'End Function

    Function LoadCustomer(ByVal customerId As Integer) As Customer
        Return LoadCustomer(customerId, Nothing)
    End Function

    Function LoadCustomer(ByVal customerId As Integer, ByVal startingFilePath As String) As Customer
        'Create a new instance of customer manager class
        Dim mgr = New CustomerManager

        Entity = mgr.LoadCustomer(customerId, startingFilePath)

        'inform the UI that the entity property has changed
        RaisePropertyChanged("Entity")

        Return Entity

    End Function

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
