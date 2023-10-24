Public Class Fashion_Section
    Dim s, s1, s2, s3, s4, s5, s6, s7, s8, s9, s10, s11, s12, s13 As Double


    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Hide()
        Billing.Show()
    End Sub

    Dim ftotal As Double
    Dim a As String

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim h = ComboBox7.SelectedIndex
        If h = 0 Then
            s8 = Val(TextBox7.Text) * 400
        ElseIf h = 1 Then
            s8 = Val(TextBox7.Text) * 450
        ElseIf h = 2 Then
            s8 = Val(TextBox7.Text) * 500
        ElseIf h = 3 Then
            s8 = Val(TextBox7.Text) * 550
        ElseIf h = 4 Then
            s8 = Val(TextBox7.Text) * 600
        End If
        Label22.Text = s8


        Dim i = ComboBox8.SelectedIndex
        If i = 0 Then
            s9 = Val(TextBox8.Text) * 400
        ElseIf i = 1 Then
            s9 = Val(TextBox8.Text) * 450
        ElseIf i = 2 Then
            s9 = Val(TextBox8.Text) * 500
        ElseIf i = 3 Then
            s9 = Val(TextBox8.Text) * 550
        ElseIf i = 4 Then
            s9 = Val(TextBox8.Text) * 600
        End If
        Label23.Text = s9

        Dim j = ComboBox9.SelectedIndex
        If j = 0 Then
            s10 = Val(TextBox9.Text) * 200
        ElseIf j = 1 Then
            s10 = Val(TextBox9.Text) * 250
        ElseIf j = 2 Then
            s10 = Val(TextBox9.Text) * 300
        ElseIf j = 3 Then
            s10 = Val(TextBox9.Text) * 350
        ElseIf j = 4 Then
            s10 = Val(TextBox9.Text) * 400
        End If
        Label24.Text = s10

        Dim k = ComboBox10.SelectedIndex
        If k = 0 Then
            s11 = Val(TextBox10.Text) * 10000
        ElseIf k = 1 Then
            s11 = Val(TextBox10.Text) * 20000
        ElseIf k = 2 Then
            s11 = Val(TextBox10.Text) * 5500
        ElseIf k = 3 Then
            s11 = Val(TextBox10.Text) * 8000
        ElseIf k = 4 Then
            s11 = Val(TextBox10.Text) * 9500
        End If
        Label25.Text = s11

        Dim l = ComboBox11.SelectedIndex
        If l = 0 Then
            s12 = Val(TextBox11.Text) * 900
        ElseIf l = 1 Then
            s12 = Val(TextBox11.Text) * 1000
        ElseIf l = 2 Then
            s12 = Val(TextBox11.Text) * 1200
        ElseIf l = 3 Then
            s12 = Val(TextBox11.Text) * 700
        ElseIf l = 4 Then
            s12 = Val(TextBox11.Text) * 750
        ElseIf l = 5 Then
            s12 = Val(TextBox11.Text) * 800
        ElseIf l = 6 Then
            s12 = Val(TextBox11.Text) * 300
        ElseIf l = 7 Then
            s12 = Val(TextBox11.Text) * 400
        ElseIf l = 8 Then
            s12 = Val(TextBox11.Text) * 500

        End If
        Label26.Text = s12

        Dim m = ComboBox12.SelectedIndex
        If m = 0 Then
            s13 = Val(TextBox12.Text) * 100
        ElseIf m = 1 Then
            s13 = Val(TextBox12.Text) * 110
        ElseIf m = 2 Then
            s13 = Val(TextBox12.Text) * 120
        ElseIf m = 3 Then
            s13 = Val(TextBox12.Text) * 125
        ElseIf m = 4 Then
            s13 = Val(TextBox12.Text) * 130
        ElseIf m = 5 Then
            s13 = Val(TextBox12.Text) * 100
        ElseIf m = 6 Then
            s13 = Val(TextBox12.Text) * 110
        ElseIf m = 7 Then
            s13 = Val(TextBox12.Text) * 120
        ElseIf m = 8 Then
            s13 = Val(TextBox12.Text) * 125
        ElseIf m = 9 Then
            s13 = Val(TextBox12.Text) * 130

        End If
        Label27.Text = s13
    End Sub

    Dim b As String


    Public Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        ftotal = ftotal + s + s1 + s2 + s3 + s4 + s5 + s8 + s9 + s10 + s11 + s12 + s13
        Label30.Text = ftotal
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim stotal As Double

        a = ComboBox1.SelectedIndex
        If a = 0 Then
            stotal = Val(TextBox1.Text) * 500
        ElseIf a = 1 Then
            stotal = Val(TextBox1.Text) * 550
        ElseIf a = 2 Then
            stotal = Val(TextBox1.Text) * 600
        ElseIf a = 3 Then
            stotal = Val(TextBox1.Text) * 750
        ElseIf a = 4 Then
            stotal = Val(TextBox1.Text) * 900
        End If

        s = stotal
        Label16.Text = s


        b = ComboBox2.SelectedIndex
        If b = 0 Then
            s1 = Val(TextBox2.Text) * 600
        ElseIf b = 1 Then
            s1 = Val(TextBox2.Text) * 650
        ElseIf b = 2 Then
            s1 = Val(TextBox2.Text) * 750
        ElseIf b = 3 Then
            s1 = Val(TextBox2.Text) * 850
        ElseIf b = 4 Then
            s1 = Val(TextBox2.Text) * 1000
        End If
        Label17.Text = s1

        Dim c = ComboBox3.SelectedIndex
        If c = 0 Then
            s2 = Val(TextBox3.Text) * 200
        ElseIf c = 1 Then
            s2 = Val(TextBox3.Text) * 250
        ElseIf c = 2 Then
            s2 = Val(TextBox3.Text) * 300
        ElseIf c = 3 Then
            s2 = Val(TextBox3.Text) * 350
        ElseIf c = 4 Then
            s2 = Val(TextBox3.Text) * 400
        End If
        Label18.Text = s2

        Dim d = ComboBox4.SelectedIndex
        If d = 0 Then
            s3 = Val(TextBox4.Text) * 10000
        ElseIf d = 1 Then
            s3 = Val(TextBox4.Text) * 20000
        ElseIf d = 2 Then
            s3 = Val(TextBox4.Text) * 5000
        ElseIf d = 3 Then
            s3 = Val(TextBox4.Text) * 8000
        ElseIf d = 4 Then
            s3 = Val(TextBox4.Text) * 9000
        End If
        Label19.Text = s3

        Dim f = ComboBox5.SelectedIndex
        If f = 0 Then
            s4 = Val(TextBox5.Text) * 900
        ElseIf f = 1 Then
            s4 = Val(TextBox5.Text) * 1000
        ElseIf f = 2 Then
            s4 = Val(TextBox5.Text) * 1200
        ElseIf f = 3 Then
            s4 = Val(TextBox5.Text) * 700
        ElseIf f = 4 Then
            s4 = Val(TextBox5.Text) * 750
        ElseIf f = 5 Then
            s4 = Val(TextBox5.Text) * 800
        ElseIf f = 6 Then
            s4 = Val(TextBox5.Text) * 300
        ElseIf f = 7 Then
            s4 = Val(TextBox5.Text) * 400
        ElseIf f = 8 Then
            s4 = Val(TextBox5.Text) * 500

        End If
        Label20.Text = s4

        Dim g = ComboBox6.SelectedIndex
        If g = 0 Then
            s5 = Val(TextBox6.Text) * 100
        ElseIf g = 1 Then
            s5 = Val(TextBox6.Text) * 110
        ElseIf g = 2 Then
            s5 = Val(TextBox6.Text) * 120
        ElseIf g = 3 Then
            s5 = Val(TextBox6.Text) * 125
        ElseIf g = 4 Then
            s5 = Val(TextBox6.Text) * 130
        ElseIf g = 5 Then
            s5 = Val(TextBox6.Text) * 100
        ElseIf g = 6 Then
            s5 = Val(TextBox6.Text) * 110
        ElseIf g = 7 Then
            s5 = Val(TextBox6.Text) * 120
        ElseIf g = 8 Then
            s5 = Val(TextBox6.Text) * 125
        ElseIf g = 9 Then
            s5 = Val(TextBox6.Text) * 130

        End If
        Label21.Text = s5

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        Section.Show()
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged

    End Sub
End Class