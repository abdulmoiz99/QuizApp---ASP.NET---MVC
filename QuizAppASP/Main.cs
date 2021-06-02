using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizAppASP
{
    sealed class Main
    {
        private static int companyID = 2;
        private static string userName;//="admin";
        public static int RDRMID = 1;// = 1;//ROlE DETAIL AND ROLEMASTERID FOR FORM AND REPORTS RIGHTS

        public static int CompanyID
        {
            get
            {
                return companyID;
            }

            set
            {
                companyID = value;
            }
        }

        public static string UserName
        {
            get
            {
                return userName;
            }

            set
            {
                userName = value;
            }
        }
      
        public static bool CheckFormRights()
        {
            String USERNAME = UserName.ToUpper();
            if (string.Compare("ADMIN", USERNAME) == 0) return true;
            else return false;
        }
        public static bool CheckUserName(string name)
        {
            string Compare = "";
            Compare = SQL.ScalarQuery("SELECT CASE WHEN EXISTS (SELECT TOP 1 * FROM Login  WHERE LoginEmail = '" + name + "' And CompanyID=" + Main.CompanyID + ") THEN CAST (1 AS BIT) ELSE CAST (0 AS BIT) END");
            if (string.Compare("True", Compare) == 0) return true;
            else return false;
        }
        public static bool verifyUser(string name, string password)
        {
            string oPassword = "";
            oPassword = SQL.ScalarQuery("Select LoginPassword from Login where LoginEmail='" + name + "'");
            if (string.Compare(password, oPassword) == 0) return true;
            else return false;
        }
        public static bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
    }
}
