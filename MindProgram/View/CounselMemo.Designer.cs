namespace MindProgram.View
{
    partial class CounselMemo
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
            this.btn_counselDelete = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_counselorPhone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_counselorName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_counselorID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_clientPhone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_clientName = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_counselUpdate = new System.Windows.Forms.Button();
            this.txt_counselorPasswd = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_clientMemo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_firstdate = new System.Windows.Forms.Label();
            this.lbl_comdate = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_Comment = new System.Windows.Forms.TextBox();
            this.txt_clientSubject = new System.Windows.Forms.TextBox();
            this.txt_clientID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_counselDelete
            // 
            this.btn_counselDelete.Location = new System.Drawing.Point(652, 7);
            this.btn_counselDelete.Name = "btn_counselDelete";
            this.btn_counselDelete.Size = new System.Drawing.Size(112, 29);
            this.btn_counselDelete.TabIndex = 3;
            this.btn_counselDelete.Text = "삭제(Delete)";
            this.btn_counselDelete.UseVisualStyleBackColor = true;
            this.btn_counselDelete.Click += new System.EventHandler(this.Btn_counselDelete_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 24);
            this.label9.TabIndex = 16;
            this.label9.Text = "상담자 비밀번호\r\n(Counselor Passwd)";
            // 
            // txt_counselorPhone
            // 
            this.txt_counselorPhone.Location = new System.Drawing.Point(417, 77);
            this.txt_counselorPhone.Name = "txt_counselorPhone";
            this.txt_counselorPhone.ReadOnly = true;
            this.txt_counselorPhone.Size = new System.Drawing.Size(134, 21);
            this.txt_counselorPhone.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(303, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 24);
            this.label5.TabIndex = 12;
            this.label5.Text = "상담자 연락처\r\n(Counselor Phone)";
            // 
            // txt_counselorName
            // 
            this.txt_counselorName.Location = new System.Drawing.Point(417, 45);
            this.txt_counselorName.Name = "txt_counselorName";
            this.txt_counselorName.ReadOnly = true;
            this.txt_counselorName.Size = new System.Drawing.Size(134, 21);
            this.txt_counselorName.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(303, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 24);
            this.label6.TabIndex = 10;
            this.label6.Text = "상담자 이름\r\n(Counselor Name)";
            // 
            // txt_counselorID
            // 
            this.txt_counselorID.Location = new System.Drawing.Point(417, 13);
            this.txt_counselorID.Name = "txt_counselorID";
            this.txt_counselorID.ReadOnly = true;
            this.txt_counselorID.Size = new System.Drawing.Size(134, 21);
            this.txt_counselorID.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(303, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 24);
            this.label7.TabIndex = 8;
            this.label7.Text = "상담자ID\r\n(Counselor ID)";
            // 
            // txt_clientPhone
            // 
            this.txt_clientPhone.Location = new System.Drawing.Point(112, 77);
            this.txt_clientPhone.Name = "txt_clientPhone";
            this.txt_clientPhone.ReadOnly = true;
            this.txt_clientPhone.Size = new System.Drawing.Size(134, 21);
            this.txt_clientPhone.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "피내담자 연락처\r\n(Client Phone)";
            // 
            // txt_clientName
            // 
            this.txt_clientName.Location = new System.Drawing.Point(112, 45);
            this.txt_clientName.Name = "txt_clientName";
            this.txt_clientName.ReadOnly = true;
            this.txt_clientName.Size = new System.Drawing.Size(134, 21);
            this.txt_clientName.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_counselUpdate);
            this.panel3.Controls.Add(this.btn_counselDelete);
            this.panel3.Controls.Add(this.txt_counselorPasswd);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Location = new System.Drawing.Point(11, 555);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(776, 45);
            this.panel3.TabIndex = 7;
            // 
            // btn_counselUpdate
            // 
            this.btn_counselUpdate.Location = new System.Drawing.Point(534, 7);
            this.btn_counselUpdate.Name = "btn_counselUpdate";
            this.btn_counselUpdate.Size = new System.Drawing.Size(112, 29);
            this.btn_counselUpdate.TabIndex = 2;
            this.btn_counselUpdate.Text = "수정(Update)";
            this.btn_counselUpdate.UseVisualStyleBackColor = true;
            this.btn_counselUpdate.Click += new System.EventHandler(this.Btn_counselUpdate_Click);
            // 
            // txt_counselorPasswd
            // 
            this.txt_counselorPasswd.Location = new System.Drawing.Point(144, 12);
            this.txt_counselorPasswd.Name = "txt_counselorPasswd";
            this.txt_counselorPasswd.Size = new System.Drawing.Size(384, 21);
            this.txt_counselorPasswd.TabIndex = 1;
            this.txt_counselorPasswd.UseSystemPasswordChar = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 13);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 12);
            this.label10.TabIndex = 8;
            this.label10.Text = "제목(Subject)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 12);
            this.label8.TabIndex = 7;
            this.label8.Text = "상담내용(Memo)";
            // 
            // txt_clientMemo
            // 
            this.txt_clientMemo.Location = new System.Drawing.Point(11, 59);
            this.txt_clientMemo.Multiline = true;
            this.txt_clientMemo.Name = "txt_clientMemo";
            this.txt_clientMemo.Size = new System.Drawing.Size(752, 114);
            this.txt_clientMemo.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "피내담자 이름\r\n(Client Name)";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lbl_firstdate);
            this.panel2.Controls.Add(this.lbl_comdate);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.txt_Comment);
            this.panel2.Controls.Add(this.txt_clientSubject);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txt_clientMemo);
            this.panel2.Location = new System.Drawing.Point(11, 177);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(776, 372);
            this.panel2.TabIndex = 6;
            // 
            // lbl_firstdate
            // 
            this.lbl_firstdate.AutoSize = true;
            this.lbl_firstdate.Location = new System.Drawing.Point(13, 179);
            this.lbl_firstdate.Name = "lbl_firstdate";
            this.lbl_firstdate.Size = new System.Drawing.Size(44, 12);
            this.lbl_firstdate.TabIndex = 12;
            this.lbl_firstdate.Text = "label12";
            // 
            // lbl_comdate
            // 
            this.lbl_comdate.AutoSize = true;
            this.lbl_comdate.Location = new System.Drawing.Point(13, 350);
            this.lbl_comdate.Name = "lbl_comdate";
            this.lbl_comdate.Size = new System.Drawing.Size(44, 12);
            this.lbl_comdate.TabIndex = 11;
            this.lbl_comdate.Text = "label12";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 212);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 12);
            this.label11.TabIndex = 10;
            this.label11.Text = "댓글(Comment)";
            // 
            // txt_Comment
            // 
            this.txt_Comment.Location = new System.Drawing.Point(11, 230);
            this.txt_Comment.Multiline = true;
            this.txt_Comment.Name = "txt_Comment";
            this.txt_Comment.Size = new System.Drawing.Size(752, 114);
            this.txt_Comment.TabIndex = 3;
            // 
            // txt_clientSubject
            // 
            this.txt_clientSubject.Location = new System.Drawing.Point(113, 10);
            this.txt_clientSubject.Name = "txt_clientSubject";
            this.txt_clientSubject.Size = new System.Drawing.Size(650, 21);
            this.txt_clientSubject.TabIndex = 1;
            // 
            // txt_clientID
            // 
            this.txt_clientID.Location = new System.Drawing.Point(112, 13);
            this.txt_clientID.Name = "txt_clientID";
            this.txt_clientID.ReadOnly = true;
            this.txt_clientID.Size = new System.Drawing.Size(134, 21);
            this.txt_clientID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "피내담자ID\r\n(Client ID)";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txt_counselorPhone);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txt_counselorName);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txt_counselorID);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txt_clientPhone);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txt_clientName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_clientID);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 114);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(17, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "상담내용(Counseling)";
            // 
            // CounselMemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 611);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CounselMemo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "상담내용(Counseling)";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_counselDelete;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_counselorPhone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_counselorName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_counselorID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_clientPhone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_clientName;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txt_counselorPasswd;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_clientMemo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_clientSubject;
        private System.Windows.Forms.TextBox txt_clientID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_counselUpdate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_Comment;
        private System.Windows.Forms.Label lbl_comdate;
        private System.Windows.Forms.Label lbl_firstdate;
    }
}