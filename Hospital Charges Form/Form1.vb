Public Class Form1
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Close Form
        Me.Close()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Clear all input fields
        txtDays.Clear()
        txtMedication.Clear()
        txtLabFees.Clear()
        txtRehab.Clear()
        txtSurgicalCharges.Clear()
        lblTotal.Text = String.Empty
        txtDays.Focus()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        If ValidateInputFields() Then

            Dim intNumDays As Integer = CInt(txtDays.Text)
            Dim decMeds As Decimal = CDec(txtMedication.Text)
            Dim decLabFees As Decimal = CDec(txtLabFees.Text)
            Dim decSurgery As Decimal = CDec(txtSurgicalCharges.Text)
            Dim decRehab As Decimal = CDec(txtRehab.Text)
            Dim decTotal As Decimal

            decTotal = (intNumDays * 350) + decMeds + decLabFees + decSurgery + decRehab

            Dim decDailyCost As Decimal

            Dim decLabFeeCost As Decimal = 0
            Dim RehabCost As Decimal = 0
            Dim decTotalCost As Decimal = 0
            Dim decMiscCosts As Decimal = 0

            decDailyCost = CalcStayCharges(intNumDays)

            decMiscCosts = CalcMiscCharges(decMeds, decLabFees, decSurgery, decRehab)

            decTotalCost = CalcTotalCharges(decDailyCost, decMiscCosts)

            lblTotal.Text = decTotalCost.ToString("c")

        End If
    End Sub
    Function CalcStayCharges(ByVal intNumDays As Integer) As Integer
        Return intNumDays * 350

    End Function

    Function CalcMiscCharges(ByVal decMeds As Decimal, ByVal decLabFees As Decimal, ByVal decSurgery As Decimal,
                             ByVal decRehab As Decimal) As Decimal
        Return decMeds + decLabFees + decSurgery + decRehab
    End Function

    Function CalcTotalCharges(ByVal decDailyCost As Decimal, ByVal miscCosts As Decimal) As Decimal
        Return decDailyCost + miscCosts
    End Function

    Function ValidateInputFields() As Boolean
        Dim intTryParse As Integer = CInt(txtDays.Text)
        Dim decTryParse As Decimal

        If txtDays.Text = "" Then
            MessageBox.Show("You must enter the number Of days As a positive number")
            Return False
        ElseIf Not Integer.TryParse(txtDays.Text, intTryParse) Then
            MessageBox.Show("Input Error You must enter positive number")
        ElseIf CInt(txtDays.Text) < 0 Then
            MessageBox.Show("Input Error the number cannot be negative.")
            Return False

        End If


        If txtMedication.Text = "" Then
            MessageBox.Show("You must enter the cost of medication as a decimal number")
            Return False
        ElseIf Not Decimal.TryParse(txtMedication.Text, decTryParse) Then
            MessageBox.Show("Invalid Input Medication Cost must be entered as a decimal")
            Return False
        ElseIf CDec(txtMedication.Text) < 0 Then
            MessageBox.Show("Input Error the number cannot be negative.")
            Return False


        End If

        If txtLabFees.Text = "" Then
            MessageBox.Show("Input Error. Lab Fees cannot be blank")
            Return False
        ElseIf Not Decimal.TryParse(txtLabFees.Text, decTryParse) Then
            MessageBox.Show("Input Error. Lab Fees must be entered as a decimal")
            Return False
        ElseIf CDec(txtLabFees.Text) < 0 Then
            MessageBox.Show("Input Error the number cannot be negative.")
            Return False

        End If

        If txtSurgicalCharges.Text = "" Then
            MessageBox.Show("Input Error. Surgical Fees cannot be blank")
            Return False
        ElseIf Not Decimal.TryParse(txtSurgicalCharges.Text, decTryParse) Then
            MessageBox.Show("Input Error. Surgical Fees must be entered as a decimal")
            Return False
        ElseIf CDec(txtSurgicalCharges.Text) < 0 Then
            MessageBox.Show("Input Error the number cannot be negative.")
            Return False

        End If

        If txtRehab.Text = "" Then
            MessageBox.Show("Input Error. Rehab Fees cannot be blank")
            Return False
        ElseIf Not Decimal.TryParse(txtRehab.Text, decTryParse) Then
            MessageBox.Show("Input Error. Rehan Fees must be entered as a decimal")
            Return False
        ElseIf CDec(txtRehab.Text) < 0 Then
            MessageBox.Show("Input Error the number cannot be negative.")
            Return False

        End If

        Return True
    End Function
End Class
