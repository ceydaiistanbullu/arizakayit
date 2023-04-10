
namespace deneme
{
	partial class frmservis
	{
		/// <summary>
		///Gerekli tasarımcı değişkeni.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///Kullanılan tüm kaynakları temizleyin.
		/// </summary>
		///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer üretilen kod

		/// <summary>
		/// Tasarımcı desteği için gerekli metot - bu metodun 
		///içeriğini kod düzenleyici ile değiştirmeyin.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			this.datagrid_ariza = new System.Windows.Forms.DataGridView();
			this.urunIsmiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.seriNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.markaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.gidisTarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.departmanAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.yoneticiAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.telefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.durumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.teknikServisBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.dbAssetManagementtDataSet1 = new deneme.DbAssetManagementtDataSet1();
			this.btnsil = new System.Windows.Forms.Button();
			this.btnkayit = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.cmbYonetici = new System.Windows.Forms.ComboBox();
			this.cmbDepartman = new System.Windows.Forms.ComboBox();
			this.dtTarih = new System.Windows.Forms.DateTimePicker();
			this.lblGönderim = new System.Windows.Forms.Label();
			this.lbltel = new System.Windows.Forms.Label();
			this.txtTel = new System.Windows.Forms.TextBox();
			this.lblilgili_kisi = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.txtDurum = new System.Windows.Forms.TextBox();
			this.txtSeriNo = new System.Windows.Forms.TextBox();
			this.lblserino = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtModel = new System.Windows.Forms.TextBox();
			this.txtMarka = new System.Windows.Forms.TextBox();
			this.txtAd = new System.Windows.Forms.TextBox();
			this.teknikServisTableAdapter = new deneme.DbAssetManagementtDataSet1TableAdapters.TeknikServisTableAdapter();
			((System.ComponentModel.ISupportInitialize)(this.datagrid_ariza)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.teknikServisBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dbAssetManagementtDataSet1)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// datagrid_ariza
			// 
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(216)))), ((int)(((byte)(240)))));
			this.datagrid_ariza.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.datagrid_ariza.AutoGenerateColumns = false;
			this.datagrid_ariza.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
			this.datagrid_ariza.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.datagrid_ariza.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.InactiveCaption;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.datagrid_ariza.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.datagrid_ariza.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.datagrid_ariza.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.urunIsmiDataGridViewTextBoxColumn,
            this.seriNoDataGridViewTextBoxColumn,
            this.markaDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.gidisTarihDataGridViewTextBoxColumn,
            this.departmanAdDataGridViewTextBoxColumn,
            this.yoneticiAdDataGridViewTextBoxColumn,
            this.telefonDataGridViewTextBoxColumn,
            this.durumDataGridViewTextBoxColumn});
			this.datagrid_ariza.DataSource = this.teknikServisBindingSource;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.datagrid_ariza.DefaultCellStyle = dataGridViewCellStyle3;
			this.datagrid_ariza.Location = new System.Drawing.Point(12, 273);
			this.datagrid_ariza.Name = "datagrid_ariza";
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.datagrid_ariza.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.datagrid_ariza.RowHeadersVisible = false;
			this.datagrid_ariza.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.datagrid_ariza.Size = new System.Drawing.Size(914, 281);
			this.datagrid_ariza.TabIndex = 0;
			this.datagrid_ariza.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagrid_ariza_CellContentClick);
			// 
			// urunIsmiDataGridViewTextBoxColumn
			// 
			this.urunIsmiDataGridViewTextBoxColumn.DataPropertyName = "urunIsmi";
			this.urunIsmiDataGridViewTextBoxColumn.HeaderText = "urunIsmi";
			this.urunIsmiDataGridViewTextBoxColumn.Name = "urunIsmiDataGridViewTextBoxColumn";
			// 
			// seriNoDataGridViewTextBoxColumn
			// 
			this.seriNoDataGridViewTextBoxColumn.DataPropertyName = "seriNo";
			this.seriNoDataGridViewTextBoxColumn.HeaderText = "seriNo";
			this.seriNoDataGridViewTextBoxColumn.Name = "seriNoDataGridViewTextBoxColumn";
			// 
			// markaDataGridViewTextBoxColumn
			// 
			this.markaDataGridViewTextBoxColumn.DataPropertyName = "marka";
			this.markaDataGridViewTextBoxColumn.HeaderText = "marka";
			this.markaDataGridViewTextBoxColumn.Name = "markaDataGridViewTextBoxColumn";
			// 
			// modelDataGridViewTextBoxColumn
			// 
			this.modelDataGridViewTextBoxColumn.DataPropertyName = "model";
			this.modelDataGridViewTextBoxColumn.HeaderText = "model";
			this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
			// 
			// gidisTarihDataGridViewTextBoxColumn
			// 
			this.gidisTarihDataGridViewTextBoxColumn.DataPropertyName = "gidisTarih";
			this.gidisTarihDataGridViewTextBoxColumn.HeaderText = "gidisTarih";
			this.gidisTarihDataGridViewTextBoxColumn.Name = "gidisTarihDataGridViewTextBoxColumn";
			// 
			// departmanAdDataGridViewTextBoxColumn
			// 
			this.departmanAdDataGridViewTextBoxColumn.DataPropertyName = "departmanAd";
			this.departmanAdDataGridViewTextBoxColumn.HeaderText = "departmanAd";
			this.departmanAdDataGridViewTextBoxColumn.Name = "departmanAdDataGridViewTextBoxColumn";
			// 
			// yoneticiAdDataGridViewTextBoxColumn
			// 
			this.yoneticiAdDataGridViewTextBoxColumn.DataPropertyName = "yoneticiAd";
			this.yoneticiAdDataGridViewTextBoxColumn.HeaderText = "yoneticiAd";
			this.yoneticiAdDataGridViewTextBoxColumn.Name = "yoneticiAdDataGridViewTextBoxColumn";
			// 
			// telefonDataGridViewTextBoxColumn
			// 
			this.telefonDataGridViewTextBoxColumn.DataPropertyName = "telefon";
			this.telefonDataGridViewTextBoxColumn.HeaderText = "telefon";
			this.telefonDataGridViewTextBoxColumn.Name = "telefonDataGridViewTextBoxColumn";
			// 
			// durumDataGridViewTextBoxColumn
			// 
			this.durumDataGridViewTextBoxColumn.DataPropertyName = "durum";
			this.durumDataGridViewTextBoxColumn.HeaderText = "durum";
			this.durumDataGridViewTextBoxColumn.Name = "durumDataGridViewTextBoxColumn";
			// 
			// teknikServisBindingSource
			// 
			this.teknikServisBindingSource.DataMember = "TeknikServis";
			this.teknikServisBindingSource.DataSource = this.dbAssetManagementtDataSet1;
			// 
			// dbAssetManagementtDataSet1
			// 
			this.dbAssetManagementtDataSet1.DataSetName = "DbAssetManagementtDataSet1";
			this.dbAssetManagementtDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// btnsil
			// 
			this.btnsil.BackColor = System.Drawing.SystemColors.HighlightText;
			this.btnsil.Location = new System.Drawing.Point(113, 215);
			this.btnsil.Name = "btnsil";
			this.btnsil.Size = new System.Drawing.Size(78, 30);
			this.btnsil.TabIndex = 1;
			this.btnsil.Text = "Sil";
			this.btnsil.UseVisualStyleBackColor = false;
			this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
			// 
			// btnkayit
			// 
			this.btnkayit.BackColor = System.Drawing.SystemColors.HighlightText;
			this.btnkayit.Location = new System.Drawing.Point(210, 213);
			this.btnkayit.Name = "btnkayit";
			this.btnkayit.Size = new System.Drawing.Size(170, 32);
			this.btnkayit.TabIndex = 0;
			this.btnkayit.Text = "Yeni Kayıt Ekle/Güncelle";
			this.btnkayit.UseVisualStyleBackColor = false;
			this.btnkayit.Click += new System.EventHandler(this.btnkayit_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.cmbYonetici);
			this.groupBox2.Controls.Add(this.btnsil);
			this.groupBox2.Controls.Add(this.cmbDepartman);
			this.groupBox2.Controls.Add(this.dtTarih);
			this.groupBox2.Controls.Add(this.lblGönderim);
			this.groupBox2.Controls.Add(this.lbltel);
			this.groupBox2.Controls.Add(this.btnkayit);
			this.groupBox2.Controls.Add(this.txtTel);
			this.groupBox2.Controls.Add(this.lblilgili_kisi);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.txtDurum);
			this.groupBox2.Controls.Add(this.txtSeriNo);
			this.groupBox2.Controls.Add(this.lblserino);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Controls.Add(this.txtModel);
			this.groupBox2.Controls.Add(this.txtMarka);
			this.groupBox2.Controls.Add(this.txtAd);
			this.groupBox2.Location = new System.Drawing.Point(12, 20);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(399, 247);
			this.groupBox2.TabIndex = 2;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Ürün Bilgileri";
			// 
			// cmbYonetici
			// 
			this.cmbYonetici.FormattingEnabled = true;
			this.cmbYonetici.Location = new System.Drawing.Point(114, 44);
			this.cmbYonetici.Name = "cmbYonetici";
			this.cmbYonetici.Size = new System.Drawing.Size(100, 21);
			this.cmbYonetici.TabIndex = 4;
			// 
			// cmbDepartman
			// 
			this.cmbDepartman.FormattingEnabled = true;
			this.cmbDepartman.Location = new System.Drawing.Point(113, 14);
			this.cmbDepartman.Name = "cmbDepartman";
			this.cmbDepartman.Size = new System.Drawing.Size(101, 21);
			this.cmbDepartman.TabIndex = 4;
			this.cmbDepartman.SelectedIndexChanged += new System.EventHandler(this.cmbDepartman_SelectedIndexChanged);
			// 
			// dtTarih
			// 
			this.dtTarih.Location = new System.Drawing.Point(113, 127);
			this.dtTarih.Name = "dtTarih";
			this.dtTarih.Size = new System.Drawing.Size(200, 20);
			this.dtTarih.TabIndex = 18;
			// 
			// lblGönderim
			// 
			this.lblGönderim.AutoSize = true;
			this.lblGönderim.Location = new System.Drawing.Point(12, 127);
			this.lblGönderim.Name = "lblGönderim";
			this.lblGönderim.Size = new System.Drawing.Size(95, 13);
			this.lblGönderim.TabIndex = 16;
			this.lblGönderim.Text = "Gönderildiği Tarih :";
			// 
			// lbltel
			// 
			this.lbltel.AutoSize = true;
			this.lbltel.Location = new System.Drawing.Point(225, 79);
			this.lbltel.Name = "lbltel";
			this.lbltel.Size = new System.Drawing.Size(49, 13);
			this.lbltel.TabIndex = 15;
			this.lbltel.Text = "Telefon :";
			// 
			// txtTel
			// 
			this.txtTel.Location = new System.Drawing.Point(280, 74);
			this.txtTel.Name = "txtTel";
			this.txtTel.Size = new System.Drawing.Size(100, 20);
			this.txtTel.TabIndex = 14;
			// 
			// lblilgili_kisi
			// 
			this.lblilgili_kisi.AutoSize = true;
			this.lblilgili_kisi.Location = new System.Drawing.Point(57, 52);
			this.lblilgili_kisi.Name = "lblilgili_kisi";
			this.lblilgili_kisi.Size = new System.Drawing.Size(51, 13);
			this.lblilgili_kisi.TabIndex = 12;
			this.lblilgili_kisi.Text = "Yönetici: ";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(63, 153);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(44, 13);
			this.label6.TabIndex = 11;
			this.label6.Text = "Durum :";
			// 
			// txtDurum
			// 
			this.txtDurum.Location = new System.Drawing.Point(113, 153);
			this.txtDurum.Multiline = true;
			this.txtDurum.Name = "txtDurum";
			this.txtDurum.Size = new System.Drawing.Size(267, 54);
			this.txtDurum.TabIndex = 10;
			// 
			// txtSeriNo
			// 
			this.txtSeriNo.Location = new System.Drawing.Point(280, 49);
			this.txtSeriNo.Name = "txtSeriNo";
			this.txtSeriNo.Size = new System.Drawing.Size(100, 20);
			this.txtSeriNo.TabIndex = 9;
			// 
			// lblserino
			// 
			this.lblserino.AutoSize = true;
			this.lblserino.Location = new System.Drawing.Point(226, 52);
			this.lblserino.Name = "lblserino";
			this.lblserino.Size = new System.Drawing.Size(48, 13);
			this.lblserino.TabIndex = 8;
			this.lblserino.Text = "Seri No :";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(65, 103);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(42, 13);
			this.label4.TabIndex = 7;
			this.label4.Text = "Model :";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(63, 79);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(43, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "Marka :";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(220, 22);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(54, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "Ürün Adı :";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(25, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(83, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "Departman Adı :";
			// 
			// txtModel
			// 
			this.txtModel.Location = new System.Drawing.Point(114, 100);
			this.txtModel.Name = "txtModel";
			this.txtModel.Size = new System.Drawing.Size(266, 20);
			this.txtModel.TabIndex = 3;
			// 
			// txtMarka
			// 
			this.txtMarka.Location = new System.Drawing.Point(114, 72);
			this.txtMarka.Name = "txtMarka";
			this.txtMarka.Size = new System.Drawing.Size(100, 20);
			this.txtMarka.TabIndex = 2;
			// 
			// txtAd
			// 
			this.txtAd.Location = new System.Drawing.Point(280, 19);
			this.txtAd.Name = "txtAd";
			this.txtAd.Size = new System.Drawing.Size(100, 20);
			this.txtAd.TabIndex = 1;
			// 
			// teknikServisTableAdapter
			// 
			this.teknikServisTableAdapter.ClearBeforeFill = true;
			// 
			// frmservis
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(928, 674);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.datagrid_ariza);
			this.Name = "frmservis";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Servis Kaydı";
			this.Load += new System.EventHandler(this.frmservis_Load);
			((System.ComponentModel.ISupportInitialize)(this.datagrid_ariza)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.teknikServisBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dbAssetManagementtDataSet1)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView datagrid_ariza;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtModel;
		private System.Windows.Forms.TextBox txtMarka;
		private System.Windows.Forms.TextBox txtAd;
		private System.Windows.Forms.TextBox txtSeriNo;
		private System.Windows.Forms.Label lblserino;
		private System.Windows.Forms.Button btnsil;
		private System.Windows.Forms.Button btnkayit;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtDurum;
		private System.Windows.Forms.Label lblilgili_kisi;
		private System.Windows.Forms.Label lblGönderim;
		private System.Windows.Forms.Label lbltel;
		private System.Windows.Forms.TextBox txtTel;
		private System.Windows.Forms.DateTimePicker dtTarih;
		private System.Windows.Forms.ComboBox cmbDepartman;
		private System.Windows.Forms.ComboBox cmbYonetici;
		private DbAssetManagementtDataSet1 dbAssetManagementtDataSet1;
		private System.Windows.Forms.BindingSource teknikServisBindingSource;
		private DbAssetManagementtDataSet1TableAdapters.TeknikServisTableAdapter teknikServisTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn urunIsmiDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn seriNoDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn markaDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn gidisTarihDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn departmanAdDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn yoneticiAdDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn durumDataGridViewTextBoxColumn;
	}
}

