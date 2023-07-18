<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        MenuStrip1 = New MenuStrip()
        FileToolStripMenuItem = New ToolStripMenuItem()
        ExitToolStripMenuItem = New ToolStripMenuItem()
        InventoryToolStripMenuItem = New ToolStripMenuItem()
        AddToItemListingToolStripMenuItem = New ToolStripMenuItem()
        ClearItemListingToolStripMenuItem = New ToolStripMenuItem()
        CountItemListingToolStripMenuItem = New ToolStripMenuItem()
        AddItemToComboBoxToolStripMenuItem = New ToolStripMenuItem()
        DeleteComboBoxItemToolStripMenuItem = New ToolStripMenuItem()
        ColorsAndFontsToolStripMenuItem = New ToolStripMenuItem()
        SetBackgroundColorToolStripMenuItem = New ToolStripMenuItem()
        SetFontToolStripMenuItem = New ToolStripMenuItem()
        HelpToolStripMenuItem = New ToolStripMenuItem()
        AboutToolStripMenuItem = New ToolStripMenuItem()
        GroupBox1 = New GroupBox()
        QuantityOfItemTextBox = New TextBox()
        WholesaleCostTextBox = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        SelectItemMenu = New ComboBox()
        Label1 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        TotalInventoryValueTextBox = New TextBox()
        InventoryItemListingTextBox = New TextBox()
        MenuStrip1.SuspendLayout()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.BackColor = SystemColors.Menu
        MenuStrip1.Items.AddRange(New ToolStripItem() {FileToolStripMenuItem, InventoryToolStripMenuItem, ColorsAndFontsToolStripMenuItem, HelpToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(528, 24)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' FileToolStripMenuItem
        ' 
        FileToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ExitToolStripMenuItem})
        FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        FileToolStripMenuItem.Size = New Size(37, 20)
        FileToolStripMenuItem.Text = "&File"
        ' 
        ' ExitToolStripMenuItem
        ' 
        ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        ExitToolStripMenuItem.Size = New Size(180, 22)
        ExitToolStripMenuItem.Text = "&Exit"
        ' 
        ' InventoryToolStripMenuItem
        ' 
        InventoryToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {AddToItemListingToolStripMenuItem, ClearItemListingToolStripMenuItem, CountItemListingToolStripMenuItem, AddItemToComboBoxToolStripMenuItem, DeleteComboBoxItemToolStripMenuItem})
        InventoryToolStripMenuItem.Name = "InventoryToolStripMenuItem"
        InventoryToolStripMenuItem.Size = New Size(69, 20)
        InventoryToolStripMenuItem.Text = "&Inventory"
        ' 
        ' AddToItemListingToolStripMenuItem
        ' 
        AddToItemListingToolStripMenuItem.Name = "AddToItemListingToolStripMenuItem"
        AddToItemListingToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.A
        AddToItemListingToolStripMenuItem.Size = New Size(252, 22)
        AddToItemListingToolStripMenuItem.Text = "&Add to Item Listing   "
        ' 
        ' ClearItemListingToolStripMenuItem
        ' 
        ClearItemListingToolStripMenuItem.Name = "ClearItemListingToolStripMenuItem"
        ClearItemListingToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.C
        ClearItemListingToolStripMenuItem.Size = New Size(252, 22)
        ClearItemListingToolStripMenuItem.Text = "&Clear Item Listing    "
        ' 
        ' CountItemListingToolStripMenuItem
        ' 
        CountItemListingToolStripMenuItem.Name = "CountItemListingToolStripMenuItem"
        CountItemListingToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.O
        CountItemListingToolStripMenuItem.Size = New Size(252, 22)
        CountItemListingToolStripMenuItem.Text = "&Count Item Listing    "
        ' 
        ' AddItemToComboBoxToolStripMenuItem
        ' 
        AddItemToComboBoxToolStripMenuItem.Name = "AddItemToComboBoxToolStripMenuItem"
        AddItemToComboBoxToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.M
        AddItemToComboBoxToolStripMenuItem.Size = New Size(252, 22)
        AddItemToComboBoxToolStripMenuItem.Text = "&Add Item To Combo Box "
        ' 
        ' DeleteComboBoxItemToolStripMenuItem
        ' 
        DeleteComboBoxItemToolStripMenuItem.Name = "DeleteComboBoxItemToolStripMenuItem"
        DeleteComboBoxItemToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.D
        DeleteComboBoxItemToolStripMenuItem.Size = New Size(252, 22)
        DeleteComboBoxItemToolStripMenuItem.Text = "&Delete Combo Box Item "
        ' 
        ' ColorsAndFontsToolStripMenuItem
        ' 
        ColorsAndFontsToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {SetBackgroundColorToolStripMenuItem, SetFontToolStripMenuItem})
        ColorsAndFontsToolStripMenuItem.Name = "ColorsAndFontsToolStripMenuItem"
        ColorsAndFontsToolStripMenuItem.Size = New Size(108, 20)
        ColorsAndFontsToolStripMenuItem.Text = "&Colors and Fonts"
        ' 
        ' SetBackgroundColorToolStripMenuItem
        ' 
        SetBackgroundColorToolStripMenuItem.Name = "SetBackgroundColorToolStripMenuItem"
        SetBackgroundColorToolStripMenuItem.Size = New Size(192, 22)
        SetBackgroundColorToolStripMenuItem.Text = "Set &Background Color "
        ' 
        ' SetFontToolStripMenuItem
        ' 
        SetFontToolStripMenuItem.Name = "SetFontToolStripMenuItem"
        SetFontToolStripMenuItem.Size = New Size(192, 22)
        SetFontToolStripMenuItem.Text = "Set &Font"
        ' 
        ' HelpToolStripMenuItem
        ' 
        HelpToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {AboutToolStripMenuItem})
        HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        HelpToolStripMenuItem.Size = New Size(44, 20)
        HelpToolStripMenuItem.Text = "&Help"
        ' 
        ' AboutToolStripMenuItem
        ' 
        AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        AboutToolStripMenuItem.Size = New Size(107, 22)
        AboutToolStripMenuItem.Text = "&About"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(QuantityOfItemTextBox)
        GroupBox1.Controls.Add(WholesaleCostTextBox)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(SelectItemMenu)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Location = New Point(12, 27)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(500, 143)
        GroupBox1.TabIndex = 1
        GroupBox1.TabStop = False
        GroupBox1.Text = "Inventory Data"
        ' 
        ' QuantityOfItemTextBox
        ' 
        QuantityOfItemTextBox.Location = New Point(134, 105)
        QuantityOfItemTextBox.Name = "QuantityOfItemTextBox"
        QuantityOfItemTextBox.Size = New Size(118, 23)
        QuantityOfItemTextBox.TabIndex = 5
        QuantityOfItemTextBox.TextAlign = HorizontalAlignment.Right
        ' 
        ' WholesaleCostTextBox
        ' 
        WholesaleCostTextBox.Location = New Point(134, 68)
        WholesaleCostTextBox.Name = "WholesaleCostTextBox"
        WholesaleCostTextBox.Size = New Size(118, 23)
        WholesaleCostTextBox.TabIndex = 4
        WholesaleCostTextBox.TextAlign = HorizontalAlignment.Right
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(22, 108)
        Label3.Name = "Label3"
        Label3.Size = New Size(97, 15)
        Label3.TabIndex = 3
        Label3.Text = "Quantity of Item:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(22, 71)
        Label2.Name = "Label2"
        Label2.Size = New Size(91, 15)
        Label2.TabIndex = 2
        Label2.Text = "Wholesale Cost:"
        ' 
        ' SelectItemMenu
        ' 
        SelectItemMenu.FormattingEnabled = True
        SelectItemMenu.Items.AddRange(New Object() {"TaylorMade R7 Driver RH 10-degree", "TaylorMade R7 Driver LH 10-degree", "TaylorMade R7 Driver RH 9-degree", "Titleist 907D2 Driver RH 9.5-degree", "Titleist 907D2 Driver RH 10.5-degree", "King Cobra HS9 X Driver RH 9-degree", "King Cobra HS9 X Driver LH 9-degree", "Adams Redline RPM Driver RH 10-degree"})
        SelectItemMenu.Location = New Point(106, 26)
        SelectItemMenu.Name = "SelectItemMenu"
        SelectItemMenu.Size = New Size(382, 23)
        SelectItemMenu.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(22, 29)
        Label1.Name = "Label1"
        Label1.Size = New Size(68, 15)
        Label1.TabIndex = 0
        Label1.Text = "Select Item:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(12, 184)
        Label4.Name = "Label4"
        Label4.Size = New Size(125, 15)
        Label4.TabIndex = 6
        Label4.Text = "Inventory Item Listing:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(269, 407)
        Label5.Name = "Label5"
        Label5.Size = New Size(119, 15)
        Label5.TabIndex = 7
        Label5.Text = "Total Inventory Value:"
        ' 
        ' TotalInventoryValueTextBox
        ' 
        TotalInventoryValueTextBox.Location = New Point(394, 404)
        TotalInventoryValueTextBox.Name = "TotalInventoryValueTextBox"
        TotalInventoryValueTextBox.ReadOnly = True
        TotalInventoryValueTextBox.Size = New Size(118, 23)
        TotalInventoryValueTextBox.TabIndex = 6
        TotalInventoryValueTextBox.TabStop = False
        TotalInventoryValueTextBox.TextAlign = HorizontalAlignment.Right
        ' 
        ' InventoryItemListingTextBox
        ' 
        InventoryItemListingTextBox.Location = New Point(12, 202)
        InventoryItemListingTextBox.Multiline = True
        InventoryItemListingTextBox.Name = "InventoryItemListingTextBox"
        InventoryItemListingTextBox.ReadOnly = True
        InventoryItemListingTextBox.Size = New Size(500, 196)
        InventoryItemListingTextBox.TabIndex = 8
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(528, 450)
        Controls.Add(InventoryItemListingTextBox)
        Controls.Add(TotalInventoryValueTextBox)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(GroupBox1)
        Controls.Add(MenuStrip1)
        Name = "Form1"
        Text = "Bock Golf - Inventory Application"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents SelectItemMenu As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents QuantityOfItemTextBox As TextBox
    Friend WithEvents WholesaleCostTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TotalInventoryValueTextBox As TextBox
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InventoryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddToItemListingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearItemListingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CountItemListingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddItemToComboBoxToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteComboBoxItemToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ColorsAndFontsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SetBackgroundColorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SetFontToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InventoryItemListingTextBox As TextBox
End Class
