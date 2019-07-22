/*
 *  Create Date: 2019-07-20 
 *  Subject: 가족상담 프로그램
 *  Filename: MindController.cs
 *  Author: 도도(Dodo) / rabbit.white at daum dot net
 *  Description:
 *  
 *  
 */

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MindProgram.Model;
using MySql.Data.MySqlClient;

namespace MindProgram.Controller
{
    class MindController
    {
        private string strConn;
        private Crypt crypt;

        public MindController()
        {
            DBConn dBConn = this.GetUsrConn();

            SetStrConn( "Server=" + dBConn.UserHost + ";Database=" + dBConn.UserDB + ";" +
                        "Uid=" + dBConn.UserID + ";Pwd=" + dBConn.UserPasswd + ";" );
            this.crypt = new Crypt("cryptthe");

            /*
            string s1 = crypt.Encrypt(this.str_Name.Text);
            string s2 = crypt.Decrypt(s1);
            MessageBox.Show(s1 + "야:" + s2);
            */
        }

        public string GetStrConn()
        {
            return this.strConn;
        }
        
        public void SetStrConn(string strConn)
        {
            this.strConn = strConn;
        }

        public Crypt GetCrypt() {
            return this.crypt;
        }

        public DataTable GetCmbFamilyType()
        {
            DataTable dt = new DataTable("dataTable");
            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("Name", typeof(string));

            // add DataRow
            DataRow row = dt.NewRow();
            row["Id"] = 1;
            row["Name"] = "본인(관리자)";
            dt.Rows.Add(row);

            row = dt.NewRow();
            row["Id"] = 2;
            row["Name"] = "아버지";
            dt.Rows.Add(row);

            row = dt.NewRow();
            row["Id"] = 3;
            row["Name"] = "어머니";
            dt.Rows.Add(row);

            row = dt.NewRow();
            row["Id"] = 4;
            row["Name"] = "형";
            dt.Rows.Add(row);

            row = dt.NewRow();
            row["Id"] = 5;
            row["Name"] = "누나";
            dt.Rows.Add(row);
            row = dt.NewRow();

            row["Id"] = 6;
            row["Name"] = "동생";
            dt.Rows.Add(row);

            row = dt.NewRow();
            row["Id"] = 7;
            row["Name"] = "할아버지";
            dt.Rows.Add(row);

            row = dt.NewRow();
            row["Id"] = 8;
            row["Name"] = "할머니";
            dt.Rows.Add(row);

            row = dt.NewRow();
            row["Id"] = 9;
            row["Name"] = "친척";
            dt.Rows.Add(row);

            return dt;
        }
        
        public DataSet GetDataSet(string strSelect, string strName)
        {
            MySqlConnection conn;
            string strconn = GetStrConn();
            
            // MySQL = 스타일1
            conn = new MySqlConnection(strconn);
            conn.Open();

            //본인의 DB이름 
            MySqlCommand cmd = new MySqlCommand(strSelect, conn);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, strName);

            conn.Close();

            return ds;
        }

        public Member GetMember(int id)
        {
            Member member = new Member();
            MySqlConnection conn;
            string strconn = GetStrConn();
            string query = "select * from member where id = @id";

            // MySQL = 스타일1
            conn = new MySqlConnection(strconn);
            conn.Open();

            //본인의 DB이름 
            MySqlCommand cmd = new MySqlCommand
            {
                Connection = conn,
                CommandText = query
            };

            cmd.Parameters.Add("@id", MySqlDbType.Int32);
            cmd.Parameters[0].Value = id;

            MySqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                member.SetID( int.Parse(rdr["id"].ToString()) );
                member.SetName( rdr["name"].ToString() );
                member.SetEmail( rdr["email"].ToString() );   // 암호 해독
                member.SetBirthDate( (DateTime)rdr["birthdate"] );
                member.SetPhone( rdr["phone"].ToString() );
                member.SetFamilytype(rdr["type"].ToString());
                member.SetPasswd(rdr["password"].ToString());

            }

            conn.Close();

            return member;

        }

        public Counsel_table GetCounsel_Table(int id)
        {
            Counsel_table counsel_Table = new Counsel_table();
            MySqlConnection conn;
            string strconn = GetStrConn();
            string query = "select * from counsel_table where id = @id";

            // MySQL = 스타일1
            conn = new MySqlConnection(strconn);
            conn.Open();

            //본인의 DB이름 
            MySqlCommand cmd = new MySqlCommand
            {
                Connection = conn,
                CommandText = query
            };

            cmd.Parameters.Add("@id", MySqlDbType.Int32);
            cmd.Parameters[0].Value = id;

            MySqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                counsel_Table.ID = int.Parse( rdr["id"].ToString() );
                counsel_Table.Subject = rdr["subject"].ToString();
                counsel_Table.Memo = crypt.Decrypt( rdr["memo"].ToString() );   // 암호 해독
                counsel_Table.Firstdate = (DateTime)rdr["firstdate"];
                counsel_Table.Comment = rdr["comment"].ToString();

                try
                {
                    counsel_Table.Comdate = (DateTime)rdr["comdate"];
                }
                catch(Exception e)
                {
                    e.Message.ToString();
                }
                counsel_Table.ClientID = int.Parse( rdr["clientID"].ToString() );
                counsel_Table.MemberID = int.Parse(rdr["memberID"].ToString() );

            }

            conn.Close();

            return counsel_Table;

        }

        public Boolean CheckPassword(string passwd)
        {
            Boolean state = false;

            MySqlConnection conn;
            string strconn = GetStrConn();
            string query = "select * from member where password = @password";

            // MySQL = 스타일1
            conn = new MySqlConnection(strconn);
            conn.Open();

            //본인의 DB이름 
            MySqlCommand cmd = new MySqlCommand
            {
                Connection = conn,
                CommandText = query
            };

            cmd.Parameters.Add("@password", MySqlDbType.Text);
            cmd.Parameters[0].Value = passwd;

            MySqlDataReader rdr = cmd.ExecuteReader();

            string str_tmp = "";
            while (rdr.Read())
            {
                str_tmp += rdr["password"];
            }

            if ( str_tmp.Length > 0 && 
                string.Equals( str_tmp, passwd ) == true )
            {
                state = true;
            }

            conn.Close();

            return state ;

        }

        public void InsertUpdate(MySqlCommand cmd)
        {
            // MySQL = 스타일2
            string strconn = GetStrConn();

            using (MySqlConnection conn = new MySqlConnection(strconn))
            {
                conn.Open();

                cmd.Connection = conn;
                cmd.ExecuteNonQuery();

                conn.Close();
            }

        }

        private DBConn GetUsrConn()
        {
            DBConn dBConn = new DBConn();

            string path = @System.IO.Directory.GetCurrentDirectory() + "\\serverInfo.txt";
            string[] txtValue = System.IO.File.ReadAllLines(path);

            if ( txtValue.Length > 0)
            {
                for ( int i = 0; i < txtValue.Length; i++)
                {
                    string tmp = txtValue[i];

                    switch ( i)
                    {
                        case 0:
                            dBConn.UserHost = tmp;
                            break;

                        case 1:
                            dBConn.UserID = tmp;
                            break;

                        case 2:
                            dBConn.UserPasswd = tmp;
                            break;

                        case 3:
                            dBConn.UserDB = tmp;
                            break;

                        default:
                            break;
                    }

                }

            }

            return dBConn;
        }


    }
}
