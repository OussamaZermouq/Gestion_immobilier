using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.WinControls.UI.PivotFieldList;
using System.Data.SqlClient;
using Telerik.WinControls;
using System.Data;
using System.Security.Cryptography;

namespace Gestion_immobilier.Database
{
    public class Connection
    {
        public static string db_name=  "Gestion_immo";
        public static string server_name = "ASUS\\SQLEXPRESS";

        public SqlCommand cmd;
        public static SqlConnection con;

        private SqlDataAdapter Dad;
        private SqlDataReader Dr;
        private DataSet Dst;
        private DataTable Dt;


        public Connection() { 
            
        }
        public static SqlConnection Connect_to_db()
        {
            String connection = $"data source={server_name};initial catalog={db_name};integrated security=true;";
            try
            {
                con = new SqlConnection(connection);
                con.Open();
                return con;

            }
            catch (Exception ex) { 
                RadMessageBox.Show("An erreur has occured while connecting to the Database, try again later"); 
            }
            return null;
            //if null then an error has occured
        }

        public DataTable renvoyer_liste_deconnecté(String chaine_sql)
        {
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = chaine_sql;
            Dad = new SqlDataAdapter(cmd);
            Dst = new DataSet();
            Dad.Fill(Dst, cmd.CommandText);
            Dt = new DataTable();
            Dt = Dst.Tables[chaine_sql];
            return Dt;
        }
        public SqlDataReader renvoyer_Data_Reader(String chaine_sql)
        {
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = chaine_sql;
            Dr = cmd.ExecuteReader();
            return Dr;
        }
        public int executer(String chaine_sql)
        {
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = chaine_sql;
            return cmd.ExecuteNonQuery();
        }
        public String renvoyer_valeur(String chaine_sql)
        {
            String x;
            cmd = new SqlCommand();
            cmd.CommandText = chaine_sql;
            cmd.Connection = con;
            object obj = cmd.ExecuteScalar();
            if (obj != null)
                x = obj.ToString();
            else
                x = "";
            return x;
        }
        public SqlConnection get_con()
        {
            return con;
        }
        public void Close_con()
        {
            con.Close();
        }
    }
}
