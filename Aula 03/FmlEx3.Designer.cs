namespace Aula_03
{
    partial class fmlEx3
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblLinha = new System.Windows.Forms.Label();
            this.tbxLinha = new System.Windows.Forms.TextBox();
            this.tbxColuna = new System.Windows.Forms.TextBox();
            this.lblColuna = new System.Windows.Forms.Label();
            this.btnCriar = new System.Windows.Forms.Button();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.gbxAreaPlot = new System.Windows.Forms.GroupBox();
            this.lboxMatriz = new System.Windows.Forms.ListBox();
            this.gbxAreaPlot.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Cooper Black", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblTitulo.Location = new System.Drawing.Point(26, 56);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(482, 45);
            this.lblTitulo.TabIndex = 4;
            this.lblTitulo.Text = "Criando uma matriz 2D";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLinha
            // 
            this.lblLinha.AutoSize = true;
            this.lblLinha.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLinha.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblLinha.Location = new System.Drawing.Point(57, 235);
            this.lblLinha.Name = "lblLinha";
            this.lblLinha.Size = new System.Drawing.Size(68, 28);
            this.lblLinha.TabIndex = 6;
            this.lblLinha.Text = "Linha:";
            // 
            // tbxLinha
            // 
            this.tbxLinha.Location = new System.Drawing.Point(131, 236);
            this.tbxLinha.Name = "tbxLinha";
            this.tbxLinha.Size = new System.Drawing.Size(116, 27);
            this.tbxLinha.TabIndex = 0;
            // 
            // tbxColuna
            // 
            this.tbxColuna.Location = new System.Drawing.Point(358, 236);
            this.tbxColuna.Name = "tbxColuna";
            this.tbxColuna.Size = new System.Drawing.Size(116, 27);
            this.tbxColuna.TabIndex = 1;
            // 
            // lblColuna
            // 
            this.lblColuna.AutoSize = true;
            this.lblColuna.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblColuna.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblColuna.Location = new System.Drawing.Point(270, 232);
            this.lblColuna.Name = "lblColuna";
            this.lblColuna.Size = new System.Drawing.Size(82, 28);
            this.lblColuna.TabIndex = 7;
            this.lblColuna.Text = "Coluna:";
            // 
            // btnCriar
            // 
            this.btnCriar.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCriar.ForeColor = System.Drawing.Color.SlateGray;
            this.btnCriar.Location = new System.Drawing.Point(57, 286);
            this.btnCriar.Name = "btnCriar";
            this.btnCriar.Size = new System.Drawing.Size(421, 51);
            this.btnCriar.TabIndex = 2;
            this.btnCriar.Text = "Criar";
            this.btnCriar.UseVisualStyleBackColor = true;
            this.btnCriar.Click += new System.EventHandler(this.btnCriar_Click);
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDescricao.Location = new System.Drawing.Point(51, 117);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(432, 84);
            this.lblDescricao.TabIndex = 5;
            this.lblDescricao.Text = "Para criar a matriz você deve inserir dois valores nos campos\r\nabaixo, um valor p" +
    "ara a quantidade de linhas e\r\noutro valor para quantidade de colunas desejas.\r\nA" +
    " matriz será criada automaticamente.";
            this.lblDescricao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbxAreaPlot
            // 
            this.gbxAreaPlot.BackColor = System.Drawing.Color.White;
            this.gbxAreaPlot.Controls.Add(this.lboxMatriz);
            this.gbxAreaPlot.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbxAreaPlot.ForeColor = System.Drawing.Color.SlateGray;
            this.gbxAreaPlot.Location = new System.Drawing.Point(57, 380);
            this.gbxAreaPlot.Name = "gbxAreaPlot";
            this.gbxAreaPlot.Size = new System.Drawing.Size(421, 247);
            this.gbxAreaPlot.TabIndex = 3;
            this.gbxAreaPlot.TabStop = false;
            this.gbxAreaPlot.Text = "Matriz 2D";
            // 
            // lboxMatriz
            // 
            this.lboxMatriz.BackColor = System.Drawing.Color.White;
            this.lboxMatriz.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lboxMatriz.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lboxMatriz.ForeColor = System.Drawing.Color.SteelBlue;
            this.lboxMatriz.FormattingEnabled = true;
            this.lboxMatriz.ItemHeight = 24;
            this.lboxMatriz.Location = new System.Drawing.Point(27, 42);
            this.lboxMatriz.MultiColumn = true;
            this.lboxMatriz.Name = "lboxMatriz";
            this.lboxMatriz.Size = new System.Drawing.Size(367, 168);
            this.lboxMatriz.TabIndex = 0;
            // 
            // fmlEx3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(534, 685);
            this.Controls.Add(this.gbxAreaPlot);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.btnCriar);
            this.Controls.Add(this.tbxColuna);
            this.Controls.Add(this.lblColuna);
            this.Controls.Add(this.tbxLinha);
            this.Controls.Add(this.lblLinha);
            this.Controls.Add(this.lblTitulo);
            this.Name = "fmlEx3";
            this.Text = "Criando uma Matriz";
            this.Load += new System.EventHandler(this.fmlEx3_Load);
            this.gbxAreaPlot.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblTitulo;
        private Label lblLinha;
        private TextBox tbxLinha;
        private TextBox tbxColuna;
        private Label lblColuna;
        private Button btnCriar;
        private Label lblDescricao;
        private GroupBox gbxAreaPlot;
        private ListBox lboxMatriz;
    }
}