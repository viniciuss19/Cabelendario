
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
            this.label1 = new System.Windows.Forms.Label();
            this.listDiasAgendar = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ListHorariosAgendar = new System.Windows.Forms.ListBox();
            this.button7 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.listServiçosAgendar = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label1.Location = new System.Drawing.Point(174, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selecione o dia";
            // 
            // listDiasAgendar
            // 
            this.listDiasAgendar.FormattingEnabled = true;
            this.listDiasAgendar.Location = new System.Drawing.Point(115, 47);
            this.listDiasAgendar.Name = "listDiasAgendar";
            this.listDiasAgendar.Size = new System.Drawing.Size(362, 56);
            this.listDiasAgendar.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label2.Location = new System.Drawing.Point(174, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 35);
            this.label2.TabIndex = 2;
            this.label2.Text = "Selecione o horário";
            // 
            // ListHorariosAgendar
            // 
            this.ListHorariosAgendar.FormattingEnabled = true;
            this.ListHorariosAgendar.Location = new System.Drawing.Point(115, 144);
            this.ListHorariosAgendar.Name = "ListHorariosAgendar";
            this.ListHorariosAgendar.Size = new System.Drawing.Size(362, 56);
            this.ListHorariosAgendar.TabIndex = 3;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(166, 339);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(273, 60);
            this.button7.TabIndex = 13;
            this.button7.Text = "AGENDAR";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label3.Location = new System.Drawing.Point(174, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(234, 35);
            this.label3.TabIndex = 14;
            this.label3.Text = "Selecione o serviço";
            // 
            // listServiçosAgendar
            // 
            this.listServiçosAgendar.FormattingEnabled = true;
            this.listServiçosAgendar.Location = new System.Drawing.Point(115, 264);
            this.listServiçosAgendar.Name = "listServiçosAgendar";
            this.listServiçosAgendar.Size = new System.Drawing.Size(362, 56);
            this.listServiçosAgendar.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label6.Location = new System.Drawing.Point(270, 412);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 18);
            this.label6.TabIndex = 17;
            this.label6.Text = "Voltar";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // Agendamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(580, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.listServiçosAgendar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.ListHorariosAgendar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listDiasAgendar);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Agendamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agendamento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listDiasAgendar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox ListHorariosAgendar;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listServiçosAgendar;
        private System.Windows.Forms.Label label6;
    }
}