namespace Autopecas
{
    partial class ClientesListar
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
            this.barraTitulo = new System.Windows.Forms.Panel();
            this.btnFechar = new System.Windows.Forms.PictureBox();
            this.txt_CadastroCliente = new System.Windows.Forms.Label();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.gbFiltro = new System.Windows.Forms.GroupBox();
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.btnListar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.rbCPF = new System.Windows.Forms.RadioButton();
            this.rbTipo = new System.Windows.Forms.RadioButton();
            this.rbNome = new System.Windows.Forms.RadioButton();
            this.gbListar = new System.Windows.Forms.GroupBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.barraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.gbFiltro.SuspendLayout();
            this.gbListar.SuspendLayout();
            this.SuspendLayout();
            // 
            // barraTitulo
            // 
            this.barraTitulo.BackColor = System.Drawing.Color.White;
            this.barraTitulo.Controls.Add(this.btnFechar);
            this.barraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.barraTitulo.Location = new System.Drawing.Point(0, 0);
            this.barraTitulo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barraTitulo.Name = "barraTitulo";
            this.barraTitulo.Size = new System.Drawing.Size(1117, 46);
            this.barraTitulo.TabIndex = 0;
            // 
            // btnFechar
            // 
            this.btnFechar.Image = global::Autopecas.Properties.Resources.Fechar;
            this.btnFechar.Location = new System.Drawing.Point(963, 9);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(4);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(31, 28);
            this.btnFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnFechar.TabIndex = 3;
            this.btnFechar.TabStop = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click_1);
            // 
            // txt_CadastroCliente
            // 
            this.txt_CadastroCliente.AutoSize = true;
            this.txt_CadastroCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CadastroCliente.Location = new System.Drawing.Point(55, 68);
            this.txt_CadastroCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt_CadastroCliente.Name = "txt_CadastroCliente";
            this.txt_CadastroCliente.Size = new System.Drawing.Size(387, 52);
            this.txt_CadastroCliente.TabIndex = 36;
            this.txt_CadastroCliente.Text = "Pesquisar Clientes";
            // 
            // dgvDados
            // 
            this.dgvDados.BackgroundColor = System.Drawing.Color.White;
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados.GridColor = System.Drawing.Color.White;
            this.dgvDados.Location = new System.Drawing.Point(23, 34);
            this.dgvDados.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.RowHeadersWidth = 51;
            this.dgvDados.RowTemplate.Height = 24;
            this.dgvDados.Size = new System.Drawing.Size(953, 246);
            this.dgvDados.TabIndex = 37;
            // 
            // gbFiltro
            // 
            this.gbFiltro.Controls.Add(this.txtBusca);
            this.gbFiltro.Controls.Add(this.btnListar);
            this.gbFiltro.Controls.Add(this.btnBuscar);
            this.gbFiltro.Controls.Add(this.rbCPF);
            this.gbFiltro.Controls.Add(this.rbTipo);
            this.gbFiltro.Controls.Add(this.rbNome);
            this.gbFiltro.Location = new System.Drawing.Point(63, 138);
            this.gbFiltro.Name = "gbFiltro";
            this.gbFiltro.Size = new System.Drawing.Size(1000, 111);
            this.gbFiltro.TabIndex = 38;
            this.gbFiltro.TabStop = false;
            this.gbFiltro.Text = "Filtro";
            // 
            // txtBusca
            // 
            this.txtBusca.Location = new System.Drawing.Point(23, 52);
            this.txtBusca.Margin = new System.Windows.Forms.Padding(4);
            this.txtBusca.Multiline = true;
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(363, 27);
            this.txtBusca.TabIndex = 6;
            // 
            // btnListar
            // 
            this.btnListar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListar.Location = new System.Drawing.Point(503, 52);
            this.btnListar.Margin = new System.Windows.Forms.Padding(4);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(172, 28);
            this.btnListar.TabIndex = 5;
            this.btnListar.Text = "Listar todos";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Location = new System.Drawing.Point(395, 52);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(100, 28);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // rbCPF
            // 
            this.rbCPF.AutoSize = true;
            this.rbCPF.Location = new System.Drawing.Point(101, 23);
            this.rbCPF.Name = "rbCPF";
            this.rbCPF.Size = new System.Drawing.Size(94, 21);
            this.rbCPF.TabIndex = 2;
            this.rbCPF.Text = "CPF/CNPJ";
            this.rbCPF.UseVisualStyleBackColor = true;
            // 
            // rbTipo
            // 
            this.rbTipo.AutoSize = true;
            this.rbTipo.Location = new System.Drawing.Point(208, 23);
            this.rbTipo.Name = "rbTipo";
            this.rbTipo.Size = new System.Drawing.Size(57, 21);
            this.rbTipo.TabIndex = 1;
            this.rbTipo.Text = "Tipo";
            this.rbTipo.UseVisualStyleBackColor = true;
            // 
            // rbNome
            // 
            this.rbNome.AutoSize = true;
            this.rbNome.Checked = true;
            this.rbNome.Location = new System.Drawing.Point(23, 23);
            this.rbNome.Name = "rbNome";
            this.rbNome.Size = new System.Drawing.Size(66, 21);
            this.rbNome.TabIndex = 0;
            this.rbNome.TabStop = true;
            this.rbNome.Text = "Nome";
            this.rbNome.UseVisualStyleBackColor = true;
            // 
            // gbListar
            // 
            this.gbListar.Controls.Add(this.dgvDados);
            this.gbListar.Location = new System.Drawing.Point(63, 256);
            this.gbListar.Margin = new System.Windows.Forms.Padding(4);
            this.gbListar.Name = "gbListar";
            this.gbListar.Size = new System.Drawing.Size(1000, 305);
            this.gbListar.TabIndex = 39;
            this.gbListar.TabStop = false;
            this.gbListar.Text = "Lista de Clientes";
            // 
            // btnEditar
            // 
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Location = new System.Drawing.Point(904, 581);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(159, 28);
            this.btnEditar.TabIndex = 7;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // ClientesListar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 630);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.gbListar);
            this.Controls.Add(this.gbFiltro);
            this.Controls.Add(this.txt_CadastroCliente);
            this.Controls.Add(this.barraTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ClientesListar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClientesListar";
            this.barraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.gbFiltro.ResumeLayout(false);
            this.gbFiltro.PerformLayout();
            this.gbListar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel barraTitulo;
        private System.Windows.Forms.PictureBox btnFechar;
        private System.Windows.Forms.Label txt_CadastroCliente;
        private System.Windows.Forms.DataGridView dgvDados;
        private System.Windows.Forms.GroupBox gbFiltro;
        private System.Windows.Forms.RadioButton rbCPF;
        private System.Windows.Forms.RadioButton rbTipo;
        private System.Windows.Forms.RadioButton rbNome;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.TextBox txtBusca;
        private System.Windows.Forms.GroupBox gbListar;
        private System.Windows.Forms.Button btnEditar;
    }
}