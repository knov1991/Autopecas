namespace Autopecas
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnVenda = new System.Windows.Forms.Button();
            this.btnCompra = new System.Windows.Forms.Button();
            this.painelEstoque = new System.Windows.Forms.Panel();
            this.btnEstoqueAdd = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btnEstoque = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelSideMenu.SuspendLayout();
            this.painelEstoque.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(250, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(684, 561);
            this.panelChildForm.TabIndex = 4;
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panelSideMenu.Controls.Add(this.btnSair);
            this.panelSideMenu.Controls.Add(this.btnVenda);
            this.panelSideMenu.Controls.Add(this.btnCompra);
            this.panelSideMenu.Controls.Add(this.painelEstoque);
            this.panelSideMenu.Controls.Add(this.btnEstoque);
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(250, 561);
            this.panelSideMenu.TabIndex = 3;
            // 
            // btnSair
            // 
            this.btnSair.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.ForeColor = System.Drawing.Color.Silver;
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.Location = new System.Drawing.Point(0, 516);
            this.btnSair.Name = "btnSair";
            this.btnSair.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnSair.Size = new System.Drawing.Size(250, 45);
            this.btnSair.TabIndex = 9;
            this.btnSair.Text = "  Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnVenda
            // 
            this.btnVenda.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVenda.FlatAppearance.BorderSize = 0;
            this.btnVenda.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.btnVenda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btnVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVenda.ForeColor = System.Drawing.Color.Silver;
            this.btnVenda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVenda.Location = new System.Drawing.Point(0, 347);
            this.btnVenda.Name = "btnVenda";
            this.btnVenda.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnVenda.Size = new System.Drawing.Size(250, 45);
            this.btnVenda.TabIndex = 8;
            this.btnVenda.Text = "  Venda";
            this.btnVenda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVenda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVenda.UseVisualStyleBackColor = true;
            // 
            // btnCompra
            // 
            this.btnCompra.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCompra.FlatAppearance.BorderSize = 0;
            this.btnCompra.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.btnCompra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btnCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompra.ForeColor = System.Drawing.Color.Silver;
            this.btnCompra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCompra.Location = new System.Drawing.Point(0, 302);
            this.btnCompra.Name = "btnCompra";
            this.btnCompra.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnCompra.Size = new System.Drawing.Size(250, 45);
            this.btnCompra.TabIndex = 3;
            this.btnCompra.Text = "  Compra";
            this.btnCompra.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCompra.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCompra.UseVisualStyleBackColor = true;
            // 
            // painelEstoque
            // 
            this.painelEstoque.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.painelEstoque.Controls.Add(this.btnEstoqueAdd);
            this.painelEstoque.Dock = System.Windows.Forms.DockStyle.Top;
            this.painelEstoque.Location = new System.Drawing.Point(0, 137);
            this.painelEstoque.Name = "painelEstoque";
            this.painelEstoque.Size = new System.Drawing.Size(250, 165);
            this.painelEstoque.TabIndex = 2;
            // 
            // btnEstoqueAdd
            // 
            this.btnEstoqueAdd.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEstoqueAdd.FlatAppearance.BorderSize = 0;
            this.btnEstoqueAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnEstoqueAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnEstoqueAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstoqueAdd.ForeColor = System.Drawing.Color.Silver;
            this.btnEstoqueAdd.Location = new System.Drawing.Point(0, 0);
            this.btnEstoqueAdd.Name = "btnEstoqueAdd";
            this.btnEstoqueAdd.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnEstoqueAdd.Size = new System.Drawing.Size(250, 40);
            this.btnEstoqueAdd.TabIndex = 0;
            this.btnEstoqueAdd.Text = "Adicionar Estoque";
            this.btnEstoqueAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEstoqueAdd.UseVisualStyleBackColor = true;
            this.btnEstoqueAdd.Click += new System.EventHandler(this.btnEstoqueAdd_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(250, 92);
            this.panelLogo.TabIndex = 0;
            // 
            // btnEstoque
            // 
            this.btnEstoque.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEstoque.FlatAppearance.BorderSize = 0;
            this.btnEstoque.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.btnEstoque.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btnEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstoque.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEstoque.Image = global::Autopecas.Properties.Resources.estoque;
            this.btnEstoque.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEstoque.Location = new System.Drawing.Point(0, 92);
            this.btnEstoque.Name = "btnEstoque";
            this.btnEstoque.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnEstoque.Size = new System.Drawing.Size(250, 45);
            this.btnEstoque.TabIndex = 1;
            this.btnEstoque.Text = "  Estoque";
            this.btnEstoque.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEstoque.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEstoque.UseVisualStyleBackColor = true;
            this.btnEstoque.Click += new System.EventHandler(this.btnEstoque_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::Autopecas.Properties.Resources.autopecas___logo;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(247, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 561);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelSideMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(950, 600);
            this.Name = "Home";
            this.Text = "Autopeças - ERP";
            this.panelSideMenu.ResumeLayout(false);
            this.painelEstoque.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnVenda;
        private System.Windows.Forms.Button btnCompra;
        private System.Windows.Forms.Panel painelEstoque;
        private System.Windows.Forms.Button btnEstoqueAdd;
        private System.Windows.Forms.Button btnEstoque;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}