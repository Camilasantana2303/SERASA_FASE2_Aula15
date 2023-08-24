namespace SERASA_Fase2_Aula15
{
    partial class Form2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtNascimento2 = new System.Windows.Forms.TextBox();
            this.txtNome2 = new System.Windows.Forms.TextBox();
            this.txtSenha2 = new System.Windows.Forms.TextBox();
            this.txtUsuario2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnProcurar2 = new System.Windows.Forms.Button();
            this.txtBuscar2 = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSalvar);
            this.groupBox1.Controls.Add(this.txtNascimento2);
            this.groupBox1.Controls.Add(this.txtNome2);
            this.groupBox1.Controls.Add(this.txtSenha2);
            this.groupBox1.Controls.Add(this.txtUsuario2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(29, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(235, 323);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastro";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(50, 297);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(123, 22);
            this.btnSalvar.TabIndex = 8;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtNascimento2
            // 
            this.txtNascimento2.Location = new System.Drawing.Point(23, 264);
            this.txtNascimento2.Name = "txtNascimento2";
            this.txtNascimento2.Size = new System.Drawing.Size(185, 25);
            this.txtNascimento2.TabIndex = 7;
            // 
            // txtNome2
            // 
            this.txtNome2.Location = new System.Drawing.Point(23, 198);
            this.txtNome2.Name = "txtNome2";
            this.txtNome2.Size = new System.Drawing.Size(185, 25);
            this.txtNome2.TabIndex = 6;
            // 
            // txtSenha2
            // 
            this.txtSenha2.Location = new System.Drawing.Point(23, 135);
            this.txtSenha2.Name = "txtSenha2";
            this.txtSenha2.Size = new System.Drawing.Size(185, 25);
            this.txtSenha2.TabIndex = 5;
            // 
            // txtUsuario2
            // 
            this.txtUsuario2.Location = new System.Drawing.Point(21, 74);
            this.txtUsuario2.Name = "txtUsuario2";
            this.txtUsuario2.Size = new System.Drawing.Size(187, 25);
            this.txtUsuario2.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ano de nascimento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nome completo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Digite sua senha:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite seu usuário:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnProcurar2);
            this.groupBox2.Controls.Add(this.txtBuscar2);
            this.groupBox2.Controls.Add(this.listView1);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(372, 37);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(258, 323);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Busca de clientes";
            // 
            // btnProcurar2
            // 
            this.btnProcurar2.Location = new System.Drawing.Point(75, 106);
            this.btnProcurar2.Name = "btnProcurar2";
            this.btnProcurar2.Size = new System.Drawing.Size(112, 30);
            this.btnProcurar2.TabIndex = 11;
            this.btnProcurar2.Text = "Procurar";
            this.btnProcurar2.UseVisualStyleBackColor = true;
            // 
            // txtBuscar2
            // 
            this.txtBuscar2.Location = new System.Drawing.Point(23, 74);
            this.txtBuscar2.Name = "txtBuscar2";
            this.txtBuscar2.Size = new System.Drawing.Size(184, 25);
            this.txtBuscar2.TabIndex = 8;
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(23, 185);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(200, 124);
            this.listView1.TabIndex = 10;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 19);
            this.label6.TabIndex = 9;
            this.label6.Text = "Clientes cadastrados:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "Buscar cliente pelo nome:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 409);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtNascimento2;
        private TextBox txtNome2;
        private TextBox txtSenha2;
        private TextBox txtUsuario2;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private Button btnProcurar2;
        private TextBox txtBuscar2;
        private ListView listView1;
        private Label label6;
        private Label label5;
        private Button btnSalvar;
    }
}