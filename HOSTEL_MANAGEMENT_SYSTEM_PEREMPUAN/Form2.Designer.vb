<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Nombor_KPLabel1 = New System.Windows.Forms.Label()
        Me.ResidenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HostelSystemDataSet = New HOSTEL_MANAGEMENT_SYSTEM_PEREMPUAN.HostelSystemDataSet()
        Me.NamaLabel1 = New System.Windows.Forms.Label()
        Me.TelefonLabel1 = New System.Windows.Forms.Label()
        Me.JawatanLabel1 = New System.Windows.Forms.Label()
        Me.Tarikh_MasukLabel1 = New System.Windows.Forms.Label()
        Me.Tarikh_KeluarLabel1 = New System.Windows.Forms.Label()
        Me.Nama_WarisLabel1 = New System.Windows.Forms.Label()
        Me.Telefon_WarisLabel1 = New System.Windows.Forms.Label()
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
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.ResidenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HostelSystemDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ResidenDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Nombor_KPLabel
        '
        Nombor_KPLabel.AutoSize = True
        Nombor_KPLabel.Font = New System.Drawing.Font("Aldrich", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Nombor_KPLabel.Location = New System.Drawing.Point(12, 52)
        Nombor_KPLabel.Name = "Nombor_KPLabel"
        Nombor_KPLabel.Size = New System.Drawing.Size(79, 15)
        Nombor_KPLabel.TabIndex = 0
        Nombor_KPLabel.Text = "Nombor KP:"
        '
        'NamaLabel
        '
        NamaLabel.AutoSize = True
        NamaLabel.Font = New System.Drawing.Font("Aldrich", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NamaLabel.Location = New System.Drawing.Point(45, 21)
        NamaLabel.Name = "NamaLabel"
        NamaLabel.Size = New System.Drawing.Size(46, 15)
        NamaLabel.TabIndex = 2
        NamaLabel.Text = "Nama:"
        '
        'TelefonLabel
        '
        TelefonLabel.AutoSize = True
        TelefonLabel.Font = New System.Drawing.Font("Aldrich", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TelefonLabel.Location = New System.Drawing.Point(36, 83)
        TelefonLabel.Name = "TelefonLabel"
        TelefonLabel.Size = New System.Drawing.Size(55, 15)
        TelefonLabel.TabIndex = 4
        TelefonLabel.Text = "Telefon:"
        '
        'JawatanLabel
        '
        JawatanLabel.AutoSize = True
        JawatanLabel.Font = New System.Drawing.Font("Aldrich", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        JawatanLabel.Location = New System.Drawing.Point(28, 114)
        JawatanLabel.Name = "JawatanLabel"
        JawatanLabel.Size = New System.Drawing.Size(63, 15)
        JawatanLabel.TabIndex = 6
        JawatanLabel.Text = "Jawatan:"
        '
        'Tarikh_MasukLabel
        '
        Tarikh_MasukLabel.AutoSize = True
        Tarikh_MasukLabel.Font = New System.Drawing.Font("Aldrich", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Tarikh_MasukLabel.Location = New System.Drawing.Point(310, 21)
        Tarikh_MasukLabel.Name = "Tarikh_MasukLabel"
        Tarikh_MasukLabel.Size = New System.Drawing.Size(91, 15)
        Tarikh_MasukLabel.TabIndex = 8
        Tarikh_MasukLabel.Text = "Tarikh Masuk:"
        '
        'Tarikh_KeluarLabel
        '
        Tarikh_KeluarLabel.AutoSize = True
        Tarikh_KeluarLabel.Font = New System.Drawing.Font("Aldrich", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Tarikh_KeluarLabel.Location = New System.Drawing.Point(311, 52)
        Tarikh_KeluarLabel.Name = "Tarikh_KeluarLabel"
        Tarikh_KeluarLabel.Size = New System.Drawing.Size(90, 15)
        Tarikh_KeluarLabel.TabIndex = 10
        Tarikh_KeluarLabel.Text = "Tarikh Keluar:"
        '
        'Nama_WarisLabel
        '
        Nama_WarisLabel.AutoSize = True
        Nama_WarisLabel.Font = New System.Drawing.Font("Aldrich", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Nama_WarisLabel.Location = New System.Drawing.Point(316, 83)
        Nama_WarisLabel.Name = "Nama_WarisLabel"
        Nama_WarisLabel.Size = New System.Drawing.Size(85, 15)
        Nama_WarisLabel.TabIndex = 12
        Nama_WarisLabel.Text = "Nama Waris:"
        '
        'Telefon_WarisLabel
        '
        Telefon_WarisLabel.AutoSize = True
        Telefon_WarisLabel.Font = New System.Drawing.Font("Aldrich", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Telefon_WarisLabel.Location = New System.Drawing.Point(307, 114)
        Telefon_WarisLabel.Name = "Telefon_WarisLabel"
        Telefon_WarisLabel.Size = New System.Drawing.Size(94, 15)
        Telefon_WarisLabel.TabIndex = 14
        Telefon_WarisLabel.Text = "Telefon Waris:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 12)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(533, 20)
        Me.TextBox1.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.ComboBox1)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(684, 46)
        Me.Panel1.TabIndex = 1
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Intern", "Staff"})
        Me.ComboBox1.Location = New System.Drawing.Point(551, 11)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.Panel2.Controls.Add(Nombor_KPLabel)
        Me.Panel2.Controls.Add(Me.Nombor_KPLabel1)
        Me.Panel2.Controls.Add(NamaLabel)
        Me.Panel2.Controls.Add(Me.NamaLabel1)
        Me.Panel2.Controls.Add(TelefonLabel)
        Me.Panel2.Controls.Add(Me.TelefonLabel1)
        Me.Panel2.Controls.Add(JawatanLabel)
        Me.Panel2.Controls.Add(Me.JawatanLabel1)
        Me.Panel2.Controls.Add(Tarikh_MasukLabel)
        Me.Panel2.Controls.Add(Me.Tarikh_MasukLabel1)
        Me.Panel2.Controls.Add(Tarikh_KeluarLabel)
        Me.Panel2.Controls.Add(Me.Tarikh_KeluarLabel1)
        Me.Panel2.Controls.Add(Nama_WarisLabel)
        Me.Panel2.Controls.Add(Me.Nama_WarisLabel1)
        Me.Panel2.Controls.Add(Telefon_WarisLabel)
        Me.Panel2.Controls.Add(Me.Telefon_WarisLabel1)
        Me.Panel2.Location = New System.Drawing.Point(12, 46)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(660, 154)
        Me.Panel2.TabIndex = 2
        '
        'Nombor_KPLabel1
        '
        Me.Nombor_KPLabel1.AutoSize = True
        Me.Nombor_KPLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ResidenBindingSource, "Nombor_KP", True))
        Me.Nombor_KPLabel1.Font = New System.Drawing.Font("Aldrich", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nombor_KPLabel1.Location = New System.Drawing.Point(97, 52)
        Me.Nombor_KPLabel1.Name = "Nombor_KPLabel1"
        Me.Nombor_KPLabel1.Size = New System.Drawing.Size(42, 15)
        Me.Nombor_KPLabel1.TabIndex = 1
        Me.Nombor_KPLabel1.Text = "Label1"
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
        'NamaLabel1
        '
        Me.NamaLabel1.AutoSize = True
        Me.NamaLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ResidenBindingSource, "Nama", True))
        Me.NamaLabel1.Font = New System.Drawing.Font("Aldrich", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NamaLabel1.Location = New System.Drawing.Point(97, 21)
        Me.NamaLabel1.Name = "NamaLabel1"
        Me.NamaLabel1.Size = New System.Drawing.Size(42, 15)
        Me.NamaLabel1.TabIndex = 3
        Me.NamaLabel1.Text = "Label1"
        '
        'TelefonLabel1
        '
        Me.TelefonLabel1.AutoSize = True
        Me.TelefonLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ResidenBindingSource, "Telefon", True))
        Me.TelefonLabel1.Font = New System.Drawing.Font("Aldrich", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TelefonLabel1.Location = New System.Drawing.Point(97, 83)
        Me.TelefonLabel1.Name = "TelefonLabel1"
        Me.TelefonLabel1.Size = New System.Drawing.Size(42, 15)
        Me.TelefonLabel1.TabIndex = 5
        Me.TelefonLabel1.Text = "Label1"
        '
        'JawatanLabel1
        '
        Me.JawatanLabel1.AutoSize = True
        Me.JawatanLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ResidenBindingSource, "Jawatan", True))
        Me.JawatanLabel1.Font = New System.Drawing.Font("Aldrich", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.JawatanLabel1.Location = New System.Drawing.Point(97, 114)
        Me.JawatanLabel1.Name = "JawatanLabel1"
        Me.JawatanLabel1.Size = New System.Drawing.Size(42, 15)
        Me.JawatanLabel1.TabIndex = 7
        Me.JawatanLabel1.Text = "Label1"
        '
        'Tarikh_MasukLabel1
        '
        Me.Tarikh_MasukLabel1.AutoSize = True
        Me.Tarikh_MasukLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ResidenBindingSource, "Tarikh_Masuk", True))
        Me.Tarikh_MasukLabel1.Font = New System.Drawing.Font("Aldrich", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tarikh_MasukLabel1.Location = New System.Drawing.Point(407, 21)
        Me.Tarikh_MasukLabel1.Name = "Tarikh_MasukLabel1"
        Me.Tarikh_MasukLabel1.Size = New System.Drawing.Size(42, 15)
        Me.Tarikh_MasukLabel1.TabIndex = 9
        Me.Tarikh_MasukLabel1.Text = "Label1"
        '
        'Tarikh_KeluarLabel1
        '
        Me.Tarikh_KeluarLabel1.AutoSize = True
        Me.Tarikh_KeluarLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ResidenBindingSource, "Tarikh_Keluar", True))
        Me.Tarikh_KeluarLabel1.Font = New System.Drawing.Font("Aldrich", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tarikh_KeluarLabel1.Location = New System.Drawing.Point(407, 52)
        Me.Tarikh_KeluarLabel1.Name = "Tarikh_KeluarLabel1"
        Me.Tarikh_KeluarLabel1.Size = New System.Drawing.Size(42, 15)
        Me.Tarikh_KeluarLabel1.TabIndex = 11
        Me.Tarikh_KeluarLabel1.Text = "Label1"
        '
        'Nama_WarisLabel1
        '
        Me.Nama_WarisLabel1.AutoSize = True
        Me.Nama_WarisLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ResidenBindingSource, "Nama_Waris", True))
        Me.Nama_WarisLabel1.Font = New System.Drawing.Font("Aldrich", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nama_WarisLabel1.Location = New System.Drawing.Point(407, 83)
        Me.Nama_WarisLabel1.Name = "Nama_WarisLabel1"
        Me.Nama_WarisLabel1.Size = New System.Drawing.Size(42, 15)
        Me.Nama_WarisLabel1.TabIndex = 13
        Me.Nama_WarisLabel1.Text = "Label1"
        '
        'Telefon_WarisLabel1
        '
        Me.Telefon_WarisLabel1.AutoSize = True
        Me.Telefon_WarisLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ResidenBindingSource, "Telefon_Waris", True))
        Me.Telefon_WarisLabel1.Font = New System.Drawing.Font("Aldrich", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Telefon_WarisLabel1.Location = New System.Drawing.Point(407, 114)
        Me.Telefon_WarisLabel1.Name = "Telefon_WarisLabel1"
        Me.Telefon_WarisLabel1.Size = New System.Drawing.Size(42, 15)
        Me.Telefon_WarisLabel1.TabIndex = 15
        Me.Telefon_WarisLabel1.Text = "Label1"
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
        Me.ResidenDataGridView.AllowUserToDeleteRows = False
        Me.ResidenDataGridView.AllowUserToResizeColumns = False
        Me.ResidenDataGridView.AllowUserToResizeRows = False
        Me.ResidenDataGridView.AutoGenerateColumns = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(162, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Aldrich", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(162, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
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
        Me.ResidenDataGridView.Location = New System.Drawing.Point(12, 206)
        Me.ResidenDataGridView.Name = "ResidenDataGridView"
        Me.ResidenDataGridView.RowHeadersVisible = False
        Me.ResidenDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ResidenDataGridView.Size = New System.Drawing.Size(660, 220)
        Me.ResidenDataGridView.TabIndex = 3
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Nama"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nama"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 65
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Nombor_KP"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Nombor Kad Pengenalan"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 173
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Telefon"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Telefon"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 75
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Jawatan"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Jawatan"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 82
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Tarikh_Masuk"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Tarikh Masuk"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 107
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Tarikh_Keluar"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Tarikh Keluar"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 109
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Nama_Waris"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Nama Waris"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 101
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Telefon_Waris"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Telefon Waris"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Width = 111
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(684, 450)
        Me.Controls.Add(Me.ResidenDataGridView)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.ResidenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HostelSystemDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ResidenDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents HostelSystemDataSet As HostelSystemDataSet
    Friend WithEvents ResidenBindingSource As BindingSource
    Friend WithEvents ResidenTableAdapter As HostelSystemDataSetTableAdapters.ResidenTableAdapter
    Friend WithEvents TableAdapterManager As HostelSystemDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ResidenDataGridView As DataGridView
    Friend WithEvents Nombor_KPLabel1 As Label
    Friend WithEvents NamaLabel1 As Label
    Friend WithEvents TelefonLabel1 As Label
    Friend WithEvents JawatanLabel1 As Label
    Friend WithEvents Tarikh_MasukLabel1 As Label
    Friend WithEvents Tarikh_KeluarLabel1 As Label
    Friend WithEvents Nama_WarisLabel1 As Label
    Friend WithEvents Telefon_WarisLabel1 As Label
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
End Class
