Public Class Form_GRS_editor
    Private Sub Form_GRS_editor_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        DataGridView_GRS_Editor.DataSource = Nothing
        Form_Main.grsTable.Clear()
        Form_Main.rptTablePeaks.Clear()
        Form_Main.refTable.Clear()
        Form_Main.rptTableMda.Clear()
        Form_Main.FileInfoDict.Clear()
        Form_Main.Enabled = True
        loadFlag = False
    End Sub

    Private Sub B_Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_Cancel.Click
        DataGridView_GRS_Editor.DataSource = Nothing
        Form_Main.grsTable.Clear()
        Form_Main.rptTablePeaks.Clear()
        Form_Main.refTable.Clear()
        Form_Main.rptTableMda.Clear()
        Form_Main.FileInfoDict.Clear()
        loadFlag = False
        Form_Main.Enabled = True
        Me.Close()
    End Sub

    Private Sub B_Save_GRS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_Save_GRS.Click
        Try
            Debug.WriteLine("Save GRS:")
            Dim formatDict As New Dictionary(Of Integer, String)
            formatDict.Add(1, "")
            formatDict.Add(2, "")
            formatDict.Add(3, "0.000")
            formatDict.Add(4, "0.00E+00")
            formatDict.Add(5, "0.00")
            formatDict.Add(6, "0.00E+00")
            formatDict.Add(7, "0.00")
            formatDict.Add(8, "0.00")

            SaveFileDialog_Grup_Stand_GRS_Editor.FileName = Form_Main.GRSName.Substring(0, Form_Main.GRSName.Length - 1) & ".GRS"
            'SaveFileDialog_Grup_Stand_GRS_Editor.InitialDirectory = "C:\GENIE2K\CONFILES")
            If SaveFileDialog_Grup_Stand_GRS_Editor.ShowDialog = System.Windows.Forms.DialogResult.Cancel Then ' Эта строчка открывает диалог и сравнивает результат с cancel 
                Exit Sub
            ElseIf System.Windows.Forms.DialogResult.OK Then ' Эта строчка только сравнивает результат с OK 

                Dim outputString As String = ""
                Dim FilesNames As String = ""

                For row As Integer = 0 To GRSAddedFileList.Rows.Count - 1
                    FilesNames = FilesNames & GRSAddedFileList.Rows(row).Cells(0).Value.ToString & ";"
                Next

                Using sw As New IO.StreamWriter(SaveFileDialog_Grup_Stand_GRS_Editor.FileName)
                    sw.WriteLine("Сводная таблица активностей стандартных образцов: " & FilesNames & vbCrLf)
                    ' my version sw.WriteLine("Имя образца	Нуклид	Достоверность идентификации	Средне-взвешенная активность, uCi/gram	Погрешность, %	Паспортная концентрация, mg/kg	Паспортная погрешность, %	Средне-квадратичная погрешность, %")
                    'old version
                    sw.WriteLine("имя	нуклид	достов.	средневзвешен.	погр.,	концентр.,	погреш.,")
                    sw.WriteLine("образца		идент.	активность,	%	mg/kg	%")
                    sw.WriteLine("			uCi/gram" & vbCrLf)

                    For i As Integer = 0 To DataGridView_GRS_Editor.Rows.Count - 1
                        For j As Integer = 1 To DataGridView_GRS_Editor.Columns.Count - 3
                            If DataGridView_GRS_Editor.Rows(i).Visible <> False Then outputString = outputString & vbTab & Format(DataGridView_GRS_Editor.Rows(i).Cells(j).Value, formatDict.Item(j)).Replace(",", ".")
                        Next
                        If outputString <> "" Then
                            sw.WriteLine(outputString.Substring(1, outputString.Length - 1))
                            Debug.WriteLine(outputString)
                        End If
                        outputString = ""
                    Next
                End Using
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
            If My.Settings.language = "Русский" Then
                MsgBox("Операция была отменена (ошибка в Form_GRS_editor.B_Save_GRS_Click)!", MsgBoxStyle.Critical, Me.Text)
            Else
                MsgBox("Operation was cancelled (error in Form_GRS_editor.B_Save_GRS_Click)!", MsgBoxStyle.Critical, Me.Text)
            End If
            Exit Sub
        End Try
    End Sub

    Public RowList As New ArrayList()
    Public IndList As New ArrayList()

    Private Sub B_Del_String_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_Del_String.Click
        Try
            Dim First_Displayed_String As Integer
            First_Displayed_String = DataGridView_GRS_Editor.FirstDisplayedScrollingRowIndex
            If DataGridView_GRS_Editor.SelectedRows.Count = 0 Or DataGridView_GRS_Editor.SelectedRows.Count > 1 Then
                If My.Settings.language = "Русский" Then
                    MsgBox("Выберите строку!", MsgBoxStyle.Exclamation, Me.Text)
                Else
                    MsgBox("Select row!", MsgBoxStyle.Exclamation, Me.Text)
                End If
                Exit Sub
            End If

            Dim selInd As Integer

            If DataGridView_GRS_Editor.Rows.Count - 1 = 0 Then
                MsgBox("Это последняя строка", MsgBoxStyle.Exclamation, Me.Text)
                Exit Sub
            End If

            selInd = DataGridView_GRS_Editor.Rows.IndexOf(DataGridView_GRS_Editor.SelectedRows(0))

            RowList.Add(Form_Main.grsTable.Rows.Find(DataGridView_GRS_Editor.SelectedRows(0).Cells(0).Value.ToString).ItemArray)
            IndList.Add(selInd)
            Form_Main.grsTable.Rows.Remove(Form_Main.grsTable.Rows.Find(DataGridView_GRS_Editor.SelectedRows(0).Cells(0).Value.ToString))
            If selInd = DataGridView_GRS_Editor.Rows.Count - 1 Or selInd = DataGridView_GRS_Editor.Rows.Count Then selInd = 0
            DataGridView_GRS_Editor.CurrentCell = DataGridView_GRS_Editor.Item(1, selInd)
            B_Undelete_Last_String.Enabled = True

            'GrsEditorFill()

            DataGridView_GRS_Editor.Focus()

            DataGridView_GRS_Editor_SelectionChanged(sender, e)

        Catch ex As Exception
            MsgBox(ex.ToString)
            If My.Settings.language = "Русский" Then
                MsgBox("Операция была отменена (ошибка в Form_GRS_editor.B_Del_String_Click)!", MsgBoxStyle.Critical, Me.Text)
            Else
                MsgBox("Operation was cancelled (error in Form_GRS_editor.B_Del_String_Click)!", MsgBoxStyle.Critical, Me.Text)
            End If
            Exit Sub
        End Try
    End Sub

    Private Sub B_Undelete_Last_String_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_Undelete_Last_String.Click
        Try
            Dim nrow = Form_Main.grsTable.NewRow
            nrow.ItemArray = RowList(RowList.Count - 1)
            Form_Main.grsTable.Rows.InsertAt(nrow, IndList(IndList.Count - 1))
            RowList.RemoveAt(RowList.Count - 1)
            IndList.RemoveAt(IndList.Count - 1)
            GrsEditorFill()
            If RowList.Count = 0 Then B_Undelete_Last_String.Enabled = False

            '  GrsView()
            DataGridView_GRS_Editor.Focus()



        Catch ex As Exception
            MsgBox(ex.ToString)
            If My.Settings.language = "Русский" Then
                MsgBox("Операция была отменена (ошибка в Form_GRS_editor.B_Undelete_Last_String_Click)!", MsgBoxStyle.Critical, Me.Text)
            Else
                MsgBox("Operation was cancelled (error in Form_GRS_editor.B_Undelete_Last_String_Click)!", MsgBoxStyle.Critical, Me.Text)
            End If
            Exit Sub
        End Try
    End Sub

    Public StdErrDict As New Dictionary(Of String, ArrayList)
    Public PaspConcErrDict As New Dictionary(Of String, ArrayList)
    Public PaspConcDict As New Dictionary(Of String, ArrayList)
    Public ValuesDict As New Dictionary(Of String, ArrayList)

    Public Sub GrsSort()
        Try
            Dim needRow() As DataRow
            For Each elem As String In Form_Main.uniqElemForGRS
                StdErrDict.Add(elem, New ArrayList)
                PaspConcErrDict.Add(elem, New ArrayList)
                PaspConcDict.Add(elem, New ArrayList)

                For Each row As DataRow In Form_Main.grsTable.Rows
                    If elem = row(2) Then
                        StdErrDict(elem).Add(row(8))
                        PaspConcErrDict(elem).Add(row(7))
                        PaspConcDict(elem).Add(row(6))
                    End If
                Next
            Next

            Dim flagDict As New Dictionary(Of String, Integer)
            Dim str As String = ""

            For Each elem As String In Form_Main.uniqElemForGRS
                'Debug.WriteLine(elem)
                If PaspConcErrDict(elem).ToArray.Min < 30 Then
                    needRow = Form_Main.grsTable.Select("nucl = '" & elem & "' AND pasErr < 30 AND stdEr > '" & (StdErrDict(elem).ToArray.Min - 0.05 * StdErrDict(elem).ToArray.Min).ToString & "' AND stdEr < '" & (StdErrDict(elem).ToArray.Min + 0.05 * StdErrDict(elem).ToArray.Min).ToString & "'", "paspConc DESC")
                Else
                    needRow = Form_Main.grsTable.Select("nucl = '" & elem & "'", "stdEr ASC")
                End If

                If elem = "MG-27" Then
                    str = Form_Main.grsTable.Select("nucl = 'AL-28'", "paspConc ASC")(0)(1)
                    needRow = Form_Main.grsTable.Select("nucl = 'MG-27' AND refname = '" & str & "'")
                End If

                For i As Integer = 0 To needRow.Length - 1
                    Form_Main.grsTable.Rows.Find(needRow(0)(0))(10) = 1
                    Exit For
                Next

            Next

            Dim view As DataView = Form_Main.grsTable.DefaultView
            view.Sort = "NuclSort ASC,nucl, sortFlag DESC"
            bindsrc.DataSource = view

        Catch ex As Exception
            '   MsgBox(ex.ToString)
            '  Exit Sub
        End Try
    End Sub
    Public bindsrc As New BindingSource
    Sub GrsEditorFill()

        GrsSort()
        DataGridView_GRS_Editor.DataSource = Form_Main.grsTable


        If My.Settings.language = "Русский" Then
            DataGridView_GRS_Editor.Columns(1).HeaderText = "Имя стандарта"
            DataGridView_GRS_Editor.Columns(2).HeaderText = "Нуклид"
            DataGridView_GRS_Editor.Columns(3).HeaderText = "Достоверность идентификации"
            DataGridView_GRS_Editor.Columns(4).HeaderText = "Средне- взвешенная активность, uCi/gram"
            DataGridView_GRS_Editor.Columns(5).HeaderText = "Погрешность, %"
            DataGridView_GRS_Editor.Columns(6).HeaderText = "Паспортная концентрация, mg/kg"
            DataGridView_GRS_Editor.Columns(7).HeaderText = "Паспортная погрешность, %"
            DataGridView_GRS_Editor.Columns(8).HeaderText = "'Средне-квадратичная погрешность', %"
        Else
            DataGridView_GRS_Editor.Columns(1).HeaderText = "Standart name"
            DataGridView_GRS_Editor.Columns(2).HeaderText = "Nuclide name"
            DataGridView_GRS_Editor.Columns(3).HeaderText = "Nuclide ID confidence"
            DataGridView_GRS_Editor.Columns(4).HeaderText = "Wt mean activity, uCi/gram"
            DataGridView_GRS_Editor.Columns(5).HeaderText = "Uncertainty, %"
            DataGridView_GRS_Editor.Columns(6).HeaderText = "Passport concentration, mg/kg"
            DataGridView_GRS_Editor.Columns(7).HeaderText = "Passport uncertainty, %"
            DataGridView_GRS_Editor.Columns(8).HeaderText = "Mean-square error, %"
        End If
        DataGridView_GRS_Editor.Columns(0).Visible = False
        DataGridView_GRS_Editor.Columns(4).DefaultCellStyle.Format = "0.00E+00"
        DataGridView_GRS_Editor.Columns(5).DefaultCellStyle.Format = "0.00"
        DataGridView_GRS_Editor.Columns(6).DefaultCellStyle.Format = "0.00E+00"
        DataGridView_GRS_Editor.Columns(7).DefaultCellStyle.Format = "0.00"
        DataGridView_GRS_Editor.Columns(8).DefaultCellStyle.Format = "0.00"
        ' DataGridView_GRS_Editor.Columns(DataGridView_GRS_Editor.Columns.Count - 3).Visible = False
        DataGridView_GRS_Editor.Columns(DataGridView_GRS_Editor.Columns.Count - 2).Visible = False
        DataGridView_GRS_Editor.Columns(DataGridView_GRS_Editor.Columns.Count - 1).Visible = False

        For ci = 0 To DataGridView_GRS_Editor.Columns.Count - 1
            DataGridView_GRS_Editor.Columns(ci).SortMode = DataGridViewColumnSortMode.NotSortable
        Next

        Dim ColorList As New ArrayList
        ColorList.Add(Color.MediumTurquoise)
        ColorList.Add(Color.LightSalmon)

        Dim i, k As Integer
        k = 0
        DataGridView_GRS_Editor.Rows(0).DefaultCellStyle.BackColor = ColorList(k Mod 2)
        DataGridView_GRS_Editor.Rows(0).DefaultCellStyle.Font = New Font("Arial", 11, FontStyle.Regular)
        For i = 1 To DataGridView_GRS_Editor.Rows.Count - 1
            DataGridView_GRS_Editor.Rows(i).DefaultCellStyle.Font = New Font("Arial", 11, FontStyle.Strikeout)
            If DataGridView_GRS_Editor.Rows(i).Cells(2).Value <> DataGridView_GRS_Editor.Rows(i - 1).Cells(2).Value Then
                DataGridView_GRS_Editor.Rows(i).DefaultCellStyle.Font = New Font("Arial", 11, FontStyle.Regular)
                k += 1
            End If



            If DataGridView_GRS_Editor.Rows(i).Cells(6).Value <> 0 Then
                DataGridView_GRS_Editor.Rows(i).DefaultCellStyle.BackColor = ColorList(k Mod 2)
            Else
                DataGridView_GRS_Editor.Rows(i).DefaultCellStyle.BackColor = Color.Gainsboro
            End If



        Next
    End Sub


    Private Sub Form_GRS_editor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        B_Del_String.Enabled = False
        B_Save_GRS.Enabled = False
        B_Undelete_Last_String.Enabled = False
        CheckGRS.Enabled = False
        InvSel.Enabled = False
        AutoGRS.Enabled = False
        Form_Main.LocalizedForm()

        Try
            Dim column1 As New DataGridViewTextBoxColumn
            Dim column2 As New DataGridViewTextBoxColumn
            Dim column3 As New DataGridViewTextBoxColumn
            Dim column4 As New DataGridViewTextBoxColumn
            Dim column5 As New DataGridViewTextBoxColumn
            Dim column6 As New DataGridViewTextBoxColumn

            GRSAddedFileList.Columns.Add(column1)
            GRSAddedFileList.Columns.Add(column2)
            GRSAddedFileList.Columns.Add(column3)
            GRSAddedFileList.Columns.Add(column4)
            GRSAddedFileList.Columns.Add(column5)
            GRSAddedFileList.Columns.Add(column6)
            If My.Settings.language = "Русский" Then
                GRSAddedFileList.Columns(0).HeaderText = "Имя файла стандарта"
                GRSAddedFileList.Columns(1).HeaderText = "Дата создания отчёта"
                GRSAddedFileList.Columns(2).HeaderText = "Описание"
                GRSAddedFileList.Columns(3).HeaderText = "Код"
                GRSAddedFileList.Columns(4).HeaderText = "Тип"
                GRSAddedFileList.Columns(5).HeaderText = "Геометрия"
            Else
                GRSAddedFileList.Columns(0).HeaderText = "File name"
                GRSAddedFileList.Columns(1).HeaderText = "Created date"
                GRSAddedFileList.Columns(2).HeaderText = "Description"
                GRSAddedFileList.Columns(3).HeaderText = "Code"
                GRSAddedFileList.Columns(4).HeaderText = "Tpye"
                GRSAddedFileList.Columns(5).HeaderText = "Geometry"
            End If


            loadFlag = True

            AutoGRSToolTip.Show("", AutoGRS)

        Catch ex As Exception
            MsgBox(ex.ToString)
            Exit Sub
        End Try
    End Sub

    Private Sub DataGridView_GRS_Editor_ColumnHeaderMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView_GRS_Editor.ColumnHeaderMouseClick
        Try
            If DataGridView_GRS_Editor.RowCount > 0 Then
                DataGridView_GRS_Editor.FirstDisplayedScrollingRowIndex = 0
                For i = 0 To DataGridView_GRS_Editor.RowCount - 1
                    DataGridView_GRS_Editor.Rows.Item(i).Selected = False
                Next
            End If
        Catch ex As Exception
            If My.Settings.language = "Русский" Then
                MsgBox("Операция была отменена (ошибка в Form_GRS_editor.DataGridView_GRS_Editor_ColumnHeaderMouseClick)!", MsgBoxStyle.Critical, Me.Text)
            Else
                MsgBox("Operation was cancelled (error in Form_GRS_editor.DataGridView_GRS_Editor_ColumnHeaderMouseClick)!", MsgBoxStyle.Critical, Me.Text)
            End If
            Exit Sub
        End Try
    End Sub

    Private Sub InvSel_Click(sender As System.Object, e As System.EventArgs) Handles InvSel.Click
        Try
            If DataGridView_GRS_Editor.SelectedRows.Count = 0 Or DataGridView_GRS_Editor.SelectedRows.Count > 1 Then
                If My.Settings.language = "Русский" Then
                    MsgBox("Выберите одну строку!", MsgBoxStyle.Exclamation, Me.Text)
                Else
                    MsgBox("Select one row!", MsgBoxStyle.Exclamation, Me.Text)
                End If
                Exit Sub
            End If

            DataGridView_GRS_Editor.SelectedRows(0).DefaultCellStyle.Font = New Font("Arial", 11, FontStyle.Regular)

            For Each row As DataGridViewRow In DataGridView_GRS_Editor.Rows
                If DataGridView_GRS_Editor.SelectedRows(0).Cells(2).Value = row.Cells(2).Value And (Not row.DefaultCellStyle.Font.Strikeout) And DataGridView_GRS_Editor.SelectedRows(0).Cells(0).Value <> row.Cells(0).Value Then
                    row.DefaultCellStyle.Font = New Font("Arial", 11, FontStyle.Strikeout)
                End If
            Next

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub AutoGRS_Click(sender As System.Object, e As System.EventArgs) Handles AutoGRS.Click
        Try
            DataGridView_GRS_Editor.ClearSelection()
            DataGridView_GRS_Editor.CurrentCell = Nothing

            For Each row As DataGridViewRow In DataGridView_GRS_Editor.Rows
                If row.DefaultCellStyle.Font.Strikeout Then row.Visible = False
            Next

            B_Del_String.Enabled = False

        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical)
            Exit Sub
        End Try
    End Sub

    Private Sub CheckGRS_Click(sender As System.Object, e As System.EventArgs) Handles CheckGRS.Click
        FormCheckGRS.Show()
    End Sub

    Public loadFlag As Boolean = False

    Private Sub DataGridView_GRS_Editor_SelectionChanged(sender As Object, e As System.EventArgs) Handles DataGridView_GRS_Editor.SelectionChanged
        Try
            If loadFlag Then
                If DataGridView_GRS_Editor.SelectedRows(0).DefaultCellStyle.Font.Strikeout Then
                    InvSel.Enabled = True
                Else
                    InvSel.Enabled = False
                End If
            End If
        Catch ex As Exception
            'MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub BChFileForGRSEd_Click(sender As System.Object, e As System.EventArgs) Handles BChFileForGRSEd.Click
        Try

            GRSAddedFileList.Rows.Clear()
            GRSAddedFileList.Refresh()
            DataGridView_GRS_Editor.DataSource = Nothing
            Form_Main.grsTable.Clear()
            Form_Main.rptTablePeaks.Clear()
            Form_Main.refTable.Clear()
            Form_Main.rptTableMda.Clear()
            Form_Main.FileInfoDict.Clear()
            StdErrDict.Clear()
            PaspConcErrDict.Clear()
            PaspConcDict.Clear()


            Me.Text = "Редактор ГРС"

            If OpenFileDialog_Akt_Stand_Obr_GRS_1.ShowDialog = System.Windows.Forms.DialogResult.Cancel Then
                MsgBox("Файлы активностей стандартных образцов не выбраны!", MsgBoxStyle.Exclamation, Me.Text)
                Exit Sub
            Else
                Dim filePath As String = System.IO.Path.GetDirectoryName(OpenFileDialog_Akt_Stand_Obr_GRS_1.FileName)

                For Each fileName In OpenFileDialog_Akt_Stand_Obr_GRS_1.SafeFileNames
                    If fileName.Contains("_") Then
                        MsgBox(fileName & "  " & "Имя файла не должно содержать нижнее подчеркивание.", MsgBoxStyle.Critical)
                        Exit Sub
                    End If
                Next


                Me.Text = Me.Text & ":   " & filePath

                Form_Main.GRSName = ""
                Dim ans As String()
                Dim fileLabels As String = ""
                For Each fileName In OpenFileDialog_Akt_Stand_Obr_GRS_1.FileNames
                    ans = Form_Main.DataFromRPT(fileName, True)
                    fileLabels += Split(fileName, "\")(Split(fileName, "\").Length - 1) & ";"
                Next

                'Dim dataView As New DataView(Form_Main.rptTablePeaks)
                'dataView.Sort = "nuclSort ASC"
                'Form_Main.rptTablePeaks = dataView.ToTable

                Form_Main.GrsSrc(Form_Main.grsTable)
                'GrsView()

                For Each elem As String In Form_Main.FileInfoDict.Keys
                    GRSAddedFileList.Rows.Add(elem, Split(Form_Main.FileInfoDict.Item(elem)(0), ":")(1).Trim.Substring(0, 10), Split(Form_Main.FileInfoDict.Item(elem)(1), ":")(1).Trim, Split(Form_Main.FileInfoDict.Item(elem)(2), ":")(1).Trim, Split(Form_Main.FileInfoDict.Item(elem)(3), ":")(1).Trim, Split(Form_Main.FileInfoDict.Item(elem)(4), ":")(1).Trim)

                Next

                GrsEditorFill()

                B_Del_String.Enabled = True
                B_Save_GRS.Enabled = True
                ' B_Undelete_Last_String.Enabled = False
                CheckGRS.Enabled = True
                '  InvSel.Enabled = False
                AutoGRS.Enabled = True


            End If
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub BLoadGRS_Click(sender As System.Object, e As System.EventArgs) Handles BLoadGRS.Click
        Try

            '  MsgBox("Возможность будет добавлена в следующих версиях.")
            If OpenGRSFiles.ShowDialog = System.Windows.Forms.DialogResult.Cancel Then
                MsgBox("Файл группового стандарта не выбран!", MsgBoxStyle.Exclamation, Me.Text)
                Exit Sub
            Else

                Dim filePath As String = System.IO.Path.GetDirectoryName(OpenGRSFiles.FileName)

                If OpenGRSFiles.SafeFileName.Contains("_") Then
                    MsgBox(OpenGRSFiles.SafeFileName & "  " & "Имя файла не должно содержать нижнее подчеркивание.", MsgBoxStyle.Critical)
                    Exit Sub
                End If

                Me.Text = Me.Text & ":   " & System.IO.Path.GetFileName(OpenGRSFiles.FileName)

                Form_Main.GRSName = System.IO.Path.GetFileName(OpenGRSFiles.FileName)

                DataGridView_GRS_Editor.DataSource = Form_Main.DataFromGrs(OpenGRSFiles.FileName)

                'GrsView()
                GrsEditorFill()

                B_Del_String.Enabled = True
                B_Save_GRS.Enabled = True
                ' B_Undelete_Last_String.Enabled = False
                CheckGRS.Enabled = True
                '  InvSel.Enabled = False
                AutoGRS.Enabled = True

            End If
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical)
        End Try
    End Sub

End Class