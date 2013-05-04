Public Class perntt

    Public intRandomNumber As Integer = 0
    Private n As New nilai
    Private Sub perntt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label4.Text = n.scor
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If intRandomNumber = 0 Then
            If RadioButton1.Checked = True Then
                n.nila(10)
                n.ben(1)
                Label3.Text = n.nil
                PictureBox2.Image = My.Resources.senang
                MessageBox.Show("Benar")
            Else
                n.score(1)
                Label4.Text = n.scor
                PictureBox2.Image = My.Resources.sedih
                MessageBox.Show("Salah")
            End If
        End If
        If intRandomNumber = 1 Then
            If RadioButton2.Checked = True Then
                n.nila(10)
                n.ben(1)
                Label3.Text = n.nil
                PictureBox2.Image = My.Resources.senang
                MessageBox.Show("Benar")
            Else
                n.score(1)
                Label4.Text = n.scor
                PictureBox2.Image = My.Resources.sedih
                MessageBox.Show("Salah")
            End If
        End If
        If intRandomNumber = 2 Then
            If RadioButton1.Checked = True Then
                n.nila(10)
                n.ben(1)
                Label3.Text = n.nil
                PictureBox2.Image = My.Resources.senang
                MessageBox.Show("Benar")
            Else
                n.score(1)
                Label4.Text = n.scor
                PictureBox2.Image = My.Resources.sedih
                MessageBox.Show("Salah")
            End If
        End If
        If intRandomNumber > 2 Then
            If RadioButton1.Checked = True Then
                n.nila(10)
                n.ben(1)
                Label3.Text = n.nil
                PictureBox2.Image = My.Resources.senang
                MessageBox.Show("Benar")
            Else
                n.score(1)
                Label4.Text = n.scor
                PictureBox2.Image = My.Resources.sedih
                MessageBox.Show("Salah")
            End If
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        PictureBox2.Image = Nothing
        Dim pert1 As New pertanyaanntt
        Dim objRandom As New Random
        Label1.Text = " "
        intRandomNumber = objRandom.Next(4)
        pert1.pertntt(intRandomNumber)
        If n.benar = 27 Then
            Me.Hide()
            ntt.Show()
        End If
    End Sub
End Class