Imports System.Deployment.Application

Module UpdateMessenger
    Sub ShowMessage()
        Try
            Dim UpdMsg As String
            UpdMsg = $"{vbTab}Добавлен редактор просмотра значений концентраций с возможностью считать средние значения. Для использования необходимо, как обычно, выбрать файлы концентраций(для построения таблиц). Затем нажать на появившуюся кнопку просмотр значений концентраций. В открытом окне отобразиться содержимое выбранных файлов, а также усредненные значения. На мой взгляд, интерфейс окна примитивный и в описании не нуждается.{vbCrLf}{vbCrLf}{vbTab}Исправлено дублирование имен в файле со среднеми значениями{vbCrLf}{vbTab}Переработан механизм подсвечивания разброса.{vbCrLf}{vbTab}Исправлен сброс окрашивания различающихся строк после удаления или восстановления.{vbCrLf}{vbTab}Исправлены замеченные ошибки{vbCrLf}"
            'update message
            If ApplicationDeployment.IsNetworkDeployed Then
                Dim current As ApplicationDeployment = ApplicationDeployment.CurrentDeployment
                If current.IsFirstRun Then
                    MessageBox.Show($"В новой версии программы {Application.ProductVersion}{vbCrLf}{vbCrLf}{UpdMsg}{vbCrLf}{vbCrLf}Комментарии, замечания, сообщения об ошибках Вы можете сообщить мне{vbCrLf}по почте - bdrum@jinr.ru{vbCrLf}по телефону - 6 24 36{vbCrLf}лично{vbCrLf}С уважением,{vbCrLf}Борис Румянцев", $"Обновление программы расчета концентраций", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical)
        End Try
    End Sub
End Module
