Public Class Form3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        NamaTextBox.Enabled = True
        Nombor_KPTextBox.Enabled = True
        TelefonTextBox.Enabled = True
        JawatanComboBox.Enabled = True
        Tarikh_KeluarDateTimePicker.Enabled = True
        Tarikh_MasukDateTimePicker.Enabled = True
        Nama_WarisTextBox.Enabled = True
        Telefon_WarisTextBox.Enabled = True
        Button2.Enabled = True
        ResidenBindingSource.AddNew()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If NamaTextBox.Text = Nothing Or Nombor_KPTextBox.Text = Nothing Or TelefonTextBox.Text = Nothing Or JawatanComboBox.Text = Nothing Or Tarikh_MasukDateTimePicker.Value = Nothing Or Tarikh_KeluarDateTimePicker.Value = Nothing Then
            MessageBox.Show("SILA ISI MAKLUMAT DENGAN LENGKAP")
        ElseIf Nombor_KPTextBox.TextLength < 11 OrElse Nombor_KPTextBox.TextLength > 13 Then
            MessageBox.Show("SILI PASTIKAN NOMBOR KAD PENGENALAN DIISI DENGAN BETUL")
        Else
            Try
                Me.Validate()
                Me.ResidenBindingSource.EndEdit()
                TableAdapterManager.UpdateAll(Me.HostelSystemDataSet)
                MessageBox.Show("MAKLUMAT TELAH BERJAYA DISIMPAN")
                NamaTextBox.Enabled = False
                Nombor_KPTextBox.Enabled = False
                TelefonTextBox.Enabled = False
                JawatanComboBox.Enabled = False
                Tarikh_KeluarDateTimePicker.Enabled = False
                Tarikh_MasukDateTimePicker.Enabled = False
                Nama_WarisTextBox.Enabled = False
                Telefon_WarisTextBox.Enabled = False
                Button2.Enabled = False
            Catch ex As Exception
                MessageBox.Show("MAKLUMAT TIDAK DAPAT DISIMPAN")
                Me.ResidenBindingSource.RemoveCurrent()
                Me.ResidenBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.HostelSystemDataSet)
            End Try
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        NamaTextBox.Enabled = True
        Nombor_KPTextBox.Enabled = True
        TelefonTextBox.Enabled = True
        JawatanComboBox.Enabled = True
        Tarikh_KeluarDateTimePicker.Enabled = True
        Tarikh_MasukDateTimePicker.Enabled = True
        Nama_WarisTextBox.Enabled = True
        Telefon_WarisTextBox.Enabled = True
        Button5.Enabled = True

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim confirmation As New Form5
        confirmation.ResidenTableAdapter.Fill(Form4.HostelSystemDataSet.Residen)
        confirmation.SewaTableAdapter.Fill(Form4.HostelSystemDataSet.Sewa)
        confirmation.TextBox1.Text = Nombor_KPTextBox.Text
        confirmation.Show()
    End Sub



    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'HostelSystemDataSet.Residen' table. You can move, or remove it, as needed.
        Me.ResidenTableAdapter.Fill(Me.HostelSystemDataSet.Residen)

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If NamaTextBox.Text = Nothing Or Nombor_KPTextBox.Text = Nothing Or TelefonTextBox.Text = Nothing Or JawatanComboBox.Text = Nothing Or Tarikh_MasukDateTimePicker.Value = Nothing Or Tarikh_KeluarDateTimePicker.Value = Nothing Then
            MessageBox.Show("SILA ISI KESEMUA MAKLUMAT DENGAN LENGKAP")
        ElseIf Nombor_KPTextBox.TextLength < 11 OrElse Nombor_KPTextBox.TextLength > 13 Then
            MessageBox.Show("SILA ISI NOMBOR KAD PENGENALAN DENGAN BETUL")
        Else
            Try
                Me.Validate()
                Me.ResidenBindingSource.EndEdit()
                TableAdapterManager.UpdateAll(Me.HostelSystemDataSet)
                MessageBox.Show("MAKLUMAT TELAH BERJAYA DIUBAHSUAI")
                NamaTextBox.Enabled = False
                Nombor_KPTextBox.Enabled = False
                TelefonTextBox.Enabled = False
                JawatanComboBox.Enabled = False
                Tarikh_KeluarDateTimePicker.Enabled = False
                Tarikh_MasukDateTimePicker.Enabled = False
                Nama_WarisTextBox.Enabled = False
                Telefon_WarisTextBox.Enabled = False
                Button5.Enabled = False
            Catch ex As Exception
                MessageBox.Show("MAKLUMAT TIDAK BERJAYA DIUBAHSUAI")
            End Try
        End If
    End Sub


End Class