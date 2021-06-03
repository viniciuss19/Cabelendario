
namespace CABELENDÁRIO
{
    partial class BarbeariaAgendamentos
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
            this.lbl = new System.Windows.Forms.Label();
            this.dgvBarbeariaHorarios = new System.Windows.Forms.DataGridView();
            this.lblNomeBarbearia = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.tbDia = new System.Windows.Forms.TextBox();
            this.tbHoras = new System.Windows.Forms.TextBox();
            this.tbCliente = new System.Windows.Forms.TextBox();
            this.lbDias = new System.Windows.Forms.Label();
            this.lbHoras = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbVoltar = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbServiços = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBarbeariaHorarios)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Bahnschrift Condensed", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.lbl.Location = new System.Drawing.Point(184, 9);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(433, 45);
            this.lbl.TabIndex = 34;
            this.lbl.Text = "Horários Agendados na Barbearia:";
            this.lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvBarbeariaHorarios
            // 
            this.dgvBarbeariaHorarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBarbeariaHorarios.Location = new System.Drawing.Point(192, 102);
            this.dgvBarbeariaHorarios.Name = "dgvBarbeariaHorarios";
            this.dgvBarbeariaHorarios.Size = new System.Drawing.Size(453, 191);
            this.dgvBarbeariaHorarios.TabIndex = 35;
            this.dgvBarbeariaHorarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBarbeariaHorarios_CellContentClick);
            // 
            // lblNomeBarbearia
            // 
            this.lblNomeBarbearia.AutoSize = true;
            this.lblNomeBarbearia.Font = new System.Drawing.Font("Bahnschrift Condensed", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeBarbearia.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.lblNomeBarbearia.Location = new System.Drawing.Point(330, 64);
            this.lblNomeBarbearia.Name = "lblNomeBarbearia";
            this.lblNomeBarbearia.Size = new System.Drawing.Size(163, 35);
            this.lblNomeBarbearia.TabIndex = 36;
            this.lblNomeBarbearia.Text = "NomeBarbearia";
            this.lblNomeBarbearia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(222, 395);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(210, 43);
            this.button7.TabIndex = 37;
            this.button7.Text = "Desmarcar Horário";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // tbDia
            // 
            this.tbDia.Location = new System.Drawing.Point(222, 324);
            this.tbDia.Name = "tbDia";
            this.tbDia.Size = new System.Drawing.Size(100, 20);
            this.tbDia.TabIndex = 38;
            // 
            // tbHoras
            // 
            this.tbHoras.Location = new System.Drawing.Point(222, 353);
            this.tbHoras.Name = "tbHoras";
            this.tbHoras.Size = new System.Drawing.Size(100, 20);
            this.tbHoras.TabIndex = 39;
            // 
            // tbCliente
            // 
            this.tbCliente.Location = new System.Drawing.Point(438, 324);
            this.tbCliente.Name = "tbCliente";
            this.tbCliente.Size = new System.Drawing.Size(100, 20);
            this.tbCliente.TabIndex = 41;
            // 
            // lbDias
            // 
            this.lbDias.AutoSize = true;
            this.lbDias.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDias.Location = new System.Drawing.Point(179, 324);
            this.lbDias.Name = "lbDias";
            this.lbDias.Size = new System.Drawing.Size(37, 20);
            this.lbDias.TabIndex = 42;
            this.lbDias.Text = "Dia:";
            // 
            // lbHoras
            // 
            this.lbHoras.AutoSize = true;
            this.lbHoras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHoras.Location = new System.Drawing.Point(160, 353);
            this.lbHoras.Name = "lbHoras";
            this.lbHoras.Size = new System.Drawing.Size(56, 20);
            this.lbHoras.TabIndex = 43;
            this.lbHoras.Text = "Horas:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(370, 324);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 45;
            this.label1.Text = "Cliente:";
            // 
            // lbVoltar
            // 
            this.lbVoltar.AutoSize = true;
            this.lbVoltar.BackColor = System.Drawing.Color.White;
            this.lbVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVoltar.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.lbVoltar.Location = new System.Drawing.Point(570, 420);
            this.lbVoltar.Name = "lbVoltar";
            this.lbVoltar.Size = new System.Drawing.Size(52, 18);
            this.lbVoltar.TabIndex = 46;
            this.lbVoltar.Text = "Voltar";
            this.lbVoltar.Click += new System.EventHandler(this.lbVoltar_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Firebrick;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(438, 396);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 42);
            this.button1.TabIndex = 47;
            this.button1.Text = "SAIR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(370, 353);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 48;
            this.label2.Text = "Serviços:";
            // 
            // tbServiços
            // 
            this.tbServiços.Location = new System.Drawing.Point(449, 353);
            this.tbServiços.Name = "tbServiços";
            this.tbServiços.Size = new System.Drawing.Size(100, 20);
            this.tbServiços.TabIndex = 49;
            // 
            // BarbeariaAgendamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbServiços);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbVoltar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbHoras);
            this.Controls.Add(this.lbDias);
            this.Controls.Add(this.tbCliente);
            this.Controls.Add(this.tbHoras);
            this.Controls.Add(this.tbDia);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.lblNomeBarbearia);
            this.Controls.Add(this.dgvBarbeariaHorarios);
            this.Controls.Add(this.lbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BarbeariaAgendamentos";
            this.Text = "BarbeariaAgendamentos";
            this.Load += new System.EventHandler(this.BarbeariaAgendamentos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBarbeariaHorarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.DataGridView dgvBarbeariaHorarios;
        private System.Windows.Forms.Label lblNomeBarbearia;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox tbDia;
        private System.Windows.Forms.TextBox tbHoras;
        private System.Windows.Forms.TextBox tbCliente;
        private System.Windows.Forms.Label lbDias;
        private System.Windows.Forms.Label lbHoras;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbVoltar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbServiços;
    }
}