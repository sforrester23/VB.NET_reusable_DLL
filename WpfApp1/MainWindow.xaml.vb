﻿Class MainWindow
    Private Sub Exit_Click(sender As Object, e As RoutedEventArgs)
        '"Me" refers to the current object, so tell it to close
        Me.Close()
    End Sub

    Private Sub ProductDetail_Click(sender As Object, e As RoutedEventArgs)
        contentArea.Children.Clear()
        contentArea.Children.Add(New ProductDetailControl())
    End Sub

    Private Sub CustomerDetail_Click(sender As Object, e As RoutedEventArgs)
        contentArea.Children.Clear()
        contentArea.Children.Add(New CustomerDetailControl())
    End Sub
End Class