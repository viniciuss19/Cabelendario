
namespace CABELENDÁRIO
{
    partial class MostrarAgendamentos
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.DGVHorariosAgendados = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lbDias = new System.Windows.Forms.Label();
            this.lbHoras = new System.Windows.Forms.Label();
            this.lbServiços = new System.Windows.Forms.Label();
            this.tbDias = new System.Windows.Forms.TextBox();
            this.tbHoras = new System.Windows.Forms.TextBox();
            this.tbServiços = new System.Windows.Forms.TextBox();
            this.lbVoltar = new System.Windows.Forms.Label();
            this.tbBarbearia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNomeUser = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGVHorariosAgendados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Bahnschrift Condensed", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.lbl1.Location = new System.Drawing.Point(172, 83);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(331, 45);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Seus horários agendados:";
            // 
            // DGVHorariosAgendados
            // 
            this.DGVHorariosAgendados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVHorariosAgendados.Location = new System.Drawing.Point(136, 131);
            this.DGVHorariosAgendados.Name = "DGVHorariosAgendados";
            this.DGVHorariosAgendados.Size = new System.Drawing.Size(410, 216);
            this.DGVHorariosAgendados.TabIndex = 1;
            this.DGVHorariosAgendados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Firebrick;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(355, 431);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 42);
            this.button1.TabIndex = 12;
            this.button1.Text = "SAIR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(211, 431);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 42);
            this.button2.TabIndex = 14;
            this.button2.Text = "DESMARCAR";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbDias
            // 
            this.lbDias.AutoSize = true;
            this.lbDias.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDias.Location = new System.Drawing.Point(162, 351);
            this.lbDias.Name = "lbDias";
            this.lbDias.Size = new System.Drawing.Size(37, 20);
            this.lbDias.TabIndex = 15;
            this.lbDias.Text = "Dia:";
            // 
            // lbHoras
            // 
            this.lbHoras.AutoSize = true;
            this.lbHoras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHoras.Location = new System.Drawing.Point(162, 382);
            this.lbHoras.Name = "lbHoras";
            this.lbHoras.Size = new System.Drawing.Size(56, 20);
            this.lbHoras.TabIndex = 16;
            this.lbHoras.Text = "Horas:";
            // 
            // lbServiços
            // 
            this.lbServiços.AutoSize = true;
            this.lbServiços.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbServiços.ForeColor = System.Drawing.Color.Black;
            this.lbServiços.Location = new System.Drawing.Point(132, 405);
            this.lbServiços.Name = "lbServiços";
            this.lbServiços.Size = new System.Drawing.Size(73, 20);
            this.lbServiços.TabIndex = 17;
            this.lbServiços.Text = "Serviços:";
            // 
            // tbDias
            // 
            this.tbDias.Location = new System.Drawing.Point(205, 353);
            this.tbDias.Name = "tbDias";
            this.tbDias.Size = new System.Drawing.Size(100, 20);
            this.tbDias.TabIndex = 18;
            // 
            // tbHoras
            // 
            this.tbHoras.Location = new System.Drawing.Point(224, 379);
            this.tbHoras.Name = "tbHoras";
            this.tbHoras.Size = new System.Drawing.Size(100, 20);
            this.tbHoras.TabIndex = 19;
            // 
            // tbServiços
            // 
            this.tbServiços.Location = new System.Drawing.Point(211, 405);
            this.tbServiços.Name = "tbServiços";
            this.tbServiços.Size = new System.Drawing.Size(100, 20);
            this.tbServiços.TabIndex = 20;
            // 
            // lbVoltar
            // 
            this.lbVoltar.AutoSize = true;
            this.lbVoltar.BackColor = System.Drawing.Color.White;
            this.lbVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVoltar.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.lbVoltar.Location = new System.Drawing.Point(487, 455);
            this.lbVoltar.Name = "lbVoltar";
            this.lbVoltar.Size = new System.Drawing.Size(52, 18);
            this.lbVoltar.TabIndex = 21;
            this.lbVoltar.Text = "Voltar";
            this.lbVoltar.Click += new System.EventHandler(this.lbVoltar_Click);
            // 
            // tbBarbearia
            // 
            this.tbBarbearia.Location = new System.Drawing.Point(422, 377);
            this.tbBarbearia.Name = "tbBarbearia";
            this.tbBarbearia.Size = new System.Drawing.Size(156, 20);
            this.tbBarbearia.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(334, 377);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "Barbearia:";
            // 
            // lblNomeUser
            // 
            this.lblNomeUser.AutoSize = true;
            this.lblNomeUser.Font = new System.Drawing.Font("Bahnschrift Condensed", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeUser.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.lblNomeUser.Location = new System.Drawing.Point(274, 24);
            this.lblNomeUser.Name = "lblNomeUser";
            this.lblNomeUser.Size = new System.Drawing.Size(142, 45);
            this.lblNomeUser.TabIndex = 24;
            this.lblNomeUser.Text = "NomeUser";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CABELENDÁRIO.Properties.Resources.usuario;
            this.pictureBox1.Location = new System.Drawing.Point(147, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 87);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 43;
            this.pictureBox1.TabStop = false;
            // 
            // MostrarAgendamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(652, 509);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblNomeUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbBarbearia);
            this.Controls.Add(this.lbVoltar);
            this.Controls.Add(this.tbServiços);
            this.Controls.Add(this.tbHoras);
            this.Controls.Add(this.tbDias);
            this.Controls.Add(this.lbServiços);
            this.Controls.Add(this.lbHoras);
            this.Controls.Add(this.lbDias);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DGVHorariosAgendados);
            this.Controls.Add(this.lbl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Name = "MostrarAgendamentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MostrarAgendamentos";
            this.Load += new System.EventHandler(this.MostrarAgendamentos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVHorariosAgendados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.DataGridView DGVHorariosAgendados;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lbDias;
        private System.Windows.Forms.Label lbHoras;
        private System.Windows.Forms.Label lbServiços;
        private System.Windows.Forms.TextBox tbDias;
        private System.Windows.Forms.TextBox tbHoras;
        private System.Windows.Forms.TextBox tbServiços;
        private System.Windows.Forms.Label lbVoltar;
        private System.Windows.Forms.TextBox tbBarbearia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNomeUser;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}