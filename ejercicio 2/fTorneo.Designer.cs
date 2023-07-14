
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
            this.SuspendLayout();
            // 
            // lbTorneo
            // 
            this.lbTorneo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTorneo.FormattingEnabled = true;
            this.lbTorneo.ItemHeight = 20;
            this.lbTorneo.Location = new System.Drawing.Point(31, 39);
            this.lbTorneo.Name = "lbTorneo";
            this.lbTorneo.Size = new System.Drawing.Size(265, 324);
            this.lbTorneo.TabIndex = 0;
            // 
            // fTorneo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbTorneo);
            this.Name = "fTorneo";
            this.Text = "fTorneo";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListBox lbTorneo;
    }
}