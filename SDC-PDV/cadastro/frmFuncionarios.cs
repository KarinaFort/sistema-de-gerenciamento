using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SDC_PDV.cadastro
{
    public partial class frmFuncionarios : Form
    {
        Conexao con = new Conexao();
        string sql;
        MySqlCommand cmd;
        string foto;

        public frmFuncionarios()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //MySQL
        
            con.AbrirConexao();
            sql = "INSERT INTO funcionarios(nome, cpf, celular, endereco, cargo, data, foto) VALUES(@nome, @cpf, @celular, @endereco, @cargo, curDate(), @foto)";

            cmd = new MySqlCommand(sql, con.con);

            cmd.Parameters.AddWithValue("@nome", txtNome.Text);
            cmd.Parameters.AddWithValue("@cpf", txtCpf.Text);
            cmd.Parameters.AddWithValue("@celular", txtCelular.Text);
            cmd.Parameters.AddWithValue("@endereco", txtEndereco.Text);
            cmd.Parameters.AddWithValue("@cargo", cbCargo.Text);
           // cmd.Parameters.AddWithValue("@foto", img()); //metodo para tratar imagem no BD

            cmd.ExecuteNonQuery();
            con.FecharConexao();
        }
       

        private void btnFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Imagens(*.jpg; *.png) | *jpg;*.png"; //mostra que é permitido png e jpg
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                foto = dialog.FileName.ToString();//pega o caminho da imagem selecionada 
                imgPerfil.ImageLocation = foto; //joga caminho da imagem p/ imgPerfil p/ exibir no form
               // alterouImagem = "sim";//editar imagem
            }
        }
    }
}
