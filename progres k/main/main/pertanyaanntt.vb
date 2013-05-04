Public Class pertanyaanntt
    Sub pertntt(ByVal a As Integer)
        If a = 0 Then
            perntt.Label1.Text = "	Tarian daerah berasal dari NTT adalah"
            perntt.RadioButton1.Text = "a.	Tari Perang"
            perntt.RadioButton2.Text = "b.	Tari Sajojo"
            perntt.RadioButton3.Text = "c.	Tari Cakalele"
            perntt.RadioButton4.Text = "d.	Tari Tifa"
        ElseIf a = 1 Then
            perntt.Label1.Text = "	Ibu kota NTT yaitu"
            perntt.RadioButton1.Text = "a.	Flores "
            perntt.RadioButton2.Text = "b.	Kupang"
            perntt.RadioButton3.Text = "c.	Sumba"
            perntt.RadioButton4.Text = "d.	Sumbawa"
        ElseIf a = 2 Then
            perntt.Label1.Text = "	Alat musik tradisional khas NTT yaitu"
            perntt.RadioButton1.Text = "a.	Sasando"
            perntt.RadioButton2.Text = "b.	Serunai"
            perntt.RadioButton3.Text = "c.	Bonang"
            perntt.RadioButton4.Text = "d.	Cengceng"
        Else
            perntt.Label1.Text = "	Nama rumah adat daerah NTT adalah"
            perntt.RadioButton1.Text = "a.	Rumah Musalaki"
            perntt.RadioButton2.Text = "b.	Rumah Betang"
            perntt.RadioButton3.Text = "c.	Rumah Joglo"
            perntt.RadioButton4.Text = "d.	Rumah Banjar Bubungan Tinggi"
        End If
    End Sub
End Class
