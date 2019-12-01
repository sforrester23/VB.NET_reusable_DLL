Public Class DataManagerBase
    Public Function LoadXElement(ByVal partialFileName As String) As XElement
        Return LoadXElement(partialFileName, Nothing)
    End Function

    Public Function LoadXElement(ByVal partialFileName As String,
                                 ByVal startingFileName As String) As XElement
        Dim path As String = IIf(String.IsNullOrEmpty(startingFileName), Environment.CurrentDirectory, startingFileName).ToString()
        Dim doc As XElement

        path &= partialFileName
        'remove the bin/debug bit because that's not part of the path that gets us to the XML folder
        path = path.Replace("bin\Debug\", "")

        'load the XML document that we now have the path for
        doc = XElement.Load(path)

        Return doc
    End Function
End Class
