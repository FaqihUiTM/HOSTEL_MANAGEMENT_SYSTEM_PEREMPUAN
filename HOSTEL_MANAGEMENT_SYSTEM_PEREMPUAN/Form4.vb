Public Class Form4
    Private Sub ResidenBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ResidenBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.HostelSystemDataSet)

    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'HostelSystemDataSet.Sewa' table. You can move, or remove it, as needed.
        Me.SewaTableAdapter.Fill(Me.HostelSystemDataSet.Sewa)
        'TODO: This line of code loads data into the 'HostelSystemDataSet.Residen' table. You can move, or remove it, as needed.
        Me.ResidenTableAdapter.Fill(Me.HostelSystemDataSet.Residen)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Maklumat_BayaranComboBox.Enabled = True
        Tarikh_BayaranDateTimePicker.Enabled = True
        Ref_NumberTextBox.Enabled = True
        SewaBindingSource.AddNew()
        Nombor_KPTextBox.Text = Nombor_KPLabel1.Text
        Button4.Enabled = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Maklumat_BayaranComboBox.Enabled = True
        Tarikh_BayaranDateTimePicker.Enabled = True
        Ref_NumberTextBox.Enabled = True
        Button5.Enabled = True
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim result As DialogResult = MessageBox.Show("Sahkan Pemadaman?", "PENGESAHAN PEMADAMAN", MessageBoxButtons.YesNo)
        If (result = DialogResult.Yes) Then
            Me.SewaBindingSource.RemoveCurrent()
            Me.SewaBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.HostelSystemDataSet)
        End If


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            Me.Validate()
            Me.SewaBindingSource.EndEdit()
            TableAdapterManager.UpdateAll(Me.HostelSystemDataSet)
            MessageBox.Show("MAKLUMAT TELAH BERJAYA DISIMPAN")
            Maklumat_BayaranComboBox.Enabled = False
            Tarikh_BayaranDateTimePicker.Enabled = False
            Ref_NumberTextBox.Enabled = False
            Button4.Enabled = False
        Catch ex As Exception
            MessageBox.Show("MAKLUMAT TIDAK BERJAYA DISIMPAN")
            Me.SewaBindingSource.RemoveCurrent()
            Me.sewaBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.HostelSystemDataSet)
        End Try
        Button4.Enabled = False
    End Sub

    Private Sub ResidenDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ResidenDataGridView.CellContentClick
        Me.SewaBindingSource.Filter = "Nombor_KP LIKE '" & Nombor_KPLabel1.Text & "%'"
    End Sub

    Private Sub Maklumat_BayaranComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Maklumat_BayaranComboBox.SelectedIndexChanged
        If Maklumat_BayaranComboBox.Text = "BAYARAN SEWA PENUH" Then
            Amaun_BayaranTextBox.Text = "80"
        ElseIf Maklumat_BayaranComboBox.Text = "BAYARAN SEWA PERTAMA + PENDAFTARAN" Then
            Amaun_BayaranTextBox.Text = "130"
        ElseIf Maklumat_BayaranComboBox.Text = "BAYARAN SEWA 11 - 20 HARIBULAN" Then
            Amaun_BayaranTextBox.Text = "60"
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Try
            Me.Validate()
            Me.SewaBindingSource.EndEdit()
            TableAdapterManager.UpdateAll(Me.HostelSystemDataSet)
            MessageBox.Show("MAKLUMAT TELAH BERJAYA DIUBAHSUAI")
            Maklumat_BayaranComboBox.Enabled = False
            Tarikh_BayaranDateTimePicker.Enabled = False
            Ref_NumberTextBox.Enabled = False
            Button5.Enabled = False
        Catch ex As Exception
            MessageBox.Show("MAKLUMAT TIDAK BERJAYA DIUBAHSUAI")
        End Try
        Button5.Enabled = False
    End Sub

    Private Sub Nombor_KPLabel1_Click(sender As Object, e As EventArgs) Handles Nombor_KPLabel1.TextChanged
        Me.SewaBindingSource.Filter = "Nombor_KP LIKE '" & Nombor_KPLabel1.Text & "%'"
    End Sub
End Class