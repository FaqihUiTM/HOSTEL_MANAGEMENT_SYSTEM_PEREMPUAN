<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Maklumat_BayaranLabel As System.Windows.Forms.Label
        Dim Amaun_BayaranLabel As System.Windows.Forms.Label
        Dim Tarikh_BayaranLabel As System.Windows.Forms.Label
        Dim Ref_NumberLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Maklumat_BayaranTextBox = New System.Windows.Forms.TextBox()
        Me.Bil_SelenggaraanBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HostelSystemDataSet = New HOSTEL_MANAGEMENT_SYSTEM_PEREMPUAN.HostelSystemDataSet()
        Me.Amaun_BayaranTextBox = New System.Windows.Forms.TextBox()
        Me.Tarikh_BayaranDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Ref_NumberTextBox = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Bil_SelenggaraanTableAdapter = New HOSTEL_MANAGEMENT_SYSTEM_PEREMPUAN.HostelSystemDataSetTableAdapters.Bil_SelenggaraanTableAdapter()
        Me.TableAdapterManager = New HOSTEL_MANAGEMENT_SYSTEM_PEREMPUAN.HostelSystemDataSetTableAdapters.TableAdapterManager()
        Me.Bil_SelenggaraanDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Maklumat_BayaranLabel = New System.Windows.Forms.Label()
        Amaun_BayaranLabel = New System.Windows.Forms.Label()
        Tarikh_BayaranLabel = New System.Windows.Forms.Label()
        Ref_NumberLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.Bil_SelenggaraanBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HostelSystemDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bil_SelenggaraanDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Maklumat_BayaranLabel
        '
        Maklumat_BayaranLabel.AutoSize = True
        Maklumat_BayaranLabel.Location = New System.Drawing.Point(22, 33)
        Maklumat_BayaranLabel.Name = "Maklumat_BayaranLabel"
        Maklumat_BayaranLabel.Size = New System.Drawing.Size(117, 15)
        Maklumat_BayaranLabel.TabIndex = 17
        Maklumat_BayaranLabel.Text = "Maklumat Bayaran:"
        '
        'Amaun_BayaranLabel
        '
        Amaun_BayaranLabel.AutoSize = True
        Amaun_BayaranLabel.Location = New System.Drawing.Point(22, 59)
        Amaun_BayaranLabel.Name = "Amaun_BayaranLabel"
        Amaun_BayaranLabel.Size = New System.Drawing.Size(100, 15)
        Amaun_BayaranLabel.TabIndex = 19
        Amaun_BayaranLabel.Text = "Amaun Bayaran:"
        '
        'Tarikh_BayaranLabel
        '
        Tarikh_BayaranLabel.AutoSize = True
        Tarikh_BayaranLabel.Location = New System.Drawing.Point(22, 86)
        Tarikh_BayaranLabel.Name = "Tarikh_BayaranLabel"
        Tarikh_BayaranLabel.Size = New System.Drawing.Size(97, 15)
        Tarikh_BayaranLabel.TabIndex = 21
        Tarikh_BayaranLabel.Text = "Tarikh Bayaran:"
        '
        'Ref_NumberLabel
        '
        Ref_NumberLabel.AutoSize = True
        Ref_NumberLabel.Location = New System.Drawing.Point(22, 111)
        Ref_NumberLabel.Name = "Ref_NumberLabel"
        Ref_NumberLabel.Size = New System.Drawing.Size(79, 15)
        Ref_NumberLabel.TabIndex = 23
        Ref_NumberLabel.Text = "Ref Number:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Button5)
        Me.Panel1.Controls.Add(Maklumat_BayaranLabel)
        Me.Panel1.Controls.Add(Me.Maklumat_BayaranTextBox)
        Me.Panel1.Controls.Add(Amaun_BayaranLabel)
        Me.Panel1.Controls.Add(Me.Amaun_BayaranTextBox)
        Me.Panel1.Controls.Add(Tarikh_BayaranLabel)
        Me.Panel1.Controls.Add(Me.Tarikh_BayaranDateTimePicker)
        Me.Panel1.Controls.Add(Ref_NumberLabel)
        Me.Panel1.Controls.Add(Me.Ref_NumberTextBox)
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Font = New System.Drawing.Font("Aldrich", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(12, 259)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(660, 166)
        Me.Panel1.TabIndex = 1
        '
        'Button5
        '
        Me.Button5.Enabled = False
        Me.Button5.Location = New System.Drawing.Point(558, 73)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 25
        Me.Button5.Text = "UPDATE"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Maklumat_BayaranTextBox
        '
        Me.Maklumat_BayaranTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bil_SelenggaraanBindingSource, "Maklumat_Bayaran", True))
        Me.Maklumat_BayaranTextBox.Enabled = False
        Me.Maklumat_BayaranTextBox.Location = New System.Drawing.Point(150, 30)
        Me.Maklumat_BayaranTextBox.Name = "Maklumat_BayaranTextBox"
        Me.Maklumat_BayaranTextBox.Size = New System.Drawing.Size(321, 21)
        Me.Maklumat_BayaranTextBox.TabIndex = 18
        '
        'Bil_SelenggaraanBindingSource
        '
        Me.Bil_SelenggaraanBindingSource.DataMember = "Bil_Selenggaraan"
        Me.Bil_SelenggaraanBindingSource.DataSource = Me.HostelSystemDataSet
        '
        'HostelSystemDataSet
        '
        Me.HostelSystemDataSet.DataSetName = "HostelSystemDataSet"
        Me.HostelSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Amaun_BayaranTextBox
        '
        Me.Amaun_BayaranTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bil_SelenggaraanBindingSource, "Amaun_Bayaran", True))
        Me.Amaun_BayaranTextBox.Enabled = False
        Me.Amaun_BayaranTextBox.Location = New System.Drawing.Point(150, 56)
        Me.Amaun_BayaranTextBox.Name = "Amaun_BayaranTextBox"
        Me.Amaun_BayaranTextBox.Size = New System.Drawing.Size(200, 21)
        Me.Amaun_BayaranTextBox.TabIndex = 20
        '
        'Tarikh_BayaranDateTimePicker
        '
        Me.Tarikh_BayaranDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Bil_SelenggaraanBindingSource, "Tarikh_Bayaran", True))
        Me.Tarikh_BayaranDateTimePicker.Enabled = False
        Me.Tarikh_BayaranDateTimePicker.Location = New System.Drawing.Point(150, 82)
        Me.Tarikh_BayaranDateTimePicker.Name = "Tarikh_BayaranDateTimePicker"
        Me.Tarikh_BayaranDateTimePicker.Size = New System.Drawing.Size(200, 21)
        Me.Tarikh_BayaranDateTimePicker.TabIndex = 22
        '
        'Ref_NumberTextBox
        '
        Me.Ref_NumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bil_SelenggaraanBindingSource, "Ref_Number", True))
        Me.Ref_NumberTextBox.Enabled = False
        Me.Ref_NumberTextBox.Location = New System.Drawing.Point(150, 108)
        Me.Ref_NumberTextBox.Name = "Ref_NumberTextBox"
        Me.Ref_NumberTextBox.Size = New System.Drawing.Size(200, 21)
        Me.Ref_NumberTextBox.TabIndex = 24
        '
        'Button4
        '
        Me.Button4.Enabled = False
        Me.Button4.Location = New System.Drawing.Point(558, 30)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 17
        Me.Button4.Text = "SAVE"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(558, 122)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 16
        Me.Button3.Text = "DELETE"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(477, 73)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "MODIFY"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(477, 30)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "ADD NEW"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Bil_SelenggaraanTableAdapter
        '
        Me.Bil_SelenggaraanTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Bil_SelenggaraanTableAdapter = Me.Bil_SelenggaraanTableAdapter
        Me.TableAdapterManager.ResidenTableAdapter = Nothing
        Me.TableAdapterManager.SewaTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = HOSTEL_MANAGEMENT_SYSTEM_PEREMPUAN.HostelSystemDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Bil_SelenggaraanDataGridView
        '
        Me.Bil_SelenggaraanDataGridView.AllowUserToAddRows = False
        Me.Bil_SelenggaraanDataGridView.AllowUserToDeleteRows = False
        Me.Bil_SelenggaraanDataGridView.AllowUserToResizeColumns = False
        Me.Bil_SelenggaraanDataGridView.AllowUserToResizeRows = False
        Me.Bil_SelenggaraanDataGridView.AutoGenerateColumns = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(162, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Aldrich", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(162, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Bil_SelenggaraanDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.Bil_SelenggaraanDataGridView.ColumnHeadersHeight = 30
        Me.Bil_SelenggaraanDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.Bil_SelenggaraanDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.Bil_SelenggaraanDataGridView.DataSource = Me.Bil_SelenggaraanBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(133, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(202, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Aldrich", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(157, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Bil_SelenggaraanDataGridView.DefaultCellStyle = DataGridViewCellStyle2
        Me.Bil_SelenggaraanDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.Bil_SelenggaraanDataGridView.EnableHeadersVisualStyles = False
        Me.Bil_SelenggaraanDataGridView.Location = New System.Drawing.Point(12, 12)
        Me.Bil_SelenggaraanDataGridView.Name = "Bil_SelenggaraanDataGridView"
        Me.Bil_SelenggaraanDataGridView.RowHeadersVisible = False
        Me.Bil_SelenggaraanDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Bil_SelenggaraanDataGridView.Size = New System.Drawing.Size(660, 220)
        Me.Bil_SelenggaraanDataGridView.TabIndex = 2
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Maklumat_Bayaran"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Maklumat Bayaran"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Amaun_Bayaran"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Amaun (RM)"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Tarikh_Bayaran"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Tarikh Bayaran"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Ref_Number"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Reference Number"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'Form6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(684, 450)
        Me.Controls.Add(Me.Bil_SelenggaraanDataGridView)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form6"
        Me.Text = "Form6"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Bil_SelenggaraanBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HostelSystemDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bil_SelenggaraanDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents HostelSystemDataSet As HostelSystemDataSet
    Friend WithEvents Bil_SelenggaraanBindingSource As BindingSource
    Friend WithEvents Bil_SelenggaraanTableAdapter As HostelSystemDataSetTableAdapters.Bil_SelenggaraanTableAdapter
    Friend WithEvents TableAdapterManager As HostelSystemDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Bil_SelenggaraanDataGridView As DataGridView
    Friend WithEvents Maklumat_BayaranTextBox As TextBox
    Friend WithEvents Amaun_BayaranTextBox As TextBox
    Friend WithEvents Tarikh_BayaranDateTimePicker As DateTimePicker
    Friend WithEvents Ref_NumberTextBox As TextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
End Class
