namespace Autopecas
{
    partial class Vendas
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
            this.txt_NovaVenda = new System.Windows.Forms.Label();
            this.textBox_CodigoProduto = new System.Windows.Forms.TextBox();
            this.textBox_NomeProduto = new System.Windows.Forms.TextBox();
            this.textBox_ValorProduto = new System.Windows.Forms.TextBox();
            this.label_NomeProduto = new System.Windows.Forms.Label();
            this.label_Quantidade = new System.Windows.Forms.Label();
            this.label_Valor = new System.Windows.Forms.Label();
            this.label_CodigoProduto = new System.Windows.Forms.Label();
            this.btn_listar = new System.Windows.Forms.Button();
            this.btn_addProduto = new System.Windows.Forms.Button();
            this.dataGridView_Carrinho = new System.Windows.Forms.DataGridView();
            this.codProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label_Carrinho = new System.Windows.Forms.Label();
            this.textBox_subTotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label_subtotal = new System.Windows.Forms.Label();
            this.btn_finalizaVenda = new System.Windows.Forms.Button();
            this.textBox_Quantidade = new System.Windows.Forms.TextBox();
            this.btn_remove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Carrinho)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_NovaVenda
            // 
            this.txt_NovaVenda.AutoSize = true;
            this.txt_NovaVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NovaVenda.Location = new System.Drawing.Point(41, 55);
            this.txt_NovaVenda.Name = "txt_NovaVenda";
            this.txt_NovaVenda.Size = new System.Drawing.Size(116, 39);
            this.txt_NovaVenda.TabIndex = 1;
            this.txt_NovaVenda.Text = "Venda";
            // 
            // textBox_CodigoProduto
            // 
            this.textBox_CodigoProduto.Location = new System.Drawing.Point(48, 123);
            this.textBox_CodigoProduto.Multiline = true;
            this.textBox_CodigoProduto.Name = "textBox_CodigoProduto";
            this.textBox_CodigoProduto.Size = new System.Drawing.Size(112, 23);
            this.textBox_CodigoProduto.TabIndex = 2;
            this.textBox_CodigoProduto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Quantidade_KeyPress);
            // 
            // textBox_NomeProduto
            // 
            this.textBox_NomeProduto.Enabled = false;
            this.textBox_NomeProduto.Location = new System.Drawing.Point(49, 171);
            this.textBox_NomeProduto.Multiline = true;
            this.textBox_NomeProduto.Name = "textBox_NomeProduto";
            this.textBox_NomeProduto.Size = new System.Drawing.Size(284, 23);
            this.textBox_NomeProduto.TabIndex = 3;
            // 
            // textBox_ValorProduto
            // 
            this.textBox_ValorProduto.Enabled = false;
            this.textBox_ValorProduto.Location = new System.Drawing.Point(452, 171);
            this.textBox_ValorProduto.Multiline = true;
            this.textBox_ValorProduto.Name = "textBox_ValorProduto";
            this.textBox_ValorProduto.Size = new System.Drawing.Size(125, 23);
            this.textBox_ValorProduto.TabIndex = 5;
            // 
            // label_NomeProduto
            // 
            this.label_NomeProduto.AutoSize = true;
            this.label_NomeProduto.Location = new System.Drawing.Point(45, 155);
            this.label_NomeProduto.Name = "label_NomeProduto";
            this.label_NomeProduto.Size = new System.Drawing.Size(90, 13);
            this.label_NomeProduto.TabIndex = 6;
            this.label_NomeProduto.Text = "Nome do Produto";
            // 
            // label_Quantidade
            // 
            this.label_Quantidade.AutoSize = true;
            this.label_Quantidade.Location = new System.Drawing.Point(336, 155);
            this.label_Quantidade.Name = "label_Quantidade";
            this.label_Quantidade.Size = new System.Drawing.Size(62, 13);
            this.label_Quantidade.TabIndex = 7;
            this.label_Quantidade.Text = "Quantidade";
            // 
            // label_Valor
            // 
            this.label_Valor.AutoSize = true;
            this.label_Valor.Location = new System.Drawing.Point(449, 155);
            this.label_Valor.Name = "label_Valor";
            this.label_Valor.Size = new System.Drawing.Size(31, 13);
            this.label_Valor.TabIndex = 8;
            this.label_Valor.Text = "Valor";
            // 
            // label_CodigoProduto
            // 
            this.label_CodigoProduto.AutoSize = true;
            this.label_CodigoProduto.Location = new System.Drawing.Point(46, 107);
            this.label_CodigoProduto.Name = "label_CodigoProduto";
            this.label_CodigoProduto.Size = new System.Drawing.Size(95, 13);
            this.label_CodigoProduto.TabIndex = 9;
            this.label_CodigoProduto.Text = "Código do Produto";
            // 
            // btn_listar
            // 
            this.btn_listar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_listar.Location = new System.Drawing.Point(166, 123);
            this.btn_listar.Name = "btn_listar";
            this.btn_listar.Size = new System.Drawing.Size(81, 23);
            this.btn_listar.TabIndex = 10;
            this.btn_listar.Text = "Listar";
            this.btn_listar.UseVisualStyleBackColor = true;
            this.btn_listar.Click += new System.EventHandler(this.btn_listar_Click);
            // 
            // btn_addProduto
            // 
            this.btn_addProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addProduto.Location = new System.Drawing.Point(583, 171);
            this.btn_addProduto.Name = "btn_addProduto";
            this.btn_addProduto.Size = new System.Drawing.Size(138, 23);
            this.btn_addProduto.TabIndex = 11;
            this.btn_addProduto.Text = "Adicionar Produto";
            this.btn_addProduto.UseVisualStyleBackColor = true;
            this.btn_addProduto.Click += new System.EventHandler(this.btn_addProduto_Click);
            // 
            // dataGridView_Carrinho
            // 
            this.dataGridView_Carrinho.AllowUserToAddRows = false;
            this.dataGridView_Carrinho.AllowUserToDeleteRows = false;
            this.dataGridView_Carrinho.AllowUserToResizeColumns = false;
            this.dataGridView_Carrinho.AllowUserToResizeRows = false;
            this.dataGridView_Carrinho.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Carrinho.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_Carrinho.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataGridView_Carrinho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Carrinho.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codProduto,
            this.nome,
            this.quantidade,
            this.valorUnitario,
            this.valorTotal});
            this.dataGridView_Carrinho.Location = new System.Drawing.Point(48, 269);
            this.dataGridView_Carrinho.MultiSelect = false;
            this.dataGridView_Carrinho.Name = "dataGridView_Carrinho";
            this.dataGridView_Carrinho.ReadOnly = true;
            this.dataGridView_Carrinho.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView_Carrinho.RowHeadersVisible = false;
            this.dataGridView_Carrinho.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView_Carrinho.Size = new System.Drawing.Size(673, 219);
            this.dataGridView_Carrinho.TabIndex = 12;
            this.dataGridView_Carrinho.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dataGridView_Carrinho_RowsRemoved);
            // 
            // codProduto
            // 
            this.codProduto.HeaderText = "Código do Produto";
            this.codProduto.Name = "codProduto";
            this.codProduto.ReadOnly = true;
            // 
            // nome
            // 
            this.nome.HeaderText = "Nome do Produto";
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            // 
            // quantidade
            // 
            this.quantidade.HeaderText = "Quantidade";
            this.quantidade.Name = "quantidade";
            this.quantidade.ReadOnly = true;
            // 
            // valorUnitario
            // 
            this.valorUnitario.HeaderText = "Valor Unitário";
            this.valorUnitario.Name = "valorUnitario";
            this.valorUnitario.ReadOnly = true;
            // 
            // valorTotal
            // 
            this.valorTotal.HeaderText = "Valor Total";
            this.valorTotal.Name = "valorTotal";
            this.valorTotal.ReadOnly = true;
            // 
            // label_Carrinho
            // 
            this.label_Carrinho.AutoSize = true;
            this.label_Carrinho.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Carrinho.Location = new System.Drawing.Point(42, 217);
            this.label_Carrinho.Name = "label_Carrinho";
            this.label_Carrinho.Size = new System.Drawing.Size(150, 39);
            this.label_Carrinho.TabIndex = 1;
            this.label_Carrinho.Text = "Carrinho";
            // 
            // textBox_subTotal
            // 
            this.textBox_subTotal.Enabled = false;
            this.textBox_subTotal.Location = new System.Drawing.Point(443, 547);
            this.textBox_subTotal.Multiline = true;
            this.textBox_subTotal.Name = "textBox_subTotal";
            this.textBox_subTotal.Size = new System.Drawing.Size(134, 23);
            this.textBox_subTotal.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-108, 854);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Forma de Pagamento";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(146, 882);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(107, 23);
            this.textBox3.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-147, 1216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Forma de Pagamento";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(383, 894);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(107, 23);
            this.textBox5.TabIndex = 4;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(229, 1243);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(107, 23);
            this.textBox6.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-64, 1577);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Forma de Pagamento";
            // 
            // label_subtotal
            // 
            this.label_subtotal.AutoSize = true;
            this.label_subtotal.Location = new System.Drawing.Point(440, 531);
            this.label_subtotal.Name = "label_subtotal";
            this.label_subtotal.Size = new System.Drawing.Size(46, 13);
            this.label_subtotal.TabIndex = 7;
            this.label_subtotal.Text = "Subtotal";
            // 
            // btn_finalizaVenda
            // 
            this.btn_finalizaVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_finalizaVenda.Location = new System.Drawing.Point(583, 547);
            this.btn_finalizaVenda.Name = "btn_finalizaVenda";
            this.btn_finalizaVenda.Size = new System.Drawing.Size(138, 23);
            this.btn_finalizaVenda.TabIndex = 14;
            this.btn_finalizaVenda.Text = "Finalizar Venda";
            this.btn_finalizaVenda.UseVisualStyleBackColor = true;
            this.btn_finalizaVenda.Click += new System.EventHandler(this.btn_finalizaVenda_Click);
            // 
            // textBox_Quantidade
            // 
            this.textBox_Quantidade.Location = new System.Drawing.Point(339, 171);
            this.textBox_Quantidade.Multiline = true;
            this.textBox_Quantidade.Name = "textBox_Quantidade";
            this.textBox_Quantidade.Size = new System.Drawing.Size(107, 23);
            this.textBox_Quantidade.TabIndex = 15;
            this.textBox_Quantidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Quantidade_KeyPress);
            // 
            // btn_remove
            // 
            this.btn_remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_remove.Location = new System.Drawing.Point(583, 494);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(138, 23);
            this.btn_remove.TabIndex = 16;
            this.btn_remove.Text = "Remover Item";
            this.btn_remove.UseVisualStyleBackColor = true;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // Vendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 718);
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.textBox_Quantidade);
            this.Controls.Add(this.btn_finalizaVenda);
            this.Controls.Add(this.dataGridView_Carrinho);
            this.Controls.Add(this.btn_addProduto);
            this.Controls.Add(this.btn_listar);
            this.Controls.Add(this.label_CodigoProduto);
            this.Controls.Add(this.label_Valor);
            this.Controls.Add(this.label_subtotal);
            this.Controls.Add(this.label_Quantidade);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label_NomeProduto);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox_subTotal);
            this.Controls.Add(this.textBox_ValorProduto);
            this.Controls.Add(this.textBox_NomeProduto);
            this.Controls.Add(this.textBox_CodigoProduto);
            this.Controls.Add(this.label_Carrinho);
            this.Controls.Add(this.txt_NovaVenda);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Vendas";
            this.Text = "Vendas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Carrinho)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txt_NovaVenda;
        private System.Windows.Forms.Label label_NomeProduto;
        private System.Windows.Forms.Label label_Quantidade;
        private System.Windows.Forms.Label label_Valor;
        private System.Windows.Forms.Label label_CodigoProduto;
        private System.Windows.Forms.Button btn_listar;
        private System.Windows.Forms.Button btn_addProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn codProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorTotal;
        private System.Windows.Forms.Label label_Carrinho;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_subtotal;
        public System.Windows.Forms.TextBox textBox_CodigoProduto;
        public System.Windows.Forms.TextBox textBox_NomeProduto;
        public System.Windows.Forms.TextBox textBox_ValorProduto;
        private System.Windows.Forms.Button btn_finalizaVenda;
        public System.Windows.Forms.TextBox textBox_Quantidade;
        private System.Windows.Forms.Button btn_remove;
        public System.Windows.Forms.TextBox textBox_subTotal;
        public System.Windows.Forms.DataGridView dataGridView_Carrinho;
    }
}