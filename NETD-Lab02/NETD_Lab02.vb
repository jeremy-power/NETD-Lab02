Public Class frmGolfMain

    Dim holes() As Integer = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18}
    Dim pars() As Integer = {72, 4, 4, 5, 4, 3, 4, 3, 5, 4, 3, 4, 4, 5, 4, 5, 3, 4, 4}
    Dim scores(17) As Integer
    Dim currentHole As Integer

    Private Sub frmGolfMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        resetForm()
        
    End Sub
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        If (MessageBox.Show("Are you sure you want to reset?", "Reset", MessageBoxButtons.YesNo)) = DialogResult.Yes Then
            resetForm()
        End If

    End Sub

    Private Sub resetForm()
        nudScore.Focus()
        currentHole = 1
        nudScore.Value = pars(currentHole)

        For k As Integer = 1 To 18
            txtHole.Text += CStr(k) + vbCrLf
        Next

        For i As Integer = 1 To 18
            txtPar.Text += CStr(pars(i)) + vbCrLf
        Next

        txtScore.Text = ""
        txtResult.Text = ""
        lblHoleNum.Text = "1"
        txtScoreFinal.Text = ""
        txtResultFinal.Text = ""
        nudScore.Enabled = True
        btnScore.Enabled = True


        For i As Integer = 0 To scores.Length - 1
            scores(i) = 0
        Next


    End Sub

    Private Sub inputScore()

        If (currentHole < 19) Then
            Dim currentScore As Decimal = nudScore.Value
            txtScore.Text += CStr(currentScore) + vbCrLf

            txtResult.Text += getResult(pars(currentHole), CInt(currentScore)) + vbCrLf

            txtScoreFinal.Text = CStr(currentTotal((CInt(currentScore))))
            txtResultFinal.Text = CStr(currentResult(currentTotal(CInt(currentScore))))

            currentHole += 1
            If (currentHole = 19) Then
                lblHoleNum.Text = "COMPLETE"
                nudScore.Enabled = False
                btnScore.Enabled = False

            Else
                nudScore.Value = pars(currentHole)
                lblHoleNum.Text = CStr(currentHole)
            End If

        End If

    End Sub

    Private Sub btnScore_Click(sender As Object, e As EventArgs) Handles btnScore.Click
        inputScore()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Function getResult(ByVal par As Integer, ByVal score As Integer) As String
        If (score = 1) Then
            Return "Ace"
        ElseIf (score = 8) Then
            Return "Snowman"
        Else
            Select Case score - par
                Case 0
                    Return "Par"
                Case -1
                    Return "Birdie"
                Case -2
                    Return "Eagle"
                Case -3
                    Return "Double Eagle"
                Case 1
                    Return "Bogey"
                Case 2
                    Return "Dbl Bogey"
                Case 3
                    Return "Triple Bogey"
            End Select

        End If
        Return "Other"
    End Function

    Private Function currentTotal(ByVal score As Integer) As Integer
        Dim totalScore As Integer
        If currentHole < 19 Then
            scores(currentHole - 1) = score
            For i As Integer = 0 To scores.Length - 1
                totalScore += scores(i)
            Next
        End If
        Return totalScore



    End Function

    Private Function currentResult(ByVal currentTotal As Integer) As Integer
        Dim currentPar As Integer
        If currentHole < 19 Then
            For i As Integer = 1 To currentHole
                currentPar += pars(i)
            Next
        End If
        Return currentTotal - currentPar
    End Function


End Class