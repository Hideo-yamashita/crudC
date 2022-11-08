namespace crud
{
    partial class FormEdit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnConexao = new System.Windows.Forms.Button();
            this.mtbPreco = new System.Windows.Forms.MaskedTextBox();
            this.pbImgProd = new System.Windows.Forms.PictureBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.btnMostrarImg = new System.Windows.Forms.Button();
            this.btnBuscarImg = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCaminhoImg = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtQtd = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCodProd = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnBuscarProd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbImgProd)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(297, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "EDITAR PRODUTO";
            // 
            // btnConexao
            // 
            this.btnConexao.Location = new System.Drawing.Point(12, 404);
            this.btnConexao.Name = "btnConexao";
            this.btnConexao.Size = new System.Drawing.Size(75, 23);
            this.btnConexao.TabIndex = 40;
            this.btnConexao.Text = "conexao";
            this.btnConexao.UseVisualStyleBackColor = true;
            // 
            // mtbPreco
            // 
            this.mtbPreco.Location = new System.Drawing.Point(409, 232);
            this.mtbPreco.Name = "mtbPreco";
            this.mtbPreco.Size = new System.Drawing.Size(100, 20);
            this.mtbPreco.TabIndex = 39;
            // 
            // pbImgProd
            // 
            this.pbImgProd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbImgProd.Location = new System.Drawing.Point(12, 125);
            this.pbImgProd.Name = "pbImgProd";
            this.pbImgProd.Size = new System.Drawing.Size(194, 168);
            this.pbImgProd.TabIndex = 38;
            this.pbImgProd.TabStop = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackgroundImage = global::crud.Properties.Resources.Close_48x48;
            this.btnCancelar.Location = new System.Drawing.Point(355, 424);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(48, 48);
            this.btnCancelar.TabIndex = 37;
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnEnviar
            // 
            this.btnEnviar.BackgroundImage = global::crud.Properties.Resources.check_48_48;
            this.btnEnviar.Location = new System.Drawing.Point(301, 424);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(48, 48);
            this.btnEnviar.TabIndex = 36;
            this.btnEnviar.UseVisualStyleBackColor = true;
            // 
            // btnMostrarImg
            // 
            this.btnMostrarImg.Location = new System.Drawing.Point(149, 316);
            this.btnMostrarImg.Name = "btnMostrarImg";
            this.btnMostrarImg.Size = new System.Drawing.Size(28, 26);
            this.btnMostrarImg.TabIndex = 35;
            this.btnMostrarImg.UseVisualStyleBackColor = true;
            // 
            // btnBuscarImg
            // 
            this.btnBuscarImg.BackgroundImage = global::crud.Properties.Resources.lupa_24x24;
            this.btnBuscarImg.Location = new System.Drawing.Point(116, 316);
            this.btnBuscarImg.Name = "btnBuscarImg";
            this.btnBuscarImg.Size = new System.Drawing.Size(27, 26);
            this.btnBuscarImg.TabIndex = 34;
            this.btnBuscarImg.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(300, 272);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "Descrição";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 305);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "Imagem";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(512, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Quantidade";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(406, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "preço";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(300, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "marca";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(300, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Nome";
            // 
            // txtCaminhoImg
            // 
            this.txtCaminhoImg.AllowDrop = true;
            this.txtCaminhoImg.Location = new System.Drawing.Point(12, 322);
            this.txtCaminhoImg.Name = "txtCaminhoImg";
            this.txtCaminhoImg.Size = new System.Drawing.Size(100, 20);
            this.txtCaminhoImg.TabIndex = 27;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::crud.Properties.Resources.carrinho128_128;
            this.button1.Location = new System.Drawing.Point(743, 125);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 136);
            this.button1.TabIndex = 26;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(303, 293);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(312, 125);
            this.txtDescricao.TabIndex = 25;
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(303, 232);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(100, 20);
            this.txtMarca.TabIndex = 24;
            // 
            // txtQtd
            // 
            this.txtQtd.Location = new System.Drawing.Point(515, 232);
            this.txtQtd.Name = "txtQtd";
            this.txtQtd.Size = new System.Drawing.Size(100, 20);
            this.txtQtd.TabIndex = 23;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(303, 188);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(312, 20);
            this.txtNome.TabIndex = 22;
            // 
            // txtCodProd
            // 
            this.txtCodProd.Location = new System.Drawing.Point(303, 147);
            this.txtCodProd.Name = "txtCodProd";
            this.txtCodProd.Size = new System.Drawing.Size(100, 20);
            this.txtCodProd.TabIndex = 41;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(301, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 13);
            this.label8.TabIndex = 42;
            this.label8.Text = "Codigo do Produto";
            // 
            // btnBuscarProd
            // 
            this.btnBuscarProd.Location = new System.Drawing.Point(409, 147);
            this.btnBuscarProd.Name = "btnBuscarProd";
            this.btnBuscarProd.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarProd.TabIndex = 43;
            this.btnBuscarProd.Text = "button2";
            this.btnBuscarProd.UseVisualStyleBackColor = true;
            this.btnBuscarProd.Click += new System.EventHandler(this.btnBuscarProd_Click);
            // 
            // FormEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 553);
            this.Controls.Add(this.btnBuscarProd);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtCodProd);
            this.Controls.Add(this.btnConexao);
            this.Controls.Add(this.mtbPreco);
            this.Controls.Add(this.pbImgProd);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.btnMostrarImg);
            this.Controls.Add(this.btnBuscarImg);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCaminhoImg);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.txtQtd);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.Name = "FormEdit";
            this.Text = "FormEdit";
            ((System.ComponentModel.ISupportInitialize)(this.pbImgProd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConexao;
        private System.Windows.Forms.MaskedTextBox mtbPreco;
        private System.Windows.Forms.PictureBox pbImgProd;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Button btnMostrarImg;
        private System.Windows.Forms.Button btnBuscarImg;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCaminhoImg;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtQtd;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCodProd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnBuscarProd;
    }
}