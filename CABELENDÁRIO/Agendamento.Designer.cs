
namespace CABELENDÁRIO
{
    partial class Agendamento
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
            this.btAgendar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lbVoltar = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbDiaAgendar = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbServiçoAgendar = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvHorariosAgendar = new System.Windows.Forms.DataGridView();
            this.dgvServiçosAgendar = new System.Windows.Forms.DataGridView();
            this.btPesquisarServiços = new System.Windows.Forms.Button();
            this.btPesquisarDatas = new System.Windows.Forms.Button();
            this.lblTBDATAS = new System.Windows.Forms.Label();
            this.lblTBSERVIÇOS = new System.Windows.Forms.Label();
            this.tbHorarioAgendar = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btPesquisarHorario = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHorariosAgendar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServiçosAgendar)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label2.Location = new System.Drawing.Point(302, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Digite o dia que você deseja";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btAgendar
            // 
            this.btAgendar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btAgendar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAgendar.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAgendar.ForeColor = System.Drawing.Color.White;
            this.btAgendar.Location = new System.Drawing.Point(372, 365);
            this.btAgendar.Name = "btAgendar";
            this.btAgendar.Size = new System.Drawing.Size(113, 41);
            this.btAgendar.TabIndex = 13;
            this.btAgendar.Text = "AGENDAR";
            this.btAgendar.UseVisualStyleBackColor = false;
            this.btAgendar.Click += new System.EventHandler(this.btAgendar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label3.Location = new System.Drawing.Point(119, 609);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(234, 35);
            this.label3.TabIndex = 14;
            this.label3.Text = "Selecione o serviço";
            // 
            // lbVoltar
            // 
            this.lbVoltar.AutoSize = true;
            this.lbVoltar.BackColor = System.Drawing.Color.White;
            this.lbVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVoltar.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.lbVoltar.Location = new System.Drawing.Point(403, 409);
            this.lbVoltar.Name = "lbVoltar";
            this.lbVoltar.Size = new System.Drawing.Size(52, 18);
            this.lbVoltar.TabIndex = 17;
            this.lbVoltar.Text = "Voltar";
            this.lbVoltar.Click += new System.EventHandler(this.label6_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label1.Location = new System.Drawing.Point(292, 254);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "Digite o serviço que você deseja";
            // 
            // tbDiaAgendar
            // 
            this.tbDiaAgendar.Location = new System.Drawing.Point(330, 80);
            this.tbDiaAgendar.Name = "tbDiaAgendar";
            this.tbDiaAgendar.Size = new System.Drawing.Size(200, 20);
            this.tbDiaAgendar.TabIndex = 19;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(330, 101);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 2);
            this.panel2.TabIndex = 21;
            // 
            // tbServiçoAgendar
            // 
            this.tbServiçoAgendar.Location = new System.Drawing.Point(330, 287);
            this.tbServiçoAgendar.Name = "tbServiçoAgendar";
            this.tbServiçoAgendar.Size = new System.Drawing.Size(200, 20);
            this.tbServiçoAgendar.TabIndex = 22;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(330, 308);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 2);
            this.panel3.TabIndex = 23;
            // 
            // dgvHorariosAgendar
            // 
            this.dgvHorariosAgendar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHorariosAgendar.Location = new System.Drawing.Point(12, 55);
            this.dgvHorariosAgendar.Name = "dgvHorariosAgendar";
            this.dgvHorariosAgendar.Size = new System.Drawing.Size(265, 150);
            this.dgvHorariosAgendar.TabIndex = 24;
            // 
            // dgvServiçosAgendar
            // 
            this.dgvServiçosAgendar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServiçosAgendar.Location = new System.Drawing.Point(12, 244);
            this.dgvServiçosAgendar.Name = "dgvServiçosAgendar";
            this.dgvServiçosAgendar.Size = new System.Drawing.Size(265, 150);
            this.dgvServiçosAgendar.TabIndex = 25;
            // 
            // btPesquisarServiços
            // 
            this.btPesquisarServiços.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btPesquisarServiços.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPesquisarServiços.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPesquisarServiços.ForeColor = System.Drawing.Color.White;
            this.btPesquisarServiços.Location = new System.Drawing.Point(330, 316);
            this.btPesquisarServiços.Name = "btPesquisarServiços";
            this.btPesquisarServiços.Size = new System.Drawing.Size(200, 31);
            this.btPesquisarServiços.TabIndex = 26;
            this.btPesquisarServiços.Text = "Pesquisar";
            this.btPesquisarServiços.UseVisualStyleBackColor = false;
            this.btPesquisarServiços.Click += new System.EventHandler(this.btPesquisarServiços_Click);
            // 
            // btPesquisarDatas
            // 
            this.btPesquisarDatas.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btPesquisarDatas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPesquisarDatas.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPesquisarDatas.ForeColor = System.Drawing.Color.White;
            this.btPesquisarDatas.Location = new System.Drawing.Point(330, 109);
            this.btPesquisarDatas.Name = "btPesquisarDatas";
            this.btPesquisarDatas.Size = new System.Drawing.Size(200, 31);
            this.btPesquisarDatas.TabIndex = 27;
            this.btPesquisarDatas.Text = "Pesquisar";
            this.btPesquisarDatas.UseVisualStyleBackColor = false;
            this.btPesquisarDatas.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblTBDATAS
            // 
            this.lblTBDATAS.AutoSize = true;
            this.lblTBDATAS.Location = new System.Drawing.Point(65, 30);
            this.lblTBDATAS.Name = "lblTBDATAS";
            this.lblTBDATAS.Size = new System.Drawing.Size(145, 13);
            this.lblTBDATAS.TabIndex = 29;
            this.lblTBDATAS.Text = "Tabela de Datas Disponíveis";
            // 
            // lblTBSERVIÇOS
            // 
            this.lblTBSERVIÇOS.AutoSize = true;
            this.lblTBSERVIÇOS.Location = new System.Drawing.Point(92, 219);
            this.lblTBSERVIÇOS.Name = "lblTBSERVIÇOS";
            this.lblTBSERVIÇOS.Size = new System.Drawing.Size(99, 13);
            this.lblTBSERVIÇOS.TabIndex = 30;
            this.lblTBSERVIÇOS.Text = "Tabela de Serviços";
            // 
            // tbHorarioAgendar
            // 
            this.tbHorarioAgendar.Location = new System.Drawing.Point(330, 167);
            this.tbHorarioAgendar.Name = "tbHorarioAgendar";
            this.tbHorarioAgendar.Size = new System.Drawing.Size(200, 20);
            this.tbHorarioAgendar.TabIndex = 31;
            this.tbHorarioAgendar.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(330, 193);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 2);
            this.panel1.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label4.Location = new System.Drawing.Point(298, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(245, 23);
            this.label4.TabIndex = 33;
            this.label4.Text = "Digite o horário que voce deseja";
            // 
            // btPesquisarHorario
            // 
            this.btPesquisarHorario.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btPesquisarHorario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPesquisarHorario.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPesquisarHorario.ForeColor = System.Drawing.Color.White;
            this.btPesquisarHorario.Location = new System.Drawing.Point(330, 201);
            this.btPesquisarHorario.Name = "btPesquisarHorario";
            this.btPesquisarHorario.Size = new System.Drawing.Size(200, 31);
            this.btPesquisarHorario.TabIndex = 34;
            this.btPesquisarHorario.Text = "Pesquisar";
            this.btPesquisarHorario.UseVisualStyleBackColor = false;
            this.btPesquisarHorario.Click += new System.EventHandler(this.btPesquisarHorario_Click);
            // 
            // Agendamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(580, 450);
            this.Controls.Add(this.btPesquisarHorario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbHorarioAgendar);
            this.Controls.Add(this.lblTBSERVIÇOS);
            this.Controls.Add(this.lblTBDATAS);
            this.Controls.Add(this.btPesquisarDatas);
            this.Controls.Add(this.btPesquisarServiços);
            this.Controls.Add(this.dgvServiçosAgendar);
            this.Controls.Add(this.dgvHorariosAgendar);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.tbServiçoAgendar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tbDiaAgendar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbVoltar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btAgendar);
            this.Controls.Add(this.label2);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Agendamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agendamento";
            this.Load += new System.EventHandler(this.Agendamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHorariosAgendar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServiçosAgendar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btAgendar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbVoltar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbDiaAgendar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tbServiçoAgendar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvHorariosAgendar;
        private System.Windows.Forms.DataGridView dgvServiçosAgendar;
        private System.Windows.Forms.Button btPesquisarServiços;
        private System.Windows.Forms.Button btPesquisarDatas;
        private System.Windows.Forms.Label lblTBDATAS;
        private System.Windows.Forms.Label lblTBSERVIÇOS;
        private System.Windows.Forms.TextBox tbHorarioAgendar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btPesquisarHorario;
    }
}