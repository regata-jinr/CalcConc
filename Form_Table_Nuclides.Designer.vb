<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Table_Nuclides
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
        Me.DataGridView_Table_Nuclides = New System.Windows.Forms.DataGridView()
        Me.B_Save_Table_Nuclides = New System.Windows.Forms.Button()
        Me.B_Cancel = New System.Windows.Forms.Button()
        Me.ButAddNucl = New System.Windows.Forms.Button()
        Me.ButDelNucl = New System.Windows.Forms.Button()
        Me.ButRestoreDefaults = New System.Windows.Forms.Button()
        CType(Me.DataGridView_Table_Nuclides, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView_Table_Nuclides
        '
        Me.DataGridView_Table_Nuclides.AllowUserToAddRows = False
        Me.DataGridView_Table_Nuclides.AllowUserToDeleteRows = False
        Me.DataGridView_Table_Nuclides.AllowUserToResizeColumns = False
        Me.DataGridView_Table_Nuclides.AllowUserToResizeRows = False
        Me.DataGridView_Table_Nuclides.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView_Table_Nuclides.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView_Table_Nuclides.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView_Table_Nuclides.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView_Table_Nuclides.Location = New System.Drawing.Point(3, 3)
        Me.DataGridView_Table_Nuclides.MultiSelect = False
        Me.DataGridView_Table_Nuclides.Name = "DataGridView_Table_Nuclides"
        Me.DataGridView_Table_Nuclides.RowHeadersVisible = False
        Me.DataGridView_Table_Nuclides.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DataGridView_Table_Nuclides.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView_Table_Nuclides.Size = New System.Drawing.Size(274, 692)
        Me.DataGridView_Table_Nuclides.TabIndex = 0
        '
        'B_Save_Table_Nuclides
        '
        Me.B_Save_Table_Nuclides.AutoSize = True
        Me.B_Save_Table_Nuclides.Location = New System.Drawing.Point(3, 701)
        Me.B_Save_Table_Nuclides.Name = "B_Save_Table_Nuclides"
        Me.B_Save_Table_Nuclides.Size = New System.Drawing.Size(274, 23)
        Me.B_Save_Table_Nuclides.TabIndex = 2
        Me.B_Save_Table_Nuclides.Text = "Сохранить таблицу"
        Me.B_Save_Table_Nuclides.UseVisualStyleBackColor = True
        '
        'B_Cancel
        '
        Me.B_Cancel.AutoSize = True
        Me.B_Cancel.Location = New System.Drawing.Point(3, 788)
        Me.B_Cancel.Name = "B_Cancel"
        Me.B_Cancel.Size = New System.Drawing.Size(274, 23)
        Me.B_Cancel.TabIndex = 4
        Me.B_Cancel.Text = "Отмена"
        Me.B_Cancel.UseVisualStyleBackColor = True
        '
        'ButAddNucl
        '
        Me.ButAddNucl.AutoSize = True
        Me.ButAddNucl.Location = New System.Drawing.Point(3, 730)
        Me.ButAddNucl.Name = "ButAddNucl"
        Me.ButAddNucl.Size = New System.Drawing.Size(274, 23)
        Me.ButAddNucl.TabIndex = 5
        Me.ButAddNucl.Text = "Добавить элемент"
        Me.ButAddNucl.UseVisualStyleBackColor = True
        '
        'ButDelNucl
        '
        Me.ButDelNucl.AutoSize = True
        Me.ButDelNucl.Location = New System.Drawing.Point(3, 759)
        Me.ButDelNucl.Name = "ButDelNucl"
        Me.ButDelNucl.Size = New System.Drawing.Size(274, 23)
        Me.ButDelNucl.TabIndex = 6
        Me.ButDelNucl.Text = "Удалить элемент"
        Me.ButDelNucl.UseVisualStyleBackColor = True
        '
        'ButRestoreDefaults
        '
        Me.ButRestoreDefaults.AutoSize = True
        Me.ButRestoreDefaults.Location = New System.Drawing.Point(3, 817)
        Me.ButRestoreDefaults.Name = "ButRestoreDefaults"
        Me.ButRestoreDefaults.Size = New System.Drawing.Size(274, 23)
        Me.ButRestoreDefaults.TabIndex = 7
        Me.ButRestoreDefaults.Text = "Восстановить таблицу"
        Me.ButRestoreDefaults.UseVisualStyleBackColor = True
        '
        'Form_Table_Nuclides
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(280, 845)
        Me.Controls.Add(Me.ButRestoreDefaults)
        Me.Controls.Add(Me.ButDelNucl)
        Me.Controls.Add(Me.ButAddNucl)
        Me.Controls.Add(Me.B_Cancel)
        Me.Controls.Add(Me.B_Save_Table_Nuclides)
        Me.Controls.Add(Me.DataGridView_Table_Nuclides)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "Form_Table_Nuclides"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form_Table_Nuclides"
        CType(Me.DataGridView_Table_Nuclides, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView_Table_Nuclides As System.Windows.Forms.DataGridView
    Friend WithEvents B_Save_Table_Nuclides As System.Windows.Forms.Button
    Friend WithEvents B_Cancel As System.Windows.Forms.Button
    Friend WithEvents ButAddNucl As System.Windows.Forms.Button
    Friend WithEvents ButDelNucl As System.Windows.Forms.Button
    Friend WithEvents ButRestoreDefaults As Button
End Class
