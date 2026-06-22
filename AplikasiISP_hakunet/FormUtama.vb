Public Class FormUtama
    Private Sub FormUtama_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadForm(dashboard)
        txtUserLogin.Text = "Welcome, " & SessionUsername
    End Sub
    'dinaicform
    Public Sub LoadForm(ByVal form As Form)

        PanelContainer.Controls.Clear()

        form.TopLevel = False

        form.FormBorderStyle =
            FormBorderStyle.None

        form.Dock = DockStyle.Fill

        PanelContainer.Controls.Add(form)

        form.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnPelanggan.Click
        LoadForm(pelanggan)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnTranksaksi.Click
        LoadForm(tranksaksi)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        LoadForm(dashboard)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick


        Try
            dashboard.TotalPelanggan()
            dashboard.TotalTransaksi()
            dashboard.TotalPendapatan()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click

        Dim konfirmasi As DialogResult = MsgBox("Apakah Anda yakin ingin keluar dari sistem?", MsgBoxStyle.YesNo Or MsgBoxStyle.Question, "Konfirmasi Logout")


        If konfirmasi = DialogResult.Yes Then


            SessionIDUser = ""

            Form1.Show()

            Me.Close()

        End If
    End Sub

    Private Sub txtUserLogin_Click(sender As Object, e As EventArgs) Handles txtUserLogin.Click
        Dim konfirmasi As DialogResult = MsgBox("Apakah Anda yakin ingin keluar dari sistem?", MsgBoxStyle.YesNo Or MsgBoxStyle.Question, "Konfirmasi Logout")


        If konfirmasi = DialogResult.Yes Then


            SessionIDUser = ""

            Form1.Show()

            Me.Close()

        End If
    End Sub
End Class