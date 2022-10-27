﻿using System;
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


namespace Persistencia
{
    //CHOTAAAAAAAAAAAAAAAAAAAAAAAA
   public class clsPersistencia 
    {
        public String miConexion = "server=192.168.2.132; uid=root ; password=Feder-ico123 ; database=begoneSatan69;";
        public MySqlConnection con;
       

        public void AbrirConexion()
        {
            con = new MySqlConnection(miConexion);
            con.Open();
        }

        public void CerrarConexion()
        {
            con.Close();
        }

        public void ejecutarSQL(string consultaSQL)
        {
    
            AbrirConexion();
           
            MySqlCommand comando = new MySqlCommand(consultaSQL, con);
            comando.ExecuteNonQuery();
            CerrarConexion();
            
        }


        public MySqlDataReader ejecutarYdevolver(string consultaSQL)
        {
            MySqlDataReader resultado = null;
            MySqlCommand comando;
            comando = new MySqlCommand(consultaSQL, con);
            resultado = comando.ExecuteReader();
            return resultado;
            CerrarConexion();
        }
    
        public DataTable listarAlgo(string consultaSQL)
        {
            DataTable dt = null;
                MySqlDataAdapter listado = new MySqlDataAdapter(consultaSQL, miConexion);
                dt = new DataTable();
                listado.Fill(dt);
            return dt;
        }

        public void openAndClose()
        {
            AbrirConexion();
            CerrarConexion();
        }

}
}

