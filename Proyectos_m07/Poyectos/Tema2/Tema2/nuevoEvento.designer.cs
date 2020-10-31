namespace Tema2
{
    partial class nuevoEvento
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
            this.pbIcono = new System.Windows.Forms.PictureBox();
            this.btAnterior = new System.Windows.Forms.Button();
            this.btSiguiente = new System.Windows.Forms.Button();
            this.tbMinuto = new System.Windows.Forms.TextBox();
            this.tbDesc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btAceptar = new System.Windows.Forms.Button();
            this.pbfondo = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.colorSelec = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbfondo)).BeginInit();
            this.SuspendLayout();
            // 
            // pbIcono
            // 
            this.pbIcono.Location = new System.Drawing.Point(27, 37);
            this.pbIcono.Name = "pbIcono";
            this.pbIcono.Size = new System.Drawing.Size(100, 100);
            this.pbIcono.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbIcono.TabIndex = 0;
            this.pbIcono.TabStop = false;
            // 
            // btAnterior
            // 
            this.btAnterior.Location = new System.Drawing.Point(43, 143);
            this.btAnterior.Name = "btAnterior";
            this.btAnterior.Size = new System.Drawing.Size(26, 26);
            this.btAnterior.TabIndex = 1;
            this.btAnterior.Text = "<";
            this.btAnterior.UseVisualStyleBackColor = true;
            this.btAnterior.Click += new System.EventHandler(this.btAnterior_Click);
            // 
            // btSiguiente
            // 
            this.btSiguiente.Location = new System.Drawing.Point(75, 143);
            this.btSiguiente.Name = "btSiguiente";
            this.btSiguiente.Size = new System.Drawing.Size(26, 26);
            this.btSiguiente.TabIndex = 2;
            this.btSiguiente.Text = ">";
            this.btSiguiente.UseVisualStyleBackColor = true;
            this.btSiguiente.Click += new System.EventHandler(this.btSiguiente_Click);
            // 
            // tbMinuto
            // 
            this.tbMinuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMinuto.Location = new System.Drawing.Point(146, 54);
            this.tbMinuto.Name = "tbMinuto";
            this.tbMinuto.Size = new System.Drawing.Size(99, 23);
            this.tbMinuto.TabIndex = 3;
            // 
            // tbDesc
            // 
            this.tbDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDesc.Location = new System.Drawing.Point(146, 114);
            this.tbDesc.Name = "tbDesc";
            this.tbDesc.Size = new System.Drawing.Size(333, 23);
            this.tbDesc.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(143, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Minuto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(143, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Descripción";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(53, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tipo";
            // 
            // btAceptar
            // 
            this.btAceptar.Location = new System.Drawing.Point(209, 157);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(75, 23);
            this.btAceptar.TabIndex = 8;
            this.btAceptar.Text = "Aceptar";
            this.btAceptar.UseVisualStyleBackColor = true;
            this.btAceptar.Click += new System.EventHandler(this.btAceptar_Click);
            // 
            // pbfondo
            // 
            this.pbfondo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbfondo.Location = new System.Drawing.Point(371, 45);
            this.pbfondo.Name = "pbfondo";
            this.pbfondo.Size = new System.Drawing.Size(32, 32);
            this.pbfondo.TabIndex = 9;
            this.pbfondo.TabStop = false;
            this.pbfondo.Click += new System.EventHandler(this.pbfondo_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(317, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Fondo";
            // 
            // colorSelec
            // 
            this.colorSelec.Color = System.Drawing.Color.White;
            // 
            // nuevoEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 227);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pbfondo);
            this.Controls.Add(this.btAceptar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbDesc);
            this.Controls.Add(this.tbMinuto);
            this.Controls.Add(this.btSiguiente);
            this.Controls.Add(this.btAnterior);
            this.Controls.Add(this.pbIcono);
            this.Name = "nuevoEvento";
            this.Text = "nuevoEvento";
            this.Shown += new System.EventHandler(this.nuevoEvento_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pbIcono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbfondo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbIcono;
        private System.Windows.Forms.Button btAnterior;
        private System.Windows.Forms.Button btSiguiente;
        private System.Windows.Forms.TextBox tbMinuto;
        private System.Windows.Forms.TextBox tbDesc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btAceptar;
        private System.Windows.Forms.PictureBox pbfondo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ColorDialog colorSelec;
    }
}