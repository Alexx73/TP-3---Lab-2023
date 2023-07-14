
namespace ejercicio_2
{
    partial class fTorneo
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
            this.lbTorneo = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.laNroRondas = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbPuntos = new System.Windows.Forms.ListBox();
            this.lbNombreCompetidor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbTorneo
            // 
            this.lbTorneo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTorneo.FormattingEnabled = true;
            this.lbTorneo.ItemHeight = 20;
            this.lbTorneo.Location = new System.Drawing.Point(31, 69);
            this.lbTorneo.Name = "lbTorneo";
            this.lbTorneo.Size = new System.Drawing.Size(243, 324);
            this.lbTorneo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(86, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Competidores";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(448, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ronda";
            // 
            // laNroRondas
            // 
            this.laNroRondas.AutoSize = true;
            this.laNroRondas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laNroRondas.Location = new System.Drawing.Point(511, 45);
            this.laNroRondas.Name = "laNroRondas";
            this.laNroRondas.Size = new System.Drawing.Size(18, 20);
            this.laNroRondas.TabIndex = 3;
            this.laNroRondas.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(315, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Competidor";
            // 
            // lbPuntos
            // 
            this.lbPuntos.FormattingEnabled = true;
            this.lbPuntos.ItemHeight = 16;
            this.lbPuntos.Location = new System.Drawing.Point(452, 109);
            this.lbPuntos.Name = "lbPuntos";
            this.lbPuntos.Size = new System.Drawing.Size(120, 180);
            this.lbPuntos.TabIndex = 5;
            // 
            // lbNombreCompetidor
            // 
            this.lbNombreCompetidor.AutoSize = true;
            this.lbNombreCompetidor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombreCompetidor.Location = new System.Drawing.Point(348, 109);
            this.lbNombreCompetidor.Name = "lbNombreCompetidor";
            this.lbNombreCompetidor.Size = new System.Drawing.Size(0, 20);
            this.lbNombreCompetidor.TabIndex = 6;
            this.lbNombreCompetidor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // fTorneo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbNombreCompetidor);
            this.Controls.Add(this.lbPuntos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.laNroRondas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbTorneo);
            this.Name = "fTorneo";
            this.Text = "fTorneo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ListBox lbTorneo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label laNroRondas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbPuntos;
        private System.Windows.Forms.Label lbNombreCompetidor;
    }
}