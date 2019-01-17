Imports System.Deployment.Application

Module UpdateMessenger
    Sub ShowMessage()
        Try
            Dim UpdMsg As String
            UpdMsg = $"Добавлен английский интерфейс{vbCrLf}Добавлены следующие изменения в отображении файлов и таблиц концентраций:{vbCrLf}{vbTab}1. В редакторе ГРС появился пункт настройки, который содержит пометку 'Показывать нуклиды со значениями не найденными в пасспорте'. Если включить эту опцию перед рассчетом ГРС, все нуклиды не найденные в ref файлах, но присутствующие в эталонах будут включены в ГРС. Это может быть использовано в тех случаях, когда Вы хотите показать, что элемент в образце найден, но у него отсутствует паспортное значение концентрации в эталоне.{vbCrLf}{vbTab}2. В файлах концентрации появились пометки с расшифровкой.{vbCrLf}{vbTab}3. В окончательной и промежуточной таблицах найденные элементов не имеющие паспортных значений концентрации содержат значения активности и ее погрешщности, а также закрашиваются белым цветом."
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
