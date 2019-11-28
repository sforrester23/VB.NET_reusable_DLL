'don't forget to add a reference (right click reference > add reference) for the next lines to take effect
Imports AdventureWorks.EntityLayer
Imports Common.Library

Public Class ProductViewModel
    Inherits ViewModelBase

    Sub New()
        LoadProduct(680)
    End Sub

    Public Property Entity As Product

    Function LoadProduct(ByVal productId As Integer) As Product
        Return LoadProduct(productId, Nothing)
    End Function

    Function LoadProduct(ByVal productId As Integer, ByVal startingFilePath As String) As Product
        ' Hard-code an entity
        Entity = New Product() With {
            .ProductID = 680,
            .Name = "HL Road Frame - Black, 58",
            .ProductNumber = "FR-R92B-58",
            .Colour = "Black",
            .Size = "58",
            .Weight = 1016.04D,
            .StandardCost = 1059.31D,
            .ListPrice = 1349.95D,
            .SellEndDate = .SellStartDate.AddDays(10)
        }
        Return Entity
    End Function

End Class
