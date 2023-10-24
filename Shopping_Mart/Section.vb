Public Class Section
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Fashion_Section.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        grocerySection.Show()
        Fashion_Section.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        grocerySection.Hide()
        Fashion_Section.Hide()
        FruitsandVegetables.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        grocerySection.Hide()
        Fashion_Section.Hide()
        FruitsandVegetables.Hide()
        Utensils.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Hide()
        grocerySection.Hide()
        Fashion_Section.Hide()
        FruitsandVegetables.Hide()
        Utensils.Hide()
        BeautyProducts.Show()

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Hide()
        Billing.Show()

    End Sub


End Class