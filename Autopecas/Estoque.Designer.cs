namespace Autopecas
{
    partial class Estoque
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
            this.labelEstoque = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelEstoque
            // 
            this.labelEstoque.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.labelEstoque.Font = new System.Drawing.Font("Times New Roman", 72F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEstoque.ForeColor = System.Drawing.Color.White;
            this.labelEstoque.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelEstoque.Location = new System.Drawing.Point(12, 9);
            this.labelEstoque.Name = "labelEstoque";
            this.labelEstoque.Size = new System.Drawing.Size(660, 151);
            this.labelEstoque.TabIndex = 0;
            this.labelEstoque.Text = "ESTOQUE";
            this.labelEstoque.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Estoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(684, 431);
            this.Controls.Add(this.labelEstoque);
            this.Name = "Estoque";
            this.Text = "Estoque";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelEstoque;
    }
}