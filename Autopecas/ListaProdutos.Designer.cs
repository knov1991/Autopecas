namespace Autopecas
{
    partial class ListaProdutos
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
            this.radioButton_filtroNome = new System.Windows.Forms.RadioButton();
            this.radioButton_filtroFornecedor = new System.Windows.Forms.RadioButton();
            this.groupBox_filtro = new System.Windows.Forms.GroupBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.textBox_filtroBusca = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox_listaProdutos = new System.Windows.Forms.GroupBox();
            this.btn_listarTodos = new System.Windows.Forms.Button();
            this.btn_selecionar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.PictureBox();
            this.barraTitulo = new System.Windows.Forms.Panel();
            this.groupBox_filtro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox_listaProdutos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).BeginInit();
            this.barraTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_listaProdutos
            // 
            this.label_listaProdutos.AutoSize = true;
            this.label_listaProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_listaProdutos.Location = new System.Drawing.Point(41, 55);
            this.label_listaProdutos.Name = "label_listaProdutos";
            this.label_listaProdutos.Size = new System.Drawing.Size(274, 39);
            this.label_listaProdutos.TabIndex = 0;
            this.label_listaProdutos.Text = "Buscar Produtos";
            // 
            // radioButton_filtroNome
            // 
            this.radioButton_filtroNome.AutoSize = true;
            this.radioButton_filtroNome.Location = new System.Drawing.Point(17, 19);
            this.radioButton_filtroNome.Name = "radioButton_filtroNome";
            this.radioButton_filtroNome.Size = new System.Drawing.Size(53, 17);
            this.radioButton_filtroNome.TabIndex = 2;
            this.radioButton_filtroNome.TabStop = true;
            this.radioButton_filtroNome.Text = "Nome";
            this.radioButton_filtroNome.UseVisualStyleBackColor = true;
            // 
            // radioButton_filtroFornecedor
            // 
            this.radioButton_filtroFornecedor.AutoSize = true;
            this.radioButton_filtroFornecedor.Location = new System.Drawing.Point(76, 19);
            this.radioButton_filtroFornecedor.Name = "radioButton_filtroFornecedor";
            this.radioButton_filtroFornecedor.Size = new System.Drawing.Size(79, 17);
            this.radioButton_filtroFornecedor.TabIndex = 3;
            this.radioButton_filtroFornecedor.TabStop = true;
            this.radioButton_filtroFornecedor.Text = "Fornecedor";
            this.radioButton_filtroFornecedor.UseVisualStyleBackColor = true;
            // 
            // groupBox_filtro
            // 
            this.groupBox_filtro.Controls.Add(this.btn_buscar);
            this.groupBox_filtro.Controls.Add(this.textBox_filtroBusca);
            this.groupBox_filtro.Controls.Add(this.radioButton_filtroFornecedor);
            this.groupBox_filtro.Controls.Add(this.radioButton_filtroNome);
            this.groupBox_filtro.Location = new System.Drawing.Point(48, 112);
            this.groupBox_filtro.Name = "groupBox_filtro";
            this.groupBox_filtro.Size = new System.Drawing.Size(653, 80);
            this.groupBox_filtro.TabIndex = 4;
            this.groupBox_filtro.TabStop = false;
            this.groupBox_filtro.Text = "Filtro";
            // 
            // btn_buscar
            // 
            this.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_buscar.Location = new System.Drawing.Point(296, 42);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_buscar.TabIndex = 5;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            // 
            // textBox_filtroBusca
            // 
            this.textBox_filtroBusca.Location = new System.Drawing.Point(17, 42);
            this.textBox_filtroBusca.Multiline = true;
            this.textBox_filtroBusca.Name = "textBox_filtroBusca";
            this.textBox_filtroBusca.Size = new System.Drawing.Size(273, 23);
            this.textBox_filtroBusca.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(17, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(619, 178);
            this.dataGridView1.TabIndex = 5;
            // 
            // groupBox_listaProdutos
            // 
            this.groupBox_listaProdutos.Controls.Add(this.btn_listarTodos);
            this.groupBox_listaProdutos.Controls.Add(this.dataGridView1);
            this.groupBox_listaProdutos.Location = new System.Drawing.Point(48, 198);
            this.groupBox_listaProdutos.Name = "groupBox_listaProdutos";
            this.groupBox_listaProdutos.Size = new System.Drawing.Size(653, 253);
            this.groupBox_listaProdutos.TabIndex = 6;
            this.groupBox_listaProdutos.TabStop = false;
            this.groupBox_listaProdutos.Text = "Lista de Produtos";
            // 
            // btn_listarTodos
            // 
            this.btn_listarTodos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_listarTodos.Location = new System.Drawing.Point(17, 212);
            this.btn_listarTodos.Name = "btn_listarTodos";
            this.btn_listarTodos.Size = new System.Drawing.Size(138, 23);
            this.btn_listarTodos.TabIndex = 6;
            this.btn_listarTodos.Text = "Listar todos";
            this.btn_listarTodos.UseVisualStyleBackColor = true;
            // 
            // btn_selecionar
            // 
            this.btn_selecionar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_selecionar.Location = new System.Drawing.Point(563, 466);
            this.btn_selecionar.Name = "btn_selecionar";
            this.btn_selecionar.Size = new System.Drawing.Size(138, 23);
            this.btn_selecionar.TabIndex = 6;
            this.btn_selecionar.Text = "Selecionar";
            this.btn_selecionar.UseVisualStyleBackColor = true;
            // 
            // btnFechar
            // 
            this.btnFechar.Image = global::Autopecas.Properties.Resources.Fechar;
            this.btnFechar.Location = new System.Drawing.Point(710, 10);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(32, 32);
            this.btnFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnFechar.TabIndex = 2;
            this.btnFechar.TabStop = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // barraTitulo
            // 
            this.barraTitulo.Controls.Add(this.btnFechar);
            this.barraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.barraTitulo.Location = new System.Drawing.Point(0, 0);
            this.barraTitulo.Name = "barraTitulo";
            this.barraTitulo.Size = new System.Drawing.Size(758, 50);
            this.barraTitulo.TabIndex = 7;
            // 
            // ListaProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(758, 541);
            this.Controls.Add(this.barraTitulo);
            this.Controls.Add(this.btn_selecionar);
            this.Controls.Add(this.groupBox_listaProdutos);
            this.Controls.Add(this.groupBox_filtro);
            this.Controls.Add(this.label_listaProdutos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListaProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Produtos";
            this.TopMost = true;
            this.groupBox_filtro.ResumeLayout(false);
            this.groupBox_filtro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox_listaProdutos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).EndInit();
            this.barraTitulo.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_listaProdutos;
        private System.Windows.Forms.RadioButton radioButton_filtroNome;
        private System.Windows.Forms.RadioButton radioButton_filtroFornecedor;
        private System.Windows.Forms.GroupBox groupBox_filtro;
        private System.Windows.Forms.TextBox textBox_filtroBusca;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox_listaProdutos;
        private System.Windows.Forms.Button btn_listarTodos;
        private System.Windows.Forms.Button btn_selecionar;
        private System.Windows.Forms.PictureBox btnFechar;
        private System.Windows.Forms.Panel barraTitulo;
    }
}