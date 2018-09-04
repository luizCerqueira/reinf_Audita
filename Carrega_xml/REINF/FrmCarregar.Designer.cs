namespace REINF
{
    partial class FrmCarregar
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
            this.txtCaminho = new System.Windows.Forms.TextBox();
            this.btnVerifica = new System.Windows.Forms.Button();
            this.lblCarregarXmls = new System.Windows.Forms.RichTextBox();
            this.lblCaminho = new System.Windows.Forms.Label();
            this.Progresso = new System.Windows.Forms.ProgressBar();
            this.btnCarregar = new System.Windows.Forms.Button();
            this.btnProcura = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCaminho
            // 
            this.txtCaminho.Location = new System.Drawing.Point(53, 39);
            this.txtCaminho.Name = "txtCaminho";
            this.txtCaminho.Size = new System.Drawing.Size(394, 20);
            this.txtCaminho.TabIndex = 0;
            // 
            // btnVerifica
            // 
            this.btnVerifica.Location = new System.Drawing.Point(317, 65);
            this.btnVerifica.Name = "btnVerifica";
            this.btnVerifica.Size = new System.Drawing.Size(62, 23);
            this.btnVerifica.TabIndex = 1;
            this.btnVerifica.Text = "Verificar";
            this.btnVerifica.UseVisualStyleBackColor = true;
            this.btnVerifica.Click += new System.EventHandler(this.btnVerifica_Click);
            // 
            // lblCarregarXmls
            // 
            this.lblCarregarXmls.Location = new System.Drawing.Point(53, 98);
            this.lblCarregarXmls.Name = "lblCarregarXmls";
            this.lblCarregarXmls.Size = new System.Drawing.Size(394, 161);
            this.lblCarregarXmls.TabIndex = 3;
            this.lblCarregarXmls.Text = "";
            // 
            // lblCaminho
            // 
            this.lblCaminho.AutoSize = true;
            this.lblCaminho.Location = new System.Drawing.Point(50, 23);
            this.lblCaminho.Name = "lblCaminho";
            this.lblCaminho.Size = new System.Drawing.Size(51, 13);
            this.lblCaminho.TabIndex = 4;
            this.lblCaminho.Text = "Caminho:";
            // 
            // Progresso
            // 
            this.Progresso.Location = new System.Drawing.Point(-1, 303);
            this.Progresso.Name = "Progresso";
            this.Progresso.Size = new System.Drawing.Size(516, 12);
            this.Progresso.TabIndex = 5;
            this.Progresso.Visible = false;
            // 
            // btnCarregar
            // 
            this.btnCarregar.Location = new System.Drawing.Point(372, 265);
            this.btnCarregar.Name = "btnCarregar";
            this.btnCarregar.Size = new System.Drawing.Size(75, 23);
            this.btnCarregar.TabIndex = 6;
            this.btnCarregar.Text = "Carregar";
            this.btnCarregar.UseVisualStyleBackColor = true;
            this.btnCarregar.Click += new System.EventHandler(this.btnCarregar_Click);
            // 
            // btnProcura
            // 
            this.btnProcura.Location = new System.Drawing.Point(385, 65);
            this.btnProcura.Name = "btnProcura";
            this.btnProcura.Size = new System.Drawing.Size(62, 23);
            this.btnProcura.TabIndex = 7;
            this.btnProcura.Text = "Procurar";
            this.btnProcura.UseVisualStyleBackColor = true;
            this.btnProcura.Click += new System.EventHandler(this.btnProcura_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(53, 65);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(48, 23);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // FrmCarregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(515, 313);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnProcura);
            this.Controls.Add(this.btnCarregar);
            this.Controls.Add(this.Progresso);
            this.Controls.Add(this.lblCaminho);
            this.Controls.Add(this.lblCarregarXmls);
            this.Controls.Add(this.btnVerifica);
            this.Controls.Add(this.txtCaminho);
            this.Name = "FrmCarregar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Carregar XML";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCaminho;
        private System.Windows.Forms.Button btnVerifica;
        private System.Windows.Forms.RichTextBox lblCarregarXmls;
        private System.Windows.Forms.Label lblCaminho;
        private System.Windows.Forms.ProgressBar Progresso;
        private System.Windows.Forms.Button btnCarregar;
        private System.Windows.Forms.Button btnProcura;
        private System.Windows.Forms.Button btnClear;
    }
}