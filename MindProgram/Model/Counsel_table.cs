/*
 *  Create Date: 2019-07-20 
 *  Subject: 가족상담 프로그램
 *  Filename: Counsel_table.cs
 *  Author: 도도(Dodo) / rabbit.white at daum dot net
 *  Description:
 *  
 *  
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindProgram.Model
{
    class Counsel_table
    {
        private int id;
        private string subject;
        private string memo;
        private DateTime firstdate;
        private string comment;
        private DateTime comdate;
        private int clientID;
        private int memberID;

        // c# 스타일의 getter && setter
        public int ID
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

        public string Subject
        {
            get
            {
                return subject;
            }
            set
            {
                subject = value;
            }
        }

        public string Memo
        {
            get
            {
                return memo;
            }
            set
            {
                memo = value;
            }

        }

        public DateTime Firstdate
        {
            get
            {
                return firstdate;
            }
            set
            {
                firstdate = value;
            }

        }

        public string Comment
        {
            get
            {
                return comment;
            }
            set
            {
                comment = value;
            }

        }

        public DateTime Comdate
        {
            get
            {
                return comdate;
            }
            set
            {
                comdate = value;
            }

        }

        public int ClientID
        {
            get
            {
                return clientID;
            }
            set
            {
                clientID = value;
            }
        }

        public int MemberID
        {
            get
            {
                return memberID;
            }
            set
            {
                memberID = value;
            }
        }

    }
}
