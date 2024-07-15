Public Class LoginForm
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblUsername.Click

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Try
            'User login
            Main.Login(txtUsername.Text, txtPassword.Text)

            'If login is successful, show a message and close
            If Main.blnLoggedIn Then
                MessageBox.Show("Thank you for logging in, " & txtUsername.Text, "Logged In.")
                Me.Close()
            End If

            ' Remove or comment out the below test code after testing
            'Create GroceryItem class to add into GroceryBasket for testing
            Dim item1 As New GroceryItem(12345, "Brand One", 4.55D) With
                {.Description = "Description for item 1", .Aisle = GroceryItem.AisleType.Drinks}
            Dim item2 As New GroceryItem(23456, "Brand Two", 8.99D) With
                {.Description = "Description for item 2", .Aisle = GroceryItem.AisleType.DryGoods}
            Dim item3 As New GroceryItem(45678, "Brand Three", 4.55D) With
                {.Description = "Description for item 1", .Aisle = GroceryItem.AisleType.FrozenFoods}
            Dim item4 As New GroceryItem(67891, "Brand Four", 2.99D) With
                {.Description = "Description for item 1", .Aisle = GroceryItem.AisleType.Produce}

            'Add objects to basket
            Dim basket As New GroceryBasket
            basket.Add(item1)
            basket.Add(item2)
            basket.Add(item3)
            basket.Add(item4)

            'Display items in the basket
            MessageBox.Show("Items in basket: " & basket.Count)

            'Handle incorrect password exception
        Catch ex As LoginException
            MessageBox.Show("Incorrect password.")
        End Try

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        'Close application 
        Application.Exit()
    End Sub

End Class
