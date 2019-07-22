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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DataGridViewForCheckGRS = New System.Windows.Forms.DataGridView()
        Me.BExportCheckTable = New System.Windows.Forms.Button()
        Me.SaveCheckTable = New System.Windows.Forms.SaveFileDialog()
        Me.CheckBoxPer = New System.Windows.Forms.CheckBox()
        Me.LabelPerc = New System.Windows.Forms.Label()
        Me.NumericUpDownPerc = New System.Windows.Forms.NumericUpDown()
        CType(Me.DataGridViewForCheckGRS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownPerc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridViewForCheckGRS
        '
        Me.DataGridViewForCheckGRS.AllowUserToAddRows = False
        Me.DataGridViewForCheckGRS.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        Me.DataGridViewForCheckGRS.Location = New System.Drawing.Point(0, 41)
        Me.DataGridViewForCheckGRS.Name = "DataGridViewForCheckGRS"
        Me.DataGridViewForCheckGRS.ReadOnly = True
        Me.DataGridViewForCheckGRS.RowHeadersVisible = False
        Me.DataGridViewForCheckGRS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewForCheckGRS.Size = New System.Drawing.Size(1183, 470)
        Me.DataGridViewForCheckGRS.TabIndex = 0
        '
        'BExportCheckTable
        '
        Me.BExportCheckTable.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BExportCheckTable.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.BExportCheckTable.Location = New System.Drawing.Point(895, 7)
        Me.BExportCheckTable.Name = "BExportCheckTable"
        Me.BExportCheckTable.Size = New System.Drawing.Size(275, 28)
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
        'CheckBoxPer
        '
        Me.CheckBoxPer.AutoSize = True
        Me.CheckBoxPer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.CheckBoxPer.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.CheckBoxPer.Location = New System.Drawing.Point(12, 12)
        Me.CheckBoxPer.Name = "CheckBoxPer"
        Me.CheckBoxPer.Size = New System.Drawing.Size(269, 20)
        Me.CheckBoxPer.TabIndex = 9
        Me.CheckBoxPer.Text = "Показать только расхождения более"
        Me.CheckBoxPer.UseVisualStyleBackColor = True
        '
        'LabelPerc
        '
        Me.LabelPerc.AutoSize = True
        Me.LabelPerc.Location = New System.Drawing.Point(351, 15)
        Me.LabelPerc.Name = "LabelPerc"
        Me.LabelPerc.Size = New System.Drawing.Size(21, 13)
        Me.LabelPerc.TabIndex = 10
        Me.LabelPerc.Text = ", %"
        '
        'NumericUpDownPerc
        '
        Me.NumericUpDownPerc.Location = New System.Drawing.Point(299, 13)
        Me.NumericUpDownPerc.Name = "NumericUpDownPerc"
        Me.NumericUpDownPerc.Size = New System.Drawing.Size(46, 20)
        Me.NumericUpDownPerc.TabIndex = 11
        Me.NumericUpDownPerc.Value = New Decimal(New Integer() {30, 0, 0, 0})
        '
        'FormCheckGRS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1182, 511)
        Me.Controls.Add(Me.NumericUpDownPerc)
        Me.Controls.Add(Me.LabelPerc)
        Me.Controls.Add(Me.CheckBoxPer)
        Me.Controls.Add(Me.BExportCheckTable)
        Me.Controls.Add(Me.DataGridViewForCheckGRS)
        Me.Name = "FormCheckGRS"
        Me.Text = "Проверка ГРС"
        CType(Me.DataGridViewForCheckGRS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownPerc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridViewForCheckGRS As System.Windows.Forms.DataGridView
    Friend WithEvents BExportCheckTable As System.Windows.Forms.Button
    Friend WithEvents SaveCheckTable As System.Windows.Forms.SaveFileDialog
    Friend WithEvents CheckBoxPer As CheckBox
    Friend WithEvents LabelPerc As Label
    Friend WithEvents NumericUpDownPerc As NumericUpDown
End Class
