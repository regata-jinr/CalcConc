<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Main))
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.Monitor_Activity_ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VibrBazFileAktMonitStand_MON_ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenFileAktMonStand_MON_ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenFileAktStand_MON_ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SavePereschAktStand_MON_ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Concentration_ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenAktIsslObr_ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenFileGrupStand_ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VibrBazFileAktMonitStand_ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenFileAktMonStand_ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveConcIsslObr_ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.OpenConcIsslObr_ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FiltersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChooseSamplesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChooseBlanksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoadMDEFilesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Table_Nuclides_ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Clear_Form_ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LangEngToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenFileDialog_Aktivn_Issl_Obr = New System.Windows.Forms.OpenFileDialog()
        Me.L_Aktivn_Issl_Obr = New System.Windows.Forms.Label()
        Me.B_calc_conc = New System.Windows.Forms.Button()
        Me.OpenFileDialog_Aktivn_Stand_Obr = New System.Windows.Forms.OpenFileDialog()
        Me.OpenFileDialog_Sert_Conc_Elem = New System.Windows.Forms.OpenFileDialog()
        Me.L_Coef = New System.Windows.Forms.Label()
        Me.TextBox_Coef = New System.Windows.Forms.TextBox()
        Me.SaveFileDialog_Conc_Elem = New System.Windows.Forms.SaveFileDialog()
        Me.B_TablConcElemOkonchat_CON = New System.Windows.Forms.Button()
        Me.B_TablConcElemPromezh_CON = New System.Windows.Forms.Button()
        Me.L_SLI_Source = New System.Windows.Forms.Label()
        Me.ComboBox_SLI_Source = New System.Windows.Forms.ComboBox()
        Me.L_Name_System_Pogr = New System.Windows.Forms.Label()
        Me.TextBox_system_Pogr = New System.Windows.Forms.TextBox()
        Me.B_Otm_Vib_Fil_Mon = New System.Windows.Forms.Button()
        Me.L_Conc_Issl_Obr_CON = New System.Windows.Forms.Label()
        Me.L_File_Akt_Mon_Stand = New System.Windows.Forms.Label()
        Me.L_Baz_File_Akt_Mon_Stand = New System.Windows.Forms.Label()
        Me.L_Grup_Stand = New System.Windows.Forms.Label()
        Me.B_make_Aktivn_Stand_Obr_GRS = New System.Windows.Forms.Button()
        Me.SaveFileDialog_Svodn_Akt_Stand_Obr_GRS = New System.Windows.Forms.SaveFileDialog()
        Me.OpenFileDialog_Grup_Stand_GRS = New System.Windows.Forms.OpenFileDialog()
        Me.OpenFileDialog_Sert_Conc_Elem_GRS_1 = New System.Windows.Forms.OpenFileDialog()
        Me.OpenFileDialog_Akt_Stand_Obr_GRS_2 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog_TablProvStand_XLS_GRS = New System.Windows.Forms.SaveFileDialog()
        Me.L_File_Akt_Mon_Stand_MON = New System.Windows.Forms.Label()
        Me.L_File_Aktivn_Stand_Dlia_Peresch_MON = New System.Windows.Forms.Label()
        Me.B_Perschet_Aktivn_Stand = New System.Windows.Forms.Button()
        Me.L_Baz_File_Akt_Mon_Stand_MON = New System.Windows.Forms.Label()
        Me.OpenFileDialog_Baz_File_Akt_Mon_Stand_MON = New System.Windows.Forms.OpenFileDialog()
        Me.OpenFileDialog_Akt_Stand_MON = New System.Windows.Forms.OpenFileDialog()
        Me.OpenFileDialog_Akt_Mon_Stand_MON = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog_PereschAktStand_MON = New System.Windows.Forms.SaveFileDialog()
        Me.OpenFileDialog_Grup_Stand = New System.Windows.Forms.OpenFileDialog()
        Me.OpenFileDialog_Baz_File_Akt_Mon_Stand = New System.Windows.Forms.OpenFileDialog()
        Me.OpenFileDialog_Akt_Mon_Stand = New System.Windows.Forms.OpenFileDialog()
        Me.OpenFileDialog_Sert_Conc_Elem_GRS_2 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog_RasStandNaGrupStand_XLS_GRS = New System.Windows.Forms.SaveFileDialog()
        Me.OpenFileDialog_Conc_Issl_Obr_CON = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog_Tabl_Conc_Elem_Promezh_XLS_CON = New System.Windows.Forms.SaveFileDialog()
        Me.SaveFileDialog_Tabl_Conc_Elem_Okonchat_XLS_CON = New System.Windows.Forms.SaveFileDialog()
        Me.FolderBrowserDialog_Conc_Elem = New System.Windows.Forms.FolderBrowserDialog()
        Me.GroupBox_L_Aktivnosti = New System.Windows.Forms.GroupBox()
        Me.GroupBox_GroupStandart = New System.Windows.Forms.GroupBox()
        Me.GroupBox_Concentration = New System.Windows.Forms.GroupBox()
        Me.ButtonShowWOConc = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxAcc = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog_ChooseBlankFile = New System.Windows.Forms.OpenFileDialog()
        Me.OpenFileDialog_ChooseFilterForTables = New System.Windows.Forms.OpenFileDialog()
        Me.ButtonConcEditor = New System.Windows.Forms.Button()
        Me.MenuStrip.SuspendLayout()
        Me.GroupBox_L_Aktivnosti.SuspendLayout()
        Me.GroupBox_GroupStandart.SuspendLayout()
        Me.GroupBox_Concentration.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Monitor_Activity_ToolStripMenuItem, Me.Concentration_ToolStripMenuItem, Me.FiltersToolStripMenuItem, Me.Table_Nuclides_ToolStripMenuItem, Me.Clear_Form_ToolStripMenuItem, Me.LangEngToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.MenuStrip.Size = New System.Drawing.Size(707, 24)
        Me.MenuStrip.TabIndex = 2
        '
        'Monitor_Activity_ToolStripMenuItem
        '
        Me.Monitor_Activity_ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VibrBazFileAktMonitStand_MON_ToolStripMenuItem, Me.OpenFileAktMonStand_MON_ToolStripMenuItem, Me.OpenFileAktStand_MON_ToolStripMenuItem, Me.SavePereschAktStand_MON_ToolStripMenuItem})
        Me.Monitor_Activity_ToolStripMenuItem.Name = "Monitor_Activity_ToolStripMenuItem"
        Me.Monitor_Activity_ToolStripMenuItem.Size = New System.Drawing.Size(196, 20)
        Me.Monitor_Activity_ToolStripMenuItem.Text = "Calculation of standards activities"
        '
        'VibrBazFileAktMonitStand_MON_ToolStripMenuItem
        '
        Me.VibrBazFileAktMonitStand_MON_ToolStripMenuItem.Name = "VibrBazFileAktMonitStand_MON_ToolStripMenuItem"
        Me.VibrBazFileAktMonitStand_MON_ToolStripMenuItem.Size = New System.Drawing.Size(359, 22)
        Me.VibrBazFileAktMonitStand_MON_ToolStripMenuItem.Text = "Choose the basic file of activities for standard monitor"
        '
        'OpenFileAktMonStand_MON_ToolStripMenuItem
        '
        Me.OpenFileAktMonStand_MON_ToolStripMenuItem.Name = "OpenFileAktMonStand_MON_ToolStripMenuItem"
        Me.OpenFileAktMonStand_MON_ToolStripMenuItem.Size = New System.Drawing.Size(359, 22)
        Me.OpenFileAktMonStand_MON_ToolStripMenuItem.Text = "Open file of activities for standard monitor"
        '
        'OpenFileAktStand_MON_ToolStripMenuItem
        '
        Me.OpenFileAktStand_MON_ToolStripMenuItem.Name = "OpenFileAktStand_MON_ToolStripMenuItem"
        Me.OpenFileAktStand_MON_ToolStripMenuItem.Size = New System.Drawing.Size(359, 22)
        Me.OpenFileAktStand_MON_ToolStripMenuItem.Text = "Open files of standards activities for calculations"
        '
        'SavePereschAktStand_MON_ToolStripMenuItem
        '
        Me.SavePereschAktStand_MON_ToolStripMenuItem.Name = "SavePereschAktStand_MON_ToolStripMenuItem"
        Me.SavePereschAktStand_MON_ToolStripMenuItem.Size = New System.Drawing.Size(359, 22)
        Me.SavePereschAktStand_MON_ToolStripMenuItem.Text = "Save files"
        Me.SavePereschAktStand_MON_ToolStripMenuItem.Visible = False
        '
        'Concentration_ToolStripMenuItem
        '
        Me.Concentration_ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenAktIsslObr_ToolStripMenuItem, Me.OpenFileGrupStand_ToolStripMenuItem, Me.VibrBazFileAktMonitStand_ToolStripMenuItem, Me.OpenFileAktMonStand_ToolStripMenuItem, Me.SaveConcIsslObr_ToolStripMenuItem, Me.ToolStripMenuItem1, Me.OpenConcIsslObr_ToolStripMenuItem})
        Me.Concentration_ToolStripMenuItem.Name = "Concentration_ToolStripMenuItem"
        Me.Concentration_ToolStripMenuItem.Size = New System.Drawing.Size(95, 20)
        Me.Concentration_ToolStripMenuItem.Text = "Concentration"
        '
        'OpenAktIsslObr_ToolStripMenuItem
        '
        Me.OpenAktIsslObr_ToolStripMenuItem.AutoSize = False
        Me.OpenAktIsslObr_ToolStripMenuItem.Name = "OpenAktIsslObr_ToolStripMenuItem"
        Me.OpenAktIsslObr_ToolStripMenuItem.Size = New System.Drawing.Size(417, 22)
        Me.OpenAktIsslObr_ToolStripMenuItem.Text = "Open file of researching sample"
        '
        'OpenFileGrupStand_ToolStripMenuItem
        '
        Me.OpenFileGrupStand_ToolStripMenuItem.Name = "OpenFileGrupStand_ToolStripMenuItem"
        Me.OpenFileGrupStand_ToolStripMenuItem.Size = New System.Drawing.Size(328, 22)
        Me.OpenFileGrupStand_ToolStripMenuItem.Text = "Open GRS file"
        '
        'VibrBazFileAktMonitStand_ToolStripMenuItem
        '
        Me.VibrBazFileAktMonitStand_ToolStripMenuItem.Name = "VibrBazFileAktMonitStand_ToolStripMenuItem"
        Me.VibrBazFileAktMonitStand_ToolStripMenuItem.Size = New System.Drawing.Size(328, 22)
        Me.VibrBazFileAktMonitStand_ToolStripMenuItem.Text = "Choose basic file of standard monitor activity"
        '
        'OpenFileAktMonStand_ToolStripMenuItem
        '
        Me.OpenFileAktMonStand_ToolStripMenuItem.Name = "OpenFileAktMonStand_ToolStripMenuItem"
        Me.OpenFileAktMonStand_ToolStripMenuItem.Size = New System.Drawing.Size(328, 22)
        Me.OpenFileAktMonStand_ToolStripMenuItem.Text = "Open files of standards activities for calculations"
        '
        'SaveConcIsslObr_ToolStripMenuItem
        '
        Me.SaveConcIsslObr_ToolStripMenuItem.Name = "SaveConcIsslObr_ToolStripMenuItem"
        Me.SaveConcIsslObr_ToolStripMenuItem.Size = New System.Drawing.Size(328, 22)
        Me.SaveConcIsslObr_ToolStripMenuItem.Text = "Save file with concentrations"
        Me.SaveConcIsslObr_ToolStripMenuItem.Visible = False
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(325, 6)
        '
        'OpenConcIsslObr_ToolStripMenuItem
        '
        Me.OpenConcIsslObr_ToolStripMenuItem.Name = "OpenConcIsslObr_ToolStripMenuItem"
        Me.OpenConcIsslObr_ToolStripMenuItem.Size = New System.Drawing.Size(328, 22)
        Me.OpenConcIsslObr_ToolStripMenuItem.Text = "Open CON files"
        '
        'FiltersToolStripMenuItem
        '
        Me.FiltersToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChooseSamplesToolStripMenuItem, Me.ChooseBlanksToolStripMenuItem, Me.LoadMDEFilesToolStripMenuItem})
        Me.FiltersToolStripMenuItem.Name = "FiltersToolStripMenuItem"
        Me.FiltersToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.FiltersToolStripMenuItem.Text = "Filters"
        '
        'ChooseSamplesToolStripMenuItem
        '
        Me.ChooseSamplesToolStripMenuItem.Name = "ChooseSamplesToolStripMenuItem"
        Me.ChooseSamplesToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ChooseSamplesToolStripMenuItem.Text = "Choose samples"
        '
        'ChooseBlanksToolStripMenuItem
        '
        Me.ChooseBlanksToolStripMenuItem.Name = "ChooseBlanksToolStripMenuItem"
        Me.ChooseBlanksToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ChooseBlanksToolStripMenuItem.Text = "Choose blanks"
        '
        'LoadMDEFilesToolStripMenuItem
        '
        Me.LoadMDEFilesToolStripMenuItem.Name = "LoadMDEFilesToolStripMenuItem"
        Me.LoadMDEFilesToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.LoadMDEFilesToolStripMenuItem.Text = "Load MDE files"
        '
        'Table_Nuclides_ToolStripMenuItem
        '
        Me.Table_Nuclides_ToolStripMenuItem.Name = "Table_Nuclides_ToolStripMenuItem"
        Me.Table_Nuclides_ToolStripMenuItem.Size = New System.Drawing.Size(88, 20)
        Me.Table_Nuclides_ToolStripMenuItem.Text = "Nuclids table"
        '
        'Clear_Form_ToolStripMenuItem
        '
        Me.Clear_Form_ToolStripMenuItem.Name = "Clear_Form_ToolStripMenuItem"
        Me.Clear_Form_ToolStripMenuItem.Size = New System.Drawing.Size(135, 20)
        Me.Clear_Form_ToolStripMenuItem.Text = "Re-launch application"
        '
        'LangEngToolStripMenuItem
        '
        Me.LangEngToolStripMenuItem.Name = "LangEngToolStripMenuItem"
        Me.LangEngToolStripMenuItem.Size = New System.Drawing.Size(42, 20)
        Me.LangEngToolStripMenuItem.Text = "lang"
        '
        'OpenFileDialog_Aktivn_Issl_Obr
        '
        Me.OpenFileDialog_Aktivn_Issl_Obr.Filter = "Файлы активностей (*.rpt)|*.rpt|Все файлы|*.*"
        Me.OpenFileDialog_Aktivn_Issl_Obr.Multiselect = True
        '
        'L_Aktivn_Issl_Obr
        '
        Me.L_Aktivn_Issl_Obr.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.L_Aktivn_Issl_Obr.Location = New System.Drawing.Point(7, 16)
        Me.L_Aktivn_Issl_Obr.Name = "L_Aktivn_Issl_Obr"
        Me.L_Aktivn_Issl_Obr.Size = New System.Drawing.Size(683, 30)
        Me.L_Aktivn_Issl_Obr.TabIndex = 3
        Me.L_Aktivn_Issl_Obr.Text = "L_Aktivn_Issl_Obr"
        '
        'B_calc_conc
        '
        Me.B_calc_conc.BackColor = System.Drawing.SystemColors.Control
        Me.B_calc_conc.Location = New System.Drawing.Point(6, 164)
        Me.B_calc_conc.Name = "B_calc_conc"
        Me.B_calc_conc.Size = New System.Drawing.Size(682, 25)
        Me.B_calc_conc.TabIndex = 4
        Me.B_calc_conc.Text = "Calculate and save concentrations"
        Me.B_calc_conc.UseVisualStyleBackColor = False
        '
        'OpenFileDialog_Aktivn_Stand_Obr
        '
        Me.OpenFileDialog_Aktivn_Stand_Obr.Filter = "Файлы активностей (*.rpt)|*.rpt|Все файлы|*.*"
        '
        'OpenFileDialog_Sert_Conc_Elem
        '
        Me.OpenFileDialog_Sert_Conc_Elem.Filter = "Файлы сертифицированных концентраций (*.ref)|*.ref|Все файлы (*.*)|*.*"
        '
        'L_Coef
        '
        Me.L_Coef.AutoSize = True
        Me.L_Coef.Location = New System.Drawing.Point(453, 115)
        Me.L_Coef.Name = "L_Coef"
        Me.L_Coef.Size = New System.Drawing.Size(182, 13)
        Me.L_Coef.TabIndex = 8
        Me.L_Coef.Text = "Coefficient of neutrons flow changing"
        '
        'TextBox_Coef
        '
        Me.TextBox_Coef.Location = New System.Drawing.Point(641, 112)
        Me.TextBox_Coef.Name = "TextBox_Coef"
        Me.TextBox_Coef.Size = New System.Drawing.Size(48, 20)
        Me.TextBox_Coef.TabIndex = 9
        Me.TextBox_Coef.Text = "1.0"
        '
        'SaveFileDialog_Conc_Elem
        '
        Me.SaveFileDialog_Conc_Elem.Filter = "Файлы концентраций (*.con)|*.con|Все файлы (*.*)|*.*"
        '
        'B_TablConcElemOkonchat_CON
        '
        Me.B_TablConcElemOkonchat_CON.BackColor = System.Drawing.SystemColors.Control
        Me.B_TablConcElemOkonchat_CON.Location = New System.Drawing.Point(5, 348)
        Me.B_TablConcElemOkonchat_CON.Name = "B_TablConcElemOkonchat_CON"
        Me.B_TablConcElemOkonchat_CON.Size = New System.Drawing.Size(684, 25)
        Me.B_TablConcElemOkonchat_CON.TabIndex = 19
        Me.B_TablConcElemOkonchat_CON.Text = "Create final table concentration"
        Me.B_TablConcElemOkonchat_CON.UseVisualStyleBackColor = False
        '
        'B_TablConcElemPromezh_CON
        '
        Me.B_TablConcElemPromezh_CON.BackColor = System.Drawing.SystemColors.Control
        Me.B_TablConcElemPromezh_CON.Location = New System.Drawing.Point(5, 286)
        Me.B_TablConcElemPromezh_CON.Name = "B_TablConcElemPromezh_CON"
        Me.B_TablConcElemPromezh_CON.Size = New System.Drawing.Size(684, 25)
        Me.B_TablConcElemPromezh_CON.TabIndex = 14
        Me.B_TablConcElemPromezh_CON.Text = "Create intermediate table of concentration"
        Me.B_TablConcElemPromezh_CON.UseVisualStyleBackColor = False
        '
        'L_SLI_Source
        '
        Me.L_SLI_Source.AutoSize = True
        Me.L_SLI_Source.Location = New System.Drawing.Point(4, 141)
        Me.L_SLI_Source.Name = "L_SLI_Source"
        Me.L_SLI_Source.Size = New System.Drawing.Size(58, 13)
        Me.L_SLI_Source.TabIndex = 21
        Me.L_SLI_Source.Text = "SLI source"
        '
        'ComboBox_SLI_Source
        '
        Me.ComboBox_SLI_Source.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_SLI_Source.FormattingEnabled = True
        Me.ComboBox_SLI_Source.Items.AddRange(New Object() {"КЖИ-1 и КЖИ-2", "только КЖИ-2"})
        Me.ComboBox_SLI_Source.Location = New System.Drawing.Point(144, 138)
        Me.ComboBox_SLI_Source.Name = "ComboBox_SLI_Source"
        Me.ComboBox_SLI_Source.Size = New System.Drawing.Size(149, 21)
        Me.ComboBox_SLI_Source.TabIndex = 20
        '
        'L_Name_System_Pogr
        '
        Me.L_Name_System_Pogr.AutoSize = True
        Me.L_Name_System_Pogr.Location = New System.Drawing.Point(536, 141)
        Me.L_Name_System_Pogr.Name = "L_Name_System_Pogr"
        Me.L_Name_System_Pogr.Size = New System.Drawing.Size(99, 13)
        Me.L_Name_System_Pogr.TabIndex = 17
        Me.L_Name_System_Pogr.Text = "Systematic error, %:"
        '
        'TextBox_system_Pogr
        '
        Me.TextBox_system_Pogr.Location = New System.Drawing.Point(641, 138)
        Me.TextBox_system_Pogr.Name = "TextBox_system_Pogr"
        Me.TextBox_system_Pogr.Size = New System.Drawing.Size(48, 20)
        Me.TextBox_system_Pogr.TabIndex = 18
        Me.TextBox_system_Pogr.Text = "0"
        '
        'B_Otm_Vib_Fil_Mon
        '
        Me.B_Otm_Vib_Fil_Mon.BackColor = System.Drawing.SystemColors.Control
        Me.B_Otm_Vib_Fil_Mon.Location = New System.Drawing.Point(7, 110)
        Me.B_Otm_Vib_Fil_Mon.Name = "B_Otm_Vib_Fil_Mon"
        Me.B_Otm_Vib_Fil_Mon.Size = New System.Drawing.Size(286, 23)
        Me.B_Otm_Vib_Fil_Mon.TabIndex = 16
        Me.B_Otm_Vib_Fil_Mon.Text = "Cancel of choosing monitors files"
        Me.B_Otm_Vib_Fil_Mon.UseVisualStyleBackColor = False
        '
        'L_Conc_Issl_Obr_CON
        '
        Me.L_Conc_Issl_Obr_CON.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.L_Conc_Issl_Obr_CON.Location = New System.Drawing.Point(6, 193)
        Me.L_Conc_Issl_Obr_CON.Name = "L_Conc_Issl_Obr_CON"
        Me.L_Conc_Issl_Obr_CON.Size = New System.Drawing.Size(682, 30)
        Me.L_Conc_Issl_Obr_CON.TabIndex = 15
        Me.L_Conc_Issl_Obr_CON.Text = "L_Conc_Issl_Obr_CON"
        '
        'L_File_Akt_Mon_Stand
        '
        Me.L_File_Akt_Mon_Stand.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.L_File_Akt_Mon_Stand.ForeColor = System.Drawing.SystemColors.ControlText
        Me.L_File_Akt_Mon_Stand.Location = New System.Drawing.Point(7, 90)
        Me.L_File_Akt_Mon_Stand.Name = "L_File_Akt_Mon_Stand"
        Me.L_File_Akt_Mon_Stand.Size = New System.Drawing.Size(683, 15)
        Me.L_File_Akt_Mon_Stand.TabIndex = 12
        Me.L_File_Akt_Mon_Stand.Text = "L_File_Akt_Mon_Stand"
        '
        'L_Baz_File_Akt_Mon_Stand
        '
        Me.L_Baz_File_Akt_Mon_Stand.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.L_Baz_File_Akt_Mon_Stand.Location = New System.Drawing.Point(7, 70)
        Me.L_Baz_File_Akt_Mon_Stand.Name = "L_Baz_File_Akt_Mon_Stand"
        Me.L_Baz_File_Akt_Mon_Stand.Size = New System.Drawing.Size(683, 15)
        Me.L_Baz_File_Akt_Mon_Stand.TabIndex = 11
        Me.L_Baz_File_Akt_Mon_Stand.Text = "L_Baz_File_Akt_Mon_Stand"
        '
        'L_Grup_Stand
        '
        Me.L_Grup_Stand.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.L_Grup_Stand.Location = New System.Drawing.Point(7, 50)
        Me.L_Grup_Stand.Name = "L_Grup_Stand"
        Me.L_Grup_Stand.Size = New System.Drawing.Size(684, 15)
        Me.L_Grup_Stand.TabIndex = 10
        Me.L_Grup_Stand.Text = "L_Grup_Stand"
        '
        'B_make_Aktivn_Stand_Obr_GRS
        '
        Me.B_make_Aktivn_Stand_Obr_GRS.BackColor = System.Drawing.SystemColors.Control
        Me.B_make_Aktivn_Stand_Obr_GRS.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.B_make_Aktivn_Stand_Obr_GRS.Location = New System.Drawing.Point(5, 18)
        Me.B_make_Aktivn_Stand_Obr_GRS.Name = "B_make_Aktivn_Stand_Obr_GRS"
        Me.B_make_Aktivn_Stand_Obr_GRS.Size = New System.Drawing.Size(684, 33)
        Me.B_make_Aktivn_Stand_Obr_GRS.TabIndex = 3
        Me.B_make_Aktivn_Stand_Obr_GRS.Text = "Open GRS editor"
        Me.B_make_Aktivn_Stand_Obr_GRS.UseVisualStyleBackColor = False
        '
        'SaveFileDialog_Svodn_Akt_Stand_Obr_GRS
        '
        Me.SaveFileDialog_Svodn_Akt_Stand_Obr_GRS.DefaultExt = "sta"
        Me.SaveFileDialog_Svodn_Akt_Stand_Obr_GRS.Filter = "Сводные файлы активностей стандартных образцов (*.sta)|*.sta|Все файлы (*.*)|*.*"
        '
        'OpenFileDialog_Grup_Stand_GRS
        '
        Me.OpenFileDialog_Grup_Stand_GRS.Filter = "Файлы групповых стандартов (*.grs)|*.grs|Все файлы (*.*)|*.*"
        '
        'OpenFileDialog_Sert_Conc_Elem_GRS_1
        '
        Me.OpenFileDialog_Sert_Conc_Elem_GRS_1.Filter = "Файлы сертифицированных концентраций (*.ref)|*.ref|Все файлы (*.*)|*.*"
        '
        'OpenFileDialog_Akt_Stand_Obr_GRS_2
        '
        Me.OpenFileDialog_Akt_Stand_Obr_GRS_2.Filter = "Файлы активностей (*.rpt)|*.rpt|Все файлы|*.*"
        Me.OpenFileDialog_Akt_Stand_Obr_GRS_2.Multiselect = True
        '
        'SaveFileDialog_TablProvStand_XLS_GRS
        '
        Me.SaveFileDialog_TablProvStand_XLS_GRS.Filter = "Файлы Excel (*.xlsx)|*.xlsx|Все файлы (*.*)|*.*"
        '
        'L_File_Akt_Mon_Stand_MON
        '
        Me.L_File_Akt_Mon_Stand_MON.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.L_File_Akt_Mon_Stand_MON.Location = New System.Drawing.Point(6, 36)
        Me.L_File_Akt_Mon_Stand_MON.Name = "L_File_Akt_Mon_Stand_MON"
        Me.L_File_Akt_Mon_Stand_MON.Size = New System.Drawing.Size(684, 15)
        Me.L_File_Akt_Mon_Stand_MON.TabIndex = 3
        Me.L_File_Akt_Mon_Stand_MON.Text = "L_File_Akt_Mon_Stand_MON"
        '
        'L_File_Aktivn_Stand_Dlia_Peresch_MON
        '
        Me.L_File_Aktivn_Stand_Dlia_Peresch_MON.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.L_File_Aktivn_Stand_Dlia_Peresch_MON.Location = New System.Drawing.Point(6, 56)
        Me.L_File_Aktivn_Stand_Dlia_Peresch_MON.Name = "L_File_Aktivn_Stand_Dlia_Peresch_MON"
        Me.L_File_Aktivn_Stand_Dlia_Peresch_MON.Size = New System.Drawing.Size(684, 30)
        Me.L_File_Aktivn_Stand_Dlia_Peresch_MON.TabIndex = 2
        Me.L_File_Aktivn_Stand_Dlia_Peresch_MON.Text = "L_File_Aktivn_Stand_Dlia_Peresch_MON"
        '
        'B_Perschet_Aktivn_Stand
        '
        Me.B_Perschet_Aktivn_Stand.BackColor = System.Drawing.SystemColors.Control
        Me.B_Perschet_Aktivn_Stand.Location = New System.Drawing.Point(6, 89)
        Me.B_Perschet_Aktivn_Stand.Name = "B_Perschet_Aktivn_Stand"
        Me.B_Perschet_Aktivn_Stand.Size = New System.Drawing.Size(684, 23)
        Me.B_Perschet_Aktivn_Stand.TabIndex = 1
        Me.B_Perschet_Aktivn_Stand.Text = "Recalc and save standards activities"
        Me.B_Perschet_Aktivn_Stand.UseVisualStyleBackColor = False
        '
        'L_Baz_File_Akt_Mon_Stand_MON
        '
        Me.L_Baz_File_Akt_Mon_Stand_MON.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.L_Baz_File_Akt_Mon_Stand_MON.Location = New System.Drawing.Point(6, 16)
        Me.L_Baz_File_Akt_Mon_Stand_MON.Name = "L_Baz_File_Akt_Mon_Stand_MON"
        Me.L_Baz_File_Akt_Mon_Stand_MON.Size = New System.Drawing.Size(684, 15)
        Me.L_Baz_File_Akt_Mon_Stand_MON.TabIndex = 2
        Me.L_Baz_File_Akt_Mon_Stand_MON.Text = "L_Baz_File_Akt_Mon_Stand_Monitor_MON"
        '
        'OpenFileDialog_Baz_File_Akt_Mon_Stand_MON
        '
        Me.OpenFileDialog_Baz_File_Akt_Mon_Stand_MON.Filter = "Файлы активностей (*.rpt)|*.rpt|Все файлы|*.*"
        '
        'OpenFileDialog_Akt_Stand_MON
        '
        Me.OpenFileDialog_Akt_Stand_MON.Filter = "Файлы активностей (*.rpt)|*.rpt|Все файлы|*.*"
        Me.OpenFileDialog_Akt_Stand_MON.Multiselect = True
        '
        'OpenFileDialog_Akt_Mon_Stand_MON
        '
        Me.OpenFileDialog_Akt_Mon_Stand_MON.Filter = "Файлы активностей (*.rpt)|*.rpt|Все файлы|*.*"
        '
        'SaveFileDialog_PereschAktStand_MON
        '
        Me.SaveFileDialog_PereschAktStand_MON.Filter = "Файлы активностей (*.rpt)|*.rpt|Все файлы|*.*"
        '
        'OpenFileDialog_Grup_Stand
        '
        Me.OpenFileDialog_Grup_Stand.Filter = "Файлы групповых стандартов (*.grs)|*.grs|Все файлы (*.*)|*.*"
        '
        'OpenFileDialog_Baz_File_Akt_Mon_Stand
        '
        Me.OpenFileDialog_Baz_File_Akt_Mon_Stand.Filter = "Файлы активностей (*.rpt)|*.rpt|Все файлы|*.*"
        '
        'OpenFileDialog_Akt_Mon_Stand
        '
        Me.OpenFileDialog_Akt_Mon_Stand.Filter = "Файлы активностей (*.rpt)|*.rpt|Все файлы|*.*"
        '
        'OpenFileDialog_Sert_Conc_Elem_GRS_2
        '
        Me.OpenFileDialog_Sert_Conc_Elem_GRS_2.Filter = "Файлы сертифицированных концентраций (*.ref)|*.ref|Все файлы (*.*)|*.*"
        '
        'SaveFileDialog_RasStandNaGrupStand_XLS_GRS
        '
        Me.SaveFileDialog_RasStandNaGrupStand_XLS_GRS.Filter = "Файлы Excel (*.xlsx)|*.xlsx|Все файлы (*.*)|*.*"
        '
        'OpenFileDialog_Conc_Issl_Obr_CON
        '
        Me.OpenFileDialog_Conc_Issl_Obr_CON.Filter = "Файлы концентраций (*.con, *.mde)|*.con;*.mde|Все файлы (*.*)|*.*"
        Me.OpenFileDialog_Conc_Issl_Obr_CON.Multiselect = True
        Me.OpenFileDialog_Conc_Issl_Obr_CON.RestoreDirectory = True
        '
        'SaveFileDialog_Tabl_Conc_Elem_Promezh_XLS_CON
        '
        Me.SaveFileDialog_Tabl_Conc_Elem_Promezh_XLS_CON.Filter = "Файлы Excel (*.xlsx)|*.xlsx|Все файлы (*.*)|*.*"
        '
        'SaveFileDialog_Tabl_Conc_Elem_Okonchat_XLS_CON
        '
        Me.SaveFileDialog_Tabl_Conc_Elem_Okonchat_XLS_CON.Filter = "Файлы Excel (*.xlsx)|*.xlsx|Все файлы (*.*)|*.*"
        '
        'GroupBox_L_Aktivnosti
        '
        Me.GroupBox_L_Aktivnosti.BackColor = System.Drawing.Color.LavenderBlush
        Me.GroupBox_L_Aktivnosti.Controls.Add(Me.L_Baz_File_Akt_Mon_Stand_MON)
        Me.GroupBox_L_Aktivnosti.Controls.Add(Me.B_Perschet_Aktivn_Stand)
        Me.GroupBox_L_Aktivnosti.Controls.Add(Me.L_File_Akt_Mon_Stand_MON)
        Me.GroupBox_L_Aktivnosti.Controls.Add(Me.L_File_Aktivn_Stand_Dlia_Peresch_MON)
        Me.GroupBox_L_Aktivnosti.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox_L_Aktivnosti.Location = New System.Drawing.Point(5, 27)
        Me.GroupBox_L_Aktivnosti.Name = "GroupBox_L_Aktivnosti"
        Me.GroupBox_L_Aktivnosti.Size = New System.Drawing.Size(696, 118)
        Me.GroupBox_L_Aktivnosti.TabIndex = 5
        Me.GroupBox_L_Aktivnosti.TabStop = False
        Me.GroupBox_L_Aktivnosti.Text = "Recalculation of standards activities"
        '
        'GroupBox_GroupStandart
        '
        Me.GroupBox_GroupStandart.BackColor = System.Drawing.Color.Azure
        Me.GroupBox_GroupStandart.Controls.Add(Me.B_make_Aktivn_Stand_Obr_GRS)
        Me.GroupBox_GroupStandart.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.GroupBox_GroupStandart.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox_GroupStandart.Location = New System.Drawing.Point(5, 151)
        Me.GroupBox_GroupStandart.Name = "GroupBox_GroupStandart"
        Me.GroupBox_GroupStandart.Size = New System.Drawing.Size(696, 57)
        Me.GroupBox_GroupStandart.TabIndex = 12
        Me.GroupBox_GroupStandart.TabStop = False
        Me.GroupBox_GroupStandart.Text = "Group standard"
        '
        'GroupBox_Concentration
        '
        Me.GroupBox_Concentration.BackColor = System.Drawing.Color.Lavender
        Me.GroupBox_Concentration.Controls.Add(Me.ButtonConcEditor)
        Me.GroupBox_Concentration.Controls.Add(Me.ButtonShowWOConc)
        Me.GroupBox_Concentration.Controls.Add(Me.Label1)
        Me.GroupBox_Concentration.Controls.Add(Me.TextBoxAcc)
        Me.GroupBox_Concentration.Controls.Add(Me.B_TablConcElemOkonchat_CON)
        Me.GroupBox_Concentration.Controls.Add(Me.L_SLI_Source)
        Me.GroupBox_Concentration.Controls.Add(Me.B_TablConcElemPromezh_CON)
        Me.GroupBox_Concentration.Controls.Add(Me.L_Aktivn_Issl_Obr)
        Me.GroupBox_Concentration.Controls.Add(Me.B_calc_conc)
        Me.GroupBox_Concentration.Controls.Add(Me.ComboBox_SLI_Source)
        Me.GroupBox_Concentration.Controls.Add(Me.L_Name_System_Pogr)
        Me.GroupBox_Concentration.Controls.Add(Me.TextBox_Coef)
        Me.GroupBox_Concentration.Controls.Add(Me.TextBox_system_Pogr)
        Me.GroupBox_Concentration.Controls.Add(Me.L_Coef)
        Me.GroupBox_Concentration.Controls.Add(Me.B_Otm_Vib_Fil_Mon)
        Me.GroupBox_Concentration.Controls.Add(Me.L_Grup_Stand)
        Me.GroupBox_Concentration.Controls.Add(Me.L_Conc_Issl_Obr_CON)
        Me.GroupBox_Concentration.Controls.Add(Me.L_Baz_File_Akt_Mon_Stand)
        Me.GroupBox_Concentration.Controls.Add(Me.L_File_Akt_Mon_Stand)
        Me.GroupBox_Concentration.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox_Concentration.Location = New System.Drawing.Point(5, 214)
        Me.GroupBox_Concentration.Name = "GroupBox_Concentration"
        Me.GroupBox_Concentration.Size = New System.Drawing.Size(696, 374)
        Me.GroupBox_Concentration.TabIndex = 13
        Me.GroupBox_Concentration.TabStop = False
        Me.GroupBox_Concentration.Text = "Concentration"
        '
        'ButtonShowWOConc
        '
        Me.ButtonShowWOConc.BackColor = System.Drawing.SystemColors.Control
        Me.ButtonShowWOConc.Location = New System.Drawing.Point(5, 317)
        Me.ButtonShowWOConc.Name = "ButtonShowWOConc"
        Me.ButtonShowWOConc.Size = New System.Drawing.Size(684, 25)
        Me.ButtonShowWOConc.TabIndex = 24
        Me.ButtonShowWOConc.Text = "label"
        Me.ButtonShowWOConc.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(521, 233)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 13)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Rounding accuracy %:"
        '
        'TextBoxAcc
        '
        Me.TextBoxAcc.Location = New System.Drawing.Point(641, 230)
        Me.TextBoxAcc.Name = "TextBoxAcc"
        Me.TextBoxAcc.Size = New System.Drawing.Size(47, 20)
        Me.TextBoxAcc.TabIndex = 22
        Me.TextBoxAcc.Text = "1"
        Me.TextBoxAcc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'OpenFileDialog_ChooseBlankFile
        '
        Me.OpenFileDialog_ChooseBlankFile.Filter = "Файлы концентраций (*.con)|*.con|Все файлы (*.*)|*.*"
        Me.OpenFileDialog_ChooseBlankFile.RestoreDirectory = True
        Me.OpenFileDialog_ChooseBlankFile.SupportMultiDottedExtensions = True
        Me.OpenFileDialog_ChooseBlankFile.Title = "Выберите файл бланка"
        '
        'OpenFileDialog_ChooseFilterForTables
        '
        Me.OpenFileDialog_ChooseFilterForTables.Filter = "Файлы фильтров (*.mde)|*.mde|Все файлы (*.*)|*.*"
        Me.OpenFileDialog_ChooseFilterForTables.Multiselect = True
        Me.OpenFileDialog_ChooseFilterForTables.RestoreDirectory = True
        '
        'ButtonConcEditor
        '
        Me.ButtonConcEditor.BackColor = System.Drawing.SystemColors.Control
        Me.ButtonConcEditor.Enabled = False
        Me.ButtonConcEditor.Location = New System.Drawing.Point(4, 256)
        Me.ButtonConcEditor.Name = "ButtonConcEditor"
        Me.ButtonConcEditor.Size = New System.Drawing.Size(684, 25)
        Me.ButtonConcEditor.TabIndex = 25
        Me.ButtonConcEditor.Text = "Edit concentration values"
        Me.ButtonConcEditor.UseVisualStyleBackColor = False
        '
        'Form_Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(707, 588)
        Me.Controls.Add(Me.GroupBox_Concentration)
        Me.Controls.Add(Me.GroupBox_GroupStandart)
        Me.Controls.Add(Me.GroupBox_L_Aktivnosti)
        Me.Controls.Add(Me.MenuStrip)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip
        Me.MaximizeBox = False
        Me.Name = "Form_Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Calculation of concentration 10.0.40219.1"
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.GroupBox_L_Aktivnosti.ResumeLayout(False)
        Me.GroupBox_GroupStandart.ResumeLayout(False)
        Me.GroupBox_Concentration.ResumeLayout(False)
        Me.GroupBox_Concentration.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents Concentration_ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenAktIsslObr_ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SaveConcIsslObr_ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenFileDialog_Aktivn_Issl_Obr As System.Windows.Forms.OpenFileDialog
    Friend WithEvents L_Aktivn_Issl_Obr As System.Windows.Forms.Label
    Friend WithEvents B_calc_conc As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog_Aktivn_Stand_Obr As System.Windows.Forms.OpenFileDialog
    Friend WithEvents OpenFileDialog_Sert_Conc_Elem As System.Windows.Forms.OpenFileDialog
    Friend WithEvents L_Coef As System.Windows.Forms.Label
    Friend WithEvents TextBox_Coef As System.Windows.Forms.TextBox
    Friend WithEvents SaveFileDialog_Conc_Elem As System.Windows.Forms.SaveFileDialog
    Friend WithEvents B_make_Aktivn_Stand_Obr_GRS As System.Windows.Forms.Button
    Friend WithEvents SaveFileDialog_Svodn_Akt_Stand_Obr_GRS As System.Windows.Forms.SaveFileDialog
    Friend WithEvents OpenFileDialog_Grup_Stand_GRS As System.Windows.Forms.OpenFileDialog
    Friend WithEvents OpenFileDialog_Sert_Conc_Elem_GRS_1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents OpenFileDialog_Akt_Stand_Obr_GRS_2 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialog_TablProvStand_XLS_GRS As System.Windows.Forms.SaveFileDialog
    Friend WithEvents Monitor_Activity_ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VibrBazFileAktMonitStand_MON_ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenFileAktStand_MON_ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SavePereschAktStand_MON_ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents L_Baz_File_Akt_Mon_Stand_MON As System.Windows.Forms.Label
    Friend WithEvents B_Perschet_Aktivn_Stand As System.Windows.Forms.Button
    Friend WithEvents L_File_Aktivn_Stand_Dlia_Peresch_MON As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog_Baz_File_Akt_Mon_Stand_MON As System.Windows.Forms.OpenFileDialog
    Friend WithEvents OpenFileDialog_Akt_Stand_MON As System.Windows.Forms.OpenFileDialog
    Friend WithEvents OpenFileAktMonStand_MON_ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents L_File_Akt_Mon_Stand_MON As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog_Akt_Mon_Stand_MON As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialog_PereschAktStand_MON As System.Windows.Forms.SaveFileDialog
    Friend WithEvents OpenFileGrupStand_ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents L_Grup_Stand As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog_Grup_Stand As System.Windows.Forms.OpenFileDialog
    Friend WithEvents VibrBazFileAktMonitStand_ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenFileAktMonStand_ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenFileDialog_Baz_File_Akt_Mon_Stand As System.Windows.Forms.OpenFileDialog
    Friend WithEvents OpenFileDialog_Akt_Mon_Stand As System.Windows.Forms.OpenFileDialog
    Friend WithEvents L_Baz_File_Akt_Mon_Stand As System.Windows.Forms.Label
    Friend WithEvents L_File_Akt_Mon_Stand As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog_Sert_Conc_Elem_GRS_2 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialog_RasStandNaGrupStand_XLS_GRS As System.Windows.Forms.SaveFileDialog
    Friend WithEvents OpenConcIsslObr_ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents L_Conc_Issl_Obr_CON As System.Windows.Forms.Label
    Friend WithEvents B_TablConcElemPromezh_CON As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog_Conc_Issl_Obr_CON As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialog_Tabl_Conc_Elem_Promezh_XLS_CON As System.Windows.Forms.SaveFileDialog
    Friend WithEvents B_Otm_Vib_Fil_Mon As System.Windows.Forms.Button
    Friend WithEvents L_Name_System_Pogr As System.Windows.Forms.Label
    Friend WithEvents TextBox_system_Pogr As System.Windows.Forms.TextBox
    Friend WithEvents B_TablConcElemOkonchat_CON As System.Windows.Forms.Button
    Friend WithEvents SaveFileDialog_Tabl_Conc_Elem_Okonchat_XLS_CON As System.Windows.Forms.SaveFileDialog
    Friend WithEvents Clear_Form_ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents L_SLI_Source As System.Windows.Forms.Label
    Friend WithEvents ComboBox_SLI_Source As System.Windows.Forms.ComboBox
    Friend WithEvents Table_Nuclides_ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FolderBrowserDialog_Conc_Elem As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents GroupBox_L_Aktivnosti As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox_GroupStandart As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox_Concentration As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxAcc As TextBox
    Friend WithEvents LangEngToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ButtonShowWOConc As Button
    Friend WithEvents FiltersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChooseSamplesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChooseBlanksToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenFileDialog_ChooseBlankFile As OpenFileDialog
    Friend WithEvents LoadMDEFilesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenFileDialog_ChooseFilterForTables As OpenFileDialog
    Friend WithEvents ButtonConcEditor As Button
End Class
