Imports System.Deployment.Application

Module UpdateMessenger
    Sub ShowMessage()
        Try
            Dim UpdMsg As String
            UpdMsg = $"{vbTab}Исправлены замеченные неточности.{vbCrLf}"
            UpdMsg = $"{vbTab}Исправлены замеченные неточности.{vbCrLf}"
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
