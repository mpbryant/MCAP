<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Information
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Information))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnContinue = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ModesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TrainerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FailureToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ICUToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ATC1BusyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WalkthroughToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InformationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MinimizeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 27)
        Me.Label1.MaximumSize = New System.Drawing.Size(300, 800)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(0, 0, 0, 30)
        Me.Label1.Size = New System.Drawing.Size(68, 52)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Label1"
        '
        'btnContinue
        '
        Me.btnContinue.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnContinue.Location = New System.Drawing.Point(0, 100)
        Me.btnContinue.Name = "btnContinue"
        Me.btnContinue.Size = New System.Drawing.Size(312, 23)
        Me.btnContinue.TabIndex = 1
        Me.btnContinue.Text = "Close"
        Me.btnContinue.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ModesToolStripMenuItem, Me.ViewToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStrip1.Size = New System.Drawing.Size(312, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ModesToolStripMenuItem
        '
        Me.ModesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TrainerToolStripMenuItem, Me.FailureToolStripMenuItem, Me.WalkthroughToolStripMenuItem})
        Me.ModesToolStripMenuItem.Name = "ModesToolStripMenuItem"
        Me.ModesToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.ModesToolStripMenuItem.Text = "Modes"
        '
        'TrainerToolStripMenuItem
        '
        Me.TrainerToolStripMenuItem.CheckOnClick = True
        Me.TrainerToolStripMenuItem.Name = "TrainerToolStripMenuItem"
        Me.TrainerToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.TrainerToolStripMenuItem.Text = "Trainer"
        '
        'FailureToolStripMenuItem
        '
        Me.FailureToolStripMenuItem.CheckOnClick = True
        Me.FailureToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ICUToolStripMenuItem, Me.ATC1BusyToolStripMenuItem})
        Me.FailureToolStripMenuItem.Name = "FailureToolStripMenuItem"
        Me.FailureToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.FailureToolStripMenuItem.Text = "Failure"
        '
        'ICUToolStripMenuItem
        '
        Me.ICUToolStripMenuItem.Name = "ICUToolStripMenuItem"
        Me.ICUToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.ICUToolStripMenuItem.Text = "ICU"
        '
        'ATC1BusyToolStripMenuItem
        '
        Me.ATC1BusyToolStripMenuItem.Name = "ATC1BusyToolStripMenuItem"
        Me.ATC1BusyToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.ATC1BusyToolStripMenuItem.Text = "ATC1 Busy"
        '
        'WalkthroughToolStripMenuItem
        '
        Me.WalkthroughToolStripMenuItem.Checked = True
        Me.WalkthroughToolStripMenuItem.CheckOnClick = True
        Me.WalkthroughToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.WalkthroughToolStripMenuItem.Name = "WalkthroughToolStripMenuItem"
        Me.WalkthroughToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.WalkthroughToolStripMenuItem.Text = "Walkthrough"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InformationToolStripMenuItem})
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.ViewToolStripMenuItem.Text = "View"
        '
        'InformationToolStripMenuItem
        '
        Me.InformationToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MinimizeToolStripMenuItem})
        Me.InformationToolStripMenuItem.Name = "InformationToolStripMenuItem"
        Me.InformationToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.InformationToolStripMenuItem.Text = "Information "
        '
        'MinimizeToolStripMenuItem
        '
        Me.MinimizeToolStripMenuItem.Name = "MinimizeToolStripMenuItem"
        Me.MinimizeToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
        Me.MinimizeToolStripMenuItem.Text = "Minimize"
        '
        'Information
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(312, 123)
        Me.Controls.Add(Me.btnContinue)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Information"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Information"
        Me.TopMost = True
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnContinue As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ModesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TrainerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FailureToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InformationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MinimizeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ICUToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ATC1BusyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WalkthroughToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
