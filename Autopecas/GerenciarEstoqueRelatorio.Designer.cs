namespace Autopecas
{
    partial class GerenciarEstoqueRelatorio
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
            this.btn_voltar = new System.Windows.Forms.Button();
            this.label_listaFornecedores = new System.Windows.Forms.Label();
            this.groupBox_filtro = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.filtroData = new System.Windows.Forms.DateTimePicker();
            this.btnListarTodos = new System.Windows.Forms.Button();
            this.groupBox_listaProdutos = new System.Windows.Forms.GroupBox();
            this.dataGridView_relatorios = new System.Windows.Forms.DataGridView();
            this.barraTitulo = new System.Windows.Forms.Panel();
            this.btnFechar = new System.Windows.Forms.PictureBox();
            this.groupBox_filtro.SuspendLayout();
            this.groupBox_listaProdutos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_relatorios)).BeginInit();
            this.barraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_voltar
            // 
            this.btn_voltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_voltar.Location = new System.Drawing.Point(595, 433);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(119, 23);
            this.btn_voltar.TabIndex = 25;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.UseVisualStyleBackColor = true;
            // 
            // label_listaFornecedores
            // 
            this.label_listaFornecedores.AutoSize = true;
            this.label_listaFornecedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_listaFornecedores.Location = new System.Drawing.Point(41, 55);
            this.label_listaFornecedores.Name = "label_listaFornecedores";
            this.label_listaFornecedores.Size = new System.Drawing.Size(475, 39);
            this.label_listaFornecedores.TabIndex = 20;
            this.label_listaFornecedores.Text = "Buscar Relatórios de Estoque";
            // 
            // groupBox_filtro
            // 
            this.groupBox_filtro.Controls.Add(this.btnBuscar);
            this.groupBox_filtro.Controls.Add(this.filtroData);
            this.groupBox_filtro.Controls.Add(this.btnListarTodos);
            this.groupBox_filtro.Location = new System.Drawing.Point(47, 112);
            this.groupBox_filtro.Name = "groupBox_filtro";
            this.groupBox_filtro.Size = new System.Drawing.Size(667, 60);
            this.groupBox_filtro.TabIndex = 21;
            this.groupBox_filtro.TabStop = false;
            this.groupBox_filtro.Text = "Filtro";
            // 
            // btnBuscar
            // 
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Location = new System.Drawing.Point(139, 22);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(98, 23);
            this.btnBuscar.TabIndex = 10;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // filtroData
            // 
            this.filtroData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.filtroData.Location = new System.Drawing.Point(17, 24);
            this.filtroData.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.filtroData.Name = "filtroData";
            this.filtroData.Size = new System.Drawing.Size(116, 20);
            this.filtroData.TabIndex = 9;
            this.filtroData.Value = new System.DateTime(2020, 6, 10, 0, 0, 0, 0);
            // 
            // btnListarTodos
            // 
            this.btnListarTodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListarTodos.Location = new System.Drawing.Point(243, 22);
            this.btnListarTodos.Name = "btnListarTodos";
            this.btnListarTodos.Size = new System.Drawing.Size(129, 23);
            this.btnListarTodos.TabIndex = 6;
            this.btnListarTodos.Text = "Listar todos";
            this.btnListarTodos.UseVisualStyleBackColor = true;
            this.btnListarTodos.Click += new System.EventHandler(this.btnListarTodos_Click);
            // 
            // groupBox_listaProdutos
            // 
            this.groupBox_listaProdutos.Controls.Add(this.dataGridView_relatorios);
            this.groupBox_listaProdutos.Location = new System.Drawing.Point(47, 178);
            this.groupBox_listaProdutos.Name = "groupBox_listaProdutos";
            this.groupBox_listaProdutos.Size = new System.Drawing.Size(667, 249);
            this.groupBox_listaProdutos.TabIndex = 22;
            this.groupBox_listaProdutos.TabStop = false;
            this.groupBox_listaProdutos.Text = "Relatórios";
            // 
            // dataGridView_relatorios
            // 
            this.dataGridView_relatorios.AllowUserToAddRows = false;
            this.dataGridView_relatorios.AllowUserToDeleteRows = false;
            this.dataGridView_relatorios.AllowUserToResizeColumns = false;
            this.dataGridView_relatorios.AllowUserToResizeRows = false;
            this.dataGridView_relatorios.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_relatorios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_relatorios.Location = new System.Drawing.Point(17, 28);
            this.dataGridView_relatorios.Name = "dataGridView_relatorios";
            this.dataGridView_relatorios.ReadOnly = true;
            this.dataGridView_relatorios.RowHeadersVisible = false;
            this.dataGridView_relatorios.RowHeadersWidth = 51;
            this.dataGridView_relatorios.Size = new System.Drawing.Size(631, 200);
            this.dataGridView_relatorios.TabIndex = 5;
            // 
            // barraTitulo
            // 
            this.barraTitulo.BackColor = System.Drawing.Color.White;
            this.barraTitulo.Controls.Add(this.btnFechar);
            this.barraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.barraTitulo.Location = new System.Drawing.Point(0, 0);
            this.barraTitulo.Name = "barraTitulo";
            this.barraTitulo.Size = new System.Drawing.Size(754, 32);
            this.barraTitulo.TabIndex = 23;
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
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // GerenciarEstoqueRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 475);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.label_listaFornecedores);
            this.Controls.Add(this.groupBox_filtro);
            this.Controls.Add(this.groupBox_listaProdutos);
            this.Controls.Add(this.barraTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GerenciarEstoqueRelatorio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GerenciarEstoqueRelatorio";
            this.groupBox_filtro.ResumeLayout(false);
            this.groupBox_listaProdutos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_relatorios)).EndInit();
            this.barraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.Label label_listaFornecedores;
        private System.Windows.Forms.GroupBox groupBox_filtro;
        private System.Windows.Forms.Button btnListarTodos;
        private System.Windows.Forms.GroupBox groupBox_listaProdutos;
        private System.Windows.Forms.Panel barraTitulo;
        private System.Windows.Forms.PictureBox btnFechar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DateTimePicker filtroData;
        private System.Windows.Forms.DataGridView dataGridView_relatorios;
    }
}