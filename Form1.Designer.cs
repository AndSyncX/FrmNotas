namespace FrmNotas
{
    partial class FrmNotas
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNota1 = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.lstNota1 = new System.Windows.Forms.ListBox();
            this.txtPromedioGeneral = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNota2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNota3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lstNota2 = new System.Windows.Forms.ListBox();
            this.lstNota3 = new System.Windows.Forms.ListBox();
            this.lstPromedio = new System.Windows.Forms.ListBox();
            this.txtAlumno = new System.Windows.Forms.TextBox();
            this.lstAlumno = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(406, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Formulario de Notas";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(17, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Alumnos:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(141, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nota1";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNota1
            // 
            this.txtNota1.Location = new System.Drawing.Point(141, 105);
            this.txtNota1.Name = "txtNota1";
            this.txtNota1.Size = new System.Drawing.Size(65, 20);
            this.txtNota1.TabIndex = 4;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(17, 232);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(402, 30);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(17, 268);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(402, 30);
            this.btnNuevo.TabIndex = 5;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.Location = new System.Drawing.Point(17, 304);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(402, 30);
            this.btnQuitar.TabIndex = 6;
            this.btnQuitar.Text = "Quitar";
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // lstNota1
            // 
            this.lstNota1.FormattingEnabled = true;
            this.lstNota1.Location = new System.Drawing.Point(141, 131);
            this.lstNota1.Name = "lstNota1";
            this.lstNota1.Size = new System.Drawing.Size(65, 95);
            this.lstNota1.TabIndex = 8;
            this.lstNota1.SelectedIndexChanged += new System.EventHandler(this.lstNota1_SelectedIndexChanged);
            // 
            // txtPromedioGeneral
            // 
            this.txtPromedioGeneral.Location = new System.Drawing.Point(319, 349);
            this.txtPromedioGeneral.Name = "txtPromedioGeneral";
            this.txtPromedioGeneral.Size = new System.Drawing.Size(100, 20);
            this.txtPromedioGeneral.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 349);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Promedio del Aula";
            // 
            // txtNota2
            // 
            this.txtNota2.Location = new System.Drawing.Point(212, 105);
            this.txtNota2.Name = "txtNota2";
            this.txtNota2.Size = new System.Drawing.Size(65, 20);
            this.txtNota2.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(212, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 23);
            this.label5.TabIndex = 12;
            this.label5.Text = "Nota2";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNota3
            // 
            this.txtNota3.Location = new System.Drawing.Point(283, 105);
            this.txtNota3.Name = "txtNota3";
            this.txtNota3.Size = new System.Drawing.Size(65, 20);
            this.txtNota3.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(283, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 23);
            this.label6.TabIndex = 14;
            this.label6.Text = "Nota3";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(354, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 23);
            this.label7.TabIndex = 16;
            this.label7.Text = "Promedio";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lstNota2
            // 
            this.lstNota2.FormattingEnabled = true;
            this.lstNota2.Location = new System.Drawing.Point(212, 131);
            this.lstNota2.Name = "lstNota2";
            this.lstNota2.Size = new System.Drawing.Size(65, 95);
            this.lstNota2.TabIndex = 18;
            this.lstNota2.SelectedIndexChanged += new System.EventHandler(this.lstNota2_SelectedIndexChanged);
            // 
            // lstNota3
            // 
            this.lstNota3.FormattingEnabled = true;
            this.lstNota3.Location = new System.Drawing.Point(283, 131);
            this.lstNota3.Name = "lstNota3";
            this.lstNota3.Size = new System.Drawing.Size(65, 95);
            this.lstNota3.TabIndex = 19;
            this.lstNota3.SelectedIndexChanged += new System.EventHandler(this.lstNota3_SelectedIndexChanged);
            // 
            // lstPromedio
            // 
            this.lstPromedio.FormattingEnabled = true;
            this.lstPromedio.Location = new System.Drawing.Point(354, 131);
            this.lstPromedio.Name = "lstPromedio";
            this.lstPromedio.Size = new System.Drawing.Size(65, 95);
            this.lstPromedio.TabIndex = 20;
            this.lstPromedio.SelectedIndexChanged += new System.EventHandler(this.lstPromedio_SelectedIndexChanged);
            // 
            // txtAlumno
            // 
            this.txtAlumno.Location = new System.Drawing.Point(17, 105);
            this.txtAlumno.Name = "txtAlumno";
            this.txtAlumno.Size = new System.Drawing.Size(118, 20);
            this.txtAlumno.TabIndex = 21;
            // 
            // lstAlumno
            // 
            this.lstAlumno.FormattingEnabled = true;
            this.lstAlumno.Location = new System.Drawing.Point(17, 131);
            this.lstAlumno.Name = "lstAlumno";
            this.lstAlumno.Size = new System.Drawing.Size(118, 95);
            this.lstAlumno.TabIndex = 22;
            this.lstAlumno.SelectedIndexChanged += new System.EventHandler(this.lstAlumno_SelectedIndexChanged);
            // 
            // FrmNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 381);
            this.Controls.Add(this.lstAlumno);
            this.Controls.Add(this.txtAlumno);
            this.Controls.Add(this.lstPromedio);
            this.Controls.Add(this.lstNota3);
            this.Controls.Add(this.lstNota2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNota3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNota2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPromedioGeneral);
            this.Controls.Add(this.lstNota1);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtNota1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmNotas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario de Notas";
            this.Load += new System.EventHandler(this.FrmNotas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNota1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.ListBox lstNota1;
        private System.Windows.Forms.TextBox txtPromedioGeneral;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNota2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNota3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox lstNota2;
        private System.Windows.Forms.ListBox lstNota3;
        private System.Windows.Forms.ListBox lstPromedio;
        private System.Windows.Forms.TextBox txtAlumno;
        private System.Windows.Forms.ListBox lstAlumno;
    }
}

