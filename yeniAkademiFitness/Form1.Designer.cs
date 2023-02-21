namespace yeniAkademiFitness
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.lblId = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.lblTckn = new System.Windows.Forms.Label();
            this.lblKayitTarih = new System.Windows.Forms.Label();
            this.lblBitisTarih = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtTCKN = new System.Windows.Forms.TextBox();
            this.dtpKayitTarih = new System.Windows.Forms.DateTimePicker();
            this.dtpBitisTarih = new System.Windows.Forms.DateTimePicker();
            this.txtArama = new System.Windows.Forms.TextBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.lblKalanGun = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cBoxUyelikTipi = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.txtBorcDurumu = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 116F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(212)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(212)))));
            this.dataGridView1.Location = new System.Drawing.Point(3, 119);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Size = new System.Drawing.Size(794, 328);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.TabStop = false;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(212)))));
            this.tableLayoutPanel2.ColumnCount = 9;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel2.Controls.Add(this.btnKaydet, 8, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblId, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblAd, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblSoyad, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblTel, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblTckn, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblKayitTarih, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblBitisTarih, 6, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtID, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtAd, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtSoyad, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtTel, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtTCKN, 4, 1);
            this.tableLayoutPanel2.Controls.Add(this.dtpKayitTarih, 5, 1);
            this.tableLayoutPanel2.Controls.Add(this.dtpBitisTarih, 6, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtArama, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.btnAra, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblKalanGun, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.label1, 7, 0);
            this.tableLayoutPanel2.Controls.Add(this.cBoxUyelikTipi, 7, 1);
            this.tableLayoutPanel2.Controls.Add(this.label2, 8, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnGuncelle, 7, 2);
            this.tableLayoutPanel2.Controls.Add(this.btnSil, 6, 2);
            this.tableLayoutPanel2.Controls.Add(this.btnTemizle, 5, 2);
            this.tableLayoutPanel2.Controls.Add(this.txtBorcDurumu, 8, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Font = new System.Drawing.Font("Calibri", 8.25F);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(794, 110);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnKaydet.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Location = new System.Drawing.Point(716, 75);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 32);
            this.btnKaydet.TabIndex = 13;
            this.btnKaydet.TabStop = false;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblId.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblId.Location = new System.Drawing.Point(3, 18);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(82, 18);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "üye ID";
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblAd.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblAd.Location = new System.Drawing.Point(91, 18);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(82, 18);
            this.lblAd.TabIndex = 0;
            this.lblAd.Text = "Üye Ad";
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblSoyad.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblSoyad.Location = new System.Drawing.Point(179, 18);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(82, 18);
            this.lblSoyad.TabIndex = 0;
            this.lblSoyad.Text = "Üye Soyad";
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblTel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblTel.Location = new System.Drawing.Point(267, 0);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(82, 36);
            this.lblTel.TabIndex = 0;
            this.lblTel.Text = "Üye Telefon";
            // 
            // lblTckn
            // 
            this.lblTckn.AutoSize = true;
            this.lblTckn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblTckn.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblTckn.Location = new System.Drawing.Point(355, 18);
            this.lblTckn.Name = "lblTckn";
            this.lblTckn.Size = new System.Drawing.Size(82, 18);
            this.lblTckn.TabIndex = 0;
            this.lblTckn.Text = "Üye TCKN";
            // 
            // lblKayitTarih
            // 
            this.lblKayitTarih.AutoSize = true;
            this.lblKayitTarih.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblKayitTarih.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblKayitTarih.Location = new System.Drawing.Point(443, 18);
            this.lblKayitTarih.Name = "lblKayitTarih";
            this.lblKayitTarih.Size = new System.Drawing.Size(82, 18);
            this.lblKayitTarih.TabIndex = 0;
            this.lblKayitTarih.Text = "Kayıt Tarih";
            // 
            // lblBitisTarih
            // 
            this.lblBitisTarih.AutoSize = true;
            this.lblBitisTarih.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblBitisTarih.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblBitisTarih.Location = new System.Drawing.Point(531, 18);
            this.lblBitisTarih.Name = "lblBitisTarih";
            this.lblBitisTarih.Size = new System.Drawing.Size(82, 18);
            this.lblBitisTarih.TabIndex = 0;
            this.lblBitisTarih.Text = "Bitiş Tarih";
            // 
            // txtID
            // 
            this.txtID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtID.Enabled = false;
            this.txtID.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtID.Location = new System.Drawing.Point(3, 39);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(82, 26);
            this.txtID.TabIndex = 1;
            // 
            // txtAd
            // 
            this.txtAd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAd.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAd.Location = new System.Drawing.Point(91, 39);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(82, 26);
            this.txtAd.TabIndex = 1;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSoyad.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSoyad.Location = new System.Drawing.Point(179, 39);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(82, 26);
            this.txtSoyad.TabIndex = 1;
            // 
            // txtTel
            // 
            this.txtTel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTel.Location = new System.Drawing.Point(267, 39);
            this.txtTel.MaxLength = 11;
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(82, 26);
            this.txtTel.TabIndex = 1;
            // 
            // txtTCKN
            // 
            this.txtTCKN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTCKN.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTCKN.Location = new System.Drawing.Point(355, 39);
            this.txtTCKN.MaxLength = 11;
            this.txtTCKN.Name = "txtTCKN";
            this.txtTCKN.Size = new System.Drawing.Size(82, 26);
            this.txtTCKN.TabIndex = 1;
            // 
            // dtpKayitTarih
            // 
            this.dtpKayitTarih.CalendarFont = new System.Drawing.Font("Calibri", 18F);
            this.dtpKayitTarih.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpKayitTarih.Enabled = false;
            this.dtpKayitTarih.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpKayitTarih.Location = new System.Drawing.Point(443, 39);
            this.dtpKayitTarih.Name = "dtpKayitTarih";
            this.dtpKayitTarih.Size = new System.Drawing.Size(82, 26);
            this.dtpKayitTarih.TabIndex = 2;
            this.dtpKayitTarih.TabStop = false;
            // 
            // dtpBitisTarih
            // 
            this.dtpBitisTarih.CalendarFont = new System.Drawing.Font("Calibri", 18F);
            this.dtpBitisTarih.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpBitisTarih.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpBitisTarih.Location = new System.Drawing.Point(531, 39);
            this.dtpBitisTarih.Name = "dtpBitisTarih";
            this.dtpBitisTarih.Size = new System.Drawing.Size(82, 26);
            this.dtpBitisTarih.TabIndex = 2;
            // 
            // txtArama
            // 
            this.txtArama.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtArama.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtArama.Location = new System.Drawing.Point(3, 75);
            this.txtArama.Name = "txtArama";
            this.txtArama.Size = new System.Drawing.Size(82, 26);
            this.txtArama.TabIndex = 5;
            this.txtArama.TabStop = false;
            // 
            // btnAra
            // 
            this.btnAra.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAra.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAra.Location = new System.Drawing.Point(91, 75);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(82, 32);
            this.btnAra.TabIndex = 6;
            this.btnAra.TabStop = false;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // lblKalanGun
            // 
            this.lblKalanGun.AutoSize = true;
            this.lblKalanGun.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblKalanGun.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblKalanGun.Location = new System.Drawing.Point(179, 72);
            this.lblKalanGun.Name = "lblKalanGun";
            this.lblKalanGun.Size = new System.Drawing.Size(82, 38);
            this.lblKalanGun.TabIndex = 7;
            this.lblKalanGun.Text = "label1";
            this.lblKalanGun.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(619, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Üyelik Tipi";
            // 
            // cBoxUyelikTipi
            // 
            this.cBoxUyelikTipi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cBoxUyelikTipi.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.cBoxUyelikTipi.FormattingEnabled = true;
            this.cBoxUyelikTipi.Items.AddRange(new object[] {
            "Normal",
            "Öğrenci"});
            this.cBoxUyelikTipi.Location = new System.Drawing.Point(619, 39);
            this.cBoxUyelikTipi.Name = "cBoxUyelikTipi";
            this.cBoxUyelikTipi.Size = new System.Drawing.Size(82, 26);
            this.cBoxUyelikTipi.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(707, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 36);
            this.label2.TabIndex = 10;
            this.label2.Text = "Borç Durumu";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnGuncelle.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.btnGuncelle.Location = new System.Drawing.Point(626, 75);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(75, 32);
            this.btnGuncelle.TabIndex = 14;
            this.btnGuncelle.TabStop = false;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSil.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.btnSil.Location = new System.Drawing.Point(538, 75);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 32);
            this.btnSil.TabIndex = 15;
            this.btnSil.TabStop = false;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnTemizle.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.btnTemizle.Location = new System.Drawing.Point(450, 75);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(75, 32);
            this.btnTemizle.TabIndex = 16;
            this.btnTemizle.TabStop = false;
            this.btnTemizle.Text = "Yenile";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // txtBorcDurumu
            // 
            this.txtBorcDurumu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBorcDurumu.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.txtBorcDurumu.Location = new System.Drawing.Point(707, 39);
            this.txtBorcDurumu.Name = "txtBorcDurumu";
            this.txtBorcDurumu.Size = new System.Drawing.Size(84, 26);
            this.txtBorcDurumu.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(212)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lblTckn;
        private System.Windows.Forms.Label lblKayitTarih;
        private System.Windows.Forms.Label lblBitisTarih;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtTCKN;
        private System.Windows.Forms.DateTimePicker dtpKayitTarih;
        private System.Windows.Forms.DateTimePicker dtpBitisTarih;
        private System.Windows.Forms.TextBox txtArama;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Label lblKalanGun;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cBoxUyelikTipi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.TextBox txtBorcDurumu;
    }
}

