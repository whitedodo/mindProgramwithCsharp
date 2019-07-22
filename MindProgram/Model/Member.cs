/*
 *  Create Date: 2019-07-20 
 *  Subject: 가족상담 프로그램
 *  Filename: Member.cs
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
    class Member
    {
        private int id;
        private string name;
        private string email;
        private DateTime birthdate;
        private string phone;
        private string familytype;
        private string passwd;

        public Member(){

        }

        public int GetID()
        {
            return this.id;
        }

        public string GetName()
        {
            return this.name;
        }

        public string GetEmail()
        {
            return this.email;
        }

        public DateTime GetBirthDate()
        {
            return this.birthdate;
        }

        public string GetPhone()
        {
            return this.phone;
        }

        public string GetFamilytype()
        {
            return this.familytype;
        }

        public string GetPasswd()
        {
            return this.passwd;
        }

        public void SetID(int id)
        {
            this.id = id;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public void SetEmail(string email)
        {
            this.email = email;
        }

        public void SetBirthDate(DateTime birthdate)
        {
            this.birthdate = birthdate;
        }

        public void SetPhone(string phone)
        {
            this.phone = phone;
        }

        public void SetFamilytype(string familytype)
        {
            this.familytype = familytype;
        }

        public void SetPasswd(string passwd)
        {
            this.passwd = passwd;
        }

    }
}
