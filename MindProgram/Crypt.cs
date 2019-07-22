/*
 *  Create Date: 2019-07-20 
 *  Subject: 가족상담 프로그램(암호)
 *  Filename: MindController.cs
 *  Author: 도도(Dodo) / rabbit.white at daum dot net
 *  Description:
 *  
 *  
 */

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MindProgram
{
    class Crypt
    {
        byte[] Skey = new byte[8];

        public Crypt(string strKey)
        {
            Skey = ASCIIEncoding.ASCII.GetBytes(strKey);
        }

        public string Encrypt(string p_data)
        {
            if (Skey.Length != 8)
            {
                throw (new Exception("Invalid key. Key length must be 8 byte."));
            }

            DESCryptoServiceProvider rc2 = new DESCryptoServiceProvider();

            rc2.Key = Skey;
            rc2.IV = Skey;
            MemoryStream ms = new MemoryStream();

            CryptoStream cryStream = new CryptoStream(ms, rc2.CreateEncryptor(), CryptoStreamMode.Write);

            byte[] data = Encoding.UTF8.GetBytes(p_data.ToCharArray());

            cryStream.Write(data, 0, data.Length);
            cryStream.FlushFinalBlock();
            return Convert.ToBase64String(ms.ToArray());

        }

        public string Decrypt(string p_data)
        {
            DESCryptoServiceProvider rc2 = new DESCryptoServiceProvider();
            rc2.Key = Skey;
            rc2.IV = Skey;

            MemoryStream ms = new MemoryStream();

            CryptoStream cryStream = new CryptoStream(ms, rc2.CreateDecryptor(), CryptoStreamMode.Write);
            byte[] data = Convert.FromBase64String(p_data);

            cryStream.Write(data, 0, data.Length);

            cryStream.FlushFinalBlock();
            return Encoding.UTF8.GetString(ms.GetBuffer());

        }
    }
}
