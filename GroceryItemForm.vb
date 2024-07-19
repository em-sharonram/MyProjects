Imports System.Drawing.Text
Imports System.IO
Imports System.Text

Public Class lblScanNumber
    Private txtPrice As TextBox

    'List of grocery items in a basket
    Private basket As New List(Of GroceryItem)

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
        ' Create an instance of BasketDisplayForm
        Dim basketForm As New BasketDisplayForm()

        ' Display the BasketDisplayForm modally
        basketForm.ShowDialog()

    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        'Configure the SaveFileDialog
        SaveFileDialog1.Filter = "CSV files (*.csv) |*.csv|All files (*.*)|*.*"
        SaveFileDialog1.Title = "Save Basket"

        'Show the SaveFileDialog
        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
            'Obtain the file location
            Dim fileLocation As String = SaveFileDialog1.FileName

            Try
                'Create specified file location
                Using writer As New StreamWriter(fileLocation)
                    'Write the header line
                    writer.WriteLine("ScanNumber,BrandName,Price,Aisle,Description")

                    'Write items in the basket as CSV 
                    For Each item In basket
                        writer.WriteLine($"{item.ScanNumber},{item.BrandName},{item.Price},{item.Aisle},{item.Description}")
                    Next
                End Using

                'Display basket saved successful
                MessageBox.Show("Basket saved successfully.", "Save Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)

                'Handle basket save error
            Catch ex As Exception
                MessageBox.Show("Error saving basket.", "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

    End Sub

    Private Sub LoadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoadToolStripMenuItem.Click
        'Configure the OpenFileDialog
        OpenFileDialog1.Filter = "CSV files (*.csv) |*.csv|All files (*.*)|*.*"
        OpenFileDialog1.Title = "Load Basket"

        'Show the OpenFileDialog
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            'Obtain the file location
            Dim fileLocation As String = OpenFileDialog1.FileName

            'Read the contents of the file
            Dim fileContents As String = File.ReadAllText(fileLocation)

            'Split the contents each line
            Dim lines() As String = fileContents.Split(New String() {Environment.NewLine}, StringSplitOptions.None)

            'Clear existing items on the basket
            basket.Clear()

            'Display basket loaded successful
            MessageBox.Show("Basket loaded successfully.", "Load Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

End Class