<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Dim NamaLabel As System.Windows.Forms.Label
        Dim Nombor_KPLabel As System.Windows.Forms.Label
        Dim Maklumat_BayaranLabel As System.Windows.Forms.Label
        Dim Amaun_BayaranLabel As System.Windows.Forms.Label
        Dim Nombor_KPLabel2 As System.Windows.Forms.Label
        Dim Tarikh_BayaranLabel As System.Windows.Forms.Label
        Dim Ref_NumberLabel As System.Windows.Forms.Label
        Dim JawatanLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.HostelSystemDataSet = New HOSTEL_MANAGEMENT_SYSTEM_PEREMPUAN.HostelSystemDataSet()
        Me.ResidenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ResidenTableAdapter = New HOSTEL_MANAGEMENT_SYSTEM_PEREMPUAN.HostelSystemDataSetTableAdapters.ResidenTableAdapter()
        Me.TableAdapterManager = New HOSTEL_MANAGEMENT_SYSTEM_PEREMPUAN.HostelSystemDataSetTableAdapters.TableAdapterManager()
        Me.SewaTableAdapter = New HOSTEL_MANAGEMENT_SYSTEM_PEREMPUAN.HostelSystemDataSetTableAdapters.SewaTableAdapter()
        Me.ResidenDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SewaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SewaDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamaLabel1 = New System.Windows.Forms.Label()
        Me.Nombor_KPLabel1 = New System.Windows.Forms.Label()
        Me.Maklumat_BayaranComboBox = New System.Windows.Forms.ComboBox()
        Me.Amaun_BayaranTextBox = New System.Windows.Forms.TextBox()
        Me.Nombor_KPTextBox = New System.Windows.Forms.TextBox()
        Me.Tarikh_BayaranDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Ref_NumberTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.JawatanLabel1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        NamaLabel = New System.Windows.Forms.Label()
        Nombor_KPLabel = New System.Windows.Forms.Label()
        Maklumat_BayaranLabel = New System.Windows.Forms.Label()
        Amaun_BayaranLabel = New System.Windows.Forms.Label()
        Nombor_KPLabel2 = New System.Windows.Forms.Label()
        Tarikh_BayaranLabel = New System.Windows.Forms.Label()
        Ref_NumberLabel = New System.Windows.Forms.Label()
        JawatanLabel = New System.Windows.Forms.Label()
        CType(Me.HostelSystemDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ResidenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ResidenDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SewaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SewaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'NamaLabel
        '
        NamaLabel.AutoSize = True
        NamaLabel.Font = New System.Drawing.Font("Aldrich", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NamaLabel.Location = New System.Drawing.Point(45, 16)
        NamaLabel.Name = "NamaLabel"
        NamaLabel.Size = New System.Drawing.Size(48, 16)
        NamaLabel.TabIndex = 14
        NamaLabel.Text = "Nama:"
        '
        'Nombor_KPLabel
        '
        Nombor_KPLabel.AutoSize = True
        Nombor_KPLabel.Font = New System.Drawing.Font("Aldrich", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Nombor_KPLabel.Location = New System.Drawing.Point(8, 48)
        Nombor_KPLabel.Name = "Nombor_KPLabel"
        Nombor_KPLabel.Size = New System.Drawing.Size(85, 16)
        Nombor_KPLabel.TabIndex = 15
        Nombor_KPLabel.Text = "Nombor KP:"
        '
        'Maklumat_BayaranLabel
        '
        Maklumat_BayaranLabel.AutoSize = True
        Maklumat_BayaranLabel.Location = New System.Drawing.Point(8, 12)
        Maklumat_BayaranLabel.Name = "Maklumat_BayaranLabel"
        Maklumat_BayaranLabel.Size = New System.Drawing.Size(117, 15)
        Maklumat_BayaranLabel.TabIndex = 16
        Maklumat_BayaranLabel.Text = "Maklumat Bayaran:"
        '
        'Amaun_BayaranLabel
        '
        Amaun_BayaranLabel.AutoSize = True
        Amaun_BayaranLabel.Location = New System.Drawing.Point(8, 52)
        Amaun_BayaranLabel.Name = "Amaun_BayaranLabel"
        Amaun_BayaranLabel.Size = New System.Drawing.Size(100, 15)
        Amaun_BayaranLabel.TabIndex = 18
        Amaun_BayaranLabel.Text = "Amaun Bayaran:"
        '
        'Nombor_KPLabel2
        '
        Nombor_KPLabel2.AutoSize = True
        Nombor_KPLabel2.Location = New System.Drawing.Point(8, 89)
        Nombor_KPLabel2.Name = "Nombor_KPLabel2"
        Nombor_KPLabel2.Size = New System.Drawing.Size(75, 15)
        Nombor_KPLabel2.TabIndex = 20
        Nombor_KPLabel2.Text = "Nombor KP:"
        '
        'Tarikh_BayaranLabel
        '
        Tarikh_BayaranLabel.AutoSize = True
        Tarikh_BayaranLabel.Location = New System.Drawing.Point(8, 128)
        Tarikh_BayaranLabel.Name = "Tarikh_BayaranLabel"
        Tarikh_BayaranLabel.Size = New System.Drawing.Size(97, 15)
        Tarikh_BayaranLabel.TabIndex = 22
        Tarikh_BayaranLabel.Text = "Tarikh Bayaran:"
        '
        'Ref_NumberLabel
        '
        Ref_NumberLabel.AutoSize = True
        Ref_NumberLabel.Location = New System.Drawing.Point(8, 167)
        Ref_NumberLabel.Name = "Ref_NumberLabel"
        Ref_NumberLabel.Size = New System.Drawing.Size(79, 15)
        Ref_NumberLabel.TabIndex = 24
        Ref_NumberLabel.Text = "Ref Number:"
        '
        'JawatanLabel
        '
        JawatanLabel.AutoSize = True
        JawatanLabel.Font = New System.Drawing.Font("Aldrich", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        JawatanLabel.Location = New System.Drawing.Point(24, 82)
        JawatanLabel.Name = "JawatanLabel"
        JawatanLabel.Size = New System.Drawing.Size(69, 16)
        JawatanLabel.TabIndex = 16
        JawatanLabel.Text = "Jawatan:"
        '
        'Button4
        '
        Me.Button4.Enabled = False
        Me.Button4.Location = New System.Drawing.Point(266, 144)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 13
        Me.Button4.Text = "SAVE"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(266, 235)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 12
        Me.Button3.Text = "DELETE"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(189, 186)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "MODIFY"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(189, 144)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "ADD NEW"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'HostelSystemDataSet
        '
        Me.HostelSystemDataSet.DataSetName = "HostelSystemDataSet"
        Me.HostelSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ResidenBindingSource
        '
        Me.ResidenBindingSource.DataMember = "Residen"
        Me.ResidenBindingSource.DataSource = Me.HostelSystemDataSet
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
        Me.TableAdapterManager.SewaTableAdapter = Me.SewaTableAdapter
        Me.TableAdapterManager.UpdateOrder = HOSTEL_MANAGEMENT_SYSTEM_PEREMPUAN.HostelSystemDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'SewaTableAdapter
        '
        Me.SewaTableAdapter.ClearBeforeFill = True
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
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(162, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ResidenDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.ResidenDataGridView.ColumnHeadersHeight = 30
        Me.ResidenDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.ResidenDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn1})
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
        Me.ResidenDataGridView.Location = New System.Drawing.Point(12, 27)
        Me.ResidenDataGridView.Name = "ResidenDataGridView"
        Me.ResidenDataGridView.RowHeadersVisible = False
        Me.ResidenDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ResidenDataGridView.Size = New System.Drawing.Size(307, 118)
        Me.ResidenDataGridView.TabIndex = 14
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Nama"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nama"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Nombor_KP"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Nombor Kad Pengenalan"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'SewaBindingSource
        '
        Me.SewaBindingSource.DataMember = "Sewa"
        Me.SewaBindingSource.DataSource = Me.HostelSystemDataSet
        '
        'SewaDataGridView
        '
        Me.SewaDataGridView.AllowUserToAddRows = False
        Me.SewaDataGridView.AllowUserToDeleteRows = False
        Me.SewaDataGridView.AllowUserToResizeColumns = False
        Me.SewaDataGridView.AllowUserToResizeRows = False
        Me.SewaDataGridView.AutoGenerateColumns = False
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(162, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Aldrich", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(162, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.SewaDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.SewaDataGridView.ColumnHeadersHeight = 30
        Me.SewaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.SewaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13})
        Me.SewaDataGridView.DataSource = Me.SewaBindingSource
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(133, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(202, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Aldrich", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(157, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.SewaDataGridView.DefaultCellStyle = DataGridViewCellStyle4
        Me.SewaDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.SewaDataGridView.EnableHeadersVisualStyles = False
        Me.SewaDataGridView.Location = New System.Drawing.Point(12, 174)
        Me.SewaDataGridView.Name = "SewaDataGridView"
        Me.SewaDataGridView.RowHeadersVisible = False
        Me.SewaDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.SewaDataGridView.Size = New System.Drawing.Size(307, 264)
        Me.SewaDataGridView.TabIndex = 14
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Maklumat_Bayaran"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Maklumat Bayaran"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Amaun_Bayaran"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Amaun (RM)"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Nombor_KP"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Nombor Kad Pengenalan"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.Width = 173
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "Tarikh_Bayaran"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Tarikh Bayaran"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.Width = 119
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "Ref_Number"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Reference Number"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.Width = 142
        '
        'NamaLabel1
        '
        Me.NamaLabel1.AutoEllipsis = True
        Me.NamaLabel1.AutoSize = True
        Me.NamaLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ResidenBindingSource, "Nama", True))
        Me.NamaLabel1.Font = New System.Drawing.Font("Aldrich", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NamaLabel1.Location = New System.Drawing.Point(96, 16)
        Me.NamaLabel1.Name = "NamaLabel1"
        Me.NamaLabel1.Size = New System.Drawing.Size(47, 16)
        Me.NamaLabel1.TabIndex = 15
        Me.NamaLabel1.Text = "Label1"
        '
        'Nombor_KPLabel1
        '
        Me.Nombor_KPLabel1.AutoSize = True
        Me.Nombor_KPLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ResidenBindingSource, "Nombor_KP", True))
        Me.Nombor_KPLabel1.Font = New System.Drawing.Font("Aldrich", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nombor_KPLabel1.Location = New System.Drawing.Point(96, 48)
        Me.Nombor_KPLabel1.Name = "Nombor_KPLabel1"
        Me.Nombor_KPLabel1.Size = New System.Drawing.Size(47, 16)
        Me.Nombor_KPLabel1.TabIndex = 16
        Me.Nombor_KPLabel1.Text = "Label1"
        '
        'Maklumat_BayaranComboBox
        '
        Me.Maklumat_BayaranComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SewaBindingSource, "Maklumat_Bayaran", True))
        Me.Maklumat_BayaranComboBox.Enabled = False
        Me.Maklumat_BayaranComboBox.FormattingEnabled = True
        Me.Maklumat_BayaranComboBox.Items.AddRange(New Object() {"BAYARAN SEWA PENUH", "BAYARAN SEWA PERTAMA + PENDAFTARAN", "BAYARAN SEWA 11 - 20 HARIBULAN"})
        Me.Maklumat_BayaranComboBox.Location = New System.Drawing.Point(11, 28)
        Me.Maklumat_BayaranComboBox.Name = "Maklumat_BayaranComboBox"
        Me.Maklumat_BayaranComboBox.Size = New System.Drawing.Size(172, 23)
        Me.Maklumat_BayaranComboBox.TabIndex = 17
        '
        'Amaun_BayaranTextBox
        '
        Me.Amaun_BayaranTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SewaBindingSource, "Amaun_Bayaran", True))
        Me.Amaun_BayaranTextBox.Location = New System.Drawing.Point(11, 68)
        Me.Amaun_BayaranTextBox.Name = "Amaun_BayaranTextBox"
        Me.Amaun_BayaranTextBox.ReadOnly = True
        Me.Amaun_BayaranTextBox.Size = New System.Drawing.Size(172, 21)
        Me.Amaun_BayaranTextBox.TabIndex = 19
        '
        'Nombor_KPTextBox
        '
        Me.Nombor_KPTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SewaBindingSource, "Nombor_KP", True))
        Me.Nombor_KPTextBox.Location = New System.Drawing.Point(11, 105)
        Me.Nombor_KPTextBox.Name = "Nombor_KPTextBox"
        Me.Nombor_KPTextBox.ReadOnly = True
        Me.Nombor_KPTextBox.Size = New System.Drawing.Size(172, 21)
        Me.Nombor_KPTextBox.TabIndex = 21
        '
        'Tarikh_BayaranDateTimePicker
        '
        Me.Tarikh_BayaranDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.SewaBindingSource, "Tarikh_Bayaran", True))
        Me.Tarikh_BayaranDateTimePicker.Enabled = False
        Me.Tarikh_BayaranDateTimePicker.Location = New System.Drawing.Point(11, 144)
        Me.Tarikh_BayaranDateTimePicker.Name = "Tarikh_BayaranDateTimePicker"
        Me.Tarikh_BayaranDateTimePicker.Size = New System.Drawing.Size(172, 21)
        Me.Tarikh_BayaranDateTimePicker.TabIndex = 23
        '
        'Ref_NumberTextBox
        '
        Me.Ref_NumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SewaBindingSource, "Ref_Number", True))
        Me.Ref_NumberTextBox.Enabled = False
        Me.Ref_NumberTextBox.Location = New System.Drawing.Point(11, 184)
        Me.Ref_NumberTextBox.Name = "Ref_NumberTextBox"
        Me.Ref_NumberTextBox.Size = New System.Drawing.Size(172, 21)
        Me.Ref_NumberTextBox.TabIndex = 25
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.GroupBox1.Controls.Add(JawatanLabel)
        Me.GroupBox1.Controls.Add(Me.JawatanLabel1)
        Me.GroupBox1.Controls.Add(Me.Nombor_KPLabel1)
        Me.GroupBox1.Controls.Add(Me.NamaLabel1)
        Me.GroupBox1.Controls.Add(NamaLabel)
        Me.GroupBox1.Controls.Add(Nombor_KPLabel)
        Me.GroupBox1.Location = New System.Drawing.Point(325, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(347, 118)
        Me.GroupBox1.TabIndex = 26
        Me.GroupBox1.TabStop = False
        '
        'JawatanLabel1
        '
        Me.JawatanLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ResidenBindingSource, "Jawatan", True))
        Me.JawatanLabel1.Font = New System.Drawing.Font("Aldrich", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.JawatanLabel1.Location = New System.Drawing.Point(96, 82)
        Me.JawatanLabel1.Name = "JawatanLabel1"
        Me.JawatanLabel1.Size = New System.Drawing.Size(100, 23)
        Me.JawatanLabel1.TabIndex = 17
        Me.JawatanLabel1.Text = "Label1"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.Button5)
        Me.GroupBox2.Controls.Add(Me.Maklumat_BayaranComboBox)
        Me.GroupBox2.Controls.Add(Me.Ref_NumberTextBox)
        Me.GroupBox2.Controls.Add(Maklumat_BayaranLabel)
        Me.GroupBox2.Controls.Add(Ref_NumberLabel)
        Me.GroupBox2.Controls.Add(Me.Button4)
        Me.GroupBox2.Controls.Add(Me.Tarikh_BayaranDateTimePicker)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Controls.Add(Amaun_BayaranLabel)
        Me.GroupBox2.Controls.Add(Tarikh_BayaranLabel)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.Amaun_BayaranTextBox)
        Me.GroupBox2.Controls.Add(Me.Nombor_KPTextBox)
        Me.GroupBox2.Controls.Add(Nombor_KPLabel2)
        Me.GroupBox2.Font = New System.Drawing.Font("Aldrich", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(325, 174)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(347, 264)
        Me.GroupBox2.TabIndex = 27
        Me.GroupBox2.TabStop = False
        '
        'Button5
        '
        Me.Button5.Enabled = False
        Me.Button5.Location = New System.Drawing.Point(266, 186)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 26
        Me.Button5.Text = "UPDATE"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Aldrich", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 20)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "RESIDEN"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Aldrich", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 151)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 20)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "SEWA"
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(684, 450)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.SewaDataGridView)
        Me.Controls.Add(Me.ResidenDataGridView)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form4"
        Me.Text = "Form4"
        CType(Me.HostelSystemDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ResidenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ResidenDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SewaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SewaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents HostelSystemDataSet As HostelSystemDataSet
    Friend WithEvents ResidenBindingSource As BindingSource
    Friend WithEvents ResidenTableAdapter As HostelSystemDataSetTableAdapters.ResidenTableAdapter
    Friend WithEvents TableAdapterManager As HostelSystemDataSetTableAdapters.TableAdapterManager
    Friend WithEvents SewaTableAdapter As HostelSystemDataSetTableAdapters.SewaTableAdapter
    Friend WithEvents ResidenDataGridView As DataGridView
    Friend WithEvents SewaBindingSource As BindingSource
    Friend WithEvents SewaDataGridView As DataGridView
    Friend WithEvents NamaLabel1 As Label
    Friend WithEvents Nombor_KPLabel1 As Label
    Friend WithEvents Maklumat_BayaranComboBox As ComboBox
    Friend WithEvents Amaun_BayaranTextBox As TextBox
    Friend WithEvents Nombor_KPTextBox As TextBox
    Friend WithEvents Tarikh_BayaranDateTimePicker As DateTimePicker
    Friend WithEvents Ref_NumberTextBox As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents JawatanLabel1 As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
End Class
