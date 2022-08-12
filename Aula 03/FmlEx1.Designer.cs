namespace Aula_03
{
    partial class fmlEx1
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
            this.tbxInsert = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.lblContador = new System.Windows.Forms.Label();
            this.lbxNumber = new System.Windows.Forms.ListBox();
            this.lbxNumPar = new System.Windows.Forms.ListBox();
            this.lbxNumImp = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(102, 65);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(382, 28);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Insira 10 valores inteiro maiores que 0.";
            // 
            // tbxInsert
            // 
            this.tbxInsert.Location = new System.Drawing.Point(98, 146);
            this.tbxInsert.Name = "tbxInsert";
            this.tbxInsert.Size = new System.Drawing.Size(337, 27);
            this.tbxInsert.TabIndex = 1;
            this.tbxInsert.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(441, 141);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(94, 37);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "Enviar";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // lblContador
            // 
            this.lblContador.AutoSize = true;
            this.lblContador.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblContador.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblContador.Location = new System.Drawing.Point(56, 149);
            this.lblContador.Name = "lblContador";
            this.lblContador.Size = new System.Drawing.Size(27, 20);
            this.lblContador.TabIndex = 3;
            this.lblContador.Text = "10";
            // 
            // lbxNumber
            // 
            this.lbxNumber.FormattingEnabled = true;
            this.lbxNumber.ItemHeight = 20;
            this.lbxNumber.Location = new System.Drawing.Point(38, 215);
            this.lbxNumber.Name = "lbxNumber";
            this.lbxNumber.Size = new System.Drawing.Size(150, 164);
            this.lbxNumber.TabIndex = 4;
            // 
            // lbxNumPar
            // 
            this.lbxNumPar.FormattingEnabled = true;
            this.lbxNumPar.ItemHeight = 20;
            this.lbxNumPar.Location = new System.Drawing.Point(218, 215);
            this.lbxNumPar.Name = "lbxNumPar";
            this.lbxNumPar.Size = new System.Drawing.Size(150, 164);
            this.lbxNumPar.TabIndex = 5;
            // 
            // lbxNumImp
            // 
            this.lbxNumImp.FormattingEnabled = true;
            this.lbxNumImp.ItemHeight = 20;
            this.lbxNumImp.Location = new System.Drawing.Point(398, 215);
            this.lbxNumImp.Name = "lbxNumImp";
            this.lbxNumImp.Size = new System.Drawing.Size(150, 164);
            this.lbxNumImp.TabIndex = 6;
            // 
            // fmlEx1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 450);
            this.Controls.Add(this.lbxNumImp);
            this.Controls.Add(this.lbxNumPar);
            this.Controls.Add(this.lbxNumber);
            this.Controls.Add(this.lblContador);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.tbxInsert);
            this.Controls.Add(this.lblTitulo);
            this.Name = "fmlEx1";
            this.Text = "Exercicio 1";
            this.Load += new System.EventHandler(this.fmlEx1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblTitulo;
        private TextBox tbxInsert;
        private Button btnSend;
        private Label lblContador;
        private ListBox lbxNumber;
        private ListBox lbxNumPar;
        private ListBox lbxNumImp;
    }
}