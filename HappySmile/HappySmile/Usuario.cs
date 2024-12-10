using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace HappySmile
{
    public class Usuario
    {
        public int id { get; set; }
        public string login { get; set; }
        public string nome { get; set; }
        public string password { get; set; }
        public bool ativo { get; set; }
        public Usuario()
        {
            id = 0;
            login = string.Empty;
            nome = string.Empty;
            password = string.Empty;
            ativo = false;
        }
        AcessoBD acesso = new AcessoBD();
        DataTable dt = new DataTable();
        List<SqlParameter> lista = new List<SqlParameter>();
        string sql = string.Empty;
        public DataTable Consultar()
        {
            try
            {
                lista.Clear();
                sql = "select id, login, nome, password, ativo \n";
                sql += "from tblUsuario \n";
                if (id != 0)
                {
                    sql += "where id = @id \n";
                    lista.Add(new SqlParameter("@id", id));
                }
                else if (login != string.Empty)
                {
                    sql += "where login = @login \n";
                    lista.Add(new SqlParameter("@login", login));
                }
                else if (nome != string.Empty)
                {
                    sql += "where nome like @nome \n";
                    lista.Add(new SqlParameter("@nome", "%" + nome + "%"));
                }

                dt = acesso.ConsultarSQL(sql, lista);

                if (dt.Rows.Count > 0 && (id != 0 || login != string.Empty))
                {
                    id = Convert.ToInt32(dt.Rows[0]["id"]);
                    nome = dt.Rows[0]["nome"].ToString();
                    login = dt.Rows[0]["login"].ToString();
                    password = dt.Rows[0]["password"].ToString();
                    ativo = Convert.ToBoolean(dt.Rows[0]["ativo"]);
                }
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Gravar()
        {

            try
            {
                lista.Clear();
                if (id == 0)
                {

                    sql = "insert into tblUsuario \n";
                    sql += "(login, nome, passoword, ativo) \n";
                    sql += "values \n";
                    sql += "(@login, @nome, @password, @ativo)";
                }

                else
                {
                    sql = "update tblUsuario \n";
                    sql += "set \n";
                    sql += "login      = @login, \n";
                    sql += "nome       = @nome, \n";
                    sql += "password   = @password,  \n";
                    sql += "ativo      = @ativo \n";
                    sql += "whre id     = @id \n";
                    lista.Add(new SqlParameter("@id", id));
                }

                lista.Add(new SqlParameter("@login", login));
                lista.Add(new SqlParameter("@nome", nome));
                lista.Add(new SqlParameter("passoword", password));
                lista.Add(new SqlParameter("@ativo", ativo));
                acesso.ExecutarSQL(sql, lista);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
    
        
