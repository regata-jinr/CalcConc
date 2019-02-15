Imports System.Deployment.Application

Module UpdateMessenger
    Sub ShowMessage()
        Try
            Dim UpdMsg As String
            UpdMsg = $"Добавлен английский интерфейс{vbCrLf}Добавлены следующие изменения в отображении файлов и таблиц концентраций:{vbCrLf}{vbTab}1. Изменен формат файлов концентраций, однако, программа совместима со старым форматом .con{vbCrLf}{vbTab}2. Появилась возможность просматривать значения активностей элементов, паспортные значения которых не найдены в эталоне.{vbCrLf}{vbTab}3. Отмеченная опция 'Рассчитать для фильтров' выводит значения концентраций в микрограммах."
            'update message
            If ApplicationDeployment.IsNetworkDeployed Then
                Dim current As ApplicationDeployment = ApplicationDeployment.CurrentDeployment
                If current.IsFirstRun Then
                    MessageBox.Show($"В новой версии программы {Application.ProductVersion}{vbCrLf}{vbCrLf}{UpdMsg}{vbCrLf}{vbCrLf}Свои комментарии, замечания, сообщения об ошибках Вы можете сообщить мне {vbCrLf}по почте - bdrum@jinr.ru{vbCrLf}по телефону - 6 24 36{vbCrLf}лично{vbCrLf}С уважением,{vbCrLf}Борис Румянцев", $"Обновление программы расчета концентраций", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical)
        End Try
    End Sub
End Module
