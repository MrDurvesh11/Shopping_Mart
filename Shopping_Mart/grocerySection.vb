Public Class grocerySection
    Dim g1, g2, g3, g4, g5, g6, g7, g8, g9, g10, g11, g12 As Double

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Hide()
        Billing.Show()

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Dim gtotal As Double
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        gtotal = gtotal + g1 + g2 + g3 + g4 + g5 + g6 + g7 + g8 + g9 + g10 + g11 + g12
        Label30.Text = gtotal
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim h = ComboBox7.SelectedIndex
        If h = 0 Then
            g7 = Val(TextBox7.Text) * 100
        ElseIf a = 1 Then
            g7 = Val(TextBox7.Text) * 110
        ElseIf a = 2 Then
            g7 = Val(TextBox7.Text) * 95
        ElseIf a = 3 Then
            g7 = Val(TextBox7.Text) * 100
        ElseIf a = 4 Then
            g7 = Val(TextBox7.Text) * 105
        End If
        Label22.Text = g7


        Dim i = ComboBox8.SelectedIndex
        If i = 0 Then
            g8 = Val(TextBox8.Text) * 400
        ElseIf i = 1 Then
            g8 = Val(TextBox8.Text) * 700
        ElseIf i = 2 Then
            g8 = Val(TextBox8.Text) * 450
        ElseIf i = 3 Then
            g8 = Val(TextBox8.Text) * 500
        ElseIf i = 4 Then
            g8 = Val(TextBox8.Text) * 550
        End If
        Label23.Text = g8

        Dim j = ComboBox9.SelectedIndex
        If j = 0 Then
            g9 = Val(TextBox9.Text) * 80
        ElseIf j = 1 Then
            g9 = Val(TextBox9.Text) * 50
        ElseIf j = 2 Then
            g9 = Val(TextBox9.Text) * 40
        ElseIf j = 3 Then
            g9 = Val(TextBox9.Text) * 30
        ElseIf j = 4 Then
            g9 = Val(TextBox9.Text) * 70
        End If
        Label24.Text = g9

        Dim k = ComboBox12.SelectedIndex
        If k = 0 Then
            g10 = Val(TextBox10.Text) * 60
        ElseIf k = 1 Then
            g10 = Val(TextBox10.Text) * 59
        ElseIf k = 2 Then
            g10 = Val(TextBox10.Text) * 63
        ElseIf k = 3 Then
            g10 = Val(TextBox10.Text) * 64
        End If
        Label25.Text = g10

        Dim l = ComboBox10.SelectedIndex
        If l = 0 Then
            g11 = Val(TextBox11.Text) * 60
        ElseIf l = 1 Then
            g11 = Val(TextBox11.Text) * 55
        ElseIf l = 2 Then
            g11 = Val(TextBox11.Text) * 50

        End If
        Label26.Text = g11

        Dim m = ComboBox11.SelectedIndex
        If m = 0 Then
            g12 = Val(TextBox12.Text) * 50
        ElseIf m = 1 Then
            g12 = Val(TextBox12.Text) * 45
        ElseIf m = 2 Then
            g12 = Val(TextBox12.Text) * 40
        End If
        Label27.Text = g12
    End Sub


    Dim a As String
    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        Section.Show()
    End Sub

    Public Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        a = ComboBox1.SelectedIndex
        If a = 0 Then
            g1 = Val(TextBox1.Text) * 70
        ElseIf a = 1 Then
            g1 = Val(TextBox1.Text) * 60
        ElseIf a = 2 Then
            g1 = Val(TextBox1.Text) * 50
        End If


        Label16.Text = g1


        Dim b = ComboBox2.SelectedIndex
        If b = 0 Then
            g2 = Val(TextBox2.Text) * 90
        ElseIf b = 1 Then
            g2 = Val(TextBox2.Text) * 70
        ElseIf b = 2 Then
            g2 = Val(TextBox2.Text) * 50

        End If
        Label17.Text = g2

        Dim c = ComboBox3.SelectedIndex
        If c = 0 Then
            g3 = Val(TextBox3.Text) * 120
        ElseIf c = 1 Then
            g3 = Val(TextBox3.Text) * 110
        ElseIf c = 2 Then
            g3 = Val(TextBox3.Text) * 100

        End If
        Label18.Text = g3

        Dim d = ComboBox4.SelectedIndex
        If d = 0 Then
            g4 = Val(TextBox4.Text) * 210
        ElseIf d = 1 Then
            g4 = Val(TextBox4.Text) * 200
        ElseIf d = 2 Then
            g4 = Val(TextBox4.Text) * 205
        End If
        Label19.Text = g4

        Dim f = ComboBox5.SelectedIndex
        If f = 0 Then
            g5 = Val(TextBox5.Text) * 170
        ElseIf f = 1 Then
            g5 = Val(TextBox5.Text) * 180
        ElseIf f = 2 Then
            g5 = Val(TextBox5.Text) * 185

        End If
        Label20.Text = g5

        Dim g = ComboBox6.SelectedIndex
        If g = 0 Then
            g6 = Val(TextBox6.Text) * 108
        ElseIf g = 1 Then
            g6 = Val(TextBox6.Text) * 69
        ElseIf g = 2 Then
            g6 = Val(TextBox6.Text) * 140
        ElseIf g = 3 Then
            g6 = Val(TextBox6.Text) * 115

        End If
        Label21.Text = g6
    End Sub
End Class