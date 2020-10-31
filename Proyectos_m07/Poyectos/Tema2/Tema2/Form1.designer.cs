namespace Tema2
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
            this.lvEventos = new System.Windows.Forms.ListView();
            this.icono = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Minuto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Descripcion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.iconos = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.partidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuInicio = new System.Windows.Forms.ToolStripMenuItem();
            this.limpiarDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMarcador = new System.Windows.Forms.ToolStripMenuItem();
            this.golLocalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.golVisitanteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEventos = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.limpiarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolLocal = new System.Windows.Forms.ToolStripLabel();
            this.toolVisitante = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.iconosGrandes = new System.Windows.Forms.ImageList(this.components);
            this.toolInicio = new System.Windows.Forms.ToolStripButton();
            this.toolGol = new System.Windows.Forms.ToolStripButton();
            this.toolAmarilla = new System.Windows.Forms.ToolStripButton();
            this.toolRoja = new System.Windows.Forms.ToolStripButton();
            this.toolTiempo = new System.Windows.Forms.ToolStripButton();
            this.gbLocal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLocal)).BeginInit();
            this.gbVisitante.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudVisitante)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
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
            // lvEventos
            // 
            this.lvEventos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.icono,
            this.Minuto,
            this.Descripcion});
            this.lvEventos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvEventos.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvEventos.Location = new System.Drawing.Point(61, 284);
            this.lvEventos.Name = "lvEventos";
            this.lvEventos.Size = new System.Drawing.Size(495, 176);
            this.lvEventos.SmallImageList = this.iconos;
            this.lvEventos.TabIndex = 3;
            this.lvEventos.UseCompatibleStateImageBehavior = false;
            this.lvEventos.View = System.Windows.Forms.View.Details;
            // 
            // icono
            // 
            this.icono.Text = "";
            this.icono.Width = 44;
            // 
            // Minuto
            // 
            this.Minuto.Text = "Min.";
            this.Minuto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Minuto.Width = 61;
            // 
            // Descripcion
            // 
            this.Descripcion.Text = "Evento";
            this.Descripcion.Width = 367;
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
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.partidoToolStripMenuItem,
            this.menuMarcador,
            this.menuEventos});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(613, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // partidoToolStripMenuItem
            // 
            this.partidoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuInicio,
            this.limpiarDatosToolStripMenuItem});
            this.partidoToolStripMenuItem.Name = "partidoToolStripMenuItem";
            this.partidoToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.partidoToolStripMenuItem.Text = "&Partido";
            // 
            // menuInicio
            // 
            this.menuInicio.Image = global::Tema2.Properties.Resources.silbato;
            this.menuInicio.Name = "menuInicio";
            this.menuInicio.Size = new System.Drawing.Size(152, 22);
            this.menuInicio.Text = "&Inicio Partido";
            this.menuInicio.Click += new System.EventHandler(this.startMatch);
            // 
            // limpiarDatosToolStripMenuItem
            // 
            this.limpiarDatosToolStripMenuItem.Name = "limpiarDatosToolStripMenuItem";
            this.limpiarDatosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.limpiarDatosToolStripMenuItem.Text = "&Limpiar Datos";
            this.limpiarDatosToolStripMenuItem.Click += new System.EventHandler(this.resetMatch);
            // 
            // menuMarcador
            // 
            this.menuMarcador.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.golLocalToolStripMenuItem,
            this.golVisitanteToolStripMenuItem});
            this.menuMarcador.Name = "menuMarcador";
            this.menuMarcador.Size = new System.Drawing.Size(70, 20);
            this.menuMarcador.Text = "&Marcador";
            // 
            // golLocalToolStripMenuItem
            // 
            this.golLocalToolStripMenuItem.Name = "golLocalToolStripMenuItem";
            this.golLocalToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.golLocalToolStripMenuItem.Text = "Gol &Local";
            this.golLocalToolStripMenuItem.Click += new System.EventHandler(this.golL);
            // 
            // golVisitanteToolStripMenuItem
            // 
            this.golVisitanteToolStripMenuItem.Name = "golVisitanteToolStripMenuItem";
            this.golVisitanteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.golVisitanteToolStripMenuItem.Text = "Gol &Visitante";
            this.golVisitanteToolStripMenuItem.Click += new System.EventHandler(this.golV);
            // 
            // menuEventos
            // 
            this.menuEventos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.limpiarToolStripMenuItem});
            this.menuEventos.Name = "menuEventos";
            this.menuEventos.Size = new System.Drawing.Size(60, 20);
            this.menuEventos.Text = "Eventos";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.nuevoToolStripMenuItem.Text = "&Nuevo...";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.newEvent);
            // 
            // limpiarToolStripMenuItem
            // 
            this.limpiarToolStripMenuItem.Name = "limpiarToolStripMenuItem";
            this.limpiarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.limpiarToolStripMenuItem.Text = "&Limpiar";
            this.limpiarToolStripMenuItem.Click += new System.EventHandler(this.clearEvents);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolInicio,
            this.toolStripSeparator1,
            this.toolLocal,
            this.toolVisitante,
            this.toolStripSeparator2,
            this.toolGol,
            this.toolAmarilla,
            this.toolRoja,
            this.toolTiempo});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(613, 25);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolLocal
            // 
            this.toolLocal.Name = "toolLocal";
            this.toolLocal.Size = new System.Drawing.Size(21, 22);
            this.toolLocal.Text = "GL";
            this.toolLocal.Click += new System.EventHandler(this.golL);
            // 
            // toolVisitante
            // 
            this.toolVisitante.Name = "toolVisitante";
            this.toolVisitante.Size = new System.Drawing.Size(22, 22);
            this.toolVisitante.Text = "GV";
            this.toolVisitante.Click += new System.EventHandler(this.golV);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
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
            // toolInicio
            // 
            this.toolInicio.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolInicio.Image = global::Tema2.Properties.Resources.silbato;
            this.toolInicio.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolInicio.Name = "toolInicio";
            this.toolInicio.Size = new System.Drawing.Size(23, 22);
            this.toolInicio.Text = "toolStripButton1";
            this.toolInicio.Click += new System.EventHandler(this.startMatch);
            // 
            // toolGol
            // 
            this.toolGol.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolGol.Image = global::Tema2.Properties.Resources.balon;
            this.toolGol.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolGol.Name = "toolGol";
            this.toolGol.Size = new System.Drawing.Size(23, 22);
            this.toolGol.Text = "toolStripButton3";
            this.toolGol.Click += new System.EventHandler(this.toolGol_Click);
            // 
            // toolAmarilla
            // 
            this.toolAmarilla.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolAmarilla.Image = global::Tema2.Properties.Resources.targeta_amarilla;
            this.toolAmarilla.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolAmarilla.Name = "toolAmarilla";
            this.toolAmarilla.Size = new System.Drawing.Size(23, 22);
            this.toolAmarilla.Text = "toolStripButton4";
            this.toolAmarilla.Click += new System.EventHandler(this.toolAmarilla_Click);
            // 
            // toolRoja
            // 
            this.toolRoja.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolRoja.Image = global::Tema2.Properties.Resources.targeta_roja;
            this.toolRoja.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolRoja.Name = "toolRoja";
            this.toolRoja.Size = new System.Drawing.Size(23, 22);
            this.toolRoja.Text = "toolStripButton5";
            this.toolRoja.Click += new System.EventHandler(this.toolRoja_Click);
            // 
            // toolTiempo
            // 
            this.toolTiempo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolTiempo.Image = global::Tema2.Properties.Resources.crono;
            this.toolTiempo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolTiempo.Name = "toolTiempo";
            this.toolTiempo.Size = new System.Drawing.Size(23, 22);
            this.toolTiempo.Text = "toolStripButton6";
            this.toolTiempo.Click += new System.EventHandler(this.toolTiempo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 493);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.lvEventos);
            this.Controls.Add(this.gbVisitante);
            this.Controls.Add(this.gbLocal);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.gbLocal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudLocal)).EndInit();
            this.gbVisitante.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudVisitante)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbLocal;
        private System.Windows.Forms.NumericUpDown nudLocal;
        private System.Windows.Forms.ComboBox cbLocal;
        private System.Windows.Forms.GroupBox gbVisitante;
        private System.Windows.Forms.NumericUpDown nudVisitante;
        private System.Windows.Forms.ComboBox cbVisitante;
        private System.Windows.Forms.ListView lvEventos;
        private System.Windows.Forms.ColumnHeader Minuto;
        private System.Windows.Forms.ColumnHeader Descripcion;
        private System.Windows.Forms.ImageList iconos;
        private System.Windows.Forms.ColumnHeader icono;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem partidoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem limpiarDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuMarcador;
        private System.Windows.Forms.ToolStripMenuItem golLocalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem golVisitanteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuEventos;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem limpiarToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ImageList iconosGrandes;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolGol;
        private System.Windows.Forms.ToolStripButton toolAmarilla;
        private System.Windows.Forms.ToolStripButton toolRoja;
        private System.Windows.Forms.ToolStripButton toolTiempo;
        private System.Windows.Forms.ToolStripLabel toolLocal;
        private System.Windows.Forms.ToolStripLabel toolVisitante;
        private System.Windows.Forms.ToolStripMenuItem menuInicio;
        private System.Windows.Forms.ToolStripButton toolInicio;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}

