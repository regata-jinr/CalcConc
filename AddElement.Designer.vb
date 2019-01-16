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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddElement))
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
        resources.ApplyResources(Me.ButAddNuclAndType, "ButAddNuclAndType")
        Me.ButAddNuclAndType.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ButAddNuclAndType.Name = "ButAddNuclAndType"
        Me.ButAddNuclAndType.UseVisualStyleBackColor = True
        '
        'LabelNucl
        '
        resources.ApplyResources(Me.LabelNucl, "LabelNucl")
        Me.LabelNucl.Name = "LabelNucl"
        '
        'LabelType
        '
        resources.ApplyResources(Me.LabelType, "LabelType")
        Me.LabelType.Name = "LabelType"
        '
        'ButCancel
        '
        resources.ApplyResources(Me.ButCancel, "ButCancel")
        Me.ButCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ButCancel.Name = "ButCancel"
        Me.ButCancel.UseVisualStyleBackColor = True
        '
        'NuclidTextBox
        '
        resources.ApplyResources(Me.NuclidTextBox, "NuclidTextBox")
        Me.NuclidTextBox.Name = "NuclidTextBox"
        '
        'ComboBoxType
        '
        resources.ApplyResources(Me.ComboBoxType, "ComboBoxType")
        Me.ComboBoxType.FormattingEnabled = True
        Me.ComboBoxType.Items.AddRange(New Object() {resources.GetString("ComboBoxType.Items"), resources.GetString("ComboBoxType.Items1"), resources.GetString("ComboBoxType.Items2"), resources.GetString("ComboBoxType.Items3"), resources.GetString("ComboBoxType.Items4")})
        Me.ComboBoxType.Name = "ComboBoxType"
        '
        'NuclidFormat
        '
        resources.ApplyResources(Me.NuclidFormat, "NuclidFormat")
        Me.NuclidFormat.Name = "NuclidFormat"
        '
        'AddElement
        '
        Me.AcceptButton = Me.ButAddNuclAndType
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.CancelButton = Me.ButCancel
        Me.ControlBox = False
        Me.Controls.Add(Me.NuclidFormat)
        Me.Controls.Add(Me.ComboBoxType)
        Me.Controls.Add(Me.NuclidTextBox)
        Me.Controls.Add(Me.ButCancel)
        Me.Controls.Add(Me.LabelType)
        Me.Controls.Add(Me.LabelNucl)
        Me.Controls.Add(Me.ButAddNuclAndType)
        Me.Name = "AddElement"
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
