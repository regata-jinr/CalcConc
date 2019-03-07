Imports System.IO
Imports System.Globalization
Imports System.Text.RegularExpressions
Imports Excel = Office
Imports File = System.IO.File
Imports StrPars = Microsoft.VisualBasic
Imports System.Threading
Imports System.ComponentModel
Imports System.Linq

Public Class Form_Main

    Dim nucl_array_Stand_Obr_GRS_1_sum(,) As String

    Dim nucl_array_Akt_Mon_Stand_MON(,) As String
    Dim nucl_array_Akt_Stand_MON(,) As String
    Dim nucl_array_Akt_Baz_Mon_Stand_MON(,) As String
    Dim nucl_array_Akt_Baz_Mon_Stand(,) As String
    Dim nucl_array_Akt_Mon_Stand(,) As String

    Dim data_array_Stand_Obr_GRS_1_sum(,) As Single
    Dim data_array_Akt_Mon_Stand_MON(,) As Single
    Dim data_array_Akt_Stand_MON(,) As Single
    Dim data_array_Akt_Baz_Mon_Stand_MON(,) As Single
    Dim data_array_Akt_Baz_Mon_Stand(,) As Single
    Dim data_array_Akt_Mon_Stand(,) As Single

    Dim arr_length_Stand_Obr_GRS_1_array() As Integer
    Dim nucl(), nucl_GRS(), nucl_dif_GRS() As String
    Dim conc(,), conc_GRS(,), conc_dif_GRS(,) As Single
    Dim aktivnost(,) As Single
    Dim Path_To_Folder_glob As String

    Public table_nuclides(,) As String

    Dim File_Aktivn_Issl_Obr_Select, File_Aktivn_Stand_Obr_Select, File_Sert_Conc_Elem_Select, File_Grup_Stand_Select As Boolean
    Dim File_Baz_File_Akt_Monit_Stand_Select_MON, File_Akt_Stand_Select_MON, File_Akt_Monit_Stand_Select_MON As Boolean
    Dim File_Baz_File_Akt_Monit_Stand_Select, File_Akt_Monit_Stand_Select As Boolean

    Dim file_name_Aktivn_Issl_Obr_Array(), file_name_Aktivn_Issl_Obr_SafeFileNames_Array(), file_name_Aktivn_Issl_Obr_Short_Array() As String
    Dim file_name_Akt_Stand_Array_MON(), file_name_Akt_Stand_SafeFileNames_MON_Array(), file_name_Akt_Stand_Short_MON_Array()
    Dim file_name_Aktivn_Stand_Obr_GRS_Array(), file_name_Aktivn_Stand_Obr_SafeFileNames_GRS_Array(), file_name_Aktivn_Stand_Obr_Short_GRS_Array() As String
    Dim file_name_Aktivn_Stand_Obr_Array_GRS_2(), file_name_Aktivn_Stand_Obr_SafeFileName_Array_GRS_2() As String
    Dim file_name_RasStandNaGrupStand_GRS_Array(), file_name_Conc_Issl_Obr_Array_CON(), file_name_Conc_Issl_Obr_SafeFileNames_Array_CON(), file_name_Conc_Issl_Obr_SafeFileNames_For_Correct_Sorting_Array_CON() As String

    Dim file_name_Aktivn_Stand_Obr, file_name_Aktivn_Stand_Obr_SafeFileName, file_name_Sert_Conc_Elem, file_name_Grup_Stand, file_name_Grup_Stand_SafeFileName As String
    Dim file_name_Aktivn_Stand_Obr_GRS_1, file_name_Sert_Conc_Elem_GRS_1, file_name_Grup_Stand_GRS, file_name_Grup_Stand_GRS_SafeFileName As String
    ' Dim file_name_Aktivn_Stand_Obr_SafeFileName_grs_2 As String
    ' Dim file_name_Aktivn_Stand_Obr_GRS_2 As String
    Dim file_name_Stand_ConcStandNaGrStand, file_name_Grup_Stand_ConcStandNaGrStand As String
    Dim file_name_Sert_Conc_Elem_GRS_3 As String
    Dim file_name_Baz_File_Akt_Mon_Stand_SafeFileName_MON, file_name_Baz_File_Akt_Mon_Stand_MON As String
    Dim file_name_Akt_Mon_Stand_MON, file_name_Akt_Mon_Stand_SafeFileName_MON As String
    Dim file_name_Akt_Mon_Stand, file_name_Akt_Mon_Stand_SafeFileName As String
    Dim file_name_Baz_File_Akt_Mon_Stand, file_name_Baz_File_Akt_Mon_Stand_SafeFileName As String

    Dim sample_title_Issl_Obr, measurements_type, sample_title_Stand_Obr, sample_title_Stand_Obr_Conc, sample_title_STA As String
    Dim sample_title_Mon_Stand_MON, sample_title_Baz_Mon_Stand_MON, sample_title_Stand_MON As String
    Dim sample_title_Baz_Mon_Stand, sample_title_Mon_Stand As String
    Dim sample_title_Stand_Obr_Conc_GRS_1, sample_title_Stand_Obr_GRS_2, sample_title_STA_GRS, sample_title_Stand_Obr_Conc_GRS_2, sample_title_ConcStandNaGrStand_GRS, sample_title_ConcIsslObr_CON As String
    Dim arr_length_count_Conc, m_glob, m_glob_MON, arr_length_count_Conc_GRS, arr_length_count_Conc_dif_GRS, arr_length_ConcIsslObr_CON As Integer
    Dim Aktivn_Issl_Obr_Files_Quant, Aktivn_Stand_Obr_Files_GRS_Quant, Files_Conc_Issl_Obr_Files_Quant_CON As Integer
    Dim Aktivn_Stand_Obr_Files_Quant_GRS_2
    Dim Akt_Stand_Files_MON_Quant As Integer
    Public Aktivn_Stand_Obr_File_list_GRS As String
    Public Aktivn_Stand_Obr_File_list_stand_GRS As String
    Public arr_length_Stand_Obr_GRS_sum As Integer


    Public Sub LocalizedForm()
        If My.Settings.language = "Русский" Then
            Form_Final_Table_Concentration.Text = "Окончательная таблица концентраций"
            Form_Final_Table_Concentration.Button_Draw_Graph.Text = "Построить график"
            Form_Final_Table_Concentration.Button_Save.Text = "Закрыть и сохранить в файл"
            Form_Final_Table_Concentration.B_Cancel.Text = "Отмена"

            Form_GRS_editor.Text = "Редактор ГРС"

            Form_GRS_editor.GroupBox3.Text = "Файловая система"
            Form_GRS_editor.B_Save_GRS.Text = "Cохранить групповой стандарт"
            Form_GRS_editor.BChFileForGRSEd.Text = "Выбрать файлы активностей"
            Form_GRS_editor.BLoadGRS.Text = "Загрузить существующий ГРС"

            Form_GRS_editor.GroupBox1.Text = "Редактирование"

            Form_GRS_editor.InvSel.Text = "Инвертировать выделение"
            Form_GRS_editor.B_Undelete_Last_String.Text = "Восстановить удалённую строку"
            Form_GRS_editor.B_Del_String.Text = "Удалить строку"

            Form_GRS_editor.GroupBox2.Text = "Создание и проверка"

            Form_GRS_editor.AutoGRS.Text = "Создать ГРС автоматически"
            Form_GRS_editor.CheckGRS.Text = "Проверить ГРС"
            Form_GRS_editor.B_Cancel.Text = "Отмена"

            Form_GRS_editor.GroupBox4.Text = "Информация"

            Form_Intermediate_Table_Concentration.Text = "Промежуточная таблица концентраций"
            Form_Intermediate_Table_Concentration.Button_Draw_Graph.Text = "Построить график"
            Form_Intermediate_Table_Concentration.Button_Save.Text = "Закрыть и сохранить в файл"
            Form_Intermediate_Table_Concentration.B_Cancel.Text = "Отмена"


            Me.TextBox_Coef.Text = "1.0"
            Me.Monitor_Activity_ToolStripMenuItem.Text = "Пересчёт активностей стандартов"
            Me.VibrBazFileAktMonitStand_MON_ToolStripMenuItem.Text = "Выбрать базовый файл активностей монитора стандарта"
            Me.OpenFileAktMonStand_MON_ToolStripMenuItem.Text = "Открыть файл активностей монитора стандарта"
            Me.OpenFileAktStand_MON_ToolStripMenuItem.Text = "Открыть файл(ы) активностей стандартов для пересчёта"
            Me.SavePereschAktStand_MON_ToolStripMenuItem.Text = "Сохранить пересчитанный файл(ы) активностей стандартов"
            Me.Concentration_ToolStripMenuItem.Text = "Концентрация"
            Me.OpenAktIsslObr_ToolStripMenuItem.Text = "Открыть файл(ы) активностей исследуемого образца"
            Me.OpenFileGrupStand_ToolStripMenuItem.Text = "Открыть файл группового стандарта"
            Me.VibrBazFileAktMonitStand_ToolStripMenuItem.Text = "Выбрать базовый файл активностей монитора стандарта"
            Me.OpenFileAktMonStand_ToolStripMenuItem.Text = "Открыть файл активностей монитора образца"
            Me.SaveConcIsslObr_ToolStripMenuItem.Text = "Сохранить файл(ы) концентраций элементов исследуемого образца"
            Me.OpenConcIsslObr_ToolStripMenuItem.Text = "Открыть файлы концентраций исследуемых образцов"
            Me.Clear_Form_ToolStripMenuItem.Text = "Очистить форму"
            Me.Table_Nuclides_ToolStripMenuItem.Text = "Таблица нуклидов"
            Me.GroupBox_L_Aktivnosti.Text = "Пересчёт активностей стандартов"
            Me.B_Perschet_Aktivn_Stand.Text = "Пересчитать и сохранить активности стандартов"
            Me.GroupBox_GroupStandart.Text = "Групповой стандарт"
            Me.B_make_Aktivn_Stand_Obr_GRS.Text = "Создать сводную таблицу активностей стандартных образцов"
            Me.GroupBox_Concentration.Text = "Концентрация"
            Me.B_Otm_Vib_Fil_Mon.Text = "Отменить выбор файлов мониторов"
            Me.L_Coef.Text = "Коэффициент изменения потока нейтронов:"
            Me.L_Name_System_Pogr.Text = "Систематическая погрешность, %:"
            Me.B_calc_conc.Text = "Рассчитать и сохранить концентрации"
            Me.B_TablConcElemPromezh_CON.Text = "Создать промежуточную таблицу концентраций элементов"
            Me.B_TablConcElemOkonchat_CON.Text = "Создать окончательную таблицу концентраций элементов"
            Me.L_SLI_Source.Text = "Источник данных КЖИ"
            RadioButtonFilter.Text = $"Рассчитать{vbCrLf}для фильтров"

            ButtonShowWOConc.Text = "Элементы без рассчитанных значений концентраций"

            Me.L_Aktivn_Issl_Obr.Text = "Файл(ы) активностей исследуемого образца: не выбран"
            Me.L_Grup_Stand.Text = "Файл группового стандарта: не выбран"
            Me.L_Baz_File_Akt_Mon_Stand.Text = "Базовый файл активностей монитора стандарта: не выбран"
            Me.L_File_Akt_Mon_Stand.Text = "Файл активностей монитора образца: не выбран"
            Me.L_Baz_File_Akt_Mon_Stand_MON.Text = "Базовый файл активностей монитора стандарта: не выбран"
            Me.L_File_Aktivn_Stand_Dlia_Peresch_MON.Text = "Файл(ы) активностей стандарта: не выбран"
            Me.L_File_Akt_Mon_Stand_MON.Text = "Файл активностей монитора стандарта: не выбран"
            Me.L_Conc_Issl_Obr_CON.Text = "Файлы концентраций элементов исследуемых образцов: не выбраны"

            Me.Text = "Программа расчета концентраций "




            Form_Table_Nuclides.Text = "Таблица нуклидов"
            Form_Table_Nuclides.B_Save_Table_Nuclides.Text = "Cохранить таблицу"
            Form_Table_Nuclides.B_Cancel.Text = "Отмена"
            Form_Table_Nuclides.ButAddNucl.Text = "Добавить новый элемент"
            Form_Table_Nuclides.ButDelNucl.Text = "Удалить выбранный элемент"
            Form_Table_Nuclides.ButRestoreDefaults.Text = "Восстановить таблицу со значениями по умолчанию"

            OpenFileDialog_Aktivn_Stand_Obr.Filter = "Файлы активностей (*.rpt)|*.rpt|Все файлы|*.*"
            OpenFileDialog_Akt_Mon_Stand.Filter = "Файлы активностей (*.rpt)|*.rpt|Все файлы|*.*"
            OpenFileDialog_Baz_File_Akt_Mon_Stand.Filter = "Файлы активностей (*.rpt)|*.rpt|Все файлы|*.*"
            OpenFileDialog_Akt_Stand_MON.Filter = "Файлы активностей (*.rpt)|*.rpt|Все файлы|*.*"
            OpenFileDialog_Akt_Mon_Stand_MON.Filter = "Файлы активностей (*.rpt)|*.rpt|Все файлы|*.*"
            OpenFileDialog_Baz_File_Akt_Mon_Stand_MON.Filter = "Файлы активностей (*.rpt)|*.rpt|Все файлы|*.*"
            OpenFileDialog_Aktivn_Issl_Obr.Filter = "Файлы активностей (*.rpt)|*.rpt|Все файлы|*.*"
            OpenFileDialog_Akt_Stand_Obr_GRS_2.Filter = "Файлы активностей (*.rpt)|*.rpt|Все файлы|*.*"
            SaveFileDialog_PereschAktStand_MON.Filter = "Файлы активностей (*.rpt)|*.rpt|Все файлы|*.*"

            OpenFileDialog_Sert_Conc_Elem.Filter = "Файлы сертифицированных концентраций (*.ref)|*.ref|Все файлы (*.*)|*.*"
            OpenFileDialog_Sert_Conc_Elem_GRS_1.Filter = "Файлы сертифицированных концентраций (*.ref)|*.ref|Все файлы (*.*)|*.*"
            OpenFileDialog_Sert_Conc_Elem_GRS_2.Filter = "Файлы сертифицированных концентраций (*.ref)|*.ref|Все файлы (*.*)|*.*"

            OpenFileDialog_Grup_Stand.Filter = "Файлы групповых стандартов (*.grs)|*.grs|Все файлы (*.*)|*.*"
            OpenFileDialog_Grup_Stand_GRS.Filter = "Файлы групповых стандартов (*.grs)|*.grs|Все файлы (*.*)|*.*"

            SaveFileDialog_Svodn_Akt_Stand_Obr_GRS.Filter = "Сводные файлы активностей стандартных образцов (*.sta)|*.sta|Все файлы (*.*)|*.*"

            OpenFileDialog_Conc_Issl_Obr_CON.Filter = "Файлы концентраций (*.con)|*.con|Все файлы (*.*)|*.*"
            SaveFileDialog_Conc_Elem.Filter = "Файлы концентраций (*.con)|*.con|Все файлы (*.*)|*.*"

            SaveFileDialog_TablProvStand_XLS_GRS.Filter = "Файлы Excel (*.xlsx)|*.xlsx|Все файлы (*.*)|*.*"
            SaveFileDialog_RasStandNaGrupStand_XLS_GRS.Filter = "Файлы Excel (*.xlsx)|*.xlsx|Все файлы (*.*)|*.*"
            SaveFileDialog_Tabl_Conc_Elem_Promezh_XLS_CON.Filter = "Файлы Excel (*.xlsx)|*.xlsx|Все файлы (*.*)|*.*"
            SaveFileDialog_Tabl_Conc_Elem_Okonchat_XLS_CON.Filter = "Файлы Excel (*.xlsx)|*.xlsx|Все файлы (*.*)|*.*"

            FormCheckGRS.BExportCheckTable.Text = "Сохранить в Excel"
            FormCheckGRS.CheckBoxPer.Text = "Показывать только расхождения более"

            Label1.Text = "Точность округления%:"

        Else

            Form_Final_Table_Concentration.Text = "Final table of concentration"
            Form_Final_Table_Concentration.Button_Draw_Graph.Text = "Construct graph"
            Form_Final_Table_Concentration.Button_Save.Text = "Close and save into file"
            Form_Final_Table_Concentration.B_Cancel.Text = "Cancel"

            Form_GRS_editor.Text = "GRS editor"

            Form_GRS_editor.GroupBox3.Text = "File managment"
            Form_GRS_editor.B_Save_GRS.Text = "Save group standard"
            Form_GRS_editor.BChFileForGRSEd.Text = "Choose rpt files"
            Form_GRS_editor.BLoadGRS.Text = "Load GRS"

            Form_GRS_editor.GroupBox1.Text = "Editing"

            Form_GRS_editor.InvSel.Text = "Invert selected row"
            Form_GRS_editor.B_Undelete_Last_String.Text = "Restore deleted line"
            Form_GRS_editor.B_Del_String.Text = "Delete line"

            Form_GRS_editor.GroupBox2.Text = "Checks and creation "

            Form_GRS_editor.AutoGRS.Text = "Create GRS automatically"
            Form_GRS_editor.CheckGRS.Text = "Check GRS"
            Form_GRS_editor.B_Cancel.Text = "Cancel"

            Form_GRS_editor.GroupBox4.Text = "Information"

            Form_Intermediate_Table_Concentration.Text = "Intermediate table of concentration"
            Form_Intermediate_Table_Concentration.Button_Draw_Graph.Text = "Construct graph"
            Form_Intermediate_Table_Concentration.Button_Save.Text = "Close and save into file"
            Form_Intermediate_Table_Concentration.B_Cancel.Text = "Cancel"

            Me.Monitor_Activity_ToolStripMenuItem.Text = "Calculation of standards activities"
            Me.VibrBazFileAktMonitStand_MON_ToolStripMenuItem.Text = "Choose the basic file of activities for standard monitor"
            Me.OpenFileAktMonStand_MON_ToolStripMenuItem.Text = "Open file of activities for standard monitor"
            Me.OpenFileAktStand_MON_ToolStripMenuItem.Text = "Open files of standards activities for calculations"
            Me.Concentration_ToolStripMenuItem.Text = "Concentration"
            Me.OpenAktIsslObr_ToolStripMenuItem.Text = "Open file of researching sample"
            Me.VibrBazFileAktMonitStand_ToolStripMenuItem.Text = "Choose basic file of standard monitor activity"
            Me.OpenFileAktMonStand_ToolStripMenuItem.Text = "Open files of standards activities for calculations"
            Me.SaveConcIsslObr_ToolStripMenuItem.Text = "Save file with concentrations"
            Me.OpenConcIsslObr_ToolStripMenuItem.Text = "Open CON files"
            Me.Table_Nuclides_ToolStripMenuItem.Text = "Nuclids table"
            Me.Clear_Form_ToolStripMenuItem.Text = "Re-launch application"
            Me.L_Aktivn_Issl_Obr.Text = "L_Aktivn_Issl_Obr"
            Me.B_calc_conc.Text = "Calculate and save concentrations"
            Me.L_Coef.Text = "Coefficient of neutrons flow changing"
            Me.TextBox_Coef.Text = "1.0"
            Me.B_TablConcElemOkonchat_CON.Text = "Create final table concentration"
            Me.B_TablConcElemPromezh_CON.Text = "Create intermediate table of concentration"
            Me.L_SLI_Source.Text = "SLI source"
            Me.L_Name_System_Pogr.Text = "Systematic error, %:"
            Me.TextBox_system_Pogr.Text = "0"
            Me.B_Otm_Vib_Fil_Mon.Text = "Cancel of choosing monitors files"
            Me.L_Conc_Issl_Obr_CON.Text = "L_Conc_Issl_Obr_CON"
            Me.L_File_Akt_Mon_Stand.Text = "L_File_Akt_Mon_Stand"
            Me.L_Baz_File_Akt_Mon_Stand.Text = "L_Baz_File_Akt_Mon_Stand"
            Me.L_Grup_Stand.Text = "L_Grup_Stand"
            Me.B_make_Aktivn_Stand_Obr_GRS.Text = "Open GRS editor"
            Me.L_File_Akt_Mon_Stand_MON.Text = "L_File_Akt_Mon_Stand_MON"
            Me.L_File_Aktivn_Stand_Dlia_Peresch_MON.Text = "L_File_Aktivn_Stand_Dlia_Peresch_MON"
            Me.B_Perschet_Aktivn_Stand.Text = "Recalculate and save standards activities"
            Me.L_Baz_File_Akt_Mon_Stand_MON.Text = "L_Baz_File_Akt_Mon_Stand_Monitor_MON"
            Me.GroupBox_L_Aktivnosti.Text = "Recalculation of standards activities"
            Me.GroupBox_GroupStandart.Text = "Group standard"
            Me.GroupBox_Concentration.Text = "Concentration"
            Me.Label1.Text = "Rounding accuracy %:"
            Me.TextBoxAcc.Text = "1"
            Me.Text = "Calculation of concentration "
            Me.SavePereschAktStand_MON_ToolStripMenuItem.Text = "Save counted file(s) of standards activity"
            Me.OpenFileGrupStand_ToolStripMenuItem.Text = "Open file of group standard"
            RadioButtonFilter.Text = $"Calculates{vbCrLf}for filters"
            ButtonShowWOConc.Text = "Elements without calculated concentration"



            Me.L_Aktivn_Issl_Obr.Text = "File(s) of observable sampl.s activity: not choosen"
            Me.L_Grup_Stand.Text = "File of group standard: not choosen"
            Me.L_Baz_File_Akt_Mon_Stand.Text = "Base file of standar.s monitor activity: not choosen"
            Me.L_File_Akt_Mon_Stand.Text = "File of sampl.s monitor activity: not choosen"
            Me.L_Baz_File_Akt_Mon_Stand_MON.Text = "Base file of standar.s monitor activity: not choosen"
            Me.L_File_Aktivn_Stand_Dlia_Peresch_MON.Text = "File(s) of standar.s activity: not choosen"
            Me.L_File_Akt_Mon_Stand_MON.Text = "File of standar.s monitor activity: not choosen"
            Me.L_Conc_Issl_Obr_CON.Text = "Files of element.s concentration of observable samples: not choosen"

            Form_Table_Nuclides.Text = "Table of nuclides"
            Form_Table_Nuclides.B_Save_Table_Nuclides.Text = "Save table"
            Form_Table_Nuclides.B_Cancel.Text = "Cancel"
            Form_Table_Nuclides.ButAddNucl.Text = "Add new element"
            Form_Table_Nuclides.ButDelNucl.Text = "Delete selected element"
            Form_Table_Nuclides.ButRestoreDefaults.Text = "Restore defaults table"

            OpenFileDialog_Aktivn_Stand_Obr.Filter = "Files of activity (*.rpt)|*.rpt|All files|*.*"
            OpenFileDialog_Akt_Mon_Stand.Filter = "Files of activity (*.rpt)|*.rpt|All files|*.*"
            OpenFileDialog_Baz_File_Akt_Mon_Stand.Filter = "Files of activity (*.rpt)|*.rpt|All files|*.*"
            OpenFileDialog_Akt_Stand_MON.Filter = "Files of activity (*.rpt)|*.rpt|All files|*.*"
            OpenFileDialog_Akt_Mon_Stand_MON.Filter = "Files of activity (*.rpt)|*.rpt|All files|*.*"
            OpenFileDialog_Baz_File_Akt_Mon_Stand_MON.Filter = "Files of activity (*.rpt)|*.rpt|All files|*.*"
            OpenFileDialog_Aktivn_Issl_Obr.Filter = "Files of activity (*.rpt)|*.rpt|All files|*.*"
            OpenFileDialog_Akt_Stand_Obr_GRS_2.Filter = "Files of activity (*.rpt)|*.rpt|All files|*.*"
            SaveFileDialog_PereschAktStand_MON.Filter = "Files of activity (*.rpt)|*.rpt|All files|*.*"

            OpenFileDialog_Sert_Conc_Elem.Filter = "Files of certificated concentrations (*.ref)|*.ref|All files (*.*)|*.*"
            OpenFileDialog_Sert_Conc_Elem_GRS_1.Filter = "Files of certificated concentrations (*.ref)|*.ref|All files (*.*)|*.*"
            OpenFileDialog_Sert_Conc_Elem_GRS_2.Filter = "Files of certificated concentrations (*.ref)|*.ref|All files (*.*)|*.*"

            OpenFileDialog_Grup_Stand.Filter = "Files of group standards (*.grs)|*.grs|All files (*.*)|*.*"
            OpenFileDialog_Grup_Stand_GRS.Filter = "Files of group standards (*.grs)|*.grs|All files (*.*)|*.*"

            SaveFileDialog_Svodn_Akt_Stand_Obr_GRS.Filter = "Summary files of standards's activity (*.sta)|*.sta|All files (*.*)|*.*"

            OpenFileDialog_Conc_Issl_Obr_CON.Filter = "Files of concentrations (*.con)|*.con|All files (*.*)|*.*"
            SaveFileDialog_Conc_Elem.Filter = "Files of concentrations (*.con)|*.con|All files (*.*)|*.*"

            SaveFileDialog_TablProvStand_XLS_GRS.Filter = "Files Excel (*.xlsx)|*.xlsx|All files (*.*)|*.*"
            SaveFileDialog_RasStandNaGrupStand_XLS_GRS.Filter = "Files Excel (*.xlsx)|*.xlsx|All files (*.*)|*.*"
            SaveFileDialog_Tabl_Conc_Elem_Promezh_XLS_CON.Filter = "Files Excel (*.xlsx)|*.xlsx|All files (*.*)|*.*"
            SaveFileDialog_Tabl_Conc_Elem_Okonchat_XLS_CON.Filter = "Files Excel (*.xlsx)|*.xlsx|All files (*.*)|*.*"


            FormCheckGRS.BExportCheckTable.Text = "Export to Excel"
            FormCheckGRS.CheckBoxPer.Text = "Show only values exceeding"

            Label1.Text = "Rounding accuracy %:"
        End If

        Me.Text += Application.ProductVersion
    End Sub

    Private Sub LangEngToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LangEngToolStripMenuItem.Click
        If LangEngToolStripMenuItem.Text = "Русский" Then
            LangEngToolStripMenuItem.Text = "English"
        Else
            LangEngToolStripMenuItem.Text = "Русский"
        End If
        My.Settings.language = LangEngToolStripMenuItem.Text
        LocalizedForm()
    End Sub

    Public Save_File_Conc_Po_Umolch As Boolean

    Function array_length_RPT(ByVal file_name_p As String) As Integer
        array_length_RPT = 0
        Try
            Using MyReader As New Microsoft.VisualBasic.FileIO.TextFieldParser(file_name_p, System.Text.Encoding.Default)
                MyReader.TextFieldType = FileIO.FieldType.Delimited
                MyReader.SetDelimiters(" ")
                Dim currentRow, currentRow_copy As String
                While Not MyReader.EndOfData
                    currentRow = MyReader.ReadLine
                    currentRow = currentRow.Trim 'удаляем пробелы в начале и конце строки, если они есть
                    While InStr(currentRow, "  ") > 0
                        currentRow = Replace(currentRow, "  ", " ")
                    End While
                    If currentRow = "Нуклид Достоверность Средневзвешенная Погрешность" Or currentRow = "Nuclide Wt mean Wt mean" Then
                        currentRow = MyReader.ReadLine
                        currentRow = currentRow.Trim 'удаляем пробелы в начале и конце строки, если они есть
                        While InStr(currentRow, "  ") > 0
                            currentRow = Replace(currentRow, "  ", " ")
                        End While
                        If currentRow = "идентификации активность," Or currentRow = "Nuclide Id Activity Activity" Then
                            currentRow = MyReader.ReadLine
                            currentRow = currentRow.Trim 'удаляем пробелы в начале и конце строки, если они есть
                            While InStr(currentRow, "  ") > 0
                                currentRow = Replace(currentRow, "  ", " ")
                            End While
                            If currentRow = "uCi /gram" Or currentRow = "Name Confidence (uCi/gram) Uncertainty" Then
                                currentRow = MyReader.ReadLine
                                If currentRow = "" Then
                                    'msgbox("Похоже, правильный формат файла активностей исследуемого образца!", MsgBoxStyle.Exclamation, Me.Text)
                                    currentRow = MyReader.ReadLine

a:                                  currentRow_copy = currentRow ' обход X и ? в файле rpt
                                    currentRow_copy = currentRow_copy.Trim() 'удаляем пробелы в начале и конце строки, если они есть
                                    While InStr(currentRow_copy, "  ") > 0
                                        currentRow_copy = Replace(currentRow_copy, "  ", " ") ' заменяем все двойные пробелы одинарными
                                    End While
                                    currentRow_copy = currentRow_copy + " " 'добавляем пробел в конец строки.
                                    If Mid(currentRow_copy, 1, InStr(1, currentRow_copy, " ") - 1) = "X" Then 'строки с крестами игнорируем
                                        currentRow = MyReader.ReadLine
                                        If currentRow <> "" Then 'отсекаем случай, когда строка с X последняя. Если этот оператор убрать, то Asc(Mid... будет давать ошибку
                                            If Asc(Mid(currentRow, 1, 1)) = 12 Then 'если после строчки с Х встретился символ разрыва страницы
                                                If currentRow.Substring(1, 5).ToUpper = "ОТЧЁТ" Or currentRow.Substring(1, 12).ToUpper = "INTERFERENCE" Then 'символ разрыва страницы не считается
                                                    currentRow = MyReader.ReadLine
                                                End If
                                            End If
                                        End If
                                    ElseIf Mid(currentRow_copy, 1, InStr(1, currentRow_copy, " ") - 1) = "?" Then 'строки с вопросами игнорируем
                                        currentRow = MyReader.ReadLine
                                        If currentRow <> "" Then 'отсекаем случай, когда строка с ? последняя.  Если этот оператор убрать, то Asc(Mid... будет давать ошибку
                                            If Asc(Mid(currentRow, 1, 1)) = 12 Then 'если после строчки с ? встретился символ разрыва страницы
                                                If currentRow.Substring(1, 5).ToUpper = "ОТЧЁТ" Or currentRow.Substring(1, 12).ToUpper = "INTERFERENCE" Then 'символ разрыва страницы не считается
                                                    currentRow = MyReader.ReadLine
                                                End If
                                            End If
                                        End If
                                    Else
                                        array_length_RPT = array_length_RPT + 1
                                        currentRow = MyReader.ReadLine
                                    End If

                                    If currentRow <> "" Then GoTo a
                                End If
                            End If
                        End If
                    End If
                End While
            End Using
        Catch ex As Exception
            If My.Settings.language = "Русский" Then
                MsgBox("Операция была отменена (ошибка в array_length_RPT)!", MsgBoxStyle.Critical, Me.Text)
            Else
                MsgBox("Operation was cancelled (error in array_length_RPT)!", MsgBoxStyle.Critical, Me.Text)
            End If
            Exit Function
        End Try
    End Function

    Private Sub ButtonShowWOConc_Click(sender As Object, e As EventArgs) Handles ButtonShowWOConc.Click
        Dim forAct As New FormWoConcTable
        forAct.Show()
        LocalizedForm()
        Debug.WriteLine("Show Table With Activity values:")


    End Sub

    Function array_length_RPT_MDA(ByVal file_name_p As String) As Integer
        array_length_RPT_MDA = 0
        Try
            Dim previous_nuclide As String
            previous_nuclide = ""
            Using MyReader As New Microsoft.VisualBasic.FileIO.TextFieldParser(file_name_p, System.Text.Encoding.Default)
                MyReader.TextFieldType = FileIO.FieldType.Delimited
                MyReader.SetDelimiters(" ")
                Dim currentRow, currentRow_copy As String
                While Not MyReader.EndOfData
                    currentRow = MyReader.ReadLine
                    currentRow = currentRow.Trim 'удаляем пробелы в начале и конце строки, если они есть
                    While InStr(currentRow, "  ") > 0
                        currentRow = Replace(currentRow, "  ", " ")
                    End While
                    If currentRow = "Нуклид Энергия, Выход, МДА линии, МДА нуклида, Активность," Or currentRow = "Nuclide Energy Yield Line MDA Nuclide MDA Activity" Then
                        currentRow = MyReader.ReadLine
                        currentRow = currentRow.Trim 'удаляем пробелы в начале и конце строки, если они есть
                        While InStr(currentRow, "  ") > 0
                            currentRow = Replace(currentRow, "  ", " ")
                        End While
                        If currentRow = "кэВ % uCi /gram uCi /gram uCi /gram" Or currentRow = "Name (keV) (%) (uCi/gram) (uCi/gram) (uCi/gram)" Then
                            currentRow = MyReader.ReadLine
                            If currentRow = "" Then
                                'msgbox("Похоже, правильный формат файла активностей исследуемого образца!", MsgBoxStyle.Exclamation, Me.Text)
                                currentRow = MyReader.ReadLine

a:                              currentRow_copy = currentRow ' обход > и @ в файле rpt
                                currentRow_copy = currentRow_copy.Trim() 'удаляем пробелы в начале и конце строки, если они есть
                                While InStr(currentRow_copy, "  ") > 0
                                    currentRow_copy = Replace(currentRow_copy, "  ", " ") ' заменяем все двойные пробелы одинарными
                                End While
                                currentRow_copy = currentRow_copy + " " 'добавляем пробел в конец строки
                                If Mid(currentRow_copy, 1, InStr(1, currentRow_copy, " ") - 1) = ">" Then 'строки с ">" игнорируем
                                    currentRow = MyReader.ReadLine
                                ElseIf Mid(currentRow_copy, 1, InStr(1, currentRow_copy, " ") - 1) = "@" Then 'строки с плюшками игнорируем
                                    currentRow = MyReader.ReadLine
                                Else
                                    For i = 0 To table_nuclides.GetLength(0) - 1 'размерность в нулевом измерении
                                        If Replace(Mid(currentRow_copy, 1, InStr(1, currentRow_copy, " ") - 1), ".", ",") = "+" Then 'обход + в файле rpt
                                            currentRow_copy = Replace(currentRow_copy, "+" + " ", "")
                                        End If
                                        If Mid(currentRow_copy, 1, InStr(1, currentRow_copy, " ") - 1).ToUpper = table_nuclides(i, 0) Then
                                            If Mid(currentRow_copy, 1, InStr(1, currentRow_copy, " ") - 1).ToUpper <> previous_nuclide Then
                                                previous_nuclide = Mid(currentRow_copy, 1, InStr(1, currentRow_copy, " ") - 1).ToUpper
                                                array_length_RPT_MDA = array_length_RPT_MDA + 1
                                            End If

                                            Exit For
                                        End If
                                    Next
                                    currentRow = MyReader.ReadLine
                                End If
                                If currentRow <> "" Then GoTo a
                            End If
                        End If
                    End If
                End While
            End Using
        Catch ex As Exception
            If My.Settings.language = "Русский" Then
                MsgBox("Операция была отменена (ошибка в array_length_RPT_MDA)!", MsgBoxStyle.Critical, Me.Text)
            Else
                MsgBox("Operation was cancelled (error in array_length_RPT_MDA)!", MsgBoxStyle.Critical, Me.Text)
            End If
            Exit Function
        End Try
    End Function

    Private Sub data_ident_RPT(ByVal currentRow_p As String, ByRef nuclide_p As String, ByRef element_p As String, ByRef dostovern_p As Single, ByRef aktivn_p As Single, ByRef pogreshn_p As Single)
        Try
            nuclide_p = ""
            element_p = ""
            dostovern_p = 0
            aktivn_p = 0
            pogreshn_p = 0

            currentRow_p = currentRow_p.Trim 'удаляем пробелы в начале и конце строки, если они есть
            While InStr(currentRow_p, "  ") > 0
                currentRow_p = Replace(currentRow_p, "  ", " ") ' заменяем все двойные пробелы одинарными
            End While
            currentRow_p = currentRow_p + " " 'добавляем пробел в конец строки

            'If Replace(Mid(currentRow_p, 1, InStr(1, currentRow_p, " ") - 1), ".", ",") = "X" Then 'обход X в файле rpt
            '    Exit Sub
            'Else
            nuclide_p = Mid(currentRow_p, 1, InStr(1, currentRow_p, " ") - 1)
            'nuclide_p = Replace(Mid(currentRow_p, 1, InStr(1, currentRow_p, " ") - 1), ".", ",")
            'End If
            Dim mask As String = nuclide_p.ToString.ToLower
            Dim num As String
            Try
                num = mask.Split("-")(1)
                element_p = Mid(nuclide_p, 1, InStr(1, nuclide_p, "-") - 1)
            Catch ex As Exception
                Debug.WriteLine(ex.ToString)
            End Try

            currentRow_p = Replace(currentRow_p, nuclide_p + " ", "", 1, 1)

            If Mid(currentRow_p, 1, InStr(1, currentRow_p, " ") - 1) = "@" Then 'обход @ в файле rpt
                currentRow_p = Replace(currentRow_p, "@" + " ", "", 1, 1)
                dostovern_p = Val(Mid(currentRow_p, 1, InStr(1, currentRow_p, " ") - 1))
                'только русские рег. параметры dostovern_p = CDbl(Replace(Mid(currentRow_p, 1, InStr(1, currentRow_p, " ") - 1), ".", ",", 1, 1))
            Else
                dostovern_p = Val(Mid(currentRow_p, 1, InStr(1, currentRow_p, " ") - 1))
                'только русские рег. параметры dostovern_p = CDbl(Replace(Mid(currentRow_p, 1, InStr(1, currentRow_p, " ") - 1), ".", ",", 1, 1))
            End If

            currentRow_p = Replace(currentRow_p, Mid(currentRow_p, 1, InStr(1, currentRow_p, " ") - 1) + " ", "", 1, 1)
            aktivn_p = Val(Mid(currentRow_p, 1, InStr(1, currentRow_p, " ") - 1))
            'только русские рег. параметры aktivn_p = CDbl(Replace(Mid(currentRow_p, 1, InStr(1, currentRow_p, " ") - 1), ".", ",", 1, 1))

            'Dim kk As Integer
            'kk = InStr(1, currentRow_p, " ") - 1

            'Dim kks As String
            'kks = Mid(currentRow_p, 1, InStr(1, currentRow_p, " ") - 1)
            'kks = Mid(currentRow_p, 1, kk)

            currentRow_p = Replace(currentRow_p, Mid(currentRow_p, 1, InStr(1, currentRow_p, " ") - 1) + " ", "", 1, 1)
            pogreshn_p = Val(Mid(currentRow_p, 1, InStr(1, currentRow_p, " ") - 1))
            'только русские рег. параметры pogreshn_p = CDbl(Replace(Mid(currentRow_p, 1, InStr(1, currentRow_p, " ") - 1), ".", ",", 1, 1))
        Catch ex As Exception
            MsgBox(ex.ToString)
            If My.Settings.language = "Русский" Then
                MsgBox("Операция была отменена (ошибка в data_ident_RPT)!", MsgBoxStyle.Critical, Me.Text)
            Else
                MsgBox("Operation was cancelled (error in data_ident_RPT)!", MsgBoxStyle.Critical, Me.Text)
            End If
            Exit Sub
        End Try
    End Sub

    Private Sub data_search_RPT(ByVal file_name_p As String, ByRef nucl_array_p(,) As String, ByRef data_array_p(,) As Single, ByRef sample_title_p As String, ByRef measurements_type_p As String)
        Try
            Dim nucl_count As Integer
            Dim currentRow, currentRow_copy As String
            Dim nuclide, element As String
            Dim aktivn, dostovern, pogreshn As Single
            nucl_count = 0
            nuclide = ""
            element = ""
            'Dim nfi As NumberFormatInfo = New CultureInfo("en-US", True).NumberFormat
            'nfi.NumberDecimalSeparator = "."
            Using MyReader As New Microsoft.VisualBasic.FileIO.TextFieldParser(file_name_p, System.Text.Encoding.Default)
                MyReader.TextFieldType = FileIO.FieldType.Delimited
                MyReader.SetDelimiters(" ")
                While Not MyReader.EndOfData
                    currentRow = MyReader.ReadLine
                    currentRow = currentRow.Trim 'удаляем пробелы в начале и конце строки, если они есть
                    While InStr(currentRow, "  ") > 0
                        currentRow = Replace(currentRow, "  ", " ") ' заменяем все двойные пробелы одинарными
                    End While
                    Try
                        If Mid(currentRow, 1, InStr(1, currentRow, ":") - 2) = "Имя образца" Or Mid(currentRow, 1, InStr(1, currentRow, ":") - 2) = "Sample Title" Then
                            sample_title_p = Mid(currentRow, (InStr(1, currentRow, ":") + 2))
                            currentRow = MyReader.ReadLine
                            currentRow = MyReader.ReadLine
                            currentRow = MyReader.ReadLine
                            currentRow = currentRow.Trim 'удаляем пробелы в начале и конце строки, если они есть
                            While InStr(currentRow, "  ") > 0
                                currentRow = Replace(currentRow, "  ", " ") ' заменяем все двойные пробелы одинарными
                            End While
                            Try
                                If Mid(currentRow, 1, InStr(1, currentRow, ":") - 2) = "Тип" Or Mid(currentRow, 1, InStr(1, currentRow, ":") - 2) = "Sample Type" Then
                                    measurements_type_p = Mid(currentRow, (InStr(1, currentRow, ":") + 2)).ToUpper
                                    Replace(measurements_type_p, " ", "")
                                    measurements_type_p = measurements_type_p.ToUpper
                                End If
                            Catch ex As Exception
                                Debug.WriteLine(ex.ToString)
                            End Try
                        End If
                    Catch ex As Exception
                        Debug.WriteLine(ex.ToString)
                    End Try
                    If currentRow = "Нуклид Достоверность Средневзвешенная Погрешность" Or currentRow = "Nuclide Wt mean Wt mean" Then
                        currentRow = MyReader.ReadLine
                        currentRow = currentRow.Trim 'удаляем пробелы в начале и конце строки, если они есть
                        While InStr(currentRow, "  ") > 0
                            currentRow = Replace(currentRow, "  ", " ") ' заменяем все двойные пробелы одинарными
                        End While
                        If currentRow = "идентификации активность," Or currentRow = "Nuclide Id Activity Activity" Then
                            currentRow = MyReader.ReadLine
                            currentRow = currentRow.Trim 'удаляем пробелы в начале и конце строки, если они есть
                            While InStr(currentRow, "  ") > 0
                                currentRow = Replace(currentRow, "  ", " ") ' заменяем все двойные пробелы одинарными
                            End While
                            If currentRow = "uCi /gram" Or currentRow = "Name Confidence (uCi/gram) Uncertainty" Then
                                currentRow = MyReader.ReadLine

                                If currentRow = "" Then
                                    'msgbox("Похоже, правильный формат файла активностей исследуемого образца!", MsgBoxStyle.Exclamation, Me.Text)
                                    currentRow = MyReader.ReadLine

a:                                  currentRow_copy = currentRow ' обход X и ? в файле rpt
                                    currentRow_copy = currentRow_copy.Trim() 'удаляем пробелы в начале и конце строки, если они есть
                                    While InStr(currentRow_copy, "  ") > 0
                                        currentRow_copy = Replace(currentRow_copy, "  ", " ") ' заменяем все двойные пробелы одинарными
                                    End While
                                    currentRow_copy = currentRow_copy + " " 'добавляем пробел в конец строки

                                    If Mid(currentRow_copy, 1, InStr(1, currentRow_copy, " ") - 1) = "X" Then 'строки с крестами игнорируем
                                        currentRow = MyReader.ReadLine
                                        If currentRow <> "" Then 'отсекаем случай, когда строка с X последняя. Если этот оператор убрать, то Asc(Mid... будет давать ошибку
                                            If Asc(Mid(currentRow, 1, 1)) = 12 Then 'сли после строчки с Х встретился символ разрыва страницы
                                                If currentRow.Substring(1, 5).ToUpper = "ОТЧЁТ" Or currentRow.Substring(1, 12).ToUpper = "INTERFERENCE" Then 'символ разрыва страницы не считается
                                                    currentRow = MyReader.ReadLine
                                                End If
                                            End If
                                        End If
                                    ElseIf Mid(currentRow_copy, 1, InStr(1, currentRow_copy, " ") - 1) = "?" Then 'строки с вопросами игнорируем
                                        currentRow = MyReader.ReadLine
                                        If currentRow <> "" Then 'отсекаем случай, когда строка с ? последняя. Если этот оператор убрать, то Asc(Mid... будет давать ошибку
                                            If Asc(Mid(currentRow, 1, 1)) = 12 Then 'сли после строчки с ? встретился символ разрыва страницы
                                                If currentRow.Substring(1, 5).ToUpper = "ОТЧЁТ" Or currentRow.Substring(1, 12).ToUpper = "INTERFERENCE" Then 'символ разрыва страницы не считается
                                                    currentRow = MyReader.ReadLine
                                                End If
                                            End If
                                        End If
                                    Else
                                        data_ident_RPT(currentRow, nuclide, element, dostovern, aktivn, pogreshn)
                                        If nuclide = "" Then
                                            currentRow = MyReader.ReadLine
                                        Else
                                            currentRow = currentRow + " " 'добавляем пробел в конец строки
                                            nucl_array_p(nucl_count, 0) = nuclide.ToUpper
                                            nucl_array_p(nucl_count, 1) = element.ToUpper
                                            data_array_p(nucl_count, 0) = dostovern
                                            data_array_p(nucl_count, 1) = aktivn
                                            data_array_p(nucl_count, 2) = pogreshn
                                            nucl_count = nucl_count + 1
                                            currentRow = MyReader.ReadLine
                                        End If

                                    End If

                                    If currentRow <> "" Then GoTo a

                                End If
                            End If
                        End If
                    End If
                End While
            End Using
        Catch ex As Exception
            If My.Settings.language = "Русский" Then
                MsgBox("Операция была отменена (ошибка в data_search_RPT)!", MsgBoxStyle.Critical, Me.Text)
            Else
                MsgBox("Operation was cancelled (error in data_search_RPT)!", MsgBoxStyle.Critical, Me.Text)
            End If
            Exit Sub
        End Try
    End Sub



    Private Sub Exit_ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Application.Exit()
    End Sub


    Private Sub OpenAktIsslObr_ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenAktIsslObr_ToolStripMenuItem.Click
        Try
            Dim L_Aktivn_Issl_Obr_File_list As String
            ' OpenFileDialog_Aktivn_Issl_Obr.InitialDirectory = "C:\GENIE2K\CONFILES"
            If OpenFileDialog_Aktivn_Issl_Obr.ShowDialog = System.Windows.Forms.DialogResult.Cancel Then
                If Not File_Aktivn_Issl_Obr_Select Then
                    If My.Settings.language = "Русский" Then
                        MsgBox("Файл(ы) активностей исследуемого образца не выбран!", MsgBoxStyle.Exclamation, Me.Text)
                    Else
                        MsgBox("File(s) of observable sample's activity not choosen!", MsgBoxStyle.Exclamation, Me.Text)
                    End If
                End If
                Exit Sub
            Else
                L_Aktivn_Issl_Obr_File_list = ""
                Aktivn_Issl_Obr_Files_Quant = OpenFileDialog_Aktivn_Issl_Obr.FileNames.Length
                ReDim file_name_Aktivn_Issl_Obr_Array(Aktivn_Issl_Obr_Files_Quant)
                ReDim file_name_Aktivn_Issl_Obr_SafeFileNames_Array(Aktivn_Issl_Obr_Files_Quant)
                ReDim file_name_Aktivn_Issl_Obr_Short_Array(Aktivn_Issl_Obr_Files_Quant)
                For i = 0 To Aktivn_Issl_Obr_Files_Quant - 1
                    file_name_Aktivn_Issl_Obr_Array(i) = OpenFileDialog_Aktivn_Issl_Obr.FileNames(i)
                    file_name_Aktivn_Issl_Obr_SafeFileNames_Array(i) = OpenFileDialog_Aktivn_Issl_Obr.SafeFileNames(i)
                    file_name_Aktivn_Issl_Obr_Short_Array(i) = OpenFileDialog_Aktivn_Issl_Obr.SafeFileNames(i)
                    file_name_Aktivn_Issl_Obr_Short_Array(i) = OpenFileDialog_Aktivn_Issl_Obr.SafeFileNames(i).ToUpper
                    file_name_Aktivn_Issl_Obr_Short_Array(i) = Replace(file_name_Aktivn_Issl_Obr_Short_Array(i), ".RPT", "")

                    If i <> Aktivn_Issl_Obr_Files_Quant - 1 Then
                        L_Aktivn_Issl_Obr_File_list = L_Aktivn_Issl_Obr_File_list + OpenFileDialog_Aktivn_Issl_Obr.SafeFileNames(i) + "; "
                    Else
                        L_Aktivn_Issl_Obr_File_list = L_Aktivn_Issl_Obr_File_list + OpenFileDialog_Aktivn_Issl_Obr.SafeFileNames(i)
                    End If
                    If OpenFileDialog_Aktivn_Issl_Obr.SafeFileNames(i) = file_name_Grup_Stand_SafeFileName Then
                        If My.Settings.language = "Русский" Then
                            MsgBox("Имя файла(ов) активностей исследуемого образца не должно совпадать с именем файла группового стандарта!", MsgBoxStyle.Exclamation, Me.Text)
                        Else
                            MsgBox("File(s) name of observable sample's activity should not coincide with file name of group standard!", MsgBoxStyle.Exclamation, Me.Text)
                        End If
                        Exit Sub
                    End If
                Next
            End If
            SaveConcIsslObr_ToolStripMenuItem.Enabled = False

            Dim first_File As System.IO.FileInfo
            first_File = My.Computer.FileSystem.GetFileInfo(OpenFileDialog_Aktivn_Issl_Obr.FileNames(0))
            OpenFileDialog_Aktivn_Issl_Obr.InitialDirectory = first_File.DirectoryName
            L_Aktivn_Issl_Obr.Text = ""
            L_Aktivn_Issl_Obr.Text += OpenFileDialog_Aktivn_Issl_Obr.InitialDirectory + "\" + L_Aktivn_Issl_Obr_File_list

            File_Aktivn_Issl_Obr_Select = True
            If (File_Aktivn_Issl_Obr_Select And File_Grup_Stand_Select) Then B_calc_conc.Enabled = True
            'If (File_Aktivn_Issl_Obr_Select And File_Aktivn_Stand_Obr_Select And File_Sert_Conc_Elem_Select) Then B_calc_conc.Enabled = True

        Catch ex As Exception
            If My.Settings.language = "Русский" Then
                MsgBox("Операция была отменена (ошибка в OpenAktIsslObr_ToolStripMenuItem_Click)!", MsgBoxStyle.Critical, Me.Text)
            Else
                MsgBox("Operation was cancelled (error in OpenAktIsslObr_ToolStripMenuItem_Click)!", MsgBoxStyle.Critical, Me.Text)
            End If
            Exit Sub
        End Try
    End Sub

    Function DataFromGrs(ByVal GrsName As String) As DataTable
        Try
            Debug.WriteLine($"GRS {GrsName} parsing:")
            Debug.WriteLine("{SRMName}|{elemName}|{RelInd}|{Act}|{ErrAct}|{Conc}|{ConcErr}|{StdErr}|{Num}")
            Dim rown As Integer = 1
            '    Dim RelInd, Act, ErrAct, Conc, ConcErr, StdErr As Double
            If grsTable.Columns.Count = 0 Then
                Dim grsKeys(0) As DataColumn
                Dim grsKeyColumn As New DataColumn()
                grsKeyColumn.ColumnName = "Key"
                grsKeys(0) = grsKeyColumn
                grsTable.Columns.Add(grsKeyColumn)
                grsTable.PrimaryKey = grsKeys


                If My.Settings.language = "Русский" Then
                    grsTable.Columns.Add("Имя образца")
                    grsTable.Columns.Add("nucl")
                    grsTable.Columns.Add("Достоверность идентификации", GetType(Double))
                    grsTable.Columns.Add("act", GetType(Double))
                    grsTable.Columns.Add("Погрешность, %", GetType(Double))
                    grsTable.Columns.Add("Паспортная концентрация, mg/kg", GetType(Double))
                    grsTable.Columns.Add("Паспортная погрешность, %", GetType(Double))
                    grsTable.Columns.Add("stdEr", GetType(Double))
                    grsTable.Columns.Add("NuclSort", GetType(Integer))
                    grsTable.Columns.Add("stdEr/Act", GetType(Double))
                Else
                    grsTable.Columns.Add("Sample name")
                    grsTable.Columns.Add("nucl")
                    grsTable.Columns.Add("Veracity of indetification", GetType(Double))
                    grsTable.Columns.Add("act", GetType(Double))
                    grsTable.Columns.Add("Error, %", GetType(Double))
                    grsTable.Columns.Add("Passport concentration, mg/kg", GetType(Double))
                    grsTable.Columns.Add("Passport error, %", GetType(Double))
                    grsTable.Columns.Add("stdEr", GetType(Double))
                    grsTable.Columns.Add("NuclSort", GetType(Integer))
                    grsTable.Columns.Add("stdEr/Act", GetType(Double))
                End If

                'grsTable.Columns.Add("Расчетная концентрация, mg/kg", GetType(Double))
            End If
            For Each line As String In File.ReadLines(GrsName, System.Text.Encoding.Default)
                Try
                    If IsNumeric(Convert.ToDouble(Split(line, vbTab)(2), CultureInfo.InvariantCulture)) Then
                        line = line.Replace(",", ".")
                        Dim values As New ArrayList
                        values.Add(Split(line, vbTab)(0) & "_" & Split(line, vbTab)(1))
                        values.Add(Split(line, vbTab)(0))
                        values.Add(Split(line, vbTab)(1))
                        For coln As Integer = 2 To Split(line, vbTab).Count - 1
                            values.Add(Double.Parse(Split(line, vbTab)(coln), CultureInfo.InvariantCulture))
                        Next

                        If Split(line, "_").Count = 7 Then
                            values.Add(Math.Sqrt(values(5) * values(5) + values(7) * values(7)))
                        End If
                        'проверка на m вконце
                        If values(2).ToString.Substring(values(2).ToString.Length - 1, 1) <> "m" Then
                            values.Add(Integer.Parse(Split(values(2), "-")(1)))
                            values.Add(values(8) / values(4))
                        Else
                            values.Add(Integer.Parse(Split(values(2).ToString.Substring(0, values(2).ToString.Length - 1), "-")(1)))
                            values.Add(values(8) / values(4))
                        End If
                        Debug.WriteLine($"{values(0)}, {values(1)}, {values(2)}, {values(3)}, {values(4)}, {values(5)}, {values(6)}, {values(7)}, {values(8)}, {values(9)}, {values(10)}")
                        grsTable.Rows.Add(values(0), values(1), values(2), values(3), values(4), values(5), values(6), values(7), values(8), values(9), values(10))
                    End If

                Catch ex As Exception
                    Debug.WriteLine(ex.ToString)
                    '  MsgBox(ex.ToString, MsgBoxStyle.Critical)
                End Try
            Next
            Return grsTable
        Catch ex As Exception
            MsgBox(ex.ToString)
            Return Nothing
        End Try
    End Function

    Private Sub B_calc_conc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_calc_conc.Click
        Debug.WriteLine("B_calc_conc click")
        rptTableMda.Clear()
        rptTablePeaks.Clear()
        grsTable.Clear()
        refTable.Clear()
        Dim Coef, system_Pogr As Single
        Try
            'только русские рег. параметры  Coef = CSng(Replace(TextBox_Coef.Text, ".", ","))
            Coef = Val(TextBox_Coef.Text)
        Catch ex As Exception
            If My.Settings.language = "Русский" Then
                MsgBox("Введите корректное значение коэффициента изменения потока нейтронов!", MsgBoxStyle.Exclamation, Me.Text)
            Else
                MsgBox("Enter correct value of coefficient of change of neutrons's flux!", MsgBoxStyle.Exclamation, Me.Text)
            End If
            Exit Sub
        End Try
        Try
            system_Pogr = Val(TextBox_system_Pogr.Text)
            'только русские рег. параметры system_Pogr = CSng(Replace(TextBox_system_Pogr.Text, ".", ","))
        Catch ex As Exception
            If My.Settings.language = "Русский" Then
                MsgBox("Введите корректное значение систематической погрешности!", MsgBoxStyle.Exclamation, Me.Text)
            Else
                MsgBox("Enter correct value of regular error!", MsgBoxStyle.Exclamation, Me.Text)
            End If
            Exit Sub
        End Try

        Try
            If system_Pogr >= 100 Then
                If My.Settings.language = "Русский" Then
                    MsgBox("Введите корректное значение систематической погрешности!", MsgBoxStyle.Exclamation, Me.Text)
                Else
                    MsgBox("Enter correct value of regular error!", MsgBoxStyle.Exclamation, Me.Text)
                End If
                Exit Sub
            End If

            FolderBrowserDialog_Conc_Elem.SelectedPath = OpenFileDialog_Aktivn_Issl_Obr.InitialDirectory

            If FolderBrowserDialog_Conc_Elem.ShowDialog = System.Windows.Forms.DialogResult.Cancel Then ' Эта строчка открывает диалог и сравнивает результат с cancel
                Exit Sub
            ElseIf System.Windows.Forms.DialogResult.OK Then ' Эта строчка только сравнивает результат с OK 

                measurements_type = ""
                Dim comment As String = ""

                For Each fileName In file_name_Aktivn_Issl_Obr_Array
                    rptTableMda.Clear()
                    rptTablePeaks.Clear()
                    If fileName = "" Then Exit Sub
                    Dim src As String() = DataFromRPT(fileName, False)
                    measurements_type = src(1)
                    If measurements_type = "" Then
                        If My.Settings.language = "Русский" Then
                            MsgBox("Поле 'Тип' в файле " + fileName + " пустое! Заполните его и повторите расчёт концентраций!", MsgBoxStyle.Critical, Me.Text)
                        Else
                            MsgBox("Field 'Type' in file " + fileName + " is empty! Fill it and repeat calculation of concentration!", MsgBoxStyle.Critical, Me.Text)
                        End If
                        Exit Sub
                    End If

                    If measurements_type <> "КЖИ-1" And measurements_type <> "SLI-1" And
                   measurements_type <> "КЖИ-2" And measurements_type <> "SLI-2" And
                   measurements_type <> "ДЖИ-1" And measurements_type <> "LLI-1" And
                   measurements_type <> "ДЖИ-2" And measurements_type <> "LLI-2" Then
                        If My.Settings.language = "Русский" Then
                            MsgBox("Поле 'Тип' в файле " + fileName + " содержит некорректные данные!", MsgBoxStyle.Critical, Me.Text)
                        Else
                            MsgBox("Field 'Type' in file " + fileName + " contains incorrect data!", MsgBoxStyle.Critical, Me.Text)
                        End If
                        Exit Sub
                    End If
                    Dim conTable As New DataTable
                    Dim actTable As New DataTable
                    Dim tempgrs As DataTable
                    tempgrs = DataFromGrs(file_name_Grup_Stand).Copy
                    conTable.Columns.Add("Элемент")
                    conTable.Columns.Add("Концентрация")
                    conTable.Columns.Add("Погрешность")
                    conTable.Columns.Add("Предел обнаружения")

                    actTable.Columns.Add("Элемент")
                    actTable.Columns.Add("Активность")
                    actTable.Columns.Add("Погрешность")
                    actTable.Columns.Add("Предел обнаружения")

                    Dim conc As Double
                    Dim concErr As Double
                    Dim lim As Double

                    For Each row As DataRow In tempgrs.Rows
                        Try
                            Debug.WriteLine($"{row(2)}")
                            'MsgBox(rptTableMda.Rows.Find(System.IO.Path.GetFileName(fileName) & "_" & src(0) & "_" & Split(row(0), "_")(1))(6))
                            'концентрацияОбразца=K*концентрацияЭталона*АктивностьОбразца/АктивностьЭталона
                            Debug.WriteLine($"conc: {Coef}_{row(6)}_{rptTablePeaks.Rows.Find(System.IO.Path.GetFileName(fileName) & "_" & src(0) & "_" & row(2))(4) / row(4)}")
                            conc = Coef * row(6) * rptTablePeaks.Rows.Find(System.IO.Path.GetFileName(fileName) & "_" & src(0) & "_" & row(2))(4) / row(4)
                        Catch ex As NullReferenceException
                            conc = 0
                        End Try
                        Try
                            'погрешность=100*корень_квадр(квадрат(погрешность_активности_образца/активность_образца)+квадрат(погрешность/100)+квадрат(погрешность_из_REF/100)+квадрат(систематическая_погрешность/100))
                            Debug.WriteLine($"err: {rptTablePeaks.Rows.Find(System.IO.Path.GetFileName(fileName) & "_" & src(0) & "_" & Split(row(0), "_")(1))(5)}_{row(7)}_{row(5)}{system_Pogr}")
                            concErr = 100 * Math.Sqrt((rptTablePeaks.Rows.Find(System.IO.Path.GetFileName(fileName) & "_" & src(0) & "_" & Split(row(0), "_")(1))(5) / 100) ^ 2 + (row(7) / 100) ^ 2 + (row(5) / 100) ^ 2 + (system_Pogr / 100) ^ 2)
                        Catch ex As NullReferenceException
                            concErr = 0
                        End Try
                        Try
                            Debug.WriteLine($"try to find {System.IO.Path.GetFileName(fileName) & "_" & src(0) & "_" & Split(row(0), "_")(1)} in rptTableMda")
                            'предел обнаружения=K*концентрация_из_REF*МДА_нуклида/средневзвешенная_активность_из_GRS
                            Debug.WriteLine($"limit: {Coef}_{row(6)}_{rptTableMda.Rows.Find(System.IO.Path.GetFileName(fileName) & "_" & src(0) & "_" & Split(row(0), "_")(1))(6) / row(4)}")
                            lim = Coef * row(6) * rptTableMda.Rows.Find(System.IO.Path.GetFileName(fileName) & "_" & src(0) & "_" & Split(row(0), "_")(1))(6) / row(4)
                        Catch ex As NullReferenceException
                            lim = 0
                        End Try
                        Debug.WriteLine($"{row(2)}, {Format(conc, "0.00E+00")}, {Format(concErr, "0.00")}, {Format(lim, "0.00E+00")}")
                        conTable.Rows.Add(row(2), Format(conc, "0.00E+00"), Format(concErr, "0.00"), Format(lim, "0.00E+00"))
                    Next

                    'check for nuclids which has found in sample, but hasn't found in standard:
                    Dim limit As Double = 0
                    Dim langStr = ""
                    If My.Settings.language = "Русский" Then
                        langStr = "Нуклид = "
                    Else
                        langStr = "Nuclid = "
                    End If
                    For Each row As DataRow In rptTablePeaks.Rows
                        limit = 0

                        If conTable.Select($"Элемент = '{row(2)}'").Count = 0 Then
                            If rptTableMda.Select($"{langStr}'{row(2)}'").Count > 0 Then
                                limit = rptTableMda.Select($"{langStr}'{row(2)}'")(0)(6)
                            End If
                            actTable.Rows.Add($"{row(2)}", Format(row(4), "0.00E+00"), Format(row(5), "0.00"), Format(limit, "0.00E+00"))
                        End If
                    Next

                    ' save to file
                    Dim outputString As String = $"{vbTab}{vbTab}"
                    ' Return {NameSamp, mesType, experimentator, id, geometry}
                    Using sw As New IO.StreamWriter($"{FolderBrowserDialog_Conc_Elem.SelectedPath}/{System.IO.Path.GetFileNameWithoutExtension(fileName)}.CON")
                        sw.WriteLine("*************************************************************************")
                        If My.Settings.language = "Русский" Then
                            sw.WriteLine("*****                    РАСЧЕТ КОНЦЕНТРАЦИЙ ЭЛЕМЕНТОВ              *****")
                            sw.WriteLine("*************************************************************************")
                            sw.WriteLine()
                            sw.WriteLine($"Дата создания файла			     : {Date.Now}")
                            sw.WriteLine($"Имя образца                      : {src(0)}")
                            sw.WriteLine($"Описание                         : {src(2)}")
                            sw.WriteLine($"Код                              : {src(3)}")
                            sw.WriteLine($"Тип                              : {src(1)}")
                            sw.WriteLine($"Геометрия                        : {src(4)}")
                            sw.WriteLine($"Групповой стандарт               : {System.IO.Path.GetFileName(file_name_Grup_Stand)}")
                            sw.WriteLine()
                            sw.WriteLine("*************************************************************************")
                            sw.WriteLine("*****           ЗНАЧЕНИЯ КОНЦЕНТРАЦИЙ ЭЛЕМЕНТОВ В ОБРАЗЦЕ           *****")
                            sw.WriteLine("*************************************************************************")
                            sw.WriteLine()
                            sw.WriteLine("		элемент	концентр.,	погр.,	предел")
                            If Not RadioButtonFilter.Checked Then
                                sw.WriteLine("					uг/гр		%	обнаруж.,")
                                sw.WriteLine("										uг/гр")
                            Else
                                sw.WriteLine("					мк.гр  		%	обнаруж.,")
                                sw.WriteLine("										мк.гр")
                            End If
                            sw.WriteLine()
                            Else
                                sw.WriteLine("*****            CALCULATION CONCENTRATIONS OF ELEMENTS             *****")
                            sw.WriteLine("*************************************************************************")
                            sw.WriteLine()
                            sw.WriteLine($"DateTime creation of file		 : {Date.Now}")
                            sw.WriteLine($"Sample name                      : {src(0)}")
                            sw.WriteLine($"Description                      : {src(2)}")
                            sw.WriteLine($"Id                               : {src(3)}")
                            sw.WriteLine($"Type                             : {src(1)}")
                            sw.WriteLine($"Geometry                         : {src(4)}")
                            sw.WriteLine($"GRS                              : {System.IO.Path.GetFileName(file_name_Grup_Stand)}")
                            sw.WriteLine()
                            sw.WriteLine("*************************************************************************")
                            sw.WriteLine("*****          CONCENTRATIONS VALUES OF ELEMENTS IN SAMPLE          *****")
                            sw.WriteLine("*************************************************************************")
                            sw.WriteLine()
                            sw.WriteLine("		element	concentr.,	err.,	detection")
                            If Not RadioButtonFilter.Checked Then
                                sw.WriteLine("					ug/gr		%	limit.,")
                                sw.WriteLine("									  ug/gr")
                            Else
                                sw.WriteLine("					ug          %	limit.,")
                                sw.WriteLine("								         ug")
                            End If

                            sw.WriteLine()
                        End If
                        For i As Integer = 0 To conTable.Rows.Count - 1
                            For j As Integer = 0 To conTable.Columns.Count - 1
                                outputString = outputString & vbTab & Replace(conTable(i)(j), ",", ".")
                            Next
                            sw.WriteLine(outputString.Substring(1, outputString.Length - 1))
                            outputString = $"{vbTab}{vbTab}"
                        Next
                        sw.WriteLine()
                        sw.WriteLine()
                        If My.Settings.language = "Русский" Then
                            sw.WriteLine("*************************************************************************")
                            sw.WriteLine("*****        ЭЛЕМЕНТЫ БЕЗ РАССЧИТАННЫХ ЗНАЧЕНИЙ КОНЦЕНТРАЦИЙ        *****")
                            sw.WriteLine("*************************************************************************")
                            sw.WriteLine()
                            sw.WriteLine("		элемент	активност.,	погр.,	предел")
                            sw.WriteLine("				uCi/gram		%	обнаруж.,")
                            sw.WriteLine("									uCi/gram")
                        Else
                            sw.WriteLine("*************************************************************************")
                            sw.WriteLine("*****                ELEMENTS WITHOUT CONCENTRATIONS                *****")
                            sw.WriteLine("*************************************************************************")
                            sw.WriteLine()
                            sw.WriteLine("		element	activity.,	err.,	detection")
                            sw.WriteLine("				uCi/gram		%	limit.,")
                            sw.WriteLine("									uCi/gram")
                        End If
                        sw.WriteLine()
                        For i As Integer = 0 To actTable.Rows.Count - 1
                            For j As Integer = 0 To actTable.Columns.Count - 1
                                outputString = outputString & vbTab & Replace(actTable(i)(j), ",", ".")
                            Next
                            sw.WriteLine(outputString.Substring(1, outputString.Length - 1))
                            outputString = $"{vbTab}{vbTab}"
                        Next

                    End Using
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
            Exit Sub
        End Try
    End Sub

    Private Sub TextBox_Coef_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox_Coef.KeyPress
        Try
            Dim numberFormatInfo As NumberFormatInfo = System.Globalization.CultureInfo.CurrentCulture.NumberFormat
            Dim decimalSeparator As String = numberFormatInfo.NumberDecimalSeparator
            Dim groupSeparator As String = numberFormatInfo.NumberGroupSeparator
            Dim keyInput As String = e.KeyChar.ToString()
            If [Char].IsDigit(e.KeyChar) Then
                ' Digits are OK
            ElseIf keyInput.Equals(decimalSeparator) OrElse keyInput.Equals(groupSeparator) OrElse keyInput.Equals(".") Then
                ' Decimal separator is OK
            ElseIf e.KeyChar = vbBack Then
                ' Backspace key is OK
                '    else if ((ModifierKeys & (Keys.Control | Keys.Alt)) != 0)
                '    {
                '     // Let the edit control handle control and alt key combinations
                '    }
            Else
                ' Consume this invalid key and beep.
                e.Handled = True
            End If
        Catch ex As Exception
            If My.Settings.language = "Русский" Then
                MsgBox("Операция была отменена (ошибка в TextBox_Coef_KeyPress)!", MsgBoxStyle.Critical, Me.Text)
            Else
                MsgBox("Operation was cancelled (error in TextBox_Coef_KeyPress)!", MsgBoxStyle.Critical, Me.Text)
            End If
            Exit Sub
        End Try
    End Sub

    Private Sub SaveConcIsslObr_ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveConcIsslObr_ToolStripMenuItem.Click
        Try
            Dim current_string As String
            Dim DI As IO.DirectoryInfo = New IO.DirectoryInfo("C:\GENIE2K\CONFILES")
            If DI.Exists Then
            Else
                MkDir("C:\GENIE2K\CONFILES")
            End If
            Dim DIK As IO.DirectoryInfo = New IO.DirectoryInfo("C:\GENIE2K\CONFILES\KJI")
            If DIK.Exists Then
            Else
                MkDir("C:\GENIE2K\CONFILES\KJI")
            End If
            Dim DIJ1 As IO.DirectoryInfo = New IO.DirectoryInfo("C:\GENIE2K\CONFILES\DJI1")
            If DIJ1.Exists Then
            Else
                MkDir("C:\GENIE2K\CONFILES\DJI1")
            End If
            Dim DIJ2 As IO.DirectoryInfo = New IO.DirectoryInfo("C:\GENIE2K\CONFILES\DJI2")
            If DIJ2.Exists Then
            Else
                MkDir("C:\GENIE2K\CONFILES\DJI2")
            End If

            ' SaveFileDialog_Conc_Elem.InitialDirectory = "C:\GENIE2K\CONFILES"
            If Save_File_Conc_Po_Umolch = False Then
                SaveFileDialog_Conc_Elem.FileName = file_name_Aktivn_Issl_Obr_Short_Array(m_glob) + ".CON"
                SaveFileDialog_Conc_Elem.FileName = SaveFileDialog_Conc_Elem.FileName.ToUpper
            ElseIf Save_File_Conc_Po_Umolch = True Then
                SaveFileDialog_Conc_Elem.FileName = Path_To_Folder_glob + file_name_Aktivn_Issl_Obr_Short_Array(m_glob) + ".CON"
                SaveFileDialog_Conc_Elem.FileName = SaveFileDialog_Conc_Elem.FileName.ToUpper
            End If

            If Save_File_Conc_Po_Umolch = True Then
                GoTo 1
            End If

            If SaveFileDialog_Conc_Elem.ShowDialog = System.Windows.Forms.DialogResult.Cancel Then ' Эта строчка открывает диалог и сравнивает результат с cancel 
                Exit Sub
            ElseIf System.Windows.Forms.DialogResult.OK Then ' Эта строчка только сравнивает результат с OK 

1:              If My.Settings.language = "Русский" Then
                    My.Computer.FileSystem.WriteAllText(SaveFileDialog_Conc_Elem.FileName, "Концентрации элементов в образце  :  " + sample_title_Issl_Obr + vbCrLf + vbCrLf, False) 'vbCrLf - символ перевода строки
                    My.Computer.FileSystem.WriteAllText(SaveFileDialog_Conc_Elem.FileName, "Тип измерений  :  " + measurements_type + vbCrLf + vbCrLf, True) 'vbCrLf - символ перевода строки
                    My.Computer.FileSystem.WriteAllText(SaveFileDialog_Conc_Elem.FileName, "Групповой стандарт  :  " + file_name_Grup_Stand_SafeFileName + vbCrLf + vbCrLf, True) 'vbCrLf - символ перевода строки
                    My.Computer.FileSystem.WriteAllText(SaveFileDialog_Conc_Elem.FileName, "элемент" + vbTab + "концентр.," + vbTab + "погр.," + vbTab + "предел" + vbCrLf, True)
                    My.Computer.FileSystem.WriteAllText(SaveFileDialog_Conc_Elem.FileName, vbTab + "uг/гр" + vbTab + vbTab + "%" + vbTab + "обнаруж.," + vbCrLf, True)
                    My.Computer.FileSystem.WriteAllText(SaveFileDialog_Conc_Elem.FileName, vbTab + vbTab + vbTab + vbTab + "uг/гр" + vbCrLf + vbCrLf, True)
                Else
                    My.Computer.FileSystem.WriteAllText(SaveFileDialog_Conc_Elem.FileName, "Concentrations of elements in sample  :  " + sample_title_Issl_Obr + vbCrLf + vbCrLf, False) 'vbCrLf - символ перевода строки
                    My.Computer.FileSystem.WriteAllText(SaveFileDialog_Conc_Elem.FileName, "Measuremnts type  :  " + measurements_type + vbCrLf + vbCrLf, True) 'vbCrLf - символ перевода строки
                    My.Computer.FileSystem.WriteAllText(SaveFileDialog_Conc_Elem.FileName, "Group standard  :  " + file_name_Grup_Stand_SafeFileName + vbCrLf + vbCrLf, True) 'vbCrLf - символ перевода строки
                    My.Computer.FileSystem.WriteAllText(SaveFileDialog_Conc_Elem.FileName, "element" + vbTab + "concentr.," + vbTab + "uncer.," + vbTab + "detect." + vbCrLf, True)
                    My.Computer.FileSystem.WriteAllText(SaveFileDialog_Conc_Elem.FileName, vbTab + "ug/gr" + vbTab + vbTab + "%" + vbTab + "limit," + vbCrLf, True)
                    My.Computer.FileSystem.WriteAllText(SaveFileDialog_Conc_Elem.FileName, vbTab + vbTab + vbTab + vbTab + "ug/gr" + vbCrLf + vbCrLf, True)
                End If

                For i = 0 To arr_length_count_Conc - 1
                    current_string = ""

                    'If nucl(i) = "CO-58" Then nucl(i) = "NI-58"
                    'If nucl(i) = "AL-29" Then nucl(i) = "SI-29"
                    'If nucl(i) = "NP-239" Then nucl(i) = "U-238"
                    'If nucl(i) = "PA-233" Then nucl(i) = "TH-233"

                    current_string = nucl(i) + vbTab
                    current_string = current_string + conc(i, 0).ToString("E2", CultureInfo.CreateSpecificCulture("en-US")) + vbTab
                    'If conc(i, 0) = 0 Then
                    '    current_string = current_string + "---------" + vbTab
                    'Else
                    '    current_string = current_string + conc(i, 0).ToString("E2", CultureInfo.CreateSpecificCulture("en-US")) + vbTab
                    'End If

                    current_string = current_string + conc(i, 1).ToString("F2", CultureInfo.CreateSpecificCulture("en-US")) + vbTab
                    'If conc(i, 1) = 0 Then
                    '    current_string = current_string + "-----" + vbTab
                    'Else
                    '    current_string = current_string + conc(i, 1).ToString("F2", CultureInfo.CreateSpecificCulture("en-US")) + vbTab
                    'End If

                    current_string = current_string + conc(i, 2).ToString("E2", CultureInfo.CreateSpecificCulture("en-US")) + vbCrLf

                    My.Computer.FileSystem.WriteAllText(SaveFileDialog_Conc_Elem.FileName, current_string, True)
                Next

                'изменяем начальную директорию, на ту, в которую сохранили первый файл
                Dim current_File As System.IO.FileInfo
                current_File = My.Computer.FileSystem.GetFileInfo(SaveFileDialog_Conc_Elem.FileName)
                SaveFileDialog_Conc_Elem.InitialDirectory = current_File.DirectoryName

            End If
        Catch ex As Exception
            If My.Settings.language = "Русский" Then
                MsgBox("Операция была отменена (ошибка в SaveConcIsslObr_ToolStripMenuItem_Click)!", MsgBoxStyle.Critical, Me.Text)
            Else
                MsgBox("Operation was cancelled (error in SaveConcIsslObr_ToolStripMenuItem_Click)!", MsgBoxStyle.Critical, Me.Text)
            End If
            Exit Sub
        End Try
    End Sub

    Public grsTable, refTable, rptTablePeaks, rptTableMda As New DataTable

    Private Sub B_make_Aktivn_Stand_Obr_GRS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_make_Aktivn_Stand_Obr_GRS.Click
        Form_GRS_editor.Show()
    End Sub

    Public GRSName As String = ""
    Public FileInfoDict As New Dictionary(Of String, ArrayList)

    Function DataFromRPT(ByVal fileName As String, ByVal calcConcFlag As Boolean) As String()
        Try
            If System.IO.Path.GetExtension(fileName) = ".RPT" Then
                If refTable.Columns.Count = 0 Then
                    'refTale
                    Dim refKeys(0) As DataColumn
                    Dim refKeyColumn As New DataColumn()
                    refKeyColumn.ColumnName = "Key"
                    refKeys(0) = refKeyColumn
                    refTable.Columns.Add(refKeyColumn)
                    refTable.PrimaryKey = refKeys
                    If My.Settings.language = "Русский" Then
                        refTable.Columns.Add("Имя образца")
                        refTable.Columns.Add("Нуклид")
                        refTable.Columns.Add("Паспортная концентрация, mg/kg", GetType(Double))
                        refTable.Columns.Add("Паспортная погрешность, %", GetType(Double))
                    Else
                        refTable.Columns.Add("Sample name")
                        refTable.Columns.Add("Nuclid")
                        refTable.Columns.Add("Passport concentration, mg/kg", GetType(Double))
                        refTable.Columns.Add("Passport error, %", GetType(Double))
                    End If

                End If
                If rptTablePeaks.Columns.Count = 0 Then
                    'rptTablePeaks
                    Dim peakKeys(0) As DataColumn
                    Dim peakKeyColumn As New DataColumn()
                    peakKeyColumn.ColumnName = "Key"
                    peakKeys(0) = peakKeyColumn
                    rptTablePeaks.Columns.Add(peakKeyColumn)
                    rptTablePeaks.PrimaryKey = peakKeys
                    If My.Settings.language = "Русский" Then
                        rptTablePeaks.Columns.Add("Имя образца")
                        rptTablePeaks.Columns.Add("Нуклид")
                        rptTablePeaks.Columns.Add("Достоверность идентификации", GetType(Double))
                        rptTablePeaks.Columns.Add("Средне-взвешенная активность, uCi/gram", GetType(Double))
                        rptTablePeaks.Columns.Add("Погрешность, %", GetType(Double))
                        rptTablePeaks.Columns.Add("nuclSort", GetType(Integer))
                    Else
                        rptTablePeaks.Columns.Add("Sample name")
                        rptTablePeaks.Columns.Add("Nuclid")
                        rptTablePeaks.Columns.Add("Veracity of identification", GetType(Double))
                        rptTablePeaks.Columns.Add("Weighted average activity, uCi/gram", GetType(Double))
                        rptTablePeaks.Columns.Add("Error, %", GetType(Double))
                        rptTablePeaks.Columns.Add("nuclSort", GetType(Integer))
                    End If

                End If
                If rptTableMda.Columns.Count = 0 Then
                    'rptTableMda
                    Dim mdaKeys(0) As DataColumn
                    Dim mdaKeyColumn As New DataColumn()
                    mdaKeyColumn.ColumnName = "Key"
                    mdaKeys(0) = mdaKeyColumn
                    rptTableMda.Columns.Add(mdaKeyColumn)
                    rptTableMda.PrimaryKey = mdaKeys
                    If My.Settings.language = "Русский" Then
                        rptTableMda.Columns.Add("Имя образца")
                        rptTableMda.Columns.Add("Нуклид")
                        rptTableMda.Columns.Add("Энергия, кэВ", GetType(Double))
                        rptTableMda.Columns.Add("Выход, %", GetType(Double))
                        rptTableMda.Columns.Add("МДА линии, mg/kg", GetType(Double))
                        rptTableMda.Columns.Add("МДА нуклида, mg/kg", GetType(Double))
                        rptTableMda.Columns.Add("Активность, uCi /gram", GetType(Double))
                    Else
                        rptTableMda.Columns.Add("Sample name")
                        rptTableMda.Columns.Add("Nuclid")
                        rptTableMda.Columns.Add("Energy, кэВ", GetType(Double))
                        rptTableMda.Columns.Add("Output, %", GetType(Double))
                        rptTableMda.Columns.Add("MDA line, mg/kg", GetType(Double))
                        rptTableMda.Columns.Add("MDA nuclid, mg/kg", GetType(Double))
                        rptTableMda.Columns.Add("Activity, uCi /gram", GetType(Double))
                    End If

                End If

                Dim Coef As Double = Val(TextBox_Coef.Text)
                Dim startGrsFlag As Boolean = False
                Dim startMdaFlag As Boolean = False

                Dim NameSamp As String = ""
                Dim LastNuclid As String = ""
                Dim mesType As String = ""
                Dim experimentator As String = ""
                Dim id As String = ""
                Dim geometry As String = ""

                Dim nuclid As String = ""
                Dim nuclNum As Integer
                'peaks
                Dim relInd, meanAct, std As Double
                Dim elem As Regex = New Regex("[A-Z]{1,2}-\d{2,3}[m]{0,1}")
                Dim req As Regex = New Regex("\d.\d{3}")
                Dim act As Regex = New Regex("\d.\d{6}E[+-]\d{3}")
                Dim num As Regex = New Regex("\d{2,3}")
                'ref
                Dim PasConc, PassErr As Double
                Dim ppm As Regex = New Regex("\d{1,8}.{0,1}\d{0,3}")
                Dim err As Regex = New Regex("\d{1,2}.{0,1}\d{0,2}\Z")
                'mda
                Dim energy, output, MdaNucl, MdaLine, Activity As Double
                'Dim MdaNucl As String = ""
                Dim enrg_otpt As Regex = New Regex("\d{1,5}.\d{2}")
                Dim mdln_act As Regex = New Regex("\d.\d{4}E[+-]\d{3}")
                Dim mdncl As Regex = New Regex("\d.\d{2}E[+-]\d{3}")
                Dim element As String = ""
                Dim FileInfo As New ArrayList
                Dim excp As New Dictionary(Of String, String)

                Debug.WriteLine($"Parsing of {fileName}")
                For Each line As String In File.ReadLines(fileName, System.Text.Encoding.Default)
                    If Not String.IsNullOrEmpty(line) And line.Trim.Length > 8 Then
                        If line.StartsWith("Дата создания") Or line.StartsWith("Report") Then
                            FileInfo.Add(line.Trim)
                        ElseIf line.StartsWith("Имя образца") Or line.StartsWith("Sample Title") Then
                            NameSamp = StrPars.Right(Trim(line), Trim(line).Length - Trim(line).LastIndexOf(" ") - 1)
                        ElseIf line.StartsWith("Описание") Or line.StartsWith("Sample Description") Then
                            experimentator = StrPars.Right(Trim(line), Trim(line).Length - Trim(line).LastIndexOf(" ") - 1)
                            FileInfo.Add(Split(line, ":")(0).Trim & ":" & Split(line, ":")(1))
                        ElseIf line.StartsWith("Код") Or line.StartsWith("Sample Identification") Then
                            id = StrPars.Right(Trim(line), Trim(line).Length - Trim(line).LastIndexOf(" ") - 1)
                            FileInfo.Add(Split(line, ":")(0).Trim & ":" & Split(line, ":")(1))
                        ElseIf line.StartsWith("Тип") Or line.StartsWith("Sample Type") Then
                            mesType = StrPars.Right(Trim(line), Trim(line).Length - Trim(line).LastIndexOf(" ") - 1)
                            FileInfo.Add(Split(line, ":")(0).Trim & ":" & Split(line, ":")(1))
                        ElseIf line.StartsWith("Геометрия") Or line.StartsWith("Sample Geometry") Then
                            geometry = StrPars.Right(Trim(line), Trim(line).Length - Trim(line).LastIndexOf(" ") - 1)
                            FileInfo.Add(Split(line, ":")(0).Trim & ":" & Split(line, ":")(1))
                        ElseIf String.Equals(Replace(line, "*", "").Trim, "Нуклид Достоверность Средневзвешенная  Погрешность") Or String.Equals(Replace(line, "*", "").Trim, "Nuclide       Wt mean         Wt mean") Then
                            Debug.WriteLine("Start interference peaks parsing:")
                            Debug.WriteLine("{nuclid}|{relInd}|{meanAct}|{std}|{nuclNum}")
                            startGrsFlag = True
                            line = Replace(line, "*", "").Trim
                        ElseIf String.Equals(Replace(line, " ", "").Trim, "НуклидЭнергия,Выход,МДАлинии,МДАнуклида,Активность,") Or String.Equals(Replace(line, " ", "").Trim, "NuclideEnergyYieldLineMDANuclideMDAActivity") Then
                            startMdaFlag = True
                            Debug.WriteLine("Start Mda parsing:")
                            Debug.WriteLine("{nuclid}|{energy}|{output}|{MdaLine}|{MdaNucl}|{Activity}")
                        ElseIf Replace(line, "*", "").Trim = "НЕИДЕНТИФИЦИРОВАННЫЕ ПИКИ" Or Replace(line, "*", "").Trim = "U N I D E N T I F I E D   P E A K S" Then
                            startGrsFlag = False
                        ElseIf startGrsFlag And elem.IsMatch(line.Trim.Substring(0, 7).Trim) And line.Substring(4, 1) = " " Then
                            nuclid = elem.Match(line).Value
                            relInd = Convert.ToDouble(req.Match(line).Value, CultureInfo.InvariantCulture)
                            meanAct = Convert.ToDouble(act.Match(line).Value, CultureInfo.InvariantCulture)
                            std = 100 * Convert.ToDouble(act.Matches(line).Item(1).Value, CultureInfo.InvariantCulture) / Convert.ToDouble(act.Match(line).Value, CultureInfo.InvariantCulture)
                            nuclNum = Convert.ToInt16(num.Match(line).Value)
                            Debug.WriteLine($"{nuclid}|{relInd}|{meanAct}|{std}|{nuclNum}")
                            Try
                                rptTablePeaks.Rows.Add(System.IO.Path.GetFileName(fileName) & "_" & NameSamp & "_" & nuclid, NameSamp, nuclid, relInd, meanAct, std, nuclNum)
                            Catch ce As ConstraintException
                                Debug.WriteLine(ce.ToString)
                            Catch ex As Exception
                                MsgBox(ex.ToString, MsgBoxStyle.Critical)
                            End Try
                        ElseIf startMdaFlag Then
                            Debug.WriteLine($"Line for parsing is {line}")
                            line = line.Substring(10, line.Length - 10)
                            line = Regex.Replace(line, "[*>]", String.Empty).Trim
                            If line = String.Empty Then
                                Exit For
                            End If
                            If Not elem.IsMatch(line.Substring(0, 7)) Then
                                Continue For
                            Else
                                Debug.WriteLine($"{line} was cut to:")
                                Debug.WriteLine($"      {line.Substring(0, 7)} for matching with elem regexp")
                            End If
                            nuclid = elem.Match(line.Substring(0, 7)).Value
                            energy = Convert.ToDouble(enrg_otpt.Matches(line).Item(0).Value, CultureInfo.InvariantCulture)
                            output = Convert.ToDouble(enrg_otpt.Matches(line).Item(1).Value, CultureInfo.InvariantCulture)
                            MdaLine = Convert.ToDouble(mdln_act.Matches(line).Item(0).Value, CultureInfo.InvariantCulture)
                            MdaNucl = Convert.ToDouble(mdncl.Match(line, 42).Value, CultureInfo.InvariantCulture)
                            Activity = Convert.ToDouble(mdln_act.Matches(line).Item(1).Value, CultureInfo.InvariantCulture)
                            Debug.WriteLine($"{nuclid}|{energy}|{output}|{MdaLine}|{MdaNucl}|{Activity}")
                            Try
                                rptTableMda.Rows.Add(System.IO.Path.GetFileName(fileName) & "_" & NameSamp & "_" & nuclid, NameSamp, nuclid, energy, output, MdaLine, MdaNucl, Activity)
                            Catch ce As ConstraintException
                                Debug.WriteLine(ce.ToString)
                            Catch ex As Exception
                                MsgBox(ex.ToString)
                            End Try
                        End If
                    End If
                Next

                If FileInfo.Count <> 0 Then FileInfoDict.Add(System.IO.Path.GetFileName(fileName).ToString, FileInfo)

                If calcConcFlag Then
                    Dim rown As Integer = 0
                    Debug.WriteLine($"Ref {NameSamp} parsing:")
                    Debug.WriteLine("{nuclid}|{PasConc}|{PassErr}")
                    For Each lineref As String In File.ReadLines("C:\WORKPROG\REF\" & NameSamp & ".ref", System.Text.Encoding.Default)
                        Debug.WriteLine($"Current String is {lineref}")
                        rown += 1
                        If rown < 5 Then Continue For 'с пятой строки начинаются данные в .ref
                        lineref = lineref.Trim
                        If lineref.Length <> 1 Then
                            nuclid = lineref.Substring(0, 3).Trim
                            PasConc = Convert.ToDouble(ppm.Match(lineref).Value, CultureInfo.InvariantCulture)
                            PassErr = Convert.ToDouble(err.Match(lineref).Value, CultureInfo.InvariantCulture)
                            Debug.WriteLine($"{nuclid}|{PasConc}|{PassErr}")
                            Try
                                refTable.Rows.Add(System.IO.Path.GetFileName(fileName) & "_" & NameSamp & "_" & nuclid, NameSamp, nuclid, PasConc, PassErr)
                                Debug.WriteLine($"Was added to ref table {System.IO.Path.GetFileName(fileName)}|{NameSamp}|{nuclid}|{PasConc}|{PassErr}")
                            Catch ce As ConstraintException
                                Debug.WriteLine(ce.ToString)
                            Catch ex As Exception
                                MsgBox(ex.ToString, MsgBoxStyle.Critical)
                            End Try
                        Else
                            Exit For
                        End If
                    Next
                End If
                If Not Split(GRSName, "-").Contains(NameSamp) Then GRSName += NameSamp & "-"
                Return {NameSamp, mesType, experimentator, id, geometry}
            Else
                MsgBox("Неверный тип файла")
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
            Return Nothing
        End Try

    End Function
    Public excp As New Dictionary(Of String, String)
    Public uniqElemForGRS As New ArrayList
    Function GrsSrc(grsTable As DataTable) As DataTable
        Try
            Debug.WriteLine($"Add elements from rpt to grs")
            Dim ppm, pasErr, stdErr As Double

            If grsTable.Columns.Count = 0 Then
                Dim grsKeys(0) As DataColumn
                Dim grsKeyColumn As New DataColumn()
                grsKeyColumn.ColumnName = "Key"
                grsKeys(0) = grsKeyColumn
                grsTable.Columns.Add(grsKeyColumn)
                grsTable.PrimaryKey = grsKeys
                grsTable.Columns.Add("refname")
                grsTable.Columns.Add("nucl")

                If My.Settings.language = "Русский" Then
                    grsTable.Columns.Add("Достоверность идентификации", GetType(Double))
                    grsTable.Columns.Add("act", GetType(Double))
                    grsTable.Columns.Add("Погрешность, %", GetType(Double))
                    grsTable.Columns.Add("paspConc", GetType(Double)) 'Паспортная концентрация, mg/kg
                    grsTable.Columns.Add("pasErr", GetType(Double))
                    grsTable.Columns.Add("stdEr", GetType(Double))
                    grsTable.Columns.Add("NuclSort", GetType(Integer))
                    grsTable.Columns.Add("sortFlag", GetType(Double))
                Else
                    grsTable.Columns.Add("Veracity of identification", GetType(Double))
                    grsTable.Columns.Add("act", GetType(Double))
                    grsTable.Columns.Add("Error, %", GetType(Double))
                    grsTable.Columns.Add("paspConc", GetType(Double)) 'Паспортная концентрация, mg/kg
                    grsTable.Columns.Add("pasErr", GetType(Double))
                    grsTable.Columns.Add("stdEr", GetType(Double))
                    grsTable.Columns.Add("NuclSort", GetType(Integer))
                    grsTable.Columns.Add("sortFlag", GetType(Double))
                End If

            End If
            Dim el As String = ""
            Dim keyString As String

            For Each row As DataRow In rptTablePeaks.Rows
                keyString = row(0).ToString.Substring(0, row(0).LastIndexOf("-"))
                Debug.WriteLine($"rptTablePeaks:{keyString}")

                If Not excp.ContainsKey(Split(row(0), "_")(2)) Then
                    el = keyString
                Else
                    el = Split(keyString, "_")(0) & "_" & Split(keyString, "_")(1) & "_" & excp(Split(row(0), "_")(2))
                End If

                If Not uniqElemForGRS.Contains(row(2)) Then uniqElemForGRS.Add(row(2))

                If Not refTable.Rows.Find(el) Is Nothing Then
                    If My.Settings.language = "Русский" Then
                        ppm = refTable.Rows.Find(el)("Паспортная концентрация, mg/kg")
                        pasErr = refTable.Rows.Find(el)("Паспортная погрешность, %")
                    Else
                        ppm = refTable.Rows.Find(el)("Passport concentration, mg/kg")
                        pasErr = refTable.Rows.Find(el)("Passport error, %")
                    End If
                Else Continue For
                End If
                stdErr = Math.Sqrt(row(5) ^ 2 + pasErr ^ 2)
                    If stdErr > 99 Then Continue For
                    Try ' если ключи одинаковые выбираем ту строку, в которой меньше ошибка
                        grsTable.Rows.Add(row(0), row(1), row(2), row(3), row(4), row(5), ppm, pasErr, stdErr, Convert.ToInt16(Replace(Split(row(2), "-")(1), "m", "")), 0)
                    Catch ce As ConstraintException
                        Debug.WriteLine(ce.ToString)
                    Catch ex As Exception
                        MsgBox(ex.ToString, MsgBoxStyle.Critical)
                    End Try

            Next
            '   refTable.Clear()
            ' rptTablePeaks.Clear()
            ' rptTableMda.Clear()
            Return grsTable
        Catch ex As Exception
            MsgBox(ex.ToString)
            Return Nothing
        End Try
    End Function


    Private Sub SaveSvodnFileAktivn_GRS_ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim marker As Integer ' маркер границ образцов

            SaveFileDialog_Svodn_Akt_Stand_Obr_GRS.FileName = Aktivn_Stand_Obr_File_list_stand_GRS + ".STA"
            Aktivn_Stand_Obr_File_list_stand_GRS = Aktivn_Stand_Obr_File_list_stand_GRS.ToUpper
            Aktivn_Stand_Obr_File_list_stand_GRS = Replace(Aktivn_Stand_Obr_File_list_stand_GRS, ".RPT", "")
            Aktivn_Stand_Obr_File_list_stand_GRS = Replace(Aktivn_Stand_Obr_File_list_stand_GRS, "; ", "-")
            SaveFileDialog_Svodn_Akt_Stand_Obr_GRS.FileName = Aktivn_Stand_Obr_File_list_stand_GRS + ".STA"
            If SaveFileDialog_Svodn_Akt_Stand_Obr_GRS.ShowDialog = System.Windows.Forms.DialogResult.Cancel Then ' Эта строчка открывает диалог и сравнивает результат с cancel 
                Exit Sub
            ElseIf System.Windows.Forms.DialogResult.OK Then ' Эта строчка только сравнивает результат с OK 
                My.Computer.FileSystem.WriteAllText(SaveFileDialog_Svodn_Akt_Stand_Obr_GRS.FileName, "Сводный файл активностей стандартных образцов: " + Replace(Aktivn_Stand_Obr_File_list_GRS, "-", "; ") + "." + vbCrLf + vbCrLf, False) 'vbCrLf - символ перевода строки
                My.Computer.FileSystem.WriteAllText(SaveFileDialog_Svodn_Akt_Stand_Obr_GRS.FileName, "имя" + vbTab + "нуклид" + vbTab + "достов." + vbTab + "средневзвешен." + vbTab + "погр.," + vbTab + "концентр.," + vbTab + "погреш.," + vbCrLf, True)
                My.Computer.FileSystem.WriteAllText(SaveFileDialog_Svodn_Akt_Stand_Obr_GRS.FileName, "образца" + vbTab + vbTab + "идент." + vbTab + "активность," + vbTab + "%" + vbTab + "mg/kg" + vbTab + "%" + vbCrLf, True)
                My.Computer.FileSystem.WriteAllText(SaveFileDialog_Svodn_Akt_Stand_Obr_GRS.FileName, vbTab + vbTab + vbTab + "uCi/gram" + vbCrLf + vbCrLf, True)
                For i = 0 To arr_length_Stand_Obr_GRS_sum - 1
                    If i <> arr_length_Stand_Obr_GRS_sum - 1 Then ' если записываемая строка НЕ последняя, символ перевода строки добавляем
                        My.Computer.FileSystem.WriteAllText(SaveFileDialog_Svodn_Akt_Stand_Obr_GRS.FileName, nucl_array_Stand_Obr_GRS_1_sum(i, 0) + vbTab + nucl_array_Stand_Obr_GRS_1_sum(i, 1) + vbTab _
                                                                             + data_array_Stand_Obr_GRS_1_sum(i, 0).ToString("F3", CultureInfo.CreateSpecificCulture("en-US")) + vbTab _
                                                                             + data_array_Stand_Obr_GRS_1_sum(i, 1).ToString("E2", CultureInfo.CreateSpecificCulture("en-US")) + vbTab _
                                                                             + (100 * data_array_Stand_Obr_GRS_1_sum(i, 2) / data_array_Stand_Obr_GRS_1_sum(i, 1)).ToString("F2", CultureInfo.CreateSpecificCulture("en-US")) + vbTab _
                                                                             + data_array_Stand_Obr_GRS_1_sum(i, 3).ToString("E2", CultureInfo.CreateSpecificCulture("en-US")) + vbTab _
                                                                             + data_array_Stand_Obr_GRS_1_sum(i, 4).ToString("F2", CultureInfo.CreateSpecificCulture("en-US")) + vbCrLf, True) ' в последней строчке делим относительную погрешность на средневзвешенную активность и умножаем на 100, чтобы получить погрешность в процентах
                    Else ' если записываемая строка последняя, символ перевода строки не добавляем
                        My.Computer.FileSystem.WriteAllText(SaveFileDialog_Svodn_Akt_Stand_Obr_GRS.FileName, nucl_array_Stand_Obr_GRS_1_sum(i, 0) + vbTab + nucl_array_Stand_Obr_GRS_1_sum(i, 1) + vbTab _
                                                                             + data_array_Stand_Obr_GRS_1_sum(i, 0).ToString("F3", CultureInfo.CreateSpecificCulture("en-US")) + vbTab _
                                                                             + data_array_Stand_Obr_GRS_1_sum(i, 1).ToString("E2", CultureInfo.CreateSpecificCulture("en-US")) + vbTab _
                                                                             + (100 * data_array_Stand_Obr_GRS_1_sum(i, 2) / data_array_Stand_Obr_GRS_1_sum(i, 1)).ToString("F2", CultureInfo.CreateSpecificCulture("en-US")) + vbTab _
                                                                             + data_array_Stand_Obr_GRS_1_sum(i, 3).ToString("E2", CultureInfo.CreateSpecificCulture("en-US")) + vbTab _
                                                                             + data_array_Stand_Obr_GRS_1_sum(i, 4).ToString("F2", CultureInfo.CreateSpecificCulture("en-US")), True)

                    End If
                    marker = 0
                    For j = 0 To arr_length_Stand_Obr_GRS_1_array.Length - 1
                        If j = 0 Then
                            marker = marker + arr_length_Stand_Obr_GRS_1_array(j) - 1
                        Else
                            marker = marker + arr_length_Stand_Obr_GRS_1_array(j)
                        End If

                        If i = marker And i <> (arr_length_Stand_Obr_GRS_sum - 1) Then
                            'If i > 0 And i < (arr_length_Stand_Obr_GRS_sum - 1) Then
                            '    If nucl_array_Stand_Obr_GRS_sum(i, 0) <> nucl_array_Stand_Obr_GRS_sum(i - 1, 0) Then
                            My.Computer.FileSystem.WriteAllText(SaveFileDialog_Svodn_Akt_Stand_Obr_GRS.FileName, vbCrLf, True)
                            '    End If
                            'End If
                        End If
                    Next
                Next
            End If
        Catch ex As Exception
            If My.Settings.language = "Русский" Then
                MsgBox("Операция была отменена (ошибка в SaveSvodnFileAktivn_GRS_ToolStripMenuItem_Click)!", MsgBoxStyle.Critical, Me.Text)
            Else
                MsgBox("Operation was cancelled (error in SaveSvodnFileAktivn_GRS_ToolStripMenuItem_Click)!", MsgBoxStyle.Critical, Me.Text)
            End If
            Exit Sub
        End Try
    End Sub

    Private Sub OpenFileAktMonStand_ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenFileAktStand_MON_ToolStripMenuItem.Click
        Try
            Dim L_Akt_Stand_File_list_MON As String
            ' OpenFileDialog_Akt_Stand_MON.InitialDirectory = "C:\GENIE2K\CONFILES"
            If OpenFileDialog_Akt_Stand_MON.ShowDialog = System.Windows.Forms.DialogResult.Cancel Then
                If My.Settings.language = "Русский" Then
                    If Not File_Akt_Stand_Select_MON Then MsgBox("Файл(ы) активностей стандарта не выбран!", MsgBoxStyle.Exclamation, Me.Text)
                Else
                    If Not File_Akt_Stand_Select_MON Then MsgBox("File(s) of standard's activity: not choosen!", MsgBoxStyle.Exclamation, Me.Text)
                End If
                Exit Sub
            Else
                Dim first_File1 As System.IO.FileInfo
                first_File1 = My.Computer.FileSystem.GetFileInfo(OpenFileDialog_Akt_Stand_MON.FileNames(0))
                OpenFileDialog_Akt_Stand_MON.InitialDirectory = first_File1.DirectoryName
                My.MySettings.Default.pathTo13 = first_File1.DirectoryName
                L_Akt_Stand_File_list_MON = ""
                Akt_Stand_Files_MON_Quant = OpenFileDialog_Akt_Stand_MON.FileNames.Length
                ReDim file_name_Akt_Stand_Array_MON(Akt_Stand_Files_MON_Quant - 1)
                ReDim file_name_Akt_Stand_SafeFileNames_MON_Array(Akt_Stand_Files_MON_Quant - 1)
                ReDim file_name_Akt_Stand_Short_MON_Array(Akt_Stand_Files_MON_Quant - 1)
                For i = 0 To Akt_Stand_Files_MON_Quant - 1
                    file_name_Akt_Stand_Array_MON(i) = OpenFileDialog_Akt_Stand_MON.FileNames(i)
                    file_name_Akt_Stand_SafeFileNames_MON_Array(i) = OpenFileDialog_Akt_Stand_MON.SafeFileNames(i)
                    file_name_Akt_Stand_Short_MON_Array(i) = OpenFileDialog_Akt_Stand_MON.SafeFileNames(i)
                    file_name_Akt_Stand_Short_MON_Array(i) = OpenFileDialog_Akt_Stand_MON.SafeFileNames(i).ToUpper
                    file_name_Akt_Stand_Short_MON_Array(i) = Replace(file_name_Akt_Stand_Short_MON_Array(i), ".RPT", "")
                    If i <> Akt_Stand_Files_MON_Quant - 1 Then
                        L_Akt_Stand_File_list_MON = L_Akt_Stand_File_list_MON + OpenFileDialog_Akt_Stand_MON.SafeFileNames(i) + "; "
                    Else
                        L_Akt_Stand_File_list_MON = L_Akt_Stand_File_list_MON + OpenFileDialog_Akt_Stand_MON.SafeFileNames(i)
                    End If
                    'If OpenFileDialog_Akt_Stand_MON.SafeFileNames(i) = file_name_Baz_File_Akt_Mon_Stand_SafeFileName_MON Then
                    '    If My.Settings.language = "Русский" Then
                    '        MsgBox("Имя файла активностей стандарта не должно совпадать с именем базового файла активностей монитора стандарта!", MsgBoxStyle.Exclamation, Me.Text)
                    '    Else
                    '        MsgBox("File name of standard's activity should not coincide with file name of base file of standard's monitor activity!", MsgBoxStyle.Exclamation, Me.Text)
                    '    End If
                    '    Exit Sub
                    'End If
                Next
            End If
            SavePereschAktStand_MON_ToolStripMenuItem.Enabled = False

            Dim first_File As System.IO.FileInfo
            first_File = My.Computer.FileSystem.GetFileInfo(OpenFileDialog_Akt_Stand_MON.FileNames(0))
            OpenFileDialog_Akt_Stand_MON.InitialDirectory = first_File.DirectoryName
            My.MySettings.Default.pathTo11 = first_File.DirectoryName
            'If My.Settings.language = "Русский" Then
            '    L_File_Aktivn_Stand_Dlia_Peresch_MON.Text = "Файл(ы) активностей стандарта: " + OpenFileDialog_Akt_Stand_MON.InitialDirectory + "\" + L_Akt_Stand_File_list_MON
            'Else
            '    L_File_Aktivn_Stand_Dlia_Peresch_MON.Text = "File(s) of standard's activity: " + OpenFileDialog_Akt_Stand_MON.InitialDirectory + "\" + L_Akt_Stand_File_list_MON
            'End If

            File_Akt_Stand_Select_MON = True
            If (File_Baz_File_Akt_Monit_Stand_Select_MON And File_Akt_Stand_Select_MON And File_Akt_Monit_Stand_Select_MON) Then B_Perschet_Aktivn_Stand.Enabled = True
        Catch ex As Exception
            If My.Settings.language = "Русский" Then
                MsgBox("Операция была отменена (ошибка в OpenFileAktMonStand_ToolStripMenuItem_Click)!", MsgBoxStyle.Critical, Me.Text)
            Else
                MsgBox("Operation was cancelled (error in OpenFileAktMonStand_ToolStripMenuItem_Click)!", MsgBoxStyle.Critical, Me.Text)
            End If
            Exit Sub
        End Try
    End Sub

    Private Sub VibrBazFileAktMonitStand_ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VibrBazFileAktMonitStand_MON_ToolStripMenuItem.Click
        Try
            ' OpenFileDialog_Baz_File_Akt_Mon_Stand_MON.InitialDirectory = "C:\GENIE2K\CONFILES"
            If OpenFileDialog_Baz_File_Akt_Mon_Stand_MON.ShowDialog = System.Windows.Forms.DialogResult.Cancel Then
                If My.Settings.language = "Русский" Then
                    If Not File_Baz_File_Akt_Monit_Stand_Select_MON Then MsgBox("Базовый файл активностей монитора стандарта не выбран!", MsgBoxStyle.Exclamation, Me.Text)
                Else
                    If Not File_Baz_File_Akt_Monit_Stand_Select_MON Then MsgBox("Base file of standard's monitor activity not choosen!", MsgBoxStyle.Exclamation, Me.Text)
                End If
                Exit Sub
            Else
                Dim first_File As System.IO.FileInfo
                first_File = My.Computer.FileSystem.GetFileInfo(OpenFileDialog_Baz_File_Akt_Mon_Stand_MON.FileNames(0))
                OpenFileDialog_Baz_File_Akt_Mon_Stand_MON.InitialDirectory = first_File.DirectoryName
                My.MySettings.Default.pathTo11 = first_File.DirectoryName
                If Akt_Stand_Files_MON_Quant > 0 Then
                    For i = 0 To Akt_Stand_Files_MON_Quant - 1
                        If OpenFileDialog_Baz_File_Akt_Mon_Stand_MON.SafeFileName = file_name_Akt_Stand_SafeFileNames_MON_Array(i) Then
                            If My.Settings.language = "Русский" Then
                                MsgBox("Имя базового файла активностей монитора стандарта не должно совпадать с именем файла активностей стандарта!", MsgBoxStyle.Exclamation, Me.Text)
                            Else
                                MsgBox("Name of base file of standard's monitor activity should not coincide with file name of standard's activity!", MsgBoxStyle.Exclamation, Me.Text)
                            End If
                            Exit Sub
                        End If
                    Next
                End If
                If OpenFileDialog_Baz_File_Akt_Mon_Stand_MON.SafeFileName = file_name_Akt_Mon_Stand_MON Then
                    If My.Settings.language = "Русский" Then
                        MsgBox("Имя базового файла активностей монитора стандарта не должно совпадать с именем файла активностей монитора стандарта!", MsgBoxStyle.Exclamation, Me.Text)
                    Else
                        MsgBox("Name of base file of standard's monitor activity should not coincide with file name of standard's monitor activity!", MsgBoxStyle.Exclamation, Me.Text)
                    End If
                    Exit Sub
                End If

            End If
            SavePereschAktStand_MON_ToolStripMenuItem.Enabled = False
            file_name_Baz_File_Akt_Mon_Stand_MON = OpenFileDialog_Baz_File_Akt_Mon_Stand_MON.FileName
            file_name_Baz_File_Akt_Mon_Stand_SafeFileName_MON = OpenFileDialog_Baz_File_Akt_Mon_Stand_MON.SafeFileName
            File_Baz_File_Akt_Monit_Stand_Select_MON = True
            If (File_Baz_File_Akt_Monit_Stand_Select_MON And File_Akt_Stand_Select_MON And File_Akt_Monit_Stand_Select_MON) Then B_Perschet_Aktivn_Stand.Enabled = True

        Catch ex As Exception
            If My.Settings.language = "Русский" Then
                MsgBox("Операция была отменена (ошибка в VibrBazFileAktMonitStand_ToolStripMenuItem_Click)!", MsgBoxStyle.Critical, Me.Text)
            Else
                MsgBox("Operation was cancelled (error in VibrBazFileAktMonitStand_ToolStripMenuItem_Click)!", MsgBoxStyle.Critical, Me.Text)
            End If
            Exit Sub
        End Try
    End Sub

    Private Sub B_Perschet_Aktivn_Monitor_Stand_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_Perschet_Aktivn_Stand.Click
        Try
            Dim arr_length_Akt_Stand_MON, arr_length_Baz_File_Akt_Mon_Stand_MON, arr_length_Akt_Mon_Stand_MON As Integer

            For m = 0 To Akt_Stand_Files_MON_Quant - 1
                m_glob_MON = m
                'file_name_Aktivn_Issl_Obr = OpenFileDialog_Aktivn_Issl_Obr.FileName
                arr_length_Akt_Stand_MON = array_length_RPT(file_name_Akt_Stand_Array_MON(m))
                If arr_length_Akt_Stand_MON = 0 Then
                    If My.Settings.language = "Русский" Then
                        MsgBox("Неправильный формат файла " + file_name_Akt_Stand_Array_MON(m) + "!", MsgBoxStyle.Critical, Me.Text)
                    Else
                        MsgBox("Incorrect file format " + file_name_Akt_Stand_Array_MON(m) + "!", MsgBoxStyle.Critical, Me.Text)
                    End If
                    Exit Sub
                End If
                ReDim nucl_array_Akt_Stand_MON(arr_length_Akt_Stand_MON - 1, 1)
                ReDim data_array_Akt_Stand_MON(arr_length_Akt_Stand_MON - 1, 2)
                sample_title_Stand_MON = ""
                measurements_type = ""
                data_search_RPT(file_name_Akt_Stand_Array_MON(m), nucl_array_Akt_Stand_MON, data_array_Akt_Stand_MON, sample_title_Stand_MON, measurements_type)
                'msgbox("Имя исследуемого образца: " + sample_title_Issl_Obr, MsgBoxStyle.Exclamation, Me.Text)

                'file_name_Aktivn_Stand_Obr:=OpenDialog_Aktivn_Stand_Obr.FileName;
                arr_length_Baz_File_Akt_Mon_Stand_MON = array_length_RPT(file_name_Baz_File_Akt_Mon_Stand_MON)
                If arr_length_Baz_File_Akt_Mon_Stand_MON = 0 Then
                    If My.Settings.language = "Русский" Then
                        MsgBox("Неправильный формат файла " + file_name_Baz_File_Akt_Mon_Stand_MON + "!", MsgBoxStyle.Critical, Me.Text)
                    Else
                        MsgBox("Incorrect file format " + file_name_Baz_File_Akt_Mon_Stand_MON + "!", MsgBoxStyle.Critical, Me.Text)
                    End If
                    Exit Sub
                End If
                ReDim nucl_array_Akt_Baz_Mon_Stand_MON(arr_length_Baz_File_Akt_Mon_Stand_MON - 1, 1)
                ReDim data_array_Akt_Baz_Mon_Stand_MON(arr_length_Baz_File_Akt_Mon_Stand_MON - 1, 2)
                sample_title_Baz_Mon_Stand_MON = ""
                measurements_type = ""
                data_search_RPT(file_name_Baz_File_Akt_Mon_Stand_MON, nucl_array_Akt_Baz_Mon_Stand_MON, data_array_Akt_Baz_Mon_Stand_MON, sample_title_Baz_Mon_Stand_MON, measurements_type)

                arr_length_Akt_Mon_Stand_MON = array_length_RPT(file_name_Akt_Mon_Stand_MON)
                If arr_length_Akt_Mon_Stand_MON = 0 Then
                    If My.Settings.language = "Русский" Then
                        MsgBox("Неправильный формат файла " + file_name_Akt_Mon_Stand_MON + "!", MsgBoxStyle.Critical, Me.Text)
                    Else
                        MsgBox("Incorrect file format " + file_name_Akt_Mon_Stand_MON + "!", MsgBoxStyle.Critical, Me.Text)
                    End If
                    Exit Sub
                End If
                ReDim nucl_array_Akt_Mon_Stand_MON(arr_length_Akt_Mon_Stand_MON - 1, 1)
                ReDim data_array_Akt_Mon_Stand_MON(arr_length_Akt_Mon_Stand_MON - 1, 2)
                sample_title_Mon_Stand_MON = ""
                measurements_type = ""
                data_search_RPT(file_name_Akt_Mon_Stand_MON, nucl_array_Akt_Mon_Stand_MON, data_array_Akt_Mon_Stand_MON, sample_title_Mon_Stand_MON, measurements_type)

                SavePereschAktStand_MON_ToolStripMenuItem.Enabled = True
                '        ReDim nucl(arr_length_count_Conc - 1)
                ReDim aktivnost(arr_length_Akt_Stand_MON, 0)
                'arr_length_count_Conc = 0
                For i = 0 To arr_length_Akt_Stand_MON - 1
                    '            For j = 0 To arr_length_Stand_Obr - 1
                    '                If nucl_array_Issl_Obr(i, 0) = nucl_array_Stand_Obr(j, 0) Then
                    '                    For k = 0 To arr_length_Conc - 1
                    '                        If nucl_array_Issl_Obr(i, 1) = nucl_array_Conc(k, 0) Then arr_length_count_Conc = arr_length_count_Conc + 1
                    '                    Next
                    '                End If
                    '            Next
                    '        Next
                    '        ReDim nucl(arr_length_count_Conc - 1)
                    'ReDim aktivn(arr_length_Akt_Stand, 0)
                    '        l = 0
                    '        For i = 0 To arr_length_Issl_Obr - 1
                    '            For j = 0 To arr_length_Stand_Obr - 1
                    '                If nucl_array_Issl_Obr(i, 0) = nucl_array_Stand_Obr(j, 0) Then
                    '                    For k = 0 To arr_length_Conc - 1
                    '                        If nucl_array_Issl_Obr(i, 1) = nucl_array_Conc(k, 0) Then
                    '                            nucl(l) = nucl_array_Issl_Obr(i, 0)


                    'активность_стандарта_корректрованная=активность_стандарта*активность_базового_монитора_стандарта/активность_монитора_стандарта
                    aktivnost(i, 0) = data_array_Akt_Stand_MON(i, 1) * data_array_Akt_Baz_Mon_Stand_MON(0, 1) / data_array_Akt_Mon_Stand_MON(0, 1)



                    '                            conc(l, 1) = 100 * Math.Sqrt((data_array_Issl_Obr(i, 2) / data_array_Issl_Obr(i, 1)) ^ 2 + (data_array_Stand_Obr(j, 2) / data_array_Stand_Obr(j, 1)) ^ 2 + (data_array_Conc(k, 1) / 100) ^ 2)
                    '                            l = l + 1
                    '                        End If
                    '                    Next
                    '                End If
                    '            Next
                Next
                SavePereschAktMonitorStand_ToolStripMenuItem_Click(sender, e)
            Next
        Catch ex As Exception
            If My.Settings.language = "Русский" Then
                MsgBox("Операция была отменена (ошибка в B_Perschet_Aktivn_Monitor_Stand_Click)!", MsgBoxStyle.Critical, Me.Text)
            Else
                MsgBox("Operation was cancelled (error in B_Perschet_Aktivn_Monitor_Stand_Click)!", MsgBoxStyle.Critical, Me.Text)
            End If
            Exit Sub
        End Try
    End Sub

    Private Sub SavePereschAktMonitorStand_ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SavePereschAktStand_MON_ToolStripMenuItem.Click
        Try
            Dim file_name_p As String
            ' SaveFileDialog_PereschAktStand_MON.InitialDirectory = "C:\GENIE2K\CONFILES"
            SaveFileDialog_PereschAktStand_MON.FileName = file_name_Akt_Stand_Short_MON_Array(m_glob_MON) + "k.RPT"
            SaveFileDialog_PereschAktStand_MON.FileName = SaveFileDialog_PereschAktStand_MON.FileName.ToUpper

            If SaveFileDialog_PereschAktStand_MON.ShowDialog = System.Windows.Forms.DialogResult.Cancel Then ' Эта строчка открывает диалог и сравнивает результат с cancel 
                Exit Sub
            ElseIf System.Windows.Forms.DialogResult.OK Then ' Эта строчка только сравнивает результат с OK 
                Dim first_File As System.IO.FileInfo
                first_File = My.Computer.FileSystem.GetFileInfo(SaveFileDialog_PereschAktStand_MON.FileNames(0))
                SaveFileDialog_PereschAktStand_MON.InitialDirectory = first_File.DirectoryName
                My.MySettings.Default.pathTo14 = first_File.DirectoryName

                Dim nucl_count As Integer
                Dim currentRow, currentRowCopy As String
                Dim nuclide, element As String
                Dim aktivn, dostovern, pogreshn As Single
                Dim sample_title_p, measurements_type_p As String
                Dim flag_sample_title_p As Boolean

                nucl_count = 0
                nuclide = ""
                element = ""
                flag_sample_title_p = False

                file_name_p = file_name_Akt_Stand_Array_MON(m_glob_MON)
                ' Using MyReader As New Microsoft.VisualBasic.FileIO.TextFieldParser(file_name_Akt_Stand_Array_MON(m_glob_MON), System.Text.Encoding.Default)
                Using MyReader As New Microsoft.VisualBasic.FileIO.TextFieldParser(file_name_p, System.Text.Encoding.Default)
                    MyReader.TextFieldType = FileIO.FieldType.Delimited
                    MyReader.SetDelimiters(" ")
                    While Not MyReader.EndOfData
                        currentRow = MyReader.ReadLine
                        currentRowCopy = currentRow
                        currentRow = currentRow.Trim 'удаляем пробелы в начале и конце строки, если они есть
                        While InStr(currentRow, "  ") > 0
                            currentRow = Replace(currentRow, "  ", " ") ' заменяем все двойные пробелы одинарными
                        End While










                        Try
                            If flag_sample_title_p = False Then
                                If Mid(currentRow, 1, InStr(1, currentRow, ":") - 2) = "Имя образца" Or Mid(currentRow, 1, InStr(1, currentRow, ":") - 2) = "Sample name" Then
                                    sample_title_p = Mid(currentRow, (InStr(1, currentRow, ":") + 2))
                                    My.Computer.FileSystem.WriteAllText(SaveFileDialog_PereschAktStand_MON.FileName, currentRowCopy + vbCrLf, False)

                                    My.Computer.FileSystem.WriteAllText(SaveFileDialog_PereschAktStand_MON.FileName, vbCrLf, True)
                                    My.Computer.FileSystem.WriteAllText(SaveFileDialog_PereschAktStand_MON.FileName, "*************************************************************************" + vbCrLf, True)
                                    My.Computer.FileSystem.WriteAllText(SaveFileDialog_PereschAktStand_MON.FileName, "*****  ОТЧЁТ О ИДЕНТИФИКАЦИИ НУКЛИДОВ С КОРРЕКЦИЕЙ НА ИНТЕРФЕРЕНИЦЮ *****" + vbCrLf, True)
                                    My.Computer.FileSystem.WriteAllText(SaveFileDialog_PereschAktStand_MON.FileName, "*************************************************************************" + vbCrLf, True)
                                    My.Computer.FileSystem.WriteAllText(SaveFileDialog_PereschAktStand_MON.FileName, vbCrLf, True)
                                    My.Computer.FileSystem.WriteAllText(SaveFileDialog_PereschAktStand_MON.FileName, vbCrLf, True)

                                    flag_sample_title_p = True
                                    currentRow = MyReader.ReadLine
                                    currentRow = MyReader.ReadLine
                                    currentRow = MyReader.ReadLine
                                    currentRowCopy = currentRow
                                    currentRow = currentRow.Trim 'удаляем пробелы в начале и конце строки, если они есть
                                    While InStr(currentRow, "  ") > 0
                                        currentRow = Replace(currentRow, "  ", " ") ' заменяем все двойные пробелы одинарными
                                    End While
                                    Try
                                        If Mid(currentRow, 1, InStr(1, currentRow, ":") - 2) = "Тип" Or Mid(currentRow, 1, InStr(1, currentRow, ":") - 2) = "Sample Type" Then
                                            measurements_type_p = Mid(currentRow, (InStr(1, currentRow, ":") + 2)).ToUpper
                                            Replace(measurements_type_p, " ", "")
                                            measurements_type_p = measurements_type_p.ToUpper
                                            My.Computer.FileSystem.WriteAllText(SaveFileDialog_PereschAktStand_MON.FileName, "" + vbCrLf, True)
                                            My.Computer.FileSystem.WriteAllText(SaveFileDialog_PereschAktStand_MON.FileName, "" + vbCrLf, True)
                                            My.Computer.FileSystem.WriteAllText(SaveFileDialog_PereschAktStand_MON.FileName, "" + vbCrLf, True)
                                            My.Computer.FileSystem.WriteAllText(SaveFileDialog_PereschAktStand_MON.FileName, currentRowCopy + vbCrLf + vbCrLf, True)

                                        End If
                                    Catch ex As Exception
                                        Debug.WriteLine(ex.ToString)
                                    End Try
                                End If
                            End If
                        Catch ex As Exception
                        End Try

                        If currentRow = "Нуклид Достоверность Средневзвешенная Погрешность" Or currentRow = "Nuclide Wt mean Wt mean" Then
                            My.Computer.FileSystem.WriteAllText(SaveFileDialog_PereschAktStand_MON.FileName, sample_title_Issl_Obr + currentRowCopy + vbCrLf, True) 'vbCrLf - символ перевода строки

                            currentRow = MyReader.ReadLine
                            currentRowCopy = currentRow
                            currentRow = currentRow.Trim 'удаляем пробелы в начале и конце строки, если они есть
                            While InStr(currentRow, "  ") > 0
                                currentRow = Replace(currentRow, "  ", " ") ' заменяем все двойные пробелы одинарными
                            End While
                            If currentRow = "идентификации активность," Or currentRow = "Nuclide Id Activity Activity" Then
                                My.Computer.FileSystem.WriteAllText(SaveFileDialog_PereschAktStand_MON.FileName, currentRowCopy + vbCrLf, True)
                                currentRow = MyReader.ReadLine
                                currentRowCopy = currentRow
                                currentRow = currentRow.Trim 'удаляем пробелы в начале и конце строки, если они есть
                                While InStr(currentRow, "  ") > 0
                                    currentRow = Replace(currentRow, "  ", " ") ' заменяем все двойные пробелы одинарными
                                End While
                                If currentRow = "uCi /gram" Or currentRow = "Name Confidence (uCi/gram) Uncertainty" Then
                                    My.Computer.FileSystem.WriteAllText(SaveFileDialog_PereschAktStand_MON.FileName, currentRowCopy + vbCrLf, True)
                                    currentRow = MyReader.ReadLine
                                    currentRowCopy = currentRow
                                    If currentRow = "" Then
                                        ' msgbox("Похоже, правильный формат файла активностей образца!", MsgBoxStyle.Exclamation, Me.Text)
                                        My.Computer.FileSystem.WriteAllText(SaveFileDialog_PereschAktStand_MON.FileName, currentRowCopy + vbCrLf, True)
                                        currentRow = MyReader.ReadLine
a:                                      data_ident_RPT(currentRow, nuclide, element, dostovern, aktivn, pogreshn)
                                        currentRow = currentRow + " " 'добавляем пробел в конец строки

                                        Dim probel As String
                                        probel = ""
                                        If Len(nuclide) = 3 Then probel = "        "
                                        If Len(nuclide) = 4 Then probel = "       "
                                        If Len(nuclide) = 5 Then probel = "      "
                                        If Len(nuclide) = 6 Then probel = "     "
                                        If Len(nuclide) = 7 Then probel = "    "
                                        '                                    nucl_array_p(nucl_count, 0) = nuclide
                                        '                                    nucl_array_p(nucl_count, 1) = element
                                        '                                    data_array_p(nucl_count, 0) = dostovern
                                        '                                    data_array_p(nucl_count, 1) = aktivn
                                        '                                    data_array_p(nucl_count, 2) = pogreshn
                                        '                                    nucl_count = nucl_count + 1
                                        My.Computer.FileSystem.WriteAllText(SaveFileDialog_PereschAktStand_MON.FileName, "       " + nuclide + probel + dostovern.ToString("F3", CultureInfo.CreateSpecificCulture("en-US")) + "      " + aktivnost(nucl_count, 0).ToString("E6", CultureInfo.CreateSpecificCulture("en-US")) + "   " + pogreshn.ToString("E6", CultureInfo.CreateSpecificCulture("en-US")) + vbCrLf, True)

                                        nucl_count = nucl_count + 1
                                        currentRow = MyReader.ReadLine
                                        If currentRow <> "" Then GoTo a

                                    End If
                                End If
                            End If
                        End If
                    End While
                End Using

                '    My.Computer.FileSystem.WriteAllText(SaveFileDialog_Conc_Elem.FileName, "Концентрации элементов в образце " + sample_title_Issl_Obr + "." + vbCrLf + vbCrLf, False) 'vbCrLf - символ перевода строки
                '    My.Computer.FileSystem.WriteAllText(SaveFileDialog_Conc_Elem.FileName, "элемент" + vbTab + "концентрация," + vbTab + "погрешность," + vbTab + "предел" + vbCrLf, True)
                '    My.Computer.FileSystem.WriteAllText(SaveFileDialog_Conc_Elem.FileName, vbTab + "uг/гр" + vbTab + vbTab + "%" + vbTab + vbTab + "обнаружения," + vbCrLf, True)
                '    My.Computer.FileSystem.WriteAllText(SaveFileDialog_Conc_Elem.FileName, vbTab + vbTab + vbTab + vbTab + vbTab + "uг/гр" + vbCrLf, True)
                '    For i = 0 To arr_length_count_Conc - 1
                '        My.Computer.FileSystem.WriteAllText(SaveFileDialog_Conc_Elem.FileName, nucl(i) + vbTab + conc(i, 0).ToString("E2", CultureInfo.CreateSpecificCulture("en-US")) + vbTab + conc(i, 1).ToString("F2", CultureInfo.CreateSpecificCulture("en-US")) + vbCrLf, True)
                '    Next

                'изменяем начальную директорию, на ту, в которую сохранили первй файл
                Dim current_File As System.IO.FileInfo
                current_File = My.Computer.FileSystem.GetFileInfo(SaveFileDialog_PereschAktStand_MON.FileName)
                SaveFileDialog_PereschAktStand_MON.InitialDirectory = current_File.DirectoryName
            End If
        Catch ex As Exception
            If My.Settings.language = "Русский" Then
                MsgBox("Операция была отменена (ошибка в SavePereschAktMonitorStand_ToolStripMenuItem_Click)!", MsgBoxStyle.Critical, Me.Text)
            Else
                MsgBox("Operation was cancelled (error in SavePereschAktMonitorStand_ToolStripMenuItem_Click)!", MsgBoxStyle.Critical, Me.Text)
            End If
            Exit Sub
        End Try
    End Sub

    Private Sub OpenFileAktMonStand_ToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenFileAktMonStand_MON_ToolStripMenuItem.Click
        Try
            ' OpenFileDialog_Akt_Mon_Stand_MON.InitialDirectory = "C:\GENIE2K\CONFILES"
            If OpenFileDialog_Akt_Mon_Stand_MON.ShowDialog = System.Windows.Forms.DialogResult.Cancel Then
                If My.Settings.language = "Русский" Then
                    If Not File_Baz_File_Akt_Monit_Stand_Select_MON Then MsgBox("Файл активностей монитора стандарта не выбран!", MsgBoxStyle.Exclamation, Me.Text)
                Else
                    If Not File_Baz_File_Akt_Monit_Stand_Select_MON Then MsgBox("File of standard's monitor activity: not choosen!", MsgBoxStyle.Exclamation, Me.Text)
                End If
                Exit Sub
            Else
                Dim first_File As System.IO.FileInfo
                first_File = My.Computer.FileSystem.GetFileInfo(OpenFileDialog_Akt_Mon_Stand_MON.FileNames(0))
                OpenFileDialog_Akt_Mon_Stand_MON.InitialDirectory = first_File.DirectoryName
                My.MySettings.Default.pathTo12 = first_File.DirectoryName
                If Akt_Stand_Files_MON_Quant > 0 Then
                    For i = 0 To Akt_Stand_Files_MON_Quant - 1
                        If OpenFileDialog_Akt_Mon_Stand_MON.SafeFileName = file_name_Akt_Stand_SafeFileNames_MON_Array(i) Then
                            If My.Settings.language = "Русский" Then
                                MsgBox("Имя файла активностей монитора стандарта не должно совпадать с именем файла активностей стандарта!", MsgBoxStyle.Exclamation, Me.Text)
                            Else
                                MsgBox("File name of standard's monitor activity should not coincide with file name of standard's activity!", MsgBoxStyle.Exclamation, Me.Text)
                            End If
                            Exit Sub
                        End If
                    Next
                End If
                If OpenFileDialog_Akt_Mon_Stand_MON.SafeFileName = file_name_Baz_File_Akt_Mon_Stand_SafeFileName_MON Then
                    If My.Settings.language = "Русский" Then
                        MsgBox("Имя файла активностей монитора стандарта не должно совпадать с именем базового файла активностей монитора стандарта!", MsgBoxStyle.Exclamation, Me.Text)
                    Else
                        MsgBox("File name of standard's monitor activity should not coincide with name of base file of standard's monitor activity!", MsgBoxStyle.Exclamation, Me.Text)
                    End If
                    Exit Sub
                End If
            End If
            SavePereschAktStand_MON_ToolStripMenuItem.Enabled = False
            file_name_Akt_Mon_Stand_MON = OpenFileDialog_Akt_Mon_Stand_MON.FileName
            file_name_Akt_Mon_Stand_SafeFileName_MON = OpenFileDialog_Akt_Mon_Stand_MON.SafeFileName
            File_Akt_Monit_Stand_Select_MON = True
            If (File_Baz_File_Akt_Monit_Stand_Select_MON And File_Akt_Stand_Select_MON And File_Akt_Monit_Stand_Select_MON) Then B_Perschet_Aktivn_Stand.Enabled = True
        Catch ex As Exception
            If My.Settings.language = "Русский" Then
                MsgBox("Операция была отменена (ошибка в OpenFileAktMonStand_ToolStripMenuItem_Click_1)!", MsgBoxStyle.Critical, Me.Text)
            Else
                MsgBox("Operation was cancelled (error in OpenFileAktMonStand_ToolStripMenuItem_Click_1)!", MsgBoxStyle.Critical, Me.Text)
            End If
            Exit Sub
        End Try
    End Sub

    Private Sub OpenFileGrupStand_ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenFileGrupStand_ToolStripMenuItem.Click
        Try
            ' OpenFileDialog_Grup_Stand.InitialDirectory = "C:\GENIE2K\CONFILES"
            If OpenFileDialog_Grup_Stand.ShowDialog = System.Windows.Forms.DialogResult.Cancel Then
                If My.Settings.language = "Русский" Then
                    If Not File_Grup_Stand_Select Then MsgBox("Файл группового стандарта не выбран!", MsgBoxStyle.Exclamation, Me.Text)
                Else
                    If Not File_Grup_Stand_Select Then MsgBox("File of group standard not choosen!", MsgBoxStyle.Exclamation, Me.Text)
                End If
                Exit Sub
            End If
            SaveConcIsslObr_ToolStripMenuItem.Enabled = False
            file_name_Grup_Stand = OpenFileDialog_Grup_Stand.FileName
            file_name_Grup_Stand_SafeFileName = OpenFileDialog_Grup_Stand.SafeFileName

            File_Grup_Stand_Select = True
            If (File_Aktivn_Issl_Obr_Select And File_Grup_Stand_Select) Then B_calc_conc.Enabled = True
            Dim first_File As System.IO.FileInfo
            first_File = My.Computer.FileSystem.GetFileInfo(OpenFileDialog_Grup_Stand.FileNames(0))
            OpenFileDialog_Grup_Stand.InitialDirectory = first_File.DirectoryName
            L_Grup_Stand.Text = ""
            L_Grup_Stand.Text = file_name_Grup_Stand
        Catch ex As Exception
            If My.Settings.language = "Русский" Then
                MsgBox("Операция была отменена (ошибка в OpenFileGrupStand_ToolStripMenuItem_Click)!", MsgBoxStyle.Critical, Me.Text)
            Else
                MsgBox("Operation was cancelled (error in OpenFileGrupStand_ToolStripMenuItem_Click)!", MsgBoxStyle.Critical, Me.Text)
            End If
            Exit Sub
        End Try
    End Sub

    Private Sub VibrBazFileAktMonitStand_ToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VibrBazFileAktMonitStand_ToolStripMenuItem.Click
        Try
            ' OpenFileDialog_Baz_File_Akt_Mon_Stand.InitialDirectory = "C:\GENIE2K\CONFILES"
            If OpenFileDialog_Baz_File_Akt_Mon_Stand.ShowDialog = System.Windows.Forms.DialogResult.Cancel Then
                If My.Settings.language = "Русский" Then
                    If Not File_Baz_File_Akt_Monit_Stand_Select Then MsgBox("Базовый файл активностей монитора стандарта не выбран!", MsgBoxStyle.Exclamation, Me.Text)
                Else
                    If Not File_Baz_File_Akt_Monit_Stand_Select Then MsgBox("Base file of standard's monitor activity not choosen!", MsgBoxStyle.Exclamation, Me.Text)
                End If
                Exit Sub
            Else
                Dim first_File As System.IO.FileInfo
                first_File = My.Computer.FileSystem.GetFileInfo(OpenFileDialog_Baz_File_Akt_Mon_Stand.FileNames(0))
                OpenFileDialog_Baz_File_Akt_Mon_Stand.InitialDirectory = first_File.DirectoryName
                My.MySettings.Default.pathTo33 = first_File.DirectoryName
                If My.Settings.language = "Русский" Then
                    MsgBox("Имя базового файла активностей монитора стандарта не должно совпадать с именем файла активностей монитора стандарта!", MsgBoxStyle.Exclamation, Me.Text)
                Else
                    MsgBox("Name of base file of standard's monitor activity should not coincide with file name of standard's monitor activity!", MsgBoxStyle.Exclamation, Me.Text)
                End If
                If OpenFileDialog_Baz_File_Akt_Mon_Stand.SafeFileName = file_name_Akt_Mon_Stand Then
                    Exit Sub
                End If

            End If
            SaveConcIsslObr_ToolStripMenuItem.Enabled = False
            file_name_Baz_File_Akt_Mon_Stand = OpenFileDialog_Baz_File_Akt_Mon_Stand.FileName
            file_name_Baz_File_Akt_Mon_Stand_SafeFileName = OpenFileDialog_Baz_File_Akt_Mon_Stand.SafeFileName
            File_Baz_File_Akt_Monit_Stand_Select = True
            If (File_Baz_File_Akt_Monit_Stand_Select And File_Akt_Monit_Stand_Select) Then rasch_coef()
        Catch ex As Exception
            If My.Settings.language = "Русский" Then
                MsgBox("Операция была отменена (ошибка в VibrBazFileAktMonitStand_ToolStripMenuItem_Click_1)!", MsgBoxStyle.Critical, Me.Text)
            Else
                MsgBox("Operation was cancelled (error in VibrBazFileAktMonitStand_ToolStripMenuItem_Click_1)!", MsgBoxStyle.Critical, Me.Text)
            End If
            Exit Sub
        End Try
    End Sub

    Private Sub rasch_coef()
        Try
            Dim arr_length_Baz_File_Akt_Mon_Stand, arr_length_Akt_Mon_Stand As Integer
            'file_name_Aktivn_Stand_Obr:=OpenDialog_Aktivn_Stand_Obr.FileName;
            arr_length_Baz_File_Akt_Mon_Stand = array_length_RPT(file_name_Baz_File_Akt_Mon_Stand)
            If arr_length_Baz_File_Akt_Mon_Stand = 0 Then
                If My.Settings.language = "Русский" Then
                    MsgBox("Неправильный формат файла " + file_name_Baz_File_Akt_Mon_Stand + "!", MsgBoxStyle.Critical, Me.Text)
                Else
                    MsgBox("Incorrect file format " + file_name_Baz_File_Akt_Mon_Stand + "!", MsgBoxStyle.Critical, Me.Text)
                End If
                Exit Sub
            End If
            ReDim nucl_array_Akt_Baz_Mon_Stand(arr_length_Baz_File_Akt_Mon_Stand - 1, 1)
            ReDim data_array_Akt_Baz_Mon_Stand(arr_length_Baz_File_Akt_Mon_Stand - 1, 2)
            sample_title_Baz_Mon_Stand = ""
            measurements_type = ""
            data_search_RPT(file_name_Baz_File_Akt_Mon_Stand, nucl_array_Akt_Baz_Mon_Stand, data_array_Akt_Baz_Mon_Stand, sample_title_Baz_Mon_Stand, measurements_type)

            arr_length_Akt_Mon_Stand = array_length_RPT(file_name_Akt_Mon_Stand)
            If arr_length_Akt_Mon_Stand = 0 Then
                If My.Settings.language = "Русский" Then
                    MsgBox("Неправильный формат файла " + file_name_Akt_Mon_Stand + "!", MsgBoxStyle.Critical, Me.Text)
                Else
                    MsgBox("Incorrect file format " + file_name_Akt_Mon_Stand + "!", MsgBoxStyle.Critical, Me.Text)
                End If
                Exit Sub
            End If
            ReDim nucl_array_Akt_Mon_Stand(arr_length_Akt_Mon_Stand - 1, 1)
            ReDim data_array_Akt_Mon_Stand(arr_length_Akt_Mon_Stand - 1, 2)
            sample_title_Mon_Stand = ""
            measurements_type = ""
            data_search_RPT(file_name_Akt_Mon_Stand, nucl_array_Akt_Mon_Stand, data_array_Akt_Mon_Stand, sample_title_Mon_Stand, measurements_type)

            'K=активность_из_базового_файла_монитора_стандарта/активность_монитора_образца
            TextBox_Coef.Text = (data_array_Akt_Baz_Mon_Stand(0, 1) / data_array_Akt_Mon_Stand(0, 1)).ToString("F4", CultureInfo.CreateSpecificCulture("en-US"))

        Catch ex As Exception
            If My.Settings.language = "Русский" Then
                MsgBox("Операция была отменена (ошибка в rasch_coef)!", MsgBoxStyle.Critical, Me.Text)
            Else
                MsgBox("Operation was cancelled (error in rasch_coef)!", MsgBoxStyle.Critical, Me.Text)
            End If
            Exit Sub
        End Try
    End Sub

    Private Sub OpenFileAktMonStand_ToolStripMenuItem_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenFileAktMonStand_ToolStripMenuItem.Click
        Try
            ' OpenFileDialog_Akt_Mon_Stand.InitialDirectory = "C:\GENIE2K\CONFILES"
            If OpenFileDialog_Akt_Mon_Stand.ShowDialog = System.Windows.Forms.DialogResult.Cancel Then
                If My.Settings.language = "Русский" Then
                    If Not File_Baz_File_Akt_Monit_Stand_Select Then MsgBox("Файл активностей монитора стандарта не выбран!", MsgBoxStyle.Exclamation, Me.Text)
                Else
                    If Not File_Baz_File_Akt_Monit_Stand_Select Then MsgBox("File of standard's monitor activity not choosen!", MsgBoxStyle.Exclamation, Me.Text)
                End If
                Exit Sub
            Else
                Dim first_File As System.IO.FileInfo
                first_File = My.Computer.FileSystem.GetFileInfo(OpenFileDialog_Akt_Mon_Stand.FileNames(0))
                OpenFileDialog_Akt_Mon_Stand.InitialDirectory = first_File.DirectoryName
                My.MySettings.Default.pathTo34 = first_File.DirectoryName
                If OpenFileDialog_Akt_Mon_Stand.SafeFileName = file_name_Baz_File_Akt_Mon_Stand_SafeFileName Then
                    If My.Settings.language = "Русский" Then
                        MsgBox("Имя файла активностей монитора стандарта не должно совпадать с именем базового файла активностей монитора стандарта!", MsgBoxStyle.Exclamation, Me.Text)
                    Else
                        MsgBox("File name of standard's monitor activity should not coincide with name of base file of standard's monitor activity!", MsgBoxStyle.Exclamation, Me.Text)
                    End If
                    Exit Sub
                End If
            End If
            SaveConcIsslObr_ToolStripMenuItem.Enabled = False

            file_name_Akt_Mon_Stand = OpenFileDialog_Akt_Mon_Stand.FileName
            file_name_Akt_Mon_Stand_SafeFileName = OpenFileDialog_Akt_Mon_Stand_MON.SafeFileName
            File_Akt_Monit_Stand_Select = True
            If (File_Baz_File_Akt_Monit_Stand_Select And File_Akt_Monit_Stand_Select) Then rasch_coef()
        Catch ex As Exception
            If My.Settings.language = "Русский" Then
                MsgBox("Операция была отменена (ошибка в OpenFileAktMonStand_ToolStripMenuItem_Click_2)!", MsgBoxStyle.Critical, Me.Text)
            Else
                MsgBox("Operation was cancelled (error in OpenFileAktMonStand_ToolStripMenuItem_Click_2)!", MsgBoxStyle.Critical, Me.Text)
            End If
            Exit Sub
        End Try
    End Sub

    Private Sub OpenConcIsslObr_ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenConcIsslObr_ToolStripMenuItem.Click
        Try
            If conDict.Keys.Count <> 0 Then
                Dim result As Integer = MessageBox.Show("Файлы концентраций уже загружены. Хотите добавить новые файлы к уже загруженным?", "Программа расчета концентраций", MessageBoxButtons.YesNo)
                If result = DialogResult.No Then
                    conDict.Clear()
                    actDict.Clear()
                    GlobalNuclidsForCon.Clear()
                    GlobalNuclidsForAct.Clear()
                    elements.Clear()
                    xNA24SLI2.Clear()
                    yNA24LLI1.Clear()
                    xSB122LLI1.Clear()
                    ySB124LLI2.Clear()
                    xCE141LLI2.Clear()
                    yLA140LLI1.Clear()
                    xNP239LLI1.Clear()
                    yPA233LLI2.Clear()
                    rowMap.Clear()
                    L_Conc_Issl_Obr_CON.Text = ""
                End If
            End If

            If OpenFileDialog_Conc_Issl_Obr_CON.ShowDialog = System.Windows.Forms.DialogResult.Cancel Then
                MsgBox("Файлы активностей стандартных образцов не выбраны!", MsgBoxStyle.Exclamation, Me.Text)
                Exit Sub
            Else

                Dim filePath As String = System.IO.Path.GetDirectoryName(OpenFileDialog_Conc_Issl_Obr_CON.FileName)

                Dim fileNum As Integer = 0
                Dim fileString As String = ""
                Dim checkStr As String = ""
                ' Tasks.Parallel.ForEach(OpenFileDialog_Conc_Issl_Obr_CON.FileNames, Sub(fileName)
                For Each fileName In OpenFileDialog_Conc_Issl_Obr_CON.FileNames
                    If System.IO.Path.GetFileName(fileName).Contains("_") Then
                        MsgBox(fileName & "  " & "Имя файла не должно содержать нижнее подчеркивание.", MsgBoxStyle.Critical)
                        Exit Sub
                    End If
                    fileString += System.IO.Path.GetFileName(fileName) & ";"
                    Using sw As New IO.StreamReader($"{fileName}")
                        checkStr = sw.ReadLine()
                    End Using
                    Debug.WriteLine($"First row from CON so that detect new or old file type is {checkStr}")
                    If checkStr.StartsWith("*") Then
                        Debug.WriteLine($"New file was found")
                        DataFromCONnew(fileName)
                    Else
                        Debug.WriteLine($"Old file was found")
                        DataFromCON(fileName)
                    End If
                    fileNum += 1
                Next
                ' End Sub)

                L_Conc_Issl_Obr_CON.Text = filePath & "\" & fileString

                B_TablConcElemPromezh_CON.Enabled = True
                B_TablConcElemOkonchat_CON.Enabled = True

            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
            Exit Sub
        End Try
    End Sub

    Public conDict As New Dictionary(Of String, ArrayList)
    Public actDict As New Dictionary(Of String, ArrayList)
    Public GlobalNuclidsForCon As New ArrayList
    Public GlobalNuclidsForAct As New ArrayList
    Public elements As List(Of String) = New List(Of String)
    Public xNA24SLI2, yNA24LLI1, xSB122LLI1, ySB124LLI2, xCE141LLI2, yLA140LLI1, xNP239LLI1, yPA233LLI2 As New Dictionary(Of String, Double)
    Public rowMap As New Dictionary(Of String, Integer)

    Sub DataFromCON(ByVal conFileName As String)
        Try
            Dim sampleName As String = ""

            Dim type As String = ""
            Dim rown As Integer = 1
            '  Dim i As Integer = 0
            Debug.WriteLine("DataFromCON " & conFileName)
            Debug.WriteLine("{sampleName}|{type}|{elemName}|{conc}|{err}|{limit}")
            For Each line As String In File.ReadLines(conFileName, System.Text.Encoding.Default)
                Debug.WriteLine($"The line is [{line}]")
                If rown = 1 Then sampleName = Split(line, ":")(1).Trim 'this is sampleName not elemName
                If rown = 3 Then type = Split(line, ":")(1).Trim
                If rown > 10 Then
                    If String.IsNullOrEmpty(line) Then Exit For
                    ParseLine4Values(line, GlobalNuclidsForCon, conDict, type, sampleName, conFileName)
                End If
                rown += 1
            Next

            If Not elements.Contains(sampleName) Then
                rowMap.Add(sampleName, elements.Count)
                elements.Add(sampleName)
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
            Exit Sub
        End Try
    End Sub

    Sub ParseLine4Values(ByVal line As String, ByRef arr As ArrayList, ByRef dict As Dictionary(Of String, ArrayList), Type As String, ByVal sampleName As String, ByVal conFileName As String)
        Dim conc As Double
        Dim values As New ArrayList
        Debug.WriteLine($"Current line with values: [{line}]")
        line = line.Replace("M" & vbTab, "m" & vbTab)
        line = line.Replace(",", ".")
        values.Add(Split(line, vbTab)(0))
        values.Add(Double.Parse(Split(line, vbTab)(1), CultureInfo.InvariantCulture))
        values.Add(Double.Parse(Split(line, vbTab)(2), CultureInfo.InvariantCulture))
        values.Add(Double.Parse(Split(line, vbTab)(3), CultureInfo.InvariantCulture))

        If Not arr.Contains(values(0) & "_" & Type) Then
            arr.Add(values(0) & "_" & Type)
        End If

        Try
            'conDict.Add(System.IO.Path.GetFileName(conFileName) & "_" & sampleName & "_" & type & "_" & values(0), values)
            conc = values(1)
            Debug.WriteLine($"{sampleName}|{Type}|{values(0)}|{values(1)}|{values(2)}|{values(3)}")
            dict.Add(System.IO.Path.GetFileName(conFileName) & "_" & sampleName & "_" & Type & "_" & values(0), values)
            If Type = "LLI-1" Then
                If values(0) = "NA-24" Then yNA24LLI1.Add(sampleName, conc)
                If values(0) = "SB-122" Then xSB122LLI1.Add(sampleName, conc)
                'If values(0) = "CE-141" Then xCE141LLI1.Add(elemName, conc)
                If values(0) = "LA-140" Then yLA140LLI1.Add(sampleName, conc)
                If values(0) = "NP-239" Then xNP239LLI1.Add(sampleName, conc)
                'If values(0) = "PA-233" Then yPA233LLI1.Add(elemName, conc)
            ElseIf Type = "LLI-2" Then
                If values(0) = "CE-141" Then xCE141LLI2.Add(sampleName, conc)
                If values(0) = "SB-124" Then ySB124LLI2.Add(sampleName, conc)
                If values(0) = "PA-233" Then yPA233LLI2.Add(sampleName, conc)
            ElseIf Type = "SLI-2" Then
                If values(0) = "NA-24" Then xNA24SLI2.Add(sampleName, conc)
            End If
        Catch ex As NullReferenceException
        Catch key As ArgumentException
            Dim result As Integer = MessageBox.Show($"Вероятно произошло дублирование имен образцов в файлах {conFileName}: проверьте образец с именем {sampleName}.", "Крах программы расчета концентраций", MessageBoxButtons.OKCancel)
            If result = DialogResult.Cancel Then
                Application.Restart()
            ElseIf result = DialogResult.OK Then
            End If
        End Try
    End Sub

    'todo: new parsing method
    'todo: add opportunity to save final table right to DB if new format of .con files used
    Sub DataFromCONnew(ByVal conFileName As String)
        Try
            Debug.WriteLine($"Start parsing file {conFileName} like file with new format")
            Dim rowNum As Integer = 0
            Dim line As String = ""
            Dim sampleName As String = ""
            Dim description As String = ""
            Dim id As String = ""
            Dim type As String = ""
            Dim geometry As String = ""
            Dim grs As String = ""
            Dim isFirstTable As Boolean = True
            Dim newStartsRow As Integer = 0
            Using sw As New IO.StreamReader($"{conFileName}")
                While Not sw.EndOfStream
                    line = sw.ReadLine()
                    If rowNum = 5 Then sampleName = StrPars.Right(Trim(line), Trim(line).Length - Trim(line).LastIndexOf(" ") - 1)
                    If rowNum = 6 Then description = StrPars.Right(Trim(line), Trim(line).Length - Trim(line).LastIndexOf(" ") - 1)
                    If rowNum = 7 Then id = StrPars.Right(Trim(line), Trim(line).Length - Trim(line).LastIndexOf(" ") - 1)
                    If rowNum = 8 Then type = StrPars.Right(Trim(line), Trim(line).Length - Trim(line).LastIndexOf(" ") - 1)
                    If rowNum = 9 Then geometry = StrPars.Right(Trim(line), Trim(line).Length - Trim(line).LastIndexOf(" ") - 1)
                    If rowNum = 10 Then grs = StrPars.Right(Trim(line), Trim(line).Length - Trim(line).LastIndexOf(" ") - 1)
                    If rowNum >= 20 And isFirstTable Then
                        If line.StartsWith("*") Then
                            isFirstTable = False
                            newStartsRow = rowNum + 7
                            Continue While
                        End If
                        If String.IsNullOrEmpty(line) Then Continue While
                        ParseLine4Values(line.TrimStart(), GlobalNuclidsForCon, conDict, type, sampleName, conFileName)
                    End If

                    If Not isFirstTable And rowNum >= newStartsRow Then
                        If String.IsNullOrEmpty(line) Then Continue While
                        ParseLine4Values(line.TrimStart(), GlobalNuclidsForAct, actDict, type, sampleName, conFileName)
                    End If

                    rowNum += 1
                End While
            End Using
            If Not elements.Contains(sampleName) Then
                rowMap.Add(sampleName, elements.Count)
                elements.Add(sampleName)
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
            Exit Sub
        End Try
    End Sub

    Private Sub B_TablConcElemPromezh_CON_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_TablConcElemPromezh_CON.Click
        Try
            My.Settings.acc = TextBoxAcc.Text
            Me.Enabled = False
            Debug.WriteLine("Show Intermediate Table Concentration:")
            Form_Intermediate_Table_Concentration.Show()
        Catch ex As Exception
            MsgBox(ex.ToString)
            If My.Settings.language = "Русский" Then
                MsgBox("Операция была отменена (ошибка в B_TablConcElemPromezh_CON_Click)!", MsgBoxStyle.Critical, Me.Text)
            Else
                MsgBox("Operation was cancelled (error in B_TablConcElemPromezh_CON_Click)!", MsgBoxStyle.Critical, Me.Text)
            End If
            Exit Sub
        End Try
    End Sub

    Private Sub B_TablConcElemOkonchat_CON_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_TablConcElemOkonchat_CON.Click
        Try
            Me.Enabled = False
            Form_Final_Table_Concentration.Show()
        Catch ex As Exception
            MsgBox(ex.ToString)
            If My.Settings.language = "Русский" Then
                MsgBox("Операция была отменена (ошибка в B_TablConcElemPromezh_CON_Click)!", MsgBoxStyle.Critical, Me.Text)
            Else
                MsgBox("Operation was cancelled (error in B_TablConcElemPromezh_CON_Click)!", MsgBoxStyle.Critical, Me.Text)
            End If
            Exit Sub
        End Try
    End Sub

    Private Sub B_Otm_Vib_Fil_Mon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_Otm_Vib_Fil_Mon.Click
        Try
            File_Baz_File_Akt_Monit_Stand_Select = False
            File_Akt_Monit_Stand_Select = False
            TextBox_Coef.Text = "1.0"
        Catch ex As Exception
            If My.Settings.language = "Русский" Then
                MsgBox("Операция была отменена (ошибка в B_Otm_Vib_Fil_Mon_Click)!", MsgBoxStyle.Critical, Me.Text)
            Else
                MsgBox("Operation was cancelled (error in B_Otm_Vib_Fil_Mon_Click)!", MsgBoxStyle.Critical, Me.Text)
            End If
            Exit Sub
        End Try
    End Sub

    'Private Sub Language_ToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles Language_ToolStripMenuItem.Click
    '    Try
    '        Me.Enabled = False
    '        Form_Language.Show()
    '    Catch ex As Exception
    '        If My.Settings.language = "Русский" Then
    '            MsgBox("Операция была отменена (ошибка в Language_ToolStripMenuItem_Click)!", MsgBoxStyle.Critical, Me.Text)
    '        Else
    '            MsgBox("Operation was cancelled (error in Language_ToolStripMenuItem_Click)!", MsgBoxStyle.Critical, Me.Text)
    '        End If
    '        Exit Sub
    '    End Try
    'End Sub

    'Private Sub Form_Main_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
    '    Try
    '        Initial_Installations()

    '        ''убрать комментарии ниже
    '        'Me.Enabled = False
    '        'Form_Language.Show()
    '        ''убрать комментарии выше
    '        ' MsgBox("hey")
    '        ' MsgBox(System.Deployment.Application.ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString())


    '    Catch ex As Exception
    '        MsgBox(ex.ToString)
    '        If My.Settings.language = "Русский" Then
    '            MsgBox("Операция была отменена (ошибка в Form_Main_Shown)!", MsgBoxStyle.Critical, Me.Text)
    '        Else
    '            MsgBox("Operation was cancelled (error in Form_Main_Shown)!", MsgBoxStyle.Critical, Me.Text)
    '        End If
    '        Exit Sub
    '    End Try
    'End Sub



    Public Sub Initial_Installations()
        Try
            GroupBox_L_Aktivnosti.Focus()
            B_calc_conc.Enabled = False
            File_Aktivn_Issl_Obr_Select = False
            File_Grup_Stand_Select = False
            File_Aktivn_Stand_Obr_Select = False
            File_Sert_Conc_Elem_Select = False
            File_Baz_File_Akt_Monit_Stand_Select = False
            File_Akt_Monit_Stand_Select = False
            SaveConcIsslObr_ToolStripMenuItem.Enabled = False


            B_Perschet_Aktivn_Stand.Enabled = False
            File_Baz_File_Akt_Monit_Stand_Select_MON = False
            File_Akt_Stand_Select_MON = False
            File_Akt_Monit_Stand_Select_MON = False
            SavePereschAktStand_MON_ToolStripMenuItem.Enabled = False

            Aktivn_Issl_Obr_Files_Quant = 0
            Akt_Stand_Files_MON_Quant = 0

            B_TablConcElemPromezh_CON.Enabled = False
            B_TablConcElemOkonchat_CON.Enabled = False


            TextBox_Coef.Text = "1.0"
            TextBox_system_Pogr.Text = "0"

            If My.Settings.language = "Русский" Then
                ComboBox_SLI_Source.SelectedItem = "КЖИ-1 и КЖИ-2"
            Else
                ComboBox_SLI_Source.SelectedItem = "SLI-1 and SLI-2"
            End If

        Catch ex As Exception
            If My.Settings.language = "Русский" Then
                MsgBox("Операция была отменена (ошибка в Initial_Installations)!", MsgBoxStyle.Critical, Me.Text)
            Else
                MsgBox("Operation was cancelled (error in Initial_Installations)!", MsgBoxStyle.Critical, Me.Text)
            End If
            Exit Sub
        End Try
    End Sub

    Private Sub Clear_Form_ToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles Clear_Form_ToolStripMenuItem.Click
        Try
            Initial_Installations()
            Application.Restart()
        Catch ex As Exception
            If My.Settings.language = "Русский" Then
                MsgBox("Операция была отменена (ошибка в Clear_Form_ToolStripMenuItem_Click)!", MsgBoxStyle.Critical, Me.Text)
            Else
                MsgBox("Operation was cancelled (error in Clear_Form_ToolStripMenuItem_Click)!", MsgBoxStyle.Critical, Me.Text)
            End If
            Exit Sub
        End Try
    End Sub

    Private Sub Table_Nuclides_ToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles Table_Nuclides_ToolStripMenuItem.Click
        Form_Table_Nuclides.Show()
        Me.Enabled = False
    End Sub

    Public NuclidFromTable As New ArrayList
    Sub NuclidFromTableFill()
        Try
            NuclidFromTable.Clear()
            Debug.WriteLine("Nuclids table parsing:")
            If File.Exists("C:\\WORKPROG\\saved_table_nuclides.txt") Then
                If File.ReadAllText("C:\WORKPROG\saved_table_nuclides.txt").Length <> 0 Then
                    For Each line As String In File.ReadLines("C:\WORKPROG\saved_table_nuclides.txt", System.Text.Encoding.UTF8)
                        '  NuclidFromTable.Add(Split(line, "_")(0) & "_" & TypeEngRu(Split(line, "_")(1)))
                        Debug.WriteLine(Split(line, "_")(0) & "_" & Split(line, "_")(1))
                        NuclidFromTable.Add(Split(line, "_")(0) & "_" & Split(line, "_")(1))
                    Next
                Else

                    My.Computer.FileSystem.WriteAllText("C:\\WORKPROG\\saved_table_nuclides.txt", "", False)
                    'fixme: добавляет конец строки в начале каждого элемента lines кроме первого решил через костыль if-else
                    For Each line As String In My.Resources.table_nuclides_def.Split(CChar(Environment.NewLine))

                        If line <> My.Resources.table_nuclides_def.Split(CChar(Environment.NewLine))(0) Then
                            line = line.Substring(1)
                        End If
                        ' NuclidFromTable.Add(Split(line, "_")(0) & "_" & TypeEngRu(Split(line, "_")(1)))
                        NuclidFromTable.Add(Split(line, "_")(0) & "_" & Split(line, "_")(1))
                    Next
                End If
            Else
                Debug.WriteLine("New file was created;")
                My.Computer.FileSystem.WriteAllText("C:\\WORKPROG\\saved_table_nuclides.txt", My.Resources.table_nuclides_def, False)
                NuclidFromTableFill()
            End If
        Catch fnf As FileNotFoundException
            Debug.WriteLine(fnf.ToString)
            '  File.CreateText("C:\\WORKPROG\\saved_table_nuclides.txt")

            '  My.Computer.FileSystem.WriteAllText("C:\\WORKPROG\\saved_table_nuclides.txt", "", False)
            ' NuclidFromTableFill()
        Catch ex As Exception
            '   My.Computer.FileSystem.WriteAllText("C:\\WORKPROG\\saved_table_nuclides.txt", "", False)
            '  NuclidFromTableFill()
            MsgBox(ex.ToString)
        End Try

    End Sub

    Public TypeRuEng As New Dictionary(Of String, String)
    Public TypeEngRu As New Dictionary(Of String, String)

    Private Sub Form_Main_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        For Each c As Control In Me.Controls
            Debug.WriteLine($"<Type key={Chr(34)}{c.Name}{Chr(34)} value={Chr(34)}{c.Text}{Chr(34)}/>")
        Next

        TypeEngRu.Add("SLI-1", "КЖИ-1")
        TypeEngRu.Add("SLI-2", "КЖИ-2")
        TypeEngRu.Add("LLI-1", "ДЖИ-1")
        TypeEngRu.Add("LLI-2", "ДЖИ-2")
        TypeEngRu.Add("-", "-")

        TypeRuEng.Add("КЖИ-1", "SLI-1")
        TypeRuEng.Add("КЖИ-2", "SLI-2")
        TypeRuEng.Add("ДЖИ-1", "LLI-1")
        TypeRuEng.Add("ДЖИ-2", "LLI-2")
        TypeRuEng.Add("-", "-")
        NuclidFromTableFill()

        LangEngToolStripMenuItem.Text = My.Settings.language

        LocalizedForm()

        excp.Add("AL-29", "SI")
        excp.Add("CO-58", "NI")
        excp.Add("NP-239", "U")
        excp.Add("PA-233", "TH")
        UpdateMessenger.ShowMessage()
    End Sub

    Private Sub Form_Main_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        Application.Exit()

    End Sub

    Private Sub Form_Main_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        LocalizedForm()
    End Sub
End Class