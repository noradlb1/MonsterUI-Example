<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.MonsterListView1 = New WindowsApp6يسباسيلسيبقلاشيبثيفاشثسبثيا.MonsterUI.MonsterListView()
        Me.SuspendLayout()
        '
        'MonsterListView1
        '
        Me.MonsterListView1.BackColor = System.Drawing.Color.White
        Me.MonsterListView1.BorderColor = System.Drawing.Color.Gray
        Me.MonsterListView1.GridLinesColor = System.Drawing.Color.LightGray
        Me.MonsterListView1.HeaderBackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.MonsterListView1.HeaderForeColor = System.Drawing.Color.Black
        Me.MonsterListView1.HeaderHeight = 25
        Me.MonsterListView1.HoveredItemBackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MonsterListView1.HoveredItemForeColor = System.Drawing.Color.Black
        Me.MonsterListView1.ItemAlternateBackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.MonsterListView1.ItemBackColor = System.Drawing.Color.White
        Me.MonsterListView1.ItemForeColor = System.Drawing.Color.Black
        Me.MonsterListView1.ItemHeight = 20
        Me.MonsterListView1.Location = New System.Drawing.Point(-23, -46)
        Me.MonsterListView1.MultiSelect = False
        Me.MonsterListView1.Name = "MonsterListView1"
        Me.MonsterListView1.SelectedItemBackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MonsterListView1.SelectedItemForeColor = System.Drawing.Color.White
        Me.MonsterListView1.ShowGridLines = True
        Me.MonsterListView1.Size = New System.Drawing.Size(400, 300)
        Me.MonsterListView1.TabIndex = 0
        Me.MonsterListView1.UseAlternateRowColors = True
        Me.MonsterListView1.UseHoverEffect = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MonsterListView1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MonsterListView1 As MonsterUI.MonsterListView
End Class
