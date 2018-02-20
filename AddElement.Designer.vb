<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddElement
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
        Me.ButAddNuclAndType = New System.Windows.Forms.Button()
        Me.LabelNucl = New System.Windows.Forms.Label()
        Me.LabelType = New System.Windows.Forms.Label()
        Me.ButCancel = New System.Windows.Forms.Button()
        Me.NuclidTextBox = New System.Windows.Forms.TextBox()
        Me.ComboBoxType = New System.Windows.Forms.ComboBox()
        Me.NuclidFormat = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ButAddNuclAndType
        '
        Me.ButAddNuclAndType.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ButAddNuclAndType.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ButAddNuclAndType.Location = New System.Drawing.Point(12, 80)
        Me.ButAddNuclAndType.Name = "ButAddNuclAndType"
        Me.ButAddNuclAndType.Size = New System.Drawing.Size(103, 35)
        Me.ButAddNuclAndType.TabIndex = 0
        Me.ButAddNuclAndType.Text = "Добавить"
        Me.ButAddNuclAndType.UseVisualStyleBackColor = True
        '
        'LabelNucl
        '
        Me.LabelNucl.AutoSize = True
        Me.LabelNucl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.LabelNucl.Location = New System.Drawing.Point(30, 9)
        Me.LabelNucl.Name = "LabelNucl"
        Me.LabelNucl.Size = New System.Drawing.Size(63, 16)
        Me.LabelNucl.TabIndex = 3
        Me.LabelNucl.Text = "Нуклид"
        '
        'LabelType
        '
        Me.LabelType.AutoSize = True
        Me.LabelType.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.LabelType.Location = New System.Drawing.Point(149, 9)
        Me.LabelType.Name = "LabelType"
        Me.LabelType.Size = New System.Drawing.Size(90, 32)
        Me.LabelType.TabIndex = 4
        Me.LabelType.Text = "Тип" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "измерений"
        '
        'ButCancel
        '
        Me.ButCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ButCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ButCancel.Location = New System.Drawing.Point(136, 80)
        Me.ButCancel.Name = "ButCancel"
        Me.ButCancel.Size = New System.Drawing.Size(103, 35)
        Me.ButCancel.TabIndex = 5
        Me.ButCancel.Text = "Отмена"
        Me.ButCancel.UseVisualStyleBackColor = True
        '
        'NuclidTextBox
        '
        Me.NuclidTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.NuclidTextBox.Location = New System.Drawing.Point(15, 53)
        Me.NuclidTextBox.Name = "NuclidTextBox"
        Me.NuclidTextBox.Size = New System.Drawing.Size(100, 21)
        Me.NuclidTextBox.TabIndex = 6
        '
        'ComboBoxType
        '
        Me.ComboBoxType.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ComboBoxType.FormattingEnabled = True
        Me.ComboBoxType.Items.AddRange(New Object() {"-", "КЖИ-1", "КЖИ-2", "ДЖИ-1", "ДЖИ-2"})
        Me.ComboBoxType.Location = New System.Drawing.Point(136, 53)
        Me.ComboBoxType.Name = "ComboBoxType"
        Me.ComboBoxType.Size = New System.Drawing.Size(103, 23)
        Me.ComboBoxType.TabIndex = 7
        Me.ComboBoxType.Text = "-"
        '
        'NuclidFormat
        '
        Me.NuclidFormat.AutoSize = True
        Me.NuclidFormat.Location = New System.Drawing.Point(4, 25)
        Me.NuclidFormat.Name = "NuclidFormat"
        Me.NuclidFormat.Size = New System.Drawing.Size(127, 26)
        Me.NuclidFormat.TabIndex = 8
        Me.NuclidFormat.Text = "Формат:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "[A-Z]{1,2}-\d{2,3}[m]{0,1}" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'AddElement
        '
        Me.AcceptButton = Me.ButAddNuclAndType
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.CancelButton = Me.ButCancel
        Me.ClientSize = New System.Drawing.Size(262, 120)
        Me.ControlBox = False
        Me.Controls.Add(Me.NuclidFormat)
        Me.Controls.Add(Me.ComboBoxType)
        Me.Controls.Add(Me.NuclidTextBox)
        Me.Controls.Add(Me.ButCancel)
        Me.Controls.Add(Me.LabelType)
        Me.Controls.Add(Me.LabelNucl)
        Me.Controls.Add(Me.ButAddNuclAndType)
        Me.Name = "AddElement"
        Me.Text = "Добавление элемента в таблицу нуклидов"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButAddNuclAndType As System.Windows.Forms.Button
    Friend WithEvents LabelNucl As System.Windows.Forms.Label
    Friend WithEvents LabelType As System.Windows.Forms.Label
    Friend WithEvents ButCancel As System.Windows.Forms.Button
    Friend WithEvents NuclidTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ComboBoxType As System.Windows.Forms.ComboBox
    Friend WithEvents NuclidFormat As System.Windows.Forms.Label
End Class
