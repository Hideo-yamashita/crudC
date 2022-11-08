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
                cmd = new MySqlCommand();
                cmd.Connection = conexao;

                MySqlDataReader dataReader;

                cmd.CommandText = "";

                cmd.Parameters.AddWithValue("@txtCodProd", Convert.ToInt32(txtCodProd.Text));

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
    }
}
