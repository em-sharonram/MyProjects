<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class lblScanNumber
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblBrandName = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lblAisle = New System.Windows.Forms.Label()
        Me.btnAddToBasket = New System.Windows.Forms.Button()
        Me.cboAisle = New System.Windows.Forms.ComboBox()
        Me.numPrice = New System.Windows.Forms.NumericUpDown()
        Me.txtScanNumber = New System.Windows.Forms.TextBox()
        Me.txtBrandName = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.grpDescription = New System.Windows.Forms.GroupBox()
        Me.txtDescription = New System.Windows.Forms.RichTextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ApplicationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BasketToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.numPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDescription.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(35, 46)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Scan:"
        '
        'lblBrandName
        '
        Me.lblBrandName.AutoSize = True
        Me.lblBrandName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBrandName.Location = New System.Drawing.Point(35, 86)
        Me.lblBrandName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblBrandName.Name = "lblBrandName"
        Me.lblBrandName.Size = New System.Drawing.Size(38, 13)
        Me.lblBrandName.TabIndex = 1
        Me.lblBrandName.Text = "&Name:"
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrice.Location = New System.Drawing.Point(35, 123)
        Me.lblPrice.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(34, 13)
        Me.lblPrice.TabIndex = 2
        Me.lblPrice.Text = "&Price:"
        '
        'lblAisle
        '
        Me.lblAisle.AutoSize = True
        Me.lblAisle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAisle.Location = New System.Drawing.Point(35, 158)
        Me.lblAisle.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblAisle.Name = "lblAisle"
        Me.lblAisle.Size = New System.Drawing.Size(32, 13)
        Me.lblAisle.TabIndex = 3
        Me.lblAisle.Text = "A&isle:"
        '
        'btnAddToBasket
        '
        Me.btnAddToBasket.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddToBasket.Location = New System.Drawing.Point(38, 331)
        Me.btnAddToBasket.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAddToBasket.Name = "btnAddToBasket"
        Me.btnAddToBasket.Size = New System.Drawing.Size(376, 24)
        Me.btnAddToBasket.TabIndex = 4
        Me.btnAddToBasket.Text = "A&dd to Basket"
        Me.btnAddToBasket.UseVisualStyleBackColor = True
        '
        'cboAisle
        '
        Me.cboAisle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAisle.FormattingEnabled = True
        Me.cboAisle.Items.AddRange(New Object() {"Bakery", "CannedGoods", "Drinks", "Deli", "DryGoods", "FrozenFoods", "Produce"})
        Me.cboAisle.Location = New System.Drawing.Point(94, 150)
        Me.cboAisle.Margin = New System.Windows.Forms.Padding(2)
        Me.cboAisle.Name = "cboAisle"
        Me.cboAisle.Size = New System.Drawing.Size(318, 21)
        Me.cboAisle.TabIndex = 2
        '
        'numPrice
        '
        Me.numPrice.DecimalPlaces = 2
        Me.numPrice.Location = New System.Drawing.Point(94, 116)
        Me.numPrice.Margin = New System.Windows.Forms.Padding(2)
        Me.numPrice.Name = "numPrice"
        Me.numPrice.Size = New System.Drawing.Size(318, 20)
        Me.numPrice.TabIndex = 1
        '
        'txtScanNumber
        '
        Me.txtScanNumber.Location = New System.Drawing.Point(94, 39)
        Me.txtScanNumber.Margin = New System.Windows.Forms.Padding(2)
        Me.txtScanNumber.Name = "txtScanNumber"
        Me.txtScanNumber.ReadOnly = True
        Me.txtScanNumber.Size = New System.Drawing.Size(318, 20)
        Me.txtScanNumber.TabIndex = 12
        Me.txtScanNumber.TabStop = False
        '
        'txtBrandName
        '
        Me.txtBrandName.Location = New System.Drawing.Point(94, 79)
        Me.txtBrandName.Margin = New System.Windows.Forms.Padding(2)
        Me.txtBrandName.Name = "txtBrandName"
        Me.txtBrandName.Size = New System.Drawing.Size(320, 20)
        Me.txtBrandName.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(128, 205)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(6, 6)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'grpDescription
        '
        Me.grpDescription.Controls.Add(Me.txtDescription)
        Me.grpDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpDescription.Location = New System.Drawing.Point(38, 188)
        Me.grpDescription.Margin = New System.Windows.Forms.Padding(2)
        Me.grpDescription.Name = "grpDescription"
        Me.grpDescription.Padding = New System.Windows.Forms.Padding(2)
        Me.grpDescription.Size = New System.Drawing.Size(374, 139)
        Me.grpDescription.TabIndex = 16
        Me.grpDescription.TabStop = False
        Me.grpDescription.Text = "&Description"
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(0, 14)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(376, 120)
        Me.txtDescription.TabIndex = 3
        Me.txtDescription.Text = ""
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ApplicationToolStripMenuItem, Me.BasketToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(477, 24)
        Me.MenuStrip1.TabIndex = 17
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ApplicationToolStripMenuItem
        '
        Me.ApplicationToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.ApplicationToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ApplicationToolStripMenuItem.Name = "ApplicationToolStripMenuItem"
        Me.ApplicationToolStripMenuItem.Size = New System.Drawing.Size(79, 20)
        Me.ApplicationToolStripMenuItem.Text = "Application"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'BasketToolStripMenuItem
        '
        Me.BasketToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddToolStripMenuItem, Me.ViewToolStripMenuItem})
        Me.BasketToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BasketToolStripMenuItem.Name = "BasketToolStripMenuItem"
        Me.BasketToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.BasketToolStripMenuItem.Text = "Basket"
        '
        'AddToolStripMenuItem
        '
        Me.AddToolStripMenuItem.Name = "AddToolStripMenuItem"
        Me.AddToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AddToolStripMenuItem.Text = "A&dd"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ViewToolStripMenuItem.Text = "&View"
        '
        'lblScanNumber
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(477, 381)
        Me.Controls.Add(Me.grpDescription)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtBrandName)
        Me.Controls.Add(Me.txtScanNumber)
        Me.Controls.Add(Me.numPrice)
        Me.Controls.Add(Me.cboAisle)
        Me.Controls.Add(Me.btnAddToBasket)
        Me.Controls.Add(Me.lblAisle)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.lblBrandName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "lblScanNumber"
        Me.Text = "Grocery Item"
        CType(Me.numPrice, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDescription.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblBrandName As Label
    Friend WithEvents lblPrice As Label
    Friend WithEvents lblAisle As Label
    Friend WithEvents btnAddToBasket As Button
    Friend WithEvents cboAisle As ComboBox
    Friend WithEvents numPrice As NumericUpDown
    Friend WithEvents txtScanNumber As TextBox
    Friend WithEvents txtBrandName As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents grpDescription As GroupBox
    Friend WithEvents txtDescription As RichTextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ApplicationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BasketToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As ToolStripMenuItem
End Class
