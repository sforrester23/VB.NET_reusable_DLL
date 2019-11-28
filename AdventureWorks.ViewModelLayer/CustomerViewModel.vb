Imports AdventureWorks.EntityLayer
Imports Common.Library
Public Class CustomerViewModel
    Inherits ViewModelBase
    Sub New()
        LoadCustomer(1)
    End Sub

    Public Property Entity As Customer

    Function LoadCustomer(ByVal customerId As Integer) As Customer
        ' Hard-code an entity
        Entity = New Customer() With {
            .CustomerID = 1,
            .FirstName = "Bruce",
            .LastName = "Jones",
            .CompanyName = "Beach Computer Company"}
        Return Entity
    End Function

End Class
