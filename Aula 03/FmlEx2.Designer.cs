namespace Aula_03
{
    partial class fmlEx2
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
            this.lbxPontuacao = new System.Windows.Forms.ListBox();
            this.lbxPodio = new System.Windows.Forms.ListBox();
            this.lblPontuacao = new System.Windows.Forms.Label();
            this.lblPodio = new System.Windows.Forms.Label();
            this.btnGo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbxPontuacao
            // 
            this.lbxPontuacao.FormattingEnabled = true;
            this.lbxPontuacao.ItemHeight = 20;
            this.lbxPontuacao.Location = new System.Drawing.Point(67, 178);
            this.lbxPontuacao.Name = "lbxPontuacao";
            this.lbxPontuacao.Size = new System.Drawing.Size(130, 104);
            this.lbxPontuacao.TabIndex = 0;
            // 
            // lbxPodio
            // 
            this.lbxPodio.FormattingEnabled = true;
            this.lbxPodio.ItemHeight = 20;
            this.lbxPodio.Location = new System.Drawing.Point(293, 178);
            this.lbxPodio.Name = "lbxPodio";
            this.lbxPodio.Size = new System.Drawing.Size(148, 104);
            this.lbxPodio.TabIndex = 1;
            // 
            // lblPontuacao
            // 
            this.lblPontuacao.AutoSize = true;
            this.lblPontuacao.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPontuacao.Location = new System.Drawing.Point(67, 152);
            this.lblPontuacao.Name = "lblPontuacao";
            this.lblPontuacao.Size = new System.Drawing.Size(130, 23);
            this.lblPontuacao.TabIndex = 2;
            this.lblPontuacao.Text = "-- Pontuação --";
            this.lblPontuacao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPodio
            // 
            this.lblPodio.AutoSize = true;
            this.lblPodio.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPodio.Location = new System.Drawing.Point(293, 152);
            this.lblPodio.Name = "lblPodio";
            this.lblPodio.Size = new System.Drawing.Size(148, 23);
            this.lblPodio.TabIndex = 3;
            this.lblPodio.Text = "-- Classificação --";
            this.lblPodio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(155, 48);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(197, 51);
            this.btnGo.TabIndex = 4;
            this.btnGo.Text = "Ver notas e classificação";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // fmlEx2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 447);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.lblPodio);
            this.Controls.Add(this.lblPontuacao);
            this.Controls.Add(this.lbxPodio);
            this.Controls.Add(this.lbxPontuacao);
            this.Name = "fmlEx2";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.fmlEx2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox lbxPontuacao;
        private ListBox lbxPodio;
        private Label lblPontuacao;
        private Label lblPodio;
        private Button btnGo;
    }
}