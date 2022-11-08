using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;

namespace crud
{
    public partial class Form1 : Form
    {
        MySqlConnection conexao;
        string strConexao = "server=localhost;uid=root;pwd=devisate;database=crud";
        MySqlCommand cmd;
        
        public Form1()
        {
            InitializeComponent();
            ToolTip tooltip = new ToolTip();

            tooltip.SetToolTip(btnEnviar,"Botao de envio");
            tooltip.SetToolTip(btnCancelar, "Cancelar envio");
            tooltip.SetToolTip(btnBuscarImg, "Procurar Imagem");
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnConexao_Click(object sender, EventArgs e)
        {
          
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new MySqlConnection();
                conexao.ConnectionString = strConexao;
                conexao.Open();
                //MessageBox.Show("Conexão realizada com sucesso:", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmd = new MySqlCommand();
                cmd.Connection = conexao;

                byte[] imagem_byte = null;

                FileStream fileStream = new FileStream(txtCaminhoImg.Text, FileMode.Open, FileAccess.Read);

                BinaryReader binaryReader = new BinaryReader(fileStream);

                imagem_byte = binaryReader.ReadBytes((int)fileStream.Length);

                cmd.CommandText = "INSERT INTO produtos  VALUES (null, @nome, @descricao, @preco_uni,@quantidade,@imagem,@marca)";
                cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                cmd.Parameters.AddWithValue("@descricao", txtDescricao.Text);
                cmd.Parameters.AddWithValue("@preco_uni", Convert.ToDouble(mtbPreco.Text.Replace(".",",")));
                cmd.Parameters.AddWithValue("@quantidade", Convert.ToInt32(txtQtd.Text));
                cmd.Parameters.AddWithValue("@imagem", imagem_byte);
                cmd.Parameters.AddWithValue("@marca", txtMarca.Text);
                cmd.ExecuteNonQuery();
                txtDescricao.Text = "";
                txtNome.Text = "";
                txtQtd.Text = "";
                txtMarca.Text = "";
                mtbPreco.Text = "";
            }
            catch (MySqlException mysqlEx)
            {
                MessageBox.Show("Erro do Mysql: " + mysqlEx, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Erro do Exception: " + Ex, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.Close();
            }
        }

        private void btnBuscarImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialogo = new OpenFileDialog();
            dialogo.Filter = "Arquivos Imagem (*.jpg;*.png;*.jpeg) | *.jpg;*.png;*.jpeg";
            if(dialogo.ShowDialog() == DialogResult.OK)
            {
                string img = dialogo.FileName.ToString();
                txtCaminhoImg.Text = img;
                pbImgProd.Image = new Bitmap(dialogo.FileName);
            }
        }

        private void txtCaminhoImg_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Link;

            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void txtCaminhoImg_DragDrop(object sender, DragEventArgs e)
        {
            string[] arquivo = e.Data.GetData(DataFormats.FileDrop) as string[];
            if(arquivo !=null && arquivo.Any())
            {
                txtCaminhoImg.Text = arquivo.First();
            }
        }

        private void btnMostrarImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialogo = new OpenFileDialog();
            pbImgProd.Image = new Bitmap(txtCaminhoImg.Text);

        }
    }
}
