Imports System.Drawing.Printing
Public Class Form7


    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'HostelSystemDataSet.Bil_Selenggaraan' table. You can move, or remove it, as needed.
        Me.Bil_SelenggaraanTableAdapter.Fill(Me.HostelSystemDataSet.Bil_Selenggaraan)
        'TODO: This line of code loads data into the 'HostelSystemDataSet.Sewa' table. You can move, or remove it, as needed.
        Me.SewaTableAdapter.Fill(Me.HostelSystemDataSet.Sewa)


    End Sub

    Dim WithEvents PD As New PrintDocument
    Dim PPD As New PrintPreviewDialog
    Dim longpaper As Integer
    Sub changelongpaper()
        Dim rowcount As Integer
        longpaper = 0
        rowcount = SewaDataGridView.Rows.Count + Bil_SelenggaraanDataGridView.Rows.Count
        longpaper = rowcount * 30
        longpaper = longpaper + 500
    End Sub

    Private Sub PD_BeginPrint(sender As Object, e As Printing.PrintEventArgs) Handles PD.BeginPrint
        Dim pagesetup As New PageSettings
        'pagesetup.PaperSize = New PaperSize("Custom", 700, 840) 'fixed size
        pagesetup.PaperSize = New PaperSize("Custom", 700, longpaper)
        PD.DefaultPageSettings = pagesetup
    End Sub

    Private Sub PD_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PD.PrintPage

        ' FONT DECLARATAION
        Dim f8 As New Font("Calibri", 12, FontStyle.Regular)
        Dim f10 As New Font("Calibri", 14, FontStyle.Regular)
        Dim f10b As New Font("Aldrich", 14, FontStyle.Bold)
        Dim f14 As New Font("Calibri", 20, FontStyle.Bold)

        'MARGIN DECLARATION
        Dim leftmargin As Integer = PD.DefaultPageSettings.Margins.Left
        Dim centermargin As Integer = PD.DefaultPageSettings.PaperSize.Width / 2
        Dim rightmargin As Integer = PD.DefaultPageSettings.PaperSize.Width

        'FONT ALIGNMENT
        Dim right As New StringFormat
        Dim center As New StringFormat
        right.Alignment = StringAlignment.Far
        center.Alignment = StringAlignment.Center

        Dim line As String
        line = "****************************************************************"
        'Dim line2 As String
        'line2 = "________________________________________________________________"

        'DRAW LOGO
        Dim logoImage As Image = My.Resources.ResourceManager.GetObject("sumayyah-bg")
        e.Graphics.DrawImage(logoImage, CInt((e.PageBounds.Width - 150) / 2), 5, 150, 150)

        Dim height0 As Integer
        height0 = 150

        e.Graphics.DrawString("ASRAMA SUMAIYYAH", f10b, Brushes.Black, centermargin, 20 + height0, center)
        e.Graphics.DrawString("REKOD KEWANGAN ASRAMA SUMAYYAH PADA : " & ComboBox1.Text & ", " & ComboBox2.Text, f8, Brushes.Black, centermargin, 60 + height0, center)

        e.Graphics.DrawString(line, f8, Brushes.Black, centermargin, 75 + height0, center)
        e.Graphics.DrawString("DUIT MASUK", f10, Brushes.Black, centermargin, 85 + height0, center)


        e.Graphics.DrawString("MAKLUMAT BAYARAN", f8, Brushes.Black, 10, 120 + height0)
        e.Graphics.DrawString("REFERENCE NUMBER", f8, Brushes.Black, 300, 120 + height0)
        e.Graphics.DrawString("JUMLAH", f8, Brushes.Black, rightmargin, 120 + height0, right)


        'DATAGRIDVIEW UNTUK SEWA
        Dim height As Integer 'DGV Position
        Dim i As Long
        SewaDataGridView.AllowUserToAddRows = False
        Bil_SelenggaraanDataGridView.AllowUserToAddRows = False

        For row As Integer = 0 To SewaDataGridView.RowCount - 1

            height += 25

            e.Graphics.DrawString(SewaDataGridView.Rows(row).Cells(0).Value.ToString, f8, Brushes.Black, 10, 125 + height + height0)

            e.Graphics.DrawString(SewaDataGridView.Rows(row).Cells(3).Value.ToString, f8, Brushes.Black, 300, 125 + height + height0)

            i = SewaDataGridView.Rows(row).Cells(1).Value
            SewaDataGridView.Rows(row).Cells(1).Value = Format(i, "##,##0")
            e.Graphics.DrawString(SewaDataGridView.Rows(row).Cells(1).Value.ToString, f8, Brushes.Black, rightmargin, 125 + height + height0, right)

        Next

        Dim height2 As Integer
        height2 = 155 + height + height0
        sumprice() 'call sub

        e.Graphics.DrawString("JUMLAH : RM  " & Format(t_price, "##,##0"), f10b, Brushes.Black, rightmargin, height2, right)
        e.Graphics.DrawString(line, f8, Brushes.Black, centermargin, 30 + height2, center)

        e.Graphics.DrawString("DUIT KELUAR", f10, Brushes.Black, centermargin, 40 + height2, center)

        e.Graphics.DrawString("MAKLUMAT BAYARAN", f8, Brushes.Black, 10, 80 + height2)
        e.Graphics.DrawString("REFERENCE NUMBER", f8, Brushes.Black, 300, 80 + height2)
        e.Graphics.DrawString("JUMLAH", f8, Brushes.Black, rightmargin, 80 + height2, right)



        Dim height3 As Integer
        height3 = 80 + height2

        For row As Integer = 0 To Bil_SelenggaraanDataGridView.RowCount - 1

            height3 += 25

            e.Graphics.DrawString(Bil_SelenggaraanDataGridView.Rows(row).Cells(0).Value.ToString, f8, Brushes.Black, 10, height3)

            e.Graphics.DrawString(Bil_SelenggaraanDataGridView.Rows(row).Cells(3).Value.ToString, f8, Brushes.Black, 300, height3)

            i = Bil_SelenggaraanDataGridView.Rows(row).Cells(1).Value
            Bil_SelenggaraanDataGridView.Rows(row).Cells(1).Value = Format(i, "##,##0")
            e.Graphics.DrawString(Bil_SelenggaraanDataGridView.Rows(row).Cells(1).Value.ToString, f8, Brushes.Black, rightmargin, height3, right)

        Next

        Dim height4 As Integer
        height4 = 30 + height3
        sumbelanja()

        e.Graphics.DrawString("JUMLAH : RM  " & Format(t_belanja, "##,##0"), f10b, Brushes.Black, rightmargin, height4, right)

    End Sub

    Dim t_price As Long
    Dim t_belanja As Long

    Sub sumprice()
        Dim countprice As Long = 0
        For rowitem As Long = 0 To SewaDataGridView.RowCount - 1
            countprice = countprice + Val(SewaDataGridView.Rows(rowitem).Cells(1).Value)
        Next

        t_price = countprice
    End Sub

    Sub sumbelanja()
        Dim countbelanja As Long = 0
        For rowitem As Long = 0 To Bil_SelenggaraanDataGridView.RowCount - 1
            countbelanja = countbelanja + Val(Bil_SelenggaraanDataGridView.Rows(rowitem).Cells(1).Value)
        Next

        t_belanja = countbelanja
    End Sub

    Sub filterTarikh()
        'TARIKH AWAL
        If ComboBox1.Text = "JANUARI" Then
            TextBox1.Text = "1/01/" & ComboBox2.Text
        ElseIf ComboBox1.Text = "FEBRUARI" Then
            TextBox1.Text = "1/02/" & ComboBox2.Text
        ElseIf ComboBox1.Text = "MAC" Then
            TextBox1.Text = "1/03/" & ComboBox2.Text
        ElseIf ComboBox1.Text = "APRIL" Then
            TextBox1.Text = "1/04/" & ComboBox2.Text
        ElseIf ComboBox1.Text = "MEI" Then
            TextBox1.Text = "1/05/" & ComboBox2.Text
        ElseIf ComboBox1.Text = "JUN" Then
            TextBox1.Text = "1/06/" & ComboBox2.Text
        ElseIf ComboBox1.Text = "JULAI" Then
            TextBox1.Text = "1/07/" & ComboBox2.Text
        ElseIf ComboBox1.Text = "OGOS" Then
            TextBox1.Text = "1/08/" & ComboBox2.Text
        ElseIf ComboBox1.Text = "SEPTEMBER" Then
            TextBox1.Text = "1/09/" & ComboBox2.Text
        ElseIf ComboBox1.Text = "OKTOBER" Then
            TextBox1.Text = "1/10/" & ComboBox2.Text
        ElseIf ComboBox1.Text = "NOVEMBER" Then
            TextBox1.Text = "1/11/" & ComboBox2.Text
        ElseIf ComboBox1.Text = "DISEMBER" Then
            TextBox1.Text = "1/12/" & ComboBox2.Text
        End If

        'TARIKH AKHIR
        If ComboBox1.Text = "JANUARI" Then
            TextBox2.Text = "31/01/" & ComboBox2.Text
        ElseIf ComboBox1.Text = "FEBRUARI" Then
            TextBox2.Text = "28/02/" & ComboBox2.Text
        ElseIf ComboBox1.Text = "MAC" Then
            TextBox2.Text = "31/03/" & ComboBox2.Text
        ElseIf ComboBox1.Text = "APRIL" Then
            TextBox2.Text = "30/04/" & ComboBox2.Text
        ElseIf ComboBox1.Text = "MEI" Then
            TextBox2.Text = "31/05/" & ComboBox2.Text
        ElseIf ComboBox1.Text = "JUN" Then
            TextBox2.Text = "30/06/" & ComboBox2.Text
        ElseIf ComboBox1.Text = "JULAI" Then
            TextBox2.Text = "31/07/" & ComboBox2.Text
        ElseIf ComboBox1.Text = "OGOS" Then
            TextBox2.Text = "31/08/" & ComboBox2.Text
        ElseIf ComboBox1.Text = "SEPTEMBER" Then
            TextBox2.Text = "30/09/" & ComboBox2.Text
        ElseIf ComboBox1.Text = "OKTOBER" Then
            TextBox2.Text = "31/10/" & ComboBox2.Text
        ElseIf ComboBox1.Text = "NOVEMBER" Then
            TextBox2.Text = "30/11/" & ComboBox2.Text
        ElseIf ComboBox1.Text = "DISEMBER" Then
            TextBox2.Text = "31/12/" & ComboBox2.Text
        End If
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ComboBox1.Text = "" And ComboBox2.Text = "" Then
            MessageBox.Show("SILA PILIH BULAN DAN TAHUN REKOD KEWANGAN YANG ANDA INGINKAN")
        Else
            filterTarikh()
            Dim a1 As String
            Dim a2 As String

            a1 = TextBox1.Text
            a2 = TextBox2.Text

            Me.SewaBindingSource.Filter = "Tarikh_Bayaran >= '#" & a1 & "#' AND Tarikh_Bayaran <= '#" & a2 & "#'"
            Me.Bil_SelenggaraanBindingSource.Filter = "Tarikh_Bayaran >= '#" & a1 & "#' AND Tarikh_Bayaran <= '#" & a2 & "#'"
        End If
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text = "" And TextBox2.Text = "" Then
            MessageBox.Show("SILA PILIH BULAN DAN TAHUN REKOD KEWANGAN YANG ANDA INGINKAN")
        Else
            changelongpaper()
            PPD.Document = PD
            PPD.ShowDialog()
            'PD.Print()  'Direct Print
        End If
    End Sub

End Class