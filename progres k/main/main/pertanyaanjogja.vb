Public Class pertanyaanjogja
    Sub pertjogja(ByVal a As Integer)
        If a = 0 Then
            perjogja.Label1.Text = "	Nama bandara terkenal di Yogyakarta adalah"
            perjogja.RadioButton1.Text = "a.	Adi Sunarno"
            perjogja.RadioButton2.Text = "b.	Ahmad Yani"
            perjogja.RadioButton3.Text = "c.	Adi Sucipto"
            perjogja.RadioButton4.Text = "d.	Iswahyudi"
        ElseIf a = 1 Then
            perjogja.Label1.Text = "	Rumah khas daerah Yogyakarta disebut"
            perjogja.RadioButton1.Text = "a.	Rumah Joglo"
            perjogja.RadioButton2.Text = "b.	Rumah Kebaya"
            perjogja.RadioButton3.Text = "c.	Rumah Kasepuhan Yogyakarta"
            perjogja.RadioButton4.Text = "d.	Rumah Rakyat"
        ElseIf a = 2 Then
            perjogja.Label1.Text = "	Tarian yang berasal dari Yogyakarta adalah"
            perjogja.RadioButton1.Text = "a.	Tari Topeng"
            perjogja.RadioButton2.Text = "b.	Tari Serimpi Sangupati"
            perjogja.RadioButton3.Text = "c.	Tari Merak"
            perjogja.RadioButton4.Text = "d.	Tari Jaipong"
        Else
            perjogja.Label1.Text = "	Salah satu objek wisata di Yogyakarta yaitu"
            perjogja.RadioButton1.Text = "a.	Monumen Pancasila Sakti"
            perjogja.RadioButton2.Text = "b.	Monumen Pangeran Diponegoro"
            perjogja.RadioButton3.Text = "c.	Tanjung Lesung"
            perjogja.RadioButton4.Text = "d.	Pantai Carita"
        End If
    End Sub
End Class
