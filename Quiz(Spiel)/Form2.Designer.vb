<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.lblFrage = New System.Windows.Forms.Label()
        Me.txtBoxAntwortA = New System.Windows.Forms.TextBox()
        Me.txtBoxAntwortB = New System.Windows.Forms.TextBox()
        Me.txtBoxAntwortD = New System.Windows.Forms.TextBox()
        Me.txtBoxAntwortC = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblSpieler1 = New System.Windows.Forms.Label()
        Me.lblSpieler2 = New System.Windows.Forms.Label()
        Me.cboBoxSpieler1 = New System.Windows.Forms.ComboBox()
        Me.lblPunkteSpieler1 = New System.Windows.Forms.Label()
        Me.lblPunkteSpieler2 = New System.Windows.Forms.Label()
        Me.btnAbgleich = New System.Windows.Forms.Button()
        Me.cboBoxSpieler2 = New System.Windows.Forms.ComboBox()
        Me.btnNaechsteFrage = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblFrage
        '
        Me.lblFrage.AutoSize = True
        Me.lblFrage.BackColor = System.Drawing.Color.Transparent
        Me.lblFrage.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFrage.ForeColor = System.Drawing.Color.Yellow
        Me.lblFrage.Location = New System.Drawing.Point(286, 174)
        Me.lblFrage.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFrage.Name = "lblFrage"
        Me.lblFrage.Size = New System.Drawing.Size(352, 31)
        Me.lblFrage.TabIndex = 0
        Me.lblFrage.Text = "Hallo dies ist ein TestText"
        '
        'txtBoxAntwortA
        '
        Me.txtBoxAntwortA.Location = New System.Drawing.Point(33, 116)
        Me.txtBoxAntwortA.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBoxAntwortA.Name = "txtBoxAntwortA"
        Me.txtBoxAntwortA.Size = New System.Drawing.Size(215, 22)
        Me.txtBoxAntwortA.TabIndex = 1
        '
        'txtBoxAntwortB
        '
        Me.txtBoxAntwortB.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBoxAntwortB.Location = New System.Drawing.Point(679, 116)
        Me.txtBoxAntwortB.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBoxAntwortB.Name = "txtBoxAntwortB"
        Me.txtBoxAntwortB.Size = New System.Drawing.Size(213, 22)
        Me.txtBoxAntwortB.TabIndex = 2
        '
        'txtBoxAntwortD
        '
        Me.txtBoxAntwortD.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBoxAntwortD.Location = New System.Drawing.Point(679, 303)
        Me.txtBoxAntwortD.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBoxAntwortD.Name = "txtBoxAntwortD"
        Me.txtBoxAntwortD.Size = New System.Drawing.Size(213, 22)
        Me.txtBoxAntwortD.TabIndex = 3
        '
        'txtBoxAntwortC
        '
        Me.txtBoxAntwortC.Location = New System.Drawing.Point(33, 303)
        Me.txtBoxAntwortC.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBoxAntwortC.Name = "txtBoxAntwortC"
        Me.txtBoxAntwortC.Size = New System.Drawing.Size(215, 22)
        Me.txtBoxAntwortC.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Fuchsia
        Me.Label1.Location = New System.Drawing.Point(72, 255)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 29)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Antwort C"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Fuchsia
        Me.Label2.Location = New System.Drawing.Point(74, 63)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 29)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Antwort A"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Fuchsia
        Me.Label3.Location = New System.Drawing.Point(750, 63)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(124, 29)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Antwort B"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Fuchsia
        Me.Label4.Location = New System.Drawing.Point(750, 255)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(125, 29)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Antwort D"
        '
        'lblSpieler1
        '
        Me.lblSpieler1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblSpieler1.AutoSize = True
        Me.lblSpieler1.BackColor = System.Drawing.Color.Fuchsia
        Me.lblSpieler1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSpieler1.Location = New System.Drawing.Point(85, 396)
        Me.lblSpieler1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSpieler1.Name = "lblSpieler1"
        Me.lblSpieler1.Size = New System.Drawing.Size(112, 29)
        Me.lblSpieler1.TabIndex = 9
        Me.lblSpieler1.Text = "Spieler1"
        '
        'lblSpieler2
        '
        Me.lblSpieler2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSpieler2.AutoSize = True
        Me.lblSpieler2.BackColor = System.Drawing.Color.Fuchsia
        Me.lblSpieler2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSpieler2.Location = New System.Drawing.Point(709, 396)
        Me.lblSpieler2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSpieler2.Name = "lblSpieler2"
        Me.lblSpieler2.Size = New System.Drawing.Size(112, 29)
        Me.lblSpieler2.TabIndex = 10
        Me.lblSpieler2.Text = "Spieler2"
        '
        'cboBoxSpieler1
        '
        Me.cboBoxSpieler1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cboBoxSpieler1.FormattingEnabled = True
        Me.cboBoxSpieler1.Items.AddRange(New Object() {"Antwort A", "Antwort B", "Antwort C", "Antwort D "})
        Me.cboBoxSpieler1.Location = New System.Drawing.Point(37, 449)
        Me.cboBoxSpieler1.Margin = New System.Windows.Forms.Padding(4)
        Me.cboBoxSpieler1.Name = "cboBoxSpieler1"
        Me.cboBoxSpieler1.Size = New System.Drawing.Size(160, 24)
        Me.cboBoxSpieler1.TabIndex = 11
        '
        'lblPunkteSpieler1
        '
        Me.lblPunkteSpieler1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblPunkteSpieler1.AutoSize = True
        Me.lblPunkteSpieler1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPunkteSpieler1.Location = New System.Drawing.Point(37, 502)
        Me.lblPunkteSpieler1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPunkteSpieler1.Name = "lblPunkteSpieler1"
        Me.lblPunkteSpieler1.Size = New System.Drawing.Size(165, 25)
        Me.lblPunkteSpieler1.TabIndex = 13
        Me.lblPunkteSpieler1.Text = "Punkte Spieler1"
        '
        'lblPunkteSpieler2
        '
        Me.lblPunkteSpieler2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPunkteSpieler2.AutoSize = True
        Me.lblPunkteSpieler2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPunkteSpieler2.Location = New System.Drawing.Point(709, 502)
        Me.lblPunkteSpieler2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPunkteSpieler2.Name = "lblPunkteSpieler2"
        Me.lblPunkteSpieler2.Size = New System.Drawing.Size(165, 25)
        Me.lblPunkteSpieler2.TabIndex = 14
        Me.lblPunkteSpieler2.Text = "Punkte Spieler2"
        '
        'btnAbgleich
        '
        Me.btnAbgleich.BackColor = System.Drawing.Color.Fuchsia
        Me.btnAbgleich.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAbgleich.Location = New System.Drawing.Point(237, 588)
        Me.btnAbgleich.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAbgleich.Name = "btnAbgleich"
        Me.btnAbgleich.Size = New System.Drawing.Size(222, 51)
        Me.btnAbgleich.TabIndex = 16
        Me.btnAbgleich.Text = "Prüfen"
        Me.btnAbgleich.UseVisualStyleBackColor = False
        '
        'cboBoxSpieler2
        '
        Me.cboBoxSpieler2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboBoxSpieler2.FormattingEnabled = True
        Me.cboBoxSpieler2.Items.AddRange(New Object() {"Antwort A", "Antwort B", "Antwort C", "Antwort D "})
        Me.cboBoxSpieler2.Location = New System.Drawing.Point(701, 449)
        Me.cboBoxSpieler2.Name = "cboBoxSpieler2"
        Me.cboBoxSpieler2.Size = New System.Drawing.Size(160, 24)
        Me.cboBoxSpieler2.TabIndex = 17
        '
        'btnNaechsteFrage
        '
        Me.btnNaechsteFrage.BackColor = System.Drawing.Color.Fuchsia
        Me.btnNaechsteFrage.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNaechsteFrage.Location = New System.Drawing.Point(481, 588)
        Me.btnNaechsteFrage.Margin = New System.Windows.Forms.Padding(4)
        Me.btnNaechsteFrage.Name = "btnNaechsteFrage"
        Me.btnNaechsteFrage.Size = New System.Drawing.Size(222, 51)
        Me.btnNaechsteFrage.TabIndex = 18
        Me.btnNaechsteFrage.Text = "Weiter"
        Me.btnNaechsteFrage.UseVisualStyleBackColor = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(921, 652)
        Me.Controls.Add(Me.btnNaechsteFrage)
        Me.Controls.Add(Me.cboBoxSpieler2)
        Me.Controls.Add(Me.btnAbgleich)
        Me.Controls.Add(Me.lblPunkteSpieler2)
        Me.Controls.Add(Me.lblPunkteSpieler1)
        Me.Controls.Add(Me.cboBoxSpieler1)
        Me.Controls.Add(Me.lblSpieler2)
        Me.Controls.Add(Me.lblSpieler1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtBoxAntwortC)
        Me.Controls.Add(Me.txtBoxAntwortD)
        Me.Controls.Add(Me.txtBoxAntwortB)
        Me.Controls.Add(Me.txtBoxAntwortA)
        Me.Controls.Add(Me.lblFrage)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form2"
        Me.Text = "Spiel"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblFrage As Label
    Friend WithEvents txtBoxAntwortA As TextBox
    Friend WithEvents txtBoxAntwortB As TextBox
    Friend WithEvents txtBoxAntwortD As TextBox
    Friend WithEvents txtBoxAntwortC As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblSpieler1 As Label
    Friend WithEvents lblSpieler2 As Label
    Friend WithEvents cboBoxSpieler1 As ComboBox
    Friend WithEvents lblPunkteSpieler1 As Label
    Friend WithEvents lblPunkteSpieler2 As Label
    Friend WithEvents btnAbgleich As Button
    Friend WithEvents cboBoxSpieler2 As ComboBox
    Friend WithEvents btnNaechsteFrage As Button
End Class
