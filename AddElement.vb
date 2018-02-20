Imports System.Text.RegularExpressions

Public Class AddElement

    Private Sub ButAddNuclAndType_Click(sender As System.Object, e As System.EventArgs) Handles ButAddNuclAndType.Click
        Try
            Dim elem As Regex = New Regex("[A-Z]{1,2}-\d{2,3}[m]{0,1}")
            Dim nucl, type As String
            nucl = NuclidTextBox.Text
            type = ComboBoxType.Text
            If Not elem.IsMatch(nucl) Then
                NuclidTextBox.Text = ""
                nucl = ""
                MsgBox("Введенный элемент не соответствует формату", MsgBoxStyle.Critical)
                Exit Sub
            End If

            'My.Settings.tableNuclids = My.Settings.tableNuclids & vbCrLf & nucl & vbTab & type
            Me.Close()
            Form_Table_Nuclides.Enabled = True
            Form_Table_Nuclides.Close()
            Form_Table_Nuclides.Form_Table_Nuclides_Load(sender, e)
            Form_Table_Nuclides.Show()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub ButCancel_Click(sender As System.Object, e As System.EventArgs) Handles ButCancel.Click
        Me.Close()
        Form_Table_Nuclides.Enabled = True
    End Sub
End Class