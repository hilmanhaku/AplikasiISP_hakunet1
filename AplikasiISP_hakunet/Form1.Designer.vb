<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        txtUsername = New MaterialSkin.Controls.MaterialTextBox2()
        txtPassword = New MaterialSkin.Controls.MaterialTextBox2()
        btnLogin = New MaterialSkin.Controls.MaterialButton()
        PictureBox1 = New PictureBox()
        MaterialButton1 = New MaterialSkin.Controls.MaterialButton()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtUsername
        ' 
        txtUsername.AnimateReadOnly = False
        txtUsername.BackgroundImageLayout = ImageLayout.None
        txtUsername.CharacterCasing = CharacterCasing.Normal
        txtUsername.Depth = 0
        txtUsername.Font = New Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel)
        txtUsername.HideSelection = True
        txtUsername.Hint = "Masukan Username"
        txtUsername.LeadingIcon = Nothing
        txtUsername.Location = New Point(636, 442)
        txtUsername.Margin = New Padding(3, 2, 3, 2)
        txtUsername.MaxLength = 32767
        txtUsername.MouseState = MaterialSkin.MouseState.OUT
        txtUsername.Name = "txtUsername"
        txtUsername.PasswordChar = ChrW(0)
        txtUsername.PrefixSuffixText = Nothing
        txtUsername.ReadOnly = False
        txtUsername.RightToLeft = RightToLeft.No
        txtUsername.SelectedText = ""
        txtUsername.SelectionLength = 0
        txtUsername.SelectionStart = 0
        txtUsername.ShortcutsEnabled = True
        txtUsername.Size = New Size(392, 48)
        txtUsername.TabIndex = 1
        txtUsername.TabStop = False
        txtUsername.TextAlign = HorizontalAlignment.Left
        txtUsername.TrailingIcon = Nothing
        txtUsername.UseSystemPasswordChar = False
        ' 
        ' txtPassword
        ' 
        txtPassword.AnimateReadOnly = False
        txtPassword.BackgroundImageLayout = ImageLayout.None
        txtPassword.CharacterCasing = CharacterCasing.Normal
        txtPassword.Depth = 0
        txtPassword.Font = New Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel)
        txtPassword.HideSelection = True
        txtPassword.Hint = "Masukan Password"
        txtPassword.LeadingIcon = Nothing
        txtPassword.Location = New Point(636, 515)
        txtPassword.Margin = New Padding(3, 2, 3, 2)
        txtPassword.MaxLength = 32767
        txtPassword.MouseState = MaterialSkin.MouseState.OUT
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "*"c
        txtPassword.PrefixSuffixText = Nothing
        txtPassword.ReadOnly = False
        txtPassword.RightToLeft = RightToLeft.No
        txtPassword.SelectedText = ""
        txtPassword.SelectionLength = 0
        txtPassword.SelectionStart = 0
        txtPassword.ShortcutsEnabled = True
        txtPassword.Size = New Size(392, 48)
        txtPassword.TabIndex = 1
        txtPassword.TabStop = False
        txtPassword.TextAlign = HorizontalAlignment.Left
        txtPassword.TrailingIcon = Nothing
        txtPassword.UseSystemPasswordChar = False
        ' 
        ' btnLogin
        ' 
        btnLogin.AutoSize = False
        btnLogin.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnLogin.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        btnLogin.Depth = 0
        btnLogin.HighEmphasis = True
        btnLogin.Icon = Nothing
        btnLogin.Location = New Point(664, 595)
        btnLogin.Margin = New Padding(4)
        btnLogin.MouseState = MaterialSkin.MouseState.HOVER
        btnLogin.Name = "btnLogin"
        btnLogin.NoAccentTextColor = Color.Empty
        btnLogin.Padding = New Padding(9, 8, 9, 8)
        btnLogin.Size = New Size(132, 44)
        btnLogin.TabIndex = 2
        btnLogin.Text = "Login"
        btnLogin.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        btnLogin.UseAccentColor = False
        btnLogin.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = My.Resources.Resources.Desain_tanpa_judul__3_
        PictureBox1.Location = New Point(562, 70)
        PictureBox1.Margin = New Padding(3, 2, 3, 2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(553, 357)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 3
        PictureBox1.TabStop = False
        ' 
        ' MaterialButton1
        ' 
        MaterialButton1.AutoSize = False
        MaterialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink
        MaterialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        MaterialButton1.Depth = 0
        MaterialButton1.HighEmphasis = True
        MaterialButton1.Icon = Nothing
        MaterialButton1.Location = New Point(833, 595)
        MaterialButton1.Margin = New Padding(4, 6, 4, 6)
        MaterialButton1.MouseState = MaterialSkin.MouseState.HOVER
        MaterialButton1.Name = "MaterialButton1"
        MaterialButton1.NoAccentTextColor = Color.Empty
        MaterialButton1.Size = New Size(133, 44)
        MaterialButton1.TabIndex = 4
        MaterialButton1.Text = "Exit"
        MaterialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        MaterialButton1.UseAccentColor = False
        MaterialButton1.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        BackgroundImage = My.Resources.Resources.Gemini_Generated_Image_4x9ofo4x9ofo4x9o
        ClientSize = New Size(1664, 846)
        Controls.Add(MaterialButton1)
        Controls.Add(PictureBox1)
        Controls.Add(btnLogin)
        Controls.Add(txtPassword)
        Controls.Add(txtUsername)
        Margin = New Padding(3, 2, 3, 2)
        Name = "Form1"
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents txtUsername As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents txtPassword As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents btnLogin As MaterialSkin.Controls.MaterialButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents MaterialButton1 As MaterialSkin.Controls.MaterialButton

End Class
