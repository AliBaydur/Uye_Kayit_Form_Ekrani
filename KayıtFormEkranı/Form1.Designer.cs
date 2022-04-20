
namespace KayıtFormEkranı
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_Adi = new System.Windows.Forms.Label();
            this.txt_Adi = new System.Windows.Forms.TextBox();
            this.lbl_soyad = new System.Windows.Forms.Label();
            this.txt_soyad = new System.Windows.Forms.TextBox();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.lbl_Sifre = new System.Windows.Forms.Label();
            this.txt_Sifre = new System.Windows.Forms.TextBox();
            this.lbl_Cinsiyet = new System.Windows.Forms.Label();
            this.rdbtn_Bay = new System.Windows.Forms.RadioButton();
            this.rbtn_Bayan = new System.Windows.Forms.RadioButton();
            this.lbl_DogumT = new System.Windows.Forms.Label();
            this.dtp_DogumT = new System.Windows.Forms.DateTimePicker();
            this.lbl_Adres = new System.Windows.Forms.Label();
            this.txt_Adres = new System.Windows.Forms.TextBox();
            this.lbl_Sehir = new System.Windows.Forms.Label();
            this.cb_Sehir = new System.Windows.Forms.ComboBox();
            this.clb_Ilgi = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_Uzmanlik = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.limklbl_Uye = new System.Windows.Forms.LinkLabel();
            this.cb_Uye = new System.Windows.Forms.CheckBox();
            this.btn_UyeOl = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.listView1 = new System.Windows.Forms.ListView();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_UyeOl);
            this.groupBox1.Controls.Add(this.cb_Uye);
            this.groupBox1.Controls.Add(this.limklbl_Uye);
            this.groupBox1.Controls.Add(this.lb_Uzmanlik);
            this.groupBox1.Controls.Add(this.clb_Ilgi);
            this.groupBox1.Controls.Add(this.cb_Sehir);
            this.groupBox1.Controls.Add(this.dtp_DogumT);
            this.groupBox1.Controls.Add(this.rbtn_Bayan);
            this.groupBox1.Controls.Add(this.rdbtn_Bay);
            this.groupBox1.Controls.Add(this.txt_Adres);
            this.groupBox1.Controls.Add(this.txt_Sifre);
            this.groupBox1.Controls.Add(this.txt_Email);
            this.groupBox1.Controls.Add(this.txt_soyad);
            this.groupBox1.Controls.Add(this.txt_Adi);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lbl_Sehir);
            this.groupBox1.Controls.Add(this.lbl_Adres);
            this.groupBox1.Controls.Add(this.lbl_DogumT);
            this.groupBox1.Controls.Add(this.lbl_Cinsiyet);
            this.groupBox1.Controls.Add(this.lbl_Sifre);
            this.groupBox1.Controls.Add(this.lbl_Email);
            this.groupBox1.Controls.Add(this.lbl_soyad);
            this.groupBox1.Controls.Add(this.lbl_Adi);
            this.groupBox1.Location = new System.Drawing.Point(19, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(335, 646);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Üye Kayıt Sistemi";
            // 
            // lbl_Adi
            // 
            this.lbl_Adi.AutoSize = true;
            this.lbl_Adi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Adi.Location = new System.Drawing.Point(6, 34);
            this.lbl_Adi.Name = "lbl_Adi";
            this.lbl_Adi.Size = new System.Drawing.Size(43, 15);
            this.lbl_Adi.TabIndex = 0;
            this.lbl_Adi.Text = "Adınız:";
            // 
            // txt_Adi
            // 
            this.txt_Adi.Location = new System.Drawing.Point(97, 33);
            this.txt_Adi.Name = "txt_Adi";
            this.txt_Adi.Size = new System.Drawing.Size(213, 20);
            this.txt_Adi.TabIndex = 0;
            // 
            // lbl_soyad
            // 
            this.lbl_soyad.AutoSize = true;
            this.lbl_soyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_soyad.Location = new System.Drawing.Point(6, 62);
            this.lbl_soyad.Name = "lbl_soyad";
            this.lbl_soyad.Size = new System.Drawing.Size(63, 15);
            this.lbl_soyad.TabIndex = 0;
            this.lbl_soyad.Text = "Soyadınız:";
            // 
            // txt_soyad
            // 
            this.txt_soyad.Location = new System.Drawing.Point(97, 59);
            this.txt_soyad.Name = "txt_soyad";
            this.txt_soyad.Size = new System.Drawing.Size(213, 20);
            this.txt_soyad.TabIndex = 1;
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Email.Location = new System.Drawing.Point(6, 92);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(46, 15);
            this.lbl_Email.TabIndex = 0;
            this.lbl_Email.Text = "E-Mail:";
            this.lbl_Email.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(97, 87);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(213, 20);
            this.txt_Email.TabIndex = 2;
            // 
            // lbl_Sifre
            // 
            this.lbl_Sifre.AutoSize = true;
            this.lbl_Sifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Sifre.Location = new System.Drawing.Point(6, 118);
            this.lbl_Sifre.Name = "lbl_Sifre";
            this.lbl_Sifre.Size = new System.Drawing.Size(35, 15);
            this.lbl_Sifre.TabIndex = 0;
            this.lbl_Sifre.Text = "Şifre:";
            this.lbl_Sifre.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt_Sifre
            // 
            this.txt_Sifre.Location = new System.Drawing.Point(97, 113);
            this.txt_Sifre.Name = "txt_Sifre";
            this.txt_Sifre.PasswordChar = '*';
            this.txt_Sifre.Size = new System.Drawing.Size(213, 20);
            this.txt_Sifre.TabIndex = 3;
            // 
            // lbl_Cinsiyet
            // 
            this.lbl_Cinsiyet.AutoSize = true;
            this.lbl_Cinsiyet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Cinsiyet.Location = new System.Drawing.Point(6, 146);
            this.lbl_Cinsiyet.Name = "lbl_Cinsiyet";
            this.lbl_Cinsiyet.Size = new System.Drawing.Size(52, 15);
            this.lbl_Cinsiyet.TabIndex = 0;
            this.lbl_Cinsiyet.Text = "Cinsiyet:";
            this.lbl_Cinsiyet.Click += new System.EventHandler(this.label2_Click);
            // 
            // rdbtn_Bay
            // 
            this.rdbtn_Bay.AutoSize = true;
            this.rdbtn_Bay.Location = new System.Drawing.Point(135, 146);
            this.rdbtn_Bay.Name = "rdbtn_Bay";
            this.rdbtn_Bay.Size = new System.Drawing.Size(43, 17);
            this.rdbtn_Bay.TabIndex = 4;
            this.rdbtn_Bay.TabStop = true;
            this.rdbtn_Bay.Text = "Bay";
            this.rdbtn_Bay.UseVisualStyleBackColor = true;
            // 
            // rbtn_Bayan
            // 
            this.rbtn_Bayan.AutoSize = true;
            this.rbtn_Bayan.Location = new System.Drawing.Point(206, 146);
            this.rbtn_Bayan.Name = "rbtn_Bayan";
            this.rbtn_Bayan.Size = new System.Drawing.Size(55, 17);
            this.rbtn_Bayan.TabIndex = 5;
            this.rbtn_Bayan.TabStop = true;
            this.rbtn_Bayan.Text = "Bayan";
            this.rbtn_Bayan.UseVisualStyleBackColor = true;
            // 
            // lbl_DogumT
            // 
            this.lbl_DogumT.AutoSize = true;
            this.lbl_DogumT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_DogumT.Location = new System.Drawing.Point(6, 177);
            this.lbl_DogumT.Name = "lbl_DogumT";
            this.lbl_DogumT.Size = new System.Drawing.Size(85, 15);
            this.lbl_DogumT.TabIndex = 0;
            this.lbl_DogumT.Text = "Doğum Tarihi:";
            this.lbl_DogumT.Click += new System.EventHandler(this.label2_Click);
            // 
            // dtp_DogumT
            // 
            this.dtp_DogumT.Location = new System.Drawing.Point(97, 173);
            this.dtp_DogumT.Name = "dtp_DogumT";
            this.dtp_DogumT.Size = new System.Drawing.Size(213, 20);
            this.dtp_DogumT.TabIndex = 6;
            // 
            // lbl_Adres
            // 
            this.lbl_Adres.AutoSize = true;
            this.lbl_Adres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Adres.Location = new System.Drawing.Point(6, 205);
            this.lbl_Adres.Name = "lbl_Adres";
            this.lbl_Adres.Size = new System.Drawing.Size(41, 15);
            this.lbl_Adres.TabIndex = 0;
            this.lbl_Adres.Text = "Adres:";
            this.lbl_Adres.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt_Adres
            // 
            this.txt_Adres.Location = new System.Drawing.Point(97, 204);
            this.txt_Adres.Multiline = true;
            this.txt_Adres.Name = "txt_Adres";
            this.txt_Adres.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_Adres.Size = new System.Drawing.Size(213, 106);
            this.txt_Adres.TabIndex = 7;
            // 
            // lbl_Sehir
            // 
            this.lbl_Sehir.AutoSize = true;
            this.lbl_Sehir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Sehir.Location = new System.Drawing.Point(6, 326);
            this.lbl_Sehir.Name = "lbl_Sehir";
            this.lbl_Sehir.Size = new System.Drawing.Size(39, 15);
            this.lbl_Sehir.TabIndex = 0;
            this.lbl_Sehir.Text = "Şehir:";
            this.lbl_Sehir.Click += new System.EventHandler(this.label2_Click);
            // 
            // cb_Sehir
            // 
            this.cb_Sehir.FormattingEnabled = true;
            this.cb_Sehir.Items.AddRange(new object[] {
            "Adana",
            "İstanbul ",
            "İzmir",
            "Elazığ",
            "Bursa"});
            this.cb_Sehir.Location = new System.Drawing.Point(97, 320);
            this.cb_Sehir.Name = "cb_Sehir";
            this.cb_Sehir.Size = new System.Drawing.Size(213, 21);
            this.cb_Sehir.TabIndex = 8;
            this.cb_Sehir.Text = "Seçiniz";
            // 
            // clb_Ilgi
            // 
            this.clb_Ilgi.FormattingEnabled = true;
            this.clb_Ilgi.Items.AddRange(new object[] {
            "Web Yazılım",
            "Windows Yazılım",
            "Android Yazılım",
            "IOS Yazılım"});
            this.clb_Ilgi.Location = new System.Drawing.Point(97, 373);
            this.clb_Ilgi.Name = "clb_Ilgi";
            this.clb_Ilgi.Size = new System.Drawing.Size(213, 94);
            this.clb_Ilgi.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(6, 373);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "İlgi Alanı:";
            this.label1.Click += new System.EventHandler(this.label2_Click);
            // 
            // lb_Uzmanlik
            // 
            this.lb_Uzmanlik.FormattingEnabled = true;
            this.lb_Uzmanlik.Items.AddRange(new object[] {
            "Donanım",
            "Yazılım",
            "Ağ Sistemleri"});
            this.lb_Uzmanlik.Location = new System.Drawing.Point(97, 473);
            this.lb_Uzmanlik.MultiColumn = true;
            this.lb_Uzmanlik.Name = "lb_Uzmanlik";
            this.lb_Uzmanlik.Size = new System.Drawing.Size(213, 56);
            this.lb_Uzmanlik.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(6, 473);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Uzmanlık:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // limklbl_Uye
            // 
            this.limklbl_Uye.AutoSize = true;
            this.limklbl_Uye.Location = new System.Drawing.Point(94, 541);
            this.limklbl_Uye.Name = "limklbl_Uye";
            this.limklbl_Uye.Size = new System.Drawing.Size(210, 13);
            this.limklbl_Uye.TabIndex = 11;
            this.limklbl_Uye.TabStop = true;
            this.limklbl_Uye.Text = "Üyelik Sözleşmesini Okumak için Tıklayınız.";
            // 
            // cb_Uye
            // 
            this.cb_Uye.AutoSize = true;
            this.cb_Uye.Location = new System.Drawing.Point(97, 566);
            this.cb_Uye.Name = "cb_Uye";
            this.cb_Uye.Size = new System.Drawing.Size(174, 17);
            this.cb_Uye.TabIndex = 12;
            this.cb_Uye.Text = "Üyelik Sözleşmesini Onaylayınız";
            this.cb_Uye.UseVisualStyleBackColor = true;
            // 
            // btn_UyeOl
            // 
            this.btn_UyeOl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_UyeOl.Location = new System.Drawing.Point(132, 599);
            this.btn_UyeOl.Name = "btn_UyeOl";
            this.btn_UyeOl.Size = new System.Drawing.Size(129, 28);
            this.btn_UyeOl.TabIndex = 13;
            this.btn_UyeOl.Text = "Üye Ol";
            this.btn_UyeOl.UseVisualStyleBackColor = true;
            this.btn_UyeOl.Click += new System.EventHandler(this.btn_UyeOl_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(369, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(582, 646);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(574, 620);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Üye Göster Data Grid View";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(574, 620);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Üye Göster List View";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(562, 611);
            this.dataGridView1.TabIndex = 14;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(6, 3);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(562, 611);
            this.listView1.TabIndex = 15;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 670);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Kontrol Kullanımı";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_soyad;
        private System.Windows.Forms.TextBox txt_Adi;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.Label lbl_soyad;
        private System.Windows.Forms.Label lbl_Adi;
        private System.Windows.Forms.TextBox txt_Sifre;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.Label lbl_Cinsiyet;
        private System.Windows.Forms.Label lbl_Sifre;
        private System.Windows.Forms.ComboBox cb_Sehir;
        private System.Windows.Forms.DateTimePicker dtp_DogumT;
        private System.Windows.Forms.RadioButton rbtn_Bayan;
        private System.Windows.Forms.RadioButton rdbtn_Bay;
        private System.Windows.Forms.TextBox txt_Adres;
        private System.Windows.Forms.Label lbl_Sehir;
        private System.Windows.Forms.Label lbl_Adres;
        private System.Windows.Forms.Label lbl_DogumT;
        private System.Windows.Forms.Button btn_UyeOl;
        private System.Windows.Forms.CheckBox cb_Uye;
        private System.Windows.Forms.LinkLabel limklbl_Uye;
        private System.Windows.Forms.ListBox lb_Uzmanlik;
        private System.Windows.Forms.CheckedListBox clb_Ilgi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListView listView1;
    }
}

