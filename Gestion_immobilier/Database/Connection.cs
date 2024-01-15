using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.WinControls.UI.PivotFieldList;
using System.Data.SqlClient;
using Telerik.WinControls;

namespace Gestion_immobilier.Database
{
    public class Connection
    {
        public static string db_name=  "Gestion_immo";
        public static string server_name = "ASUS\\SQLEXPRESS";
        

        public Connection() { 
            
        }
        public static SqlConnection Connect_to_db()
        {
            String connection = $"data source={server_name};initial catalog={db_name};integrated security=true;";
            try
            {
                SqlConnection conn = new SqlConnection(connection);
                conn.Open();
                return conn;

            }
            catch (Exception ex) { 
                RadMessageBox.Show("An erreur has occured while connecting to the Database, try again later"); 
            }
            return null;
            //if null then an error has occured

        }
    }
}
