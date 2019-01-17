namespace INTERNSHIP
{
    partial class InternshipFRM
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
            this.grbStudent = new System.Windows.Forms.GroupBox();
            this.grbCourses = new System.Windows.Forms.GroupBox();
            this.chbENM214 = new System.Windows.Forms.CheckBox();
            this.chbBİM211 = new System.Windows.Forms.CheckBox();
            this.chbBİL255 = new System.Windows.Forms.CheckBox();
            this.chbENM102 = new System.Windows.Forms.CheckBox();
            this.dtpSDate = new System.Windows.Forms.DateTimePicker();
            this.lblSDate3 = new System.Windows.Forms.Label();
            this.lblSDate2 = new System.Windows.Forms.Label();
            this.lblSDate1 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.tbSurname = new System.Windows.Forms.TextBox();
            this.tbSName = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblSName = new System.Windows.Forms.Label();
            this.grbFirm = new System.Windows.Forms.GroupBox();
            this.cbEngineer = new System.Windows.Forms.ComboBox();
            this.lblEngineer2 = new System.Windows.Forms.Label();
            this.lblEngineer1 = new System.Windows.Forms.Label();
            this.grbSaturday = new System.Windows.Forms.GroupBox();
            this.rbNoS = new System.Windows.Forms.RadioButton();
            this.rbYesS = new System.Windows.Forms.RadioButton();
            this.grbManifacturing = new System.Windows.Forms.GroupBox();
            this.rbNoM = new System.Windows.Forms.RadioButton();
            this.rbYesM = new System.Windows.Forms.RadioButton();
            this.tbWeb = new System.Windows.Forms.TextBox();
            this.lblWebsite = new System.Windows.Forms.Label();
            this.cbCity = new System.Windows.Forms.ComboBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.tbFName = new System.Windows.Forms.TextBox();
            this.lblFName = new System.Windows.Forms.Label();
            this.grbInternship = new System.Windows.Forms.GroupBox();
            this.lblEDateIntern = new System.Windows.Forms.Label();
            this.dtpEDateIntern = new System.Windows.Forms.DateTimePicker();
            this.lblSDateIntern = new System.Windows.Forms.Label();
            this.dtpSDateIntern = new System.Windows.Forms.DateTimePicker();
            this.BridgeBtn1 = new System.Windows.Forms.Button();
            this.BridgeBtn2 = new System.Windows.Forms.Button();
            this.SubmitBtn = new System.Windows.Forms.Button();
            this.BridgeBackBtn1 = new System.Windows.Forms.Button();
            this.BridgeBackBtn2 = new System.Windows.Forms.Button();
            this.grbStudent.SuspendLayout();
            this.grbCourses.SuspendLayout();
            this.grbFirm.SuspendLayout();
            this.grbSaturday.SuspendLayout();
            this.grbManifacturing.SuspendLayout();
            this.grbInternship.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbStudent
            // 
            this.grbStudent.Controls.Add(this.grbCourses);
            this.grbStudent.Controls.Add(this.dtpSDate);
            this.grbStudent.Controls.Add(this.lblSDate3);
            this.grbStudent.Controls.Add(this.lblSDate2);
            this.grbStudent.Controls.Add(this.lblSDate1);
            this.grbStudent.Controls.Add(this.tbEmail);
            this.grbStudent.Controls.Add(this.lblEmail);
            this.grbStudent.Controls.Add(this.tbID);
            this.grbStudent.Controls.Add(this.tbSurname);
            this.grbStudent.Controls.Add(this.tbSName);
            this.grbStudent.Controls.Add(this.lblID);
            this.grbStudent.Controls.Add(this.lblSurname);
            this.grbStudent.Controls.Add(this.lblSName);
            this.grbStudent.Location = new System.Drawing.Point(22, 20);
            this.grbStudent.Name = "grbStudent";
            this.grbStudent.Size = new System.Drawing.Size(300, 334);
            this.grbStudent.TabIndex = 0;
            this.grbStudent.TabStop = false;
            this.grbStudent.Text = "Student";
            // 
            // grbCourses
            // 
            this.grbCourses.Controls.Add(this.chbENM214);
            this.grbCourses.Controls.Add(this.chbBİM211);
            this.grbCourses.Controls.Add(this.chbBİL255);
            this.grbCourses.Controls.Add(this.chbENM102);
            this.grbCourses.Location = new System.Drawing.Point(9, 185);
            this.grbCourses.Name = "grbCourses";
            this.grbCourses.Size = new System.Drawing.Size(266, 124);
            this.grbCourses.TabIndex = 12;
            this.grbCourses.TabStop = false;
            this.grbCourses.Text = "Which fallowin courses are completed?";
            // 
            // chbENM214
            // 
            this.chbENM214.AutoSize = true;
            this.chbENM214.Location = new System.Drawing.Point(7, 18);
            this.chbENM214.Name = "chbENM214";
            this.chbENM214.Size = new System.Drawing.Size(247, 17);
            this.chbENM214.TabIndex = 4;
            this.chbENM214.Text = "ENM214/Manifacturing Methods and Mat. Sel.";
            this.chbENM214.UseVisualStyleBackColor = true;
            // 
            // chbBİM211
            // 
            this.chbBİM211.AutoSize = true;
            this.chbBİM211.Location = new System.Drawing.Point(7, 87);
            this.chbBİM211.Name = "chbBİM211";
            this.chbBİM211.Size = new System.Drawing.Size(160, 17);
            this.chbBİM211.TabIndex = 3;
            this.chbBİM211.Text = "BİM211/Visual Programming";
            this.chbBİM211.UseVisualStyleBackColor = true;
            // 
            // chbBİL255
            // 
            this.chbBİL255.AutoSize = true;
            this.chbBİL255.Location = new System.Drawing.Point(7, 64);
            this.chbBİL255.Name = "chbBİL255";
            this.chbBİL255.Size = new System.Drawing.Size(223, 17);
            this.chbBİL255.TabIndex = 2;
            this.chbBİL255.Text = "BİL255/AdvancedComputer Programming";
            this.chbBİL255.UseVisualStyleBackColor = true;
            // 
            // chbENM102
            // 
            this.chbENM102.AutoSize = true;
            this.chbENM102.Location = new System.Drawing.Point(7, 41);
            this.chbENM102.Name = "chbENM102";
            this.chbENM102.Size = new System.Drawing.Size(249, 17);
            this.chbENM102.TabIndex = 1;
            this.chbENM102.Text = "ENM102/Introduction to Endustrial Engineering";
            this.chbENM102.UseVisualStyleBackColor = true;
            // 
            // dtpSDate
            // 
            this.dtpSDate.Location = new System.Drawing.Point(100, 146);
            this.dtpSDate.Name = "dtpSDate";
            this.dtpSDate.Size = new System.Drawing.Size(175, 20);
            this.dtpSDate.TabIndex = 11;
            // 
            // lblSDate3
            // 
            this.lblSDate3.AutoSize = true;
            this.lblSDate3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSDate3.Location = new System.Drawing.Point(6, 165);
            this.lblSDate3.Name = "lblSDate3";
            this.lblSDate3.Size = new System.Drawing.Size(137, 13);
            this.lblSDate3.TabIndex = 10;
            this.lblSDate3.Text = "(except english praperation)";
            // 
            // lblSDate2
            // 
            this.lblSDate2.AutoSize = true;
            this.lblSDate2.Location = new System.Drawing.Point(6, 152);
            this.lblSDate2.Name = "lblSDate2";
            this.lblSDate2.Size = new System.Drawing.Size(78, 13);
            this.lblSDate2.TabIndex = 9;
            this.lblSDate2.Text = "to department :";
            // 
            // lblSDate1
            // 
            this.lblSDate1.AutoSize = true;
            this.lblSDate1.Location = new System.Drawing.Point(6, 139);
            this.lblSDate1.Name = "lblSDate1";
            this.lblSDate1.Size = new System.Drawing.Size(67, 13);
            this.lblSDate1.TabIndex = 8;
            this.lblSDate1.Text = "Starting date";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(100, 111);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(175, 20);
            this.tbEmail.TabIndex = 7;
            this.tbEmail.Text = "@anadolu.edu.tr";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(6, 114);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(42, 13);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "E-Mail :";
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(100, 82);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(175, 20);
            this.tbID.TabIndex = 5;
            // 
            // tbSurname
            // 
            this.tbSurname.Location = new System.Drawing.Point(100, 54);
            this.tbSurname.Name = "tbSurname";
            this.tbSurname.Size = new System.Drawing.Size(175, 20);
            this.tbSurname.TabIndex = 4;
            // 
            // tbSName
            // 
            this.tbSName.Location = new System.Drawing.Point(100, 24);
            this.tbSName.Name = "tbSName";
            this.tbSName.Size = new System.Drawing.Size(175, 20);
            this.tbSName.TabIndex = 3;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(6, 85);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(24, 13);
            this.lblID.TabIndex = 2;
            this.lblID.Text = "ID :";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(6, 57);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(55, 13);
            this.lblSurname.TabIndex = 1;
            this.lblSurname.Text = "Surname :";
            // 
            // lblSName
            // 
            this.lblSName.AutoSize = true;
            this.lblSName.Location = new System.Drawing.Point(6, 27);
            this.lblSName.Name = "lblSName";
            this.lblSName.Size = new System.Drawing.Size(41, 13);
            this.lblSName.TabIndex = 0;
            this.lblSName.Text = "Name :";
            // 
            // grbFirm
            // 
            this.grbFirm.Controls.Add(this.cbEngineer);
            this.grbFirm.Controls.Add(this.lblEngineer2);
            this.grbFirm.Controls.Add(this.lblEngineer1);
            this.grbFirm.Controls.Add(this.grbSaturday);
            this.grbFirm.Controls.Add(this.grbManifacturing);
            this.grbFirm.Controls.Add(this.tbWeb);
            this.grbFirm.Controls.Add(this.lblWebsite);
            this.grbFirm.Controls.Add(this.cbCity);
            this.grbFirm.Controls.Add(this.lblCity);
            this.grbFirm.Controls.Add(this.tbFName);
            this.grbFirm.Controls.Add(this.lblFName);
            this.grbFirm.Enabled = false;
            this.grbFirm.Location = new System.Drawing.Point(372, 20);
            this.grbFirm.Name = "grbFirm";
            this.grbFirm.Size = new System.Drawing.Size(300, 334);
            this.grbFirm.TabIndex = 1;
            this.grbFirm.TabStop = false;
            this.grbFirm.Text = "Firm";
            // 
            // cbEngineer
            // 
            this.cbEngineer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEngineer.FormattingEnabled = true;
            this.cbEngineer.Items.AddRange(new object[] {
            "Non",
            "1-10",
            "11-50",
            "51-100",
            "101-..."});
            this.cbEngineer.Location = new System.Drawing.Point(114, 201);
            this.cbEngineer.Name = "cbEngineer";
            this.cbEngineer.Size = new System.Drawing.Size(161, 21);
            this.cbEngineer.TabIndex = 14;
            // 
            // lblEngineer2
            // 
            this.lblEngineer2.AutoSize = true;
            this.lblEngineer2.Location = new System.Drawing.Point(12, 208);
            this.lblEngineer2.Name = "lblEngineer2";
            this.lblEngineer2.Size = new System.Drawing.Size(99, 13);
            this.lblEngineer2.TabIndex = 13;
            this.lblEngineer2.Text = "working engineers :";
            // 
            // lblEngineer1
            // 
            this.lblEngineer1.AutoSize = true;
            this.lblEngineer1.Location = new System.Drawing.Point(12, 195);
            this.lblEngineer1.Name = "lblEngineer1";
            this.lblEngineer1.Size = new System.Drawing.Size(59, 13);
            this.lblEngineer1.TabIndex = 12;
            this.lblEngineer1.Text = "Number of ";
            // 
            // grbSaturday
            // 
            this.grbSaturday.Controls.Add(this.rbNoS);
            this.grbSaturday.Controls.Add(this.rbYesS);
            this.grbSaturday.Location = new System.Drawing.Point(15, 249);
            this.grbSaturday.Name = "grbSaturday";
            this.grbSaturday.Size = new System.Drawing.Size(260, 57);
            this.grbSaturday.TabIndex = 11;
            this.grbSaturday.TabStop = false;
            this.grbSaturday.Text = "Consider Saturday as a workday?";
            // 
            // rbNoS
            // 
            this.rbNoS.AutoSize = true;
            this.rbNoS.Checked = true;
            this.rbNoS.Location = new System.Drawing.Point(167, 25);
            this.rbNoS.Name = "rbNoS";
            this.rbNoS.Size = new System.Drawing.Size(39, 17);
            this.rbNoS.TabIndex = 1;
            this.rbNoS.TabStop = true;
            this.rbNoS.Text = "No";
            this.rbNoS.UseVisualStyleBackColor = true;
            // 
            // rbYesS
            // 
            this.rbYesS.AutoSize = true;
            this.rbYesS.Location = new System.Drawing.Point(52, 25);
            this.rbYesS.Name = "rbYesS";
            this.rbYesS.Size = new System.Drawing.Size(43, 17);
            this.rbYesS.TabIndex = 0;
            this.rbYesS.TabStop = true;
            this.rbYesS.Text = "Yes";
            this.rbYesS.UseVisualStyleBackColor = true;
            // 
            // grbManifacturing
            // 
            this.grbManifacturing.Controls.Add(this.rbNoM);
            this.grbManifacturing.Controls.Add(this.rbYesM);
            this.grbManifacturing.Location = new System.Drawing.Point(15, 121);
            this.grbManifacturing.Name = "grbManifacturing";
            this.grbManifacturing.Size = new System.Drawing.Size(260, 57);
            this.grbManifacturing.TabIndex = 10;
            this.grbManifacturing.TabStop = false;
            this.grbManifacturing.Text = "Have a manifacturing workshop?";
            // 
            // rbNoM
            // 
            this.rbNoM.AutoSize = true;
            this.rbNoM.Checked = true;
            this.rbNoM.Location = new System.Drawing.Point(167, 25);
            this.rbNoM.Name = "rbNoM";
            this.rbNoM.Size = new System.Drawing.Size(39, 17);
            this.rbNoM.TabIndex = 1;
            this.rbNoM.TabStop = true;
            this.rbNoM.Text = "No";
            this.rbNoM.UseVisualStyleBackColor = true;
            // 
            // rbYesM
            // 
            this.rbYesM.AutoSize = true;
            this.rbYesM.Location = new System.Drawing.Point(52, 25);
            this.rbYesM.Name = "rbYesM";
            this.rbYesM.Size = new System.Drawing.Size(43, 17);
            this.rbYesM.TabIndex = 0;
            this.rbYesM.TabStop = true;
            this.rbYesM.Text = "Yes";
            this.rbYesM.UseVisualStyleBackColor = true;
            // 
            // tbWeb
            // 
            this.tbWeb.Location = new System.Drawing.Point(114, 85);
            this.tbWeb.Name = "tbWeb";
            this.tbWeb.Size = new System.Drawing.Size(161, 20);
            this.tbWeb.TabIndex = 9;
            // 
            // lblWebsite
            // 
            this.lblWebsite.AutoSize = true;
            this.lblWebsite.Location = new System.Drawing.Point(12, 88);
            this.lblWebsite.Name = "lblWebsite";
            this.lblWebsite.Size = new System.Drawing.Size(87, 13);
            this.lblWebsite.TabIndex = 8;
            this.lblWebsite.Text = "Website Adress :";
            // 
            // cbCity
            // 
            this.cbCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCity.FormattingEnabled = true;
            this.cbCity.Items.AddRange(new object[] {
            "ADANA",
            "ADIYAMAN",
            "AFYONKARAHİSAR",
            "AĞRI",
            "AKSARAY",
            "AMASYA",
            "ANKARA",
            "ANTALYA",
            "ARDAHAN",
            "ARTVİN",
            "AYDIN",
            "BALIKESİR",
            "BARTIN",
            "BATMAN",
            "BAYBURT",
            "BİLECİK",
            "BİNGÖL",
            "BİTLİS",
            "BOLU",
            "BURDUR",
            "BURSA",
            "ÇANAKKALE",
            "ÇANKIRI",
            "ÇORUM",
            "DENİZLİ",
            "DİYARBAKIR",
            "DÜZCE",
            "EDİRNE",
            "ELAZIĞ",
            "ERZİNCAN",
            "ERZURUM",
            "ESKİŞEHİR",
            "GAZİANTEP",
            "GİRESUN",
            "GÜMÜŞHANE",
            "HAKKARİ",
            "HATAY",
            "IĞDIR",
            "ISPARTA",
            "İSTANBUL",
            "İZMİR",
            "KAHRAMANMARAŞ",
            "KARABÜK",
            "KARAMAN",
            "KARS",
            "KASTAMONU",
            "KAYSERİ",
            "KIRIKKALE",
            "KIRKLARELİ",
            "KIRŞEHİR",
            "KİLİS",
            "KOCAELİ",
            "KONYA",
            "KÜTAHYA",
            "MALATYA",
            "MANİSA",
            "MARDİN",
            "MERSİN",
            "MUĞLA",
            "MUŞ",
            "NEVŞEHİR",
            "NİĞDE",
            "ORDU",
            "OSMANİYE",
            "RİZE",
            "SAKARYA",
            "SAMSUN",
            "SİİRT",
            "SİNOP",
            "SİVAS",
            "ŞANLI URFA",
            "ŞIRNAK",
            "TEKİRDAĞ",
            "TOKAT",
            "TRABZON",
            "TUNCELİ",
            "UŞAK",
            "VAN",
            "YALOVA",
            "YOZGAT",
            "ZONGULDAK"});
            this.cbCity.Location = new System.Drawing.Point(114, 54);
            this.cbCity.Name = "cbCity";
            this.cbCity.Size = new System.Drawing.Size(161, 21);
            this.cbCity.TabIndex = 7;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(12, 57);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(30, 13);
            this.lblCity.TabIndex = 6;
            this.lblCity.Text = "City :";
            // 
            // tbFName
            // 
            this.tbFName.Location = new System.Drawing.Point(114, 24);
            this.tbFName.Name = "tbFName";
            this.tbFName.Size = new System.Drawing.Size(161, 20);
            this.tbFName.TabIndex = 5;
            // 
            // lblFName
            // 
            this.lblFName.AutoSize = true;
            this.lblFName.Location = new System.Drawing.Point(12, 27);
            this.lblFName.Name = "lblFName";
            this.lblFName.Size = new System.Drawing.Size(41, 13);
            this.lblFName.TabIndex = 4;
            this.lblFName.Text = "Name :";
            // 
            // grbInternship
            // 
            this.grbInternship.Controls.Add(this.lblEDateIntern);
            this.grbInternship.Controls.Add(this.dtpEDateIntern);
            this.grbInternship.Controls.Add(this.lblSDateIntern);
            this.grbInternship.Controls.Add(this.dtpSDateIntern);
            this.grbInternship.Enabled = false;
            this.grbInternship.Location = new System.Drawing.Point(722, 20);
            this.grbInternship.Name = "grbInternship";
            this.grbInternship.Size = new System.Drawing.Size(300, 152);
            this.grbInternship.TabIndex = 2;
            this.grbInternship.TabStop = false;
            this.grbInternship.Text = "Internship";
            // 
            // lblEDateIntern
            // 
            this.lblEDateIntern.AutoSize = true;
            this.lblEDateIntern.Location = new System.Drawing.Point(16, 92);
            this.lblEDateIntern.Name = "lblEDateIntern";
            this.lblEDateIntern.Size = new System.Drawing.Size(75, 13);
            this.lblEDateIntern.TabIndex = 3;
            this.lblEDateIntern.Text = "Starting Date :";
            // 
            // dtpEDateIntern
            // 
            this.dtpEDateIntern.Location = new System.Drawing.Point(125, 86);
            this.dtpEDateIntern.Name = "dtpEDateIntern";
            this.dtpEDateIntern.Size = new System.Drawing.Size(169, 20);
            this.dtpEDateIntern.TabIndex = 2;
            // 
            // lblSDateIntern
            // 
            this.lblSDateIntern.AutoSize = true;
            this.lblSDateIntern.Location = new System.Drawing.Point(16, 50);
            this.lblSDateIntern.Name = "lblSDateIntern";
            this.lblSDateIntern.Size = new System.Drawing.Size(75, 13);
            this.lblSDateIntern.TabIndex = 1;
            this.lblSDateIntern.Text = "Starting Date :";
            // 
            // dtpSDateIntern
            // 
            this.dtpSDateIntern.Location = new System.Drawing.Point(125, 50);
            this.dtpSDateIntern.Name = "dtpSDateIntern";
            this.dtpSDateIntern.Size = new System.Drawing.Size(169, 20);
            this.dtpSDateIntern.TabIndex = 0;
            // 
            // BridgeBtn1
            // 
            this.BridgeBtn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BridgeBtn1.ForeColor = System.Drawing.Color.Firebrick;
            this.BridgeBtn1.Location = new System.Drawing.Point(328, 146);
            this.BridgeBtn1.Name = "BridgeBtn1";
            this.BridgeBtn1.Size = new System.Drawing.Size(38, 26);
            this.BridgeBtn1.TabIndex = 3;
            this.BridgeBtn1.Text = ">>>";
            this.BridgeBtn1.UseVisualStyleBackColor = true;
            this.BridgeBtn1.Click += new System.EventHandler(this.BridgeBtn1_Click);
            // 
            // BridgeBtn2
            // 
            this.BridgeBtn2.Enabled = false;
            this.BridgeBtn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BridgeBtn2.ForeColor = System.Drawing.Color.Firebrick;
            this.BridgeBtn2.Location = new System.Drawing.Point(678, 68);
            this.BridgeBtn2.Name = "BridgeBtn2";
            this.BridgeBtn2.Size = new System.Drawing.Size(38, 26);
            this.BridgeBtn2.TabIndex = 4;
            this.BridgeBtn2.Text = ">>>";
            this.BridgeBtn2.UseVisualStyleBackColor = true;
            this.BridgeBtn2.Click += new System.EventHandler(this.BridgeBtn2_Click);
            // 
            // SubmitBtn
            // 
            this.SubmitBtn.Enabled = false;
            this.SubmitBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SubmitBtn.ForeColor = System.Drawing.Color.Firebrick;
            this.SubmitBtn.Location = new System.Drawing.Point(783, 226);
            this.SubmitBtn.Name = "SubmitBtn";
            this.SubmitBtn.Size = new System.Drawing.Size(170, 92);
            this.SubmitBtn.TabIndex = 5;
            this.SubmitBtn.Text = "SUBMIT MY INTERNSHIP";
            this.SubmitBtn.UseVisualStyleBackColor = true;
            this.SubmitBtn.Click += new System.EventHandler(this.SubmitBtn_Click);
            // 
            // BridgeBackBtn1
            // 
            this.BridgeBackBtn1.Enabled = false;
            this.BridgeBackBtn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BridgeBackBtn1.ForeColor = System.Drawing.Color.Teal;
            this.BridgeBackBtn1.Location = new System.Drawing.Point(328, 178);
            this.BridgeBackBtn1.Name = "BridgeBackBtn1";
            this.BridgeBackBtn1.Size = new System.Drawing.Size(38, 26);
            this.BridgeBackBtn1.TabIndex = 6;
            this.BridgeBackBtn1.Text = "<<<";
            this.BridgeBackBtn1.UseVisualStyleBackColor = true;
            this.BridgeBackBtn1.Click += new System.EventHandler(this.BridgeBackBtn1_Click);
            // 
            // BridgeBackBtn2
            // 
            this.BridgeBackBtn2.Enabled = false;
            this.BridgeBackBtn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BridgeBackBtn2.ForeColor = System.Drawing.Color.Teal;
            this.BridgeBackBtn2.Location = new System.Drawing.Point(678, 100);
            this.BridgeBackBtn2.Name = "BridgeBackBtn2";
            this.BridgeBackBtn2.Size = new System.Drawing.Size(38, 26);
            this.BridgeBackBtn2.TabIndex = 7;
            this.BridgeBackBtn2.Text = "<<<";
            this.BridgeBackBtn2.UseVisualStyleBackColor = true;
            this.BridgeBackBtn2.Click += new System.EventHandler(this.BridgeBackBtn2_Click);
            // 
            // InternshipFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 452);
            this.Controls.Add(this.BridgeBackBtn2);
            this.Controls.Add(this.BridgeBackBtn1);
            this.Controls.Add(this.BridgeBtn1);
            this.Controls.Add(this.SubmitBtn);
            this.Controls.Add(this.BridgeBtn2);
            this.Controls.Add(this.grbInternship);
            this.Controls.Add(this.grbFirm);
            this.Controls.Add(this.grbStudent);
            this.Name = "InternshipFRM";
            this.Text = "Internship Acceptance Form";
            this.Load += new System.EventHandler(this.InternshipFRM_Load);
            this.grbStudent.ResumeLayout(false);
            this.grbStudent.PerformLayout();
            this.grbCourses.ResumeLayout(false);
            this.grbCourses.PerformLayout();
            this.grbFirm.ResumeLayout(false);
            this.grbFirm.PerformLayout();
            this.grbSaturday.ResumeLayout(false);
            this.grbSaturday.PerformLayout();
            this.grbManifacturing.ResumeLayout(false);
            this.grbManifacturing.PerformLayout();
            this.grbInternship.ResumeLayout(false);
            this.grbInternship.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbStudent;
        private System.Windows.Forms.GroupBox grbCourses;
        private System.Windows.Forms.CheckBox chbBİM211;
        private System.Windows.Forms.CheckBox chbBİL255;
        private System.Windows.Forms.CheckBox chbENM102;
        private System.Windows.Forms.DateTimePicker dtpSDate;
        private System.Windows.Forms.Label lblSDate3;
        private System.Windows.Forms.Label lblSDate2;
        private System.Windows.Forms.Label lblSDate1;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.TextBox tbSurname;
        private System.Windows.Forms.TextBox tbSName;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblSName;
        private System.Windows.Forms.GroupBox grbFirm;
        private System.Windows.Forms.GroupBox grbInternship;
        private System.Windows.Forms.Button BridgeBtn1;
        private System.Windows.Forms.Button BridgeBtn2;
        private System.Windows.Forms.Button SubmitBtn;
        private System.Windows.Forms.Label lblEngineer2;
        private System.Windows.Forms.Label lblEngineer1;
        private System.Windows.Forms.GroupBox grbSaturday;
        private System.Windows.Forms.RadioButton rbNoS;
        private System.Windows.Forms.RadioButton rbYesS;
        private System.Windows.Forms.GroupBox grbManifacturing;
        private System.Windows.Forms.RadioButton rbYesM;
        private System.Windows.Forms.TextBox tbWeb;
        private System.Windows.Forms.Label lblWebsite;
        private System.Windows.Forms.ComboBox cbCity;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox tbFName;
        private System.Windows.Forms.Label lblFName;
        private System.Windows.Forms.Label lblEDateIntern;
        private System.Windows.Forms.DateTimePicker dtpEDateIntern;
        private System.Windows.Forms.Label lblSDateIntern;
        private System.Windows.Forms.DateTimePicker dtpSDateIntern;
        private System.Windows.Forms.CheckBox chbENM214;
        private System.Windows.Forms.Button BridgeBackBtn1;
        private System.Windows.Forms.Button BridgeBackBtn2;
        private System.Windows.Forms.ComboBox cbEngineer;
        private System.Windows.Forms.RadioButton rbNoM;
    }
}

