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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.kiracimuhasebetarih = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kiracidanalinan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kiracidepozito = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kiracikomisyon = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kiracidanaidat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kiracitoplam = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DosyanoDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KlasornoDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KiracitcDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KiracimuhasebetarihDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KiracidanalinanDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KiracidepozitoDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KiracikomisyonDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KiracidanaidatDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KiracitoplamDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EvsahibitarihDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EvsahibineödenenDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EvsahibikesintiDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EvsahibidekontnoDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EvsahibitoplamDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.YonetimtarihDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.YonetimeodenenDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.YonetimbankaDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.YonetimbankanoDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.YonetimodemeyapankisiDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.YonetimtoplamDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MuhasebeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MülkbilgileriDataSet2 = New GÜRSOYEMLAK1.mülkbilgileriDataSet2()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Tarih2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EvSahibineÖdenen = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Kesinti = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KesintiTürü = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DekontNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Toplam2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DosyanoDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KlasornoDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KiracitcDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KiracimuhasebetarihDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KiracidanalinanDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KiracidepozitoDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KiracikomisyonDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KiracidanaidatDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KiracitoplamDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EvsahibitarihDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EvsahibineödenenDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EvsahibikesintiDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EvsahibidekontnoDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EvsahibitoplamDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.YonetimtarihDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.YonetimeodenenDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.YonetimbankaDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.YonetimbankanoDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.YonetimodemeyapankisiDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.YonetimtoplamDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.Tarih3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.YönetimeÖdenen = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Banka = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BankaNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ÖdemeYapanKişi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Toplam3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DosyanoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KlasornoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KiracitcDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KiracimuhasebetarihDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KiracidanalinanDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KiracidepozitoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KiracikomisyonDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KiracidanaidatDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KiracitoplamDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EvsahibitarihDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EvsahibineödenenDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EvsahibikesintiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EvsahibidekontnoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EvsahibitoplamDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.YonetimtarihDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.YonetimeodenenDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.YonetimbankaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.YonetimbankanoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.YonetimodemeyapankisiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.YonetimtoplamDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.arabtn = New System.Windows.Forms.Button()
        Me.guncellebtn = New System.Windows.Forms.Button()
        Me.arsivbtn = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.kiraciTc = New System.Windows.Forms.TextBox()
        Me.kiraciSoyad = New System.Windows.Forms.TextBox()
        Me.kiraciAd = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.MülkbilgileriDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MuhasebeTableAdapter = New GÜRSOYEMLAK1.mülkbilgileriDataSet2TableAdapters.MuhasebeTableAdapter()
        Me.TableAdapterManager = New GÜRSOYEMLAK1.mülkbilgileriDataSet2TableAdapters.TableAdapterManager()
        Me.MülkbilgileriDataSet = New GÜRSOYEMLAK1.mülkbilgileriDataSet()
        Me.temizleBtn = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MuhasebeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MülkbilgileriDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MülkbilgileriDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MülkbilgileriDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.kiracimuhasebetarih, Me.kiracidanalinan, Me.kiracidepozito, Me.kiracikomisyon, Me.kiracidanaidat, Me.kiracitoplam, Me.DosyanoDataGridViewTextBoxColumn2, Me.KlasornoDataGridViewTextBoxColumn2, Me.KiracitcDataGridViewTextBoxColumn2, Me.KiracimuhasebetarihDataGridViewTextBoxColumn2, Me.KiracidanalinanDataGridViewTextBoxColumn2, Me.KiracidepozitoDataGridViewTextBoxColumn2, Me.KiracikomisyonDataGridViewTextBoxColumn2, Me.KiracidanaidatDataGridViewTextBoxColumn2, Me.KiracitoplamDataGridViewTextBoxColumn2, Me.EvsahibitarihDataGridViewTextBoxColumn2, Me.EvsahibineödenenDataGridViewTextBoxColumn2, Me.EvsahibikesintiDataGridViewTextBoxColumn2, Me.EvsahibidekontnoDataGridViewTextBoxColumn2, Me.EvsahibitoplamDataGridViewTextBoxColumn2, Me.YonetimtarihDataGridViewTextBoxColumn2, Me.YonetimeodenenDataGridViewTextBoxColumn2, Me.YonetimbankaDataGridViewTextBoxColumn2, Me.YonetimbankanoDataGridViewTextBoxColumn2, Me.YonetimodemeyapankisiDataGridViewTextBoxColumn2, Me.YonetimtoplamDataGridViewTextBoxColumn2})
        Me.DataGridView1.DataSource = Me.MuhasebeBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(644, 173)
        Me.DataGridView1.TabIndex = 0
        '
        'kiracimuhasebetarih
        '
        Me.kiracimuhasebetarih.DataPropertyName = "kiracimuhasebetarih"
        Me.kiracimuhasebetarih.HeaderText = "Tarih"
        Me.kiracimuhasebetarih.Name = "kiracimuhasebetarih"
        '
        'kiracidanalinan
        '
        Me.kiracidanalinan.DataPropertyName = "kiracidanalinan"
        Me.kiracidanalinan.HeaderText = "Kiracıdan Alınan"
        Me.kiracidanalinan.Name = "kiracidanalinan"
        '
        'kiracidepozito
        '
        Me.kiracidepozito.DataPropertyName = "kiracidepozito"
        Me.kiracidepozito.HeaderText = "Depozito"
        Me.kiracidepozito.Name = "kiracidepozito"
        '
        'kiracikomisyon
        '
        Me.kiracikomisyon.DataPropertyName = "kiracikomisyon"
        Me.kiracikomisyon.HeaderText = "Komisyon"
        Me.kiracikomisyon.Name = "kiracikomisyon"
        '
        'kiracidanaidat
        '
        Me.kiracidanaidat.DataPropertyName = "kiracidanaidat"
        Me.kiracidanaidat.HeaderText = "Aidat"
        Me.kiracidanaidat.Name = "kiracidanaidat"
        '
        'kiracitoplam
        '
        Me.kiracitoplam.DataPropertyName = "kiracitoplam"
        Me.kiracitoplam.HeaderText = "Toplam"
        Me.kiracitoplam.Name = "kiracitoplam"
        '
        'DosyanoDataGridViewTextBoxColumn2
        '
        Me.DosyanoDataGridViewTextBoxColumn2.DataPropertyName = "dosyano"
        Me.DosyanoDataGridViewTextBoxColumn2.HeaderText = "dosyano"
        Me.DosyanoDataGridViewTextBoxColumn2.Name = "DosyanoDataGridViewTextBoxColumn2"
        '
        'KlasornoDataGridViewTextBoxColumn2
        '
        Me.KlasornoDataGridViewTextBoxColumn2.DataPropertyName = "klasorno"
        Me.KlasornoDataGridViewTextBoxColumn2.HeaderText = "klasorno"
        Me.KlasornoDataGridViewTextBoxColumn2.Name = "KlasornoDataGridViewTextBoxColumn2"
        '
        'KiracitcDataGridViewTextBoxColumn2
        '
        Me.KiracitcDataGridViewTextBoxColumn2.DataPropertyName = "kiracitc"
        Me.KiracitcDataGridViewTextBoxColumn2.HeaderText = "kiracitc"
        Me.KiracitcDataGridViewTextBoxColumn2.Name = "KiracitcDataGridViewTextBoxColumn2"
        '
        'KiracimuhasebetarihDataGridViewTextBoxColumn2
        '
        Me.KiracimuhasebetarihDataGridViewTextBoxColumn2.DataPropertyName = "kiracimuhasebetarih"
        Me.KiracimuhasebetarihDataGridViewTextBoxColumn2.HeaderText = "kiracimuhasebetarih"
        Me.KiracimuhasebetarihDataGridViewTextBoxColumn2.Name = "KiracimuhasebetarihDataGridViewTextBoxColumn2"
        '
        'KiracidanalinanDataGridViewTextBoxColumn2
        '
        Me.KiracidanalinanDataGridViewTextBoxColumn2.DataPropertyName = "kiracidanalinan"
        Me.KiracidanalinanDataGridViewTextBoxColumn2.HeaderText = "kiracidanalinan"
        Me.KiracidanalinanDataGridViewTextBoxColumn2.Name = "KiracidanalinanDataGridViewTextBoxColumn2"
        '
        'KiracidepozitoDataGridViewTextBoxColumn2
        '
        Me.KiracidepozitoDataGridViewTextBoxColumn2.DataPropertyName = "kiracidepozito"
        Me.KiracidepozitoDataGridViewTextBoxColumn2.HeaderText = "kiracidepozito"
        Me.KiracidepozitoDataGridViewTextBoxColumn2.Name = "KiracidepozitoDataGridViewTextBoxColumn2"
        '
        'KiracikomisyonDataGridViewTextBoxColumn2
        '
        Me.KiracikomisyonDataGridViewTextBoxColumn2.DataPropertyName = "kiracikomisyon"
        Me.KiracikomisyonDataGridViewTextBoxColumn2.HeaderText = "kiracikomisyon"
        Me.KiracikomisyonDataGridViewTextBoxColumn2.Name = "KiracikomisyonDataGridViewTextBoxColumn2"
        '
        'KiracidanaidatDataGridViewTextBoxColumn2
        '
        Me.KiracidanaidatDataGridViewTextBoxColumn2.DataPropertyName = "kiracidanaidat"
        Me.KiracidanaidatDataGridViewTextBoxColumn2.HeaderText = "kiracidanaidat"
        Me.KiracidanaidatDataGridViewTextBoxColumn2.Name = "KiracidanaidatDataGridViewTextBoxColumn2"
        '
        'KiracitoplamDataGridViewTextBoxColumn2
        '
        Me.KiracitoplamDataGridViewTextBoxColumn2.DataPropertyName = "kiracitoplam"
        Me.KiracitoplamDataGridViewTextBoxColumn2.HeaderText = "kiracitoplam"
        Me.KiracitoplamDataGridViewTextBoxColumn2.Name = "KiracitoplamDataGridViewTextBoxColumn2"
        '
        'EvsahibitarihDataGridViewTextBoxColumn2
        '
        Me.EvsahibitarihDataGridViewTextBoxColumn2.DataPropertyName = "evsahibitarih"
        Me.EvsahibitarihDataGridViewTextBoxColumn2.HeaderText = "evsahibitarih"
        Me.EvsahibitarihDataGridViewTextBoxColumn2.Name = "EvsahibitarihDataGridViewTextBoxColumn2"
        '
        'EvsahibineödenenDataGridViewTextBoxColumn2
        '
        Me.EvsahibineödenenDataGridViewTextBoxColumn2.DataPropertyName = "evsahibineödenen"
        Me.EvsahibineödenenDataGridViewTextBoxColumn2.HeaderText = "evsahibineödenen"
        Me.EvsahibineödenenDataGridViewTextBoxColumn2.Name = "EvsahibineödenenDataGridViewTextBoxColumn2"
        '
        'EvsahibikesintiDataGridViewTextBoxColumn2
        '
        Me.EvsahibikesintiDataGridViewTextBoxColumn2.DataPropertyName = "evsahibikesinti"
        Me.EvsahibikesintiDataGridViewTextBoxColumn2.HeaderText = "evsahibikesinti"
        Me.EvsahibikesintiDataGridViewTextBoxColumn2.Name = "EvsahibikesintiDataGridViewTextBoxColumn2"
        '
        'EvsahibidekontnoDataGridViewTextBoxColumn2
        '
        Me.EvsahibidekontnoDataGridViewTextBoxColumn2.DataPropertyName = "evsahibidekontno"
        Me.EvsahibidekontnoDataGridViewTextBoxColumn2.HeaderText = "evsahibidekontno"
        Me.EvsahibidekontnoDataGridViewTextBoxColumn2.Name = "EvsahibidekontnoDataGridViewTextBoxColumn2"
        '
        'EvsahibitoplamDataGridViewTextBoxColumn2
        '
        Me.EvsahibitoplamDataGridViewTextBoxColumn2.DataPropertyName = "evsahibitoplam"
        Me.EvsahibitoplamDataGridViewTextBoxColumn2.HeaderText = "evsahibitoplam"
        Me.EvsahibitoplamDataGridViewTextBoxColumn2.Name = "EvsahibitoplamDataGridViewTextBoxColumn2"
        '
        'YonetimtarihDataGridViewTextBoxColumn2
        '
        Me.YonetimtarihDataGridViewTextBoxColumn2.DataPropertyName = "yonetimtarih"
        Me.YonetimtarihDataGridViewTextBoxColumn2.HeaderText = "yonetimtarih"
        Me.YonetimtarihDataGridViewTextBoxColumn2.Name = "YonetimtarihDataGridViewTextBoxColumn2"
        '
        'YonetimeodenenDataGridViewTextBoxColumn2
        '
        Me.YonetimeodenenDataGridViewTextBoxColumn2.DataPropertyName = "yonetimeodenen"
        Me.YonetimeodenenDataGridViewTextBoxColumn2.HeaderText = "yonetimeodenen"
        Me.YonetimeodenenDataGridViewTextBoxColumn2.Name = "YonetimeodenenDataGridViewTextBoxColumn2"
        '
        'YonetimbankaDataGridViewTextBoxColumn2
        '
        Me.YonetimbankaDataGridViewTextBoxColumn2.DataPropertyName = "yonetimbanka"
        Me.YonetimbankaDataGridViewTextBoxColumn2.HeaderText = "yonetimbanka"
        Me.YonetimbankaDataGridViewTextBoxColumn2.Name = "YonetimbankaDataGridViewTextBoxColumn2"
        '
        'YonetimbankanoDataGridViewTextBoxColumn2
        '
        Me.YonetimbankanoDataGridViewTextBoxColumn2.DataPropertyName = "yonetimbankano"
        Me.YonetimbankanoDataGridViewTextBoxColumn2.HeaderText = "yonetimbankano"
        Me.YonetimbankanoDataGridViewTextBoxColumn2.Name = "YonetimbankanoDataGridViewTextBoxColumn2"
        '
        'YonetimodemeyapankisiDataGridViewTextBoxColumn2
        '
        Me.YonetimodemeyapankisiDataGridViewTextBoxColumn2.DataPropertyName = "yonetimodemeyapankisi"
        Me.YonetimodemeyapankisiDataGridViewTextBoxColumn2.HeaderText = "yonetimodemeyapankisi"
        Me.YonetimodemeyapankisiDataGridViewTextBoxColumn2.Name = "YonetimodemeyapankisiDataGridViewTextBoxColumn2"
        '
        'YonetimtoplamDataGridViewTextBoxColumn2
        '
        Me.YonetimtoplamDataGridViewTextBoxColumn2.DataPropertyName = "yonetimtoplam"
        Me.YonetimtoplamDataGridViewTextBoxColumn2.HeaderText = "yonetimtoplam"
        Me.YonetimtoplamDataGridViewTextBoxColumn2.Name = "YonetimtoplamDataGridViewTextBoxColumn2"
        '
        'MuhasebeBindingSource
        '
        Me.MuhasebeBindingSource.DataMember = "Muhasebe"
        Me.MuhasebeBindingSource.DataSource = Me.MülkbilgileriDataSet2
        '
        'MülkbilgileriDataSet2
        '
        Me.MülkbilgileriDataSet2.DataSetName = "mülkbilgileriDataSet2"
        Me.MülkbilgileriDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridView2
        '
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Tarih2, Me.EvSahibineÖdenen, Me.Kesinti, Me.KesintiTürü, Me.DekontNo, Me.Toplam2, Me.DosyanoDataGridViewTextBoxColumn1, Me.KlasornoDataGridViewTextBoxColumn1, Me.KiracitcDataGridViewTextBoxColumn1, Me.KiracimuhasebetarihDataGridViewTextBoxColumn1, Me.KiracidanalinanDataGridViewTextBoxColumn1, Me.KiracidepozitoDataGridViewTextBoxColumn1, Me.KiracikomisyonDataGridViewTextBoxColumn1, Me.KiracidanaidatDataGridViewTextBoxColumn1, Me.KiracitoplamDataGridViewTextBoxColumn1, Me.EvsahibitarihDataGridViewTextBoxColumn1, Me.EvsahibineödenenDataGridViewTextBoxColumn1, Me.EvsahibikesintiDataGridViewTextBoxColumn1, Me.EvsahibidekontnoDataGridViewTextBoxColumn1, Me.EvsahibitoplamDataGridViewTextBoxColumn1, Me.YonetimtarihDataGridViewTextBoxColumn1, Me.YonetimeodenenDataGridViewTextBoxColumn1, Me.YonetimbankaDataGridViewTextBoxColumn1, Me.YonetimbankanoDataGridViewTextBoxColumn1, Me.YonetimodemeyapankisiDataGridViewTextBoxColumn1, Me.YonetimtoplamDataGridViewTextBoxColumn1})
        Me.DataGridView2.DataSource = Me.MuhasebeBindingSource
        Me.DataGridView2.Location = New System.Drawing.Point(12, 203)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(643, 260)
        Me.DataGridView2.TabIndex = 1
        '
        'Tarih2
        '
        Me.Tarih2.DataPropertyName = "evsahibitarih"
        Me.Tarih2.HeaderText = "Tarih"
        Me.Tarih2.Name = "Tarih2"
        '
        'EvSahibineÖdenen
        '
        Me.EvSahibineÖdenen.DataPropertyName = "evsahibineödenen"
        Me.EvSahibineÖdenen.HeaderText = "Ev Sahibine Ödenen"
        Me.EvSahibineÖdenen.Name = "EvSahibineÖdenen"
        '
        'Kesinti
        '
        Me.Kesinti.DataPropertyName = "evsahibikesinti"
        Me.Kesinti.HeaderText = "Kesinti"
        Me.Kesinti.Name = "Kesinti"
        '
        'KesintiTürü
        '
        Me.KesintiTürü.HeaderText = "Kesinti Türü"
        Me.KesintiTürü.Name = "KesintiTürü"
        '
        'DekontNo
        '
        Me.DekontNo.DataPropertyName = "evsahibidekontno"
        Me.DekontNo.HeaderText = "Dekont No"
        Me.DekontNo.Name = "DekontNo"
        Me.DekontNo.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DekontNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Toplam2
        '
        Me.Toplam2.DataPropertyName = "evsahibitoplam"
        Me.Toplam2.HeaderText = "Toplam"
        Me.Toplam2.Name = "Toplam2"
        '
        'DosyanoDataGridViewTextBoxColumn1
        '
        Me.DosyanoDataGridViewTextBoxColumn1.DataPropertyName = "dosyano"
        Me.DosyanoDataGridViewTextBoxColumn1.HeaderText = "dosyano"
        Me.DosyanoDataGridViewTextBoxColumn1.Name = "DosyanoDataGridViewTextBoxColumn1"
        '
        'KlasornoDataGridViewTextBoxColumn1
        '
        Me.KlasornoDataGridViewTextBoxColumn1.DataPropertyName = "klasorno"
        Me.KlasornoDataGridViewTextBoxColumn1.HeaderText = "klasorno"
        Me.KlasornoDataGridViewTextBoxColumn1.Name = "KlasornoDataGridViewTextBoxColumn1"
        '
        'KiracitcDataGridViewTextBoxColumn1
        '
        Me.KiracitcDataGridViewTextBoxColumn1.DataPropertyName = "kiracitc"
        Me.KiracitcDataGridViewTextBoxColumn1.HeaderText = "kiracitc"
        Me.KiracitcDataGridViewTextBoxColumn1.Name = "KiracitcDataGridViewTextBoxColumn1"
        '
        'KiracimuhasebetarihDataGridViewTextBoxColumn1
        '
        Me.KiracimuhasebetarihDataGridViewTextBoxColumn1.DataPropertyName = "kiracimuhasebetarih"
        Me.KiracimuhasebetarihDataGridViewTextBoxColumn1.HeaderText = "kiracimuhasebetarih"
        Me.KiracimuhasebetarihDataGridViewTextBoxColumn1.Name = "KiracimuhasebetarihDataGridViewTextBoxColumn1"
        '
        'KiracidanalinanDataGridViewTextBoxColumn1
        '
        Me.KiracidanalinanDataGridViewTextBoxColumn1.DataPropertyName = "kiracidanalinan"
        Me.KiracidanalinanDataGridViewTextBoxColumn1.HeaderText = "kiracidanalinan"
        Me.KiracidanalinanDataGridViewTextBoxColumn1.Name = "KiracidanalinanDataGridViewTextBoxColumn1"
        '
        'KiracidepozitoDataGridViewTextBoxColumn1
        '
        Me.KiracidepozitoDataGridViewTextBoxColumn1.DataPropertyName = "kiracidepozito"
        Me.KiracidepozitoDataGridViewTextBoxColumn1.HeaderText = "kiracidepozito"
        Me.KiracidepozitoDataGridViewTextBoxColumn1.Name = "KiracidepozitoDataGridViewTextBoxColumn1"
        '
        'KiracikomisyonDataGridViewTextBoxColumn1
        '
        Me.KiracikomisyonDataGridViewTextBoxColumn1.DataPropertyName = "kiracikomisyon"
        Me.KiracikomisyonDataGridViewTextBoxColumn1.HeaderText = "kiracikomisyon"
        Me.KiracikomisyonDataGridViewTextBoxColumn1.Name = "KiracikomisyonDataGridViewTextBoxColumn1"
        '
        'KiracidanaidatDataGridViewTextBoxColumn1
        '
        Me.KiracidanaidatDataGridViewTextBoxColumn1.DataPropertyName = "kiracidanaidat"
        Me.KiracidanaidatDataGridViewTextBoxColumn1.HeaderText = "kiracidanaidat"
        Me.KiracidanaidatDataGridViewTextBoxColumn1.Name = "KiracidanaidatDataGridViewTextBoxColumn1"
        '
        'KiracitoplamDataGridViewTextBoxColumn1
        '
        Me.KiracitoplamDataGridViewTextBoxColumn1.DataPropertyName = "kiracitoplam"
        Me.KiracitoplamDataGridViewTextBoxColumn1.HeaderText = "kiracitoplam"
        Me.KiracitoplamDataGridViewTextBoxColumn1.Name = "KiracitoplamDataGridViewTextBoxColumn1"
        '
        'EvsahibitarihDataGridViewTextBoxColumn1
        '
        Me.EvsahibitarihDataGridViewTextBoxColumn1.DataPropertyName = "evsahibitarih"
        Me.EvsahibitarihDataGridViewTextBoxColumn1.HeaderText = "evsahibitarih"
        Me.EvsahibitarihDataGridViewTextBoxColumn1.Name = "EvsahibitarihDataGridViewTextBoxColumn1"
        '
        'EvsahibineödenenDataGridViewTextBoxColumn1
        '
        Me.EvsahibineödenenDataGridViewTextBoxColumn1.DataPropertyName = "evsahibineödenen"
        Me.EvsahibineödenenDataGridViewTextBoxColumn1.HeaderText = "evsahibineödenen"
        Me.EvsahibineödenenDataGridViewTextBoxColumn1.Name = "EvsahibineödenenDataGridViewTextBoxColumn1"
        '
        'EvsahibikesintiDataGridViewTextBoxColumn1
        '
        Me.EvsahibikesintiDataGridViewTextBoxColumn1.DataPropertyName = "evsahibikesinti"
        Me.EvsahibikesintiDataGridViewTextBoxColumn1.HeaderText = "evsahibikesinti"
        Me.EvsahibikesintiDataGridViewTextBoxColumn1.Name = "EvsahibikesintiDataGridViewTextBoxColumn1"
        '
        'EvsahibidekontnoDataGridViewTextBoxColumn1
        '
        Me.EvsahibidekontnoDataGridViewTextBoxColumn1.DataPropertyName = "evsahibidekontno"
        Me.EvsahibidekontnoDataGridViewTextBoxColumn1.HeaderText = "evsahibidekontno"
        Me.EvsahibidekontnoDataGridViewTextBoxColumn1.Name = "EvsahibidekontnoDataGridViewTextBoxColumn1"
        '
        'EvsahibitoplamDataGridViewTextBoxColumn1
        '
        Me.EvsahibitoplamDataGridViewTextBoxColumn1.DataPropertyName = "evsahibitoplam"
        Me.EvsahibitoplamDataGridViewTextBoxColumn1.HeaderText = "evsahibitoplam"
        Me.EvsahibitoplamDataGridViewTextBoxColumn1.Name = "EvsahibitoplamDataGridViewTextBoxColumn1"
        '
        'YonetimtarihDataGridViewTextBoxColumn1
        '
        Me.YonetimtarihDataGridViewTextBoxColumn1.DataPropertyName = "yonetimtarih"
        Me.YonetimtarihDataGridViewTextBoxColumn1.HeaderText = "yonetimtarih"
        Me.YonetimtarihDataGridViewTextBoxColumn1.Name = "YonetimtarihDataGridViewTextBoxColumn1"
        '
        'YonetimeodenenDataGridViewTextBoxColumn1
        '
        Me.YonetimeodenenDataGridViewTextBoxColumn1.DataPropertyName = "yonetimeodenen"
        Me.YonetimeodenenDataGridViewTextBoxColumn1.HeaderText = "yonetimeodenen"
        Me.YonetimeodenenDataGridViewTextBoxColumn1.Name = "YonetimeodenenDataGridViewTextBoxColumn1"
        '
        'YonetimbankaDataGridViewTextBoxColumn1
        '
        Me.YonetimbankaDataGridViewTextBoxColumn1.DataPropertyName = "yonetimbanka"
        Me.YonetimbankaDataGridViewTextBoxColumn1.HeaderText = "yonetimbanka"
        Me.YonetimbankaDataGridViewTextBoxColumn1.Name = "YonetimbankaDataGridViewTextBoxColumn1"
        '
        'YonetimbankanoDataGridViewTextBoxColumn1
        '
        Me.YonetimbankanoDataGridViewTextBoxColumn1.DataPropertyName = "yonetimbankano"
        Me.YonetimbankanoDataGridViewTextBoxColumn1.HeaderText = "yonetimbankano"
        Me.YonetimbankanoDataGridViewTextBoxColumn1.Name = "YonetimbankanoDataGridViewTextBoxColumn1"
        '
        'YonetimodemeyapankisiDataGridViewTextBoxColumn1
        '
        Me.YonetimodemeyapankisiDataGridViewTextBoxColumn1.DataPropertyName = "yonetimodemeyapankisi"
        Me.YonetimodemeyapankisiDataGridViewTextBoxColumn1.HeaderText = "yonetimodemeyapankisi"
        Me.YonetimodemeyapankisiDataGridViewTextBoxColumn1.Name = "YonetimodemeyapankisiDataGridViewTextBoxColumn1"
        '
        'YonetimtoplamDataGridViewTextBoxColumn1
        '
        Me.YonetimtoplamDataGridViewTextBoxColumn1.DataPropertyName = "yonetimtoplam"
        Me.YonetimtoplamDataGridViewTextBoxColumn1.HeaderText = "yonetimtoplam"
        Me.YonetimtoplamDataGridViewTextBoxColumn1.Name = "YonetimtoplamDataGridViewTextBoxColumn1"
        '
        'DataGridView3
        '
        Me.DataGridView3.AutoGenerateColumns = False
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Tarih3, Me.YönetimeÖdenen, Me.Banka, Me.BankaNo, Me.ÖdemeYapanKişi, Me.Toplam3, Me.DosyanoDataGridViewTextBoxColumn, Me.KlasornoDataGridViewTextBoxColumn, Me.KiracitcDataGridViewTextBoxColumn, Me.KiracimuhasebetarihDataGridViewTextBoxColumn, Me.KiracidanalinanDataGridViewTextBoxColumn, Me.KiracidepozitoDataGridViewTextBoxColumn, Me.KiracikomisyonDataGridViewTextBoxColumn, Me.KiracidanaidatDataGridViewTextBoxColumn, Me.KiracitoplamDataGridViewTextBoxColumn, Me.EvsahibitarihDataGridViewTextBoxColumn, Me.EvsahibineödenenDataGridViewTextBoxColumn, Me.EvsahibikesintiDataGridViewTextBoxColumn, Me.EvsahibidekontnoDataGridViewTextBoxColumn, Me.EvsahibitoplamDataGridViewTextBoxColumn, Me.YonetimtarihDataGridViewTextBoxColumn, Me.YonetimeodenenDataGridViewTextBoxColumn, Me.YonetimbankaDataGridViewTextBoxColumn, Me.YonetimbankanoDataGridViewTextBoxColumn, Me.YonetimodemeyapankisiDataGridViewTextBoxColumn, Me.YonetimtoplamDataGridViewTextBoxColumn})
        Me.DataGridView3.DataSource = Me.MuhasebeBindingSource
        Me.DataGridView3.Location = New System.Drawing.Point(12, 469)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.Size = New System.Drawing.Size(644, 260)
        Me.DataGridView3.TabIndex = 2
        '
        'Tarih3
        '
        Me.Tarih3.DataPropertyName = "yonetimtarih"
        Me.Tarih3.HeaderText = "Tarih"
        Me.Tarih3.Name = "Tarih3"
        '
        'YönetimeÖdenen
        '
        Me.YönetimeÖdenen.DataPropertyName = "yonetimeodenen"
        Me.YönetimeÖdenen.HeaderText = "Yönetime Ödenen"
        Me.YönetimeÖdenen.Name = "YönetimeÖdenen"
        '
        'Banka
        '
        Me.Banka.DataPropertyName = "yonetimbanka"
        Me.Banka.HeaderText = "Banka"
        Me.Banka.Name = "Banka"
        '
        'BankaNo
        '
        Me.BankaNo.DataPropertyName = "yonetimbankano"
        Me.BankaNo.HeaderText = "Banka No"
        Me.BankaNo.Name = "BankaNo"
        '
        'ÖdemeYapanKişi
        '
        Me.ÖdemeYapanKişi.DataPropertyName = "yonetimodemeyapankisi"
        Me.ÖdemeYapanKişi.HeaderText = "Ödeme Yapan Kişi"
        Me.ÖdemeYapanKişi.Name = "ÖdemeYapanKişi"
        '
        'Toplam3
        '
        Me.Toplam3.DataPropertyName = "yonetimtoplam"
        Me.Toplam3.HeaderText = "Toplam"
        Me.Toplam3.Name = "Toplam3"
        '
        'DosyanoDataGridViewTextBoxColumn
        '
        Me.DosyanoDataGridViewTextBoxColumn.DataPropertyName = "dosyano"
        Me.DosyanoDataGridViewTextBoxColumn.HeaderText = "dosyano"
        Me.DosyanoDataGridViewTextBoxColumn.Name = "DosyanoDataGridViewTextBoxColumn"
        '
        'KlasornoDataGridViewTextBoxColumn
        '
        Me.KlasornoDataGridViewTextBoxColumn.DataPropertyName = "klasorno"
        Me.KlasornoDataGridViewTextBoxColumn.HeaderText = "klasorno"
        Me.KlasornoDataGridViewTextBoxColumn.Name = "KlasornoDataGridViewTextBoxColumn"
        '
        'KiracitcDataGridViewTextBoxColumn
        '
        Me.KiracitcDataGridViewTextBoxColumn.DataPropertyName = "kiracitc"
        Me.KiracitcDataGridViewTextBoxColumn.HeaderText = "kiracitc"
        Me.KiracitcDataGridViewTextBoxColumn.Name = "KiracitcDataGridViewTextBoxColumn"
        '
        'KiracimuhasebetarihDataGridViewTextBoxColumn
        '
        Me.KiracimuhasebetarihDataGridViewTextBoxColumn.DataPropertyName = "kiracimuhasebetarih"
        Me.KiracimuhasebetarihDataGridViewTextBoxColumn.HeaderText = "kiracimuhasebetarih"
        Me.KiracimuhasebetarihDataGridViewTextBoxColumn.Name = "KiracimuhasebetarihDataGridViewTextBoxColumn"
        '
        'KiracidanalinanDataGridViewTextBoxColumn
        '
        Me.KiracidanalinanDataGridViewTextBoxColumn.DataPropertyName = "kiracidanalinan"
        Me.KiracidanalinanDataGridViewTextBoxColumn.HeaderText = "kiracidanalinan"
        Me.KiracidanalinanDataGridViewTextBoxColumn.Name = "KiracidanalinanDataGridViewTextBoxColumn"
        '
        'KiracidepozitoDataGridViewTextBoxColumn
        '
        Me.KiracidepozitoDataGridViewTextBoxColumn.DataPropertyName = "kiracidepozito"
        Me.KiracidepozitoDataGridViewTextBoxColumn.HeaderText = "kiracidepozito"
        Me.KiracidepozitoDataGridViewTextBoxColumn.Name = "KiracidepozitoDataGridViewTextBoxColumn"
        '
        'KiracikomisyonDataGridViewTextBoxColumn
        '
        Me.KiracikomisyonDataGridViewTextBoxColumn.DataPropertyName = "kiracikomisyon"
        Me.KiracikomisyonDataGridViewTextBoxColumn.HeaderText = "kiracikomisyon"
        Me.KiracikomisyonDataGridViewTextBoxColumn.Name = "KiracikomisyonDataGridViewTextBoxColumn"
        '
        'KiracidanaidatDataGridViewTextBoxColumn
        '
        Me.KiracidanaidatDataGridViewTextBoxColumn.DataPropertyName = "kiracidanaidat"
        Me.KiracidanaidatDataGridViewTextBoxColumn.HeaderText = "kiracidanaidat"
        Me.KiracidanaidatDataGridViewTextBoxColumn.Name = "KiracidanaidatDataGridViewTextBoxColumn"
        '
        'KiracitoplamDataGridViewTextBoxColumn
        '
        Me.KiracitoplamDataGridViewTextBoxColumn.DataPropertyName = "kiracitoplam"
        Me.KiracitoplamDataGridViewTextBoxColumn.HeaderText = "kiracitoplam"
        Me.KiracitoplamDataGridViewTextBoxColumn.Name = "KiracitoplamDataGridViewTextBoxColumn"
        '
        'EvsahibitarihDataGridViewTextBoxColumn
        '
        Me.EvsahibitarihDataGridViewTextBoxColumn.DataPropertyName = "evsahibitarih"
        Me.EvsahibitarihDataGridViewTextBoxColumn.HeaderText = "evsahibitarih"
        Me.EvsahibitarihDataGridViewTextBoxColumn.Name = "EvsahibitarihDataGridViewTextBoxColumn"
        '
        'EvsahibineödenenDataGridViewTextBoxColumn
        '
        Me.EvsahibineödenenDataGridViewTextBoxColumn.DataPropertyName = "evsahibineödenen"
        Me.EvsahibineödenenDataGridViewTextBoxColumn.HeaderText = "evsahibineödenen"
        Me.EvsahibineödenenDataGridViewTextBoxColumn.Name = "EvsahibineödenenDataGridViewTextBoxColumn"
        '
        'EvsahibikesintiDataGridViewTextBoxColumn
        '
        Me.EvsahibikesintiDataGridViewTextBoxColumn.DataPropertyName = "evsahibikesinti"
        Me.EvsahibikesintiDataGridViewTextBoxColumn.HeaderText = "evsahibikesinti"
        Me.EvsahibikesintiDataGridViewTextBoxColumn.Name = "EvsahibikesintiDataGridViewTextBoxColumn"
        '
        'EvsahibidekontnoDataGridViewTextBoxColumn
        '
        Me.EvsahibidekontnoDataGridViewTextBoxColumn.DataPropertyName = "evsahibidekontno"
        Me.EvsahibidekontnoDataGridViewTextBoxColumn.HeaderText = "evsahibidekontno"
        Me.EvsahibidekontnoDataGridViewTextBoxColumn.Name = "EvsahibidekontnoDataGridViewTextBoxColumn"
        '
        'EvsahibitoplamDataGridViewTextBoxColumn
        '
        Me.EvsahibitoplamDataGridViewTextBoxColumn.DataPropertyName = "evsahibitoplam"
        Me.EvsahibitoplamDataGridViewTextBoxColumn.HeaderText = "evsahibitoplam"
        Me.EvsahibitoplamDataGridViewTextBoxColumn.Name = "EvsahibitoplamDataGridViewTextBoxColumn"
        '
        'YonetimtarihDataGridViewTextBoxColumn
        '
        Me.YonetimtarihDataGridViewTextBoxColumn.DataPropertyName = "yonetimtarih"
        Me.YonetimtarihDataGridViewTextBoxColumn.HeaderText = "yonetimtarih"
        Me.YonetimtarihDataGridViewTextBoxColumn.Name = "YonetimtarihDataGridViewTextBoxColumn"
        '
        'YonetimeodenenDataGridViewTextBoxColumn
        '
        Me.YonetimeodenenDataGridViewTextBoxColumn.DataPropertyName = "yonetimeodenen"
        Me.YonetimeodenenDataGridViewTextBoxColumn.HeaderText = "yonetimeodenen"
        Me.YonetimeodenenDataGridViewTextBoxColumn.Name = "YonetimeodenenDataGridViewTextBoxColumn"
        '
        'YonetimbankaDataGridViewTextBoxColumn
        '
        Me.YonetimbankaDataGridViewTextBoxColumn.DataPropertyName = "yonetimbanka"
        Me.YonetimbankaDataGridViewTextBoxColumn.HeaderText = "yonetimbanka"
        Me.YonetimbankaDataGridViewTextBoxColumn.Name = "YonetimbankaDataGridViewTextBoxColumn"
        '
        'YonetimbankanoDataGridViewTextBoxColumn
        '
        Me.YonetimbankanoDataGridViewTextBoxColumn.DataPropertyName = "yonetimbankano"
        Me.YonetimbankanoDataGridViewTextBoxColumn.HeaderText = "yonetimbankano"
        Me.YonetimbankanoDataGridViewTextBoxColumn.Name = "YonetimbankanoDataGridViewTextBoxColumn"
        '
        'YonetimodemeyapankisiDataGridViewTextBoxColumn
        '
        Me.YonetimodemeyapankisiDataGridViewTextBoxColumn.DataPropertyName = "yonetimodemeyapankisi"
        Me.YonetimodemeyapankisiDataGridViewTextBoxColumn.HeaderText = "yonetimodemeyapankisi"
        Me.YonetimodemeyapankisiDataGridViewTextBoxColumn.Name = "YonetimodemeyapankisiDataGridViewTextBoxColumn"
        '
        'YonetimtoplamDataGridViewTextBoxColumn
        '
        Me.YonetimtoplamDataGridViewTextBoxColumn.DataPropertyName = "yonetimtoplam"
        Me.YonetimtoplamDataGridViewTextBoxColumn.HeaderText = "yonetimtoplam"
        Me.YonetimtoplamDataGridViewTextBoxColumn.Name = "YonetimtoplamDataGridViewTextBoxColumn"
        '
        'arabtn
        '
        Me.arabtn.Location = New System.Drawing.Point(688, 152)
        Me.arabtn.Name = "arabtn"
        Me.arabtn.Size = New System.Drawing.Size(75, 23)
        Me.arabtn.TabIndex = 8
        Me.arabtn.Text = "Ara"
        Me.arabtn.UseVisualStyleBackColor = True
        '
        'guncellebtn
        '
        Me.guncellebtn.Location = New System.Drawing.Point(769, 152)
        Me.guncellebtn.Name = "guncellebtn"
        Me.guncellebtn.Size = New System.Drawing.Size(75, 23)
        Me.guncellebtn.TabIndex = 9
        Me.guncellebtn.Text = "Güncelle"
        Me.guncellebtn.UseVisualStyleBackColor = True
        '
        'arsivbtn
        '
        Me.arsivbtn.Location = New System.Drawing.Point(689, 181)
        Me.arsivbtn.Name = "arsivbtn"
        Me.arsivbtn.Size = New System.Drawing.Size(75, 23)
        Me.arsivbtn.TabIndex = 11
        Me.arsivbtn.Text = "Arşive Aktar"
        Me.arsivbtn.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(685, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Kiracı Tc:"
        '
        'kiraciTc
        '
        Me.kiraciTc.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MuhasebeBindingSource, "kiracitc", True))
        Me.kiraciTc.Location = New System.Drawing.Point(743, 24)
        Me.kiraciTc.Name = "kiraciTc"
        Me.kiraciTc.Size = New System.Drawing.Size(100, 20)
        Me.kiraciTc.TabIndex = 13
        '
        'kiraciSoyad
        '
        Me.kiraciSoyad.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kiraciSoyad.Location = New System.Drawing.Point(743, 81)
        Me.kiraciSoyad.Name = "kiraciSoyad"
        Me.kiraciSoyad.Size = New System.Drawing.Size(100, 21)
        Me.kiraciSoyad.TabIndex = 18
        '
        'kiraciAd
        '
        Me.kiraciAd.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kiraciAd.Location = New System.Drawing.Point(743, 55)
        Me.kiraciAd.Name = "kiraciAd"
        Me.kiraciAd.Size = New System.Drawing.Size(100, 21)
        Me.kiraciAd.TabIndex = 17
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(685, 55)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(26, 15)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "Adı"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(686, 81)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(41, 15)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "Soyadı"
        '
        'MuhasebeTableAdapter
        '
        Me.MuhasebeTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.KullanıcıTableAdapter = Nothing
        Me.TableAdapterManager.MuhasebeTableAdapter = Me.MuhasebeTableAdapter
        Me.TableAdapterManager.tabloTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = GÜRSOYEMLAK1.mülkbilgileriDataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'MülkbilgileriDataSet
        '
        Me.MülkbilgileriDataSet.DataSetName = "mülkbilgileriDataSet"
        Me.MülkbilgileriDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'temizleBtn
        '
        Me.temizleBtn.Location = New System.Drawing.Point(771, 180)
        Me.temizleBtn.Name = "temizleBtn"
        Me.temizleBtn.Size = New System.Drawing.Size(75, 23)
        Me.temizleBtn.TabIndex = 19
        Me.temizleBtn.Text = "Temizle"
        Me.temizleBtn.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(863, 741)
        Me.Controls.Add(Me.temizleBtn)
        Me.Controls.Add(Me.kiraciSoyad)
        Me.Controls.Add(Me.kiraciAd)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.kiraciTc)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.arsivbtn)
        Me.Controls.Add(Me.guncellebtn)
        Me.Controls.Add(Me.arabtn)
        Me.Controls.Add(Me.DataGridView3)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form3"
        Me.Text = "Muhasebe"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MuhasebeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MülkbilgileriDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MülkbilgileriDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MülkbilgileriDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents DataGridView3 As DataGridView
    Friend WithEvents arabtn As Button
    Friend WithEvents guncellebtn As Button
    Friend WithEvents arsivbtn As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents kiraciTc As TextBox
    Friend WithEvents kiraciSoyad As TextBox
    Friend WithEvents kiraciAd As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents MülkbilgileriDataSetBindingSource As BindingSource
    Friend WithEvents MülkbilgileriDataSet2 As mülkbilgileriDataSet2
    Friend WithEvents MuhasebeBindingSource As BindingSource
    Friend WithEvents MuhasebeTableAdapter As mülkbilgileriDataSet2TableAdapters.MuhasebeTableAdapter
    Friend WithEvents TableAdapterManager As mülkbilgileriDataSet2TableAdapters.TableAdapterManager
    Friend WithEvents MülkbilgileriDataSet As mülkbilgileriDataSet
    Friend WithEvents kiracimuhasebetarih As DataGridViewTextBoxColumn
    Friend WithEvents kiracidanalinan As DataGridViewTextBoxColumn
    Friend WithEvents kiracidepozito As DataGridViewTextBoxColumn
    Friend WithEvents kiracikomisyon As DataGridViewTextBoxColumn
    Friend WithEvents kiracidanaidat As DataGridViewTextBoxColumn
    Friend WithEvents kiracitoplam As DataGridViewTextBoxColumn
    Friend WithEvents Tarih2 As DataGridViewTextBoxColumn
    Friend WithEvents EvSahibineÖdenen As DataGridViewTextBoxColumn
    Friend WithEvents Kesinti As DataGridViewTextBoxColumn
    Friend WithEvents KesintiTürü As DataGridViewTextBoxColumn
    Friend WithEvents DekontNo As DataGridViewTextBoxColumn
    Friend WithEvents Toplam2 As DataGridViewTextBoxColumn
    Friend WithEvents Tarih3 As DataGridViewTextBoxColumn
    Friend WithEvents YönetimeÖdenen As DataGridViewTextBoxColumn
    Friend WithEvents Banka As DataGridViewTextBoxColumn
    Friend WithEvents BankaNo As DataGridViewTextBoxColumn
    Friend WithEvents ÖdemeYapanKişi As DataGridViewTextBoxColumn
    Friend WithEvents Toplam3 As DataGridViewTextBoxColumn
    Friend WithEvents temizleBtn As Button
    Friend WithEvents DosyanoDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KlasornoDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KiracitcDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KiracimuhasebetarihDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KiracidanalinanDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KiracidepozitoDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KiracikomisyonDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KiracidanaidatDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KiracitoplamDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EvsahibitarihDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EvsahibineödenenDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EvsahibikesintiDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EvsahibidekontnoDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EvsahibitoplamDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents YonetimtarihDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents YonetimeodenenDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents YonetimbankaDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents YonetimbankanoDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents YonetimodemeyapankisiDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents YonetimtoplamDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DosyanoDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KlasornoDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KiracitcDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KiracimuhasebetarihDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KiracidanalinanDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KiracidepozitoDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KiracikomisyonDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KiracidanaidatDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KiracitoplamDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EvsahibitarihDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EvsahibineödenenDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EvsahibikesintiDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EvsahibidekontnoDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EvsahibitoplamDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents YonetimtarihDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents YonetimeodenenDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents YonetimbankaDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents YonetimbankanoDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents YonetimodemeyapankisiDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents YonetimtoplamDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DosyanoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KlasornoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KiracitcDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KiracimuhasebetarihDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KiracidanalinanDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KiracidepozitoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KiracikomisyonDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KiracidanaidatDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KiracitoplamDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EvsahibitarihDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EvsahibineödenenDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EvsahibikesintiDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EvsahibidekontnoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EvsahibitoplamDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents YonetimtarihDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents YonetimeodenenDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents YonetimbankaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents YonetimbankanoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents YonetimodemeyapankisiDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents YonetimtoplamDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
