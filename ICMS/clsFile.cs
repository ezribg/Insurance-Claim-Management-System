using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ICMS
{
    public class clsFile
    {
        public static clsDBH_File DBH { get; set; } = new clsDBH_File();

        public override string ToString()
        {
            string pString = File_name;
            return pString;
        }


        public clsFile(int user_id = 0)
        {
            File_id = 0;
            User_id = user_id;
            Claim_id = 0;
            File_name = "";
            File_type = "";
        }

        public int File_id { get; set; }
        public int User_id { get; set; }
        public int Claim_id { get; set; }
        public String File_name { get; set; }
        public String File_type { get; set; }
        public Byte[] Data { get; set; }


        public void Rewrite(clsFile file)
        {
            this.File_id = file.File_id;
            this.User_id = file.User_id;
            this.Claim_id = file.Claim_id;
            this.File_name = file.File_name;
            this.File_type = file.File_type;
            this.Data = file.Data;
        }


        public void Fetch()
        {
            Rewrite(clsDBH_File.FetchFile(this));
        }


    }
}
