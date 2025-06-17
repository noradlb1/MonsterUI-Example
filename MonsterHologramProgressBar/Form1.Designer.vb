<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.MonsterHologramProgressBar1 = New WindowsApp6يسباسيلسيبقلاشيبثيفاشثسبثيا.MonsterUI.MonsterHologramProgressBar()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(62, 23)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(110, 52)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(192, 90)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(110, 52)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(62, 90)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(110, 52)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Button3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(192, 32)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(110, 52)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Button4"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'MonsterHologramProgressBar1
        '
        Me.MonsterHologramProgressBar1.AnimationSpeed = 50
        Me.MonsterHologramProgressBar1.BackColor = System.Drawing.Color.Transparent
        Me.MonsterHologramProgressBar1.BorderColor = System.Drawing.Color.DeepSkyBlue
        Me.MonsterHologramProgressBar1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.MonsterHologramProgressBar1.GlowColor = System.Drawing.Color.White
        Me.MonsterHologramProgressBar1.HologramColor = System.Drawing.Color.Cyan
        Me.MonsterHologramProgressBar1.HologramDepth = 20
        Me.MonsterHologramProgressBar1.HologramStyle = WindowsApp6يسباسيلسيبقلاشيبثيفاشثسبثيا.MonsterUI.MonsterHologramProgressBar.MonsterHologramStyle.Digital
        Me.MonsterHologramProgressBar1.Location = New System.Drawing.Point(79, 226)
        Me.MonsterHologramProgressBar1.Maximum = 100
        Me.MonsterHologramProgressBar1.Name = "MonsterHologramProgressBar1"
        Me.MonsterHologramProgressBar1.PulseEffect = True
        Me.MonsterHologramProgressBar1.ScanlineEffect = True
        Me.MonsterHologramProgressBar1.ShowText = True
        Me.MonsterHologramProgressBar1.Size = New System.Drawing.Size(300, 50)
        Me.MonsterHologramProgressBar1.TabIndex = 4
        Me.MonsterHologramProgressBar1.Text = "MonsterHologramProgressBar1"
        Me.MonsterHologramProgressBar1.Value = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(620, 313)
        Me.Controls.Add(Me.MonsterHologramProgressBar1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents MonsterHologramProgressBar1 As MonsterUI.MonsterHologramProgressBar
End Class
