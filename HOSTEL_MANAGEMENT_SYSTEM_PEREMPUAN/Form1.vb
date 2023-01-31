Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        switchPanel(Form2)
        Form2.ResidenTableAdapter.Fill(Form2.HostelSystemDataSet.Residen)
        Label1.Text = "Maklumat Residen"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        switchPanel(Form3)
        Form3.ResidenTableAdapter.Fill(Form3.HostelSystemDataSet.Residen)
        Label1.Text = "Ubahsuai Residen Terkini"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        switchPanel(Form4)
        Form4.ResidenTableAdapter.Fill(Form4.HostelSystemDataSet.Residen)
        Form4.SewaTableAdapter.Fill(Form4.HostelSystemDataSet.Sewa)
        Label1.Text = "Rekod Bayaran Sewa"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        switchPanel(Form6)
        Form6.Bil_SelenggaraanTableAdapter.Fill(Form6.HostelSystemDataSet.Bil_Selenggaraan)
        Label1.Text = "Rekod Bil Selenggaraan"
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        switchPanel(Form7)
        Form7.SewaTableAdapter.Fill(Form7.HostelSystemDataSet.Sewa)
        Form7.Bil_SelenggaraanTableAdapter.Fill(Form7.HostelSystemDataSet.Bil_Selenggaraan)
        Label1.Text = "Rekod Kewangan"
    End Sub

    Sub switchPanel(ByVal panel As Form)
        panelMain.Controls.Clear()
        panel.TopLevel = False
        panelMain.Controls.Add(panel)
        panel.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "HOME"
    End Sub


End Class
