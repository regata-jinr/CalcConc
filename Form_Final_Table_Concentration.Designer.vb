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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series4 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.Button_Save = New System.Windows.Forms.Button()
        Me.B_Cancel = New System.Windows.Forms.Button()
        Me.Button_Draw_Graph = New System.Windows.Forms.Button()
        Me.DataGridView_Final_Table_Concentration = New System.Windows.Forms.DataGridView()
        Me.SaveFinalTable = New System.Windows.Forms.SaveFileDialog()
        Me.Chart_Ce_La = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Chart_Th_U = New System.Windows.Forms.DataVisualization.Charting.Chart()
        CType(Me.DataGridView_Final_Table_Concentration, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart_Ce_La, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart_Th_U, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button_Save
        '
        Me.Button_Save.Location = New System.Drawing.Point(373, 509)
        Me.Button_Save.Name = "Button_Save"
        Me.Button_Save.Size = New System.Drawing.Size(176, 23)
        Me.Button_Save.TabIndex = 13
        Me.Button_Save.Text = "Закрыть и сохранить в файл"
        Me.Button_Save.UseVisualStyleBackColor = True
        '
        'B_Cancel
        '
        Me.B_Cancel.Location = New System.Drawing.Point(555, 509)
        Me.B_Cancel.Name = "B_Cancel"
        Me.B_Cancel.Size = New System.Drawing.Size(176, 23)
        Me.B_Cancel.TabIndex = 12
        Me.B_Cancel.Text = "Отмена"
        Me.B_Cancel.UseVisualStyleBackColor = True
        '
        'Button_Draw_Graph
        '
        Me.Button_Draw_Graph.Location = New System.Drawing.Point(191, 509)
        Me.Button_Draw_Graph.Name = "Button_Draw_Graph"
        Me.Button_Draw_Graph.Size = New System.Drawing.Size(176, 23)
        Me.Button_Draw_Graph.TabIndex = 11
        Me.Button_Draw_Graph.Text = "Построить график"
        Me.Button_Draw_Graph.UseVisualStyleBackColor = True
        '
        'DataGridView_Final_Table_Concentration
        '
        Me.DataGridView_Final_Table_Concentration.AllowUserToAddRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView_Final_Table_Concentration.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView_Final_Table_Concentration.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView_Final_Table_Concentration.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView_Final_Table_Concentration.Location = New System.Drawing.Point(1, 3)
        Me.DataGridView_Final_Table_Concentration.Name = "DataGridView_Final_Table_Concentration"
        Me.DataGridView_Final_Table_Concentration.ReadOnly = True
        Me.DataGridView_Final_Table_Concentration.RowHeadersVisible = False
        Me.DataGridView_Final_Table_Concentration.Size = New System.Drawing.Size(934, 310)
        Me.DataGridView_Final_Table_Concentration.TabIndex = 9
        '
        'SaveFinalTable
        '
        Me.SaveFinalTable.DefaultExt = "xlsx"
        Me.SaveFinalTable.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*"
        Me.SaveFinalTable.RestoreDirectory = True
        '
        'Chart_Ce_La
        '
        ChartArea1.Name = "ChartArea1"
        Me.Chart_Ce_La.ChartAreas.Add(ChartArea1)
        Me.Chart_Ce_La.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Chart_Ce_La.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Legend1.Name = "Legend1"
        Me.Chart_Ce_La.Legends.Add(Legend1)
        Me.Chart_Ce_La.Location = New System.Drawing.Point(1, 319)
        Me.Chart_Ce_La.Name = "Chart_Ce_La"
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point
        Series1.CustomProperties = "EmptyPointValue=Zero"
        Series1.Legend = "Legend1"
        Series1.Name = "Ce-La"
        Series1.YValuesPerPoint = 4
        Series2.ChartArea = "ChartArea1"
        Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series2.Color = System.Drawing.Color.Red
        Series2.Legend = "Legend1"
        Series2.Name = "TrendLine"
        Me.Chart_Ce_La.Series.Add(Series1)
        Me.Chart_Ce_La.Series.Add(Series2)
        Me.Chart_Ce_La.Size = New System.Drawing.Size(464, 184)
        Me.Chart_Ce_La.TabIndex = 15
        Me.Chart_Ce_La.Text = "Chart_1"
        '
        'Chart_Th_U
        '
        ChartArea2.Name = "ChartArea1"
        Me.Chart_Th_U.ChartAreas.Add(ChartArea2)
        Me.Chart_Th_U.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Chart_Th_U.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Legend2.Name = "Legend1"
        Me.Chart_Th_U.Legends.Add(Legend2)
        Me.Chart_Th_U.Location = New System.Drawing.Point(469, 319)
        Me.Chart_Th_U.Name = "Chart_Th_U"
        Series3.ChartArea = "ChartArea1"
        Series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point
        Series3.CustomProperties = "EmptyPointValue=Zero"
        Series3.Legend = "Legend1"
        Series3.Name = "U-Th"
        Series3.YValuesPerPoint = 4
        Series4.ChartArea = "ChartArea1"
        Series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series4.Color = System.Drawing.Color.Red
        Series4.Legend = "Legend1"
        Series4.Name = "TrendLine"
        Me.Chart_Th_U.Series.Add(Series3)
        Me.Chart_Th_U.Series.Add(Series4)
        Me.Chart_Th_U.Size = New System.Drawing.Size(466, 184)
        Me.Chart_Th_U.TabIndex = 16
        Me.Chart_Th_U.Text = "Chart_1"
        '
        'Form_Final_Table_Concentration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(937, 535)
        Me.Controls.Add(Me.Chart_Th_U)
        Me.Controls.Add(Me.Chart_Ce_La)
        Me.Controls.Add(Me.Button_Save)
        Me.Controls.Add(Me.B_Cancel)
        Me.Controls.Add(Me.Button_Draw_Graph)
        Me.Controls.Add(Me.DataGridView_Final_Table_Concentration)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "Form_Final_Table_Concentration"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Окончательная таблица концентраций."
        CType(Me.DataGridView_Final_Table_Concentration, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart_Ce_La, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart_Th_U, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button_Save As System.Windows.Forms.Button
    Friend WithEvents B_Cancel As System.Windows.Forms.Button
    Friend WithEvents Button_Draw_Graph As System.Windows.Forms.Button
    Friend WithEvents DataGridView_Final_Table_Concentration As System.Windows.Forms.DataGridView
    Friend WithEvents SaveFinalTable As System.Windows.Forms.SaveFileDialog
    Friend WithEvents Chart_Ce_La As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents Chart_Th_U As System.Windows.Forms.DataVisualization.Charting.Chart
End Class
