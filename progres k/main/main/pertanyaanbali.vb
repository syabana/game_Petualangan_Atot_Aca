Public Class pertanyaanbali
    Sub pertbali(ByVal a As Integer)
        If a = 0 Then
            perbali.Label1.Text = "	Ibu kota Bali adalah"
            perbali.RadioButton1.Text = "a.	Denpasar"
            perbali.RadioButton2.Text = "b.	Bangli"
            perbali.RadioButton3.Text = "c.	Gilimanuk"
            perbali.RadioButton4.Text = "d.	Gianyar"
        ElseIf a = 1 Then
            perbali.Label1.Text = "	Makanan khas daerah Bali yaitu"
            perbali.RadioButton1.Text = "a.	Ayam Betutu "
            perbali.RadioButton2.Text = "b.	Angeun Lada"
            perbali.RadioButton3.Text = "c.	Ayam Kalasan"
            perbali.RadioButton4.Text = "d.	Ayam Kaliwang"
        ElseIf a = 2 Then
            perbali.Label1.Text = "	Nama rumah adat daerah Bali adalah"
            perbali.RadioButton1.Text = "a.	Rumah Mbaru Niang"
            perbali.RadioButton2.Text = "b.	Rumah Kebaya"
            perbali.RadioButton3.Text = "c.	Rumah Gapura Candi Bentar"
            perbali.RadioButton4.Text = "d.	Rumah Rakyat"
        Else
            perbali.Label1.Text = "	Tarian khas Bali adalah"
            perbali.RadioButton1.Text = "a.	Tari Kecak"
            perbali.RadioButton2.Text = "b.	Tari Batunganga"
            perbali.RadioButton3.Text = "c.	Tari Mpaa Lenggogo"
            perbali.RadioButton4.Text = "d.	Tari Gareng Lameng"
        End If
    End Sub
End Class
