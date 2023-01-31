Public Class Form6
    Private Sub Bil_SelenggaraanBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Bil_SelenggaraanBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.HostelSystemDataSet)

    End Sub

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'HostelSystemDataSet.Bil_Selenggaraan' table. You can move, or remove it, as needed.
        Me.Bil_SelenggaraanTableAdapter.Fill(Me.HostelSystemDataSet.Bil_Selenggaraan)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Maklumat_BayaranTextBox.Enabled = True
        Amaun_BayaranTextBox.Enabled = True
        Tarikh_BayaranDateTimePicker.Enabled = True
        Ref_NumberTextBox.Enabled = True
        Button4.Enabled = True
        Bil_SelenggaraanBindingSource.AddNew()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Maklumat_BayaranTextBox.Enabled = True
        Amaun_BayaranTextBox.Enabled = True
        Tarikh_BayaranDateTimePicker.Enabled = True
        Ref_NumberTextBox.Enabled = True
        Button5.Enabled = True

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Bil_SelenggaraanBindingSource.RemoveCurrent()
        Bil_SelenggaraanBindingSource.EndEdit()
        TableAdapterManager.UpdateAll(Me.HostelSystemDataSet)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            Me.Validate()
            Me.Bil_SelenggaraanBindingSource.EndEdit()
            TableAdapterManager.UpdateAll(Me.HostelSystemDataSet)
            MessageBox.Show("MAKLUMAT TELAH BERJAYA DISIMPAN")

            Maklumat_BayaranTextBox.Enabled = False
            Amaun_BayaranTextBox.Enabled = False
            Tarikh_BayaranDateTimePicker.Enabled = False
            Ref_NumberTextBox.Enabled = False
            Button4.Enabled = False

        Catch ex As Exception
            MessageBox.Show("MAKLUMAT TIDAK BERJAYA DISIMPAN")
            Me.Bil_SelenggaraanBindingSource.RemoveCurrent()
            Me.Bil_SelenggaraanBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.HostelSystemDataSet)
        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Try
            Me.Validate()
            Me.Bil_SelenggaraanBindingSource.EndEdit()
            TableAdapterManager.UpdateAll(Me.HostelSystemDataSet)
            MessageBox.Show("MAKLUMAT TELAH BERJAYA DIUBAHSUAI")

            Maklumat_BayaranTextBox.Enabled = False
            Amaun_BayaranTextBox.Enabled = False
            Tarikh_BayaranDateTimePicker.Enabled = False
            Ref_NumberTextBox.Enabled = False
            Button5.Enabled = False

        Catch ex As Exception
            MessageBox.Show("MAKLUMAT TIDAK BERJAYA DIUBAHSUAI")
        End Try

    End Sub
End Class