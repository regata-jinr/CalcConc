Public Class FormWoConcTable
    Private Sub FormWoConcTable_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            If My.Settings.language = "Russian" Then
                Me.Text = "Таблица элементов ненайденных в эталоне"
                LabelTableInterComment.Text = "Таблица содержит значения активностей элементов, которые не удалось найти в эталоне"
                Button_Save.Text = "Закрыть и сохранить в файл"
            Else
                Me.Text = "Table with elements which was not found in standard"
                LabelTableInterComment.Text = "Table has an elements which was not found in standard."
                Button_Save.Text = "Close and save into file"
            End If

            Dim unit As String = ""
            If Not Form_Main.CheckBoxFilter.Checked Then
                unit = "uCi/gr"
            Else
                unit = "uCi"
            End If

            ConcForms.TableContentLoad(DataGridView_WoConcElements, False, Form_Main.GlobalNuclidsForAct, Form_Main.actDict, $"Activity, {unit}", $"MDC, {unit}")
            Form_Main.LocalizedForm()
            DataGridView_WoConcElements.ClearSelection()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Button_Save_Click(sender As Object, e As EventArgs) Handles Button_Save.Click
        Dim valuesRange As New Dictionary(Of String, String())
        valuesRange = SaveToExcel(DataGridView_WoConcElements, SaveWoConcTable, False, "Activity, uCi/gr")
        If IsNothing(valuesRange) Then Exit Sub
        Try
            'chart save
            Dim xlApp As Object
            Dim xlWorkBook As Object
            Dim xlWorkSheet As Object
            xlApp = CreateObject("Excel.Application")
            xlWorkBook = xlApp.Workbooks.Open(SaveWoConcTable.FileName)
            xlWorkSheet = xlWorkBook.Worksheets(1)

            'процесс EXCEL.EXE не завершается http://blog.byndyu.ru/2009/05/excelexe-interopexcel.html
            ' System.Runtime.InteropServices.Marshal.ReleaseComObject(xlWorkSheet)
            xlWorkBook.Save()
            xlWorkBook.Close()
            '  System.Runtime.InteropServices.Marshal.ReleaseComObject(xlWorkBook)
            'xlApp.ActiveWorkbook.Close()
            xlApp.Quit()
            '  xlApp = Nothing
            '  System.Runtime.InteropServices.Marshal.ReleaseComObject(xlApp)
            'процесс EXCEL.EXE не завершается

            Me.Close()
            Dim result As Integer = MessageBox.Show("Готово! Хотите открыть файл?", "Программа расчета концентраций", MessageBoxButtons.YesNo)
            If result = DialogResult.No Then
                Exit Sub
            ElseIf result = DialogResult.Yes Then
                System.Diagnostics.Process.Start(SaveWoConcTable.FileName)
            End If

        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical)
            If My.Settings.language = "Russian" Then
                MsgBox("Операция была отменена (ошибка в Form_Intermediate_Table_Concentration.Button_Save_Click)!", MsgBoxStyle.Critical, Me.Text)
            Else
                MsgBox("Operation was cancelled (error in Form_Intermediate_Table_Concentration.Button_Save_Click)!", MsgBoxStyle.Critical, Me.Text)
            End If
            Exit Sub
        End Try
    End Sub
End Class