namespace Autopecas
{
    partial class ContasPagarListar
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
            this.btn_listarTodos = new System.Windows.Forms.Button();
            this.label_listaFornecedores = new System.Windows.Forms.Label();
            this.dataGridView_buscaFornecedor = new System.Windows.Forms.DataGridView();
            this.groupBox_listaProdutos = new System.Windows.Forms.GroupBox();
            this.btnFechar = new System.Windows.Forms.PictureBox();
            this.barraTitulo = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_buscaFornecedor)).BeginInit();
            this.groupBox_listaProdutos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).BeginInit();
            this.barraTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_listarTodos
            // 
            this.btn_listarTodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_listarTodos.Location = new System.Drawing.Point(586, 442);
            this.btn_listarTodos.Name = "btn_listarTodos";
            this.btn_listarTodos.Size = new System.Drawing.Size(129, 23);
            this.btn_listarTodos.TabIndex = 24;
            this.btn_listarTodos.Text = "Listar todos";
            this.btn_listarTodos.UseVisualStyleBackColor = true;
            this.btn_listarTodos.Click += new System.EventHandler(this.btn_listarTodos_Click_1);
            // 
            // label_listaFornecedores
            // 
            this.label_listaFornecedores.AutoSize = true;
            this.label_listaFornecedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_listaFornecedores.Location = new System.Drawing.Point(41, 111);
            this.label_listaFornecedores.Name = "label_listaFornecedores";
            this.label_listaFornecedores.Size = new System.Drawing.Size(374, 39);
            this.label_listaFornecedores.TabIndex = 25;
            this.label_listaFornecedores.Text = "Buscar Contas à Pagar";
            // 
            // dataGridView_buscaFornecedor
            // 
            this.dataGridView_buscaFornecedor.AllowUserToAddRows = false;
            this.dataGridView_buscaFornecedor.AllowUserToDeleteRows = false;
            this.dataGridView_buscaFornecedor.AllowUserToResizeColumns = false;
            this.dataGridView_buscaFornecedor.AllowUserToResizeRows = false;
            this.dataGridView_buscaFornecedor.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_buscaFornecedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_buscaFornecedor.Location = new System.Drawing.Point(6, 19);
            this.dataGridView_buscaFornecedor.Name = "dataGridView_buscaFornecedor";
            this.dataGridView_buscaFornecedor.ReadOnly = true;
            this.dataGridView_buscaFornecedor.RowHeadersVisible = false;
            this.dataGridView_buscaFornecedor.RowHeadersWidth = 51;
            this.dataGridView_buscaFornecedor.Size = new System.Drawing.Size(631, 200);
            this.dataGridView_buscaFornecedor.TabIndex = 5;
            this.dataGridView_buscaFornecedor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_buscaFornecedor_CellContentClick);
            // 
            // groupBox_listaProdutos
            // 
            this.groupBox_listaProdutos.Controls.Add(this.dataGridView_buscaFornecedor);
            this.groupBox_listaProdutos.Location = new System.Drawing.Point(48, 170);
            this.groupBox_listaProdutos.Name = "groupBox_listaProdutos";
            this.groupBox_listaProdutos.Size = new System.Drawing.Size(667, 248);
            this.groupBox_listaProdutos.TabIndex = 26;
            this.groupBox_listaProdutos.TabStop = false;
            this.groupBox_listaProdutos.Text = "Listar Contas ";
            // 
            // btnFechar
            // 
            this.btnFechar.Image = global::Autopecas.Properties.Resources.Fechar;
            this.btnFechar.Location = new System.Drawing.Point(722, 6);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(2);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(19, 19);
            this.btnFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnFechar.TabIndex = 2;
            this.btnFechar.TabStop = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click_1);
            // 
            // barraTitulo
            // 
            this.barraTitulo.BackColor = System.Drawing.Color.White;
            this.barraTitulo.Controls.Add(this.btnFechar);
            this.barraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.barraTitulo.Location = new System.Drawing.Point(0, 0);
            this.barraTitulo.Name = "barraTitulo";
            this.barraTitulo.Size = new System.Drawing.Size(754, 32);
            this.barraTitulo.TabIndex = 27;
            // 
            // ContasPagarListar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 512);
            this.Controls.Add(this.btn_listarTodos);
            this.Controls.Add(this.label_listaFornecedores);
            this.Controls.Add(this.groupBox_listaProdutos);
            this.Controls.Add(this.barraTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ContasPagarListar";
            this.Text = "ContasPagarListar";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_buscaFornecedor)).EndInit();
            this.groupBox_listaProdutos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).EndInit();
            this.barraTitulo.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_listarTodos;
        private System.Windows.Forms.Label label_listaFornecedores;
        private System.Windows.Forms.DataGridView dataGridView_buscaFornecedor;
        private System.Windows.Forms.GroupBox groupBox_listaProdutos;
        private System.Windows.Forms.PictureBox btnFechar;
        private System.Windows.Forms.Panel barraTitulo;
    }
}