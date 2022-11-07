namespace crud
{
    partial class Form1
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
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtQtd = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtCaminhoImg = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnMostrarImg = new System.Windows.Forms.Button();
            this.pbImgProd = new System.Windows.Forms.PictureBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.btnBuscarImg = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.mtbPreco = new System.Windows.Forms.MaskedTextBox();
            this.btnConexao = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbImgProd)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(148, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(611, 63);
            this.label1.TabIndex = 0;
            this.label1.Text = "CADASTRO PRODUTO";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(335, 156);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(312, 20);
            this.txtNome.TabIndex = 1;
            // 
            // txtQtd
            // 
            this.txtQtd.Location = new System.Drawing.Point(547, 200);
            this.txtQtd.Name = "txtQtd";
            this.txtQtd.Size = new System.Drawing.Size(100, 20);
            this.txtQtd.TabIndex = 3;
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(335, 200);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(100, 20);
            this.txtMarca.TabIndex = 4;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(335, 261);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(312, 125);
            this.txtDescricao.TabIndex = 5;
            // 
            // txtCaminhoImg
            // 
            this.txtCaminhoImg.AllowDrop = true;
            this.txtCaminhoImg.Location = new System.Drawing.Point(34, 335);
            this.txtCaminhoImg.Name = "txtCaminhoImg";
            this.txtCaminhoImg.Size = new System.Drawing.Size(100, 20);
            this.txtCaminhoImg.TabIndex = 8;
            this.txtCaminhoImg.DragDrop += new System.Windows.Forms.DragEventHandler(this.txtCaminhoImg_DragDrop);
            this.txtCaminhoImg.DragOver += new System.Windows.Forms.DragEventHandler(this.txtCaminhoImg_DragOver);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(332, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(332, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "marca";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(438, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "preço";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(544, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Quantidade";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 318);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Imagem";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(332, 240);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Descrição";
            // 
            // btnMostrarImg
            // 
            this.btnMostrarImg.Location = new System.Drawing.Point(171, 329);
            this.btnMostrarImg.Name = "btnMostrarImg";
            this.btnMostrarImg.Size = new System.Drawing.Size(28, 26);
            this.btnMostrarImg.TabIndex = 16;
            this.btnMostrarImg.UseVisualStyleBackColor = true;
            this.btnMostrarImg.Click += new System.EventHandler(this.btnMostrarImg_Click);
            // 
            // pbImgProd
            // 
            this.pbImgProd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbImgProd.Location = new System.Drawing.Point(34, 138);
            this.pbImgProd.Name = "pbImgProd";
            this.pbImgProd.Size = new System.Drawing.Size(194, 168);
            this.pbImgProd.TabIndex = 19;
            this.pbImgProd.TabStop = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackgroundImage = global::crud.Properties.Resources.Close_48x48;
            this.btnCancelar.Location = new System.Drawing.Point(387, 392);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(48, 48);
            this.btnCancelar.TabIndex = 18;
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnEnviar
            // 
            this.btnEnviar.BackgroundImage = global::crud.Properties.Resources.check_48_48;
            this.btnEnviar.Location = new System.Drawing.Point(333, 392);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(48, 48);
            this.btnEnviar.TabIndex = 17;
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // btnBuscarImg
            // 
            this.btnBuscarImg.BackgroundImage = global::crud.Properties.Resources.lupa_24x24;
            this.btnBuscarImg.Location = new System.Drawing.Point(138, 329);
            this.btnBuscarImg.Name = "btnBuscarImg";
            this.btnBuscarImg.Size = new System.Drawing.Size(27, 26);
            this.btnBuscarImg.TabIndex = 15;
            this.btnBuscarImg.UseVisualStyleBackColor = true;
            this.btnBuscarImg.Click += new System.EventHandler(this.btnBuscarImg_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::crud.Properties.Resources.carrinho128_128;
            this.button1.Location = new System.Drawing.Point(765, 138);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 136);
            this.button1.TabIndex = 6;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // mtbPreco
            // 
            this.mtbPreco.Location = new System.Drawing.Point(441, 200);
            this.mtbPreco.Name = "mtbPreco";
            this.mtbPreco.Size = new System.Drawing.Size(100, 20);
            this.mtbPreco.TabIndex = 20;
            // 
            // btnConexao
            // 
            this.btnConexao.Location = new System.Drawing.Point(34, 417);
            this.btnConexao.Name = "btnConexao";
            this.btnConexao.Size = new System.Drawing.Size(75, 23);
            this.btnConexao.TabIndex = 21;
            this.btnConexao.Text = "conexao";
            this.btnConexao.UseVisualStyleBackColor = true;
            this.btnConexao.Click += new System.EventHandler(this.btnConexao_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 581);
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
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbImgProd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtQtd;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtCaminhoImg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnBuscarImg;
        private System.Windows.Forms.Button btnMostrarImg;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.PictureBox pbImgProd;
        private System.Windows.Forms.MaskedTextBox mtbPreco;
        private System.Windows.Forms.Button btnConexao;
    }
}

