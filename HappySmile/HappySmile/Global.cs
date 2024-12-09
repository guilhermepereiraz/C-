using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Configuration;
using System.Net.NetworkInformation;

namespace HappySmile
{
    public static class Global
    {
        public enum tabelas
        {
            Especialidade,
            FormaPagamento,
            Procedimento,
            Situacao,
            Tipo,
            TipoTelefone
        }
        public static string conexao = string.Empty;
        public static string servidor = string.Empty;
        public static string banco = string.Empty;

        public static string usuario = string.Empty;
        public static string nome = string.Empty;
        public static int idUsuario = 0;

        public static string EncriptPassword(string senha)
        {
            Byte[] original;
            Byte[] criptografado;
            MD5 md5 = new MD5CryptoServiceProvider();
            original = ASCIIEncoding.Default.GetBytes(senha);
            criptografado = md5.ComputeHash(original);

            return Regex.Replace(BitConverter.ToString(criptografado), "-", "").ToLower();
        }
        public static void MontarStringConexao()
        {
            servidor = ConfigurationManager.AppSettings["server"];
            banco = ConfigurationManager.AppSettings["database"];
            conexao = string.Format("Data Source={0};Initial Catalog={1};Integrated Security=true;",
                servidor, banco);            
        }
    }
}
