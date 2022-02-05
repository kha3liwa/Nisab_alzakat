Imports System.Globalization

Public Class Form1


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtNow.Text = Now
    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            Dim xx As Date
            xx = Now

            Dim dt1 As Date
            Dim dt2 As Date
            Dim dt3 As TimeSpan
            Dim diff As Double

            dt1 = xx.Date.ToShortDateString
            dt2 = DateTimePicker2.Value.ToShortDateString
            dt3 = (dt1 - dt2)
            diff = dt3.Days
            xy.Text = Str(Int(diff / 365))

            diff = diff Mod 365
            xm.Text = (Str(Int(diff / 30)))
            diff = diff Mod 30
            xd.Text = (Str(diff))

        Catch ex As Exception
            MsgBox("خطأ في صيغة التاريخ المدخل")
            Exit Sub
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            Dim wazn, alnisab, qerat As Double
            Dim result As Double = 0
            wazn = Convert.ToDouble(txtklalwzin.Text)
            alnisab = Convert.ToDouble(txtSAR.Text)
            qerat = Convert.ToDouble(ComboBox1.SelectedItem)
            result = wazn * qerat / 24
            txtnisabalzkat_klalwzin.Text = result

        Catch ex As Exception
            MsgBox("Error !!! سعر القراط أو الوزن الكلي أو نوع القراط فارغ")
        End Try

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)
        manyYears.Text = xy.Text

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Dim nisab, allnisab As String

            nisab = Convert.ToDouble(txtSAR.Text)
            allnisab = Convert.ToDouble(txtnisabalzkat_klalwzin.Text)
            'سعر بيع الغرام الذهب * وزن الكلي
            txtmkdarZkat.Text = Val(nisab) * Val(allnisab)

            'txtdenar_on_years.Text = Val(nisab) * Val(allnisab)
            txtdenar_on_years.Text = Val(txtmkdarZkat.Text) * Val(xy.Text)
            txt_onONEyear.Text = txtmkdarZkat.Text / 40
            txtagmaly_al_zkat.Text = Val(txtdenar_on_years.Text) / 40
        Catch ex As Exception
            MsgBox("Error - Some think is Empty !!! ")
        End Try


    End Sub

    Private Sub DateTimePicker2_ValueChanged_1(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged
        Dim ci As New CultureInfo("ar-sa")
        txtHigry.Text = DateTimePicker2.Value.ToString("dd/MMM/yyyy", ci)
    End Sub
End Class
