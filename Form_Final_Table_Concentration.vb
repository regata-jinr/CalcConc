Public Class Form_Final_Table_Concentration

    Private Sub B_Cancel_Click(sender As System.Object, e As System.EventArgs) Handles B_Cancel.Click
        Me.Close()
    End Sub

    Private Sub Button_Save_Click(sender As System.Object, e As System.EventArgs) Handles Button_Save.Click
        Dim valuesRange As New Dictionary(Of String, String())
        valuesRange = SaveToExcel(DataGridView_Final_Table_Concentration, SaveFinalTable, True)
        If IsNothing(valuesRange) Then Exit Sub

        Try
            'chart save
            Dim xlApp As Object
            Dim xlWorkBook As Object
            Dim xlWorkSheet As Object
            xlApp = CreateObject("Excel.Application")
            xlWorkBook = xlApp.Workbooks.Open(SaveFinalTable.FileName)
            xlWorkSheet = xlWorkBook.Worksheets(1)

            If Chart_Ce_La.Series("Ce-La").Points.Count > 0 Then
                AddChartToExcel(xlApp, xlWorkSheet, 1, (DataGridView_Final_Table_Concentration.Rows.Count + 2) * 17, valuesRange("CE_LLI-2")(0), valuesRange("CE_LLI-2")(1), valuesRange("LA_LLI-1")(0), valuesRange("LA_LLI-1")(1), Chart_Ce_La.ChartAreas("ChartArea1").AxisX.Title, Chart_Ce_La.ChartAreas("ChartArea1").AxisY.Title)
            End If
            If Chart_Th_U.Series("U-Th").Points.Count > 0 Then
                AddChartToExcel(xlApp, xlWorkSheet, 420, (DataGridView_Final_Table_Concentration.Rows.Count + 2) * 17, valuesRange("U_LLI-1")(0), valuesRange("U_LLI-1")(1), valuesRange("TH_LLI-2")(0), valuesRange("TH_LLI-2")(1), Chart_Th_U.ChartAreas("ChartArea1").AxisX.Title, Chart_Th_U.ChartAreas("ChartArea1").AxisY.Title)
            End If

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
                System.Diagnostics.Process.Start(SaveFinalTable.FileName)
            End If
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, Me.Text)
            If My.Settings.language = "Русский" Then
                MsgBox("Операция была отменена (ошибка в Form_Final_Table_Concentration.Button_Save_Click)!", MsgBoxStyle.Critical, Me.Text)
            Else
                MsgBox("Operation was cancelled (error in Form_Final_Table_Concentration.Button_Save_Click)!", MsgBoxStyle.Critical, Me.Text)
            End If
            Exit Sub
        End Try
    End Sub

    Private Sub Form_Final_Table_Concentartion_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            ConcForms.TableContentLoad(DataGridView_Final_Table_Concentration, True)

            BuildGraph(Form_Main.xCE141LLI2, Form_Main.yLA140LLI1, "Ce-La", Chart_Ce_La)
            BuildGraph(Form_Main.xNP239LLI1, Form_Main.yPA233LLI2, "U-Th", Chart_Th_U)
            DataGridView_Final_Table_Concentration.ClearSelection()

            If My.Settings.language = "Русский" Then
                Me.Text = "Окончательная таблица концентраций."
                Button_Draw_Graph.Text = "Построить график"
                Button_Save.Text = "Закрыть и сохранить в файл"
                B_Cancel.Text = "Отмена"
            Else
                Me.Text = "Final table of concentration."
                Button_Draw_Graph.Text = "Construct graph"
                Button_Save.Text = "Close and save into file"
                B_Cancel.Text = "Cancel"
            End If
        Catch ex As Exception
            If My.Settings.language = "Русский" Then
                MsgBox("Операция была отменена (ошибка в Form_Final_Table_Concentration.Form_Final_Table_Concentartion_Load)!", MsgBoxStyle.Critical, Me.Text)
            Else
                MsgBox("Operation was cancelled (error in Form_Final_Table_Concentration.Form_Final_Table_Concentartion_Load)!", MsgBoxStyle.Critical, Me.Text)
            End If
            Exit Sub
        End Try

    End Sub

    Private Sub Button_Draw_Graph_Click(sender As System.Object, e As System.EventArgs) Handles Button_Draw_Graph.Click
        Try
            Dim list As New ArrayList
            list = ConcForms.SelectionColumnParse(DataGridView_Final_Table_Concentration)
            BuildGraph(list(0), list(1), list(2), Chart_Ce_La)
        Catch ex As Exception
            If My.Settings.language = "Русский" Then
                MsgBox("Операция была отменена (ошибка в Form_Final_Table_Concentration.Button_Draw_Graph_Click)!", MsgBoxStyle.Critical, Me.Text)
            Else
                MsgBox("Operation was cancelled (error in Form_Final_Table_Concentration.Button_Draw_Graph_Click)!", MsgBoxStyle.Critical, Me.Text)
            End If
            Exit Sub
        End Try
    End Sub

    Private Sub Form_Final_Table_Concentration_FormClosed(sender As System.Object, e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Form_Main.Enabled = True
    End Sub
End Class