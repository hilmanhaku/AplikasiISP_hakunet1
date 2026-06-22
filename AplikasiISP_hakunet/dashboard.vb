Imports MySql.Data.MySqlClient

Public Class dashboard
    Private Sub dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Tampilpaket()

        TotalPelanggan()

        TotalTransaksi()

        TotalPendapatan()

    End Sub
    Sub TotalPelanggan()

        Try

            Call Konek()

            cmd = New MySqlCommand(
            "SELECT COUNT(*)
             FROM tb_pelanggan",
            Koneksi
        )

            Dim total As Integer

            total = Convert.ToInt32(
            cmd.ExecuteScalar()
        )

            lblTotalPelanggan.Text =
            total.ToString()

            Call Diskonek()

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try
    End Sub

    Sub TotalTransaksi()

        Try

            Call Konek()

            cmd = New MySqlCommand(
                "SELECT COUNT(*)
             FROM transaksi",
                Koneksi
            )

            Dim total As Integer

            total = Convert.ToInt32(
                cmd.ExecuteScalar()
            )

            lblTotalTransaksi.Text =
                total.ToString()

            Call Diskonek()

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

    End Sub

    Sub TotalPendapatan()

        Try

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
                    "Rp 0"

            Else

                lblTotalPendapatan.Text =
                    "Rp " &
                    Format(
                        total,
                        "N0"
                    )

            End If

            Call Diskonek()

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub dgvPaket_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPaket.CellContentClick

    End Sub

    Sub Tampilpaket()

        Call Konek()

        da = New MySqlDataAdapter(
            "SELECT * FROM tb_paket",
            Koneksi
        )

        dt = New DataTable

        da.Fill(dt)

        dgvPaket.DataSource = dt

        Call Diskonek()

    End Sub

End Class