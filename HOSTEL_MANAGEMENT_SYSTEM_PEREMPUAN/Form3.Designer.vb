<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim Nombor_KPLabel As System.Windows.Forms.Label
        Dim NamaLabel As System.Windows.Forms.Label
        Dim TelefonLabel As System.Windows.Forms.Label
        Dim JawatanLabel As System.Windows.Forms.Label
        Dim Tarikh_MasukLabel As System.Windows.Forms.Label
        Dim Tarikh_KeluarLabel As System.Windows.Forms.Label
        Dim Nama_WarisLabel As System.Windows.Forms.Label
        Dim Telefon_WarisLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Nombor_KPTextBox = New System.Windows.Forms.TextBox()
        Me.ResidenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HostelSystemDataSet = New HOSTEL_MANAGEMENT_SYSTEM_PEREMPUAN.HostelSystemDataSet()
        Me.NamaTextBox = New System.Windows.Forms.TextBox()
        Me.TelefonTextBox = New System.Windows.Forms.TextBox()
        Me.JawatanComboBox = New System.Windows.Forms.ComboBox()
        Me.Tarikh_MasukDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Tarikh_KeluarDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Nama_WarisTextBox = New System.Windows.Forms.TextBox()
        Me.Telefon_WarisTextBox = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ResidenTableAdapter = New HOSTEL_MANAGEMENT_SYSTEM_PEREMPUAN.HostelSystemDataSetTableAdapters.ResidenTableAdapter()
        Me.TableAdapterManager = New HOSTEL_MANAGEMENT_SYSTEM_PEREMPUAN.HostelSystemDataSetTableAdapters.TableAdapterManager()
        Me.ResidenDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Nombor_KPLabel = New System.Windows.Forms.Label()
        NamaLabel = New System.Windows.Forms.Label()
        TelefonLabel = New System.Windows.Forms.Label()
        JawatanLabel = New System.Windows.Forms.Label()
        Tarikh_MasukLabel = New System.Windows.Forms.Label()
        Tarikh_KeluarLabel = New System.Windows.Forms.Label()
        Nama_WarisLabel = New System.Windows.Forms.Label()
        Telefon_WarisLabel = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ResidenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HostelSystemDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ResidenDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Nombor_KPLabel
        '
        Nombor_KPLabel.AutoSize = True
        Nombor_KPLabel.Font = New System.Drawing.Font("Aldrich", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Nombor_KPLabel.Location = New System.Drawing.Point(12, 73)
        Nombor_KPLabel.Name = "Nombor_KPLabel"
        Nombor_KPLabel.Size = New System.Drawing.Size(75, 15)
        Nombor_KPLabel.TabIndex = 4
        Nombor_KPLabel.Text = "Nombor KP:"
        '
        'NamaLabel
        '
        NamaLabel.AutoSize = True
        NamaLabel.Font = New System.Drawing.Font("Aldrich", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NamaLabel.Location = New System.Drawing.Point(12, 41)
        NamaLabel.Name = "NamaLabel"
        NamaLabel.Size = New System.Drawing.Size(43, 15)
        NamaLabel.TabIndex = 6
        NamaLabel.Text = "Nama:"
        '
        'TelefonLabel
        '
        TelefonLabel.AutoSize = True
        TelefonLabel.Font = New System.Drawing.Font("Aldrich", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TelefonLabel.Location = New System.Drawing.Point(12, 106)
        TelefonLabel.Name = "TelefonLabel"
        TelefonLabel.Size = New System.Drawing.Size(53, 15)
        TelefonLabel.TabIndex = 8
        TelefonLabel.Text = "Telefon:"
        '
        'JawatanLabel
        '
        JawatanLabel.AutoSize = True
        JawatanLabel.Font = New System.Drawing.Font("Aldrich", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        JawatanLabel.Location = New System.Drawing.Point(12, 140)
        JawatanLabel.Name = "JawatanLabel"
        JawatanLabel.Size = New System.Drawing.Size(60, 15)
        JawatanLabel.TabIndex = 10
        JawatanLabel.Text = "Jawatan:"
        '
        'Tarikh_MasukLabel
        '
        Tarikh_MasukLabel.AutoSize = True
        Tarikh_MasukLabel.Font = New System.Drawing.Font("Aldrich", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Tarikh_MasukLabel.Location = New System.Drawing.Point(12, 176)
        Tarikh_MasukLabel.Name = "Tarikh_MasukLabel"
        Tarikh_MasukLabel.Size = New System.Drawing.Size(85, 15)
        Tarikh_MasukLabel.TabIndex = 12
        Tarikh_MasukLabel.Text = "Tarikh Masuk:"
        '
        'Tarikh_KeluarLabel
        '
        Tarikh_KeluarLabel.AutoSize = True
        Tarikh_KeluarLabel.Font = New System.Drawing.Font("Aldrich", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Tarikh_KeluarLabel.Location = New System.Drawing.Point(12, 210)
        Tarikh_KeluarLabel.Name = "Tarikh_KeluarLabel"
        Tarikh_KeluarLabel.Size = New System.Drawing.Size(87, 15)
        Tarikh_KeluarLabel.TabIndex = 14
        Tarikh_KeluarLabel.Text = "Tarikh Keluar:"
        '
        'Nama_WarisLabel
        '
        Nama_WarisLabel.AutoSize = True
        Nama_WarisLabel.Font = New System.Drawing.Font("Aldrich", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Nama_WarisLabel.Location = New System.Drawing.Point(12, 243)
        Nama_WarisLabel.Name = "Nama_WarisLabel"
        Nama_WarisLabel.Size = New System.Drawing.Size(79, 15)
        Nama_WarisLabel.TabIndex = 16
        Nama_WarisLabel.Text = "Nama Waris:"
        '
        'Telefon_WarisLabel
        '
        Telefon_WarisLabel.AutoSize = True
        Telefon_WarisLabel.Font = New System.Drawing.Font("Aldrich", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Telefon_WarisLabel.Location = New System.Drawing.Point(12, 277)
        Telefon_WarisLabel.Name = "Telefon_WarisLabel"
        Telefon_WarisLabel.Size = New System.Drawing.Size(89, 15)
        Telefon_WarisLabel.TabIndex = 18
        Telefon_WarisLabel.Text = "Telefon Waris:"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.Button5)
        Me.GroupBox1.Controls.Add(Nombor_KPLabel)
        Me.GroupBox1.Controls.Add(Me.Nombor_KPTextBox)
        Me.GroupBox1.Controls.Add(NamaLabel)
        Me.GroupBox1.Controls.Add(Me.NamaTextBox)
        Me.GroupBox1.Controls.Add(TelefonLabel)
        Me.GroupBox1.Controls.Add(Me.TelefonTextBox)
        Me.GroupBox1.Controls.Add(JawatanLabel)
        Me.GroupBox1.Controls.Add(Me.JawatanComboBox)
        Me.GroupBox1.Controls.Add(Tarikh_MasukLabel)
        Me.GroupBox1.Controls.Add(Me.Tarikh_MasukDateTimePicker)
        Me.GroupBox1.Controls.Add(Tarikh_KeluarLabel)
        Me.GroupBox1.Controls.Add(Me.Tarikh_KeluarDateTimePicker)
        Me.GroupBox1.Controls.Add(Nama_WarisLabel)
        Me.GroupBox1.Controls.Add(Me.Nama_WarisTextBox)
        Me.GroupBox1.Controls.Add(Telefon_WarisLabel)
        Me.GroupBox1.Controls.Add(Me.Telefon_WarisTextBox)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Font = New System.Drawing.Font("Aldrich", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(317, 426)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Maklumat Residen"
        '
        'Button5
        '
        Me.Button5.Enabled = False
        Me.Button5.Location = New System.Drawing.Point(96, 387)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 20
        Me.Button5.Text = "UPDATE"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Nombor_KPTextBox
        '
        Me.Nombor_KPTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ResidenBindingSource, "Nombor_KP", True))
        Me.Nombor_KPTextBox.Enabled = False
        Me.Nombor_KPTextBox.Location = New System.Drawing.Point(104, 70)
        Me.Nombor_KPTextBox.Name = "Nombor_KPTextBox"
        Me.Nombor_KPTextBox.Size = New System.Drawing.Size(200, 21)
        Me.Nombor_KPTextBox.TabIndex = 5
        '
        'ResidenBindingSource
        '
        Me.ResidenBindingSource.DataMember = "Residen"
        Me.ResidenBindingSource.DataSource = Me.HostelSystemDataSet
        '
        'HostelSystemDataSet
        '
        Me.HostelSystemDataSet.DataSetName = "HostelSystemDataSet"
        Me.HostelSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'NamaTextBox
        '
        Me.NamaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ResidenBindingSource, "Nama", True))
        Me.NamaTextBox.Enabled = False
        Me.NamaTextBox.Location = New System.Drawing.Point(104, 38)
        Me.NamaTextBox.Name = "NamaTextBox"
        Me.NamaTextBox.Size = New System.Drawing.Size(200, 21)
        Me.NamaTextBox.TabIndex = 7
        '
        'TelefonTextBox
        '
        Me.TelefonTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ResidenBindingSource, "Telefon", True))
        Me.TelefonTextBox.Enabled = False
        Me.TelefonTextBox.Location = New System.Drawing.Point(104, 103)
        Me.TelefonTextBox.Name = "TelefonTextBox"
        Me.TelefonTextBox.Size = New System.Drawing.Size(200, 21)
        Me.TelefonTextBox.TabIndex = 9
        '
        'JawatanComboBox
        '
        Me.JawatanComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ResidenBindingSource, "Jawatan", True))
        Me.JawatanComboBox.Enabled = False
        Me.JawatanComboBox.FormattingEnabled = True
        Me.JawatanComboBox.Items.AddRange(New Object() {"Staff", "Intern"})
        Me.JawatanComboBox.Location = New System.Drawing.Point(104, 137)
        Me.JawatanComboBox.Name = "JawatanComboBox"
        Me.JawatanComboBox.Size = New System.Drawing.Size(200, 23)
        Me.JawatanComboBox.TabIndex = 11
        '
        'Tarikh_MasukDateTimePicker
        '
        Me.Tarikh_MasukDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ResidenBindingSource, "Tarikh_Masuk", True))
        Me.Tarikh_MasukDateTimePicker.Enabled = False
        Me.Tarikh_MasukDateTimePicker.Location = New System.Drawing.Point(104, 172)
        Me.Tarikh_MasukDateTimePicker.Name = "Tarikh_MasukDateTimePicker"
        Me.Tarikh_MasukDateTimePicker.Size = New System.Drawing.Size(200, 21)
        Me.Tarikh_MasukDateTimePicker.TabIndex = 13
        '
        'Tarikh_KeluarDateTimePicker
        '
        Me.Tarikh_KeluarDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ResidenBindingSource, "Tarikh_Keluar", True))
        Me.Tarikh_KeluarDateTimePicker.Enabled = False
        Me.Tarikh_KeluarDateTimePicker.Location = New System.Drawing.Point(104, 206)
        Me.Tarikh_KeluarDateTimePicker.Name = "Tarikh_KeluarDateTimePicker"
        Me.Tarikh_KeluarDateTimePicker.Size = New System.Drawing.Size(200, 21)
        Me.Tarikh_KeluarDateTimePicker.TabIndex = 15
        '
        'Nama_WarisTextBox
        '
        Me.Nama_WarisTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ResidenBindingSource, "Nama_Waris", True))
        Me.Nama_WarisTextBox.Enabled = False
        Me.Nama_WarisTextBox.Location = New System.Drawing.Point(104, 240)
        Me.Nama_WarisTextBox.Name = "Nama_WarisTextBox"
        Me.Nama_WarisTextBox.Size = New System.Drawing.Size(200, 21)
        Me.Nama_WarisTextBox.TabIndex = 17
        '
        'Telefon_WarisTextBox
        '
        Me.Telefon_WarisTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ResidenBindingSource, "Telefon_Waris", True))
        Me.Telefon_WarisTextBox.Enabled = False
        Me.Telefon_WarisTextBox.Location = New System.Drawing.Point(104, 274)
        Me.Telefon_WarisTextBox.Name = "Telefon_WarisTextBox"
        Me.Telefon_WarisTextBox.Size = New System.Drawing.Size(200, 21)
        Me.Telefon_WarisTextBox.TabIndex = 19
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(229, 387)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "DELETE"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(15, 387)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "MODIFY"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Enabled = False
        Me.Button2.Location = New System.Drawing.Point(96, 346)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "SAVE"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(15, 346)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "ADD NEW" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ResidenTableAdapter
        '
        Me.ResidenTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Bil_SelenggaraanTableAdapter = Nothing
        Me.TableAdapterManager.ResidenTableAdapter = Me.ResidenTableAdapter
        Me.TableAdapterManager.SewaTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = HOSTEL_MANAGEMENT_SYSTEM_PEREMPUAN.HostelSystemDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ResidenDataGridView
        '
        Me.ResidenDataGridView.AllowUserToAddRows = False
        Me.ResidenDataGridView.AutoGenerateColumns = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(162, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Aldrich", 8.25!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(162, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ResidenDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.ResidenDataGridView.ColumnHeadersHeight = 30
        Me.ResidenDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.ResidenDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.ResidenDataGridView.DataSource = Me.ResidenBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(133, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(202, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Aldrich", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(157, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ResidenDataGridView.DefaultCellStyle = DataGridViewCellStyle2
        Me.ResidenDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.ResidenDataGridView.EnableHeadersVisualStyles = False
        Me.ResidenDataGridView.Location = New System.Drawing.Point(335, 12)
        Me.ResidenDataGridView.Name = "ResidenDataGridView"
        Me.ResidenDataGridView.RowHeadersVisible = False
        Me.ResidenDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ResidenDataGridView.Size = New System.Drawing.Size(337, 426)
        Me.ResidenDataGridView.TabIndex = 23
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Nama"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nama"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Nombor_KP"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Nombor kad Pengenalan"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Telefon"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Telefon"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Jawatan"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Jawatan"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Tarikh_Masuk"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Tarikh Masuk"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Tarikh_Keluar"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Tarikh Keluar"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Nama_Waris"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Nama Waris"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Telefon_Waris"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Telefon Waris"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(684, 450)
        Me.Controls.Add(Me.ResidenDataGridView)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ResidenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HostelSystemDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ResidenDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents HostelSystemDataSet As HostelSystemDataSet
    Friend WithEvents ResidenBindingSource As BindingSource
    Friend WithEvents ResidenTableAdapter As HostelSystemDataSetTableAdapters.ResidenTableAdapter
    Friend WithEvents TableAdapterManager As HostelSystemDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ResidenDataGridView As DataGridView
    Friend WithEvents Nombor_KPTextBox As TextBox
    Friend WithEvents NamaTextBox As TextBox
    Friend WithEvents TelefonTextBox As TextBox
    Friend WithEvents JawatanComboBox As ComboBox
    Friend WithEvents Tarikh_MasukDateTimePicker As DateTimePicker
    Friend WithEvents Tarikh_KeluarDateTimePicker As DateTimePicker
    Friend WithEvents Nama_WarisTextBox As TextBox
    Friend WithEvents Telefon_WarisTextBox As TextBox
    Friend WithEvents Button5 As Button
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
End Class
