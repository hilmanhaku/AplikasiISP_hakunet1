Imports MySql.Data.MySqlClient

Public Class Form1
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtUsername.Text = "" Or txtPassword.Text = "" Then
            MessageBox.Show("username / password wajib diisi...")
        Else
            Dim username, password As String
            username = txtUsername.Text
            password = txtPassword.Text
            Try
                Konek()
                cmd = New MySqlCommand("SELECT * FROM tbl_user WHERE username = '" & username & "' AND password ='" & password & "' ", Koneksi)
                'Dim reader As MySqlDataReader
                dr = cmd.ExecuteReader
                dr.Read()

                If dr.HasRows Then
                    ' Username dan password ditemukan
                    MessageBox.Show("Login Sukses, Akses Telah Diberikan", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    'Buka Form Tujuan

                    SessionIDUser = dr("id_user")
                    SessionUsername = dr("username")
                    SessionLevel = dr("level")

                    Dim MainMenu As New FormUtama
                    MainMenu.Show()
                    Hide()
                Else

                    ' Username dan password tidak ditemukan
                    MessageBox.Show("Login gagal ! Username atau password salah.", "Warning ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
                Diskonek()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub MaterialButton1_Click(sender As Object, e As EventArgs) Handles MaterialButton1.Click

        Dim tutup As DialogResult = MsgBox("Apakah Anda yakin ingin menutup aplikasi HAKU.NET?", MsgBoxStyle.YesNo Or MsgBoxStyle.Question, "Konfirmasi Keluar")


        If tutup = DialogResult.Yes Then

            Application.Exit()

        End If
    End Sub
End Class
