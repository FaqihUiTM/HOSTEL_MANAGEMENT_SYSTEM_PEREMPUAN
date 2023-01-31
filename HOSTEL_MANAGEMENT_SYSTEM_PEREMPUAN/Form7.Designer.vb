<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form7
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.HostelSystemDataSet = New HOSTEL_MANAGEMENT_SYSTEM_PEREMPUAN.HostelSystemDataSet()
        Me.SewaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SewaTableAdapter = New HOSTEL_MANAGEMENT_SYSTEM_PEREMPUAN.HostelSystemDataSetTableAdapters.SewaTableAdapter()
        Me.TableAdapterManager = New HOSTEL_MANAGEMENT_SYSTEM_PEREMPUAN.HostelSystemDataSetTableAdapters.TableAdapterManager()
        Me.Bil_SelenggaraanTableAdapter = New HOSTEL_MANAGEMENT_SYSTEM_PEREMPUAN.HostelSystemDataSetTableAdapters.Bil_SelenggaraanTableAdapter()
        Me.SewaDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Bil_SelenggaraanBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Bil_SelenggaraanDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.HostelSystemDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SewaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SewaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bil_SelenggaraanBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bil_SelenggaraanDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"JANUARI", "FEBRUARI", "MAC", "APRIL", "MEI", "JUN", "JULAI", "OGOS", "SEPTEMBER", "OKTOBER", "NOVEMBER", "DISEMBER"})
        Me.ComboBox1.Location = New System.Drawing.Point(104, 21)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(146, 21)
        Me.ComboBox1.TabIndex = 0
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"2022", "2023", "2024"})
        Me.ComboBox2.Location = New System.Drawing.Point(347, 22)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(139, 21)
        Me.ComboBox2.TabIndex = 1
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(20, 45)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(230, 20)
        Me.TextBox1.TabIndex = 2
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(256, 45)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(230, 20)
        Me.TextBox2.TabIndex = 3
        '
        'HostelSystemDataSet
        '
        Me.HostelSystemDataSet.DataSetName = "HostelSystemDataSet"
        Me.HostelSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SewaBindingSource
        '
        Me.SewaBindingSource.DataMember = "Sewa"
        Me.SewaBindingSource.DataSource = Me.HostelSystemDataSet
        '
        'SewaTableAdapter
        '
        Me.SewaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Bil_SelenggaraanTableAdapter = Me.Bil_SelenggaraanTableAdapter
        Me.TableAdapterManager.ResidenTableAdapter = Nothing
        Me.TableAdapterManager.SewaTableAdapter = Me.SewaTableAdapter
        Me.TableAdapterManager.UpdateOrder = HOSTEL_MANAGEMENT_SYSTEM_PEREMPUAN.HostelSystemDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Bil_SelenggaraanTableAdapter
        '
        Me.Bil_SelenggaraanTableAdapter.ClearBeforeFill = True
        '
        'SewaDataGridView
        '
        Me.SewaDataGridView.AllowUserToAddRows = False
        Me.SewaDataGridView.AllowUserToDeleteRows = False
        Me.SewaDataGridView.AllowUserToResizeColumns = False
        Me.SewaDataGridView.AllowUserToResizeRows = False
        Me.SewaDataGridView.AutoGenerateColumns = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(162, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Aldrich", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(162, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.SewaDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.SewaDataGridView.ColumnHeadersHeight = 30
        Me.SewaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.SewaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.SewaDataGridView.DataSource = Me.SewaBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(133, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(202, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Aldrich", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(157, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.SewaDataGridView.DefaultCellStyle = DataGridViewCellStyle2
        Me.SewaDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.SewaDataGridView.EnableHeadersVisualStyles = False
        Me.SewaDataGridView.Location = New System.Drawing.Point(20, 92)
        Me.SewaDataGridView.Name = "SewaDataGridView"
        Me.SewaDataGridView.RowHeadersVisible = False
        Me.SewaDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.SewaDataGridView.Size = New System.Drawing.Size(628, 142)
        Me.SewaDataGridView.TabIndex = 5
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
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Amaun_Bayaran"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Amaun (RM)"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Tarikh_Bayaran"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Tarikh Bayaran"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 119
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Ref_Number"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Reference Number"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 142
        '
        'Bil_SelenggaraanBindingSource
        '
        Me.Bil_SelenggaraanBindingSource.DataMember = "Bil_Selenggaraan"
        Me.Bil_SelenggaraanBindingSource.DataSource = Me.HostelSystemDataSet
        '
        'Bil_SelenggaraanDataGridView
        '
        Me.Bil_SelenggaraanDataGridView.AllowUserToAddRows = False
        Me.Bil_SelenggaraanDataGridView.AllowUserToDeleteRows = False
        Me.Bil_SelenggaraanDataGridView.AllowUserToResizeColumns = False
        Me.Bil_SelenggaraanDataGridView.AllowUserToResizeRows = False
        Me.Bil_SelenggaraanDataGridView.AutoGenerateColumns = False
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(162, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Aldrich", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(162, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Bil_SelenggaraanDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.Bil_SelenggaraanDataGridView.ColumnHeadersHeight = 30
        Me.Bil_SelenggaraanDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.Bil_SelenggaraanDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9})
        Me.Bil_SelenggaraanDataGridView.DataSource = Me.Bil_SelenggaraanBindingSource
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(133, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(202, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Aldrich", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(157, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Bil_SelenggaraanDataGridView.DefaultCellStyle = DataGridViewCellStyle4
        Me.Bil_SelenggaraanDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.Bil_SelenggaraanDataGridView.EnableHeadersVisualStyles = False
        Me.Bil_SelenggaraanDataGridView.Location = New System.Drawing.Point(20, 262)
        Me.Bil_SelenggaraanDataGridView.Name = "Bil_SelenggaraanDataGridView"
        Me.Bil_SelenggaraanDataGridView.RowHeadersVisible = False
        Me.Bil_SelenggaraanDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Bil_SelenggaraanDataGridView.Size = New System.Drawing.Size(628, 163)
        Me.Bil_SelenggaraanDataGridView.TabIndex = 5
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Maklumat_Bayaran"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Maklumat Bayaran"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Amaun_Bayaran"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Amaun(RM)"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 97
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Tarikh_Bayaran"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Tarikh Bayaran"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Width = 119
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Ref_Number"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Reference Number"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Width = 142
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(492, 24)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 41)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "FILTER"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(573, 22)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 44)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "PRINT"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Aldrich", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 20)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "BULAN :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Aldrich", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(256, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 20)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "TAHUN :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Aldrich", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(122, 20)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "DUIT MASUK"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Aldrich", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 239)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(129, 20)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "DUIT KELUAR"
        '
        'Form7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(684, 450)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Bil_SelenggaraanDataGridView)
        Me.Controls.Add(Me.SewaDataGridView)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form7"
        Me.Text = "Form7"
        CType(Me.HostelSystemDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SewaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SewaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bil_SelenggaraanBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bil_SelenggaraanDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents HostelSystemDataSet As HostelSystemDataSet
    Friend WithEvents SewaBindingSource As BindingSource
    Friend WithEvents SewaTableAdapter As HostelSystemDataSetTableAdapters.SewaTableAdapter
    Friend WithEvents TableAdapterManager As HostelSystemDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Bil_SelenggaraanTableAdapter As HostelSystemDataSetTableAdapters.Bil_SelenggaraanTableAdapter
    Friend WithEvents SewaDataGridView As DataGridView
    Friend WithEvents Bil_SelenggaraanBindingSource As BindingSource
    Friend WithEvents Bil_SelenggaraanDataGridView As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
End Class
