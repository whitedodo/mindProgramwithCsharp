using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindProgram.Model
{
    class DBConn
    {
        private string userHost;
        private string userDB;
        private string userID;
        private string userPassword;
        
        public string UserHost
        {
            get
            {
                return userHost;
            }
            set
            {
                userHost = value;
            }
        }

        public string UserDB
        {
            get
            {
                return userDB;
            }
            set
            {
                userDB = value;
            }
        }

        public string UserID
        {
            get
            {
                return userID;
            }
            set
            {
                userID = value;
            }
        }
        public string UserPasswd
        {
            get
            {
                return userPassword;
            }
            set
            {
                userPassword = value;
            }
        }

    }
}
