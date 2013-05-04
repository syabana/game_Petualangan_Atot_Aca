Public Class perjakarta
    Public intRandomNumber As Integer = 0
    Private n As New nilai
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        PictureBox1.Image = Nothing
        Dim pert1 As New pertanyaan
        Dim objRandom As New Random
        Label1.Text = " "
        intRandomNumber = objRandom.Next(4)
        pert1.pertjakarta(intRandomNumber)
        If n.benar = 9 Then
            Me.Hide()
            jakarta3.Show()
        End If
    End Sub

    Private Sub perjakarta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label4.Text = n.scor
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If intRandomNumber = 0 Then
            If RadioButton1.Checked = True Then
                n.nila(10)
                n.ben(1)
                Label3.Text = n.nil
                PictureBox1.Image = My.Resources.senang
                MessageBox.Show("Benar")
            Else
                n.score(1)
                Label4.Text = n.scor
                PictureBox1.Image = My.Resources.sedih
                MessageBox.Show("Salah")
            End If
        End If
        If intRandomNumber = 1 Then
            If RadioButton4.Checked = True Then
                n.nila(10)
                n.ben(1)
                Label3.Text = n.nil
                PictureBox1.Image = My.Resources.senang
                MessageBox.Show("Benar")
            Else
                n.score(1)
                Label4.Text = n.scor
                PictureBox1.Image = My.Resources.sedih
                MessageBox.Show("Salah")
            End If
        End If
        If intRandomNumber = 2 Then
            If RadioButton1.Checked = True Then
                n.nila(10)
                n.ben(1)
                Label3.Text = n.nil
                PictureBox1.Image = My.Resources.senang
                MessageBox.Show("Benar")
            Else
                n.score(1)
                Label4.Text = n.scor
                PictureBox1.Image = My.Resources.sedih
                MessageBox.Show("Salah")
            End If
        End If
        If intRandomNumber > 2 Then
            If RadioButton3.Checked = True Then
                n.nila(10)
                n.ben(1)
                Label3.Text = n.nil
                PictureBox1.Image = My.Resources.senang
                MessageBox.Show("Benar")
            Else
                n.score(1)
                Label4.Text = n.scor
                PictureBox1.Image = My.Resources.sedih
                MessageBox.Show("Salah")
            End If
        End If
    End Sub
End Class