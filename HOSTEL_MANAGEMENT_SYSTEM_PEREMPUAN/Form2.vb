Public Class Form2
    Private Sub ResidenBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ResidenBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.HostelSystemDataSet)

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'HostelSystemDataSet.Residen' table. You can move, or remove it, as needed.
        Me.ResidenTableAdapter.Fill(Me.HostelSystemDataSet.Residen)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If ComboBox1.Text = "Staff" Then
            Me.ResidenBindingSource.Filter = "Nama LIKE '" & TextBox1.Text & "%'OR Nombor_KP LIKE '" & TextBox1.Text & "%'OR Jawatan LIKE 'Staff'"
        ElseIf ComboBox1.Text = "Intern" Then
            Me.ResidenBindingSource.Filter = "Nama LIKE '" & TextBox1.Text & "%'OR Nombor_KP LIKE '" & TextBox1.Text & "%'OR Jawatan LIKE 'Intern'"
        Else
            Me.ResidenBindingSource.Filter = "Nama LIKE '" & TextBox1.Text & "%'OR Nombor_KP LIKE '" & TextBox1.Text & "%'"
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = "Staff" Then
            Me.ResidenBindingSource.Filter = "Jawatan LIKE 'Staff'"
        ElseIf ComboBox1.Text = "Intern" Then
            Me.ResidenBindingSource.Filter = "Jawatan LIKE 'Intern'"
        End If
    End Sub
End Class