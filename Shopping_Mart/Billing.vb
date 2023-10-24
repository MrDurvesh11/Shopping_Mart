Imports System.Data.SqlClient
Public Class Billing
    Dim conn As New SqlConnection("Data Source=LAPTOP-GPD3LBLA\SQLEXPRESS;Initial Catalog=ShopingMart;Integrated Security=True")

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Try
            conn.Open()
            Dim con As New SqlCommand("insert into Shop2 (Mobile_No,Password,Total_Amount,[Discount_7%],Discount_Price,[Total_GST_18%],[Total_Bill_With_GST_&_Discount]) 
            values ('" & Form1.TextBox1.Text & "', '" & Form1.TextBox2.Text & "','" & TextBox1.Text & "', '" & TextBox7.Text & "','" & TextBox8.Text & "','" & TextBox9.Text & "','" & TextBox10.Text & "')", conn)

            con.ExecuteNonQuery()

            conn.Close()

            MsgBox("Bill Paid Successfully", MsgBoxStyle.Exclamation, "***** Thank You ******")

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MsgBox("Log Out Successfully", MsgBoxStyle.Exclamation, "***** Please Visit Again ******")
        End
    End Sub





    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Label9.Text = Val(Fashion_Section.Label30.Text)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Label11.Text = Val(grocerySection.Label30.Text)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Label12.Text = Val(FruitsandVegetables.Label30.Text)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Label14.Text = Val(Utensils.Label30.Text)
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Label15.Text = Val(BeautyProducts.Label30.Text)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox1.Text = Val(Label9.Text) + Val(Label11.Text) + Val(Label12.Text) + Val(Label14.Text) + Val(Label15.Text)

        TextBox7.Text = (Val(TextBox1.Text) * 7) / 100

        TextBox8.Text = (Val(TextBox1.Text)) - Val(TextBox7.Text)

        TextBox9.Text = ((Val(TextBox8.Text)) * 18) / 100

        TextBox10.Text = (Val(TextBox8.Text)) + (Val(TextBox9.Text))

        Label8.Text = Val(TextBox7.Text)


    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Section.Show()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Me.Hide()
        Section.Show()

    End Sub

    Private Sub Billing_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form1.TextBox2.Text = "******"
    End Sub
End Class