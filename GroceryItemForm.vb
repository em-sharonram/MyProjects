Imports System.Drawing.Text
Imports System.Text

Public Class lblScanNumber
    Private txtPrice As TextBox

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles grpDescription.Enter

    End Sub

    Private Sub lblScanNumber_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Display the login modally
        If LoginForm.ShowDialog() = DialogResult.OK Then
            'Exit application LoginForm
            Application.Exit()
        End If

    End Sub

    Private Sub btnAddToBasket_Click(sender As Object, e As EventArgs) Handles btnAddToBasket.Click
        'Create and verify all required fields are filled except txtScanNumber
        If txtBrandName.Text = String.Empty _
            OrElse txtPrice.Text = String.Empty _
            OrElse cboAisle.Text = String.Empty _
            OrElse txtDescription.Text = String.Empty Then
            MessageBox.Show("Please fill in all the fields except scan number.",
                            "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        'Set the value of the txtScanNumber control
        txtScanNumber.Text = txtBrandName.Text.Substring(0, 3) & "1019"

        'Instantiate the GroceryItem class using the control values
        'Use the expression to set the Aisle property
        Dim newItem As New GroceryItem(txtScanNumber.Text) With {
            .BrandName = txtBrandName.Text,
            .Price = Decimal.Parse(txtPrice.Text),
            .Aisle = [Enum].Parse(GetType(Aisle), cboAisle.Text),
            .Description = txtDescription.Text
        }

        'Add the GroceryItem object to the basket variable
        basket.Add(newItem)

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        'Close or end the application
        Me.Close()

    End Sub

    Private Sub AddToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddToolStripMenuItem.Click
        'Handle adding items to the basket
        'Example: Add item to the basket collection

    End Sub

    Private Sub ViewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewToolStripMenuItem.Click
        Dim message As New StringBuilder()

        'Collection of GroceryItem in the basket
        For Each item As GroceryItem In basket
            message.AppendLine("Aisle: " & item.Aisle & ", Scan Number: " & item.ScanNumber & ", Brand: " & item.BrandName)
        Next

        'Display all of the items in the basket
        MessageBox.Show(message.ToString(), "Items in Basket",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
    End Sub

End Class