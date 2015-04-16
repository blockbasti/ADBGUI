<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.Label_Status = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Label_DeviceName = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ProgressBar_Battery = New System.Windows.Forms.ToolStripProgressBar()
        Me.Label_Battery = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label_device_ownpath = New System.Windows.Forms.Label()
        Me.TextBox_OwnPath = New System.Windows.Forms.TextBox()
        Me.Label_device_system = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label_device_intern = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label_device_sdcard = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label_device_batterytechnology = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label_device_temperature = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label_device_batterylevel = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label_device_busybox = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label_device_root = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label_device_codename = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label_device_device = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label_device_manufacturer = New System.Windows.Forms.Label()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Button_PullDirectory = New System.Windows.Forms.Button()
        Me.Button_PushFile = New System.Windows.Forms.Button()
        Me.Button_Push = New System.Windows.Forms.Button()
        Me.Button_Pull = New System.Windows.Forms.Button()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.TextBox_PathPC = New System.Windows.Forms.TextBox()
        Me.TextBox_PathPhone = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CheckBox_RecOnPC = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox_ResWidth = New System.Windows.Forms.TextBox()
        Me.TextBox_ResHeight = New System.Windows.Forms.TextBox()
        Me.CheckBox_Resolution = New System.Windows.Forms.CheckBox()
        Me.Label_Bitrate = New System.Windows.Forms.Label()
        Me.TrackBar_Bitrate = New System.Windows.Forms.TrackBar()
        Me.Label_RecTime = New System.Windows.Forms.Label()
        Me.TrackBar_RecTime = New System.Windows.Forms.TrackBar()
        Me.Button_Screenrec = New System.Windows.Forms.Button()
        Me.CheckBox_ScreenCap = New System.Windows.Forms.CheckBox()
        Me.Picture_Screen = New System.Windows.Forms.PictureBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button_Recovery = New System.Windows.Forms.Button()
        Me.Button_Bootloader = New System.Windows.Forms.Button()
        Me.Button_Fastboot = New System.Windows.Forms.Button()
        Me.Button_Reboot = New System.Windows.Forms.Button()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Button_Sideload = New System.Windows.Forms.Button()
        Me.Button_SideloadSearch = New System.Windows.Forms.Button()
        Me.TextBox_SideloadPath = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Button_RecoverySideload = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.TextBox_Apps_Search = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Button_Apk = New System.Windows.Forms.Button()
        Me.Button_Install = New System.Windows.Forms.Button()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.TextBox_Apk = New System.Windows.Forms.TextBox()
        Me.Button_Uninstall = New System.Windows.Forms.Button()
        Me.Button_Apps_Refresh = New System.Windows.Forms.Button()
        Me.ListBox_Apps = New System.Windows.Forms.ListBox()
        Me.TabPage7 = New System.Windows.Forms.TabPage()
        Me.Button_Call = New System.Windows.Forms.Button()
        Me.Button_Dial = New System.Windows.Forms.Button()
        Me.TextBox_Nummer = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.TabPage8 = New System.Windows.Forms.TabPage()
        Me.Button_BuildPropSet = New System.Windows.Forms.Button()
        Me.TextBox_BuildPropValue = New System.Windows.Forms.TextBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.TextBox_BuildPropKey = New System.Windows.Forms.TextBox()
        Me.TextBox_BuildPropSearch = New System.Windows.Forms.TextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Button_BuildPropRefresh = New System.Windows.Forms.Button()
        Me.ListBox_BuildProp = New System.Windows.Forms.ListBox()
        Me.TabPage10 = New System.Windows.Forms.TabPage()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Button_Command = New System.Windows.Forms.Button()
        Me.TextBox_Command = New System.Windows.Forms.TextBox()
        Me.TextBox_Command_Output = New System.Windows.Forms.TextBox()
        Me.TabPage9 = New System.Windows.Forms.TabPage()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.StatusTimer = New System.Windows.Forms.Timer(Me.components)
        Me.StatusWorker = New System.ComponentModel.BackgroundWorker()
        Me.ScreenWorker = New System.ComponentModel.BackgroundWorker()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.ScreenTimer = New System.Windows.Forms.Timer(Me.components)
        Me.OpenFile_Push = New System.Windows.Forms.OpenFileDialog()
        Me.FolderBrowserPull = New System.Windows.Forms.FolderBrowserDialog()
        Me.OpenFile_Apk = New System.Windows.Forms.OpenFileDialog()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TabPage11 = New System.Windows.Forms.TabPage()
        Me.TextBox_Backup_Target = New System.Windows.Forms.TextBox()
        Me.Button_Backup_Target = New System.Windows.Forms.Button()
        Me.CheckBox_Backup_All = New System.Windows.Forms.CheckBox()
        Me.CheckBox_Backup_APK = New System.Windows.Forms.CheckBox()
        Me.CheckBox_Backup_OBB = New System.Windows.Forms.CheckBox()
        Me.CheckBox_Backup_Shared = New System.Windows.Forms.CheckBox()
        Me.CheckBox_Backup_System = New System.Windows.Forms.CheckBox()
        Me.Button_Backup_Backup = New System.Windows.Forms.Button()
        Me.Button_Backup_Restore = New System.Windows.Forms.Button()
        Me.TextBox_Backup_RestorePath = New System.Windows.Forms.TextBox()
        Me.Button_Backup_RestorePath = New System.Windows.Forms.Button()
        Me.OpenFile_Backup = New System.Windows.Forms.OpenFileDialog()
        Me.StatusStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage6.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.TrackBar_Bitrate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBar_RecTime, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Picture_Screen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.TabPage7.SuspendLayout()
        Me.TabPage8.SuspendLayout()
        Me.TabPage10.SuspendLayout()
        Me.TabPage9.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage11.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackgroundImage = Global.ADBGUI.My.Resources.Resources.Hintergrund2
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Label_Status, Me.Label_DeviceName, Me.ProgressBar_Battery, Me.Label_Battery})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 379)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.StatusStrip1.Size = New System.Drawing.Size(728, 22)
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'Label_Status
        '
        Me.Label_Status.Name = "Label_Status"
        Me.Label_Status.Size = New System.Drawing.Size(72, 17)
        Me.Label_Status.Text = "Label_Status"
        '
        'Label_DeviceName
        '
        Me.Label_DeviceName.Name = "Label_DeviceName"
        Me.Label_DeviceName.Size = New System.Drawing.Size(107, 17)
        Me.Label_DeviceName.Text = "Label_DeviceName"
        '
        'ProgressBar_Battery
        '
        Me.ProgressBar_Battery.Name = "ProgressBar_Battery"
        Me.ProgressBar_Battery.Size = New System.Drawing.Size(100, 16)
        Me.ProgressBar_Battery.Step = 1
        '
        'Label_Battery
        '
        Me.Label_Battery.Name = "Label_Battery"
        Me.Label_Battery.Size = New System.Drawing.Size(77, 17)
        Me.Label_Battery.Text = "Label_Battery"
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage6)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Controls.Add(Me.TabPage7)
        Me.TabControl1.Controls.Add(Me.TabPage8)
        Me.TabControl1.Controls.Add(Me.TabPage10)
        Me.TabControl1.Controls.Add(Me.TabPage11)
        Me.TabControl1.Controls.Add(Me.TabPage9)
        Me.TabControl1.Location = New System.Drawing.Point(0, -1)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(728, 373)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage6
        '
        Me.TabPage6.BackgroundImage = Global.ADBGUI.My.Resources.Resources.Hintergrund2
        Me.TabPage6.Controls.Add(Me.GroupBox4)
        Me.TabPage6.Controls.Add(Me.GroupBox3)
        Me.TabPage6.Controls.Add(Me.GroupBox2)
        Me.TabPage6.Location = New System.Drawing.Point(4, 22)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage6.Size = New System.Drawing.Size(672, 350)
        Me.TabPage6.TabIndex = 5
        Me.TabPage6.Text = "Gerät"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label_device_ownpath)
        Me.GroupBox4.Controls.Add(Me.TextBox_OwnPath)
        Me.GroupBox4.Controls.Add(Me.Label_device_system)
        Me.GroupBox4.Controls.Add(Me.Label25)
        Me.GroupBox4.Controls.Add(Me.Label_device_intern)
        Me.GroupBox4.Controls.Add(Me.Label24)
        Me.GroupBox4.Controls.Add(Me.Label_device_sdcard)
        Me.GroupBox4.Controls.Add(Me.Label23)
        Me.GroupBox4.Location = New System.Drawing.Point(3, 161)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(297, 83)
        Me.GroupBox4.TabIndex = 6
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Speicherplatz"
        '
        'Label_device_ownpath
        '
        Me.Label_device_ownpath.AutoSize = True
        Me.Label_device_ownpath.Location = New System.Drawing.Point(81, 62)
        Me.Label_device_ownpath.Name = "Label_device_ownpath"
        Me.Label_device_ownpath.Size = New System.Drawing.Size(48, 13)
        Me.Label_device_ownpath.TabIndex = 7
        Me.Label_device_ownpath.Text = "ownpath"
        '
        'TextBox_OwnPath
        '
        Me.TextBox_OwnPath.Location = New System.Drawing.Point(9, 59)
        Me.TextBox_OwnPath.Name = "TextBox_OwnPath"
        Me.TextBox_OwnPath.Size = New System.Drawing.Size(66, 20)
        Me.TextBox_OwnPath.TabIndex = 6
        Me.TextBox_OwnPath.Text = "Eigener Pfad"
        '
        'Label_device_system
        '
        Me.Label_device_system.AutoSize = True
        Me.Label_device_system.Location = New System.Drawing.Point(65, 42)
        Me.Label_device_system.Name = "Label_device_system"
        Me.Label_device_system.Size = New System.Drawing.Size(39, 13)
        Me.Label_device_system.TabIndex = 5
        Me.Label_device_system.Text = "system"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(6, 42)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(44, 13)
        Me.Label25.TabIndex = 4
        Me.Label25.Text = "System:"
        '
        'Label_device_intern
        '
        Me.Label_device_intern.AutoSize = True
        Me.Label_device_intern.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label_device_intern.Location = New System.Drawing.Point(65, 29)
        Me.Label_device_intern.Name = "Label_device_intern"
        Me.Label_device_intern.Size = New System.Drawing.Size(33, 13)
        Me.Label_device_intern.TabIndex = 3
        Me.Label_device_intern.Text = "intern"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(6, 29)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(37, 13)
        Me.Label24.TabIndex = 2
        Me.Label24.Text = "Intern:"
        '
        'Label_device_sdcard
        '
        Me.Label_device_sdcard.AutoSize = True
        Me.Label_device_sdcard.Location = New System.Drawing.Point(65, 16)
        Me.Label_device_sdcard.Name = "Label_device_sdcard"
        Me.Label_device_sdcard.Size = New System.Drawing.Size(39, 13)
        Me.Label_device_sdcard.TabIndex = 1
        Me.Label_device_sdcard.Text = "sdcard"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(6, 16)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(53, 13)
        Me.Label23.TabIndex = 0
        Me.Label23.Text = "SD-Karte:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label_device_batterytechnology)
        Me.GroupBox3.Controls.Add(Me.Label20)
        Me.GroupBox3.Controls.Add(Me.Label_device_temperature)
        Me.GroupBox3.Controls.Add(Me.Label19)
        Me.GroupBox3.Controls.Add(Me.Label_device_batterylevel)
        Me.GroupBox3.Controls.Add(Me.Label18)
        Me.GroupBox3.Location = New System.Drawing.Point(3, 96)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(200, 59)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Batterie"
        '
        'Label_device_batterytechnology
        '
        Me.Label_device_batterytechnology.AutoSize = True
        Me.Label_device_batterytechnology.Location = New System.Drawing.Point(81, 42)
        Me.Label_device_batterytechnology.Name = "Label_device_batterytechnology"
        Me.Label_device_batterytechnology.Size = New System.Drawing.Size(59, 13)
        Me.Label_device_batterytechnology.TabIndex = 5
        Me.Label_device_batterytechnology.Text = "technology"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(6, 42)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(69, 13)
        Me.Label20.TabIndex = 4
        Me.Label20.Text = "Technologie:"
        '
        'Label_device_temperature
        '
        Me.Label_device_temperature.AutoSize = True
        Me.Label_device_temperature.Location = New System.Drawing.Point(81, 29)
        Me.Label_device_temperature.Name = "Label_device_temperature"
        Me.Label_device_temperature.Size = New System.Drawing.Size(63, 13)
        Me.Label_device_temperature.TabIndex = 3
        Me.Label_device_temperature.Text = "temperature"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(6, 29)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(64, 13)
        Me.Label19.TabIndex = 2
        Me.Label19.Text = "Temperatur:"
        '
        'Label_device_batterylevel
        '
        Me.Label_device_batterylevel.AutoSize = True
        Me.Label_device_batterylevel.Location = New System.Drawing.Point(81, 16)
        Me.Label_device_batterylevel.Name = "Label_device_batterylevel"
        Me.Label_device_batterylevel.Size = New System.Drawing.Size(61, 13)
        Me.Label_device_batterylevel.TabIndex = 1
        Me.Label_device_batterylevel.Text = "batterylevel"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(6, 16)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(61, 13)
        Me.Label18.TabIndex = 0
        Me.Label18.Text = "Akkustand:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label_device_busybox)
        Me.GroupBox2.Controls.Add(Me.Label21)
        Me.GroupBox2.Controls.Add(Me.Label_device_root)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.Label_device_codename)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Label_device_device)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.Label_device_manufacturer)
        Me.GroupBox2.Location = New System.Drawing.Point(3, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(142, 84)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Gerät"
        '
        'Label_device_busybox
        '
        Me.Label_device_busybox.AutoSize = True
        Me.Label_device_busybox.Location = New System.Drawing.Point(73, 68)
        Me.Label_device_busybox.Name = "Label_device_busybox"
        Me.Label_device_busybox.Size = New System.Drawing.Size(46, 13)
        Me.Label_device_busybox.TabIndex = 9
        Me.Label_device_busybox.Text = "busybox"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(6, 68)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(51, 13)
        Me.Label21.TabIndex = 8
        Me.Label21.Text = "BusyBox:"
        '
        'Label_device_root
        '
        Me.Label_device_root.AutoSize = True
        Me.Label_device_root.Location = New System.Drawing.Point(73, 55)
        Me.Label_device_root.Name = "Label_device_root"
        Me.Label_device_root.Size = New System.Drawing.Size(25, 13)
        Me.Label_device_root.TabIndex = 7
        Me.Label_device_root.Text = "root"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(6, 55)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(33, 13)
        Me.Label17.TabIndex = 6
        Me.Label17.Text = "Root:"
        '
        'Label_device_codename
        '
        Me.Label_device_codename.AutoSize = True
        Me.Label_device_codename.Location = New System.Drawing.Point(73, 42)
        Me.Label_device_codename.Name = "Label_device_codename"
        Me.Label_device_codename.Size = New System.Drawing.Size(57, 13)
        Me.Label_device_codename.TabIndex = 5
        Me.Label_device_codename.Text = "codename"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(6, 42)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(61, 13)
        Me.Label15.TabIndex = 4
        Me.Label15.Text = "Codename:"
        '
        'Label_device_device
        '
        Me.Label_device_device.AutoSize = True
        Me.Label_device_device.Location = New System.Drawing.Point(73, 29)
        Me.Label_device_device.Name = "Label_device_device"
        Me.Label_device_device.Size = New System.Drawing.Size(39, 13)
        Me.Label_device_device.TabIndex = 3
        Me.Label_device_device.Text = "device"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(6, 16)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(54, 13)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "Hersteller:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(6, 29)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(36, 13)
        Me.Label16.TabIndex = 2
        Me.Label16.Text = "Gerät:"
        '
        'Label_device_manufacturer
        '
        Me.Label_device_manufacturer.AutoSize = True
        Me.Label_device_manufacturer.Location = New System.Drawing.Point(73, 16)
        Me.Label_device_manufacturer.Name = "Label_device_manufacturer"
        Me.Label_device_manufacturer.Size = New System.Drawing.Size(69, 13)
        Me.Label_device_manufacturer.TabIndex = 1
        Me.Label_device_manufacturer.Text = "manufacturer"
        '
        'TabPage1
        '
        Me.TabPage1.BackgroundImage = CType(resources.GetObject("TabPage1.BackgroundImage"), System.Drawing.Image)
        Me.TabPage1.Controls.Add(Me.Button_PullDirectory)
        Me.TabPage1.Controls.Add(Me.Button_PushFile)
        Me.TabPage1.Controls.Add(Me.Button_Push)
        Me.TabPage1.Controls.Add(Me.Button_Pull)
        Me.TabPage1.Controls.Add(Me.Label27)
        Me.TabPage1.Controls.Add(Me.Label26)
        Me.TabPage1.Controls.Add(Me.TextBox_PathPC)
        Me.TabPage1.Controls.Add(Me.TextBox_PathPhone)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(720, 347)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Dateimanager"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Button_PullDirectory
        '
        Me.Button_PullDirectory.Location = New System.Drawing.Point(165, 87)
        Me.Button_PullDirectory.Name = "Button_PullDirectory"
        Me.Button_PullDirectory.Size = New System.Drawing.Size(143, 23)
        Me.Button_PullDirectory.TabIndex = 7
        Me.Button_PullDirectory.Text = "Zielordner..."
        Me.Button_PullDirectory.UseVisualStyleBackColor = True
        '
        'Button_PushFile
        '
        Me.Button_PushFile.Location = New System.Drawing.Point(14, 87)
        Me.Button_PushFile.Name = "Button_PushFile"
        Me.Button_PushFile.Size = New System.Drawing.Size(145, 23)
        Me.Button_PushFile.TabIndex = 6
        Me.Button_PushFile.Text = "Datei..."
        Me.Button_PushFile.UseVisualStyleBackColor = True
        '
        'Button_Push
        '
        Me.Button_Push.Location = New System.Drawing.Point(165, 32)
        Me.Button_Push.Name = "Button_Push"
        Me.Button_Push.Size = New System.Drawing.Size(143, 23)
        Me.Button_Push.TabIndex = 5
        Me.Button_Push.Text = "PC --> Handy"
        Me.Button_Push.UseVisualStyleBackColor = True
        '
        'Button_Pull
        '
        Me.Button_Pull.Location = New System.Drawing.Point(14, 32)
        Me.Button_Pull.Name = "Button_Pull"
        Me.Button_Pull.Size = New System.Drawing.Size(145, 23)
        Me.Button_Pull.TabIndex = 4
        Me.Button_Pull.Text = "Handy --> PC"
        Me.Button_Pull.UseVisualStyleBackColor = True
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(6, 64)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(90, 13)
        Me.Label27.TabIndex = 3
        Me.Label27.Text = "Pfad auf dem PC:"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(6, 9)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(107, 13)
        Me.Label26.TabIndex = 2
        Me.Label26.Text = "Pfad auf dem Handy:"
        '
        'TextBox_PathPC
        '
        Me.TextBox_PathPC.Location = New System.Drawing.Point(119, 61)
        Me.TextBox_PathPC.Name = "TextBox_PathPC"
        Me.TextBox_PathPC.Size = New System.Drawing.Size(201, 20)
        Me.TextBox_PathPC.TabIndex = 1
        '
        'TextBox_PathPhone
        '
        Me.TextBox_PathPhone.Location = New System.Drawing.Point(119, 6)
        Me.TextBox_PathPhone.Name = "TextBox_PathPhone"
        Me.TextBox_PathPhone.Size = New System.Drawing.Size(201, 20)
        Me.TextBox_PathPhone.TabIndex = 0
        Me.TextBox_PathPhone.Text = "/storage/sdcard0/"
        '
        'TabPage2
        '
        Me.TabPage2.BackgroundImage = Global.ADBGUI.My.Resources.Resources.Hintergrund2
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.Controls.Add(Me.CheckBox_ScreenCap)
        Me.TabPage2.Controls.Add(Me.Picture_Screen)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(672, 350)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Bildschirmübertragung"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.CheckBox_RecOnPC)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TextBox_ResWidth)
        Me.GroupBox1.Controls.Add(Me.TextBox_ResHeight)
        Me.GroupBox1.Controls.Add(Me.CheckBox_Resolution)
        Me.GroupBox1.Controls.Add(Me.Label_Bitrate)
        Me.GroupBox1.Controls.Add(Me.TrackBar_Bitrate)
        Me.GroupBox1.Controls.Add(Me.Label_RecTime)
        Me.GroupBox1.Controls.Add(Me.TrackBar_RecTime)
        Me.GroupBox1.Controls.Add(Me.Button_Screenrec)
        Me.GroupBox1.Location = New System.Drawing.Point(335, 30)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(329, 313)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Bildschirmaufnahme"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 143)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(250, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Es wird sonst die normale Displayauflösung benutzt."
        '
        'CheckBox_RecOnPC
        '
        Me.CheckBox_RecOnPC.AutoSize = True
        Me.CheckBox_RecOnPC.Checked = True
        Me.CheckBox_RecOnPC.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox_RecOnPC.Location = New System.Drawing.Point(6, 159)
        Me.CheckBox_RecOnPC.Name = "CheckBox_RecOnPC"
        Me.CheckBox_RecOnPC.Size = New System.Drawing.Size(330, 17)
        Me.CheckBox_RecOnPC.TabIndex = 14
        Me.CheckBox_RecOnPC.Text = "In ""Videos"" auf dem PC speichern(sonst auf internem Speicher)?"
        Me.CheckBox_RecOnPC.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 69)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Bitrate"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(25, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Zeit"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(171, 124)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Breite:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(85, 124)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Höhe:"
        '
        'TextBox_ResWidth
        '
        Me.TextBox_ResWidth.Location = New System.Drawing.Point(214, 121)
        Me.TextBox_ResWidth.Name = "TextBox_ResWidth"
        Me.TextBox_ResWidth.ReadOnly = True
        Me.TextBox_ResWidth.Size = New System.Drawing.Size(38, 20)
        Me.TextBox_ResWidth.TabIndex = 9
        '
        'TextBox_ResHeight
        '
        Me.TextBox_ResHeight.Location = New System.Drawing.Point(127, 121)
        Me.TextBox_ResHeight.Name = "TextBox_ResHeight"
        Me.TextBox_ResHeight.ReadOnly = True
        Me.TextBox_ResHeight.Size = New System.Drawing.Size(38, 20)
        Me.TextBox_ResHeight.TabIndex = 8
        '
        'CheckBox_Resolution
        '
        Me.CheckBox_Resolution.AutoSize = True
        Me.CheckBox_Resolution.Location = New System.Drawing.Point(6, 123)
        Me.CheckBox_Resolution.Name = "CheckBox_Resolution"
        Me.CheckBox_Resolution.Size = New System.Drawing.Size(73, 17)
        Me.CheckBox_Resolution.TabIndex = 7
        Me.CheckBox_Resolution.Text = "Auflösung"
        Me.CheckBox_Resolution.UseVisualStyleBackColor = True
        '
        'Label_Bitrate
        '
        Me.Label_Bitrate.AutoSize = True
        Me.Label_Bitrate.Location = New System.Drawing.Point(46, 100)
        Me.Label_Bitrate.Name = "Label_Bitrate"
        Me.Label_Bitrate.Size = New System.Drawing.Size(38, 13)
        Me.Label_Bitrate.TabIndex = 6
        Me.Label_Bitrate.Text = "4Mb/s"
        '
        'TrackBar_Bitrate
        '
        Me.TrackBar_Bitrate.Location = New System.Drawing.Point(49, 68)
        Me.TrackBar_Bitrate.Minimum = 1
        Me.TrackBar_Bitrate.Name = "TrackBar_Bitrate"
        Me.TrackBar_Bitrate.Size = New System.Drawing.Size(274, 45)
        Me.TrackBar_Bitrate.TabIndex = 5
        Me.TrackBar_Bitrate.Value = 4
        '
        'Label_RecTime
        '
        Me.Label_RecTime.AutoSize = True
        Me.Label_RecTime.Location = New System.Drawing.Point(46, 52)
        Me.Label_RecTime.Name = "Label_RecTime"
        Me.Label_RecTime.Size = New System.Drawing.Size(30, 13)
        Me.Label_RecTime.TabIndex = 3
        Me.Label_RecTime.Text = "180s"
        '
        'TrackBar_RecTime
        '
        Me.TrackBar_RecTime.Location = New System.Drawing.Point(49, 20)
        Me.TrackBar_RecTime.Maximum = 180
        Me.TrackBar_RecTime.Minimum = 1
        Me.TrackBar_RecTime.Name = "TrackBar_RecTime"
        Me.TrackBar_RecTime.Size = New System.Drawing.Size(274, 45)
        Me.TrackBar_RecTime.TabIndex = 2
        Me.TrackBar_RecTime.TickFrequency = 10
        Me.TrackBar_RecTime.Value = 180
        '
        'Button_Screenrec
        '
        Me.Button_Screenrec.Location = New System.Drawing.Point(9, 241)
        Me.Button_Screenrec.Name = "Button_Screenrec"
        Me.Button_Screenrec.Size = New System.Drawing.Size(317, 23)
        Me.Button_Screenrec.TabIndex = 0
        Me.Button_Screenrec.Text = "Aufnahme starten"
        Me.Button_Screenrec.UseVisualStyleBackColor = True
        '
        'CheckBox_ScreenCap
        '
        Me.CheckBox_ScreenCap.AutoSize = True
        Me.CheckBox_ScreenCap.Location = New System.Drawing.Point(335, 7)
        Me.CheckBox_ScreenCap.Name = "CheckBox_ScreenCap"
        Me.CheckBox_ScreenCap.Size = New System.Drawing.Size(127, 17)
        Me.CheckBox_ScreenCap.TabIndex = 1
        Me.CheckBox_ScreenCap.TabStop = False
        Me.CheckBox_ScreenCap.Text = "Bildschirm übertragen"
        Me.CheckBox_ScreenCap.UseVisualStyleBackColor = True
        '
        'Picture_Screen
        '
        Me.Picture_Screen.Location = New System.Drawing.Point(6, 6)
        Me.Picture_Screen.Name = "Picture_Screen"
        Me.Picture_Screen.Size = New System.Drawing.Size(319, 337)
        Me.Picture_Screen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Picture_Screen.TabIndex = 0
        Me.Picture_Screen.TabStop = False
        Me.Picture_Screen.WaitOnLoad = True
        '
        'TabPage3
        '
        Me.TabPage3.BackgroundImage = Global.ADBGUI.My.Resources.Resources.Hintergrund2
        Me.TabPage3.Controls.Add(Me.Label9)
        Me.TabPage3.Controls.Add(Me.Label8)
        Me.TabPage3.Controls.Add(Me.Label7)
        Me.TabPage3.Controls.Add(Me.Label6)
        Me.TabPage3.Controls.Add(Me.Button_Recovery)
        Me.TabPage3.Controls.Add(Me.Button_Bootloader)
        Me.TabPage3.Controls.Add(Me.Button_Fastboot)
        Me.TabPage3.Controls.Add(Me.Button_Reboot)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(672, 350)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Neustart"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(9, 158)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(188, 13)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Startet das Gerät in die Recovery neu."
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(9, 116)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(262, 13)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Startet das Gerät im Bootloader/Downloadmodus neu."
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(9, 74)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(396, 13)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Startet das Gerät im Fastboot-Modus neu.(Wird nicht von allen Geräten unterstüzt!" & _
    ")"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 32)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(145, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Startet das Gerät normal neu."
        '
        'Button_Recovery
        '
        Me.Button_Recovery.Location = New System.Drawing.Point(6, 132)
        Me.Button_Recovery.Name = "Button_Recovery"
        Me.Button_Recovery.Size = New System.Drawing.Size(75, 23)
        Me.Button_Recovery.TabIndex = 3
        Me.Button_Recovery.Text = "Recovery"
        Me.Button_Recovery.UseVisualStyleBackColor = True
        '
        'Button_Bootloader
        '
        Me.Button_Bootloader.Location = New System.Drawing.Point(6, 90)
        Me.Button_Bootloader.Name = "Button_Bootloader"
        Me.Button_Bootloader.Size = New System.Drawing.Size(75, 23)
        Me.Button_Bootloader.TabIndex = 2
        Me.Button_Bootloader.Text = "Bootloader"
        Me.Button_Bootloader.UseVisualStyleBackColor = True
        '
        'Button_Fastboot
        '
        Me.Button_Fastboot.Location = New System.Drawing.Point(6, 48)
        Me.Button_Fastboot.Name = "Button_Fastboot"
        Me.Button_Fastboot.Size = New System.Drawing.Size(75, 23)
        Me.Button_Fastboot.TabIndex = 1
        Me.Button_Fastboot.Text = "Fastboot"
        Me.Button_Fastboot.UseVisualStyleBackColor = True
        '
        'Button_Reboot
        '
        Me.Button_Reboot.Location = New System.Drawing.Point(6, 6)
        Me.Button_Reboot.Name = "Button_Reboot"
        Me.Button_Reboot.Size = New System.Drawing.Size(75, 23)
        Me.Button_Reboot.TabIndex = 0
        Me.Button_Reboot.Text = "Neustart"
        Me.Button_Reboot.UseVisualStyleBackColor = True
        '
        'TabPage4
        '
        Me.TabPage4.BackgroundImage = Global.ADBGUI.My.Resources.Resources.Hintergrund2
        Me.TabPage4.Controls.Add(Me.Label13)
        Me.TabPage4.Controls.Add(Me.Button_Sideload)
        Me.TabPage4.Controls.Add(Me.Button_SideloadSearch)
        Me.TabPage4.Controls.Add(Me.TextBox_SideloadPath)
        Me.TabPage4.Controls.Add(Me.Label12)
        Me.TabPage4.Controls.Add(Me.Label11)
        Me.TabPage4.Controls.Add(Me.Button_RecoverySideload)
        Me.TabPage4.Controls.Add(Me.Label10)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(672, 350)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Sideload"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(7, 107)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(148, 13)
        Me.Label13.TabIndex = 7
        Me.Label13.Text = "4. Ausgewählte Datei flashen."
        '
        'Button_Sideload
        '
        Me.Button_Sideload.Location = New System.Drawing.Point(6, 123)
        Me.Button_Sideload.Name = "Button_Sideload"
        Me.Button_Sideload.Size = New System.Drawing.Size(75, 23)
        Me.Button_Sideload.TabIndex = 6
        Me.Button_Sideload.Text = "Flash!"
        Me.Button_Sideload.UseVisualStyleBackColor = True
        '
        'Button_SideloadSearch
        '
        Me.Button_SideloadSearch.Location = New System.Drawing.Point(297, 78)
        Me.Button_SideloadSearch.Name = "Button_SideloadSearch"
        Me.Button_SideloadSearch.Size = New System.Drawing.Size(75, 23)
        Me.Button_SideloadSearch.TabIndex = 5
        Me.Button_SideloadSearch.Text = "Suchen..."
        Me.Button_SideloadSearch.UseVisualStyleBackColor = True
        '
        'TextBox_SideloadPath
        '
        Me.TextBox_SideloadPath.Location = New System.Drawing.Point(7, 80)
        Me.TextBox_SideloadPath.Name = "TextBox_SideloadPath"
        Me.TextBox_SideloadPath.Size = New System.Drawing.Size(284, 20)
        Me.TextBox_SideloadPath.TabIndex = 4
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(7, 63)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(232, 13)
        Me.Label12.TabIndex = 3
        Me.Label12.Text = "3. Zip-Datei die geflasht werden soll auswählen."
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(7, 50)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(242, 13)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "2. In der Recovery in den Sideload-Modus gehen."
        '
        'Button_RecoverySideload
        '
        Me.Button_RecoverySideload.Location = New System.Drawing.Point(7, 24)
        Me.Button_RecoverySideload.Name = "Button_RecoverySideload"
        Me.Button_RecoverySideload.Size = New System.Drawing.Size(75, 23)
        Me.Button_RecoverySideload.TabIndex = 1
        Me.Button_RecoverySideload.Text = "Recovery"
        Me.Button_RecoverySideload.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(7, 7)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(178, 13)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "1. Gerät in die Recovery neustarten."
        '
        'TabPage5
        '
        Me.TabPage5.BackgroundImage = Global.ADBGUI.My.Resources.Resources.Hintergrund2
        Me.TabPage5.Controls.Add(Me.TextBox_Apps_Search)
        Me.TabPage5.Controls.Add(Me.Label29)
        Me.TabPage5.Controls.Add(Me.Button_Apk)
        Me.TabPage5.Controls.Add(Me.Button_Install)
        Me.TabPage5.Controls.Add(Me.Label28)
        Me.TabPage5.Controls.Add(Me.TextBox_Apk)
        Me.TabPage5.Controls.Add(Me.Button_Uninstall)
        Me.TabPage5.Controls.Add(Me.Button_Apps_Refresh)
        Me.TabPage5.Controls.Add(Me.ListBox_Apps)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(672, 350)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Apps"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'TextBox_Apps_Search
        '
        Me.TextBox_Apps_Search.Location = New System.Drawing.Point(336, 6)
        Me.TextBox_Apps_Search.Name = "TextBox_Apps_Search"
        Me.TextBox_Apps_Search.Size = New System.Drawing.Size(209, 20)
        Me.TextBox_Apps_Search.TabIndex = 8
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(283, 9)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(47, 13)
        Me.Label29.TabIndex = 7
        Me.Label29.Text = "Suchen:"
        '
        'Button_Apk
        '
        Me.Button_Apk.Location = New System.Drawing.Point(470, 283)
        Me.Button_Apk.Name = "Button_Apk"
        Me.Button_Apk.Size = New System.Drawing.Size(75, 23)
        Me.Button_Apk.TabIndex = 6
        Me.Button_Apk.Text = "APK-Datei..."
        Me.Button_Apk.UseVisualStyleBackColor = True
        '
        'Button_Install
        '
        Me.Button_Install.Location = New System.Drawing.Point(470, 312)
        Me.Button_Install.Name = "Button_Install"
        Me.Button_Install.Size = New System.Drawing.Size(75, 23)
        Me.Button_Install.TabIndex = 5
        Me.Button_Install.Text = "Installieren"
        Me.Button_Install.UseVisualStyleBackColor = True
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(283, 260)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(59, 13)
        Me.Label28.TabIndex = 4
        Me.Label28.Text = "APK-Datei:"
        '
        'TextBox_Apk
        '
        Me.TextBox_Apk.Location = New System.Drawing.Point(348, 257)
        Me.TextBox_Apk.Name = "TextBox_Apk"
        Me.TextBox_Apk.Size = New System.Drawing.Size(197, 20)
        Me.TextBox_Apk.TabIndex = 3
        '
        'Button_Uninstall
        '
        Me.Button_Uninstall.Location = New System.Drawing.Point(364, 312)
        Me.Button_Uninstall.Name = "Button_Uninstall"
        Me.Button_Uninstall.Size = New System.Drawing.Size(100, 23)
        Me.Button_Uninstall.TabIndex = 2
        Me.Button_Uninstall.Text = "Deinstallieren"
        Me.Button_Uninstall.UseVisualStyleBackColor = True
        '
        'Button_Apps_Refresh
        '
        Me.Button_Apps_Refresh.Location = New System.Drawing.Point(283, 312)
        Me.Button_Apps_Refresh.Name = "Button_Apps_Refresh"
        Me.Button_Apps_Refresh.Size = New System.Drawing.Size(75, 23)
        Me.Button_Apps_Refresh.TabIndex = 1
        Me.Button_Apps_Refresh.Text = "Aktualisieren"
        Me.Button_Apps_Refresh.UseVisualStyleBackColor = True
        '
        'ListBox_Apps
        '
        Me.ListBox_Apps.FormattingEnabled = True
        Me.ListBox_Apps.Location = New System.Drawing.Point(6, 6)
        Me.ListBox_Apps.Name = "ListBox_Apps"
        Me.ListBox_Apps.Size = New System.Drawing.Size(271, 329)
        Me.ListBox_Apps.TabIndex = 0
        '
        'TabPage7
        '
        Me.TabPage7.BackgroundImage = Global.ADBGUI.My.Resources.Resources.Hintergrund2
        Me.TabPage7.Controls.Add(Me.Button_Call)
        Me.TabPage7.Controls.Add(Me.Button_Dial)
        Me.TabPage7.Controls.Add(Me.TextBox_Nummer)
        Me.TabPage7.Controls.Add(Me.Label22)
        Me.TabPage7.Location = New System.Drawing.Point(4, 22)
        Me.TabPage7.Name = "TabPage7"
        Me.TabPage7.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage7.Size = New System.Drawing.Size(672, 350)
        Me.TabPage7.TabIndex = 6
        Me.TabPage7.Text = "Telefon"
        Me.TabPage7.UseVisualStyleBackColor = True
        '
        'Button_Call
        '
        Me.Button_Call.Location = New System.Drawing.Point(6, 61)
        Me.Button_Call.Name = "Button_Call"
        Me.Button_Call.Size = New System.Drawing.Size(232, 23)
        Me.Button_Call.TabIndex = 3
        Me.Button_Call.Text = "Wählen und Anrufen"
        Me.Button_Call.UseVisualStyleBackColor = True
        '
        'Button_Dial
        '
        Me.Button_Dial.Location = New System.Drawing.Point(6, 32)
        Me.Button_Dial.Name = "Button_Dial"
        Me.Button_Dial.Size = New System.Drawing.Size(232, 23)
        Me.Button_Dial.TabIndex = 2
        Me.Button_Dial.Text = "Wählen"
        Me.Button_Dial.UseVisualStyleBackColor = True
        '
        'TextBox_Nummer
        '
        Me.TextBox_Nummer.Location = New System.Drawing.Point(92, 6)
        Me.TextBox_Nummer.Name = "TextBox_Nummer"
        Me.TextBox_Nummer.Size = New System.Drawing.Size(146, 20)
        Me.TextBox_Nummer.TabIndex = 1
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(3, 9)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(83, 13)
        Me.Label22.TabIndex = 0
        Me.Label22.Text = "Telefonnummer:"
        '
        'TabPage8
        '
        Me.TabPage8.BackgroundImage = Global.ADBGUI.My.Resources.Resources.Hintergrund2
        Me.TabPage8.Controls.Add(Me.Button_BuildPropSet)
        Me.TabPage8.Controls.Add(Me.TextBox_BuildPropValue)
        Me.TabPage8.Controls.Add(Me.Label32)
        Me.TabPage8.Controls.Add(Me.Label31)
        Me.TabPage8.Controls.Add(Me.TextBox_BuildPropKey)
        Me.TabPage8.Controls.Add(Me.TextBox_BuildPropSearch)
        Me.TabPage8.Controls.Add(Me.Label30)
        Me.TabPage8.Controls.Add(Me.Button_BuildPropRefresh)
        Me.TabPage8.Controls.Add(Me.ListBox_BuildProp)
        Me.TabPage8.Location = New System.Drawing.Point(4, 22)
        Me.TabPage8.Name = "TabPage8"
        Me.TabPage8.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage8.Size = New System.Drawing.Size(720, 347)
        Me.TabPage8.TabIndex = 7
        Me.TabPage8.Text = "BuildProp"
        Me.TabPage8.UseVisualStyleBackColor = True
        '
        'Button_BuildPropSet
        '
        Me.Button_BuildPropSet.Location = New System.Drawing.Point(527, 57)
        Me.Button_BuildPropSet.Name = "Button_BuildPropSet"
        Me.Button_BuildPropSet.Size = New System.Drawing.Size(75, 23)
        Me.Button_BuildPropSet.TabIndex = 8
        Me.Button_BuildPropSet.Text = "Setzen"
        Me.Button_BuildPropSet.UseVisualStyleBackColor = True
        '
        'TextBox_BuildPropValue
        '
        Me.TextBox_BuildPropValue.Location = New System.Drawing.Point(344, 59)
        Me.TextBox_BuildPropValue.Name = "TextBox_BuildPropValue"
        Me.TextBox_BuildPropValue.Size = New System.Drawing.Size(177, 20)
        Me.TextBox_BuildPropValue.TabIndex = 7
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(283, 62)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(33, 13)
        Me.Label32.TabIndex = 6
        Me.Label32.Text = "Wert:"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(283, 36)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(55, 13)
        Me.Label31.TabIndex = 5
        Me.Label31.Text = "Schlüssel:"
        '
        'TextBox_BuildPropKey
        '
        Me.TextBox_BuildPropKey.Location = New System.Drawing.Point(344, 33)
        Me.TextBox_BuildPropKey.Name = "TextBox_BuildPropKey"
        Me.TextBox_BuildPropKey.Size = New System.Drawing.Size(177, 20)
        Me.TextBox_BuildPropKey.TabIndex = 4
        '
        'TextBox_BuildPropSearch
        '
        Me.TextBox_BuildPropSearch.Location = New System.Drawing.Point(344, 7)
        Me.TextBox_BuildPropSearch.Name = "TextBox_BuildPropSearch"
        Me.TextBox_BuildPropSearch.Size = New System.Drawing.Size(177, 20)
        Me.TextBox_BuildPropSearch.TabIndex = 3
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(283, 9)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(47, 13)
        Me.Label30.TabIndex = 2
        Me.Label30.Text = "Suchen:"
        '
        'Button_BuildPropRefresh
        '
        Me.Button_BuildPropRefresh.Location = New System.Drawing.Point(284, 312)
        Me.Button_BuildPropRefresh.Name = "Button_BuildPropRefresh"
        Me.Button_BuildPropRefresh.Size = New System.Drawing.Size(75, 23)
        Me.Button_BuildPropRefresh.TabIndex = 1
        Me.Button_BuildPropRefresh.Text = "Aktualisieren"
        Me.Button_BuildPropRefresh.UseVisualStyleBackColor = True
        '
        'ListBox_BuildProp
        '
        Me.ListBox_BuildProp.FormattingEnabled = True
        Me.ListBox_BuildProp.Location = New System.Drawing.Point(7, 7)
        Me.ListBox_BuildProp.Name = "ListBox_BuildProp"
        Me.ListBox_BuildProp.Size = New System.Drawing.Size(270, 329)
        Me.ListBox_BuildProp.TabIndex = 0
        '
        'TabPage10
        '
        Me.TabPage10.BackgroundImage = Global.ADBGUI.My.Resources.Resources.Hintergrund2
        Me.TabPage10.Controls.Add(Me.Label35)
        Me.TabPage10.Controls.Add(Me.Button_Command)
        Me.TabPage10.Controls.Add(Me.TextBox_Command)
        Me.TabPage10.Controls.Add(Me.TextBox_Command_Output)
        Me.TabPage10.Location = New System.Drawing.Point(4, 22)
        Me.TabPage10.Name = "TabPage10"
        Me.TabPage10.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage10.Size = New System.Drawing.Size(720, 347)
        Me.TabPage10.TabIndex = 9
        Me.TabPage10.Text = "Konsole"
        Me.TabPage10.UseVisualStyleBackColor = True
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(8, 327)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(65, 13)
        Me.Label35.TabIndex = 3
        Me.Label35.Text = "ADB-Befehl:"
        '
        'Button_Command
        '
        Me.Button_Command.Location = New System.Drawing.Point(567, 322)
        Me.Button_Command.Name = "Button_Command"
        Me.Button_Command.Size = New System.Drawing.Size(102, 23)
        Me.Button_Command.TabIndex = 2
        Me.Button_Command.Text = "Ausführen"
        Me.Button_Command.UseVisualStyleBackColor = True
        '
        'TextBox_Command
        '
        Me.TextBox_Command.Location = New System.Drawing.Point(79, 324)
        Me.TextBox_Command.Name = "TextBox_Command"
        Me.TextBox_Command.Size = New System.Drawing.Size(479, 20)
        Me.TextBox_Command.TabIndex = 1
        '
        'TextBox_Command_Output
        '
        Me.TextBox_Command_Output.Location = New System.Drawing.Point(3, 3)
        Me.TextBox_Command_Output.Multiline = True
        Me.TextBox_Command_Output.Name = "TextBox_Command_Output"
        Me.TextBox_Command_Output.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox_Command_Output.Size = New System.Drawing.Size(666, 315)
        Me.TextBox_Command_Output.TabIndex = 0
        '
        'TabPage9
        '
        Me.TabPage9.BackColor = System.Drawing.Color.Transparent
        Me.TabPage9.BackgroundImage = Global.ADBGUI.My.Resources.Resources.Hintergrund2
        Me.TabPage9.Controls.Add(Me.Label34)
        Me.TabPage9.Controls.Add(Me.Label33)
        Me.TabPage9.Location = New System.Drawing.Point(4, 22)
        Me.TabPage9.Name = "TabPage9"
        Me.TabPage9.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage9.Size = New System.Drawing.Size(720, 347)
        Me.TabPage9.TabIndex = 8
        Me.TabPage9.Text = "Hilfe"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(4, 20)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(348, 65)
        Me.Label34.TabIndex = 1
        Me.Label34.Text = resources.GetString("Label34.Text")
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(4, 7)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(157, 13)
        Me.Label33.TabIndex = 0
        Me.Label33.Text = "ADB-Debugging aktivieren"
        '
        'StatusTimer
        '
        Me.StatusTimer.Interval = 1000
        '
        'StatusWorker
        '
        '
        'ScreenWorker
        '
        '
        'OpenFileDialog
        '
        Me.OpenFileDialog.DefaultExt = "zip"
        Me.OpenFileDialog.Filter = "Zip-Dateien|*.zip"
        '
        'ScreenTimer
        '
        Me.ScreenTimer.Interval = 1
        '
        'OpenFile_Apk
        '
        Me.OpenFile_Apk.Filter = "APK-Dateien|*.apk"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.ADBGUI.My.Resources.Resources.android
        Me.PictureBox1.Location = New System.Drawing.Point(640, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(80, 15)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'TabPage11
        '
        Me.TabPage11.BackgroundImage = Global.ADBGUI.My.Resources.Resources.Hintergrund2
        Me.TabPage11.Controls.Add(Me.Button_Backup_RestorePath)
        Me.TabPage11.Controls.Add(Me.TextBox_Backup_RestorePath)
        Me.TabPage11.Controls.Add(Me.Button_Backup_Restore)
        Me.TabPage11.Controls.Add(Me.Button_Backup_Backup)
        Me.TabPage11.Controls.Add(Me.CheckBox_Backup_System)
        Me.TabPage11.Controls.Add(Me.CheckBox_Backup_Shared)
        Me.TabPage11.Controls.Add(Me.CheckBox_Backup_OBB)
        Me.TabPage11.Controls.Add(Me.CheckBox_Backup_APK)
        Me.TabPage11.Controls.Add(Me.CheckBox_Backup_All)
        Me.TabPage11.Controls.Add(Me.Button_Backup_Target)
        Me.TabPage11.Controls.Add(Me.TextBox_Backup_Target)
        Me.TabPage11.Location = New System.Drawing.Point(4, 22)
        Me.TabPage11.Name = "TabPage11"
        Me.TabPage11.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage11.Size = New System.Drawing.Size(720, 347)
        Me.TabPage11.TabIndex = 10
        Me.TabPage11.Text = "Backup"
        Me.TabPage11.UseVisualStyleBackColor = True
        '
        'TextBox_Backup_Target
        '
        Me.TextBox_Backup_Target.Location = New System.Drawing.Point(8, 6)
        Me.TextBox_Backup_Target.Name = "TextBox_Backup_Target"
        Me.TextBox_Backup_Target.Size = New System.Drawing.Size(307, 20)
        Me.TextBox_Backup_Target.TabIndex = 0
        '
        'Button_Backup_Target
        '
        Me.Button_Backup_Target.Location = New System.Drawing.Point(321, 4)
        Me.Button_Backup_Target.Name = "Button_Backup_Target"
        Me.Button_Backup_Target.Size = New System.Drawing.Size(75, 23)
        Me.Button_Backup_Target.TabIndex = 1
        Me.Button_Backup_Target.Text = "Zielort"
        Me.Button_Backup_Target.UseVisualStyleBackColor = True
        '
        'CheckBox_Backup_All
        '
        Me.CheckBox_Backup_All.AutoSize = True
        Me.CheckBox_Backup_All.Location = New System.Drawing.Point(8, 32)
        Me.CheckBox_Backup_All.Name = "CheckBox_Backup_All"
        Me.CheckBox_Backup_All.Size = New System.Drawing.Size(48, 17)
        Me.CheckBox_Backup_All.TabIndex = 2
        Me.CheckBox_Backup_All.Text = "Alles"
        Me.CheckBox_Backup_All.UseVisualStyleBackColor = True
        '
        'CheckBox_Backup_APK
        '
        Me.CheckBox_Backup_APK.AutoSize = True
        Me.CheckBox_Backup_APK.Location = New System.Drawing.Point(8, 55)
        Me.CheckBox_Backup_APK.Name = "CheckBox_Backup_APK"
        Me.CheckBox_Backup_APK.Size = New System.Drawing.Size(87, 17)
        Me.CheckBox_Backup_APK.TabIndex = 3
        Me.CheckBox_Backup_APK.Text = "APK-Dateien"
        Me.CheckBox_Backup_APK.UseVisualStyleBackColor = True
        '
        'CheckBox_Backup_OBB
        '
        Me.CheckBox_Backup_OBB.AutoSize = True
        Me.CheckBox_Backup_OBB.Location = New System.Drawing.Point(8, 78)
        Me.CheckBox_Backup_OBB.Name = "CheckBox_Backup_OBB"
        Me.CheckBox_Backup_OBB.Size = New System.Drawing.Size(88, 17)
        Me.CheckBox_Backup_OBB.TabIndex = 4
        Me.CheckBox_Backup_OBB.Text = "OBB-Dateien"
        Me.CheckBox_Backup_OBB.UseVisualStyleBackColor = True
        '
        'CheckBox_Backup_Shared
        '
        Me.CheckBox_Backup_Shared.AutoSize = True
        Me.CheckBox_Backup_Shared.Location = New System.Drawing.Point(8, 101)
        Me.CheckBox_Backup_Shared.Name = "CheckBox_Backup_Shared"
        Me.CheckBox_Backup_Shared.Size = New System.Drawing.Size(149, 17)
        Me.CheckBox_Backup_Shared.TabIndex = 5
        Me.CheckBox_Backup_Shared.Text = "Daten(Bilder, Musik, usw.)"
        Me.CheckBox_Backup_Shared.UseVisualStyleBackColor = True
        '
        'CheckBox_Backup_System
        '
        Me.CheckBox_Backup_System.AutoSize = True
        Me.CheckBox_Backup_System.Location = New System.Drawing.Point(8, 124)
        Me.CheckBox_Backup_System.Name = "CheckBox_Backup_System"
        Me.CheckBox_Backup_System.Size = New System.Drawing.Size(60, 17)
        Me.CheckBox_Backup_System.TabIndex = 6
        Me.CheckBox_Backup_System.Text = "System"
        Me.CheckBox_Backup_System.UseVisualStyleBackColor = True
        '
        'Button_Backup_Backup
        '
        Me.Button_Backup_Backup.Location = New System.Drawing.Point(8, 147)
        Me.Button_Backup_Backup.Name = "Button_Backup_Backup"
        Me.Button_Backup_Backup.Size = New System.Drawing.Size(162, 23)
        Me.Button_Backup_Backup.TabIndex = 7
        Me.Button_Backup_Backup.Text = "Sichern"
        Me.Button_Backup_Backup.UseVisualStyleBackColor = True
        '
        'Button_Backup_Restore
        '
        Me.Button_Backup_Restore.Location = New System.Drawing.Point(8, 202)
        Me.Button_Backup_Restore.Name = "Button_Backup_Restore"
        Me.Button_Backup_Restore.Size = New System.Drawing.Size(162, 23)
        Me.Button_Backup_Restore.TabIndex = 8
        Me.Button_Backup_Restore.Text = "Wiederherstellen"
        Me.Button_Backup_Restore.UseVisualStyleBackColor = True
        '
        'TextBox_Backup_RestorePath
        '
        Me.TextBox_Backup_RestorePath.Location = New System.Drawing.Point(8, 176)
        Me.TextBox_Backup_RestorePath.Name = "TextBox_Backup_RestorePath"
        Me.TextBox_Backup_RestorePath.Size = New System.Drawing.Size(307, 20)
        Me.TextBox_Backup_RestorePath.TabIndex = 9
        '
        'Button_Backup_RestorePath
        '
        Me.Button_Backup_RestorePath.Location = New System.Drawing.Point(321, 174)
        Me.Button_Backup_RestorePath.Name = "Button_Backup_RestorePath"
        Me.Button_Backup_RestorePath.Size = New System.Drawing.Size(100, 23)
        Me.Button_Backup_RestorePath.TabIndex = 10
        Me.Button_Backup_RestorePath.Text = "Backup-Datei"
        Me.Button_Backup_RestorePath.UseVisualStyleBackColor = True
        '
        'OpenFile_Backup
        '
        Me.OpenFile_Backup.Filter = "Backup|*.ab"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(728, 401)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Main"
        Me.Text = "ADBGUI"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage6.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.TrackBar_Bitrate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBar_RecTime, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Picture_Screen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
        Me.TabPage7.ResumeLayout(False)
        Me.TabPage7.PerformLayout()
        Me.TabPage8.ResumeLayout(False)
        Me.TabPage8.PerformLayout()
        Me.TabPage10.ResumeLayout(False)
        Me.TabPage10.PerformLayout()
        Me.TabPage9.ResumeLayout(False)
        Me.TabPage9.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage11.ResumeLayout(False)
        Me.TabPage11.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents Label_Status As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Label_DeviceName As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ProgressBar_Battery As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents Label_Battery As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusTimer As System.Windows.Forms.Timer
    Friend WithEvents StatusWorker As System.ComponentModel.BackgroundWorker
    Friend WithEvents CheckBox_ScreenCap As System.Windows.Forms.CheckBox
    Friend WithEvents Picture_Screen As System.Windows.Forms.PictureBox
    Friend WithEvents ScreenWorker As System.ComponentModel.BackgroundWorker
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button_Screenrec As System.Windows.Forms.Button
    Friend WithEvents TrackBar_RecTime As System.Windows.Forms.TrackBar
    Friend WithEvents Label_RecTime As System.Windows.Forms.Label
    Friend WithEvents TrackBar_Bitrate As System.Windows.Forms.TrackBar
    Friend WithEvents Label_Bitrate As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox_ResWidth As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_ResHeight As System.Windows.Forms.TextBox
    Friend WithEvents CheckBox_Resolution As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox_RecOnPC As System.Windows.Forms.CheckBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Button_Recovery As System.Windows.Forms.Button
    Friend WithEvents Button_Bootloader As System.Windows.Forms.Button
    Friend WithEvents Button_Fastboot As System.Windows.Forms.Button
    Friend WithEvents Button_Reboot As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents Button_RecoverySideload As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Button_SideloadSearch As System.Windows.Forms.Button
    Friend WithEvents TextBox_SideloadPath As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Button_Sideload As System.Windows.Forms.Button
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage6 As System.Windows.Forms.TabPage
    Friend WithEvents Label_device_manufacturer As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label_device_device As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label_device_codename As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label_device_batterylevel As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label_device_root As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label_device_temperature As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label_device_batterytechnology As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label_device_busybox As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents TabPage7 As System.Windows.Forms.TabPage
    Friend WithEvents TextBox_Nummer As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Button_Call As System.Windows.Forms.Button
    Friend WithEvents Button_Dial As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Button_Apps_Refresh As System.Windows.Forms.Button
    Friend WithEvents ListBox_Apps As System.Windows.Forms.ListBox
    Friend WithEvents Label_device_sdcard As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label_device_intern As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label_device_system As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label_device_ownpath As System.Windows.Forms.Label
    Friend WithEvents TextBox_OwnPath As System.Windows.Forms.TextBox
    Friend WithEvents Button_Uninstall As System.Windows.Forms.Button
    Friend WithEvents ScreenTimer As System.Windows.Forms.Timer
    Friend WithEvents TextBox_PathPC As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_PathPhone As System.Windows.Forms.TextBox
    Friend WithEvents OpenFile_Push As System.Windows.Forms.OpenFileDialog
    Friend WithEvents FolderBrowserPull As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents Button_PullDirectory As System.Windows.Forms.Button
    Friend WithEvents Button_PushFile As System.Windows.Forms.Button
    Friend WithEvents Button_Push As System.Windows.Forms.Button
    Friend WithEvents Button_Pull As System.Windows.Forms.Button
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents OpenFile_Apk As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Button_Apk As System.Windows.Forms.Button
    Friend WithEvents Button_Install As System.Windows.Forms.Button
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents TextBox_Apk As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_Apps_Search As System.Windows.Forms.TextBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents TabPage8 As System.Windows.Forms.TabPage
    Friend WithEvents Button_BuildPropRefresh As System.Windows.Forms.Button
    Friend WithEvents ListBox_BuildProp As System.Windows.Forms.ListBox
    Friend WithEvents TextBox_BuildPropSearch As System.Windows.Forms.TextBox
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents TextBox_BuildPropKey As System.Windows.Forms.TextBox
    Friend WithEvents Button_BuildPropSet As System.Windows.Forms.Button
    Friend WithEvents TextBox_BuildPropValue As System.Windows.Forms.TextBox
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents TabPage9 As System.Windows.Forms.TabPage
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents TabPage10 As System.Windows.Forms.TabPage
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents Button_Command As System.Windows.Forms.Button
    Friend WithEvents TextBox_Command As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_Command_Output As System.Windows.Forms.TextBox
    Friend WithEvents TabPage11 As System.Windows.Forms.TabPage
    Friend WithEvents Button_Backup_Restore As System.Windows.Forms.Button
    Friend WithEvents Button_Backup_Backup As System.Windows.Forms.Button
    Friend WithEvents CheckBox_Backup_System As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox_Backup_Shared As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox_Backup_OBB As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox_Backup_APK As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox_Backup_All As System.Windows.Forms.CheckBox
    Friend WithEvents Button_Backup_Target As System.Windows.Forms.Button
    Friend WithEvents TextBox_Backup_Target As System.Windows.Forms.TextBox
    Friend WithEvents Button_Backup_RestorePath As System.Windows.Forms.Button
    Friend WithEvents TextBox_Backup_RestorePath As System.Windows.Forms.TextBox
    Friend WithEvents OpenFile_Backup As System.Windows.Forms.OpenFileDialog

End Class
