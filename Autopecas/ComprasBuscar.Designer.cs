namespace Autopecas
{
    partial class ComprasBuscar
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
            this.label_listaProdutos = new System.Windows.Forms.Label();
            this.radioButton_filtroFornecedor = new System.Windows.Forms.RadioButton();
            this.radioButton_filtroNome = new System.Windows.Forms.RadioButton();
            this.groupBox_filtro = new System.Windows.Forms.GroupBox();
            this.checkBox_foraEstoque = new System.Windows.Forms.CheckBox();
            this.checkBox_estoque = new System.Windows.Forms.CheckBox();
            this.btn_listarTodos = new System.Windows.Forms.Button();
            this.radioButton_Categoria = new System.Windows.Forms.RadioButton();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.textBox_filtroBusca = new System.Windows.Forms.TextBox();
            this.dataGridView_buscaCompras = new System.Windows.Forms.DataGridView();
            this.btn_selecionar = new System.Windows.Forms.Button();
            this.groupBox_listaProdutos = new System.Windows.Forms.GroupBox();
            this.btnFechar = new System.Windows.Forms.PictureBox();
            this.barraTitulo = new System.Windows.Forms.Panel();
            this.groupBox_filtro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_buscaCompras)).BeginInit();
            this.groupBox_listaProdutos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).BeginInit();
            this.barraTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_listaProdutos
            // 
            this.label_listaProdutos.AutoSize = true;
            this.label_listaProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_listaProdutos.Location = new System.Drawing.Point(37, 60);
            this.label_listaProdutos.Name = "label_listaProdutos";
            this.label_listaProdutos.Size = new System.Drawing.Size(277, 39);
            this.label_listaProdutos.TabIndex = 18;
            this.label_listaProdutos.Text = "Buscar Compras";
            // 
            // radioButton_filtroFornecedor
            // 
            this.radioButton_filtroFornecedor.AutoSize = true;
            this.radioButton_filtroFornecedor.Location = new System.Drawing.Point(76, 19);
            this.radioButton_filtroFornecedor.Name = "radioButton_filtroFornecedor";
            this.radioButton_filtroFornecedor.Size = new System.Drawing.Size(79, 17);
            this.radioButton_filtroFornecedor.TabIndex = 3;
            this.radioButton_filtroFornecedor.Text = "Fornecedor";
            this.radioButton_filtroFornecedor.UseVisualStyleBackColor = true;
            // 
            // radioButton_filtroNome
            // 
            this.radioButton_filtroNome.AutoSize = true;
            this.radioButton_filtroNome.Checked = true;
            this.radioButton_filtroNome.Location = new System.Drawing.Point(17, 19);
            this.radioButton_filtroNome.Name = "radioButton_filtroNome";
            this.radioButton_filtroNome.Size = new System.Drawing.Size(53, 17);
            this.radioButton_filtroNome.TabIndex = 2;
            this.radioButton_filtroNome.TabStop = true;
            this.radioButton_filtroNome.Text = "Nome";
            this.radioButton_filtroNome.UseVisualStyleBackColor = true;
            // 
            // groupBox_filtro
            // 
            this.groupBox_filtro.Controls.Add(this.checkBox_foraEstoque);
            this.groupBox_filtro.Controls.Add(this.checkBox_estoque);
            this.groupBox_filtro.Controls.Add(this.btn_listarTodos);
            this.groupBox_filtro.Controls.Add(this.radioButton_Categoria);
            this.groupBox_filtro.Controls.Add(this.radioButton_filtroFornecedor);
            this.groupBox_filtro.Controls.Add(this.btn_buscar);
            this.groupBox_filtro.Controls.Add(this.textBox_filtroBusca);
            this.groupBox_filtro.Controls.Add(this.radioButton_filtroNome);
            this.groupBox_filtro.Location = new System.Drawing.Point(44, 117);
            this.groupBox_filtro.Name = "groupBox_filtro";
            this.groupBox_filtro.Size = new System.Drawing.Size(746, 90);
            this.groupBox_filtro.TabIndex = 19;
            this.groupBox_filtro.TabStop = false;
            this.groupBox_filtro.Text = "Filtro";
            // 
            // checkBox_foraEstoque
            // 
            this.checkBox_foraEstoque.AutoSize = true;
            this.checkBox_foraEstoque.Location = new System.Drawing.Point(618, 44);
            this.checkBox_foraEstoque.Name = "checkBox_foraEstoque";
            this.checkBox_foraEstoque.Size = new System.Drawing.Size(103, 17);
            this.checkBox_foraEstoque.TabIndex = 8;
            this.checkBox_foraEstoque.Text = "Fora de estoque";
            this.checkBox_foraEstoque.UseVisualStyleBackColor = true;
            // 
            // checkBox_estoque
            // 
            this.checkBox_estoque.AutoSize = true;
            this.checkBox_estoque.Checked = true;
            this.checkBox_estoque.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_estoque.Location = new System.Drawing.Point(530, 44);
            this.checkBox_estoque.Name = "checkBox_estoque";
            this.checkBox_estoque.Size = new System.Drawing.Size(82, 17);
            this.checkBox_estoque.TabIndex = 7;
            this.checkBox_estoque.Text = "Em estoque";
            this.checkBox_estoque.UseVisualStyleBackColor = true;
            // 
            // btn_listarTodos
            // 
            this.btn_listarTodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_listarTodos.Location = new System.Drawing.Point(377, 42);
            this.btn_listarTodos.Name = "btn_listarTodos";
            this.btn_listarTodos.Size = new System.Drawing.Size(129, 23);
            this.btn_listarTodos.TabIndex = 6;
            this.btn_listarTodos.Text = "Listar todos";
            this.btn_listarTodos.UseVisualStyleBackColor = true;
            this.btn_listarTodos.Click += new System.EventHandler(this.btn_listarTodos_Click);
            // 
            // radioButton_Categoria
            // 
            this.radioButton_Categoria.AutoSize = true;
            this.radioButton_Categoria.Location = new System.Drawing.Point(161, 19);
            this.radioButton_Categoria.Name = "radioButton_Categoria";
            this.radioButton_Categoria.Size = new System.Drawing.Size(70, 17);
            this.radioButton_Categoria.TabIndex = 3;
            this.radioButton_Categoria.Text = "Categoria";
            this.radioButton_Categoria.UseVisualStyleBackColor = true;
            // 
            // btn_buscar
            // 
            this.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscar.Location = new System.Drawing.Point(296, 42);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_buscar.TabIndex = 5;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // textBox_filtroBusca
            // 
            this.textBox_filtroBusca.Location = new System.Drawing.Point(17, 42);
            this.textBox_filtroBusca.Multiline = true;
            this.textBox_filtroBusca.Name = "textBox_filtroBusca";
            this.textBox_filtroBusca.Size = new System.Drawing.Size(273, 23);
            this.textBox_filtroBusca.TabIndex = 4;
            // 
            // dataGridView_buscaCompras
            // 
            this.dataGridView_buscaCompras.AllowUserToAddRows = false;
            this.dataGridView_buscaCompras.AllowUserToDeleteRows = false;
            this.dataGridView_buscaCompras.AllowUserToResizeColumns = false;
            this.dataGridView_buscaCompras.AllowUserToResizeRows = false;
            this.dataGridView_buscaCompras.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_buscaCompras.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_buscaCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_buscaCompras.Location = new System.Drawing.Point(17, 28);
            this.dataGridView_buscaCompras.Name = "dataGridView_buscaCompras";
            this.dataGridView_buscaCompras.ReadOnly = true;
            this.dataGridView_buscaCompras.RowHeadersVisible = false;
            this.dataGridView_buscaCompras.Size = new System.Drawing.Size(710, 200);
            this.dataGridView_buscaCompras.TabIndex = 5;
            // 
            // btn_selecionar
            // 
            this.btn_selecionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_selecionar.Location = new System.Drawing.Point(651, 467);
            this.btn_selecionar.Name = "btn_selecionar";
            this.btn_selecionar.Size = new System.Drawing.Size(138, 23);
            this.btn_selecionar.TabIndex = 20;
            this.btn_selecionar.Text = "Selecionar";
            this.btn_selecionar.UseVisualStyleBackColor = true;
            this.btn_selecionar.Click += new System.EventHandler(this.btn_selecionar_Click);
            // 
            // groupBox_listaProdutos
            // 
            this.groupBox_listaProdutos.Controls.Add(this.dataGridView_buscaCompras);
            this.groupBox_listaProdutos.Location = new System.Drawing.Point(44, 213);
            this.groupBox_listaProdutos.Name = "groupBox_listaProdutos";
            this.groupBox_listaProdutos.Size = new System.Drawing.Size(745, 248);
            this.groupBox_listaProdutos.TabIndex = 21;
            this.groupBox_listaProdutos.TabStop = false;
            this.groupBox_listaProdutos.Text = "Lista de Produtos";
            // 
            // btnFechar
            // 
            this.btnFechar.Image = global::Autopecas.Properties.Resources.Fechar;
            this.btnFechar.Location = new System.Drawing.Point(804, 7);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(2);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(23, 23);
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
            this.barraTitulo.Name = "barraTitulo";
            this.barraTitulo.Size = new System.Drawing.Size(837, 37);
            this.barraTitulo.TabIndex = 22;
            // 
            // ComprasBuscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 512);
            this.Controls.Add(this.label_listaProdutos);
            this.Controls.Add(this.groupBox_filtro);
            this.Controls.Add(this.btn_selecionar);
            this.Controls.Add(this.groupBox_listaProdutos);
            this.Controls.Add(this.barraTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ComprasBuscar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ComprasBuscar";
            this.groupBox_filtro.ResumeLayout(false);
            this.groupBox_filtro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_buscaCompras)).EndInit();
            this.groupBox_listaProdutos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).EndInit();
            this.barraTitulo.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_listaProdutos;
        private System.Windows.Forms.RadioButton radioButton_filtroFornecedor;
        private System.Windows.Forms.RadioButton radioButton_filtroNome;
        private System.Windows.Forms.GroupBox groupBox_filtro;
        private System.Windows.Forms.CheckBox checkBox_foraEstoque;
        private System.Windows.Forms.CheckBox checkBox_estoque;
        private System.Windows.Forms.Button btn_listarTodos;
        private System.Windows.Forms.RadioButton radioButton_Categoria;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.TextBox textBox_filtroBusca;
        private System.Windows.Forms.DataGridView dataGridView_buscaCompras;
        private System.Windows.Forms.Button btn_selecionar;
        private System.Windows.Forms.GroupBox groupBox_listaProdutos;
        private System.Windows.Forms.PictureBox btnFechar;
        private System.Windows.Forms.Panel barraTitulo;
    }
}