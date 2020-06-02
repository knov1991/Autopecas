namespace Autopecas
{
    partial class Estoque
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
            this.dataGridView_buscaProdutos = new System.Windows.Forms.DataGridView();
            this.groupBox_listaProdutos = new System.Windows.Forms.GroupBox();
            this.btnCadastro = new System.Windows.Forms.Button();
            this.btnGerenciar = new System.Windows.Forms.Button();
            this.groupBox_filtro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_buscaProdutos)).BeginInit();
            this.groupBox_listaProdutos.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_listaProdutos
            // 
            this.label_listaProdutos.AutoSize = true;
            this.label_listaProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_listaProdutos.Location = new System.Drawing.Point(41, 58);
            this.label_listaProdutos.Name = "label_listaProdutos";
            this.label_listaProdutos.Size = new System.Drawing.Size(144, 39);
            this.label_listaProdutos.TabIndex = 8;
            this.label_listaProdutos.Text = "Estoque";
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
            this.groupBox_filtro.Location = new System.Drawing.Point(48, 115);
            this.groupBox_filtro.Name = "groupBox_filtro";
            this.groupBox_filtro.Size = new System.Drawing.Size(674, 106);
            this.groupBox_filtro.TabIndex = 9;
            this.groupBox_filtro.TabStop = false;
            this.groupBox_filtro.Text = "Filtro de Busca";
            // 
            // checkBox_foraEstoque
            // 
            this.checkBox_foraEstoque.AutoSize = true;
            this.checkBox_foraEstoque.Location = new System.Drawing.Point(105, 71);
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
            this.checkBox_estoque.Location = new System.Drawing.Point(17, 71);
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
            // dataGridView_buscaProdutos
            // 
            this.dataGridView_buscaProdutos.AllowUserToAddRows = false;
            this.dataGridView_buscaProdutos.AllowUserToDeleteRows = false;
            this.dataGridView_buscaProdutos.AllowUserToResizeColumns = false;
            this.dataGridView_buscaProdutos.AllowUserToResizeRows = false;
            this.dataGridView_buscaProdutos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_buscaProdutos.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_buscaProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_buscaProdutos.Location = new System.Drawing.Point(17, 28);
            this.dataGridView_buscaProdutos.Name = "dataGridView_buscaProdutos";
            this.dataGridView_buscaProdutos.ReadOnly = true;
            this.dataGridView_buscaProdutos.RowHeadersVisible = false;
            this.dataGridView_buscaProdutos.Size = new System.Drawing.Size(637, 200);
            this.dataGridView_buscaProdutos.TabIndex = 5;
            // 
            // groupBox_listaProdutos
            // 
            this.groupBox_listaProdutos.Controls.Add(this.dataGridView_buscaProdutos);
            this.groupBox_listaProdutos.Location = new System.Drawing.Point(48, 227);
            this.groupBox_listaProdutos.Name = "groupBox_listaProdutos";
            this.groupBox_listaProdutos.Size = new System.Drawing.Size(674, 248);
            this.groupBox_listaProdutos.TabIndex = 11;
            this.groupBox_listaProdutos.TabStop = false;
            this.groupBox_listaProdutos.Text = "Lista de Produtos";
            // 
            // btnCadastro
            // 
            this.btnCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastro.Image = global::Autopecas.Properties.Resources.Novo;
            this.btnCadastro.Location = new System.Drawing.Point(48, 480);
            this.btnCadastro.Margin = new System.Windows.Forms.Padding(2);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(155, 44);
            this.btnCadastro.TabIndex = 16;
            this.btnCadastro.Text = "  Cadastrar Produtos";
            this.btnCadastro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCadastro.UseVisualStyleBackColor = true;
            this.btnCadastro.Click += new System.EventHandler(this.btnCadastro_Click);
            // 
            // btnGerenciar
            // 
            this.btnGerenciar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGerenciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerenciar.Image = global::Autopecas.Properties.Resources.Alterar;
            this.btnGerenciar.Location = new System.Drawing.Point(209, 480);
            this.btnGerenciar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGerenciar.Name = "btnGerenciar";
            this.btnGerenciar.Size = new System.Drawing.Size(155, 44);
            this.btnGerenciar.TabIndex = 17;
            this.btnGerenciar.Text = "  Gerenciar Produto Selecionado";
            this.btnGerenciar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGerenciar.UseVisualStyleBackColor = true;
            this.btnGerenciar.Click += new System.EventHandler(this.btnGerenciar_Click);
            // 
            // Estoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 718);
            this.Controls.Add(this.btnGerenciar);
            this.Controls.Add(this.btnCadastro);
            this.Controls.Add(this.label_listaProdutos);
            this.Controls.Add(this.groupBox_filtro);
            this.Controls.Add(this.groupBox_listaProdutos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Estoque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GerenciarEstoque";
            this.groupBox_filtro.ResumeLayout(false);
            this.groupBox_filtro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_buscaProdutos)).EndInit();
            this.groupBox_listaProdutos.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_listaProdutos;
        private System.Windows.Forms.RadioButton radioButton_filtroFornecedor;
        private System.Windows.Forms.RadioButton radioButton_filtroNome;
        private System.Windows.Forms.CheckBox checkBox_foraEstoque;
        private System.Windows.Forms.CheckBox checkBox_estoque;
        private System.Windows.Forms.Button btn_listarTodos;
        private System.Windows.Forms.RadioButton radioButton_Categoria;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.TextBox textBox_filtroBusca;
        private System.Windows.Forms.DataGridView dataGridView_buscaProdutos;
        private System.Windows.Forms.GroupBox groupBox_listaProdutos;
        private System.Windows.Forms.GroupBox groupBox_filtro;
        public System.Windows.Forms.Button btnCadastro;
        public System.Windows.Forms.Button btnGerenciar;
    }
}