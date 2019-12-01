using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TikTokForWindows
{
    class TikTokLogin
    {
        /* username or email is filled. Maybe not both */
        public string username;
        public string email;
        public string passwd; // --> To encrypt

        public TikTokLogin(string id, string passwd)
        {
            if (id.Contains("@")) //this will lead to any issue if the user use @ in his nickname
            {
                this.email = id;
            }
            else
            {
                this.username = id;
            }
            this.passwd = passwd;
        }

        public static void LoginWithEmail(string email, string passwd)
        {
            var encryptedMail = XorEncrypt(email);
            var encryptedPass = XorEncrypt(passwd);
        }

        public void LoginWithEmail()
        {
            var encryptedMail = XorEncrypt(this.email);
            var encryptedPass = XorEncrypt(this.passwd);
        }

        public static void LoginWithUsername(string username, string passwd)
        {
            var encryptedUsername = XorEncrypt(username);
            var encryptedPass = XorEncrypt(passwd);
        }

        public void LoginWithUsername()
        {
            var encryptedUsername = XorEncrypt(this.username);
            var encryptedPass = XorEncrypt(this.passwd);
        }

        private static void errorInGivenInfo()
        {

        }

        private static string XorEncrypt(string xorToEncrypt)
        {
            string encryptedString = "";
            foreach (byte chara in Encoding.Default.GetBytes(xorToEncrypt))
            {
                encryptedString += Convert.ToInt32(chara ^ 5).ToString("x");
            }
            return encryptedString;
        }
    }
}
