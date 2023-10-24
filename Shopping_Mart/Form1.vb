Imports System.ComponentModel
Imports System.Text.RegularExpressions


Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Section.Show()
        MsgBox("Login SuccessFully.....:)", MsgBoxStyle.Information, "Login ")
    End Sub

    Private Sub TextBox2_Validating(sender As Object, e As CancelEventArgs) Handles TextBox2.Validating
        If TextBox2.Text = " " Then
            ErrorProvider1.SetError(TextBox2, "Please Enter A Password")
            e.Cancel = True
        ElseIf (Len(TextBox2.Text) < 6) Then
            ErrorProvider1.SetError(TextBox2, "Enter A Strong Password more than 6 Character")
            e.Cancel = True
        End If
    End Sub


    Private Sub TextBox1_Validating(sender As Object, e As CancelEventArgs) Handles TextBox1.Validating
        Dim Expression As New Regex("\b/d{10}$")
        If TextBox1.Text = " " Then
            ErrorProvider2.SetError(TextBox2, "Cannot Be Empty")
            e.Cancel = True
        ElseIf TextBox1.TextLength < 10 Then
            ErrorProvider2.SetError(TextBox2, "Not a Valid Number")
            e.Cancel = True
        ElseIf TextBox1.TextLength > 10 Then
            ErrorProvider2.SetError(TextBox2, "Not a Valid Number")
            e.Cancel = True
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox2.UseSystemPasswordChar = True
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

        If CheckBox1.CheckState = CheckState.Checked Then
            TextBox2.UseSystemPasswordChar = False
        Else
            TextBox2.UseSystemPasswordChar = True
        End If

    End Sub
End Class

