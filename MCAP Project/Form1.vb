Imports System.Threading




Public Class MainForm

    'DIM statements
    Dim ATCcount As Integer = 1
    Dim INTcount As Integer = 1
    Dim HFADFcount As Integer = 1
    Dim VU1count As Integer = 1
    Dim VU2count As Integer = 1
    Dim VORcount As Integer = 1
    Dim DMEcount As Integer = 1
    Dim MKRTCNcount As Integer = 1
    Dim Displaycount As Integer = 1
    Dim knobIndex As Integer = 1
    Dim i As String
    Dim j As Integer
    Dim k As String
    Dim l As String
    Dim m As Integer
    Dim CALLcount As Integer
    Dim MSR1count As Integer = 1
    Dim MODEcount As Integer = 1
    Dim MICcurrentState As String = "MIC  ON"
    Dim VOXcurrentState As String = "VOX  05"
    Dim VOXval As Integer
    Dim MVOLcurrentState As String = "MVOL 06"
    Dim MSR2count As Integer = 1
    Dim MSR3count As Integer = 1
    Dim MSR4count As Integer = 1
    Dim CDLcount As Integer = 1
    Dim AUXcount As Integer = 1
    Dim ATCstate As Integer
    Dim INTstate As Integer
    Dim HFstate As Integer
    Dim VU1state As Integer
    Dim VU2state As Integer
    Dim MSR1state As Integer
    Dim MSR2state As Integer
    Dim MSR3state As Integer
    Dim MSR4state As Integer
    Dim CDLstate As Integer
    Dim AUXstate As Integer
    Private trd As Thread
    Dim MVOLval As String = "MVOL 06"
    Dim ATC1val As String = "ATC1 05"
    Dim ATC2val As String = "ATC2 05"
    Dim HFval As String = "HF   05"
    Dim ADFval As String = "ADF  05"
    Dim VU1val As String = "VU1  05"
    Dim VU2val As String = "VU2  05"
    Dim VOR1val As String = "VOR1 05"
    Dim VOR2val As String = "VOR2 05"
    Dim MKRval As String = "MKR  05"
    Dim TCNval As String = "TCN  05"
    Dim DME1val As String = "DME1 05"
    Dim DME2val As String = "DME2 05"
    Public INT1val As String = "INT1 05"
    Dim INT2val As String = "INT2 05"
    Dim MSR1val As String = "MSR1 05"
    Dim MSR2val As String = "MSR2 05"
    Dim MSR3val As String = "MSR3 05"
    Dim MSR4val As String = "MSR4 05"
    Dim CDLval As String = "CDL  05"
    Dim AUXval As String = "AUX  05"
    Dim ATC1ATC2 As String = "ATC  0505"
    Dim HFDF As String = "HFDF 0505"
    Dim VOR1VOR2 As String = "VOR  0505"
    Dim MKRTCN As String = "MKTN 0505"
    Dim DME1DME2 As String = "DME  0505"
    Dim INT1INT2 As String = "INT  0505"
    Dim threadCount As Integer = 0
    Dim timeDelayCount As Integer = 1
    Dim timeDelayCountHigh As Integer = 5
    Dim pressNum As Integer = 0
    Dim timeStart As Integer = 0
    Dim timeEnd As Integer
    Dim formIsClosed As Boolean = False
    Dim naptime As Integer
    Public multiCastMode As Boolean = False
    Dim BKUPtxState As Boolean = False
    Dim INT1txState As Boolean = False
    Dim INT2txState As Boolean = False
    Dim ATC1txState As Boolean = False
    Dim ATC2txState As Boolean = False
    Dim HFtxState As Boolean = False
    Dim VU1txState As Boolean = False
    Dim VU2txState As Boolean = False
    Dim MSR1txState As Boolean = False
    Dim MSR2txState As Boolean = False
    Dim MSR3txState As Boolean = False
    Dim MSR4txState As Boolean = False
    Dim CDLtxState As Boolean = False
    Dim ADFState As Integer
    Dim MKRState As Integer
    Dim TCNState As Integer
    Dim DME1State As Integer
    Dim DME2State As Integer
    Dim VOR1State As Integer
    Dim VOR2State As Integer
    Dim selectTX As Boolean = False
    Dim LoopCount As Integer = 0
    Public imageLoaded As String = "INT1"
    Dim multRXlight As Boolean = True
    Public firstMoveComplete As Boolean = False
    Public multiINTmode As Boolean = False
    Public multiCastRecall As Boolean = False
    Public multiIntRecall As Boolean = False
    Dim firstClick As Boolean = True



    'for StaticLightTest()
    Dim INT1Condition As Boolean = False
    Dim INT2Condition As Boolean = False
    Dim INTRecall As Integer
    Dim ATC1Condition As Boolean = False
    Dim ATC2Condition As Boolean = False
    Dim ATCRecall As Integer
    Dim HFCondition As Boolean = False
    Dim ADFCondition As Boolean = False
    Dim HFDFRecall As Integer

    Dim forcedBKUPcount As Integer = 0
    Dim delayLength As Integer = 5 'used to determine how long the display takes to revert to MVOL

    'For moving form that does nothave borders
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer

    Dim alpha As Double = 0.5 'initial dimmer setting

    Dim ld1 As New LightDimmer
    Dim ld2 As New LightDimmer
    Dim ld3 As New LightDimmer
    Dim ld4 As New LightDimmer
    Dim ld5 As New LightDimmer
    Dim ld6 As New LightDimmer
    Dim ld7 As New LightDimmer
    Dim ld8 As New LightDimmer
    Dim ld9 As New LightDimmer
    Dim ld10 As New LightDimmer

    Dim ld11 As New LightDimmer
    Dim ld12 As New LightDimmer
    Dim ld13 As New LightDimmer
    Dim ld14 As New LightDimmer
    Dim ld15 As New LightDimmer
    Dim ld16 As New LightDimmer
    Dim ld17 As New LightDimmer
    Dim ld18 As New LightDimmer
    Dim ld19 As New LightDimmer
    Dim ld20 As New LightDimmer

    Dim ld21 As New LightDimmer
    Dim ld22 As New LightDimmer
    Dim ld23 As New LightDimmer
    Dim ld24 As New LightDimmer
    Dim ld25 As New LightDimmer

    Dim ld31 As New LightDimmer
    Dim ld32 As New LightDimmer
    Dim ld33 As New LightDimmer
    Dim ld34 As New LightDimmer
    Dim ld35 As New LightDimmer
    Dim ld36 As New LightDimmer
    Dim ld37 As New LightDimmer
    Dim ld38 As New LightDimmer
    Dim ld39 As New LightDimmer
    Dim ld40 As New LightDimmer
    Dim ld41 As New LightDimmer
    Dim ld42 As New LightDimmer
    Dim ld43 As New LightDimmer

    Public xoffset As Integer = 0
    Public yoffset As Integer = 0

    Dim sideWidth As Integer = 8
    Dim topHeight As Integer = 24




    'Buttons
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles btnInt12.Click



        Dim info As String
        If INT1tx.BackColor = Color.GreenYellow And INT2tx.BackColor = Color.GreenYellow Then
            lblDisplay.Text = INT1INT2
        Else

            If imageLoaded = "INT1" And INT1tx.BackColor = Color.GreenYellow Then
                ButtonPressWhenKnobSelectEqualsINT1()
            ElseIf imageLoaded = "INT2" And INT2tx.BackColor = Color.GreenYellow Then
                ButtonPressWhenKnobSelectEqualsINT2()
            ElseIf (imageLoaded = "INT1" Or imageLoaded = "INT2") And INT1tx.BackColor = Color.Transparent And INT2tx.BackColor = Color.Transparent Then

                If lblDisplay.Text <> "" Then   'In BKUP the display will be blank. This wraps the code to test that status


                    'begin test of pushbutton. If button has been pushed within the last five seconds, this will allow the button to sequence to the next selection. If the button has reverted to MVOL, the next button push will not sequence to the next selection. It will only display the current volume settings and setup the program to advance on the next button push.


                    If lblDisplay.Text.Substring(0, 3) = "INT" Then
                    Else
                        INTcount = INTcount - 1
                    End If


                    If INTcount = 0 Then
                        INTcount = 1
                    End If
                    'end pushbutton test 

                    'If INT1tx.BackColor = Color.GreenYellow Then    'tests to see if the INT1tx light is active
                    '    ButtonPressWhenKnobSelectEqualsINT1()       'switches only INT2 light

                    'End If

                    'If INT2tx.BackColor = Color.GreenYellow Then    'tests to see if the INT2tx light is active
                    '    ButtonPressWhenKnobSelectEqualsINT2()        'switches only INT1 light
                    'End If


                    If INT1tx.BackColor <> Color.GreenYellow Then       'if neither tx light is on we switch normally
                        If INT2tx.BackColor <> Color.GreenYellow Then

                            If INTcount = 1 Then
                                btnINT1light.BackColor = Color.GreenYellow
                                INT1Condition = True
                                INT2Condition = False


                                info = "Pressing the INT1/2 button once will activate the INT1 audio. The display shows INT1 05 indicating that INT1 audio is active and the volume level is set to 05. Volume for intercom 1 can be adjusted from 00 to 09 using the up/down arrows. After five seconds the display will revert back to the master volume control (MVOL)."
                                Information.Label1.Text = info
                                Information.Show()
                                lblDisplay.Text = INT1val

                            ElseIf INTcount = 2 Then
                                btnINT1light.BackColor = Color.Transparent
                                btnINT2light.BackColor = Color.GreenYellow
                                INT1Condition = False
                                INT2Condition = True

                                info = "The second press switches to INT2. The volume controls work the same way and are independent from the INT1 audio level. This allows the user to set an audio level that is comfortable for them. After five seconds the display will revert back to the master volume control (MVOL)."
                                Information.Label1.Text = info
                                Information.Show()
                                lblDisplay.Text = INT2val

                            ElseIf INTcount = 3 Then

                                btnINT2light.BackColor = Color.GreenYellow
                                btnINT1light.BackColor = Color.GreenYellow
                                INT1Condition = True
                                INT2Condition = True

                                info = "The 3rd press connects to both intercoms. Notice that the data in the display has changed. It now shows the volume levels for both radios. Pressing the up arrow will increase the volumes together until the radios reach their maximum volume. If one volume reaches the limit first, it will stop increasing while the other volume continues to rise. Decreasing the volume works the same way. After five seconds the display will revert back to the master volume control (MVOL)."
                                Information.Label1.Text = info
                                Information.Show()
                                lblDisplay.Text = INT1INT2

                            ElseIf INTcount = 4 Then
                                btnINT1light.BackColor = Color.Transparent
                                btnINT2light.BackColor = Color.Transparent
                                INT1Condition = False
                                INT2Condition = False

                                info = "The 4th press deselects both radios."
                                Information.Label1.Text = info
                                Information.Show()
                                lblDisplay.Text = MVOLval

                                INTcount = 0   'resets the counter
                            End If
                        End If
                    End If

                    INTstate = INTcount


                    INTcount = INTcount + 1
                    ReloadLights()
                End If




            ElseIf multiINTmode = True Then
                ButtonPressWhenHeldINT1()
                ButtonPressWhenHeldINT2()
            Else

                If lblDisplay.Text <> "" Then   'In BKUP the display will be blank. This wraps the code to test that status


                    'begin test of pushbutton. If button has been pushed within the last five seconds, this will allow the button to sequence to the next selection. If the button has reverted to MVOL, the next button push will not sequence to the next selection. It will only display the current volume settings and setup the program to advance on the next button push.


                    If lblDisplay.Text.Substring(0, 3) = "INT" Then
                    Else
                        INTcount = INTcount - 1
                    End If


                    If INTcount = 0 Then
                        INTcount = 1
                    End If
                    'end pushbutton test 

                    If INT1tx.BackColor = Color.GreenYellow Then    'tests to see if the INT1tx light is active
                        ButtonPressWhenKnobSelectEqualsINT1()       'switches only INT2 light

                    End If

                    If INT2tx.BackColor = Color.GreenYellow Then    'tests to see if the INT2tx light is active
                        ButtonPressWhenKnobSelectEqualsINT2()        'switches only INT1 light
                    End If


                    If INT1tx.BackColor <> Color.GreenYellow Then       'if neither tx light is on we switch normally
                        If INT2tx.BackColor <> Color.GreenYellow Then

                            If INTcount = 1 Then
                                btnINT1light.BackColor = Color.GreenYellow
                                INT1Condition = True
                                INT2Condition = False


                                info = "Pressing the INT1/2 button once will activate the INT1 audio. The display shows INT1 05 indicating that INT1 audio is active and the volume level is set to 05. Volume for intercom 1 can be adjusted from 00 to 09 using the up/down arrows. After five seconds the display will revert back to the master volume control (MVOL)."
                                Information.Label1.Text = info
                                Information.Show()
                                lblDisplay.Text = INT1val

                            ElseIf INTcount = 2 Then
                                btnINT1light.BackColor = Color.Transparent
                                btnINT2light.BackColor = Color.GreenYellow
                                INT1Condition = False
                                INT2Condition = True

                                info = "The second press switches to INT2. The volume controls work the same way and are independent from the INT1 audio level. This allows the user to set an audio level that is comfortable for them. After five seconds the display will revert back to the master volume control (MVOL)."
                                Information.Label1.Text = info
                                Information.Show()
                                lblDisplay.Text = INT2val

                            ElseIf INTcount = 3 Then

                                btnINT2light.BackColor = Color.GreenYellow
                                btnINT1light.BackColor = Color.GreenYellow
                                INT1Condition = True
                                INT2Condition = True

                                info = "The 3rd press connects to both intercoms. Notice that the data in the display has changed. It now shows the volume levels for both radios. Pressing the up arrow will increase the volumes together until the radios reach their maximum volume. If one volume reaches the limit first, it will stop increasing while the other volume continues to rise. Decreasing the volume works the same way. After five seconds the display will revert back to the master volume control (MVOL)."
                                Information.Label1.Text = info
                                Information.Show()
                                lblDisplay.Text = INT1INT2

                            ElseIf INTcount = 4 Then
                                btnINT1light.BackColor = Color.Transparent
                                btnINT2light.BackColor = Color.Transparent
                                INT1Condition = False
                                INT2Condition = False

                                info = "The 4th press deselects both radios."
                                Information.Label1.Text = info
                                Information.Show()
                                lblDisplay.Text = MVOLval

                                INTcount = 0   'resets the counter
                            End If
                        End If
                    End If

                    INTstate = INTcount

                    If imageLoaded = "INT1" Then
                        btnINT1light.BackColor = Color.GreenYellow
                    End If

                    If imageLoaded = "INT2" Then
                        btnINT2light.BackColor = Color.GreenYellow
                    End If

                    INTcount = INTcount + 1
                    ReloadLights()
                End If

            End If

        End If

    End Sub
    Private Sub btnATC12_Click(sender As Object, e As EventArgs) Handles btnATC12.Click

        Dim info As String

        If imageLoaded = "ATC1" Then
            ButtonPressWhenKnobSelectEqualsATC1()
        ElseIf imageLoaded = "ATC2" Then
            ButtonPressWhenKnobSelectEqualsATC2()
        ElseIf multiCastMode = True And ATC1tx.BackColor = Color.GreenYellow Then
            ButtonPressWhenHeldATC1()
        ElseIf multiCastMode = True And ATC2tx.BackColor = Color.GreenYellow Then
            ButtonPressWhenHeldATC2()
            'MultiCastToggle()
        Else
            If lblDisplay.Text <> "" Then   'In BKUP the display will be blank. This wraps the code to test that status

                If lblDisplay.Text.Substring(0, 3) <> "ATC" Then
                    ATCcount = ATCcount - 1
                End If
                If ATCcount = 0 Then
                    ATCcount = 1
                End If

                If ATCcount = 1 Then
                    btnATC1light.BackColor = Color.GreenYellow
                    ATCstate = 1

                End If


                If ATC1tx.BackColor = Color.GreenYellow Then    'tests to see if the ATC1tx light is active
                    ButtonPressWhenKnobSelectEqualsATC1()       'switches only ATC2 light

                End If

                If ATC2tx.BackColor = Color.GreenYellow Then    'tests to see if the ATC2tx light is active
                    ButtonPressWhenKnobSelectEqualsATC2()        'switches only ATC1 light
                End If


                If ATC1tx.BackColor <> Color.GreenYellow Then       'if neither tx light is on we switch normally
                    If ATC2tx.BackColor <> Color.GreenYellow Then





                        If ATCcount = 1 Then   'count 1 = ATC1 on
                            btnATC1light.BackColor = Color.GreenYellow
                            ATC1Condition = True
                            ATC2Condition = False
                            lblDisplay.Text = ATC1val

                            info = "Pressing the ATC 1/2 radio button once will activate the ATC1 radio audio. Notice the light at the top left of the ATC button is on and the display shows ATC1 05 indicating that ATC1 audio is active and the volume level is set to 05. Volume for that radio can be adjusted from 00 to 09 using the up/down arrows as long as the display shows ATC1. Adjust the volume to any level you wish using the up/down buttons. After five seconds the display will revert back to the master volume control (MVOL). Notice the MVOL level is where you set it. Press the ATC1/2 button once and you will see the ATC1 volume level is where you set it as well. Pressing a receiver button while the display shows MVOL will change the display to the selected receiver audio level. If no receivers are active, the first button push will activate the receivers audio. Press the ATC1/2 button again while ATC1 is displayed."
                            Information.Label1.Text = info
                            Information.Show()


                        ElseIf ATCcount = 2 Then   'count 2 = ATC2 on
                            btnATC2light.BackColor = Color.GreenYellow
                            btnATC1light.BackColor = Color.Transparent
                            ATC1Condition = False
                            ATC2Condition = True
                            lblDisplay.Text = ATC2val

                            info = "The second press switches to the ATC2 radio. The volume controls work the same way and are independent from the ATC1 audio level. This allows the user to set an audio level that is comfortable for them. After five seconds the display will revert back to the master volume control (MVOL). Remember, if you want to adjust an individual receiver audio level and MVOL is displayed, press the receiver button to show the receiver audio level and then adjust the volume. While ATC2 is displayed, press the ATC1/2 button again. If the display has reverted back to MVOL, simply press the receiver button once to display the receiver audio level and press again to transition to the next receiver selection."
                            Information.Label1.Text = info
                            Information.Show()


                        ElseIf ATCcount = 3 Then   'count 3 = ATC1 and 2 on

                            btnATC2light.BackColor = Color.GreenYellow
                            btnATC1light.BackColor = Color.GreenYellow
                            ATC1Condition = True
                            ATC2Condition = True
                            lblDisplay.Text = ATC1ATC2


                            info = "The 3rd press connects to both receivers. Notice that the data in the display has changed. It now shows the volume levels for both radios. Pressing the up arrow will increase the volumes together until the radios reach their maximum volume. If one volume reaches the limit first, it will stop increasing while the other volume continues to rise. Decreasing the volume works the same way. After five seconds the display will revert back to the master volume control (MVOL).Press the ATC1/2 once (twice if MVOL is displayed)."
                            Information.Label1.Text = info
                            Information.Show()

                        ElseIf ATCcount = 4 Then   'count 4 equals no lights

                            btnATC2light.BackColor = Color.Transparent
                            btnATC1light.BackColor = Color.Transparent
                            ATC1Condition = False
                            ATC2Condition = False
                            lblDisplay.Text = MVOLval

                            info = "The 4th press deselects both radios. The HF/ADF, VOR 1/2, MKR/TCN, DME 1/2, INT 1/2 buttons all work the same as the ATC 1/2 button. Press the VU 1 button to continue."
                            Information.Label1.Text = info
                            Information.Show()

                            ATCcount = 0   'resets the counter
                        End If
                    End If
                End If

                ATCstate = ATCcount

                If imageLoaded = "ATC1" Then
                    btnATC1light.BackColor = Color.GreenYellow
                End If
                If imageLoaded = "ATC2" Then
                    btnATC2light.BackColor = Color.GreenYellow
                End If

                'If naptime >= 5 Then
                If lblDisplay.Text.Substring(0, 3) <> "ATC" Then ' removed naptime in favor of this code due to intermittent ATC switching caused by naptime delay issue
                    If ATCcount <> 0 Then
                        ATCcount = ATCcount - 1
                    End If
                End If

                ATCcount = ATCcount + 1

                ReloadLights()
            End If


            'End If

        End If
        'End If
    End Sub
    Private Sub btnHFADF_Click(sender As Object, e As EventArgs) Handles btnHFADF.Click
        Dim info As String


        If imageLoaded = "HF" And HFtx.BackColor = Color.GreenYellow Then
            ButtonPressWhenKnobSelectEqualsHF()
        ElseIf multiCastMode = True And HFtx.BackColor = Color.GreenYellow Then
            ButtonPressWhenHeldHF()
        ElseIf HFtx.BackColor = Color.Transparent Then
            If lblDisplay.Text <> "" Then   'In BKUP the display will be blank. This wraps the code to test that status


                'begin test of pushbutton. If button has been pushed within the last five seconds, this will allow the button to sequence to the next selection. If the button has reverted to MVOL, the next button push will not sequence to the next selection. It will only display the current volume settings and setup the program to advance on the next button push.
                If lblDisplay.Text.Substring(0, 3) = "HF " Then
                ElseIf lblDisplay.Text.Substring(0, 3) = "ADF" Then
                ElseIf lblDisplay.Text.Substring(0, 3) = "HFD" Then
                Else
                    HFADFcount = HFADFcount - 1
                End If
                If HFADFcount = 0 Then
                    HFADFcount = 1
                End If
                'end pushbutton test 


                If HFtx.BackColor = Color.GreenYellow Then
                    ButtonPressWhenKnobSelectEqualsHF()
                Else

                    If HFADFcount = 1 Then
                        btnHFlight.BackColor = Color.GreenYellow
                        ADFState = 0
                        HFstate = 1

                        info = "Pressing the HF/ADF radio button once will activate the HF radio audio. The display shows HF 05 indicating that HF audio is active and the volume level is set to 05. Volume for that radio can be adjusted from 00 to 09 using the up/down arrows. After five seconds the display will revert back to the master volume control (MVOL)."
                        Information.Label1.Text = info
                        Information.Show()
                        lblDisplay.Text = HFval

                    ElseIf HFADFcount = 2 Then
                        btnADFlight.BackColor = Color.GreenYellow
                        btnHFlight.BackColor = Color.Transparent
                        ADFState = 1
                        HFstate = 0

                        info = "The second press switches to the ADF radio. The volume controls work the same way and are independent from the ADF audio level. This allows the user to set an audio level that is comfortable for them. After five seconds the display will revert back to the master volume control (MVOL)."
                        Information.Label1.Text = info
                        Information.Show()
                        lblDisplay.Text = ADFval

                    ElseIf HFADFcount = 3 Then

                        btnADFlight.BackColor = Color.GreenYellow
                        btnHFlight.BackColor = Color.GreenYellow
                        ADFState = 1
                        HFstate = 1

                        info = "The 3rd press connects to both radios. Notice that the data in the display has changed. It now shows the volume levels for both radios. Pressing the up arrow will increase the volumes together until the radios reach their maximum volume. If one volume reaches the limit first, it will stop increasing while the other volume continues to rise. Decreasing the volume works the same way. After five seconds the display will revert back to the master volume control (MVOL)."
                        Information.Label1.Text = info
                        Information.Show()
                        lblDisplay.Text = HFDF

                    ElseIf HFADFcount = 4 Then

                        btnADFlight.BackColor = Color.Transparent
                        btnHFlight.BackColor = Color.Transparent
                        ADFState = 0
                        HFstate = 0

                        info = "The 4th press deselects both radios."
                        Information.Label1.Text = info
                        Information.Show()
                        lblDisplay.Text = MVOLval

                        HFADFcount = 0   'resets the counter
                    End If
                    HFstate = HFADFcount
                    'If imageLoaded = "HF" Then
                    '    btnHFlight.BackColor = Color.GreenYellow
                    'End If
                    HFADFcount = HFADFcount + 1
                    ReloadLights()

                End If
            End If




        Else
            If lblDisplay.Text <> "" Then   'In BKUP the display will be blank. This wraps the code to test that status


                'begin test of pushbutton. If button has been pushed within the last five seconds, this will allow the button to sequence to the next selection. If the button has reverted to MVOL, the next button push will not sequence to the next selection. It will only display the current volume settings and setup the program to advance on the next button push.
                If lblDisplay.Text.Substring(0, 3) = "HF " Then
                ElseIf lblDisplay.Text.Substring(0, 3) = "ADF" Then
                ElseIf lblDisplay.Text.Substring(0, 3) = "HFD" Then
                Else
                    HFADFcount = HFADFcount - 1
                End If
                If HFADFcount = 0 Then
                    HFADFcount = 1
                End If
                'end pushbutton test 


                If HFtx.BackColor = Color.GreenYellow Then
                    ButtonPressWhenKnobSelectEqualsHF()
                Else

                    If HFADFcount = 1 Then
                        btnHFlight.BackColor = Color.GreenYellow
                        ADFState = 0
                        HFstate = 1

                        info = "Pressing the HF/ADF radio button once will activate the HF radio audio. The display shows HF 05 indicating that HF audio is active and the volume level is set to 05. Volume for that radio can be adjusted from 00 to 09 using the up/down arrows. After five seconds the display will revert back to the master volume control (MVOL)."
                        Information.Label1.Text = info
                        Information.Show()
                        lblDisplay.Text = HFval

                    ElseIf HFADFcount = 2 Then
                        btnADFlight.BackColor = Color.GreenYellow
                        btnHFlight.BackColor = Color.Transparent
                        ADFState = 1
                        HFstate = 0

                        info = "The second press switches to the ADF radio. The volume controls work the same way and are independent from the ADF audio level. This allows the user to set an audio level that is comfortable for them. After five seconds the display will revert back to the master volume control (MVOL)."
                        Information.Label1.Text = info
                        Information.Show()
                        lblDisplay.Text = ADFval

                    ElseIf HFADFcount = 3 Then

                        btnADFlight.BackColor = Color.GreenYellow
                        btnHFlight.BackColor = Color.GreenYellow
                        ADFState = 1
                        HFstate = 1

                        info = "The 3rd press connects to both radios. Notice that the data in the display has changed. It now shows the volume levels for both radios. Pressing the up arrow will increase the volumes together until the radios reach their maximum volume. If one volume reaches the limit first, it will stop increasing while the other volume continues to rise. Decreasing the volume works the same way. After five seconds the display will revert back to the master volume control (MVOL)."
                        Information.Label1.Text = info
                        Information.Show()
                        lblDisplay.Text = HFDF

                    ElseIf HFADFcount = 4 Then

                        btnADFlight.BackColor = Color.Transparent
                        btnHFlight.BackColor = Color.Transparent
                        ADFState = 0
                        HFstate = 0

                        info = "The 4th press deselects both radios."
                        Information.Label1.Text = info
                        Information.Show()
                        lblDisplay.Text = MVOLval

                        HFADFcount = 0   'resets the counter
                    End If
                    HFstate = HFADFcount
                    If imageLoaded = "HF" Then
                        btnHFlight.BackColor = Color.GreenYellow
                    End If
                    HFADFcount = HFADFcount + 1
                    ReloadLights()

                End If
            End If

        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnVU1.Click
        Dim info As String

        If imageLoaded = "VU1" And VU1tx.BackColor = Color.GreenYellow Then
            lblDisplay.Text = VU1val
        ElseIf imageLoaded = "VU1" And VU1tx.BackColor = Color.Transparent Then

            If lblDisplay.Text <> "" Then   'In BKUP the display will be blank. This wraps the code to test that status

                'begin test of pushbutton. If button has been pushed within the last five seconds, this will allow the button to sequence to the next selection. If the button has reverted to MVOL, the next button push will not sequence to the next selection. It will only display the current volume settings and setup the program to advance on the next button push.
                If lblDisplay.Text.Substring(0, 3) = "VU1" Then
                Else
                    VU1count = VU1count - 1
                End If
                If VU1count = 0 Then
                    VU1count = 1
                End If
                'end pushbutton test 

                If VU1count = 1 Then
                    btnVU1light.BackColor = Color.GreenYellow

                    info = "Pressing the VHF1/UHF1 radio button once will activate the VU1 radio audio. The display shows VU1 05 for five seconds indicating that VU1 audio is active and the volume level is set to 05. Volume for that radio can be adjusted from 00 to 09 using the up/down arrows while the display indicates VU1. After five seconds the display will revert back to the master volume control (MVOL). Press the VU1 button again (twice if MVOL is displayed)."
                    Information.Label1.Text = info
                    Information.Show()
                    lblDisplay.Text = VU1val

                ElseIf VU1count = 2 Then
                    'btnVU1Slight.BackColor = Color.GreenYellow
                    btnVU1light.BackColor = Color.Transparent

                    info = "The second press deactivates the VU1 audio. The VU1, VU2, MSR1, MSR2, MSR3, MSR4, AUX and CDL buttons all work the same as the VU1 button. Press the MODE button to continue."
                    Information.Label1.Text = info
                    Information.Show()
                    lblDisplay.Text = MVOLval

                    VU1count = 0   'resets the counter
                End If
                VU1state = VU1count
                VU1count = VU1count + 1
                ReloadLights()

            End If

        Else
            If multiCastMode = True And VU1tx.BackColor = Color.GreenYellow Then
                lblDisplay.Text = VU1val
            Else

                If lblDisplay.Text <> "" Then   'In BKUP the display will be blank. This wraps the code to test that status

                    'begin test of pushbutton. If button has been pushed within the last five seconds, this will allow the button to sequence to the next selection. If the button has reverted to MVOL, the next button push will not sequence to the next selection. It will only display the current volume settings and setup the program to advance on the next button push.
                    If lblDisplay.Text.Substring(0, 3) = "VU1" Then
                    Else
                        VU1count = VU1count - 1
                    End If
                    If VU1count = 0 Then
                        VU1count = 1
                    End If
                    'end pushbutton test 

                    If VU1count = 1 Then
                        btnVU1light.BackColor = Color.GreenYellow

                        info = "Pressing the VHF1/UHF1 radio button once will activate the VU1 radio audio. The display shows VU1 05 for five seconds indicating that VU1 audio is active and the volume level is set to 05. Volume for that radio can be adjusted from 00 to 09 using the up/down arrows while the display indicates VU1. After five seconds the display will revert back to the master volume control (MVOL). Press the VU1 button again (twice if MVOL is displayed)."
                        Information.Label1.Text = info
                        Information.Show()
                        lblDisplay.Text = VU1val

                    ElseIf VU1count = 2 Then
                        'btnVU1Slight.BackColor = Color.GreenYellow
                        btnVU1light.BackColor = Color.Transparent

                        info = "The second press deactivates the VU1 audio. The VU1, MSR1, MSR2, MSR3, MSR4, AUX and CDL buttons all work the same as the VU1 button. Press the MODE button to continue."
                        Information.Label1.Text = info
                        Information.Show()
                        lblDisplay.Text = MVOLval

                        VU1count = 0   'resets the counter
                    End If
                    VU1state = VU1count
                    If imageLoaded = "VU1" Then
                        btnVU1light.BackColor = Color.GreenYellow
                    End If
                    VU1count = VU1count + 1
                    ReloadLights()

                End If
            End If
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnVU2.Click
        Dim info As String

        If imageLoaded = "VU2" And VU2tx.BackColor = Color.GreenYellow Then
            lblDisplay.Text = VU2val
        ElseIf imageLoaded = "VU2" And VU2tx.BackColor = Color.Transparent Then

            If lblDisplay.Text <> "" Then   'In BKUP the display will be blank. This wraps the code to test that status

                'begin test of pushbutton. If button has been pushed within the last five seconds, this will allow the button to sequence to the next selection. If the button has reverted to MVOL, the next button push will not sequence to the next selection. It will only display the current volume settings and setup the program to advance on the next button push.
                If lblDisplay.Text.Substring(0, 3) = "VU2" Then
                Else
                    VU2count = VU2count - 1
                End If
                If VU2count = 0 Then
                    VU2count = 1
                End If
                'end pushbutton test 

                If VU2count = 1 Then
                    btnVU2light.BackColor = Color.GreenYellow

                    info = "Pressing the VHF2/UHF2 radio button once will activate the VU2 radio audio. The display shows VU2 05 for five seconds indicating that VU2 audio is active and the volume level is set to 05. Volume for that radio can be adjusted from 00 to 09 using the up/down arrows while the display indicates VU2. After five seconds, the display will revert to the master volume adjustment (MVOL)."
                    Information.Label1.Text = info
                    Information.Show()
                    lblDisplay.Text = VU2val

                ElseIf VU2count = 2 Then
                    btnVU2light.BackColor = Color.Transparent

                    info = "The second press deactivates the audio."
                    Information.Label1.Text = info
                    Information.Show()
                    lblDisplay.Text = MVOLval

                    VU2count = 0   'resets the counter
                End If
                VU2state = VU2count
                VU2count = VU2count + 1
                ReloadLights()

            End If


        Else
            If multiCastMode = True And VU2tx.BackColor = Color.GreenYellow Then
                lblDisplay.Text = VU2val
            Else

                If lblDisplay.Text <> "" Then   'In BKUP the display will be blank. This wraps the code to test that status

                    'begin test of pushbutton. If button has been pushed within the last five seconds, this will allow the button to sequence to the next selection. If the button has reverted to MVOL, the next button push will not sequence to the next selection. It will only display the current volume settings and setup the program to advance on the next button push.
                    If lblDisplay.Text.Substring(0, 3) = "VU2" Then
                    Else
                        VU2count = VU2count - 1
                    End If
                    If VU2count = 0 Then
                        VU2count = 1
                    End If
                    'end pushbutton test 

                    If VU2count = 1 Then
                        btnVU2light.BackColor = Color.GreenYellow

                        info = "Pressing the VHF2/UHF2 radio button once will activate the VU2 radio audio. The display shows VU2 05 for five seconds indicating that VU2 audio is active and the volume level is set to 05. Volume for that radio can be adjusted from 00 to 09 using the up/down arrows while the display indicates VU2. After five seconds, the display will revert to the master volume adjustment (MVOL)."
                        Information.Label1.Text = info
                        Information.Show()
                        lblDisplay.Text = VU2val

                    ElseIf VU2count = 2 Then
                        btnVU2light.BackColor = Color.Transparent

                        info = "The second press deactivates the audio."
                        Information.Label1.Text = info
                        Information.Show()
                        lblDisplay.Text = MVOLval

                        VU2count = 0   'resets the counter
                    End If
                    VU2state = VU2count
                    If imageLoaded = "VU2" Then
                        btnVU2light.BackColor = Color.GreenYellow
                    End If
                    VU2count = VU2count + 1
                    ReloadLights()

                End If
            End If
        End If

    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnVOR12.Click
        Dim info As String

        If lblDisplay.Text <> "" Then   'In BKUP the display will be blank. This wraps the code to test that status

            'begin test of pushbutton. If button has been pushed within the last five seconds, this will allow the button to sequence to the next selection. If the button has reverted to MVOL, the next button push will not sequence to the next selection. It will only display the current volume settings and setup the program to advance on the next button push.
            If lblDisplay.Text.Substring(0, 3) = "VOR" Then
            Else
                VORcount = VORcount - 1
            End If
            If VORcount = 0 Then
                VORcount = 1
            End If
            'end pushbutton test 

            If VORcount = 1 Then
                btnVOR1light.BackColor = Color.GreenYellow
                VOR1State = 1
                VOR2State = 0


                info = "Pressing the VOR1/2 radio button once will activate the VOR1 radio audio. The display shows VOR1 05 indicating that VOR1 audio is active and the volume level is set to 05. Volume for that radio can be adjusted from 00 to 09 using the up/down arrows. After five seconds the display will revert back to the master volume control (MVOL)."
                Information.Label1.Text = info
                Information.Show()
                lblDisplay.Text = VOR1val

            ElseIf VORcount = 2 Then
                btnVOR2light.BackColor = Color.GreenYellow
                btnVOR1light.BackColor = Color.Transparent
                VOR1State = 0
                VOR2State = 1

                info = "The second press switches to the VOR2 radio. The volume controls work the same way and are independent from the VOR1 audio level. This allows the user to set an audio level that is comfortable for them. After five seconds the display will revert back to the master volume control (MVOL)."
                Information.Label1.Text = info
                Information.Show()
                lblDisplay.Text = VOR2val

            ElseIf VORcount = 3 Then

                btnVOR2light.BackColor = Color.GreenYellow
                btnVOR1light.BackColor = Color.GreenYellow
                VOR1State = 1
                VOR2State = 1

                info = "The 3rd press connects to both radios. Notice that the data in the display has changed. It now shows the volume levels for both radios. Pressing the up arrow will increase the volumes together until the radios reach their maximum volume. If one volume reaches the limit first, it will stop increasing while the other volume continues to rise. Decreasing the volume works the same way. After five seconds the display will revert back to the master volume control (MVOL)."
                Information.Label1.Text = info
                Information.Show()
                lblDisplay.Text = VOR1VOR2

            ElseIf VORcount = 4 Then

                btnVOR2light.BackColor = Color.Transparent
                btnVOR1light.BackColor = Color.Transparent
                VOR1State = 0
                VOR2State = 0

                info = "The 4th press deselects both radios."
                Information.Label1.Text = info
                Information.Show()
                lblDisplay.Text = MVOLval

                VORcount = 0   'resets the counter
            End If
            VORcount = VORcount + 1

        End If

    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles btnMKRTCN.Click
        Dim info As String

        If lblDisplay.Text <> "" Then   'In BKUP the display will be blank. This wraps the code to test that status

            'begin test of pushbutton. If button has been pushed within the last five seconds, this will allow the button to sequence to the next selection. If the button has reverted to MVOL, the next button push will not sequence to the next selection. It will only display the current volume settings and setup the program to advance on the next button push.
            If lblDisplay.Text.Substring(0, 3) = "MKR" Then
            ElseIf lblDisplay.Text.Substring(0, 3) = "TCN" Then
            ElseIf lblDisplay.Text.Substring(0, 3) = "MKT" Then
            Else
                MKRTCNcount = MKRTCNcount - 1
            End If
            If MKRTCNcount = 0 Then
                MKRTCNcount = 1
            End If
            'end pushbutton test 

            If MKRTCNcount = 1 Then
                btnMBlight.BackColor = Color.GreenYellow
                MKRState = 1
                TCNState = 0


                info = "Pressing the MKR/TCN radio button once will activate the Marker Beacon audio. The display shows MKR 05 indicating that Marker Beacon audio is active and the volume level is set to 05. Volume for that radio can be adjusted from 00 to 09 using the up/down arrows. After five seconds the display will revert back to the master volume control (MVOL)."
                Information.Label1.Text = info
                Information.Show()
                lblDisplay.Text = MKRval

            ElseIf MKRTCNcount = 2 Then
                btnTACANlight.BackColor = Color.GreenYellow
                btnMBlight.BackColor = Color.Transparent
                MKRState = 0
                TCNState = 1

                info = "The second press switches to the TACAN. The volume controls work the same way and are independent from the MB audio level. This allows the user to set an audio level that is comfortable for them. After five seconds the display will revert back to the master volume control (MVOL)."
                Information.Label1.Text = info
                Information.Show()
                lblDisplay.Text = TCNval

            ElseIf MKRTCNcount = 3 Then

                btnTACANlight.BackColor = Color.GreenYellow
                btnMBlight.BackColor = Color.GreenYellow
                MKRState = 1
                TCNState = 1

                info = "The 3rd press connects to both radios. Notice that the data in the display has changed. It now shows the volume levels for both radios. Pressing the up arrow will increase the volumes together until the radios reach their maximum volume. If one volume reaches the limit first, it will stop increasing while the other volume continues to rise. Decreasing the volume works the same way. After five seconds the display will revert back to the master volume control (MVOL)."
                Information.Label1.Text = info
                Information.Show()
                lblDisplay.Text = MKRTCN

            ElseIf MKRTCNcount = 4 Then

                btnTACANlight.BackColor = Color.Transparent
                btnMBlight.BackColor = Color.Transparent
                MKRState = 0
                TCNState = 0

                info = "The 4th press deselects both radios."
                Information.Label1.Text = info
                Information.Show()
                lblDisplay.Text = MVOLval

                MKRTCNcount = 0   'resets the counter
            End If
            MKRTCNcount = MKRTCNcount + 1

        End If

    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles btnDME.Click
        Dim info As String

        If lblDisplay.Text <> "" Then   'In BKUP the display will be blank. This wraps the code to test that status

            'begin test of pushbutton. If button has been pushed within the last five seconds, this will allow the button to sequence to the next selection. If the button has reverted to MVOL, the next button push will not sequence to the next selection. It will only display the current volume settings and setup the program to advance on the next button push.
            If lblDisplay.Text.Substring(0, 3) = "DME" Then
            Else
                DMEcount = DMEcount - 1
            End If
            If DMEcount = 0 Then
                DMEcount = 1
            End If
            'end pushbutton test 

            If DMEcount = 1 Then
                btnDME1light.BackColor = Color.GreenYellow
                DME1State = 1
                DME2State = 0


                info = "Pressing the DME1/2 radio button once will activate the DME1 audio. The display shows DME1 05 indicating that DME1 audio is active and the volume level is set to 05. Volume for that radio can be adjusted from 00 to 09 using the up/down arrows. After five seconds the display will revert back to the master volume control (MVOL)."
                Information.Label1.Text = info
                Information.Show()
                lblDisplay.Text = DME1val

            ElseIf DMEcount = 2 Then
                btnDME2light.BackColor = Color.GreenYellow
                btnDME1light.BackColor = Color.Transparent
                DME1State = 0
                DME2State = 1

                info = "The second press switches to the DME2 radio. The volume controls work the same way and are independent from the DME1 audio level. This allows the user to set an audio level that is comfortable for them. After five seconds the display will revert back to the master volume control (MVOL)."
                Information.Label1.Text = info
                Information.Show()
                lblDisplay.Text = DME2val

            ElseIf DMEcount = 3 Then

                btnDME2light.BackColor = Color.GreenYellow
                btnDME1light.BackColor = Color.GreenYellow
                DME1State = 1
                DME2State = 1

                info = "The 3rd press connects to both radios. Notice that the data in the display has changed. It now shows the volume levels for both radios. Pressing the up arrow will increase the volumes together until the radios reach their maximum volume. If one volume reaches the limit first, it will stop increasing while the other volume continues to rise. Decreasing the volume works the same way. After five seconds the display will revert back to the master volume control (MVOL)."
                Information.Label1.Text = info
                Information.Show()
                lblDisplay.Text = DME1DME2

            ElseIf DMEcount = 4 Then

                btnDME2light.BackColor = Color.Transparent
                btnDME1light.BackColor = Color.Transparent
                DME1State = 0
                DME2State = 0

                info = "The 4th press deselects both radios."
                Information.Label1.Text = info
                Information.Show()
                lblDisplay.Text = MVOLval

                DMEcount = 0   'resets the counter
            End If
            DMEcount = DMEcount + 1

        End If

    End Sub
    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles btnUp.Click
        If lblDisplay.Text = "DIM " Then
            DimUp()
            Exit Sub
        End If

        If lblDisplay.Text <> "" Then   'In BKUP the display will be blank. This wraps the code to test that status
            RXTXcompare()               'see RXTXcomare sub for details on this code
            If multRXlight = True Then  'wraps volume control with a condition test
                Try
                    k = lblDisplay.Text.Substring(0, 4) 'stores the string of the first 4 characters
                    i = lblDisplay.Text.Substring(5, 2) 'checks the value of the 5th and 6th character
                    Try
                        l = lblDisplay.Text.Substring(7, 2)    'checks the value of the 7th and 8th char
                    Catch
                    End Try

                    j = CInt(i)
                    m = CInt(l)


                    If lblDisplay.Text.Length > 7 Then


                        If j < 9 And m < 9 Then
                            j = j + 1
                            m = m + 1
                            lblDisplay.Text = k + " 0" + CStr(j) + "0" + CStr(m)
                        ElseIf j >= 9 And m < 9 Then
                            m = m + 1
                            lblDisplay.Text = k + " 0" + CStr(j) + "0" + CStr(m)
                        ElseIf j < 9 And m >= 9 Then
                            j = j + 1
                            lblDisplay.Text = k + " 0" + CStr(j) + "0" + CStr(m)
                        End If


                        'Sets the upper volume for VOX
                    ElseIf k = "VOX " Then
                        If j <> 14 Then
                            j = j + 1
                            If j < 10 Then
                                lblDisplay.Text = k + " 0" + CStr(j)
                            Else
                                lblDisplay.Text = k + " " + CStr(j)
                            End If
                        End If
                        VOXval = j
                        VOXcurrentState = lblDisplay.Text


                    ElseIf k <> "MVOL" Then
                        If j <> 9 Then
                            j = j + 1
                            If j < 10 Then
                                lblDisplay.Text = k + " 0" + CStr(j)
                            Else
                                lblDisplay.Text = k + " " + CStr(j)
                            End If
                        End If
                    Else
                        If j <> 13 Then
                            j = j + 1
                            If j < 10 Then
                                lblDisplay.Text = k + " 0" + CStr(j)
                            Else
                                lblDisplay.Text = k + " " + CStr(j)
                            End If
                        Else
                        End If
                    End If


                    volumeLevels()


                Catch ex As Exception
                    lblDisplay.Text = MVOLval
                End Try
            End If
        End If

    End Sub
    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles btnDown.Click

        If lblDisplay.Text = "DIM " Then
            DimDown()
            Exit Sub
        End If

        If lblDisplay.Text <> "" Then   'In BKUP the display will be blank. This wraps the code to test that status
            RXTXcompare()               'see RXTXcomare sub for details on this code
            If multRXlight = True Then  'wraps volume control with a condition test
                Try
                    k = lblDisplay.Text.Substring(0, 4)
                    i = lblDisplay.Text.Substring(5, 2) 'checks the value of the fifth and sixth character
                    Try
                        l = lblDisplay.Text.Substring(7, 2)    'checks the value of the 7th and 8th char
                    Catch
                    End Try

                    j = CInt(i)
                    m = CInt(l)


                    If lblDisplay.Text.Length > 7 Then

                        If j > 0 And m > 0 Then
                            j = j - 1
                            m = m - 1
                            lblDisplay.Text = k + " 0" + CStr(j) + "0" + CStr(m)
                        ElseIf j <= 0 And m > 0 Then
                            m = m - 1
                            lblDisplay.Text = k + " 0" + CStr(j) + "0" + CStr(m)
                        ElseIf j > 0 And m <= 0 Then
                            j = j - 1
                            lblDisplay.Text = k + " 0" + CStr(j) + "0" + CStr(m)
                        End If

                        'Sets lower VOX level
                    ElseIf k = "VOX " Then
                        If j <> 1 Then
                            j = j - 1

                            If j < 10 Then
                                lblDisplay.Text = k + " 0" + CStr(j)
                            Else
                                lblDisplay.Text = k + " " + CStr(j)
                            End If
                        End If
                        VOXval = j
                        VOXcurrentState = lblDisplay.Text

                    ElseIf k = "MVOL" Then
                        If j <> 0 Then
                            j = j - 1

                            If j < 10 Then
                                lblDisplay.Text = k + " 0" + CStr(j)
                            Else
                                lblDisplay.Text = k + " " + CStr(j)
                            End If
                        End If



                    ElseIf j <> 0 Then


                        j = j - 1

                        If j < 10 Then
                            lblDisplay.Text = k + " 0" + CStr(j)
                        Else
                            lblDisplay.Text = k + " " + CStr(j)
                        End If




                    Else

                    End If
                    volumeLevels()


                Catch ex As Exception
                    lblDisplay.Text = MVOLval


                End Try
            End If
        End If


    End Sub
    Private Sub btnMODE_Click(sender As Object, e As EventArgs) Handles btnMODE.Click

        Dim info As String

        If lblDisplay.Text <> "" Then   'In BKUP the display will be blank. This wraps the code to test that status


            If MODEcount = 1 Then   'Sets the initial display setting to MIC ON
                lblDisplay.Text = MICcurrentState
            End If


            'begin test of pushbutton. If button has been pushed within the last five seconds, this will allow the button to sequence to the next selection. If the button has reverted to MVOL, the next button push will not sequence to the next selection. It will only display the current volume settings and setup the program to advance on the next button push.
            If lblDisplay.Text.Substring(0, 3) = "MIC" Then
            ElseIf lblDisplay.Text.Substring(0, 3) = "VOX" Then
            ElseIf lblDisplay.Text.Substring(0, 3) = "DIM" Then
            ElseIf lblDisplay.Text.Substring(0, 4) = "MBIT" Then
            Else
                MODEcount = 1
            End If
            If MODEcount = 0 Then
                MODEcount = 4
            End If
            'end pushbutton test 

            If MODEcount = 1 Then   'count 1 = mic on
                lblDisplay.Text = MICcurrentState


                info = "The MODE PB cycles through the mode selections: MIC, VOX, DIM, and MBIT. When the last item is in the display, a press of the MODE PB will cycle back to the first item. VOX and DIM modes do not require the SEL PB to be pressed. For all other modes, pressing the SEL PB will cause the mode currently in the display to become active. Pressing the select pushbutton while MIC is displayed will cause the mic to toggle on and off. Pressing the SEL PB when MIC OFF is displayed activates the HOT MIC mode for Interphone Nets (INT1 and INT2) and displays MIC ON. This sets the VOX function to 0. Pressing the SEL PB, when MIC ON is displayed de-activates the Hot Mic, and displays MIC OFF. VOX will be restored to its previously selected level. The mic setting does not affect the operation of an ICS switch.Press the MODE pushbutton to toggle to the VOX setting."
                Information.Label1.Text = info
                Information.Show()


            ElseIf MODEcount = 2 Then   'count 2 = VOX on

                lblDisplay.Text = VOXcurrentState

                info = "The VOX has a sensitivity adjustment range of 01-15 (where 01 is the most sensitive and 15 is off.) To set the VOX sensitivity level, press MODE PB until the VOX display appears on the 8-character display. The number, between 01 (least sensitive) and maximum 14 (most sensitive), will indicate the relative VOX threshold. The VOX threshold adjustment does not have any effect if the MIC has been turned on.Press the MODE push button to toggle to the DIM setting."
                Information.Label1.Text = info
                Information.Show()


            ElseIf MODEcount = 3 Then   'count 3 = DIM on

                lblDisplay.Text = "DIM "

                info = "Adjusts the display and annunciator brightness. Use the up and down arrows to make the adjustments while in DIM.Press the MODE push button to toggle to the MBIT setting."
                Information.Label1.Text = info
                Information.Show()

            ElseIf MODEcount = 4 Then   'count 4 = MBIT

                lblDisplay.Text = "MBIT"

                info = "The 4th press brings you to the MBIT function. Pressing SEL PB activates Maintenance BIT. (MBIT is enabled only when WOW is active. In flight this option is skipped).Pressing the MODE button again will circle back to the MIC function. Hover your mouse cursor over the CALL button to continue."
                Information.Label1.Text = info
                Information.Show()

                MODEcount = 0   'resets the counter
            End If
            MODEcount = MODEcount + 1

        End If

    End Sub
    Private Sub btnSEL_Click(sender As Object, e As EventArgs) Handles btnSEL.Click

        Dim info As String

        If lblDisplay.Text <> "" Then   'In BKUP the display will be blank. This wraps the code to test that status


            If lblDisplay.Text.Substring(0, 4) <> "MIC " Then
                If lblDisplay.Text.Substring(0, 4) <> "VOX " Then
                    If lblDisplay.Text.Substring(0, 4) <> "MBIT" Then
                        If lblDisplay.Text.Substring(0, 4) <> "DIM " Then

                            '9-01 added condition to seperate multicastmode and multiINTmode
                            If knobIndex > 3 Then
                                multiCastMode = True    'original
                                simulcastTextbox()
                                multiSelect()
                                TransmitHold()
                                ReloadLights()
                            ElseIf knobIndex <= 3 Then
                                If BKUPtx.BackColor <> Color.YellowGreen Then
                                    multiINTmode = True
                                    simulcastTextbox()
                                    INTSelect()
                                    IntHold()
                                    ReloadLights()
                                End If
                            End If
                            '9-01 end addition

                            '8-29 wrapped the DisplayUpdate sub with an if statement so the diplay is not updated with SEL push in similcast mode
                            If multiCastMode = False Then
                                DisplayUpdate() 'original code
                            End If
                            '8-29 end update
                            'If multiINTmode = False Then
                            '    DisplayUpdate()
                            'End If
                        End If
                    End If
                End If
            Else

                If MODEcount = 2 Then

                    If MICcurrentState = "MIC  ON" Then

                        info = "The Microphone mode can be selected to either Hot Mic or to a VOX level. To do so press the MODE PB until the HOT MIC status display of either MIC ON or MIC OFF appears on the 8-character display. Pressing the SEL PB when MIC OFF is displayed activates the HOT MIC mode for Interphone Nets (INT1 and INT2) and displays MIC ON. This sets the VOX function to 0."
                        Information.Label1.Text = info
                        Information.Show()

                        lblDisplay.Text = "MIC  OFF"
                        MICcurrentState = "MIC  OFF"
                    ElseIf MICcurrentState = "MIC  OFF" Then

                        info = "Pressing the SEL PB, when MIC ON is displayed de-activates the Hot Mic, and displays MIC OFF. VOX will be restored to its previously selected level. After five seconds of inactivity, the DISPLAY will return to MVOL."
                        Information.Label1.Text = info
                        Information.Show()

                        lblDisplay.Text = "MIC  ON"
                        MICcurrentState = "MIC  ON"
                    End If
                ElseIf MODEcount = 1 Then
                    lblDisplay.Text = ""
                    lblDisplay.Refresh()
                    System.Threading.Thread.Sleep(2000)
                    lblDisplay.Text = "MBIT OK"




                End If

            End If

        End If


    End Sub
    Private Sub btnMSR1_Click(sender As Object, e As EventArgs) Handles btnMSR1.Click

        Dim info As String

        If imageLoaded = "MSR1" And MSR1tx.BackColor = Color.GreenYellow Then
            lblDisplay.Text = MSR1val
        ElseIf imageLoaded = "MSR1" And MSR1tx.BackColor = Color.Transparent Then

            If lblDisplay.Text <> "" Then   'In BKUP the display will be blank. This wraps the code to test that status


                'begin test of pushbutton. If button has been pushed within the last five seconds, this will allow the button to sequence to the next selection. If the button has reverted to MVOL, the next button push will not sequence to the next selection. It will only display the current volume settings and setup the program to advance on the next button push.
                If lblDisplay.Text.Substring(0, 4) = "MSR1" Then
                Else
                    MSR1count = MSR1count - 1
                End If
                If MSR1count = 0 Then
                    MSR1count = 1
                End If
                'end pushbutton test 

                If MSR1count = 1 Then   'count 1 = MSR1 left on
                    btnMSR1leftLight.BackColor = Color.GreenYellow
                    lblDisplay.Text = MSR1val

                    info = "Pressing the MSR1 radio button once will activate the #1 PRC-117 radio audio. The display shows MSR1 05 for five seconds indicating that MSR1 audio is active and the volume level is set to 05. Volume for that radio can be adjusted from 00 to 09 using the up/down arrows while the display indicates MSR1. After five seconds the display will revert back to the master volume control (MVOL)."
                    Information.Label1.Text = info
                    Information.Show()


                ElseIf MSR1count = 2 Then   'count 2 = MSR1 left and right on
                    btnMSR1leftLight.BackColor = Color.Transparent
                    lblDisplay.Text = MVOLval

                    MSR1count = 0   'resets the counter
                End If
                MSR1state = MSR1count
                MSR1count = MSR1count + 1
                ReloadLights()

            End If

        Else
            If multiCastMode = True And MSR1tx.BackColor = Color.GreenYellow Then
                lblDisplay.Text = MSR1val
            Else

                If lblDisplay.Text <> "" Then   'In BKUP the display will be blank. This wraps the code to test that status


                    'begin test of pushbutton. If button has been pushed within the last five seconds, this will allow the button to sequence to the next selection. If the button has reverted to MVOL, the next button push will not sequence to the next selection. It will only display the current volume settings and setup the program to advance on the next button push.
                    If lblDisplay.Text.Substring(0, 4) = "MSR1" Then
                    Else
                        MSR1count = MSR1count - 1
                    End If
                    If MSR1count = 0 Then
                        MSR1count = 1
                    End If
                    'end pushbutton test 

                    If MSR1count = 1 Then   'count 1 = MSR1 left on
                        btnMSR1leftLight.BackColor = Color.GreenYellow
                        lblDisplay.Text = MSR1val

                        info = "Pressing the MSR1 radio button once will activate the #1 PRC-117 radio audio. The display shows MSR1 05 for five seconds indicating that MSR1 audio is active and the volume level is set to 05. Volume for that radio can be adjusted from 00 to 09 using the up/down arrows while the display indicates MSR1. After five seconds the display will revert back to the master volume control (MVOL)."
                        Information.Label1.Text = info
                        Information.Show()


                    ElseIf MSR1count = 2 Then   'count 2 = MSR1 left and right on
                        btnMSR1leftLight.BackColor = Color.Transparent
                        lblDisplay.Text = MVOLval

                        MSR1count = 0   'resets the counter
                    End If
                    MSR1state = MSR1count
                    If imageLoaded = "MSR1" Then
                        btnMSR1leftLight.BackColor = Color.GreenYellow
                    End If
                    MSR1count = MSR1count + 1
                    ReloadLights()

                End If
            End If
        End If

    End Sub
    Private Sub btnMSR2_Click(sender As Object, e As EventArgs) Handles btnMSR2.Click
        Dim info As String

        If imageLoaded = "MSR2" And MSR2tx.BackColor = Color.GreenYellow Then
            lblDisplay.Text = MSR2val
        ElseIf imageLoaded = "MSR2" And MSR2tx.BackColor = Color.Transparent Then

            If lblDisplay.Text <> "" Then   'In BKUP the display will be blank. This wraps the code to test that status


                'begin test of pushbutton. If button has been pushed within the last five seconds, this will allow the button to sequence to the next selection. If the button has reverted to MVOL, the next button push will not sequence to the next selection. It will only display the current volume settings and setup the program to advance on the next button push.
                If lblDisplay.Text.Substring(0, 4) = "MSR2" Then
                Else
                    MSR2count = MSR2count - 1
                End If
                If MSR2count = 0 Then
                    MSR2count = 1
                End If
                'end pushbutton test 

                If MSR2count = 1 Then   'count 2 = MSR2 on
                    btnMSR2leftLight.BackColor = Color.GreenYellow
                    lblDisplay.Text = MSR2val

                    If Information.walkThrough = False Then

                        info = "Pressing the MSR2 radio button once will activate the #2 PRC-117 radio audio. The display shows MSR2 05 for five seconds indicating that MSR2 audio is active and the volume level is set to 05. Volume for that radio can be adjusted from 00 to 09 using the up/down arrows while the display indicates MSR2. After five seconds the display will revert back to the master volume control (MVOL)."
                        Information.Label1.Text = info
                        Information.Show()
                    Else

                    End If

                ElseIf MSR2count = 2 Then   'count 2 = MSR2 off
                    btnMSR2leftLight.BackColor = Color.Transparent
                    lblDisplay.Text = MVOLval

                    MSR2count = 0   'resets the counter
                End If
                MSR2state = MSR2count
                MSR2count = MSR2count + 1
                ReloadLights()

            End If

        Else
            If multiCastMode = True And MSR2tx.BackColor = Color.GreenYellow Then
                lblDisplay.Text = MSR2val
            Else

                If lblDisplay.Text <> "" Then   'In BKUP the display will be blank. This wraps the code to test that status


                    'begin test of pushbutton. If button has been pushed within the last five seconds, this will allow the button to sequence to the next selection. If the button has reverted to MVOL, the next button push will not sequence to the next selection. It will only display the current volume settings and setup the program to advance on the next button push.
                    If lblDisplay.Text.Substring(0, 4) = "MSR2" Then
                    Else
                        MSR2count = MSR2count - 1
                    End If
                    If MSR2count = 0 Then
                        MSR2count = 1
                    End If
                    'end pushbutton test 

                    If MSR2count = 1 Then   'count 2 = MSR2 on
                        btnMSR2leftLight.BackColor = Color.GreenYellow
                        lblDisplay.Text = MSR2val

                        If Information.walkThrough = False Then

                            info = "Pressing the MSR2 radio button once will activate the #2 PRC-117 radio audio. The display shows MSR2 05 for five seconds indicating that MSR2 audio is active and the volume level is set to 05. Volume for that radio can be adjusted from 00 to 09 using the up/down arrows while the display indicates MSR2. After five seconds the display will revert back to the master volume control (MVOL)."
                            Information.Label1.Text = info
                            Information.Show()
                        Else

                        End If


                    ElseIf MSR2count = 2 Then   'count 2 = MSR2 off
                        btnMSR2leftLight.BackColor = Color.Transparent
                        lblDisplay.Text = MVOLval

                        MSR2count = 0   'resets the counter
                    End If
                    MSR2state = MSR2count
                    If imageLoaded = "MSR2" Then
                        btnMSR2leftLight.BackColor = Color.GreenYellow
                    End If
                    MSR2count = MSR2count + 1
                    ReloadLights()

                End If
            End If
        End If
    End Sub
    Private Sub btnMSR3_Click(sender As Object, e As EventArgs) Handles btnMSR3.Click
        Dim info As String

        If imageLoaded = "MSR3" And MSR3tx.BackColor = Color.GreenYellow Then
            lblDisplay.Text = MSR3val
        ElseIf imageLoaded = "MSR3" And MSR3tx.BackColor = Color.Transparent Then

            If lblDisplay.Text <> "" Then   'In BKUP the display will be blank. This wraps the code to test that status


                'begin test of pushbutton. If button has been pushed within the last five seconds, this will allow the button to sequence to the next selection. If the button has reverted to MVOL, the next button push will not sequence to the next selection. It will only display the current volume settings and setup the program to advance on the next button push.
                If lblDisplay.Text.Substring(0, 4) = "MSR3" Then
                Else
                    MSR3count = MSR3count - 1
                End If
                If MSR3count = 0 Then
                    MSR3count = 1
                End If
                'end pushbutton test 

                If MSR3count = 1 Then   'count 2 = msr3 on
                    btnMSR3leftLight.BackColor = Color.GreenYellow
                    lblDisplay.Text = MSR3val

                    If Information.walkThrough = False Then


                        info = "Pressing the MSR3 radio button once will activate the #3 PRC-117 radio audio. The display shows MSR3 05 for five seconds indicating that MSR3 audio is active and the volume level is set to 05. Volume for that radio can be adjusted from 00 to 09 using the up/down arrows while the display indicates MSR3. After five seconds the display will revert back to the master volume control (MVOL)."
                        Information.Label1.Text = info
                        Information.Show()
                    Else
                    End If

                ElseIf MSR3count = 2 Then   'count 2 = msr3 off
                    btnMSR3leftLight.BackColor = Color.Transparent
                    lblDisplay.Text = MVOLval

                    MSR3count = 0   'resets the counter
                End If
                MSR3state = MSR3count
                MSR3count = MSR3count + 1
                ReloadLights()

            End If


        Else
            If multiCastMode = True And MSR3tx.BackColor = Color.GreenYellow Then
                lblDisplay.Text = MSR3val
            Else

                If lblDisplay.Text <> "" Then   'In BKUP the display will be blank. This wraps the code to test that status


                    'begin test of pushbutton. If button has been pushed within the last five seconds, this will allow the button to sequence to the next selection. If the button has reverted to MVOL, the next button push will not sequence to the next selection. It will only display the current volume settings and setup the program to advance on the next button push.
                    If lblDisplay.Text.Substring(0, 4) = "MSR3" Then
                    Else
                        MSR3count = MSR3count - 1
                    End If
                    If MSR3count = 0 Then
                        MSR3count = 1
                    End If
                    'end pushbutton test 

                    If MSR3count = 1 Then   'count 2 = msr3 on
                        btnMSR3leftLight.BackColor = Color.GreenYellow
                        lblDisplay.Text = MSR3val

                        If Information.walkThrough = False Then


                            info = "Pressing the MSR3 radio button once will activate the #3 PRC-117 radio audio. The display shows MSR3 05 for five seconds indicating that MSR3 audio is active and the volume level is set to 05. Volume for that radio can be adjusted from 00 to 09 using the up/down arrows while the display indicates MSR3. After five seconds the display will revert back to the master volume control (MVOL)."
                            Information.Label1.Text = info
                            Information.Show()
                        Else
                        End If


                    ElseIf MSR3count = 2 Then   'count 2 = msr3 off
                        btnMSR3leftLight.BackColor = Color.Transparent
                        lblDisplay.Text = MVOLval

                        MSR3count = 0   'resets the counter
                    End If
                    MSR3state = MSR3count
                    If imageLoaded = "MSR3" Then
                        btnMSR3leftLight.BackColor = Color.GreenYellow
                    End If
                    MSR3count = MSR3count + 1
                    ReloadLights()

                End If
            End If
        End If
    End Sub
    Private Sub btnMSR4_Click(sender As Object, e As EventArgs) Handles btnMSR4.Click
        Dim info As String

        If imageLoaded = "MSR4" And MSR4tx.BackColor = Color.GreenYellow Then
            lblDisplay.Text = MSR4val
        ElseIf imageLoaded = "MSR4" And MSR4tx.BackColor = Color.Transparent Then

            If lblDisplay.Text <> "" Then   'In BKUP the display will be blank. This wraps the code to test that status


                'begin test of pushbutton. If button has been pushed within the last five seconds, this will allow the button to sequence to the next selection. If the button has reverted to MVOL, the next button push will not sequence to the next selection. It will only display the current volume settings and setup the program to advance on the next button push.
                If lblDisplay.Text.Substring(0, 4) = "MSR4" Then
                Else
                    MSR4count = MSR4count - 1
                End If
                If MSR4count = 0 Then
                    MSR4count = 1
                End If
                'end pushbutton test 

                If MSR4count = 1 Then   'count 2 = msr4 on
                    btnMSR4leftLight.BackColor = Color.GreenYellow
                    lblDisplay.Text = MSR4val

                    If Information.walkThrough = False Then


                        info = "Pressing the MSR4 radio button once will activate the #4 PRC-117 radio audio. The display shows MSR4 05 for five seconds indicating that MSR4 audio is active and the volume level is set to 05. Volume for that radio can be adjusted from 00 to 09 using the up/down arrows while the display indicates MSR4. After five seconds the display will revert back to the master volume control (MVOL)."
                        Information.Label1.Text = info
                        Information.Show()
                    Else
                    End If


                ElseIf MSR4count = 2 Then   'count 2 = msr4 off
                    btnMSR4leftLight.BackColor = Color.Transparent
                    lblDisplay.Text = MVOLval

                    MSR4count = 0   'resets the counter
                End If
                MSR4state = MSR4count
                MSR4count = MSR4count + 1
                ReloadLights()

            End If


        Else
            If multiCastMode = True And MSR4tx.BackColor = Color.GreenYellow Then
                lblDisplay.Text = MSR4val
            Else

                If lblDisplay.Text <> "" Then   'In BKUP the display will be blank. This wraps the code to test that status


                    'begin test of pushbutton. If button has been pushed within the last five seconds, this will allow the button to sequence to the next selection. If the button has reverted to MVOL, the next button push will not sequence to the next selection. It will only display the current volume settings and setup the program to advance on the next button push.
                    If lblDisplay.Text.Substring(0, 4) = "MSR4" Then
                    Else
                        MSR4count = MSR4count - 1
                    End If
                    If MSR4count = 0 Then
                        MSR4count = 1
                    End If
                    'end pushbutton test 

                    If MSR4count = 1 Then   'count 2 = msr4 on
                        btnMSR4leftLight.BackColor = Color.GreenYellow
                        lblDisplay.Text = MSR4val

                        If Information.walkThrough = False Then


                            info = "Pressing the MSR4 radio button once will activate the #4 PRC-117 radio audio. The display shows MSR4 05 for five seconds indicating that MSR4 audio is active and the volume level is set to 05. Volume for that radio can be adjusted from 00 to 09 using the up/down arrows while the display indicates MSR4. After five seconds the display will revert back to the master volume control (MVOL)."
                            Information.Label1.Text = info
                            Information.Show()
                        Else
                        End If


                    ElseIf MSR4count = 2 Then   'count 2 = msr4 off
                        btnMSR4leftLight.BackColor = Color.Transparent
                        lblDisplay.Text = MVOLval

                        MSR4count = 0   'resets the counter
                    End If
                    MSR4state = MSR4count
                    If imageLoaded = "MSR4" Then
                        btnMSR4leftLight.BackColor = Color.GreenYellow
                    End If
                    MSR4count = MSR4count + 1
                    ReloadLights()

                End If
            End If
        End If

    End Sub
    Private Sub btnCDL_Click(sender As Object, e As EventArgs) Handles btnCDL.Click
        Dim info As String

        If imageLoaded = "CDL" And CDLtx.BackColor = Color.GreenYellow Then
            lblDisplay.Text = CDLval
        ElseIf imageLoaded = "CDL" And CDLtx.BackColor = Color.Transparent Then

            If lblDisplay.Text <> "" Then   'In BKUP the display will be blank. This wraps the code to test that status


                'begin test of pushbutton. If button has been pushed within the last five seconds, this will allow the button to sequence to the next selection. If the button has reverted to MVOL, the next button push will not sequence to the next selection. It will only display the current volume settings and setup the program to advance on the next button push.
                If lblDisplay.Text.Substring(0, 3) = "CDL" Then
                Else
                    CDLcount = CDLcount - 1
                End If
                If CDLcount = 0 Then
                    CDLcount = 1
                End If
                'end pushbutton test 

                If CDLcount = 1 Then   'count 2 = CDL on
                    btnCDLleftLight.BackColor = Color.GreenYellow
                    lblDisplay.Text = CDLval

                    info = "Pressing the CDL radio button once will activate the Wideband Communications Data Link (or CDL) radio audio. The display shows CDL 05 for five seconds indicating that CDL audio is active and the volume level is set to 05. Volume for that radio can be adjusted from 00 to 09 using the up/down arrows while the display indicates CDL. After five seconds the display will revert back to the master volume control (MVOL)."
                    Information.Label1.Text = info
                    Information.Show()


                ElseIf CDLcount = 2 Then   'count 2 = CDL off
                    btnCDLleftLight.BackColor = Color.Transparent
                    lblDisplay.Text = MVOLval

                    CDLcount = 0   'resets the counter
                End If
                CDLstate = CDLcount
                CDLcount = CDLcount + 1
                ReloadLights()

            End If


        Else
            If multiCastMode = True And CDLtx.BackColor = Color.GreenYellow Then
                lblDisplay.Text = CDLval
            Else

                If lblDisplay.Text <> "" Then   'In BKUP the display will be blank. This wraps the code to test that status


                    'begin test of pushbutton. If button has been pushed within the last five seconds, this will allow the button to sequence to the next selection. If the button has reverted to MVOL, the next button push will not sequence to the next selection. It will only display the current volume settings and setup the program to advance on the next button push.
                    If lblDisplay.Text.Substring(0, 3) = "CDL" Then
                    Else
                        CDLcount = CDLcount - 1
                    End If
                    If CDLcount = 0 Then
                        CDLcount = 1
                    End If
                    'end pushbutton test 

                    If CDLcount = 1 Then   'count 2 = CDL on
                        btnCDLleftLight.BackColor = Color.GreenYellow
                        lblDisplay.Text = CDLval

                        info = "Pressing the CDL radio button once will activate the Wideband Communications Data Link (or CDL) radio audio. The display shows CDL 05 for five seconds indicating that CDL audio is active and the volume level is set to 05. Volume for that radio can be adjusted from 00 to 09 using the up/down arrows while the display indicates CDL. After five seconds the display will revert back to the master volume control (MVOL)."
                        Information.Label1.Text = info
                        Information.Show()


                    ElseIf CDLcount = 2 Then   'count 2 = CDL off
                        btnCDLleftLight.BackColor = Color.Transparent
                        lblDisplay.Text = MVOLval

                        CDLcount = 0   'resets the counter
                    End If
                    CDLstate = CDLcount
                    If imageLoaded = "CDL" Then
                        btnCDLleftLight.BackColor = Color.GreenYellow
                    End If
                    CDLcount = CDLcount + 1
                    ReloadLights()

                End If
            End If
        End If
    End Sub
    Private Sub btnCALL_Click(sender As Object, e As EventArgs) Handles btnCALL.MouseHover


        Dim info As String

        If lblDisplay.Text <> "" Then   'In BKUP the display will be blank. This wraps the code to test that status


            btnCALLlight.BackColor = Color.GreenYellow
            lblDisplay.Text = "CALL"




            info = "The CALL Function is always available and is governed by the following rules: The operator will always hear a CALL from any other operator, The volume is set to the maximum (to ensure that it is audible), The CALL function disables INT 2 at all MCAPs, The CALL discrete is wired to all LRUs (ICUs and MCAPs), The CALL function does not affect radio operation, The CALL function is not part of Clear/Secure interlock rules, and The status of the LEDs on the MCAP does not change when the CALL function is active. Pushing and holding the CALL PB activates the CALL function. The CALL LED will be illuminated, and Call will be displayed on the MCAP display (assuming the ICU is communicating with the MCAP). The MCAP display will be blank when the ICU is not communicating with the MCAP. Release the CALL pushbutton by moving the mouse cursor away from the CALL button."
            Information.Label1.Text = info
            Information.Show()



        End If

    End Sub
    Private Sub btnCALL_gone(sender As Object, e As EventArgs) Handles btnCALL.MouseLeave

        Dim info As String

        If lblDisplay.Text <> "" Then   'In BKUP the display will be blank. This wraps the code to test that status

            If Information.walkThrough = True Then
                info = "Releasing the CALL PB ends CALL and returns the MCAP display to MVOL and the CALL LED extinguishes. The CALL Receive Function is always available and requires no operator selection. Next, we will look at the transmit functions of the MCAP. Place your mouse cursor on the text 'BKUP' next to the transmit select knob and click the mouse."
                Information.Label1.Text = info
                Information.Show()
            Else
                info = "Releasing the CALL PB ends CALL and returns the MCAP display to MVOL and the CALL LED extinguishes. The CALL Receive Function is always available and requires no operator selection."
                Information.Label1.Text = info
                Information.Show()
            End If

            btnCALLlight.BackColor = Color.Transparent

            lblDisplay.Text = MVOLval

        End If

    End Sub
    Private Sub btnAUX_Click(sender As Object, e As EventArgs) Handles btnAUX.Click
        Dim info As String

        If lblDisplay.Text <> "" Then   'In BKUP the display will be blank. This wraps the code to test that status


            'begin test of pushbutton. If button has been pushed within the last five seconds, this will allow the button to sequence to the next selection. If the button has reverted to MVOL, the next button push will not sequence to the next selection. It will only display the current volume settings and setup the program to advance on the next button push.
            If lblDisplay.Text.Substring(0, 3) = "AUX" Then
            Else
                AUXcount = AUXcount - 1
            End If
            If AUXcount = 0 Then
                AUXcount = 1
            End If
            'end pushbutton test 

            If AUXcount = 1 Then   'count 2 = AUX on
                btnAUXleftLight.BackColor = Color.GreenYellow
                lblDisplay.Text = AUXval

                info = "Pressing the AUX radio button once will activate the AUX radio audio. The display shows AUX 05 for five seconds indicating that AUX audio is active and the volume level is set to 05. Volume for that radio can be adjusted from 00 to 09 using the up/down arrows while the display indicates AUX. After five seconds the display will revert back to the master volume control (MVOL)."
                Information.Label1.Text = info
                Information.Show()


            ElseIf AUXcount = 2 Then   'count 2 = AUX off
                btnAUXleftLight.BackColor = Color.Transparent
                lblDisplay.Text = MVOLval

                AUXcount = 0   'resets the counter
            End If
            AUXstate = AUXcount
            'If knobIndex = 1 Then
            '    btnAUXleftLight.BackColor = Color.GreenYellow
            'End If
            AUXcount = AUXcount + 1

        End If

    End Sub
    Private Sub lblDisplay_Click(sender As Object, e As EventArgs) Handles lblDisplay.Click
        Dim info As String

        If lblDisplay.Text <> "" Then   'In BKUP the display will be blank. This wraps the code to test that status


            If Displaycount = 1 Then   'PBIT OK
                lblDisplay.Text = "PBIT OK"

                If Information.walkThrough = True Then


                    info = "When the ICU (Integrated Control Unit, the brains of the audio system) completes its initialization period, the ICU runs normal Power-up BIT (PBIT). PBIT automatically performs a set of BIT functions at power-up to provide confidence that the equipment is operational. Upon successful completion of PBIT, the MCAP displays PBIT OK. After five seconds the display will show MVOL 06. This indicates the master volume level. The master volume controls all incoming audio levels simultaneously without affecting the independent radio volume controls. The settings can be set from 00 to 13 using the up and down arrows. The master volume view is the default view on the MCAP display. Adjust the master volume, using the up and down pushbuttons. Set it to anything you wish. When you are finished, press the ATC1/2 pushbutton to continue."
                    Information.Label1.Text = info
                    Information.Show()
                Else
                    info = "When the ICU (Integrated Control Unit, the brains of the audio system) completes its initialization period, the ICU runs normal Power-up BIT (PBIT). PBIT automatically performs a set of BIT functions at power-up to provide confidence that the equipment is operational. Upon successful completion of PBIT, the MCAP displays PBIT OK. After five seconds the display will show MVOL 06. This indicates the master volume level. The master volume controls all incoming audio levels simultaneously without affecting the independent radio volume controls. The settings can be set from 00 to 13 using the up and down arrows. The master volume view is the default view on the MCAP display."
                    Information.Label1.Text = info
                    Information.Show()
                End If
            End If
            Displaycount = 1

        End If

    End Sub



    'Knob
    Private Sub btnBKUPposition_Click(sender As Object, e As EventArgs) Handles btnBKUPposition.Click



        knobIndex = 1
        imageLoaded = "BKUP"
        KnobSelect()

        If Information.walkThrough = True Then



            Dim info As String

            info = "BKUP provides emergency communications between all stations via INT1. In the BKUP mode the BKUP transmit indicator, INT1 receive indicator, and  INT1 transmit indicator will be the only indications available for the operator. The display will be blank and all other lights will go blank. Turning the transmit to any other selection will reenable all lights and the display. Select INT1 with the transmit select knob (place the mouse cursor over INT1 next to the transmit select knob and click the mouse)."
            Information.Label1.Text = info
            Information.Show()
        End If
    End Sub
    Private Sub btnINT2position_Click(sender As Object, e As EventArgs) Handles btnINT2position.Click
        knobIndex = 3
        imageLoaded = "INT2"
        KnobSelect()

        If Information.walkThrough = True Then
            If multiCastMode = True Then



                Dim info As String

                info = "Notice that the transmit light came on immediately when the knob was placed in the INT 2 position. The reason for this is because the intercom channels work separately in simulcast mode than the transmitter channels. Think of it as having two simulcast networks, one for transmitters and the other for intercom channels. Selecting intercom simulcast works the same way as selecting transmitter simulcast. Turn the transmit select knob to CDL and press the SEL button. Do this for all of the simulcasted radios. This deselects the transmitters. In the information window, click MODES in the menubar."
                Information.Label1.Text = info
                Information.Show()
            End If
        End If
    End Sub
    Private Sub btnINT1position_Click(sender As Object, e As EventArgs) Handles btnINT1position.Click

        knobIndex = 2
        imageLoaded = "INT1"
        KnobSelect()

        If Information.walkThrough = True Then
            Dim info As String

            info = "Notice the display is indicating INT1 and the current volume setting. Each time the knob is rotated the current selection will indicate in the display along with its current volume setting. After five seconds, the display will revert to MVOL. Click on the HF transmit position."
            Information.Label1.Text = info
            Information.Show()
        End If

    End Sub
    Private Sub btnATC1position_Click(sender As Object, e As EventArgs) Handles btnATC1position.Click

        knobIndex = 4
        imageLoaded = "ATC1"
        KnobSelect()

    End Sub
    Private Sub btnATC2position_Click(sender As Object, e As EventArgs) Handles btnATC2position.Click

        knobIndex = 5
        imageLoaded = "ATC2"
        KnobSelect()

    End Sub

    Private Sub btnHFposition_Click(sender As Object, e As EventArgs) Handles btnHFposition.Click

        knobIndex = 6
        imageLoaded = "HF"
        KnobSelect()

        If Information.walkThrough = True Then
            Dim info As String

            info = "Notice the receive light on each of the receivers automatically lights up as you select that transmitter. If the transmit select knob is pointed at a particular radio you cannot deselect the received function. If the display has timed out and returned to its master volume setting, pushing the HF receive button while the transmit select knob is pointed to HF will refresh the display to the HF volume level. Subsequent presses of the HF receive button will have not turn off the HF receive audio. Press the HF/ADF button several times. The first time you press the HF/ADF button, the display will return to the HF volume (if the display had timed out to master volume). The next click of the button will turn on the received audio for the ADF. Pressing the button again will turn the ADF volume off. Subsequent presses of the button will only toggle the ADF volume on and off.Turn the transmit select knob to MSR1."
            Information.Label1.Text = info
            Information.Show()

        End If




    End Sub
    Private Sub btnVU1position_Click(sender As Object, e As EventArgs) Handles btnVU1position.Click

        knobIndex = 7
        imageLoaded = "VU1"
        KnobSelect()

    End Sub
    Private Sub btnVU2position_Click(sender As Object, e As EventArgs) Handles btnVU2position.Click

        knobIndex = 8
        imageLoaded = "VU2"
        KnobSelect()

    End Sub
    Private Sub btnMSR1position_Click(sender As Object, e As EventArgs) Handles btnMSR1position.Click

        knobIndex = 9
        imageLoaded = "MSR1"
        KnobSelect()

        If Information.walkThrough = True Then



            Dim info As String

            info = "To monitor multiple radios at one time, simply push the receive button until the receive indicator light is lit. This has to be done before the transmit select knob has been placed in that receiver position. For example, push the MSR 2, MSR 3, and MSR 4 receiver select buttons. When you have selected all of the receivers, turn the transmit select knob to those receivers. You will see the display update as you turn the transmit select knob but the received lights on the pushbuttons remain lit throughout the knob transitions. Turn the transmit select knob to CDL."
            Information.Label1.Text = info
            Information.Show()
        End If
    End Sub
    Private Sub btnMSR2position_Click(sender As Object, e As EventArgs) Handles btnMSR2position.Click

        knobIndex = 10
        imageLoaded = "MSR2"
        KnobSelect()

        If Information.walkThrough = True Then
            If multiCastMode = True Then
                If CDLtx.BackColor = Color.GreenYellow Then


                    Dim info As String

                    info = "Now you have selected multiple transmitters for simulcast mode, you can also select multiple intercom channels. Turn the transmit select knob to INT2."
                    Information.Label1.Text = info
                    Information.Show()
                End If
            End If
        End If
    End Sub
    Private Sub btnMSR3position_Click(sender As Object, e As EventArgs) Handles btnMSR3position.Click

        knobIndex = 11
        imageLoaded = "MSR3"
        KnobSelect()

    End Sub
    Private Sub btnMSR4position_Click(sender As Object, e As EventArgs) Handles btnMSR4position.Click

        knobIndex = 12
        imageLoaded = "MSR4"
        KnobSelect()

    End Sub
    Private Sub btnCDLposition_Click(sender As Object, e As EventArgs) Handles btnCDLposition.Click

        knobIndex = 13
        imageLoaded = "CDL"
        KnobSelect()

        If Information.walkThrough = True Then
            If MSR3tx.BackColor = Color.Transparent Then

                Dim info As String

                info = "Deselect MSR2, MSR3, and MSR4 by pushing the pushbuttons until the lights go out. Next we will discuss simulcast. Just like selecting multiple receivers at one time, we can also transmit on multiple radios at one time. This is known as SIMULCAST MODE. By turning your transmit select knob to the desired receiver, CDL for example, and pressing the SEL pushbutton, the unit will enter SIMULCAST MODE. Turn the transmit select switch to CDL, MSR 4, MSR 3, and MSR 2, pressing the SEL pushbutton after each turn of the knob. Notice that the transmit select lights are working differently now. Until you press the SEL pushbutton, the transmit select light does not light up. Neither does the received light for the associated pushbutton."
                Information.Label1.Text = info
                Information.Show()
            Else

            End If
        End If
    End Sub
    Private Sub KnobSelect()
        If ICUfailLight.Visible = True Then
            MoveKnob()
            lblDisplay.Text = ""
            If imageLoaded = "BKUP" Then
                INT1tx.BackColor = Color.GreenYellow
                btnINT1light.BackColor = Color.GreenYellow
                BKUPtx.BackColor = Color.GreenYellow
            Else
                INT1tx.BackColor = Color.Transparent
                btnINT1light.BackColor = Color.Transparent
                BKUPtx.BackColor = Color.Transparent
            End If
        Else

            firstMoveComplete = True
            'begin test for backup mode. If backup knob is loaded I force the system to turn off all lights and display. I create a variable called forcedBKUPcount to determine if the system just came out of backup mode. If it did, I force the backup lights off. The original code remembers the state of the lights so if they should be left on, the original code does it automatically.
            If imageLoaded = "BKUP" Then
                ForceBKUP()
                forcedBKUPcount = 1
            Else
                If forcedBKUPcount = 1 Then
                    forcedBKUPcount = 0
                    INT1tx.BackColor = Color.Transparent
                    btnINT1light.BackColor = Color.Transparent
                    BKUPtx.BackColor = Color.Transparent
                    multiCastMode = multiCastRecall
                    multiINTmode = multiIntRecall

                    'End If
                    'end backup code.

                    StaticLightTest()
                    'firstMoveComplete = True

                    'IF no lights are on set MultiCastMode to False
                ElseIf BKUPtx.BackColor = Color.Transparent Then
                    If ATC1tx.BackColor = Color.Transparent Then
                        If ATC2tx.BackColor = Color.Transparent Then
                            If HFtx.BackColor = Color.Transparent Then
                                If VU1tx.BackColor = Color.Transparent Then
                                    If VU2tx.BackColor = Color.Transparent Then
                                        If MSR1tx.BackColor = Color.Transparent Then
                                            If MSR2tx.BackColor = Color.Transparent Then
                                                If MSR3tx.BackColor = Color.Transparent Then
                                                    If MSR4tx.BackColor = Color.Transparent Then
                                                        If CDLtx.BackColor = Color.Transparent Then

                                                            multiCastMode = False
                                                        End If
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If


                'IF no lights are on set MultiINTMode to False
                If INT1tx.BackColor = Color.Transparent Then
                    If INT2tx.BackColor = Color.Transparent Then
                        multiINTmode = False
                    End If
                End If



                Dim knobText As New Information
                Dim info As String




                If ICUfailLight.Visible = False Then

                    If Information.walkThrough = False Then


                        info = "Turning the transmit select knob during normal operation will connect the users microphone audio lines to that transmitter. Also, the receive audio has also been automatically selected as indicated by the green light above the receiver switch (for example, the INT2 receive audio light automatically comes on when you place the transmit select knob to INT2). Switch the transmit select knob to ATC1, ATC 2, and then HF and watch the lights on the buttons. "
                        Information.Label1.Text = info
                    ElseIf imageLoaded = "MSR2" Or imageLoaded = "MSR3" Or imageLoaded = "MSR4" Then


                    End If

                End If

                If multiCastMode = True Then
                    If knobIndex >= 4 Then
                        MoveKnob()
                    End If
                End If
                If multiCastMode = False Then

                    If imageLoaded = "ATC1" Then   'ATC1 mode
                        lblDisplay.Text = ATC1val
                        OvalShape1.BackgroundImage = My.Resources.ATC1
                        BKUPtx.BackColor = Color.Transparent
                        INT1tx.BackColor = Color.Transparent
                        INT2tx.BackColor = Color.Transparent
                        btnINT1light.BackColor = Color.Transparent
                        btnINT2light.BackColor = Color.Transparent
                        btnATC2light.BackColor = Color.Transparent
                        btnHFlight.BackColor = Color.Transparent
                        btnVU1light.BackColor = Color.Transparent
                        btnVU2light.BackColor = Color.Transparent
                        btnMSR1leftLight.BackColor = Color.Transparent
                        btnMSR2leftLight.BackColor = Color.Transparent
                        btnMSR3leftLight.BackColor = Color.Transparent
                        btnMSR4leftLight.BackColor = Color.Transparent
                        btnCDLleftLight.BackColor = Color.Transparent
                        ATC1tx.BackColor = Color.GreenYellow
                        btnATC1light.BackColor = Color.GreenYellow


                        ATC2tx.BackColor = Color.Transparent
                        HFtx.BackColor = Color.Transparent
                        VU1tx.BackColor = Color.Transparent
                        VU2tx.BackColor = Color.Transparent
                        MSR1tx.BackColor = Color.Transparent
                        MSR2tx.BackColor = Color.Transparent
                        MSR3tx.BackColor = Color.Transparent
                        MSR4tx.BackColor = Color.Transparent
                        CDLtx.BackColor = Color.Transparent
                    ElseIf imageLoaded = "ATC2" Then   'ATC2 mode
                        lblDisplay.Text = ATC2val
                        OvalShape1.BackgroundImage = My.Resources.ATC2
                        BKUPtx.BackColor = Color.Transparent
                        INT1tx.BackColor = Color.Transparent
                        INT2tx.BackColor = Color.Transparent
                        ATC1tx.BackColor = Color.Transparent
                        btnINT1light.BackColor = Color.Transparent
                        btnINT2light.BackColor = Color.Transparent
                        btnATC1light.BackColor = Color.Transparent
                        btnHFlight.BackColor = Color.Transparent
                        btnVU1light.BackColor = Color.Transparent
                        btnVU2light.BackColor = Color.Transparent
                        btnMSR1leftLight.BackColor = Color.Transparent
                        btnMSR2leftLight.BackColor = Color.Transparent
                        btnMSR3leftLight.BackColor = Color.Transparent
                        btnMSR4leftLight.BackColor = Color.Transparent
                        btnCDLleftLight.BackColor = Color.Transparent
                        ATC2tx.BackColor = Color.GreenYellow
                        btnATC2light.BackColor = Color.YellowGreen
                        HFtx.BackColor = Color.Transparent
                        VU1tx.BackColor = Color.Transparent
                        VU2tx.BackColor = Color.Transparent
                        MSR1tx.BackColor = Color.Transparent
                        MSR2tx.BackColor = Color.Transparent
                        MSR3tx.BackColor = Color.Transparent
                        MSR4tx.BackColor = Color.Transparent
                        CDLtx.BackColor = Color.Transparent
                    ElseIf imageLoaded = "HF" Then   'HF mode
                        lblDisplay.Text = HFval
                        OvalShape1.BackgroundImage = My.Resources.HF
                        BKUPtx.BackColor = Color.Transparent
                        INT1tx.BackColor = Color.Transparent
                        INT2tx.BackColor = Color.Transparent
                        ATC1tx.BackColor = Color.Transparent
                        ATC2tx.BackColor = Color.Transparent
                        btnINT1light.BackColor = Color.Transparent
                        btnINT2light.BackColor = Color.Transparent
                        btnATC1light.BackColor = Color.Transparent
                        btnATC2light.BackColor = Color.Transparent
                        btnVU1light.BackColor = Color.Transparent
                        btnVU2light.BackColor = Color.Transparent
                        btnMSR1leftLight.BackColor = Color.Transparent
                        btnMSR2leftLight.BackColor = Color.Transparent
                        btnMSR3leftLight.BackColor = Color.Transparent
                        btnMSR4leftLight.BackColor = Color.Transparent
                        btnCDLleftLight.BackColor = Color.Transparent
                        HFtx.BackColor = Color.GreenYellow
                        btnHFlight.BackColor = Color.YellowGreen
                        VU1tx.BackColor = Color.Transparent
                        VU2tx.BackColor = Color.Transparent
                        MSR1tx.BackColor = Color.Transparent
                        MSR2tx.BackColor = Color.Transparent
                        MSR3tx.BackColor = Color.Transparent
                        MSR4tx.BackColor = Color.Transparent
                        CDLtx.BackColor = Color.Transparent
                    ElseIf imageLoaded = "VU1" Then   'VU1 mode
                        lblDisplay.Text = VU1val
                        OvalShape1.BackgroundImage = My.Resources.VU1
                        BKUPtx.BackColor = Color.Transparent
                        INT1tx.BackColor = Color.Transparent
                        INT2tx.BackColor = Color.Transparent
                        ATC1tx.BackColor = Color.Transparent
                        ATC2tx.BackColor = Color.Transparent
                        HFtx.BackColor = Color.Transparent
                        btnINT1light.BackColor = Color.Transparent
                        btnINT2light.BackColor = Color.Transparent
                        btnATC1light.BackColor = Color.Transparent
                        btnATC2light.BackColor = Color.Transparent
                        btnHFlight.BackColor = Color.Transparent
                        btnVU2light.BackColor = Color.Transparent
                        btnMSR1leftLight.BackColor = Color.Transparent
                        btnMSR2leftLight.BackColor = Color.Transparent
                        btnMSR3leftLight.BackColor = Color.Transparent
                        btnMSR4leftLight.BackColor = Color.Transparent
                        btnCDLleftLight.BackColor = Color.Transparent
                        VU1tx.BackColor = Color.GreenYellow
                        btnVU1light.BackColor = Color.YellowGreen
                        VU2tx.BackColor = Color.Transparent
                        MSR1tx.BackColor = Color.Transparent
                        MSR2tx.BackColor = Color.Transparent
                        MSR3tx.BackColor = Color.Transparent
                        MSR4tx.BackColor = Color.Transparent
                        CDLtx.BackColor = Color.Transparent
                    ElseIf imageLoaded = "VU2" Then   'VU2 mode
                        lblDisplay.Text = VU2val
                        OvalShape1.BackgroundImage = My.Resources.VU2
                        BKUPtx.BackColor = Color.Transparent
                        INT1tx.BackColor = Color.Transparent
                        INT2tx.BackColor = Color.Transparent
                        ATC1tx.BackColor = Color.Transparent
                        ATC2tx.BackColor = Color.Transparent
                        HFtx.BackColor = Color.Transparent
                        VU1tx.BackColor = Color.Transparent
                        btnINT1light.BackColor = Color.Transparent
                        btnINT2light.BackColor = Color.Transparent
                        btnATC1light.BackColor = Color.Transparent
                        btnATC2light.BackColor = Color.Transparent
                        btnHFlight.BackColor = Color.Transparent
                        btnVU1light.BackColor = Color.Transparent
                        btnMSR1leftLight.BackColor = Color.Transparent
                        btnMSR2leftLight.BackColor = Color.Transparent
                        btnMSR3leftLight.BackColor = Color.Transparent
                        btnMSR4leftLight.BackColor = Color.Transparent
                        btnCDLleftLight.BackColor = Color.Transparent
                        VU2tx.BackColor = Color.GreenYellow
                        btnVU2light.BackColor = Color.YellowGreen
                        MSR1tx.BackColor = Color.Transparent
                        MSR2tx.BackColor = Color.Transparent
                        MSR3tx.BackColor = Color.Transparent
                        MSR4tx.BackColor = Color.Transparent
                        CDLtx.BackColor = Color.Transparent
                    ElseIf imageLoaded = "MSR1" Then   'MSR1 mode
                        lblDisplay.Text = MSR1val
                        OvalShape1.BackgroundImage = My.Resources.MSR1
                        BKUPtx.BackColor = Color.Transparent
                        INT1tx.BackColor = Color.Transparent
                        INT2tx.BackColor = Color.Transparent
                        ATC1tx.BackColor = Color.Transparent
                        ATC2tx.BackColor = Color.Transparent
                        HFtx.BackColor = Color.Transparent
                        VU1tx.BackColor = Color.Transparent
                        VU2tx.BackColor = Color.Transparent
                        btnINT1light.BackColor = Color.Transparent
                        btnINT2light.BackColor = Color.Transparent
                        btnATC1light.BackColor = Color.Transparent
                        btnATC2light.BackColor = Color.Transparent
                        btnHFlight.BackColor = Color.Transparent
                        btnVU1light.BackColor = Color.Transparent
                        btnVU2light.BackColor = Color.Transparent
                        btnMSR2leftLight.BackColor = Color.Transparent
                        btnMSR3leftLight.BackColor = Color.Transparent
                        btnMSR4leftLight.BackColor = Color.Transparent
                        btnCDLleftLight.BackColor = Color.Transparent
                        MSR1tx.BackColor = Color.GreenYellow
                        btnMSR1leftLight.BackColor = Color.YellowGreen
                        MSR2tx.BackColor = Color.Transparent
                        MSR3tx.BackColor = Color.Transparent
                        MSR4tx.BackColor = Color.Transparent
                        CDLtx.BackColor = Color.Transparent
                    ElseIf imageLoaded = "MSR2" Then  'MSR2 mode
                        lblDisplay.Text = MSR2val
                        OvalShape1.BackgroundImage = My.Resources.MSR2
                        BKUPtx.BackColor = Color.Transparent
                        INT1tx.BackColor = Color.Transparent
                        INT2tx.BackColor = Color.Transparent
                        ATC1tx.BackColor = Color.Transparent
                        ATC2tx.BackColor = Color.Transparent
                        HFtx.BackColor = Color.Transparent
                        VU1tx.BackColor = Color.Transparent
                        VU2tx.BackColor = Color.Transparent
                        MSR1tx.BackColor = Color.Transparent
                        btnINT1light.BackColor = Color.Transparent
                        btnINT2light.BackColor = Color.Transparent
                        btnATC1light.BackColor = Color.Transparent
                        btnATC2light.BackColor = Color.Transparent
                        btnHFlight.BackColor = Color.Transparent
                        btnVU1light.BackColor = Color.Transparent
                        btnVU2light.BackColor = Color.Transparent
                        btnMSR1leftLight.BackColor = Color.Transparent
                        btnMSR3leftLight.BackColor = Color.Transparent
                        btnMSR4leftLight.BackColor = Color.Transparent
                        btnCDLleftLight.BackColor = Color.Transparent
                        MSR2tx.BackColor = Color.GreenYellow
                        btnMSR2leftLight.BackColor = Color.YellowGreen
                        MSR3tx.BackColor = Color.Transparent
                        MSR4tx.BackColor = Color.Transparent
                        CDLtx.BackColor = Color.Transparent
                    ElseIf imageLoaded = "MSR3" Then  'MSR3 mode
                        lblDisplay.Text = MSR3val
                        OvalShape1.BackgroundImage = My.Resources.MSR3
                        BKUPtx.BackColor = Color.Transparent
                        INT1tx.BackColor = Color.Transparent
                        INT2tx.BackColor = Color.Transparent
                        ATC1tx.BackColor = Color.Transparent
                        ATC2tx.BackColor = Color.Transparent
                        HFtx.BackColor = Color.Transparent
                        VU1tx.BackColor = Color.Transparent
                        VU2tx.BackColor = Color.Transparent
                        MSR1tx.BackColor = Color.Transparent
                        MSR2tx.BackColor = Color.Transparent
                        btnINT1light.BackColor = Color.Transparent
                        btnINT2light.BackColor = Color.Transparent
                        btnATC1light.BackColor = Color.Transparent
                        btnATC2light.BackColor = Color.Transparent
                        btnHFlight.BackColor = Color.Transparent
                        btnVU1light.BackColor = Color.Transparent
                        btnVU2light.BackColor = Color.Transparent
                        btnMSR1leftLight.BackColor = Color.Transparent
                        btnMSR2leftLight.BackColor = Color.Transparent
                        btnMSR4leftLight.BackColor = Color.Transparent
                        btnCDLleftLight.BackColor = Color.Transparent
                        MSR3tx.BackColor = Color.GreenYellow
                        btnMSR3leftLight.BackColor = Color.YellowGreen
                        MSR4tx.BackColor = Color.Transparent
                        CDLtx.BackColor = Color.Transparent
                    ElseIf imageLoaded = "MSR4" Then  'MSR4 mode
                        lblDisplay.Text = MSR4val
                        OvalShape1.BackgroundImage = My.Resources.MSR4
                        BKUPtx.BackColor = Color.Transparent
                        INT1tx.BackColor = Color.Transparent
                        INT2tx.BackColor = Color.Transparent
                        ATC1tx.BackColor = Color.Transparent
                        ATC2tx.BackColor = Color.Transparent
                        HFtx.BackColor = Color.Transparent
                        VU1tx.BackColor = Color.Transparent
                        VU2tx.BackColor = Color.Transparent
                        MSR1tx.BackColor = Color.Transparent
                        MSR2tx.BackColor = Color.Transparent
                        MSR3tx.BackColor = Color.Transparent
                        btnINT1light.BackColor = Color.Transparent
                        btnINT2light.BackColor = Color.Transparent
                        btnATC1light.BackColor = Color.Transparent
                        btnATC2light.BackColor = Color.Transparent
                        btnHFlight.BackColor = Color.Transparent
                        btnVU1light.BackColor = Color.Transparent
                        btnVU2light.BackColor = Color.Transparent
                        btnMSR1leftLight.BackColor = Color.Transparent
                        btnMSR2leftLight.BackColor = Color.Transparent
                        btnMSR3leftLight.BackColor = Color.Transparent
                        btnCDLleftLight.BackColor = Color.Transparent
                        MSR4tx.BackColor = Color.GreenYellow
                        btnMSR4leftLight.BackColor = Color.YellowGreen
                        CDLtx.BackColor = Color.Transparent
                    ElseIf imageLoaded = "CDL" Then  'CDL mode
                        lblDisplay.Text = CDLval
                        OvalShape1.BackgroundImage = My.Resources.CDL
                        BKUPtx.BackColor = Color.Transparent
                        INT1tx.BackColor = Color.Transparent
                        INT2tx.BackColor = Color.Transparent
                        ATC1tx.BackColor = Color.Transparent
                        ATC2tx.BackColor = Color.Transparent
                        HFtx.BackColor = Color.Transparent
                        VU1tx.BackColor = Color.Transparent
                        VU2tx.BackColor = Color.Transparent
                        MSR1tx.BackColor = Color.Transparent
                        MSR2tx.BackColor = Color.Transparent
                        MSR3tx.BackColor = Color.Transparent
                        MSR4tx.BackColor = Color.Transparent
                        btnINT1light.BackColor = Color.Transparent
                        btnINT2light.BackColor = Color.Transparent
                        btnATC1light.BackColor = Color.Transparent
                        btnATC2light.BackColor = Color.Transparent
                        btnHFlight.BackColor = Color.Transparent
                        btnVU1light.BackColor = Color.Transparent
                        btnVU2light.BackColor = Color.Transparent
                        btnMSR1leftLight.BackColor = Color.Transparent
                        btnMSR2leftLight.BackColor = Color.Transparent
                        btnMSR3leftLight.BackColor = Color.Transparent
                        btnMSR4leftLight.BackColor = Color.Transparent
                        CDLtx.BackColor = Color.GreenYellow
                        btnCDLleftLight.BackColor = Color.YellowGreen
                    Else
                        BKUPtx.BackColor = Color.Transparent
                        INT1tx.BackColor = Color.Transparent
                        INT2tx.BackColor = Color.Transparent
                        ATC1tx.BackColor = Color.Transparent
                        ATC2tx.BackColor = Color.Transparent
                        HFtx.BackColor = Color.Transparent
                        VU1tx.BackColor = Color.Transparent
                        VU2tx.BackColor = Color.Transparent
                        MSR1tx.BackColor = Color.Transparent
                        MSR2tx.BackColor = Color.Transparent
                        MSR3tx.BackColor = Color.Transparent
                        MSR4tx.BackColor = Color.Transparent
                        btnINT1light.BackColor = Color.Transparent
                        btnINT2light.BackColor = Color.Transparent
                        btnATC1light.BackColor = Color.Transparent
                        btnATC2light.BackColor = Color.Transparent
                        btnHFlight.BackColor = Color.Transparent
                        btnVU1light.BackColor = Color.Transparent
                        btnVU2light.BackColor = Color.Transparent
                        btnMSR1leftLight.BackColor = Color.Transparent
                        btnMSR2leftLight.BackColor = Color.Transparent
                        btnMSR3leftLight.BackColor = Color.Transparent
                        btnMSR4leftLight.BackColor = Color.Transparent
                        CDLtx.BackColor = Color.Transparent     ''''
                        btnCDLleftLight.BackColor = Color.Transparent
                    End If


                End If

                If multiINTmode = False Then
                    If imageLoaded = "BKUP" Then   'BKUP mode
                        lblDisplay.Text = ""
                        OvalShape1.BackgroundImage = My.Resources.BCKP2
                        BKUPtx.BackColor = Color.GreenYellow
                        INT1tx.BackColor = Color.GreenYellow
                        INT2tx.BackColor = Color.Transparent
                        ATC1tx.BackColor = Color.Transparent
                        ATC2tx.BackColor = Color.Transparent
                        HFtx.BackColor = Color.Transparent
                        VU1tx.BackColor = Color.Transparent
                        VU2tx.BackColor = Color.Transparent
                        MSR1tx.BackColor = Color.Transparent
                        MSR2tx.BackColor = Color.Transparent
                        MSR3tx.BackColor = Color.Transparent
                        MSR4tx.BackColor = Color.Transparent
                        CDLtx.BackColor = Color.Transparent
                        btnINT1light.BackColor = Color.GreenYellow
                        btnINT2light.BackColor = Color.Transparent
                        btnATC1light.BackColor = Color.Transparent
                        btnATC2light.BackColor = Color.Transparent
                        btnHFlight.BackColor = Color.Transparent
                        btnVU1light.BackColor = Color.Transparent
                        btnVU2light.BackColor = Color.Transparent
                        btnMSR1leftLight.BackColor = Color.Transparent
                        btnMSR2leftLight.BackColor = Color.Transparent
                        btnMSR3leftLight.BackColor = Color.Transparent
                        btnMSR4leftLight.BackColor = Color.Transparent
                        btnCDLleftLight.BackColor = Color.Transparent
                    ElseIf imageLoaded = "INT1" Then   'INT1 mode
                        lblDisplay.Text = INT1val
                        OvalShape1.BackgroundImage = My.Resources.INT1
                        BKUPtx.BackColor = Color.Transparent
                        INT1tx.BackColor = Color.GreenYellow
                        btnINT1light.BackColor = Color.YellowGreen
                        btnINT2light.BackColor = Color.Transparent
                        btnATC1light.BackColor = Color.Transparent
                        btnATC2light.BackColor = Color.Transparent
                        btnHFlight.BackColor = Color.Transparent
                        btnVU1light.BackColor = Color.Transparent
                        btnVU2light.BackColor = Color.Transparent
                        btnMSR1leftLight.BackColor = Color.Transparent
                        btnMSR2leftLight.BackColor = Color.Transparent
                        btnMSR3leftLight.BackColor = Color.Transparent
                        btnMSR4leftLight.BackColor = Color.Transparent
                        btnCDLleftLight.BackColor = Color.Transparent
                        INT2tx.BackColor = Color.Transparent
                        ATC1tx.BackColor = Color.Transparent
                        ATC2tx.BackColor = Color.Transparent
                        HFtx.BackColor = Color.Transparent
                        VU1tx.BackColor = Color.Transparent
                        VU2tx.BackColor = Color.Transparent
                        MSR1tx.BackColor = Color.Transparent
                        MSR2tx.BackColor = Color.Transparent
                        MSR3tx.BackColor = Color.Transparent
                        MSR4tx.BackColor = Color.Transparent
                        CDLtx.BackColor = Color.Transparent
                    ElseIf imageLoaded = "INT2" Then   'INT2 mode
                        lblDisplay.Text = INT2val
                        OvalShape1.BackgroundImage = My.Resources.INT2
                        BKUPtx.BackColor = Color.Transparent
                        INT1tx.BackColor = Color.Transparent
                        btnINT1light.BackColor = Color.Transparent
                        btnATC1light.BackColor = Color.Transparent
                        btnATC2light.BackColor = Color.Transparent
                        btnHFlight.BackColor = Color.Transparent
                        btnVU1light.BackColor = Color.Transparent
                        btnVU2light.BackColor = Color.Transparent
                        btnMSR1leftLight.BackColor = Color.Transparent
                        btnMSR2leftLight.BackColor = Color.Transparent
                        btnMSR3leftLight.BackColor = Color.Transparent
                        btnMSR4leftLight.BackColor = Color.Transparent
                        btnCDLleftLight.BackColor = Color.Transparent
                        INT2tx.BackColor = Color.GreenYellow
                        btnINT2light.BackColor = Color.YellowGreen
                        ATC1tx.BackColor = Color.Transparent
                        ATC2tx.BackColor = Color.Transparent
                        HFtx.BackColor = Color.Transparent
                        VU1tx.BackColor = Color.Transparent
                        VU2tx.BackColor = Color.Transparent
                        MSR1tx.BackColor = Color.Transparent
                        MSR2tx.BackColor = Color.Transparent
                        MSR3tx.BackColor = Color.Transparent
                        MSR4tx.BackColor = Color.Transparent
                        CDLtx.BackColor = Color.Transparent
                    End If

                End If

                If multiINTmode = True Then
                    If knobIndex < 4 Then
                        MoveKnob()
                    End If

                End If



                If multiCastMode = False Then
                    If multiINTmode = False Then


                        If knobIndex = 1 Then   'BKUP mode
                            imageLoaded = "BKUP"
                            lblDisplay.Text = ""
                            OvalShape1.BackgroundImage = My.Resources.BCKP2
                            BKUPtx.BackColor = Color.GreenYellow
                            INT1tx.BackColor = Color.GreenYellow
                            INT2tx.BackColor = Color.Transparent
                            ATC1tx.BackColor = Color.Transparent
                            ATC2tx.BackColor = Color.Transparent
                            HFtx.BackColor = Color.Transparent
                            VU1tx.BackColor = Color.Transparent
                            VU2tx.BackColor = Color.Transparent
                            MSR1tx.BackColor = Color.Transparent
                            MSR2tx.BackColor = Color.Transparent
                            MSR3tx.BackColor = Color.Transparent
                            MSR4tx.BackColor = Color.Transparent
                            CDLtx.BackColor = Color.Transparent
                            btnINT1light.BackColor = Color.GreenYellow
                            btnINT2light.BackColor = Color.Transparent
                            btnATC1light.BackColor = Color.Transparent
                            btnATC2light.BackColor = Color.Transparent
                            btnHFlight.BackColor = Color.Transparent
                            btnVU1light.BackColor = Color.Transparent
                            btnVU2light.BackColor = Color.Transparent
                            btnMSR1leftLight.BackColor = Color.Transparent
                            btnMSR2leftLight.BackColor = Color.Transparent
                            btnMSR3leftLight.BackColor = Color.Transparent
                            btnMSR4leftLight.BackColor = Color.Transparent
                            btnCDLleftLight.BackColor = Color.Transparent
                        ElseIf knobIndex = 2 Then   'INT1 mode
                            imageLoaded = "INT1"
                            lblDisplay.Text = INT1val
                            OvalShape1.BackgroundImage = My.Resources.INT1
                            BKUPtx.BackColor = Color.Transparent
                            INT1tx.BackColor = Color.GreenYellow
                            btnINT1light.BackColor = Color.YellowGreen
                            btnINT2light.BackColor = Color.Transparent
                            btnATC1light.BackColor = Color.Transparent
                            btnATC2light.BackColor = Color.Transparent
                            btnHFlight.BackColor = Color.Transparent
                            btnVU1light.BackColor = Color.Transparent
                            btnVU2light.BackColor = Color.Transparent
                            btnMSR1leftLight.BackColor = Color.Transparent
                            btnMSR2leftLight.BackColor = Color.Transparent
                            btnMSR3leftLight.BackColor = Color.Transparent
                            btnMSR4leftLight.BackColor = Color.Transparent
                            btnCDLleftLight.BackColor = Color.Transparent
                            INT2tx.BackColor = Color.Transparent
                            ATC1tx.BackColor = Color.Transparent
                            ATC2tx.BackColor = Color.Transparent
                            HFtx.BackColor = Color.Transparent
                            VU1tx.BackColor = Color.Transparent
                            VU2tx.BackColor = Color.Transparent
                            MSR1tx.BackColor = Color.Transparent
                            MSR2tx.BackColor = Color.Transparent
                            MSR3tx.BackColor = Color.Transparent
                            MSR4tx.BackColor = Color.Transparent
                            CDLtx.BackColor = Color.Transparent
                        ElseIf knobIndex = 3 Then   'INT2 mode
                            imageLoaded = "INT2"
                            lblDisplay.Text = INT2val
                            OvalShape1.BackgroundImage = My.Resources.INT2
                            BKUPtx.BackColor = Color.Transparent
                            INT1tx.BackColor = Color.Transparent
                            btnINT1light.BackColor = Color.Transparent
                            btnATC1light.BackColor = Color.Transparent
                            btnATC2light.BackColor = Color.Transparent
                            btnHFlight.BackColor = Color.Transparent
                            btnVU1light.BackColor = Color.Transparent
                            btnVU2light.BackColor = Color.Transparent
                            btnMSR1leftLight.BackColor = Color.Transparent
                            btnMSR2leftLight.BackColor = Color.Transparent
                            btnMSR3leftLight.BackColor = Color.Transparent
                            btnMSR4leftLight.BackColor = Color.Transparent
                            btnCDLleftLight.BackColor = Color.Transparent
                            INT2tx.BackColor = Color.GreenYellow
                            btnINT2light.BackColor = Color.YellowGreen
                            ATC1tx.BackColor = Color.Transparent
                            ATC2tx.BackColor = Color.Transparent
                            HFtx.BackColor = Color.Transparent
                            VU1tx.BackColor = Color.Transparent
                            VU2tx.BackColor = Color.Transparent
                            MSR1tx.BackColor = Color.Transparent
                            MSR2tx.BackColor = Color.Transparent
                            MSR3tx.BackColor = Color.Transparent
                            MSR4tx.BackColor = Color.Transparent
                            CDLtx.BackColor = Color.Transparent
                        ElseIf knobIndex = 4 Then   'ATC1 mode
                            imageLoaded = "ATC1"
                            lblDisplay.Text = ATC1val
                            OvalShape1.BackgroundImage = My.Resources.ATC1
                            BKUPtx.BackColor = Color.Transparent
                            INT1tx.BackColor = Color.Transparent
                            INT2tx.BackColor = Color.Transparent
                            btnINT1light.BackColor = Color.Transparent
                            btnINT2light.BackColor = Color.Transparent
                            btnATC2light.BackColor = Color.Transparent
                            btnHFlight.BackColor = Color.Transparent
                            btnVU1light.BackColor = Color.Transparent
                            btnVU2light.BackColor = Color.Transparent
                            btnMSR1leftLight.BackColor = Color.Transparent
                            btnMSR2leftLight.BackColor = Color.Transparent
                            btnMSR3leftLight.BackColor = Color.Transparent
                            btnMSR4leftLight.BackColor = Color.Transparent
                            btnCDLleftLight.BackColor = Color.Transparent
                            ATC1tx.BackColor = Color.GreenYellow
                            btnATC1light.BackColor = Color.GreenYellow
                            ATC2tx.BackColor = Color.Transparent
                            HFtx.BackColor = Color.Transparent
                            VU1tx.BackColor = Color.Transparent
                            VU2tx.BackColor = Color.Transparent
                            MSR1tx.BackColor = Color.Transparent
                            MSR2tx.BackColor = Color.Transparent
                            MSR3tx.BackColor = Color.Transparent
                            MSR4tx.BackColor = Color.Transparent
                            CDLtx.BackColor = Color.Transparent
                        ElseIf knobIndex = 5 Then   'ATC2 mode
                            imageLoaded = "ATC2"
                            lblDisplay.Text = ATC2val
                            OvalShape1.BackgroundImage = My.Resources.ATC2
                            BKUPtx.BackColor = Color.Transparent
                            INT1tx.BackColor = Color.Transparent
                            INT2tx.BackColor = Color.Transparent
                            ATC1tx.BackColor = Color.Transparent
                            btnINT1light.BackColor = Color.Transparent
                            btnINT2light.BackColor = Color.Transparent
                            btnATC1light.BackColor = Color.Transparent
                            btnHFlight.BackColor = Color.Transparent
                            btnVU1light.BackColor = Color.Transparent
                            btnVU2light.BackColor = Color.Transparent
                            btnMSR1leftLight.BackColor = Color.Transparent
                            btnMSR2leftLight.BackColor = Color.Transparent
                            btnMSR3leftLight.BackColor = Color.Transparent
                            btnMSR4leftLight.BackColor = Color.Transparent
                            btnCDLleftLight.BackColor = Color.Transparent
                            ATC2tx.BackColor = Color.GreenYellow
                            btnATC2light.BackColor = Color.YellowGreen
                            HFtx.BackColor = Color.Transparent
                            VU1tx.BackColor = Color.Transparent
                            VU2tx.BackColor = Color.Transparent
                            MSR1tx.BackColor = Color.Transparent
                            MSR2tx.BackColor = Color.Transparent
                            MSR3tx.BackColor = Color.Transparent
                            MSR4tx.BackColor = Color.Transparent
                            CDLtx.BackColor = Color.Transparent
                        ElseIf knobIndex = 6 Then   'HF mode
                            imageLoaded = "HF"
                            lblDisplay.Text = HFval
                            OvalShape1.BackgroundImage = My.Resources.HF
                            BKUPtx.BackColor = Color.Transparent
                            INT1tx.BackColor = Color.Transparent
                            INT2tx.BackColor = Color.Transparent
                            ATC1tx.BackColor = Color.Transparent
                            ATC2tx.BackColor = Color.Transparent
                            btnINT1light.BackColor = Color.Transparent
                            btnINT2light.BackColor = Color.Transparent
                            btnATC1light.BackColor = Color.Transparent
                            btnATC2light.BackColor = Color.Transparent
                            btnVU1light.BackColor = Color.Transparent
                            btnVU2light.BackColor = Color.Transparent
                            btnMSR1leftLight.BackColor = Color.Transparent
                            btnMSR2leftLight.BackColor = Color.Transparent
                            btnMSR3leftLight.BackColor = Color.Transparent
                            btnMSR4leftLight.BackColor = Color.Transparent
                            btnCDLleftLight.BackColor = Color.Transparent
                            HFtx.BackColor = Color.GreenYellow
                            btnHFlight.BackColor = Color.YellowGreen
                            VU1tx.BackColor = Color.Transparent
                            VU2tx.BackColor = Color.Transparent
                            MSR1tx.BackColor = Color.Transparent
                            MSR2tx.BackColor = Color.Transparent
                            MSR3tx.BackColor = Color.Transparent
                            MSR4tx.BackColor = Color.Transparent
                            CDLtx.BackColor = Color.Transparent
                        ElseIf knobIndex = 7 Then   'VU1 mode
                            imageLoaded = "VU1"
                            lblDisplay.Text = VU1val
                            OvalShape1.BackgroundImage = My.Resources.VU1
                            BKUPtx.BackColor = Color.Transparent
                            INT1tx.BackColor = Color.Transparent
                            INT2tx.BackColor = Color.Transparent
                            ATC1tx.BackColor = Color.Transparent
                            ATC2tx.BackColor = Color.Transparent
                            HFtx.BackColor = Color.Transparent
                            btnINT1light.BackColor = Color.Transparent
                            btnINT2light.BackColor = Color.Transparent
                            btnATC1light.BackColor = Color.Transparent
                            btnATC2light.BackColor = Color.Transparent
                            btnHFlight.BackColor = Color.Transparent
                            btnVU2light.BackColor = Color.Transparent
                            btnMSR1leftLight.BackColor = Color.Transparent
                            btnMSR2leftLight.BackColor = Color.Transparent
                            btnMSR3leftLight.BackColor = Color.Transparent
                            btnMSR4leftLight.BackColor = Color.Transparent
                            btnCDLleftLight.BackColor = Color.Transparent
                            VU1tx.BackColor = Color.GreenYellow
                            btnVU1light.BackColor = Color.YellowGreen
                            VU2tx.BackColor = Color.Transparent
                            MSR1tx.BackColor = Color.Transparent
                            MSR2tx.BackColor = Color.Transparent
                            MSR3tx.BackColor = Color.Transparent
                            MSR4tx.BackColor = Color.Transparent
                            CDLtx.BackColor = Color.Transparent
                        ElseIf knobIndex = 8 Then   'VU2 mode
                            imageLoaded = "VU2"
                            lblDisplay.Text = VU2val
                            OvalShape1.BackgroundImage = My.Resources.VU2
                            BKUPtx.BackColor = Color.Transparent
                            INT1tx.BackColor = Color.Transparent
                            INT2tx.BackColor = Color.Transparent
                            ATC1tx.BackColor = Color.Transparent
                            ATC2tx.BackColor = Color.Transparent
                            HFtx.BackColor = Color.Transparent
                            VU1tx.BackColor = Color.Transparent
                            btnINT1light.BackColor = Color.Transparent
                            btnINT2light.BackColor = Color.Transparent
                            btnATC1light.BackColor = Color.Transparent
                            btnATC2light.BackColor = Color.Transparent
                            btnHFlight.BackColor = Color.Transparent
                            btnVU1light.BackColor = Color.Transparent
                            btnMSR1leftLight.BackColor = Color.Transparent
                            btnMSR2leftLight.BackColor = Color.Transparent
                            btnMSR3leftLight.BackColor = Color.Transparent
                            btnMSR4leftLight.BackColor = Color.Transparent
                            btnCDLleftLight.BackColor = Color.Transparent
                            VU2tx.BackColor = Color.GreenYellow
                            btnVU2light.BackColor = Color.YellowGreen
                            MSR1tx.BackColor = Color.Transparent
                            MSR2tx.BackColor = Color.Transparent
                            MSR3tx.BackColor = Color.Transparent
                            MSR4tx.BackColor = Color.Transparent
                            CDLtx.BackColor = Color.Transparent
                        ElseIf knobIndex = 9 Then   'MSR1 mode
                            imageLoaded = "MSR1"
                            lblDisplay.Text = MSR1val
                            OvalShape1.BackgroundImage = My.Resources.MSR1
                            BKUPtx.BackColor = Color.Transparent
                            INT1tx.BackColor = Color.Transparent
                            INT2tx.BackColor = Color.Transparent
                            ATC1tx.BackColor = Color.Transparent
                            ATC2tx.BackColor = Color.Transparent
                            HFtx.BackColor = Color.Transparent
                            VU1tx.BackColor = Color.Transparent
                            VU2tx.BackColor = Color.Transparent
                            btnINT1light.BackColor = Color.Transparent
                            btnINT2light.BackColor = Color.Transparent
                            btnATC1light.BackColor = Color.Transparent
                            btnATC2light.BackColor = Color.Transparent
                            btnHFlight.BackColor = Color.Transparent
                            btnVU1light.BackColor = Color.Transparent
                            btnVU2light.BackColor = Color.Transparent
                            btnMSR2leftLight.BackColor = Color.Transparent
                            btnMSR3leftLight.BackColor = Color.Transparent
                            btnMSR4leftLight.BackColor = Color.Transparent
                            btnCDLleftLight.BackColor = Color.Transparent
                            MSR1tx.BackColor = Color.GreenYellow
                            btnMSR1leftLight.BackColor = Color.YellowGreen
                            MSR2tx.BackColor = Color.Transparent
                            MSR3tx.BackColor = Color.Transparent
                            MSR4tx.BackColor = Color.Transparent
                            CDLtx.BackColor = Color.Transparent
                        ElseIf knobIndex = 10 Then  'MSR2 mode
                            imageLoaded = "MSR2"
                            lblDisplay.Text = MSR2val
                            OvalShape1.BackgroundImage = My.Resources.MSR2
                            BKUPtx.BackColor = Color.Transparent
                            INT1tx.BackColor = Color.Transparent
                            INT2tx.BackColor = Color.Transparent
                            ATC1tx.BackColor = Color.Transparent
                            ATC2tx.BackColor = Color.Transparent
                            HFtx.BackColor = Color.Transparent
                            VU1tx.BackColor = Color.Transparent
                            VU2tx.BackColor = Color.Transparent
                            MSR1tx.BackColor = Color.Transparent
                            btnINT1light.BackColor = Color.Transparent
                            btnINT2light.BackColor = Color.Transparent
                            btnATC1light.BackColor = Color.Transparent
                            btnATC2light.BackColor = Color.Transparent
                            btnHFlight.BackColor = Color.Transparent
                            btnVU1light.BackColor = Color.Transparent
                            btnVU2light.BackColor = Color.Transparent
                            btnMSR1leftLight.BackColor = Color.Transparent
                            btnMSR3leftLight.BackColor = Color.Transparent
                            btnMSR4leftLight.BackColor = Color.Transparent
                            btnCDLleftLight.BackColor = Color.Transparent
                            MSR2tx.BackColor = Color.GreenYellow
                            btnMSR2leftLight.BackColor = Color.YellowGreen
                            MSR3tx.BackColor = Color.Transparent
                            MSR4tx.BackColor = Color.Transparent
                            CDLtx.BackColor = Color.Transparent
                        ElseIf knobIndex = 11 Then  'MSR3 mode
                            imageLoaded = "MSR3"
                            lblDisplay.Text = MSR3val
                            OvalShape1.BackgroundImage = My.Resources.MSR3
                            BKUPtx.BackColor = Color.Transparent
                            INT1tx.BackColor = Color.Transparent
                            INT2tx.BackColor = Color.Transparent
                            ATC1tx.BackColor = Color.Transparent
                            ATC2tx.BackColor = Color.Transparent
                            HFtx.BackColor = Color.Transparent
                            VU1tx.BackColor = Color.Transparent
                            VU2tx.BackColor = Color.Transparent
                            MSR1tx.BackColor = Color.Transparent
                            MSR2tx.BackColor = Color.Transparent
                            btnINT1light.BackColor = Color.Transparent
                            btnINT2light.BackColor = Color.Transparent
                            btnATC1light.BackColor = Color.Transparent
                            btnATC2light.BackColor = Color.Transparent
                            btnHFlight.BackColor = Color.Transparent
                            btnVU1light.BackColor = Color.Transparent
                            btnVU2light.BackColor = Color.Transparent
                            btnMSR1leftLight.BackColor = Color.Transparent
                            btnMSR2leftLight.BackColor = Color.Transparent
                            btnMSR4leftLight.BackColor = Color.Transparent
                            btnCDLleftLight.BackColor = Color.Transparent
                            MSR3tx.BackColor = Color.GreenYellow
                            btnMSR3leftLight.BackColor = Color.YellowGreen
                            MSR4tx.BackColor = Color.Transparent
                            CDLtx.BackColor = Color.Transparent
                        ElseIf knobIndex = 12 Then  'MSR4 mode
                            imageLoaded = "MSR4"
                            lblDisplay.Text = MSR4val
                            OvalShape1.BackgroundImage = My.Resources.MSR4
                            BKUPtx.BackColor = Color.Transparent
                            INT1tx.BackColor = Color.Transparent
                            INT2tx.BackColor = Color.Transparent
                            ATC1tx.BackColor = Color.Transparent
                            ATC2tx.BackColor = Color.Transparent
                            HFtx.BackColor = Color.Transparent
                            VU1tx.BackColor = Color.Transparent
                            VU2tx.BackColor = Color.Transparent
                            MSR1tx.BackColor = Color.Transparent
                            MSR2tx.BackColor = Color.Transparent
                            MSR3tx.BackColor = Color.Transparent
                            btnINT1light.BackColor = Color.Transparent
                            btnINT2light.BackColor = Color.Transparent
                            btnATC1light.BackColor = Color.Transparent
                            btnATC2light.BackColor = Color.Transparent
                            btnHFlight.BackColor = Color.Transparent
                            btnVU1light.BackColor = Color.Transparent
                            btnVU2light.BackColor = Color.Transparent
                            btnMSR1leftLight.BackColor = Color.Transparent
                            btnMSR2leftLight.BackColor = Color.Transparent
                            btnMSR3leftLight.BackColor = Color.Transparent
                            btnCDLleftLight.BackColor = Color.Transparent
                            MSR4tx.BackColor = Color.GreenYellow
                            btnMSR4leftLight.BackColor = Color.YellowGreen
                            CDLtx.BackColor = Color.Transparent
                        ElseIf knobIndex = 13 Then  'CDL mode
                            imageLoaded = "CDL"
                            lblDisplay.Text = CDLval
                            OvalShape1.BackgroundImage = My.Resources.CDL
                            BKUPtx.BackColor = Color.Transparent
                            INT1tx.BackColor = Color.Transparent
                            INT2tx.BackColor = Color.Transparent
                            ATC1tx.BackColor = Color.Transparent
                            ATC2tx.BackColor = Color.Transparent
                            HFtx.BackColor = Color.Transparent
                            VU1tx.BackColor = Color.Transparent
                            VU2tx.BackColor = Color.Transparent
                            MSR1tx.BackColor = Color.Transparent
                            MSR2tx.BackColor = Color.Transparent
                            MSR3tx.BackColor = Color.Transparent
                            MSR4tx.BackColor = Color.Transparent
                            btnINT1light.BackColor = Color.Transparent
                            btnINT2light.BackColor = Color.Transparent
                            btnATC1light.BackColor = Color.Transparent
                            btnATC2light.BackColor = Color.Transparent
                            btnHFlight.BackColor = Color.Transparent
                            btnVU1light.BackColor = Color.Transparent
                            btnVU2light.BackColor = Color.Transparent
                            btnMSR1leftLight.BackColor = Color.Transparent
                            btnMSR2leftLight.BackColor = Color.Transparent
                            btnMSR3leftLight.BackColor = Color.Transparent
                            btnMSR4leftLight.BackColor = Color.Transparent
                            CDLtx.BackColor = Color.GreenYellow
                            btnCDLleftLight.BackColor = Color.YellowGreen
                        End If
                    End If
                End If

                StaticLightTest()

                ReloadLights()


            End If
        End If
    End Sub

    Private Sub MoveKnob()

        Dim info As String

        If ICUfailLight.Visible = True Then


            info = "Turning the transmit select knob during an ICU fail will not do anything. The system remains in emergency mode allowing intercom functions to the crew."
            Information.Label1.Text = info
        End If

        If knobIndex = 1 Then   'BKUP mode
            OvalShape1.BackgroundImage = My.Resources.BCKP2
        ElseIf knobIndex = 2 Then   'INT1 mode
            OvalShape1.BackgroundImage = My.Resources.INT1
        ElseIf knobIndex = 3 Then   'INT2 mode
            OvalShape1.BackgroundImage = My.Resources.INT2
        ElseIf knobIndex = 4 Then   'ATC1 mode
            OvalShape1.BackgroundImage = My.Resources.ATC1
        ElseIf knobIndex = 5 Then   'ATC2 mode
            OvalShape1.BackgroundImage = My.Resources.ATC2
        ElseIf knobIndex = 6 Then   'HF mode
            OvalShape1.BackgroundImage = My.Resources.HF
        ElseIf knobIndex = 7 Then   'VU1 mode
            OvalShape1.BackgroundImage = My.Resources.VU1
        ElseIf knobIndex = 8 Then   'VU2 mode
            OvalShape1.BackgroundImage = My.Resources.VU2
        ElseIf knobIndex = 9 Then   'MSR1 mode
            OvalShape1.BackgroundImage = My.Resources.MSR1
        ElseIf knobIndex = 10 Then  'MSR2 mode
            OvalShape1.BackgroundImage = My.Resources.MSR2
        ElseIf knobIndex = 11 Then  'MSR3 mode
            OvalShape1.BackgroundImage = My.Resources.MSR3
        ElseIf knobIndex = 12 Then  'MSR4 mode
            OvalShape1.BackgroundImage = My.Resources.MSR4
        ElseIf knobIndex = 13 Then  'CDL mode
            OvalShape1.BackgroundImage = My.Resources.CDL
        End If

        '8-29 added to update the display window when the knob is turned in similcast mode
        DisplayUpdate()
        'end 8-29
    End Sub

    'Windows

    Private Sub DisplayPwrBit()


        lblDisplay.Text = "PBIT OK"

    End Sub

    Private Sub MainForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        formIsClosed = True

    End Sub
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        'Create thread for display update
        Dim t As Thread
        t = New Thread(AddressOf Me.timeDelay)

        CheckForIllegalCrossThreadCalls = False
        timeDelayCount = 0

        t.Start()

        DisplayPwrBit()


        Dim Info As String
        Dim informationBox As New Information


        AboutBox1.ShowDialog()
        Info = "Thank you for using the Mission Control Audio Panel (MCAP) desktop trainer. Throughout the simulation, windows will open providing text guidance for the user. PLEASE READ THE TEXT BEFORE CLICKING ON THE MCAP. The text will guide you on what to do next. Once you are familiar with the basic operation of the MCAP, you can then explore features without following the scripted steps. Click continue to begin."
        Welcome.Label1.Text = Info
        Welcome.ShowDialog()
        InfoWindow()

        DimmerSetup()
        SetAlphas()






    End Sub

    Public Sub InfoWindow()

        Dim info As String

        If ICUfailLight.Visible = True Then
            info = "In the event of an ICU failure, the display will be blank, all receive indicator lights will extinguish, and the ICU fail light will be illuminated."
        Else



            If Information.walkThrough = False Then



                info = "This is the information window of the desktop trainer. This guide will aid you in exploring the MCAP. You can move this window to any position or minimize it if you like. A new information window will open to explain the functions as you select items on the MCAP. The MCAP is displayed to the right. Moving the mouse cursor over an MCAP button will display a hand icon. The hand icon indicates a physical item on the MCAP that can be manipulated. Clicking the buttons will display a guide describing the actions of that switch. If the mouse cursor turns into a cross, that means the mouse is over an area that can be manipulated only in this simulator. The cross provides a quick way of turning the knob to HF, for example. Click on the MCAP display to begin (the display is the rectangle on the mcap that is showing MVOL 06)."
            Else

                info = "This is the information window of the desktop trainer. This guide will aid you in exploring the MCAP. The system will start in walk-through mode. If this is your first time to explore the MCAP desktop trainer, stay in walk-through mode until you complete the trainer in its entirety. After that you can explore other functions of the desktop simulator.The MCAP is displayed to the right. Moving the mouse cursor over an MCAP button will display a hand icon. The hand icon indicates a physical item on the MCAP that can be manipulated. Clicking the buttons will display a guide describing the actions of that switch. If the mouse cursor turns into a cross, that means the mouse is over an area that can be manipulated only in this simulator. The cross provides a quick way of turning the knob to HF, for example. Click on the MCAP display to begin (the display is the rectangle on the mcap that is showing MVOL 06)."


            End If
        End If

        Information.Label1.Text = info
        Information.Show()




    End Sub

    Public Sub ViewMCAP()

        Dim info As String

        info = "The menu bar allows you to view certain failure modes of the MCAP system such as an ICU communications failure. Simply select the failure you wish to view and the failure will be displayed on the MCAP. Select TRAINER from the menu to return to the desktop simulator. This will take you out of WALKTHOUGH mode so you can explore more functions of the MCAP. You can also minimize the information window from the menu if you want to view the MCAP by itself. Click MODES again and then click TRAINER to begin exploring in a non-linear fashion."
        Information.Label1.Text = info
        Information.Show()



    End Sub

    'Volumes
    Private Sub timeDelay()
        timeStart = 0
        timeEnd = 0



        Do  'begin new thread to time display

            If formIsClosed = True Then 'checks to see if the main form is closed
                Exit Do 'exits do loop and closes thread if form is closed
            End If

            System.Threading.Thread.Sleep(1000)
            timeEnd = timeEnd + 1
            naptime = timeEnd
            If (timeEnd - delayLength) = timeStart Then   'checks for 5 second duration

                Try


                    If lblDisplay.Text.Substring(0, 4) <> "CALL" Then  'aborts update for CALL function
                        MasterVolumeDisplay()   'call subroutine to update display w/MVOL
                    End If

                Catch ex As Exception

                End Try
            End If
            timeDelayCount = timeDelayCount + 1

        Loop



    End Sub

    Private Sub volumeLevels()
        If k = "MVOL" Then
            MVOLval = lblDisplay.Text
        ElseIf k = "ATC1" Then
            ATC1val = lblDisplay.Text
            ATC1ATC2 = "ATC  " + ATC1val.Substring(5, 2) + ATC2val.Substring(5, 2)
        ElseIf k = "ATC2" Then
            ATC2val = lblDisplay.Text
            ATC1ATC2 = "ATC  " + ATC1val.Substring(5, 2) + ATC2val.Substring(5, 2)
        ElseIf k = "HF  " Then
            HFval = lblDisplay.Text
            HFDF = "HFDF " + HFval.Substring(5, 2) + ADFval.Substring(5, 2)
        ElseIf k = "ADF " Then
            ADFval = lblDisplay.Text
            HFDF = "HFDF " + HFval.Substring(5, 2) + ADFval.Substring(5, 2)
        ElseIf k = "VU1 " Then
            VU1val = lblDisplay.Text
        ElseIf k = "VU2 " Then
            VU2val = lblDisplay.Text
        ElseIf k = "VOR1" Then
            VOR1val = lblDisplay.Text
            VOR1VOR2 = "VOR  " + VOR1val.Substring(5, 2) + VOR2val.Substring(5, 2)
        ElseIf k = "VOR2" Then
            VOR2val = lblDisplay.Text
            VOR1VOR2 = "VOR  " + VOR1val.Substring(5, 2) + VOR2val.Substring(5, 2)
        ElseIf k = "MKR " Then
            MKRval = lblDisplay.Text
            MKRTCN = "MKTN " + MKRval.Substring(5, 2) + TCNval.Substring(5, 2)
        ElseIf k = "TCN " Then
            TCNval = lblDisplay.Text
            MKRTCN = "MKTN " + MKRval.Substring(5, 2) + TCNval.Substring(5, 2)
        ElseIf k = "DME1" Then
            DME1val = lblDisplay.Text
            DME1DME2 = "DME  " + DME1val.Substring(5, 2) + DME2val.Substring(5, 2)
        ElseIf k = "DME2" Then
            DME2val = lblDisplay.Text
            DME1DME2 = "DME  " + DME1val.Substring(5, 2) + DME2val.Substring(5, 2)
        ElseIf k = "INT1" Then
            INT1val = lblDisplay.Text
            INT1INT2 = "INT  " + INT1val.Substring(5, 2) + INT2val.Substring(5, 2)
        ElseIf k = "INT2" Then
            INT2val = lblDisplay.Text
            INT1INT2 = "INT  " + INT1val.Substring(5, 2) + INT2val.Substring(5, 2)
        ElseIf k = "MSR2" Then
            MSR2val = lblDisplay.Text
        ElseIf k = "MSR2" Then
            MSR2val = lblDisplay.Text
        ElseIf k = "MSR3" Then
            MSR3val = lblDisplay.Text
        ElseIf k = "MSR4" Then
            MSR4val = lblDisplay.Text
        ElseIf k = "CDL " Then
            CDLval = lblDisplay.Text
        ElseIf k = "ATC " Then
            ATC1ATC2 = lblDisplay.Text
            ATC1val = "ATC1 " + ATC1ATC2.Substring(5, 2)
            ATC2val = "ATC2 " + ATC1ATC2.Substring(7, 2)
        ElseIf k = "HFDF" Then
            HFDF = lblDisplay.Text
            HFval = "HF   " + HFDF.Substring(5, 2)
            ADFval = "ADF  " + HFDF.Substring(7, 2)
        ElseIf k = "VOR " Then
            VOR1VOR2 = lblDisplay.Text
            VOR1val = "VOR1 " + VOR1VOR2.Substring(5, 2)
            VOR2val = "VOR2 " + VOR1VOR2.Substring(7, 2)
        ElseIf k = "MKTN" Then
            MKRTCN = lblDisplay.Text
            MKRval = "MKR  " + MKRTCN.Substring(5, 2)
            TCNval = "TCN  " + MKRTCN.Substring(7, 2)
        ElseIf k = "DME " Then
            DME1DME2 = lblDisplay.Text
            DME1val = "DME1 " + DME1DME2.Substring(5, 2)
            DME2val = "DME2 " + DME1DME2.Substring(7, 2)
        ElseIf k = "INT " Then
            INT1INT2 = lblDisplay.Text
            INT1val = "INT1 " + INT1INT2.Substring(5, 2)
            INT2val = "INT2 " + INT1INT2.Substring(7, 2)
        End If


    End Sub

    Private Sub MasterVolumeDisplay()
        lblDisplay.Text = MVOLval
    End Sub

    'Simulcast
    Private Sub multiSelect()

        'TEST 8/26 12:00
        'IF no lights are on set MultiCastMode to True
        If BKUPtx.BackColor <> Color.Transparent Then
            multiCastMode = True
            'ElseIf INT1tx.BackColor <> Color.Transparent Then
            '    multiCastMode = True
            'ElseIf INT2tx.BackColor <> Color.Transparent Then
            '    multiCastMode = True
        ElseIf ATC1tx.BackColor <> Color.Transparent Then
            multiCastMode = True
        ElseIf ATC2tx.BackColor <> Color.Transparent Then
            multiCastMode = True
        ElseIf HFtx.BackColor <> Color.Transparent Then
            multiCastMode = True
        ElseIf VU1tx.BackColor <> Color.Transparent Then
            multiCastMode = True
        ElseIf VU2tx.BackColor <> Color.Transparent Then
            multiCastMode = True
        ElseIf MSR1tx.BackColor <> Color.Transparent Then
            multiCastMode = True
        ElseIf MSR2tx.BackColor <> Color.Transparent Then
            multiCastMode = True
        ElseIf MSR3tx.BackColor <> Color.Transparent Then
            multiCastMode = True
        ElseIf MSR4tx.BackColor <> Color.Transparent Then
            multiCastMode = True
        ElseIf CDLtx.BackColor <> Color.Transparent Then
            multiCastMode = True

        End If
        'END TEST 8/26 12:00

        'IF no lights are on set MultiCastMode to False
        If BKUPtx.BackColor = Color.Transparent Then
            'If INT1tx.BackColor = Color.Transparent Then
            '    If INT2tx.BackColor = Color.Transparent Then
            If ATC1tx.BackColor = Color.Transparent Then
                If ATC2tx.BackColor = Color.Transparent Then
                    If HFtx.BackColor = Color.Transparent Then
                        If VU1tx.BackColor = Color.Transparent Then
                            If VU2tx.BackColor = Color.Transparent Then
                                If MSR1tx.BackColor = Color.Transparent Then
                                    If MSR2tx.BackColor = Color.Transparent Then
                                        If MSR3tx.BackColor = Color.Transparent Then
                                            If MSR4tx.BackColor = Color.Transparent Then
                                                If CDLtx.BackColor = Color.Transparent Then
                                                    multiCastMode = False
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
        '    End If
        'End If

    End Sub

    Private Sub INTSelect()


        'IF no lights are on set multiintmode to True
        If INT1tx.BackColor <> Color.Transparent Then
            multiINTmode = True
        ElseIf INT2tx.BackColor <> Color.Transparent Then
            multiINTmode = True
        End If


        'IF no lights are on set multiintmode to False
        If INT1tx.BackColor = Color.Transparent Then
            If INT2tx.BackColor = Color.Transparent Then
                multiINTmode = False
            End If

        End If
    End Sub

    Private Sub TransmitHold() ''''''''''''''''''''''''''9-03 9:30PM

        '8-28 Pressing the SEL button without turning the knob first causes the CDLtx light to illuminate. This code addition checks the knobindex against the loaded knob image. If they agree, knobindex will be bumped up to 3. If they don't agree, the code is bypassed.
        'If knobIndex = 1 Then
        '    If imageLoaded = "INT1" Then
        '        knobIndex = 3
        '    End If
        'End If
        ' end 8-28

        If imageLoaded = "CDL" Then
            If CDLtxState = False Then
                CDLtxState = True
                CDLtx.BackColor = Color.GreenYellow
            ElseIf CDLtxState = True Then
                CDLtxState = False
                CDLtx.BackColor = Color.Transparent
                If CDLcount = 1 Then
                    btnCDLleftLight.BackColor = Color.Transparent
                End If
            End If
        End If



        If imageLoaded = "ATC1" Then
            If ATC1txState = False Then
                ATC1txState = True
                ATC1tx.BackColor = Color.GreenYellow
            ElseIf ATC1txState = True Then
                ATC1txState = False
                ATC1tx.BackColor = Color.Transparent
                If ATCcount = 1 Or ATCcount = 3 Or ATCcount = 0 Then
                    btnATC1light.BackColor = Color.Transparent
                End If
            End If
        End If

        If imageLoaded = "ATC2" Then
            If ATC2txState = False Then
                ATC2txState = True
                ATC2tx.BackColor = Color.GreenYellow
            ElseIf ATC2txState = True Then
                ATC2txState = False
                ATC2tx.BackColor = Color.Transparent
                If ATCcount = 1 Or ATCcount = 2 Or ATCcount = 0 Then
                    btnATC2light.BackColor = Color.Transparent
                End If
            End If
        End If

        If imageLoaded = "HF" Then
            If HFtxState = False Then
                HFtxState = True
                HFtx.BackColor = Color.GreenYellow
            ElseIf HFtxState = True Then
                HFtxState = False
                HFtx.BackColor = Color.Transparent
                If HFADFcount = 1 Or HFADFcount = 3 Or HFADFcount = 0 Then
                    btnHFlight.BackColor = Color.Transparent
                End If
            End If
        End If

        If imageLoaded = "VU1" Then
            If VU1txState = False Then
                VU1txState = True
                VU1tx.BackColor = Color.GreenYellow
            ElseIf VU1txState = True Then
                VU1txState = False
                VU1tx.BackColor = Color.Transparent
                If VU1count = 1 Then
                    btnVU1light.BackColor = Color.Transparent
                End If
            End If
        End If

        If imageLoaded = "VU2" Then
            If VU2txState = False Then
                VU2txState = True
                VU2tx.BackColor = Color.GreenYellow
            ElseIf VU2txState = True Then
                VU2txState = False
                VU2tx.BackColor = Color.Transparent
                If VU2count = 1 Then
                    btnVU2light.BackColor = Color.Transparent
                End If
            End If
        End If

        If imageLoaded = "MSR1" Then
            If MSR1txState = False Then
                MSR1txState = True
                MSR1tx.BackColor = Color.GreenYellow
            ElseIf MSR1txState = True Then
                MSR1txState = False
                MSR1tx.BackColor = Color.Transparent
                If MSR1count = 1 Then
                    btnMSR1leftLight.BackColor = Color.Transparent
                End If
            End If
        End If

        If imageLoaded = "MSR2" Then
            If MSR2txState = False Then
                MSR2txState = True
                MSR2tx.BackColor = Color.GreenYellow
            ElseIf MSR2txState = True Then
                MSR2txState = False
                MSR2tx.BackColor = Color.Transparent
                If MSR2count = 1 Then
                    btnMSR2leftLight.BackColor = Color.Transparent
                End If
            End If
        End If

        If imageLoaded = "MSR3" Then
            If MSR3txState = False Then
                MSR3txState = True
                MSR3tx.BackColor = Color.GreenYellow
            ElseIf MSR3txState = True Then
                MSR3txState = False
                MSR3tx.BackColor = Color.Transparent
                If MSR3count = 1 Then
                    btnMSR3leftLight.BackColor = Color.Transparent
                End If
            End If
        End If

        If imageLoaded = "MSR4" Then
            If MSR4txState = False Then
                MSR4txState = True
                MSR4tx.BackColor = Color.GreenYellow
            ElseIf MSR4txState = True Then
                MSR4txState = False
                MSR4tx.BackColor = Color.Transparent
                If MSR4count = 1 Then
                    btnMSR4leftLight.BackColor = Color.Transparent
                End If
            End If
        End If

    End Sub

    Private Sub IntHold() ''''''''''''''''''''''''

        '9-01 Pressing the SEL button without turning the knob first causes the CDLtx light to illuminate. This code addition checks the knobindex against the loaded knob image. If they agree, knobindex will be bumped up to 3. If they don't agree, the code is bypassed.
        'If knobIndex = 1 Then
        '    If imageLoaded = "INT1" Then
        '        knobIndex = 3
        '    End If
        'End If
        ' end 9-01

        If multiINTmode = True Then


            If imageLoaded = "INT1" Then
                If INT1txState = False Then
                    INT1txState = True
                    INT1tx.BackColor = Color.GreenYellow
                ElseIf INT1txState = True Then
                    INT1txState = False
                    INT1tx.BackColor = Color.Transparent
                    If INTcount = 1 Or INTcount = 3 Or INTcount = 0 Then
                        btnINT1light.BackColor = Color.Transparent
                    End If
                End If
            End If

            If imageLoaded = "INT2" Then
                If INT2txState = False Then
                    INT2txState = True
                    INT2tx.BackColor = Color.GreenYellow
                ElseIf INT2txState = True Then
                    INT2txState = False
                    INT2tx.BackColor = Color.Transparent
                    If INTcount = 1 Or INTcount = 2 Or INTcount = 0 Then
                        btnINT2light.BackColor = Color.Transparent
                    End If
                End If
            End If
        End If

        If multiCastMode = False Then
            If imageLoaded = "ATC1" Then   'ATC1 mode
                lblDisplay.Text = ATC1val
                OvalShape1.BackgroundImage = My.Resources.ATC1
                BKUPtx.BackColor = Color.Transparent
                INT1tx.BackColor = Color.Transparent
                INT2tx.BackColor = Color.Transparent
                btnINT1light.BackColor = Color.Transparent
                btnINT2light.BackColor = Color.Transparent
                btnATC2light.BackColor = Color.Transparent
                btnHFlight.BackColor = Color.Transparent
                btnVU1light.BackColor = Color.Transparent
                btnVU2light.BackColor = Color.Transparent
                btnMSR1leftLight.BackColor = Color.Transparent
                btnMSR2leftLight.BackColor = Color.Transparent
                btnMSR3leftLight.BackColor = Color.Transparent
                btnMSR4leftLight.BackColor = Color.Transparent
                btnCDLleftLight.BackColor = Color.Transparent

                'If multiCastMode = False Then
                ATC1tx.BackColor = Color.GreenYellow
                btnATC1light.BackColor = Color.GreenYellow
                'End If

                ATC2tx.BackColor = Color.Transparent
                HFtx.BackColor = Color.Transparent
                VU1tx.BackColor = Color.Transparent
                VU2tx.BackColor = Color.Transparent
                MSR1tx.BackColor = Color.Transparent
                MSR2tx.BackColor = Color.Transparent
                MSR3tx.BackColor = Color.Transparent
                MSR4tx.BackColor = Color.Transparent
                CDLtx.BackColor = Color.Transparent
            ElseIf imageLoaded = "ATC2" Then   'ATC2 mode
                lblDisplay.Text = ATC2val
                OvalShape1.BackgroundImage = My.Resources.ATC2
                BKUPtx.BackColor = Color.Transparent
                INT1tx.BackColor = Color.Transparent
                INT2tx.BackColor = Color.Transparent
                ATC1tx.BackColor = Color.Transparent
                btnINT1light.BackColor = Color.Transparent
                btnINT2light.BackColor = Color.Transparent
                btnATC1light.BackColor = Color.Transparent
                btnHFlight.BackColor = Color.Transparent
                btnVU1light.BackColor = Color.Transparent
                btnVU2light.BackColor = Color.Transparent
                btnMSR1leftLight.BackColor = Color.Transparent
                btnMSR2leftLight.BackColor = Color.Transparent
                btnMSR3leftLight.BackColor = Color.Transparent
                btnMSR4leftLight.BackColor = Color.Transparent
                btnCDLleftLight.BackColor = Color.Transparent
                ATC2tx.BackColor = Color.GreenYellow
                btnATC2light.BackColor = Color.YellowGreen
                HFtx.BackColor = Color.Transparent
                VU1tx.BackColor = Color.Transparent
                VU2tx.BackColor = Color.Transparent
                MSR1tx.BackColor = Color.Transparent
                MSR2tx.BackColor = Color.Transparent
                MSR3tx.BackColor = Color.Transparent
                MSR4tx.BackColor = Color.Transparent
                CDLtx.BackColor = Color.Transparent
            ElseIf imageLoaded = "HF" Then   'HF mode
                lblDisplay.Text = HFval
                OvalShape1.BackgroundImage = My.Resources.HF
                BKUPtx.BackColor = Color.Transparent
                INT1tx.BackColor = Color.Transparent
                INT2tx.BackColor = Color.Transparent
                ATC1tx.BackColor = Color.Transparent
                ATC2tx.BackColor = Color.Transparent
                btnINT1light.BackColor = Color.Transparent
                btnINT2light.BackColor = Color.Transparent
                btnATC1light.BackColor = Color.Transparent
                btnATC2light.BackColor = Color.Transparent
                btnVU1light.BackColor = Color.Transparent
                btnVU2light.BackColor = Color.Transparent
                btnMSR1leftLight.BackColor = Color.Transparent
                btnMSR2leftLight.BackColor = Color.Transparent
                btnMSR3leftLight.BackColor = Color.Transparent
                btnMSR4leftLight.BackColor = Color.Transparent
                btnCDLleftLight.BackColor = Color.Transparent
                HFtx.BackColor = Color.GreenYellow
                btnHFlight.BackColor = Color.YellowGreen
                VU1tx.BackColor = Color.Transparent
                VU2tx.BackColor = Color.Transparent
                MSR1tx.BackColor = Color.Transparent
                MSR2tx.BackColor = Color.Transparent
                MSR3tx.BackColor = Color.Transparent
                MSR4tx.BackColor = Color.Transparent
                CDLtx.BackColor = Color.Transparent
            ElseIf imageLoaded = "VU1" Then   'VU1 mode
                lblDisplay.Text = VU1val
                OvalShape1.BackgroundImage = My.Resources.VU1
                BKUPtx.BackColor = Color.Transparent
                INT1tx.BackColor = Color.Transparent
                INT2tx.BackColor = Color.Transparent
                ATC1tx.BackColor = Color.Transparent
                ATC2tx.BackColor = Color.Transparent
                HFtx.BackColor = Color.Transparent
                btnINT1light.BackColor = Color.Transparent
                btnINT2light.BackColor = Color.Transparent
                btnATC1light.BackColor = Color.Transparent
                btnATC2light.BackColor = Color.Transparent
                btnHFlight.BackColor = Color.Transparent
                btnVU2light.BackColor = Color.Transparent
                btnMSR1leftLight.BackColor = Color.Transparent
                btnMSR2leftLight.BackColor = Color.Transparent
                btnMSR3leftLight.BackColor = Color.Transparent
                btnMSR4leftLight.BackColor = Color.Transparent
                btnCDLleftLight.BackColor = Color.Transparent
                VU1tx.BackColor = Color.GreenYellow
                btnVU1light.BackColor = Color.YellowGreen
                VU2tx.BackColor = Color.Transparent
                MSR1tx.BackColor = Color.Transparent
                MSR2tx.BackColor = Color.Transparent
                MSR3tx.BackColor = Color.Transparent
                MSR4tx.BackColor = Color.Transparent
                CDLtx.BackColor = Color.Transparent
            ElseIf imageLoaded = "VU2" Then   'VU2 mode
                lblDisplay.Text = VU2val
                OvalShape1.BackgroundImage = My.Resources.VU2
                BKUPtx.BackColor = Color.Transparent
                INT1tx.BackColor = Color.Transparent
                INT2tx.BackColor = Color.Transparent
                ATC1tx.BackColor = Color.Transparent
                ATC2tx.BackColor = Color.Transparent
                HFtx.BackColor = Color.Transparent
                VU1tx.BackColor = Color.Transparent
                btnINT1light.BackColor = Color.Transparent
                btnINT2light.BackColor = Color.Transparent
                btnATC1light.BackColor = Color.Transparent
                btnATC2light.BackColor = Color.Transparent
                btnHFlight.BackColor = Color.Transparent
                btnVU1light.BackColor = Color.Transparent
                btnMSR1leftLight.BackColor = Color.Transparent
                btnMSR2leftLight.BackColor = Color.Transparent
                btnMSR3leftLight.BackColor = Color.Transparent
                btnMSR4leftLight.BackColor = Color.Transparent
                btnCDLleftLight.BackColor = Color.Transparent
                VU2tx.BackColor = Color.GreenYellow
                btnVU2light.BackColor = Color.YellowGreen
                MSR1tx.BackColor = Color.Transparent
                MSR2tx.BackColor = Color.Transparent
                MSR3tx.BackColor = Color.Transparent
                MSR4tx.BackColor = Color.Transparent
                CDLtx.BackColor = Color.Transparent
            ElseIf imageLoaded = "MSR1" Then   'MSR1 mode
                lblDisplay.Text = MSR1val
                OvalShape1.BackgroundImage = My.Resources.MSR1
                BKUPtx.BackColor = Color.Transparent
                INT1tx.BackColor = Color.Transparent
                INT2tx.BackColor = Color.Transparent
                ATC1tx.BackColor = Color.Transparent
                ATC2tx.BackColor = Color.Transparent
                HFtx.BackColor = Color.Transparent
                VU1tx.BackColor = Color.Transparent
                VU2tx.BackColor = Color.Transparent
                btnINT1light.BackColor = Color.Transparent
                btnINT2light.BackColor = Color.Transparent
                btnATC1light.BackColor = Color.Transparent
                btnATC2light.BackColor = Color.Transparent
                btnHFlight.BackColor = Color.Transparent
                btnVU1light.BackColor = Color.Transparent
                btnVU2light.BackColor = Color.Transparent
                btnMSR2leftLight.BackColor = Color.Transparent
                btnMSR3leftLight.BackColor = Color.Transparent
                btnMSR4leftLight.BackColor = Color.Transparent
                btnCDLleftLight.BackColor = Color.Transparent
                MSR1tx.BackColor = Color.GreenYellow
                btnMSR1leftLight.BackColor = Color.YellowGreen
                MSR2tx.BackColor = Color.Transparent
                MSR3tx.BackColor = Color.Transparent
                MSR4tx.BackColor = Color.Transparent
                CDLtx.BackColor = Color.Transparent
            ElseIf imageLoaded = "MSR2" Then  'MSR2 mode
                lblDisplay.Text = MSR2val
                OvalShape1.BackgroundImage = My.Resources.MSR2
                BKUPtx.BackColor = Color.Transparent
                INT1tx.BackColor = Color.Transparent
                INT2tx.BackColor = Color.Transparent
                ATC1tx.BackColor = Color.Transparent
                ATC2tx.BackColor = Color.Transparent
                HFtx.BackColor = Color.Transparent
                VU1tx.BackColor = Color.Transparent
                VU2tx.BackColor = Color.Transparent
                MSR1tx.BackColor = Color.Transparent
                btnINT1light.BackColor = Color.Transparent
                btnINT2light.BackColor = Color.Transparent
                btnATC1light.BackColor = Color.Transparent
                btnATC2light.BackColor = Color.Transparent
                btnHFlight.BackColor = Color.Transparent
                btnVU1light.BackColor = Color.Transparent
                btnVU2light.BackColor = Color.Transparent
                btnMSR1leftLight.BackColor = Color.Transparent
                btnMSR3leftLight.BackColor = Color.Transparent
                btnMSR4leftLight.BackColor = Color.Transparent
                btnCDLleftLight.BackColor = Color.Transparent
                MSR2tx.BackColor = Color.GreenYellow
                btnMSR2leftLight.BackColor = Color.YellowGreen
                MSR3tx.BackColor = Color.Transparent
                MSR4tx.BackColor = Color.Transparent
                CDLtx.BackColor = Color.Transparent
            ElseIf imageLoaded = "MSR3" Then  'MSR3 mode
                lblDisplay.Text = MSR3val
                OvalShape1.BackgroundImage = My.Resources.MSR3
                BKUPtx.BackColor = Color.Transparent
                INT1tx.BackColor = Color.Transparent
                INT2tx.BackColor = Color.Transparent
                ATC1tx.BackColor = Color.Transparent
                ATC2tx.BackColor = Color.Transparent
                HFtx.BackColor = Color.Transparent
                VU1tx.BackColor = Color.Transparent
                VU2tx.BackColor = Color.Transparent
                MSR1tx.BackColor = Color.Transparent
                MSR2tx.BackColor = Color.Transparent
                btnINT1light.BackColor = Color.Transparent
                btnINT2light.BackColor = Color.Transparent
                btnATC1light.BackColor = Color.Transparent
                btnATC2light.BackColor = Color.Transparent
                btnHFlight.BackColor = Color.Transparent
                btnVU1light.BackColor = Color.Transparent
                btnVU2light.BackColor = Color.Transparent
                btnMSR1leftLight.BackColor = Color.Transparent
                btnMSR2leftLight.BackColor = Color.Transparent
                btnMSR4leftLight.BackColor = Color.Transparent
                btnCDLleftLight.BackColor = Color.Transparent
                MSR3tx.BackColor = Color.GreenYellow
                btnMSR3leftLight.BackColor = Color.YellowGreen
                MSR4tx.BackColor = Color.Transparent
                CDLtx.BackColor = Color.Transparent
            ElseIf imageLoaded = "MSR4" Then  'MSR4 mode
                lblDisplay.Text = MSR4val
                OvalShape1.BackgroundImage = My.Resources.MSR4
                BKUPtx.BackColor = Color.Transparent
                INT1tx.BackColor = Color.Transparent
                INT2tx.BackColor = Color.Transparent
                ATC1tx.BackColor = Color.Transparent
                ATC2tx.BackColor = Color.Transparent
                HFtx.BackColor = Color.Transparent
                VU1tx.BackColor = Color.Transparent
                VU2tx.BackColor = Color.Transparent
                MSR1tx.BackColor = Color.Transparent
                MSR2tx.BackColor = Color.Transparent
                MSR3tx.BackColor = Color.Transparent
                btnINT1light.BackColor = Color.Transparent
                btnINT2light.BackColor = Color.Transparent
                btnATC1light.BackColor = Color.Transparent
                btnATC2light.BackColor = Color.Transparent
                btnHFlight.BackColor = Color.Transparent
                btnVU1light.BackColor = Color.Transparent
                btnVU2light.BackColor = Color.Transparent
                btnMSR1leftLight.BackColor = Color.Transparent
                btnMSR2leftLight.BackColor = Color.Transparent
                btnMSR3leftLight.BackColor = Color.Transparent
                btnCDLleftLight.BackColor = Color.Transparent
                MSR4tx.BackColor = Color.GreenYellow
                btnMSR4leftLight.BackColor = Color.YellowGreen
                CDLtx.BackColor = Color.Transparent
            ElseIf imageLoaded = "CDL" Then  'CDL mode
                lblDisplay.Text = CDLval
                OvalShape1.BackgroundImage = My.Resources.CDL
                BKUPtx.BackColor = Color.Transparent
                INT1tx.BackColor = Color.Transparent
                INT2tx.BackColor = Color.Transparent
                ATC1tx.BackColor = Color.Transparent
                ATC2tx.BackColor = Color.Transparent
                HFtx.BackColor = Color.Transparent
                VU1tx.BackColor = Color.Transparent
                VU2tx.BackColor = Color.Transparent
                MSR1tx.BackColor = Color.Transparent
                MSR2tx.BackColor = Color.Transparent
                MSR3tx.BackColor = Color.Transparent
                MSR4tx.BackColor = Color.Transparent
                btnINT1light.BackColor = Color.Transparent
                btnINT2light.BackColor = Color.Transparent
                btnATC1light.BackColor = Color.Transparent
                btnATC2light.BackColor = Color.Transparent
                btnHFlight.BackColor = Color.Transparent
                btnVU1light.BackColor = Color.Transparent
                btnVU2light.BackColor = Color.Transparent
                btnMSR1leftLight.BackColor = Color.Transparent
                btnMSR2leftLight.BackColor = Color.Transparent
                btnMSR3leftLight.BackColor = Color.Transparent
                btnMSR4leftLight.BackColor = Color.Transparent
                CDLtx.BackColor = Color.GreenYellow
                btnCDLleftLight.BackColor = Color.YellowGreen
            End If
        End If


    End Sub

    Private Sub CDLforceon()
        btnCDLleftLight.BackColor = Color.GreenYellow
        CDLtx.BackColor = Color.GreenYellow
    End Sub

    Private Sub INT1forceon()
        btnINT1light.BackColor = Color.GreenYellow
        INT1tx.BackColor = Color.GreenYellow
    End Sub

    Private Sub INT2forceon()
        btnINT2light.BackColor = Color.GreenYellow
        INT2tx.BackColor = Color.GreenYellow
    End Sub

    Private Sub ATC1forceon()
        btnATC1light.BackColor = Color.GreenYellow
        ATC1tx.BackColor = Color.GreenYellow
    End Sub

    Private Sub ATC2forceon()
        btnATC2light.BackColor = Color.GreenYellow
        ATC2tx.BackColor = Color.GreenYellow
    End Sub

    Private Sub HFforceon()
        btnHFlight.BackColor = Color.GreenYellow
        HFtx.BackColor = Color.GreenYellow
    End Sub

    Private Sub VU1forceon()
        btnVU1light.BackColor = Color.GreenYellow
        VU1tx.BackColor = Color.GreenYellow
    End Sub

    Private Sub VU2forceon()
        btnVU2light.BackColor = Color.GreenYellow
        VU2tx.BackColor = Color.GreenYellow
    End Sub

    Private Sub MSR1forceon()
        btnMSR1leftLight.BackColor = Color.GreenYellow
        MSR1tx.BackColor = Color.GreenYellow
    End Sub

    Private Sub MSR2forceon()
        btnMSR2leftLight.BackColor = Color.GreenYellow
        MSR2tx.BackColor = Color.GreenYellow
    End Sub

    Private Sub MSR3forceon()
        btnMSR3leftLight.BackColor = Color.GreenYellow
        MSR3tx.BackColor = Color.GreenYellow
    End Sub

    Private Sub MSR4forceon()
        btnMSR4leftLight.BackColor = Color.GreenYellow
        MSR4tx.BackColor = Color.GreenYellow
    End Sub

    Private Sub simulcastTextbox()
        Dim info As String
        If Information.walkThrough = False Then


            info = "Pressing the SEL button without pressing the MODE button first will activate SIMULCAST mode. Multiple radios may be selected for Tx (Simulcast). The first radio is selected in transmit by rotating the TRS to the desired radio, waiting for the transmit LED to illuminate and then pressing the SEL PB. This locks the radio in transmit. The operator then can rotate the TRS to another radio, then press the SEL PB and wait for the transmit LED to illuminate. Now the operator can transmit out on both assets. This process can be repeated to add more radios. Radios may be removed from the simulcast by rotating the TRS to the desired asset and pressing the SEL PB. The Tx LED associated with the asset will extinguish. The PB monitor LED will also extinguish, unless the asset was previously selected for monitor, then it will remain illuminated."
            Information.Label1.Text = info
            Information.Show()
        End If
    End Sub

    Public Sub ReloadLights()
        If imageLoaded = "BKUP" Then
            lblDisplay.Text = ""
            OvalShape1.BackgroundImage = My.Resources.BCKP2
            BKUPtx.BackColor = Color.GreenYellow
            INT1tx.BackColor = Color.GreenYellow
            INT2tx.BackColor = Color.Transparent
            ATC1tx.BackColor = Color.Transparent
            ATC2tx.BackColor = Color.Transparent
            HFtx.BackColor = Color.Transparent
            VU1tx.BackColor = Color.Transparent
            VU2tx.BackColor = Color.Transparent
            MSR1tx.BackColor = Color.Transparent
            MSR2tx.BackColor = Color.Transparent
            MSR3tx.BackColor = Color.Transparent
            MSR4tx.BackColor = Color.Transparent
            CDLtx.BackColor = Color.Transparent
            btnINT1light.BackColor = Color.GreenYellow
            btnINT2light.BackColor = Color.Transparent
            btnATC1light.BackColor = Color.Transparent
            btnATC2light.BackColor = Color.Transparent
            btnHFlight.BackColor = Color.Transparent
            btnVU1light.BackColor = Color.Transparent
            btnVU2light.BackColor = Color.Transparent
            btnMSR1leftLight.BackColor = Color.Transparent
            btnMSR2leftLight.BackColor = Color.Transparent
            btnMSR3leftLight.BackColor = Color.Transparent
            btnMSR4leftLight.BackColor = Color.Transparent
            btnCDLleftLight.BackColor = Color.Transparent
        End If


        If ATCstate = 1 Then   'count 1 = ATC1 on
            btnATC1light.BackColor = Color.GreenYellow
        ElseIf ATCstate = 2 Then   'count 2 = ATC2 on
            btnATC2light.BackColor = Color.GreenYellow
        ElseIf ATCstate = 3 Then   'count 3 = ATC1 and 2 on
            btnATC2light.BackColor = Color.GreenYellow
            btnATC1light.BackColor = Color.GreenYellow
        End If


        If INTstate = 1 Then    'INT1 on 
            btnINT1light.BackColor = Color.GreenYellow
            'btnINT2light.BackColor = Color.Transparent
        ElseIf INTstate = 2 Then    'INT2 on
            'btnINT1light.BackColor = Color.Transparent
            btnINT2light.BackColor = Color.GreenYellow
        ElseIf INTstate = 3 Then    'INT 1&2 on
            btnINT2light.BackColor = Color.GreenYellow
            btnINT1light.BackColor = Color.GreenYellow
        End If


        'Added INT1 and INT2 Condition statements to correct receiver lights not going out when in simulcast mode and switching knob from INT1 or 2 to another position.
        If INT1Condition = False Then
            If imageLoaded <> "INT1" Then
                btnINT1light.BackColor = Color.Transparent
            End If
        End If

        If INT2Condition = False Then
            If imageLoaded <> "INT2" Then
                btnINT2light.BackColor = Color.Transparent
            End If
        End If
        'end addition 

        If INT1txState = False Then
            If imageLoaded <> "INT1" Then
                INT1tx.BackColor = Color.Transparent
            End If
        End If

        If INT2txState = False Then
            If imageLoaded <> "INT2" Then
                INT2tx.BackColor = Color.Transparent
            End If
        End If

        If HFstate = 1 Then
            btnHFlight.BackColor = Color.GreenYellow
        ElseIf HFstate = 3 Then
            btnHFlight.BackColor = Color.GreenYellow
        End If

        If VU1state = 1 Then
            btnVU1light.BackColor = Color.GreenYellow
        End If

        If VU2state = 1 Then
            btnVU2light.BackColor = Color.GreenYellow
        End If

        If MSR1state = 1 Then
            btnMSR1leftLight.BackColor = Color.GreenYellow
        End If

        If MSR2state = 1 Then
            btnMSR2leftLight.BackColor = Color.GreenYellow
        End If

        If MSR3state = 1 Then
            btnMSR3leftLight.BackColor = Color.GreenYellow
        End If

        If MSR4state = 1 Then
            btnMSR4leftLight.BackColor = Color.GreenYellow
        End If

        If CDLstate = 1 Then
            btnCDLleftLight.BackColor = Color.GreenYellow
        End If

        If AUXstate = 1 Then
            btnAUXleftLight.BackColor = Color.GreenYellow
        End If

        If ADFState = 1 Then
            btnADFlight.BackColor = Color.GreenYellow
        End If

        If MKRState = 1 Then
            btnMBlight.BackColor = Color.GreenYellow
        End If

        If TCNState = 1 Then
            btnTACANlight.BackColor = Color.GreenYellow
        End If

        If DME1State = 1 Then
            btnDME1light.BackColor = Color.GreenYellow
        End If

        If DME2State = 1 Then
            btnDME2light.BackColor = Color.GreenYellow
        End If

        If VOR1State = 1 Then
            btnVOR1light.BackColor = Color.GreenYellow
        End If

        If VOR2State = 1 Then
            btnVOR2light.BackColor = Color.GreenYellow
        End If

        ' this section of "forceon" statements are causing the simulcast mode to function incorrectly when transitioning from walkthrough to trainer
        If Information.transition = True Then
            Information.transition = False
            CDLtxState = False
            INT1txState = False
            INT2txState = False
            ATC1txState = False
            ATC2txState = False
            HFtxState = False
            VU1txState = False
            VU2txState = False
            MSR1txState = False
            MSR2txState = False
            MSR3txState = False
            MSR4txState = False
        Else

            If CDLtxState = True Then
                CDLforceon()
            End If

            If INT1txState = True Then
                INT1forceon()

            End If

            If INT2txState = True Then
                INT2forceon()
            End If

            If ATC1txState = True Then
                ATC1forceon()
            End If

            If ATC2txState = True Then
                ATC2forceon()
            End If

            If HFtxState = True Then
                HFforceon()
            End If

            If VU1txState = True Then
                VU1forceon()
            End If

            If VU2txState = True Then
                VU2forceon()
            End If

            If MSR1txState = True Then
                MSR1forceon()
            End If

            If MSR2txState = True Then
                MSR2forceon()
            End If

            If MSR3txState = True Then
                MSR3forceon()
            End If

            If MSR4txState = True Then
                MSR4forceon()
            End If


        End If

    End Sub

    Private Sub RXTXcompare()   'added this sub to test condition in similcast mode. If the RX light is not on the volume should not be adjustable. MVOL should always be adjustable. Once the RX light is on, the volume adjustment should work on that asset.

        If multiCastMode = False Then
            multRXlight = True
        End If

        If lblDisplay.Text.Substring(0, 4) = "MVOL" Then
            multRXlight = True
        End If

        If multiCastMode = True Then

            If lblDisplay.Text.Substring(0, 4) = "INT1" Then

                If btnINT1light.BackColor = Color.GreenYellow Then
                    multRXlight = True
                Else
                    multRXlight = False
                End If

            End If

            If lblDisplay.Text.Substring(0, 4) = "INT2" Then

                If btnINT2light.BackColor = Color.GreenYellow Then
                    multRXlight = True
                Else
                    multRXlight = False
                End If

            End If

            If lblDisplay.Text.Substring(0, 4) = "ATC1" Then

                If btnATC1light.BackColor = Color.GreenYellow Then
                    multRXlight = True
                Else
                    multRXlight = False
                End If

            End If

            If lblDisplay.Text.Substring(0, 4) = "ATC2" Then

                If btnATC2light.BackColor = Color.GreenYellow Then
                    multRXlight = True
                Else
                    multRXlight = False
                End If

            End If

            If lblDisplay.Text.Substring(0, 2) = "HF" Then

                If btnHFlight.BackColor = Color.GreenYellow Then
                    multRXlight = True
                Else
                    multRXlight = False
                End If

            End If

            If lblDisplay.Text.Substring(0, 4) = "VU1 " Then

                If btnVU1light.BackColor = Color.GreenYellow Then
                    multRXlight = True
                Else
                    multRXlight = False
                End If

            End If

            If lblDisplay.Text.Substring(0, 4) = "VU2" Then

                If btnVU2light.BackColor = Color.GreenYellow Then
                    multRXlight = True
                Else
                    multRXlight = False
                End If

            End If

            If lblDisplay.Text.Substring(0, 4) = "MSR1" Then

                If btnMSR1leftLight.BackColor = Color.GreenYellow Then
                    multRXlight = True
                Else
                    multRXlight = False
                End If

            End If

            If lblDisplay.Text.Substring(0, 4) = "MSR2" Then

                If btnMSR2leftLight.BackColor = Color.GreenYellow Then
                    multRXlight = True
                Else
                    multRXlight = False
                End If

            End If

            If lblDisplay.Text.Substring(0, 4) = "MSR3" Then

                If btnMSR3leftLight.BackColor = Color.GreenYellow Then
                    multRXlight = True
                Else
                    multRXlight = False
                End If

            End If

            If lblDisplay.Text.Substring(0, 4) = "MSR4" Then

                If btnMSR4leftLight.BackColor = Color.GreenYellow Then
                    multRXlight = True
                Else
                    multRXlight = False
                End If

            End If

            If lblDisplay.Text.Substring(0, 4) = "CDL " Then

                If btnCDLleftLight.BackColor = Color.GreenYellow Then
                    multRXlight = True
                Else
                    multRXlight = False
                End If

            End If

        End If
    End Sub

    Private Sub ButtonPressWhenKnobSelectEqualsINT1()

        '8-31 added to test if INT is displayed before switching
        If lblDisplay.Text.Substring(0, 3) <> "INT" Then

            If INT2Condition = True Then
                lblDisplay.Text = "INT  " + INT1val.Substring(5, 2) + INT2val.Substring(5, 2)
            ElseIf INT2Condition = False Then
                lblDisplay.Text = INT1val
            End If


            '8-31 end addition with exception of ELSE and ENDIF
        Else
            '8-30 This code works for switching the lights
            If btnINT2light.BackColor = Color.Transparent Then
                btnINT2light.BackColor = Color.GreenYellow
                INT2Condition = True
                lblDisplay.Text = "INT  " + INT1val.Substring(5, 2) + INT2val.Substring(5, 2)
            ElseIf btnINT2light.BackColor = Color.GreenYellow Then
                btnINT2light.BackColor = Color.Transparent
                INT2Condition = False
                lblDisplay.Text = INT1val
            End If
            'INTstate = INTcount

            If INT1Condition = True Then
                If INT2Condition = True Then
                    INTRecall = 3
                ElseIf INT2Condition = False Then
                    INTRecall = 1
                End If
            End If

            If INT1Condition = False Then
                If INT2Condition = True Then
                    INTRecall = 2
                ElseIf INT2Condition = False Then
                    INTRecall = 0
                End If
            End If
            'INTstate = INTcount
            INTstate = INTRecall
            INTcount = INTstate + 1
            '8-30 end code

        End If

    End Sub

    Private Sub ButtonPressWhenKnobSelectEqualsINT2()

        '8-31 added to test if INT is displayed before switching
        If lblDisplay.Text.Substring(0, 3) <> "INT" Then

            If INT1Condition = True Then
                lblDisplay.Text = "INT  " + INT1val.Substring(5, 2) + INT2val.Substring(5, 2)
            ElseIf INT1Condition = False Then
                lblDisplay.Text = INT2val
            End If


            '8-31 end addition with exception of ELSE and ENDIF
        Else
            '8-30 This code works for switching the lights
            If btnINT1light.BackColor = Color.Transparent Then
                btnINT1light.BackColor = Color.GreenYellow
                INT1Condition = True
                lblDisplay.Text = "INT  " + INT1val.Substring(5, 2) + INT2val.Substring(5, 2)
            ElseIf btnINT1light.BackColor = Color.GreenYellow Then
                btnINT1light.BackColor = Color.Transparent
                INT1Condition = False
                lblDisplay.Text = INT2val
            End If
            'INTstate = INTcount

            If INT1Condition = True Then
                If INT2Condition = True Then
                    INTRecall = 3
                ElseIf INT2Condition = False Then
                    INTRecall = 1
                End If
            End If

            If INT1Condition = False Then
                If INT2Condition = True Then
                    INTRecall = 2
                ElseIf INT2Condition = False Then
                    INTRecall = 0
                End If
            End If
            'INTstate = INTcount
            INTstate = INTRecall
            INTcount = INTstate + 1
            '8-30 end code

        End If

    End Sub

    Private Sub ButtonPressWhenKnobSelectEqualsATC1()
        '8-31 copy of INT1 code
        If lblDisplay.Text.Substring(0, 3) <> "ATC" Then

            If ATCcount = 0 Then
                ATCcount = 1
            End If

            If ATCcount = 1 Then
                ATCcount = 2
                btnATC1light.BackColor = Color.GreenYellow
                ATCstate = 1

            End If



            If ATC2Condition = True Then
                lblDisplay.Text = "ATC  " + ATC1val.Substring(5, 2) + ATC2val.Substring(5, 2)
            ElseIf ATC2Condition = False Then
                lblDisplay.Text = ATC1val
            End If


        Else
            If multiCastMode = True And ATC1tx.BackColor = Color.Transparent Then
                MultiCastToggle()
            Else
                If ATC2tx.BackColor = Color.GreenYellow Then
                    lblDisplay.Text = "ATC  " + ATC1val.Substring(5, 2) + ATC2val.Substring(5, 2)

                Else

                    '8-30 This code works for switching the lights
                    If btnATC2light.BackColor = Color.Transparent Then
                        btnATC2light.BackColor = Color.GreenYellow
                        ATC2Condition = True
                        lblDisplay.Text = "ATC  " + ATC1val.Substring(5, 2) + ATC2val.Substring(5, 2)
                    ElseIf btnATC2light.BackColor = Color.GreenYellow Then
                        btnATC2light.BackColor = Color.Transparent
                        ATC2Condition = False
                        lblDisplay.Text = ATC1val
                    End If

                    If ATC1Condition = True Then
                        If ATC2Condition = True Then
                            ATCRecall = 3
                        ElseIf ATC2Condition = False Then
                            ATCRecall = 1
                        End If
                    End If

                    If ATC1Condition = False Then
                        If ATC2Condition = True Then
                            ATCRecall = 2
                        ElseIf ATC2Condition = False Then
                            ATCRecall = 0
                        End If
                    End If
                    ATCstate = ATCRecall
                    ATCcount = ATCstate + 1
                    '8-30 end code
                End If

            End If

        End If

    End Sub

    Private Sub ButtonPressWhenKnobSelectEqualsATC2()

        '8-31 copy of INT1 code
        If lblDisplay.Text.Substring(0, 3) <> "ATC" Then

            If ATCcount = 0 Then
                ATCcount = 1
            End If

            If ATCcount = 1 Then
                ATCcount = 2
                btnATC1light.BackColor = Color.GreenYellow
                ATCstate = 1
                lblDisplay.Text = ATC1val
            Else

                If ATC1Condition = True Then
                    lblDisplay.Text = "ATC  " + ATC1val.Substring(5, 2) + ATC2val.Substring(5, 2)
                ElseIf ATC1Condition = False Then
                    lblDisplay.Text = ATC2val
                End If
            End If

        Else

            If multiCastMode = True And ATC2tx.BackColor = Color.Transparent Then
                MultiCastToggle()
            Else

                If ATC1tx.BackColor = Color.GreenYellow Then
                    lblDisplay.Text = "ATC  " + ATC1val.Substring(5, 2) + ATC2val.Substring(5, 2)
                Else

                    '8-30 This code works for switching the lights
                    If btnATC1light.BackColor = Color.Transparent Then
                        btnATC1light.BackColor = Color.GreenYellow
                        ATC1Condition = True
                        lblDisplay.Text = "ATC  " + ATC1val.Substring(5, 2) + ATC2val.Substring(5, 2)
                    ElseIf btnATC1light.BackColor = Color.GreenYellow Then
                        btnATC1light.BackColor = Color.Transparent
                        ATC1Condition = False
                        lblDisplay.Text = ATC2val
                    End If

                    If ATC1Condition = True Then
                        If ATC2Condition = True Then
                            ATCRecall = 3
                        ElseIf ATC2Condition = False Then
                            ATCRecall = 1
                        End If
                    End If

                    If ATC1Condition = False Then
                        If ATC2Condition = True Then
                            ATCRecall = 2
                        ElseIf ATC2Condition = False Then
                            ATCRecall = 0
                        End If
                    End If
                    ATCstate = ATCRecall
                    ATCcount = ATCstate + 1
                    '8-30 end code

                End If
            End If

        End If

    End Sub

    Private Sub ButtonPressWhenKnobSelectEqualsHF()
        '8-31 copy of INT1 code
        If lblDisplay.Text.Substring(0, 2) <> "HF" Then

            If ADFCondition = True Then
                lblDisplay.Text = "HFDF " + HFval.Substring(5, 2) + ADFval.Substring(5, 2)
            ElseIf ADFCondition = False Then
                lblDisplay.Text = HFval
            End If


        Else
            'begin test of pushbutton. If button has been pushed within the last five seconds, this will allow the button to sequence to the next selection. If the button has reverted to MVOL, the next button push will not sequence to the next selection. It will only display the current volume settings and setup the program to advance on the next button push.
            If lblDisplay.Text.Substring(0, 3) = "HF " And btnADFlight.BackColor = Color.Transparent Then
            ElseIf lblDisplay.Text.Substring(0, 3) = "ADF" Then
            ElseIf lblDisplay.Text.Substring(0, 3) = "HFD" Then
            Else
                btnADFlight.BackColor = Color.Transparent
            End If
            'end pushbutton test 



            '8-30 This code works for switching the lights
            If btnADFlight.BackColor = Color.Transparent Then
                btnADFlight.BackColor = Color.GreenYellow
                ADFCondition = True
                ADFState = 1
                lblDisplay.Text = "HFDF " + HFval.Substring(5, 2) + ADFval.Substring(5, 2)
            ElseIf btnADFlight.BackColor = Color.GreenYellow Then
                btnADFlight.BackColor = Color.Transparent
                ADFCondition = False
                ADFState = 0
                lblDisplay.Text = HFval
            End If

            If HFCondition = True Then
                If ADFCondition = True Then
                    HFDFRecall = 3
                ElseIf ADFCondition = False Then
                    HFDFRecall = 1
                End If
            End If

            If HFCondition = False Then
                If ADFCondition = True Then
                    HFDFRecall = 2
                ElseIf ADFCondition = False Then
                    HFDFRecall = 0
                End If
            End If
            HFstate = HFDFRecall
            HFADFcount = HFstate + 1
            '8-30 end code

        End If

    End Sub

    Private Sub ButtonPressWhenHeldATC1()

        If ATC1tx.BackColor = Color.GreenYellow Then
            If ATC2tx.BackColor = Color.GreenYellow Then
                lblDisplay.Text = "ATC  " + ATC1val.Substring(5, 2) + ATC2val.Substring(5, 2)

            Else
                '8-31 copy of INT1 code
                If lblDisplay.Text.Substring(0, 3) <> "ATC" Then

                    If ATC2Condition = True Then
                        lblDisplay.Text = "ATC  " + ATC1val.Substring(5, 2) + ATC2val.Substring(5, 2)
                    ElseIf ATC2Condition = False Then
                        lblDisplay.Text = ATC1val
                    End If


                Else
                    '8-30 This code works for switching the lights
                    If btnATC2light.BackColor = Color.Transparent Then
                        btnATC2light.BackColor = Color.GreenYellow
                        ATC2Condition = True
                        lblDisplay.Text = "ATC  " + ATC1val.Substring(5, 2) + ATC2val.Substring(5, 2)
                    ElseIf btnATC2light.BackColor = Color.GreenYellow Then
                        btnATC2light.BackColor = Color.Transparent
                        ATC2Condition = False
                        lblDisplay.Text = ATC1val
                    End If

                    If ATC1Condition = True Then
                        If ATC2Condition = True Then
                            ATCRecall = 3
                        ElseIf ATC2Condition = False Then
                            ATCRecall = 1
                        End If
                    End If

                    If ATC1Condition = False Then
                        If ATC2Condition = True Then
                            ATCRecall = 2
                        ElseIf ATC2Condition = False Then
                            ATCRecall = 0
                        End If
                    End If
                    ATCstate = ATCRecall
                    ATCcount = ATCstate + 1
                    '8-30 end code

                End If
            End If
        End If
    End Sub

    Private Sub ButtonPressWhenHeldATC2()
        If ATC2tx.BackColor = Color.GreenYellow Then
            If ATC1tx.BackColor = Color.GreenYellow Then
            Else
                '8-31 copy of INT1 code
                If lblDisplay.Text.Substring(0, 3) <> "ATC" Then

                    If ATC1Condition = True Then
                        lblDisplay.Text = "ATC  " + ATC1val.Substring(5, 2) + ATC2val.Substring(5, 2)
                    ElseIf ATC1Condition = False Then
                        lblDisplay.Text = ATC2val
                    End If


                Else
                    '8-30 This code works for switching the lights
                    If btnATC1light.BackColor = Color.Transparent Then
                        btnATC1light.BackColor = Color.GreenYellow
                        ATC1Condition = True
                        lblDisplay.Text = "ATC  " + ATC1val.Substring(5, 2) + ATC2val.Substring(5, 2)
                    ElseIf btnATC1light.BackColor = Color.GreenYellow Then
                        btnATC1light.BackColor = Color.Transparent
                        ATC1Condition = False
                        lblDisplay.Text = ATC2val
                    End If

                    If ATC1Condition = True Then
                        If ATC2Condition = True Then
                            ATCRecall = 3
                        ElseIf ATC2Condition = False Then
                            ATCRecall = 1
                        End If
                    End If

                    If ATC1Condition = False Then
                        If ATC2Condition = True Then
                            ATCRecall = 2
                        ElseIf ATC2Condition = False Then
                            ATCRecall = 0
                        End If
                    End If
                    ATCstate = ATCRecall
                    ATCcount = ATCstate + 1
                    '8-30 end code

                End If

            End If
        End If

    End Sub

    Private Sub ButtonPressWhenHeldHF()

        If HFtx.BackColor = Color.GreenYellow Then

            '8-31 copy of INT1 code
            If lblDisplay.Text.Substring(0, 2) <> "HF" Then

                If ADFCondition = True Then
                    lblDisplay.Text = "HFDF " + HFval.Substring(5, 2) + ADFval.Substring(5, 2)
                ElseIf ADFCondition = False Then
                    lblDisplay.Text = HFval
                End If


            Else
                '8-30 This code works for switching the lights
                If ADFState = 0 Then
                    btnADFlight.BackColor = Color.GreenYellow
                    ADFCondition = True
                    ADFState = 1
                    lblDisplay.Text = "HFDF " + HFval.Substring(5, 2) + ADFval.Substring(5, 2)
                ElseIf ADFState = 1 Then
                    btnADFlight.BackColor = Color.Transparent
                    ADFCondition = False
                    ADFState = 0
                    lblDisplay.Text = HFval
                End If

                If HFCondition = True Then
                    If ADFCondition = True Then
                        HFDFRecall = 3
                    ElseIf ADFCondition = False Then
                        HFDFRecall = 1
                    End If
                End If

                If HFCondition = False Then
                    If ADFCondition = True Then
                        HFDFRecall = 2
                    ElseIf ADFCondition = False Then
                        HFDFRecall = 0
                    End If
                End If
                HFstate = HFDFRecall
                HFstate = HFstate + 1
                '8-30 end code

            End If

        End If



    End Sub

    Private Sub ButtonPressWhenHeldINT1()
        If INT1tx.BackColor = Color.GreenYellow Then
            If INT2tx.BackColor = Color.GreenYellow Then
                lblDisplay.Text = "INT  " + INT1val.Substring(5, 2) + INT2val.Substring(5, 2)

            Else
                '8-31 added to test if INT is displayed before switching
                If lblDisplay.Text.Substring(0, 3) <> "INT" Then

                    If INT2Condition = True Then
                        lblDisplay.Text = "INT  " + INT1val.Substring(5, 2) + INT2val.Substring(5, 2)
                    ElseIf INT2Condition = False Then
                        lblDisplay.Text = INT1val
                    End If


                    '8-31 end addition with exception of ELSE and ENDIF
                Else
                    '8-30 This code works for switching the lights
                    If btnINT2light.BackColor = Color.Transparent Then
                        btnINT2light.BackColor = Color.GreenYellow
                        INT2Condition = True
                        lblDisplay.Text = "INT  " + INT1val.Substring(5, 2) + INT2val.Substring(5, 2)
                    ElseIf btnINT2light.BackColor = Color.GreenYellow Then
                        btnINT2light.BackColor = Color.Transparent
                        INT2Condition = False
                        lblDisplay.Text = INT1val
                    End If
                    'INTstate = INTcount

                    If INT1Condition = True Then
                        If INT2Condition = True Then
                            INTRecall = 3
                        ElseIf INT2Condition = False Then
                            INTRecall = 1
                        End If
                    End If

                    If INT1Condition = False Then
                        If INT2Condition = True Then
                            INTRecall = 2
                        ElseIf INT2Condition = False Then
                            INTRecall = 0
                        End If
                    End If
                    'INTstate = INTcount
                    INTstate = INTRecall
                    INTcount = INTstate + 1
                    '8-30 end code

                End If


            End If
        End If





    End Sub

    Private Sub ButtonPressWhenHeldINT2()
        If INT2tx.BackColor = Color.GreenYellow Then
            If INT1tx.BackColor = Color.GreenYellow Then
                lblDisplay.Text = "INT  " + INT1val.Substring(5, 2) + INT2val.Substring(5, 2)
            Else
                '8-31 added to test if INT is displayed before switching
                If lblDisplay.Text.Substring(0, 3) <> "INT" Then

                    If INT1Condition = True Then
                        lblDisplay.Text = "INT  " + INT1val.Substring(5, 2) + INT2val.Substring(5, 2)
                    ElseIf INT1Condition = False Then
                        lblDisplay.Text = INT2val
                    End If


                    '8-31 end addition with exception of ELSE and ENDIF
                Else
                    '8-30 This code works for switching the lights
                    If btnINT1light.BackColor = Color.Transparent Then
                        btnINT1light.BackColor = Color.GreenYellow
                        INT1Condition = True
                        lblDisplay.Text = "INT  " + INT1val.Substring(5, 2) + INT2val.Substring(5, 2)
                    ElseIf btnINT1light.BackColor = Color.GreenYellow Then
                        btnINT1light.BackColor = Color.Transparent
                        INT1Condition = False
                        lblDisplay.Text = INT2val
                    End If
                    'INTstate = INTcount

                    If INT1Condition = True Then
                        If INT2Condition = True Then
                            INTRecall = 3
                        ElseIf INT2Condition = False Then
                            INTRecall = 1
                        End If
                    End If

                    If INT1Condition = False Then
                        If INT2Condition = True Then
                            INTRecall = 2
                        ElseIf INT2Condition = False Then
                            INTRecall = 0
                        End If
                    End If
                    'INTstate = INTcount
                    INTstate = INTRecall
                    INTcount = INTstate + 1
                    '8-30 end code

                End If

            End If
        End If

    End Sub

    Private Sub MultiCastToggle()

        Dim info As String

        If lblDisplay.Text <> "" Then   'In BKUP the display will be blank. This wraps the code to test that status

            If lblDisplay.Text.Substring(0, 3) <> "ATC" Then
                ATCcount = ATCcount - 1
            End If
            If ATCcount = 0 Then
                ATCcount = 1
            End If

            If ATCcount = 1 Then
                btnATC1light.BackColor = Color.GreenYellow
                ATCstate = 1

            End If

            If ATC1tx.BackColor = Color.GreenYellow Then    'tests to see if the ATC1tx light is active
                ButtonPressWhenKnobSelectEqualsATC1()       'switches only ATC2 light

            End If

            If ATC2tx.BackColor = Color.GreenYellow Then    'tests to see if the ATC2tx light is active
                ButtonPressWhenKnobSelectEqualsATC2()        'switches only ATC1 light
            End If


            If ATC1tx.BackColor <> Color.GreenYellow Then       'if neither tx light is on we switch normally
                If ATC2tx.BackColor <> Color.GreenYellow Then





                    If ATCcount = 1 Then   'count 1 = ATC1 on
                        btnATC1light.BackColor = Color.GreenYellow
                        ATC1Condition = True
                        ATC2Condition = False
                        lblDisplay.Text = ATC1val

                        info = "Pressing the ATC 1/2 radio button once will activate the ATC1 radio audio. The display shows ATC1 05 indicating that ATC1 audio is active and the volume level is set to 05. Volume for that radio can be adjusted from 00 to 09 using the up/down arrows. After five seconds the display will revert back to the master volume control (MVOL)."
                        Information.Label1.Text = info
                        Information.Show()


                    ElseIf ATCcount = 2 Then   'count 2 = ATC2 on
                        btnATC2light.BackColor = Color.GreenYellow
                        btnATC1light.BackColor = Color.Transparent
                        ATC1Condition = False
                        ATC2Condition = True
                        lblDisplay.Text = ATC2val

                        info = "The second press switches to the ATC2 radio. The volume controls work the same way and are independent from the ATC1 audio level. This allows the user to set an audio level that is comfortable for them. After five seconds the display will revert back to the master volume control (MVOL)."
                        Information.Label1.Text = info
                        Information.Show()


                    ElseIf ATCcount = 3 Then   'count 3 = ATC1 and 2 on

                        btnATC2light.BackColor = Color.GreenYellow
                        btnATC1light.BackColor = Color.GreenYellow
                        ATC1Condition = True
                        ATC2Condition = True
                        lblDisplay.Text = ATC1ATC2


                        info = "The 3rd press connects to both radios. Notice that the data in the display has changed. It now shows the volume levels for both radios. Pressing the up arrow will increase the volumes together until the radios reach their maximum volume. If one volume reaches the limit first, it will stop increasing while the other volume continues to rise. Decreasing the volume works the same way. After five seconds the display will revert back to the master volume control (MVOL)."
                        Information.Label1.Text = info
                        Information.Show()

                    ElseIf ATCcount = 4 Then   'count 4 equals no lights

                        btnATC2light.BackColor = Color.Transparent
                        btnATC1light.BackColor = Color.Transparent
                        ATC1Condition = False
                        ATC2Condition = False
                        lblDisplay.Text = MVOLval

                        info = "The 4th press deselects both radios."
                        Information.Label1.Text = info
                        Information.Show()

                        ATCcount = 0   'resets the counter
                    End If
                End If
            End If

            ATCstate = ATCcount

            'If imageLoaded = "ATC1" Then
            '    btnATC1light.BackColor = Color.GreenYellow
            'End If
            'If imageLoaded = "ATC2" Then
            '    btnATC2light.BackColor = Color.GreenYellow
            'End If

            If naptime >= 5 Then
                ATCcount = ATCcount - 1
            End If

            ATCcount = ATCcount + 1
            ReloadLights()
        End If

    End Sub

    'Monitors
    Private Sub ICUfailLight_VisibleChanged(sender As Object, e As EventArgs) Handles ICUfailLight.VisibleChanged

        LoopCount = LoopCount + 1

        If ICUfailLight.Visible = False Then
            If LoopCount <> 0 Then
                knobIndex = 1
                INT2tx.BackColor = Color.Transparent
                ATC1tx.BackColor = Color.Transparent
                ATC2tx.BackColor = Color.Transparent
                HFtx.BackColor = Color.Transparent
                VU1tx.BackColor = Color.Transparent
                VU2tx.BackColor = Color.Transparent
                MSR1tx.BackColor = Color.Transparent
                MSR2tx.BackColor = Color.Transparent
                MSR3tx.BackColor = Color.Transparent
                btnINT1light.BackColor = Color.Transparent
                btnINT2light.BackColor = Color.Transparent
                btnATC1light.BackColor = Color.Transparent
                btnATC2light.BackColor = Color.Transparent
                btnHFlight.BackColor = Color.Transparent
                btnVU1light.BackColor = Color.Transparent
                btnVU2light.BackColor = Color.Transparent
                btnMSR1leftLight.BackColor = Color.Transparent
                btnMSR2leftLight.BackColor = Color.Transparent
                btnMSR3leftLight.BackColor = Color.Transparent
                btnCDLleftLight.BackColor = Color.Transparent
                MSR4tx.BackColor = Color.Transparent
                btnMSR4leftLight.BackColor = Color.Transparent
                CDLtx.BackColor = Color.Transparent
            End If
        End If

    End Sub
    Private Sub Knob_Click(sender As Object, e As EventArgs) Handles OvalShape1.Click
        'If imageLoaded = "INT1" Then
        '    If firstClick = True Then
        '        imageLoaded = "INT2"
        '        knobIndex = 3
        '        firstClick = False
        '    End If
        'End If

        'KnobSelect()

        'If knobIndex = 1 Then   'BKUP mode
        '    imageLoaded = "BKUP"
        '    knobIndex = 2
        'ElseIf knobIndex = 2 Then   'INT1 mode
        '    OvalShape1.BackgroundImage = My.Resources.INT1
        '    imageLoaded = "INT1"
        '    lblDisplay.Text = INT1val
        '    BKUPtx.BackColor = Color.Transparent
        '    knobIndex = 3
        'ElseIf knobIndex = 3 Then   'INT2 mode
        '    imageLoaded = "INT2"
        '    knobIndex = 4
        'ElseIf knobIndex = 4 Then   'ATC1 mode
        '    imageLoaded = "ATC1"
        '    knobIndex = 5
        'ElseIf knobIndex = 5 Then   'ATC2 mode
        '    imageLoaded = "ATC2"
        '    knobIndex = 6
        'ElseIf knobIndex = 6 Then   'HF mode
        '    imageLoaded = "HF"
        '    knobIndex = 7
        'ElseIf knobIndex = 7 Then   'VU1 mode
        '    imageLoaded = "VU1"
        '    knobIndex = 8
        'ElseIf knobIndex = 8 Then   'VU2 mode
        '    imageLoaded = "VU2"
        '    knobIndex = 9
        'ElseIf knobIndex = 9 Then   'MSR1 mode
        '    imageLoaded = "MSR1"
        '    knobIndex = 10
        'ElseIf knobIndex = 10 Then   'MSR2 mode
        '    imageLoaded = "MSR2"
        '    knobIndex = 11
        'ElseIf knobIndex = 11 Then   'MSR3 mode
        '    imageLoaded = "MSR3"
        '    knobIndex = 12
        'ElseIf knobIndex = 12 Then   'MSR4 mode
        '    imageLoaded = "MSR4"
        '    knobIndex = 13
        'ElseIf knobIndex = 13 Then   'CDL mode
        '    imageLoaded = "CDL"
        '    knobIndex = 1
        'End If


        'If imageLoaded = "BKUP" Then
        '    If BKUPtx.BackColor = Color.GreenYellow Then
        '        INT1tx.BackColor = Color.GreenYellow
        '    End If

        'End If



    End Sub
    Private Sub displayMonitor(sender As Object, e As EventArgs) Handles lblDisplay.TextChanged

        'sets baseline times for new button click
        timeStart = 0
        timeEnd = 0

        If lblDisplay.Text = "" Then
            If knobIndex <> 1 Then
                btnINT1light.BackColor = Color.Transparent
                INT1tx.BackColor = Color.Transparent
                BKUPtx.BackColor = Color.Transparent
            End If
        End If
    End Sub
    Private Sub DisplayUpdate()

        '8-29 add code to keep display synced with knob position in similcast mode
        If imageLoaded = "BKUP" Then   'BKUP mode
            'lblDisplay.Text = MVOLval
        ElseIf imageLoaded = "INT1" Then   'INT1 mode
            lblDisplay.Text = INT1val
        ElseIf imageLoaded = "INT2" Then   'INT2 mode
            lblDisplay.Text = INT2val
        ElseIf imageLoaded = "ATC1" Then   'ATC1 mode
            lblDisplay.Text = ATC1val
        ElseIf imageLoaded = "ATC2" Then   'ATC2 mode
            lblDisplay.Text = ATC2val
        ElseIf imageLoaded = "HF" Then   'HF mode
            lblDisplay.Text = HFval
        ElseIf imageLoaded = "VU1" Then   'VU1 mode
            lblDisplay.Text = VU1val
        ElseIf imageLoaded = "VU2" Then   'VU2 mode
            lblDisplay.Text = VU2val
        ElseIf imageLoaded = "MSR1" Then   'MSR1 mode
            lblDisplay.Text = MSR1val
        ElseIf imageLoaded = "MSR2" Then  'MSR2 mode
            lblDisplay.Text = MSR2val
        ElseIf imageLoaded = "MSR3" Then  'MSR3 mode
            lblDisplay.Text = MSR3val
        ElseIf imageLoaded = "MSR4" Then  'MSR4 mode
            lblDisplay.Text = MSR4val
        ElseIf imageLoaded = "CDL" Then  'CDL mode
            lblDisplay.Text = CDLval
        End If


    End Sub

    Private Sub StaticLightTest()

        If multiINTmode = True Then


            'special test for INT1. If the knob hasn't moved then I force INT1Condition to false since it cannot be selected without moving the knob
            If firstMoveComplete = False Then
                INT1Condition = False
            ElseIf INTstate <> 1 Then
                If INTstate <> 3 Then
                    INT1Condition = False
                End If
            Else
                INT1Condition = True
            End If

            If INTstate <> 2 Then
                If INTstate <> 3 Then
                    INT2Condition = False
                End If
            Else
                INT2Condition = True
            End If
            '''''''''''''''''''''''''''''''''''''''''''
            If INT1Condition = False Then
                If INT2Condition = False Then
                    INTstate = 0
                ElseIf INT2Condition = True Then
                    INTstate = 2
                End If
            End If

            If INT1Condition = True Then
                If INT2Condition = False Then
                    INTstate = 1
                ElseIf INT2Condition = True Then
                    INTstate = 3
                End If
            End If
            ''''''''''''''''''''''''''''''''''''''''''''''
        ElseIf multiINTmode = False Then
            'INT light tests
            If INTstate = 0 Then
                INT1Condition = False
                INT2Condition = False
            ElseIf INTstate = 1 Then
                INT1Condition = True
                INT2Condition = False
            ElseIf INTstate = 2 Then
                INT1Condition = False
                INT2Condition = True
            ElseIf INTstate = 3 Then
                INT1Condition = True
                INT2Condition = True
            ElseIf INTstate = 4 Then
                INT1Condition = False
                INT2Condition = False
            End If
        End If

        If multiCastMode = True Then

            'ATC light tests
            If ATCstate <> 1 Then
                If ATCstate <> 3 Then
                    ATC1Condition = False
                End If
            Else
                ATC1Condition = True
            End If

            If ATCstate <> 2 Then
                If ATCstate <> 3 Then
                    ATC2Condition = False
                End If
            Else
                ATC2Condition = True
            End If

            '''''''''''''''''''''''''''''''''''''''''''
            If ATC1Condition = False Then
                If ATC2Condition = False Then
                    ATCstate = 0
                ElseIf ATC2Condition = True Then
                    ATCstate = 2
                End If
            End If

            If ATC1Condition = True Then
                If ATC2Condition = False Then
                    ATCstate = 1
                ElseIf ATC2Condition = True Then
                    ATCstate = 3
                End If
            End If
            ''''''''''''''''''''''''''''''''''''''''''''''

            'HF/ADF light tests
            If HFCondition = True Then
                If ADFCondition = True Then
                    'ADFCondition = False
                    ADFState = 1
                    HFstate = 1
                ElseIf ADFCondition = False Then
                    'ADFCondition = True
                    ADFState = 0
                    HFstate = 1
                End If

            ElseIf HFCondition = False Then
                If ADFCondition = True Then
                    'ADFCondition = False
                    ADFState = 1
                    HFstate = 0
                ElseIf ADFCondition = False Then
                    'ADFCondition = True
                    ADFState = 0
                    HFstate = 0
                End If

            End If



        ElseIf multiCastMode = False Then


            'HF/ADF light tests
            If HFstate = 0 Then
                HFCondition = False
            ElseIf HFstate = 2 Then
                HFCondition = False
            Else
                HFCondition = True
            End If

            If btnADFlight.BackColor = Color.Transparent Then
                ADFCondition = False
            Else
                ADFCondition = True
            End If


            'ATC light tests
            If ATCstate = 0 Then
                ATC1Condition = False
                ATC2Condition = False
            ElseIf ATCstate = 1 Then
                ATC1Condition = True
                ATC2Condition = False
            ElseIf HFstate = 2 Then
                ATC1Condition = False
                ATC2Condition = True
            ElseIf ATCstate = 3 Then
                ATC1Condition = True
                ATC2Condition = True
            ElseIf ATCstate = 4 Then
                ATC1Condition = False
                ATC2Condition = False
            End If



        End If

    End Sub

    Public Sub ForceBKUP()
        If knobIndex = 1 Then


            multiIntRecall = multiINTmode
            multiCastRecall = multiCastMode



            lblDisplay.Text = ""
            OvalShape1.BackgroundImage = My.Resources.BCKP2
            BKUPtx.BackColor = Color.GreenYellow
            INT1tx.BackColor = Color.GreenYellow
            INT2tx.BackColor = Color.Transparent
            ATC1tx.BackColor = Color.Transparent
            ATC2tx.BackColor = Color.Transparent
            HFtx.BackColor = Color.Transparent
            VU1tx.BackColor = Color.Transparent
            VU2tx.BackColor = Color.Transparent
            MSR1tx.BackColor = Color.Transparent
            MSR2tx.BackColor = Color.Transparent
            MSR3tx.BackColor = Color.Transparent
            MSR4tx.BackColor = Color.Transparent
            CDLtx.BackColor = Color.Transparent
            btnINT1light.BackColor = Color.GreenYellow
            btnINT2light.BackColor = Color.Transparent
            btnATC1light.BackColor = Color.Transparent
            btnATC2light.BackColor = Color.Transparent
            btnHFlight.BackColor = Color.Transparent
            btnVU1light.BackColor = Color.Transparent
            btnVU2light.BackColor = Color.Transparent
            btnMSR1leftLight.BackColor = Color.Transparent
            btnMSR2leftLight.BackColor = Color.Transparent
            btnMSR3leftLight.BackColor = Color.Transparent
            btnMSR4leftLight.BackColor = Color.Transparent
            btnCDLleftLight.BackColor = Color.Transparent

            btnDME1light.BackColor = Color.Transparent
            btnDME2light.BackColor = Color.Transparent
            btnMBlight.BackColor = Color.Transparent
            btnTACANlight.BackColor = Color.Transparent
            btnVOR1light.BackColor = Color.Transparent
            btnVOR2light.BackColor = Color.Transparent
            btnAUXleftLight.BackColor = Color.Transparent
            btnADFlight.BackColor = Color.Transparent

        End If
    End Sub

    Public Sub ForceBKUP2() 'when transitioning from trainer to walkthrough, TX select lights were staying on. This is the fix.
        BKUPtx.BackColor = Color.Transparent
        INT1tx.BackColor = Color.GreenYellow
        INT2tx.BackColor = Color.Transparent
        ATC1tx.BackColor = Color.Transparent
        ATC2tx.BackColor = Color.Transparent
        HFtx.BackColor = Color.Transparent
        VU1tx.BackColor = Color.Transparent
        VU2tx.BackColor = Color.Transparent
        MSR1tx.BackColor = Color.Transparent
        MSR2tx.BackColor = Color.Transparent
        MSR3tx.BackColor = Color.Transparent
        MSR4tx.BackColor = Color.Transparent
        CDLtx.BackColor = Color.Transparent
        btnINT1light.BackColor = Color.GreenYellow
        btnINT2light.BackColor = Color.Transparent
        btnATC1light.BackColor = Color.Transparent
        btnATC2light.BackColor = Color.Transparent
        btnHFlight.BackColor = Color.Transparent
        btnVU1light.BackColor = Color.Transparent
        btnVU2light.BackColor = Color.Transparent
        btnMSR1leftLight.BackColor = Color.Transparent
        btnMSR2leftLight.BackColor = Color.Transparent
        btnMSR3leftLight.BackColor = Color.Transparent
        btnMSR4leftLight.BackColor = Color.Transparent
        btnCDLleftLight.BackColor = Color.Transparent

        btnDME1light.BackColor = Color.Transparent
        btnDME2light.BackColor = Color.Transparent
        btnMBlight.BackColor = Color.Transparent
        btnTACANlight.BackColor = Color.Transparent
        btnVOR1light.BackColor = Color.Transparent
        btnVOR2light.BackColor = Color.Transparent
        btnAUXleftLight.BackColor = Color.Transparent
        btnADFlight.BackColor = Color.Transparent
    End Sub

    Private Sub GroupBox1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown, moveBtn.MouseDown

        drag = True
        mousex = Windows.Forms.Cursor.Position.X - Me.Left
        mousey = Windows.Forms.Cursor.Position.X - Me.Top

    End Sub

    Private Sub GroupBox1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove, moveBtn.MouseMove

        If drag Then
            Me.Top = Windows.Forms.Cursor.Position.Y - 310
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub GroupBox1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp, moveBtn.MouseUp

        drag = False

    End Sub


    Private Sub closeBtn_Click(sender As Object, e As EventArgs) Handles closeBtn.Click
        Me.Close()
    End Sub

    Private Sub DimDown()
        If alpha <= 0.75 Then
            alpha = alpha + 0.05
        End If
        SetAlphas()
        'sets baseline times for new button click
        timeStart = 0
        timeEnd = 0
    End Sub

    Private Sub DimUp()
        If alpha >= 0.05 Then
            alpha = alpha - 0.05
        End If
        SetAlphas()
        'sets baseline times for new button click
        timeStart = 0
        timeEnd = 0
    End Sub

    Private Sub DimmerSetup()
        DimmerForm.Show()
        DimmerForm.Owner = Me
        DimmerForm.Size = New Size(248, 51)


        ld1.Show()
        ld1.Owner = Me
        ld1.Size = New Size(5, 5)


        ld2.Show()
        ld2.Owner = Me
        ld2.Size = New Size(5, 5)


        ld3.Show()
        ld3.Owner = Me
        ld3.Size = New Size(5, 5)


        ld4.Show()
        ld4.Owner = Me
        ld4.Size = New Size(5, 5)


        ld5.Show()
        ld5.Owner = Me
        ld5.Size = New Size(5, 5)


        ld6.Show()
        ld6.Owner = Me
        ld6.Size = New Size(5, 5)


        ld7.Show()
        ld7.Owner = Me
        ld7.Size = New Size(5, 5)


        ld8.Show()
        ld8.Owner = Me
        ld8.Size = New Size(5, 5)


        ld9.Show()
        ld9.Owner = Me
        ld9.Size = New Size(5, 5)


        ld10.Show()
        ld10.Owner = Me
        ld10.Size = New Size(5, 5)


        ld11.Show()
        ld11.Owner = Me
        ld11.Size = New Size(5, 5)

        ld12.Show()
        ld12.Owner = Me
        ld12.Size = New Size(5, 5)

        ld13.Show()
        ld13.Owner = Me
        ld13.Size = New Size(5, 5)

        ld14.Show()
        ld14.Owner = Me
        ld14.Size = New Size(5, 5)

        ld15.Show()
        ld15.Owner = Me
        ld15.Size = New Size(5, 5)

        ld16.Show()
        ld16.Owner = Me
        ld16.Size = New Size(5, 5)

        ld17.Show()
        ld17.Owner = Me
        ld17.Size = New Size(5, 5)

        ld18.Show()
        ld18.Owner = Me
        ld18.Size = New Size(5, 5)

        ld19.Show()
        ld19.Owner = Me
        ld19.Size = New Size(5, 5)

        ld20.Show()
        ld20.Owner = Me
        ld20.Size = New Size(5, 5)


        ld21.Show()
        ld21.Owner = Me
        ld21.Size = New Size(5, 5)

        ld22.Show()
        ld22.Owner = Me
        ld22.Size = New Size(5, 5)

        ld23.Show()
        ld23.Owner = Me
        ld23.Size = New Size(5, 5)

        ld24.Show()
        ld24.Owner = Me
        ld24.Size = New Size(5, 5)

        ld25.Show()
        ld25.Owner = Me
        ld25.Size = New Size(5, 5)


        ld31.Show()
        ld31.Owner = Me
        ld31.Size = New Size(5, 5)

        ld32.Show()
        ld32.Owner = Me
        ld32.Size = New Size(5, 5)

        ld33.Show()
        ld33.Owner = Me
        ld33.Size = New Size(5, 5)

        ld34.Show()
        ld34.Owner = Me
        ld34.Size = New Size(5, 5)

        ld35.Show()
        ld35.Owner = Me
        ld35.Size = New Size(5, 5)

        ld36.Show()
        ld36.Owner = Me
        ld36.Size = New Size(5, 5)

        ld37.Show()
        ld37.Owner = Me
        ld37.Size = New Size(5, 5)

        ld38.Show()
        ld38.Owner = Me
        ld38.Size = New Size(5, 5)

        ld39.Show()
        ld39.Owner = Me
        ld39.Size = New Size(5, 5)

        ld40.Show()
        ld40.Owner = Me
        ld40.Size = New Size(5, 5)

        ld41.Show()
        ld41.Owner = Me
        ld41.Size = New Size(5, 5)

        ld42.Show()
        ld42.Owner = Me
        ld42.Size = New Size(5, 5)

        ld43.Show()
        ld43.Owner = Me
        ld43.Size = New Size(5, 5)


        DimmerLocations()






    End Sub

    Private Sub SetAlphas()
        DimmerForm.Opacity = alpha
        ld1.Opacity = alpha
        ld2.Opacity = alpha
        ld3.Opacity = alpha
        ld4.Opacity = alpha
        ld5.Opacity = alpha
        ld6.Opacity = alpha
        ld7.Opacity = alpha
        ld8.Opacity = alpha
        ld9.Opacity = alpha
        ld10.Opacity = alpha

        ld11.Opacity = alpha
        ld12.Opacity = alpha
        ld13.Opacity = alpha
        ld14.Opacity = alpha
        ld15.Opacity = alpha
        ld16.Opacity = alpha
        ld17.Opacity = alpha
        ld18.Opacity = alpha
        ld19.Opacity = alpha
        ld20.Opacity = alpha

        ld21.Opacity = alpha
        ld22.Opacity = alpha
        ld23.Opacity = alpha
        ld24.Opacity = alpha
        ld25.Opacity = alpha

        ld31.Opacity = alpha
        ld32.Opacity = alpha
        ld33.Opacity = alpha
        ld34.Opacity = alpha
        ld35.Opacity = alpha
        ld36.Opacity = alpha
        ld37.Opacity = alpha
        ld38.Opacity = alpha
        ld39.Opacity = alpha
        ld40.Opacity = alpha
        ld41.Opacity = alpha
        ld42.Opacity = alpha
        ld43.Opacity = alpha

    End Sub



    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Public Sub DimmerLocations()
        DimmerForm.Location = New Point(Me.Location.X + xoffset + 386, Me.Location.Y + yoffset + 52)
        ld1.Location = New Point(Me.Location.X + 307 + xoffset + sideWidth, Me.Location.Y + yoffset + 109 + topHeight)
        ld2.Location = New Point(Me.Location.X + 334 + xoffset + sideWidth, Me.Location.Y + yoffset + 109 + topHeight)
        ld3.Location = New Point(Me.Location.X + 379 + xoffset + sideWidth, Me.Location.Y + yoffset + 109 + topHeight)
        ld4.Location = New Point(Me.Location.X + 406 + xoffset + sideWidth, Me.Location.Y + yoffset + 109 + topHeight)
        ld5.Location = New Point(Me.Location.X + 599 + xoffset + sideWidth, Me.Location.Y + yoffset + 109 + topHeight)
        ld6.Location = New Point(Me.Location.X + 261 + xoffset + sideWidth, Me.Location.Y + yoffset + 109 + topHeight)
        ld7.Location = New Point(Me.Location.X + 234 + xoffset + sideWidth, Me.Location.Y + yoffset + 109 + topHeight)
        ld8.Location = New Point(Me.Location.X + 187 + xoffset + sideWidth, Me.Location.Y + yoffset + 109 + topHeight)
        ld9.Location = New Point(Me.Location.X + 160 + xoffset + sideWidth, Me.Location.Y + yoffset + 109 + topHeight)
        ld10.Location = New Point(Me.Location.X + 112 + xoffset + sideWidth, Me.Location.Y + yoffset + 109 + topHeight)
        ld11.Location = New Point(Me.Location.X + 85 + xoffset + sideWidth, Me.Location.Y + yoffset + 109 + topHeight)
        ld12.Location = New Point(Me.Location.X + 85 + xoffset + sideWidth, Me.Location.Y + yoffset + 40 + topHeight)
        ld13.Location = New Point(Me.Location.X + 112 + xoffset + sideWidth, Me.Location.Y + yoffset + 40 + topHeight)
        ld14.Location = New Point(Me.Location.X + 160 + xoffset + sideWidth, Me.Location.Y + yoffset + 40 + topHeight)
        ld15.Location = New Point(Me.Location.X + 187 + xoffset + sideWidth, Me.Location.Y + yoffset + 40 + topHeight)
        ld16.Location = New Point(Me.Location.X + 234 + xoffset + sideWidth, Me.Location.Y + yoffset + 40 + topHeight)
        ld17.Location = New Point(Me.Location.X + 261 + xoffset + sideWidth, Me.Location.Y + yoffset + 40 + topHeight)
        ld18.Location = New Point(Me.Location.X + 307 + xoffset + sideWidth, Me.Location.Y + yoffset + 40 + topHeight)
        ld19.Location = New Point(Me.Location.X + 334 + xoffset + sideWidth, Me.Location.Y + yoffset + 40 + topHeight)
        ld20.Location = New Point(Me.Location.X + 85 + xoffset + sideWidth, Me.Location.Y + yoffset + 179 + topHeight)
        ld21.Location = New Point(Me.Location.X + 160 + xoffset + sideWidth, Me.Location.Y + yoffset + 179 + topHeight)
        ld22.Location = New Point(Me.Location.X + 234 + xoffset + sideWidth, Me.Location.Y + yoffset + 179 + topHeight)
        ld23.Location = New Point(Me.Location.X + 85 + xoffset + sideWidth, Me.Location.Y + yoffset + 248 + topHeight)
        ld24.Location = New Point(Me.Location.X + 160 + xoffset + sideWidth, Me.Location.Y + yoffset + 248 + topHeight)
        ld25.Location = New Point(Me.Location.X + 234 + xoffset + sideWidth, Me.Location.Y + yoffset + 248 + topHeight)
        ld31.Location = New Point(Me.Location.X + 474 + xoffset + sideWidth, Me.Location.Y + yoffset + 313 + topHeight)
        ld32.Location = New Point(Me.Location.X + 459 + xoffset + sideWidth, Me.Location.Y + yoffset + 293 + topHeight)
        ld33.Location = New Point(Me.Location.X + 454 + xoffset + sideWidth, Me.Location.Y + yoffset + 268 + topHeight)
        ld34.Location = New Point(Me.Location.X + 459 + xoffset + sideWidth, Me.Location.Y + yoffset + 243 + topHeight)
        ld35.Location = New Point(Me.Location.X + 472 + xoffset + sideWidth, Me.Location.Y + yoffset + 223 + topHeight)
        ld36.Location = New Point(Me.Location.X + 492 + xoffset + sideWidth, Me.Location.Y + yoffset + 210 + topHeight)
        ld37.Location = New Point(Me.Location.X + 517 + xoffset + sideWidth, Me.Location.Y + yoffset + 204 + topHeight)
        ld38.Location = New Point(Me.Location.X + 541 + xoffset + sideWidth, Me.Location.Y + yoffset + 209 + topHeight)
        ld39.Location = New Point(Me.Location.X + 562 + xoffset + sideWidth, Me.Location.Y + yoffset + 223 + topHeight)
        ld40.Location = New Point(Me.Location.X + 575 + xoffset + sideWidth, Me.Location.Y + yoffset + 244 + topHeight)
        ld41.Location = New Point(Me.Location.X + 580 + xoffset + sideWidth, Me.Location.Y + yoffset + 268 + topHeight)
        ld42.Location = New Point(Me.Location.X + 575 + xoffset + sideWidth, Me.Location.Y + yoffset + 293 + topHeight)
        ld43.Location = New Point(Me.Location.X + 561 + xoffset + sideWidth, Me.Location.Y + yoffset + 312 + topHeight)
    End Sub

    Private Sub MainForm_Move(sender As Object, e As EventArgs) Handles MyBase.Move

    End Sub

    Private Sub MainForm_LocationChanged(sender As Object, e As EventArgs) Handles MyBase.LocationChanged
        If Me.FormBorderStyle <> Windows.Forms.FormBorderStyle.None Then
            xoffset = 0
            yoffset = 0
        Else
            xoffset = -10
            yoffset = -32
        End If
        DimmerLocations()
    End Sub

    

End Class
