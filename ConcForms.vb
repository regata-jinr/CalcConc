Imports Excel = Office
Imports ClosedXML.Excel
Imports System.ComponentModel
Imports File = System.IO.File
Module ConcForms
    Sub ElementsSort()
        Try
            Debug.WriteLine("ElementsSort")
            Dim OrderedNulcidList As New ArrayList
            For Each nucl_type As String In Form_Main.NuclidFromTable
                For Each key In Form_Main.TypeEngRu.Keys
                    If Form_Main.GlobalNuclidsForCon.Contains(Split(nucl_type, "_")(0) & "_" & key) Then
                        OrderedNulcidList.Add(Split(nucl_type, "_")(0) & "_" & key)
                    End If
                Next
            Next

            Form_Main.GlobalNuclidsForCon.Clear()
            Form_Main.GlobalNuclidsForCon = OrderedNulcidList
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical)
        End Try
    End Sub

    Sub BuildGraph(xDict As Dictionary(Of String, Double), yDict As Dictionary(Of String, Double), ChartName As String, Chart As System.Windows.Forms.DataVisualization.Charting.Chart)
        Try
            Dim xCount, yCount As Integer
            Dim xValues, yValues, appy As New List(Of Double)
            Dim xMin, yMin, xMax, yMax As Double
            xCount = xDict.Keys.Count
            yCount = yDict.Keys.Count
            If xCount + yCount > 0 Then
                If xCount >= yCount Then
                    For Each elem As String In xDict.Keys
                        Try
                            If xDict(elem) <> 0 And yDict(elem) <> 0 Then
                                xValues.Add(xDict(elem))
                                yValues.Add(yDict(elem))
                            End If
                        Catch ex As KeyNotFoundException
                            '   MsgBox(elem & " key is absent")
                        End Try
                    Next
                ElseIf xCount <= yCount Then
                    For Each elem As String In yDict.Keys
                        Try
                            If xDict(elem) <> 0 And yDict(elem) <> 0 Then
                                xValues.Add(xDict(elem))
                                yValues.Add(yDict(elem))
                            End If
                        Catch ex As KeyNotFoundException
                            '   MsgBox(elem & " key is absent")
                        End Try
                    Next
                End If
            End If

            If xValues.Count + yValues.Count = 0 Then Exit Sub

            Chart.Series.Clear()
            Chart.Series.Add(ChartName)
            Chart.Series(ChartName).MarkerStyle = DataVisualization.Charting.MarkerStyle.Square
            Chart.Series(ChartName).ChartType = DataVisualization.Charting.SeriesChartType.Point
            Chart.Series(ChartName).Points.DataBindXY(xValues, yValues)
            Chart.ChartAreas("ChartArea1").AxisX.Title = Split(ChartName, "-")(0) & ", mg/kg"
            '  Chart.ChartAreas("ChartArea1").AxisX.Name = Split(ChartName, "-")(0) & ", mg/kg)"

            ' Chart.ChartAreas("ChartArea1").AxisY.Name = Split(ChartName, "-")(1) & ", mg/kg)"
            'Try
            Chart.ChartAreas("ChartArea1").AxisY.Title = Split(ChartName, "-")(1) & ", mg/kg"
            xMin = xValues.Min - 0.05 * xValues.Min
            yMin = yValues.Min - 0.05 * yValues.Min
            xMax = xValues.Max + 0.05 * xValues.Max
            yMax = yValues.Max + 0.05 * yValues.Max
            If xMin <= 0 Or yMin <= 0 Or xMax <= 0 Or yMax <= 0 Then
                Chart.ChartAreas("ChartArea1").AxisX.Minimum = Format(xMin, "0.00")
                Chart.ChartAreas("ChartArea1").AxisY.Minimum = Format(yMin, "0.00")
                Chart.ChartAreas("ChartArea1").AxisY.Maximum = Format(yMax, "0.00")
                Chart.ChartAreas("ChartArea1").AxisX.Maximum = Format(xMax, "0.00")
            End If
            Chart.ChartAreas("ChartArea1").AxisX.Interval = Format((xValues.Max - xValues.Min) / 4, "0.00")
                Chart.ChartAreas("ChartArea1").AxisY.Interval = Format((yValues.Max - yValues.Min) / 4, "0.00")

            'МНК
            Dim a, b As Double
            Dim c1 As Double = 0
            Dim c2 As Double = 0
            Dim ru As Double = 0
            Dim rd1 As Double = 0
            Dim rd2 As Double = 0
            Dim n As Integer = xValues.Count

            For i As Integer = 0 To n - 1
                'c1 = sum(xValues(i)*yValues(i))
                c1 += xValues(i) * yValues(i)
                'c2 =  sum(xValues(i)*xValues(i))
                c2 += xValues(i) * xValues(i)
                'Коэффициент корреляции Пирсона http://alglib.sources.ru/statistics/i/pearsonr.gif
                ru += (xValues(i) - xValues.Average) * (yValues(i) - yValues.Average)
                rd1 += (xValues(i) - xValues.Average) * (xValues(i) - xValues.Average)
                rd2 += (yValues(i) - yValues.Average) * (yValues(i) - yValues.Average)
            Next

            Dim r As Double

            r = ru / (Math.Sqrt(rd1) * Math.Sqrt(rd2))
            r = r * r

            a = (n * c1 - xValues.Sum() * yValues.Sum()) / (n * c2 - xValues.Sum() * xValues.Sum())
            b = (yValues.Sum() - a * xValues.Sum()) / n

            For Each xVal As Double In xValues
                appy.Add(b + a * xVal)
            Next
            Chart.Series.Add("TrendLine")
            Chart.Series("TrendLine").MarkerStyle = DataVisualization.Charting.MarkerStyle.None
            Chart.Series("TrendLine").Color = Color.Red
            Chart.Series("TrendLine").ChartType = DataVisualization.Charting.SeriesChartType.Line
            Chart.Series("TrendLine").Points.DataBindXY(xValues, appy)
            Chart.Series("TrendLine").LegendText = "R^2 = " & Format(r, "0.00")

            Catch ex As Exception
                MsgBox(ex.ToString, MsgBoxStyle.Critical)
        End Try
    End Sub

    Function SelectionColumnParse(ByVal datagridview As DataGridView) As ArrayList
        Try
            Dim ans As New ArrayList
            If {1, 2, 3, 4}.Contains(datagridview.SelectedColumns(0).Index) And {1, 2, 3, 4}.Contains(datagridview.SelectedColumns(1).Index) And datagridview.SelectedColumns.Count <> 2 Then
                If Form_Main.language = "russian" Then
                    MsgBox("Выделите два столбца с данными!", MsgBoxStyle.Exclamation, Form_Main.Text)
                ElseIf Form_Main.language = "english" Then
                    MsgBox("Select two columns with data!", MsgBoxStyle.Exclamation, Form_Main.Text)
                End If
                Return Nothing
                Exit Function
            End If

            Dim xDict, yDict As New Dictionary(Of String, Double)
            Dim xind, yind As Integer
            xind = datagridview.SelectedColumns(0).Index
            yind = datagridview.SelectedColumns(1).Index
            For rown As Integer = 0 To datagridview.Rows.Count - 1
                xDict.Add(datagridview(0, rown).Value, datagridview(xind, rown).Value)
                yDict.Add(datagridview(0, rown).Value, datagridview(yind, rown).Value)
            Next
            Dim chartName As String = datagridview.SelectedColumns(1).HeaderText & "---" & datagridview.SelectedColumns(0).HeaderText
            ans.Add(xDict)
            ans.Add(yDict)
            ans.Add(chartName)
            Return ans

        Catch ex As Exception
            MsgBox(ex.ToString(), MsgBoxStyle.Critical)
            If Form_Main.language = "russian" Then
                MsgBox("Операция была отменена (ошибка в Form_Intermediate_Table_Concentration.Button_Draw_Graph_Click)!", MsgBoxStyle.Critical)
            ElseIf Form_Main.language = "english" Then
                MsgBox("Operation was cancelled (error in Form_Intermediate_Table_Concentration.Button_Draw_Graph_Click)!", MsgBoxStyle.Critical)
            End If
            Return Nothing
            Exit Function
        End Try
    End Function

    Public NuclStartStop As New Dictionary(Of String, Integer())
    Public curNucl As String = ""
    Sub TableContentLoad(ByVal DataGridViewTable As DataGridView, ByVal FinalFlag As Boolean)
        Try
            Debug.WriteLine("TableContentLoad: ")
            Dim columnMap As New Dictionary(Of String, Integer)
            Dim nucl, type, conFileName, elemName As String
            ElementsSort()

            'todo: change to lang dictionary
            DataGridViewTable.Columns.Add("sample", "Имя образца")
            DataGridViewTable.Columns(0).SortMode = DataGridViewColumnSortMode.NotSortable
            columnMap.Add("sample", 0)
            DataGridViewTable.Columns.Add("SLI-1", "SLI-1")
            DataGridViewTable.Columns(1).SortMode = DataGridViewColumnSortMode.NotSortable
            columnMap.Add("SLI-1", 1)
            DataGridViewTable.Columns.Add("SLI-2", "SLI-2")
            DataGridViewTable.Columns(2).SortMode = DataGridViewColumnSortMode.NotSortable
            columnMap.Add("SLI-2", 2)
            DataGridViewTable.Columns.Add("LLI-1", "LLI-1")
            DataGridViewTable.Columns(3).SortMode = DataGridViewColumnSortMode.NotSortable
            columnMap.Add("LLI-1", 3)
            DataGridViewTable.Columns.Add("LLI-2", "LLI-2")
            DataGridViewTable.Columns(4).SortMode = DataGridViewColumnSortMode.NotSortable
            columnMap.Add("LLI-2", 4)

            Dim i As Integer = 0
            Dim k As Integer = 0
            Dim ti As Integer = 0
            Dim nameOfColumn As String

            'Dim TypeLang As New Dictionary(Of String, String)
            'TypeLang.Add("SLI-1", "КЖИ-1")
            'TypeLang.Add("SLI-2", "КЖИ-2")
            'TypeLang.Add("LLI-1", "ДЖИ-1")
            'TypeLang.Add("LLI-2", "ДЖИ-2")
            'TypeLang.Add("КЖИ-1", "SLI-1")
            'TypeLang.Add("КЖИ-2", "SLI-2")
            'TypeLang.Add("ДЖИ-1", "LLI-1")
            'TypeLang.Add("ДЖИ-2", "LLI-2")
            Debug.WriteLine("Filling content in tables: ")
            For Each nucl_type As String In Form_Main.GlobalNuclidsForCon

                nucl = Split(nucl_type, "_")(0)
                type = Split(nucl_type, "_")(1)

                If FinalFlag Then
                    '  If nucl = "SB-122" Then Continue For
                    If Not Form_Main.NuclidFromTable.Contains(nucl_type) Then Continue For
                    Debug.WriteLine(nucl_type)
                    If Form_Main.excp.ContainsKey(nucl.ToString) Then
                        nucl = Form_Main.excp(nucl)
                    Else
                        nucl = Split(nucl, "-")(0)
                    End If
                End If

                Try
                    nameOfColumn = nucl & vbCrLf & "Conc, mg/kg" & vbCrLf & type
                    Debug.WriteLine("nameOfColumn " & nameOfColumn)
                    DataGridViewTable.Columns.Add(nameOfColumn, nameOfColumn)
                    columnMap.Add(nameOfColumn, 3 * i + 5)
                    DataGridViewTable.Columns(3 * i + 5).SortMode = DataGridViewColumnSortMode.NotSortable
                    nameOfColumn = nucl & vbCrLf & "Err, %" & vbCrLf & type
                    DataGridViewTable.Columns.Add(nameOfColumn, nameOfColumn)
                    columnMap.Add(nameOfColumn, 3 * i + 6)
                    DataGridViewTable.Columns(3 * i + 6).SortMode = DataGridViewColumnSortMode.NotSortable
                    nameOfColumn = nucl & vbCrLf & "MDC, mg/kg" & vbCrLf & type
                    DataGridViewTable.Columns.Add(nameOfColumn, nameOfColumn)
                    columnMap.Add(nameOfColumn, 3 * i + 7)
                    DataGridViewTable.Columns(3 * i + 7).SortMode = DataGridViewColumnSortMode.NotSortable
                    If i <> 0 And nucl <> Split(DataGridViewTable.Columns(3 * (i - 1) + 5).HeaderText, vbCrLf)(0) Then k += 1
                    If k Mod 2 = 0 Then
                        DataGridViewTable.Columns(3 * i + 5).DefaultCellStyle.BackColor = Color.MediumTurquoise
                        DataGridViewTable.Columns(3 * i + 6).DefaultCellStyle.BackColor = Color.MediumTurquoise
                        DataGridViewTable.Columns(3 * i + 7).DefaultCellStyle.BackColor = Color.MediumTurquoise
                        If Not NuclStartStop.ContainsKey(nucl) Then
                            NuclStartStop.Add(nucl, {3 * i + 5, 3 * i + 7})
                        Else
                            NuclStartStop(nucl)(1) = 3 * i + 7
                        End If
                    Else
                        If Not NuclStartStop.ContainsKey(nucl) Then
                            NuclStartStop.Add(nucl, {3 * i + 5, 3 * i + 7})
                        Else
                            NuclStartStop(nucl)(1) = 3 * i + 7
                        End If
                        DataGridViewTable.Columns(3 * i + 5).DefaultCellStyle.BackColor = Color.LightSalmon
                        DataGridViewTable.Columns(3 * i + 6).DefaultCellStyle.BackColor = Color.LightSalmon
                        DataGridViewTable.Columns(3 * i + 7).DefaultCellStyle.BackColor = Color.LightSalmon
                    End If
                    i += 1
                Catch ex As DuplicateNameException
                    MsgBox(ex.ToString)
                End Try
            Next

            DataGridViewTable.SelectionMode = DataGridViewSelectionMode.FullColumnSelect
            For Each elem As String In Form_Main.elements
                DataGridViewTable.Rows.Add(elem)
            Next

            Dim conc, err, lim As Decimal
            Dim rown As Integer
            For Each key As String In Form_Main.conDict.Keys

                nucl = Split(key, "_")(3)
                type = Split(key, "_")(2)

                If FinalFlag Then
                    If Not Form_Main.NuclidFromTable.Contains(nucl & "_" & type) Then Continue For
                    If Form_Main.excp.Keys.Contains(nucl) Then
                        nucl = Form_Main.excp(nucl)
                    Else
                        nucl = Split(nucl, "-")(0)
                    End If
                End If
                elemName = Split(key, "_")(1)
                conFileName = Split(key, "_")(0)
                Debug.WriteLine(key & " parse into " & "|" & conFileName & "|" & elemName & "|" & nucl & "_" & type)
                rown = Form_Main.rowMap(elemName)
                Try
                    conc = Double.Parse(Form_Main.conDict(key)(1).ToString.Replace(".", ","), System.Globalization.NumberStyles.Any)
                    err = Math.Ceiling(Double.Parse(Form_Main.conDict(key)(2).ToString.Replace(".", ","), System.Globalization.NumberStyles.Any))
                    lim = Double.Parse(Form_Main.conDict(key)(3).ToString.Replace(".", ","), System.Globalization.NumberStyles.Any)
                    Debug.WriteLine("conc err lim: " & "|" & conc & "|" & err & "|" & lim)
                Catch ex As OverflowException
                    MsgBox("Perhaps NaN in file: " & conFileName)
                    Form_Intermediate_Table_Concentration.Close()
                    Form_Final_Table_Concentration.Close()
                    Form_Main.Show()
                    Exit Sub
                End Try
                Try
                    curNucl = nucl
                    DataGridViewTable(columnMap(type), rown).Value = System.IO.Path.GetFileName(conFileName)
                    DataGridViewTable(columnMap(nucl & vbCrLf & "Conc, mg/kg" & vbCrLf & type), rown).Value = Rounding(conc, 0.01)
                    DataGridViewTable(columnMap(nucl & vbCrLf & "Err, %" & vbCrLf & type), rown).Value = Math.Ceiling(err)
                    DataGridViewTable(columnMap(nucl & vbCrLf & "MDC, mg/kg" & vbCrLf & type), rown).Value = Rounding(lim, 0.01)
                Catch keyNF As KeyNotFoundException
                    Debug.WriteLine(keyNF.ToString)
                    Dim result As Integer = MessageBox.Show($"Вероятно этот элемент {curNucl} из файла {conFileName} не надйен в таблице нуклидов. Вы можете добавить его самостоятельно в таблицу нуклидов (будьте осторожны это может повлиять на сортировку в промежуточной и окончательной таблицах) или нажать ok. В этом случае он будет пропущен.", "Крах программы расчета концентраций", MessageBoxButtons.OKCancel)
                    If result = DialogResult.Cancel Then
                        Application.Restart()
                    ElseIf result = DialogResult.OK Then
                    End If
                End Try
            Next

            DataGridViewTable.Columns(0).Frozen = True
            '  DataGridViewTable.Columns(2).Frozen = True
            DataGridViewTable.ClearSelection()
            DataGridViewTable.Sort(DataGridViewTable.Columns(0), ListSortDirection.Ascending)
            'Catch keyNF As KeyNotFoundException
            '    Debug.WriteLine(keyNF.ToString)
            '    Dim result As Integer = MessageBox.Show("Вероятно этот элемент " & curNucl & " не надйен в таблице нуклидов.", "Крах программы расчета концентраций", MessageBoxButtons.OKCancel)
            '    If result = DialogResult.Cancel Then
            '        Application.Restart()
            '    ElseIf result = DialogResult.OK Then
            '    End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Sub AddChartToExcel(ByVal xlApp As Object, xlWorkSheet As Object, ByVal xpos As Double, ByVal ypos As Double, xRangeStart As String, xRangeFinish As String, yRangeStart As String, yRangeFinish As String, xName As String, yName As String)
        Try
            Dim XRange As Object
            Dim YRange As Object
            Dim URange As Object
            Dim xlChart As Object

            xlChart = xlWorkSheet.ChartObjects.Add(xpos, ypos, 400, 200).Chart
            xlChart.ChartType = Excel.XlChartType.xlXYScatter
            xlChart.HasLegend = False


            XRange = xlWorkSheet.Range(xRangeStart, xRangeFinish)
            YRange = xlWorkSheet.Range(yRangeStart, yRangeFinish)
            URange = xlApp.Union(XRange, YRange)

            xlChart.SetSourceData(Source:=URange, PlotBy:=Office.XlRowCol.xlColumns)
            xlChart.SeriesCollection.NewSeries()
            xlChart.SeriesCollection(1).Name = xName + "-" + yName
            xlChart.SeriesCollection(1).XValues = xlWorkSheet.Name & "!" & xRangeStart & ":" & xRangeFinish
            xlChart.SeriesCollection(1).Values = xlWorkSheet.Name & "!" & yRangeStart & ":" & yRangeFinish
            xlChart.Axes(Excel.XlAxisType.xlValue).HasTitle = True
            xlChart.Axes(Excel.XlAxisType.xlValue).AxisTitle.Caption = yName
            xlChart.Axes(Excel.XlAxisType.xlValue).AxisTitle.Font.Name = "Arial Cyr"
            xlChart.Axes(Excel.XlAxisType.xlValue).AxisTitle.Font.Size = 10
            'xlChart.Axes(Excel.XlAxisType.xlValue).MinimumScaleIsAuto = True
            ' xlChart.Axes(Excel.XlAxisType.xlValue).MaximumScaleIsAuto = True

            xlChart.Axes(Excel.XlAxisType.xlCategory).HasTitle = True
            xlChart.Axes(Excel.XlAxisType.xlCategory).AxisTitle.Caption = xName
            xlChart.Axes(Excel.XlAxisType.xlCategory).AxisTitle.Font.Name = "Arial Cyr"
            xlChart.Axes(Excel.XlAxisType.xlCategory).AxisTitle.Font.Size = 10
            ' xlChart.Axes(Excel.XlAxisType.xlCategory).MinimumScaleIsAuto = True
            'xlChart.Axes(Excel.XlAxisType.xlCategory).MaximumScaleIsAuto = True

            xlChart.SeriesCollection(1).Trendlines.Add()
            xlChart.SeriesCollection(1).Trendlines(1).DisplayRSquared = 1
            xlChart.SeriesCollection(1).Trendlines(1).DataLabel.Left = xpos + 80

        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical)
            xlApp.Quit()
        End Try
    End Sub

    Function SaveToExcel(ByVal DataGridViewTable As DataGridView, ByVal SaveDialog As SaveFileDialog, ByVal FinalTable As Boolean) As Dictionary(Of String, String())
        Try
            '  Form_Main.SaveTablConcElemPromezh_ToolStripMenuItem.Enabled = True
            If FinalTable Then
                SaveDialog.FileName = "finalTable.xlsx"
            Else
                SaveDialog.FileName = "tempTable.xlsx"
            End If

            If SaveDialog.ShowDialog = System.Windows.Forms.DialogResult.Cancel Then ' Эта строчка открывает диалог и сравнивает результат с cancel 

                Return Nothing
                Exit Function
            ElseIf System.Windows.Forms.DialogResult.OK Then ' Эта строчка только сравнивает результат с OK 
                Using wb As New ClosedXML.Excel.XLWorkbook()
                    Dim ws = wb.Worksheets.Add("1")
                    If FinalTable Then
                        ws.Name = "table_conc_elem_final"
                    Else
                        ws.Name = "table_conc_elem_interim"
                    End If

                    Dim nucl, val, type, nuclForSave As String
                    Dim countType As Integer
                    Dim fillMarker As Integer = 0

                    Dim GraphHeader As New ArrayList
                    If FinalTable Then
                        GraphHeader.Add("LA" & vbCrLf & "Conc, mg/kg" & vbCrLf & "LLI-1")
                        GraphHeader.Add("CE" & vbCrLf & "Conc, mg/kg" & vbCrLf & "LLI-2")
                        GraphHeader.Add("TH" & vbCrLf & "Conc, mg/kg" & vbCrLf & "LLI-2")
                        GraphHeader.Add("U" & vbCrLf & "Conc, mg/kg" & vbCrLf & "LLI-1")
                    Else
                        GraphHeader.Add("NA-24" & vbCrLf & "Conc, mg/kg" & vbCrLf & "SLI-2")
                        GraphHeader.Add("NA-24" & vbCrLf & "Conc, mg/kg" & vbCrLf & "LLI-1")
                        GraphHeader.Add("SB-122" & vbCrLf & "Conc, mg/kg" & vbCrLf & "LLI-1")
                        GraphHeader.Add("SB-124" & vbCrLf & "Conc, mg/kg" & vbCrLf & "LLI-2")
                        GraphHeader.Add("LA-140" & vbCrLf & "Conc, mg/kg" & vbCrLf & "LLI-1")
                        GraphHeader.Add("CE-141" & vbCrLf & "Conc, mg/kg" & vbCrLf & "LLI-2")
                        GraphHeader.Add("PA-233" & vbCrLf & "Conc, mg/kg" & vbCrLf & "LLI-2")
                        GraphHeader.Add("NP-239" & vbCrLf & "Conc, mg/kg" & vbCrLf & "LLI-1")
                    End If
                    Dim valuesRange As New Dictionary(Of String, String())
                    Dim RangeStart, RangeFinish As String
                    For coln As Integer = 0 To DataGridViewTable.Columns.Count - 1
                        If coln <= 4 Then
                            ws.Range(2, coln + 1, 3, coln + 1).Cell(1, 1).Value = DataGridViewTable.Columns(coln).HeaderText
                            ws.Range(2, coln + 1, 3, coln + 1).Merge()
                            ws.Range(2, coln + 1, 3, coln + 1).Style.Alignment.Horizontal = ClosedXML.Excel.XLAlignmentHorizontalValues.Center
                        Else
                            'добавим информацию, которая понадобиться для построения графика
                            nucl = Split(DataGridViewTable.Columns(coln).HeaderText, vbCrLf)(0)
                            'приведем вторую букву в названии элемента, если таковая имеется, к нижнему регистру
                            If Not FinalTable Then
                                If Split(nucl, "-")(0).Length = 2 Then
                                    nuclForSave = Split(nucl, "-")(0).Substring(0, 1) & Split(nucl, "-")(0).Substring(1, 1).ToLower & "-" & Split(nucl, "-")(1)
                                Else
                                    nuclForSave = nucl
                                End If
                            Else
                                If nucl.Length = 2 Then
                                    nuclForSave = nucl.Substring(0, 1) & nucl.Substring(1, 1).ToLower
                                Else
                                    nuclForSave = nucl
                                End If
                            End If
                            val = Split(DataGridViewTable.Columns(coln).HeaderText, vbCrLf)(1)
                            type = Split(DataGridViewTable.Columns(coln).HeaderText, vbCrLf)(2)

                            If GraphHeader.Contains(DataGridViewTable.Columns(coln).HeaderText) Then
                                RangeStart = ws.Cell(4, coln + 1).Address.ToStringFixed
                                RangeFinish = ws.Cell(DataGridViewTable.Rows.Count + 3, coln + 1).Address.ToStringFixed
                                valuesRange.Add(nucl & "_" & type, {RangeStart, RangeFinish})
                            End If

                            'Nuclid
                            ws.Range(1, coln + 1, 1, coln + 1).Cell(1, 1).Value = nuclForSave
                            ws.Range(1, NuclStartStop(nucl)(0) + 1, 1, NuclStartStop(nucl)(1) + 1).Merge()
                            ws.Range(1, NuclStartStop(nucl)(0) + 1, 1, NuclStartStop(nucl)(1) + 1).Style.Alignment.Horizontal = ClosedXML.Excel.XLAlignmentHorizontalValues.Center
                            ws.Range(1, NuclStartStop(nucl)(0) + 1, 1, NuclStartStop(nucl)(1) + 1).Style.Font.Bold = True
                            If fillMarker Mod 2 = 0 Then
                                ws.Range(1, NuclStartStop(nucl)(0) + 1, DataGridViewTable.Rows.Count + 3, NuclStartStop(nucl)(1) + 1).Style.Fill.BackgroundColor = ClosedXML.Excel.XLColor.SkyBlue
                            Else
                                ws.Range(1, NuclStartStop(nucl)(0) + 1, DataGridViewTable.Rows.Count + 3, NuclStartStop(nucl)(1) + 1).Style.Fill.BackgroundColor = ClosedXML.Excel.XLColor.Moccasin
                            End If
                            If nucl <> Split(DataGridViewTable.Columns(coln - 1).HeaderText, vbCrLf)(0) Then fillMarker += 1
                            'Nuclid

                            'Type
                            countType = (NuclStartStop(nucl)(1) + 1 - NuclStartStop(nucl)(0)) / 3
                            For typec As Integer = 0 To countType
                                ws.Range(2, coln + 1, 2, coln + 1).Cell(1, 1).Value = type
                                ws.Range(2, NuclStartStop(nucl)(0) + 2 * typec + typec + 1, 2, NuclStartStop(nucl)(0) + (typec + 1) * 2 + typec + 1).Merge()
                                ws.Range(2, NuclStartStop(nucl)(0) + 2 * typec + typec + 1, 2, NuclStartStop(nucl)(0) + (typec + 1) * 2 + typec + 1).Style.Font.Bold = True
                            Next
                            'Type

                            'ValueName
                            ws.Range(3, coln + 1, 3, coln + 1).Cell(1, 1).Value = val
                            ws.Range(3, coln + 1, 3, coln + 1).Style.Font.Bold = True
                            'ValueName

                        End If
                        For rown As Integer = 0 To DataGridViewTable.Rows.Count - 1
                            If coln > 4 Then
                                If DataGridViewTable(coln, rown).Value = 0 Then Continue For
                                ws.Cell(rown + 4, coln + 1).Value = DataGridViewTable(coln, rown).Value
                            Else
                                ws.Cell(rown + 4, coln + 1).Value = "'" & DataGridViewTable(coln, rown).Value ' "'" нужен из-за того, что такие имена как 2710-1 без апострофа он переводит в дату
                            End If

                        Next
                    Next

                    'для закрашивания ячеек, в которых концентрация меньше предела 
                    'TODO: интегрировать в циклы при сохранении

                    For coln As Integer = 0 To DataGridViewTable.Columns.Count - 1
                        For rown As Integer = 0 To DataGridViewTable.Rows.Count - 1
                            If coln > 4 And coln < DataGridViewTable.ColumnCount - 3 Then
                                If Split(DataGridViewTable.Columns(coln).HeaderText, vbCrLf)(1) = "Conc, mg/kg" And DataGridViewTable(coln, rown).Value <= DataGridViewTable(coln + 2, rown).Value And DataGridViewTable(coln, rown).Value <> 0 Then

                                    ws.Cell(rown + 4, coln + 1).Style.Fill.BackgroundColor = ClosedXML.Excel.XLColor.Bittersweet
                                End If
                            End If
                        Next
                    Next

                    Dim rngbord = ws.Range(1, 1, DataGridViewTable.Rows.Count + 3, DataGridViewTable.Columns.Count)
                    rngbord.Style.Border.OutsideBorder = ClosedXML.Excel.XLBorderStyleValues.Thin
                    rngbord.Style.Border.InsideBorder = ClosedXML.Excel.XLBorderStyleValues.Thin
                    rngbord.Style.Alignment.Horizontal = ClosedXML.Excel.XLAlignmentHorizontalValues.Center
                    ws.Columns().Style.Alignment.WrapText = True
                    ws.Columns().AdjustToContents()
                    wb.SaveAs(SaveDialog.FileName)
                    Return valuesRange
                End Using
            Else
                Return Nothing
            End If

        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical)
            Return Nothing
            Exit Function
        End Try
    End Function

    Function Rounding(num As Decimal, prec As Decimal) As Decimal
        Dim dig As Integer = 0
        If num <> 0 Then
            While 1 - Math.Round(num, dig) / num >= prec
                dig += 1
            End While
        End If
        Return Math.Round(num, dig)
    End Function

End Module