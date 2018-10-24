using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CasaReparadora
{
    class Empleado
    {
       private MySqlConnection connection;
       private string server;
       private string database;
       private string uid;
       private string password;
       public MySqlConnection cn = null;

        public Empleado(){
            Initialize();
        }
        //Initialize values
        private void Initialize()
        {
            server = "db4free.net";
            database = "casareparadora";
            uid = "casareparadora@localhost";
            password = "casareparadora";
            string connectionString;
            connectionString = "host=db4free.net;user='"+uid+"';password='"+password+"';database='"+database+"';";

            connection = new MySqlConnection(connectionString);
        }
        public bool Logear(){
            bool Resp  = false;
        try{
            string sql  = "Select * from EMPLEADO";
            MySqlCommand cmd = new MySqlCommand(sql,connection);
            connection.Open();
            MySqlDataReader Lector  = cmd.ExecuteReader();
                if( Lector.Read()){
                    Resp = true;
                }
            Lector.Close();
            connection.Close();
            }catch(Exception ex){
                MessageBox.Show(ex.Message);
            }
        return Resp;
        }
        }
        
}
