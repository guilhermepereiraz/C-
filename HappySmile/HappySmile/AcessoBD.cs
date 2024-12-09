﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Collections;

namespace HappySmile
{
    public class AcessoBD
    {
        SqlConnection conn;
             
        private void Conectar()
        {
            try
            {
                conn = new SqlConnection(Global.conexao);
                conn.Open();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        private void Desconectar()
        {
            try
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                    conn.Dispose();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable ConsultarSQL(string sql, List<SqlParameter> parametros)
        {
            try
            {
                Conectar();
                SqlCommand command = new SqlCommand(sql, conn);
                foreach (SqlParameter p in parametros)
                {
                    command.Parameters.Add(p);
                }
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                Desconectar();
            }
        }
        public void ExecutarSQL(string sql, List<SqlParameter> parametros)
        {
            try
            {
                Conectar();
                SqlCommand command = new SqlCommand(sql, conn);
                foreach (SqlParameter p in parametros)
                {
                    command.Parameters.Add(p);
                }
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                Desconectar();
            }
        }
    }
}
