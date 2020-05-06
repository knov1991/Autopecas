namespace Autopecas
{
    partial class Home
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
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.painelPrincipal = new System.Windows.Forms.Panel();
            this.barraTitulo = new System.Windows.Forms.Panel();
            this.btnFechar = new System.Windows.Forms.PictureBox();
            this.painelLateral = new System.Windows.Forms.Panel();
            this.btnControleFinanceiro = new System.Windows.Forms.Button();
            this.btnVendas = new System.Windows.Forms.Button();
            this.painelFornecedor = new System.Windows.Forms.Panel();
            this.btnFornecedorListar = new System.Windows.Forms.Button();
            this.btnFornecedorCadastrar = new System.Windows.Forms.Button();
            this.btnFornecedor = new System.Windows.Forms.Button();
            this.btnEstoque = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            Home.labelConectar = new System.Windows.Forms.Label();
            this.panelChildForm.SuspendLayout();
            this.painelPrincipal.SuspendLayout();
            this.barraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).BeginInit();
            this.painelLateral.SuspendLayout();
            this.painelFornecedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelChildForm.Controls.Add(this.painelPrincipal);
            this.panelChildForm.Controls.Add(this.barraTitulo);
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(250, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(774, 768);
            this.panelChildForm.TabIndex = 4;
            // 
            // painelPrincipal
            // 
            this.painelPrincipal.BackgroundImage = global::Autopecas.Properties.Resources.Autopecas;
            this.painelPrincipal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.painelPrincipal.Controls.Add(Home.labelConectar);
            this.painelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.painelPrincipal.Location = new System.Drawing.Point(0, 50);
            this.painelPrincipal.Name = "painelPrincipal";
            this.painelPrincipal.Size = new System.Drawing.Size(774, 718);
            this.painelPrincipal.TabIndex = 1;
            // 
            // barraTitulo
            // 
            this.barraTitulo.Controls.Add(this.btnFechar);
            this.barraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.barraTitulo.Location = new System.Drawing.Point(0, 0);
            this.barraTitulo.Name = "barraTitulo";
            this.barraTitulo.Size = new System.Drawing.Size(774, 50);
            this.barraTitulo.TabIndex = 0;
            this.barraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.barraTitulo_MouseDown);
            // 
            // btnFechar
            // 
            this.btnFechar.Image = global::Autopecas.Properties.Resources.Fechar;
            this.btnFechar.Location = new System.Drawing.Point(730, 9);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(32, 32);
            this.btnFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnFechar.TabIndex = 2;
            this.btnFechar.TabStop = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // painelLateral
            // 
            this.painelLateral.AutoScroll = true;
            this.painelLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.painelLateral.Controls.Add(this.btnControleFinanceiro);
            this.painelLateral.Controls.Add(this.btnVendas);
            this.painelLateral.Controls.Add(this.painelFornecedor);
            this.painelLateral.Controls.Add(this.btnFornecedor);
            this.painelLateral.Controls.Add(this.btnEstoque);
            this.painelLateral.Controls.Add(this.btnSair);
            this.painelLateral.Controls.Add(this.pictureBox1);
            this.painelLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.painelLateral.Location = new System.Drawing.Point(0, 0);
            this.painelLateral.Name = "painelLateral";
            this.painelLateral.Size = new System.Drawing.Size(250, 768);
            this.painelLateral.TabIndex = 3;
            // 
            // btnControleFinanceiro
            // 
            this.btnControleFinanceiro.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnControleFinanceiro.FlatAppearance.BorderSize = 0;
            this.btnControleFinanceiro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnControleFinanceiro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnControleFinanceiro.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnControleFinanceiro.ForeColor = System.Drawing.Color.White;
            this.btnControleFinanceiro.Image = global::Autopecas.Properties.Resources.Financeiro;
            this.btnControleFinanceiro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnControleFinanceiro.Location = new System.Drawing.Point(0, 444);
            this.btnControleFinanceiro.Name = "btnControleFinanceiro";
            this.btnControleFinanceiro.Size = new System.Drawing.Size(250, 50);
            this.btnControleFinanceiro.TabIndex = 8;
            this.btnControleFinanceiro.Text = "       Controle Financeiro";
            this.btnControleFinanceiro.UseVisualStyleBackColor = true;
            this.btnControleFinanceiro.Click += new System.EventHandler(this.btnControleFinanceiro_Click);
            // 
            // btnVendas
            // 
            this.btnVendas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVendas.FlatAppearance.BorderSize = 0;
            this.btnVendas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnVendas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVendas.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVendas.ForeColor = System.Drawing.Color.White;
            this.btnVendas.Image = global::Autopecas.Properties.Resources.Vendas;
            this.btnVendas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVendas.Location = new System.Drawing.Point(0, 394);
            this.btnVendas.Name = "btnVendas";
            this.btnVendas.Size = new System.Drawing.Size(250, 50);
            this.btnVendas.TabIndex = 6;
            this.btnVendas.Text = "Vendas";
            this.btnVendas.UseVisualStyleBackColor = true;
            this.btnVendas.Click += new System.EventHandler(this.btnVendas_Click);
            // 
            // painelFornecedor
            // 
            this.painelFornecedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(150)))));
            this.painelFornecedor.Controls.Add(this.btnFornecedorListar);
            this.painelFornecedor.Controls.Add(this.btnFornecedorCadastrar);
            this.painelFornecedor.Dock = System.Windows.Forms.DockStyle.Top;
            this.painelFornecedor.Location = new System.Drawing.Point(0, 294);
            this.painelFornecedor.Name = "painelFornecedor";
            this.painelFornecedor.Size = new System.Drawing.Size(250, 100);
            this.painelFornecedor.TabIndex = 5;
            // 
            // btnFornecedorListar
            // 
            this.btnFornecedorListar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFornecedorListar.FlatAppearance.BorderSize = 0;
            this.btnFornecedorListar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnFornecedorListar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFornecedorListar.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFornecedorListar.ForeColor = System.Drawing.Color.White;
            this.btnFornecedorListar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFornecedorListar.Location = new System.Drawing.Point(0, 50);
            this.btnFornecedorListar.Name = "btnFornecedorListar";
            this.btnFornecedorListar.Size = new System.Drawing.Size(250, 50);
            this.btnFornecedorListar.TabIndex = 5;
            this.btnFornecedorListar.Text = "Lista";
            this.btnFornecedorListar.UseVisualStyleBackColor = true;
            this.btnFornecedorListar.Click += new System.EventHandler(this.btnFornecedorListar_Click);
            // 
            // btnFornecedorCadastrar
            // 
            this.btnFornecedorCadastrar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFornecedorCadastrar.FlatAppearance.BorderSize = 0;
            this.btnFornecedorCadastrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnFornecedorCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFornecedorCadastrar.Font = new System.Drawing.Font("Arial", 14.75F);
            this.btnFornecedorCadastrar.ForeColor = System.Drawing.Color.White;
            this.btnFornecedorCadastrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFornecedorCadastrar.Location = new System.Drawing.Point(0, 0);
            this.btnFornecedorCadastrar.Name = "btnFornecedorCadastrar";
            this.btnFornecedorCadastrar.Size = new System.Drawing.Size(250, 50);
            this.btnFornecedorCadastrar.TabIndex = 4;
            this.btnFornecedorCadastrar.Text = "Cadastrar";
            this.btnFornecedorCadastrar.UseVisualStyleBackColor = true;
            this.btnFornecedorCadastrar.Click += new System.EventHandler(this.btnFornecedorCadastrar_Click);
            // 
            // btnFornecedor
            // 
            this.btnFornecedor.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFornecedor.FlatAppearance.BorderSize = 0;
            this.btnFornecedor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnFornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFornecedor.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFornecedor.ForeColor = System.Drawing.Color.White;
            this.btnFornecedor.Image = global::Autopecas.Properties.Resources.Fornecedor;
            this.btnFornecedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFornecedor.Location = new System.Drawing.Point(0, 244);
            this.btnFornecedor.Name = "btnFornecedor";
            this.btnFornecedor.Size = new System.Drawing.Size(250, 50);
            this.btnFornecedor.TabIndex = 4;
            this.btnFornecedor.Text = "Fornecedor";
            this.btnFornecedor.UseVisualStyleBackColor = true;
            this.btnFornecedor.Click += new System.EventHandler(this.btnFornecedor_Click);
            // 
            // btnEstoque
            // 
            this.btnEstoque.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEstoque.FlatAppearance.BorderSize = 0;
            this.btnEstoque.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstoque.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstoque.ForeColor = System.Drawing.Color.White;
            this.btnEstoque.Image = global::Autopecas.Properties.Resources.Estoque;
            this.btnEstoque.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEstoque.Location = new System.Drawing.Point(0, 194);
            this.btnEstoque.Name = "btnEstoque";
            this.btnEstoque.Size = new System.Drawing.Size(250, 50);
            this.btnEstoque.TabIndex = 2;
            this.btnEstoque.Text = "Estoque";
            this.btnEstoque.UseVisualStyleBackColor = true;
            this.btnEstoque.Click += new System.EventHandler(this.btnEstoque_Click);
            // 
            // btnSair
            // 
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.Image = global::Autopecas.Properties.Resources.Sair;
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.Location = new System.Drawing.Point(-2, 718);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(250, 50);
            this.btnSair.TabIndex = 1;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::Autopecas.Properties.Resources.Autopecas;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 194);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // labelConectar
            // 
            Home.labelConectar.AutoSize = true;
            Home.labelConectar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            Home.labelConectar.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Home.labelConectar.Location = new System.Drawing.Point(261, 87);
            Home.labelConectar.Name = "labelConectar";
            Home.labelConectar.Size = new System.Drawing.Size(2, 57);
            Home.labelConectar.TabIndex = 0;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.painelLateral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(1024, 768);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Autopeças - ERP";
            this.panelChildForm.ResumeLayout(false);
            this.painelPrincipal.ResumeLayout(false);
            this.painelPrincipal.PerformLayout();
            this.barraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).EndInit();
            this.painelLateral.ResumeLayout(false);
            this.painelFornecedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.Panel painelPrincipal;
        private System.Windows.Forms.Panel barraTitulo;
        private System.Windows.Forms.Panel painelLateral;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.PictureBox btnFechar;
        private System.Windows.Forms.Button btnEstoque;
        private System.Windows.Forms.Button btnVendas;
        private System.Windows.Forms.Panel painelFornecedor;
        private System.Windows.Forms.Button btnFornecedor;
        private System.Windows.Forms.Button btnFornecedorListar;
        private System.Windows.Forms.Button btnFornecedorCadastrar;
        private System.Windows.Forms.Button btnControleFinanceiro;
        public static System.Windows.Forms.Label labelConectar;
    }
}