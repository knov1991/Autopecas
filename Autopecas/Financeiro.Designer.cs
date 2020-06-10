namespace Autopecas
{
    partial class Financeiro
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
            this.btnContasReceber = new System.Windows.Forms.Button();
            this.btnContasPagar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TotalDiario = new System.Windows.Forms.Label();
            this.dataGridView_totalVendas = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_totalVendas)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_NovaVenda
            // 
            this.txt_NovaVenda.AutoSize = true;
            this.txt_NovaVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NovaVenda.Location = new System.Drawing.Point(54, 49);
            this.txt_NovaVenda.Name = "txt_NovaVenda";
            this.txt_NovaVenda.Size = new System.Drawing.Size(179, 39);
            this.txt_NovaVenda.TabIndex = 2;
            this.txt_NovaVenda.Text = "Financeiro";
            // 
            // btnContasReceber
            // 
            this.btnContasReceber.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContasReceber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContasReceber.Location = new System.Drawing.Point(59, 419);
            this.btnContasReceber.Name = "btnContasReceber";
            this.btnContasReceber.Size = new System.Drawing.Size(196, 45);
            this.btnContasReceber.TabIndex = 11;
            this.btnContasReceber.Text = "Contas Receber";
            this.btnContasReceber.UseVisualStyleBackColor = true;
            this.btnContasReceber.Click += new System.EventHandler(this.btnContasReceber_Click);
            // 
            // btnContasPagar
            // 
            this.btnContasPagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContasPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContasPagar.Location = new System.Drawing.Point(261, 419);
            this.btnContasPagar.Name = "btnContasPagar";
            this.btnContasPagar.Size = new System.Drawing.Size(196, 45);
            this.btnContasPagar.TabIndex = 12;
            this.btnContasPagar.Text = "Contas Pagar";
            this.btnContasPagar.UseVisualStyleBackColor = true;
            this.btnContasPagar.Click += new System.EventHandler(this.btnContasPagar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "Vendas Diárias";
            // 
            // TotalDiario
            // 
            this.TotalDiario.AutoSize = true;
            this.TotalDiario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalDiario.Location = new System.Drawing.Point(54, 1);
            this.TotalDiario.Name = "TotalDiario";
            this.TotalDiario.Size = new System.Drawing.Size(62, 25);
            this.TotalDiario.TabIndex = 16;
            this.TotalDiario.Text = "Valor";
            // 
            // dataGridView_totalVendas
            // 
            this.dataGridView_totalVendas.AllowUserToAddRows = false;
            this.dataGridView_totalVendas.AllowUserToDeleteRows = false;
            this.dataGridView_totalVendas.AllowUserToResizeColumns = false;
            this.dataGridView_totalVendas.AllowUserToResizeRows = false;
            this.dataGridView_totalVendas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_totalVendas.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_totalVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_totalVendas.Location = new System.Drawing.Point(60, 154);
            this.dataGridView_totalVendas.Name = "dataGridView_totalVendas";
            this.dataGridView_totalVendas.ReadOnly = true;
            this.dataGridView_totalVendas.RowHeadersVisible = false;
            this.dataGridView_totalVendas.Size = new System.Drawing.Size(660, 200);
            this.dataGridView_totalVendas.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-5, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 25);
            this.label1.TabIndex = 19;
            this.label1.Text = "Total:";
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.TotalDiario);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(61, 360);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(119, 26);
            this.panel1.TabIndex = 20;
            // 
            // Financeiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 718);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView_totalVendas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnContasPagar);
            this.Controls.Add(this.btnContasReceber);
            this.Controls.Add(this.txt_NovaVenda);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Financeiro";
            this.Text = "Financeiro";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_totalVendas)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txt_NovaVenda;
        private System.Windows.Forms.Button btnContasReceber;
        private System.Windows.Forms.Button btnContasPagar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label TotalDiario;
        private System.Windows.Forms.DataGridView dataGridView_totalVendas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}