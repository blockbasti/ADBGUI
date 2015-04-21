Imports RegawMOD.Android
Imports System.Globalization

Public Class Main
    Dim android As AndroidController
    Dim device As Device
    Dim serial As String
    Dim prev As String = ""
    'Variablen für Gerätestatus'
    Dim device_value_status As String
    Dim device_value_battery As Integer
    Dim device_value_name As String
    Dim device_value_temperature As Double
    Dim device_value_manufacturer As String
    Dim device_value_battery_technology As String
    Dim device_value_codename As String
    Dim device_value_root As String
    Dim device_value_busybox As String
    Dim device_value_sdfree As String
    Dim device_value_internfree As String
    Dim device_value_systemfree As String
    Dim device_value_ownpathfree As String
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        android = AndroidController.Instance
        TextBox_OwnPath.Text = My.Settings.OwnPath
        TextBox_Path_Internal.Text = My.Settings.InternalPath
        TextBox_Path_SDCard.Text = My.Settings.SDPath
        Select Case My.Settings.color
            Case "blue"
                RadioButton_blue.Checked = True
            Case "green"
                RadioButton_green.Checked = True
            Case "grey"
                RadioButton_grey.Checked = True
            Case "purple"
                RadioButton_purple.Checked = True
            Case "red"
                RadioButton_red.Checked = True
        End Select
        ChangeColor()
        StatusWorker.RunWorkerAsync()
        StatusTimer.Start()
        GetApps()

        ScreenTimer.Start()
    End Sub
    Private Sub Main_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        android.Dispose()
        'Löscht evtl. das verbleibende Bild der Bildschirmübertragung.'
        Picture_Screen.Dispose()
        If System.IO.File.Exists(Application.StartupPath + "/screen.png") = True Then
            System.IO.File.Delete(Application.StartupPath + "/screen.png")
        End If
    End Sub

    'Timer um die Statusleiste zu aktualisieren.'
    Private Sub StatusTimer_Tick(sender As Object, e As EventArgs) Handles StatusTimer.Tick
        Label_Status.Text = device_value_status
        Label_DeviceName.Text = device_value_name
        ProgressBar_Battery.Value = device_value_battery
        Label_Battery.Text = CStr(device_value_battery) + "%"
        Label_device_temperature.Text = CStr(device_value_temperature) + "°C"
        Label_device_batterylevel.Text = Label_Battery.Text
        Label_device_batterytechnology.Text = device_value_battery_technology
        Label_device_manufacturer.Text = device_value_manufacturer
        Label_device_device.Text = device_value_name
        Label_device_codename.Text = device_value_codename
        Label_device_root.Text = device_value_root
        Label_device_busybox.Text = device_value_busybox
        Label_device_sdcard.Text = device_value_sdfree
        Label_device_intern.Text = device_value_internfree
        Label_device_system.Text = device_value_systemfree
        Label_device_ownpath.Text = device_value_ownpathfree
        Label_ownpath.Text = TextBox_OwnPath.Text + ":"
        If StatusWorker.IsBusy = False Then StatusWorker.RunWorkerAsync()
    End Sub

    'Workerthread um die Verbindung etc. zu überprüfen. Gibt Werte für StatusTimer zurück.'
    Private Sub StatusWorker_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles StatusWorker.DoWork
        android.UpdateDeviceList()
        ChangeColor()
        My.Settings.OwnPath = TextBox_OwnPath.Text
        My.Settings.InternalPath = TextBox_Path_Internal.Text
        My.Settings.SDPath = TextBox_Path_SDCard.Text
        If android.HasConnectedDevices Then
            serial = android.ConnectedDevices(0)
            device = android.GetConnectedDevice(serial)
            Select Case device.State
                Case 0
                    device_value_status = "Verbunden"
                Case 1
                    device_value_status = "Offline"
                Case 2
                    device_value_status = "Recovery"
                Case 3
                    device_value_status = "Fastboot"
                Case 4
                    device_value_status = "Unbekannt"
            End Select
            If device.State = DeviceState.ONLINE Then
                device_value_battery = device.Battery.Level
                device_value_name = device.BuildProp.GetProp("ro.product.model")
                device_value_manufacturer = Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(device.BuildProp.GetProp("ro.product.brand"))
                device_value_temperature = device.Battery.Temperature / 10
                device_value_battery_technology = device.Battery.Technology
                device_value_codename = device.BuildProp.GetProp("ro.product.name")
                device_value_sdfree = df("/storage/sdcard1")
                device_value_internfree = df("/data")
                device_value_systemfree = df("/system")
                device_value_ownpathfree = df(TextBox_OwnPath.Text)
                Select Case device.BusyBox.IsInstalled
                    Case True
                        device_value_busybox = "Ja(" + CStr(device.BusyBox.Version) + ")"
                    Case False
                        device_value_busybox = "Nein"
                End Select
                Select Case device.HasRoot
                    Case True
                        device_value_root = "Ja"
                    Case False
                        device_value_root = "Nein"
                End Select
            End If
        Else
            device_value_status = "kein Gerät"
            device_value_battery = 0
            device_value_name = "kein Gerät"
        End If
    End Sub

    'Macht einen Screenshot des Displays und sendet ihn an Picture_Screen.'
    Public Sub ScreenWorker_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles ScreenWorker.DoWork
        Adb.ExecuteAdbCommandNoReturn(Adb.FormAdbCommand("shell screencap -p /sdcard/screen.png"))
        device.PullFile("/sdcard/screen.png", Application.StartupPath + "/screen.png")
        Picture_Screen.ImageLocation = Application.StartupPath + "/screen.png"
        Adb.ExecuteAdbCommandNoReturn(Adb.FormAdbCommand("shell rm /sdcard/screen.png"))
        System.IO.File.Delete(Application.StartupPath + "/screen2.png")

        Adb.ExecuteAdbCommandNoReturn(Adb.FormAdbCommand("shell screencap -p /sdcard/screen2.png"))
        device.PullFile("/sdcard/screen.png", Application.StartupPath + "/screen2.png")
        Picture_Screen.ImageLocation = Application.StartupPath + "/screen2.png"
        Adb.ExecuteAdbCommandNoReturn(Adb.FormAdbCommand("shell rm /sdcard/screen2.png"))
        System.IO.File.Delete(Application.StartupPath + "/screen.png")
    End Sub

    'Bildschirmübertragung/-aufnahme'
    Private Sub TrackBar_RecTime_ValueChanged(sender As Object, e As EventArgs) Handles TrackBar_RecTime.ValueChanged
        Label_RecTime.Text = CStr(TrackBar_RecTime.Value) + "s"
    End Sub

    Private Sub TrackBar_Bitrate_ValueChanged(sender As Object, e As EventArgs) Handles TrackBar_Bitrate.ValueChanged
        Label_Bitrate.Text = CStr(TrackBar_Bitrate.Value) + "Mb/s"
    End Sub

    Private Sub CheckBox_Resolution_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_Resolution.CheckedChanged
        If CheckBox_Resolution.Checked = True Then
            TextBox_ResHeight.ReadOnly = False
            TextBox_ResWidth.ReadOnly = False
        Else
            TextBox_ResHeight.ReadOnly = True
            TextBox_ResWidth.ReadOnly = True
        End If
    End Sub

    Private Sub Button_Screenrec_Click(sender As Object, e As EventArgs) Handles Button_Screenrec.Click
        If CheckBox_Resolution.Checked = True Then
            Adb.ExecuteAdbCommand(Adb.FormAdbCommand("shell screenrecord --size " + TextBox_ResHeight.Text + "x" + TextBox_ResWidth.Text + " --bit-rate " + CStr(TrackBar_Bitrate.Value * 1000000) + " --time-limit " + CStr(TrackBar_RecTime.Value) + " /sdcard/adbgui_aufnahme.mp4"))
        Else
            Adb.ExecuteAdbCommand(Adb.FormAdbCommand("shell screenrecord --bit-rate " + CStr(TrackBar_Bitrate.Value * 1000000) + " --time-limit " + CStr(TrackBar_RecTime.Value) + " /sdcard/adbgui_aufnahme.mp4"))
        End If
        If CheckBox_RecOnPC.Checked = True Then
            device.PullFile("/sdcard/adbgui_aufnahme.mp4", Environment.GetFolderPath(Environment.SpecialFolder.MyVideos) + "/adbgui_aufnahme.mp4")
            Adb.ExecuteAdbCommandNoReturn(Adb.FormAdbCommand("shell rm /sdcard/adbgui_aufnahme.mp4"))
        End If
    End Sub

    'Neustart Buttons'
    Private Sub Button_Reboot_Click(sender As Object, e As EventArgs) Handles Button_Reboot.Click
        device.Reboot()
    End Sub

    Private Sub Button_Fastboot_Click(sender As Object, e As EventArgs) Handles Button_Fastboot.Click
        device.FastbootReboot()
    End Sub

    Private Sub Button_Bootloader_Click(sender As Object, e As EventArgs) Handles Button_Bootloader.Click
        device.RebootBootloader()
    End Sub

    Private Sub Button_Recovery_Click(sender As Object, e As EventArgs) Handles Button_Recovery.Click
        device.RebootRecovery()
    End Sub

    'Sideload'
    Private Sub Button_RecoverySideload_Click(sender As Object, e As EventArgs) Handles Button_RecoverySideload.Click
        device.RebootRecovery()
    End Sub

    Private Sub Button_SideloadSearch_Click(sender As Object, e As EventArgs) Handles Button_SideloadSearch.Click
        OpenFileDialog.ShowDialog()
        TextBox_SideloadPath.Text = OpenFileDialog.FileName
    End Sub

    Private Sub Button_Sideload_Click(sender As Object, e As EventArgs) Handles Button_Sideload.Click
        If TextBox_SideloadPath.Text <> "" Then
            Adb.ExecuteAdbCommand(Adb.FormAdbCommand("sideload " + TextBox_SideloadPath.Text))
        Else
            MsgBox("Bitte Datei auswählen!")
        End If
    End Sub
    'Telefon'
    Private Sub Button_Dial_Click(sender As Object, e As EventArgs) Handles Button_Dial.Click
        device.Phone.DialPhoneNumber(TextBox_Nummer.Text)
    End Sub

    Private Sub Button_Call_Click(sender As Object, e As EventArgs) Handles Button_Call.Click
        device.Phone.CallPhoneNumber(TextBox_Nummer.Text)
    End Sub

    'Freier Speicher'
    Function df(Path As String) As String
        Dim Returned As String

        Returned = Adb.ExecuteAdbCommand(Adb.FormAdbCommand("shell df " + Path))
        Returned = Returned.Remove(0, 57)
        Returned = Returned.Replace(Path, "")
        Returned = Returned.Replace(Environment.NewLine, "")
        Dim Formated() As String = Returned.Split({" "}, StringSplitOptions.RemoveEmptyEntries)
        If (Formated(1) <> "No") And (Path <> "") Then
            Return Formated(1) + "B von " + Formated(0) + "B benutzt (" + Formated(2) + "B frei)"
        Else
            Return "0KB von 0KB benutzt (0KB frei)"
        End If
    End Function
    'Apps'
    Private Sub Button_Apps_Refresh_Click(sender As Object, e As EventArgs) Handles Button_Apps_Refresh.Click
        GetApps()
    End Sub
    Sub GetApps()
        Dim Apps() As String = Replace(Adb.ExecuteAdbCommand(Adb.FormAdbCommand("shell pm list packages")), "package:", "").Split(Environment.NewLine.ToCharArray, StringSplitOptions.RemoveEmptyEntries)
        ListBox_Apps.Items.Clear()
        For Each App In Apps
            ListBox_Apps.Items.Add(App)
        Next
        ListBox_Apps.Sorted = True
    End Sub

    Private Sub TextBox_OwnPath_MouseClick(sender As Object, e As MouseEventArgs)
        TextBox_OwnPath.Text = ""
    End Sub

    Private Sub Button_Uninstall_Click(sender As Object, e As EventArgs) Handles Button_Uninstall.Click
        Adb.ExecuteAdbCommand(Adb.FormAdbCommand("uninstall " + ListBox_Apps.Items.Item(ListBox_Apps.SelectedIndex)))
        GetApps()
    End Sub

    Private Sub ScreenTimer_Tick(sender As Object, e As EventArgs) Handles ScreenTimer.Tick
        If CheckBox_ScreenCap.Checked = True Then
            If ScreenWorker.IsBusy = False Then
                ScreenWorker.RunWorkerAsync()
            End If
        End If
    End Sub
    'Dateimanager'
    Private Sub Button_PushFile_Click(sender As Object, e As EventArgs) Handles Button_PushFile.Click
        OpenFile_Push.ShowDialog()
        TextBox_PathPC.Text = OpenFile_Push.FileName
    End Sub

    Private Sub Button_PullDirectory_Click(sender As Object, e As EventArgs) Handles Button_PullDirectory.Click
        FolderBrowserPull.ShowDialog()
        TextBox_PathPC.Text = FolderBrowserPull.SelectedPath
    End Sub

    Private Sub Button_Pull_Click(sender As Object, e As EventArgs) Handles Button_Pull.Click
        If TextBox_PathPhone.Text <> "" And TextBox_PathPC.Text <> "" Then
            If TextBox_PathPhone.Text.Contains(".") Then
                device.PullFile(TextBox_PathPhone.Text, TextBox_PathPC.Text)
            Else
                device.PullDirectory(TextBox_PathPhone.Text, TextBox_PathPC.Text)
            End If
        Else
            MessageBox.Show("Bitte Pfad eingeben!")
        End If
    End Sub

    Private Sub Button_Push_Click(sender As Object, e As EventArgs) Handles Button_Push.Click
        If TextBox_PathPhone.Text <> "" And TextBox_PathPC.Text <> "" Then
            device.PushFile(TextBox_PathPC.Text, TextBox_PathPhone.Text)
        Else
            MessageBox.Show("Bitte Pfad eingeben!")
        End If
    End Sub
    'APK installieren'
    Private Sub Button_Install_Click(sender As Object, e As EventArgs) Handles Button_Apk.Click
        OpenFile_Apk.ShowDialog()
        TextBox_Apk.Text = OpenFile_Apk.FileName
    End Sub

    Private Sub Button_Install_Click_1(sender As Object, e As EventArgs) Handles Button_Install.Click
        If TextBox_Apk.Text <> "" Then
            device.InstallApk(TextBox_Apk.Text)
            GetApps()
        Else
            MessageBox.Show("Pfad eingeben!")
        End If
    End Sub

    Private Sub TextBox_Apps_Search_TextChanged(sender As Object, e As EventArgs) Handles TextBox_Apps_Search.TextChanged
        If TextBox_Apps_Search.Text <> String.Empty Then
            Dim index As Integer = ListBox_Apps.FindString(TextBox_Apps_Search.Text)
            If index <> -1 Then
                ListBox_Apps.SetSelected(index, True)
            End If
        End If
    End Sub

    'BuildProp'
    Private Sub Button_BuildPropRefresh_Click(sender As Object, e As EventArgs) Handles Button_BuildPropRefresh.Click
        GetBuildProp()
    End Sub

    Sub GetBuildProp()
        ListBox_BuildProp.Items.Clear()
        ListBox_BuildProp.Items.AddRange(device.BuildProp.Keys.ToArray)
        ListBox_BuildProp.Sorted = True
    End Sub


    Private Sub TextBox_BuildPropSearch_TextChanged(sender As Object, e As EventArgs) Handles TextBox_BuildPropSearch.TextChanged
        If TextBox_BuildPropSearch.Text <> String.Empty Then
            Dim index As Integer = ListBox_BuildProp.FindString(TextBox_BuildPropSearch.Text)
            If index <> -1 Then
                ListBox_BuildProp.SetSelected(index, True)
            End If
        End If
    End Sub

    Private Sub ListBox_BuildProp_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox_BuildProp.SelectedIndexChanged
        TextBox_BuildPropKey.Text = ListBox_BuildProp.SelectedItem.ToString
        TextBox_BuildPropValue.Text = device.BuildProp.GetProp(TextBox_BuildPropKey.Text)
    End Sub

    Private Sub Button_BuildPropSet_Click(sender As Object, e As EventArgs) Handles Button_BuildPropSet.Click
        device.BuildProp.SetProp(TextBox_BuildPropKey.Text, TextBox_BuildPropValue.Text)
    End Sub

    Private Sub Button_Command_Click(sender As Object, e As EventArgs) Handles Button_Command.Click
        TextBox_Command_Output.Text = Adb.ExecuteAdbCommand(Adb.FormAdbCommand(TextBox_Command.Text))
    End Sub
    'Backup'
    Private Sub Button_Backup_Target_Click(sender As Object, e As EventArgs) Handles Button_Backup_Target.Click
        FolderBrowserPull.ShowDialog()
        TextBox_Backup_Target.Text = FolderBrowserPull.SelectedPath
    End Sub

    Private Sub Button_Backup_RestorePath_Click(sender As Object, e As EventArgs) Handles Button_Backup_RestorePath.Click
        OpenFile_Backup.ShowDialog()
        TextBox_Backup_RestorePath.Text = OpenFile_Backup.FileName
    End Sub

    Private Sub Button_Backup_Backup_Click(sender As Object, e As EventArgs) Handles Button_Backup_Backup.Click
        Backup()
    End Sub

    Sub Backup()
        Dim Args As String = ""
        If CheckBox_Backup_APK.Checked Then
            Args = Args + " -apk"
        End If

        If CheckBox_Backup_OBB.Checked Then
            Args = Args + " -obb"
        End If

        If CheckBox_Backup_Shared.Checked Then
            Args = Args + " -shared"
        End If

        If CheckBox_Backup_System.Checked Then
            Args = Args + " -system"
        End If

        If CheckBox_Backup_All.Checked Then
            Args = " -all"
        End If
        Adb.ExecuteAdbCommand(Adb.FormAdbCommand("backup -f " + TextBox_Backup_Target.Text + "Backup.ab " + Args))
    End Sub

    Private Sub CheckBox_Backup_All_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_Backup_All.CheckedChanged
        If CheckBox_Backup_All.Checked Then
            CheckBox_Backup_APK.Checked = True
            CheckBox_Backup_OBB.Checked = True
            CheckBox_Backup_Shared.Checked = True
            CheckBox_Backup_System.Checked = True
        Else
            CheckBox_Backup_APK.Checked = False
            CheckBox_Backup_OBB.Checked = False
            CheckBox_Backup_Shared.Checked = False
            CheckBox_Backup_System.Checked = False
        End If
    End Sub

    Sub ChangeColor()
        Dim color As String
        If RadioButton_blue.Checked Then
            color = "blue"
        End If
        If RadioButton_green.Checked Then
            color = "green"
        End If
        If RadioButton_grey.Checked Then
            color = "grey"
        End If
        If RadioButton_purple.Checked Then
            color = "purple"
        End If
        If RadioButton_red.Checked Then
            color = "red"
        End If
        If color <> prev Then
            Select Case color
                Case "blue"
                    My.Settings.color = "blue"
                    TabPage_Apps.BackgroundImage = My.Resources.Background_blue
                    TabPage_Backup.BackgroundImage = My.Resources.Background_blue
                    TabPage_BuildProp.BackgroundImage = My.Resources.Background_blue
                    TabPage_Console.BackgroundImage = My.Resources.Background_blue
                    TabPage_Device.BackgroundImage = My.Resources.Background_blue
                    TabPage_Filemanager.BackgroundImage = My.Resources.Background_blue
                    TabPage_Help.BackgroundImage = My.Resources.Background_blue
                    TabPage_Phone.BackgroundImage = My.Resources.Background_blue
                    TabPage_Restart.BackgroundImage = My.Resources.Background_blue
                    TabPage_Screen.BackgroundImage = My.Resources.Background_blue
                    TabPage_Sideload.BackgroundImage = My.Resources.Background_blue
                    TabPageSettings.BackgroundImage = My.Resources.Background_blue
                    Me.BackgroundImage = My.Resources.Background_blue
                    StatusStrip1.BackgroundImage = My.Resources.Background_blue
                Case "green"
                    My.Settings.color = "green"
                    TabPage_Apps.BackgroundImage = My.Resources.Background_green
                    TabPage_Backup.BackgroundImage = My.Resources.Background_green
                    TabPage_BuildProp.BackgroundImage = My.Resources.Background_green
                    TabPage_Console.BackgroundImage = My.Resources.Background_green
                    TabPage_Device.BackgroundImage = My.Resources.Background_green
                    TabPage_Filemanager.BackgroundImage = My.Resources.Background_green
                    TabPage_Help.BackgroundImage = My.Resources.Background_green
                    TabPage_Phone.BackgroundImage = My.Resources.Background_green
                    TabPage_Restart.BackgroundImage = My.Resources.Background_green
                    TabPage_Screen.BackgroundImage = My.Resources.Background_green
                    TabPage_Sideload.BackgroundImage = My.Resources.Background_green
                    TabPageSettings.BackgroundImage = My.Resources.Background_green
                    Me.BackgroundImage = My.Resources.Background_green
                    StatusStrip1.BackgroundImage = My.Resources.Background_green
                Case "grey"
                    My.Settings.color = "grey"
                    TabPage_Apps.BackgroundImage = My.Resources.Background_grey
                    TabPage_Backup.BackgroundImage = My.Resources.Background_grey
                    TabPage_BuildProp.BackgroundImage = My.Resources.Background_grey
                    TabPage_Console.BackgroundImage = My.Resources.Background_grey
                    TabPage_Device.BackgroundImage = My.Resources.Background_grey
                    TabPage_Filemanager.BackgroundImage = My.Resources.Background_grey
                    TabPage_Help.BackgroundImage = My.Resources.Background_grey
                    TabPage_Phone.BackgroundImage = My.Resources.Background_grey
                    TabPage_Restart.BackgroundImage = My.Resources.Background_grey
                    TabPage_Screen.BackgroundImage = My.Resources.Background_grey
                    TabPage_Sideload.BackgroundImage = My.Resources.Background_grey
                    TabPageSettings.BackgroundImage = My.Resources.Background_grey
                    Me.BackgroundImage = My.Resources.Background_grey
                    StatusStrip1.BackgroundImage = My.Resources.Background_grey
                Case "purple"
                    My.Settings.color = "purple"
                    TabPage_Apps.BackgroundImage = My.Resources.Background_purple
                    TabPage_Backup.BackgroundImage = My.Resources.Background_purple
                    TabPage_BuildProp.BackgroundImage = My.Resources.Background_purple
                    TabPage_Console.BackgroundImage = My.Resources.Background_purple
                    TabPage_Device.BackgroundImage = My.Resources.Background_purple
                    TabPage_Filemanager.BackgroundImage = My.Resources.Background_purple
                    TabPage_Help.BackgroundImage = My.Resources.Background_purple
                    TabPage_Phone.BackgroundImage = My.Resources.Background_purple
                    TabPage_Restart.BackgroundImage = My.Resources.Background_purple
                    TabPage_Screen.BackgroundImage = My.Resources.Background_purple
                    TabPage_Sideload.BackgroundImage = My.Resources.Background_purple
                    TabPageSettings.BackgroundImage = My.Resources.Background_purple
                    Me.BackgroundImage = My.Resources.Background_purple
                    StatusStrip1.BackgroundImage = My.Resources.Background_purple
                Case "red"
                    My.Settings.color = "red"
                    TabPage_Apps.BackgroundImage = My.Resources.Background_red
                    TabPage_Backup.BackgroundImage = My.Resources.Background_red
                    TabPage_BuildProp.BackgroundImage = My.Resources.Background_red
                    TabPage_Console.BackgroundImage = My.Resources.Background_red
                    TabPage_Device.BackgroundImage = My.Resources.Background_red
                    TabPage_Filemanager.BackgroundImage = My.Resources.Background_red
                    TabPage_Help.BackgroundImage = My.Resources.Background_red
                    TabPage_Phone.BackgroundImage = My.Resources.Background_red
                    TabPage_Restart.BackgroundImage = My.Resources.Background_red
                    TabPage_Screen.BackgroundImage = My.Resources.Background_red
                    TabPage_Sideload.BackgroundImage = My.Resources.Background_red
                    TabPageSettings.BackgroundImage = My.Resources.Background_red
                    Me.BackgroundImage = My.Resources.Background_red
                    StatusStrip1.BackgroundImage = My.Resources.Background_red
            End Select
        End If
        prev = My.Settings.color
    End Sub
End Class
