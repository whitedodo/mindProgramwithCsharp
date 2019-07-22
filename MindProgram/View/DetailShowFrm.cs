/*
 *  Create Date: 2019-07-20 
 *  Subject: 가족상담 프로그램
 *  Filename: DetailShowFrm.cs
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
    public partial class DetailShowFrm : Form
    {
        private MindController mind = null;
        private CounselMemo counselMemoFrm;

        public DetailShowFrm(Object v)
        {
            InitializeComponent();
            Member member = (Member) v;
            mind = new MindController();
            counselMemoFrm = new CounselMemo(null);

            member.GetID();

            this.txt_ID.Text = member.GetID().ToString();
            this.txt_Name.Text = member.GetName().ToString();
            this.txt_Phone.Text = member.GetPhone().ToString();
            this.txt_Email.Text = member.GetEmail().ToString();
            this.dtp_birthdate.Value = member.GetBirthDate();
            this.cmb_familyType.Text = member.GetFamilytype();

            // DatagridView
            RefreshDataGrid();

            // ComboBox
            DataTable dt = mind.GetCmbFamilyType();

            cmb_familyType.DataSource = dt;
            cmb_familyType.DisplayMember = "Name";
            cmb_familyType.ValueMember = "Id";

        }
        private void Btn_Update_Click(object sender, EventArgs e)
        {
            Boolean state = true;
            Crypt crypt = mind.GetCrypt();
            string passwd = crypt.Encrypt(txt_strPasswd.Text);

            Member member = new Member();
            member.SetName(txt_Name.Text);
            member.SetEmail(txt_Email.Text);
            member.SetBirthDate(dtp_birthdate.Value);
            member.SetPhone(txt_Phone.Text);
            member.SetFamilytype(cmb_familyType.GetItemText(this.cmb_familyType.SelectedItem));

            if (member.GetName().Length == 0)
            {
                MessageBox.Show("이름을 입력하세요\r(Enter the userName)", "알림(Alert)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                state = false;
            }

            if (member.GetEmail().Length == 0 && state == true)
            {
                MessageBox.Show("이메일을 입력하세요\r(Enter the email)", "알림(Alert)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                state = false;
            }

            if (txt_strPasswd.Text.Length == 0 &&
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

            if ( state == true)
            {
                string query = "Update member set name = @name, " +
                    "email = @email, " +
                    "birthdate = @birthdate, phone = @phone, " +
                    "type = @type where id = @id and password = @password";

                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = query;

                cmd.Parameters.Add("@name", MySqlDbType.VarChar, 50);
                cmd.Parameters.Add("@email", MySqlDbType.VarChar, 100);
                cmd.Parameters.Add("@birthdate", MySqlDbType.DateTime);
                cmd.Parameters.Add("@phone", MySqlDbType.VarChar, 20);
                cmd.Parameters.Add("@type", MySqlDbType.VarChar, 20);
                cmd.Parameters.Add("@id", MySqlDbType.Int32, 11);
                cmd.Parameters.Add("@password", MySqlDbType.Text);

                cmd.Parameters[0].Value = member.GetName();
                cmd.Parameters[1].Value = member.GetEmail();
                cmd.Parameters[2].Value = member.GetBirthDate();
                cmd.Parameters[3].Value = member.GetPhone();
                cmd.Parameters[4].Value = member.GetFamilytype();
                cmd.Parameters[5].Value = member.GetID();
                cmd.Parameters[6].Value = member.GetPasswd();

                mind.InsertUpdate(cmd);
                MessageBox.Show("성공적으로 수정되었습니다.\r(It has been successfully modified.)",
                                "알림(Alert)", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void Btn_counselMemo_Click(object sender, EventArgs e)
        {

            Boolean state = true;
            Crypt crypt = mind.GetCrypt();
            string passwd = crypt.Encrypt( txt_strPasswd.Text);

            Counsel_table counsel_Table = new Counsel_table();
            counsel_Table.ID = int.Parse( dataGridView.Rows[dataGridView.CurrentCellAddress.Y].Cells[0].Value.ToString() );

            if (txt_strPasswd.Text.Length == 0 &&
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

            //MessageBox.Show(mind.CheckPassword(passwd).ToString())

            // state가 true일 때
            if ( state == true)
            {
                counselMemoFrm = new CounselMemo((object)counsel_Table);
                counselMemoFrm.Owner = this;
                counselMemoFrm.ShowDialog();
            }

        }

        internal void ParentMethod()
        {
            RefreshDataGrid();
        }

        private void Btn_Refresh_Click(object sender, EventArgs e)
        {
            RefreshDataGrid();
        }

        public void RefreshDataGrid()
        {

            // DataGridView
            DataSet ds = mind.GetDataSet("select id as '일련번호(ID)', subject as '제목(Subject)', " +
                "firstdate as '등록일자(regidate)', comdate as '답변일자(comment Date)', clientID  from counsel_table " +
                "where memberID = " + txt_ID.Text +
                " order by id", "counsel_table");

            this.dataGridView.DataSource = ds;
            this.dataGridView.DataMember = "counsel_table";
            this.dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }


    }

}
