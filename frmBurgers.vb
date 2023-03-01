'Program Name: Burger Selection
'

Public Class frmBurgers
    Private Sub lblInstructions_Click(sender As Object, e As EventArgs) Handles lblInstructions.Click

    End Sub

    Private Sub lblConfirmation_Click(sender As Object, e As EventArgs) Handles lblConfirmation.Click

    End Sub

    Private Sub btnPrime_Click(sender As Object, e As EventArgs) Handles btnPrime.Click
        'Renders the prime burger image 
        'Hides the veggie burger image
        'Enables the selection button
        picPrime.Visible = True
        picVeggie.Visible = False
        btnSelectMeal.Enabled = True
    End Sub

    Private Sub btnVeggie_Click(sender As Object, e As EventArgs) Handles btnVeggie.Click
        'Renders the veggie burger image 
        'Hides the prime burger image
        'Enables the selection button
        picPrime.Visible = False
        picVeggie.Visible = True
        btnSelectMeal.Enabled = True

    End Sub

    Private Sub btnSelectMeal_Click(sender As Object, e As EventArgs) Handles btnSelectMeal.Click
        'Selects the burger option
        'Enables exit button
        'Disables selection button, veggie button, prime button
        'Hides the instruction label
        'Shows the confirmation label
        lblConfirmation.Visible = True
        lblInstructions.Visible = False
        btnExit.Enabled = True
        btnPrime.Enabled = False
        btnSelectMeal.Enabled = False
        btnVeggie.Enabled = False

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Exits the program
        Close()

    End Sub
End Class
