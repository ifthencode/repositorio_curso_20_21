namespace Tema1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gbLocal = new System.Windows.Forms.GroupBox();
            this.nudLocal = new System.Windows.Forms.NumericUpDown();
            this.cbLocal = new System.Windows.Forms.ComboBox();
            this.gbVisitante = new System.Windows.Forms.GroupBox();
            this.nudVisitante = new System.Windows.Forms.NumericUpDown();
            this.cbVisitante = new System.Windows.Forms.ComboBox();
            this.iconos = new System.Windows.Forms.ImageList(this.components);
            this.iconosGrandes = new System.Windows.Forms.ImageList(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.gbLocal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLocal)).BeginInit();
            this.gbVisitante.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudVisitante)).BeginInit();
            this.SuspendLayout();
            // 
            // gbLocal
            // 
            this.gbLocal.Controls.Add(this.nudLocal);
            this.gbLocal.Controls.Add(this.cbLocal);
            this.gbLocal.Location = new System.Drawing.Point(56, 110);
            this.gbLocal.Name = "gbLocal";
            this.gbLocal.Size = new System.Drawing.Size(239, 155);
            this.gbLocal.TabIndex = 0;
            this.gbLocal.TabStop = false;
            this.gbLocal.Text = "LOCAL";
            // 
            // nudLocal
            // 
            this.nudLocal.BackColor = System.Drawing.SystemColors.MenuBar;
            this.nudLocal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nudLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudLocal.Location = new System.Drawing.Point(88, 75);
            this.nudLocal.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudLocal.Name = "nudLocal";
            this.nudLocal.Size = new System.Drawing.Size(48, 40);
            this.nudLocal.TabIndex = 1;
            this.nudLocal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbLocal
            // 
            this.cbLocal.FormattingEnabled = true;
            this.cbLocal.Location = new System.Drawing.Point(38, 31);
            this.cbLocal.Name = "cbLocal";
            this.cbLocal.Size = new System.Drawing.Size(163, 21);
            this.cbLocal.TabIndex = 0;
            this.cbLocal.SelectedIndexChanged += new System.EventHandler(this.seleccion);
            // 
            // gbVisitante
            // 
            this.gbVisitante.Controls.Add(this.nudVisitante);
            this.gbVisitante.Controls.Add(this.cbVisitante);
            this.gbVisitante.Location = new System.Drawing.Point(318, 110);
            this.gbVisitante.Name = "gbVisitante";
            this.gbVisitante.Size = new System.Drawing.Size(239, 155);
            this.gbVisitante.TabIndex = 2;
            this.gbVisitante.TabStop = false;
            this.gbVisitante.Text = "VISITANTE";
            // 
            // nudVisitante
            // 
            this.nudVisitante.BackColor = System.Drawing.SystemColors.MenuBar;
            this.nudVisitante.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nudVisitante.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudVisitante.Location = new System.Drawing.Point(88, 75);
            this.nudVisitante.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudVisitante.Name = "nudVisitante";
            this.nudVisitante.Size = new System.Drawing.Size(48, 40);
            this.nudVisitante.TabIndex = 1;
            this.nudVisitante.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbVisitante
            // 
            this.cbVisitante.FormattingEnabled = true;
            this.cbVisitante.Location = new System.Drawing.Point(38, 31);
            this.cbVisitante.Name = "cbVisitante";
            this.cbVisitante.Size = new System.Drawing.Size(163, 21);
            this.cbVisitante.TabIndex = 0;
            this.cbVisitante.SelectedIndexChanged += new System.EventHandler(this.seleccion);
            // 
            // iconos
            // 
            this.iconos.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iconos.ImageStream")));
            this.iconos.TransparentColor = System.Drawing.Color.Transparent;
            this.iconos.Images.SetKeyName(0, "balon.png");
            this.iconos.Images.SetKeyName(1, "targeta_amarilla.png");
            this.iconos.Images.SetKeyName(2, "targeta_roja.png");
            this.iconos.Images.SetKeyName(3, "crono.png");
            // 
            // iconosGrandes
            // 
            this.iconosGrandes.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iconosGrandes.ImageStream")));
            this.iconosGrandes.TransparentColor = System.Drawing.Color.Transparent;
            this.iconosGrandes.Images.SetKeyName(0, "balon.png");
            this.iconosGrandes.Images.SetKeyName(1, "targeta_amarilla.png");
            this.iconosGrandes.Images.SetKeyName(2, "targeta_roja.png");
            this.iconosGrandes.Images.SetKeyName(3, "crono.png");
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(243, 290);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 56);
            this.button1.TabIndex = 3;
            this.button1.Text = "INICIAR PARTIDO";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.startMatch);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(473, 30);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 48);
            this.button2.TabIndex = 4;
            this.button2.Text = "REINICIAR PARTIDO";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.resetMatch);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 493);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gbVisitante);
            this.Controls.Add(this.gbLocal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.gbLocal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudLocal)).EndInit();
            this.gbVisitante.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudVisitante)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbLocal;
        private System.Windows.Forms.NumericUpDown nudLocal;
        private System.Windows.Forms.ComboBox cbLocal;
        private System.Windows.Forms.GroupBox gbVisitante;
        private System.Windows.Forms.NumericUpDown nudVisitante;
        private System.Windows.Forms.ComboBox cbVisitante;
        private System.Windows.Forms.ImageList iconos;
        private System.Windows.Forms.ImageList iconosGrandes;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

