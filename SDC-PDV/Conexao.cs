using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDC_PDV
{
    public class Conexao
    {
        //Faz a conexão do banco de dados
        public string conect = "SERVER=localhost; DATABASE=sdc-pdv; UID=root; PWD=; PORT=;";
        public MySqlConnection con = null;

        //metodo
        public void AbrirConexao()
        {

            con = new MySqlConnection(conect);
            con.Open();
        }

        public void FecharConexao()
        {
            con = new MySqlConnection(conect);
            con.Close();
            con.Dispose();//Derruba Conexões abertas
            con.ClearAllPoolsAsync(); //Limpar
        }
    }
}

   