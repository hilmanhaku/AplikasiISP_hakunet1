<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pelanggan
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
        Label1 = New Label()
        GroupBox1 = New GroupBox()
        lblTgl = New Label()
        dtTgl = New DateTimePicker()
        btnReset = New MaterialSkin.Controls.MaterialButton()
        btnHapus = New MaterialSkin.Controls.MaterialButton()
        btnUbah = New MaterialSkin.Controls.MaterialButton()
        btnSimpan = New MaterialSkin.Controls.MaterialButton()
        cmbStatus = New MaterialSkin.Controls.MaterialComboBox()
        cmbJenis = New MaterialSkin.Controls.MaterialComboBox()
        txtHP = New MaterialSkin.Controls.MaterialTextBox2()
        txtAlamat = New MaterialSkin.Controls.MaterialTextBox2()
        txtNama = New MaterialSkin.Controls.MaterialTextBox2()
        txtCari = New MaterialSkin.Controls.MaterialTextBox2()
        dgvPelanggan = New DataGridView()
        GroupBox1.SuspendLayout()
        CType(dgvPelanggan, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(86, 27)
        Label1.Name = "Label1"
        Label1.Size = New Size(481, 45)
        Label1.TabIndex = 0
        Label1.Text = "DATA PELANGGAN HAKU.NET"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(lblTgl)
        GroupBox1.Controls.Add(dtTgl)
        GroupBox1.Controls.Add(btnReset)
        GroupBox1.Controls.Add(btnHapus)
        GroupBox1.Controls.Add(btnUbah)
        GroupBox1.Controls.Add(btnSimpan)
        GroupBox1.Controls.Add(cmbStatus)
        GroupBox1.Controls.Add(cmbJenis)
        GroupBox1.Controls.Add(txtHP)
        GroupBox1.Controls.Add(txtAlamat)
        GroupBox1.Controls.Add(txtNama)
        GroupBox1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox1.Location = New Point(64, 105)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(502, 680)
        GroupBox1.TabIndex = 1
        GroupBox1.TabStop = False
        GroupBox1.Text = "Form pelanggan"
        ' 
        ' lblTgl
        ' 
        lblTgl.AutoSize = True
        lblTgl.Location = New Point(15, 417)
        lblTgl.Name = "lblTgl"
        lblTgl.Size = New Size(123, 21)
        lblTgl.TabIndex = 4
        lblTgl.Text = "Tanggal Daftar"
        ' 
        ' dtTgl
        ' 
        dtTgl.CalendarMonthBackground = SystemColors.InactiveCaption
        dtTgl.CustomFormat = "dddd, dd mmmm yyyy"
        dtTgl.DropDownAlign = LeftRightAlignment.Right
        dtTgl.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        dtTgl.Format = DateTimePickerFormat.Short
        dtTgl.Location = New Point(15, 453)
        dtTgl.Name = "dtTgl"
        dtTgl.RightToLeft = RightToLeft.Yes
        dtTgl.ShowUpDown = True
        dtTgl.Size = New Size(467, 33)
        dtTgl.TabIndex = 3
        dtTgl.UseWaitCursor = True
        dtTgl.Value = New Date(2026, 6, 21, 13, 32, 57, 0)
        ' 
        ' btnReset
        ' 
        btnReset.AutoSize = False
        btnReset.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnReset.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        btnReset.Depth = 0
        btnReset.HighEmphasis = True
        btnReset.Icon = Nothing
        btnReset.Location = New Point(385, 518)
        btnReset.Margin = New Padding(4, 6, 4, 6)
        btnReset.MouseState = MaterialSkin.MouseState.HOVER
        btnReset.Name = "btnReset"
        btnReset.NoAccentTextColor = Color.Empty
        btnReset.Size = New Size(81, 36)
        btnReset.TabIndex = 2
        btnReset.Text = "RESET"
        btnReset.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        btnReset.UseAccentColor = False
        btnReset.UseVisualStyleBackColor = True
        ' 
        ' btnHapus
        ' 
        btnHapus.AutoSize = False
        btnHapus.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnHapus.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        btnHapus.Depth = 0
        btnHapus.HighEmphasis = True
        btnHapus.Icon = Nothing
        btnHapus.Location = New Point(264, 518)
        btnHapus.Margin = New Padding(4, 6, 4, 6)
        btnHapus.MouseState = MaterialSkin.MouseState.HOVER
        btnHapus.Name = "btnHapus"
        btnHapus.NoAccentTextColor = Color.Empty
        btnHapus.Size = New Size(81, 36)
        btnHapus.TabIndex = 2
        btnHapus.Text = "HAPUS"
        btnHapus.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        btnHapus.UseAccentColor = False
        btnHapus.UseVisualStyleBackColor = True
        ' 
        ' btnUbah
        ' 
        btnUbah.AutoSize = False
        btnUbah.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnUbah.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        btnUbah.Depth = 0
        btnUbah.HighEmphasis = True
        btnUbah.Icon = Nothing
        btnUbah.Location = New Point(143, 518)
        btnUbah.Margin = New Padding(4, 6, 4, 6)
        btnUbah.MouseState = MaterialSkin.MouseState.HOVER
        btnUbah.Name = "btnUbah"
        btnUbah.NoAccentTextColor = Color.Empty
        btnUbah.Size = New Size(81, 36)
        btnUbah.TabIndex = 2
        btnUbah.Text = "UBAH"
        btnUbah.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        btnUbah.UseAccentColor = False
        btnUbah.UseVisualStyleBackColor = True
        ' 
        ' btnSimpan
        ' 
        btnSimpan.AutoSize = False
        btnSimpan.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnSimpan.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        btnSimpan.Depth = 0
        btnSimpan.HighEmphasis = True
        btnSimpan.Icon = Nothing
        btnSimpan.Location = New Point(22, 518)
        btnSimpan.Margin = New Padding(4, 6, 4, 6)
        btnSimpan.MouseState = MaterialSkin.MouseState.HOVER
        btnSimpan.Name = "btnSimpan"
        btnSimpan.NoAccentTextColor = Color.Empty
        btnSimpan.Size = New Size(81, 36)
        btnSimpan.TabIndex = 2
        btnSimpan.Text = "SIMPAN"
        btnSimpan.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        btnSimpan.UseAccentColor = False
        btnSimpan.UseVisualStyleBackColor = True
        ' 
        ' cmbStatus
        ' 
        cmbStatus.AutoResize = False
        cmbStatus.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        cmbStatus.Depth = 0
        cmbStatus.DrawMode = DrawMode.OwnerDrawVariable
        cmbStatus.DropDownHeight = 174
        cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList
        cmbStatus.DropDownWidth = 121
        cmbStatus.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel)
        cmbStatus.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        cmbStatus.FormattingEnabled = True
        cmbStatus.Hint = "Status"
        cmbStatus.IntegralHeight = False
        cmbStatus.ItemHeight = 43
        cmbStatus.Items.AddRange(New Object() {"", "Aktif", "Nonaktif"})
        cmbStatus.Location = New Point(15, 348)
        cmbStatus.MaxDropDownItems = 4
        cmbStatus.MouseState = MaterialSkin.MouseState.OUT
        cmbStatus.Name = "cmbStatus"
        cmbStatus.Size = New Size(467, 49)
        cmbStatus.StartIndex = 0
        cmbStatus.TabIndex = 1
        ' 
        ' cmbJenis
        ' 
        cmbJenis.AutoResize = False
        cmbJenis.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        cmbJenis.Depth = 0
        cmbJenis.DrawMode = DrawMode.OwnerDrawVariable
        cmbJenis.DropDownHeight = 174
        cmbJenis.DropDownStyle = ComboBoxStyle.DropDownList
        cmbJenis.DropDownWidth = 121
        cmbJenis.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel)
        cmbJenis.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        cmbJenis.FormattingEnabled = True
        cmbJenis.Hint = "Jenis Paket (id)"
        cmbJenis.IntegralHeight = False
        cmbJenis.ItemHeight = 43
        cmbJenis.Items.AddRange(New Object() {"", "1", "2", "3"})
        cmbJenis.Location = New Point(15, 276)
        cmbJenis.MaxDropDownItems = 4
        cmbJenis.MouseState = MaterialSkin.MouseState.OUT
        cmbJenis.Name = "cmbJenis"
        cmbJenis.Size = New Size(467, 49)
        cmbJenis.StartIndex = 0
        cmbJenis.TabIndex = 1
        ' 
        ' txtHP
        ' 
        txtHP.AnimateReadOnly = False
        txtHP.BackgroundImageLayout = ImageLayout.None
        txtHP.CharacterCasing = CharacterCasing.Normal
        txtHP.Depth = 0
        txtHP.Font = New Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel)
        txtHP.HideSelection = True
        txtHP.Hint = "Nomor HP"
        txtHP.LeadingIcon = Nothing
        txtHP.Location = New Point(15, 194)
        txtHP.MaxLength = 32767
        txtHP.MouseState = MaterialSkin.MouseState.OUT
        txtHP.Name = "txtHP"
        txtHP.PasswordChar = ChrW(0)
        txtHP.PrefixSuffixText = Nothing
        txtHP.ReadOnly = False
        txtHP.RightToLeft = RightToLeft.No
        txtHP.SelectedText = ""
        txtHP.SelectionLength = 0
        txtHP.SelectionStart = 0
        txtHP.ShortcutsEnabled = True
        txtHP.Size = New Size(467, 48)
        txtHP.TabIndex = 0
        txtHP.TabStop = False
        txtHP.TextAlign = HorizontalAlignment.Left
        txtHP.TrailingIcon = Nothing
        txtHP.UseSystemPasswordChar = False
        ' 
        ' txtAlamat
        ' 
        txtAlamat.AnimateReadOnly = False
        txtAlamat.BackgroundImageLayout = ImageLayout.None
        txtAlamat.CharacterCasing = CharacterCasing.Normal
        txtAlamat.Depth = 0
        txtAlamat.Font = New Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel)
        txtAlamat.HideSelection = True
        txtAlamat.Hint = "Alamat"
        txtAlamat.LeadingIcon = Nothing
        txtAlamat.Location = New Point(15, 127)
        txtAlamat.MaxLength = 32767
        txtAlamat.MouseState = MaterialSkin.MouseState.OUT
        txtAlamat.Name = "txtAlamat"
        txtAlamat.PasswordChar = ChrW(0)
        txtAlamat.PrefixSuffixText = Nothing
        txtAlamat.ReadOnly = False
        txtAlamat.RightToLeft = RightToLeft.No
        txtAlamat.SelectedText = ""
        txtAlamat.SelectionLength = 0
        txtAlamat.SelectionStart = 0
        txtAlamat.ShortcutsEnabled = True
        txtAlamat.Size = New Size(467, 48)
        txtAlamat.TabIndex = 0
        txtAlamat.TabStop = False
        txtAlamat.TextAlign = HorizontalAlignment.Left
        txtAlamat.TrailingIcon = Nothing
        txtAlamat.UseSystemPasswordChar = False
        ' 
        ' txtNama
        ' 
        txtNama.AnimateReadOnly = False
        txtNama.BackgroundImageLayout = ImageLayout.None
        txtNama.CharacterCasing = CharacterCasing.Normal
        txtNama.Depth = 0
        txtNama.Font = New Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel)
        txtNama.HideSelection = True
        txtNama.Hint = "Nama Pelanggan"
        txtNama.LeadingIcon = Nothing
        txtNama.Location = New Point(15, 53)
        txtNama.MaxLength = 32767
        txtNama.MouseState = MaterialSkin.MouseState.OUT
        txtNama.Name = "txtNama"
        txtNama.PasswordChar = ChrW(0)
        txtNama.PrefixSuffixText = Nothing
        txtNama.ReadOnly = False
        txtNama.RightToLeft = RightToLeft.No
        txtNama.SelectedText = ""
        txtNama.SelectionLength = 0
        txtNama.SelectionStart = 0
        txtNama.ShortcutsEnabled = True
        txtNama.Size = New Size(467, 48)
        txtNama.TabIndex = 0
        txtNama.TabStop = False
        txtNama.TextAlign = HorizontalAlignment.Left
        txtNama.TrailingIcon = Nothing
        txtNama.UseSystemPasswordChar = False
        ' 
        ' txtCari
        ' 
        txtCari.AnimateReadOnly = False
        txtCari.BackgroundImageLayout = ImageLayout.None
        txtCari.CharacterCasing = CharacterCasing.Normal
        txtCari.Depth = 0
        txtCari.Font = New Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel)
        txtCari.HideSelection = True
        txtCari.Hint = "Cari Pelanggan"
        txtCari.LeadingIcon = Nothing
        txtCari.Location = New Point(612, 105)
        txtCari.MaxLength = 32767
        txtCari.MouseState = MaterialSkin.MouseState.OUT
        txtCari.Name = "txtCari"
        txtCari.PasswordChar = ChrW(0)
        txtCari.PrefixSuffixText = Nothing
        txtCari.ReadOnly = False
        txtCari.RightToLeft = RightToLeft.No
        txtCari.SelectedText = ""
        txtCari.SelectionLength = 0
        txtCari.SelectionStart = 0
        txtCari.ShortcutsEnabled = True
        txtCari.Size = New Size(978, 48)
        txtCari.TabIndex = 0
        txtCari.TabStop = False
        txtCari.TextAlign = HorizontalAlignment.Left
        txtCari.TrailingIcon = Nothing
        txtCari.UseSystemPasswordChar = False
        ' 
        ' dgvPelanggan
        ' 
        dgvPelanggan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvPelanggan.BackgroundColor = SystemColors.ActiveCaption
        dgvPelanggan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvPelanggan.Location = New Point(612, 174)
        dgvPelanggan.MultiSelect = False
        dgvPelanggan.Name = "dgvPelanggan"
        dgvPelanggan.ReadOnly = True
        dgvPelanggan.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvPelanggan.Size = New Size(978, 550)
        dgvPelanggan.TabIndex = 2
        ' 
        ' pelanggan
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.GradientActiveCaption
        ClientSize = New Size(1660, 837)
        Controls.Add(dgvPelanggan)
        Controls.Add(GroupBox1)
        Controls.Add(Label1)
        Controls.Add(txtCari)
        Name = "pelanggan"
        StartPosition = FormStartPosition.Manual
        Text = "pelanggan"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(dgvPelanggan, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtHP As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents txtAlamat As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents txtNama As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents cmbJenis As MaterialSkin.Controls.MaterialComboBox
    Friend WithEvents cmbStatus As MaterialSkin.Controls.MaterialComboBox
    Friend WithEvents btnReset As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnHapus As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnUbah As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnSimpan As MaterialSkin.Controls.MaterialButton
    Friend WithEvents txtCari As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents dgvPelanggan As DataGridView
    Friend WithEvents dtTgl As DateTimePicker
    Friend WithEvents lblTgl As Label
End Class
