Public Class pertanyaanaceh
    Sub pertaceh(ByVal a As Integer)
        If a = 0 Then
            peraceh.Label1.Text = "	Lagu daerah yang berasal dari provinsi Aceh adalah?"
            peraceh.RadioButton1.Text = "a.	Bugong Jeumpa"
            peraceh.RadioButton2.Text = "b.	Yamko Rambe Yamko"
            peraceh.RadioButton3.Text = "c.	Butet"
            peraceh.RadioButton4.Text = "d.	Gelang sipaku gelang"
        ElseIf a = 1 Then
            peraceh.Label1.Text = "	Makanan khas dari daerah provinsi aceh adalah?"
            peraceh.RadioButton1.Text = "a.	Rendang "
            peraceh.RadioButton2.Text = "b.	Kari kambing"
            peraceh.RadioButton3.Text = "c.	Lemang"
            peraceh.RadioButton4.Text = "d.	Dendeng"
        ElseIf a = 2 Then
            peraceh.Label1.Text = "	Pahlawan Perempuan yang berasal dari daerah Aceh adalah?"
            peraceh.RadioButton1.Text = "a.	R.A. Kartini"
            peraceh.RadioButton2.Text = "b.	Dewi Sartika"
            peraceh.RadioButton3.Text = "c.	Nyi Ageng Serang"
            peraceh.RadioButton4.Text = "d.	Cut Nyak Dien"
        Else
            peraceh.Label1.Text = "	Kerajaan Islam pertama yang berdiri di Indonesia yang terletak di Provinsi Aceh adalah?"
            peraceh.RadioButton1.Text = "a.	Kesultanan Demak"
            peraceh.RadioButton2.Text = "b.	Kerjaan Samudra Pasai"
            peraceh.RadioButton3.Text = "c.	Kesultanan Gowa"
            peraceh.RadioButton4.Text = "d.	Kesultanan Cirebon"
        End If

    End Sub
End Class
