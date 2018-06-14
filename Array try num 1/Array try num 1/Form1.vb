
Imports System.Drawing

Public Class Form1
    'Dim G As Graphics
    'Dim StrArray(2, 2) As String '3x3 2dimentional Array Grid "up to 18 mins"

    Dim MyArray(13) As String
    Dim IndexPos As Integer = 0
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'populate array
        MyArray(0) = "Welcome to My Visual Basic Semester Overview!"
        MyArray(1) = "We Have Learned So Programming Many Lessons this Semester!"
        MyArray(2) = "We  began with Visual Basic Controls and Events and Basic Walk Throughs!"
        MyArray(3) = "We then Began to Discus Numbers, Variables. "
        MyArray(4) = "Then We Discussed Input and OutPut. We Also walked through the widening and Norrowing Comments and Scope."
        MyArray(5) = "We also learned about the difference between Input Boxes, Message Boxes. "
        MyArray(6) = "Then We Learned About Decisions, relational and Logic Operators."
        MyArray(7) = "The Decision section Included, If Blocks, Select Case Blocks and Condition Statments."
        MyArray(8) = "We also Began to use Listboxes More, and Radio Buttons, as well as CheckBoxes."
        MyArray(9) = "Next we 'Mathed' it Up With Creating Functions, and implamenting them into Our Code."
        MyArray(10) = "Sub procedurs was Next on the list and We also Discussed the Scope and Lifetime of Variables."
        MyArray(11) = " Next we coverd Repetition, with Loops, Specifically Do Loops and Mostly For Next Loops."
        MyArray(12) = "We've Completed Projects Using Some or all of thes Programing Problems solving methods In Visual Basic, and this is all Do to Thes Class and Our Teacher. "
        MyArray(13) = "Thank You For Teaching Me and Us All, This Semester!!! Best Max."

        NextArrayItem(0)
    End Sub
    Private Sub NextArrayItem(Index As Integer)
        IndexPos += Index
        'Aviod going outside of the Array
        If IndexPos < 0 Then
            IndexPos = 13
        ElseIf IndexPos > 13 Then
            IndexPos = 0
        End If
        'Set index Label
        lblIndex.Text = "Index:" & IndexPos
        txtOutput.Text = MyArray(IndexPos)

    End Sub

    Private Sub btncmdPrevious_Click(sender As Object, e As EventArgs) Handles btncmdPrevious.Click
        NextArrayItem(-1)
    End Sub

    Private Sub btncmdNext_Click(sender As Object, e As EventArgs) Handles btncmdNext.Click
        NextArrayItem(+1)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show("You Are Now Done With The Array?")
        MessageBox.Show("Have a Nice Day.")
        Close()
    End Sub
End Class
