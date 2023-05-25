
namespace BenzinİstasyonuOtomasyonu
{
    partial class Form1
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
            this.yakit_tabbedpane = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pBar_lpg = new System.Windows.Forms.ProgressBar();
            this.btn_updateinfo = new System.Windows.Forms.Button();
            this.pBar_benzin95 = new System.Windows.Forms.ProgressBar();
            this.pBar_benzin97 = new System.Windows.Forms.ProgressBar();
            this.pBar_dizel = new System.Windows.Forms.ProgressBar();
            this.pBar_eurodizel = new System.Windows.Forms.ProgressBar();
            this.tBox_depolpg = new System.Windows.Forms.TextBox();
            this.tBox_depobenzin95 = new System.Windows.Forms.TextBox();
            this.tBox_depobenzin97 = new System.Windows.Forms.TextBox();
            this.tBox_depodizel = new System.Windows.Forms.TextBox();
            this.tBox_depoeurodizel = new System.Windows.Forms.TextBox();
            this.lbl_depolpg = new System.Windows.Forms.Label();
            this.lbl_depoeurodizel = new System.Windows.Forms.Label();
            this.lbl_depodizel = new System.Windows.Forms.Label();
            this.lbl_depobenzin97 = new System.Windows.Forms.Label();
            this.lbl_depobenzin95 = new System.Windows.Forms.Label();
            this.lbl_lpg = new System.Windows.Forms.Label();
            this.lbl_eurodizel = new System.Windows.Forms.Label();
            this.lbl_dizel = new System.Windows.Forms.Label();
            this.lbl_benzin97 = new System.Windows.Forms.Label();
            this.lbl_benzin95 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label16 = new System.Windows.Forms.Label();
            this.tBox_discountlpg = new System.Windows.Forms.TextBox();
            this.tBox_discountbenzin95 = new System.Windows.Forms.TextBox();
            this.tBox_discountbenzin97 = new System.Windows.Forms.TextBox();
            this.tBox_discountdizel = new System.Windows.Forms.TextBox();
            this.tBox_discounteurodizel = new System.Windows.Forms.TextBox();
            this.lbl_discountlpg = new System.Windows.Forms.Label();
            this.lbl_discounteurodizel = new System.Windows.Forms.Label();
            this.lbl_discountdizel = new System.Windows.Forms.Label();
            this.lbl_discountbenzin97 = new System.Windows.Forms.Label();
            this.lbl_discountbenzin95 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btn_sell = new System.Windows.Forms.Button();
            this.numeric_eurodizel = new System.Windows.Forms.NumericUpDown();
            this.numeric_dizel = new System.Windows.Forms.NumericUpDown();
            this.numeric_benzin97 = new System.Windows.Forms.NumericUpDown();
            this.numeric_benzin95 = new System.Windows.Forms.NumericUpDown();
            this.numeric_lpg = new System.Windows.Forms.NumericUpDown();
            this.cBox_fueltype = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_pay = new System.Windows.Forms.Label();
            this.btn_updateprice = new System.Windows.Forms.Button();
            this.yakit_tabbedpane.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_eurodizel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_dizel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_benzin97)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_benzin95)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_lpg)).BeginInit();
            this.SuspendLayout();
            // 
            // yakit_tabbedpane
            // 
            this.yakit_tabbedpane.Controls.Add(this.tabPage1);
            this.yakit_tabbedpane.Controls.Add(this.tabPage2);
            this.yakit_tabbedpane.Controls.Add(this.tabPage3);
            this.yakit_tabbedpane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.yakit_tabbedpane.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yakit_tabbedpane.Location = new System.Drawing.Point(0, 0);
            this.yakit_tabbedpane.Name = "yakit_tabbedpane";
            this.yakit_tabbedpane.SelectedIndex = 0;
            this.yakit_tabbedpane.Size = new System.Drawing.Size(800, 450);
            this.yakit_tabbedpane.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pBar_lpg);
            this.tabPage1.Controls.Add(this.btn_updateinfo);
            this.tabPage1.Controls.Add(this.pBar_benzin95);
            this.tabPage1.Controls.Add(this.pBar_benzin97);
            this.tabPage1.Controls.Add(this.pBar_dizel);
            this.tabPage1.Controls.Add(this.pBar_eurodizel);
            this.tabPage1.Controls.Add(this.tBox_depolpg);
            this.tabPage1.Controls.Add(this.tBox_depobenzin95);
            this.tabPage1.Controls.Add(this.tBox_depobenzin97);
            this.tabPage1.Controls.Add(this.tBox_depodizel);
            this.tabPage1.Controls.Add(this.tBox_depoeurodizel);
            this.tabPage1.Controls.Add(this.lbl_depolpg);
            this.tabPage1.Controls.Add(this.lbl_depoeurodizel);
            this.tabPage1.Controls.Add(this.lbl_depodizel);
            this.tabPage1.Controls.Add(this.lbl_depobenzin97);
            this.tabPage1.Controls.Add(this.lbl_depobenzin95);
            this.tabPage1.Controls.Add(this.lbl_lpg);
            this.tabPage1.Controls.Add(this.lbl_eurodizel);
            this.tabPage1.Controls.Add(this.lbl_dizel);
            this.tabPage1.Controls.Add(this.lbl_benzin97);
            this.tabPage1.Controls.Add(this.lbl_benzin95);
            this.tabPage1.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabPage1.Location = new System.Drawing.Point(4, 32);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 414);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "DEPO BİLGİLERİ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // pBar_lpg
            // 
            this.pBar_lpg.Location = new System.Drawing.Point(413, 235);
            this.pBar_lpg.MarqueeAnimationSpeed = 50;
            this.pBar_lpg.Maximum = 1000;
            this.pBar_lpg.Name = "pBar_lpg";
            this.pBar_lpg.Size = new System.Drawing.Size(288, 30);
            this.pBar_lpg.TabIndex = 21;
            // 
            // btn_updateinfo
            // 
            this.btn_updateinfo.Location = new System.Drawing.Point(413, 304);
            this.btn_updateinfo.Name = "btn_updateinfo";
            this.btn_updateinfo.Size = new System.Drawing.Size(288, 30);
            this.btn_updateinfo.TabIndex = 20;
            this.btn_updateinfo.Text = "DEPO BİLGİLERİNİ GÜNCELLE";
            this.btn_updateinfo.UseVisualStyleBackColor = true;
            this.btn_updateinfo.Click += new System.EventHandler(this.btn_updateinfo_Click);
            // 
            // pBar_benzin95
            // 
            this.pBar_benzin95.Location = new System.Drawing.Point(413, 36);
            this.pBar_benzin95.MarqueeAnimationSpeed = 50;
            this.pBar_benzin95.Maximum = 1000;
            this.pBar_benzin95.Name = "pBar_benzin95";
            this.pBar_benzin95.Size = new System.Drawing.Size(288, 30);
            this.pBar_benzin95.TabIndex = 19;
            // 
            // pBar_benzin97
            // 
            this.pBar_benzin97.Location = new System.Drawing.Point(413, 81);
            this.pBar_benzin97.MarqueeAnimationSpeed = 50;
            this.pBar_benzin97.Maximum = 1000;
            this.pBar_benzin97.Name = "pBar_benzin97";
            this.pBar_benzin97.Size = new System.Drawing.Size(288, 30);
            this.pBar_benzin97.TabIndex = 18;
            // 
            // pBar_dizel
            // 
            this.pBar_dizel.Location = new System.Drawing.Point(413, 133);
            this.pBar_dizel.MarqueeAnimationSpeed = 50;
            this.pBar_dizel.Maximum = 1000;
            this.pBar_dizel.Name = "pBar_dizel";
            this.pBar_dizel.Size = new System.Drawing.Size(288, 30);
            this.pBar_dizel.TabIndex = 17;
            // 
            // pBar_eurodizel
            // 
            this.pBar_eurodizel.Location = new System.Drawing.Point(413, 183);
            this.pBar_eurodizel.MarqueeAnimationSpeed = 50;
            this.pBar_eurodizel.Maximum = 1000;
            this.pBar_eurodizel.Name = "pBar_eurodizel";
            this.pBar_eurodizel.Size = new System.Drawing.Size(288, 30);
            this.pBar_eurodizel.TabIndex = 16;
            // 
            // tBox_depolpg
            // 
            this.tBox_depolpg.Location = new System.Drawing.Point(279, 235);
            this.tBox_depolpg.Name = "tBox_depolpg";
            this.tBox_depolpg.Size = new System.Drawing.Size(100, 30);
            this.tBox_depolpg.TabIndex = 14;
            // 
            // tBox_depobenzin95
            // 
            this.tBox_depobenzin95.Location = new System.Drawing.Point(279, 36);
            this.tBox_depobenzin95.Name = "tBox_depobenzin95";
            this.tBox_depobenzin95.Size = new System.Drawing.Size(100, 30);
            this.tBox_depobenzin95.TabIndex = 13;
            // 
            // tBox_depobenzin97
            // 
            this.tBox_depobenzin97.Location = new System.Drawing.Point(279, 81);
            this.tBox_depobenzin97.Name = "tBox_depobenzin97";
            this.tBox_depobenzin97.Size = new System.Drawing.Size(100, 30);
            this.tBox_depobenzin97.TabIndex = 12;
            // 
            // tBox_depodizel
            // 
            this.tBox_depodizel.Location = new System.Drawing.Point(279, 133);
            this.tBox_depodizel.Name = "tBox_depodizel";
            this.tBox_depodizel.Size = new System.Drawing.Size(100, 30);
            this.tBox_depodizel.TabIndex = 11;
            // 
            // tBox_depoeurodizel
            // 
            this.tBox_depoeurodizel.Location = new System.Drawing.Point(279, 183);
            this.tBox_depoeurodizel.Name = "tBox_depoeurodizel";
            this.tBox_depoeurodizel.Size = new System.Drawing.Size(100, 30);
            this.tBox_depoeurodizel.TabIndex = 10;
            // 
            // lbl_depolpg
            // 
            this.lbl_depolpg.AutoSize = true;
            this.lbl_depolpg.Location = new System.Drawing.Point(177, 235);
            this.lbl_depolpg.Name = "lbl_depolpg";
            this.lbl_depolpg.Size = new System.Drawing.Size(62, 23);
            this.lbl_depolpg.TabIndex = 9;
            this.lbl_depolpg.Text = "label10";
            // 
            // lbl_depoeurodizel
            // 
            this.lbl_depoeurodizel.AutoSize = true;
            this.lbl_depoeurodizel.Location = new System.Drawing.Point(185, 183);
            this.lbl_depoeurodizel.Name = "lbl_depoeurodizel";
            this.lbl_depoeurodizel.Size = new System.Drawing.Size(55, 23);
            this.lbl_depoeurodizel.TabIndex = 8;
            this.lbl_depoeurodizel.Text = "label9";
            // 
            // lbl_depodizel
            // 
            this.lbl_depodizel.AutoSize = true;
            this.lbl_depodizel.Location = new System.Drawing.Point(185, 133);
            this.lbl_depodizel.Name = "lbl_depodizel";
            this.lbl_depodizel.Size = new System.Drawing.Size(55, 23);
            this.lbl_depodizel.TabIndex = 7;
            this.lbl_depodizel.Text = "label8";
            // 
            // lbl_depobenzin97
            // 
            this.lbl_depobenzin97.AutoSize = true;
            this.lbl_depobenzin97.Location = new System.Drawing.Point(185, 81);
            this.lbl_depobenzin97.Name = "lbl_depobenzin97";
            this.lbl_depobenzin97.Size = new System.Drawing.Size(55, 23);
            this.lbl_depobenzin97.TabIndex = 6;
            this.lbl_depobenzin97.Text = "label7";
            // 
            // lbl_depobenzin95
            // 
            this.lbl_depobenzin95.AutoSize = true;
            this.lbl_depobenzin95.Location = new System.Drawing.Point(185, 36);
            this.lbl_depobenzin95.Name = "lbl_depobenzin95";
            this.lbl_depobenzin95.Size = new System.Drawing.Size(55, 23);
            this.lbl_depobenzin95.TabIndex = 5;
            this.lbl_depobenzin95.Text = "label6";
            // 
            // lbl_lpg
            // 
            this.lbl_lpg.AutoSize = true;
            this.lbl_lpg.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_lpg.Location = new System.Drawing.Point(46, 235);
            this.lbl_lpg.Name = "lbl_lpg";
            this.lbl_lpg.Size = new System.Drawing.Size(40, 23);
            this.lbl_lpg.TabIndex = 4;
            this.lbl_lpg.Text = "LPG";
            // 
            // lbl_eurodizel
            // 
            this.lbl_eurodizel.AutoSize = true;
            this.lbl_eurodizel.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_eurodizel.Location = new System.Drawing.Point(46, 183);
            this.lbl_eurodizel.Name = "lbl_eurodizel";
            this.lbl_eurodizel.Size = new System.Drawing.Size(104, 23);
            this.lbl_eurodizel.TabIndex = 3;
            this.lbl_eurodizel.Text = "EURO DİZEL";
            // 
            // lbl_dizel
            // 
            this.lbl_dizel.AutoSize = true;
            this.lbl_dizel.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_dizel.Location = new System.Drawing.Point(46, 133);
            this.lbl_dizel.Name = "lbl_dizel";
            this.lbl_dizel.Size = new System.Drawing.Size(54, 23);
            this.lbl_dizel.TabIndex = 2;
            this.lbl_dizel.Text = "DİZEL";
            // 
            // lbl_benzin97
            // 
            this.lbl_benzin97.AutoSize = true;
            this.lbl_benzin97.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_benzin97.Location = new System.Drawing.Point(46, 81);
            this.lbl_benzin97.Name = "lbl_benzin97";
            this.lbl_benzin97.Size = new System.Drawing.Size(105, 23);
            this.lbl_benzin97.TabIndex = 1;
            this.lbl_benzin97.Text = "BENZİN (97)";
            // 
            // lbl_benzin95
            // 
            this.lbl_benzin95.AutoSize = true;
            this.lbl_benzin95.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_benzin95.Location = new System.Drawing.Point(46, 30);
            this.lbl_benzin95.Name = "lbl_benzin95";
            this.lbl_benzin95.Size = new System.Drawing.Size(105, 23);
            this.lbl_benzin95.TabIndex = 0;
            this.lbl_benzin95.Text = "BENZİN (95)";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_updateprice);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.tBox_discountlpg);
            this.tabPage2.Controls.Add(this.tBox_discountbenzin95);
            this.tabPage2.Controls.Add(this.tBox_discountbenzin97);
            this.tabPage2.Controls.Add(this.tBox_discountdizel);
            this.tabPage2.Controls.Add(this.tBox_discounteurodizel);
            this.tabPage2.Controls.Add(this.lbl_discountlpg);
            this.tabPage2.Controls.Add(this.lbl_discounteurodizel);
            this.tabPage2.Controls.Add(this.lbl_discountdizel);
            this.tabPage2.Controls.Add(this.lbl_discountbenzin97);
            this.tabPage2.Controls.Add(this.lbl_discountbenzin95);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Location = new System.Drawing.Point(4, 32);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 414);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "FİYAT BİLGİLER";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(228, 18);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(255, 46);
            this.label16.TabIndex = 30;
            this.label16.Text = "ZAM / İNDİRİM ORANLARI (%) \r\n  İndirim için bir değer giriniz !";
            // 
            // tBox_discountlpg
            // 
            this.tBox_discountlpg.Location = new System.Drawing.Point(408, 284);
            this.tBox_discountlpg.Name = "tBox_discountlpg";
            this.tBox_discountlpg.Size = new System.Drawing.Size(100, 30);
            this.tBox_discountlpg.TabIndex = 29;
            // 
            // tBox_discountbenzin95
            // 
            this.tBox_discountbenzin95.Location = new System.Drawing.Point(408, 85);
            this.tBox_discountbenzin95.Name = "tBox_discountbenzin95";
            this.tBox_discountbenzin95.Size = new System.Drawing.Size(100, 30);
            this.tBox_discountbenzin95.TabIndex = 28;
            // 
            // tBox_discountbenzin97
            // 
            this.tBox_discountbenzin97.Location = new System.Drawing.Point(408, 130);
            this.tBox_discountbenzin97.Name = "tBox_discountbenzin97";
            this.tBox_discountbenzin97.Size = new System.Drawing.Size(100, 30);
            this.tBox_discountbenzin97.TabIndex = 27;
            // 
            // tBox_discountdizel
            // 
            this.tBox_discountdizel.Location = new System.Drawing.Point(408, 182);
            this.tBox_discountdizel.Name = "tBox_discountdizel";
            this.tBox_discountdizel.Size = new System.Drawing.Size(100, 30);
            this.tBox_discountdizel.TabIndex = 26;
            // 
            // tBox_discounteurodizel
            // 
            this.tBox_discounteurodizel.Location = new System.Drawing.Point(408, 232);
            this.tBox_discounteurodizel.Name = "tBox_discounteurodizel";
            this.tBox_discounteurodizel.Size = new System.Drawing.Size(100, 30);
            this.tBox_discounteurodizel.TabIndex = 25;
            // 
            // lbl_discountlpg
            // 
            this.lbl_discountlpg.AutoSize = true;
            this.lbl_discountlpg.Location = new System.Drawing.Point(314, 284);
            this.lbl_discountlpg.Name = "lbl_discountlpg";
            this.lbl_discountlpg.Size = new System.Drawing.Size(53, 23);
            this.lbl_discountlpg.TabIndex = 24;
            this.lbl_discountlpg.Text = "label1";
            // 
            // lbl_discounteurodizel
            // 
            this.lbl_discounteurodizel.AutoSize = true;
            this.lbl_discounteurodizel.Location = new System.Drawing.Point(314, 232);
            this.lbl_discounteurodizel.Name = "lbl_discounteurodizel";
            this.lbl_discounteurodizel.Size = new System.Drawing.Size(55, 23);
            this.lbl_discounteurodizel.TabIndex = 23;
            this.lbl_discounteurodizel.Text = "label2";
            // 
            // lbl_discountdizel
            // 
            this.lbl_discountdizel.AutoSize = true;
            this.lbl_discountdizel.Location = new System.Drawing.Point(314, 182);
            this.lbl_discountdizel.Name = "lbl_discountdizel";
            this.lbl_discountdizel.Size = new System.Drawing.Size(55, 23);
            this.lbl_discountdizel.TabIndex = 22;
            this.lbl_discountdizel.Text = "label3";
            // 
            // lbl_discountbenzin97
            // 
            this.lbl_discountbenzin97.AutoSize = true;
            this.lbl_discountbenzin97.Location = new System.Drawing.Point(314, 130);
            this.lbl_discountbenzin97.Name = "lbl_discountbenzin97";
            this.lbl_discountbenzin97.Size = new System.Drawing.Size(56, 23);
            this.lbl_discountbenzin97.TabIndex = 21;
            this.lbl_discountbenzin97.Text = "label4";
            // 
            // lbl_discountbenzin95
            // 
            this.lbl_discountbenzin95.AutoSize = true;
            this.lbl_discountbenzin95.Location = new System.Drawing.Point(314, 85);
            this.lbl_discountbenzin95.Name = "lbl_discountbenzin95";
            this.lbl_discountbenzin95.Size = new System.Drawing.Size(55, 23);
            this.lbl_discountbenzin95.TabIndex = 20;
            this.lbl_discountbenzin95.Text = "label5";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(175, 284);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 23);
            this.label11.TabIndex = 19;
            this.label11.Text = "LPG";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(175, 232);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(104, 23);
            this.label12.TabIndex = 18;
            this.label12.Text = "EURO DİZEL";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(175, 182);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(54, 23);
            this.label13.TabIndex = 17;
            this.label13.Text = "DİZEL";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(175, 130);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(105, 23);
            this.label14.TabIndex = 16;
            this.label14.Text = "BENZİN (97)";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(175, 79);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(105, 23);
            this.label15.TabIndex = 15;
            this.label15.Text = "BENZİN (95)";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.lbl_pay);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.btn_sell);
            this.tabPage3.Controls.Add(this.numeric_eurodizel);
            this.tabPage3.Controls.Add(this.numeric_dizel);
            this.tabPage3.Controls.Add(this.numeric_benzin97);
            this.tabPage3.Controls.Add(this.numeric_benzin95);
            this.tabPage3.Controls.Add(this.numeric_lpg);
            this.tabPage3.Controls.Add(this.cBox_fueltype);
            this.tabPage3.Controls.Add(this.label22);
            this.tabPage3.Controls.Add(this.label17);
            this.tabPage3.Controls.Add(this.label18);
            this.tabPage3.Controls.Add(this.label19);
            this.tabPage3.Controls.Add(this.label20);
            this.tabPage3.Controls.Add(this.label21);
            this.tabPage3.Location = new System.Drawing.Point(4, 32);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(792, 414);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "SATIŞ YAP";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btn_sell
            // 
            this.btn_sell.Location = new System.Drawing.Point(486, 193);
            this.btn_sell.Name = "btn_sell";
            this.btn_sell.Size = new System.Drawing.Size(170, 30);
            this.btn_sell.TabIndex = 32;
            this.btn_sell.Text = "SATIŞ YAP";
            this.btn_sell.UseVisualStyleBackColor = true;
            this.btn_sell.Click += new System.EventHandler(this.btn_sell_Click);
            // 
            // numeric_eurodizel
            // 
            this.numeric_eurodizel.Location = new System.Drawing.Point(301, 243);
            this.numeric_eurodizel.Name = "numeric_eurodizel";
            this.numeric_eurodizel.Size = new System.Drawing.Size(120, 30);
            this.numeric_eurodizel.TabIndex = 31;
            // 
            // numeric_dizel
            // 
            this.numeric_dizel.Location = new System.Drawing.Point(301, 193);
            this.numeric_dizel.Name = "numeric_dizel";
            this.numeric_dizel.Size = new System.Drawing.Size(120, 30);
            this.numeric_dizel.TabIndex = 30;
            // 
            // numeric_benzin97
            // 
            this.numeric_benzin97.Location = new System.Drawing.Point(301, 146);
            this.numeric_benzin97.Name = "numeric_benzin97";
            this.numeric_benzin97.Size = new System.Drawing.Size(120, 30);
            this.numeric_benzin97.TabIndex = 29;
            // 
            // numeric_benzin95
            // 
            this.numeric_benzin95.Location = new System.Drawing.Point(301, 97);
            this.numeric_benzin95.Name = "numeric_benzin95";
            this.numeric_benzin95.Size = new System.Drawing.Size(120, 30);
            this.numeric_benzin95.TabIndex = 28;
            // 
            // numeric_lpg
            // 
            this.numeric_lpg.Location = new System.Drawing.Point(301, 300);
            this.numeric_lpg.Name = "numeric_lpg";
            this.numeric_lpg.Size = new System.Drawing.Size(120, 30);
            this.numeric_lpg.TabIndex = 27;
            // 
            // cBox_fueltype
            // 
            this.cBox_fueltype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBox_fueltype.FormattingEnabled = true;
            this.cBox_fueltype.Location = new System.Drawing.Point(301, 52);
            this.cBox_fueltype.Name = "cBox_fueltype";
            this.cBox_fueltype.Size = new System.Drawing.Size(249, 31);
            this.cBox_fueltype.TabIndex = 26;
            this.cBox_fueltype.SelectedIndexChanged += new System.EventHandler(this.cBox_fueltype_SelectedIndexChanged);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(153, 55);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(103, 23);
            this.label22.TabIndex = 25;
            this.label22.Text = "YAKIT TÜRÜ";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label17.Location = new System.Drawing.Point(151, 302);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(40, 23);
            this.label17.TabIndex = 24;
            this.label17.Text = "LPG";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label18.Location = new System.Drawing.Point(151, 250);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(104, 23);
            this.label18.TabIndex = 23;
            this.label18.Text = "EURO DİZEL";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label19.Location = new System.Drawing.Point(151, 200);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(54, 23);
            this.label19.TabIndex = 22;
            this.label19.Text = "DİZEL";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label20.Location = new System.Drawing.Point(151, 148);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(105, 23);
            this.label20.TabIndex = 21;
            this.label20.Text = "BENZİN (97)";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label21.Location = new System.Drawing.Point(151, 97);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(105, 23);
            this.label21.TabIndex = 20;
            this.label21.Text = "BENZİN (95)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(153, 365);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 23);
            this.label1.TabIndex = 33;
            this.label1.Text = "ÖDENECEK TUTAR: ";
            // 
            // lbl_pay
            // 
            this.lbl_pay.AutoSize = true;
            this.lbl_pay.Location = new System.Drawing.Point(320, 365);
            this.lbl_pay.Name = "lbl_pay";
            this.lbl_pay.Size = new System.Drawing.Size(108, 23);
            this.lbl_pay.TabIndex = 34;
            this.lbl_pay.Text = "______________";
            // 
            // btn_updateprice
            // 
            this.btn_updateprice.Location = new System.Drawing.Point(389, 334);
            this.btn_updateprice.Name = "btn_updateprice";
            this.btn_updateprice.Size = new System.Drawing.Size(137, 30);
            this.btn_updateprice.TabIndex = 33;
            this.btn_updateprice.Text = "GÜNCELLE";
            this.btn_updateprice.UseVisualStyleBackColor = true;
            this.btn_updateprice.Click += new System.EventHandler(this.btn_updateprice_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.yakit_tabbedpane);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.yakit_tabbedpane.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_eurodizel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_dizel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_benzin97)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_benzin95)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_lpg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl yakit_tabbedpane;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lbl_depolpg;
        private System.Windows.Forms.Label lbl_depoeurodizel;
        private System.Windows.Forms.Label lbl_depodizel;
        private System.Windows.Forms.Label lbl_depobenzin97;
        private System.Windows.Forms.Label lbl_depobenzin95;
        private System.Windows.Forms.Label lbl_lpg;
        private System.Windows.Forms.Label lbl_eurodizel;
        private System.Windows.Forms.Label lbl_dizel;
        private System.Windows.Forms.Label lbl_benzin97;
        private System.Windows.Forms.Label lbl_benzin95;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox tBox_depolpg;
        private System.Windows.Forms.TextBox tBox_depobenzin95;
        private System.Windows.Forms.TextBox tBox_depobenzin97;
        private System.Windows.Forms.TextBox tBox_depodizel;
        private System.Windows.Forms.TextBox tBox_depoeurodizel;
        private System.Windows.Forms.Button btn_updateinfo;
        private System.Windows.Forms.ProgressBar pBar_benzin95;
        private System.Windows.Forms.ProgressBar pBar_benzin97;
        private System.Windows.Forms.ProgressBar pBar_dizel;
        private System.Windows.Forms.ProgressBar pBar_eurodizel;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ProgressBar pBar_lpg;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tBox_discountlpg;
        private System.Windows.Forms.TextBox tBox_discountbenzin95;
        private System.Windows.Forms.TextBox tBox_discountbenzin97;
        private System.Windows.Forms.TextBox tBox_discountdizel;
        private System.Windows.Forms.TextBox tBox_discounteurodizel;
        private System.Windows.Forms.Label lbl_discountlpg;
        private System.Windows.Forms.Label lbl_discounteurodizel;
        private System.Windows.Forms.Label lbl_discountdizel;
        private System.Windows.Forms.Label lbl_discountbenzin97;
        private System.Windows.Forms.Label lbl_discountbenzin95;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btn_sell;
        private System.Windows.Forms.NumericUpDown numeric_eurodizel;
        private System.Windows.Forms.NumericUpDown numeric_dizel;
        private System.Windows.Forms.NumericUpDown numeric_benzin97;
        private System.Windows.Forms.NumericUpDown numeric_benzin95;
        private System.Windows.Forms.NumericUpDown numeric_lpg;
        private System.Windows.Forms.ComboBox cBox_fueltype;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button btn_updateprice;
        private System.Windows.Forms.Label lbl_pay;
        private System.Windows.Forms.Label label1;
    }
}

