namespace Interfaz_Incidencias
{
    partial class ModificarIncidencia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificarIncidencia));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.dtCierre = new System.Windows.Forms.DateTimePicker();
            this.cbEstadoIncidencia = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(366, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(597, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Estado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha Cierre";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(337, 200);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Modificar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(258, 98);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(228, 20);
            this.tbEmail.TabIndex = 5;
            this.tbEmail.Text = "eee";
            this.tbEmail.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dtCierre
            // 
            this.dtCierre.Location = new System.Drawing.Point(12, 97);
            this.dtCierre.Name = "dtCierre";
            this.dtCierre.Size = new System.Drawing.Size(200, 20);
            this.dtCierre.TabIndex = 6;
            this.dtCierre.Value = new System.DateTime(2029, 12, 31, 0, 0, 0, 0);
            this.dtCierre.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // cbEstadoIncidencia
            // 
            this.cbEstadoIncidencia.FormattingEnabled = true;
            this.cbEstadoIncidencia.Location = new System.Drawing.Point(565, 97);
            this.cbEstadoIncidencia.Name = "cbEstadoIncidencia";
            this.cbEstadoIncidencia.Size = new System.Drawing.Size(121, 21);
            this.cbEstadoIncidencia.TabIndex = 7;
            this.cbEstadoIncidencia.SelectedIndexChanged += new System.EventHandler(this.cbEstadoIncidencia_SelectedIndexChanged);
            // 
            // ModificarIncidencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbEstadoIncidencia);
            this.Controls.Add(this.dtCierre);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ModificarIncidencia";
            this.Text = "Modificar Incidencia";
            this.Load += new System.EventHandler(this.ModificarIncidencia_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.ComboBox cbEstadoIncidencia;
        public System.Windows.Forms.DateTimePicker dtCierre;
    }
}