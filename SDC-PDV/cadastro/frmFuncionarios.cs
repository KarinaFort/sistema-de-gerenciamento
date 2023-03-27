using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            //Tratar dados 
            
            if (txtNome.Text.ToString().Trim() =="")//Corrige preenchimnento de nome e não permite que seja vazio
            {
                MessageBox.Show("Preencha o campo nome", "Cadastro de funcionários", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNome.Text = "";
                txtNome.Focus();
                return;
            }

            if (txtCpf.Text == "   .   .   -  " || txtCpf.Text.Length < 14)
            {
                MessageBox.Show("Preencha o campo CPF", "Cadastro de funcionarios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCpf.Focus();
                return;
            }

            con.AbrirConexao();
            sql = "INSERT INTO funcionarios(nome, cpf, celular, endereco, cargo, data, foto) VALUES(@nome, @cpf, @celular, @endereco, @cargo, curDate(), @foto)";

            cmd = new MySqlCommand(sql, con.con);

            cmd.Parameters.AddWithValue("@nome", txtNome.Text);//Tratamento caixa alta da caixa de nome AAAA
            cmd.Parameters.AddWithValue("@cpf", txtCpf.Text);//Mascara 000.000.000-00
            cmd.Parameters.AddWithValue("@celular", txtCelular.Text);//(00) 00 00000-0000
            cmd.Parameters.AddWithValue("@endereco", txtEndereco.Text);//BD
            cmd.Parameters.AddWithValue("@cargo", cbCargo.Text);//BD
            cmd.Parameters.AddWithValue("@foto", img()); //metodo para tratar imagem no BD

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
                //alterouImagem = "sim";//editar imagem
            }else
            {
                LimparFoto();
            }
        }

        private byte[] img()//metodo para enviar foto ao BD
        {
            byte[] imagem_byte = null;//variavel para enviar o comprimento da imagem
            if(foto =="")
            {
                return null;
            }

            //filestream p/ enviar imagem e 3 parametros local(foto), tipo de imagem(FileMode) e tipo de acesso(FileAccess)
            FileStream fs = new FileStream(foto, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);//lidar com FileStream

            imagem_byte = br.ReadBytes((int)fs.Length);//pega o comprimento da imagem e joga p/ tipo IMAGEM BYTE
            return imagem_byte;
        }
        private void LimparFoto()
        {
            imgPerfil.Image = Properties.Resources.icons8_picture_480px_1;//coloca a imagem que indica sem foto
            foto = "img/icons8_picture_480px_1.png";
        }
    }
}
