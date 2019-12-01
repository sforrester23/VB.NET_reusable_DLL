Imports AdventureWorks.ViewModelLayer

Public Class CustomerDetailControl

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _viewModel = DirectCast(Me.Resources("viewModel"), CustomerViewModel)
    End Sub

    Private _viewModel As CustomerViewModel
    Private Sub UserControl_Loaded(sender As Object, e As RoutedEventArgs)
        _viewModel.LoadCustomer(4)
    End Sub
End Class
