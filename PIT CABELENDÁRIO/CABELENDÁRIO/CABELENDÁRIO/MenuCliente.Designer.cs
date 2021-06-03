
namespace CABELENDÁRIO
{
    partial class MenuCliente
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
            this.label1 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvBarbearias = new System.Windows.Forms.DataGridView();
            this.lblBarbearia = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvHorário = new System.Windows.Forms.DataGridView();
            this.dgvServiço = new System.Windows.Forms.DataGridView();
            this.tbPesquisarBarbearia = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPesquisarBarbearia = new System.Windows.Forms.Button();
            this.tbDia = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbHoras = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbServiços = new System.Windows.Forms.TextBox();
            this.tbPreço = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbBarbearia = new System.Windows.Forms.TextBox();
            this.tbEndereço = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBarbearias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHorário)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServiço)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Bauhaus 93", 45F);
            this.label1.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label1.Location = new System.Drawing.Point(361, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 68);
            this.label1.TabIndex = 2;
            this.label1.Text = "MENU";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(510, 481);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(186, 49);
            this.button5.TabIndex = 10;
            this.button5.Text = "SAIR";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(131, 481);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(228, 49);
            this.button7.TabIndex = 12;
            this.button7.Text = "AGENDAR";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(705, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 33);
            this.button1.TabIndex = 13;
            this.button1.Text = "Ver meus horários agendados";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvBarbearias
            // 
            this.dgvBarbearias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBarbearias.Location = new System.Drawing.Point(34, 90);
            this.dgvBarbearias.Name = "dgvBarbearias";
            this.dgvBarbearias.Size = new System.Drawing.Size(245, 156);
            this.dgvBarbearias.TabIndex = 14;
            this.dgvBarbearias.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBarbearias_CellContentClick);
            // 
            // lblBarbearia
            // 
            this.lblBarbearia.AutoSize = true;
            this.lblBarbearia.BackColor = System.Drawing.Color.White;
            this.lblBarbearia.Font = new System.Drawing.Font("Bahnschrift Condensed", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBarbearia.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.lblBarbearia.Location = new System.Drawing.Point(49, 45);
            this.lblBarbearia.Name = "lblBarbearia";
            this.lblBarbearia.Size = new System.Drawing.Size(151, 42);
            this.lblBarbearia.TabIndex = 16;
            this.lblBarbearia.Text = "Barbearias:";
            this.lblBarbearia.Click += new System.EventHandler(this.lblBarbearia_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label2.Location = new System.Drawing.Point(673, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 42);
            this.label2.TabIndex = 17;
            this.label2.Text = "Data:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Bahnschrift Condensed", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label4.Location = new System.Drawing.Point(673, 304);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 42);
            this.label4.TabIndex = 18;
            this.label4.Text = "Serviços:";
            // 
            // dgvHorário
            // 
            this.dgvHorário.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHorário.Location = new System.Drawing.Point(570, 90);
            this.dgvHorário.Name = "dgvHorário";
            this.dgvHorário.Size = new System.Drawing.Size(307, 159);
            this.dgvHorário.TabIndex = 19;
            this.dgvHorário.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHorário_CellContentClick);
            // 
            // dgvServiço
            // 
            this.dgvServiço.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServiço.Location = new System.Drawing.Point(605, 349);
            this.dgvServiço.Name = "dgvServiço";
            this.dgvServiço.Size = new System.Drawing.Size(240, 126);
            this.dgvServiço.TabIndex = 20;
            this.dgvServiço.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvServiço_CellContentClick);
            // 
            // tbPesquisarBarbearia
            // 
            this.tbPesquisarBarbearia.Location = new System.Drawing.Point(34, 257);
            this.tbPesquisarBarbearia.Name = "tbPesquisarBarbearia";
            this.tbPesquisarBarbearia.Size = new System.Drawing.Size(245, 20);
            this.tbPesquisarBarbearia.TabIndex = 21;
            // 
            // panel1
            // 
            this.panel1.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.panel1.Location = new System.Drawing.Point(34, 280);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(248, 2);
            this.panel1.TabIndex = 22;
            // 
            // btnPesquisarBarbearia
            // 
            this.btnPesquisarBarbearia.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnPesquisarBarbearia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisarBarbearia.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisarBarbearia.ForeColor = System.Drawing.Color.White;
            this.btnPesquisarBarbearia.Location = new System.Drawing.Point(97, 288);
            this.btnPesquisarBarbearia.Name = "btnPesquisarBarbearia";
            this.btnPesquisarBarbearia.Size = new System.Drawing.Size(134, 36);
            this.btnPesquisarBarbearia.TabIndex = 23;
            this.btnPesquisarBarbearia.Text = "Pesquisar";
            this.btnPesquisarBarbearia.UseVisualStyleBackColor = false;
            this.btnPesquisarBarbearia.Click += new System.EventHandler(this.btnPesquisarBarbearia_Click);
            // 
            // tbDia
            // 
            this.tbDia.Location = new System.Drawing.Point(484, 140);
            this.tbDia.Name = "tbDia";
            this.tbDia.Size = new System.Drawing.Size(66, 20);
            this.tbDia.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label5.Location = new System.Drawing.Point(500, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 25);
            this.label5.TabIndex = 25;
            this.label5.Text = "Dia:";
            // 
            // tbHoras
            // 
            this.tbHoras.Location = new System.Drawing.Point(484, 191);
            this.tbHoras.Name = "tbHoras";
            this.tbHoras.Size = new System.Drawing.Size(66, 20);
            this.tbHoras.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label6.Location = new System.Drawing.Point(493, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 25);
            this.label6.TabIndex = 27;
            this.label6.Text = "Horas:";
            // 
            // tbServiços
            // 
            this.tbServiços.Location = new System.Drawing.Point(519, 382);
            this.tbServiços.Name = "tbServiços";
            this.tbServiços.Size = new System.Drawing.Size(66, 20);
            this.tbServiços.TabIndex = 30;
            // 
            // tbPreço
            // 
            this.tbPreço.Location = new System.Drawing.Point(522, 433);
            this.tbPreço.Name = "tbPreço";
            this.tbPreço.Size = new System.Drawing.Size(66, 20);
            this.tbPreço.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label7.Location = new System.Drawing.Point(520, 354);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 25);
            this.label7.TabIndex = 32;
            this.label7.Text = "Serviço:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label8.Location = new System.Drawing.Point(530, 405);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 25);
            this.label8.TabIndex = 33;
            this.label8.Text = "Preço:";
            // 
            // tbBarbearia
            // 
            this.tbBarbearia.Location = new System.Drawing.Point(285, 155);
            this.tbBarbearia.Name = "tbBarbearia";
            this.tbBarbearia.Size = new System.Drawing.Size(104, 20);
            this.tbBarbearia.TabIndex = 36;
            // 
            // tbEndereço
            // 
            this.tbEndereço.Location = new System.Drawing.Point(288, 206);
            this.tbEndereço.Name = "tbEndereço";
            this.tbEndereço.Size = new System.Drawing.Size(104, 20);
            this.tbEndereço.TabIndex = 37;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label9.Location = new System.Drawing.Point(298, 127);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 25);
            this.label9.TabIndex = 38;
            this.label9.Text = "Barbearia:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label10.Location = new System.Drawing.Point(298, 178);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 25);
            this.label10.TabIndex = 41;
            this.label10.Text = "Endereço:";
            // 
            // MenuCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(889, 542);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbEndereço);
            this.Controls.Add(this.tbBarbearia);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbPreço);
            this.Controls.Add(this.tbServiços);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbHoras);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbDia);
            this.Controls.Add(this.btnPesquisarBarbearia);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbPesquisarBarbearia);
            this.Controls.Add(this.dgvServiço);
            this.Controls.Add(this.dgvHorário);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblBarbearia);
            this.Controls.Add(this.dgvBarbearias);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBarbearias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHorário)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServiço)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvBarbearias;
        private System.Windows.Forms.Label lblBarbearia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvHorário;
        private System.Windows.Forms.DataGridView dgvServiço;
        private System.Windows.Forms.TextBox tbPesquisarBarbearia;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPesquisarBarbearia;
        private System.Windows.Forms.TextBox tbDia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbHoras;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbServiços;
        private System.Windows.Forms.TextBox tbPreço;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbBarbearia;
        private System.Windows.Forms.TextBox tbEndereço;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}