<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class tranksaksi
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(tranksaksi))
        GroupBox1 = New GroupBox()
        btnReset = New MaterialSkin.Controls.MaterialButton()
        btnSimpan = New MaterialSkin.Controls.MaterialButton()
        cbKecepatan = New MaterialSkin.Controls.MaterialComboBox()
        cbPaket = New MaterialSkin.Controls.MaterialComboBox()
        cbStatus = New MaterialSkin.Controls.MaterialComboBox()
        cbPelanggan = New MaterialSkin.Controls.MaterialComboBox()
        txtHarga = New MaterialSkin.Controls.MaterialTextBox2()
        txtTotal = New MaterialSkin.Controls.MaterialTextBox2()
        txtCari = New MaterialSkin.Controls.MaterialTextBox2()
        lblKode = New MaterialSkin.Controls.MaterialTextBox2()
        lblTgl = New Label()
        dtTanggal = New DateTimePicker()
        Label1 = New Label()
        dgvTransaksi = New DataGridView()
        GroupBox3 = New GroupBox()
        lblTotalPendapatan = New Label()
        btnCetak = New MaterialSkin.Controls.MaterialFloatingActionButton()
        PrintDocument1 = New Printing.PrintDocument()
        PrintPreviewDialog1 = New PrintPreviewDialog()
        GroupBox1.SuspendLayout()
        CType(dgvTransaksi, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox3.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(btnReset)
        GroupBox1.Controls.Add(btnSimpan)
        GroupBox1.Controls.Add(cbKecepatan)
        GroupBox1.Controls.Add(cbPaket)
        GroupBox1.Controls.Add(cbStatus)
        GroupBox1.Controls.Add(cbPelanggan)
        GroupBox1.Controls.Add(txtHarga)
        GroupBox1.Controls.Add(txtTotal)
        GroupBox1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox1.Location = New Point(50, 125)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(286, 584)
        GroupBox1.TabIndex = 5
        GroupBox1.TabStop = False
        GroupBox1.Text = "Form Transaksi"
        ' 
        ' btnReset
        ' 
        btnReset.AutoSize = False
        btnReset.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnReset.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        btnReset.Depth = 0
        btnReset.HighEmphasis = True
        btnReset.Icon = Nothing
        btnReset.Location = New Point(146, 509)
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
        ' btnSimpan
        ' 
        btnSimpan.AutoSize = False
        btnSimpan.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnSimpan.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        btnSimpan.Depth = 0
        btnSimpan.HighEmphasis = True
        btnSimpan.Icon = Nothing
        btnSimpan.Location = New Point(34, 509)
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
        ' cbKecepatan
        ' 
        cbKecepatan.AutoResize = False
        cbKecepatan.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        cbKecepatan.Depth = 0
        cbKecepatan.DrawMode = DrawMode.OwnerDrawVariable
        cbKecepatan.DropDownHeight = 174
        cbKecepatan.DropDownStyle = ComboBoxStyle.DropDownList
        cbKecepatan.DropDownWidth = 121
        cbKecepatan.Font = New Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        cbKecepatan.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        cbKecepatan.FormattingEnabled = True
        cbKecepatan.Hint = "Kecepatan / Mbps"
        cbKecepatan.IntegralHeight = False
        cbKecepatan.ItemHeight = 43
        cbKecepatan.Location = New Point(21, 269)
        cbKecepatan.MaxDropDownItems = 4
        cbKecepatan.MouseState = MaterialSkin.MouseState.OUT
        cbKecepatan.Name = "cbKecepatan"
        cbKecepatan.Size = New Size(234, 49)
        cbKecepatan.StartIndex = 0
        cbKecepatan.TabIndex = 1
        ' 
        ' cbPaket
        ' 
        cbPaket.AutoResize = False
        cbPaket.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        cbPaket.Depth = 0
        cbPaket.DrawMode = DrawMode.OwnerDrawVariable
        cbPaket.DropDownHeight = 174
        cbPaket.DropDownStyle = ComboBoxStyle.DropDownList
        cbPaket.DropDownWidth = 121
        cbPaket.Font = New Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        cbPaket.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        cbPaket.FormattingEnabled = True
        cbPaket.Hint = "Jenis Paket"
        cbPaket.IntegralHeight = False
        cbPaket.ItemHeight = 43
        cbPaket.Location = New Point(21, 204)
        cbPaket.MaxDropDownItems = 4
        cbPaket.MouseState = MaterialSkin.MouseState.OUT
        cbPaket.Name = "cbPaket"
        cbPaket.Size = New Size(234, 49)
        cbPaket.StartIndex = 0
        cbPaket.TabIndex = 1
        ' 
        ' cbStatus
        ' 
        cbStatus.AutoResize = False
        cbStatus.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        cbStatus.Depth = 0
        cbStatus.DrawMode = DrawMode.OwnerDrawVariable
        cbStatus.DropDownHeight = 174
        cbStatus.DropDownStyle = ComboBoxStyle.DropDownList
        cbStatus.DropDownWidth = 121
        cbStatus.Font = New Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        cbStatus.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        cbStatus.FormattingEnabled = True
        cbStatus.Hint = "Status Pelanggan"
        cbStatus.IntegralHeight = False
        cbStatus.ItemHeight = 43
        cbStatus.Location = New Point(21, 330)
        cbStatus.MaxDropDownItems = 4
        cbStatus.MouseState = MaterialSkin.MouseState.OUT
        cbStatus.Name = "cbStatus"
        cbStatus.Size = New Size(234, 49)
        cbStatus.StartIndex = 0
        cbStatus.TabIndex = 1
        ' 
        ' cbPelanggan
        ' 
        cbPelanggan.AutoResize = False
        cbPelanggan.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        cbPelanggan.Depth = 0
        cbPelanggan.DrawMode = DrawMode.OwnerDrawVariable
        cbPelanggan.DropDownHeight = 174
        cbPelanggan.DropDownStyle = ComboBoxStyle.DropDownList
        cbPelanggan.DropDownWidth = 121
        cbPelanggan.Font = New Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        cbPelanggan.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        cbPelanggan.FormattingEnabled = True
        cbPelanggan.Hint = "Pilih Pelanggan"
        cbPelanggan.IntegralHeight = False
        cbPelanggan.ItemHeight = 43
        cbPelanggan.Items.AddRange(New Object() {"", "1", "2", "3"})
        cbPelanggan.Location = New Point(22, 58)
        cbPelanggan.MaxDropDownItems = 4
        cbPelanggan.MouseState = MaterialSkin.MouseState.OUT
        cbPelanggan.Name = "cbPelanggan"
        cbPelanggan.Size = New Size(234, 49)
        cbPelanggan.StartIndex = 0
        cbPelanggan.TabIndex = 1
        ' 
        ' txtHarga
        ' 
        txtHarga.AnimateReadOnly = False
        txtHarga.BackgroundImageLayout = ImageLayout.None
        txtHarga.CharacterCasing = CharacterCasing.Normal
        txtHarga.Depth = 0
        txtHarga.Font = New Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel)
        txtHarga.HideSelection = True
        txtHarga.Hint = "Harga Per Mbps"
        txtHarga.LeadingIcon = Nothing
        txtHarga.Location = New Point(22, 134)
        txtHarga.MaxLength = 32767
        txtHarga.MouseState = MaterialSkin.MouseState.OUT
        txtHarga.Name = "txtHarga"
        txtHarga.PasswordChar = ChrW(0)
        txtHarga.PrefixSuffixText = Nothing
        txtHarga.ReadOnly = False
        txtHarga.RightToLeft = RightToLeft.No
        txtHarga.SelectedText = ""
        txtHarga.SelectionLength = 0
        txtHarga.SelectionStart = 0
        txtHarga.ShortcutsEnabled = True
        txtHarga.Size = New Size(234, 48)
        txtHarga.TabIndex = 0
        txtHarga.TabStop = False
        txtHarga.TextAlign = HorizontalAlignment.Left
        txtHarga.TrailingIcon = Nothing
        txtHarga.UseSystemPasswordChar = False
        ' 
        ' txtTotal
        ' 
        txtTotal.AnimateReadOnly = False
        txtTotal.BackgroundImageLayout = ImageLayout.None
        txtTotal.CharacterCasing = CharacterCasing.Normal
        txtTotal.Depth = 0
        txtTotal.Font = New Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel)
        txtTotal.HideSelection = True
        txtTotal.Hint = "Total Bayar"
        txtTotal.LeadingIcon = Nothing
        txtTotal.Location = New Point(21, 407)
        txtTotal.MaxLength = 32767
        txtTotal.MouseState = MaterialSkin.MouseState.OUT
        txtTotal.Name = "txtTotal"
        txtTotal.PasswordChar = ChrW(0)
        txtTotal.PrefixSuffixText = Nothing
        txtTotal.ReadOnly = True
        txtTotal.RightToLeft = RightToLeft.No
        txtTotal.SelectedText = ""
        txtTotal.SelectionLength = 0
        txtTotal.SelectionStart = 0
        txtTotal.ShortcutsEnabled = True
        txtTotal.Size = New Size(234, 48)
        txtTotal.TabIndex = 0
        txtTotal.TabStop = False
        txtTotal.TextAlign = HorizontalAlignment.Left
        txtTotal.TrailingIcon = Nothing
        txtTotal.UseSystemPasswordChar = False
        ' 
        ' txtCari
        ' 
        txtCari.AnimateReadOnly = False
        txtCari.BackgroundImageLayout = ImageLayout.None
        txtCari.CharacterCasing = CharacterCasing.Normal
        txtCari.Depth = 0
        txtCari.Font = New Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel)
        txtCari.HideSelection = True
        txtCari.Hint = "Cari Transaksi"
        txtCari.LeadingIcon = Nothing
        txtCari.Location = New Point(422, 227)
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
        txtCari.Size = New Size(862, 48)
        txtCari.TabIndex = 0
        txtCari.TabStop = False
        txtCari.TextAlign = HorizontalAlignment.Left
        txtCari.TrailingIcon = Nothing
        txtCari.UseSystemPasswordChar = False
        ' 
        ' lblKode
        ' 
        lblKode.AnimateReadOnly = False
        lblKode.BackgroundImageLayout = ImageLayout.None
        lblKode.CharacterCasing = CharacterCasing.Normal
        lblKode.Depth = 0
        lblKode.Font = New Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel)
        lblKode.HideSelection = True
        lblKode.Hint = "Kode Transaksi"
        lblKode.LeadingIcon = Nothing
        lblKode.Location = New Point(1301, 227)
        lblKode.MaxLength = 32767
        lblKode.MouseState = MaterialSkin.MouseState.OUT
        lblKode.Name = "lblKode"
        lblKode.PasswordChar = ChrW(0)
        lblKode.PrefixSuffixText = Nothing
        lblKode.ReadOnly = True
        lblKode.RightToLeft = RightToLeft.No
        lblKode.SelectedText = ""
        lblKode.SelectionLength = 0
        lblKode.SelectionStart = 0
        lblKode.ShortcutsEnabled = True
        lblKode.Size = New Size(234, 48)
        lblKode.TabIndex = 0
        lblKode.TabStop = False
        lblKode.TextAlign = HorizontalAlignment.Left
        lblKode.TrailingIcon = Nothing
        lblKode.UseSystemPasswordChar = False
        ' 
        ' lblTgl
        ' 
        lblTgl.AutoSize = True
        lblTgl.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTgl.Location = New Point(1301, 141)
        lblTgl.Name = "lblTgl"
        lblTgl.Size = New Size(145, 21)
        lblTgl.TabIndex = 4
        lblTgl.Text = "Tanggal Transaksi"
        ' 
        ' dtTanggal
        ' 
        dtTanggal.CalendarMonthBackground = SystemColors.InactiveCaption
        dtTanggal.CustomFormat = "dddd, dd mmmm yyyy"
        dtTanggal.DropDownAlign = LeftRightAlignment.Right
        dtTanggal.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        dtTanggal.Format = DateTimePickerFormat.Short
        dtTanggal.Location = New Point(1301, 175)
        dtTanggal.Name = "dtTanggal"
        dtTanggal.RightToLeft = RightToLeft.Yes
        dtTanggal.ShowUpDown = True
        dtTanggal.Size = New Size(234, 33)
        dtTanggal.TabIndex = 3
        dtTanggal.UseWaitCursor = True
        dtTanggal.Value = New Date(2026, 6, 21, 13, 32, 57, 0)
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(37, 45)
        Label1.Name = "Label1"
        Label1.Size = New Size(313, 45)
        Label1.TabIndex = 3
        Label1.Text = "DATA TRANKSAKSI"
        ' 
        ' dgvTransaksi
        ' 
        dgvTransaksi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvTransaksi.BackgroundColor = SystemColors.ActiveCaption
        dgvTransaksi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvTransaksi.Location = New Point(422, 281)
        dgvTransaksi.MultiSelect = False
        dgvTransaksi.Name = "dgvTransaksi"
        dgvTransaksi.ReadOnly = True
        dgvTransaksi.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvTransaksi.Size = New Size(1113, 428)
        dgvTransaksi.TabIndex = 6
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(lblTotalPendapatan)
        GroupBox3.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox3.Location = New Point(422, 45)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(862, 163)
        GroupBox3.TabIndex = 8
        GroupBox3.TabStop = False
        GroupBox3.Text = "Total Penedapatan"
        ' 
        ' lblTotalPendapatan
        ' 
        lblTotalPendapatan.AutoSize = True
        lblTotalPendapatan.Font = New Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTotalPendapatan.Location = New Point(61, 57)
        lblTotalPendapatan.Name = "lblTotalPendapatan"
        lblTotalPendapatan.Size = New Size(289, 86)
        lblTotalPendapatan.TabIndex = 0
        lblTotalPendapatan.Text = "XXXXXX"
        ' 
        ' btnCetak
        ' 
        btnCetak.Depth = 0
        btnCetak.Icon = CType(resources.GetObject("btnCetak.Icon"), Image)
        btnCetak.Location = New Point(446, 730)
        btnCetak.MouseState = MaterialSkin.MouseState.HOVER
        btnCetak.Name = "btnCetak"
        btnCetak.Size = New Size(56, 56)
        btnCetak.TabIndex = 9
        btnCetak.Text = "MaterialFloatingActionButton1"
        btnCetak.UseVisualStyleBackColor = True
        ' 
        ' PrintDocument1
        ' 
        ' 
        ' PrintPreviewDialog1
        ' 
        PrintPreviewDialog1.AutoScrollMargin = New Size(0, 0)
        PrintPreviewDialog1.AutoScrollMinSize = New Size(0, 0)
        PrintPreviewDialog1.ClientSize = New Size(400, 300)
        PrintPreviewDialog1.Enabled = True
        PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), Icon)
        PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        PrintPreviewDialog1.Visible = False
        ' 
        ' tranksaksi
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.GradientActiveCaption
        ClientSize = New Size(1660, 837)
        Controls.Add(btnCetak)
        Controls.Add(GroupBox3)
        Controls.Add(lblTgl)
        Controls.Add(dtTanggal)
        Controls.Add(GroupBox1)
        Controls.Add(Label1)
        Controls.Add(dgvTransaksi)
        Controls.Add(lblKode)
        Controls.Add(txtCari)
        Name = "tranksaksi"
        StartPosition = FormStartPosition.Manual
        Text = "tranksaksi"
        GroupBox1.ResumeLayout(False)
        CType(dgvTransaksi, ComponentModel.ISupportInitialize).EndInit()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblTgl As Label
    Friend WithEvents dtTanggal As DateTimePicker
    Friend WithEvents btnSimpan As MaterialSkin.Controls.MaterialButton
    Friend WithEvents cbPelanggan As MaterialSkin.Controls.MaterialComboBox
    Friend WithEvents txtCari As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents lblKode As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvTransaksi As DataGridView
    Friend WithEvents btnReset As MaterialSkin.Controls.MaterialButton
    Friend WithEvents txtTotal As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents cbStatus As MaterialSkin.Controls.MaterialComboBox
    Friend WithEvents txtHarga As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents lblTotalPendapatan As Label
    Friend WithEvents btnCetak As MaterialSkin.Controls.MaterialFloatingActionButton
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents cbPaket As MaterialSkin.Controls.MaterialComboBox
    Friend WithEvents cbKecepatan As MaterialSkin.Controls.MaterialComboBox
End Class
