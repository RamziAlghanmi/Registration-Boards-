namespace Registration
{
    partial class frmMainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainPage));
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnMax = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnMin = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnExit = new Bunifu.Framework.UI.BunifuImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuElipseMinLable = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.dateBirth = new Bunifu.Framework.UI.BunifuDatepicker();
            this.labDownloadImage = new System.Windows.Forms.LinkLabel();
            this.photo = new System.Windows.Forms.PictureBox();
            this.radMain = new System.Windows.Forms.RadioButton();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lableCheck = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.radMale = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.openFileImage = new System.Windows.Forms.OpenFileDialog();
            this.txtName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.boxMain = new System.Windows.Forms.GroupBox();
            this.labCheckPass = new System.Windows.Forms.Label();
            this.labCheckEmaile = new System.Windows.Forms.Label();
            this.comboBoxCountry = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPass = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmaile = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.labCheckAcademic = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAcademicNumber = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuElipseMax = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipseExit = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLoade = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnSave = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnClear = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuElipseMin = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.photo)).BeginInit();
            this.boxMain.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.btnMax);
            this.bunifuGradientPanel1.Controls.Add(this.btnMin);
            this.bunifuGradientPanel1.Controls.Add(this.btnExit);
            this.bunifuGradientPanel1.Controls.Add(this.label1);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.LightSeaGreen;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.PowderBlue;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.LightSkyBlue;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.LightBlue;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(510, 49);
            this.bunifuGradientPanel1.TabIndex = 0;
            // 
            // btnMax
            // 
            this.btnMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMax.BackColor = System.Drawing.Color.SeaGreen;
            this.btnMax.Image = ((System.Drawing.Image)(resources.GetObject("btnMax.Image")));
            this.btnMax.ImageActive = null;
            this.btnMax.Location = new System.Drawing.Point(437, 3);
            this.btnMax.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(34, 38);
            this.btnMax.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMax.TabIndex = 3;
            this.btnMax.TabStop = false;
            this.btnMax.Zoom = 10;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnMin
            // 
            this.btnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMin.BackColor = System.Drawing.Color.SeaGreen;
            this.btnMin.Image = ((System.Drawing.Image)(resources.GetObject("btnMin.Image")));
            this.btnMin.ImageActive = null;
            this.btnMin.Location = new System.Drawing.Point(401, 3);
            this.btnMin.Margin = new System.Windows.Forms.Padding(1);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(34, 38);
            this.btnMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMin.TabIndex = 2;
            this.btnMin.TabStop = false;
            this.btnMin.Zoom = 10;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.SeaGreen;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageActive = null;
            this.btnExit.Location = new System.Drawing.Point(473, 3);
            this.btnExit.Margin = new System.Windows.Forms.Padding(1, 1, 3, 1);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(34, 38);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnExit.TabIndex = 1;
            this.btnExit.TabStop = false;
            this.btnExit.Zoom = 10;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Baskerville Old Face", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(129, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registration Board";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuElipseMinLable
            // 
            this.bunifuElipseMinLable.ElipseRadius = 15;
            this.bunifuElipseMinLable.TargetControl = this.label1;
            // 
            // dateBirth
            // 
            this.dateBirth.BackColor = System.Drawing.Color.DarkCyan;
            this.dateBirth.BorderRadius = 0;
            this.dateBirth.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateBirth.ForeColor = System.Drawing.Color.White;
            this.dateBirth.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateBirth.FormatCustom = null;
            this.dateBirth.Location = new System.Drawing.Point(8, 64);
            this.dateBirth.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateBirth.Name = "dateBirth";
            this.dateBirth.Size = new System.Drawing.Size(196, 32);
            this.dateBirth.TabIndex = 5;
            this.dateBirth.Value = new System.DateTime(2025, 10, 12, 20, 54, 38, 631);
            // 
            // labDownloadImage
            // 
            this.labDownloadImage.AutoSize = true;
            this.labDownloadImage.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDownloadImage.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.labDownloadImage.Location = new System.Drawing.Point(44, 306);
            this.labDownloadImage.Name = "labDownloadImage";
            this.labDownloadImage.Size = new System.Drawing.Size(36, 16);
            this.labDownloadImage.TabIndex = 6;
            this.labDownloadImage.TabStop = true;
            this.labDownloadImage.Text = "تحميل";
            this.labDownloadImage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.labDownloadImage_LinkClicked);
            // 
            // photo
            // 
            this.photo.BackColor = System.Drawing.Color.LightCyan;
            this.photo.Location = new System.Drawing.Point(44, 195);
            this.photo.Name = "photo";
            this.photo.Size = new System.Drawing.Size(131, 108);
            this.photo.TabIndex = 13;
            this.photo.TabStop = false;
            // 
            // radMain
            // 
            this.radMain.AutoSize = true;
            this.radMain.Checked = true;
            this.radMain.Location = new System.Drawing.Point(146, 137);
            this.radMain.Name = "radMain";
            this.radMain.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radMain.Size = new System.Drawing.Size(49, 27);
            this.radMain.TabIndex = 11;
            this.radMain.TabStop = true;
            this.radMain.Text = "ذكر";
            this.radMain.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.LightBlue;
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label12.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label12.Location = new System.Drawing.Point(187, 108);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 25);
            this.label12.TabIndex = 9;
            this.label12.Text = "الجنس";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.LightBlue;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Location = new System.Drawing.Point(145, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(2, 25);
            this.label8.TabIndex = 5;
            // 
            // lableCheck
            // 
            this.lableCheck.AutoSize = true;
            this.lableCheck.Location = new System.Drawing.Point(141, 331);
            this.lableCheck.Name = "lableCheck";
            this.lableCheck.Size = new System.Drawing.Size(0, 23);
            this.lableCheck.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.LightBlue;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(171, 358);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 25);
            this.label6.TabIndex = 1;
            this.label6.Text = "العنوان";
            // 
            // radMale
            // 
            this.radMale.AutoSize = true;
            this.radMale.Location = new System.Drawing.Point(47, 137);
            this.radMale.Name = "radMale";
            this.radMale.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radMale.Size = new System.Drawing.Size(50, 27);
            this.radMale.TabIndex = 12;
            this.radMale.Text = "أنثى";
            this.radMale.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.LightBlue;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label9.Location = new System.Drawing.Point(181, 177);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 25);
            this.label9.TabIndex = 3;
            this.label9.Text = "صورة ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.LightBlue;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label10.Location = new System.Drawing.Point(153, 34);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 25);
            this.label10.TabIndex = 1;
            this.label10.Text = "تاريخ الميلاد";
            // 
            // openFileImage
            // 
            this.openFileImage.FileName = "openFileImage";
            this.openFileImage.Title = "اختر الصورة";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.PowderBlue;
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtName.HintForeColor = System.Drawing.Color.Empty;
            this.txtName.HintText = "";
            this.txtName.isPassword = false;
            this.txtName.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtName.LineIdleColor = System.Drawing.Color.Gray;
            this.txtName.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtName.LineThickness = 3;
            this.txtName.Location = new System.Drawing.Point(16, 63);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Padding = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.txtName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtName.Size = new System.Drawing.Size(183, 33);
            this.txtName.TabIndex = 0;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtName.Validating += new System.ComponentModel.CancelEventHandler(this.txtName_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightBlue;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(142, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "اسم الطالب";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "المعلومات الأساسية";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(65, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(110, 23);
            this.label11.TabIndex = 0;
            this.label11.Text = "المعلومات الجانبية";
            // 
            // boxMain
            // 
            this.boxMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.boxMain.BackColor = System.Drawing.Color.LightBlue;
            this.boxMain.Controls.Add(this.labCheckPass);
            this.boxMain.Controls.Add(this.labCheckEmaile);
            this.boxMain.Controls.Add(this.comboBoxCountry);
            this.boxMain.Controls.Add(this.label7);
            this.boxMain.Controls.Add(this.txtPass);
            this.boxMain.Controls.Add(this.label5);
            this.boxMain.Controls.Add(this.txtEmaile);
            this.boxMain.Controls.Add(this.labCheckAcademic);
            this.boxMain.Controls.Add(this.label4);
            this.boxMain.Controls.Add(this.txtAcademicNumber);
            this.boxMain.Controls.Add(this.lableCheck);
            this.boxMain.Controls.Add(this.label6);
            this.boxMain.Controls.Add(this.txtName);
            this.boxMain.Controls.Add(this.label3);
            this.boxMain.Controls.Add(this.label2);
            this.boxMain.Location = new System.Drawing.Point(266, 57);
            this.boxMain.Name = "boxMain";
            this.boxMain.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.boxMain.Size = new System.Drawing.Size(241, 433);
            this.boxMain.TabIndex = 9;
            this.boxMain.TabStop = false;
            // 
            // labCheckPass
            // 
            this.labCheckPass.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCheckPass.Location = new System.Drawing.Point(22, 337);
            this.labCheckPass.Name = "labCheckPass";
            this.labCheckPass.Size = new System.Drawing.Size(183, 16);
            this.labCheckPass.TabIndex = 18;
            this.labCheckPass.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labCheckEmaile
            // 
            this.labCheckEmaile.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCheckEmaile.Location = new System.Drawing.Point(25, 252);
            this.labCheckEmaile.Name = "labCheckEmaile";
            this.labCheckEmaile.Size = new System.Drawing.Size(183, 16);
            this.labCheckEmaile.TabIndex = 17;
            this.labCheckEmaile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBoxCountry
            // 
            this.comboBoxCountry.AutoCompleteCustomSource.AddRange(new string[] {
            "trtrt",
            "trtr",
            "hj",
            "jhjh"});
            this.comboBoxCountry.BackColor = System.Drawing.Color.PowderBlue;
            this.comboBoxCountry.FormattingEnabled = true;
            this.comboBoxCountry.Items.AddRange(new object[] {
            "اليمن ",
            "السعودية",
            "مصر",
            "قطر",
            "فلسطين",
            "تركيا",
            "الأردن",
            "عمان",
            "الإمارات",
            "السودان"});
            this.comboBoxCountry.Location = new System.Drawing.Point(22, 386);
            this.comboBoxCountry.Name = "comboBoxCountry";
            this.comboBoxCountry.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBoxCountry.Size = new System.Drawing.Size(183, 31);
            this.comboBoxCountry.TabIndex = 4;
            this.comboBoxCountry.Text = " ";
            this.comboBoxCountry.Validating += new System.ComponentModel.CancelEventHandler(this.comboBoxCountry_Validating);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.LightBlue;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(138, 278);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 25);
            this.label7.TabIndex = 16;
            this.label7.Text = "كلمة المرور";
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.Color.PowderBlue;
            this.txtPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPass.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPass.HintForeColor = System.Drawing.Color.Empty;
            this.txtPass.HintText = "";
            this.txtPass.isPassword = true;
            this.txtPass.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtPass.LineIdleColor = System.Drawing.Color.Gray;
            this.txtPass.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtPass.LineThickness = 3;
            this.txtPass.Location = new System.Drawing.Point(22, 307);
            this.txtPass.Margin = new System.Windows.Forms.Padding(4);
            this.txtPass.Name = "txtPass";
            this.txtPass.Padding = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.txtPass.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPass.Size = new System.Drawing.Size(183, 33);
            this.txtPass.TabIndex = 3;
            this.txtPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPass.OnValueChanged += new System.EventHandler(this.txtPass_OnValueChanged);
            this.txtPass.Validating += new System.ComponentModel.CancelEventHandler(this.txtPass_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.LightBlue;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(122, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "البريد الإكتروني";
            // 
            // txtEmaile
            // 
            this.txtEmaile.BackColor = System.Drawing.Color.PowderBlue;
            this.txtEmaile.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmaile.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtEmaile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtEmaile.HintForeColor = System.Drawing.Color.Empty;
            this.txtEmaile.HintText = "";
            this.txtEmaile.isPassword = false;
            this.txtEmaile.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtEmaile.LineIdleColor = System.Drawing.Color.Gray;
            this.txtEmaile.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtEmaile.LineThickness = 3;
            this.txtEmaile.Location = new System.Drawing.Point(22, 224);
            this.txtEmaile.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmaile.Name = "txtEmaile";
            this.txtEmaile.Padding = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.txtEmaile.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtEmaile.Size = new System.Drawing.Size(183, 33);
            this.txtEmaile.TabIndex = 2;
            this.txtEmaile.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtEmaile.OnValueChanged += new System.EventHandler(this.txtEmaile_OnValueChanged);
            this.txtEmaile.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmaile_Validating);
            // 
            // labCheckAcademic
            // 
            this.labCheckAcademic.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCheckAcademic.Location = new System.Drawing.Point(25, 174);
            this.labCheckAcademic.Name = "labCheckAcademic";
            this.labCheckAcademic.Size = new System.Drawing.Size(183, 16);
            this.labCheckAcademic.TabIndex = 12;
            this.labCheckAcademic.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LightBlue;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(122, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "الرقم الأكاديمي";
            // 
            // txtAcademicNumber
            // 
            this.txtAcademicNumber.BackColor = System.Drawing.Color.PowderBlue;
            this.txtAcademicNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAcademicNumber.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtAcademicNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAcademicNumber.HintForeColor = System.Drawing.Color.Empty;
            this.txtAcademicNumber.HintText = "";
            this.txtAcademicNumber.isPassword = false;
            this.txtAcademicNumber.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtAcademicNumber.LineIdleColor = System.Drawing.Color.Gray;
            this.txtAcademicNumber.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtAcademicNumber.LineThickness = 3;
            this.txtAcademicNumber.Location = new System.Drawing.Point(22, 137);
            this.txtAcademicNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtAcademicNumber.Name = "txtAcademicNumber";
            this.txtAcademicNumber.Padding = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.txtAcademicNumber.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtAcademicNumber.Size = new System.Drawing.Size(183, 33);
            this.txtAcademicNumber.TabIndex = 1;
            this.txtAcademicNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAcademicNumber.OnValueChanged += new System.EventHandler(this.txtAcademicNumber_OnValueChanged);
            this.txtAcademicNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumber_KeyPress);
            this.txtAcademicNumber.Validating += new System.ComponentModel.CancelEventHandler(this.txtAcademicNumber_Validating);
            // 
            // bunifuElipseMax
            // 
            this.bunifuElipseMax.ElipseRadius = 16;
            this.bunifuElipseMax.TargetControl = this.btnMax;
            // 
            // bunifuElipseExit
            // 
            this.bunifuElipseExit.ElipseRadius = 15;
            this.bunifuElipseExit.TargetControl = this.btnExit;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.BackColor = System.Drawing.Color.LightBlue;
            this.groupBox1.Controls.Add(this.btnLoade);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.dateBirth);
            this.groupBox1.Controls.Add(this.labDownloadImage);
            this.groupBox1.Controls.Add(this.photo);
            this.groupBox1.Controls.Add(this.radMale);
            this.groupBox1.Controls.Add(this.radMain);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Location = new System.Drawing.Point(9, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(243, 433);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // btnLoade
            // 
            this.btnLoade.ActiveBorderThickness = 1;
            this.btnLoade.ActiveCornerRadius = 20;
            this.btnLoade.ActiveFillColor = System.Drawing.Color.LightSeaGreen;
            this.btnLoade.ActiveForecolor = System.Drawing.Color.White;
            this.btnLoade.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnLoade.BackColor = System.Drawing.Color.LightBlue;
            this.btnLoade.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLoade.BackgroundImage")));
            this.btnLoade.ButtonText = "تحميل";
            this.btnLoade.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoade.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoade.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnLoade.IdleBorderThickness = 1;
            this.btnLoade.IdleCornerRadius = 20;
            this.btnLoade.IdleFillColor = System.Drawing.Color.MediumAquamarine;
            this.btnLoade.IdleForecolor = System.Drawing.Color.Black;
            this.btnLoade.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnLoade.Location = new System.Drawing.Point(161, 351);
            this.btnLoade.Margin = new System.Windows.Forms.Padding(0);
            this.btnLoade.Name = "btnLoade";
            this.btnLoade.Size = new System.Drawing.Size(74, 41);
            this.btnLoade.TabIndex = 16;
            this.btnLoade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLoade.Click += new System.EventHandler(this.btnLoade_Click);
            // 
            // btnSave
            // 
            this.btnSave.ActiveBorderThickness = 1;
            this.btnSave.ActiveCornerRadius = 20;
            this.btnSave.ActiveFillColor = System.Drawing.Color.LightSeaGreen;
            this.btnSave.ActiveForecolor = System.Drawing.Color.White;
            this.btnSave.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnSave.BackColor = System.Drawing.Color.LightBlue;
            this.btnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave.BackgroundImage")));
            this.btnSave.ButtonText = "حفظ";
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnSave.IdleBorderThickness = 1;
            this.btnSave.IdleCornerRadius = 20;
            this.btnSave.IdleFillColor = System.Drawing.Color.MediumAquamarine;
            this.btnSave.IdleForecolor = System.Drawing.Color.Black;
            this.btnSave.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnSave.Location = new System.Drawing.Point(8, 351);
            this.btnSave.Margin = new System.Windows.Forms.Padding(0);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 41);
            this.btnSave.TabIndex = 15;
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.ActiveBorderThickness = 1;
            this.btnClear.ActiveCornerRadius = 20;
            this.btnClear.ActiveFillColor = System.Drawing.Color.Red;
            this.btnClear.ActiveForecolor = System.Drawing.Color.White;
            this.btnClear.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnClear.BackColor = System.Drawing.Color.LightBlue;
            this.btnClear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClear.BackgroundImage")));
            this.btnClear.ButtonText = "تنظيف";
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnClear.IdleBorderThickness = 1;
            this.btnClear.IdleCornerRadius = 20;
            this.btnClear.IdleFillColor = System.Drawing.Color.Aquamarine;
            this.btnClear.IdleForecolor = System.Drawing.Color.Black;
            this.btnClear.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnClear.Location = new System.Drawing.Point(3, 392);
            this.btnClear.Margin = new System.Windows.Forms.Padding(0);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(232, 41);
            this.btnClear.TabIndex = 14;
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // bunifuElipseMin
            // 
            this.bunifuElipseMin.ElipseRadius = 15;
            this.bunifuElipseMin.TargetControl = this.btnMin;
            // 
            // frmMainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(510, 502);
            this.Controls.Add(this.boxMain);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMainPage";
            this.Load += new System.EventHandler(this.frmMainPage_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMainPage_KeyDown);
            this.bunifuGradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.photo)).EndInit();
            this.boxMain.ResumeLayout(false);
            this.boxMain.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipseMinLable;
        private Bunifu.Framework.UI.BunifuImageButton btnMax;
        private Bunifu.Framework.UI.BunifuImageButton btnMin;
        private Bunifu.Framework.UI.BunifuImageButton btnExit;
        private Bunifu.Framework.UI.BunifuDatepicker dateBirth;
        private System.Windows.Forms.LinkLabel labDownloadImage;
        private System.Windows.Forms.PictureBox photo;
        private System.Windows.Forms.RadioButton radMain;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lableCheck;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton radMale;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.OpenFileDialog openFileImage;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox boxMain;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipseMax;
        private System.Windows.Forms.GroupBox groupBox1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipseExit;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipseMin;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtAcademicNumber;
        private System.Windows.Forms.Label labCheckAcademic;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPass;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtEmaile;
        private System.Windows.Forms.ComboBox comboBoxCountry;
        private System.Windows.Forms.Label labCheckPass;
        private System.Windows.Forms.Label labCheckEmaile;
        private Bunifu.Framework.UI.BunifuThinButton2 btnLoade;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSave;
        private Bunifu.Framework.UI.BunifuThinButton2 btnClear;
    }
}

