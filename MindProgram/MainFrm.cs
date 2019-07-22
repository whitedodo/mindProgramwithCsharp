/*
 *  Create Date: 2019-07-20 
 *  Subject: 가족상담 프로그램
 *  Filename: MainFrm.cs
 *  Author: 도도(Dodo) / rabbit.white at daum dot net
 *  Description:
 *  
 *  
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MindProgram.Controller;
using MindProgram.Model;
using MindProgram.View;
using MySql.Data.MySqlClient;

namespace MindProgram
{
    public partial class MainFrm : Form
    {
        private MindController mind = null;

        public MainFrm()
        {
            this.mind = new MindController();

            InitializeComponent();
            RefreshDataGrid();

            this.toolStripStatusLbl.Text = DateTime.Now.ToString() + "::::: 환영합니다.";

            DataTable dt = mind.GetCmbFamilyType();
            cmb_MemType.DataSource = dt;
            cmb_MemType.DisplayMember = "Name";
            cmb_MemType.ValueMember = "Id";

        }

        private void BtnQueries_Click(object sender, EventArgs e)
        {
            Boolean state = true;
            Member member = new Member();
            Crypt crypt = mind.GetCrypt();

            member.SetName(str_Name.Text);
            member.SetEmail(str_MemEmail.Text);
            member.SetBirthDate(str_MemDateTimePicker.Value);
            member.SetPhone(str_MemPhoneNumber.Text);
            member.SetFamilytype(cmb_MemType.GetItemText(this.cmb_MemType.SelectedItem));
            // this.comboBox1.GetItemText(this.comboBox1.SelectedItem);
            //MessageBox.Show(cmb_MemType.GetItemText(this.cmb_MemType.SelectedItem));
            
            if ( member.GetName().Length == 0)
            {
                MessageBox.Show("이름을 입력하세요\r(Enter the userName)", "알림(Alert)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                state = false;
            }

            if ( member.GetEmail().Length == 0 && state == true)
            {
                MessageBox.Show("이메일을 입력하세요\r(Enter the email)", "알림(Alert)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                state = false;
            }

            if ( ( str_passwd1.Text.Length == 0 || 
                   str_passwd2.Text.Length == 0 ) && 
                   state == true )
            {
                MessageBox.Show("비밀번호를 입력하세요\r(Enter the Password)", "알림(Alert)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                state = false;
            }

            if ( ( str_passwd1.Text != str_passwd2.Text) && state == true )
            {
                MessageBox.Show("비밀번호가 일치하지 않습니다.\r(Mismatch the password)",
                                "알림(Alert)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                state = false;
            }

            // state가 true일 때
            if ( state == true)
            {
                // 비밀번호 입력 처리(암호화)
                member.SetPasswd(crypt.Encrypt(str_passwd1.Text));

                // 쿼리
                string query = "INSERT INTO member(name, email, " +
                    "birthdate, phone, type, password) " +
                    "VALUES (@name, @email, @birthdate, @phone, " +
                    "@type, @password)";

                MySqlCommand insertCommand = new MySqlCommand();
                insertCommand.CommandText = query;

                insertCommand.Parameters.Add("@name", MySqlDbType.VarChar, 50);
                insertCommand.Parameters.Add("@email", MySqlDbType.VarChar, 100);
                insertCommand.Parameters.Add("@birthdate", MySqlDbType.DateTime );
                insertCommand.Parameters.Add("@phone", MySqlDbType.VarChar, 20);
                insertCommand.Parameters.Add("@type", MySqlDbType.VarChar, 20);
                insertCommand.Parameters.Add("@password", MySqlDbType.Text);

                insertCommand.Parameters[0].Value = member.GetName();
                insertCommand.Parameters[1].Value = member.GetEmail();
                insertCommand.Parameters[2].Value = member.GetBirthDate();
                insertCommand.Parameters[3].Value = member.GetPhone();
                insertCommand.Parameters[4].Value = member.GetFamilytype();
                insertCommand.Parameters[5].Value = member.GetPasswd();

                mind.InsertUpdate(insertCommand);

                MessageBox.Show("등록이 완료되었습니다.\r(Registration is complete)",
                                "알림(Alert)", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // DatagridView Refresh
                RefreshDataGrid();
            }

        }

        private void BtnDetail_information_Click(object sender, EventArgs e)
        {
            Member member = new Member();
            member.SetID( int.Parse( dataGridView1.Rows[dataGridView1.CurrentCellAddress.Y].Cells[0].Value.ToString() ));
            member.SetName(dataGridView1.Rows[dataGridView1.CurrentCellAddress.Y].Cells[1].Value.ToString());
            member.SetEmail(dataGridView1.Rows[dataGridView1.CurrentCellAddress.Y].Cells[2].Value.ToString());
            member.SetBirthDate(DateTime.Parse( dataGridView1.Rows[dataGridView1.CurrentCellAddress.Y].Cells[3].Value.ToString()) );
            member.SetPhone(dataGridView1.Rows[dataGridView1.CurrentCellAddress.Y].Cells[4].Value.ToString());
            member.SetFamilytype(dataGridView1.Rows[dataGridView1.CurrentCellAddress.Y].Cells[5].Value.ToString());

//          MessageBox.Show( member.GetBirthDate().ToString() );            

            DetailShowFrm detailShowFrm = new DetailShowFrm( (Object)member );

            detailShowFrm.Owner = this;
            detailShowFrm.ShowDialog();
        }

        private void Btn_selectedClient_Click(object sender, EventArgs e)
        {
            this.str_clientID.Text = dataGridView1.Rows[dataGridView1.CurrentCellAddress.Y].Cells[0].Value.ToString();
            this.str_clientName.Text = dataGridView1.Rows[dataGridView1.CurrentCellAddress.Y].Cells[1].Value.ToString();
            this.str_clientPhone.Text = dataGridView1.Rows[dataGridView1.CurrentCellAddress.Y].Cells[4].Value.ToString();
        }

        private void Btn_selectedCounselor_Click(object sender, EventArgs e)
        {
            this.str_counselorID.Text = dataGridView1.Rows[dataGridView1.CurrentCellAddress.Y].Cells[0].Value.ToString();
            this.str_counselorName.Text = dataGridView1.Rows[dataGridView1.CurrentCellAddress.Y].Cells[1].Value.ToString();
            this.str_counselorPhone.Text = dataGridView1.Rows[dataGridView1.CurrentCellAddress.Y].Cells[4].Value.ToString();
        }

        private void Btn_selectedCounseling_Click(object sender, EventArgs e)
        {
            Boolean state = true;
            Member clientMember = new Member();
            Member counselorMember = new Member();

            if (str_clientID.Text.Length != 0)
            {
                clientMember.SetID(int.Parse(str_clientID.Text.ToString()));
            }
            else
            {
                clientMember.SetID(0);
            }
            clientMember.SetName(str_clientName.Text);
            clientMember.SetPhone(str_clientPhone.Text);

            if (str_counselorID.Text.Length != 0)
            {
                counselorMember.SetID(int.Parse(str_counselorID.Text));
            }
            else
            {
                counselorMember.SetID(0);
            }
            counselorMember.SetName(str_counselorName.Text);
            counselorMember.SetPhone(str_counselorPhone.Text);

            if ( clientMember.GetID() == 0)
            {
                MessageBox.Show("피내담자를 선택하세요\r(Select the client)", "알림(Alert)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                state = false;
            }

            if ( counselorMember.GetID() == 0 && 
                 state == true)
            {
                MessageBox.Show("상담자를 선택하세요\r(Select the counselor)", "알림(Alert)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                state = false;
            }

            if ( clientMember.GetID() == counselorMember.GetID() &&
                state == true)
            {
                MessageBox.Show("상담자와 피내담자의 아이디는 같을 수 없습니다.\r(The name of the client can not be the same as that of the client)",
                                "알림(Alert)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                state = false;
            }

            // state가 true일 때
            if ( state == true )
            {
                CounselRegister counselFrm = new CounselRegister((object)clientMember, (object)counselorMember);

                counselFrm.Owner = this;
                counselFrm.ShowDialog();

            }

        }

        private void Btn_refresh_Click(object sender, EventArgs e)
        {
            RefreshDataGrid();
        }
        internal void ParentMethod()
        {
            RefreshDataGrid();
        }

        private void RefreshDataGrid()
        {
            // 데이터 requery
            DataSet ds = mind.GetDataSet("Select id as '일련번호(Id)', name as '이름(name)', " +
            "email as 'email(이메일)', birthdate as '생년월일(birthdate)'," +
            "phone as '연락처(phone)', type as '구분(family Type)' " +
            "from member order by id", "member");

            this.dataGridView1.DataSource = ds;
            this.dataGridView1.DataMember = "member";
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }

        private void 종료ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 정보AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About aboutFrm = new About();
            aboutFrm.ShowDialog();
        }
    }
}
