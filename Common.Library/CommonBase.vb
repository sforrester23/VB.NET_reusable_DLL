Public Class CommonBase
    'Default Properties assignment
    Sub New()
        IsActive = True
        ModifiedDate = DateTime.Now
        CreatedBy = Environment.UserName 'We can use the environment class to query properties about your computer
    End Sub
    Public Property IsActive As Boolean
    Public Property ModifiedDate As DateTime
    Public Property CreatedBy As String

    'We can define the ToString method in the parent class so that all of the child classes inherite and have access to this method
    'It overrides the overridable function ToString() which is a method call for the Object Class that every single class in VB.NET inherits from
    Public Overrides Function ToString() As String
        Return GetClassData()
    End Function

    'Marking a method as overridable informs inheriting classes that they must use the keyword Overrides in order to implement this same method
    'Helps with reusability of the code
    'Functions are public by default. We also have private functions and ///protected/// functions
    'We can also use the keyword "protected" to define these
    'They mean that only a class in the inheritance chain can see this method
    Protected Overridable Function GetClassData() As String
        Dim sb As New Text.StringBuilder(1024)
        sb.AppendLine("Is Active: " + IsActive.ToString())
        sb.AppendLine("Modified Date: " + ModifiedDate.ToLongDateString())
        sb.AppendLine("Created By: " + CreatedBy)

        Return sb.ToString()
    End Function

End Class
