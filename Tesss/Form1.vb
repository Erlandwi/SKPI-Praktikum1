Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btjumlah.Click
        Dim angka1, angka2, hasil As Double
        angka1 = Val(Txtangka1.Text)
        angka2 = Val(Txtangka2.Text)
        hasil = angka1 + angka2
        Txthasil.Text = hasil
    End Sub

    Private Sub btkurang_Click(sender As Object, e As EventArgs) Handles btkurang.Click
        Dim angka1, angka2, hasil As Double
        angka1 = Val(Txtangka1.Text)
        angka2 = Val(Txtangka2.Text)
        hasil = angka1 - angka2
        Txthasil.Text = hasil
    End Sub

    Private Sub btbagi_Click(sender As Object, e As EventArgs) Handles btbagi.Click
        Dim angka1, angka2, hasil As Double
        angka1 = Val(Txtangka1.Text)
        angka2 = Val(Txtangka2.Text)
        hasil = angka1 / angka2
        Txthasil.Text = hasil
    End Sub

    Private Sub btkali_Click(sender As Object, e As EventArgs) Handles btkali.Click
        Dim angka1, angka2, hasil As Double
        angka1 = Val(Txtangka1.Text)
        angka2 = Val(Txtangka2.Text)
        hasil = angka1 * angka2
        Txthasil.Text = hasil
    End Sub
End Class
