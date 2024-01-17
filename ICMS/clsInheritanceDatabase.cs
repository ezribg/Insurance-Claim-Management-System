using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ICMS
{
	public abstract class clsInheritanceDatabase
	{

		public static string strConnection { get; set; } = @"Data Source=se361.cysfo7qeek6c.us-east-1.rds.amazonaws.com;Initial Catalog=TEAM_C;Persist Security Info=True;User ID=TEAM_C;Password=GJuANjex89rS7uxfksbj4cjt";

		public static SqlConnection Cnn { get; set; }



	}
}
