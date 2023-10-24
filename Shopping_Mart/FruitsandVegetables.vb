Public Class FruitsandVegetables
    Dim a2, b2, c2, d2, f2, g2 As Double
    Dim a, b, c, d, f, g As Double

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Hide()
        Billing.Show()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        Section.Show()
    End Sub

    Dim fvtotal As Double

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        fvtotal = fvtotal + a2 + b2 + c2 + d2 + f2 + g2 + a + b + c + d + f + g
        Label30.Text = (fvtotal)
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        a2 = Val(TextBox7.Text) * 30
        Label22.Text = a2
        b2 = Val(TextBox8.Text) * 20
        Label23.Text = b2
        c2 = Val(TextBox9.Text) * 30
        Label24.Text = c2
        d2 = Val(TextBox10.Text) * 25
        Label25.Text = d2
        f2 = Val(TextBox11.Text) * 30
        Label26.Text = f2
        g2 = Val(TextBox12.Text) * 30
        Label27.Text = g2
    End Sub


    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        a = Val(TextBox1.Text) * 30
        Label16.Text = a
        b = Val(TextBox2.Text) * 120
        Label17.Text = b
        c = Val(TextBox3.Text) * 80
        Label18.Text = c
        d = Val(TextBox4.Text) * 200
        Label19.Text = d
        f = Val(TextBox5.Text) * 30
        Label20.Text = f
        g = Val(TextBox6.Text) * 60
        Label21.Text = g
    End Sub
End Class