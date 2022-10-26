using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Data;
using System.Windows.Forms;

namespace Persistencia
{
    //CHOTAAAAAAAAAAAAAAAAAAAAAAAA
   public class clsPersistencia : Form
    {
        public String miConexion = "server=192.168.2.132; uid=root ; password=Feder-ico123 ; database=begoneSatan69;";
        public MySqlConnection con;
       

        public void AbrirConexion()
        {
            
            //"server=localhost; uid=Jesus ; password=Luca1234. ; database=BDprueba;";
            con = new MySqlConnection(miConexion);
            con.Open();
            //jaja pinga
        }

        public void CerrarConexion()
        {
            con.Close();//.Close();
        }

        public void ejecutarSQL(string consultaSQL)
        {
            try
            {
            AbrirConexion();
            MySqlCommand comando = new MySqlCommand(consultaSQL, con);
            comando.ExecuteNonQuery();
            CerrarConexion();
            }
            catch (Exception error) { MessageBox.Show(error.Message); }
        }


        public MySqlDataReader ejecutarYdevolver(string consultaSQL)
        {
            MySqlDataReader resultado = null;
            MySqlCommand comando;
            AbrirConexion();
            try
            {
                comando = new MySqlCommand(consultaSQL, con);
                resultado = comando.ExecuteReader();
                return resultado;
                CerrarConexion();
            }
            catch (Exception error) { MessageBox.Show(error.Message); }
            return resultado;
            
        }
    
        public DataTable listarAlgo(string consultaSQL)
        {
            DataTable dt = null;
            
            try
            {
                MySqlDataAdapter listado = new MySqlDataAdapter(consultaSQL, miConexion);
                dt = new DataTable();
                listado.Fill(dt);
            }
            catch (Exception error) { MessageBox.Show(error.Message); }

            return dt;

        }
}
}

