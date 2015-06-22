<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LicenseForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.label_ValidLicenseAvailable = New System.Windows.Forms.Label()
        Me.manager_groupbox = New System.Windows.Forms.GroupBox()
        Me.label_HardwareLock_Bios = New System.Windows.Forms.Label()
        Me.label_HardwareLock_OS = New System.Windows.Forms.Label()
        Me.label_HardwareLock_Mainboard = New System.Windows.Forms.Label()
        Me.label_HardwareLock_MAC = New System.Windows.Forms.Label()
        Me.label_HardwareLock_HDD = New System.Windows.Forms.Label()
        Me.label_HardwareLock_CPU = New System.Windows.Forms.Label()
        Me.label_LicenseHardwareID = New System.Windows.Forms.Label()
        Me.label_HardwareLock_Enabled = New System.Windows.Forms.Label()
        Me.label_LicenseServer = New System.Windows.Forms.Label()
        Me.label_LicenseServer_Enabled = New System.Windows.Forms.Label()
        Me.label_LicenseLocks_Enabled = New System.Windows.Forms.Label()
        Me.locks_groupbox = New System.Windows.Forms.GroupBox()
        Me.panel_devider = New System.Windows.Forms.Panel()
        Me.label_Custom_Enabled = New System.Windows.Forms.Label()
        Me.label_GlobalTime = New System.Windows.Forms.Label()
        Me.label_GlobalTime_Enabled = New System.Windows.Forms.Label()
        Me.label_GlobalTime_Current = New System.Windows.Forms.Label()
        Me.label_Runtime_Enabled = New System.Windows.Forms.Label()
        Me.label_Runtime = New System.Windows.Forms.Label()
        Me.label_ExpirationDays_Current = New System.Windows.Forms.Label()
        Me.label_ExpirationDate_Enabled = New System.Windows.Forms.Label()
        Me.label_ExpirationDate = New System.Windows.Forms.Label()
        Me.label_Executions = New System.Windows.Forms.Label()
        Me.label_Executions_Enabled = New System.Windows.Forms.Label()
        Me.label_Instances = New System.Windows.Forms.Label()
        Me.label_Executions_Current = New System.Windows.Forms.Label()
        Me.label_Instances_Enabled = New System.Windows.Forms.Label()
        Me.label_ExpirationDays_Enabled = New System.Windows.Forms.Label()
        Me.label_ExpirationDays = New System.Windows.Forms.Label()
        Me.listView1 = New System.Windows.Forms.ListView()
        Me.columnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.columnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.label9 = New System.Windows.Forms.Label()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.hid_textbox = New System.Windows.Forms.TextBox()
        Me.hid_mainboard = New System.Windows.Forms.CheckBox()
        Me.hid_os = New System.Windows.Forms.CheckBox()
        Me.hid_hdd = New System.Windows.Forms.CheckBox()
        Me.hid_cpu = New System.Windows.Forms.CheckBox()
        Me.hid_mac = New System.Windows.Forms.CheckBox()
        Me.hid_bios = New System.Windows.Forms.CheckBox()
        Me.manager_groupbox.SuspendLayout()
        Me.locks_groupbox.SuspendLayout()
        Me.groupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'label_ValidLicenseAvailable
        '
        Me.label_ValidLicenseAvailable.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.label_ValidLicenseAvailable.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_ValidLicenseAvailable.Location = New System.Drawing.Point(12, 22)
        Me.label_ValidLicenseAvailable.Name = "label_ValidLicenseAvailable"
        Me.label_ValidLicenseAvailable.Size = New System.Drawing.Size(616, 24)
        Me.label_ValidLicenseAvailable.TabIndex = 29
        Me.label_ValidLicenseAvailable.Text = "CurrentLicense.LicenseStatus = "
        Me.label_ValidLicenseAvailable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'manager_groupbox
        '
        Me.manager_groupbox.Controls.Add(Me.label_HardwareLock_Bios)
        Me.manager_groupbox.Controls.Add(Me.label_HardwareLock_OS)
        Me.manager_groupbox.Controls.Add(Me.label_HardwareLock_Mainboard)
        Me.manager_groupbox.Controls.Add(Me.label_HardwareLock_MAC)
        Me.manager_groupbox.Controls.Add(Me.label_HardwareLock_HDD)
        Me.manager_groupbox.Controls.Add(Me.label_HardwareLock_CPU)
        Me.manager_groupbox.Controls.Add(Me.label_LicenseHardwareID)
        Me.manager_groupbox.Controls.Add(Me.label_HardwareLock_Enabled)
        Me.manager_groupbox.Controls.Add(Me.label_LicenseServer)
        Me.manager_groupbox.Controls.Add(Me.label_LicenseServer_Enabled)
        Me.manager_groupbox.Controls.Add(Me.label_LicenseLocks_Enabled)
        Me.manager_groupbox.Location = New System.Drawing.Point(12, 49)
        Me.manager_groupbox.Name = "manager_groupbox"
        Me.manager_groupbox.Size = New System.Drawing.Size(612, 224)
        Me.manager_groupbox.TabIndex = 32
        Me.manager_groupbox.TabStop = False
        Me.manager_groupbox.Text = "License Settings"
        '
        'label_HardwareLock_Bios
        '
        Me.label_HardwareLock_Bios.AutoSize = True
        Me.label_HardwareLock_Bios.Location = New System.Drawing.Point(24, 96)
        Me.label_HardwareLock_Bios.Name = "label_HardwareLock_Bios"
        Me.label_HardwareLock_Bios.Size = New System.Drawing.Size(191, 13)
        Me.label_HardwareLock_Bios.TabIndex = 29
        Me.label_HardwareLock_Bios.Text = "CurrentLicense.HardwareLock_BIOS ="
        Me.label_HardwareLock_Bios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'label_HardwareLock_OS
        '
        Me.label_HardwareLock_OS.AutoSize = True
        Me.label_HardwareLock_OS.Location = New System.Drawing.Point(24, 176)
        Me.label_HardwareLock_OS.Name = "label_HardwareLock_OS"
        Me.label_HardwareLock_OS.Size = New System.Drawing.Size(181, 13)
        Me.label_HardwareLock_OS.TabIndex = 28
        Me.label_HardwareLock_OS.Text = "CurrentLicense.HardwareLock_OS ="
        Me.label_HardwareLock_OS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'label_HardwareLock_Mainboard
        '
        Me.label_HardwareLock_Mainboard.AutoSize = True
        Me.label_HardwareLock_Mainboard.Location = New System.Drawing.Point(24, 160)
        Me.label_HardwareLock_Mainboard.Name = "label_HardwareLock_Mainboard"
        Me.label_HardwareLock_Mainboard.Size = New System.Drawing.Size(216, 13)
        Me.label_HardwareLock_Mainboard.TabIndex = 27
        Me.label_HardwareLock_Mainboard.Text = "CurrentLicense.HardwareLock_Mainboard ="
        Me.label_HardwareLock_Mainboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'label_HardwareLock_MAC
        '
        Me.label_HardwareLock_MAC.AutoSize = True
        Me.label_HardwareLock_MAC.Location = New System.Drawing.Point(24, 144)
        Me.label_HardwareLock_MAC.Name = "label_HardwareLock_MAC"
        Me.label_HardwareLock_MAC.Size = New System.Drawing.Size(189, 13)
        Me.label_HardwareLock_MAC.TabIndex = 26
        Me.label_HardwareLock_MAC.Text = "CurrentLicense.HardwareLock_MAC ="
        Me.label_HardwareLock_MAC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'label_HardwareLock_HDD
        '
        Me.label_HardwareLock_HDD.AutoSize = True
        Me.label_HardwareLock_HDD.Location = New System.Drawing.Point(24, 128)
        Me.label_HardwareLock_HDD.Name = "label_HardwareLock_HDD"
        Me.label_HardwareLock_HDD.Size = New System.Drawing.Size(190, 13)
        Me.label_HardwareLock_HDD.TabIndex = 25
        Me.label_HardwareLock_HDD.Text = "CurrentLicense.HardwareLock_HDD ="
        Me.label_HardwareLock_HDD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'label_HardwareLock_CPU
        '
        Me.label_HardwareLock_CPU.AutoSize = True
        Me.label_HardwareLock_CPU.Location = New System.Drawing.Point(24, 112)
        Me.label_HardwareLock_CPU.Name = "label_HardwareLock_CPU"
        Me.label_HardwareLock_CPU.Size = New System.Drawing.Size(188, 13)
        Me.label_HardwareLock_CPU.TabIndex = 24
        Me.label_HardwareLock_CPU.Text = "CurrentLicense.HardwareLock_CPU ="
        Me.label_HardwareLock_CPU.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'label_LicenseHardwareID
        '
        Me.label_LicenseHardwareID.AutoSize = True
        Me.label_LicenseHardwareID.Location = New System.Drawing.Point(24, 80)
        Me.label_LicenseHardwareID.Name = "label_LicenseHardwareID"
        Me.label_LicenseHardwareID.Size = New System.Drawing.Size(147, 13)
        Me.label_LicenseHardwareID.TabIndex = 23
        Me.label_LicenseHardwareID.Text = "CurrentLicense.HardwareID ="
        Me.label_LicenseHardwareID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'label_HardwareLock_Enabled
        '
        Me.label_HardwareLock_Enabled.AutoSize = True
        Me.label_HardwareLock_Enabled.Location = New System.Drawing.Point(8, 64)
        Me.label_HardwareLock_Enabled.Name = "label_HardwareLock_Enabled"
        Me.label_HardwareLock_Enabled.Size = New System.Drawing.Size(205, 13)
        Me.label_HardwareLock_Enabled.TabIndex = 22
        Me.label_HardwareLock_Enabled.Text = "CurrentLicense.HardwareLock_Enabled ="
        Me.label_HardwareLock_Enabled.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'label_LicenseServer
        '
        Me.label_LicenseServer.AutoSize = True
        Me.label_LicenseServer.Location = New System.Drawing.Point(24, 40)
        Me.label_LicenseServer.Name = "label_LicenseServer"
        Me.label_LicenseServer.Size = New System.Drawing.Size(158, 13)
        Me.label_LicenseServer.TabIndex = 19
        Me.label_LicenseServer.Text = "CurrentLicense.LicenseServer ="
        Me.label_LicenseServer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'label_LicenseServer_Enabled
        '
        Me.label_LicenseServer_Enabled.AutoSize = True
        Me.label_LicenseServer_Enabled.Location = New System.Drawing.Point(8, 24)
        Me.label_LicenseServer_Enabled.Name = "label_LicenseServer_Enabled"
        Me.label_LicenseServer_Enabled.Size = New System.Drawing.Size(241, 13)
        Me.label_LicenseServer_Enabled.TabIndex = 18
        Me.label_LicenseServer_Enabled.Text = "CurrentLicense.RequireLicenseServerValidation ="
        Me.label_LicenseServer_Enabled.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'label_LicenseLocks_Enabled
        '
        Me.label_LicenseLocks_Enabled.AutoSize = True
        Me.label_LicenseLocks_Enabled.Location = New System.Drawing.Point(8, 200)
        Me.label_LicenseLocks_Enabled.Name = "label_LicenseLocks_Enabled"
        Me.label_LicenseLocks_Enabled.Size = New System.Drawing.Size(158, 13)
        Me.label_LicenseLocks_Enabled.TabIndex = 24
        Me.label_LicenseLocks_Enabled.Text = "CurrentLicense.TrialRestricted ="
        Me.label_LicenseLocks_Enabled.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'locks_groupbox
        '
        Me.locks_groupbox.Controls.Add(Me.panel_devider)
        Me.locks_groupbox.Controls.Add(Me.label_Custom_Enabled)
        Me.locks_groupbox.Controls.Add(Me.label_GlobalTime)
        Me.locks_groupbox.Controls.Add(Me.label_GlobalTime_Enabled)
        Me.locks_groupbox.Controls.Add(Me.label_GlobalTime_Current)
        Me.locks_groupbox.Controls.Add(Me.label_Runtime_Enabled)
        Me.locks_groupbox.Controls.Add(Me.label_Runtime)
        Me.locks_groupbox.Controls.Add(Me.label_ExpirationDays_Current)
        Me.locks_groupbox.Controls.Add(Me.label_ExpirationDate_Enabled)
        Me.locks_groupbox.Controls.Add(Me.label_ExpirationDate)
        Me.locks_groupbox.Controls.Add(Me.label_Executions)
        Me.locks_groupbox.Controls.Add(Me.label_Executions_Enabled)
        Me.locks_groupbox.Controls.Add(Me.label_Instances)
        Me.locks_groupbox.Controls.Add(Me.label_Executions_Current)
        Me.locks_groupbox.Controls.Add(Me.label_Instances_Enabled)
        Me.locks_groupbox.Controls.Add(Me.label_ExpirationDays_Enabled)
        Me.locks_groupbox.Controls.Add(Me.label_ExpirationDays)
        Me.locks_groupbox.Location = New System.Drawing.Point(12, 279)
        Me.locks_groupbox.Name = "locks_groupbox"
        Me.locks_groupbox.Size = New System.Drawing.Size(612, 216)
        Me.locks_groupbox.TabIndex = 33
        Me.locks_groupbox.TabStop = False
        Me.locks_groupbox.Text = "Locks"
        '
        'panel_devider
        '
        Me.panel_devider.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel_devider.Location = New System.Drawing.Point(311, 16)
        Me.panel_devider.Name = "panel_devider"
        Me.panel_devider.Size = New System.Drawing.Size(1, 192)
        Me.panel_devider.TabIndex = 24
        '
        'label_Custom_Enabled
        '
        Me.label_Custom_Enabled.AutoSize = True
        Me.label_Custom_Enabled.Location = New System.Drawing.Point(328, 120)
        Me.label_Custom_Enabled.Name = "label_Custom_Enabled"
        Me.label_Custom_Enabled.Size = New System.Drawing.Size(173, 13)
        Me.label_Custom_Enabled.TabIndex = 23
        Me.label_Custom_Enabled.Text = "CurrentLicense.Custom_Enabled = "
        Me.label_Custom_Enabled.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'label_GlobalTime
        '
        Me.label_GlobalTime.AutoSize = True
        Me.label_GlobalTime.Location = New System.Drawing.Point(344, 40)
        Me.label_GlobalTime.Name = "label_GlobalTime"
        Me.label_GlobalTime.Size = New System.Drawing.Size(146, 13)
        Me.label_GlobalTime.TabIndex = 21
        Me.label_GlobalTime.Text = "CurrentLicense.GlobalTime = "
        Me.label_GlobalTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'label_GlobalTime_Enabled
        '
        Me.label_GlobalTime_Enabled.AutoSize = True
        Me.label_GlobalTime_Enabled.Location = New System.Drawing.Point(328, 24)
        Me.label_GlobalTime_Enabled.Name = "label_GlobalTime_Enabled"
        Me.label_GlobalTime_Enabled.Size = New System.Drawing.Size(191, 13)
        Me.label_GlobalTime_Enabled.TabIndex = 20
        Me.label_GlobalTime_Enabled.Text = "CurrentLicense.GlobalTime_Enabled = "
        Me.label_GlobalTime_Enabled.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'label_GlobalTime_Current
        '
        Me.label_GlobalTime_Current.AutoSize = True
        Me.label_GlobalTime_Current.Location = New System.Drawing.Point(344, 56)
        Me.label_GlobalTime_Current.Name = "label_GlobalTime_Current"
        Me.label_GlobalTime_Current.Size = New System.Drawing.Size(186, 13)
        Me.label_GlobalTime_Current.TabIndex = 22
        Me.label_GlobalTime_Current.Text = "CurrentLicense.GlobalTime_Current = "
        Me.label_GlobalTime_Current.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'label_Runtime_Enabled
        '
        Me.label_Runtime_Enabled.AutoSize = True
        Me.label_Runtime_Enabled.Location = New System.Drawing.Point(8, 176)
        Me.label_Runtime_Enabled.Name = "label_Runtime_Enabled"
        Me.label_Runtime_Enabled.Size = New System.Drawing.Size(177, 13)
        Me.label_Runtime_Enabled.TabIndex = 18
        Me.label_Runtime_Enabled.Text = "CurrentLicense.Runtime_Enabled = "
        Me.label_Runtime_Enabled.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'label_Runtime
        '
        Me.label_Runtime.AutoSize = True
        Me.label_Runtime.Location = New System.Drawing.Point(24, 192)
        Me.label_Runtime.Name = "label_Runtime"
        Me.label_Runtime.Size = New System.Drawing.Size(132, 13)
        Me.label_Runtime.TabIndex = 19
        Me.label_Runtime.Text = "CurrentLicense.Runtime = "
        Me.label_Runtime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'label_ExpirationDays_Current
        '
        Me.label_ExpirationDays_Current.AutoSize = True
        Me.label_ExpirationDays_Current.Location = New System.Drawing.Point(24, 56)
        Me.label_ExpirationDays_Current.Name = "label_ExpirationDays_Current"
        Me.label_ExpirationDays_Current.Size = New System.Drawing.Size(203, 13)
        Me.label_ExpirationDays_Current.TabIndex = 5
        Me.label_ExpirationDays_Current.Text = "CurrentLicense.ExpirationDays_Current = "
        Me.label_ExpirationDays_Current.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'label_ExpirationDate_Enabled
        '
        Me.label_ExpirationDate_Enabled.AutoSize = True
        Me.label_ExpirationDate_Enabled.Location = New System.Drawing.Point(8, 80)
        Me.label_ExpirationDate_Enabled.Name = "label_ExpirationDate_Enabled"
        Me.label_ExpirationDate_Enabled.Size = New System.Drawing.Size(207, 13)
        Me.label_ExpirationDate_Enabled.TabIndex = 8
        Me.label_ExpirationDate_Enabled.Text = "CurrentLicense.ExpirationDate_Enabled = "
        Me.label_ExpirationDate_Enabled.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'label_ExpirationDate
        '
        Me.label_ExpirationDate.AutoSize = True
        Me.label_ExpirationDate.Location = New System.Drawing.Point(24, 96)
        Me.label_ExpirationDate.Name = "label_ExpirationDate"
        Me.label_ExpirationDate.Size = New System.Drawing.Size(162, 13)
        Me.label_ExpirationDate.TabIndex = 9
        Me.label_ExpirationDate.Text = "CurrentLicense.ExpirationDate = "
        Me.label_ExpirationDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'label_Executions
        '
        Me.label_Executions.AutoSize = True
        Me.label_Executions.Location = New System.Drawing.Point(24, 136)
        Me.label_Executions.Name = "label_Executions"
        Me.label_Executions.Size = New System.Drawing.Size(145, 13)
        Me.label_Executions.TabIndex = 13
        Me.label_Executions.Text = "CurrentLicense.Executions = "
        Me.label_Executions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'label_Executions_Enabled
        '
        Me.label_Executions_Enabled.AutoSize = True
        Me.label_Executions_Enabled.Location = New System.Drawing.Point(8, 120)
        Me.label_Executions_Enabled.Name = "label_Executions_Enabled"
        Me.label_Executions_Enabled.Size = New System.Drawing.Size(190, 13)
        Me.label_Executions_Enabled.TabIndex = 12
        Me.label_Executions_Enabled.Text = "CurrentLicense.Executions_Enabled = "
        Me.label_Executions_Enabled.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'label_Instances
        '
        Me.label_Instances.AutoSize = True
        Me.label_Instances.Location = New System.Drawing.Point(344, 96)
        Me.label_Instances.Name = "label_Instances"
        Me.label_Instances.Size = New System.Drawing.Size(139, 13)
        Me.label_Instances.TabIndex = 17
        Me.label_Instances.Text = "CurrentLicense.Instances = "
        Me.label_Instances.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'label_Executions_Current
        '
        Me.label_Executions_Current.AutoSize = True
        Me.label_Executions_Current.Location = New System.Drawing.Point(24, 152)
        Me.label_Executions_Current.Name = "label_Executions_Current"
        Me.label_Executions_Current.Size = New System.Drawing.Size(185, 13)
        Me.label_Executions_Current.TabIndex = 14
        Me.label_Executions_Current.Text = "CurrentLicense.Executions_Current = "
        Me.label_Executions_Current.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'label_Instances_Enabled
        '
        Me.label_Instances_Enabled.AutoSize = True
        Me.label_Instances_Enabled.Location = New System.Drawing.Point(328, 80)
        Me.label_Instances_Enabled.Name = "label_Instances_Enabled"
        Me.label_Instances_Enabled.Size = New System.Drawing.Size(184, 13)
        Me.label_Instances_Enabled.TabIndex = 16
        Me.label_Instances_Enabled.Text = "CurrentLicense.Instances_Enabled = "
        Me.label_Instances_Enabled.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'label_ExpirationDays_Enabled
        '
        Me.label_ExpirationDays_Enabled.AutoSize = True
        Me.label_ExpirationDays_Enabled.Location = New System.Drawing.Point(8, 24)
        Me.label_ExpirationDays_Enabled.Name = "label_ExpirationDays_Enabled"
        Me.label_ExpirationDays_Enabled.Size = New System.Drawing.Size(205, 13)
        Me.label_ExpirationDays_Enabled.TabIndex = 3
        Me.label_ExpirationDays_Enabled.Text = "CurrentLicense.ExpirationDays_Enabled ="
        Me.label_ExpirationDays_Enabled.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'label_ExpirationDays
        '
        Me.label_ExpirationDays.AutoSize = True
        Me.label_ExpirationDays.Location = New System.Drawing.Point(24, 40)
        Me.label_ExpirationDays.Name = "label_ExpirationDays"
        Me.label_ExpirationDays.Size = New System.Drawing.Size(163, 13)
        Me.label_ExpirationDays.TabIndex = 4
        Me.label_ExpirationDays.Text = "CurrentLicense.ExpirationDays = "
        Me.label_ExpirationDays.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'listView1
        '
        Me.listView1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.listView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.listView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.columnHeader1, Me.columnHeader2})
        Me.listView1.Location = New System.Drawing.Point(12, 523)
        Me.listView1.Name = "listView1"
        Me.listView1.Size = New System.Drawing.Size(610, 136)
        Me.listView1.TabIndex = 34
        Me.listView1.UseCompatibleStateImageBehavior = False
        Me.listView1.View = System.Windows.Forms.View.Details
        '
        'columnHeader1
        '
        Me.columnHeader1.Text = "Key"
        Me.columnHeader1.Width = 148
        '
        'columnHeader2
        '
        Me.columnHeader2.Text = "Value"
        Me.columnHeader2.Width = 439
        '
        'label9
        '
        Me.label9.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.label9.Location = New System.Drawing.Point(12, 507)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(518, 16)
        Me.label9.TabIndex = 35
        Me.label9.Text = "License Information:"
        Me.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.hid_textbox)
        Me.groupBox1.Controls.Add(Me.hid_mainboard)
        Me.groupBox1.Controls.Add(Me.hid_os)
        Me.groupBox1.Controls.Add(Me.hid_hdd)
        Me.groupBox1.Controls.Add(Me.hid_cpu)
        Me.groupBox1.Controls.Add(Me.hid_mac)
        Me.groupBox1.Controls.Add(Me.hid_bios)
        Me.groupBox1.Location = New System.Drawing.Point(12, 665)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(608, 56)
        Me.groupBox1.TabIndex = 36
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Hardware ID"
        '
        'hid_textbox
        '
        Me.hid_textbox.Location = New System.Drawing.Point(368, 24)
        Me.hid_textbox.Name = "hid_textbox"
        Me.hid_textbox.Size = New System.Drawing.Size(224, 20)
        Me.hid_textbox.TabIndex = 6
        Me.hid_textbox.Text = "####-####-####-####-####-####"
        '
        'hid_mainboard
        '
        Me.hid_mainboard.AutoCheck = False
        Me.hid_mainboard.Checked = True
        Me.hid_mainboard.CheckState = System.Windows.Forms.CheckState.Checked
        Me.hid_mainboard.Location = New System.Drawing.Point(232, 24)
        Me.hid_mainboard.Name = "hid_mainboard"
        Me.hid_mainboard.Size = New System.Drawing.Size(80, 24)
        Me.hid_mainboard.TabIndex = 5
        Me.hid_mainboard.Text = "Mainboard"
        '
        'hid_os
        '
        Me.hid_os.AutoCheck = False
        Me.hid_os.Location = New System.Drawing.Point(312, 24)
        Me.hid_os.Name = "hid_os"
        Me.hid_os.Size = New System.Drawing.Size(50, 24)
        Me.hid_os.TabIndex = 4
        Me.hid_os.Text = "OS"
        '
        'hid_hdd
        '
        Me.hid_hdd.AutoCheck = False
        Me.hid_hdd.Location = New System.Drawing.Point(120, 24)
        Me.hid_hdd.Name = "hid_hdd"
        Me.hid_hdd.Size = New System.Drawing.Size(50, 24)
        Me.hid_hdd.TabIndex = 3
        Me.hid_hdd.Text = "HDD"
        '
        'hid_cpu
        '
        Me.hid_cpu.AutoCheck = False
        Me.hid_cpu.Checked = True
        Me.hid_cpu.CheckState = System.Windows.Forms.CheckState.Checked
        Me.hid_cpu.Location = New System.Drawing.Point(64, 24)
        Me.hid_cpu.Name = "hid_cpu"
        Me.hid_cpu.Size = New System.Drawing.Size(48, 24)
        Me.hid_cpu.TabIndex = 2
        Me.hid_cpu.Text = "CPU"
        '
        'hid_mac
        '
        Me.hid_mac.AutoCheck = False
        Me.hid_mac.Checked = True
        Me.hid_mac.CheckState = System.Windows.Forms.CheckState.Checked
        Me.hid_mac.Location = New System.Drawing.Point(176, 24)
        Me.hid_mac.Name = "hid_mac"
        Me.hid_mac.Size = New System.Drawing.Size(50, 24)
        Me.hid_mac.TabIndex = 1
        Me.hid_mac.Text = "MAC"
        '
        'hid_bios
        '
        Me.hid_bios.AutoCheck = False
        Me.hid_bios.Checked = True
        Me.hid_bios.CheckState = System.Windows.Forms.CheckState.Checked
        Me.hid_bios.Location = New System.Drawing.Point(8, 24)
        Me.hid_bios.Name = "hid_bios"
        Me.hid_bios.Size = New System.Drawing.Size(56, 24)
        Me.hid_bios.TabIndex = 0
        Me.hid_bios.Text = "BIOS"
        '
        'LicenseForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(633, 739)
        Me.Controls.Add(Me.groupBox1)
        Me.Controls.Add(Me.listView1)
        Me.Controls.Add(Me.label9)
        Me.Controls.Add(Me.locks_groupbox)
        Me.Controls.Add(Me.manager_groupbox)
        Me.Controls.Add(Me.label_ValidLicenseAvailable)
        Me.Name = "LicenseForm"
        Me.Text = "LicenseForm"
        Me.manager_groupbox.ResumeLayout(False)
        Me.manager_groupbox.PerformLayout()
        Me.locks_groupbox.ResumeLayout(False)
        Me.locks_groupbox.PerformLayout()
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents label_ValidLicenseAvailable As System.Windows.Forms.Label
    Private WithEvents manager_groupbox As System.Windows.Forms.GroupBox
    Private WithEvents label_HardwareLock_Bios As System.Windows.Forms.Label
    Private WithEvents label_HardwareLock_OS As System.Windows.Forms.Label
    Private WithEvents label_HardwareLock_Mainboard As System.Windows.Forms.Label
    Private WithEvents label_HardwareLock_MAC As System.Windows.Forms.Label
    Private WithEvents label_HardwareLock_HDD As System.Windows.Forms.Label
    Private WithEvents label_HardwareLock_CPU As System.Windows.Forms.Label
    Private WithEvents label_LicenseHardwareID As System.Windows.Forms.Label
    Private WithEvents label_HardwareLock_Enabled As System.Windows.Forms.Label
    Private WithEvents label_LicenseServer As System.Windows.Forms.Label
    Private WithEvents label_LicenseServer_Enabled As System.Windows.Forms.Label
    Private WithEvents label_LicenseLocks_Enabled As System.Windows.Forms.Label
    Private WithEvents locks_groupbox As System.Windows.Forms.GroupBox
    Private WithEvents panel_devider As System.Windows.Forms.Panel
    Private WithEvents label_Custom_Enabled As System.Windows.Forms.Label
    Private WithEvents label_GlobalTime As System.Windows.Forms.Label
    Private WithEvents label_GlobalTime_Enabled As System.Windows.Forms.Label
    Private WithEvents label_GlobalTime_Current As System.Windows.Forms.Label
    Private WithEvents label_Runtime_Enabled As System.Windows.Forms.Label
    Private WithEvents label_Runtime As System.Windows.Forms.Label
    Private WithEvents label_ExpirationDays_Current As System.Windows.Forms.Label
    Private WithEvents label_ExpirationDate_Enabled As System.Windows.Forms.Label
    Private WithEvents label_ExpirationDate As System.Windows.Forms.Label
    Private WithEvents label_Executions As System.Windows.Forms.Label
    Private WithEvents label_Executions_Enabled As System.Windows.Forms.Label
    Private WithEvents label_Instances As System.Windows.Forms.Label
    Private WithEvents label_Executions_Current As System.Windows.Forms.Label
    Private WithEvents label_Instances_Enabled As System.Windows.Forms.Label
    Private WithEvents label_ExpirationDays_Enabled As System.Windows.Forms.Label
    Private WithEvents label_ExpirationDays As System.Windows.Forms.Label
    Private WithEvents listView1 As System.Windows.Forms.ListView
    Private WithEvents columnHeader1 As System.Windows.Forms.ColumnHeader
    Private WithEvents columnHeader2 As System.Windows.Forms.ColumnHeader
    Private WithEvents label9 As System.Windows.Forms.Label
    Private WithEvents groupBox1 As System.Windows.Forms.GroupBox
    Private WithEvents hid_textbox As System.Windows.Forms.TextBox
    Private WithEvents hid_mainboard As System.Windows.Forms.CheckBox
    Private WithEvents hid_os As System.Windows.Forms.CheckBox
    Private WithEvents hid_hdd As System.Windows.Forms.CheckBox
    Private WithEvents hid_cpu As System.Windows.Forms.CheckBox
    Private WithEvents hid_mac As System.Windows.Forms.CheckBox
    Private WithEvents hid_bios As System.Windows.Forms.CheckBox
End Class
