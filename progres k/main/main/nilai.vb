Public Class nilai
    Public nil As Integer = 0
    Public scor As Integer = 3
    Public benar As Integer = 0

    Sub nila(ByVal a As Integer)
        Me.nil += a
    End Sub

    Sub score(ByVal b As Integer)
        Me.scor -= b
        If scor = 0 Then
            MessageBox.Show("Anda Kalah")
            utama.Close()
        End If
    End Sub

    Sub ben(ByVal c As Integer)
        Me.benar += c
    End Sub

End Class
