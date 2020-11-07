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
            this.label1 = new System.Windows.Forms.Label();
            this.lvIncidenciasF = new System.Windows.Forms.ListView();
            this.vacia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clTipo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clAsunto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clEstado = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clApertura = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clCierre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(484, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Filtrado de Incidencias";
            // 
            // lvIncidenciasF
            // 
            this.lvIncidenciasF.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lvIncidenciasF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvIncidenciasF.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.vacia,
            this.clTipo,
            this.clAsunto,
            this.clEmail,
            this.clEstado,
            this.clApertura,
            this.clCierre});
            this.lvIncidenciasF.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvIncidenciasF.FullRowSelect = true;
            this.lvIncidenciasF.GridLines = true;
            this.lvIncidenciasF.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvIncidenciasF.HideSelection = false;
            this.lvIncidenciasF.LabelWrap = false;
            this.lvIncidenciasF.Location = new System.Drawing.Point(0, 143);
            this.lvIncidenciasF.Name = "lvIncidenciasF";
            this.lvIncidenciasF.Size = new System.Drawing.Size(1120, 306);
            this.lvIncidenciasF.TabIndex = 5;
            this.lvIncidenciasF.UseCompatibleStateImageBehavior = false;
            this.lvIncidenciasF.View = System.Windows.Forms.View.Details;
            // 
            // vacia
            // 
            this.vacia.Text = "";
            this.vacia.Width = 20;
            // 
            // clTipo
            // 
            this.clTipo.Text = "Tipo";
            this.clTipo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clTipo.Width = 96;
            // 
            // clAsunto
            // 
            this.clAsunto.Text = "Asunto";
            this.clAsunto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clAsunto.Width = 336;
            // 
            // clEmail
            // 
            this.clEmail.Text = "Email";
            this.clEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clEmail.Width = 179;
            // 
            // clEstado
            // 
            this.clEstado.Text = "Estado";
            this.clEstado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clEstado.Width = 155;
            // 
            // clApertura
            // 
            this.clApertura.Text = "Fecha apertura";
            this.clApertura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clApertura.Width = 161;
            // 
            // clCierre
            // 
            this.clCierre.Text = "Fecha Cierre";
            this.clCierre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clCierre.Width = 177;
            // 
            // FiltrarIncidencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 445);
            this.Controls.Add(this.lvIncidenciasF);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FiltrarIncidencias";
            this.Text = "Filtrado Incidencias";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvIncidenciasF;
        private System.Windows.Forms.ColumnHeader vacia;
        private System.Windows.Forms.ColumnHeader clTipo;
        private System.Windows.Forms.ColumnHeader clAsunto;
        private System.Windows.Forms.ColumnHeader clEmail;
        private System.Windows.Forms.ColumnHeader clEstado;
        private System.Windows.Forms.ColumnHeader clApertura;
        private System.Windows.Forms.ColumnHeader clCierre;
    }
}