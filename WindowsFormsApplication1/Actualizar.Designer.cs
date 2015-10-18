namespace WindowsFormsApplication1
{
    partial class Actualizar
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
            this.Combo_actualizar = new System.Windows.Forms.ComboBox();
            this.Escoger_Tabla_actualizar = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.buttonActualizar = new System.Windows.Forms.Button();
            this.TextBoxValorActualizar = new System.Windows.Forms.TextBox();
            this.valor_actualizar = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonDatosActualizados_Actualizar = new System.Windows.Forms.Button();
            this.GridActualizar = new System.Windows.Forms.DataGridView();
            this.Tabla_actualizar = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxColumnaActualizar = new System.Windows.Forms.ComboBox();
            this.comboBoxColumnaIDActualizar = new System.Windows.Forms.ComboBox();
            this.comboBoxIDActualizar = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.GridActualizar)).BeginInit();
            this.SuspendLayout();
            // 
            // Combo_actualizar
            // 
            this.Combo_actualizar.FormattingEnabled = true;
            this.Combo_actualizar.Location = new System.Drawing.Point(118, 46);
            this.Combo_actualizar.Name = "Combo_actualizar";
            this.Combo_actualizar.Size = new System.Drawing.Size(121, 21);
            this.Combo_actualizar.TabIndex = 17;
            this.Combo_actualizar.SelectedIndexChanged += new System.EventHandler(this.comboActualizar_SelectedIndexChanged);
            // 
            // Escoger_Tabla_actualizar
            // 
            this.Escoger_Tabla_actualizar.AutoSize = true;
            this.Escoger_Tabla_actualizar.Location = new System.Drawing.Point(13, 49);
            this.Escoger_Tabla_actualizar.Name = "Escoger_Tabla_actualizar";
            this.Escoger_Tabla_actualizar.Size = new System.Drawing.Size(100, 13);
            this.Escoger_Tabla_actualizar.TabIndex = 16;
            this.Escoger_Tabla_actualizar.Text = "Escoga una Tabla: ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(345, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(144, 13);
            this.label13.TabIndex = 18;
            this.label13.Text = "Actualizar datos de una tabla";
            // 
            // buttonActualizar
            // 
            this.buttonActualizar.Location = new System.Drawing.Point(58, 372);
            this.buttonActualizar.Name = "buttonActualizar";
            this.buttonActualizar.Size = new System.Drawing.Size(130, 23);
            this.buttonActualizar.TabIndex = 26;
            this.buttonActualizar.Text = "Actualizar";
            this.buttonActualizar.UseVisualStyleBackColor = true;
            this.buttonActualizar.Click += new System.EventHandler(this.Actualizar_Click);
            // 
            // TextBoxValorActualizar
            // 
            this.TextBoxValorActualizar.Location = new System.Drawing.Point(238, 105);
            this.TextBoxValorActualizar.Name = "TextBoxValorActualizar";
            this.TextBoxValorActualizar.Size = new System.Drawing.Size(150, 20);
            this.TextBoxValorActualizar.TabIndex = 23;
            // 
            // valor_actualizar
            // 
            this.valor_actualizar.AutoSize = true;
            this.valor_actualizar.Location = new System.Drawing.Point(13, 105);
            this.valor_actualizar.Name = "valor_actualizar";
            this.valor_actualizar.Size = new System.Drawing.Size(139, 13);
            this.valor_actualizar.TabIndex = 22;
            this.valor_actualizar.Text = "Ingrese el valor a actualizar:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(561, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Tabla:";
            // 
            // buttonDatosActualizados_Actualizar
            // 
            this.buttonDatosActualizados_Actualizar.Location = new System.Drawing.Point(523, 372);
            this.buttonDatosActualizados_Actualizar.Name = "buttonDatosActualizados_Actualizar";
            this.buttonDatosActualizados_Actualizar.Size = new System.Drawing.Size(237, 23);
            this.buttonDatosActualizados_Actualizar.TabIndex = 28;
            this.buttonDatosActualizados_Actualizar.Text = "Mostrar datos actualizados";
            this.buttonDatosActualizados_Actualizar.UseVisualStyleBackColor = true;
            this.buttonDatosActualizados_Actualizar.Click += new System.EventHandler(this.MostrarDatosActualizar_Click);
            // 
            // GridActualizar
            // 
            this.GridActualizar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridActualizar.Location = new System.Drawing.Point(483, 80);
            this.GridActualizar.Name = "GridActualizar";
            this.GridActualizar.Size = new System.Drawing.Size(356, 252);
            this.GridActualizar.TabIndex = 27;
            // 
            // Tabla_actualizar
            // 
            this.Tabla_actualizar.AutoSize = true;
            this.Tabla_actualizar.Location = new System.Drawing.Point(627, 49);
            this.Tabla_actualizar.Name = "Tabla_actualizar";
            this.Tabla_actualizar.Size = new System.Drawing.Size(108, 13);
            this.Tabla_actualizar.TabIndex = 30;
            this.Tabla_actualizar.Text = "<Nombre de la tabla>";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "Escoja el nombre de la columna a actualizar:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 269);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "Escoja el  ID a actualizar:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "Escoja el nombre de la columna del ID:";
            // 
            // comboBoxColumnaActualizar
            // 
            this.comboBoxColumnaActualizar.FormattingEnabled = true;
            this.comboBoxColumnaActualizar.Location = new System.Drawing.Point(250, 153);
            this.comboBoxColumnaActualizar.Name = "comboBoxColumnaActualizar";
            this.comboBoxColumnaActualizar.Size = new System.Drawing.Size(121, 21);
            this.comboBoxColumnaActualizar.TabIndex = 40;
            // 
            // comboBoxColumnaIDActualizar
            // 
            this.comboBoxColumnaIDActualizar.FormattingEnabled = true;
            this.comboBoxColumnaIDActualizar.Location = new System.Drawing.Point(250, 203);
            this.comboBoxColumnaIDActualizar.Name = "comboBoxColumnaIDActualizar";
            this.comboBoxColumnaIDActualizar.Size = new System.Drawing.Size(121, 21);
            this.comboBoxColumnaIDActualizar.TabIndex = 41;
            // 
            // comboBoxIDActualizar
            // 
            this.comboBoxIDActualizar.FormattingEnabled = true;
            this.comboBoxIDActualizar.Location = new System.Drawing.Point(250, 269);
            this.comboBoxIDActualizar.Name = "comboBoxIDActualizar";
            this.comboBoxIDActualizar.Size = new System.Drawing.Size(121, 21);
            this.comboBoxIDActualizar.TabIndex = 42;
            // 
            // Actualizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 448);
            this.Controls.Add(this.comboBoxIDActualizar);
            this.Controls.Add(this.comboBoxColumnaIDActualizar);
            this.Controls.Add(this.comboBoxColumnaActualizar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Tabla_actualizar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonDatosActualizados_Actualizar);
            this.Controls.Add(this.GridActualizar);
            this.Controls.Add(this.buttonActualizar);
            this.Controls.Add(this.TextBoxValorActualizar);
            this.Controls.Add(this.valor_actualizar);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.Combo_actualizar);
            this.Controls.Add(this.Escoger_Tabla_actualizar);
            this.Name = "Actualizar";
            this.Text = "Actualizar";
            ((System.ComponentModel.ISupportInitialize)(this.GridActualizar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Combo_actualizar;
        private System.Windows.Forms.Label Escoger_Tabla_actualizar;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button buttonActualizar;
        private System.Windows.Forms.TextBox TextBoxValorActualizar;
        private System.Windows.Forms.Label valor_actualizar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonDatosActualizados_Actualizar;
        private System.Windows.Forms.DataGridView GridActualizar;
        private System.Windows.Forms.Label Tabla_actualizar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxColumnaActualizar;
        private System.Windows.Forms.ComboBox comboBoxColumnaIDActualizar;
        private System.Windows.Forms.ComboBox comboBoxIDActualizar;
    }
}