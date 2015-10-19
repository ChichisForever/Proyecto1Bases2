namespace WindowsFormsApplication1
{
    partial class EliminarColumna
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
            this.comboColumnaEliminar = new System.Windows.Forms.ComboBox();
            this.buttonMostrarDatosEliminarColumna = new System.Windows.Forms.Button();
            this.Tabla_EliminarColumna = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.GridEliminarColumna = new System.Windows.Forms.DataGridView();
            this.buttonEliminarColumna = new System.Windows.Forms.Button();
            this.valor_actualizar = new System.Windows.Forms.Label();
            this.ComboEliminarColumna = new System.Windows.Forms.ComboBox();
            this.Escoger_Tabla_actualizar = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GridEliminarColumna)).BeginInit();
            this.SuspendLayout();
            // 
            // comboColumnaEliminar
            // 
            this.comboColumnaEliminar.FormattingEnabled = true;
            this.comboColumnaEliminar.Location = new System.Drawing.Point(236, 120);
            this.comboColumnaEliminar.Name = "comboColumnaEliminar";
            this.comboColumnaEliminar.Size = new System.Drawing.Size(121, 21);
            this.comboColumnaEliminar.TabIndex = 55;
            // 
            // buttonMostrarDatosEliminarColumna
            // 
            this.buttonMostrarDatosEliminarColumna.Location = new System.Drawing.Point(628, 358);
            this.buttonMostrarDatosEliminarColumna.Name = "buttonMostrarDatosEliminarColumna";
            this.buttonMostrarDatosEliminarColumna.Size = new System.Drawing.Size(237, 23);
            this.buttonMostrarDatosEliminarColumna.TabIndex = 54;
            this.buttonMostrarDatosEliminarColumna.Text = "Mostrar datos actualizados";
            this.buttonMostrarDatosEliminarColumna.UseVisualStyleBackColor = true;
            this.buttonMostrarDatosEliminarColumna.Click += new System.EventHandler(this.MostrarDatosEliminarColumna_Click);
            // 
            // Tabla_EliminarColumna
            // 
            this.Tabla_EliminarColumna.AutoSize = true;
            this.Tabla_EliminarColumna.Location = new System.Drawing.Point(718, 52);
            this.Tabla_EliminarColumna.Name = "Tabla_EliminarColumna";
            this.Tabla_EliminarColumna.Size = new System.Drawing.Size(108, 13);
            this.Tabla_EliminarColumna.TabIndex = 53;
            this.Tabla_EliminarColumna.Text = "<Nombre de la tabla>";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(625, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 52;
            this.label3.Text = "Tabla:";
            // 
            // GridEliminarColumna
            // 
            this.GridEliminarColumna.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridEliminarColumna.Location = new System.Drawing.Point(543, 77);
            this.GridEliminarColumna.Name = "GridEliminarColumna";
            this.GridEliminarColumna.Size = new System.Drawing.Size(417, 256);
            this.GridEliminarColumna.TabIndex = 51;
            // 
            // buttonEliminarColumna
            // 
            this.buttonEliminarColumna.Location = new System.Drawing.Point(45, 346);
            this.buttonEliminarColumna.Name = "buttonEliminarColumna";
            this.buttonEliminarColumna.Size = new System.Drawing.Size(130, 23);
            this.buttonEliminarColumna.TabIndex = 50;
            this.buttonEliminarColumna.Text = "Eliminar";
            this.buttonEliminarColumna.UseVisualStyleBackColor = true;
            this.buttonEliminarColumna.Click += new System.EventHandler(this.EliminarColumna_Click);
            // 
            // valor_actualizar
            // 
            this.valor_actualizar.AutoSize = true;
            this.valor_actualizar.Location = new System.Drawing.Point(32, 123);
            this.valor_actualizar.Name = "valor_actualizar";
            this.valor_actualizar.Size = new System.Drawing.Size(143, 13);
            this.valor_actualizar.TabIndex = 49;
            this.valor_actualizar.Text = "Escoja la columna a eliminar:";
            // 
            // ComboEliminarColumna
            // 
            this.ComboEliminarColumna.FormattingEnabled = true;
            this.ComboEliminarColumna.Location = new System.Drawing.Point(236, 64);
            this.ComboEliminarColumna.Name = "ComboEliminarColumna";
            this.ComboEliminarColumna.Size = new System.Drawing.Size(121, 21);
            this.ComboEliminarColumna.TabIndex = 48;
            this.ComboEliminarColumna.SelectedIndexChanged += new System.EventHandler(this.comboEliminarColumna_SelectedIndexChanged);
            // 
            // Escoger_Tabla_actualizar
            // 
            this.Escoger_Tabla_actualizar.AutoSize = true;
            this.Escoger_Tabla_actualizar.Location = new System.Drawing.Point(32, 61);
            this.Escoger_Tabla_actualizar.Name = "Escoger_Tabla_actualizar";
            this.Escoger_Tabla_actualizar.Size = new System.Drawing.Size(100, 13);
            this.Escoger_Tabla_actualizar.TabIndex = 47;
            this.Escoger_Tabla_actualizar.Text = "Escoga una Tabla: ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(416, 21);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(107, 13);
            this.label13.TabIndex = 46;
            this.label13.Text = "Eliminar una columna";
            // 
            // EliminarColumna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 477);
            this.Controls.Add(this.comboColumnaEliminar);
            this.Controls.Add(this.buttonMostrarDatosEliminarColumna);
            this.Controls.Add(this.Tabla_EliminarColumna);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.GridEliminarColumna);
            this.Controls.Add(this.buttonEliminarColumna);
            this.Controls.Add(this.valor_actualizar);
            this.Controls.Add(this.ComboEliminarColumna);
            this.Controls.Add(this.Escoger_Tabla_actualizar);
            this.Controls.Add(this.label13);
            this.Name = "EliminarColumna";
            this.Text = "EliminarColumna";
            ((System.ComponentModel.ISupportInitialize)(this.GridEliminarColumna)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboColumnaEliminar;
        private System.Windows.Forms.Button buttonMostrarDatosEliminarColumna;
        private System.Windows.Forms.Label Tabla_EliminarColumna;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView GridEliminarColumna;
        private System.Windows.Forms.Button buttonEliminarColumna;
        private System.Windows.Forms.Label valor_actualizar;
        private System.Windows.Forms.ComboBox ComboEliminarColumna;
        private System.Windows.Forms.Label Escoger_Tabla_actualizar;
        private System.Windows.Forms.Label label13;
    }
}