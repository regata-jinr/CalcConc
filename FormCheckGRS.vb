Public Class FormCheckGRS
    Public Nuclids As List(Of String) = New List(Of String)
    Public UniqElements As List(Of String) = New List(Of String)
    Public CheckGRSSrc As New DataTable
    Private Sub FormCheckGRS_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Try

            Dim Standarts As List(Of String) = New List(Of String)
            For Each row As DataGridViewRow In Form_GRS_editor.DataGridView_GRS_Editor.Rows
                Nuclids.Add((row.Cells(2).Value.ToString))
                Standarts.Add((row.Cells(1).Value.ToString))
            Next

            UniqElements = Nuclids.Distinct.ToList

            Dim CheckGRSSrcKeyColumns(0) As DataColumn
            Dim CheckGRSSrcKeyColumn As New DataColumn()
            CheckGRSSrcKeyColumn.ColumnName = "Key"
            CheckGRSSrcKeyColumns(0) = CheckGRSSrcKeyColumn
            CheckGRSSrc.Columns.Add(CheckGRSSrcKeyColumn)
            CheckGRSSrc.PrimaryKey = CheckGRSSrcKeyColumns
            If My.Settings.language = "English" Then
                CheckGRSSrc.Columns.Add("Имя файла")
                CheckGRSSrc.Columns.Add("Имя стандарта")

                For Each element As String In UniqElements
                    CheckGRSSrc.Columns.Add(element & vbCrLf & "Расчетная концентрация, mg/kg", GetType(Double))
                    CheckGRSSrc.Columns.Add(element & vbCrLf & "Паспортная концентрация, mg/kg", GetType(Double))
                    CheckGRSSrc.Columns.Add(element & vbCrLf & "Расчетная погрешность, %", GetType(Double))
                    CheckGRSSrc.Columns.Add(element & vbCrLf & "Паспортная погрешность, %", GetType(Double))
                    CheckGRSSrc.Columns.Add(element & vbCrLf & "1 - процентное отношение между расч. и пасп. значениями, %", GetType(Double))
                Next
            Else
                CheckGRSSrc.Columns.Add("File Name")
                CheckGRSSrc.Columns.Add("Standart name")
                For Each element As String In UniqElements
                    CheckGRSSrc.Columns.Add(element & vbCrLf & "Calculated concentration, mg/kg", GetType(Double))
                    CheckGRSSrc.Columns.Add(element & vbCrLf & "Passport Concentration, mg/kg", GetType(Double))
                    CheckGRSSrc.Columns.Add(element & vbCrLf & "Calculated error, %", GetType(Double))
                    CheckGRSSrc.Columns.Add(element & vbCrLf & "Passport error, %", GetType(Double))
                    CheckGRSSrc.Columns.Add(element & vbCrLf & "1 - perc. ratio betw. calc. and passp. vals, %", GetType(Double))
                Next
            End If


            For Each row As DataRow In Form_Main.rptTablePeaks.Rows
                Try
                    CheckGRSSrc.Rows.Add(Split(row(0), "_")(0) & "_" & Split(row(0), "_")(1))
                Catch ce As ConstraintException

                Catch ex As Exception
                    MsgBox(ex.ToString, MsgBoxStyle.Critical)
                End Try
            Next

            Dim calcConc, pasConc, calcErr, StdErr, passErr As Double

            For Each grsRow As DataGridViewRow In Form_GRS_editor.DataGridView_GRS_Editor.Rows
                If Not grsRow.DefaultCellStyle.Font.Strikeout Then
                    For Each grsCheckRow As DataRow In CheckGRSSrc.Rows
                        CheckGRSSrc.Rows.Find(grsCheckRow(0))("Имя файла") = Split(grsCheckRow(0), "_")(0)
                        CheckGRSSrc.Rows.Find(grsCheckRow(0))("Имя стандарта") = Split(grsCheckRow(0), "_")(1)
                        Try
                            calcConc = Math.Round(Convert.ToDouble(grsRow.Cells(6).Value) * Convert.ToDouble(Form_Main.rptTablePeaks.Rows.Find(grsCheckRow(0) & "_" & grsRow.Cells(2).Value)("Средне-взвешенная активность, uCi/gram")) / Convert.ToDouble(grsRow.Cells(4).Value), 3)
                            If calcConc <> Double.NaN And calcConc <> Double.PositiveInfinity And calcConc <> Double.NegativeInfinity Then CheckGRSSrc.Rows.Find(grsCheckRow(0))(Split(grsRow.Cells(0).Value, "_")(2) & vbCrLf & "Расчетная концентрация, mg/kg") = calcConc
                        Catch ex As Exception
                        End Try

                        Try
                            pasConc = Convert.ToDouble(Form_Main.grsTable.Rows.Find(grsCheckRow(0) & "_" & grsRow.Cells(2).Value)("paspConc"))
                            If pasConc <> Double.NaN And pasConc <> Double.PositiveInfinity And pasConc <> Double.NegativeInfinity Then CheckGRSSrc.Rows.Find(grsCheckRow(0))(Split(grsRow.Cells(0).Value, "_")(2) & vbCrLf & "Паспортная концентрация, mg/kg") = pasConc
                        Catch ex As Exception
                        End Try

                        Try
                            calcErr = Convert.ToDouble(Form_Main.grsTable.Rows.Find(grsCheckRow(0) & "_" & grsRow.Cells(2).Value)("paspConc"))
                            calcErr = Math.Round(100 * Math.Sqrt((Convert.ToDouble(Form_Main.rptTablePeaks.Rows.Find(grsCheckRow(0) & "_" & grsRow.Cells(2).Value)("Погрешность, %")) / 100) ^ 2 + (Convert.ToDouble(grsRow.Cells(5).Value) / 100) ^ 2 + (Convert.ToDouble(grsRow.Cells(7).Value) / 100) ^ 2), 1)

                            If calcErr <> Double.NaN And calcErr <> Double.PositiveInfinity And calcErr <> Double.NegativeInfinity Then CheckGRSSrc.Rows.Find(grsCheckRow(0))(Split(grsRow.Cells(0).Value, "_")(2) & vbCrLf & "Расчетная погрешность, %") = calcErr
                        Catch ex As Exception
                        End Try

                        Try
                            StdErr = Convert.ToDouble(Form_Main.grsTable.Rows.Find(grsCheckRow(0) & "_" & grsRow.Cells(2).Value)("paspConc"))
                            StdErr = Math.Round(100 * (calcConc - pasConc) / pasConc, 1)
                            If StdErr <> Double.NaN And StdErr <> Double.PositiveInfinity And StdErr <> Double.NegativeInfinity Then
                                CheckGRSSrc.Rows.Find(grsCheckRow(0))(Split(grsRow.Cells(0).Value, "_")(2) & vbCrLf & "1 - процентное отношение между расч. и пасп. значениями, %") = StdErr
                            End If
                        Catch ex As Exception
                        End Try

                        Try
                            passErr = Convert.ToDouble(Form_Main.grsTable.Rows.Find(grsCheckRow(0) & "_" & grsRow.Cells(2).Value)("pasErr"))
                            If passErr <> Double.NaN And passErr <> Double.PositiveInfinity And passErr <> Double.NegativeInfinity Then CheckGRSSrc.Rows.Find(grsCheckRow(0))(Split(grsRow.Cells(0).Value, "_")(2) & vbCrLf & "Паспортная погрешность, %") = passErr
                        Catch ex As Exception
                        End Try
                    Next
                End If
            Next
            DataGridViewForCheckGRS.ColumnHeadersVisible = False
            DataGridViewForCheckGRS.DataSource = CheckGRSSrc
            CheckGrsEditorFill()
            DataGridViewForCheckGRS.ColumnHeadersVisible = True

            CheckBoxPer.Checked = True


        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical)
        End Try
    End Sub

    Public bindsrcForCheckGRS As New BindingSource
    Public NuclStartStopForCheckGRS As New Dictionary(Of String, Integer())

    Sub CheckGrsEditorFill()
        DataGridViewForCheckGRS.Columns(0).Visible = False
        DataGridViewForCheckGRS.Columns(1).Frozen = True
        DataGridViewForCheckGRS.Columns(2).Frozen = True
        Dim nucl As String
        Dim changeFlag As Boolean = False
        For ci = 3 To DataGridViewForCheckGRS.Columns.Count - 1
            nucl = Split(DataGridViewForCheckGRS.Columns(ci).HeaderText, Convert.ToChar(Keys.Enter))(0)
            If nucl <> Split(DataGridViewForCheckGRS.Columns(ci - 1).HeaderText, Convert.ToChar(Keys.Enter))(0) Then changeFlag = Not changeFlag
            If changeFlag Then
                DataGridViewForCheckGRS.Columns(ci).DefaultCellStyle.BackColor = Color.SkyBlue
                If Not NuclStartStopForCheckGRS.ContainsKey(nucl) Then
                    NuclStartStopForCheckGRS.Add(nucl, {ci, ci, ci})
                Else
                    NuclStartStopForCheckGRS(nucl)(1) = ci
                    NuclStartStopForCheckGRS(nucl)(2) = (ci - 2) / 6
                End If
            Else
                If Not NuclStartStopForCheckGRS.ContainsKey(nucl) Then
                    NuclStartStopForCheckGRS.Add(nucl, {ci, ci, ci})
                Else
                    NuclStartStopForCheckGRS(nucl)(1) = ci
                    NuclStartStopForCheckGRS(nucl)(2) = (ci - 2) / 6
                End If
                DataGridViewForCheckGRS.Columns(ci).DefaultCellStyle.BackColor = Color.Moccasin
            End If
            For Each row As DataGridViewRow In DataGridViewForCheckGRS.Rows
                If (String.IsNullOrEmpty(row.Cells(ci).Value.ToString)) Then Continue For
                If Math.Abs(row.Cells(ci).Value) > NumericUpDownPerc.Value And DataGridViewForCheckGRS.Columns(ci).HeaderText.Contains("отношение") Then row.Cells(ci).Style.BackColor = Color.LightCoral
            Next
        Next
    End Sub


    Private Sub CheckBoxPer_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxPer.CheckedChanged
        CheckGrsEditorFill()
        Dim HiddenElements As New ArrayList
        For ci As Integer = 3 To DataGridViewForCheckGRS.Columns.Count - 1
            For Each row As DataGridViewRow In DataGridViewForCheckGRS.Rows
                If (String.IsNullOrEmpty(row.Cells(ci).Value.ToString)) Then Continue For
                If Math.Abs(row.Cells(ci).Value) > NumericUpDownPerc.Value And DataGridViewForCheckGRS.Columns(ci).HeaderText.Contains("отношение") Then HiddenElements.Add(DataGridViewForCheckGRS.Columns(ci).HeaderText.Split(vbCrLf)(0))
            Next
        Next

        If CheckBoxPer.Checked Then
            For ci As Integer = 3 To DataGridViewForCheckGRS.Columns.Count - 1
                If Not HiddenElements.Contains(DataGridViewForCheckGRS.Columns(ci).HeaderText.Split(vbCrLf)(0)) Then DataGridViewForCheckGRS.Columns(ci).Visible = False
            Next
            BExportCheckTable.Enabled = False
        Else
            For ci As Integer = 3 To DataGridViewForCheckGRS.Columns.Count - 1
                DataGridViewForCheckGRS.Columns(ci).Visible = True
            Next
            BExportCheckTable.Enabled = True
        End If
    End Sub


    Private Sub BExportCheckTable_Click(sender As System.Object, e As System.EventArgs) Handles BExportCheckTable.Click
        Try
            SaveCheckTable.FileName = "Standard check table.xlsx"
            If SaveCheckTable.ShowDialog = System.Windows.Forms.DialogResult.Cancel Then 'Эта строчка открывает диалог и сравнивает результат с cancel 
                Exit Sub
            ElseIf System.Windows.Forms.DialogResult.OK Then ' Эта строчка только сравнивает результат с OK 
                Dim nucl, val, nuclForSave As String
                Dim fillMarker As Integer = 0
                Dim qnt As Integer = 0
                'учитываем скрытые

                Dim HiddenColumnsIndex As New ArrayList

                For Each column As DataGridViewColumn In DataGridViewForCheckGRS.Columns
                    If Not column.Visible Then
                        HiddenColumnsIndex.Add(column.Index)
                    End If
                Next

                Dim i As Integer = 0

                For Each elem As Integer In HiddenColumnsIndex
                    DataGridViewForCheckGRS.Columns.RemoveAt(elem - i)
                    i += 1
                Next

                Using wb As New ClosedXML.Excel.XLWorkbook()
                    Dim ws = wb.Worksheets.Add("Standard check table")
                    For coln As Integer = 0 To DataGridViewForCheckGRS.Columns.Count - 1
                        If coln <= 1 Then
                            ws.Cell(3, coln + 1).Value = DataGridViewForCheckGRS.Columns(coln).HeaderText
                            ws.Cell(3, coln + 1).Style.Alignment.Horizontal = ClosedXML.Excel.XLAlignmentHorizontalValues.Center
                            ws.Cell(3, coln + 1).Style.Font.Bold = True
                            ws.Column(coln + 1).Width = 11
                            For rown As Integer = 0 To DataGridViewForCheckGRS.Rows.Count - 1
                                ws.Cell(rown + 4, coln + 1).Value = DataGridViewForCheckGRS(coln, rown).Value
                                ws.Row(rown + 4).Height = 18
                            Next
                        Else
                            nucl = Split(DataGridViewForCheckGRS.Columns(coln).HeaderText, vbCrLf)(0)
                            'приведем вторую букву в названии элемента, если таковая имеется, к нижнему регистру
                            If Split(nucl, "-")(0).Length = 2 Then
                                nuclForSave = Split(nucl, "-")(0).Substring(0, 1) & Split(nucl, "-")(0).Substring(1, 1).ToLower & "-" & Split(nucl, "-")(1)
                            Else
                                nuclForSave = nucl
                            End If
                            val = Split(DataGridViewForCheckGRS.Columns(coln).HeaderText, vbCrLf)(1)

                            ws.Cell(3, coln + 1).Value = val
                            ws.Cell(3, coln + 1).Style.Alignment.Horizontal = ClosedXML.Excel.XLAlignmentHorizontalValues.Center
                            ws.Column(coln + 1).Width = 21
                            ws.Cell(3, coln + 1).Style.Font.Bold = True
                            If nucl <> Split(DataGridViewForCheckGRS.Columns(coln - 1).HeaderText, vbCrLf)(0) Then fillMarker += 1
                            ws.Range(2, NuclStartStopForCheckGRS(nucl)(0) - qnt * (NuclStartStopForCheckGRS(nucl)(2) - 1), 2, NuclStartStopForCheckGRS(nucl)(1) - qnt * NuclStartStopForCheckGRS(nucl)(2)).Cell(1, 1).Value = nuclForSave
                            ws.Range(2, NuclStartStopForCheckGRS(nucl)(0) - qnt * (NuclStartStopForCheckGRS(nucl)(2) - 1), 2, NuclStartStopForCheckGRS(nucl)(1) - qnt * NuclStartStopForCheckGRS(nucl)(2)).Merge()
                            ws.Range(2, NuclStartStopForCheckGRS(nucl)(0) - qnt * (NuclStartStopForCheckGRS(nucl)(2) - 1), 2, NuclStartStopForCheckGRS(nucl)(1) - qnt * NuclStartStopForCheckGRS(nucl)(2)).Style.Font.Bold = True
                            ws.Range(2, NuclStartStopForCheckGRS(nucl)(0) - qnt * (NuclStartStopForCheckGRS(nucl)(2) - 1), 2, NuclStartStopForCheckGRS(nucl)(1) - qnt * NuclStartStopForCheckGRS(nucl)(2)).Style.Alignment.Horizontal = ClosedXML.Excel.XLAlignmentHorizontalValues.Center
                            If fillMarker Mod 2 = 0 Then
                                ws.Range(2, NuclStartStopForCheckGRS(nucl)(0) - qnt * (NuclStartStopForCheckGRS(nucl)(2) - 1), DataGridViewForCheckGRS.Rows.Count + 3, NuclStartStopForCheckGRS(nucl)(1) - qnt * NuclStartStopForCheckGRS(nucl)(2)).Style.Fill.BackgroundColor = ClosedXML.Excel.XLColor.SkyBlue
                            Else
                                ws.Range(2, NuclStartStopForCheckGRS(nucl)(0) - qnt * (NuclStartStopForCheckGRS(nucl)(2) - 1), DataGridViewForCheckGRS.Rows.Count + 3, NuclStartStopForCheckGRS(nucl)(1) - qnt * NuclStartStopForCheckGRS(nucl)(2)).Style.Fill.BackgroundColor = ClosedXML.Excel.XLColor.Moccasin
                            End If

                            For rown As Integer = 0 To DataGridViewForCheckGRS.Rows.Count - 1
                                ws.Cell(rown + 4, coln + 1).Value = DataGridViewForCheckGRS(coln, rown).Value
                            Next
                        End If
                    Next
                    Dim rngbord = ws.Range(1, 1, DataGridViewForCheckGRS.Rows.Count + 3, DataGridViewForCheckGRS.Columns.Count)
                    rngbord.Style.Border.OutsideBorder = ClosedXML.Excel.XLBorderStyleValues.Thin
                    rngbord.Style.Border.InsideBorder = ClosedXML.Excel.XLBorderStyleValues.Thin
                    rngbord.Style.Alignment.Horizontal = ClosedXML.Excel.XLAlignmentHorizontalValues.Center
                    ws.Columns.Style.Alignment.WrapText = True
                    wb.SaveAs(SaveCheckTable.FileName)
                End Using
                Dim result As Integer = MessageBox.Show("Готово! Хотите открыть файл?", "Программа расчета концентраций", MessageBoxButtons.YesNo)
                If result = DialogResult.No Then
                    Exit Sub
                ElseIf result = DialogResult.Yes Then
                    System.Diagnostics.Process.Start(SaveCheckTable.FileName)
                End If
            End If
        Catch ex As IO.IOException
            MsgBox("Файл excel уже открыт. Закройте его.", MsgBoxStyle.Exclamation)
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical)
        End Try
    End Sub


End Class