using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLCHG
{
    class SQLDatabase
    {
        public static SqlConnection GetDBConnection()
        {
            string datasource = @"(LocalDB)\v11.0";
            string databasePath = Application.StartupPath + @"\Database\QLCHG.mdf";
            //string databasePath = @"D:\INFORMATION TECHNOLOGY\SOURCE CODE\CSHARP\QLCHG\QLCHG\QLCHG\DATABASE\QLCHG.MDF";
            return new SqlConnection("Data Source=" + datasource + ";AttachDbFilename=" + databasePath + ";Integrated Security=True");
        }
    }
}
