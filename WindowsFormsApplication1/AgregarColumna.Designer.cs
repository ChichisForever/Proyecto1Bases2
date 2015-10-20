namespace WindowsFormsApplication1
{
    partial class AgregarColumna
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
            this.buttonMostrarDatosAgregarColumna = new System.Windows.Forms.Button();
            this.Tabla_AgregarColumna = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.GridAgregarColumna = new System.Windows.Forms.DataGridView();
            this.buttonAgregarColumna = new System.Windows.Forms.Button();
            this.TextBoxTipoColumnaAgregar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TextBoxColumnaAgregar = new System.Windows.Forms.TextBox();
            this.valor_actualizar = new System.Windows.Forms.Label();
            this.ComboAgregarColumna = new System.Windows.Forms.ComboBox();
            this.Escoger_Tabla_actualizar = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxTamanioAgregar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.GridAgregarColumna)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonMostrarDatosAgregarColumna
            // 
            this.buttonMostrarDatosAgregarColumna.Location = new System.Drawing.Point(629, 367);
            this.buttonMostrarDatosAgregarColumna.Name = "buttonMostrarDatosAgregarColumna";
            this.buttonMostrarDatosAgregarColumna.Size = new System.Drawing.Size(237, 23);
            this.buttonMostrarDatosAgregarColumna.TabIndex = 44;
            this.buttonMostrarDatosAgregarColumna.Text = "Mostrar datos actualizados";
            this.buttonMostrarDatosAgregarColumna.UseVisualStyleBackColor = true;
            this.buttonMostrarDatosAgregarColumna.Click += new System.EventHandler(this.MostrarDatosAgregarColumna_Click);
            // 
            // Tabla_AgregarColumna
            // 
            this.Tabla_AgregarColumna.AutoSize = true;
            this.Tabla_AgregarColumna.Location = new System.Drawing.Point(721, 60);
            this.Tabla_AgregarColumna.Name = "Tabla_AgregarColumna";
            this.Tabla_AgregarColumna.Size = new System.Drawing.Size(108, 13);
            this.Tabla_AgregarColumna.TabIndex = 43;
            this.Tabla_AgregarColumna.Text = "<Nombre de la tabla>";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(643, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 42;
            this.label3.Text = "Tabla:";
            // 
            // GridAgregarColumna
            // 
            this.GridAgregarColumna.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridAgregarColumna.Location = new System.Drawing.Point(503, 88);
            this.GridAgregarColumna.Name = "GridAgregarColumna";
            this.GridAgregarColumna.Size = new System.Drawing.Size(486, 256);
            this.GridAgregarColumna.TabIndex = 41;
            // 
            // buttonAgregarColumna
            // 
            this.buttonAgregarColumna.Location = new System.Drawing.Point(117, 358);
            this.buttonAgregarColumna.Name = "buttonAgregarColumna";
            this.buttonAgregarColumna.Size = new System.Drawing.Size(130, 23);
            this.buttonAgregarColumna.TabIndex = 40;
            this.buttonAgregarColumna.Text = "Agregar";
            this.buttonAgregarColumna.UseVisualStyleBackColor = true;
            this.buttonAgregarColumna.Click += new System.EventHandler(this.AgregarColumna_Click);
            // 
            // TextBoxTipoColumnaAgregar
            // 
            this.TextBoxTipoColumnaAgregar.Location = new System.Drawing.Point(261, 204);
            this.TextBoxTipoColumnaAgregar.Name = "TextBoxTipoColumnaAgregar";
            this.TextBoxTipoColumnaAgregar.Size = new System.Drawing.Size(150, 20);
            this.TextBoxTipoColumnaAgregar.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Ingrese el tipo de la columna:";
            // 
            // TextBoxColumnaAgregar
            // 
            this.TextBoxColumnaAgregar.Location = new System.Drawing.Point(261, 122);
            this.TextBoxColumnaAgregar.Name = "TextBoxColumnaAgregar";
            this.TextBoxColumnaAgregar.Size = new System.Drawing.Size(150, 20);
            this.TextBoxColumnaAgregar.TabIndex = 37;
            // 
            // valor_actualizar
            // 
            this.valor_actualizar.AutoSize = true;
            this.valor_actualizar.Location = new System.Drawing.Point(36, 122);
            this.valor_actualizar.Name = "valor_actualizar";
            this.valor_actualizar.Size = new System.Drawing.Size(211, 13);
            this.valor_actualizar.TabIndex = 36;
            this.valor_actualizar.Text = "Ingrese el nombre de la columna a agregar:";
            // 
            // ComboAgregarColumna
            // 
            this.ComboAgregarColumna.FormattingEnabled = true;
            this.ComboAgregarColumna.Location = new System.Drawing.Point(290, 63);
            this.ComboAgregarColumna.Name = "ComboAgregarColumna";
            this.ComboAgregarColumna.Size = new System.Drawing.Size(121, 21);
            this.ComboAgregarColumna.TabIndex = 35;
            this.ComboAgregarColumna.SelectedIndexChanged += new System.EventHandler(this.comboAgregarColumna_SelectedIndexChanged);
            // 
            // Escoger_Tabla_actualizar
            // 
            this.Escoger_Tabla_actualizar.AutoSize = true;
            this.Escoger_Tabla_actualizar.Location = new System.Drawing.Point(36, 63);
            this.Escoger_Tabla_actualizar.Name = "Escoger_Tabla_actualizar";
            this.Escoger_Tabla_actualizar.Size = new System.Drawing.Size(100, 13);
            this.Escoger_Tabla_actualizar.TabIndex = 34;
            this.Escoger_Tabla_actualizar.Text = "Escoga una Tabla: ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(413, 24);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(111, 13);
            this.label13.TabIndex = 33;
            this.label13.Text = "Agregar una columna ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 45;
            this.label2.Text = "Ingrese el tamaño :";
            // 
            // textBoxTamanioAgregar
            // 
            this.textBoxTamanioAgregar.Location = new System.Drawing.Point(261, 255);
            this.textBoxTamanioAgregar.Name = "textBoxTamanioAgregar";
            this.textBoxTamanioAgregar.Size = new System.Drawing.Size(150, 20);
            this.textBoxTamanioAgregar.TabIndex = 46;
            // 
            // AgregarColumna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 456);
            this.Controls.Add(this.textBoxTamanioAgregar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonMostrarDatosAgregarColumna);
            this.Controls.Add(this.Tabla_AgregarColumna);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.GridAgregarColumna);
            this.Controls.Add(this.buttonAgregarColumna);
            this.Controls.Add(this.TextBoxTipoColumnaAgregar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBoxColumnaAgregar);
            this.Controls.Add(this.valor_actualizar);
            this.Controls.Add(this.ComboAgregarColumna);
            this.Controls.Add(this.Escoger_Tabla_actualizar);
            this.Controls.Add(this.label13);
            this.Name = "AgregarColumna";
            this.Text = "AgregarColumna";
            ((System.ComponentModel.ISupportInitialize)(this.GridAgregarColumna)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonMostrarDatosAgregarColumna;
        private System.Windows.Forms.Label Tabla_AgregarColumna;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView GridAgregarColumna;
        private System.Windows.Forms.Button buttonAgregarColumna;
        private System.Windows.Forms.TextBox TextBoxTipoColumnaAgregar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBoxColumnaAgregar;
        private System.Windows.Forms.Label valor_actualizar;
        private System.Windows.Forms.ComboBox ComboAgregarColumna;
        private System.Windows.Forms.Label Escoger_Tabla_actualizar;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxTamanioAgregar;
    }
}