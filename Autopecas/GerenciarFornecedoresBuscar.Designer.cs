namespace Autopecas
{
    partial class GerenciarFornecedoresBuscar
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
            this.label_listaFornecedores = new System.Windows.Forms.Label();
            this.radioButton_filtroDoc = new System.Windows.Forms.RadioButton();
            this.radioButton_filtroNome = new System.Windows.Forms.RadioButton();
            this.groupBox_filtro = new System.Windows.Forms.GroupBox();
            this.btn_listarTodos = new System.Windows.Forms.Button();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.textBox_filtroBusca = new System.Windows.Forms.TextBox();
            this.dataGridView_buscaFornecedor = new System.Windows.Forms.DataGridView();
            this.groupBox_listaProdutos = new System.Windows.Forms.GroupBox();
            this.btnFechar = new System.Windows.Forms.PictureBox();
            this.barraTitulo = new System.Windows.Forms.Panel();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.groupBox_filtro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_buscaFornecedor)).BeginInit();
            this.groupBox_listaProdutos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).BeginInit();
            this.barraTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_listaFornecedores
            // 
            this.label_listaFornecedores.AutoSize = true;
            this.label_listaFornecedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_listaFornecedores.Location = new System.Drawing.Point(55, 68);
            this.label_listaFornecedores.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_listaFornecedores.Name = "label_listaFornecedores";
            this.label_listaFornecedores.Size = new System.Drawing.Size(440, 52);
            this.label_listaFornecedores.TabIndex = 13;
            this.label_listaFornecedores.Text = "Buscar Fornecedores";
            // 
            // radioButton_filtroDoc
            // 
            this.radioButton_filtroDoc.AutoSize = true;
            this.radioButton_filtroDoc.Location = new System.Drawing.Point(101, 23);
            this.radioButton_filtroDoc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton_filtroDoc.Name = "radioButton_filtroDoc";
            this.radioButton_filtroDoc.Size = new System.Drawing.Size(64, 21);
            this.radioButton_filtroDoc.TabIndex = 3;
            this.radioButton_filtroDoc.Text = "CNPJ";
            this.radioButton_filtroDoc.UseVisualStyleBackColor = true;
            // 
            // radioButton_filtroNome
            // 
            this.radioButton_filtroNome.AutoSize = true;
            this.radioButton_filtroNome.Checked = true;
            this.radioButton_filtroNome.Location = new System.Drawing.Point(23, 23);
            this.radioButton_filtroNome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton_filtroNome.Name = "radioButton_filtroNome";
            this.radioButton_filtroNome.Size = new System.Drawing.Size(66, 21);
            this.radioButton_filtroNome.TabIndex = 2;
            this.radioButton_filtroNome.TabStop = true;
            this.radioButton_filtroNome.Text = "Nome";
            this.radioButton_filtroNome.UseVisualStyleBackColor = true;
            // 
            // groupBox_filtro
            // 
            this.groupBox_filtro.Controls.Add(this.btn_listarTodos);
            this.groupBox_filtro.Controls.Add(this.radioButton_filtroDoc);
            this.groupBox_filtro.Controls.Add(this.btn_buscar);
            this.groupBox_filtro.Controls.Add(this.textBox_filtroBusca);
            this.groupBox_filtro.Controls.Add(this.radioButton_filtroNome);
            this.groupBox_filtro.Location = new System.Drawing.Point(63, 138);
            this.groupBox_filtro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox_filtro.Name = "groupBox_filtro";
            this.groupBox_filtro.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox_filtro.Size = new System.Drawing.Size(1000, 111);
            this.groupBox_filtro.TabIndex = 14;
            this.groupBox_filtro.TabStop = false;
            this.groupBox_filtro.Text = "Filtro";
            // 
            // btn_listarTodos
            // 
            this.btn_listarTodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_listarTodos.Location = new System.Drawing.Point(503, 52);
            this.btn_listarTodos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_listarTodos.Name = "btn_listarTodos";
            this.btn_listarTodos.Size = new System.Drawing.Size(172, 28);
            this.btn_listarTodos.TabIndex = 6;
            this.btn_listarTodos.Text = "Listar todos";
            this.btn_listarTodos.UseVisualStyleBackColor = true;
            this.btn_listarTodos.Click += new System.EventHandler(this.btn_listarTodos_Click);
            // 
            // btn_buscar
            // 
            this.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscar.Location = new System.Drawing.Point(395, 52);
            this.btn_buscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(100, 28);
            this.btn_buscar.TabIndex = 5;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // textBox_filtroBusca
            // 
            this.textBox_filtroBusca.Location = new System.Drawing.Point(23, 52);
            this.textBox_filtroBusca.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_filtroBusca.Multiline = true;
            this.textBox_filtroBusca.Name = "textBox_filtroBusca";
            this.textBox_filtroBusca.Size = new System.Drawing.Size(363, 27);
            this.textBox_filtroBusca.TabIndex = 4;
            // 
            // dataGridView_buscaFornecedor
            // 
            this.dataGridView_buscaFornecedor.AllowUserToAddRows = false;
            this.dataGridView_buscaFornecedor.AllowUserToDeleteRows = false;
            this.dataGridView_buscaFornecedor.AllowUserToResizeColumns = false;
            this.dataGridView_buscaFornecedor.AllowUserToResizeRows = false;
            this.dataGridView_buscaFornecedor.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_buscaFornecedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_buscaFornecedor.Location = new System.Drawing.Point(23, 34);
            this.dataGridView_buscaFornecedor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView_buscaFornecedor.Name = "dataGridView_buscaFornecedor";
            this.dataGridView_buscaFornecedor.ReadOnly = true;
            this.dataGridView_buscaFornecedor.RowHeadersVisible = false;
            this.dataGridView_buscaFornecedor.RowHeadersWidth = 51;
            this.dataGridView_buscaFornecedor.Size = new System.Drawing.Size(953, 246);
            this.dataGridView_buscaFornecedor.TabIndex = 5;
            // 
            // groupBox_listaProdutos
            // 
            this.groupBox_listaProdutos.Controls.Add(this.dataGridView_buscaFornecedor);
            this.groupBox_listaProdutos.Location = new System.Drawing.Point(63, 256);
            this.groupBox_listaProdutos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox_listaProdutos.Name = "groupBox_listaProdutos";
            this.groupBox_listaProdutos.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox_listaProdutos.Size = new System.Drawing.Size(1000, 305);
            this.groupBox_listaProdutos.TabIndex = 16;
            this.groupBox_listaProdutos.TabStop = false;
            this.groupBox_listaProdutos.Text = "Lista de Fornecedores";
            // 
            // btnFechar
            // 
            this.btnFechar.Image = global::Autopecas.Properties.Resources.Fechar;
            this.btnFechar.Location = new System.Drawing.Point(1073, 10);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(31, 28);
            this.btnFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnFechar.TabIndex = 2;
            this.btnFechar.TabStop = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // barraTitulo
            // 
            this.barraTitulo.BackColor = System.Drawing.Color.White;
            this.barraTitulo.Controls.Add(this.btnFechar);
            this.barraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.barraTitulo.Location = new System.Drawing.Point(0, 0);
            this.barraTitulo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.barraTitulo.Name = "barraTitulo";
            this.barraTitulo.Size = new System.Drawing.Size(1117, 46);
            this.barraTitulo.TabIndex = 17;
            // 
            // btn_editar
            // 
            this.btn_editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editar.Location = new System.Drawing.Point(904, 581);
            this.btn_editar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(159, 28);
            this.btn_editar.TabIndex = 18;
            this.btn_editar.Text = "Editar";
            this.btn_editar.UseVisualStyleBackColor = true;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // btn_voltar
            // 
            this.btn_voltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_voltar.Location = new System.Drawing.Point(737, 581);
            this.btn_voltar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(159, 28);
            this.btn_voltar.TabIndex = 19;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.UseVisualStyleBackColor = true;
            // 
            // LocalizarFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 630);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.label_listaFornecedores);
            this.Controls.Add(this.groupBox_filtro);
            this.Controls.Add(this.groupBox_listaProdutos);
            this.Controls.Add(this.barraTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "LocalizarFornecedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LocalizarFornecedor";
            this.groupBox_filtro.ResumeLayout(false);
            this.groupBox_filtro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_buscaFornecedor)).EndInit();
            this.groupBox_listaProdutos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).EndInit();
            this.barraTitulo.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_listaFornecedores;
        private System.Windows.Forms.RadioButton radioButton_filtroDoc;
        private System.Windows.Forms.RadioButton radioButton_filtroNome;
        private System.Windows.Forms.GroupBox groupBox_filtro;
        private System.Windows.Forms.Button btn_listarTodos;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.TextBox textBox_filtroBusca;
        private System.Windows.Forms.DataGridView dataGridView_buscaFornecedor;
        private System.Windows.Forms.GroupBox groupBox_listaProdutos;
        private System.Windows.Forms.PictureBox btnFechar;
        private System.Windows.Forms.Panel barraTitulo;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_voltar;
    }
}