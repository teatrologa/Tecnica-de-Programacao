namespace Aula_02
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.lblTituloMenu = new System.Windows.Forms.Label();
            this.pbxDiv = new System.Windows.Forms.PictureBox();
            this.pbxCalcSimples = new System.Windows.Forms.PictureBox();
            this.pbxCalcImc = new System.Windows.Forms.PictureBox();
            this.pbxSair = new System.Windows.Forms.PictureBox();
            this.btnCalcSimples = new System.Windows.Forms.Button();
            this.btnCalcImc = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDiv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCalcSimples)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCalcImc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSair)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTituloMenu
            // 
            this.lblTituloMenu.AutoSize = true;
            this.lblTituloMenu.BackColor = System.Drawing.Color.Transparent;
            this.lblTituloMenu.Font = new System.Drawing.Font("Cooper Black", 27F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTituloMenu.ForeColor = System.Drawing.Color.Maroon;
            this.lblTituloMenu.Location = new System.Drawing.Point(110, 50);
            this.lblTituloMenu.Name = "lblTituloMenu";
            this.lblTituloMenu.Size = new System.Drawing.Size(319, 102);
            this.lblTituloMenu.TabIndex = 0;
            this.lblTituloMenu.Text = "Menu de\r\nCalculadoras";
            this.lblTituloMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbxDiv
            // 
            this.pbxDiv.BackColor = System.Drawing.Color.RosyBrown;
            this.pbxDiv.Location = new System.Drawing.Point(60, 193);
            this.pbxDiv.Name = "pbxDiv";
            this.pbxDiv.Size = new System.Drawing.Size(419, 10);
            this.pbxDiv.TabIndex = 1;
            this.pbxDiv.TabStop = false;
            // 
            // pbxCalcSimples
            // 
            this.pbxCalcSimples.BackColor = System.Drawing.Color.Transparent;
            this.pbxCalcSimples.Image = ((System.Drawing.Image)(resources.GetObject("pbxCalcSimples.Image")));
            this.pbxCalcSimples.Location = new System.Drawing.Point(81, 251);
            this.pbxCalcSimples.Name = "pbxCalcSimples";
            this.pbxCalcSimples.Size = new System.Drawing.Size(50, 50);
            this.pbxCalcSimples.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxCalcSimples.TabIndex = 2;
            this.pbxCalcSimples.TabStop = false;
            // 
            // pbxCalcImc
            // 
            this.pbxCalcImc.BackColor = System.Drawing.Color.Transparent;
            this.pbxCalcImc.Image = ((System.Drawing.Image)(resources.GetObject("pbxCalcImc.Image")));
            this.pbxCalcImc.Location = new System.Drawing.Point(81, 326);
            this.pbxCalcImc.Name = "pbxCalcImc";
            this.pbxCalcImc.Size = new System.Drawing.Size(50, 50);
            this.pbxCalcImc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxCalcImc.TabIndex = 3;
            this.pbxCalcImc.TabStop = false;
            // 
            // pbxSair
            // 
            this.pbxSair.BackColor = System.Drawing.Color.Transparent;
            this.pbxSair.Image = ((System.Drawing.Image)(resources.GetObject("pbxSair.Image")));
            this.pbxSair.Location = new System.Drawing.Point(81, 400);
            this.pbxSair.Name = "pbxSair";
            this.pbxSair.Size = new System.Drawing.Size(50, 50);
            this.pbxSair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxSair.TabIndex = 4;
            this.pbxSair.TabStop = false;
            // 
            // btnCalcSimples
            // 
            this.btnCalcSimples.Font = new System.Drawing.Font("Cooper Black", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCalcSimples.ForeColor = System.Drawing.Color.IndianRed;
            this.btnCalcSimples.Location = new System.Drawing.Point(139, 251);
            this.btnCalcSimples.Name = "btnCalcSimples";
            this.btnCalcSimples.Size = new System.Drawing.Size(318, 50);
            this.btnCalcSimples.TabIndex = 5;
            this.btnCalcSimples.Text = "Calculadora Simples";
            this.btnCalcSimples.UseVisualStyleBackColor = true;
            this.btnCalcSimples.Click += new System.EventHandler(this.btnCalcSimples_Click);
            // 
            // btnCalcImc
            // 
            this.btnCalcImc.Font = new System.Drawing.Font("Cooper Black", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCalcImc.ForeColor = System.Drawing.Color.IndianRed;
            this.btnCalcImc.Location = new System.Drawing.Point(139, 326);
            this.btnCalcImc.Name = "btnCalcImc";
            this.btnCalcImc.Size = new System.Drawing.Size(318, 50);
            this.btnCalcImc.TabIndex = 6;
            this.btnCalcImc.Text = "Calculadora de IMC";
            this.btnCalcImc.UseVisualStyleBackColor = true;
            this.btnCalcImc.Click += new System.EventHandler(this.btnCalcImc_Click);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Cooper Black", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSair.ForeColor = System.Drawing.Color.DimGray;
            this.btnSair.Location = new System.Drawing.Point(139, 400);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(318, 50);
            this.btnSair.TabIndex = 7;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(538, 506);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnCalcImc);
            this.Controls.Add(this.btnCalcSimples);
            this.Controls.Add(this.pbxSair);
            this.Controls.Add(this.pbxCalcImc);
            this.Controls.Add(this.pbxCalcSimples);
            this.Controls.Add(this.pbxDiv);
            this.Controls.Add(this.lblTituloMenu);
            this.Name = "Menu";
            this.Text = "Menu  |  Calculadoras";
            ((System.ComponentModel.ISupportInitialize)(this.pbxDiv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCalcSimples)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCalcImc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSair)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblTituloMenu;
        private PictureBox pbxDiv;
        private PictureBox pbxCalcSimples;
        private PictureBox pbxCalcImc;
        private PictureBox pbxSair;
        private Button btnCalcSimples;
        private Button btnCalcImc;
        private Button btnSair;
    }
}