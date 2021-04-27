Public Class Form1
    Private nowStep As Steps
    Private nowPan(9) As Steps
    Public Enum Steps
        Maru = 0
        Ex = 1
        N = 255
    End Enum
    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        clearP()
        nowStep = 1
    End Sub

    Private Sub clearP()
        Button1.Text = ""
        Button2.Text = ""
        Button3.Text = ""
        Button4.Text = ""
        Button5.Text = ""
        Button6.Text = ""
        Button7.Text = ""
        Button8.Text = ""
        Button9.Text = ""

        Button1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
        Button4.Enabled = True
        Button5.Enabled = True
        Button6.Enabled = True
        Button7.Enabled = True
        Button8.Enabled = True
        Button9.Enabled = True
        For i = 1 To 9
            nowPan(i) = 255
        Next
    End Sub
    Private Function getnextStepinString() As String
        Select Case nowStep
            Case 0
                nowStep = 1
                Return "X"
            Case 1
                nowStep = 0
                Return "O"
        End Select
    End Function
    Private Sub Check()
        
        '行
        Dim temp
        For start = 1 To 7 Step 3
            temp = nowPan(start) + nowPan(start + 1) + nowPan(start + 2)
            Select Case temp
                Case 0
                    'Maru Wins
                    Wins(0)
                    Exit Sub
                Case 3
                    'Ex Wins
                    Wins(1)
                    Exit Sub
                Case Else
            End Select
        Next
        '列
        For start = 1 To 3 Step 1
            temp = nowPan(start) + nowPan(start + 3) + nowPan(start + 6)
            Select Case temp
                Case 0
                    'Maru Wins
                    Wins(0)
                    Exit Sub
                Case 3
                    'Ex Wins
                    Wins(1)
                    Exit Sub
                Case Else
            End Select
        Next
        temp = nowPan(1) + nowPan(5) + nowPan(9)
        Select Case temp
            Case 0
                'Maru Wins
                Wins(0)
                Exit Sub
            Case 3
                'Ex Wins
                Wins(1)
                Exit Sub
            Case Else
        End Select
        temp = nowPan(3) + nowPan(5) + nowPan(7)
        Select Case temp
            Case 0
                'Maru Wins
                Wins(0)
                Exit Sub
            Case 3
                'Ex Wins
                Wins(1)
                Exit Sub
            Case Else
        End Select
        Dim empty As Boolean
        empty = False
        For i = 1 To 9
            If nowPan(i) = 255 Then
                empty = True
            End If
        Next
        If empty = False Then
            MsgBox("Draw!")
        End If
    End Sub
    Private Sub Wins(winner As Steps)
        Select Case winner
            Case 0
                MsgBox("Congratulation!Maru wins")
            Case 1
                MsgBox("Congratulation!Cross wins")
        End Select
    End Sub
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim p As String
        p = getnextStepinString()
        Button9.Text = p
        Button9.Enabled = False
        nowPan(9) = StringToSteps(p)
        Check()
    End Sub

    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel1.Paint

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim p As String
        p = getnextStepinString()
        Button8.Text = p
        Button8.Enabled = False
        nowPan(8) = StringToSteps(p)
        Check()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim p As String
        p = getnextStepinString()
        Button7.Text = p
        Button7.Enabled = False
        nowPan(7) = StringToSteps(p)
        Check()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim p As String
        p = getnextStepinString()
        Button6.Text = p
        Button6.Enabled = False
        nowPan(6) = StringToSteps(p)
        Check()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim p As String
        p = getnextStepinString()
        Button5.Text = p
        Button5.Enabled = False
        nowPan(5) = StringToSteps(p)
        Check()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim p As String
        p = getnextStepinString()
        Button4.Text = p
        Button4.Enabled = False
        nowPan(4) = StringToSteps(p)
        Check()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim p As String
        p = getnextStepinString()
        Button3.Text = p
        Button3.Enabled = False
        nowPan(3) = StringToSteps(p)
        Check()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim p As String
        p = getnextStepinString()
        Button2.Text = p
        Button2.Enabled = False
        nowPan(2) = StringToSteps(p)
        Check()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim p As String
        p = getnextStepinString()
        Button1.Text = p
        Button1.Enabled = False
        nowPan(1) = StringToSteps(p)
        Check()
    End Sub
    Private Function StringToSteps(t As String) As Steps
        Select Case t
            Case "X"
                Return 1
            Case "O"
                Return 0
        End Select
    End Function
End Class
