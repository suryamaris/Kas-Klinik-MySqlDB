<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class rekap
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rekap))
        Me.KasBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.KasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.kasMasuk = New System.Windows.Forms.Button()
        Me.kembali = New System.Windows.Forms.Button()
        Me.cetak = New System.Windows.Forms.Button()
        Me.awal = New System.Windows.Forms.DateTimePicker()
        Me.akhir = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        CType(Me.KasBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'KasBindingSource
        '
        Me.KasBindingSource.DataMember = "kas"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Cambria", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(12, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 28)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Rekapitulasi"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Salmon
        Me.Button2.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(170, 365)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(133, 46)
        Me.Button2.TabIndex = 26
        Me.Button2.Text = "Kas Keluar"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'kasMasuk
        '
        Me.kasMasuk.BackColor = System.Drawing.Color.Salmon
        Me.kasMasuk.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kasMasuk.Location = New System.Drawing.Point(12, 365)
        Me.kasMasuk.Name = "kasMasuk"
        Me.kasMasuk.Size = New System.Drawing.Size(133, 46)
        Me.kasMasuk.TabIndex = 25
        Me.kasMasuk.Text = "Kas Masuk"
        Me.kasMasuk.UseVisualStyleBackColor = False
        '
        'kembali
        '
        Me.kembali.BackColor = System.Drawing.Color.Maroon
        Me.kembali.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kembali.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.kembali.Location = New System.Drawing.Point(693, 365)
        Me.kembali.Name = "kembali"
        Me.kembali.Size = New System.Drawing.Size(95, 46)
        Me.kembali.TabIndex = 27
        Me.kembali.Text = "Kembali"
        Me.kembali.UseVisualStyleBackColor = False
        '
        'cetak
        '
        Me.cetak.BackColor = System.Drawing.Color.Orange
        Me.cetak.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cetak.Location = New System.Drawing.Point(582, 365)
        Me.cetak.Name = "cetak"
        Me.cetak.Size = New System.Drawing.Size(95, 46)
        Me.cetak.TabIndex = 28
        Me.cetak.Text = "Cetak"
        Me.cetak.UseVisualStyleBackColor = False
        '
        'awal
        '
        Me.awal.Location = New System.Drawing.Point(408, 365)
        Me.awal.Name = "awal"
        Me.awal.Size = New System.Drawing.Size(168, 20)
        Me.awal.TabIndex = 30
        '
        'akhir
        '
        Me.akhir.Location = New System.Drawing.Point(408, 391)
        Me.akhir.Name = "akhir"
        Me.akhir.Size = New System.Drawing.Size(168, 20)
        Me.akhir.TabIndex = 31
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(331, 365)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 15)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Dari           :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(331, 391)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 15)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Sampai     :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label5.Font = New System.Drawing.Font("Myriad Arabic", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.Menu
        Me.Label5.Location = New System.Drawing.Point(509, -1)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(258, 70)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "Klinik Dr. Indra"
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(17, 72)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(771, 287)
        Me.CrystalReportViewer1.TabIndex = 35
        '
        'rekap
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.akhir)
        Me.Controls.Add(Me.awal)
        Me.Controls.Add(Me.cetak)
        Me.Controls.Add(Me.kembali)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.kasMasuk)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "rekap"
        Me.Text = "rekap"
        CType(Me.KasBindingSource1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.KasBindingSource,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents kasMasuk As Button
    Friend WithEvents kembali As Button
    Friend WithEvents cetak As Button

    Friend WithEvents KasBindingSource As BindingSource

    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TanggalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents JenisDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents KeteranganDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents JumlahDataGridViewTextBoxColumn As DataGridViewTextBoxColumn

    Friend WithEvents KasBindingSource1 As BindingSource
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents awal As DateTimePicker
    Friend WithEvents akhir As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class