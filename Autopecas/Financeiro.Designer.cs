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
            this.label2 = new System.Windows.Forms.Label();
            this.TotalDiario = new System.Windows.Forms.Label();
            this.dataGridView_totalVendas = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelExibindo = new System.Windows.Forms.Label();
            this.labelDataInicio = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.filtroDataInicio = new System.Windows.Forms.DateTimePicker();
            this.filtroDataFinal = new System.Windows.Forms.DateTimePicker();
            this.labelTraco = new System.Windows.Forms.Label();
            this.labelDataFinal = new System.Windows.Forms.Label();
            this.labelData1 = new System.Windows.Forms.Label();
            this.labelData2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_totalVendas)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.TotalDiario.Size = new System.Drawing.Size(87, 25);
            this.TotalDiario.TabIndex = 16;
            this.TotalDiario.Text = "R$ 0,00";
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
            this.dataGridView_totalVendas.Location = new System.Drawing.Point(60, 169);
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
            this.panel1.Location = new System.Drawing.Point(61, 375);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(144, 26);
            this.panel1.TabIndex = 20;
            // 
            // labelExibindo
            // 
            this.labelExibindo.AutoSize = true;
            this.labelExibindo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExibindo.Location = new System.Drawing.Point(-4, 0);
            this.labelExibindo.Name = "labelExibindo";
            this.labelExibindo.Size = new System.Drawing.Size(134, 20);
            this.labelExibindo.TabIndex = 22;
            this.labelExibindo.Text = "Exibindo Caixa de";
            // 
            // labelDataInicio
            // 
            this.labelDataInicio.AutoSize = true;
            this.labelDataInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDataInicio.Location = new System.Drawing.Point(126, 0);
            this.labelDataInicio.Name = "labelDataInicio";
            this.labelDataInicio.Size = new System.Drawing.Size(81, 20);
            this.labelDataInicio.TabIndex = 23;
            this.labelDataInicio.Text = "DataInicio";
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.Controls.Add(this.labelDataFinal);
            this.panel2.Controls.Add(this.labelTraco);
            this.panel2.Controls.Add(this.labelExibindo);
            this.panel2.Controls.Add(this.labelDataInicio);
            this.panel2.Location = new System.Drawing.Point(61, 142);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(318, 22);
            this.panel2.TabIndex = 24;
            // 
            // filtroDataInicio
            // 
            this.filtroDataInicio.CustomFormat = "";
            this.filtroDataInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.filtroDataInicio.Location = new System.Drawing.Point(506, 143);
            this.filtroDataInicio.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.filtroDataInicio.Name = "filtroDataInicio";
            this.filtroDataInicio.Size = new System.Drawing.Size(104, 20);
            this.filtroDataInicio.TabIndex = 27;
            this.filtroDataInicio.Value = new System.DateTime(2020, 6, 25, 0, 0, 0, 0);
            this.filtroDataInicio.ValueChanged += new System.EventHandler(this.dataInicio_ValueChanged);
            // 
            // filtroDataFinal
            // 
            this.filtroDataFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.filtroDataFinal.Location = new System.Drawing.Point(616, 143);
            this.filtroDataFinal.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.filtroDataFinal.Name = "filtroDataFinal";
            this.filtroDataFinal.Size = new System.Drawing.Size(104, 20);
            this.filtroDataFinal.TabIndex = 28;
            this.filtroDataFinal.Value = new System.DateTime(2020, 6, 10, 0, 0, 0, 0);
            this.filtroDataFinal.ValueChanged += new System.EventHandler(this.dataFinal_ValueChanged);
            // 
            // labelTraco
            // 
            this.labelTraco.AutoSize = true;
            this.labelTraco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTraco.Location = new System.Drawing.Point(219, 0);
            this.labelTraco.Name = "labelTraco";
            this.labelTraco.Size = new System.Drawing.Size(14, 20);
            this.labelTraco.TabIndex = 24;
            this.labelTraco.Text = "-";
            // 
            // labelDataFinal
            // 
            this.labelDataFinal.AutoSize = true;
            this.labelDataFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDataFinal.Location = new System.Drawing.Point(237, 0);
            this.labelDataFinal.Name = "labelDataFinal";
            this.labelDataFinal.Size = new System.Drawing.Size(78, 20);
            this.labelDataFinal.TabIndex = 25;
            this.labelDataFinal.Text = "DataFinal";
            // 
            // labelData1
            // 
            this.labelData1.AutoSize = true;
            this.labelData1.Location = new System.Drawing.Point(503, 127);
            this.labelData1.Name = "labelData1";
            this.labelData1.Size = new System.Drawing.Size(60, 13);
            this.labelData1.TabIndex = 29;
            this.labelData1.Text = "Data Início";
            // 
            // labelData2
            // 
            this.labelData2.AutoSize = true;
            this.labelData2.Location = new System.Drawing.Point(613, 127);
            this.labelData2.Name = "labelData2";
            this.labelData2.Size = new System.Drawing.Size(55, 13);
            this.labelData2.TabIndex = 30;
            this.labelData2.Text = "Data Final";
            // 
            // Financeiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 718);
            this.Controls.Add(this.labelData2);
            this.Controls.Add(this.labelData1);
            this.Controls.Add(this.filtroDataFinal);
            this.Controls.Add(this.filtroDataInicio);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView_totalVendas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_NovaVenda);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Financeiro";
            this.Text = "Financeiro";
            this.Load += new System.EventHandler(this.Financeiro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_totalVendas)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txt_NovaVenda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label TotalDiario;
        private System.Windows.Forms.DataGridView dataGridView_totalVendas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelExibindo;
        private System.Windows.Forms.Label labelDataInicio;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker filtroDataInicio;
        private System.Windows.Forms.DateTimePicker filtroDataFinal;
        private System.Windows.Forms.Label labelTraco;
        private System.Windows.Forms.Label labelDataFinal;
        private System.Windows.Forms.Label labelData1;
        private System.Windows.Forms.Label labelData2;
    }
}