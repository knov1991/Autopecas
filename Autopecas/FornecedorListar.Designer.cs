﻿namespace Autopecas
{
    partial class FornecedorListar
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.txt_CadastroFornecedor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pesquisar Fornecedor(a)";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(64, 171);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(903, 22);
            this.textBox1.TabIndex = 1;
            // 
            // dgvDados
            // 
            this.dgvDados.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados.Location = new System.Drawing.Point(64, 210);
            this.dgvDados.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.RowHeadersWidth = 51;
            this.dgvDados.RowTemplate.Height = 24;
            this.dgvDados.Size = new System.Drawing.Size(903, 566);
            this.dgvDados.TabIndex = 2;
            // 
            // txt_CadastroFornecedor
            // 
            this.txt_CadastroFornecedor.AutoSize = true;
            this.txt_CadastroFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CadastroFornecedor.Location = new System.Drawing.Point(55, 68);
            this.txt_CadastroFornecedor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt_CadastroFornecedor.Name = "txt_CadastroFornecedor";
            this.txt_CadastroFornecedor.Size = new System.Drawing.Size(426, 52);
            this.txt_CadastroFornecedor.TabIndex = 35;
            this.txt_CadastroFornecedor.Text = "Procurar Fornecedor";
            // 
            // FornecedorListar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 884);
            this.Controls.Add(this.txt_CadastroFornecedor);
            this.Controls.Add(this.dgvDados);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FornecedorListar";
            this.Text = "FornecedorListar";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dgvDados;
        private System.Windows.Forms.Label txt_CadastroFornecedor;
    }
}