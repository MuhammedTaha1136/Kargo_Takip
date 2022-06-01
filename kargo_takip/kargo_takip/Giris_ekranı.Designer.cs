namespace kargo_takip
{
    partial class Giris_ekranı
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Giris_ekranı));
            this.btnUye_ol = new System.Windows.Forms.Button();
            this.chcGöster_Gizle = new System.Windows.Forms.CheckBox();
            this.mstTc_no_login = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGiris = new System.Windows.Forms.Button();
            this.txtParola = new System.Windows.Forms.TextBox();
            this.lblParola = new System.Windows.Forms.Label();
            this.lblTc = new System.Windows.Forms.Label();
            this.gbxÜye_olma = new System.Windows.Forms.GroupBox();
            this.mstTc_no = new System.Windows.Forms.MaskedTextBox();
            this.chcGöster_Gizle2 = new System.Windows.Forms.CheckBox();
            this.btnUyelik_tamamla = new System.Windows.Forms.Button();
            this.txtŞifre_Tekrar = new System.Windows.Forms.TextBox();
            this.txtŞifre = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.gbxBilgiler = new System.Windows.Forms.GroupBox();
            this.btnUyelikGuncelle = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lblSoyisim = new System.Windows.Forms.Label();
            this.lblİsim = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblParola_bilgi = new System.Windows.Forms.Label();
            this.lblTc_kimlik = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.gbxÜye_listele = new System.Windows.Forms.GroupBox();
            this.dgvUyeListele = new System.Windows.Forms.DataGridView();
            this.txtGuncelParola = new System.Windows.Forms.TextBox();
            this.lblGuncelParola = new System.Windows.Forms.Label();
            this.txtGuncelİsim = new System.Windows.Forms.TextBox();
            this.lblGguncelAD = new System.Windows.Forms.Label();
            this.lblGuncelSoyad = new System.Windows.Forms.Label();
            this.lblGuncelTc = new System.Windows.Forms.Label();
            this.txtGuncelSoyisim = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.gbxUyeGuncelle = new System.Windows.Forms.GroupBox();
            this.mstGuncelTC = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.gbxÜye_olma.SuspendLayout();
            this.gbxBilgiler.SuspendLayout();
            this.gbxÜye_listele.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUyeListele)).BeginInit();
            this.gbxUyeGuncelle.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUye_ol
            // 
            this.btnUye_ol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.btnUye_ol.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUye_ol.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUye_ol.ForeColor = System.Drawing.Color.White;
            this.btnUye_ol.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUye_ol.Location = new System.Drawing.Point(18, 179);
            this.btnUye_ol.Name = "btnUye_ol";
            this.btnUye_ol.Size = new System.Drawing.Size(124, 55);
            this.btnUye_ol.TabIndex = 5;
            this.btnUye_ol.Text = "ÜYE OL";
            this.btnUye_ol.UseVisualStyleBackColor = false;
            this.btnUye_ol.Click += new System.EventHandler(this.btnUye_ol_Click);
            // 
            // chcGöster_Gizle
            // 
            this.chcGöster_Gizle.AutoSize = true;
            this.chcGöster_Gizle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.chcGöster_Gizle.Location = new System.Drawing.Point(266, 51);
            this.chcGöster_Gizle.Name = "chcGöster_Gizle";
            this.chcGöster_Gizle.Size = new System.Drawing.Size(59, 19);
            this.chcGöster_Gizle.TabIndex = 3;
            this.chcGöster_Gizle.Text = "göster";
            this.chcGöster_Gizle.UseVisualStyleBackColor = true;
            this.chcGöster_Gizle.CheckedChanged += new System.EventHandler(this.chcGöster_Gizle_CheckedChanged);
            // 
            // mstTc_no_login
            // 
            this.mstTc_no_login.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mstTc_no_login.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mstTc_no_login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.mstTc_no_login.Location = new System.Drawing.Point(128, 8);
            this.mstTc_no_login.Mask = "00000000000";
            this.mstTc_no_login.Name = "mstTc_no_login";
            this.mstTc_no_login.Size = new System.Drawing.Size(135, 27);
            this.mstTc_no_login.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.label2.Location = new System.Drawing.Point(14, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "*Kaydınız yoksa kayıt oluşturabilirsiniz.";
            // 
            // btnGiris
            // 
            this.btnGiris.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.btnGiris.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGiris.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGiris.ForeColor = System.Drawing.Color.White;
            this.btnGiris.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGiris.Location = new System.Drawing.Point(128, 81);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(136, 53);
            this.btnGiris.TabIndex = 4;
            this.btnGiris.Text = "Giriş";
            this.btnGiris.UseVisualStyleBackColor = false;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // txtParola
            // 
            this.txtParola.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtParola.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtParola.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.txtParola.Location = new System.Drawing.Point(128, 48);
            this.txtParola.Multiline = true;
            this.txtParola.Name = "txtParola";
            this.txtParola.PasswordChar = '■';
            this.txtParola.Size = new System.Drawing.Size(135, 25);
            this.txtParola.TabIndex = 2;
            // 
            // lblParola
            // 
            this.lblParola.AutoSize = true;
            this.lblParola.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblParola.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.lblParola.Location = new System.Drawing.Point(14, 53);
            this.lblParola.Name = "lblParola";
            this.lblParola.Size = new System.Drawing.Size(68, 21);
            this.lblParola.TabIndex = 1;
            this.lblParola.Text = "Parola :";
            // 
            // lblTc
            // 
            this.lblTc.AutoSize = true;
            this.lblTc.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.lblTc.Location = new System.Drawing.Point(14, 13);
            this.lblTc.Name = "lblTc";
            this.lblTc.Size = new System.Drawing.Size(114, 21);
            this.lblTc.TabIndex = 0;
            this.lblTc.Text = "TC Kimlik No :";
            // 
            // gbxÜye_olma
            // 
            this.gbxÜye_olma.Controls.Add(this.mstTc_no);
            this.gbxÜye_olma.Controls.Add(this.chcGöster_Gizle2);
            this.gbxÜye_olma.Controls.Add(this.btnUyelik_tamamla);
            this.gbxÜye_olma.Controls.Add(this.txtŞifre_Tekrar);
            this.gbxÜye_olma.Controls.Add(this.txtŞifre);
            this.gbxÜye_olma.Controls.Add(this.txtAd);
            this.gbxÜye_olma.Controls.Add(this.txtSoyad);
            this.gbxÜye_olma.Controls.Add(this.label7);
            this.gbxÜye_olma.Controls.Add(this.label5);
            this.gbxÜye_olma.Controls.Add(this.label1);
            this.gbxÜye_olma.Controls.Add(this.label8);
            this.gbxÜye_olma.Controls.Add(this.label10);
            this.gbxÜye_olma.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbxÜye_olma.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.gbxÜye_olma.Location = new System.Drawing.Point(17, 241);
            this.gbxÜye_olma.Name = "gbxÜye_olma";
            this.gbxÜye_olma.Size = new System.Drawing.Size(454, 238);
            this.gbxÜye_olma.TabIndex = 5;
            this.gbxÜye_olma.TabStop = false;
            this.gbxÜye_olma.Text = "Üye Olma Formu";
            // 
            // mstTc_no
            // 
            this.mstTc_no.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mstTc_no.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mstTc_no.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.mstTc_no.Location = new System.Drawing.Point(105, 27);
            this.mstTc_no.Mask = "00000000000";
            this.mstTc_no.Name = "mstTc_no";
            this.mstTc_no.Size = new System.Drawing.Size(152, 23);
            this.mstTc_no.TabIndex = 8;
            // 
            // chcGöster_Gizle2
            // 
            this.chcGöster_Gizle2.AutoSize = true;
            this.chcGöster_Gizle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chcGöster_Gizle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.chcGöster_Gizle2.Location = new System.Drawing.Point(263, 140);
            this.chcGöster_Gizle2.Name = "chcGöster_Gizle2";
            this.chcGöster_Gizle2.Size = new System.Drawing.Size(59, 19);
            this.chcGöster_Gizle2.TabIndex = 7;
            this.chcGöster_Gizle2.Text = "göster";
            this.chcGöster_Gizle2.UseVisualStyleBackColor = true;
            this.chcGöster_Gizle2.CheckedChanged += new System.EventHandler(this.chcGöster_Gizle2_CheckedChanged);
            // 
            // btnUyelik_tamamla
            // 
            this.btnUyelik_tamamla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.btnUyelik_tamamla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUyelik_tamamla.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUyelik_tamamla.ForeColor = System.Drawing.Color.White;
            this.btnUyelik_tamamla.Location = new System.Drawing.Point(273, 174);
            this.btnUyelik_tamamla.Name = "btnUyelik_tamamla";
            this.btnUyelik_tamamla.Size = new System.Drawing.Size(159, 58);
            this.btnUyelik_tamamla.TabIndex = 13;
            this.btnUyelik_tamamla.Text = "ÜYELİĞİ TAMAMLA";
            this.btnUyelik_tamamla.UseVisualStyleBackColor = false;
            this.btnUyelik_tamamla.Click += new System.EventHandler(this.btnUyelik_tamamla_Click);
            // 
            // txtŞifre_Tekrar
            // 
            this.txtŞifre_Tekrar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtŞifre_Tekrar.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtŞifre_Tekrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.txtŞifre_Tekrar.Location = new System.Drawing.Point(105, 174);
            this.txtŞifre_Tekrar.Multiline = true;
            this.txtŞifre_Tekrar.Name = "txtŞifre_Tekrar";
            this.txtŞifre_Tekrar.PasswordChar = '■';
            this.txtŞifre_Tekrar.Size = new System.Drawing.Size(152, 23);
            this.txtŞifre_Tekrar.TabIndex = 12;
            // 
            // txtŞifre
            // 
            this.txtŞifre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtŞifre.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtŞifre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.txtŞifre.Location = new System.Drawing.Point(105, 138);
            this.txtŞifre.Multiline = true;
            this.txtŞifre.Name = "txtŞifre";
            this.txtŞifre.PasswordChar = '■';
            this.txtŞifre.Size = new System.Drawing.Size(152, 23);
            this.txtŞifre.TabIndex = 11;
            // 
            // txtAd
            // 
            this.txtAd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAd.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.txtAd.Location = new System.Drawing.Point(105, 64);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(152, 23);
            this.txtAd.TabIndex = 9;
            // 
            // txtSoyad
            // 
            this.txtSoyad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSoyad.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSoyad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.txtSoyad.Location = new System.Drawing.Point(105, 101);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(152, 23);
            this.txtSoyad.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.label7.Location = new System.Drawing.Point(14, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 16);
            this.label7.TabIndex = 20;
            this.label7.Text = "Şifre Tekrar :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.label5.Location = new System.Drawing.Point(14, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 16);
            this.label5.TabIndex = 19;
            this.label5.Text = "Şifre :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.label1.Location = new System.Drawing.Point(14, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "TC No :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.label8.Location = new System.Drawing.Point(14, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "Ad :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.label10.Location = new System.Drawing.Point(14, 103);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 16);
            this.label10.TabIndex = 14;
            this.label10.Text = "Soyad :";
            // 
            // gbxBilgiler
            // 
            this.gbxBilgiler.Controls.Add(this.btnUyelikGuncelle);
            this.gbxBilgiler.Controls.Add(this.label6);
            this.gbxBilgiler.Controls.Add(this.lblSoyisim);
            this.gbxBilgiler.Controls.Add(this.lblİsim);
            this.gbxBilgiler.Controls.Add(this.label12);
            this.gbxBilgiler.Controls.Add(this.label13);
            this.gbxBilgiler.Controls.Add(this.lblParola_bilgi);
            this.gbxBilgiler.Controls.Add(this.lblTc_kimlik);
            this.gbxBilgiler.Controls.Add(this.label14);
            this.gbxBilgiler.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbxBilgiler.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.gbxBilgiler.Location = new System.Drawing.Point(323, 8);
            this.gbxBilgiler.Name = "gbxBilgiler";
            this.gbxBilgiler.Size = new System.Drawing.Size(322, 174);
            this.gbxBilgiler.TabIndex = 40;
            this.gbxBilgiler.TabStop = false;
            this.gbxBilgiler.Text = "Bilgileriniz";
            // 
            // btnUyelikGuncelle
            // 
            this.btnUyelikGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.btnUyelikGuncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUyelikGuncelle.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUyelikGuncelle.ForeColor = System.Drawing.Color.White;
            this.btnUyelikGuncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUyelikGuncelle.Location = new System.Drawing.Point(8, 113);
            this.btnUyelikGuncelle.Name = "btnUyelikGuncelle";
            this.btnUyelikGuncelle.Size = new System.Drawing.Size(296, 55);
            this.btnUyelikGuncelle.TabIndex = 41;
            this.btnUyelikGuncelle.Text = "ÜYELİK GÜNCELLE";
            this.btnUyelikGuncelle.UseVisualStyleBackColor = false;
            this.btnUyelikGuncelle.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(165, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 16);
            this.label6.TabIndex = 39;
            this.label6.Text = "İsim :";
            // 
            // lblSoyisim
            // 
            this.lblSoyisim.AutoSize = true;
            this.lblSoyisim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSoyisim.Location = new System.Drawing.Point(230, 72);
            this.lblSoyisim.Name = "lblSoyisim";
            this.lblSoyisim.Size = new System.Drawing.Size(62, 16);
            this.lblSoyisim.TabIndex = 42;
            this.lblSoyisim.Text = "..................";
            // 
            // lblİsim
            // 
            this.lblİsim.AutoSize = true;
            this.lblİsim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblİsim.Location = new System.Drawing.Point(230, 39);
            this.lblİsim.Name = "lblİsim";
            this.lblİsim.Size = new System.Drawing.Size(62, 16);
            this.lblİsim.TabIndex = 40;
            this.lblİsim.Text = "..................";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(165, 72);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 16);
            this.label12.TabIndex = 41;
            this.label12.Text = "Soyisim :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(6, 39);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 16);
            this.label13.TabIndex = 31;
            this.label13.Text = "TC kimlik :";
            // 
            // lblParola_bilgi
            // 
            this.lblParola_bilgi.AutoSize = true;
            this.lblParola_bilgi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblParola_bilgi.Location = new System.Drawing.Point(76, 72);
            this.lblParola_bilgi.Name = "lblParola_bilgi";
            this.lblParola_bilgi.Size = new System.Drawing.Size(62, 16);
            this.lblParola_bilgi.TabIndex = 38;
            this.lblParola_bilgi.Text = "..................";
            // 
            // lblTc_kimlik
            // 
            this.lblTc_kimlik.AutoSize = true;
            this.lblTc_kimlik.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTc_kimlik.Location = new System.Drawing.Point(76, 39);
            this.lblTc_kimlik.Name = "lblTc_kimlik";
            this.lblTc_kimlik.Size = new System.Drawing.Size(62, 16);
            this.lblTc_kimlik.TabIndex = 32;
            this.lblTc_kimlik.Text = "..................";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(7, 72);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(54, 16);
            this.label14.TabIndex = 37;
            this.label14.Text = "Parola :";
            // 
            // gbxÜye_listele
            // 
            this.gbxÜye_listele.Controls.Add(this.dgvUyeListele);
            this.gbxÜye_listele.Font = new System.Drawing.Font("Century Gothic", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbxÜye_listele.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.gbxÜye_listele.Location = new System.Drawing.Point(491, 263);
            this.gbxÜye_listele.Name = "gbxÜye_listele";
            this.gbxÜye_listele.Size = new System.Drawing.Size(360, 216);
            this.gbxÜye_listele.TabIndex = 41;
            this.gbxÜye_listele.TabStop = false;
            this.gbxÜye_listele.Text = "Üyeler";
            // 
            // dgvUyeListele
            // 
            this.dgvUyeListele.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dgvUyeListele.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUyeListele.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvUyeListele.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.dgvUyeListele.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUyeListele.ColumnHeadersHeight = 30;
            this.dgvUyeListele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvUyeListele.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUyeListele.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvUyeListele.Location = new System.Drawing.Point(3, 22);
            this.dgvUyeListele.MultiSelect = false;
            this.dgvUyeListele.Name = "dgvUyeListele";
            this.dgvUyeListele.RowHeadersVisible = false;
            this.dgvUyeListele.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUyeListele.Size = new System.Drawing.Size(354, 191);
            this.dgvUyeListele.TabIndex = 11;
            this.dgvUyeListele.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUyeListele_CellContentClick);
            this.dgvUyeListele.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUyeListele_CellDoubleClick);
            // 
            // txtGuncelParola
            // 
            this.txtGuncelParola.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGuncelParola.Location = new System.Drawing.Point(97, 121);
            this.txtGuncelParola.Name = "txtGuncelParola";
            this.txtGuncelParola.Size = new System.Drawing.Size(120, 27);
            this.txtGuncelParola.TabIndex = 49;
            // 
            // lblGuncelParola
            // 
            this.lblGuncelParola.AutoSize = true;
            this.lblGuncelParola.Location = new System.Drawing.Point(10, 124);
            this.lblGuncelParola.Name = "lblGuncelParola";
            this.lblGuncelParola.Size = new System.Drawing.Size(68, 21);
            this.lblGuncelParola.TabIndex = 48;
            this.lblGuncelParola.Text = "Parola :";
            // 
            // txtGuncelİsim
            // 
            this.txtGuncelİsim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGuncelİsim.Location = new System.Drawing.Point(97, 25);
            this.txtGuncelİsim.Name = "txtGuncelİsim";
            this.txtGuncelİsim.Size = new System.Drawing.Size(120, 27);
            this.txtGuncelİsim.TabIndex = 43;
            // 
            // lblGguncelAD
            // 
            this.lblGguncelAD.AutoSize = true;
            this.lblGguncelAD.Location = new System.Drawing.Point(10, 28);
            this.lblGguncelAD.Name = "lblGguncelAD";
            this.lblGguncelAD.Size = new System.Drawing.Size(48, 21);
            this.lblGguncelAD.TabIndex = 42;
            this.lblGguncelAD.Text = "İsim :";
            // 
            // lblGuncelSoyad
            // 
            this.lblGuncelSoyad.AutoSize = true;
            this.lblGuncelSoyad.Location = new System.Drawing.Point(10, 60);
            this.lblGuncelSoyad.Name = "lblGuncelSoyad";
            this.lblGuncelSoyad.Size = new System.Drawing.Size(75, 21);
            this.lblGuncelSoyad.TabIndex = 44;
            this.lblGuncelSoyad.Text = "Soyisim :";
            // 
            // lblGuncelTc
            // 
            this.lblGuncelTc.AutoSize = true;
            this.lblGuncelTc.Location = new System.Drawing.Point(10, 92);
            this.lblGuncelTc.Name = "lblGuncelTc";
            this.lblGuncelTc.Size = new System.Drawing.Size(87, 21);
            this.lblGuncelTc.TabIndex = 46;
            this.lblGuncelTc.Text = "TC Kimlik :";
            // 
            // txtGuncelSoyisim
            // 
            this.txtGuncelSoyisim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGuncelSoyisim.Location = new System.Drawing.Point(97, 57);
            this.txtGuncelSoyisim.Name = "txtGuncelSoyisim";
            this.txtGuncelSoyisim.Size = new System.Drawing.Size(120, 27);
            this.txtGuncelSoyisim.TabIndex = 45;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(97, 152);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 40);
            this.button2.TabIndex = 43;
            this.button2.Text = "GÜNCELLE";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // gbxUyeGuncelle
            // 
            this.gbxUyeGuncelle.Controls.Add(this.button1);
            this.gbxUyeGuncelle.Controls.Add(this.mstGuncelTC);
            this.gbxUyeGuncelle.Controls.Add(this.lblGguncelAD);
            this.gbxUyeGuncelle.Controls.Add(this.button2);
            this.gbxUyeGuncelle.Controls.Add(this.txtGuncelSoyisim);
            this.gbxUyeGuncelle.Controls.Add(this.txtGuncelParola);
            this.gbxUyeGuncelle.Controls.Add(this.lblGuncelTc);
            this.gbxUyeGuncelle.Controls.Add(this.lblGuncelParola);
            this.gbxUyeGuncelle.Controls.Add(this.lblGuncelSoyad);
            this.gbxUyeGuncelle.Controls.Add(this.txtGuncelİsim);
            this.gbxUyeGuncelle.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbxUyeGuncelle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.gbxUyeGuncelle.Location = new System.Drawing.Point(641, 36);
            this.gbxUyeGuncelle.Name = "gbxUyeGuncelle";
            this.gbxUyeGuncelle.Size = new System.Drawing.Size(237, 198);
            this.gbxUyeGuncelle.TabIndex = 43;
            this.gbxUyeGuncelle.TabStop = false;
            this.gbxUyeGuncelle.Text = "Bilgileriniz";
            // 
            // mstGuncelTC
            // 
            this.mstGuncelTC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mstGuncelTC.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mstGuncelTC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.mstGuncelTC.Location = new System.Drawing.Point(97, 90);
            this.mstGuncelTC.Mask = "00000000000";
            this.mstGuncelTC.Name = "mstGuncelTC";
            this.mstGuncelTC.Size = new System.Drawing.Size(120, 27);
            this.mstGuncelTC.TabIndex = 44;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(36, 152);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(55, 40);
            this.button1.TabIndex = 51;
            this.button1.Text = "SİL";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Giris_ekranı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(881, 491);
            this.Controls.Add(this.gbxUyeGuncelle);
            this.Controls.Add(this.gbxÜye_listele);
            this.Controls.Add(this.gbxBilgiler);
            this.Controls.Add(this.chcGöster_Gizle);
            this.Controls.Add(this.mstTc_no_login);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.gbxÜye_olma);
            this.Controls.Add(this.btnUye_ol);
            this.Controls.Add(this.lblTc);
            this.Controls.Add(this.txtParola);
            this.Controls.Add(this.lblParola);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Giris_ekranı";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GİRİŞ";
            this.Load += new System.EventHandler(this.Giris_ekranı_Load);
            this.Shown += new System.EventHandler(this.Giris_ekranı_Shown);
            this.gbxÜye_olma.ResumeLayout(false);
            this.gbxÜye_olma.PerformLayout();
            this.gbxBilgiler.ResumeLayout(false);
            this.gbxBilgiler.PerformLayout();
            this.gbxÜye_listele.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUyeListele)).EndInit();
            this.gbxUyeGuncelle.ResumeLayout(false);
            this.gbxUyeGuncelle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnUye_ol;
        private System.Windows.Forms.Label lblParola;
        private System.Windows.Forms.Label lblTc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.CheckBox chcGöster_Gizle;
        private System.Windows.Forms.GroupBox gbxÜye_olma;
        private System.Windows.Forms.TextBox txtŞifre_Tekrar;
        private System.Windows.Forms.TextBox txtŞifre;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnUyelik_tamamla;
        private System.Windows.Forms.CheckBox chcGöster_Gizle2;
        public System.Windows.Forms.TextBox txtParola;
        private System.Windows.Forms.MaskedTextBox mstTc_no_login;
        private System.Windows.Forms.MaskedTextBox mstTc_no;
        private System.Windows.Forms.GroupBox gbxBilgiler;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label lblSoyisim;
        public System.Windows.Forms.Label lblİsim;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        public System.Windows.Forms.Label lblParola_bilgi;
        public System.Windows.Forms.Label lblTc_kimlik;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnUyelikGuncelle;
        private System.Windows.Forms.GroupBox gbxÜye_listele;
        private System.Windows.Forms.DataGridView dgvUyeListele;
        private System.Windows.Forms.TextBox txtGuncelParola;
        private System.Windows.Forms.Label lblGuncelParola;
        private System.Windows.Forms.TextBox txtGuncelİsim;
        private System.Windows.Forms.Label lblGguncelAD;
        private System.Windows.Forms.Label lblGuncelSoyad;
        private System.Windows.Forms.Label lblGuncelTc;
        private System.Windows.Forms.TextBox txtGuncelSoyisim;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox gbxUyeGuncelle;
        private System.Windows.Forms.MaskedTextBox mstGuncelTC;
        private System.Windows.Forms.Button button1;
    }
}

