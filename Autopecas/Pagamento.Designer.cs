namespace Autopecas
{
    partial class Pagamento
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
            this.textBox_subTotal = new System.Windows.Forms.TextBox();
            this.textBox_desconto = new System.Windows.Forms.TextBox();
            this.textBox_total = new System.Windows.Forms.TextBox();
            this.comboBox_formaPagamento = new System.Windows.Forms.ComboBox();
            this.label_subTotal = new System.Windows.Forms.Label();
            this.label_desconto = new System.Windows.Forms.Label();
            this.label_total = new System.Windows.Forms.Label();
            this.label_formaPagamento = new System.Windows.Forms.Label();
            this.comboBox_parcelas = new System.Windows.Forms.ComboBox();
            this.label_parcelado = new System.Windows.Forms.Label();
            this.btn_concluirVenda = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.PictureBox();
            this.barraTitulo = new System.Windows.Forms.Panel();
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
            this.label_listaProdutos.Size = new System.Drawing.Size(194, 39);
            this.label_listaProdutos.TabIndex = 9;
            this.label_listaProdutos.Text = "Pagamento";
            // 
            // textBox_subTotal
            // 
            this.textBox_subTotal.Enabled = false;
            this.textBox_subTotal.Location = new System.Drawing.Point(48, 142);
            this.textBox_subTotal.Multiline = true;
            this.textBox_subTotal.Name = "textBox_subTotal";
            this.textBox_subTotal.Size = new System.Drawing.Size(132, 21);
            this.textBox_subTotal.TabIndex = 10;
            // 
            // textBox_desconto
            // 
            this.textBox_desconto.Location = new System.Drawing.Point(186, 142);
            this.textBox_desconto.Multiline = true;
            this.textBox_desconto.Name = "textBox_desconto";
            this.textBox_desconto.Size = new System.Drawing.Size(134, 21);
            this.textBox_desconto.TabIndex = 11;
            this.textBox_desconto.Visible = false;
            this.textBox_desconto.TextChanged += new System.EventHandler(this.textBox_desconto_TextChanged);
            // 
            // textBox_total
            // 
            this.textBox_total.Enabled = false;
            this.textBox_total.Location = new System.Drawing.Point(48, 183);
            this.textBox_total.Multiline = true;
            this.textBox_total.Name = "textBox_total";
            this.textBox_total.Size = new System.Drawing.Size(132, 21);
            this.textBox_total.TabIndex = 12;
            // 
            // comboBox_formaPagamento
            // 
            this.comboBox_formaPagamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_formaPagamento.FormattingEnabled = true;
            this.comboBox_formaPagamento.Items.AddRange(new object[] {
            "Dinheiro (à vista)",
            "Cartão de Crédito",
            "Cartão de Débito",
            "Boleto"});
            this.comboBox_formaPagamento.Location = new System.Drawing.Point(48, 223);
            this.comboBox_formaPagamento.Name = "comboBox_formaPagamento";
            this.comboBox_formaPagamento.Size = new System.Drawing.Size(132, 21);
            this.comboBox_formaPagamento.TabIndex = 13;
            this.comboBox_formaPagamento.SelectedIndexChanged += new System.EventHandler(this.comboBox_formaPagamento_SelectedIndexChanged);
            // 
            // label_subTotal
            // 
            this.label_subTotal.AutoSize = true;
            this.label_subTotal.Location = new System.Drawing.Point(45, 126);
            this.label_subTotal.Name = "label_subTotal";
            this.label_subTotal.Size = new System.Drawing.Size(46, 13);
            this.label_subTotal.TabIndex = 14;
            this.label_subTotal.Text = "Subtotal";
            // 
            // label_desconto
            // 
            this.label_desconto.AutoSize = true;
            this.label_desconto.Location = new System.Drawing.Point(183, 126);
            this.label_desconto.Name = "label_desconto";
            this.label_desconto.Size = new System.Drawing.Size(53, 13);
            this.label_desconto.TabIndex = 15;
            this.label_desconto.Text = "Desconto";
            this.label_desconto.Visible = false;
            // 
            // label_total
            // 
            this.label_total.AutoSize = true;
            this.label_total.Location = new System.Drawing.Point(45, 167);
            this.label_total.Name = "label_total";
            this.label_total.Size = new System.Drawing.Size(31, 13);
            this.label_total.TabIndex = 16;
            this.label_total.Text = "Total";
            // 
            // label_formaPagamento
            // 
            this.label_formaPagamento.AutoSize = true;
            this.label_formaPagamento.Location = new System.Drawing.Point(45, 207);
            this.label_formaPagamento.Name = "label_formaPagamento";
            this.label_formaPagamento.Size = new System.Drawing.Size(108, 13);
            this.label_formaPagamento.TabIndex = 17;
            this.label_formaPagamento.Text = "Forma de Pagamento";
            // 
            // comboBox_parcelas
            // 
            this.comboBox_parcelas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_parcelas.FormattingEnabled = true;
            this.comboBox_parcelas.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.comboBox_parcelas.Location = new System.Drawing.Point(186, 223);
            this.comboBox_parcelas.Name = "comboBox_parcelas";
            this.comboBox_parcelas.Size = new System.Drawing.Size(105, 21);
            this.comboBox_parcelas.TabIndex = 20;
            // 
            // label_parcelado
            // 
            this.label_parcelado.AutoSize = true;
            this.label_parcelado.Location = new System.Drawing.Point(183, 207);
            this.label_parcelado.Name = "label_parcelado";
            this.label_parcelado.Size = new System.Drawing.Size(55, 13);
            this.label_parcelado.TabIndex = 21;
            this.label_parcelado.Text = "Parcelado";
            // 
            // btn_concluirVenda
            // 
            this.btn_concluirVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_concluirVenda.Location = new System.Drawing.Point(397, 273);
            this.btn_concluirVenda.Name = "btn_concluirVenda";
            this.btn_concluirVenda.Size = new System.Drawing.Size(134, 23);
            this.btn_concluirVenda.TabIndex = 23;
            this.btn_concluirVenda.Text = "Concluir Venda";
            this.btn_concluirVenda.UseVisualStyleBackColor = true;
            this.btn_concluirVenda.Click += new System.EventHandler(this.btn_concluirVenda_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Image = global::Autopecas.Properties.Resources.Fechar;
            this.btnFechar.Location = new System.Drawing.Point(527, 7);
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
            this.barraTitulo.Size = new System.Drawing.Size(563, 37);
            this.barraTitulo.TabIndex = 8;
            // 
            // Pagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 317);
            this.Controls.Add(this.btn_concluirVenda);
            this.Controls.Add(this.label_parcelado);
            this.Controls.Add(this.comboBox_parcelas);
            this.Controls.Add(this.label_formaPagamento);
            this.Controls.Add(this.label_total);
            this.Controls.Add(this.label_desconto);
            this.Controls.Add(this.label_subTotal);
            this.Controls.Add(this.comboBox_formaPagamento);
            this.Controls.Add(this.textBox_total);
            this.Controls.Add(this.textBox_desconto);
            this.Controls.Add(this.textBox_subTotal);
            this.Controls.Add(this.label_listaProdutos);
            this.Controls.Add(this.barraTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pagamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pagamento";
            this.Load += new System.EventHandler(this.Pagamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).EndInit();
            this.barraTitulo.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_listaProdutos;
        private System.Windows.Forms.TextBox textBox_subTotal;
        private System.Windows.Forms.TextBox textBox_desconto;
        private System.Windows.Forms.TextBox textBox_total;
        private System.Windows.Forms.ComboBox comboBox_formaPagamento;
        private System.Windows.Forms.Label label_subTotal;
        private System.Windows.Forms.Label label_desconto;
        private System.Windows.Forms.Label label_total;
        private System.Windows.Forms.Label label_formaPagamento;
        private System.Windows.Forms.ComboBox comboBox_parcelas;
        private System.Windows.Forms.Label label_parcelado;
        private System.Windows.Forms.Button btn_concluirVenda;
        private System.Windows.Forms.PictureBox btnFechar;
        private System.Windows.Forms.Panel barraTitulo;
    }
}