namespace Aula_01
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblLogin = new System.Windows.Forms.Label();
            this.txbLogin = new System.Windows.Forms.TextBox();
            this.txbSenha = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lnkEsqueciSenha = new System.Windows.Forms.LinkLabel();
            this.lnkNovoCadastro = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLogin.ForeColor = System.Drawing.Color.White;
            this.lblLogin.Location = new System.Drawing.Point(56, 266);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(48, 20);
            this.lblLogin.TabIndex = 0;
            this.lblLogin.Text = "Login";
            this.lblLogin.Click += new System.EventHandler(this.label1_Click);
            // 
            // txbLogin
            // 
            this.txbLogin.Location = new System.Drawing.Point(56, 298);
            this.txbLogin.Name = "txbLogin";
            this.txbLogin.Size = new System.Drawing.Size(349, 27);
            this.txbLogin.TabIndex = 1;
            // 
            // txbSenha
            // 
            this.txbSenha.Location = new System.Drawing.Point(57, 381);
            this.txbSenha.Name = "txbSenha";
            this.txbSenha.Size = new System.Drawing.Size(349, 27);
            this.txbSenha.TabIndex = 3;
            this.txbSenha.UseSystemPasswordChar = true;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSenha.ForeColor = System.Drawing.Color.White;
            this.lblSenha.Location = new System.Drawing.Point(57, 349);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(51, 20);
            this.lblSenha.TabIndex = 2;
            this.lblSenha.Text = "Senha";
            // 
            // btnEntrar
            // 
            this.btnEntrar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEntrar.Location = new System.Drawing.Point(56, 455);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(146, 29);
            this.btnEntrar.TabIndex = 4;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSair.Location = new System.Drawing.Point(260, 455);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(146, 29);
            this.btnSair.TabIndex = 5;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.button2_Click);
            this.btnSair.Leave += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(156, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(57, 543);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "Opa, sou novo aqui.";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // lnkEsqueciSenha
            // 
            this.lnkEsqueciSenha.ActiveLinkColor = System.Drawing.Color.LightSkyBlue;
            this.lnkEsqueciSenha.AutoSize = true;
            this.lnkEsqueciSenha.BackColor = System.Drawing.Color.Transparent;
            this.lnkEsqueciSenha.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lnkEsqueciSenha.LinkColor = System.Drawing.Color.Firebrick;
            this.lnkEsqueciSenha.Location = new System.Drawing.Point(56, 514);
            this.lnkEsqueciSenha.Name = "lnkEsqueciSenha";
            this.lnkEsqueciSenha.Size = new System.Drawing.Size(149, 19);
            this.lnkEsqueciSenha.TabIndex = 10;
            this.lnkEsqueciSenha.TabStop = true;
            this.lnkEsqueciSenha.Text = "Esqueci minha senha.";
            this.lnkEsqueciSenha.VisitedLinkColor = System.Drawing.Color.SkyBlue;
            // 
            // lnkNovoCadastro
            // 
            this.lnkNovoCadastro.AutoSize = true;
            this.lnkNovoCadastro.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lnkNovoCadastro.LinkColor = System.Drawing.Color.Firebrick;
            this.lnkNovoCadastro.Location = new System.Drawing.Point(197, 543);
            this.lnkNovoCadastro.Name = "lnkNovoCadastro";
            this.lnkNovoCadastro.Size = new System.Drawing.Size(167, 19);
            this.lnkNovoCadastro.TabIndex = 11;
            this.lnkNovoCadastro.TabStop = true;
            this.lnkNovoCadastro.Text = "Realizar novo cadastro.";
            this.lnkNovoCadastro.VisitedLinkColor = System.Drawing.Color.SkyBlue;
            this.lnkNovoCadastro.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(462, 618);
            this.Controls.Add(this.lnkNovoCadastro);
            this.Controls.Add(this.lnkEsqueciSenha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.txbSenha);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.txbLogin);
            this.Controls.Add(this.lblLogin);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblLogin;
        private TextBox txbLogin;
        private TextBox txbSenha;
        private Label lblSenha;
        private Button btnEntrar;
        private Button btnSair;
        private PictureBox pictureBox1;
        private Label label2;
        private LinkLabel lnkEsqueciSenha;
        private LinkLabel lnkNovoCadastro;
    }
}