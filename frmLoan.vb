Public Class frmLoan

  Structure Month
    Dim number As Integer
    Dim interestPaid As Decimal
    Dim principalPaid As Decimal
    Dim endBalance As Decimal
  End Structure

  Structure EffectOfRate
    Dim interestRate As Decimal
    Dim monthlyPayment As Decimal
  End Structure

  Private Sub btnPayment_Click(sender As System.Object, e As System.EventArgs) Handles btnPayment.Click
    Dim principal As Decimal  'Amount of the loan
    Dim yearlyRate As Decimal 'Annual rate of interest
    Dim numMonths As Integer 'Number of months to repay loan
    InputData(principal, yearlyRate, numMonths)
    Dim monthlyRate As Decimal = yearlyRate / 12
    Dim monthlyPayment As Decimal
    'Calculate monthly payment
    monthlyPayment = Payment(principal, monthlyRate, numMonths)
    'Display results
    MessageBox.Show("Monthly payment: " & monthlyPayment.ToString("C"), "Payment")
  End Sub

  Private Sub btnAmort_Click(sender As System.Object, e As System.EventArgs) Handles btnAmort.Click
    Dim principal As Decimal  'amount of the loan
    Dim yearlyRate As Decimal 'annual rate of interest
    Dim numMonths As Integer 'number of months to repay loan
    InputData(principal, yearlyRate, numMonths)
    Dim months(numMonths - 1) As Month
    Dim monthlyRate As Decimal = yearlyRate / 12
    Dim monthlyPayment As Decimal = Payment(principal, monthlyRate, numMonths)
    months = GenerateMonthsArray(principal, monthlyRate, numMonths)
    Dim query = From mnth In months
                Let num = mnth.number
                Let interest = (mnth.interestPaid).ToString("C")
                Let prin = (mnth.principalPaid).ToString("C")
                Let bal = (mnth.endBalance).ToString("C")
                Select num, interest, prin, bal
    dgvResults.DataSource = query.ToList
    dgvResults.CurrentCell = Nothing
    dgvResults.Columns("num").HeaderText = "Month"
    dgvResults.Columns("interest").HeaderText = "Amount Paid for Interest"
    dgvResults.Columns("prin").HeaderText = "Amount Paid for Principal"
    dgvResults.Columns("bal").HeaderText = "Balance at End of Month"
  End Sub

  Private Sub btnShow_Click(sender As System.Object, e As System.EventArgs) Handles btnShow.Click
    Dim principal As Decimal  'amount of loan
    Dim yearlyRate As Decimal 'annual rate of interest
    Dim numMonths As Integer 'number of months to repay loan
    InputData(principal, yearlyRate, numMonths)
    Dim months(numMonths - 1) As Month
    Dim monthlyRate As Decimal = yearlyRate / 12
    Dim monthlyPayment As Decimal = Payment(principal, monthlyRate, numMonths)
    months = GenerateMonthsArray(principal, monthlyRate, numMonths)
    Dim beginningMonth As Integer = CInt(InputBox("Enter beginning month: "))
    Dim query = From month In months
                Where (month.number >= beginningMonth) And
                      (month.number < beginningMonth + 12)
                Select month.interestPaid
    MessageBox.Show("Interest Paid for year beginning with month " &
            beginningMonth & ": " & (query.Sum).ToString("C"), "Interest For Year")
  End Sub

  Private Sub btnRateTable_Click(sender As System.Object, e As System.EventArgs) Handles btnRateTable.Click
    Dim principal As Decimal  'amount of loan
    Dim yearlyRate As Decimal 'annual rate of interest
    Dim numMonths As Integer 'number of months to repay loan
    InputData(principal, yearlyRate, numMonths)
    Dim rates(16) As EffectOfRate
    Dim monthlyRate As Decimal = yearlyRate / 12
    'Dim monthlyPayment As Decimal = Payment(principal, monthlyRate, numMonths)
    'Fill rates array
    For i As Integer = 0 To 16
      rates(i).interestRate = (yearlyRate - 0.01D) + i * 0.00125D
      rates(i).monthlyPayment = Payment(principal, rates(i).interestRate / 12, numMonths)
    Next
    Dim query = From rate In rates
                Let annualRate = (rate.interestRate).ToString("P3")
                Let monthlyPayment = (rate.monthlyPayment).ToString("C")
                Select annualRate, monthlyPayment
    dgvResults.DataSource = query.ToList
    dgvResults.CurrentCell = Nothing
    dgvResults.Columns("annualRate").HeaderText = "Interest Rate"
    dgvResults.Columns("monthlyPayment").HeaderText = "Monthly Payment"
  End Sub

  Private Sub btnQuit_Click(sender As System.Object, e As System.EventArgs) Handles btnQuit.Click
    Me.Close()
  End Sub

  Sub InputData(ByRef principal As Decimal,
                ByRef yearlyRate As Decimal,
                ByRef numMonths As Integer)
    'Input loan amount, yearly rate of interest, and duration
    Dim percentageRate As Decimal, numYears As Integer
    principal = CDec(txtPrincipal.Text)
    percentageRate = CDec(txtYearlyRate.Text)
    yearlyRate = percentageRate / 100   'Convert interest rate to decimal form
    numYears = CInt(txtNumYears.Text)
    numMonths = numYears * 12           'Duration of loan in months
  End Sub

  Function Payment(principal As Decimal, monthlyRate As Decimal, numMonths As Integer) As Decimal
    Dim estimate As Decimal          'Estimate of monthly payment
    estimate = CDec(principal * monthlyRate / (1 - (1 + monthlyRate) ^ (-numMonths)))
    ' Round the payment up if there are fractions of a cent
    If estimate = Math.Round(estimate, 2) Then
      Return estimate
    Else
      Return Math.Round(estimate + 0.005D, 2)
    End If
  End Function

  Function GenerateMonthsArray(principal As Decimal, monthlyRate As Decimal, numMonths As Integer) As Month()
    Dim months(numMonths - 1) As Month
    'Fill the months array
    Dim monthlyPayment As Decimal = Payment(principal, monthlyRate, numMonths)
    'Assign values for first month
    months(0).number = 1
    months(0).interestPaid = monthlyRate * principal
    months(0).principalPaid = monthlyPayment - months(0).interestPaid
    'months(0).endBalance = (1 + monthlyRate) * principal - monthlyPayment
    months(0).endBalance = principal - months(0).principalPaid
    'Assign values for interior months
    For i As Integer = 1 To numMonths - 2
      months(i).number = i + 1
      months(i).interestPaid = monthlyRate * months(i - 1).endBalance
      months(i).principalPaid = monthlyPayment - months(i).interestPaid
      'months(i).endBalance = (1 + monthlyRate) * months(i - 1).endBalance -
      '                         monthlyPayment
      months(i).endBalance = months(i - 1).endBalance - months(i).principalPaid
    Next
    'Assign values for last month
    months(numMonths - 1).number = numMonths
    months(numMonths - 1).interestPaid = monthlyRate *
                                         months(numMonths - 2).endBalance
    months(numMonths - 1).principalPaid = months(numMonths - 2).endBalance
    months(numMonths - 1).endBalance = 0
    Return months
  End Function

End Class
