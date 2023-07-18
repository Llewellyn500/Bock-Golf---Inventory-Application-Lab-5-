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
End Class
