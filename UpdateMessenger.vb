Imports System

Module UpdateMessenger
    Sub ShowMessage()
        Try
            'В случае, если мне надо что-то изменять на компьютерах пользователей.
            'If My.Settings.currentVersion <> Application.ProductVersion Then
            '    Dim result As Integer = MessageBox.Show("Добрый день, уважаемый пользователь! Теперь, после каждого обновления, будет выводиться такое сообщение, в котором я буду сообщать Вам об изменениях в программе. В новой версии исправлена ошибка добавления элементов содержащих заглавную букву M в финальную таблицу. Вы можете нажать кнопу ОК, в таком случае Ваша таблица обновится автоматически. Если у Вас есть какие-либо изменения в таблице нуклидов, которые вы хотите сохранить, это необходимо проделать вручную. Файл с таблицей находится в папке WORKPROG. Хорошего дня!", "Обновление программы расчета концентраций", MessageBoxButtons.OKCancel)
            '    If result = DialogResult.Cancel Then
            '        Exit Sub
            '    ElseIf result = DialogResult.OK Then
            '        Form_Table_Nuclides.ButRestoreDefaults_Click(Nothing, Nothing)
            '        My.Settings.currentVersion = Application.ProductVersion
            '    End If
            'End If
            '  В случае, если мне не надо ничего изменять на компьютерах пользователей.
            If Application.ProductVersion <> My.MySettings.Default.currentVersion Then
                MsgBox($"В новой версии программы {Application.ProductVersion} сортировка элементов в таблицах производится в соответствии c таблицей нуклидов. Информация о некоторых ошибках дополнена так, что может помочь понять в чем причина ошибки. Внимательно читайте сообщение, возникающее при ошибке. Добавлен алгоритм округления, который записывает число в более удобном виде, теряя при этом не более 1% точности.", MsgBoxStyle.Information)
                My.MySettings.Default.currentVersion = Application.ProductVersion
            End If
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical)
        End Try
    End Sub
End Module
