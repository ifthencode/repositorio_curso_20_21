namespace Interfaz_Incidencias
{
    partial class AgregadorIncidencias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregadorIncidencias));
            this.label1 = new System.Windows.Forms.Label();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbAsunto = new System.Windows.Forms.TextBox();
            this.tBEmailPantallaAgreqar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbEstadoIncidencia = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtApertura = new System.Windows.Forms.DateTimePicker();
            this.guardarPantallaAgregar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo Incidencia";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cbTipo
            // 
            this.cbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipo.Location = new System.Drawing.Point(17, 62);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(121, 21);
            this.cbTipo.TabIndex = 1;
            this.cbTipo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descripción de la Incidencia";
            // 
            // tbAsunto
            // 
            this.tbAsunto.Location = new System.Drawing.Point(0, 162);
            this.tbAsunto.MaxLength = 25;
            this.tbAsunto.Multiline = true;
            this.tbAsunto.Name = "tbAsunto";
            this.tbAsunto.Size = new System.Drawing.Size(225, 114);
            this.tbAsunto.TabIndex = 3;
            this.tbAsunto.TextChanged += new System.EventHandler(this.textBoxAsunto_TextChanged);
            // 
            // tBEmailPantallaAgreqar
            // 
            this.tBEmailPantallaAgreqar.Location = new System.Drawing.Point(260, 62);
            this.tBEmailPantallaAgreqar.Name = "tBEmailPantallaAgreqar";
            this.tBEmailPantallaAgreqar.Size = new System.Drawing.Size(185, 20);
            this.tBEmailPantallaAgreqar.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(334, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(559, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Estado de la incidencia";
            // 
            // cbEstadoIncidencia
            // 
            this.cbEstadoIncidencia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstadoIncidencia.Location = new System.Drawing.Point(562, 62);
            this.cbEstadoIncidencia.Name = "cbEstadoIncidencia";
            this.cbEstadoIncidencia.Size = new System.Drawing.Size(121, 21);
            this.cbEstadoIncidencia.TabIndex = 7;
            this.cbEstadoIncidencia.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(406, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Fecha Apertura Incidencia";
            // 
            // dtApertura
            // 
            this.dtApertura.Location = new System.Drawing.Point(370, 162);
            this.dtApertura.Name = "dtApertura";
            this.dtApertura.Size = new System.Drawing.Size(200, 20);
            this.dtApertura.TabIndex = 9;
            // 
            // guardarPantallaAgregar
            // 
            this.guardarPantallaAgregar.Location = new System.Drawing.Point(495, 253);
            this.guardarPantallaAgregar.Name = "guardarPantallaAgregar";
            this.guardarPantallaAgregar.Size = new System.Drawing.Size(75, 23);
            this.guardarPantallaAgregar.TabIndex = 12;
            this.guardarPantallaAgregar.Text = "Guardar";
            this.guardarPantallaAgregar.UseVisualStyleBackColor = true;
            this.guardarPantallaAgregar.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.guardarPantallaAgregar);
            this.groupBox1.Controls.Add(this.cbTipo);
            this.groupBox1.Controls.Add(this.dtApertura);
            this.groupBox1.Controls.Add(this.tBEmailPantallaAgreqar);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cbEstadoIncidencia);
            this.groupBox1.Controls.Add(this.tbAsunto);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(35, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(710, 385);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // AgregadorIncidencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AgregadorIncidencias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregación de Incidencias";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbAsunto;
        private System.Windows.Forms.TextBox tBEmailPantallaAgreqar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbEstadoIncidencia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtApertura;
        private System.Windows.Forms.Button guardarPantallaAgregar;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}