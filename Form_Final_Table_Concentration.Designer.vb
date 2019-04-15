<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_Final_Table_Concentration
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
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
        CType(Me.DataGridView_Final_Table_Concentration, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart_Ce_La, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart_Th_U, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button_Save
        '
        Me.Button_Save.Location = New System.Drawing.Point(373, 532)
        Me.Button_Save.Name = "Button_Save"
        Me.Button_Save.Size = New System.Drawing.Size(176, 23)
        Me.Button_Save.TabIndex = 13
        Me.Button_Save.Text = "Закрыть и сохранить в файл"
        Me.Button_Save.UseVisualStyleBackColor = True
        '
        'B_Cancel
        '
        Me.B_Cancel.Location = New System.Drawing.Point(555, 532)
        Me.B_Cancel.Name = "B_Cancel"
        Me.B_Cancel.Size = New System.Drawing.Size(176, 23)
        Me.B_Cancel.TabIndex = 12
        Me.B_Cancel.Text = "Отмена"
        Me.B_Cancel.UseVisualStyleBackColor = True
        '
        'Button_Draw_Graph
        '
        Me.Button_Draw_Graph.Location = New System.Drawing.Point(191, 532)
        Me.Button_Draw_Graph.Name = "Button_Draw_Graph"
        Me.Button_Draw_Graph.Size = New System.Drawing.Size(176, 23)
        Me.Button_Draw_Graph.TabIndex = 11
        Me.Button_Draw_Graph.Text = "Построить график"
        Me.Button_Draw_Graph.UseVisualStyleBackColor = True
        '
        'DataGridView_Final_Table_Concentration
        '
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
        Me.DataGridView_Final_Table_Concentration.Location = New System.Drawing.Point(1, 3)
        Me.DataGridView_Final_Table_Concentration.Name = "DataGridView_Final_Table_Concentration"
        Me.DataGridView_Final_Table_Concentration.ReadOnly = True
        Me.DataGridView_Final_Table_Concentration.RowHeadersVisible = False
        Me.DataGridView_Final_Table_Concentration.Size = New System.Drawing.Size(934, 333)
        Me.DataGridView_Final_Table_Concentration.TabIndex = 9
        '
        'SaveFinalTable
        '
        Me.SaveFinalTable.DefaultExt = "xlsx"
        Me.SaveFinalTable.FileName = "FinalTable"
        Me.SaveFinalTable.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*"
        Me.SaveFinalTable.RestoreDirectory = True
        '
        'Chart_Ce_La
        '
        ChartArea3.Name = "ChartArea1"
        Me.Chart_Ce_La.ChartAreas.Add(ChartArea3)
        Me.Chart_Ce_La.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Chart_Ce_La.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Legend3.Name = "Legend1"
        Me.Chart_Ce_La.Legends.Add(Legend3)
        Me.Chart_Ce_La.Location = New System.Drawing.Point(1, 342)
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
        Me.Chart_Ce_La.Size = New System.Drawing.Size(464, 184)
        Me.Chart_Ce_La.TabIndex = 15
        Me.Chart_Ce_La.Text = "Chart_1"
        '
        'Chart_Th_U
        '
        ChartArea4.Name = "ChartArea1"
        Me.Chart_Th_U.ChartAreas.Add(ChartArea4)
        Me.Chart_Th_U.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Chart_Th_U.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Legend4.Name = "Legend1"
        Me.Chart_Th_U.Legends.Add(Legend4)
        Me.Chart_Th_U.Location = New System.Drawing.Point(469, 342)
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
        Me.Chart_Th_U.Size = New System.Drawing.Size(466, 184)
        Me.Chart_Th_U.TabIndex = 16
        Me.Chart_Th_U.Text = "Chart_1"
        '
        'Form_Final_Table_Concentration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(937, 565)
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
