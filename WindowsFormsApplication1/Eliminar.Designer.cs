﻿namespace WindowsFormsApplication1
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
            this.GridEliminar = new System.Windows.Forms.DataGridView();
            this.Tabla_eliminar = new System.Windows.Forms.Label();
            this.ButtonDatos_actualizados_eliminar = new System.Windows.Forms.Button();
            this.ButtonBorrar = new System.Windows.Forms.Button();
            this.Nombre_tabla_eliminar = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.id_eliminar = new System.Windows.Forms.Label();
            this.comboBoxIDEliminar = new System.Windows.Forms.ComboBox();
            this.comboBoxColumnaID = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.GridEliminar)).BeginInit();
            this.SuspendLayout();
            // 
            // Escoger_Tabla_eliminar
            // 
            this.Escoger_Tabla_eliminar.AutoSize = true;
            this.Escoger_Tabla_eliminar.Location = new System.Drawing.Point(55, 48);
            this.Escoger_Tabla_eliminar.Name = "Escoger_Tabla_eliminar";
            this.Escoger_Tabla_eliminar.Size = new System.Drawing.Size(100, 13);
            this.Escoger_Tabla_eliminar.TabIndex = 14;
            this.Escoger_Tabla_eliminar.Text = "Escoga una Tabla: ";
            // 
            // ComboEliminar
            // 
            this.ComboEliminar.FormattingEnabled = true;
            this.ComboEliminar.Location = new System.Drawing.Point(178, 45);
            this.ComboEliminar.Name = "ComboEliminar";
            this.ComboEliminar.Size = new System.Drawing.Size(121, 21);
            this.ComboEliminar.TabIndex = 15;
            this.ComboEliminar.SelectedIndexChanged += new System.EventHandler(this.comboEliminar_SelectedIndexChanged);
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
            // GridEliminar
            // 
            this.GridEliminar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridEliminar.Location = new System.Drawing.Point(451, 78);
            this.GridEliminar.Name = "GridEliminar";
            this.GridEliminar.Size = new System.Drawing.Size(477, 246);
            this.GridEliminar.TabIndex = 19;
            // 
            // Tabla_eliminar
            // 
            this.Tabla_eliminar.AutoSize = true;
            this.Tabla_eliminar.Location = new System.Drawing.Point(586, 45);
            this.Tabla_eliminar.Name = "Tabla_eliminar";
            this.Tabla_eliminar.Size = new System.Drawing.Size(37, 13);
            this.Tabla_eliminar.TabIndex = 20;
            this.Tabla_eliminar.Text = "Tabla:";
            // 
            // ButtonDatos_actualizados_eliminar
            // 
            this.ButtonDatos_actualizados_eliminar.Location = new System.Drawing.Point(614, 353);
            this.ButtonDatos_actualizados_eliminar.Name = "ButtonDatos_actualizados_eliminar";
            this.ButtonDatos_actualizados_eliminar.Size = new System.Drawing.Size(158, 23);
            this.ButtonDatos_actualizados_eliminar.TabIndex = 21;
            this.ButtonDatos_actualizados_eliminar.Text = "Mostrar datos actualizados";
            this.ButtonDatos_actualizados_eliminar.UseVisualStyleBackColor = true;
            this.ButtonDatos_actualizados_eliminar.Click += new System.EventHandler(this.MostrarDatosEliminar_Click);
            // 
            // ButtonBorrar
            // 
            this.ButtonBorrar.Location = new System.Drawing.Point(117, 353);
            this.ButtonBorrar.Name = "ButtonBorrar";
            this.ButtonBorrar.Size = new System.Drawing.Size(130, 23);
            this.ButtonBorrar.TabIndex = 22;
            this.ButtonBorrar.Text = "Borrar";
            this.ButtonBorrar.UseVisualStyleBackColor = true;
            this.ButtonBorrar.Click += new System.EventHandler(this.Borrar_Click);
            // 
            // Nombre_tabla_eliminar
            // 
            this.Nombre_tabla_eliminar.AutoSize = true;
            this.Nombre_tabla_eliminar.Location = new System.Drawing.Point(664, 45);
            this.Nombre_tabla_eliminar.Name = "Nombre_tabla_eliminar";
            this.Nombre_tabla_eliminar.Size = new System.Drawing.Size(108, 13);
            this.Nombre_tabla_eliminar.TabIndex = 31;
            this.Nombre_tabla_eliminar.Text = "<Nombre de la tabla>";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Escoja el  ID a eliminar:";
            // 
            // id_eliminar
            // 
            this.id_eliminar.AutoSize = true;
            this.id_eliminar.Location = new System.Drawing.Point(55, 128);
            this.id_eliminar.Name = "id_eliminar";
            this.id_eliminar.Size = new System.Drawing.Size(130, 13);
            this.id_eliminar.TabIndex = 36;
            this.id_eliminar.Text = "Escoja la columna del ID :";
            // 
            // comboBoxIDEliminar
            // 
            this.comboBoxIDEliminar.FormattingEnabled = true;
            this.comboBoxIDEliminar.Location = new System.Drawing.Point(173, 232);
            this.comboBoxIDEliminar.Name = "comboBoxIDEliminar";
            this.comboBoxIDEliminar.Size = new System.Drawing.Size(121, 21);
            this.comboBoxIDEliminar.TabIndex = 37;
            this.comboBoxIDEliminar.Click += new System.EventHandler(this.comboBoxIDEliminar_SelectedIndexChanged);
            // 
            // comboBoxColumnaID
            // 
            this.comboBoxColumnaID.FormattingEnabled = true;
            this.comboBoxColumnaID.Location = new System.Drawing.Point(178, 128);
            this.comboBoxColumnaID.Name = "comboBoxColumnaID";
            this.comboBoxColumnaID.Size = new System.Drawing.Size(121, 21);
            this.comboBoxColumnaID.TabIndex = 38;
            // 
            // Eliminar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 428);
            this.Controls.Add(this.comboBoxColumnaID);
            this.Controls.Add(this.comboBoxIDEliminar);
            this.Controls.Add(this.id_eliminar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Nombre_tabla_eliminar);
            this.Controls.Add(this.ButtonBorrar);
            this.Controls.Add(this.ButtonDatos_actualizados_eliminar);
            this.Controls.Add(this.Tabla_eliminar);
            this.Controls.Add(this.GridEliminar);
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
        private System.Windows.Forms.DataGridView GridEliminar;
        private System.Windows.Forms.Label Tabla_eliminar;
        private System.Windows.Forms.Button ButtonDatos_actualizados_eliminar;
        private System.Windows.Forms.Button ButtonBorrar;
        private System.Windows.Forms.Label Nombre_tabla_eliminar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label id_eliminar;
        private System.Windows.Forms.ComboBox comboBoxIDEliminar;
        private System.Windows.Forms.ComboBox comboBoxColumnaID;
    }
}