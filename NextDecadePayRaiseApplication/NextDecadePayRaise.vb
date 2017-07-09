Public Class frmNextDecadePayRaise

    Private Sub mnuClear_Click(sender As Object, e As EventArgs) Handles mnuClear.Click
        lstListBox.Items.Clear()
        lblCurrentHourly.Visible = False
        lblIncreasePercent.Visible = False
        lblYearlyIncrease.Visible = False
        lblYouEntered.Visible = False
        btnCalculate.Enabled = True
    End Sub

    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        Close()
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim strHourlyPayEntered As String
        Dim decHourlyPayEntered As Decimal = 0D
        Dim strPercentIncreaseEntered As String
        Dim decPercentIncreaseEntered As Decimal = 0D
        Dim decTotalHourlyPayEntered As Decimal = 0D
        Dim decTotalPercentEntered As Decimal = 0D
        Dim strCancelClicked As String = ""
        Dim intTotalYearly As Integer
        Const cintYearlyHours = 2080
        Dim intAnnualSalary As Integer

        strHourlyPayEntered = InputBox("What is your hourly pay?", "Current Hourly Pay")

        If IsNumeric(strHourlyPayEntered) And strHourlyPayEntered > 0 Then
            decHourlyPayEntered = Convert.ToInt32(strHourlyPayEntered)
            lblCurrentHourly.Text = "Your current pay is " & decHourlyPayEntered.ToString("C") & " per hour"
            lblCurrentHourly.Visible = True
        Else
            MsgBox("Please enter a valid number")
        End If

        strPercentIncreaseEntered = InputBox("What is your predicted percent increase?", "Wage Increase")

        If IsNumeric(strPercentIncreaseEntered) And strPercentIncreaseEntered > 0 Then
            decPercentIncreaseEntered = Convert.ToInt32(strPercentIncreaseEntered)
            lblIncreasePercent.Text = "Your predicted increase is " & decPercentIncreaseEntered.ToString & "%"
            lblIncreasePercent.Visible = True
            lblYearlyIncrease.Visible = True
            lstListBox.Visible = True
        Else
            MsgBox("Please enter a valid number")
        End If

        intTotalYearly = decHourlyPayEntered * cintYearlyHours
        For intYears = 1 To 10
            intAnnualSalary = (intTotalYearly * (decPercentIncreaseEntered / 100)) + intTotalYearly
            intTotalYearly += intAnnualSalary - intTotalYearly
            lstListBox.Items.Add("Year " & intYears & ": " & "$" & intAnnualSalary)
        Next
    End Sub


    Private Sub lstListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstListBox.SelectedIndexChanged
        'lstListBox.Items.Add("$" & (decHourlyPayEntered * 40 * 52) + (100 * decPercentIncreaseEntered) & " annual salary")
    End Sub
End Class

