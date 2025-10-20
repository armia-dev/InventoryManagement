Module layouthelper


    Public Sub SetupFormLayout(targetForm As Form, mainPanel As Panel)
        With targetForm
            .StartPosition = FormStartPosition.CenterScreen
            .FormBorderStyle = FormBorderStyle.FixedSingle
            .WindowState = FormWindowState.Normal


            Dim screenWidth As Integer = Screen.PrimaryScreen.WorkingArea.Width
            Dim screenHeight As Integer = Screen.PrimaryScreen.WorkingArea.Height
            .Size = New Size(CInt(screenWidth * 0.85), CInt(screenHeight * 0.85))
        End With


        If mainPanel IsNot Nothing Then
            CenterPanel(targetForm, mainPanel)
        End If
    End Sub

    Public Sub CenterPanel(f As Form, p As Panel)
        If p Is Nothing Then Return
        p.Left = (f.ClientSize.Width - p.Width) \ 2
        p.Top = (f.ClientSize.Height - p.Height) \ 2
    End Sub

End Module

