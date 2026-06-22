Imports MySql.Data.MySqlClient

Public Class pelanggan
    Sub TampilData()

        Call Konek()

        da = New MySqlDataAdapter(
            "SELECT * FROM tb_pelanggan",
            Koneksi
        )

        dt = New DataTable

        da.Fill(dt)

        dgvPelanggan.DataSource = dt

        Call Diskonek()

    End Sub

    Sub ResetForm()

        txtNama.Clear()
        txtHP.Clear()
        txtAlamat.Clear()
        dtTgl.Value = DateTime.Now

        cmbJenis.SelectedIndex = -1
        cmbStatus.SelectedIndex = -1

        txtNama.Focus()

    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Try

            Call Konek()

            Dim query As String =
                "INSERT INTO tb_pelanggan (nama, alamat, no_hp, id_paket, tanggal_daftar, status) " &
                               "VALUES (@nama,@alamat,@hp,@paket,@tgl,@status)"

            cmd = New MySqlCommand(
                query,
                Koneksi
            )

            cmd.Parameters.AddWithValue("@nama", txtNama.Text)
            cmd.Parameters.AddWithValue("@alamat", txtAlamat.Text)
            cmd.Parameters.AddWithValue("@hp", txtHP.Text)
            cmd.Parameters.AddWithValue("@paket", cmbJenis.Text)
            cmd.Parameters.AddWithValue("@tgl", dtTgl.Value)
            cmd.Parameters.AddWithValue("@status", cmbStatus.Text)

            ' Execute the insert
            cmd.ExecuteNonQuery()

            MessageBox.Show("Data berhasil disimpan.")

            ' Refresh data grid and reset form
            Call TampilData()
            Call ResetForm()

        Catch ex As Exception
            MessageBox.Show("Gagal menyimpan data: " & ex.Message)
        Finally
            Call Diskonek()
        End Try
    End Sub


    Private Sub dgvPelanggan_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPelanggan.CellClick
        Dim baris As Integer =
        dgvPelanggan.CurrentRow.Index

        txtNama.Text =
        dgvPelanggan.Rows(baris).
        Cells(1).Value

        txtAlamat.Text =
        dgvPelanggan.Rows(baris).
        Cells(2).Value

        txtHP.Text =
        dgvPelanggan.Rows(baris).
        Cells(3).Value

        cmbJenis.Text =
        dgvPelanggan.Rows(baris).
        Cells(4).Value

        dtTgl.Value =
        dgvPelanggan.Rows(baris).
        Cells(5).Value

        cmbStatus.Text =
        dgvPelanggan.Rows(baris).
        Cells(6).Value

    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        Try

            Call Konek()

            Dim id As String =
                dgvPelanggan.CurrentRow.
                Cells(0).Value

            Dim query As String = "UPDATE tb_pelanggan SET nama=@nama, alamat=@alamat, no_hp=@hp, id_paket=@paket, tanggal_daftar=@tgl, status=@status WHERE id_pelanggan=@id"
            cmd = New MySqlCommand(query, Koneksi)

            cmd.Parameters.AddWithValue("@nama", txtNama.Text)
            cmd.Parameters.AddWithValue("@alamat", txtAlamat.Text)
            cmd.Parameters.AddWithValue("@hp", txtHP.Text)
            cmd.Parameters.AddWithValue("@paket", cmbJenis.Text)
            cmd.Parameters.AddWithValue("@tgl", dtTgl.Value)
            cmd.Parameters.AddWithValue("@status", cmbStatus.Text)
            cmd.Parameters.AddWithValue("@id", id)

            cmd.ExecuteNonQuery()

            MsgBox(
                "Data Berhasil Diubah"
            )

            TampilData()

            ResetForm()

            Call Diskonek()

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Try

            Dim jawab As DialogResult

            jawab = MessageBox.Show(
                "Yakin ingin menghapus data?",
                "Konfirmasi",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            )

            If jawab = DialogResult.Yes Then

                Call Konek()

                Dim id As String =
                    dgvPelanggan.CurrentRow.
                    Cells(0).Value

                Dim query As String =
                    "DELETE FROM tb_pelanggan
                 WHERE id_pelanggan=@id"

                cmd = New MySqlCommand(
                    query,
                    Koneksi
                )

                cmd.Parameters.AddWithValue(
                    "@id",
                    id
                )

                cmd.ExecuteNonQuery()

                MsgBox(
                    "Data Berhasil Dihapus"
                )

                TampilData()

                ResetForm()

                Call Diskonek()

            End If

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ResetForm()
    End Sub

    Private Sub txtCari_TextChanged(sender As Object, e As EventArgs) Handles txtCari.TextChanged
        Call Konek()

        da = New MySqlDataAdapter(
        "SELECT * FROM tb_pelanggan
         WHERE nama
         LIKE '%" &
         txtCari.Text &
         "%'",
        Koneksi
    )

        dt = New DataTable

        da.Fill(dt)

        dgvPelanggan.DataSource = dt

        Call Diskonek()

    End Sub
End Class