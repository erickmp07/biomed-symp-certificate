
namespace BiomedSympCertificate.Presentation
{
    partial class PrincipalForm
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
            this.btnCadeLista = new System.Windows.Forms.Button();
            this.lblQtdMinima = new System.Windows.Forms.Label();
            this.nudQuantidadeMinimaPalestras = new System.Windows.Forms.NumericUpDown();
            this.tlpBackground = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantidadeMinimaPalestras)).BeginInit();
            this.tlpBackground.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCadeLista
            // 
            this.btnCadeLista.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCadeLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadeLista.Location = new System.Drawing.Point(123, 129);
            this.btnCadeLista.Margin = new System.Windows.Forms.Padding(3, 30, 30, 30);
            this.btnCadeLista.Name = "btnCadeLista";
            this.btnCadeLista.Size = new System.Drawing.Size(375, 225);
            this.btnCadeLista.TabIndex = 2;
            this.btnCadeLista.Text = "Cadê a lista de presença?";
            this.btnCadeLista.UseVisualStyleBackColor = true;
            // 
            // lblQtdMinima
            // 
            this.lblQtdMinima.AutoSize = true;
            this.lblQtdMinima.Location = new System.Drawing.Point(123, 60);
            this.lblQtdMinima.Name = "lblQtdMinima";
            this.lblQtdMinima.Size = new System.Drawing.Size(162, 13);
            this.lblQtdMinima.TabIndex = 0;
            this.lblQtdMinima.Text = "Quantidade mínima de palestras:";
            // 
            // nudQuantidadeMinimaPalestras
            // 
            this.nudQuantidadeMinimaPalestras.Location = new System.Drawing.Point(123, 76);
            this.nudQuantidadeMinimaPalestras.Name = "nudQuantidadeMinimaPalestras";
            this.nudQuantidadeMinimaPalestras.Size = new System.Drawing.Size(173, 20);
            this.nudQuantidadeMinimaPalestras.TabIndex = 1;
            // 
            // tlpBackground
            // 
            this.tlpBackground.ColumnCount = 3;
            this.tlpBackground.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tlpBackground.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBackground.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tlpBackground.Controls.Add(this.lblQtdMinima, 1, 1);
            this.tlpBackground.Controls.Add(this.nudQuantidadeMinimaPalestras, 1, 2);
            this.tlpBackground.Controls.Add(this.btnCadeLista, 1, 3);
            this.tlpBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpBackground.Location = new System.Drawing.Point(0, 0);
            this.tlpBackground.Name = "tlpBackground";
            this.tlpBackground.RowCount = 5;
            this.tlpBackground.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlpBackground.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpBackground.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpBackground.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBackground.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlpBackground.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpBackground.Size = new System.Drawing.Size(648, 444);
            this.tlpBackground.TabIndex = 3;
            // 
            // PrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 444);
            this.Controls.Add(this.tlpBackground);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "PrincipalForm";
            this.Text = "Gerador de certificado - Simpósio de Biomedicina";
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantidadeMinimaPalestras)).EndInit();
            this.tlpBackground.ResumeLayout(false);
            this.tlpBackground.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCadeLista;
        private System.Windows.Forms.Label lblQtdMinima;
        private System.Windows.Forms.NumericUpDown nudQuantidadeMinimaPalestras;
        private System.Windows.Forms.TableLayoutPanel tlpBackground;
    }
}

