<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_GRS_editor))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
        resources.ApplyResources(Me.DataGridView_GRS_Editor, "DataGridView_GRS_Editor")
        Me.DataGridView_GRS_Editor.AllowUserToAddRows = False
        Me.DataGridView_GRS_Editor.AllowUserToDeleteRows = False
        Me.DataGridView_GRS_Editor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView_GRS_Editor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView_GRS_Editor.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView_GRS_Editor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView_GRS_Editor.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView_GRS_Editor.MultiSelect = False
        Me.DataGridView_GRS_Editor.Name = "DataGridView_GRS_Editor"
        Me.DataGridView_GRS_Editor.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView_GRS_Editor.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView_GRS_Editor.RowHeadersVisible = False
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.DataGridView_GRS_Editor.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView_GRS_Editor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.AutoGRSToolTip.SetToolTip(Me.DataGridView_GRS_Editor, resources.GetString("DataGridView_GRS_Editor.ToolTip"))
        '
        'SaveFileDialog_Grup_Stand_GRS_Editor
        '
        Me.SaveFileDialog_Grup_Stand_GRS_Editor.DefaultExt = "grs"
        resources.ApplyResources(Me.SaveFileDialog_Grup_Stand_GRS_Editor, "SaveFileDialog_Grup_Stand_GRS_Editor")
        Me.SaveFileDialog_Grup_Stand_GRS_Editor.RestoreDirectory = True
        '
        'AutoGRS
        '
        resources.ApplyResources(Me.AutoGRS, "AutoGRS")
        Me.AutoGRS.Name = "AutoGRS"
        Me.AutoGRSToolTip.SetToolTip(Me.AutoGRS, resources.GetString("AutoGRS.ToolTip"))
        Me.AutoGRS.UseVisualStyleBackColor = True
        '
        'InvSel
        '
        resources.ApplyResources(Me.InvSel, "InvSel")
        Me.InvSel.Name = "InvSel"
        Me.AutoGRSToolTip.SetToolTip(Me.InvSel, resources.GetString("InvSel.ToolTip"))
        Me.InvSel.UseVisualStyleBackColor = True
        '
        'B_Undelete_Last_String
        '
        resources.ApplyResources(Me.B_Undelete_Last_String, "B_Undelete_Last_String")
        Me.B_Undelete_Last_String.Name = "B_Undelete_Last_String"
        Me.AutoGRSToolTip.SetToolTip(Me.B_Undelete_Last_String, resources.GetString("B_Undelete_Last_String.ToolTip"))
        Me.B_Undelete_Last_String.UseVisualStyleBackColor = True
        '
        'B_Del_String
        '
        resources.ApplyResources(Me.B_Del_String, "B_Del_String")
        Me.B_Del_String.Name = "B_Del_String"
        Me.AutoGRSToolTip.SetToolTip(Me.B_Del_String, resources.GetString("B_Del_String.ToolTip"))
        Me.B_Del_String.UseVisualStyleBackColor = True
        '
        'B_Save_GRS
        '
        resources.ApplyResources(Me.B_Save_GRS, "B_Save_GRS")
        Me.B_Save_GRS.Name = "B_Save_GRS"
        Me.AutoGRSToolTip.SetToolTip(Me.B_Save_GRS, resources.GetString("B_Save_GRS.ToolTip"))
        Me.B_Save_GRS.UseVisualStyleBackColor = True
        '
        'CheckGRS
        '
        resources.ApplyResources(Me.CheckGRS, "CheckGRS")
        Me.CheckGRS.Name = "CheckGRS"
        Me.AutoGRSToolTip.SetToolTip(Me.CheckGRS, resources.GetString("CheckGRS.ToolTip"))
        Me.CheckGRS.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        resources.ApplyResources(Me.GroupBox1, "GroupBox1")
        Me.GroupBox1.Controls.Add(Me.B_Del_String)
        Me.GroupBox1.Controls.Add(Me.B_Undelete_Last_String)
        Me.GroupBox1.Controls.Add(Me.InvSel)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.TabStop = False
        Me.AutoGRSToolTip.SetToolTip(Me.GroupBox1, resources.GetString("GroupBox1.ToolTip"))
        '
        'GroupBox2
        '
        resources.ApplyResources(Me.GroupBox2, "GroupBox2")
        Me.GroupBox2.Controls.Add(Me.B_Cancel)
        Me.GroupBox2.Controls.Add(Me.AutoGRS)
        Me.GroupBox2.Controls.Add(Me.CheckGRS)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.TabStop = False
        Me.AutoGRSToolTip.SetToolTip(Me.GroupBox2, resources.GetString("GroupBox2.ToolTip"))
        '
        'B_Cancel
        '
        resources.ApplyResources(Me.B_Cancel, "B_Cancel")
        Me.B_Cancel.Name = "B_Cancel"
        Me.AutoGRSToolTip.SetToolTip(Me.B_Cancel, resources.GetString("B_Cancel.ToolTip"))
        Me.B_Cancel.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        resources.ApplyResources(Me.GroupBox3, "GroupBox3")
        Me.GroupBox3.Controls.Add(Me.BLoadGRS)
        Me.GroupBox3.Controls.Add(Me.B_Save_GRS)
        Me.GroupBox3.Controls.Add(Me.BChFileForGRSEd)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.TabStop = False
        Me.AutoGRSToolTip.SetToolTip(Me.GroupBox3, resources.GetString("GroupBox3.ToolTip"))
        '
        'BLoadGRS
        '
        resources.ApplyResources(Me.BLoadGRS, "BLoadGRS")
        Me.BLoadGRS.Name = "BLoadGRS"
        Me.AutoGRSToolTip.SetToolTip(Me.BLoadGRS, resources.GetString("BLoadGRS.ToolTip"))
        Me.BLoadGRS.UseVisualStyleBackColor = True
        '
        'BChFileForGRSEd
        '
        resources.ApplyResources(Me.BChFileForGRSEd, "BChFileForGRSEd")
        Me.BChFileForGRSEd.BackColor = System.Drawing.SystemColors.Control
        Me.BChFileForGRSEd.Name = "BChFileForGRSEd"
        Me.AutoGRSToolTip.SetToolTip(Me.BChFileForGRSEd, resources.GetString("BChFileForGRSEd.ToolTip"))
        Me.BChFileForGRSEd.UseVisualStyleBackColor = False
        '
        'GRSAddedFileList
        '
        resources.ApplyResources(Me.GRSAddedFileList, "GRSAddedFileList")
        Me.GRSAddedFileList.AllowUserToAddRows = False
        Me.GRSAddedFileList.AllowUserToDeleteRows = False
        Me.GRSAddedFileList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.GRSAddedFileList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.GRSAddedFileList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GRSAddedFileList.MultiSelect = False
        Me.GRSAddedFileList.Name = "GRSAddedFileList"
        Me.GRSAddedFileList.ReadOnly = True
        Me.GRSAddedFileList.RowHeadersVisible = False
        Me.GRSAddedFileList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.AutoGRSToolTip.SetToolTip(Me.GRSAddedFileList, resources.GetString("GRSAddedFileList.ToolTip"))
        '
        'GroupBox4
        '
        resources.ApplyResources(Me.GroupBox4, "GroupBox4")
        Me.GroupBox4.Controls.Add(Me.GRSAddedFileList)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.TabStop = False
        Me.AutoGRSToolTip.SetToolTip(Me.GroupBox4, resources.GetString("GroupBox4.ToolTip"))
        '
        'OpenFileDialog_Akt_Stand_Obr_GRS_1
        '
        resources.ApplyResources(Me.OpenFileDialog_Akt_Stand_Obr_GRS_1, "OpenFileDialog_Akt_Stand_Obr_GRS_1")
        Me.OpenFileDialog_Akt_Stand_Obr_GRS_1.Multiselect = True
        Me.OpenFileDialog_Akt_Stand_Obr_GRS_1.RestoreDirectory = True
        '
        'OpenGRSFiles
        '
        resources.ApplyResources(Me.OpenGRSFiles, "OpenGRSFiles")
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
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGridView_GRS_Editor)
        Me.Name = "Form_GRS_editor"
        Me.AutoGRSToolTip.SetToolTip(Me, resources.GetString("$this.ToolTip"))
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
