Imports System.Text.RegularExpressions
Imports Excel = Office

Public Class Form_Intermediate_Table_Concentration

    Private Sub Form_Intermediate_Table_Concentration_FormClosed(sender As System.Object, e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Form_Main.Enabled = True
    End Sub

    Private Sub Button_Draw_Graph_Click(sender As System.Object, e As System.EventArgs) Handles Button_Draw_Graph.Click
        Dim list As New ArrayList
        list = ConcForms.SelectionColumnParse(DataGridView_Intermediate_Table_Concentration)
        BuildGraph(list(0), list(1), list(2), Chart_Na_Na)

    End Sub

    Private Sub Form_Intermediate_Table_Concentration_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            Dim unit As String = ""
            If Not Form_Main.isFilters Then
                unit = "ug/g"
            Else
                unit = "gram"
            End If
            ConcForms.TableContentLoad(DataGridView_Intermediate_Table_Concentration, False, Form_Main.GlobalNuclidsForCon, Form_Main.conDict, $"Conc, {unit}", $"MDC, {unit}")

            Form_Main.LocalizedForm()
            BuildGraph(Form_Main.xNA24SLI2, Form_Main.yNA24LLI1, "Na24-Na24", Chart_Na_Na)
            BuildGraph(Form_Main.xSB122LLI1, Form_Main.ySB124LLI2, "Sb122-Sb124", Chart_Sb122_Sb124)
            BuildGraph(Form_Main.xCE141LLI2, Form_Main.yLA140LLI1, "Ce141-La140", Chart_Ce_La)
            BuildGraph(Form_Main.xNP239LLI1, Form_Main.yPA233LLI2, "Np239-Pa233", Chart_Pa_Np)
            DataGridView_Intermediate_Table_Concentration.ClearSelection()


        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Try
            If My.Settings.language = "English" Then
                Me.Text = "Промежуточная таблица концентраций."
                Button_Draw_Graph.Text = "Построить график"
                Button_Save.Text = "Закрыть и сохранить в файл"
                B_Cancel.Text = "Отмена"
            Else
                Me.Text = "Intermediate table of concentration."
                Button_Draw_Graph.Text = "Construct graph"
                Button_Save.Text = "Close and save into file"
                B_Cancel.Text = "Cancel"
            End If
        Catch ex As Exception
            If My.Settings.language = "English" Then
                MsgBox("Операция была отменена (ошибка в Form_Intermediate_Table_Concentration.Form_Intermediate_Table_Concentration_Load)!", MsgBoxStyle.Critical, Me.Text)
            Else
                MsgBox("Operation was cancelled (error in Form_Intermediate_Table_Concentration.Form_Intermediate_Table_Concentration_Load)!", MsgBoxStyle.Critical, Me.Text)
            End If
            Exit Sub
        End Try
    End Sub

    Private Sub B_Cancel_Click(sender As System.Object, e As System.EventArgs) Handles B_Cancel.Click
        Me.Close()
    End Sub

    Private Sub Button_Save_Click(sender As System.Object, e As System.EventArgs) Handles Button_Save.Click
        Try

            Dim valuesRange As New Dictionary(Of String, String())
            Dim unit As String = ""
            unit = "Conc, ug/g"
            valuesRange = SaveToExcel(DataGridView_Intermediate_Table_Concentration, SaveInterTable, False, unit)
            If IsNothing(valuesRange) Then Exit Sub

            ''chart save
            'Dim xlApp As Object
            'Dim xlWorkBook As Object
            'Dim xlWorkSheet As Object
            'xlApp = CreateObject("Excel.Application")
            'xlWorkBook = xlApp.Workbooks.Open(SaveInterTable.FileName)
            'xlWorkSheet = xlWorkBook.Worksheets(1)

            'If Chart_Na_Na.Series("Na24-Na24").Points.Count > 0 Then
            '    AddChartToExcel(xlApp, xlWorkSheet, 1, (DataGridView_Intermediate_Table_Concentration.Rows.Count + 2) * 17, valuesRange("NA-24_SLI-2")(0), valuesRange("NA-24_SLI-2")(1), valuesRange("NA-24_LLI-1")(0), valuesRange("NA-24_LLI-1")(1), Chart_Na_Na.ChartAreas("ChartArea1").AxisX.Title, Chart_Na_Na.ChartAreas("ChartArea1").AxisY.Title)
            'End If
            'If Chart_Sb122_Sb124.Series("Sb122-Sb124").Points.Count > 0 Then
            '    AddChartToExcel(xlApp, xlWorkSheet, 420, (DataGridView_Intermediate_Table_Concentration.Rows.Count + 2) * 17, valuesRange("SB-122_LLI-1")(0), valuesRange("SB-122_LLI-1")(1), valuesRange("SB-124_LLI-2")(0), valuesRange("SB-124_LLI-2")(1), Chart_Sb122_Sb124.ChartAreas("ChartArea1").AxisX.Title, Chart_Sb122_Sb124.ChartAreas("ChartArea1").AxisY.Title)
            'End If
            'If Chart_Ce_La.Series("Ce141-La140").Points.Count > 0 Then
            '    AddChartToExcel(xlApp, xlWorkSheet, 1, (DataGridView_Intermediate_Table_Concentration.Rows.Count + 2) * 17 + 220, valuesRange("CE-141_LLI-2")(0), valuesRange("CE-141_LLI-2")(1), valuesRange("LA-140_LLI-1")(0), valuesRange("LA-140_LLI-1")(1), Chart_Ce_La.ChartAreas("ChartArea1").AxisX.Title, Chart_Ce_La.ChartAreas("ChartArea1").AxisY.Title)
            'End If
            'If Chart_Pa_Np.Series("Np239-Pa233").Points.Count > 0 Then
            '    AddChartToExcel(xlApp, xlWorkSheet, 420, (DataGridView_Intermediate_Table_Concentration.Rows.Count + 2) * 17 + 220, valuesRange("NP-239_LLI-1")(0), valuesRange("NP-239_LLI-1")(1), valuesRange("PA-233_LLI-2")(0), valuesRange("PA-233_LLI-2")(1), Chart_Pa_Np.ChartAreas("ChartArea1").AxisX.Title, Chart_Pa_Np.ChartAreas("ChartArea1").AxisY.Title)
            'End If

            ''процесс EXCEL.EXE не завершается http://blog.byndyu.ru/2009/05/excelexe-interopexcel.html
            '' System.Runtime.InteropServices.Marshal.ReleaseComObject(xlWorkSheet)
            'xlWorkBook.Save()
            'xlWorkBook.Close()
            ''  System.Runtime.InteropServices.Marshal.ReleaseComObject(xlWorkBook)
            ''xlApp.ActiveWorkbook.Close()
            'xlApp.Quit()
            ''  xlApp = Nothing
            ''  System.Runtime.InteropServices.Marshal.ReleaseComObject(xlApp)
            ''процесс EXCEL.EXE не завершается

            Me.Close()
            Dim result As Integer = MessageBox.Show("Готово! Хотите открыть файл?", "Программа расчета концентраций", MessageBoxButtons.YesNo)
            If result = DialogResult.No Then
                Exit Sub
            ElseIf result = DialogResult.Yes Then
                System.Diagnostics.Process.Start(SaveInterTable.FileName)
            End If

        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical)
        If My.Settings.language = "English" Then
            MsgBox("Операция была отменена (ошибка в Form_Intermediate_Table_Concentration.Button_Save_Click)!", MsgBoxStyle.Critical, Me.Text)
        Else
            MsgBox("Operation was cancelled (error in Form_Intermediate_Table_Concentration.Button_Save_Click)!", MsgBoxStyle.Critical, Me.Text)
        End If
        Exit Sub
        End Try
    End Sub
End Class