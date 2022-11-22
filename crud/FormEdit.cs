using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace crud
{
    public partial class FormEdit : Form
    {
        MySqlConnection conexao;
        string strConexao = "server=localhost;uid=root;pwd=devisate;database=crud";
        MySqlCommand cmd;
        public FormEdit()
        {
            InitializeComponent();
        }

        private void btnBuscarProd_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new MySqlConnection();
                conexao.ConnectionString = strConexao;
                conexao.Open();



                cmd = new MySqlCommand();
                cmd.Connection = conexao;

                MySqlDataReader dataReader;

                cmd.CommandText = "SELECT * FROM PRODUTOS where id_prod = @id_prod";

                cmd.Parameters.AddWithValue("@id_prod", Convert.ToInt32(txtCodProd.Text));

                dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    txtNome.Text = dataReader["nome"].ToString();
                    mtbPreco.Text = dataReader["preco_uni"].ToString();
                    txtMarca.Text = dataReader["marca"].ToString();
                    txtQtd.Text = dataReader["Quantidade"].ToString();
                    txtDescricao.Text = dataReader["descricao"].ToString();

                    byte[] imagem = (byte[])(dataReader["imagem"]);

                    if (imagem == null)
                    {
                        pbImgProd.Image = null;
                    }
                    else
                    {
                        MemoryStream memoryStream = new MemoryStream(imagem);
                        pbImgProd.Image = System.Drawing.Image.FromStream(memoryStream);
                    }

                }
                if(dataReader.HasRows)
                {
                    MessageBox.Show("Dados localizado com sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Nenhum dado localizado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            catch (MySqlException exMysql)
            {
                MessageBox.Show("Erro Mysql" + exMysql, "Atencao", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.Close();
            }
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {

        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 FmCadastro = new Form1();
            FmCadastro.Show();
            this.Hide();
        }
    }
}
