namespace MindProgram
{
    partial class MainFrm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.파일ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.종료ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.str_passwd2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.str_passwd1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmb_MemType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.str_MemPhoneNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_MemQueries = new System.Windows.Forms.Button();
            this.str_MemDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.str_MemEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.str_Name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_Detail_information = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_selectedCounselor = new System.Windows.Forms.Button();
            this.btn_selectedClient = new System.Windows.Forms.Button();
            this.str_counselorPhone = new System.Windows.Forms.TextBox();
            this.str_clientPhone = new System.Windows.Forms.TextBox();
            this.str_counselorName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.str_clientName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.str_counselorID = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.str_clientID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_selectedCounseling = new System.Windows.Forms.Button();
            this.정보AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일ToolStripMenuItem,
            this.정보AboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(984, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 파일ToolStripMenuItem
            // 
            this.파일ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.종료ToolStripMenuItem});
            this.파일ToolStripMenuItem.Name = "파일ToolStripMenuItem";
            this.파일ToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.파일ToolStripMenuItem.Text = "파일(File)";
            // 
            // 종료ToolStripMenuItem
            // 
            this.종료ToolStripMenuItem.Name = "종료ToolStripMenuItem";
            this.종료ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.종료ToolStripMenuItem.Text = "종료(Exit)";
            this.종료ToolStripMenuItem.Click += new System.EventHandler(this.종료ToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_refresh);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(13, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(658, 474);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "등록된 회원 현황(Registered member status)";
            // 
            // btn_refresh
            // 
            this.btn_refresh.Location = new System.Drawing.Point(539, 15);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(102, 33);
            this.btn_refresh.TabIndex = 3;
            this.btn_refresh.Text = "새로고침(Refresh)";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.Btn_refresh_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 56);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(626, 398);
            this.dataGridView1.TabIndex = 2;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLbl});
            this.statusStrip1.Location = new System.Drawing.Point(0, 569);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(984, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLbl
            // 
            this.toolStripStatusLbl.Name = "toolStripStatusLbl";
            this.toolStripStatusLbl.Size = new System.Drawing.Size(18, 17);
            this.toolStripStatusLbl.Text = "sa";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.str_passwd2);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.str_passwd1);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.cmb_MemType);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.str_MemPhoneNumber);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btn_MemQueries);
            this.groupBox2.Controls.Add(this.str_MemDateTimePicker);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.str_MemEmail);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.str_Name);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(677, 36);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(295, 321);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "회원 간편등록(Membership Registration)";
            // 
            // str_passwd2
            // 
            this.str_passwd2.Location = new System.Drawing.Point(7, 262);
            this.str_passwd2.Name = "str_passwd2";
            this.str_passwd2.Size = new System.Drawing.Size(278, 21);
            this.str_passwd2.TabIndex = 14;
            this.str_passwd2.UseSystemPasswordChar = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 247);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(188, 12);
            this.label8.TabIndex = 16;
            this.label8.Text = "비밀번호 확인(Password Check)";
            // 
            // str_passwd1
            // 
            this.str_passwd1.Location = new System.Drawing.Point(8, 223);
            this.str_passwd1.Name = "str_passwd1";
            this.str_passwd1.Size = new System.Drawing.Size(278, 21);
            this.str_passwd1.TabIndex = 12;
            this.str_passwd1.UseSystemPasswordChar = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 208);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 12);
            this.label7.TabIndex = 14;
            this.label7.Text = "비밀번호(Password)";
            // 
            // cmb_MemType
            // 
            this.cmb_MemType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_MemType.FormattingEnabled = true;
            this.cmb_MemType.Location = new System.Drawing.Point(8, 182);
            this.cmb_MemType.Name = "cmb_MemType";
            this.cmb_MemType.Size = new System.Drawing.Size(278, 20);
            this.cmb_MemType.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 12);
            this.label5.TabIndex = 11;
            this.label5.Text = "구분(Type)";
            // 
            // str_MemPhoneNumber
            // 
            this.str_MemPhoneNumber.Location = new System.Drawing.Point(8, 139);
            this.str_MemPhoneNumber.Name = "str_MemPhoneNumber";
            this.str_MemPhoneNumber.Size = new System.Drawing.Size(278, 21);
            this.str_MemPhoneNumber.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "연락처(Phone Number)";
            // 
            // btn_MemQueries
            // 
            this.btn_MemQueries.Location = new System.Drawing.Point(7, 289);
            this.btn_MemQueries.Name = "btn_MemQueries";
            this.btn_MemQueries.Size = new System.Drawing.Size(279, 23);
            this.btn_MemQueries.TabIndex = 16;
            this.btn_MemQueries.Text = "질의(Queries)";
            this.btn_MemQueries.UseVisualStyleBackColor = true;
            this.btn_MemQueries.Click += new System.EventHandler(this.BtnQueries_Click);
            // 
            // str_MemDateTimePicker
            // 
            this.str_MemDateTimePicker.Location = new System.Drawing.Point(8, 97);
            this.str_MemDateTimePicker.Name = "str_MemDateTimePicker";
            this.str_MemDateTimePicker.Size = new System.Drawing.Size(278, 21);
            this.str_MemDateTimePicker.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "생년월일(BirthDate)";
            // 
            // str_MemEmail
            // 
            this.str_MemEmail.Location = new System.Drawing.Point(8, 55);
            this.str_MemEmail.Name = "str_MemEmail";
            this.str_MemEmail.Size = new System.Drawing.Size(278, 21);
            this.str_MemEmail.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "이메일(E-mail)";
            // 
            // str_Name
            // 
            this.str_Name.Location = new System.Drawing.Point(101, 14);
            this.str_Name.Name = "str_Name";
            this.str_Name.Size = new System.Drawing.Size(185, 21);
            this.str_Name.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "이름(Name)";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_Detail_information);
            this.groupBox3.Location = new System.Drawing.Point(677, 357);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(294, 57);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "부가기능(Additional Function)";
            // 
            // btn_Detail_information
            // 
            this.btn_Detail_information.Location = new System.Drawing.Point(8, 21);
            this.btn_Detail_information.Name = "btn_Detail_information";
            this.btn_Detail_information.Size = new System.Drawing.Size(277, 25);
            this.btn_Detail_information.TabIndex = 0;
            this.btn_Detail_information.Text = "상세정보(Detail Information)";
            this.btn_Detail_information.UseVisualStyleBackColor = true;
            this.btn_Detail_information.Click += new System.EventHandler(this.BtnDetail_information_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("나눔고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(12, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(229, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "회원현황(Member Status)";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btn_selectedCounselor);
            this.groupBox4.Controls.Add(this.btn_selectedClient);
            this.groupBox4.Controls.Add(this.str_counselorPhone);
            this.groupBox4.Controls.Add(this.str_clientPhone);
            this.groupBox4.Controls.Add(this.str_counselorName);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.str_clientName);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.str_counselorID);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.str_clientID);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.btn_selectedCounseling);
            this.groupBox4.Location = new System.Drawing.Point(677, 409);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(295, 157);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "상담기능(Counseling Function)";
            // 
            // btn_selectedCounselor
            // 
            this.btn_selectedCounselor.Location = new System.Drawing.Point(142, 86);
            this.btn_selectedCounselor.Name = "btn_selectedCounselor";
            this.btn_selectedCounselor.Size = new System.Drawing.Size(142, 32);
            this.btn_selectedCounselor.TabIndex = 8;
            this.btn_selectedCounselor.Text = "상담자선택\r\n(Choose a Counselor)";
            this.btn_selectedCounselor.UseVisualStyleBackColor = true;
            this.btn_selectedCounselor.Click += new System.EventHandler(this.Btn_selectedCounselor_Click);
            // 
            // btn_selectedClient
            // 
            this.btn_selectedClient.Location = new System.Drawing.Point(7, 86);
            this.btn_selectedClient.Name = "btn_selectedClient";
            this.btn_selectedClient.Size = new System.Drawing.Size(135, 32);
            this.btn_selectedClient.TabIndex = 4;
            this.btn_selectedClient.Text = "내담자선택\r\n(Choose a client)";
            this.btn_selectedClient.UseVisualStyleBackColor = true;
            this.btn_selectedClient.Click += new System.EventHandler(this.Btn_selectedClient_Click);
            // 
            // str_counselorPhone
            // 
            this.str_counselorPhone.Location = new System.Drawing.Point(142, 64);
            this.str_counselorPhone.Name = "str_counselorPhone";
            this.str_counselorPhone.ReadOnly = true;
            this.str_counselorPhone.Size = new System.Drawing.Size(141, 21);
            this.str_counselorPhone.TabIndex = 7;
            // 
            // str_clientPhone
            // 
            this.str_clientPhone.Location = new System.Drawing.Point(8, 64);
            this.str_clientPhone.Name = "str_clientPhone";
            this.str_clientPhone.ReadOnly = true;
            this.str_clientPhone.Size = new System.Drawing.Size(132, 21);
            this.str_clientPhone.TabIndex = 3;
            // 
            // str_counselorName
            // 
            this.str_counselorName.Location = new System.Drawing.Point(230, 39);
            this.str_counselorName.Name = "str_counselorName";
            this.str_counselorName.ReadOnly = true;
            this.str_counselorName.Size = new System.Drawing.Size(53, 21);
            this.str_counselorName.TabIndex = 6;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(147, 44);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 12);
            this.label12.TabIndex = 9;
            this.label12.Text = "상담자 이름";
            // 
            // str_clientName
            // 
            this.str_clientName.Location = new System.Drawing.Point(87, 39);
            this.str_clientName.Name = "str_clientName";
            this.str_clientName.ReadOnly = true;
            this.str_clientName.Size = new System.Drawing.Size(53, 21);
            this.str_clientName.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 44);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 12);
            this.label11.TabIndex = 7;
            this.label11.Text = "내담자 이름";
            // 
            // str_counselorID
            // 
            this.str_counselorID.Location = new System.Drawing.Point(230, 15);
            this.str_counselorID.Name = "str_counselorID";
            this.str_counselorID.ReadOnly = true;
            this.str_counselorID.Size = new System.Drawing.Size(53, 21);
            this.str_counselorID.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(147, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 12);
            this.label10.TabIndex = 5;
            this.label10.Text = "상담자 ID";
            // 
            // str_clientID
            // 
            this.str_clientID.Location = new System.Drawing.Point(87, 15);
            this.str_clientID.Name = "str_clientID";
            this.str_clientID.ReadOnly = true;
            this.str_clientID.Size = new System.Drawing.Size(53, 21);
            this.str_clientID.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 12);
            this.label9.TabIndex = 3;
            this.label9.Text = "내담자 ID";
            // 
            // btn_selectedCounseling
            // 
            this.btn_selectedCounseling.Location = new System.Drawing.Point(7, 119);
            this.btn_selectedCounseling.Name = "btn_selectedCounseling";
            this.btn_selectedCounseling.Size = new System.Drawing.Size(277, 33);
            this.btn_selectedCounseling.TabIndex = 9;
            this.btn_selectedCounseling.Text = "상담 등록\r\n(Counseling Registration)";
            this.btn_selectedCounseling.UseVisualStyleBackColor = true;
            this.btn_selectedCounseling.Click += new System.EventHandler(this.Btn_selectedCounseling_Click);
            // 
            // 정보AboutToolStripMenuItem
            // 
            this.정보AboutToolStripMenuItem.Name = "정보AboutToolStripMenuItem";
            this.정보AboutToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.정보AboutToolStripMenuItem.Text = "정보(About)";
            this.정보AboutToolStripMenuItem.Click += new System.EventHandler(this.정보AboutToolStripMenuItem_Click);
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 591);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "상담 프로그램(Counseling program)";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 파일ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 종료ToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLbl;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox str_Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox str_MemEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_MemQueries;
        private System.Windows.Forms.DateTimePicker str_MemDateTimePicker;
        private System.Windows.Forms.TextBox str_MemPhoneNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_Detail_information;
        private System.Windows.Forms.ComboBox cmb_MemType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox str_passwd1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox str_passwd2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btn_selectedCounseling;
        private System.Windows.Forms.TextBox str_counselorID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox str_clientID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox str_counselorName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox str_clientName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox str_counselorPhone;
        private System.Windows.Forms.TextBox str_clientPhone;
        private System.Windows.Forms.Button btn_selectedClient;
        private System.Windows.Forms.Button btn_selectedCounselor;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.ToolStripMenuItem 정보AboutToolStripMenuItem;
    }
}

