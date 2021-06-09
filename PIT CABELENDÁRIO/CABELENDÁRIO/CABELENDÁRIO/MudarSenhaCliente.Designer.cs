
namespace CABELENDÁRIO
{
    partial class MudarSenhaCliente
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
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblNomeUser = new System.Windows.Forms.Label();
            this.btnPesquisarBarbearia = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label2.Location = new System.Drawing.Point(236, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 29);
            this.label2.TabIndex = 16;
            this.label2.Text = "Digite sua antiga senha:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(281, 187);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 20);
            this.textBox1.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label1.Location = new System.Drawing.Point(236, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 29);
            this.label1.TabIndex = 18;
            this.label1.Text = "Digite sua nova senha:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(281, 242);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(150, 20);
            this.textBox2.TabIndex = 19;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CABELENDÁRIO.Properties.Resources.usuario;
            this.pictureBox1.Location = new System.Drawing.Point(193, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(103, 115);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 43;
            this.pictureBox1.TabStop = false;
            // 
            // lblNomeUser
            // 
            this.lblNomeUser.AutoSize = true;
            this.lblNomeUser.BackColor = System.Drawing.Color.White;
            this.lblNomeUser.Font = new System.Drawing.Font("Bahnschrift Condensed", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeUser.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.lblNomeUser.Location = new System.Drawing.Point(302, 59);
            this.lblNomeUser.Name = "lblNomeUser";
            this.lblNomeUser.Size = new System.Drawing.Size(140, 35);
            this.lblNomeUser.TabIndex = 44;
            this.lblNomeUser.Text = "NomeUsuario";
            // 
            // btnPesquisarBarbearia
            // 
            this.btnPesquisarBarbearia.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnPesquisarBarbearia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisarBarbearia.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisarBarbearia.ForeColor = System.Drawing.Color.White;
            this.btnPesquisarBarbearia.Location = new System.Drawing.Point(267, 268);
            this.btnPesquisarBarbearia.Name = "btnPesquisarBarbearia";
            this.btnPesquisarBarbearia.Size = new System.Drawing.Size(175, 39);
            this.btnPesquisarBarbearia.TabIndex = 45;
            this.btnPesquisarBarbearia.Text = "Mudar Senha";
            this.btnPesquisarBarbearia.UseVisualStyleBackColor = false;
            this.btnPesquisarBarbearia.Click += new System.EventHandler(this.btnPesquisarBarbearia_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.ForeColor = System.Drawing.Color.White;
            this.btnCadastrar.Location = new System.Drawing.Point(295, 313);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(120, 34);
            this.btnCadastrar.TabIndex = 46;
            this.btnCadastrar.Text = "Voltar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // MudarSenhaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(687, 382);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.btnPesquisarBarbearia);
            this.Controls.Add(this.lblNomeUser);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MudarSenhaCliente";
            this.Text = "MudarSenhaCliente";
            this.Load += new System.EventHandler(this.MudarSenhaCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblNomeUser;
        private System.Windows.Forms.Button btnPesquisarBarbearia;
        private System.Windows.Forms.Button btnCadastrar;
    }
}