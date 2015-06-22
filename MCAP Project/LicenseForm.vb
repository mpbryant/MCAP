Public Class LicenseForm

    Private Sub LicenseForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DisplayHardwareID()
        Me.UpdateSettings()
    End Sub

    Private Sub hid_item_checkedchanged(ByVal sender As Object, ByVal e As EventArgs) Handles hid_os.CheckedChanged, hid_mainboard.CheckedChanged, hid_mac.CheckedChanged, hid_hdd.CheckedChanged, hid_cpu.CheckedChanged, hid_bios.CheckedChanged
        Me.DisplayHardwareID()
    End Sub

    Private Sub DisplayHardwareID()
        Me.hid_textbox.Text = IntelliLock.Licensing.HardwareID.GetHardwareID(Me.hid_cpu.Checked, Me.hid_hdd.Checked, Me.hid_mac.Checked, Me.hid_mainboard.Checked, Me.hid_bios.Checked, Me.hid_os.Checked)
    End Sub

    Private Sub UpdateSettings()

        Me.label_ValidLicenseAvailable.Text = ("CurrentLicense.LicenseStatus = " & StatusCheck(IntelliLock.Licensing.EvaluationMonitor.CurrentLicense.LicenseStatus))
        Me.label_LicenseServer_Enabled.Text = ("CurrentLicense.RequireLicenseServerValidation = " & IntelliLock.Licensing.EvaluationMonitor.CurrentLicense.RequireLicenseServerValidation.ToString)
        Me.label_LicenseServer.Text = ("CurrentLicense.LicenseServer = """ & IntelliLock.Licensing.EvaluationMonitor.CurrentLicense.LicenseServer & """")
        Me.label_HardwareLock_Enabled.Text = ("CurrentLicense.HardwareLock_Enabled = " & IntelliLock.Licensing.EvaluationMonitor.CurrentLicense.HardwareLock_Enabled.ToString)
        Me.label_HardwareLock_Bios.Text = ("CurrentLicense.HardwareLock_BIOS = " & IntelliLock.Licensing.EvaluationMonitor.CurrentLicense.HardwareLock_BIOS.ToString)
        Me.label_HardwareLock_OS.Text = ("CurrentLicense.HardwareLock_OS = " & IntelliLock.Licensing.EvaluationMonitor.CurrentLicense.HardwareLock_OS.ToString)
        Me.label_HardwareLock_CPU.Text = ("CurrentLicense.HardwareLock_CPU = " & IntelliLock.Licensing.EvaluationMonitor.CurrentLicense.HardwareLock_CPU.ToString)
        Me.label_HardwareLock_HDD.Text = ("CurrentLicense.HardwareLock_HDD = " & IntelliLock.Licensing.EvaluationMonitor.CurrentLicense.HardwareLock_HDD.ToString)
        Me.label_HardwareLock_MAC.Text = ("CurrentLicense.HardwareLock_MAC = " & IntelliLock.Licensing.EvaluationMonitor.CurrentLicense.HardwareLock_MAC.ToString)
        Me.label_HardwareLock_Mainboard.Text = ("CurrentLicense.HardwareLock_Mainboard = " & IntelliLock.Licensing.EvaluationMonitor.CurrentLicense.HardwareLock_Mainboard.ToString)
        Me.label_LicenseLocks_Enabled.Text = ("CurrentLicense.TrialRestricted = " & IntelliLock.Licensing.EvaluationMonitor.CurrentLicense.TrialRestricted.ToString)
        Me.label_LicenseHardwareID.Text = ("CurrentLicense.HardwareID = """ & IntelliLock.Licensing.EvaluationMonitor.CurrentLicense.HardwareID & """")
        Me.label_ExpirationDays.Text = ("CurrentLicense.ExpirationDays = " & IntelliLock.Licensing.EvaluationMonitor.CurrentLicense.ExpirationDays.ToString)
        Me.label_ExpirationDays_Current.Text = ("CurrentLicense.ExpirationDays_Current = " & IntelliLock.Licensing.EvaluationMonitor.CurrentLicense.ExpirationDays_Current.ToString)
        Me.label_ExpirationDays_Enabled.Text = ("CurrentLicense.ExpirationDays_Enabled = " & IntelliLock.Licensing.EvaluationMonitor.CurrentLicense.ExpirationDays_Enabled.ToString)
        Me.label_ExpirationDate.Text = ("CurrentLicense.ExpirationDate = " & IntelliLock.Licensing.EvaluationMonitor.CurrentLicense.ExpirationDate.ToString)
        Me.label_ExpirationDate_Enabled.Text = ("CurrentLicense.ExpirationDate_Enabled = " & IntelliLock.Licensing.EvaluationMonitor.CurrentLicense.ExpirationDate_Enabled.ToString)
        Me.label_Executions.Text = ("CurrentLicense.Executions = " & IntelliLock.Licensing.EvaluationMonitor.CurrentLicense.Executions.ToString)
        Me.label_Executions_Current.Text = ("CurrentLicense.Executions_Current = " & IntelliLock.Licensing.EvaluationMonitor.CurrentLicense.Executions_Current.ToString)
        Me.label_Executions_Enabled.Text = ("CurrentLicense.Executions_Enabled = " & IntelliLock.Licensing.EvaluationMonitor.CurrentLicense.Executions_Enabled.ToString)
        Me.label_Runtime.Text = ("CurrentLicense.Runtime = " & IntelliLock.Licensing.EvaluationMonitor.CurrentLicense.Runtime.ToString)
        Me.label_Runtime_Enabled.Text = ("CurrentLicense.Runtime_Enabled = " & IntelliLock.Licensing.EvaluationMonitor.CurrentLicense.Runtime_Enabled.ToString)
        Me.label_GlobalTime.Text = ("CurrentLicense.GlobalTime = " & IntelliLock.Licensing.EvaluationMonitor.CurrentLicense.GlobalTime.ToString)
        Me.label_GlobalTime_Current.Text = ("CurrentLicense.GlobalTime_Current = " & IntelliLock.Licensing.EvaluationMonitor.CurrentLicense.GlobalTime_Current.ToString)
        Me.label_GlobalTime_Enabled.Text = ("CurrentLicense.GlobalTime_Enabled = " & IntelliLock.Licensing.EvaluationMonitor.CurrentLicense.GlobalTime_Enabled.ToString)
        Me.label_Instances.Text = ("CurrentLicense.Instances = " & IntelliLock.Licensing.EvaluationMonitor.CurrentLicense.Instances.ToString)
        Me.label_Instances_Enabled.Text = ("CurrentLicense.Instances_Enabled = " & IntelliLock.Licensing.EvaluationMonitor.CurrentLicense.Instances_Enabled.ToString)
        Me.label_Custom_Enabled.Text = ("CurrentLicense.Custom_Enabled = " & IntelliLock.Licensing.EvaluationMonitor.CurrentLicense.Custom_Enabled.ToString)
        Me.listView1.Items.Clear()
        If ((IntelliLock.Licensing.EvaluationMonitor.CurrentLicense.LicenseStatus = IntelliLock.Licensing.LicenseStatus.EvaluationMode) OrElse (IntelliLock.Licensing.EvaluationMonitor.CurrentLicense.LicenseStatus = IntelliLock.Licensing.LicenseStatus.Licensed)) Then
            Dim i As Integer
            For i = 0 To IntelliLock.Licensing.EvaluationMonitor.CurrentLicense.LicenseInformation.Count - 1
                Me.listView1.Items.Add(New ListViewItem(New String() {IntelliLock.Licensing.EvaluationMonitor.CurrentLicense.LicenseInformation.GetKey(i).ToString, IntelliLock.Licensing.EvaluationMonitor.CurrentLicense.LicenseInformation.GetByIndex(i).ToString}))
            Next i
        End If
    End Sub

    Private Function StatusCheck(i As Integer) As String
        Select Case i
            Case 0
                Return "Not Checked"
            Case 1
                Return "Licensed"
            Case 2
                Return "Evaluation Mode"
            Case 3
                Return "Evaluation Expired"
            Case 4
                Return "License File Not Found"
            Case 5
                Return "Hardware Not Matched"
            Case 6
                Return "Invalid Signature"
            Case 7
                Return "Server Validation Failed"
            Case 8
                Return "Deactivated"
            Case 9
                Return "Reactivated"
            Case 10
                Return "Floating License User Exceeded"
            Case 11
                Return "Floating License Server Error"
            Case 12
                Return "Full Version Expired"
            Case 13
                Return "Floating License Server Timeout"
        End Select

        Return "InvalidCase"

    End Function

End Class