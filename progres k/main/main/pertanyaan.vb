Public Class pertanyaan
    Sub pertjatim(ByVal a As Integer)
        If a = 0 Then
            perjatim.Label1.Text = "	Objek wisata di Jatim salah satunya adalah"
            perjatim.RadioButton1.Text = "a.	Waduk Jati Luhur"
            perjatim.RadioButton2.Text = "b.	Museum Trowulan"
            perjatim.RadioButton3.Text = "c.	Pantai Baron"
            perjatim.RadioButton4.Text = "d.	Goa Kiskendo"
        ElseIf a = 1 Then
            perjatim.Label1.Text = "	Tarian berasal dari Jatim yaitu"
            perjatim.RadioButton1.Text = "a.	Tari Bambangan Cakil"
            perjatim.RadioButton2.Text = "b.	Tari Sintren"
            perjatim.RadioButton3.Text = "c.	Tari Remong"
            perjatim.RadioButton4.Text = "d.	Tari Topeng"
        ElseIf a = 2 Then
            perjatim.Label1.Text = "	Makanan khas daerah Jatim adalah"
            perjatim.RadioButton1.Text = "a.	Oncom"
            perjatim.RadioButton2.Text = "b.	Sate Bandeng"
            perjatim.RadioButton3.Text = "c.	Sayur Asem"
            perjatim.RadioButton4.Text = "d.	Rujak Cingur"
        Else
            perjatim.Label1.Text = "	Salah satu nama bandara di Jatim yaitu"
            perjatim.RadioButton1.Text = "a.	Abdur Rahman Shaleh"
            perjatim.RadioButton2.Text = "b.	Adi Sucipto"
            perjatim.RadioButton3.Text = "c.	Ahmad Yani"
            perjatim.RadioButton4.Text = "d.	Adi Sumarno"
        End If
    End Sub
    Sub pertjakarta(ByVal a As Integer)
        If a = 0 Then
            perjakarta.Label1.Text = "	Nama pelabuhan di Jakarta yaitu"
            perjakarta.RadioButton1.Text = "a.	Tanjung Priok"
            perjakarta.RadioButton2.Text = "b.	Pelabuhan Cirebon"
            perjakarta.RadioButton3.Text = "c.	Tanjung Merak"
            perjakarta.RadioButton4.Text = "d.	Tanjung Mas"
        ElseIf a = 1 Then
            perjakarta.Label1.Text = "	Nama bandara di Jakarta yaitu"
            perjakarta.RadioButton1.Text = "a.	Depati Amir"
            perjakarta.RadioButton2.Text = "b.	Halim Perdanakusumah"
            perjakarta.RadioButton3.Text = "c.	Padang Kemiling"
            perjakarta.RadioButton4.Text = "d.	Soekarno Hatta"
        ElseIf a = 2 Then
            perjakarta.Label1.Text = "	Lagu yang berasal dari Jakarta adalah"
            perjakarta.RadioButton1.Text = "a.	Jali-jali"
            perjakarta.RadioButton2.Text = "b.	Cing Cangkeling"
            perjakarta.RadioButton3.Text = "c.	Tokecang"
            perjakarta.RadioButton4.Text = "d.	Bubuy Bulan"
        Else
            perjakarta.Label1.Text = "	Nama rumah adat daerah di Jakarta adalah"
            perjakarta.RadioButton1.Text = "a.	Rumah Kasepuhan Cirebon"
            perjakarta.RadioButton2.Text = "b.	Rumah Badui"
            perjakarta.RadioButton3.Text = "c.	Rumah Kebaya"
            perjakarta.RadioButton4.Text = "d.	Rumah Rakyat"
        End If
    End Sub
    Sub pertkalimantan(ByVal a As Integer)
        If a = 0 Then
            perkalimantan.Label1.Text = "	Suku yang mendiami provinsi kalimantan tengah adalah?"
            perkalimantan.RadioButton1.Text = "a.	Badui"
            perkalimantan.RadioButton2.Text = "b.	Batak"
            perkalimantan.RadioButton3.Text = "c.	Asmat"
            perkalimantan.RadioButton4.Text = "d.	Dayak"
        ElseIf a = 1 Then
            perkalimantan.Label1.Text = "	Lagu ampar-ampar pisang berasal dari provinsi ?"
            perkalimantan.RadioButton1.Text = "a.	Kalimantan barat"
            perkalimantan.RadioButton2.Text = "b.	Kalimantan selatan"
            perkalimantan.RadioButton3.Text = "c.	Kalimantan timur"
            perkalimantan.RadioButton4.Text = "d.	Kalimantan tengah"
        ElseIf a = 2 Then
            perkalimantan.Label1.Text = "	Hewan endemik yang mendiami provinsi kalimantan tengah adalah?"
            perkalimantan.RadioButton1.Text = "a.	Banteng"
            perkalimantan.RadioButton2.Text = "b.	Orang Utan"
            perkalimantan.RadioButton3.Text = "c.	Macan"
            perkalimantan.RadioButton4.Text = "d.	Komodo"
        Else
            perkalimantan.Label1.Text = "	Sungai yang melewati provinsi Kalimantan Timur adalah?"
            perkalimantan.RadioButton1.Text = "a.	Sungai Mahakam"
            perkalimantan.RadioButton2.Text = "b.	Sungai Kapuas"
            perkalimantan.RadioButton3.Text = "c.	Sungai Musi"
            perkalimantan.RadioButton4.Text = "d.	Sungai Ciliwung"
        End If
    End Sub
    Sub pertsulawesi(ByVal a As Integer)
        If a = 0 Then
            persulawesi.Label1.Text = "	Tongkonan merupakan rumah adat dari daerah ?"
            persulawesi.RadioButton1.Text = "a.	Gowa"
            persulawesi.RadioButton2.Text = "b.	Tana Toraja"
            persulawesi.RadioButton3.Text = "c.	Palopo"
            persulawesi.RadioButton4.Text = "d.	Bone"
        ElseIf a = 1 Then
            persulawesi.Label1.Text = "	Taman laut bunaken terletak di kota?"
            persulawesi.RadioButton1.Text = "a.	Makasar"
            persulawesi.RadioButton2.Text = "b.	Gorontalo"
            persulawesi.RadioButton3.Text = "c.	Manado"
            persulawesi.RadioButton4.Text = "d.	Palu"
        ElseIf a = 2 Then
            persulawesi.Label1.Text = "	Lagu daerah yang berasal dari provinsi sulawesi selatan adalah?"
            persulawesi.RadioButton1.Text = "a.	Soleram"
            persulawesi.RadioButton2.Text = "b.	Injit-injit semut"
            persulawesi.RadioButton3.Text = "c.	O ina ni keke"
            persulawesi.RadioButton4.Text = "d.	Bubui Bulan"
        Else
            persulawesi.Label1.Text = "	Tokoh dari Makasar yang dijuluki Sebagai Ayam Jantan dari Timur adalah?"
            persulawesi.RadioButton1.Text = "a.	Pangeran Antasari"
            persulawesi.RadioButton2.Text = "b.	Sultan Hasanudin"
            persulawesi.RadioButton3.Text = "c.	Kapiten Pattimura"
            persulawesi.RadioButton4.Text = "d.	Tuanku Imam Bonjol"
        End If
    End Sub
    Sub pertpapua(ByVal a As Integer)
        If a = 0 Then
            perpapua.Label1.Text = "	Lagu daerah yang berasal dari papua adalah?"
            perpapua.RadioButton1.Text = "a.	Apuse"
            perpapua.RadioButton2.Text = "b.	Ayo mama"
            perpapua.RadioButton3.Text = "c.	Burung kakak tua"
            perpapua.RadioButton4.Text = "d.	Marencong rencong"
        ElseIf a = 1 Then
            perpapua.Label1.Text = "	Gunung tertinggi di Indonesia yang terdapat di pulau Irian adalah gunung?"
            perpapua.RadioButton1.Text = "a.	Gunung Merapi"
            perpapua.RadioButton2.Text = "b.	Gunung Rinjani"
            perpapua.RadioButton3.Text = "c.	Gunung Jayawijaya"
            perpapua.RadioButton4.Text = "d.	Gunung Krakatau"
        ElseIf a = 2 Then
            perpapua.Label1.Text = "	Honai merupakan rumah adat dari suku?"
            perpapua.RadioButton1.Text = "a.	Asmat"
            perpapua.RadioButton2.Text = "b.	Dani"
            perpapua.RadioButton3.Text = "c.	Kamoro"
            perpapua.RadioButton4.Text = "d.	Mimika"
        Else
            perpapua.Label1.Text = "	Alat musik khas dari daerah papua yang berbentuk seperti gendang disebut?"
            perpapua.RadioButton1.Text = "a.	Triton"
            perpapua.RadioButton2.Text = "b.	Tifa"
            perpapua.RadioButton3.Text = "c.	Sasando"
            perpapua.RadioButton4.Text = "d.	Talempong"
        End If
    End Sub
End Class
