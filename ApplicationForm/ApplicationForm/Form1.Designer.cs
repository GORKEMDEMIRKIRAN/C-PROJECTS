namespace ApplicationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.email = new System.Windows.Forms.TextBox();
            this.communication = new System.Windows.Forms.ComboBox();
            this.phone = new System.Windows.Forms.MaskedTextBox();
            this.company = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.project_target = new System.Windows.Forms.TextBox();
            this.project_scope = new System.Windows.Forms.ComboBox();
            this.project_type = new System.Windows.Forms.ComboBox();
            this.project_name = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.entegration = new System.Windows.Forms.TextBox();
            this.technology = new System.Windows.Forms.TextBox();
            this.system = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.hours = new System.Windows.Forms.MaskedTextBox();
            this.project_date = new System.Windows.Forms.MaskedTextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.extra = new System.Windows.Forms.RichTextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.money = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1070, 170);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Moccasin;
            this.groupBox1.Controls.Add(this.email);
            this.groupBox1.Controls.Add(this.communication);
            this.groupBox1.Controls.Add(this.phone);
            this.groupBox1.Controls.Add(this.company);
            this.groupBox1.Controls.Add(this.name);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(12, 173);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(551, 236);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "KİŞİSEL BİLGİLER";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Moccasin;
            this.groupBox2.Controls.Add(this.money);
            this.groupBox2.Controls.Add(this.project_target);
            this.groupBox2.Controls.Add(this.project_scope);
            this.groupBox2.Controls.Add(this.project_type);
            this.groupBox2.Controls.Add(this.project_name);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox2.Location = new System.Drawing.Point(13, 415);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(550, 205);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "PROJE BİLGİLERİ";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Moccasin;
            this.groupBox3.Controls.Add(this.entegration);
            this.groupBox3.Controls.Add(this.technology);
            this.groupBox3.Controls.Add(this.system);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox3.Location = new System.Drawing.Point(568, 173);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(487, 174);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "TEKNİK BİLGİLER";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Moccasin;
            this.groupBox4.Controls.Add(this.hours);
            this.groupBox4.Controls.Add(this.project_date);
            this.groupBox4.Controls.Add(this.label20);
            this.groupBox4.Controls.Add(this.label21);
            this.groupBox4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox4.Location = new System.Drawing.Point(569, 354);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(487, 131);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "ZAMAN ÇİZELGESİ";
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.Moccasin;
            this.groupBox5.Controls.Add(this.extra);
            this.groupBox5.Controls.Add(this.label22);
            this.groupBox5.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(568, 491);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(487, 129);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "EKSTRA BİLGİLER";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Turquoise;
            this.button1.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(667, 623);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(321, 65);
            this.button1.TabIndex = 3;
            this.button1.Text = "KAYIT İÇİN TIKLAYINIZ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // email
            // 
            this.email.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.email.Location = new System.Drawing.Point(209, 159);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(220, 22);
            this.email.TabIndex = 27;
            // 
            // communication
            // 
            this.communication.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.communication.FormattingEnabled = true;
            this.communication.Items.AddRange(new object[] {
            "Telefon",
            "E-Posta",
            "Diğer"});
            this.communication.Location = new System.Drawing.Point(209, 199);
            this.communication.Name = "communication";
            this.communication.Size = new System.Drawing.Size(138, 24);
            this.communication.TabIndex = 26;
            // 
            // phone
            // 
            this.phone.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.phone.Location = new System.Drawing.Point(209, 124);
            this.phone.Mask = "(999) 000-0000";
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(220, 22);
            this.phone.TabIndex = 25;
            // 
            // company
            // 
            this.company.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.company.Location = new System.Drawing.Point(209, 89);
            this.company.Name = "company";
            this.company.Size = new System.Drawing.Size(220, 22);
            this.company.TabIndex = 24;
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.name.Location = new System.Drawing.Point(209, 55);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(220, 22);
            this.name.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(69, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 15);
            this.label7.TabIndex = 18;
            this.label7.Text = "Adınız ve Soyadınız :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(26, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(163, 15);
            this.label8.TabIndex = 19;
            this.label8.Text = "Şirket Adı ( Zorunlu Değil) :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(137, 128);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 15);
            this.label9.TabIndex = 20;
            this.label9.Text = "Tel. No :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(95, 159);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 15);
            this.label10.TabIndex = 21;
            this.label10.Text = "E-Posta Adresi :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(90, 203);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(99, 15);
            this.label11.TabIndex = 22;
            this.label11.Text = "İletişim Tercihi :";
            // 
            // project_target
            // 
            this.project_target.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.project_target.Location = new System.Drawing.Point(373, 61);
            this.project_target.Name = "project_target";
            this.project_target.Size = new System.Drawing.Size(157, 22);
            this.project_target.TabIndex = 30;
            // 
            // project_scope
            // 
            this.project_scope.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.project_scope.FormattingEnabled = true;
            this.project_scope.Items.AddRange(new object[] {
            "Mevcut Sistem Üzerinde Geliştirme",
            "Yeni Bir Sistem Geliştirme"});
            this.project_scope.Location = new System.Drawing.Point(352, 107);
            this.project_scope.Name = "project_scope";
            this.project_scope.Size = new System.Drawing.Size(192, 23);
            this.project_scope.TabIndex = 29;
            // 
            // project_type
            // 
            this.project_type.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.project_type.FormattingEnabled = true;
            this.project_type.Items.AddRange(new object[] {
            "Web Uygulaması",
            "Mobil Uygulama",
            "Veri Yönetimi",
            "ERP",
            "CRM",
            "Diğer"});
            this.project_type.Location = new System.Drawing.Point(87, 107);
            this.project_type.Name = "project_type";
            this.project_type.Size = new System.Drawing.Size(147, 23);
            this.project_type.TabIndex = 28;
            // 
            // project_name
            // 
            this.project_name.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.project_name.Location = new System.Drawing.Point(87, 57);
            this.project_name.Name = "project_name";
            this.project_name.Size = new System.Drawing.Size(147, 22);
            this.project_name.TabIndex = 27;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(16, 61);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 15);
            this.label12.TabIndex = 22;
            this.label12.Text = "Proje Adı :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(6, 110);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(75, 15);
            this.label13.TabIndex = 23;
            this.label13.Text = "Proje Türü :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(255, 110);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(94, 15);
            this.label14.TabIndex = 24;
            this.label14.Text = "Proje Kapsamı :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(255, 64);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(98, 15);
            this.label15.TabIndex = 25;
            this.label15.Text = "Proje Hedefleri :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.Location = new System.Drawing.Point(79, 163);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(144, 15);
            this.label16.TabIndex = 26;
            this.label16.Text = "Beklenen Bütçe Aralığı :";
            // 
            // entegration
            // 
            this.entegration.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.entegration.Location = new System.Drawing.Point(229, 124);
            this.entegration.Name = "entegration";
            this.entegration.Size = new System.Drawing.Size(220, 22);
            this.entegration.TabIndex = 29;
            // 
            // technology
            // 
            this.technology.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.technology.Location = new System.Drawing.Point(229, 79);
            this.technology.Name = "technology";
            this.technology.Size = new System.Drawing.Size(220, 22);
            this.technology.TabIndex = 26;
            // 
            // system
            // 
            this.system.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.system.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.system.FormattingEnabled = true;
            this.system.Items.AddRange(new object[] {
            "ERP",
            "CRM",
            "Muhasebe Yazılımları",
            "Lojistik Yazılımları",
            "Tedarik Yazılımları",
            "Savunma Yazılımları",
            "Tasarım Yazılımları",
            "Diğer"});
            this.system.Location = new System.Drawing.Point(244, 38);
            this.system.Name = "system";
            this.system.Size = new System.Drawing.Size(189, 23);
            this.system.TabIndex = 28;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label18.Location = new System.Drawing.Point(39, 83);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(158, 15);
            this.label18.TabIndex = 25;
            this.label18.Text = "Tercih Edilen Teknolojiler :";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label17.Location = new System.Drawing.Point(26, 41);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(171, 15);
            this.label17.TabIndex = 24;
            this.label17.Text = "Kullanılan Mevcut Sistemler :";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label19.Location = new System.Drawing.Point(55, 128);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(142, 15);
            this.label19.TabIndex = 27;
            this.label19.Text = "Entegrasyon İhtiyaçları :";
            // 
            // hours
            // 
            this.hours.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hours.Location = new System.Drawing.Point(276, 90);
            this.hours.Mask = "00:00";
            this.hours.Name = "hours";
            this.hours.Size = new System.Drawing.Size(74, 22);
            this.hours.TabIndex = 25;
            this.hours.ValidatingType = typeof(System.DateTime);
            // 
            // project_date
            // 
            this.project_date.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.project_date.Location = new System.Drawing.Point(276, 49);
            this.project_date.Mask = "00/00/0000";
            this.project_date.Name = "project_date";
            this.project_date.Size = new System.Drawing.Size(113, 22);
            this.project_date.TabIndex = 22;
            this.project_date.ValidatingType = typeof(System.DateTime);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label20.Location = new System.Drawing.Point(95, 53);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(139, 15);
            this.label20.TabIndex = 23;
            this.label20.Text = "Proje Başlangıç Tarihi :";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label21.Location = new System.Drawing.Point(26, 94);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(208, 15);
            this.label21.TabIndex = 24;
            this.label21.Text = "Proje Tamamlama Beklentisi (Saat) :";
            // 
            // extra
            // 
            this.extra.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.extra.Location = new System.Drawing.Point(244, 40);
            this.extra.Name = "extra";
            this.extra.Size = new System.Drawing.Size(220, 67);
            this.extra.TabIndex = 24;
            this.extra.Text = "";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label22.Location = new System.Drawing.Point(26, 65);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(200, 15);
            this.label22.TabIndex = 23;
            this.label22.Text = "Eklemek istediğiniz diğer bilgiler :";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SkyBlue;
            this.button2.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(175, 626);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(240, 59);
            this.button2.TabIndex = 4;
            this.button2.Text = "TEMİZLEME";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Turquoise;
            this.label1.Font = new System.Drawing.Font("Algerian", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(178, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(720, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "YAZILIM DANIŞMANLIĞI ÖN TALEP FORMU";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RosyBrown;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, -3);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1070, 168);
            this.panel1.TabIndex = 0;
            // 
            // money
            // 
            this.money.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.money.Location = new System.Drawing.Point(243, 157);
            this.money.Mask = "00000000";
            this.money.Name = "money";
            this.money.Size = new System.Drawing.Size(145, 26);
            this.money.TabIndex = 32;
            this.money.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.money.ValidatingType = typeof(int);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1067, 692);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.ComboBox communication;
        private System.Windows.Forms.MaskedTextBox phone;
        private System.Windows.Forms.TextBox company;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox project_target;
        private System.Windows.Forms.ComboBox project_scope;
        private System.Windows.Forms.ComboBox project_type;
        private System.Windows.Forms.TextBox project_name;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox entegration;
        private System.Windows.Forms.TextBox technology;
        private System.Windows.Forms.ComboBox system;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.MaskedTextBox hours;
        private System.Windows.Forms.MaskedTextBox project_date;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.RichTextBox extra;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MaskedTextBox money;
    }
}

