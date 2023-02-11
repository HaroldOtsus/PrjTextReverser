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
        Me.tekstiPikkus = New System.Windows.Forms.Label()
        Me.t2isH22likud = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tekstiPoorajaRadio = New System.Windows.Forms.RadioButton()
        Me.algoPoorajaRadio = New System.Windows.Forms.RadioButton()
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
        Me.txtSisendTekst.Location = New System.Drawing.Point(240, 73)
        Me.txtSisendTekst.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSisendTekst.Name = "txtSisendTekst"
        Me.txtSisendTekst.Size = New System.Drawing.Size(151, 20)
        Me.txtSisendTekst.TabIndex = 2
        '
        'txtValjundTekst1
        '
        Me.txtValjundTekst1.Location = New System.Drawing.Point(240, 192)
        Me.txtValjundTekst1.Margin = New System.Windows.Forms.Padding(2)
        Me.txtValjundTekst1.Name = "txtValjundTekst1"
        Me.txtValjundTekst1.Size = New System.Drawing.Size(151, 20)
        Me.txtValjundTekst1.TabIndex = 3
        '
        'txtValjundTekst2
        '
        Me.txtValjundTekst2.Location = New System.Drawing.Point(240, 302)
        Me.txtValjundTekst2.Margin = New System.Windows.Forms.Padding(2)
        Me.txtValjundTekst2.Name = "txtValjundTekst2"
        Me.txtValjundTekst2.Size = New System.Drawing.Size(151, 20)
        Me.txtValjundTekst2.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(93, 77)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Sisendtekst"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(93, 196)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Pööramine funktsiooniga"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(93, 306)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(124, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Pööramine protseduuriga"
        '
        'btnPoora1
        '
        Me.btnPoora1.Location = New System.Drawing.Point(240, 243)
        Me.btnPoora1.Margin = New System.Windows.Forms.Padding(2)
        Me.btnPoora1.Name = "btnPoora1"
        Me.btnPoora1.Size = New System.Drawing.Size(151, 32)
        Me.btnPoora1.TabIndex = 8
        Me.btnPoora1.Text = "Pööra funktsiooniga"
        Me.btnPoora1.UseVisualStyleBackColor = True
        '
        'btnPoora2
        '
        Me.btnPoora2.Location = New System.Drawing.Point(240, 345)
        Me.btnPoora2.Margin = New System.Windows.Forms.Padding(2)
        Me.btnPoora2.Name = "btnPoora2"
        Me.btnPoora2.Size = New System.Drawing.Size(151, 36)
        Me.btnPoora2.TabIndex = 9
        Me.btnPoora2.Text = "Pööra protseduuriga"
        Me.btnPoora2.UseVisualStyleBackColor = True
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(526, 119)
        Me.btnStart.Margin = New System.Windows.Forms.Padding(2)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(82, 38)
        Me.btnStart.TabIndex = 10
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'btnStopp
        '
        Me.btnStopp.Location = New System.Drawing.Point(526, 243)
        Me.btnStopp.Margin = New System.Windows.Forms.Padding(2)
        Me.btnStopp.Name = "btnStopp"
        Me.btnStopp.Size = New System.Drawing.Size(87, 43)
        Me.btnStopp.TabIndex = 11
        Me.btnStopp.Text = "Stop"
        Me.btnStopp.UseVisualStyleBackColor = True
        '
        'timerUuenda
        '
        Me.timerUuenda.Interval = 5000
        '
        'tekstiPikkus
        '
        Me.tekstiPikkus.AutoSize = True
        Me.tekstiPikkus.Location = New System.Drawing.Point(396, 80)
        Me.tekstiPikkus.Name = "tekstiPikkus"
        Me.tekstiPikkus.Size = New System.Drawing.Size(7, 13)
        Me.tekstiPikkus.TabIndex = 12
        Me.tekstiPikkus.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        't2isH22likud
        '
        Me.t2isH22likud.AutoSize = True
        Me.t2isH22likud.Location = New System.Drawing.Point(425, 80)
        Me.t2isH22likud.Name = "t2isH22likud"
        Me.t2isH22likud.Size = New System.Drawing.Size(0, 13)
        Me.t2isH22likud.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(237, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Klassivalik:"
        '
        'tekstiPoorajaRadio
        '
        Me.tekstiPoorajaRadio.AutoSize = True
        Me.tekstiPoorajaRadio.Checked = True
        Me.tekstiPoorajaRadio.Location = New System.Drawing.Point(313, 5)
        Me.tekstiPoorajaRadio.Name = "tekstiPoorajaRadio"
        Me.tekstiPoorajaRadio.Size = New System.Drawing.Size(93, 17)
        Me.tekstiPoorajaRadio.TabIndex = 15
        Me.tekstiPoorajaRadio.TabStop = True
        Me.tekstiPoorajaRadio.Text = "Teksti Pööraja"
        Me.tekstiPoorajaRadio.UseVisualStyleBackColor = True
        '
        'algoPoorajaRadio
        '
        Me.algoPoorajaRadio.AutoSize = True
        Me.algoPoorajaRadio.Location = New System.Drawing.Point(313, 28)
        Me.algoPoorajaRadio.Name = "algoPoorajaRadio"
        Me.algoPoorajaRadio.Size = New System.Drawing.Size(119, 17)
        Me.algoPoorajaRadio.TabIndex = 16
        Me.algoPoorajaRadio.Text = "Algoritmiline Pööraja"
        Me.algoPoorajaRadio.UseVisualStyleBackColor = True
        '
        'formKasutajaAken
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(657, 421)
        Me.Controls.Add(Me.algoPoorajaRadio)
        Me.Controls.Add(Me.tekstiPoorajaRadio)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.t2isH22likud)
        Me.Controls.Add(Me.tekstiPikkus)
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
        Me.Margin = New System.Windows.Forms.Padding(2)
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
    Friend WithEvents tekstiPikkus As Label
    Friend WithEvents t2isH22likud As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents tekstiPoorajaRadio As RadioButton
    Friend WithEvents algoPoorajaRadio As RadioButton
End Class
