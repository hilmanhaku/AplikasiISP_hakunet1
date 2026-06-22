<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUtama
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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormUtama))
        Panel1 = New Panel()
        btnLogout = New Button()
        btnTranksaksi = New Button()
        btnPelanggan = New Button()
        btnDashboard = New Button()
        Panel3 = New Panel()
        PictureBox4 = New PictureBox()
        PictureBox1 = New PictureBox()
        Panel2 = New Panel()
        txtUserLogin = New Button()
        PictureBox2 = New PictureBox()
        PanelContainer = New Panel()
        Timer1 = New Timer(components)
        Panel1.SuspendLayout()
        Panel3.SuspendLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(2), CByte(45), CByte(61))
        Panel1.Controls.Add(btnLogout)
        Panel1.Controls.Add(btnTranksaksi)
        Panel1.Controls.Add(btnPelanggan)
        Panel1.Controls.Add(btnDashboard)
        Panel1.Controls.Add(Panel3)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Margin = New Padding(3, 2, 3, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(262, 1041)
        Panel1.TabIndex = 0
        ' 
        ' btnLogout
        ' 
        btnLogout.BackColor = Color.Transparent
        btnLogout.FlatAppearance.BorderSize = 0
        btnLogout.FlatStyle = FlatStyle.Flat
        btnLogout.Font = New Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnLogout.ForeColor = SystemColors.ButtonFace
        btnLogout.Image = CType(resources.GetObject("btnLogout.Image"), Image)
        btnLogout.ImageAlign = ContentAlignment.TopCenter
        btnLogout.Location = New Point(38, 750)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(184, 94)
        btnLogout.TabIndex = 0
        btnLogout.Text = "LogOut"
        btnLogout.TextAlign = ContentAlignment.BottomCenter
        btnLogout.UseVisualStyleBackColor = False
        ' 
        ' btnTranksaksi
        ' 
        btnTranksaksi.BackColor = Color.Transparent
        btnTranksaksi.FlatAppearance.BorderSize = 0
        btnTranksaksi.FlatStyle = FlatStyle.Flat
        btnTranksaksi.Font = New Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnTranksaksi.ForeColor = SystemColors.ButtonFace
        btnTranksaksi.Image = CType(resources.GetObject("btnTranksaksi.Image"), Image)
        btnTranksaksi.ImageAlign = ContentAlignment.TopCenter
        btnTranksaksi.Location = New Point(38, 598)
        btnTranksaksi.Name = "btnTranksaksi"
        btnTranksaksi.Size = New Size(184, 94)
        btnTranksaksi.TabIndex = 0
        btnTranksaksi.Text = "Tranksaksi"
        btnTranksaksi.TextAlign = ContentAlignment.BottomCenter
        btnTranksaksi.UseVisualStyleBackColor = False
        ' 
        ' btnPelanggan
        ' 
        btnPelanggan.BackColor = Color.Transparent
        btnPelanggan.FlatAppearance.BorderSize = 0
        btnPelanggan.FlatStyle = FlatStyle.Flat
        btnPelanggan.Font = New Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnPelanggan.ForeColor = SystemColors.ButtonFace
        btnPelanggan.Image = CType(resources.GetObject("btnPelanggan.Image"), Image)
        btnPelanggan.ImageAlign = ContentAlignment.TopCenter
        btnPelanggan.Location = New Point(38, 447)
        btnPelanggan.Name = "btnPelanggan"
        btnPelanggan.Size = New Size(184, 94)
        btnPelanggan.TabIndex = 0
        btnPelanggan.Text = "Pelanggan"
        btnPelanggan.TextAlign = ContentAlignment.BottomCenter
        btnPelanggan.UseVisualStyleBackColor = False
        ' 
        ' btnDashboard
        ' 
        btnDashboard.BackColor = Color.Transparent
        btnDashboard.FlatAppearance.BorderSize = 0
        btnDashboard.FlatStyle = FlatStyle.Flat
        btnDashboard.Font = New Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDashboard.ForeColor = SystemColors.ButtonFace
        btnDashboard.Image = CType(resources.GetObject("btnDashboard.Image"), Image)
        btnDashboard.ImageAlign = ContentAlignment.TopCenter
        btnDashboard.Location = New Point(38, 268)
        btnDashboard.Name = "btnDashboard"
        btnDashboard.Size = New Size(184, 94)
        btnDashboard.TabIndex = 0
        btnDashboard.Text = "Dashboard"
        btnDashboard.TextAlign = ContentAlignment.BottomCenter
        btnDashboard.UseVisualStyleBackColor = False
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.ForestGreen
        Panel3.Controls.Add(PictureBox4)
        Panel3.Controls.Add(PictureBox1)
        Panel3.Dock = DockStyle.Top
        Panel3.Location = New Point(0, 0)
        Panel3.Margin = New Padding(3, 2, 3, 2)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(262, 120)
        Panel3.TabIndex = 1
        ' 
        ' PictureBox4
        ' 
        PictureBox4.BackColor = Color.DeepSkyBlue
        PictureBox4.BackgroundImage = CType(resources.GetObject("PictureBox4.BackgroundImage"), Image)
        PictureBox4.Image = My.Resources.Resources.Desain_tanpa_judul__3_
        PictureBox4.Location = New Point(-3, -83)
        PictureBox4.Margin = New Padding(3, 2, 3, 2)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(265, 285)
        PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox4.TabIndex = 1
        PictureBox4.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.DeepSkyBlue
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.Image = My.Resources.Resources.Desain_tanpa_judul__3_
        PictureBox1.Location = New Point(-3, -20)
        PictureBox1.Margin = New Padding(3, 2, 3, 2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(265, 157)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(2), CByte(45), CByte(61))
        Panel2.Controls.Add(txtUserLogin)
        Panel2.Controls.Add(PictureBox2)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(262, 0)
        Panel2.Margin = New Padding(3, 2, 3, 2)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1642, 120)
        Panel2.TabIndex = 1
        ' 
        ' txtUserLogin
        ' 
        txtUserLogin.BackColor = Color.Transparent
        txtUserLogin.FlatAppearance.BorderSize = 0
        txtUserLogin.FlatStyle = FlatStyle.Flat
        txtUserLogin.Font = New Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtUserLogin.ForeColor = SystemColors.ButtonFace
        txtUserLogin.Image = CType(resources.GetObject("txtUserLogin.Image"), Image)
        txtUserLogin.ImageAlign = ContentAlignment.TopCenter
        txtUserLogin.Location = New Point(1488, 9)
        txtUserLogin.Name = "txtUserLogin"
        txtUserLogin.Size = New Size(159, 104)
        txtUserLogin.TabIndex = 0
        txtUserLogin.Text = "Username"
        txtUserLogin.TextAlign = ContentAlignment.BottomCenter
        txtUserLogin.UseVisualStyleBackColor = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.FromArgb(CByte(47), CByte(53), CByte(66))
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(0, 0)
        PictureBox2.Margin = New Padding(3, 2, 3, 2)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(1486, 120)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 1
        PictureBox2.TabStop = False
        ' 
        ' PanelContainer
        ' 
        PanelContainer.BackColor = SystemColors.GradientActiveCaption
        PanelContainer.Dock = DockStyle.Fill
        PanelContainer.Location = New Point(262, 120)
        PanelContainer.Margin = New Padding(3, 2, 3, 2)
        PanelContainer.Name = "PanelContainer"
        PanelContainer.Size = New Size(1642, 921)
        PanelContainer.TabIndex = 2
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        Timer1.Interval = 3000
        ' 
        ' FormUtama
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1904, 1041)
        Controls.Add(PanelContainer)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Margin = New Padding(3, 2, 3, 2)
        Name = "FormUtama"
        Text = "FormUtama"
        Panel1.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PanelContainer As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents btnDashboard As Button
    Friend WithEvents btnPelanggan As Button
    Friend WithEvents btnTranksaksi As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents txtUserLogin As Button
    Friend WithEvents Timer1 As Timer
End Class
