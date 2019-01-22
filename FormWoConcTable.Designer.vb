<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormWoConcTable
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DataGridView_WoConcElements = New System.Windows.Forms.DataGridView()
        Me.Button_Save = New System.Windows.Forms.Button()
        Me.LabelTableInterComment = New System.Windows.Forms.Label()
        Me.SaveWoConcTable = New System.Windows.Forms.SaveFileDialog()
        CType(Me.DataGridView_WoConcElements, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView_WoConcElements
        '
        Me.DataGridView_WoConcElements.AllowUserToAddRows = False
        Me.DataGridView_WoConcElements.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView_WoConcElements.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView_WoConcElements.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView_WoConcElements.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView_WoConcElements.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView_WoConcElements.Name = "DataGridView_WoConcElements"
        Me.DataGridView_WoConcElements.ReadOnly = True
        Me.DataGridView_WoConcElements.RowHeadersVisible = False
        Me.DataGridView_WoConcElements.Size = New System.Drawing.Size(961, 393)
        Me.DataGridView_WoConcElements.TabIndex = 10
        '
        'Button_Save
        '
        Me.Button_Save.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Button_Save.Location = New System.Drawing.Point(797, 415)
        Me.Button_Save.Name = "Button_Save"
        Me.Button_Save.Size = New System.Drawing.Size(176, 23)
        Me.Button_Save.TabIndex = 15
        Me.Button_Save.Text = "Закрыть и сохранить в файл"
        Me.Button_Save.UseVisualStyleBackColor = True
        '
        'LabelTableInterComment
        '
        Me.LabelTableInterComment.AutoSize = True
        Me.LabelTableInterComment.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.LabelTableInterComment.Location = New System.Drawing.Point(12, 418)
        Me.LabelTableInterComment.Name = "LabelTableInterComment"
        Me.LabelTableInterComment.Size = New System.Drawing.Size(55, 16)
        Me.LabelTableInterComment.TabIndex = 16
        Me.LabelTableInterComment.Text = "Label1"
        '
        'SaveWoConcTable
        '
        Me.SaveWoConcTable.DefaultExt = "xlsx"
        Me.SaveWoConcTable.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*"
        Me.SaveWoConcTable.RestoreDirectory = True
        '
        'FormWoConcTable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(985, 450)
        Me.Controls.Add(Me.LabelTableInterComment)
        Me.Controls.Add(Me.Button_Save)
        Me.Controls.Add(Me.DataGridView_WoConcElements)
        Me.Name = "FormWoConcTable"
        Me.Text = "FormWoConcTable"
        CType(Me.DataGridView_WoConcElements, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView_WoConcElements As DataGridView
    Friend WithEvents Button_Save As Button
    Friend WithEvents LabelTableInterComment As Label
    Friend WithEvents SaveWoConcTable As SaveFileDialog
End Class
