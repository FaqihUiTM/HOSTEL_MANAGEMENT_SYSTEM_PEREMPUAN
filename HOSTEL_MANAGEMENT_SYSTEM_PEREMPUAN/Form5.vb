Public Class Form5
    Private Sub ResidenBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ResidenBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.HostelSystemDataSet)

    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'HostelSystemDataSet.Sewa' table. You can move, or remove it, as needed.
        Me.SewaTableAdapter.Fill(Me.HostelSystemDataSet.Sewa)
        'TODO: This line of code loads data into the 'HostelSystemDataSet.Residen' table. You can move, or remove it, as needed.
        Me.ResidenTableAdapter.Fill(Me.HostelSystemDataSet.Residen)

        Me.SewaBindingSource.Filter = "Nombor_KP LIKE '" & TextBox1.Text & "%'"
        Me.ResidenBindingSource.Filter = "Nombor_KP LIKE '" & TextBox1.Text & "%'"
        Me.SewaDataGridView.SelectAll()
        Me.ResidenDataGridView.SelectAll()
        TextBox2.Text = SewaDataGridView.SelectedRows.Count
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'BUTTON DELETE/PADAM'
        Dim i As Integer
        i = 1
        Dim indicator As Integer
        indicator = SewaDataGridView.SelectedRows.Count

        If i = i Then

        Else
            Do
                Me.SewaDataGridView.SelectAll()
                Me.SewaBindingSource.RemoveCurrent()
                i = i + 1
            Loop Until i = indicator
        End If


        Me.SewaBindingSource.EndEdit()
        Me.ResidenBindingSource.RemoveCurrent()
        Me.ResidenBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.HostelSystemDataSet)

        Form3.ResidenTableAdapter.Fill(Form3.HostelSystemDataSet.Residen)
        Me.Hide()
        MessageBox.Show("MAKLUMAT TELAH BERJAYA DIPADAM")
    End Sub
End Class