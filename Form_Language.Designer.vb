<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Language
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
        Me.RadioButton_Russian = New System.Windows.Forms.RadioButton()
        Me.RadioButton_English = New System.Windows.Forms.RadioButton()
        Me.Button_Close = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'RadioButton_Russian
        '
        Me.RadioButton_Russian.AutoSize = True
        Me.RadioButton_Russian.Location = New System.Drawing.Point(12, 12)
        Me.RadioButton_Russian.Name = "RadioButton_Russian"
        Me.RadioButton_Russian.Size = New System.Drawing.Size(66, 17)
        Me.RadioButton_Russian.TabIndex = 0
        Me.RadioButton_Russian.Text = "русский"
        Me.RadioButton_Russian.UseVisualStyleBackColor = True
        '
        'RadioButton_English
        '
        Me.RadioButton_English.AutoSize = True
        Me.RadioButton_English.Location = New System.Drawing.Point(12, 35)
        Me.RadioButton_English.Name = "RadioButton_English"
        Me.RadioButton_English.Size = New System.Drawing.Size(84, 17)
        Me.RadioButton_English.TabIndex = 1
        Me.RadioButton_English.Text = "английский"
        Me.RadioButton_English.UseVisualStyleBackColor = True
        '
        'Button_Close
        '
        Me.Button_Close.Location = New System.Drawing.Point(35, 71)
        Me.Button_Close.Name = "Button_Close"
        Me.Button_Close.Size = New System.Drawing.Size(75, 23)
        Me.Button_Close.TabIndex = 2
        Me.Button_Close.Text = "Закрыть"
        Me.Button_Close.UseVisualStyleBackColor = True
        '
        'Form_Language
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(146, 100)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button_Close)
        Me.Controls.Add(Me.RadioButton_English)
        Me.Controls.Add(Me.RadioButton_Russian)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form_Language"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Язык"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RadioButton_Russian As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton_English As System.Windows.Forms.RadioButton
    Friend WithEvents Button_Close As System.Windows.Forms.Button
End Class
