﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_GRS_editor
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_GRS_editor))
        Me.DataGridView_GRS_Editor = New System.Windows.Forms.DataGridView()
        Me.SaveFileDialog_Grup_Stand_GRS_Editor = New System.Windows.Forms.SaveFileDialog()
        Me.AutoGRS = New System.Windows.Forms.Button()
        Me.InvSel = New System.Windows.Forms.Button()
        Me.B_Undelete_Last_String = New System.Windows.Forms.Button()
        Me.B_Del_String = New System.Windows.Forms.Button()
        Me.B_Save_GRS = New System.Windows.Forms.Button()
        Me.CheckGRS = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.B_Cancel = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.BLoadGRS = New System.Windows.Forms.Button()
        Me.BChFileForGRSEd = New System.Windows.Forms.Button()
        Me.GRSAddedFileList = New System.Windows.Forms.DataGridView()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.OpenFileDialog_Akt_Stand_Obr_GRS_1 = New System.Windows.Forms.OpenFileDialog()
        Me.OpenGRSFiles = New System.Windows.Forms.OpenFileDialog()
        Me.AutoGRSToolTip = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.DataGridView_GRS_Editor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.GRSAddedFileList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView_GRS_Editor
        '
        Me.DataGridView_GRS_Editor.AllowUserToAddRows = False
        Me.DataGridView_GRS_Editor.AllowUserToDeleteRows = False
        Me.DataGridView_GRS_Editor.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView_GRS_Editor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView_GRS_Editor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView_GRS_Editor.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridView_GRS_Editor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView_GRS_Editor.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridView_GRS_Editor.Location = New System.Drawing.Point(-5, 128)
        Me.DataGridView_GRS_Editor.MultiSelect = False
        Me.DataGridView_GRS_Editor.Name = "DataGridView_GRS_Editor"
        Me.DataGridView_GRS_Editor.ReadOnly = True
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView_GRS_Editor.RowHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridView_GRS_Editor.RowHeadersVisible = False
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.DataGridView_GRS_Editor.RowsDefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridView_GRS_Editor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView_GRS_Editor.Size = New System.Drawing.Size(1229, 684)
        Me.DataGridView_GRS_Editor.TabIndex = 0
        '
        'SaveFileDialog_Grup_Stand_GRS_Editor
        '
        Me.SaveFileDialog_Grup_Stand_GRS_Editor.DefaultExt = "grs"
        Me.SaveFileDialog_Grup_Stand_GRS_Editor.Filter = "Файлы групповых стандартов (*.grs)|*.grs|Все файлы (*.*)|*.*"
        Me.SaveFileDialog_Grup_Stand_GRS_Editor.RestoreDirectory = True
        '
        'AutoGRS
        '
        Me.AutoGRS.Location = New System.Drawing.Point(6, 18)
        Me.AutoGRS.Name = "AutoGRS"
        Me.AutoGRS.Size = New System.Drawing.Size(207, 25)
        Me.AutoGRS.TabIndex = 14
        Me.AutoGRS.Text = "Создать ГРС автоматически"
        Me.AutoGRSToolTip.SetToolTip(Me.AutoGRS, resources.GetString("AutoGRS.ToolTip"))
        Me.AutoGRS.UseVisualStyleBackColor = True
        '
        'InvSel
        '
        Me.InvSel.Location = New System.Drawing.Point(6, 18)
        Me.InvSel.Name = "InvSel"
        Me.InvSel.Size = New System.Drawing.Size(235, 25)
        Me.InvSel.TabIndex = 13
        Me.InvSel.Text = "Инвертировать выделение"
        Me.InvSel.UseVisualStyleBackColor = True
        '
        'B_Undelete_Last_String
        '
        Me.B_Undelete_Last_String.Location = New System.Drawing.Point(6, 49)
        Me.B_Undelete_Last_String.Name = "B_Undelete_Last_String"
        Me.B_Undelete_Last_String.Size = New System.Drawing.Size(235, 25)
        Me.B_Undelete_Last_String.TabIndex = 12
        Me.B_Undelete_Last_String.Text = "Восстановить удалённую строку"
        Me.B_Undelete_Last_String.UseVisualStyleBackColor = True
        '
        'B_Del_String
        '
        Me.B_Del_String.Location = New System.Drawing.Point(6, 83)
        Me.B_Del_String.Name = "B_Del_String"
        Me.B_Del_String.Size = New System.Drawing.Size(235, 25)
        Me.B_Del_String.TabIndex = 11
        Me.B_Del_String.Text = "Удалить строку"
        Me.B_Del_String.UseVisualStyleBackColor = True
        '
        'B_Save_GRS
        '
        Me.B_Save_GRS.Location = New System.Drawing.Point(6, 18)
        Me.B_Save_GRS.Name = "B_Save_GRS"
        Me.B_Save_GRS.Size = New System.Drawing.Size(224, 25)
        Me.B_Save_GRS.TabIndex = 9
        Me.B_Save_GRS.Text = "Cохранить групповой стандарт"
        Me.B_Save_GRS.UseVisualStyleBackColor = True
        '
        'CheckGRS
        '
        Me.CheckGRS.Location = New System.Drawing.Point(6, 49)
        Me.CheckGRS.Name = "CheckGRS"
        Me.CheckGRS.Size = New System.Drawing.Size(207, 25)
        Me.CheckGRS.TabIndex = 15
        Me.CheckGRS.Text = "Проверить стандарт"
        Me.CheckGRS.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.B_Del_String)
        Me.GroupBox1.Controls.Add(Me.B_Undelete_Last_String)
        Me.GroupBox1.Controls.Add(Me.InvSel)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(254, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(248, 118)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Редактирование"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.B_Cancel)
        Me.GroupBox2.Controls.Add(Me.AutoGRS)
        Me.GroupBox2.Controls.Add(Me.CheckGRS)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(508, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(218, 118)
        Me.GroupBox2.TabIndex = 17
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Создание и проверка"
        '
        'B_Cancel
        '
        Me.B_Cancel.Location = New System.Drawing.Point(6, 83)
        Me.B_Cancel.Name = "B_Cancel"
        Me.B_Cancel.Size = New System.Drawing.Size(207, 25)
        Me.B_Cancel.TabIndex = 14
        Me.B_Cancel.Text = "Отмена"
        Me.B_Cancel.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.BLoadGRS)
        Me.GroupBox3.Controls.Add(Me.B_Save_GRS)
        Me.GroupBox3.Controls.Add(Me.BChFileForGRSEd)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(12, 4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(236, 118)
        Me.GroupBox3.TabIndex = 17
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Сохранение и загрузка"
        '
        'BLoadGRS
        '
        Me.BLoadGRS.Location = New System.Drawing.Point(6, 83)
        Me.BLoadGRS.Name = "BLoadGRS"
        Me.BLoadGRS.Size = New System.Drawing.Size(224, 25)
        Me.BLoadGRS.TabIndex = 10
        Me.BLoadGRS.Text = "Загрузить групповой стандарт"
        Me.BLoadGRS.UseVisualStyleBackColor = True
        '
        'BChFileForGRSEd
        '
        Me.BChFileForGRSEd.BackColor = System.Drawing.SystemColors.Control
        Me.BChFileForGRSEd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.BChFileForGRSEd.Location = New System.Drawing.Point(6, 49)
        Me.BChFileForGRSEd.Name = "BChFileForGRSEd"
        Me.BChFileForGRSEd.Size = New System.Drawing.Size(224, 25)
        Me.BChFileForGRSEd.TabIndex = 5
        Me.BChFileForGRSEd.Text = "Выбрать файлы активностей стандартов"
        Me.BChFileForGRSEd.UseVisualStyleBackColor = False
        '
        'GRSAddedFileList
        '
        Me.GRSAddedFileList.AllowUserToAddRows = False
        Me.GRSAddedFileList.AllowUserToDeleteRows = False
        Me.GRSAddedFileList.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GRSAddedFileList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.GRSAddedFileList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.GRSAddedFileList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GRSAddedFileList.Location = New System.Drawing.Point(6, 15)
        Me.GRSAddedFileList.MultiSelect = False
        Me.GRSAddedFileList.Name = "GRSAddedFileList"
        Me.GRSAddedFileList.ReadOnly = True
        Me.GRSAddedFileList.RowHeadersVisible = False
        Me.GRSAddedFileList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GRSAddedFileList.Size = New System.Drawing.Size(480, 97)
        Me.GRSAddedFileList.TabIndex = 18
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.Controls.Add(Me.GRSAddedFileList)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(732, 4)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(492, 118)
        Me.GroupBox4.TabIndex = 19
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Информация о стандартах"
        '
        'OpenFileDialog_Akt_Stand_Obr_GRS_1
        '
        Me.OpenFileDialog_Akt_Stand_Obr_GRS_1.Filter = "Файлы активностей (*.rpt)|*.rpt|Все файлы|*.*"
        Me.OpenFileDialog_Akt_Stand_Obr_GRS_1.Multiselect = True
        Me.OpenFileDialog_Akt_Stand_Obr_GRS_1.RestoreDirectory = True
        '
        'OpenGRSFiles
        '
        Me.OpenGRSFiles.Filter = "Файлы ГРС (*.grs)|*.grs|Все файлы|*.*"
        Me.OpenGRSFiles.RestoreDirectory = True
        '
        'AutoGRSToolTip
        '
        Me.AutoGRSToolTip.AutoPopDelay = 20000
        Me.AutoGRSToolTip.InitialDelay = 500
        Me.AutoGRSToolTip.ReshowDelay = 100
        '
        'Form_GRS_editor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1230, 815)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGridView_GRS_Editor)
        Me.Name = "Form_GRS_editor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Редактор ГРС"
        CType(Me.DataGridView_GRS_Editor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.GRSAddedFileList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView_GRS_Editor As System.Windows.Forms.DataGridView
    Friend WithEvents SaveFileDialog_Grup_Stand_GRS_Editor As System.Windows.Forms.SaveFileDialog
    Friend WithEvents AutoGRS As System.Windows.Forms.Button
    Friend WithEvents InvSel As System.Windows.Forms.Button
    Friend WithEvents B_Undelete_Last_String As System.Windows.Forms.Button
    Friend WithEvents B_Del_String As System.Windows.Forms.Button
    Friend WithEvents B_Save_GRS As System.Windows.Forms.Button
    Friend WithEvents CheckGRS As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GRSAddedFileList As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents BChFileForGRSEd As System.Windows.Forms.Button
    Friend WithEvents BLoadGRS As System.Windows.Forms.Button
    Friend WithEvents B_Cancel As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog_Akt_Stand_Obr_GRS_1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents OpenGRSFiles As System.Windows.Forms.OpenFileDialog
    Friend WithEvents AutoGRSToolTip As ToolTip
End Class