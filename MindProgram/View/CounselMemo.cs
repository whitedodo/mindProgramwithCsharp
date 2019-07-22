/*
 *  Create Date: 2019-07-20 
 *  Subject: 가족상담 프로그램
 *  Filename: CounselMemo.cs
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
    public partial class CounselMemo : Form
    {
        private int id;
        private MindController mind = null;
        private Counsel_table counsel_Table = null;
        private Member client = null;
        private Member counselor = null;


        public CounselMemo(object v1)
        { 
            if ( v1 != null) { 

                this.id = ((Counsel_table)v1).ID;
                mind = new MindController();
                Crypt crypt = mind.GetCrypt();

                InitializeComponent();

                this.counsel_Table = mind.GetCounsel_Table(id);
                this.client = mind.GetMember(counsel_Table.ClientID);
                this.counselor = mind.GetMember(counsel_Table.MemberID);

                // 피내담자(고객)
                this.txt_clientID.Text = client.GetID().ToString();
                this.txt_clientName.Text = client.GetName().ToString();
                this.txt_clientPhone.Text = client.GetPhone().ToString();

                // 상담자
                this.txt_counselorID.Text = counselor.GetID().ToString();
                this.txt_counselorName.Text = counselor.GetName().ToString();
                this.txt_counselorPhone.Text = counselor.GetPhone().ToString();

                // 내용
                this.txt_clientSubject.Text = counsel_Table.Subject;
                this.txt_clientMemo.Text = counsel_Table.Memo;
                this.lbl_firstdate.Text = counsel_Table.Firstdate.ToString();

                // 코멘트
                this.txt_Comment.Text = crypt.Decrypt( counsel_Table.Comment.ToString() );
                this.lbl_comdate.Text = counsel_Table.Comdate.ToString();
            }
        }

        private void Btn_counselUpdate_Click(object sender, EventArgs e)
        {
            Boolean state = true;
            Counsel_table usrTbl = new Counsel_table();
            Crypt crypt = mind.GetCrypt();
            string passwd = crypt.Encrypt(txt_counselorPasswd.Text);

            usrTbl.ID = id;
            usrTbl.Subject = txt_clientSubject.Text;
            usrTbl.Memo = crypt.Encrypt(txt_clientMemo.Text);
            usrTbl.Comment = txt_Comment.Text;
            usrTbl.Comdate = DateTime.Now;
            usrTbl.MemberID = int.Parse( txt_counselorID.Text );

            if (txt_clientSubject.Text.Length == 0)
            {
                MessageBox.Show("제목을 입력하세요\r(Enter the subject)", "알림(Alert)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                state = false;
            }

            if (txt_clientMemo.Text.Length == 0 &&
                state == true)
            {
                MessageBox.Show("내용을 입력하세요\r(Enter the memo)", "알림(Alert)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                state = false;

            }

            if (txt_counselorPasswd.Text.Length == 0 &&
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
            if (state == true)
            {
                string query = "UPDATE counsel_table set subject = @subject, " +
                    "memo = @memo, comment = @comment, comdate = @comdate where id = @id";

                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = query;
                cmd.Parameters.Add("@subject", MySqlDbType.VarChar, 50);
                cmd.Parameters.Add("@memo", MySqlDbType.Text);
                cmd.Parameters.Add("@comment", MySqlDbType.Text);
                cmd.Parameters.Add("@comdate", MySqlDbType.DateTime);
                cmd.Parameters.Add("@id", MySqlDbType.Int32, 11);

                cmd.Parameters[0].Value = usrTbl.Subject;
                cmd.Parameters[1].Value = usrTbl.Memo;
                cmd.Parameters[2].Value = crypt.Encrypt( usrTbl.Comment );
                cmd.Parameters[3].Value = DateTime.Now;
                cmd.Parameters[4].Value = counsel_Table.ID;

                mind.InsertUpdate(cmd);
                MessageBox.Show("성공적으로 수정되었습니다.\r(Successfully updated.)",
                                "알림(Alert)", MessageBoxButtons.OK, MessageBoxIcon.Information);


                this.Close();
                var myParent = (DetailShowFrm)this.Owner;
                myParent.ParentMethod();
            }

        }

        private void Btn_counselDelete_Click(object sender, EventArgs e)
        {
            Boolean state = true;
            Crypt crypt = mind.GetCrypt();
            string passwd = crypt.Encrypt(txt_counselorPasswd.Text);

            if (txt_counselorPasswd.Text.Length == 0 &&
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
            if (state == true)
            {
                string query = "DELETE from counsel_table where id = @id";

                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = query;
                cmd.Parameters.Add("@id", MySqlDbType.Int32, 11);

                cmd.Parameters[0].Value = counsel_Table.ID;

                mind.InsertUpdate(cmd);
                MessageBox.Show("상담내용이 삭제되었습니다.\r(Consultation has been deleted.)",
                                "알림(Alert)", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
                var myParent = (DetailShowFrm)this.Owner;
                myParent.ParentMethod();

            }
        }
    }
}
