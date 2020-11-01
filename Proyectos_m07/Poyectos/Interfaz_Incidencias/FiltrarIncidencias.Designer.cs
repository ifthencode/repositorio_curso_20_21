namespace Interfaz_Incidencias
{
    partial class FiltrarIncidencias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FiltrarIncidencias));
            this.lvFiltrado = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lvFiltrado
            // 
            this.lvFiltrado.HideSelection = false;
            this.lvFiltrado.Location = new System.Drawing.Point(-1, 145);
            this.lvFiltrado.Name = "lvFiltrado";
            this.lvFiltrado.Size = new System.Drawing.Size(804, 303);
            this.lvFiltrado.TabIndex = 0;
            this.lvFiltrado.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(305, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Filtrado de Incidencias";
            // 
            // FiltrarIncidencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvFiltrado);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FiltrarIncidencias";
            this.Text = "Filtrado Incidencias";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvFiltrado;
        private System.Windows.Forms.Label label1;
    }
}