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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GunaCircleButton1 = New Guna.UI.WinForms.GunaCircleButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.UIDtxt = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.PSWDtxt = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BunifuThinButton21 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.button1 = New Bunifu.Framework.UI.BunifuThinButton2()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Agency FB", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Green
        Me.Label1.Location = New System.Drawing.Point(385, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(383, 44)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Employee Management System"
        '
        'GunaCircleButton1
        '
        Me.GunaCircleButton1.AnimationHoverSpeed = 0.07!
        Me.GunaCircleButton1.AnimationSpeed = 0.03!
        Me.GunaCircleButton1.BaseColor = System.Drawing.Color.Green
        Me.GunaCircleButton1.BorderColor = System.Drawing.Color.Black
        Me.GunaCircleButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaCircleButton1.FocusedColor = System.Drawing.Color.Empty
        Me.GunaCircleButton1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaCircleButton1.ForeColor = System.Drawing.Color.White
        Me.GunaCircleButton1.Image = Nothing
        Me.GunaCircleButton1.ImageSize = New System.Drawing.Size(52, 52)
        Me.GunaCircleButton1.Location = New System.Drawing.Point(-83, -54)
        Me.GunaCircleButton1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GunaCircleButton1.Name = "GunaCircleButton1"
        Me.GunaCircleButton1.OnHoverBaseColor = System.Drawing.Color.Green
        Me.GunaCircleButton1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaCircleButton1.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaCircleButton1.OnHoverImage = Nothing
        Me.GunaCircleButton1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaCircleButton1.Size = New System.Drawing.Size(373, 529)
        Me.GunaCircleButton1.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Green
        Me.Label3.Location = New System.Drawing.Point(360, 140)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 33)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "User ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Green
        Me.Label2.Location = New System.Drawing.Point(360, 221)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(147, 33)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Password"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Green
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(99, 113)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(157, 168)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Green
        Me.Label4.Location = New System.Drawing.Point(828, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 42)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "X"
        '
        'UIDtxt
        '
        Me.UIDtxt.BackColor = System.Drawing.Color.White
        Me.UIDtxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.UIDtxt.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UIDtxt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.UIDtxt.HintForeColor = System.Drawing.Color.Empty
        Me.UIDtxt.HintText = ""
        Me.UIDtxt.isPassword = False
        Me.UIDtxt.LineFocusedColor = System.Drawing.Color.DarkSeaGreen
        Me.UIDtxt.LineIdleColor = System.Drawing.Color.Green
        Me.UIDtxt.LineMouseHoverColor = System.Drawing.Color.DarkBlue
        Me.UIDtxt.LineThickness = 3
        Me.UIDtxt.Location = New System.Drawing.Point(541, 129)
        Me.UIDtxt.Margin = New System.Windows.Forms.Padding(4)
        Me.UIDtxt.Name = "UIDtxt"
        Me.UIDtxt.Size = New System.Drawing.Size(248, 44)
        Me.UIDtxt.TabIndex = 12
        Me.UIDtxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'PSWDtxt
        '
        Me.PSWDtxt.BackColor = System.Drawing.Color.White
        Me.PSWDtxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.PSWDtxt.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PSWDtxt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PSWDtxt.HintForeColor = System.Drawing.Color.Empty
        Me.PSWDtxt.HintText = " "
        Me.PSWDtxt.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PSWDtxt.isPassword = False
        Me.PSWDtxt.LineFocusedColor = System.Drawing.Color.Blue
        Me.PSWDtxt.LineIdleColor = System.Drawing.Color.Green
        Me.PSWDtxt.LineMouseHoverColor = System.Drawing.Color.DarkBlue
        Me.PSWDtxt.LineThickness = 3
        Me.PSWDtxt.Location = New System.Drawing.Point(541, 201)
        Me.PSWDtxt.Margin = New System.Windows.Forms.Padding(4)
        Me.PSWDtxt.Name = "PSWDtxt"
        Me.PSWDtxt.Size = New System.Drawing.Size(248, 44)
        Me.PSWDtxt.TabIndex = 13
        Me.PSWDtxt.Tag = ""
        Me.PSWDtxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuThinButton21
        '
        Me.BunifuThinButton21.ActiveBorderThickness = 1
        Me.BunifuThinButton21.ActiveCornerRadius = 20
        Me.BunifuThinButton21.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton21.ActiveForecolor = System.Drawing.Color.White
        Me.BunifuThinButton21.ActiveLineColor = System.Drawing.Color.White
        Me.BunifuThinButton21.BackColor = System.Drawing.Color.White
        Me.BunifuThinButton21.BackgroundImage = CType(resources.GetObject("BunifuThinButton21.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton21.ButtonText = "Log In"
        Me.BunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton21.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton21.ForeColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton21.IdleBorderThickness = 1
        Me.BunifuThinButton21.IdleCornerRadius = 20
        Me.BunifuThinButton21.IdleFillColor = System.Drawing.Color.Green
        Me.BunifuThinButton21.IdleForecolor = System.Drawing.Color.White
        Me.BunifuThinButton21.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton21.Location = New System.Drawing.Point(442, 313)
        Me.BunifuThinButton21.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuThinButton21.Name = "BunifuThinButton21"
        Me.BunifuThinButton21.Size = New System.Drawing.Size(222, 45)
        Me.BunifuThinButton21.TabIndex = 14
        Me.BunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'button1
        '
        Me.button1.ActiveBorderThickness = 1
        Me.button1.ActiveCornerRadius = 20
        Me.button1.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.button1.ActiveForecolor = System.Drawing.Color.White
        Me.button1.ActiveLineColor = System.Drawing.Color.White
        Me.button1.BackColor = System.Drawing.Color.White
        Me.button1.BackgroundImage = CType(resources.GetObject("button1.BackgroundImage"), System.Drawing.Image)
        Me.button1.ButtonText = "Reset"
        Me.button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.button1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button1.ForeColor = System.Drawing.Color.SeaGreen
        Me.button1.IdleBorderThickness = 1
        Me.button1.IdleCornerRadius = 20
        Me.button1.IdleFillColor = System.Drawing.Color.Green
        Me.button1.IdleForecolor = System.Drawing.Color.White
        Me.button1.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.button1.Location = New System.Drawing.Point(674, 313)
        Me.button1.Margin = New System.Windows.Forms.Padding(5)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(94, 45)
        Me.button1.TabIndex = 15
        Me.button1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(866, 427)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.BunifuThinButton21)
        Me.Controls.Add(Me.PSWDtxt)
        Me.Controls.Add(Me.UIDtxt)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GunaCircleButton1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Log In"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GunaCircleButton1 As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents UIDtxt As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents PSWDtxt As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BunifuThinButton21 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents button1 As Bunifu.Framework.UI.BunifuThinButton2
End Class
