namespace ATA_Cisco_187
{
    partial class FrmCisco
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.macLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // macLabel
            // 
            this.macLabel.AutoSize = true;
            this.macLabel.Location = new System.Drawing.Point(43, 94);
            this.macLabel.Name = "macLabel";
            this.macLabel.Size = new System.Drawing.Size(35, 13);
            this.macLabel.TabIndex = 0;
            this.macLabel.Text = "label1";
            // 
            // FrmCisco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 450);
            this.Controls.Add(this.macLabel);
            this.Name = "FrmCisco";
            this.Text = "Cisco ATA 187";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label macLabel;
    }
}

