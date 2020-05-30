namespace Autopecas
{
    partial class FornecedorCadastrar
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
            this.lbId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lbNome = new System.Windows.Forms.Label();
            this.txtRSocial = new System.Windows.Forms.TextBox();
            this.lbRSocial = new System.Windows.Forms.Label();
            this.txtCnpj = new System.Windows.Forms.TextBox();
            this.lbCnpj = new System.Windows.Forms.Label();
            this.txtIe = new System.Windows.Forms.TextBox();
            this.lbIe = new System.Windows.Forms.Label();
            this.txtCep = new System.Windows.Forms.TextBox();
            this.lbCep = new System.Windows.Forms.Label();
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
            this.lbCelular = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.lbTelefone = new System.Windows.Forms.Label();
            this.btnLocalizar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.txt_CadastroFornecedor = new System.Windows.Forms.Label();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Location = new System.Drawing.Point(45, 113);
            this.lbId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(18, 13);
            this.lbId.TabIndex = 0;
            this.lbId.Text = "ID";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(48, 129);
            this.txtId.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(83, 20);
            this.txtId.TabIndex = 1;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(48, 171);
            this.txtNome.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(667, 20);
            this.txtNome.TabIndex = 2;
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(45, 154);
            this.lbNome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(35, 13);
            this.lbNome.TabIndex = 2;
            this.lbNome.Text = "Nome";
            // 
            // txtRSocial
            // 
            this.txtRSocial.Location = new System.Drawing.Point(48, 218);
            this.txtRSocial.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtRSocial.Name = "txtRSocial";
            this.txtRSocial.Size = new System.Drawing.Size(667, 20);
            this.txtRSocial.TabIndex = 3;
            // 
            // lbRSocial
            // 
            this.lbRSocial.AutoSize = true;
            this.lbRSocial.Location = new System.Drawing.Point(45, 201);
            this.lbRSocial.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbRSocial.Name = "lbRSocial";
            this.lbRSocial.Size = new System.Drawing.Size(70, 13);
            this.lbRSocial.TabIndex = 4;
            this.lbRSocial.Text = "Razão Social";
            // 
            // txtCnpj
            // 
            this.txtCnpj.Location = new System.Drawing.Point(48, 261);
            this.txtCnpj.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCnpj.MaxLength = 18;
            this.txtCnpj.Name = "txtCnpj";
            this.txtCnpj.Size = new System.Drawing.Size(329, 20);
            this.txtCnpj.TabIndex = 4;
            this.txtCnpj.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCnpj_KeyPress);
            // 
            // lbCnpj
            // 
            this.lbCnpj.AutoSize = true;
            this.lbCnpj.Location = new System.Drawing.Point(45, 245);
            this.lbCnpj.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCnpj.Name = "lbCnpj";
            this.lbCnpj.Size = new System.Drawing.Size(34, 13);
            this.lbCnpj.TabIndex = 6;
            this.lbCnpj.Text = "CNPJ";
            // 
            // txtIe
            // 
            this.txtIe.Location = new System.Drawing.Point(381, 261);
            this.txtIe.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtIe.MaxLength = 11;
            this.txtIe.Name = "txtIe";
            this.txtIe.Size = new System.Drawing.Size(331, 20);
            this.txtIe.TabIndex = 5;
            this.txtIe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIe_KeyPress);
            // 
            // lbIe
            // 
            this.lbIe.AutoSize = true;
            this.lbIe.Location = new System.Drawing.Point(378, 246);
            this.lbIe.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbIe.Name = "lbIe";
            this.lbIe.Size = new System.Drawing.Size(17, 13);
            this.lbIe.TabIndex = 8;
            this.lbIe.Text = "IE";
            // 
            // txtCep
            // 
            this.txtCep.Location = new System.Drawing.Point(48, 308);
            this.txtCep.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCep.MaxLength = 9;
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(159, 20);
            this.txtCep.TabIndex = 6;
            this.txtCep.TextChanged += new System.EventHandler(this.txtCep_TextChanged);
            this.txtCep.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCep_KeyPress);
            // 
            // lbCep
            // 
            this.lbCep.AutoSize = true;
            this.lbCep.Location = new System.Drawing.Point(45, 292);
            this.lbCep.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCep.Name = "lbCep";
            this.lbCep.Size = new System.Drawing.Size(28, 13);
            this.lbCep.TabIndex = 10;
            this.lbCep.Text = "CEP";
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(211, 308);
            this.txtEstado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(37, 20);
            this.txtEstado.TabIndex = 7;
            // 
            // lbEstado
            // 
            this.lbEstado.AutoSize = true;
            this.lbEstado.Location = new System.Drawing.Point(208, 293);
            this.lbEstado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbEstado.Name = "lbEstado";
            this.lbEstado.Size = new System.Drawing.Size(21, 13);
            this.lbEstado.TabIndex = 12;
            this.lbEstado.Text = "UF";
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(252, 308);
            this.txtCidade.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(175, 20);
            this.txtCidade.TabIndex = 8;
            // 
            // lbCidade
            // 
            this.lbCidade.AutoSize = true;
            this.lbCidade.Location = new System.Drawing.Point(249, 293);
            this.lbCidade.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCidade.Name = "lbCidade";
            this.lbCidade.Size = new System.Drawing.Size(40, 13);
            this.lbCidade.TabIndex = 14;
            this.lbCidade.Text = "Cidade";
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(431, 308);
            this.txtBairro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(284, 20);
            this.txtBairro.TabIndex = 9;
            // 
            // lbBairro
            // 
            this.lbBairro.AutoSize = true;
            this.lbBairro.Location = new System.Drawing.Point(428, 292);
            this.lbBairro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbBairro.Name = "lbBairro";
            this.lbBairro.Size = new System.Drawing.Size(34, 13);
            this.lbBairro.TabIndex = 16;
            this.lbBairro.Text = "Bairro";
            // 
            // txtRua
            // 
            this.txtRua.Location = new System.Drawing.Point(47, 350);
            this.txtRua.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(559, 20);
            this.txtRua.TabIndex = 10;
            // 
            // lbRua
            // 
            this.lbRua.AutoSize = true;
            this.lbRua.Location = new System.Drawing.Point(44, 335);
            this.lbRua.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbRua.Name = "lbRua";
            this.lbRua.Size = new System.Drawing.Size(27, 13);
            this.lbRua.TabIndex = 18;
            this.lbRua.Text = "Rua";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(610, 350);
            this.txtNumero.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNumero.MaxLength = 5;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(104, 20);
            this.txtNumero.TabIndex = 11;
            // 
            // lbNumero
            // 
            this.lbNumero.AutoSize = true;
            this.lbNumero.Location = new System.Drawing.Point(607, 335);
            this.lbNumero.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNumero.Name = "lbNumero";
            this.lbNumero.Size = new System.Drawing.Size(44, 13);
            this.lbNumero.TabIndex = 20;
            this.lbNumero.Text = "Número";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(48, 393);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(667, 20);
            this.txtEmail.TabIndex = 12;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(45, 377);
            this.lbEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(32, 13);
            this.lbEmail.TabIndex = 22;
            this.lbEmail.Text = "Email";
            // 
            // lbCelular
            // 
            this.lbCelular.AutoSize = true;
            this.lbCelular.Location = new System.Drawing.Point(45, 420);
            this.lbCelular.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCelular.Name = "lbCelular";
            this.lbCelular.Size = new System.Drawing.Size(39, 13);
            this.lbCelular.TabIndex = 24;
            this.lbCelular.Text = "Celular";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(381, 437);
            this.txtTelefone.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTelefone.MaxLength = 14;
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(334, 20);
            this.txtTelefone.TabIndex = 14;
            this.txtTelefone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefone_KeyPress);
            // 
            // lbTelefone
            // 
            this.lbTelefone.AutoSize = true;
            this.lbTelefone.Location = new System.Drawing.Point(378, 422);
            this.lbTelefone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTelefone.Name = "lbTelefone";
            this.lbTelefone.Size = new System.Drawing.Size(49, 13);
            this.lbTelefone.TabIndex = 26;
            this.lbTelefone.Text = "Telefone";
            // 
            // btnLocalizar
            // 
            this.btnLocalizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLocalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocalizar.Image = global::Autopecas.Properties.Resources.Localizar;
            this.btnLocalizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLocalizar.Location = new System.Drawing.Point(160, 480);
            this.btnLocalizar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLocalizar.Name = "btnLocalizar";
            this.btnLocalizar.Size = new System.Drawing.Size(106, 44);
            this.btnLocalizar.TabIndex = 16;
            this.btnLocalizar.Text = "  Localizar";
            this.btnLocalizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLocalizar.UseVisualStyleBackColor = true;
            this.btnLocalizar.Click += new System.EventHandler(this.btnLocalizar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.Image = global::Autopecas.Properties.Resources.Alterar;
            this.btnAlterar.Location = new System.Drawing.Point(272, 480);
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(106, 44);
            this.btnAlterar.TabIndex = 17;
            this.btnAlterar.Text = "  Alterar";
            this.btnAlterar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Image = global::Autopecas.Properties.Resources.Excluir;
            this.btnExcluir.Location = new System.Drawing.Point(498, 480);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(107, 44);
            this.btnExcluir.TabIndex = 19;
            this.btnExcluir.Text = "  Excluir";
            this.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Image = global::Autopecas.Properties.Resources.Salvar;
            this.btnSalvar.Location = new System.Drawing.Point(385, 480);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(107, 44);
            this.btnSalvar.TabIndex = 18;
            this.btnSalvar.Text = "  Salvar";
            this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = global::Autopecas.Properties.Resources.Cancelar;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(610, 480);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(106, 44);
            this.btnCancelar.TabIndex = 20;
            this.btnCancelar.Text = "  Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserir.Image = global::Autopecas.Properties.Resources.Novo;
            this.btnInserir.Location = new System.Drawing.Point(48, 480);
            this.btnInserir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(106, 44);
            this.btnInserir.TabIndex = 15;
            this.btnInserir.Text = "  Inserir";
            this.btnInserir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // txt_CadastroFornecedor
            // 
            this.txt_CadastroFornecedor.AutoSize = true;
            this.txt_CadastroFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CadastroFornecedor.Location = new System.Drawing.Point(41, 55);
            this.txt_CadastroFornecedor.Name = "txt_CadastroFornecedor";
            this.txt_CadastroFornecedor.Size = new System.Drawing.Size(231, 39);
            this.txt_CadastroFornecedor.TabIndex = 34;
            this.txt_CadastroFornecedor.Text = "Fornecedores";
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(48, 437);
            this.txtCelular.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCelular.MaxLength = 14;
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(329, 20);
            this.txtCelular.TabIndex = 13;
            this.txtCelular.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCelular_KeyPress);
            // 
            // FornecedorCadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 718);
            this.Controls.Add(this.txtCelular);
            this.Controls.Add(this.txt_CadastroFornecedor);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnLocalizar);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.lbTelefone);
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
            this.Controls.Add(this.lbCep);
            this.Controls.Add(this.txtIe);
            this.Controls.Add(this.lbIe);
            this.Controls.Add(this.txtCnpj);
            this.Controls.Add(this.lbCnpj);
            this.Controls.Add(this.txtRSocial);
            this.Controls.Add(this.lbRSocial);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lbId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FornecedorCadastrar";
            this.Text = "FornecedorCadastrar";
            this.Load += new System.EventHandler(this.FornecedorCadastrar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.TextBox txtRSocial;
        private System.Windows.Forms.Label lbRSocial;
        private System.Windows.Forms.TextBox txtCnpj;
        private System.Windows.Forms.Label lbCnpj;
        private System.Windows.Forms.TextBox txtIe;
        private System.Windows.Forms.Label lbIe;
        private System.Windows.Forms.TextBox txtCep;
        private System.Windows.Forms.Label lbCep;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label lbEstado;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label lbCidade;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label lbBairro;
        private System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.Label lbRua;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lbNumero;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbCelular;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.Label lbTelefone;
        private System.Windows.Forms.Button btnLocalizar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Label txt_CadastroFornecedor;
        private System.Windows.Forms.TextBox txtCelular;
    }
}