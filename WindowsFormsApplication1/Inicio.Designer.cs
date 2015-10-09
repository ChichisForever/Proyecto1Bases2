namespace WindowsFormsApplication1
{
    partial class Inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.label1 = new System.Windows.Forms.Label();
            this.oracle = new System.Windows.Forms.Button();
            this.sqlserver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Font = new System.Drawing.Font("Arial", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(713, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenido al Administrador de Bases de Datos";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // oracle
            // 
            this.oracle.Image = ((System.Drawing.Image)(resources.GetObject("oracle.Image")));
            this.oracle.Location = new System.Drawing.Point(120, 217);
            this.oracle.Name = "oracle";
            this.oracle.Size = new System.Drawing.Size(198, 72);
            this.oracle.TabIndex = 1;
            this.oracle.UseVisualStyleBackColor = true;
            this.oracle.Click += new System.EventHandler(this.oracle_Click);
            // 
            // sqlserver
            // 
            this.sqlserver.Image = ((System.Drawing.Image)(resources.GetObject("sqlserver.Image")));
            this.sqlserver.Location = new System.Drawing.Point(459, 215);
            this.sqlserver.Name = "sqlserver";
            this.sqlserver.Size = new System.Drawing.Size(216, 74);
            this.sqlserver.TabIndex = 2;
            this.sqlserver.UseVisualStyleBackColor = true;
            this.sqlserver.Click += new System.EventHandler(this.sqlserver_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(786, 488);
            this.Controls.Add(this.sqlserver);
            this.Controls.Add(this.oracle);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Inicio";
            this.Text = "Administrador de Bases de Datos";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button oracle;
        private System.Windows.Forms.Button sqlserver;
    }
}

