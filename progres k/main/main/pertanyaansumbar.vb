Public Class pertanyaansumbar
    Sub pertsumbar(ByVal a As Integer)
        If a = 0 Then
            persumbar.Label1.Text = "	Hewan khas dari provinsi Sumatra Barat adalah ?"
            persumbar.RadioButton1.Text = "a.	Kuau Raja"
            persumbar.RadioButton2.Text = "b.	Harimau Sumatra"
            persumbar.RadioButton3.Text = "c.	Gajah Sumatra"
            persumbar.RadioButton4.Text = "d.	Beruang Madu"
        ElseIf a = 1 Then
            persumbar.Label1.Text = "	Rumah adat dari provinsi Sumatra Barat adalah ?"
            persumbar.RadioButton1.Text = "a.	Rumah Panggung "
            persumbar.RadioButton2.Text = "b.	Rumah Gadang"
            persumbar.RadioButton3.Text = "c.	Rumah Limas"
            persumbar.RadioButton4.Text = "d.	Rumah Nuwo Sesat"
        ElseIf a = 2 Then
            persumbar.Label1.Text = "	Gunung Tertinggi di Provinsi Sumatra Barat adalah?"
            persumbar.RadioButton1.Text = "a.	Gunung Talang"
            persumbar.RadioButton2.Text = "b.	Dewi Sartika"
            persumbar.RadioButton3.Text = "c.	Gungung Marapai"
            persumbar.RadioButton4.Text = "d.	Gunung Kerinci"
        Else
            persumbar.Label1.Text = "	Bandar Udara yang terdapat di Provinsi Sumatra Barat adalah?"
            persumbar.RadioButton1.Text = "a.	Bandar Udara Sultan Iskandar Muda"
            persumbar.RadioButton2.Text = "b.	Bandar Udara Polonia"
            persumbar.RadioButton3.Text = "c.	Bandar Udara Tabing"
            persumbar.RadioButton4.Text = "d.	Bandar Udara Sultan Syarif Kasim II"
        End If
    End Sub
End Class
