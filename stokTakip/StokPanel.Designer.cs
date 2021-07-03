
namespace stokTakip
{
    partial class StokPanel
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_adet = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker_tarih = new System.Windows.Forms.DateTimePicker();
            this.textBox_urunAdi = new System.Windows.Forms.TextBox();
            this.textBox_adet = new System.Windows.Forms.TextBox();
            this.comboBox_durum = new System.Windows.Forms.ComboBox();
            this.button_ekle = new System.Windows.Forms.Button();
            this.button_sil = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.stokID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.urunKodu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.urunAdi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tarih = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.adet = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.durum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label_urunSayisi = new System.Windows.Forms.Label();
            this.label_adetSayisi = new System.Windows.Forms.Label();
            this.comboBox_urunKodu = new System.Windows.Forms.ComboBox();
            this.urunlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stokTakipurunKoduBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stokTakip_urunKodu = new stokTakip.stokTakip_urunKodu();
            this.textBox_silinecekID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label_urunSayisi_deger = new System.Windows.Forms.Label();
            this.label_adetSayisi_deger = new System.Windows.Forms.Label();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.button_yenile = new System.Windows.Forms.Button();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.urunlerTableAdapter = new stokTakip.stokTakip_urunKoduTableAdapters.UrunlerTableAdapter();
            this.button_pdf = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.urunlerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokTakipurunKoduBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokTakip_urunKodu)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tarih";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(158, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ürün Kodu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(251, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ürün Adı";
            // 
            // label_adet
            // 
            this.label_adet.AutoSize = true;
            this.label_adet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_adet.Location = new System.Drawing.Point(344, 0);
            this.label_adet.Name = "label_adet";
            this.label_adet.Size = new System.Drawing.Size(36, 16);
            this.label_adet.TabIndex = 3;
            this.label_adet.Text = "Adet";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(437, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Durum";
            // 
            // dateTimePicker_tarih
            // 
            this.dateTimePicker_tarih.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker_tarih.Checked = false;
            this.dateTimePicker_tarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_tarih.Location = new System.Drawing.Point(3, 32);
            this.dateTimePicker_tarih.Name = "dateTimePicker_tarih";
            this.dateTimePicker_tarih.Size = new System.Drawing.Size(149, 20);
            this.dateTimePicker_tarih.TabIndex = 5;
            // 
            // textBox_urunAdi
            // 
            this.textBox_urunAdi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_urunAdi.Location = new System.Drawing.Point(251, 32);
            this.textBox_urunAdi.Name = "textBox_urunAdi";
            this.textBox_urunAdi.ReadOnly = true;
            this.textBox_urunAdi.Size = new System.Drawing.Size(87, 20);
            this.textBox_urunAdi.TabIndex = 7;
            // 
            // textBox_adet
            // 
            this.textBox_adet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_adet.Location = new System.Drawing.Point(344, 32);
            this.textBox_adet.Name = "textBox_adet";
            this.textBox_adet.Size = new System.Drawing.Size(87, 20);
            this.textBox_adet.TabIndex = 8;
            this.textBox_adet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_adet_KeyPress);
            // 
            // comboBox_durum
            // 
            this.comboBox_durum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox_durum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_durum.FormattingEnabled = true;
            this.comboBox_durum.Items.AddRange(new object[] {
            "Yok",
            "Var"});
            this.comboBox_durum.Location = new System.Drawing.Point(437, 32);
            this.comboBox_durum.Name = "comboBox_durum";
            this.comboBox_durum.Size = new System.Drawing.Size(88, 21);
            this.comboBox_durum.TabIndex = 9;
            // 
            // button_ekle
            // 
            this.button_ekle.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_ekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_ekle.ForeColor = System.Drawing.Color.Black;
            this.button_ekle.Location = new System.Drawing.Point(3, 3);
            this.button_ekle.Name = "button_ekle";
            this.button_ekle.Size = new System.Drawing.Size(522, 45);
            this.button_ekle.TabIndex = 10;
            this.button_ekle.Text = "Ekle";
            this.button_ekle.UseVisualStyleBackColor = true;
            this.button_ekle.Click += new System.EventHandler(this.button_ekle_Click);
            // 
            // button_sil
            // 
            this.button_sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_sil.ForeColor = System.Drawing.Color.Red;
            this.button_sil.Location = new System.Drawing.Point(3, 3);
            this.button_sil.Name = "button_sil";
            this.button_sil.Size = new System.Drawing.Size(221, 46);
            this.button_sil.TabIndex = 11;
            this.button_sil.Text = "Sil";
            this.button_sil.UseVisualStyleBackColor = true;
            this.button_sil.Click += new System.EventHandler(this.button_sil_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.stokID,
            this.urunKodu,
            this.urunAdi,
            this.tarih,
            this.adet,
            this.durum});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(15, 125);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(776, 286);
            this.listView1.TabIndex = 12;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // stokID
            // 
            this.stokID.Text = "Stok ID";
            // 
            // urunKodu
            // 
            this.urunKodu.Text = "Ürün Kodu";
            this.urunKodu.Width = 197;
            // 
            // urunAdi
            // 
            this.urunAdi.Text = "Ürün Adı";
            this.urunAdi.Width = 228;
            // 
            // tarih
            // 
            this.tarih.DisplayIndex = 4;
            this.tarih.Text = "Tarih";
            this.tarih.Width = 143;
            // 
            // adet
            // 
            this.adet.DisplayIndex = 3;
            this.adet.Text = "Adet";
            // 
            // durum
            // 
            this.durum.Text = "Durum";
            this.durum.Width = 83;
            // 
            // label_urunSayisi
            // 
            this.label_urunSayisi.AutoSize = true;
            this.label_urunSayisi.Location = new System.Drawing.Point(3, 0);
            this.label_urunSayisi.Name = "label_urunSayisi";
            this.label_urunSayisi.Size = new System.Drawing.Size(64, 13);
            this.label_urunSayisi.TabIndex = 13;
            this.label_urunSayisi.Text = "Ürün sayısı: ";
            // 
            // label_adetSayisi
            // 
            this.label_adetSayisi.AutoSize = true;
            this.label_adetSayisi.Location = new System.Drawing.Point(3, 0);
            this.label_adetSayisi.Name = "label_adetSayisi";
            this.label_adetSayisi.Size = new System.Drawing.Size(63, 13);
            this.label_adetSayisi.TabIndex = 14;
            this.label_adetSayisi.Text = "Adet sayısı: ";
            // 
            // comboBox_urunKodu
            // 
            this.comboBox_urunKodu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox_urunKodu.DataSource = this.urunlerBindingSource;
            this.comboBox_urunKodu.DisplayMember = "urunKodu";
            this.comboBox_urunKodu.FormattingEnabled = true;
            this.comboBox_urunKodu.Location = new System.Drawing.Point(158, 32);
            this.comboBox_urunKodu.Name = "comboBox_urunKodu";
            this.comboBox_urunKodu.Size = new System.Drawing.Size(87, 21);
            this.comboBox_urunKodu.TabIndex = 15;
            this.comboBox_urunKodu.ValueMember = "urunKodu";
            this.comboBox_urunKodu.SelectionChangeCommitted += new System.EventHandler(this.comboBox_urunKodu_SelectionChangeCommitted);
            this.comboBox_urunKodu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox_urunKodu_KeyPress);
            // 
            // urunlerBindingSource
            // 
            this.urunlerBindingSource.DataMember = "Urunler";
            this.urunlerBindingSource.DataSource = this.stokTakipurunKoduBindingSource;
            // 
            // stokTakipurunKoduBindingSource
            // 
            this.stokTakipurunKoduBindingSource.DataSource = this.stokTakip_urunKodu;
            this.stokTakipurunKoduBindingSource.Position = 0;
            // 
            // stokTakip_urunKodu
            // 
            this.stokTakip_urunKodu.DataSetName = "stokTakip_urunKodu";
            this.stokTakip_urunKodu.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox_silinecekID
            // 
            this.textBox_silinecekID.Location = new System.Drawing.Point(3, 30);
            this.textBox_silinecekID.Name = "textBox_silinecekID";
            this.textBox_silinecekID.Size = new System.Drawing.Size(221, 20);
            this.textBox_silinecekID.TabIndex = 16;
            this.textBox_silinecekID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_silinecekID_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 16);
            this.label8.TabIndex = 17;
            this.label8.Text = "Silinecek ID";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.41176F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.64706F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.64706F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.64706F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.64706F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dateTimePicker_tarih, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.comboBox_urunKodu, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox_urunAdi, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox_adet, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label_adet, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.comboBox_durum, 4, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(528, 57);
            this.tableLayoutPanel1.TabIndex = 18;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.button_ekle, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 71);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(528, 52);
            this.tableLayoutPanel2.TabIndex = 19;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.textBox_silinecekID, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label8, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(561, 12);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.22523F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.92793F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(227, 57);
            this.tableLayoutPanel3.TabIndex = 20;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.button_sil, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(561, 71);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(227, 52);
            this.tableLayoutPanel4.TabIndex = 21;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.label_urunSayisi, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.label_urunSayisi_deger, 1, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(12, 420);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(152, 21);
            this.tableLayoutPanel5.TabIndex = 22;
            // 
            // label_urunSayisi_deger
            // 
            this.label_urunSayisi_deger.AutoSize = true;
            this.label_urunSayisi_deger.Location = new System.Drawing.Point(79, 0);
            this.label_urunSayisi_deger.Name = "label_urunSayisi_deger";
            this.label_urunSayisi_deger.Size = new System.Drawing.Size(64, 13);
            this.label_urunSayisi_deger.TabIndex = 14;
            this.label_urunSayisi_deger.Text = "*ürün sayısı*";
            // 
            // label_adetSayisi_deger
            // 
            this.label_adetSayisi_deger.AutoSize = true;
            this.label_adetSayisi_deger.Location = new System.Drawing.Point(79, 0);
            this.label_adetSayisi_deger.Name = "label_adetSayisi_deger";
            this.label_adetSayisi_deger.Size = new System.Drawing.Size(64, 13);
            this.label_adetSayisi_deger.TabIndex = 23;
            this.label_adetSayisi_deger.Text = "*adet sayısı*";
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.label_adetSayisi, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.label_adetSayisi_deger, 1, 0);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(636, 420);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(152, 21);
            this.tableLayoutPanel6.TabIndex = 24;
            // 
            // button_yenile
            // 
            this.button_yenile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_yenile.Location = new System.Drawing.Point(77, 3);
            this.button_yenile.Name = "button_yenile";
            this.button_yenile.Size = new System.Drawing.Size(75, 22);
            this.button_yenile.TabIndex = 25;
            this.button_yenile.Text = "Yenile";
            this.button_yenile.UseVisualStyleBackColor = true;
            this.button_yenile.Click += new System.EventHandler(this.button_yenile_Click);
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 2;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Controls.Add(this.button_yenile, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.button_pdf, 1, 0);
            this.tableLayoutPanel7.Location = new System.Drawing.Point(170, 417);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(460, 28);
            this.tableLayoutPanel7.TabIndex = 26;
            // 
            // urunlerTableAdapter
            // 
            this.urunlerTableAdapter.ClearBeforeFill = true;
            // 
            // button_pdf
            // 
            this.button_pdf.Location = new System.Drawing.Point(233, 3);
            this.button_pdf.Name = "button_pdf";
            this.button_pdf.Size = new System.Drawing.Size(134, 22);
            this.button_pdf.TabIndex = 26;
            this.button_pdf.Text = "PDF olarak dışarı aktar";
            this.button_pdf.UseVisualStyleBackColor = true;
            // 
            // StokPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel7);
            this.Controls.Add(this.tableLayoutPanel6);
            this.Controls.Add(this.tableLayoutPanel5);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.listView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StokPanel";
            this.Text = "StokPanel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StokPanel_FormClosing);
            this.Load += new System.EventHandler(this.StokPanel_Load);
            this.MdiChildActivate += new System.EventHandler(this.StokPanel_MdiChildActivate);
            ((System.ComponentModel.ISupportInitialize)(this.urunlerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokTakipurunKoduBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokTakip_urunKodu)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_adet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker_tarih;
        private System.Windows.Forms.TextBox textBox_urunAdi;
        private System.Windows.Forms.TextBox textBox_adet;
        private System.Windows.Forms.ComboBox comboBox_durum;
        private System.Windows.Forms.Button button_ekle;
        private System.Windows.Forms.Button button_sil;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label_urunSayisi;
        private System.Windows.Forms.Label label_adetSayisi;
        private System.Windows.Forms.ComboBox comboBox_urunKodu;
        private System.Windows.Forms.ColumnHeader urunKodu;
        private System.Windows.Forms.ColumnHeader urunAdi;
        private System.Windows.Forms.ColumnHeader adet;
        private System.Windows.Forms.ColumnHeader tarih;
        private System.Windows.Forms.ColumnHeader durum;
        private stokTakip_urunKodu stokTakip_urunKodu;
        private System.Windows.Forms.ColumnHeader stokID;
        private System.Windows.Forms.TextBox textBox_silinecekID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label label_urunSayisi_deger;
        private System.Windows.Forms.Label label_adetSayisi_deger;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Button button_yenile;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.BindingSource urunlerBindingSource;
        private stokTakip_urunKoduTableAdapters.UrunlerTableAdapter urunlerTableAdapter;
        private System.Windows.Forms.BindingSource stokTakipurunKoduBindingSource;
        private System.Windows.Forms.Button button_pdf;
    }
}