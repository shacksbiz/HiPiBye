' The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

''' <summary>
''' An empty page that can be used on its own or navigated to within a Frame.
''' </summary>
Public NotInheritable Class MainPage
    Inherits Page

    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        'test
        txtbox1.text = "Hello Pi!" '
    End Sub

    Private Sub but_2_Click(sender As Object, e As RoutedEventArgs) Handles but_2.Click
        txtbox1.text = "GoodBye Pi!"
    End Sub
End Class
