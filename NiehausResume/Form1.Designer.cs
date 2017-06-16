namespace NiehausResume
{
    partial class FormResume
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormResume));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuBar_File = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_FileStart = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_FileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.gBox_AboutMe = new System.Windows.Forms.GroupBox();
            this.pnl_AboutMe = new System.Windows.Forms.Panel();
            this.pnl_AboutSection = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.rtb_AboutMe = new System.Windows.Forms.RichTextBox();
            this.btn_SelectAboutItem = new System.Windows.Forms.Button();
            this.lstBx_AboutMe = new System.Windows.Forms.ListBox();
            this.pBox_AboutMePic = new System.Windows.Forms.PictureBox();
            this.pnl_Start = new System.Windows.Forms.Panel();
            this.gBox_Main = new System.Windows.Forms.GroupBox();
            this.link_GitHub = new System.Windows.Forms.LinkLabel();
            this.link_LinkedIN = new System.Windows.Forms.LinkLabel();
            this.btn_SelectMain = new System.Windows.Forms.Button();
            this.cBox_ResumeCats = new System.Windows.Forms.ComboBox();
            this.lbl_Start = new System.Windows.Forms.Label();
            this.lbl_NameTop = new System.Windows.Forms.Label();
            this.gBox_Welcome = new System.Windows.Forms.GroupBox();
            this.lbl_WelcomeGB = new System.Windows.Forms.Label();
            this.gBox_Education = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_Courses = new System.Windows.Forms.Label();
            this.lbl_UMSLExpand = new System.Windows.Forms.Label();
            this.lbl_UMSL = new System.Windows.Forms.Label();
            this.gBox_Skills = new System.Windows.Forms.GroupBox();
            this.wb_Skills = new System.Windows.Forms.WebBrowser();
            this.gBox_WorkHistory = new System.Windows.Forms.GroupBox();
            this.rtb_WorkHistory = new System.Windows.Forms.RichTextBox();
            this.btn_EmpHistory = new System.Windows.Forms.Button();
            this.rb_Emmaus = new System.Windows.Forms.RadioButton();
            this.rb_DSFC = new System.Windows.Forms.RadioButton();
            this.rb_UMSL = new System.Windows.Forms.RadioButton();
            this.gBox_Objective = new System.Windows.Forms.GroupBox();
            this.lbl_ObjectiveTitle = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_Objective = new System.Windows.Forms.Label();
            this.pnl_Welcome = new System.Windows.Forms.Panel();
            this.lbl_Author = new System.Windows.Forms.Label();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.lbl_Welcome = new System.Windows.Forms.Label();
            this.btn_Explain = new System.Windows.Forms.Button();
            this.pnl_Explain = new System.Windows.Forms.Panel();
            this.btn_Whatis = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.gBox_AboutMe.SuspendLayout();
            this.pnl_AboutMe.SuspendLayout();
            this.pnl_AboutSection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_AboutMePic)).BeginInit();
            this.pnl_Start.SuspendLayout();
            this.gBox_Main.SuspendLayout();
            this.gBox_Welcome.SuspendLayout();
            this.gBox_Education.SuspendLayout();
            this.gBox_Skills.SuspendLayout();
            this.gBox_WorkHistory.SuspendLayout();
            this.gBox_Objective.SuspendLayout();
            this.pnl_Welcome.SuspendLayout();
            this.pnl_Explain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuBar_File});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(2096, 35);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuBar_File
            // 
            this.MenuBar_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_FileStart,
            this.Menu_FileExit});
            this.MenuBar_File.Font = new System.Drawing.Font("Times New Roman", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuBar_File.Name = "MenuBar_File";
            this.MenuBar_File.Size = new System.Drawing.Size(60, 31);
            this.MenuBar_File.Text = "File";
            // 
            // Menu_FileStart
            // 
            this.Menu_FileStart.Name = "Menu_FileStart";
            this.Menu_FileStart.Size = new System.Drawing.Size(147, 34);
            this.Menu_FileStart.Text = "Start";
            this.Menu_FileStart.Click += new System.EventHandler(this.Menu_FileStart_Click);
            // 
            // Menu_FileExit
            // 
            this.Menu_FileExit.Name = "Menu_FileExit";
            this.Menu_FileExit.Size = new System.Drawing.Size(147, 34);
            this.Menu_FileExit.Text = "Exit";
            this.Menu_FileExit.Click += new System.EventHandler(this.doExit);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_Exit.Location = new System.Drawing.Point(1797, 44);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(145, 45);
            this.btn_Exit.TabIndex = 3;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.doExit);
            // 
            // gBox_AboutMe
            // 
            this.gBox_AboutMe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.gBox_AboutMe.Controls.Add(this.pnl_AboutMe);
            this.gBox_AboutMe.Font = new System.Drawing.Font("Trajan Pro 3", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBox_AboutMe.Location = new System.Drawing.Point(391, 0);
            this.gBox_AboutMe.Name = "gBox_AboutMe";
            this.gBox_AboutMe.Size = new System.Drawing.Size(1480, 971);
            this.gBox_AboutMe.TabIndex = 3;
            this.gBox_AboutMe.TabStop = false;
            this.gBox_AboutMe.Text = "About Me";
            this.gBox_AboutMe.Visible = false;
            // 
            // pnl_AboutMe
            // 
            this.pnl_AboutMe.Controls.Add(this.pnl_AboutSection);
            this.pnl_AboutMe.Controls.Add(this.btn_SelectAboutItem);
            this.pnl_AboutMe.Controls.Add(this.lstBx_AboutMe);
            this.pnl_AboutMe.Controls.Add(this.pBox_AboutMePic);
            this.pnl_AboutMe.Location = new System.Drawing.Point(25, 42);
            this.pnl_AboutMe.Name = "pnl_AboutMe";
            this.pnl_AboutMe.Size = new System.Drawing.Size(1432, 905);
            this.pnl_AboutMe.TabIndex = 0;
            // 
            // pnl_AboutSection
            // 
            this.pnl_AboutSection.Controls.Add(this.label1);
            this.pnl_AboutSection.Controls.Add(this.lbl_Name);
            this.pnl_AboutSection.Controls.Add(this.rtb_AboutMe);
            this.pnl_AboutSection.Location = new System.Drawing.Point(421, 16);
            this.pnl_AboutSection.Name = "pnl_AboutSection";
            this.pnl_AboutSection.Size = new System.Drawing.Size(992, 870);
            this.pnl_AboutSection.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.Font = new System.Drawing.Font("Trajan Pro 3", 9.857142F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(315, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(362, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "636-432-3355";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Name
            // 
            this.lbl_Name.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_Name.Font = new System.Drawing.Font("Trajan Pro 3", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.Location = new System.Drawing.Point(71, 18);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(851, 56);
            this.lbl_Name.TabIndex = 1;
            this.lbl_Name.Text = "Christopher ( Chris ) L. Niehaus\r\n\r\n";
            this.lbl_Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rtb_AboutMe
            // 
            this.rtb_AboutMe.Font = new System.Drawing.Font("Times New Roman", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtb_AboutMe.Location = new System.Drawing.Point(25, 102);
            this.rtb_AboutMe.Name = "rtb_AboutMe";
            this.rtb_AboutMe.ReadOnly = true;
            this.rtb_AboutMe.Size = new System.Drawing.Size(948, 751);
            this.rtb_AboutMe.TabIndex = 0;
            this.rtb_AboutMe.Text = "";
            // 
            // btn_SelectAboutItem
            // 
            this.btn_SelectAboutItem.Font = new System.Drawing.Font("Times New Roman", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SelectAboutItem.Location = new System.Drawing.Point(137, 447);
            this.btn_SelectAboutItem.Name = "btn_SelectAboutItem";
            this.btn_SelectAboutItem.Size = new System.Drawing.Size(97, 45);
            this.btn_SelectAboutItem.TabIndex = 4;
            this.btn_SelectAboutItem.Text = "View";
            this.btn_SelectAboutItem.UseVisualStyleBackColor = true;
            this.btn_SelectAboutItem.Click += new System.EventHandler(this.btn_AboutMeSelect);
            // 
            // lstBx_AboutMe
            // 
            this.lstBx_AboutMe.FormattingEnabled = true;
            this.lstBx_AboutMe.ItemHeight = 28;
            this.lstBx_AboutMe.Items.AddRange(new object[] {
            "About Me",
            "Family",
            "Hobbies"});
            this.lstBx_AboutMe.Location = new System.Drawing.Point(76, 308);
            this.lstBx_AboutMe.Name = "lstBx_AboutMe";
            this.lstBx_AboutMe.Size = new System.Drawing.Size(227, 116);
            this.lstBx_AboutMe.TabIndex = 5;
            // 
            // pBox_AboutMePic
            // 
            this.pBox_AboutMePic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pBox_AboutMePic.Image = global::NiehausResume.Properties.Resources.Resize;
            this.pBox_AboutMePic.Location = new System.Drawing.Point(76, 58);
            this.pBox_AboutMePic.Name = "pBox_AboutMePic";
            this.pBox_AboutMePic.Size = new System.Drawing.Size(227, 219);
            this.pBox_AboutMePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBox_AboutMePic.TabIndex = 0;
            this.pBox_AboutMePic.TabStop = false;
            // 
            // pnl_Start
            // 
            this.pnl_Start.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_Start.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnl_Start.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnl_Start.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_Start.Controls.Add(this.gBox_Main);
            this.pnl_Start.Controls.Add(this.gBox_AboutMe);
            this.pnl_Start.Controls.Add(this.gBox_Welcome);
            this.pnl_Start.Controls.Add(this.gBox_Education);
            this.pnl_Start.Controls.Add(this.gBox_Skills);
            this.pnl_Start.Controls.Add(this.gBox_WorkHistory);
            this.pnl_Start.Controls.Add(this.gBox_Objective);
            this.pnl_Start.Location = new System.Drawing.Point(111, 177);
            this.pnl_Start.Name = "pnl_Start";
            this.pnl_Start.Size = new System.Drawing.Size(1874, 1070);
            this.pnl_Start.TabIndex = 4;
            this.pnl_Start.Visible = false;
            // 
            // gBox_Main
            // 
            this.gBox_Main.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gBox_Main.Controls.Add(this.link_GitHub);
            this.gBox_Main.Controls.Add(this.link_LinkedIN);
            this.gBox_Main.Controls.Add(this.btn_SelectMain);
            this.gBox_Main.Controls.Add(this.cBox_ResumeCats);
            this.gBox_Main.Controls.Add(this.lbl_Start);
            this.gBox_Main.Controls.Add(this.lbl_NameTop);
            this.gBox_Main.Font = new System.Drawing.Font("Trajan Pro 3", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBox_Main.Location = new System.Drawing.Point(15, 0);
            this.gBox_Main.Name = "gBox_Main";
            this.gBox_Main.Size = new System.Drawing.Size(370, 1063);
            this.gBox_Main.TabIndex = 2;
            this.gBox_Main.TabStop = false;
            this.gBox_Main.Text = "Menu";
            // 
            // link_GitHub
            // 
            this.link_GitHub.AutoSize = true;
            this.link_GitHub.Location = new System.Drawing.Point(118, 586);
            this.link_GitHub.Name = "link_GitHub";
            this.link_GitHub.Size = new System.Drawing.Size(134, 29);
            this.link_GitHub.TabIndex = 5;
            this.link_GitHub.TabStop = true;
            this.link_GitHub.Text = "My Github";
            this.link_GitHub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_GitHub_LinkClicked);
            // 
            // link_LinkedIN
            // 
            this.link_LinkedIN.AutoSize = true;
            this.link_LinkedIN.Location = new System.Drawing.Point(107, 541);
            this.link_LinkedIN.Name = "link_LinkedIN";
            this.link_LinkedIN.Size = new System.Drawing.Size(157, 29);
            this.link_LinkedIN.TabIndex = 4;
            this.link_LinkedIN.TabStop = true;
            this.link_LinkedIN.Text = "My LinkedIn";
            this.link_LinkedIN.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_LinkedIN_LinkClicked);
            // 
            // btn_SelectMain
            // 
            this.btn_SelectMain.Font = new System.Drawing.Font("Times New Roman", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SelectMain.Location = new System.Drawing.Point(137, 400);
            this.btn_SelectMain.Name = "btn_SelectMain";
            this.btn_SelectMain.Size = new System.Drawing.Size(97, 45);
            this.btn_SelectMain.TabIndex = 2;
            this.btn_SelectMain.Text = "Select";
            this.btn_SelectMain.UseVisualStyleBackColor = true;
            this.btn_SelectMain.Click += new System.EventHandler(this.btn_SelectMain_Click);
            // 
            // cBox_ResumeCats
            // 
            this.cBox_ResumeCats.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cBox_ResumeCats.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cBox_ResumeCats.Items.AddRange(new object[] {
            "Objective",
            "About Me",
            "Education",
            "Skills",
            "Work History"});
            this.cBox_ResumeCats.Location = new System.Drawing.Point(76, 316);
            this.cBox_ResumeCats.Name = "cBox_ResumeCats";
            this.cBox_ResumeCats.Size = new System.Drawing.Size(219, 36);
            this.cBox_ResumeCats.TabIndex = 1;
            this.cBox_ResumeCats.Text = "-Select-";
            this.cBox_ResumeCats.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.noEditComboBox);
            // 
            // lbl_Start
            // 
            this.lbl_Start.Font = new System.Drawing.Font("Times New Roman", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Start.Location = new System.Drawing.Point(34, 192);
            this.lbl_Start.Name = "lbl_Start";
            this.lbl_Start.Size = new System.Drawing.Size(303, 71);
            this.lbl_Start.TabIndex = 0;
            this.lbl_Start.Text = "What would you like to learn about me?";
            this.lbl_Start.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_NameTop
            // 
            this.lbl_NameTop.Font = new System.Drawing.Font("Trajan Pro 3", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NameTop.Location = new System.Drawing.Point(33, 45);
            this.lbl_NameTop.Name = "lbl_NameTop";
            this.lbl_NameTop.Size = new System.Drawing.Size(304, 121);
            this.lbl_NameTop.TabIndex = 3;
            this.lbl_NameTop.Text = "Christopher L. Niehaus";
            this.lbl_NameTop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gBox_Welcome
            // 
            this.gBox_Welcome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.gBox_Welcome.Controls.Add(this.lbl_WelcomeGB);
            this.gBox_Welcome.Font = new System.Drawing.Font("Trajan Pro 3", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBox_Welcome.Location = new System.Drawing.Point(391, 0);
            this.gBox_Welcome.Name = "gBox_Welcome";
            this.gBox_Welcome.Size = new System.Drawing.Size(1580, 1090);
            this.gBox_Welcome.TabIndex = 6;
            this.gBox_Welcome.TabStop = false;
            this.gBox_Welcome.Text = "Welcome";
            this.gBox_Welcome.Visible = false;
            // 
            // lbl_WelcomeGB
            // 
            this.lbl_WelcomeGB.Font = new System.Drawing.Font("Trajan Pro 3", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_WelcomeGB.Location = new System.Drawing.Point(232, 286);
            this.lbl_WelcomeGB.Name = "lbl_WelcomeGB";
            this.lbl_WelcomeGB.Size = new System.Drawing.Size(1017, 399);
            this.lbl_WelcomeGB.TabIndex = 0;
            this.lbl_WelcomeGB.Text = "Use the Drop Down Box to the left and choose a category";
            this.lbl_WelcomeGB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gBox_Education
            // 
            this.gBox_Education.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.gBox_Education.Controls.Add(this.label2);
            this.gBox_Education.Controls.Add(this.lbl_Courses);
            this.gBox_Education.Controls.Add(this.lbl_UMSLExpand);
            this.gBox_Education.Controls.Add(this.lbl_UMSL);
            this.gBox_Education.Font = new System.Drawing.Font("Trajan Pro 3", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBox_Education.Location = new System.Drawing.Point(391, 0);
            this.gBox_Education.Name = "gBox_Education";
            this.gBox_Education.Size = new System.Drawing.Size(1480, 971);
            this.gBox_Education.TabIndex = 5;
            this.gBox_Education.TabStop = false;
            this.gBox_Education.Text = "Education";
            this.gBox_Education.Visible = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Trajan Pro 3", 11.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(262, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(985, 43);
            this.label2.TabIndex = 3;
            this.label2.Text = "Information Systems and Business Related Coursework\r\n\r\n";
            // 
            // lbl_Courses
            // 
            this.lbl_Courses.Font = new System.Drawing.Font("Trajan Pro 3", 9.857142F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Courses.Location = new System.Drawing.Point(315, 318);
            this.lbl_Courses.Name = "lbl_Courses";
            this.lbl_Courses.Size = new System.Drawing.Size(365, 438);
            this.lbl_Courses.TabIndex = 2;
            this.lbl_Courses.Text = resources.GetString("lbl_Courses.Text");
            // 
            // lbl_UMSLExpand
            // 
            this.lbl_UMSLExpand.Font = new System.Drawing.Font("Trajan Pro 3", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UMSLExpand.Location = new System.Drawing.Point(262, 141);
            this.lbl_UMSLExpand.Name = "lbl_UMSLExpand";
            this.lbl_UMSLExpand.Size = new System.Drawing.Size(985, 80);
            this.lbl_UMSLExpand.TabIndex = 1;
            this.lbl_UMSLExpand.Text = "- Under Graduate | BS Information Systems | December 2018\r\n- Current GPA (Spring " +
    "2017) 3.415\r\n\r\n";
            // 
            // lbl_UMSL
            // 
            this.lbl_UMSL.Font = new System.Drawing.Font("Trajan Pro 3", 15.85714F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UMSL.Location = new System.Drawing.Point(234, 95);
            this.lbl_UMSL.Name = "lbl_UMSL";
            this.lbl_UMSL.Size = new System.Drawing.Size(853, 46);
            this.lbl_UMSL.TabIndex = 0;
            this.lbl_UMSL.Text = "University of Missouri St. Louis";
            // 
            // gBox_Skills
            // 
            this.gBox_Skills.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.gBox_Skills.Controls.Add(this.wb_Skills);
            this.gBox_Skills.Font = new System.Drawing.Font("Trajan Pro 3", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBox_Skills.Location = new System.Drawing.Point(391, 0);
            this.gBox_Skills.Name = "gBox_Skills";
            this.gBox_Skills.Size = new System.Drawing.Size(1480, 971);
            this.gBox_Skills.TabIndex = 5;
            this.gBox_Skills.TabStop = false;
            this.gBox_Skills.Text = "Skills";
            this.gBox_Skills.Visible = false;
            // 
            // wb_Skills
            // 
            this.wb_Skills.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wb_Skills.Location = new System.Drawing.Point(3, 26);
            this.wb_Skills.MinimumSize = new System.Drawing.Size(18, 18);
            this.wb_Skills.Name = "wb_Skills";
            this.wb_Skills.ScriptErrorsSuppressed = true;
            this.wb_Skills.Size = new System.Drawing.Size(1474, 942);
            this.wb_Skills.TabIndex = 0;
            this.wb_Skills.Url = new System.Uri("https://niehausresume.wordpress.com/2017/06/08/resumeshowwebbrowser/", System.UriKind.Absolute);
            // 
            // gBox_WorkHistory
            // 
            this.gBox_WorkHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.gBox_WorkHistory.Controls.Add(this.rtb_WorkHistory);
            this.gBox_WorkHistory.Controls.Add(this.btn_EmpHistory);
            this.gBox_WorkHistory.Controls.Add(this.rb_Emmaus);
            this.gBox_WorkHistory.Controls.Add(this.rb_DSFC);
            this.gBox_WorkHistory.Controls.Add(this.rb_UMSL);
            this.gBox_WorkHistory.Font = new System.Drawing.Font("Trajan Pro 3", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBox_WorkHistory.Location = new System.Drawing.Point(391, 0);
            this.gBox_WorkHistory.Name = "gBox_WorkHistory";
            this.gBox_WorkHistory.Size = new System.Drawing.Size(1480, 971);
            this.gBox_WorkHistory.TabIndex = 5;
            this.gBox_WorkHistory.TabStop = false;
            this.gBox_WorkHistory.Text = "Work History";
            this.gBox_WorkHistory.Visible = false;
            // 
            // rtb_WorkHistory
            // 
            this.rtb_WorkHistory.Font = new System.Drawing.Font("Times New Roman", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtb_WorkHistory.Location = new System.Drawing.Point(434, 42);
            this.rtb_WorkHistory.Name = "rtb_WorkHistory";
            this.rtb_WorkHistory.ReadOnly = true;
            this.rtb_WorkHistory.Size = new System.Drawing.Size(1023, 905);
            this.rtb_WorkHistory.TabIndex = 4;
            this.rtb_WorkHistory.Text = "";
            // 
            // btn_EmpHistory
            // 
            this.btn_EmpHistory.Location = new System.Drawing.Point(101, 248);
            this.btn_EmpHistory.Name = "btn_EmpHistory";
            this.btn_EmpHistory.Size = new System.Drawing.Size(120, 44);
            this.btn_EmpHistory.TabIndex = 3;
            this.btn_EmpHistory.Text = "View";
            this.btn_EmpHistory.UseVisualStyleBackColor = true;
            this.btn_EmpHistory.Click += new System.EventHandler(this.btn_EmpHistory_Click);
            // 
            // rb_Emmaus
            // 
            this.rb_Emmaus.AutoSize = true;
            this.rb_Emmaus.Location = new System.Drawing.Point(61, 188);
            this.rb_Emmaus.Name = "rb_Emmaus";
            this.rb_Emmaus.Size = new System.Drawing.Size(210, 33);
            this.rb_Emmaus.TabIndex = 2;
            this.rb_Emmaus.TabStop = true;
            this.rb_Emmaus.Text = "Emmaus Homes ";
            this.rb_Emmaus.UseVisualStyleBackColor = true;
            // 
            // rb_DSFC
            // 
            this.rb_DSFC.AutoSize = true;
            this.rb_DSFC.Location = new System.Drawing.Point(61, 144);
            this.rb_DSFC.Name = "rb_DSFC";
            this.rb_DSFC.Size = new System.Drawing.Size(303, 33);
            this.rb_DSFC.TabIndex = 1;
            this.rb_DSFC.TabStop = true;
            this.rb_DSFC.Text = "Developmental Services";
            this.rb_DSFC.UseVisualStyleBackColor = true;
            // 
            // rb_UMSL
            // 
            this.rb_UMSL.AutoSize = true;
            this.rb_UMSL.Location = new System.Drawing.Point(61, 100);
            this.rb_UMSL.Name = "rb_UMSL";
            this.rb_UMSL.Size = new System.Drawing.Size(99, 33);
            this.rb_UMSL.TabIndex = 0;
            this.rb_UMSL.TabStop = true;
            this.rb_UMSL.Text = "UMSL";
            this.rb_UMSL.UseVisualStyleBackColor = true;
            // 
            // gBox_Objective
            // 
            this.gBox_Objective.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.gBox_Objective.Controls.Add(this.lbl_ObjectiveTitle);
            this.gBox_Objective.Controls.Add(this.label4);
            this.gBox_Objective.Controls.Add(this.label3);
            this.gBox_Objective.Controls.Add(this.lbl_Objective);
            this.gBox_Objective.Font = new System.Drawing.Font("Trajan Pro 3", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBox_Objective.Location = new System.Drawing.Point(391, 0);
            this.gBox_Objective.Name = "gBox_Objective";
            this.gBox_Objective.Size = new System.Drawing.Size(1480, 971);
            this.gBox_Objective.TabIndex = 4;
            this.gBox_Objective.TabStop = false;
            this.gBox_Objective.Text = "Objective";
            this.gBox_Objective.Visible = false;
            // 
            // lbl_ObjectiveTitle
            // 
            this.lbl_ObjectiveTitle.Font = new System.Drawing.Font("Trajan Pro 3", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ObjectiveTitle.Location = new System.Drawing.Point(379, 75);
            this.lbl_ObjectiveTitle.Name = "lbl_ObjectiveTitle";
            this.lbl_ObjectiveTitle.Size = new System.Drawing.Size(723, 84);
            this.lbl_ObjectiveTitle.TabIndex = 3;
            this.lbl_ObjectiveTitle.Text = "My Objective";
            this.lbl_ObjectiveTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Trajan Pro 3", 15.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(393, 600);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(734, 52);
            this.label4.TabIndex = 2;
            this.label4.Text = "-Pablo Picasso\r\n";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Trajan Pro 3", 15.85714F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(159, 530);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1163, 58);
            this.label3.TabIndex = 1;
            this.label3.Text = "\"Action is the fundamental key to all success.\"";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Objective
            // 
            this.lbl_Objective.Font = new System.Drawing.Font("Trajan Pro 3", 15.85714F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Objective.Location = new System.Drawing.Point(168, 248);
            this.lbl_Objective.Name = "lbl_Objective";
            this.lbl_Objective.Size = new System.Drawing.Size(1144, 178);
            this.lbl_Objective.TabIndex = 0;
            this.lbl_Objective.Text = "Start a career in software development and to continue to learn and develop my sk" +
    "ill set.\r\n";
            this.lbl_Objective.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnl_Welcome
            // 
            this.pnl_Welcome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_Welcome.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnl_Welcome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnl_Welcome.Controls.Add(this.lbl_Author);
            this.pnl_Welcome.Controls.Add(this.lbl_Date);
            this.pnl_Welcome.Controls.Add(this.lbl_Welcome);
            this.pnl_Welcome.Location = new System.Drawing.Point(539, 124);
            this.pnl_Welcome.Name = "pnl_Welcome";
            this.pnl_Welcome.Size = new System.Drawing.Size(1018, 364);
            this.pnl_Welcome.TabIndex = 0;
            // 
            // lbl_Author
            // 
            this.lbl_Author.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Author.Font = new System.Drawing.Font("Trajan Pro 3", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Author.Location = new System.Drawing.Point(102, 165);
            this.lbl_Author.Name = "lbl_Author";
            this.lbl_Author.Size = new System.Drawing.Size(751, 112);
            this.lbl_Author.TabIndex = 1;
            this.lbl_Author.Text = "Created by Chris Niehaus";
            this.lbl_Author.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Date
            // 
            this.lbl_Date.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Date.Font = new System.Drawing.Font("Trajan Pro 3", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Date.Location = new System.Drawing.Point(146, 273);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(663, 112);
            this.lbl_Date.TabIndex = 2;
            this.lbl_Date.Text = "Go to Menu > File > Start";
            this.lbl_Date.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Welcome
            // 
            this.lbl_Welcome.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Welcome.Font = new System.Drawing.Font("Trajan Pro 3", 27.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Welcome.Location = new System.Drawing.Point(22, 58);
            this.lbl_Welcome.Name = "lbl_Welcome";
            this.lbl_Welcome.Size = new System.Drawing.Size(912, 112);
            this.lbl_Welcome.TabIndex = 0;
            this.lbl_Welcome.Text = "Welcome to My Resume";
            this.lbl_Welcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Explain
            // 
            this.btn_Explain.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Explain.Location = new System.Drawing.Point(841, 28);
            this.btn_Explain.Name = "btn_Explain";
            this.btn_Explain.Size = new System.Drawing.Size(352, 76);
            this.btn_Explain.TabIndex = 7;
            this.btn_Explain.Text = "What is going on?";
            this.btn_Explain.UseVisualStyleBackColor = true;
            this.btn_Explain.Click += new System.EventHandler(this.btn_Explain_Click);
            // 
            // pnl_Explain
            // 
            this.pnl_Explain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnl_Explain.Controls.Add(this.btn_Whatis);
            this.pnl_Explain.Controls.Add(this.btn_Exit);
            this.pnl_Explain.Controls.Add(this.btn_Explain);
            this.pnl_Explain.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_Explain.Location = new System.Drawing.Point(0, 1275);
            this.pnl_Explain.Name = "pnl_Explain";
            this.pnl_Explain.Size = new System.Drawing.Size(2096, 132);
            this.pnl_Explain.TabIndex = 5;
            // 
            // btn_Whatis
            // 
            this.btn_Whatis.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Whatis.Location = new System.Drawing.Point(1199, 28);
            this.btn_Whatis.Name = "btn_Whatis";
            this.btn_Whatis.Size = new System.Drawing.Size(352, 76);
            this.btn_Whatis.TabIndex = 9;
            this.btn_Whatis.Text = "What is \"What is going on\"?";
            this.btn_Whatis.UseVisualStyleBackColor = true;
            this.btn_Whatis.Click += new System.EventHandler(this.btn_Whatis_Click);
            // 
            // FormResume
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(168F, 168F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(2096, 1407);
            this.Controls.Add(this.pnl_Explain);
            this.Controls.Add(this.pnl_Start);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pnl_Welcome);
            this.Font = new System.Drawing.Font("Times New Roman", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormResume";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Christopher Lee Niehaus | Resume";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gBox_AboutMe.ResumeLayout(false);
            this.pnl_AboutMe.ResumeLayout(false);
            this.pnl_AboutSection.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pBox_AboutMePic)).EndInit();
            this.pnl_Start.ResumeLayout(false);
            this.gBox_Main.ResumeLayout(false);
            this.gBox_Main.PerformLayout();
            this.gBox_Welcome.ResumeLayout(false);
            this.gBox_Education.ResumeLayout(false);
            this.gBox_Skills.ResumeLayout(false);
            this.gBox_WorkHistory.ResumeLayout(false);
            this.gBox_WorkHistory.PerformLayout();
            this.gBox_Objective.ResumeLayout(false);
            this.pnl_Welcome.ResumeLayout(false);
            this.pnl_Explain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuBar_File;
        private System.Windows.Forms.GroupBox gBox_AboutMe;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Panel pnl_Start;
        private System.Windows.Forms.ToolStripMenuItem Menu_FileStart;
        private System.Windows.Forms.ToolStripMenuItem Menu_FileExit;
        private System.Windows.Forms.RichTextBox rtb_AboutMe;
        private System.Windows.Forms.Panel pnl_AboutMe;
        private System.Windows.Forms.Panel pnl_AboutSection;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Button btn_SelectAboutItem;
        private System.Windows.Forms.ListBox lstBx_AboutMe;
        private System.Windows.Forms.PictureBox pBox_AboutMePic;
        private System.Windows.Forms.GroupBox gBox_Education;
        private System.Windows.Forms.GroupBox gBox_Skills;
        private System.Windows.Forms.GroupBox gBox_WorkHistory;
        private System.Windows.Forms.GroupBox gBox_Objective;
        private System.Windows.Forms.GroupBox gBox_Welcome;
        private System.Windows.Forms.Panel pnl_Welcome;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.Label lbl_Author;
        private System.Windows.Forms.Label lbl_Welcome;
        private System.Windows.Forms.GroupBox gBox_Main;
        private System.Windows.Forms.Button btn_SelectMain;
        private System.Windows.Forms.ComboBox cBox_ResumeCats;
        private System.Windows.Forms.Label lbl_Start;
        private System.Windows.Forms.Label lbl_WelcomeGB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_Courses;
        private System.Windows.Forms.Label lbl_UMSLExpand;
        private System.Windows.Forms.Label lbl_UMSL;
        private System.Windows.Forms.WebBrowser wb_Skills;
        private System.Windows.Forms.Label lbl_ObjectiveTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel link_GitHub;
        private System.Windows.Forms.LinkLabel link_LinkedIN;
        private System.Windows.Forms.Label lbl_NameTop;
        private System.Windows.Forms.RichTextBox rtb_WorkHistory;
        private System.Windows.Forms.Button btn_EmpHistory;
        private System.Windows.Forms.RadioButton rb_Emmaus;
        private System.Windows.Forms.RadioButton rb_DSFC;
        private System.Windows.Forms.RadioButton rb_UMSL;
        private System.Windows.Forms.Button btn_Explain;
        private System.Windows.Forms.Panel pnl_Explain;
        private System.Windows.Forms.Button btn_Whatis;
        private System.Windows.Forms.Label lbl_Objective;
        private System.Windows.Forms.Label label4;
    }
}

