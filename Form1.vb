Imports System.Globalization

Public Class Form1
    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        Dim ci As New CultureInfo("ar-sa")
        txtHigry.Text = DateTimePicker1.Value.ToString("dd/MMM/yyyy", ci)


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'txtNow.Text = DateTimePicker1.Text
        txtNow.Text = Now
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Dim ci As New CultureInfo("ar-sa")
        'txtdateUse.Text = DateTimePicker2.Value.ToString("dd/MMM/yyyy", ci)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            Dim xx As Date
            xx = txtNow.Text

            txtResult.Text = DateAdd(DateInterval.Day, 0, Date.Now.Date).ToString("dd/MM/yyyy")
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
            alnisab = Convert.ToDouble(txtnisabalzkat.Text)
            qerat = Convert.ToDouble(ComboBox1.SelectedItem)
            result = wazn * qerat / 24
            txtnisabalzkat_klalwzin.Text = result

        Catch ex As Exception
            MsgBox("Error !!! txtklalwzin OR txtnisabalzkat OR ComboBox1 are Empty")
        End Try

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)
        manyYears.Text = xy.Text

    End Sub
End Class
