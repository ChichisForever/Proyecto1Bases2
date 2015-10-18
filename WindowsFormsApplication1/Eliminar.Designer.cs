namespace WindowsFormsApplication1
{
    partial class Eliminar
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
            this.Escoger_Tabla_eliminar = new System.Windows.Forms.Label();
            this.ComboEliminar = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.id_eliminar = new System.Windows.Forms.Label();
            this.TextBoxIDEliminar = new System.Windows.Forms.TextBox();
            this.GridEliminar = new System.Windows.Forms.DataGridView();
            this.Tabla_eliminar = new System.Windows.Forms.Label();
            this.ButtonDatos_actualizados_eliminar = new System.Windows.Forms.Button();
            this.ButtonBorrar = new System.Windows.Forms.Button();
            this.Nombre_tabla_eliminar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GridEliminar)).BeginInit();
            this.SuspendLayout();
            // 
            // Escoger_Tabla_eliminar
            // 
            this.Escoger_Tabla_eliminar.AutoSize = true;
            this.Escoger_Tabla_eliminar.Location = new System.Drawing.Point(12, 43);
            this.Escoger_Tabla_eliminar.Name = "Escoger_Tabla_eliminar";
            this.Escoger_Tabla_eliminar.Size = new System.Drawing.Size(100, 13);
            this.Escoger_Tabla_eliminar.TabIndex = 14;
            this.Escoger_Tabla_eliminar.Text = "Escoga una Tabla: ";
            // 
            // ComboEliminar
            // 
            this.ComboEliminar.FormattingEnabled = true;
            this.ComboEliminar.Location = new System.Drawing.Point(130, 40);
            this.ComboEliminar.Name = "ComboEliminar";
            this.ComboEliminar.Size = new System.Drawing.Size(121, 21);
            this.ComboEliminar.TabIndex = 15;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(354, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(134, 13);
            this.label13.TabIndex = 16;
            this.label13.Text = "Eliminar datos de una tabla";
            // 
            // id_eliminar
            // 
            this.id_eliminar.AutoSize = true;
            this.id_eliminar.Location = new System.Drawing.Point(12, 142);
            this.id_eliminar.Name = "id_eliminar";
            this.id_eliminar.Size = new System.Drawing.Size(202, 13);
            this.id_eliminar.TabIndex = 17;
            this.id_eliminar.Text = "Ingrese el ID del dato que desea eliminar:";
            // 
            // TextBoxIDEliminar
            // 
            this.TextBoxIDEliminar.Location = new System.Drawing.Point(220, 139);
            this.TextBoxIDEliminar.Name = "TextBoxIDEliminar";
            this.TextBoxIDEliminar.Size = new System.Drawing.Size(97, 20);
            this.TextBoxIDEliminar.TabIndex = 18;
            // 
            // GridEliminar
            // 
            this.GridEliminar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridEliminar.Location = new System.Drawing.Point(357, 75);
            this.GridEliminar.Name = "GridEliminar";
            this.GridEliminar.Size = new System.Drawing.Size(493, 246);
            this.GridEliminar.TabIndex = 19;
            // 
            // Tabla_eliminar
            // 
            this.Tabla_eliminar.AutoSize = true;
            this.Tabla_eliminar.Location = new System.Drawing.Point(530, 48);
            this.Tabla_eliminar.Name = "Tabla_eliminar";
            this.Tabla_eliminar.Size = new System.Drawing.Size(37, 13);
            this.Tabla_eliminar.TabIndex = 20;
            this.Tabla_eliminar.Text = "Tabla:";
            // 
            // ButtonDatos_actualizados_eliminar
            // 
            this.ButtonDatos_actualizados_eliminar.Location = new System.Drawing.Point(546, 348);
            this.ButtonDatos_actualizados_eliminar.Name = "ButtonDatos_actualizados_eliminar";
            this.ButtonDatos_actualizados_eliminar.Size = new System.Drawing.Size(158, 23);
            this.ButtonDatos_actualizados_eliminar.TabIndex = 21;
            this.ButtonDatos_actualizados_eliminar.Text = "Mostrar datos actualizados";
            this.ButtonDatos_actualizados_eliminar.UseVisualStyleBackColor = true;
            // 
            // ButtonBorrar
            // 
            this.ButtonBorrar.Location = new System.Drawing.Point(74, 348);
            this.ButtonBorrar.Name = "ButtonBorrar";
            this.ButtonBorrar.Size = new System.Drawing.Size(130, 23);
            this.ButtonBorrar.TabIndex = 22;
            this.ButtonBorrar.Text = "Borrar";
            this.ButtonBorrar.UseVisualStyleBackColor = true;
            // 
            // Nombre_tabla_eliminar
            // 
            this.Nombre_tabla_eliminar.AutoSize = true;
            this.Nombre_tabla_eliminar.Location = new System.Drawing.Point(608, 48);
            this.Nombre_tabla_eliminar.Name = "Nombre_tabla_eliminar";
            this.Nombre_tabla_eliminar.Size = new System.Drawing.Size(108, 13);
            this.Nombre_tabla_eliminar.TabIndex = 31;
            this.Nombre_tabla_eliminar.Text = "<Nombre de la tabla>";
            // 
            // Eliminar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 428);
            this.Controls.Add(this.Nombre_tabla_eliminar);
            this.Controls.Add(this.ButtonBorrar);
            this.Controls.Add(this.ButtonDatos_actualizados_eliminar);
            this.Controls.Add(this.Tabla_eliminar);
            this.Controls.Add(this.GridEliminar);
            this.Controls.Add(this.TextBoxIDEliminar);
            this.Controls.Add(this.id_eliminar);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.ComboEliminar);
            this.Controls.Add(this.Escoger_Tabla_eliminar);
            this.Name = "Eliminar";
            this.Text = "Eliminar";
            ((System.ComponentModel.ISupportInitialize)(this.GridEliminar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Escoger_Tabla_eliminar;
        private System.Windows.Forms.ComboBox ComboEliminar;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label id_eliminar;
        private System.Windows.Forms.TextBox TextBoxIDEliminar;
        private System.Windows.Forms.DataGridView GridEliminar;
        private System.Windows.Forms.Label Tabla_eliminar;
        private System.Windows.Forms.Button ButtonDatos_actualizados_eliminar;
        private System.Windows.Forms.Button ButtonBorrar;
        private System.Windows.Forms.Label Nombre_tabla_eliminar;
    }
}