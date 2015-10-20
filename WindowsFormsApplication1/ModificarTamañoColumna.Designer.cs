namespace WindowsFormsApplication1
{
    partial class ModificarTamañoColumna
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
            this.textBoxTamanioModificar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxTipoModificar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboColumnaModificar = new System.Windows.Forms.ComboBox();
            this.buttonMostrarDatosModificarTamaño = new System.Windows.Forms.Button();
            this.Tabla_ModificarTamaño = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.GridModificarColumna = new System.Windows.Forms.DataGridView();
            this.buttonModificarColumna = new System.Windows.Forms.Button();
            this.valor_actualizar = new System.Windows.Forms.Label();
            this.ComboModificarTamaño = new System.Windows.Forms.ComboBox();
            this.Escoger_Tabla_actualizar = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.GridTipoActualizado = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.GridModificarColumna)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridTipoActualizado)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxTamanioModificar
            // 
            this.textBoxTamanioModificar.Location = new System.Drawing.Point(226, 291);
            this.textBoxTamanioModificar.Name = "textBoxTamanioModificar";
            this.textBoxTamanioModificar.Size = new System.Drawing.Size(150, 20);
            this.textBoxTamanioModificar.TabIndex = 73;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 294);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 72;
            this.label2.Text = "Ingrese el tamaño:";
            // 
            // textBoxTipoModificar
            // 
            this.textBoxTipoModificar.Location = new System.Drawing.Point(226, 220);
            this.textBoxTipoModificar.Name = "textBoxTipoModificar";
            this.textBoxTipoModificar.Size = new System.Drawing.Size(150, 20);
            this.textBoxTipoModificar.TabIndex = 71;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 70;
            this.label1.Text = "Ingrese el  tipo de dato:";
            // 
            // comboColumnaModificar
            // 
            this.comboColumnaModificar.FormattingEnabled = true;
            this.comboColumnaModificar.Location = new System.Drawing.Point(255, 136);
            this.comboColumnaModificar.Name = "comboColumnaModificar";
            this.comboColumnaModificar.Size = new System.Drawing.Size(121, 21);
            this.comboColumnaModificar.TabIndex = 69;
            // 
            // buttonMostrarDatosModificarTamaño
            // 
            this.buttonMostrarDatosModificarTamaño.Location = new System.Drawing.Point(624, 397);
            this.buttonMostrarDatosModificarTamaño.Name = "buttonMostrarDatosModificarTamaño";
            this.buttonMostrarDatosModificarTamaño.Size = new System.Drawing.Size(237, 23);
            this.buttonMostrarDatosModificarTamaño.TabIndex = 68;
            this.buttonMostrarDatosModificarTamaño.Text = "Mostrar Tipo Actualizado";
            this.buttonMostrarDatosModificarTamaño.UseVisualStyleBackColor = true;
            this.buttonMostrarDatosModificarTamaño.Click += new System.EventHandler(this.MostrarDatosModificar_Click);
            // 
            // Tabla_ModificarTamaño
            // 
            this.Tabla_ModificarTamaño.AutoSize = true;
            this.Tabla_ModificarTamaño.Location = new System.Drawing.Point(691, 35);
            this.Tabla_ModificarTamaño.Name = "Tabla_ModificarTamaño";
            this.Tabla_ModificarTamaño.Size = new System.Drawing.Size(108, 13);
            this.Tabla_ModificarTamaño.TabIndex = 67;
            this.Tabla_ModificarTamaño.Text = "<Nombre de la tabla>";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(621, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 66;
            this.label3.Text = "Tabla:";
            // 
            // GridModificarColumna
            // 
            this.GridModificarColumna.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridModificarColumna.Location = new System.Drawing.Point(528, 58);
            this.GridModificarColumna.Name = "GridModificarColumna";
            this.GridModificarColumna.Size = new System.Drawing.Size(447, 192);
            this.GridModificarColumna.TabIndex = 65;
            // 
            // buttonModificarColumna
            // 
            this.buttonModificarColumna.Location = new System.Drawing.Point(135, 397);
            this.buttonModificarColumna.Name = "buttonModificarColumna";
            this.buttonModificarColumna.Size = new System.Drawing.Size(130, 23);
            this.buttonModificarColumna.TabIndex = 64;
            this.buttonModificarColumna.Text = "Modificar";
            this.buttonModificarColumna.UseVisualStyleBackColor = true;
            this.buttonModificarColumna.Click += new System.EventHandler(this.ModificarColumna_Click);
            // 
            // valor_actualizar
            // 
            this.valor_actualizar.AutoSize = true;
            this.valor_actualizar.Location = new System.Drawing.Point(33, 136);
            this.valor_actualizar.Name = "valor_actualizar";
            this.valor_actualizar.Size = new System.Drawing.Size(150, 13);
            this.valor_actualizar.TabIndex = 63;
            this.valor_actualizar.Text = "Escoja la columna a modificar:";
            // 
            // ComboModificarTamaño
            // 
            this.ComboModificarTamaño.FormattingEnabled = true;
            this.ComboModificarTamaño.Location = new System.Drawing.Point(255, 74);
            this.ComboModificarTamaño.Name = "ComboModificarTamaño";
            this.ComboModificarTamaño.Size = new System.Drawing.Size(121, 21);
            this.ComboModificarTamaño.TabIndex = 62;
            this.ComboModificarTamaño.SelectedIndexChanged += new System.EventHandler(this.comboModificarTamanio_SelectedIndexChanged);
            // 
            // Escoger_Tabla_actualizar
            // 
            this.Escoger_Tabla_actualizar.AutoSize = true;
            this.Escoger_Tabla_actualizar.Location = new System.Drawing.Point(33, 74);
            this.Escoger_Tabla_actualizar.Name = "Escoger_Tabla_actualizar";
            this.Escoger_Tabla_actualizar.Size = new System.Drawing.Size(100, 13);
            this.Escoger_Tabla_actualizar.TabIndex = 61;
            this.Escoger_Tabla_actualizar.Text = "Escoga una Tabla: ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(394, 19);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(167, 13);
            this.label13.TabIndex = 60;
            this.label13.Text = "Modificar tamaño de una columna";
            // 
            // GridTipoActualizado
            // 
            this.GridTipoActualizado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridTipoActualizado.Location = new System.Drawing.Point(545, 271);
            this.GridTipoActualizado.Name = "GridTipoActualizado";
            this.GridTipoActualizado.Size = new System.Drawing.Size(417, 110);
            this.GridTipoActualizado.TabIndex = 74;
            // 
            // ModificarTamañoColumna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 475);
            this.Controls.Add(this.GridTipoActualizado);
            this.Controls.Add(this.textBoxTamanioModificar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxTipoModificar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboColumnaModificar);
            this.Controls.Add(this.buttonMostrarDatosModificarTamaño);
            this.Controls.Add(this.Tabla_ModificarTamaño);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.GridModificarColumna);
            this.Controls.Add(this.buttonModificarColumna);
            this.Controls.Add(this.valor_actualizar);
            this.Controls.Add(this.ComboModificarTamaño);
            this.Controls.Add(this.Escoger_Tabla_actualizar);
            this.Controls.Add(this.label13);
            this.Name = "ModificarTamañoColumna";
            this.Text = "ModificarTamañoColumna";
            ((System.ComponentModel.ISupportInitialize)(this.GridModificarColumna)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridTipoActualizado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxTamanioModificar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxTipoModificar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboColumnaModificar;
        private System.Windows.Forms.Button buttonMostrarDatosModificarTamaño;
        private System.Windows.Forms.Label Tabla_ModificarTamaño;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView GridModificarColumna;
        private System.Windows.Forms.Button buttonModificarColumna;
        private System.Windows.Forms.Label valor_actualizar;
        private System.Windows.Forms.ComboBox ComboModificarTamaño;
        private System.Windows.Forms.Label Escoger_Tabla_actualizar;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView GridTipoActualizado;
    }
}