Partial Public Class frmLoan
  Inherits System.Windows.Forms.Form

  <System.Diagnostics.DebuggerNonUserCode()> _
  Public Sub New()
    MyBase.New()

    'This call is required by the Windows Form Designer.
    InitializeComponent()

  End Sub

  'Form overrides dispose to clean up the component list.
  <System.Diagnostics.DebuggerNonUserCode()> _
  Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
    If disposing AndAlso components IsNot Nothing Then
      components.Dispose()
    End If
    MyBase.Dispose(disposing)
  End Sub

  'Required by the Windows Form Designer
  Private components As System.ComponentModel.IContainer

  'NOTE: The following procedure is required by the Windows Form Designer
  'It can be modified using the Windows Form Designer.  
  'Do not modify it using the code editor.
  <System.Diagnostics.DebuggerStepThrough()> _
  Private Sub InitializeComponent()
    Me.lblPrincipal = New System.Windows.Forms.Label()
    Me.lblYearlyRate = New System.Windows.Forms.Label()
    Me.lblYrs = New System.Windows.Forms.Label()
    Me.btnPayment = New System.Windows.Forms.Button()
    Me.btnAmort = New System.Windows.Forms.Button()
    Me.btnRateTable = New System.Windows.Forms.Button()
    Me.btnQuit = New System.Windows.Forms.Button()
    Me.txtNumYears = New System.Windows.Forms.TextBox()
    Me.txtPrincipal = New System.Windows.Forms.TextBox()
    Me.txtYearlyRate = New System.Windows.Forms.TextBox()
    Me.dgvResults = New System.Windows.Forms.DataGridView()
    Me.btnShow = New System.Windows.Forms.Button()
    CType(Me.dgvResults, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'lblPrincipal
    '
    Me.lblPrincipal.AutoSize = True
    Me.lblPrincipal.Location = New System.Drawing.Point(67, 19)
    Me.lblPrincipal.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
    Me.lblPrincipal.Name = "lblPrincipal"
    Me.lblPrincipal.Size = New System.Drawing.Size(107, 17)
    Me.lblPrincipal.TabIndex = 0
    Me.lblPrincipal.Text = "Amount of loan:"
    '
    'lblYearlyRate
    '
    Me.lblYearlyRate.AutoSize = True
    Me.lblYearlyRate.Location = New System.Drawing.Point(85, 57)
    Me.lblYearlyRate.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
    Me.lblYearlyRate.Name = "lblYearlyRate"
    Me.lblYearlyRate.Size = New System.Drawing.Size(88, 17)
    Me.lblYearlyRate.TabIndex = 2
    Me.lblYearlyRate.Text = "Interest rate:"
    '
    'lblYrs
    '
    Me.lblYrs.AutoSize = True
    Me.lblYrs.Location = New System.Drawing.Point(27, 95)
    Me.lblYrs.Margin = New System.Windows.Forms.Padding(5, 1, 5, 4)
    Me.lblYrs.Name = "lblYrs"
    Me.lblYrs.Size = New System.Drawing.Size(148, 17)
    Me.lblYrs.TabIndex = 4
    Me.lblYrs.Text = "Number of loan years:"
    '
    'btnPayment
    '
    Me.btnPayment.Location = New System.Drawing.Point(17, 150)
    Me.btnPayment.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
    Me.btnPayment.Name = "btnPayment"
    Me.btnPayment.Size = New System.Drawing.Size(243, 36)
    Me.btnPayment.TabIndex = 6
    Me.btnPayment.Text = "Calculate Monthly Payment"
    '
    'btnAmort
    '
    Me.btnAmort.Location = New System.Drawing.Point(16, 233)
    Me.btnAmort.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
    Me.btnAmort.Name = "btnAmort"
    Me.btnAmort.Size = New System.Drawing.Size(243, 36)
    Me.btnAmort.TabIndex = 7
    Me.btnAmort.Text = "Display Amortization Schedule"
    '
    'btnRateTable
    '
    Me.btnRateTable.Location = New System.Drawing.Point(17, 399)
    Me.btnRateTable.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
    Me.btnRateTable.Name = "btnRateTable"
    Me.btnRateTable.Size = New System.Drawing.Size(243, 36)
    Me.btnRateTable.TabIndex = 8
    Me.btnRateTable.Text = "Display Interest Rate Change Table"
    '
    'btnQuit
    '
    Me.btnQuit.Location = New System.Drawing.Point(17, 482)
    Me.btnQuit.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
    Me.btnQuit.Name = "btnQuit"
    Me.btnQuit.Size = New System.Drawing.Size(243, 36)
    Me.btnQuit.TabIndex = 9
    Me.btnQuit.Text = "Quit"
    '
    'txtNumYears
    '
    Me.txtNumYears.Location = New System.Drawing.Point(179, 92)
    Me.txtNumYears.Margin = New System.Windows.Forms.Padding(4)
    Me.txtNumYears.Name = "txtNumYears"
    Me.txtNumYears.Size = New System.Drawing.Size(79, 22)
    Me.txtNumYears.TabIndex = 5
    Me.txtNumYears.Text = "30"
    '
    'txtPrincipal
    '
    Me.txtPrincipal.Location = New System.Drawing.Point(179, 16)
    Me.txtPrincipal.Margin = New System.Windows.Forms.Padding(4)
    Me.txtPrincipal.Name = "txtPrincipal"
    Me.txtPrincipal.Size = New System.Drawing.Size(79, 22)
    Me.txtPrincipal.TabIndex = 1
    Me.txtPrincipal.Text = "250000"
    '
    'txtYearlyRate
    '
    Me.txtYearlyRate.Location = New System.Drawing.Point(179, 54)
    Me.txtYearlyRate.Margin = New System.Windows.Forms.Padding(4)
    Me.txtYearlyRate.Name = "txtYearlyRate"
    Me.txtYearlyRate.Size = New System.Drawing.Size(79, 22)
    Me.txtYearlyRate.TabIndex = 3
    Me.txtYearlyRate.Text = "4"
    '
    'dgvResults
    '
    Me.dgvResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
    Me.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.dgvResults.Location = New System.Drawing.Point(288, 15)
    Me.dgvResults.Margin = New System.Windows.Forms.Padding(4)
    Me.dgvResults.Name = "dgvResults"
    Me.dgvResults.RowHeadersVisible = False
    Me.dgvResults.Size = New System.Drawing.Size(560, 504)
    Me.dgvResults.TabIndex = 10
    '
    'btnShow
    '
    Me.btnShow.Location = New System.Drawing.Point(16, 316)
    Me.btnShow.Margin = New System.Windows.Forms.Padding(4)
    Me.btnShow.Name = "btnShow"
    Me.btnShow.Size = New System.Drawing.Size(243, 36)
    Me.btnShow.TabIndex = 11
    Me.btnShow.Text = "Show Interest Paid for One Year"
    Me.btnShow.UseVisualStyleBackColor = True
    '
    'frmLoan
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(865, 530)
    Me.Controls.Add(Me.btnShow)
    Me.Controls.Add(Me.dgvResults)
    Me.Controls.Add(Me.txtYearlyRate)
    Me.Controls.Add(Me.txtPrincipal)
    Me.Controls.Add(Me.txtNumYears)
    Me.Controls.Add(Me.btnQuit)
    Me.Controls.Add(Me.btnRateTable)
    Me.Controls.Add(Me.btnAmort)
    Me.Controls.Add(Me.btnPayment)
    Me.Controls.Add(Me.lblYrs)
    Me.Controls.Add(Me.lblYearlyRate)
    Me.Controls.Add(Me.lblPrincipal)
    Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
    Me.Name = "frmLoan"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Analyze a Loan"
    CType(Me.dgvResults, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents lblPrincipal As System.Windows.Forms.Label
  Friend WithEvents lblYearlyRate As System.Windows.Forms.Label
  Friend WithEvents lblYrs As System.Windows.Forms.Label
  Friend WithEvents btnPayment As System.Windows.Forms.Button
  Friend WithEvents btnAmort As System.Windows.Forms.Button
  Friend WithEvents btnRateTable As System.Windows.Forms.Button
  Friend WithEvents btnQuit As System.Windows.Forms.Button
  Friend WithEvents txtNumYears As System.Windows.Forms.TextBox
  Friend WithEvents txtPrincipal As System.Windows.Forms.TextBox
  Friend WithEvents txtYearlyRate As System.Windows.Forms.TextBox
  Friend WithEvents dgvResults As System.Windows.Forms.DataGridView
  Friend WithEvents btnShow As System.Windows.Forms.Button

End Class
