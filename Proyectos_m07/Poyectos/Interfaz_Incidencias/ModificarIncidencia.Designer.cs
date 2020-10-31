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
            this.tbEmailPantallaModificar = new System.Windows.Forms.TextBox();
            this.dtCierre = new System.Windows.Forms.DateTimePicker();
            this.cbEstadoIncidencia = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(376, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(607, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Estado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(74, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha Cierre";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(347, 147);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Modificar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbEmailPantallaModificar
            // 
            this.tbEmailPantallaModificar.Location = new System.Drawing.Point(268, 51);
            this.tbEmailPantallaModificar.Name = "tbEmailPantallaModificar";
            this.tbEmailPantallaModificar.Size = new System.Drawing.Size(228, 20);
            this.tbEmailPantallaModificar.TabIndex = 5;
            this.tbEmailPantallaModificar.Text = "eee";
            this.tbEmailPantallaModificar.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dtCierre
            // 
            this.dtCierre.Location = new System.Drawing.Point(22, 50);
            this.dtCierre.Name = "dtCierre";
            this.dtCierre.Size = new System.Drawing.Size(200, 20);
            this.dtCierre.TabIndex = 6;
            this.dtCierre.Value = new System.DateTime(2029, 12, 31, 0, 0, 0, 0);
            this.dtCierre.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // cbEstadoIncidencia
            // 
            this.cbEstadoIncidencia.FormattingEnabled = true;
            this.cbEstadoIncidencia.Location = new System.Drawing.Point(575, 50);
            this.cbEstadoIncidencia.Name = "cbEstadoIncidencia";
            this.cbEstadoIncidencia.Size = new System.Drawing.Size(121, 21);
            this.cbEstadoIncidencia.TabIndex = 7;
            this.cbEstadoIncidencia.SelectedIndexChanged += new System.EventHandler(this.cbEstadoIncidencia_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.cbEstadoIncidencia);
            this.groupBox1.Controls.Add(this.tbEmailPantallaModificar);
            this.groupBox1.Controls.Add(this.dtCierre);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(12, 108);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 204);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // ModificarIncidencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 384);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "ModificarIncidencia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar Incidencia";
            this.Load += new System.EventHandler(this.ModificarIncidencia_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbEmailPantallaModificar;
        private System.Windows.Forms.ComboBox cbEstadoIncidencia;
        public System.Windows.Forms.DateTimePicker dtCierre;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}