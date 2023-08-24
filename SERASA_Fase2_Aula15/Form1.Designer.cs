namespace SERASA_Fase2_Aula15
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsuario1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSalvar1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtSenha1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(56, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite seu usuário:";
            // 
            // txtUsuario1
            // 
            this.txtUsuario1.Location = new System.Drawing.Point(56, 101);
            this.txtUsuario1.Name = "txtUsuario1";
            this.txtUsuario1.Size = new System.Drawing.Size(185, 23);
            this.txtUsuario1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(55, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Faça login para continuar";
            // 
            // btnSalvar1
            // 
            this.btnSalvar1.Location = new System.Drawing.Point(57, 215);
            this.btnSalvar1.Name = "btnSalvar1";
            this.btnSalvar1.Size = new System.Drawing.Size(184, 32);
            this.btnSalvar1.TabIndex = 5;
            this.btnSalvar1.Text = "Entrar";
            this.btnSalvar1.UseVisualStyleBackColor = true;
            this.btnSalvar1.Click += new System.EventHandler(this.btnSalvar1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(56, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Digite sua senha:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SERASA_Fase2_Aula15.Properties.Resources.usuario;
            this.pictureBox1.Location = new System.Drawing.Point(19, 101);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SERASA_Fase2_Aula15.Properties.Resources.senha;
            this.pictureBox2.Location = new System.Drawing.Point(19, 173);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 23);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // txtSenha1
            // 
            this.txtSenha1.Location = new System.Drawing.Point(57, 186);
            this.txtSenha1.Name = "txtSenha1";
            this.txtSenha1.Size = new System.Drawing.Size(182, 23);
            this.txtSenha1.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 275);
            this.Controls.Add(this.txtSenha1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSalvar1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUsuario1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtUsuario1;
        private Label label3;
        private Button btnSalvar1;
        private Label label2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private TextBox txtSenha1;
    }
}