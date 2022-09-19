﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Data;

namespace Persistencia
{
   public class clsPersistencia
    {
        public MySqlConnection con;
        public string miConexion;

        public void AbrirConexion()
        {
            miConexion = "server=localhost; uid=Jesus ; password=Luca1234. ; database=BDprueba;";
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
            AbrirConexion();
            MySqlCommand comando = new MySqlCommand(consultaSQL, con);
            comando.ExecuteNonQuery();
            CerrarConexion();
        }


        public MySqlDataReader ejecutarYdevolver(string consultaSQL)
        {
            MySqlDataReader resultado;

            AbrirConexion();

            MySqlCommand comando = new MySqlCommand(consultaSQL, con);

            resultado = comando.ExecuteReader();

            return resultado;
            CerrarConexion();

        }
        public DataTable listarAlgo(string consultaSQL)
        {
            MySqlDataAdapter listado = new MySqlDataAdapter(consultaSQL, "server=localhost; uid=root ; password= ; database=BDprueba;");

            DataTable dt = new DataTable();

            listado.Fill(dt);
            return dt;
        }

    


    }
}
