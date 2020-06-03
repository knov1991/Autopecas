namespace Autopecas
{
    partial class Clientes
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
            this.rbTipo = new System.Windows.Forms.GroupBox();
            this.rbJuridico = new System.Windows.Forms.RadioButton();
            this.rbFisico = new System.Windows.Forms.RadioButton();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lbNome = new System.Windows.Forms.Label();
            this.txtRSocial = new System.Windows.Forms.TextBox();
            this.lbRSocial = new System.Windows.Forms.Label();
            this.txtCPFCNPJ = new System.Windows.Forms.TextBox();
            this.lbCPFCNPJ = new System.Windows.Forms.Label();
            this.txtRGIE = new System.Windows.Forms.TextBox();
            this.lbRGIE = new System.Windows.Forms.Label();
            this.txtCep = new System.Windows.Forms.TextBox();
            this.lbCEP = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.lbEstado = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.lbCidade = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.lbBairro = new System.Windows.Forms.Label();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.lbRua = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lbNumero = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.lbCelular = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.lbTelefone = new System.Windows.Forms.Label();
            this.txt_CadastroFornecedor = new System.Windows.Forms.Label();
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnLocalizar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.rbTipo.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbTipo
            // 
            this.rbTipo.Controls.Add(this.rbJuridico);
            this.rbTipo.Controls.Add(this.rbFisico);
            this.rbTipo.Location = new System.Drawing.Point(46, 111);
            this.rbTipo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbTipo.Name = "rbTipo";
            this.rbTipo.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbTipo.Size = new System.Drawing.Size(182, 50);
            this.rbTipo.TabIndex = 0;
            this.rbTipo.TabStop = false;
            this.rbTipo.Text = "Tipo de Cliente";
            // 
            // rbJuridico
            // 
            this.rbJuridico.AutoSize = true;
            this.rbJuridico.Location = new System.Drawing.Point(97, 20);
            this.rbJuridico.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbJuridico.Name = "rbJuridico";
            this.rbJuridico.Size = new System.Drawing.Size(63, 17);
            this.rbJuridico.TabIndex = 1;
            this.rbJuridico.Text = "Jurídico";
            this.rbJuridico.UseVisualStyleBackColor = true;
            this.rbJuridico.CheckedChanged += new System.EventHandler(this.rbJuridico_CheckedChanged);
            // 
            // rbFisico
            // 
            this.rbFisico.AutoSize = true;
            this.rbFisico.Checked = true;
            this.rbFisico.Location = new System.Drawing.Point(30, 20);
            this.rbFisico.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbFisico.Name = "rbFisico";
            this.rbFisico.Size = new System.Drawing.Size(54, 17);
            this.rbFisico.TabIndex = 0;
            this.rbFisico.TabStop = true;
            this.rbFisico.Text = "Físico";
            this.rbFisico.UseVisualStyleBackColor = true;
            this.rbFisico.CheckedChanged += new System.EventHandler(this.rbFisico_CheckedChanged);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(46, 192);
            this.txtNome.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(667, 20);
            this.txtNome.TabIndex = 4;
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(43, 175);
            this.lbNome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(35, 13);
            this.lbNome.TabIndex = 3;
            this.lbNome.Text = "Nome";
            // 
            // txtRSocial
            // 
            this.txtRSocial.Location = new System.Drawing.Point(46, 239);
            this.txtRSocial.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtRSocial.Name = "txtRSocial";
            this.txtRSocial.Size = new System.Drawing.Size(667, 20);
            this.txtRSocial.TabIndex = 6;
            this.txtRSocial.Visible = false;
            // 
            // lbRSocial
            // 
            this.lbRSocial.AutoSize = true;
            this.lbRSocial.Location = new System.Drawing.Point(43, 222);
            this.lbRSocial.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbRSocial.Name = "lbRSocial";
            this.lbRSocial.Size = new System.Drawing.Size(70, 13);
            this.lbRSocial.TabIndex = 5;
            this.lbRSocial.Text = "Razão Social";
            this.lbRSocial.Visible = false;
            // 
            // txtCPFCNPJ
            // 
            this.txtCPFCNPJ.Location = new System.Drawing.Point(46, 282);
            this.txtCPFCNPJ.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCPFCNPJ.MaxLength = 5000;
            this.txtCPFCNPJ.Name = "txtCPFCNPJ";
            this.txtCPFCNPJ.Size = new System.Drawing.Size(329, 20);
            this.txtCPFCNPJ.TabIndex = 8;
            this.txtCPFCNPJ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCPFCNPJ_KeyPress);
            // 
            // lbCPFCNPJ
            // 
            this.lbCPFCNPJ.AutoSize = true;
            this.lbCPFCNPJ.Location = new System.Drawing.Point(43, 266);
            this.lbCPFCNPJ.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCPFCNPJ.Name = "lbCPFCNPJ";
            this.lbCPFCNPJ.Size = new System.Drawing.Size(27, 13);
            this.lbCPFCNPJ.TabIndex = 7;
            this.lbCPFCNPJ.Text = "CPF";
            // 
            // txtRGIE
            // 
            this.txtRGIE.Location = new System.Drawing.Point(379, 282);
            this.txtRGIE.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtRGIE.Name = "txtRGIE";
            this.txtRGIE.Size = new System.Drawing.Size(332, 20);
            this.txtRGIE.TabIndex = 10;
            this.txtRGIE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRGIE_KeyPress);
            // 
            // lbRGIE
            // 
            this.lbRGIE.AutoSize = true;
            this.lbRGIE.Location = new System.Drawing.Point(376, 267);
            this.lbRGIE.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbRGIE.Name = "lbRGIE";
            this.lbRGIE.Size = new System.Drawing.Size(23, 13);
            this.lbRGIE.TabIndex = 9;
            this.lbRGIE.Text = "RG";
            // 
            // txtCep
            // 
            this.txtCep.Location = new System.Drawing.Point(46, 329);
            this.txtCep.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCep.MaxLength = 9;
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(159, 20);
            this.txtCep.TabIndex = 12;
            this.txtCep.TextChanged += new System.EventHandler(this.txtCep_TextChanged);
            this.txtCep.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCep_KeyPress);
            // 
            // lbCEP
            // 
            this.lbCEP.AutoSize = true;
            this.lbCEP.Location = new System.Drawing.Point(43, 313);
            this.lbCEP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCEP.Name = "lbCEP";
            this.lbCEP.Size = new System.Drawing.Size(28, 13);
            this.lbCEP.TabIndex = 11;
            this.lbCEP.Text = "CEP";
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(209, 329);
            this.txtEstado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(37, 20);
            this.txtEstado.TabIndex = 14;
            // 
            // lbEstado
            // 
            this.lbEstado.AutoSize = true;
            this.lbEstado.Location = new System.Drawing.Point(206, 314);
            this.lbEstado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbEstado.Name = "lbEstado";
            this.lbEstado.Size = new System.Drawing.Size(21, 13);
            this.lbEstado.TabIndex = 13;
            this.lbEstado.Text = "UF";
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(250, 329);
            this.txtCidade.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(175, 20);
            this.txtCidade.TabIndex = 16;
            // 
            // lbCidade
            // 
            this.lbCidade.AutoSize = true;
            this.lbCidade.Location = new System.Drawing.Point(247, 314);
            this.lbCidade.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCidade.Name = "lbCidade";
            this.lbCidade.Size = new System.Drawing.Size(40, 13);
            this.lbCidade.TabIndex = 15;
            this.lbCidade.Text = "Cidade";
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(429, 329);
            this.txtBairro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(284, 20);
            this.txtBairro.TabIndex = 18;
            // 
            // lbBairro
            // 
            this.lbBairro.AutoSize = true;
            this.lbBairro.Location = new System.Drawing.Point(426, 313);
            this.lbBairro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbBairro.Name = "lbBairro";
            this.lbBairro.Size = new System.Drawing.Size(34, 13);
            this.lbBairro.TabIndex = 17;
            this.lbBairro.Text = "Bairro";
            // 
            // txtRua
            // 
            this.txtRua.Location = new System.Drawing.Point(45, 371);
            this.txtRua.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(559, 20);
            this.txtRua.TabIndex = 20;
            // 
            // lbRua
            // 
            this.lbRua.AutoSize = true;
            this.lbRua.Location = new System.Drawing.Point(42, 356);
            this.lbRua.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbRua.Name = "lbRua";
            this.lbRua.Size = new System.Drawing.Size(27, 13);
            this.lbRua.TabIndex = 19;
            this.lbRua.Text = "Rua";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(608, 371);
            this.txtNumero.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(104, 20);
            this.txtNumero.TabIndex = 22;
            // 
            // lbNumero
            // 
            this.lbNumero.AutoSize = true;
            this.lbNumero.Location = new System.Drawing.Point(605, 356);
            this.lbNumero.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNumero.Name = "lbNumero";
            this.lbNumero.Size = new System.Drawing.Size(44, 13);
            this.lbNumero.TabIndex = 21;
            this.lbNumero.Text = "Número";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(46, 414);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(667, 20);
            this.txtEmail.TabIndex = 24;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(43, 398);
            this.lbEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(32, 13);
            this.lbEmail.TabIndex = 23;
            this.lbEmail.Text = "Email";
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(46, 458);
            this.txtCelular.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCelular.MaxLength = 14;
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(329, 20);
            this.txtCelular.TabIndex = 26;
            this.txtCelular.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCelular_KeyPress);
            // 
            // lbCelular
            // 
            this.lbCelular.AutoSize = true;
            this.lbCelular.Location = new System.Drawing.Point(43, 441);
            this.lbCelular.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCelular.Name = "lbCelular";
            this.lbCelular.Size = new System.Drawing.Size(39, 13);
            this.lbCelular.TabIndex = 25;
            this.lbCelular.Text = "Celular";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(379, 458);
            this.txtTelefone.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTelefone.MaxLength = 14;
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(334, 20);
            this.txtTelefone.TabIndex = 28;
            this.txtTelefone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefone_KeyPress);
            // 
            // lbTelefone
            // 
            this.lbTelefone.AutoSize = true;
            this.lbTelefone.Location = new System.Drawing.Point(376, 443);
            this.lbTelefone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTelefone.Name = "lbTelefone";
            this.lbTelefone.Size = new System.Drawing.Size(49, 13);
            this.lbTelefone.TabIndex = 27;
            this.lbTelefone.Text = "Telefone";
            // 
            // txt_CadastroFornecedor
            // 
            this.txt_CadastroFornecedor.AutoSize = true;
            this.txt_CadastroFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CadastroFornecedor.Location = new System.Drawing.Point(41, 55);
            this.txt_CadastroFornecedor.Name = "txt_CadastroFornecedor";
            this.txt_CadastroFornecedor.Size = new System.Drawing.Size(143, 39);
            this.txt_CadastroFornecedor.TabIndex = 35;
            this.txt_CadastroFornecedor.Text = "Clientes";
            // 
            // btnInserir
            // 
            this.btnInserir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserir.Image = global::Autopecas.Properties.Resources.Novo;
            this.btnInserir.Location = new System.Drawing.Point(46, 501);
            this.btnInserir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(106, 44);
            this.btnInserir.TabIndex = 36;
            this.btnInserir.Text = "  Inserir";
            this.btnInserir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Image = global::Autopecas.Properties.Resources.Salvar;
            this.btnSalvar.Location = new System.Drawing.Point(383, 501);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(107, 44);
            this.btnSalvar.TabIndex = 39;
            this.btnSalvar.Text = " Cadastrar";
            this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.Image = global::Autopecas.Properties.Resources.Alterar;
            this.btnAlterar.Location = new System.Drawing.Point(270, 501);
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(106, 44);
            this.btnAlterar.TabIndex = 38;
            this.btnAlterar.Text = "  Alterar";
            this.btnAlterar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnLocalizar
            // 
            this.btnLocalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLocalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocalizar.Image = global::Autopecas.Properties.Resources.Localizar;
            this.btnLocalizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLocalizar.Location = new System.Drawing.Point(158, 501);
            this.btnLocalizar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLocalizar.Name = "btnLocalizar";
            this.btnLocalizar.Size = new System.Drawing.Size(106, 44);
            this.btnLocalizar.TabIndex = 37;
            this.btnLocalizar.Text = "Pesquisar ou Editar";
            this.btnLocalizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLocalizar.UseVisualStyleBackColor = true;
            this.btnLocalizar.Click += new System.EventHandler(this.btnLocalizar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = global::Autopecas.Properties.Resources.Cancelar;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(608, 501);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(106, 44);
            this.btnCancelar.TabIndex = 41;
            this.btnCancelar.Text = "  Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Image = global::Autopecas.Properties.Resources.Excluir;
            this.btnExcluir.Location = new System.Drawing.Point(496, 501);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(107, 44);
            this.btnExcluir.TabIndex = 40;
            this.btnExcluir.Text = "  Excluir";
            this.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 679);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnLocalizar);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.txt_CadastroFornecedor);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.lbTelefone);
            this.Controls.Add(this.txtCelular);
            this.Controls.Add(this.lbCelular);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.lbNumero);
            this.Controls.Add(this.txtRua);
            this.Controls.Add(this.lbRua);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.lbBairro);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.lbCidade);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.lbEstado);
            this.Controls.Add(this.txtCep);
            this.Controls.Add(this.lbCEP);
            this.Controls.Add(this.txtRGIE);
            this.Controls.Add(this.lbRGIE);
            this.Controls.Add(this.txtCPFCNPJ);
            this.Controls.Add(this.lbCPFCNPJ);
            this.Controls.Add(this.txtRSocial);
            this.Controls.Add(this.lbRSocial);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.rbTipo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Clientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.Clientes_Load);
            this.rbTipo.ResumeLayout(false);
            this.rbTipo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox rbTipo;
        private System.Windows.Forms.RadioButton rbJuridico;
        private System.Windows.Forms.RadioButton rbFisico;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label lbRSocial;
        private System.Windows.Forms.Label lbCPFCNPJ;
        private System.Windows.Forms.Label lbRGIE;
        private System.Windows.Forms.Label lbCEP;
        private System.Windows.Forms.Label lbEstado;
        private System.Windows.Forms.Label lbCidade;
        private System.Windows.Forms.Label lbBairro;
        private System.Windows.Forms.Label lbRua;
        private System.Windows.Forms.Label lbNumero;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbCelular;
        private System.Windows.Forms.Label lbTelefone;
        private System.Windows.Forms.Label txt_CadastroFornecedor;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnExcluir;
        public System.Windows.Forms.TextBox txtRSocial;
        public System.Windows.Forms.TextBox txtCPFCNPJ;
        public System.Windows.Forms.TextBox txtRGIE;
        public System.Windows.Forms.TextBox txtCep;
        public System.Windows.Forms.TextBox txtNome;
        public System.Windows.Forms.TextBox txtEstado;
        public System.Windows.Forms.TextBox txtCidade;
        public System.Windows.Forms.TextBox txtBairro;
        public System.Windows.Forms.TextBox txtRua;
        public System.Windows.Forms.TextBox txtNumero;
        public System.Windows.Forms.TextBox txtEmail;
        public System.Windows.Forms.TextBox txtCelular;
        public System.Windows.Forms.TextBox txtTelefone;
        public System.Windows.Forms.Button btnInserir;
        public System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnLocalizar;
    }
}