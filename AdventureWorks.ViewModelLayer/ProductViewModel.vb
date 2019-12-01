'don't forget to add a reference (right click reference > add reference) for the next lines to take effect
Imports System.Collections.ObjectModel
Imports AdventureWorks.DataLayer
Imports AdventureWorks.EntityLayer
Imports Common.Library

Public Class ProductViewModel
    Inherits ViewModelBase

    Sub New()
        LoadProducts()
    End Sub

    Public Property Products As ObservableCollection(Of Product) 'Use an ObservableCollection if the data can change. 
    'This collection raise an Event To inform any bound controls To re-read the data When it changes
    'If the data changes here then the WPF will automatically pick up that change and change the display accordingly
    Public Property Entity As Product

    'Function LoadProduct(ByVal productId As Integer) As Product
    '    Return LoadProduct(productId, Nothing)
    'End Function

    'Function LoadProduct(ByVal productId As Integer, ByVal startingFilePath As String) As Product
    '    ' Hard-code an entity
    '    Entity = New Product() With {
    '        .ProductID = 680,
    '        .Name = "HL Road Frame - Black, 58",
    '        .ProductNumber = "FR-R92B-58",
    '        .Colour = "Black",
    '        .Size = "58",
    '        .Weight = 1016.04D,
    '        .StandardCost = 1059.31D,
    '        .ListPrice = 1349.95D,
    '        .SellEndDate = .SellStartDate.AddDays(10)
    '    }
    '    Return Entity
    'End Function

    Function LoadProducts() As ObservableCollection(Of Product)
        Return LoadProducts(Nothing)
    End Function

    Function LoadProducts(ByVal startingFilePath As String) As ObservableCollection(Of Product)
        ' Create a new instance of the Product Manager Class
        Dim mgr = New ProductManager

        Products = mgr.LoadProducts(startingFilePath)

        Return Products
    End Function

End Class
