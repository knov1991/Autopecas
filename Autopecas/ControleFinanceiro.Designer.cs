﻿namespace Autopecas
{
    partial class ControleFinanceiro
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
            this.SuspendLayout();
            // 
            // txt_NovaVenda
            // 
            this.txt_NovaVenda.AutoSize = true;
            this.txt_NovaVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NovaVenda.Location = new System.Drawing.Point(41, 55);
            this.txt_NovaVenda.Name = "txt_NovaVenda";
            this.txt_NovaVenda.Size = new System.Drawing.Size(179, 39);
            this.txt_NovaVenda.TabIndex = 2;
            this.txt_NovaVenda.Text = "Financeiro";
            // 
            // ControleFinanceiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 718);
            this.Controls.Add(this.txt_NovaVenda);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ControleFinanceiro";
            this.Text = "Financeiro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txt_NovaVenda;
    }
}