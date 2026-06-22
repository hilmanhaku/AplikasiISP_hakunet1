<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dashboard))
        Panel1 = New Panel()
        PictureBox1 = New PictureBox()
        lblTotalPelanggan = New Label()
        Label1 = New Label()
        Panel3 = New Panel()
        PictureBox3 = New PictureBox()
        lblTotalPendapatan = New Label()
        Label5 = New Label()
        Panel4 = New Panel()
        PictureBox2 = New PictureBox()
        lblTotalTransaksi = New Label()
        Label3 = New Label()
        MaterialProgressBar1 = New MaterialSkin.Controls.MaterialProgressBar()
        GroupBox1 = New GroupBox()
        dgvPaket = New DataGridView()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        Panel4.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        CType(dgvPaket, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.Highlight
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(lblTotalPelanggan)
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(328, 837)
        Panel1.TabIndex = 0
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(62, 444)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(148, 129)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' lblTotalPelanggan
        ' 
        lblTotalPelanggan.AutoSize = True
        lblTotalPelanggan.Font = New Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTotalPelanggan.Location = New Point(111, 373)
        lblTotalPelanggan.Name = "lblTotalPelanggan"
        lblTotalPelanggan.Size = New Size(43, 47)
        lblTotalPelanggan.TabIndex = 0
        lblTotalPelanggan.Text = "X"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(34, 317)
        Label1.Name = "Label1"
        Label1.Size = New Size(269, 37)
        Label1.TabIndex = 0
        Label1.Text = "TOTAL PELANGGAN"
        ' 
        ' Panel3
        ' 
        Panel3.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        Panel3.BackColor = Color.Cyan
        Panel3.Controls.Add(PictureBox3)
        Panel3.Controls.Add(lblTotalPendapatan)
        Panel3.Controls.Add(Label5)
        Panel3.Location = New Point(642, 0)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(341, 837)
        Panel3.TabIndex = 0
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(91, 444)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(148, 129)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 1
        PictureBox3.TabStop = False
        ' 
        ' lblTotalPendapatan
        ' 
        lblTotalPendapatan.AutoSize = True
        lblTotalPendapatan.Font = New Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTotalPendapatan.Location = New Point(53, 373)
        lblTotalPendapatan.Name = "lblTotalPendapatan"
        lblTotalPendapatan.Size = New Size(46, 50)
        lblTotalPendapatan.TabIndex = 0
        lblTotalPendapatan.Text = "X"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(38, 312)
        Label5.Name = "Label5"
        Label5.Size = New Size(282, 37)
        Label5.TabIndex = 0
        Label5.Text = "TOTAL PENDAPATAN"
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.ForestGreen
        Panel4.Controls.Add(PictureBox2)
        Panel4.Controls.Add(lblTotalTransaksi)
        Panel4.Controls.Add(Label3)
        Panel4.Dock = DockStyle.Left
        Panel4.Location = New Point(328, 0)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(318, 837)
        Panel4.TabIndex = 0
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(77, 444)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(148, 129)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 1
        PictureBox2.TabStop = False
        ' 
        ' lblTotalTransaksi
        ' 
        lblTotalTransaksi.AutoSize = True
        lblTotalTransaksi.Font = New Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTotalTransaksi.Location = New Point(126, 373)
        lblTotalTransaksi.Name = "lblTotalTransaksi"
        lblTotalTransaksi.Size = New Size(43, 47)
        lblTotalTransaksi.TabIndex = 0
        lblTotalTransaksi.Text = "X"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(36, 312)
        Label3.Name = "Label3"
        Label3.Size = New Size(255, 37)
        Label3.TabIndex = 0
        Label3.Text = "TOTAL TRANSAKSI"
        ' 
        ' MaterialProgressBar1
        ' 
        MaterialProgressBar1.Depth = 0
        MaterialProgressBar1.Location = New Point(1594, 155)
        MaterialProgressBar1.MouseState = MaterialSkin.MouseState.HOVER
        MaterialProgressBar1.Name = "MaterialProgressBar1"
        MaterialProgressBar1.Size = New Size(100, 5)
        MaterialProgressBar1.TabIndex = 1
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(dgvPaket)
        GroupBox1.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox1.Location = New Point(1002, 0)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(586, 837)
        GroupBox1.TabIndex = 2
        GroupBox1.TabStop = False
        GroupBox1.Text = "Daftar Paket"
        ' 
        ' dgvPaket
        ' 
        dgvPaket.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvPaket.BackgroundColor = SystemColors.ActiveCaption
        dgvPaket.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvPaket.Location = New Point(6, 56)
        dgvPaket.MultiSelect = False
        dgvPaket.Name = "dgvPaket"
        dgvPaket.ReadOnly = True
        dgvPaket.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvPaket.Size = New Size(574, 769)
        dgvPaket.TabIndex = 3
        ' 
        ' dashboard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.GradientActiveCaption
        ClientSize = New Size(1660, 837)
        Controls.Add(GroupBox1)
        Controls.Add(MaterialProgressBar1)
        Controls.Add(Panel4)
        Controls.Add(Panel3)
        Controls.Add(Panel1)
        Name = "dashboard"
        StartPosition = FormStartPosition.Manual
        Text = "dashboard"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        CType(dgvPaket, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents lblTotalPelanggan As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblTotalPendapatan As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblTotalTransaksi As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents MaterialProgressBar1 As MaterialSkin.Controls.MaterialProgressBar
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dgvPaket As DataGridView
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
End Class
