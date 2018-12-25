Imports IWshRuntimeLibrary
Public Class Form1
    Dim SendToFolder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\Microsoft\Windows\SendTo\"
    Dim shell = CreateObject("WScript.Shell")
    Dim files() As String
    Dim no_ext As String = Nothing
    Dim TargetPath As String
    Dim items As ListViewItem
    Dim shrt(2) As String
    Dim wsh As New WshShell
    Dim iconpath As String
    Dim ext As String = Nothing

    Public Sub Display()
        Title.Select()
        SrtIcon.Image = Nothing
        SrtIcon.Visible = False
        change_icon.Visible = False
        delete_srt.Visible = False
        rename_srt.Visible = False
        SrtTitle.Visible = False
        shrt(1) = Nothing
        shrt(2) = Nothing
        ListView1.Clear()
        ListView1.Columns.Add("Shortcut", 80)
        ListView1.Columns.Add("Target", 300)

        files = IO.Directory.GetFiles(SendToFolder)

        For Each File As String In files
            no_ext = IO.Path.GetFileNameWithoutExtension(File)
            If (no_ext = "desktop") Then
                Continue For
            End If
            Try
                TargetPath = shell.CreateShortcut(File).TargetPath
                shrt(1) = TargetPath
            Catch ex As Exception

            End Try
            shrt(0) = no_ext
            items = New ListViewItem(shrt)
            ListView1.Items.Add(items)
        Next
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        files = IO.Directory.GetFiles(SendToFolder)
        Try
            If Not (ListView1.SelectedItems(0).Text = Nothing) Then
                SrtIcon.Visible = True
                change_icon.Visible = True
                delete_srt.Visible = True
                rename_srt.Visible = True
                SrtTitle.Visible = True
                SrtTitle.Text = ListView1.SelectedItems(0).Text
                Try
                    For Each File As String In files
                        If (File.Contains(ListView1.SelectedItems(0).Text)) Then
                            ext = IO.Path.GetExtension(File)
                            Exit For
                        End If
                    Next
                    SrtIcon.Image = Icon.ExtractAssociatedIcon(SendToFolder + ListView1.SelectedItems(0).Text + ext).ToBitmap
                Catch ex As Exception
                End Try
            End If
        Catch ex As Exception
            SrtIcon.Image = Nothing
            SrtIcon.Visible = False
            change_icon.Visible = False
            delete_srt.Visible = False
            rename_srt.Visible = False
        End Try
    End Sub

    Private Sub Delete_srt_Click(sender As Object, e As EventArgs) Handles delete_srt.Click
        My.Computer.FileSystem.DeleteFile(SendToFolder + ListView1.SelectedItems(0).Text + ext)
        Display()
    End Sub

    Private Sub Refresh_srt_Click(sender As Object, e As EventArgs) Handles refresh_srt.Click
        Display()
    End Sub

    Private Sub Rename_srt_Click(sender As Object, e As EventArgs) Handles rename_srt.Click
        Dim NewName As String
        NewName = InputBox("Enter new name for this shortcut" + vbNewLine + vbNewLine + "You will see this name in sendto menu" + vbNewLine + vbNewLine + "Click cancel if you don't won't to rename", "SendTo Manager", ListView1.SelectedItems(0).Text)
        If Not (NewName = Nothing) Then
            My.Computer.FileSystem.RenameFile(SendToFolder + ListView1.SelectedItems(0).Text + ext, NewName + ext)
        End If
        Display()
    End Sub

    Private Sub Change_icon_Click(sender As Object, e As EventArgs) Handles change_icon.Click
        OpenFileDialog1.FileName = "Select Icon"
        OpenFileDialog1.Filter = "Icon|*.ico"
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            Dim NewSrt As IWshShortcut = wsh.CreateShortcut(SendToFolder + ListView1.SelectedItems(0).Text + ".lnk")
            NewSrt.IconLocation = OpenFileDialog1.FileName
            NewSrt.Save()
            Display()
            MsgBox("Icon Changed")
        End If
    End Sub

    Private Sub Add_folder_Click(sender As Object, e As EventArgs) Handles add_folder.Click
        If FolderBrowserDialog1.ShowDialog = DialogResult.OK Then
            Dim SrtFolderName As String = My.Computer.FileSystem.GetName(FolderBrowserDialog1.SelectedPath + ".lnk")
            Dim NewSrt As IWshShortcut = wsh.CreateShortcut(SendToFolder + SrtFolderName)
            NewSrt.TargetPath = FolderBrowserDialog1.SelectedPath
            NewSrt.Save()
        End If
        Display()
    End Sub

    Private Sub Add_app_Click(sender As Object, e As EventArgs) Handles add_app.Click
        OpenFileDialog1.FileName = "Select Application"
        OpenFileDialog1.Filter = "Application|*.exe"
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            Dim SrtFileName As String = IO.Path.GetFileNameWithoutExtension(OpenFileDialog1.FileName)
            Dim NewSrt As IWshShortcut = wsh.CreateShortcut(SendToFolder + SrtFileName + ".lnk")
            NewSrt.TargetPath = OpenFileDialog1.FileName
            NewSrt.Save()
        End If
        Display()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Display()
    End Sub

    Private Sub TelegramToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TelegramToolStripMenuItem.Click
        Process.Start("https://t.me/VarunSaiTeja")
    End Sub

    Private Sub YouTubeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles YouTubeToolStripMenuItem.Click
        Process.Start("https://www.youtube.com/VarunTeja")
    End Sub

    Private Sub PaytmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PaytmToolStripMenuItem.Click
        Process.Start("http://tiny.cc/varunpaytm")
    End Sub

    Private Sub UPIToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UPIToolStripMenuItem.Click
        Process.Start("http://tiny.cc/varunupi")
    End Sub

    Private Sub PayPalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PayPalToolStripMenuItem.Click
        Process.Start("https://www.paypal.me/varunsaiteja")
    End Sub
End Class
