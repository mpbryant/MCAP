Public Class Information
    Public visibleCount As Integer = 1
    Public walkThrough As Boolean = True
    Public trainer As Boolean = False
    Public transition As Boolean



    Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click
        Me.Close()

    End Sub

    Private Sub MinimizeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MinimizeToolStripMenuItem.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub ICUToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ICUToolStripMenuItem.Click
        visibleCount = 0
        If MainForm.firstMoveComplete = False Then
            MainForm.OvalShape1.BackgroundImage = My.Resources.BCKP2
        End If

        'visibleCount 0 is used to set most lights to a default OFF mode. Used for failures such as ICU.
        MainForm.ICUfailLight.Visible = True

        MainForm.btnHFlight.Visible = False
        MainForm.btnINT2light.Visible = False
        MainForm.btnATC1light.Visible = False
        MainForm.btnATC2light.Visible = False
        MainForm.btnVU1light.Visible = False
        MainForm.btnVU2light.Visible = False
        MainForm.btnMSR1leftLight.Visible = False
        MainForm.btnMSR2leftLight.Visible = False
        MainForm.btnMSR3leftLight.Visible = False
        MainForm.btnMSR4leftLight.Visible = False
        MainForm.btnCDLleftLight.Visible = False
        MainForm.btnVOR1light.Visible = False
        MainForm.btnVOR2light.Visible = False
        MainForm.btnADFlight.Visible = False
        MainForm.btnVOR2light.Visible = False
        MainForm.btnMBlight.Visible = False
        MainForm.btnTACANlight.Visible = False
        MainForm.btnDME1light.Visible = False
        MainForm.btnDME2light.Visible = False
        MainForm.btnINT2light.Visible = False
        MainForm.btnAUXleftLight.Visible = False
        MainForm.INT2tx.Visible = False
        MainForm.ATC1tx.Visible = False
        MainForm.ATC2tx.Visible = False
        MainForm.HFtx.Visible = False
        MainForm.VU1tx.Visible = False
        MainForm.VU2tx.Visible = False
        MainForm.MSR1tx.Visible = False
        MainForm.MSR2tx.Visible = False
        MainForm.MSR3tx.Visible = False
        MainForm.MSR4tx.Visible = False
        MainForm.CDLtx.Visible = False
        MainForm.INT1tx.BackColor = Color.GreenYellow
        MainForm.BKUPtx.BackColor = Color.GreenYellow
        MainForm.btnINT1light.BackColor = Color.GreenYellow
        MainForm.lblDisplay.Text = ""

        MainForm.InfoWindow()



    End Sub

    Private Sub TrainerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TrainerToolStripMenuItem.Click

        trainer = True
        transition = True
        TrainerToolStripMenuItem.CheckState = CheckState.Checked

        walkThrough = False
        WalkthroughToolStripMenuItem.CheckState = CheckState.Unchecked


        visibleCount = 1
        MainForm.OvalShape1.BackgroundImage = My.Resources.BCKP2
        MainForm.ICUfailLight.Visible = False
        MainForm.lblDisplay.Visible = True
        MainForm.btnHFlight.Visible = True
        MainForm.btnINT2light.Visible = True
        MainForm.btnATC1light.Visible = True
        MainForm.btnATC2light.Visible = True
        MainForm.btnVU1light.Visible = True
        MainForm.btnVU2light.Visible = True
        MainForm.btnMSR1leftLight.Visible = True
        MainForm.btnMSR2leftLight.Visible = True
        MainForm.btnMSR3leftLight.Visible = True
        MainForm.btnMSR4leftLight.Visible = True
        MainForm.btnCDLleftLight.Visible = True
        MainForm.btnVOR1light.Visible = True
        MainForm.btnVOR2light.Visible = True
        MainForm.btnADFlight.Visible = True
        MainForm.btnVOR2light.Visible = True
        MainForm.btnMBlight.Visible = True
        MainForm.btnTACANlight.Visible = True
        MainForm.btnDME1light.Visible = True
        MainForm.btnDME2light.Visible = True
        MainForm.btnINT1light.Visible = True
        MainForm.btnINT2light.Visible = True
        MainForm.btnAUXleftLight.Visible = True
        MainForm.INT2tx.Visible = True
        MainForm.ATC1tx.Visible = True
        MainForm.ATC2tx.Visible = True
        MainForm.HFtx.Visible = True
        MainForm.VU1tx.Visible = True
        MainForm.VU2tx.Visible = True
        MainForm.MSR1tx.Visible = True
        MainForm.MSR2tx.Visible = True
        MainForm.MSR3tx.Visible = True
        MainForm.MSR4tx.Visible = True
        MainForm.CDLtx.Visible = True
        MainForm.INT1tx.BackColor = Color.GreenYellow
        MainForm.BKUPtx.BackColor = Color.GreenYellow
        MainForm.btnINT1light.BackColor = Color.GreenYellow



        MainForm.lblDisplay.Text = MainForm.int1val
        MainForm.OvalShape1.BackgroundImage = My.Resources.INT1
        MainForm.BKUPtx.BackColor = Color.Transparent
        MainForm.INT1tx.BackColor = Color.GreenYellow
        MainForm.INT2tx.BackColor = Color.Transparent
        MainForm.ATC1tx.BackColor = Color.Transparent
        MainForm.ATC2tx.BackColor = Color.Transparent
        MainForm.HFtx.BackColor = Color.Transparent
        MainForm.VU1tx.BackColor = Color.Transparent
        MainForm.VU2tx.BackColor = Color.Transparent
        MainForm.MSR1tx.BackColor = Color.Transparent
        MainForm.MSR2tx.BackColor = Color.Transparent
        MainForm.MSR3tx.BackColor = Color.Transparent
        MainForm.MSR4tx.BackColor = Color.Transparent
        MainForm.CDLtx.BackColor = Color.Transparent
        MainForm.btnINT1light.BackColor = Color.GreenYellow
        MainForm.btnINT2light.BackColor = Color.Transparent
        MainForm.btnATC1light.BackColor = Color.Transparent
        MainForm.btnATC2light.BackColor = Color.Transparent
        MainForm.btnHFlight.BackColor = Color.Transparent
        MainForm.btnVU1light.BackColor = Color.Transparent
        MainForm.btnVU2light.BackColor = Color.Transparent
        MainForm.btnMSR1leftLight.BackColor = Color.Transparent
        MainForm.btnMSR2leftLight.BackColor = Color.Transparent
        MainForm.btnMSR3leftLight.BackColor = Color.Transparent
        MainForm.btnMSR4leftLight.BackColor = Color.Transparent
        MainForm.btnCDLleftLight.BackColor = Color.Transparent

        MainForm.btnDME1light.BackColor = Color.Transparent
        MainForm.btnDME2light.BackColor = Color.Transparent
        MainForm.btnMBlight.BackColor = Color.Transparent
        MainForm.btnTACANlight.BackColor = Color.Transparent
        MainForm.btnVOR1light.BackColor = Color.Transparent
        MainForm.btnVOR2light.BackColor = Color.Transparent
        MainForm.btnAUXleftLight.BackColor = Color.Transparent
        MainForm.btnADFlight.BackColor = Color.Transparent
        MainForm.multiCastRecall = False
        MainForm.multiIntRecall = False




        MainForm.InfoWindow()

    End Sub

    Private Sub ModesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModesToolStripMenuItem.Click
        MainForm.viewMCAP()

    End Sub

    Private Sub ATC1BusyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ATC1BusyToolStripMenuItem.Click
        MainForm.ICUfailLight.Visible = False
        MainForm.btnHFlight.Visible = False
        MainForm.btnINT2light.Visible = False
        MainForm.btnATC1light.Visible = True
        MainForm.btnATC2light.Visible = False
        MainForm.btnVU1light.Visible = False
        MainForm.btnVU2light.Visible = False
        MainForm.btnMSR1leftLight.Visible = False
        MainForm.btnMSR2leftLight.Visible = False
        MainForm.btnMSR3leftLight.Visible = False
        MainForm.btnMSR4leftLight.Visible = False
        MainForm.btnCDLleftLight.Visible = False
        MainForm.btnVOR1light.Visible = False
        MainForm.btnVOR2light.Visible = False
        MainForm.btnADFlight.Visible = False
        MainForm.btnVOR2light.Visible = False
        MainForm.btnMBlight.Visible = False
        MainForm.btnTACANlight.Visible = False
        MainForm.btnDME1light.Visible = False
        MainForm.btnDME2light.Visible = False
        MainForm.btnINT2light.Visible = False
        MainForm.btnAUXleftLight.Visible = False
        MainForm.INT2tx.Visible = False
        MainForm.ATC1tx.Visible = True
        MainForm.ATC2tx.Visible = False
        MainForm.HFtx.Visible = False
        MainForm.VU1tx.Visible = False
        MainForm.VU2tx.Visible = False
        MainForm.MSR1tx.Visible = False
        MainForm.MSR2tx.Visible = False
        MainForm.MSR3tx.Visible = False
        MainForm.MSR4tx.Visible = False
        MainForm.CDLtx.Visible = False
        MainForm.ATC1tx.BackColor = Color.GreenYellow
        MainForm.btnATC1light.BackColor = Color.GreenYellow
        MainForm.INT1tx.BackColor = Color.Transparent
        MainForm.BKUPtx.BackColor = Color.Transparent
        MainForm.btnINT1light.BackColor = Color.Transparent
        MainForm.lblDisplay.Text = "ATC1 BUSY"
        MainForm.OvalShape1.BackgroundImage = My.Resources.ATC1

        Dim info As String

        info = "When multiple users have access to a single asset, in the case of ATC1 being available to the pilot and the copilot, sometimes both users attempts to transmit at the same time. When this happens, the user that keys that radio last will receive a busy indication on the MCAP display."
        Label1.Text = info
        Show()



    End Sub


    Private Sub WalkthroughWillToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WalkthroughToolStripMenuItem.Click


        walkThrough = True
        transition = True
            WalkthroughToolStripMenuItem.CheckState = CheckState.Checked

            trainer = False
            TrainerToolStripMenuItem.CheckState = CheckState.Unchecked




            visibleCount = 1
            MainForm.OvalShape1.BackgroundImage = My.Resources.INT1
            MainForm.ICUfailLight.Visible = False
            MainForm.lblDisplay.Visible = True
            MainForm.btnHFlight.Visible = True
            MainForm.btnINT2light.Visible = True
            MainForm.btnATC1light.Visible = True
            MainForm.btnATC2light.Visible = True
            MainForm.btnVU1light.Visible = True
            MainForm.btnVU2light.Visible = True
            MainForm.btnMSR1leftLight.Visible = True
            MainForm.btnMSR2leftLight.Visible = True
            MainForm.btnMSR3leftLight.Visible = True
            MainForm.btnMSR4leftLight.Visible = True
            MainForm.btnCDLleftLight.Visible = True
            MainForm.btnVOR1light.Visible = True
            MainForm.btnVOR2light.Visible = True
            MainForm.btnADFlight.Visible = True
            MainForm.btnVOR2light.Visible = True
            MainForm.btnMBlight.Visible = True
            MainForm.btnTACANlight.Visible = True
            MainForm.btnDME1light.Visible = True
            MainForm.btnDME2light.Visible = True
            MainForm.btnINT1light.Visible = True
            MainForm.btnINT2light.Visible = True
            MainForm.btnAUXleftLight.Visible = True
            MainForm.INT2tx.Visible = True
            MainForm.ATC1tx.Visible = True
            MainForm.ATC2tx.Visible = True
            MainForm.HFtx.Visible = True
            MainForm.VU1tx.Visible = True
            MainForm.VU2tx.Visible = True
            MainForm.MSR1tx.Visible = True
            MainForm.MSR2tx.Visible = True
            MainForm.MSR3tx.Visible = True
            MainForm.MSR4tx.Visible = True
        MainForm.CDLtx.Visible = True


            MainForm.INT1tx.BackColor = Color.GreenYellow
            MainForm.BKUPtx.BackColor = Color.Transparent
        MainForm.btnINT1light.BackColor = Color.GreenYellow


        MainForm.ForceBKUP2() 'when transitioning from trainer to walkthrough, TX select lights were staying on. This is the fix.
        MainForm.multiCastRecall = False
        MainForm.multiIntRecall = False

            MainForm.InfoWindow()

    End Sub
End Class