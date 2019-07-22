/*
 *  Create Date: 2019-07-20 
 *  Subject: 가족상담 프로그램
 *  Filename: CounselRegister.cs
 *  Author: 도도(Dodo) / rabbit.white at daum dot net
 *  Description:
 *  
 *  
 */

using MindProgram.Controller;
using MindProgram.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MindProgram.View
{
    public partial class CounselRegister : Form
    {
        private MindController mind = null;
        private Member clientMember = null;
        private Member counselorMember = null;

        public CounselRegister(object v1, object v2)
        {
            InitializeComponent();
            this.mind = new MindController();
            this.clientMember = (Member)v1;
            this.counselorMember = (Member)v2;

            this.txt_clientID.Text = clientMember.GetID().ToString();
            this.txt_clientName.Text = clientMember.GetName();
            this.txt_clientPhone.Text = clientMember.GetPhone();

            this.txt_counselorID.Text = counselorMember.GetID().ToString();
            this.txt_counselorName.Text = counselorMember.GetName();
            this.txt_counselorPhone.Text = counselorMember.GetPhone();

        }

        private void Btn_counselSubmit_Click(object sender, EventArgs e)
        {
            Boolean state = true;
            Crypt crypt = mind.GetCrypt();
            string passwd = crypt.Encrypt( txt_counselorPasswd.Text );
            
            Counsel_table counsel_Table = new Counsel_table();
            counsel_Table.Subject = this.txt_clientSubject.Text ;
            counsel_Table.Memo = crypt.Encrypt( this.txt_clientMemo.Text );
            counsel_Table.Firstdate = DateTime.Now;
            counsel_Table.ClientID = int.Parse( txt_clientID.Text );
            counsel_Table.MemberID = int.Parse( txt_counselorID.Text );

            //MessageBox.Show(passwd);
            //MessageBox.Show( mind.CheckPassword(passwd).ToString() );

            if ( txt_clientSubject.Text.Length == 0)
            {
                MessageBox.Show("제목을 입력하세요\r(Enter the subject)", "알림(Alert)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                state = false;
            }

            if ( txt_clientMemo.Text.Length == 0 &&
                state == true)
            {
                MessageBox.Show("내용을 입력하세요\r(Enter the memo)", "알림(Alert)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                state = false;

            }

            if ( txt_counselorPasswd.Text.Length == 0 &&
                state == true)
            {
                MessageBox.Show("상담자 비밀번호를 입력하세요\r(Enter the counselor password)", "알림(Alert)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                state = false;

            }

            if (mind.CheckPassword(passwd) == false && 
                state == true)
            {
                MessageBox.Show("비밀번호가 일치하지 않습니다.\r(Mismatch password.)", "알림(Alert)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                state = false;

            }

            // 추가 Query
            if ( state == true)
            {
                string query = "INSERT INTO counsel_table(subject, memo, " +
                    "firstdate, comment, comdate, clientID, memberID) VALUES(" +
                    "@subject, @memo, @firstdate, @comment, @comdate, @clientID, @memberID)";

                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = query;
                cmd.Parameters.Add("@subject", MySqlDbType.VarChar, 50);
                cmd.Parameters.Add("@memo", MySqlDbType.Text);
                cmd.Parameters.Add("@firstdate", MySqlDbType.DateTime);
                cmd.Parameters.Add("@comment", MySqlDbType.Text);
                cmd.Parameters.Add("@comdate", MySqlDbType.DateTime);
                cmd.Parameters.Add("@clientID", MySqlDbType.Int32, 11);
                cmd.Parameters.Add("@memberID", MySqlDbType.Int32, 11);

                cmd.Parameters[0].Value = counsel_Table.Subject;
                cmd.Parameters[1].Value = counsel_Table.Memo;
                cmd.Parameters[2].Value = counsel_Table.Firstdate;
                cmd.Parameters[3].Value = null;
                cmd.Parameters[4].Value = null;
                cmd.Parameters[5].Value = counsel_Table.ClientID;
                cmd.Parameters[6].Value = counsel_Table.MemberID;

                mind.InsertUpdate(cmd);
                MessageBox.Show("성공적으로 등록되었습니다.\r(Successfully registered.)",
                                "알림(Alert)", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();

                var myParent = (MainFrm)this.Owner;
                myParent.ParentMethod();
            }


        }

    }
}
