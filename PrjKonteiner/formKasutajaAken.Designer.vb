<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formKasutajaAken
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
        Me.components = New System.ComponentModel.Container()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.txtSisendTekst = New System.Windows.Forms.TextBox()
        Me.txtValjundTekst1 = New System.Windows.Forms.TextBox()
        Me.txtValjundTekst2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnPoora1 = New System.Windows.Forms.Button()
        Me.btnPoora2 = New System.Windows.Forms.Button()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnStopp = New System.Windows.Forms.Button()
        Me.timerUuenda = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'txtSisendTekst
        '
        Me.txtSisendTekst.Location = New System.Drawing.Point(360, 113)
        Me.txtSisendTekst.Name = "txtSisendTekst"
        Me.txtSisendTekst.Size = New System.Drawing.Size(224, 26)
        Me.txtSisendTekst.TabIndex = 2
        '
        'txtValjundTekst1
        '
        Me.txtValjundTekst1.Location = New System.Drawing.Point(360, 296)
        Me.txtValjundTekst1.Name = "txtValjundTekst1"
        Me.txtValjundTekst1.Size = New System.Drawing.Size(224, 26)
        Me.txtValjundTekst1.TabIndex = 3
        '
        'txtValjundTekst2
        '
        Me.txtValjundTekst2.Location = New System.Drawing.Point(360, 464)
        Me.txtValjundTekst2.Name = "txtValjundTekst2"
        Me.txtValjundTekst2.Size = New System.Drawing.Size(224, 26)
        Me.txtValjundTekst2.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(139, 119)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Sisendtekst"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(139, 302)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(184, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Pööramine funktsiooniga"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(139, 470)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(187, 20)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Pööramine protseduuriga"
        '
        'btnPoora1
        '
        Me.btnPoora1.Location = New System.Drawing.Point(360, 374)
        Me.btnPoora1.Name = "btnPoora1"
        Me.btnPoora1.Size = New System.Drawing.Size(224, 28)
        Me.btnPoora1.TabIndex = 8
        Me.btnPoora1.Text = "Pööra funktsiooniga"
        Me.btnPoora1.UseVisualStyleBackColor = True
        '
        'btnPoora2
        '
        Me.btnPoora2.Location = New System.Drawing.Point(360, 531)
        Me.btnPoora2.Name = "btnPoora2"
        Me.btnPoora2.Size = New System.Drawing.Size(224, 27)
        Me.btnPoora2.TabIndex = 9
        Me.btnPoora2.Text = "Pööra protseduuriga"
        Me.btnPoora2.UseVisualStyleBackColor = True
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(735, 119)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(123, 59)
        Me.btnStart.TabIndex = 10
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'btnStopp
        '
        Me.btnStopp.Location = New System.Drawing.Point(728, 492)
        Me.btnStopp.Name = "btnStopp"
        Me.btnStopp.Size = New System.Drawing.Size(130, 66)
        Me.btnStopp.TabIndex = 11
        Me.btnStopp.Text = "Stop"
        Me.btnStopp.UseVisualStyleBackColor = True
        '
        'timerUuenda
        '
        Me.timerUuenda.Interval = 5000
        '
        'formKasutajaAken
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(961, 648)
        Me.Controls.Add(Me.btnStopp)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.btnPoora2)
        Me.Controls.Add(Me.btnPoora1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtValjundTekst2)
        Me.Controls.Add(Me.txtValjundTekst1)
        Me.Controls.Add(Me.txtSisendTekst)
        Me.Name = "formKasutajaAken"
        Me.Text = "Tekstitöötlus"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents txtSisendTekst As TextBox
    Friend WithEvents txtValjundTekst1 As TextBox
    Friend WithEvents txtValjundTekst2 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnPoora1 As Button
    Friend WithEvents btnPoora2 As Button
    Friend WithEvents btnStart As Button
    Friend WithEvents btnStopp As Button
    Friend WithEvents timerUuenda As Timer
End Class
