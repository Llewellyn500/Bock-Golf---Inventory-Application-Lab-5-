Imports System.Numerics

Public Class Form1

    ' Declare variables
    Dim inventoryItem As New List(Of String)
    Dim totalInventoryValue As Decimal = 0

    ' Validation
    Private Function ValidData() As Boolean
        ' Validate if an item is selected in the comboBox
        If SelectItemMenu.SelectedIndex = -1 Then
            MessageBox.Show("Please select an inventory item from the list.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        ' Validate if wholesale cost is a numeric value greater than zero
        If Not Decimal.TryParse(WholesaleCostTextBox.Text, Nothing) OrElse
                Decimal.Parse(WholesaleCostTextBox.Text) <= 0 Then
            MessageBox.Show("Please enter a valid wholesale cost greater than zero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        ' Validating if quantity is a numeric value greater than zero
        If Not Integer.TryParse(QuantityOfItemTextBox.Text, Nothing) OrElse
                Integer.Parse(QuantityOfItemTextBox.Text) <= 0 Then
            MessageBox.Show("Please enter a valid quantity greater than zero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        Return True
    End Function

    ' Exit Menu Item
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    ' Add to Item Listing
    Private Sub AddToItemListingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddToItemListingToolStripMenuItem.Click
        If ValidData() Then
            Dim item As String = SelectItemMenu.SelectedItem.ToString()
            Dim wholesaleCost As Decimal = Decimal.Parse(WholesaleCostTextBox.Text)
            Dim quantity As Integer = Integer.Parse(QuantityOfItemTextBox.Text)
            Dim itemValue As Decimal = wholesaleCost * quantity

            ' Add item and item value to the listbox
            Dim itemString As String = $"{item} - Qty: {quantity} - {itemValue:C}"
            InventoryItemListingTextBox.AppendText(itemString & Environment.NewLine)

            ' Update total inventory value
            totalInventoryValue += itemValue
            TotalInventoryValueTextBox.Text = totalInventoryValue.ToString("C")

            ' Clear input controls
            SelectItemMenu.SelectedIndex = -1
            WholesaleCostTextBox.Clear()
            QuantityOfItemTextBox.Clear()

            ' Set focus to SelectItemMenu
            SelectItemMenu.Focus()
        End If
    End Sub

    ' Clear Item Listing
    Private Sub ClearItemListingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearItemListingToolStripMenuItem.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to clear the item listing?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)

        If result = DialogResult.Yes Then
            ' Cleaar ListBox and input controls
            InventoryItemListingTextBox.Clear()
            SelectItemMenu.SelectedIndex = -1
            WholesaleCostTextBox.Clear()
            QuantityOfItemTextBox.Clear()

            ' Reset total inventory value
            totalInventoryValue = 0
            TotalInventoryValueTextBox.Text = totalInventoryValue.ToString("C")

            ' Set focus to SelectItemMenu
            SelectItemMenu.Focus()
        End If
    End Sub

    ' Count Item Listing
    Private Sub CountItemListingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CountItemListingToolStripMenuItem.Click
        Dim count As Integer = SelectItemMenu.Items.Count
        MessageBox.Show($"Number of different inventory items: {count}", "Item Count", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        ' Display an About message box with the programmer's name
        MessageBox.Show("Llewellyn Paintsil" & Environment.NewLine & DateTime.Now, "About", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub AddItemToComboBoxToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddItemToComboBoxToolStripMenuItem.Click
        ' Get the new item entered by the user in the itemComboBox
        Dim newItem As String = SelectItemMenu.Text.Trim()

        ' Check if the new item is not blank
        If newItem <> "" Then
            ' Check if the new item is not a duplicate (case-insensitive)
            Dim isDuplicate As Boolean = SelectItemMenu.Items.Cast(Of Object)().Any(Function(item) item.ToString().Equals(newItem, StringComparison.OrdinalIgnoreCase))

            If Not isDuplicate Then
                ' Add the new item to the ComboBox and sort the items
                SelectItemMenu.Items.Add(newItem)
                SelectItemMenu.Sorted = True

                ' Display a success message
                MessageBox.Show("The new item has been added to the ComboBox.", "Item Added", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ' Clear the ComboBox text for the next input
                SelectItemMenu.Text = ""
            Else
                ' Display an error message for a duplicate item
                MessageBox.Show("The item already exists in the ComboBox. Please enter a unique item.", "Duplicate Item", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            ' Display an error message for a blank item
            MessageBox.Show("Please enter a valid item name to add to the ComboBox.", "Invalid Item", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub DeleteComboBoxItemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteComboBoxItemToolStripMenuItem.Click
        ' Check if an item is selected in the itemComboBox
        If SelectItemMenu.SelectedIndex <> -1 Then
            ' Get the selected item from the itemComboBox
            Dim selectedItem As String = SelectItemMenu.SelectedItem.ToString()

            ' Remove the selected item from the itemComboBox
            SelectItemMenu.Items.Remove(selectedItem)

            ' Clear the Text property of the itemComboBox control
            SelectItemMenu.Text = ""

            ' Display a success message
            MessageBox.Show("The selected item has been deleted from the ComboBox.", "Item Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            ' Display an error message if no item is selected in the itemComboBox
            MessageBox.Show("Please select an item to delete from the ComboBox.", "No Item Selected", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub SetBackgroundColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SetBackgroundColorToolStripMenuItem.Click
        ' Display a Color dialog box and change the form's ForeColor
        If ColorDialog1.ShowDialog() = DialogResult.OK Then
            Me.ForeColor = ColorDialog1.Color
        End If
    End Sub

    Private Sub SetFontToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SetFontToolStripMenuItem.Click
        If FontDialog1.ShowDialog() = DialogResult.OK Then
            FontToolStripMenuItem.Font = FontDialog1.Font
        End If
    End Sub

    Private Sub FontToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FontToolStripMenuItem.Click
        Call SetFontToolStripMenuItem_Click(sender, e)
    End Sub

    Private Sub ColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ColorToolStripMenuItem.Click
        Call SetBackgroundColorToolStripMenuItem_Click(sender, e)
    End Sub

    Private Sub ExitToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem1.Click
        Call ExitToolStripMenuItem_Click(sender, e)
    End Sub

    Private Sub Form1_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        If e.Button = MouseButtons.Right Then
            ContextMenuStrip1.Show(Me, e.Location)
        End If
    End Sub
End Class
