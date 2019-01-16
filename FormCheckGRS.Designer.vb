<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCheckGRS
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormCheckGRS))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DataGridViewForCheckGRS = New System.Windows.Forms.DataGridView()
        Me.CheckBoxZVal = New System.Windows.Forms.CheckBox()
        Me.CheckBoxCaclErr = New System.Windows.Forms.CheckBox()
        Me.CheckBoxPassErr = New System.Windows.Forms.CheckBox()
        Me.HideGroupBox = New System.Windows.Forms.GroupBox()
        Me.BExportCheckTable = New System.Windows.Forms.Button()
        Me.SaveCheckTable = New System.Windows.Forms.SaveFileDialog()
        CType(Me.DataGridViewForCheckGRS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.HideGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridViewForCheckGRS
        '
        resources.ApplyResources(Me.DataGridViewForCheckGRS, "DataGridViewForCheckGRS")
        Me.DataGridViewForCheckGRS.AllowUserToAddRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewForCheckGRS.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewForCheckGRS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewForCheckGRS.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewForCheckGRS.Name = "DataGridViewForCheckGRS"
        Me.DataGridViewForCheckGRS.ReadOnly = True
        Me.DataGridViewForCheckGRS.RowHeadersVisible = False
        Me.DataGridViewForCheckGRS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        '
        'CheckBoxZVal
        '
        resources.ApplyResources(Me.CheckBoxZVal, "CheckBoxZVal")
        Me.CheckBoxZVal.Name = "CheckBoxZVal"
        Me.CheckBoxZVal.UseVisualStyleBackColor = True
        '
        'CheckBoxCaclErr
        '
        resources.ApplyResources(Me.CheckBoxCaclErr, "CheckBoxCaclErr")
        Me.CheckBoxCaclErr.Name = "CheckBoxCaclErr"
        Me.CheckBoxCaclErr.UseVisualStyleBackColor = True
        '
        'CheckBoxPassErr
        '
        resources.ApplyResources(Me.CheckBoxPassErr, "CheckBoxPassErr")
        Me.CheckBoxPassErr.Name = "CheckBoxPassErr"
        Me.CheckBoxPassErr.UseVisualStyleBackColor = True
        '
        'HideGroupBox
        '
        resources.ApplyResources(Me.HideGroupBox, "HideGroupBox")
        Me.HideGroupBox.Controls.Add(Me.CheckBoxZVal)
        Me.HideGroupBox.Controls.Add(Me.CheckBoxPassErr)
        Me.HideGroupBox.Controls.Add(Me.CheckBoxCaclErr)
        Me.HideGroupBox.Name = "HideGroupBox"
        Me.HideGroupBox.TabStop = False
        '
        'BExportCheckTable
        '
        resources.ApplyResources(Me.BExportCheckTable, "BExportCheckTable")
        Me.BExportCheckTable.Name = "BExportCheckTable"
        Me.BExportCheckTable.UseVisualStyleBackColor = True
        '
        'SaveCheckTable
        '
        Me.SaveCheckTable.DefaultExt = "xlsx"
        resources.ApplyResources(Me.SaveCheckTable, "SaveCheckTable")
        Me.SaveCheckTable.RestoreDirectory = True
        '
        'FormCheckGRS
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.BExportCheckTable)
        Me.Controls.Add(Me.HideGroupBox)
        Me.Controls.Add(Me.DataGridViewForCheckGRS)
        Me.Name = "FormCheckGRS"
        CType(Me.DataGridViewForCheckGRS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HideGroupBox.ResumeLayout(False)
        Me.HideGroupBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridViewForCheckGRS As System.Windows.Forms.DataGridView
    Friend WithEvents CheckBoxZVal As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxCaclErr As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxPassErr As System.Windows.Forms.CheckBox
    Friend WithEvents HideGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents BExportCheckTable As System.Windows.Forms.Button
    Friend WithEvents SaveCheckTable As System.Windows.Forms.SaveFileDialog
End Class
