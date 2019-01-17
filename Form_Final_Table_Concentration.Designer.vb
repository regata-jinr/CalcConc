<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Final_Table_Concentration
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Final_Table_Concentration))
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim ChartArea3 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend3 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series5 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series6 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea4 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend4 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series7 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series8 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.Button_Save = New System.Windows.Forms.Button()
        Me.B_Cancel = New System.Windows.Forms.Button()
        Me.Button_Draw_Graph = New System.Windows.Forms.Button()
        Me.DataGridView_Final_Table_Concentration = New System.Windows.Forms.DataGridView()
        Me.SaveFinalTable = New System.Windows.Forms.SaveFileDialog()
        Me.Chart_Ce_La = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Chart_Th_U = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.LabelTableFinalComment = New System.Windows.Forms.Label()
        CType(Me.DataGridView_Final_Table_Concentration, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart_Ce_La, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart_Th_U, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button_Save
        '
        resources.ApplyResources(Me.Button_Save, "Button_Save")
        Me.Button_Save.Name = "Button_Save"
        Me.Button_Save.UseVisualStyleBackColor = True
        '
        'B_Cancel
        '
        resources.ApplyResources(Me.B_Cancel, "B_Cancel")
        Me.B_Cancel.Name = "B_Cancel"
        Me.B_Cancel.UseVisualStyleBackColor = True
        '
        'Button_Draw_Graph
        '
        resources.ApplyResources(Me.Button_Draw_Graph, "Button_Draw_Graph")
        Me.Button_Draw_Graph.Name = "Button_Draw_Graph"
        Me.Button_Draw_Graph.UseVisualStyleBackColor = True
        '
        'DataGridView_Final_Table_Concentration
        '
        resources.ApplyResources(Me.DataGridView_Final_Table_Concentration, "DataGridView_Final_Table_Concentration")
        Me.DataGridView_Final_Table_Concentration.AllowUserToAddRows = False
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView_Final_Table_Concentration.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView_Final_Table_Concentration.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView_Final_Table_Concentration.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView_Final_Table_Concentration.Name = "DataGridView_Final_Table_Concentration"
        Me.DataGridView_Final_Table_Concentration.ReadOnly = True
        Me.DataGridView_Final_Table_Concentration.RowHeadersVisible = False
        '
        'SaveFinalTable
        '
        Me.SaveFinalTable.DefaultExt = "xlsx"
        resources.ApplyResources(Me.SaveFinalTable, "SaveFinalTable")
        Me.SaveFinalTable.RestoreDirectory = True
        '
        'Chart_Ce_La
        '
        resources.ApplyResources(Me.Chart_Ce_La, "Chart_Ce_La")
        ChartArea3.Name = "ChartArea1"
        Me.Chart_Ce_La.ChartAreas.Add(ChartArea3)
        Me.Chart_Ce_La.Cursor = System.Windows.Forms.Cursors.IBeam
        Legend3.Name = "Legend1"
        Me.Chart_Ce_La.Legends.Add(Legend3)
        Me.Chart_Ce_La.Name = "Chart_Ce_La"
        Series5.ChartArea = "ChartArea1"
        Series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point
        Series5.CustomProperties = "EmptyPointValue=Zero"
        Series5.Legend = "Legend1"
        Series5.Name = "Ce-La"
        Series5.YValuesPerPoint = 4
        Series6.ChartArea = "ChartArea1"
        Series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series6.Color = System.Drawing.Color.Red
        Series6.Legend = "Legend1"
        Series6.Name = "TrendLine"
        Me.Chart_Ce_La.Series.Add(Series5)
        Me.Chart_Ce_La.Series.Add(Series6)
        '
        'Chart_Th_U
        '
        resources.ApplyResources(Me.Chart_Th_U, "Chart_Th_U")
        ChartArea4.Name = "ChartArea1"
        Me.Chart_Th_U.ChartAreas.Add(ChartArea4)
        Me.Chart_Th_U.Cursor = System.Windows.Forms.Cursors.IBeam
        Legend4.Name = "Legend1"
        Me.Chart_Th_U.Legends.Add(Legend4)
        Me.Chart_Th_U.Name = "Chart_Th_U"
        Series7.ChartArea = "ChartArea1"
        Series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point
        Series7.CustomProperties = "EmptyPointValue=Zero"
        Series7.Legend = "Legend1"
        Series7.Name = "U-Th"
        Series7.YValuesPerPoint = 4
        Series8.ChartArea = "ChartArea1"
        Series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series8.Color = System.Drawing.Color.Red
        Series8.Legend = "Legend1"
        Series8.Name = "TrendLine"
        Me.Chart_Th_U.Series.Add(Series7)
        Me.Chart_Th_U.Series.Add(Series8)
        '
        'LabelTableFinalComment
        '
        resources.ApplyResources(Me.LabelTableFinalComment, "LabelTableFinalComment")
        Me.LabelTableFinalComment.Name = "LabelTableFinalComment"
        '
        'Form_Final_Table_Concentration
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.LabelTableFinalComment)
        Me.Controls.Add(Me.Chart_Th_U)
        Me.Controls.Add(Me.Chart_Ce_La)
        Me.Controls.Add(Me.Button_Save)
        Me.Controls.Add(Me.B_Cancel)
        Me.Controls.Add(Me.Button_Draw_Graph)
        Me.Controls.Add(Me.DataGridView_Final_Table_Concentration)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "Form_Final_Table_Concentration"
        CType(Me.DataGridView_Final_Table_Concentration, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart_Ce_La, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart_Th_U, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button_Save As System.Windows.Forms.Button
    Friend WithEvents B_Cancel As System.Windows.Forms.Button
    Friend WithEvents Button_Draw_Graph As System.Windows.Forms.Button
    Friend WithEvents DataGridView_Final_Table_Concentration As System.Windows.Forms.DataGridView
    Friend WithEvents SaveFinalTable As System.Windows.Forms.SaveFileDialog
    Friend WithEvents Chart_Ce_La As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents Chart_Th_U As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents LabelTableFinalComment As Label
End Class
