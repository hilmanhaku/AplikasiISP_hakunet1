Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle.Asn1

Public Class tranksaksi

    Dim idTransaksi As String
    Dim kode As String
    Dim tanggal As String
    Dim pelanggan As String
    Dim userLogin As String
    Dim paket As String
    Dim speed As String
    Dim harga As String
    Dim total As String
    Dim status As String

    Private Sub lblTgl_Click(sender As Object, e As EventArgs) Handles lblTgl.Click
        ' Biarkan kosong saja dulu
    End Sub
    Sub TampilData()
        Try
            Call Konek()

            Dim query As String =
            "SELECT " &
            "   transaksi.id_transaksi, " &
            "   transaksi.kode_transaksi, " &
            "   transaksi.tanggal, " &
            "   tb_pelanggan.nama, " &
            "   tbl_user.nama_lengkap, " &
            "   tb_paket.nama_paket, " &
            "   tb_paket.`kecepatan / Mbps`, " &
            "   transaksi.harga, " &
            "   transaksi.total_bayar, " &
            "   transaksi.status " &
            "FROM transaksi " &
            "JOIN tb_pelanggan ON transaksi.id_pelanggan = tb_pelanggan.id_pelanggan " &
            "JOIN tbl_user ON transaksi.id_user = tbl_user.id_user " &
            "JOIN tb_paket ON transaksi.id_paket = tb_paket.id_paket " &
            "ORDER BY transaksi.id_transaksi DESC"

            da = New MySqlDataAdapter(query, Koneksi)
            dt = New DataTable
            da.Fill(dt)
            dgvTransaksi.DataSource = dt

            ' Mengatur Header DataGridView (Total 10 Kolom, Index 0-9)
            dgvTransaksi.Columns(0).Visible = False ' ID Transaksi disembunyikan

            dgvTransaksi.Columns(1).HeaderText = "Kode Transaksi"
            dgvTransaksi.Columns(2).HeaderText = "Tanggal"
            dgvTransaksi.Columns(3).HeaderText = "Pelanggan"
            dgvTransaksi.Columns(4).HeaderText = "User"
            dgvTransaksi.Columns(5).HeaderText = "Paket"
            dgvTransaksi.Columns(6).HeaderText = "Speed (Mbps)"
            dgvTransaksi.Columns(7).HeaderText = "Harga"
            dgvTransaksi.Columns(8).HeaderText = "Total Bayar"
            dgvTransaksi.Columns(9).HeaderText = "Status"

            ' Format angka menjadi nominal Rupiah (N0)
            dgvTransaksi.Columns(7).DefaultCellStyle.Format = "N0"
            dgvTransaksi.Columns(8).DefaultCellStyle.Format = "N0"

            Call Diskonek()
        Catch ex As Exception
            MsgBox("Error Tampil Data: " & ex.Message)
        End Try
    End Sub

    Sub ResetForm()

        txtCari.Clear()
        txtHarga.Clear()
        txtTotal.Clear()

        cbPelanggan.SelectedIndex = -1
        cbStatus.SelectedIndex = -1

        txtCari.Focus()

    End Sub

    Sub TampilPelanggan()

        Call Konek()

        Dim query As String =
        "SELECT * FROM tb_pelanggan"

        cmd = New MySqlCommand(
        query,
        Koneksi
    )

        dr = cmd.ExecuteReader()

        cbPelanggan.Items.Clear()

        While dr.Read()

            cbPelanggan.Items.Add(
            dr("nama")
        )

        End While

        dr.Close()

        Call Diskonek()

    End Sub


    Sub StatusLaundry()

        cbStatus.Items.Add("Aktif")
        cbStatus.Items.Add("Masa Tenggang")

    End Sub

    Sub GenerateKode()

        Call Konek()

        cmd = New MySqlCommand(
        "SELECT * FROM transaksi 
         ORDER BY id_transaksi DESC",
        Koneksi
    )

        dr = cmd.ExecuteReader()

        If dr.Read() Then

            Dim nomor As Integer

            nomor =
            Val(Microsoft.VisualBasic.Right(
            dr.Item("kode_transaksi").ToString,
            3
        )) + 1

            lblKode.Text =
            "TRX" &
            Format(nomor, "000")

        Else

            lblKode.Text = "TRX001"

        End If

        dr.Close()

        Call Diskonek()

    End Sub






    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click

        Try

            Call Konek()

            Dim idPelanggan As String = ""

            cmd = New MySqlCommand(
            "SELECT id_pelanggan 
             FROM tb_pelanggan
             WHERE nama=@nama",
            Koneksi
        )

            cmd.Parameters.AddWithValue(
            "@nama",
            cbPelanggan.Text
        )

            dr = cmd.ExecuteReader()

            If dr.Read() Then

                idPelanggan =
                dr("id_pelanggan")

            End If
            dr.Close()

            Dim idPaket As String = ""
            cmd = New MySqlCommand("SELECT id_paket FROM tb_paket WHERE nama_paket=@namaPaket", Koneksi)
            cmd.Parameters.AddWithValue("@namaPaket", cbPaket.Text)
            dr = cmd.ExecuteReader()
            If dr.Read() Then
                idPaket = dr("id_paket").ToString()
            End If
            dr.Close()



            Dim query As String =
            "INSERT INTO transaksi
            (
                kode_transaksi,
                tanggal,
                id_pelanggan,
                id_user,
                id_paket,
                harga,
                total_bayar,
                status
            )
            VALUES
            (
                @kode,
                @tanggal,
                @pelanggan,
                @user,
                @speed,
                @harga,
                @total,
                @status
            )"

            cmd = New MySqlCommand(
            query,
            Koneksi
        )

            cmd.Parameters.AddWithValue(
            "@kode",
            lblKode.Text
        )

            cmd.Parameters.AddWithValue(
            "@tanggal",
            dtTanggal.Value
        )

            cmd.Parameters.AddWithValue(
            "@pelanggan",
            idPelanggan
        )

            cmd.Parameters.AddWithValue(
            "@user",
            SessionIDUser
        )

            cmd.Parameters.AddWithValue(
            "@speed",
            idPaket
        )

            cmd.Parameters.AddWithValue(
            "@harga",
            txtHarga.Text
        )

            cmd.Parameters.AddWithValue(
            "@total",
            txtTotal.Text
        )

            cmd.Parameters.AddWithValue(
            "@status",
            cbStatus.Text
        )

            cmd.ExecuteNonQuery()

            MsgBox(
            "Transaksi Berhasil Disimpan"
        )

            TampilData()

            ResetForm()

            GenerateKode()

            Call Diskonek()

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

    End Sub


    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

        ResetForm()

    End Sub

    Private Sub tranksaksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TampilPaket()

        TampilKecepatan()

        TampilData()

        TampilPelanggan()

        StatusLaundry()

        GenerateKode()

        TotalPendapatan()

    End Sub


    Private Sub txtSpeed_TextChanged(
    sender As Object,
    e As EventArgs
) Handles txtHarga.TextChanged

        If cbKecepatan.Text <> "" And
           txtHarga.Text <> "" Then

            Dim speed As Double
            Dim harga As Double

            speed = Val(cbKecepatan.Text)
            harga = Val(txtHarga.Text)

            txtTotal.Text =
                speed * harga
        End If

    End Sub


    Sub TampilPaket()
        Try
            Call Konek()
            Dim query As String = "SELECT * FROM tb_paket"
            cmd = New MySqlCommand(query, Koneksi)
            dr = cmd.ExecuteReader()

            cbPaket.Items.Clear()
            While dr.Read()
                cbPaket.Items.Add(dr("nama_paket").ToString()) ' <--- Menampilkan Nama Paket
            End While

            dr.Close()
            Call Diskonek()
        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan: " & ex.Message)
        End Try
    End Sub

    Sub TampilKecepatan()
        Try
            Call Konek()
            Dim query As String = "SELECT * FROM tb_paket"
            cmd = New MySqlCommand(query, Koneksi)
            dr = cmd.ExecuteReader()

            cbKecepatan.Items.Clear()
            While dr.Read()
                cbKecepatan.Items.Add(dr("kecepatan / Mbps").ToString()) ' <--- Menampilkan Nama Paket
            End While

            dr.Close()
            Call Diskonek()
        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan: " & ex.Message)
        End Try
    End Sub

    Private Sub txtHarga_Click(sender As Object, e As EventArgs) Handles txtHarga.Click

    End Sub

    Private Sub cbStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbStatus.SelectedIndexChanged

    End Sub
    Sub TotalPendapatan()

        Call Konek()

        cmd = New MySqlCommand(
            "SELECT SUM(total_bayar)
         FROM transaksi",
            Koneksi
        )

        Dim total As Object

        total = cmd.ExecuteScalar()

        If IsDBNull(total) Then

            lblTotalPendapatan.Text =
                "0"

        Else

            lblTotalPendapatan.Text =
                Format(total, "N0")

        End If

        Call Diskonek()

    End Sub

    Private Sub txtSpeed_Click(sender As Object, e As EventArgs) Handles txtCari.Click

    End Sub

    Private Sub txtCari_DockChanged(sender As Object, e As EventArgs) Handles txtCari.DockChanged

    End Sub

    Private Sub dgvTransaksi_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTransaksi.CellClick

        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvTransaksi.Rows(e.RowIndex)

            ' Urutan ini sudah disesuaikan dengan Query SELECT di atas
            idTransaksi = row.Cells(0).Value.ToString()
            kode = row.Cells(1).Value.ToString()
            tanggal = row.Cells(2).Value.ToString()
            pelanggan = row.Cells(3).Value.ToString()
            userLogin = row.Cells(4).Value.ToString()
            paket = row.Cells(5).Value.ToString()
            speed = row.Cells(6).Value.ToString()
            harga = row.Cells(7).Value.ToString()
            total = row.Cells(8).Value.ToString()
            status = row.Cells(9).Value.ToString()


        End If

    End Sub

    Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click
        PrintPreviewDialog1.Document =
      PrintDocument1

        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage

        Dim fontJudul As New Font(
       "Poppins",
       16,
       FontStyle.Bold
   )

        Dim fontIsi As New Font(
            "Consolas",
            11
        )

        Dim y As Integer = 40

        ' =========================
        ' LOAD LOGO RESOURCE
        ' =========================

        Dim logo As Image =
            My.Resources.Desain_tanpa_judul__3_

        ' =========================
        ' TAMPILKAN LOGO
        ' =========================

        e.Graphics.DrawImage(
            logo,
            20,
            20,
            60,
            60
        )

        ' =========================
        ' JUDUL
        ' =========================

        e.Graphics.DrawString(
            "HAKU.NET",
            fontJudul,
            Brushes.Black,
            95,
            y
        )

        y += 35

        e.Graphics.DrawString(
            "Internet Cepat & stabil",
            fontIsi,
            Brushes.Black,
            95,
            y
        )

        y += 40

        e.Graphics.DrawString(
            "================================",
            fontIsi,
            Brushes.Black,
            20,
            y
        )

        y += 30

        e.Graphics.DrawString(
            "Kode       : " & kode,
            fontIsi,
            Brushes.Black,
            20,
            y
        )

        y += 25

        e.Graphics.DrawString(
            "Tanggal    : " & tanggal,
            fontIsi,
            Brushes.Black,
            20,
            y
        )

        y += 25

        e.Graphics.DrawString(
            "Pelanggan  : " & pelanggan,
            fontIsi,
            Brushes.Black,
            20,
            y
        )

        y += 25

        e.Graphics.DrawString(
            "Kasir      : " & userLogin,
            fontIsi,
            Brushes.Black,
            20,
            y
        )

        y += 35

        e.Graphics.DrawString(
    "Paket      : " & paket,
    fontIsi, Brushes.Black, 20, y
)
        y += 25

        e.Graphics.DrawString(
            "--------------------------------",
            fontIsi,
            Brushes.Black,
            20,
            y
        )

        y += 30

        e.Graphics.DrawString(
            "Speed          : " &
            speed & " Mbps",
            fontIsi,
            Brushes.Black,
            20,
            y
        )

        y += 25

        e.Graphics.DrawString(
            "Harga / Mbps     : " &
            harga,
            fontIsi,
            Brushes.Black,
            20,
            y
        )

        y += 25

        e.Graphics.DrawString(
            "Total Bayar    : " &
            Format(
                Val(total),
                "N0"
            ),
            fontIsi,
            Brushes.Black,
            20,
            y
        )

        y += 25

        e.Graphics.DrawString(
            "Status         : " &
            status,
            fontIsi,
            Brushes.Black,
            20,
            y
        )

        y += 35

        e.Graphics.DrawString(
            "--------------------------------",
            fontIsi,
            Brushes.Black,
            20,
            y
        )

        y += 35

        e.Graphics.DrawString(
            "Terima Kasih",
            fontIsi,
            Brushes.Black,
            80,
            y
        )

    End Sub

    Private Sub dgvTransaksi_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTransaksi.CellContentClick

    End Sub

    Private Sub txtCari_TextChanged(sender As Object, e As EventArgs) Handles txtCari.TextChanged

        Try
            Call Konek()

            Dim query As String =
        "SELECT " &
        "   transaksi.id_transaksi, " &
        "   transaksi.kode_transaksi, " &
        "   transaksi.tanggal, " &
        "   tb_pelanggan.nama, " &
        "   tbl_user.nama_lengkap, " &
        "   tb_paket.nama_paket, " &
        "   tb_paket.`kecepatan / Mbps`, " &
        "   transaksi.harga, " &
        "   transaksi.total_bayar, " &
        "   transaksi.status " &
        "FROM transaksi " &
        "JOIN tb_pelanggan ON transaksi.id_pelanggan = tb_pelanggan.id_pelanggan " &
        "JOIN tbl_user ON transaksi.id_user = tbl_user.id_user " &
        "JOIN tb_paket ON transaksi.id_paket = tb_paket.id_paket " &
        "WHERE tb_pelanggan.nama LIKE @cari " &
        "ORDER BY transaksi.id_transaksi DESC"

            cmd = New MySqlCommand(query, Koneksi)
            cmd.Parameters.AddWithValue("@cari", "%" & txtCari.Text & "%")

            da = New MySqlDataAdapter(cmd)
            dt = New DataTable
            da.Fill(dt)
            dgvTransaksi.DataSource = dt

            If dgvTransaksi.Columns.Count > 0 Then
                dgvTransaksi.Columns(0).Visible = False

                dgvTransaksi.Columns(1).HeaderText = "Kode Transaksi"
                dgvTransaksi.Columns(2).HeaderText = "Tanggal"
                dgvTransaksi.Columns(3).HeaderText = "Pelanggan"
                dgvTransaksi.Columns(4).HeaderText = "User"
                dgvTransaksi.Columns(5).HeaderText = "Paket"
                dgvTransaksi.Columns(6).HeaderText = "Speed (Mbps)"
                dgvTransaksi.Columns(7).HeaderText = "Harga"
                dgvTransaksi.Columns(8).HeaderText = "Total Bayar"
                dgvTransaksi.Columns(9).HeaderText = "Status"

                dgvTransaksi.Columns(7).DefaultCellStyle.Format = "N0"
                dgvTransaksi.Columns(8).DefaultCellStyle.Format = "N0"
                dgvTransaksi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            End If

            Call Diskonek()
        Catch ex As Exception
            MsgBox("Error Pencarian: " & ex.Message)
        End Try

    End Sub
End Class