Public Class frmGolfMain
#Region "Global Variable Declaration"
    'array to hold the par for each hole
    Dim gpars() As Integer = {72, 4, 4, 5, 4, 3, 4, 3, 5, 4, 3, 4, 4, 5, 4, 5, 3, 4, 4}
    'array to hold the user's score for each hole
    Dim gscores(17) As Integer
    'variable to track current hole
    Dim gcurrentHole As Integer
#End Region
    ''' <summary>
    ''' Handles the form loading event
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub frmGolfMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        resetForm()

    End Sub
    ''' <summary>
    ''' handles the reset button event
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        'checks if user wants to reset
        If (MessageBox.Show("Are you sure you want to reset?", "Reset", MessageBoxButtons.YesNo)) = DialogResult.Yes Then
            resetForm()
        End If

    End Sub

    ''' <summary>
    ''' abstracts all actions when form resets to defaults
    ''' </summary>
    Private Sub resetForm()
        'sets focus on the score input number box
        nudScore.Focus()
        'sets the current hole to 0
        gcurrentHole = 1
        'sets the default option of the input number box to the par of the current hole
        nudScore.Value = gpars(gcurrentHole)

        'fills in all hole numbers
        For k As Integer = 1 To 18
            txtHole.Text += CStr(k) + vbCrLf
        Next

        'fills in all par numbers
        For i As Integer = 1 To 18
            txtPar.Text += CStr(gpars(i)) + vbCrLf
        Next

        'resets all labels and text boes on the form
        txtScore.Text = ""
        txtResult.Text = ""
        lblHoleNum.Text = "1"
        txtScoreFinal.Text = ""
        txtResultFinal.Text = ""
        're-enables the input controls if they were disabled by finishing the form
        nudScore.Enabled = True
        btnScore.Enabled = True

        'resets scores to 0
        For i As Integer = 0 To gscores.Length - 1
            gscores(i) = 0
        Next

    End Sub

    ''' <summary>
    ''' subroutine that places the user's score into the score text box,
    ''' then moves to the next hole
    ''' </summary>
    Private Sub inputScore()
        'handles the event ending after 18 holes
        If (gcurrentHole < 19) Then

            'sets the user's input to a value
            Dim currentScore As Integer = CInt(nudScore.Value)
            'puts the user's score into the score text box
            txtScore.Text += CStr(currentScore) + vbCrLf

            'sets the result text to outcome of the user's shot
            txtResult.Text += getResult(gpars(gcurrentHole), CInt(currentScore)) + vbCrLf

            'sets total score and  and final result against par values to their respective text boxes
            txtScoreFinal.Text = CStr(currentTotal((currentScore)))
            txtResultFinal.Text = CStr(currentResult(currentTotal(currentScore)))

            ''moves logic to next hole
            gcurrentHole += 1
            'ends at 19
            If (gcurrentHole = 19) Then
                'completes form
                lblHoleNum.Text = "COMPLETE"
                nudScore.Enabled = False
                btnScore.Enabled = False

                'if not ending, moves form to next hole
            Else
                nudScore.Value = gpars(gcurrentHole)
                lblHoleNum.Text = CStr(gcurrentHole)
            End If

        End If

    End Sub

    ''' <summary>
    ''' handles the enter score button event
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnScore_Click(sender As Object, e As EventArgs) Handles btnScore.Click
        'inputs the score
        inputScore()
    End Sub

    ''' <summary>
    ''' handles close button event
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    ''' <summary>
    ''' determines using the user's score and the current hole's par what type of
    ''' shot they had
    ''' </summary>
    ''' <param name="par">Value of Par for the current hole</param>
    ''' <param name="score">User's Score for the current hole</param>
    ''' <returns>returns a string to be represented as the result of the shot</returns>
    Private Function getResult(ByVal par As Integer, ByVal score As Integer) As String
        'hole in one
        If (score = 1) Then
            Return "Ace"
            'snowman
        ElseIf (score = 8) Then
            Return "Snowman"
            'otherwise compares their score to par
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
        'if no types apply, return other
        Return "Other"
    End Function

    ''' <summary>
    ''' returns the user's current total score, to be printed to the screen
    ''' and also used to compare to par
    ''' </summary>
    ''' <param name="score">uses the current score for the hole</param>
    ''' <returns></returns>
    Private Function currentTotal(ByVal score As Integer) As Integer
        'integer to hold current total score
        Dim totalScore As Integer
        'avoids index out of boud error
        If gcurrentHole < 19 Then
            'adds the current hole score to its spot in the array
            gscores(gcurrentHole - 1) = score

            'iterates through the array
            For i As Integer = 0 To gscores.Length - 1
                'adds all scores together
                totalScore += gscores(i)
            Next
        End If
        'returns total score
        Return totalScore
    End Function

    ''' <summary>
    ''' calculates the total par up to the current hole, compares it to the user's current total score to give them
    ''' a + or - value against par
    ''' </summary>
    ''' <param name="currentTotal">uses the current total to compare to the total par up to the current hole</param>
    ''' <returns>an integer value that represents how well the user is doing against par for the course</returns>
    Private Function currentResult(ByVal currentTotal As Integer) As Integer
        'value to hold the par up to this hole
        Dim currentPar As Integer
        'avoids index out of bound error
        If gcurrentHole < 19 Then
            'iterates from hole 1 to the current hole
            For i As Integer = 1 To gcurrentHole
                'adds up all pars
                currentPar += gpars(i)
            Next
        End If
        'returns the difference between the user's score and par
        Return currentTotal - currentPar
    End Function

End Class