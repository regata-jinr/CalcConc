Public Class Form_Language

    Private Sub RadioButton_Russian_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton_Russian.CheckedChanged
        If RadioButton_Russian.Checked = True Then
            RadioButton_English.Checked = False
            Form_Main.language = "russian"

        End If
        If RadioButton_Russian.Checked = False Then
            RadioButton_English.Checked = True
            Form_Main.language = "english"
        End If
        Form_Main.Change_Language_Always()
        Form_Main.Change_Language_Label_First()
        Form_Main.Initial_Installations()
    End Sub

    Private Sub RadioButton_English_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton_English.CheckedChanged
        If RadioButton_Russian.Checked = True Then
            RadioButton_English.Checked = False
            Form_Main.language = "russian"
        End If
        If RadioButton_Russian.Checked = False Then
            RadioButton_English.Checked = True
            Form_Main.language = "english"
        End If

        Form_Main.Change_Language_Always()
    End Sub
    Private Sub Button_Close_Click(sender As System.Object, e As System.EventArgs) Handles Button_Close.Click
        Form_Main.Enabled = True
        Me.Close()
    End Sub

    Private Sub Form_Language_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If Form_Main.language = "russian" Then
            RadioButton_Russian.Checked = True
            RadioButton_English.Checked = False

        ElseIf Form_Main.language = "english" Then
            RadioButton_Russian.Checked = False
            RadioButton_English.Checked = True
        End If
    End Sub

    Private Sub Form_Language_QueryClose(Cancel As Integer, CloseMode As Integer)
        'If UnloadMode = vbFormControl_Menu Then
        Cancel = 1
        'End If
    End Sub

End Class