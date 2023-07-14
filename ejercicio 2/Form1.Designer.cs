
namespace ejercicio_2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.bCompetidores = new System.Windows.Forms.Button();
            this.bTorneo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bCompetidores
            // 
            this.bCompetidores.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCompetidores.Location = new System.Drawing.Point(132, 52);
            this.bCompetidores.Name = "bCompetidores";
            this.bCompetidores.Size = new System.Drawing.Size(139, 67);
            this.bCompetidores.TabIndex = 0;
            this.bCompetidores.Text = "Cargar Competidores";
            this.bCompetidores.UseVisualStyleBackColor = true;
            this.bCompetidores.Click += new System.EventHandler(this.bCompetidores_Click);
            // 
            // bTorneo
            // 
            this.bTorneo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bTorneo.Location = new System.Drawing.Point(132, 185);
            this.bTorneo.Name = "bTorneo";
            this.bTorneo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bTorneo.Size = new System.Drawing.Size(139, 67);
            this.bTorneo.TabIndex = 1;
            this.bTorneo.Text = "Iniciar Competencia";
            this.bTorneo.UseVisualStyleBackColor = true;
            this.bTorneo.Click += new System.EventHandler(this.bTorneo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 345);
            this.Controls.Add(this.bTorneo);
            this.Controls.Add(this.bCompetidores);
            this.Name = "Form1";
            this.Text = "Torneo de Tiro";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bCompetidores;
        private System.Windows.Forms.Button bTorneo;
    }
}

