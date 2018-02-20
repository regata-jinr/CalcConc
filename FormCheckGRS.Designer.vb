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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
        Me.DataGridViewForCheckGRS.AllowUserToAddRows = False
        Me.DataGridViewForCheckGRS.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewForCheckGRS.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewForCheckGRS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewForCheckGRS.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewForCheckGRS.Location = New System.Drawing.Point(0, 71)
        Me.DataGridViewForCheckGRS.Name = "DataGridViewForCheckGRS"
        Me.DataGridViewForCheckGRS.ReadOnly = True
        Me.DataGridViewForCheckGRS.RowHeadersVisible = False
        Me.DataGridViewForCheckGRS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewForCheckGRS.Size = New System.Drawing.Size(1183, 440)
        Me.DataGridViewForCheckGRS.TabIndex = 0
        '
        'CheckBoxZVal
        '
        Me.CheckBoxZVal.AutoSize = True
        Me.CheckBoxZVal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.CheckBoxZVal.Location = New System.Drawing.Point(6, 22)
        Me.CheckBoxZVal.Name = "CheckBoxZVal"
        Me.CheckBoxZVal.Size = New System.Drawing.Size(102, 20)
        Me.CheckBoxZVal.TabIndex = 1
        Me.CheckBoxZVal.Text = "Z-значения"
        Me.CheckBoxZVal.UseVisualStyleBackColor = True
        '
        'CheckBoxCaclErr
        '
        Me.CheckBoxCaclErr.AutoSize = True
        Me.CheckBoxCaclErr.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.CheckBoxCaclErr.Location = New System.Drawing.Point(313, 22)
        Me.CheckBoxCaclErr.Name = "CheckBoxCaclErr"
        Me.CheckBoxCaclErr.Size = New System.Drawing.Size(184, 20)
        Me.CheckBoxCaclErr.TabIndex = 2
        Me.CheckBoxCaclErr.Text = "Расчётная погрешность"
        Me.CheckBoxCaclErr.UseVisualStyleBackColor = True
        '
        'CheckBoxPassErr
        '
        Me.CheckBoxPassErr.AutoSize = True
        Me.CheckBoxPassErr.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.CheckBoxPassErr.Location = New System.Drawing.Point(114, 22)
        Me.CheckBoxPassErr.Name = "CheckBoxPassErr"
        Me.CheckBoxPassErr.Size = New System.Drawing.Size(193, 20)
        Me.CheckBoxPassErr.TabIndex = 3
        Me.CheckBoxPassErr.Text = "Паспортная погрешность"
        Me.CheckBoxPassErr.UseVisualStyleBackColor = True
        '
        'HideGroupBox
        '
        Me.HideGroupBox.Controls.Add(Me.CheckBoxZVal)
        Me.HideGroupBox.Controls.Add(Me.CheckBoxPassErr)
        Me.HideGroupBox.Controls.Add(Me.CheckBoxCaclErr)
        Me.HideGroupBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.HideGroupBox.Location = New System.Drawing.Point(12, 4)
        Me.HideGroupBox.Name = "HideGroupBox"
        Me.HideGroupBox.Size = New System.Drawing.Size(514, 61)
        Me.HideGroupBox.TabIndex = 7
        Me.HideGroupBox.TabStop = False
        Me.HideGroupBox.Text = "Скрыть отмеченные значения"
        '
        'BExportCheckTable
        '
        Me.BExportCheckTable.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.BExportCheckTable.Location = New System.Drawing.Point(1039, 4)
        Me.BExportCheckTable.Name = "BExportCheckTable"
        Me.BExportCheckTable.Size = New System.Drawing.Size(131, 61)
        Me.BExportCheckTable.TabIndex = 8
        Me.BExportCheckTable.Text = "Экспорт таблицы проверки в Excel"
        Me.BExportCheckTable.UseVisualStyleBackColor = True
        '
        'SaveCheckTable
        '
        Me.SaveCheckTable.DefaultExt = "xlsx"
        Me.SaveCheckTable.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*"
        Me.SaveCheckTable.RestoreDirectory = True
        '
        'FormCheckGRS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1182, 511)
        Me.Controls.Add(Me.BExportCheckTable)
        Me.Controls.Add(Me.HideGroupBox)
        Me.Controls.Add(Me.DataGridViewForCheckGRS)
        Me.Name = "FormCheckGRS"
        Me.Text = "Проверка ГРС"
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
