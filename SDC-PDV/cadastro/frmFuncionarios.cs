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

        private void FormatarGrid()
        {
            grid.Columns[0].HeaderText = "ID";
            grid.Columns[1].HeaderText = "Nome";
            grid.Columns[2].HeaderText = "CPF";
            grid.Columns[3].HeaderText = "Celular";
            grid.Columns[4].HeaderText = "Endereço";
            grid.Columns[5].HeaderText = "Cargo";
            grid.Columns[6].HeaderText = "Data";
            grid.Columns[7].HeaderText = "Foto";

            grid.Columns[0].Width = 50;
            grid.Columns[6].Width = 110;
            grid.Columns[0].Visible = false;
            grid.Columns[7].Visible = true;

        }

        private void frmFuncionarios_Load(object sender, EventArgs e)
        {
            LimparFoto();
            Listar();
            FormatarGrid();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            HabilitarCampo();
            LimparCampos();
            txtNome.Focus();
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

            if (txtCpf.Text == "   ,   ,   - " || txtCpf.Text.Length < 14)
            {
                MessageBox.Show("Preencha o campo CPF", "Cadastro de funcionarios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCpf.Focus();
                return;
            }

            con.AbrirConexao();
            sql = "INSERT INTO funcionarios(nome, cpf, celular, endereco, cargo, data, foto) VALUES(@nome, @cpf, @celular, @endereco, @cargo, curDate(), @foto)";

            cmd = new MySqlCommand(cmdText: sql, con.con);

            cmd.Parameters.AddWithValue("@nome", txtNome.Text);//Tratamento caixa alta da caixa de nome AAAA
            cmd.Parameters.AddWithValue("@cpf", txtCpf.Text);//Mascara 000.000.000-00
            cmd.Parameters.AddWithValue("@celular", txtCelular.Text);//(00) 00 00000-0000
            cmd.Parameters.AddWithValue("@endereco", txtEndereco.Text);//BD
            cmd.Parameters.AddWithValue("@cargo", cbCargo.Text);//BD
            cmd.Parameters.AddWithValue("@foto", img()); //metodo para tratar imagem no BD

            cmd.ExecuteNonQuery();
            con.FecharConexao();

            LimparFoto();
            

            MessageBox.Show("Registro salvo com sucesso!", "Cadastro de funcionarios", MessageBoxButtons.OK, MessageBoxIcon.Information);

            btnNovo.Enabled = true;
            btnSalvar.Enabled = false;
            btnExcluir.Enabled = false;
            btnEditar.Enabled = false;
            btnFoto.Enabled = false;

           
            LimparCampos();
            Listar();
            DesabilitarCampos();
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

        

        private void HabilitarCampo()
        {
            
            btnSalvar.Enabled = true;
            txtNome.Enabled = true;
            txtCpf.Enabled = true;
            txtCelular.Enabled = true;
            txtEndereco.Enabled = true;
            cbCargo.Enabled = true;
            btnFoto.Enabled = true;
            btnNovo.Enabled = false;

        }

        private void LimparCampos()
        {
            txtNome.Text = "";
            txtCpf.Text = "";
            txtCelular.Text = "";
            txtEndereco.Text = "";
        }

        private void DesabilitarCampos()
        {
            btnSalvar.Enabled = false;
            txtNome.Enabled = false;
            txtCpf.Enabled = false;
            txtCelular.Enabled = false;
            txtEndereco.Enabled = false;
            cbCargo.Enabled = false;
            btnFoto.Enabled = false;
            btnNovo.Enabled = true;
        }

        private void Listar()
        {
            con.AbrirConexao();
            sql = "SELECT * FROM funcionarios ORDER BY nome asc";
            cmd = new MySqlCommand(sql, con.con);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            grid.DataSource = dt;
            con.FecharConexao();
        }

        //Subindo informaçoes do BD para editar
        private void grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                HabilitarCampo();
                btnEditar.Enabled = true;
                btnExcluir.Enabled = true;
                btnSalvar.Enabled = false;
                btnNovo.Enabled = false;

                txtNome.Text = grid.CurrentRow.Cells[1].Value.ToString();
                txtCpf.Text = grid.CurrentRow.Cells[2].Value.ToString();
                txtCelular.Text = grid.CurrentRow.Cells[3].Value.ToString();
                txtEndereco.Text = grid.CurrentRow.Cells[4].Value.ToString();
                cbCargo.Text = grid.CurrentRow.Cells[5].Value.ToString();

                if(grid.CurrentRow.Cells[7].Value != DBNull.Value)//Verifica informação do banco de dados
                {
                    byte[] imagem = (byte[])grid.Rows[e.RowIndex].Cells[7].Value;//variavel byte[] criada p/ receber o que vem da grid em bytes
                    MemoryStream ms = new MemoryStream(imagem);//recebe a variavel ja com o valor da grid convertido 

                    imgPerfil.Image = Image.FromStream(ms);
                }
                else
                {
                    imgPerfil.Image = Properties.Resources.icons8_picture_480px_1;//coloca a imagem que indica sem foto
                }
            }
            else
            {
                return;
            }
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnNovo.Enabled = true;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            btnSalvar.Enabled = false;
            DesabilitarCampos();
            LimparCampos();
            

        }
    }
}
