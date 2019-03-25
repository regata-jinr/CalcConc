Imports System.Text.RegularExpressions
Imports File = System.IO.File
Imports System.IO
Imports System.Text
Imports System

Public Class Form_Table_Nuclides

    Public FirstLoad As Boolean = True

    Public Sub Form_Table_Nuclides_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            Form_Main.LocalizedForm()

            Dim elem As String = ""
            Dim type As String = ""
            Dim i As Integer = 0
            Dim Nucl As New DataGridViewTextBoxColumn
            Dim TypeClmn As New DataGridViewComboBoxColumn 'необходим элемент ComboBoxCell
            Dim comboCell As New DataGridViewComboBoxCell

            If DataGridView_Table_Nuclides.Columns.Count = 0 Then
                DataGridView_Table_Nuclides.Columns.Add(Nucl)
                DataGridView_Table_Nuclides.Columns.Add(TypeClmn)
            End If

            DataGridView_Table_Nuclides.Rows.Clear()

            For Each elem_type In Form_Main.NuclidFromTable
                elem = Split(elem_type, "_")(0)
                type = Split(elem_type, "_")(1)

                DataGridView_Table_Nuclides.Rows.Add()
                DataGridView_Table_Nuclides.Item(0, i).Value = elem

                comboCell = DataGridView_Table_Nuclides.Item(1, i)

                For Each key As String In Form_Main.TypeRuEng.Keys
                    comboCell.Items.Add(key)
                    ' type comparison
                    Debug.WriteLine(key.ToLower & "  " & type.ToLower)
                    If Form_Main.TypeRuEng(key).ToLower = type.ToLower Then
                        DataGridView_Table_Nuclides.Item(1, i).Value = key
                    End If
                Next
                i += 1
            Next

            DataGridView_Table_Nuclides.Columns(0).SortMode = DataGridViewColumnSortMode.NotSortable
            DataGridView_Table_Nuclides.Columns(1).SortMode = DataGridViewColumnSortMode.NotSortable

            If My.Settings.language = "Russian" Then
                Me.Text = "Таблица нуклидов."
                B_Save_Table_Nuclides.Text = "Cохранить таблицу"
                B_Cancel.Text = "Отмена"

                DataGridView_Table_Nuclides.Columns(0).HeaderText = "Нуклид"
                DataGridView_Table_Nuclides.Columns(1).HeaderText = "Тип измерений"
                'SaveFileDialog_Grup_Stand_GRS_Editor.Filter = "Файлы групповых стандартов (*.grs)|*.grs|Все файлы (*.*)|*.*"
            Else
                Me.Text = "Table of nuclides."

                B_Save_Table_Nuclides.Text = "Save table"
                B_Cancel.Text = "Cancel"

                DataGridView_Table_Nuclides.Columns(0).HeaderText = "Nuclide"
                DataGridView_Table_Nuclides.Columns(1).HeaderText = "Type of measurements"

            End If

            FirstLoad = False

        Catch ex As Exception
            MsgBox(ex.ToString)
            If My.Settings.language = "Russian" Then
                MsgBox("Операция была отменена (ошибка в Form_Table_Nuclides.Form_Table_Nuclides_Load)!", MsgBoxStyle.Critical, Me.Text)
            Else
                MsgBox("Operation was cancelled (error in Form_Table_Nuclides.Form_Table_Nuclides_Load)!", MsgBoxStyle.Critical, Me.Text)
            End If
            Exit Sub
        End Try
    End Sub

    Private Sub Form_Table_Nuclides_FormClosed(sender As System.Object, e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Form_Main.Enabled = True
    End Sub

    Private Sub B_Save_Table_Nuclides_Click(sender As System.Object, e As System.EventArgs) Handles B_Save_Table_Nuclides.Click
        Try
            File.Delete("C:\WORKPROG\saved_table_nuclides.txt")
            Using sw As New IO.StreamWriter("C:\WORKPROG\saved_table_nuclides.txt")
                Dim tempString As String = ""

                For i As Integer = 0 To DataGridView_Table_Nuclides.Rows.Count - 1
                    tempString = DataGridView_Table_Nuclides(0, i).Value & "_" & Form_Main.TypeRuEng(DataGridView_Table_Nuclides(1, i).Value)

                    sw.WriteLine(tempString)
                    'My.Settings.tableNuclids = DataGridView_Table_Nuclides(0, i).Value & vbTab & DataGridView_Table_Nuclides(1, i).Value
                Next
            End Using
            'fs.Close()
            Form_Main.NuclidFromTableFill()

            '            Me.Refresh()
            MsgBox("Готово!", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical)
            Exit Sub
        End Try
    End Sub

    Private Sub B_Cancel_Click(sender As System.Object, e As System.EventArgs) Handles B_Cancel.Click
        Me.Close()
    End Sub


    Private Sub ButDelNucl_Click(sender As System.Object, e As System.EventArgs) Handles ButDelNucl.Click
        DataGridView_Table_Nuclides.Rows.Remove(DataGridView_Table_Nuclides.SelectedRows(0))
    End Sub

    Private Sub ButAddNucl_Click(sender As System.Object, e As System.EventArgs) Handles ButAddNucl.Click
        Me.Enabled = False
        AddElement.Show()
    End Sub

    Public Sub ButRestoreDefaults_Click(sender As Object, e As EventArgs) Handles ButRestoreDefaults.Click

        File.Delete("C:\\WORKPROG\\saved_table_nuclides.txt")
        Form_Main.NuclidFromTableFill()
        Form_Table_Nuclides_Load(sender, e)

    End Sub
End Class