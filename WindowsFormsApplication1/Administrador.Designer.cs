namespace WindowsFormsApplication1
{
    partial class Administrador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Administrador));
            this.ventana = new System.Windows.Forms.TabControl();
            this.Informacion = new System.Windows.Forms.TabPage();
            this.indices = new System.Windows.Forms.DataGridView();
            this.nombreInd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.tablaEscogida = new System.Windows.Forms.DataGridView();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.particio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tablas = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dbname = new System.Windows.Forms.Label();
            this.info2 = new System.Windows.Forms.TabPage();
            this.info3 = new System.Windows.Forms.TabPage();
            this.DdlObject = new System.Windows.Forms.TabPage();
            this.edicionTablas = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.vista = new System.Windows.Forms.DataGridView();
            this.nomVista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoVista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.defultVista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nullVista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ejecutarQuerys = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.espacioPaquetes = new System.Windows.Forms.RichTextBox();
            this.espacioFunciones = new System.Windows.Forms.RichTextBox();
            this.espacioTriggers = new System.Windows.Forms.RichTextBox();
            this.espacioProcedimientos = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.infoSesion = new System.Windows.Forms.DataGridView();
            this.identificador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hostname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Esquema = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comandosql = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.infoTablespace = new System.Windows.Forms.DataGridView();
            this.nomTablespace = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tamanio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.espacioUtilizado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.espacioDisponible = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label10 = new System.Windows.Forms.Label();
            this.tabladdl = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.mostrarDdl = new System.Windows.Forms.Button();
            this.EspacioDDL = new System.Windows.Forms.RichTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.TablaGridEdit = new System.Windows.Forms.DataGridView();
            this.tablaComboEdit = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.entradaQuery = new System.Windows.Forms.RichTextBox();
            this.validar = new System.Windows.Forms.Button();
            this.ejecutar = new System.Windows.Forms.Button();
            this.executionPlan = new System.Windows.Forms.Button();
            this.mostrarExecutionPlan = new System.Windows.Forms.RichTextBox();
            this.objetos = new System.Windows.Forms.TabPage();
            this.ventana.SuspendLayout();
            this.Informacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.indices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaEscogida)).BeginInit();
            this.info2.SuspendLayout();
            this.info3.SuspendLayout();
            this.DdlObject.SuspendLayout();
            this.edicionTablas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vista)).BeginInit();
            this.ejecutarQuerys.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infoSesion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoTablespace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TablaGridEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // ventana
            // 
            this.ventana.Controls.Add(this.Informacion);
            this.ventana.Controls.Add(this.info2);
            this.ventana.Controls.Add(this.info3);
            this.ventana.Controls.Add(this.DdlObject);
            this.ventana.Controls.Add(this.edicionTablas);
            this.ventana.Controls.Add(this.ejecutarQuerys);
            this.ventana.Controls.Add(this.objetos);
            this.ventana.Location = new System.Drawing.Point(0, 0);
            this.ventana.Name = "ventana";
            this.ventana.SelectedIndex = 0;
            this.ventana.Size = new System.Drawing.Size(974, 671);
            this.ventana.TabIndex = 0;
            // 
            // Informacion
            // 
            this.Informacion.Controls.Add(this.vista);
            this.Informacion.Controls.Add(this.comboBox1);
            this.Informacion.Controls.Add(this.label4);
            this.Informacion.Controls.Add(this.indices);
            this.Informacion.Controls.Add(this.label2);
            this.Informacion.Controls.Add(this.tablaEscogida);
            this.Informacion.Controls.Add(this.tablas);
            this.Informacion.Controls.Add(this.label1);
            this.Informacion.Controls.Add(this.dbname);
            this.Informacion.Font = new System.Drawing.Font("Arial", 10F);
            this.Informacion.Location = new System.Drawing.Point(4, 22);
            this.Informacion.Name = "Informacion";
            this.Informacion.Padding = new System.Windows.Forms.Padding(3);
            this.Informacion.Size = new System.Drawing.Size(966, 645);
            this.Informacion.TabIndex = 0;
            this.Informacion.Text = "Información";
            this.Informacion.UseVisualStyleBackColor = true;
            this.Informacion.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // indices
            // 
            this.indices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.indices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreInd,
            this.tabla,
            this.columna,
            this.unico});
            this.indices.Location = new System.Drawing.Point(8, 213);
            this.indices.Name = "indices";
            this.indices.Size = new System.Drawing.Size(445, 150);
            this.indices.TabIndex = 5;
            // 
            // nombreInd
            // 
            this.nombreInd.HeaderText = "Nombre";
            this.nombreInd.Name = "nombreInd";
            // 
            // tabla
            // 
            this.tabla.HeaderText = "Tabla";
            this.tabla.Name = "tabla";
            // 
            // columna
            // 
            this.columna.HeaderText = "Columna";
            this.columna.Name = "columna";
            // 
            // unico
            // 
            this.unico.HeaderText = "Unico";
            this.unico.Name = "unico";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Indices";
            // 
            // tablaEscogida
            // 
            this.tablaEscogida.AllowUserToDeleteRows = false;
            this.tablaEscogida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaEscogida.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombre,
            this.tipo,
            this.pk,
            this.fk,
            this.particio});
            this.tablaEscogida.Location = new System.Drawing.Point(8, 71);
            this.tablaEscogida.Name = "tablaEscogida";
            this.tablaEscogida.Size = new System.Drawing.Size(544, 107);
            this.tablaEscogida.TabIndex = 3;
            this.tablaEscogida.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            // 
            // tipo
            // 
            this.tipo.HeaderText = "Tipo";
            this.tipo.Name = "tipo";
            // 
            // pk
            // 
            this.pk.HeaderText = "PK";
            this.pk.Name = "pk";
            // 
            // fk
            // 
            this.fk.HeaderText = "FK";
            this.fk.Name = "fk";
            // 
            // particio
            // 
            this.particio.HeaderText = "Particion";
            this.particio.Name = "particio";
            // 
            // tablas
            // 
            this.tablas.FormattingEnabled = true;
            this.tablas.Location = new System.Drawing.Point(117, 32);
            this.tablas.Name = "tablas";
            this.tablas.Size = new System.Drawing.Size(121, 24);
            this.tablas.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Escoga la Tabla";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // dbname
            // 
            this.dbname.AutoSize = true;
            this.dbname.Location = new System.Drawing.Point(368, 3);
            this.dbname.Name = "dbname";
            this.dbname.Size = new System.Drawing.Size(143, 16);
            this.dbname.TabIndex = 0;
            this.dbname.Text = "<Nombre de la base>";
            this.dbname.Click += new System.EventHandler(this.label1_Click);
            // 
            // info2
            // 
            this.info2.Controls.Add(this.espacioProcedimientos);
            this.info2.Controls.Add(this.espacioTriggers);
            this.info2.Controls.Add(this.espacioFunciones);
            this.info2.Controls.Add(this.espacioPaquetes);
            this.info2.Controls.Add(this.label7);
            this.info2.Controls.Add(this.label6);
            this.info2.Controls.Add(this.label5);
            this.info2.Controls.Add(this.label3);
            this.info2.Location = new System.Drawing.Point(4, 22);
            this.info2.Name = "info2";
            this.info2.Padding = new System.Windows.Forms.Padding(3);
            this.info2.Size = new System.Drawing.Size(966, 645);
            this.info2.TabIndex = 1;
            this.info2.Text = "Información 2";
            this.info2.UseVisualStyleBackColor = true;
            this.info2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // info3
            // 
            this.info3.Controls.Add(this.infoTablespace);
            this.info3.Controls.Add(this.infoSesion);
            this.info3.Controls.Add(this.label9);
            this.info3.Controls.Add(this.label8);
            this.info3.Location = new System.Drawing.Point(4, 22);
            this.info3.Name = "info3";
            this.info3.Padding = new System.Windows.Forms.Padding(3);
            this.info3.Size = new System.Drawing.Size(966, 645);
            this.info3.TabIndex = 2;
            this.info3.Text = "Información 3";
            this.info3.UseVisualStyleBackColor = true;
            // 
            // DdlObject
            // 
            this.DdlObject.Controls.Add(this.EspacioDDL);
            this.DdlObject.Controls.Add(this.mostrarDdl);
            this.DdlObject.Controls.Add(this.textBox1);
            this.DdlObject.Controls.Add(this.label11);
            this.DdlObject.Controls.Add(this.tabladdl);
            this.DdlObject.Controls.Add(this.label10);
            this.DdlObject.Location = new System.Drawing.Point(4, 22);
            this.DdlObject.Name = "DdlObject";
            this.DdlObject.Padding = new System.Windows.Forms.Padding(3);
            this.DdlObject.Size = new System.Drawing.Size(966, 645);
            this.DdlObject.TabIndex = 3;
            this.DdlObject.Text = "DDL del Objeto";
            this.DdlObject.UseVisualStyleBackColor = true;
            // 
            // edicionTablas
            // 
            this.edicionTablas.Controls.Add(this.TablaGridEdit);
            this.edicionTablas.Controls.Add(this.tablaComboEdit);
            this.edicionTablas.Controls.Add(this.label12);
            this.edicionTablas.Location = new System.Drawing.Point(4, 22);
            this.edicionTablas.Name = "edicionTablas";
            this.edicionTablas.Padding = new System.Windows.Forms.Padding(3);
            this.edicionTablas.Size = new System.Drawing.Size(966, 645);
            this.edicionTablas.TabIndex = 4;
            this.edicionTablas.Text = "Edicion Tablas";
            this.edicionTablas.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 385);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Escoja la Vista";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(110, 385);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 7;
            // 
            // vista
            // 
            this.vista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomVista,
            this.tipoVista,
            this.defultVista,
            this.nullVista});
            this.vista.Location = new System.Drawing.Point(7, 418);
            this.vista.Name = "vista";
            this.vista.Size = new System.Drawing.Size(446, 150);
            this.vista.TabIndex = 8;
            // 
            // nomVista
            // 
            this.nomVista.HeaderText = "Nombre";
            this.nomVista.Name = "nomVista";
            // 
            // tipoVista
            // 
            this.tipoVista.HeaderText = "Tipo";
            this.tipoVista.Name = "tipoVista";
            // 
            // defultVista
            // 
            this.defultVista.HeaderText = "Defult";
            this.defultVista.Name = "defultVista";
            // 
            // nullVista
            // 
            this.nullVista.HeaderText = "Null";
            this.nullVista.Name = "nullVista";
            // 
            // ejecutarQuerys
            // 
            this.ejecutarQuerys.Controls.Add(this.mostrarExecutionPlan);
            this.ejecutarQuerys.Controls.Add(this.executionPlan);
            this.ejecutarQuerys.Controls.Add(this.ejecutar);
            this.ejecutarQuerys.Controls.Add(this.validar);
            this.ejecutarQuerys.Controls.Add(this.entradaQuery);
            this.ejecutarQuerys.Controls.Add(this.label13);
            this.ejecutarQuerys.Location = new System.Drawing.Point(4, 22);
            this.ejecutarQuerys.Name = "ejecutarQuerys";
            this.ejecutarQuerys.Padding = new System.Windows.Forms.Padding(3);
            this.ejecutarQuerys.Size = new System.Drawing.Size(966, 645);
            this.ejecutarQuerys.TabIndex = 5;
            this.ejecutarQuerys.Text = "Ejecutar Querys";
            this.ejecutarQuerys.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Paquetes";
            this.label3.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(525, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Procedimientos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 299);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Funciones";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(525, 299);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Triggers";
            // 
            // espacioPaquetes
            // 
            this.espacioPaquetes.Location = new System.Drawing.Point(76, 46);
            this.espacioPaquetes.Name = "espacioPaquetes";
            this.espacioPaquetes.Size = new System.Drawing.Size(219, 197);
            this.espacioPaquetes.TabIndex = 4;
            this.espacioPaquetes.Text = "";
            // 
            // espacioFunciones
            // 
            this.espacioFunciones.Location = new System.Drawing.Point(76, 343);
            this.espacioFunciones.Name = "espacioFunciones";
            this.espacioFunciones.Size = new System.Drawing.Size(219, 169);
            this.espacioFunciones.TabIndex = 5;
            this.espacioFunciones.Text = "";
            // 
            // espacioTriggers
            // 
            this.espacioTriggers.Location = new System.Drawing.Point(590, 343);
            this.espacioTriggers.Name = "espacioTriggers";
            this.espacioTriggers.Size = new System.Drawing.Size(233, 169);
            this.espacioTriggers.TabIndex = 6;
            this.espacioTriggers.Text = "";
            // 
            // espacioProcedimientos
            // 
            this.espacioProcedimientos.Location = new System.Drawing.Point(590, 46);
            this.espacioProcedimientos.Name = "espacioProcedimientos";
            this.espacioProcedimientos.Size = new System.Drawing.Size(233, 197);
            this.espacioProcedimientos.TabIndex = 7;
            this.espacioProcedimientos.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(43, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Información de la Sesión";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(43, 277);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(224, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Información Tablespace/Archivos del Sistema";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // infoSesion
            // 
            this.infoSesion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.infoSesion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.identificador,
            this.status,
            this.hostname,
            this.Esquema,
            this.comandosql,
            this.usuario});
            this.infoSesion.Location = new System.Drawing.Point(46, 74);
            this.infoSesion.Name = "infoSesion";
            this.infoSesion.Size = new System.Drawing.Size(645, 150);
            this.infoSesion.TabIndex = 2;
            // 
            // identificador
            // 
            this.identificador.HeaderText = "Identificador";
            this.identificador.Name = "identificador";
            // 
            // status
            // 
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            // 
            // hostname
            // 
            this.hostname.HeaderText = "Hostname";
            this.hostname.Name = "hostname";
            // 
            // Esquema
            // 
            this.Esquema.HeaderText = "esquema";
            this.Esquema.Name = "Esquema";
            // 
            // comandosql
            // 
            this.comandosql.HeaderText = "Comando Sql";
            this.comandosql.Name = "comandosql";
            // 
            // usuario
            // 
            this.usuario.HeaderText = "Usuario";
            this.usuario.Name = "usuario";
            // 
            // infoTablespace
            // 
            this.infoTablespace.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.infoTablespace.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomTablespace,
            this.tamanio,
            this.espacioUtilizado,
            this.espacioDisponible});
            this.infoTablespace.Location = new System.Drawing.Point(46, 315);
            this.infoTablespace.Name = "infoTablespace";
            this.infoTablespace.Size = new System.Drawing.Size(444, 150);
            this.infoTablespace.TabIndex = 3;
            // 
            // nomTablespace
            // 
            this.nomTablespace.HeaderText = "Nombre";
            this.nomTablespace.Name = "nomTablespace";
            // 
            // tamanio
            // 
            this.tamanio.HeaderText = "Tamaño";
            this.tamanio.Name = "tamanio";
            // 
            // espacioUtilizado
            // 
            this.espacioUtilizado.HeaderText = "Espacio Utilizado";
            this.espacioUtilizado.Name = "espacioUtilizado";
            // 
            // espacioDisponible
            // 
            this.espacioDisponible.HeaderText = "Espacio Disponible";
            this.espacioDisponible.Name = "espacioDisponible";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(42, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Seleccione el Objeto";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // tabladdl
            // 
            this.tabladdl.FormattingEnabled = true;
            this.tabladdl.Location = new System.Drawing.Point(206, 28);
            this.tabladdl.Name = "tabladdl";
            this.tabladdl.Size = new System.Drawing.Size(121, 21);
            this.tabladdl.TabIndex = 1;
            this.tabladdl.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(42, 93);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(144, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Escriba el Nombre del Objeto";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(206, 90);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(206, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // mostrarDdl
            // 
            this.mostrarDdl.Location = new System.Drawing.Point(491, 90);
            this.mostrarDdl.Name = "mostrarDdl";
            this.mostrarDdl.Size = new System.Drawing.Size(108, 23);
            this.mostrarDdl.TabIndex = 4;
            this.mostrarDdl.Text = "Mostrar DDL";
            this.mostrarDdl.UseVisualStyleBackColor = true;
            // 
            // EspacioDDL
            // 
            this.EspacioDDL.Location = new System.Drawing.Point(160, 157);
            this.EspacioDDL.Name = "EspacioDDL";
            this.EspacioDDL.Size = new System.Drawing.Size(604, 358);
            this.EspacioDDL.TabIndex = 5;
            this.EspacioDDL.Text = "";
            this.EspacioDDL.TextChanged += new System.EventHandler(this.richTextBox5_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(313, 45);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Escoga una Tabla: ";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // TablaGridEdit
            // 
            this.TablaGridEdit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaGridEdit.Location = new System.Drawing.Point(138, 125);
            this.TablaGridEdit.Name = "TablaGridEdit";
            this.TablaGridEdit.Size = new System.Drawing.Size(725, 309);
            this.TablaGridEdit.TabIndex = 2;
            // 
            // tablaComboEdit
            // 
            this.tablaComboEdit.FormattingEnabled = true;
            this.tablaComboEdit.Location = new System.Drawing.Point(433, 42);
            this.tablaComboEdit.Name = "tablaComboEdit";
            this.tablaComboEdit.Size = new System.Drawing.Size(121, 21);
            this.tablaComboEdit.TabIndex = 1;
            this.tablaComboEdit.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged_1);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(57, 20);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(90, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Escriba su Query:";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // entradaQuery
            // 
            this.entradaQuery.Location = new System.Drawing.Point(150, 36);
            this.entradaQuery.Name = "entradaQuery";
            this.entradaQuery.Size = new System.Drawing.Size(619, 207);
            this.entradaQuery.TabIndex = 1;
            this.entradaQuery.Text = "";
            // 
            // validar
            // 
            this.validar.Location = new System.Drawing.Point(241, 249);
            this.validar.Name = "validar";
            this.validar.Size = new System.Drawing.Size(75, 23);
            this.validar.TabIndex = 2;
            this.validar.Text = "Validar";
            this.validar.UseVisualStyleBackColor = true;
            // 
            // ejecutar
            // 
            this.ejecutar.Location = new System.Drawing.Point(481, 249);
            this.ejecutar.Name = "ejecutar";
            this.ejecutar.Size = new System.Drawing.Size(75, 23);
            this.ejecutar.TabIndex = 3;
            this.ejecutar.Text = "Ejecutar";
            this.ejecutar.UseVisualStyleBackColor = true;
            // 
            // executionPlan
            // 
            this.executionPlan.Location = new System.Drawing.Point(60, 305);
            this.executionPlan.Name = "executionPlan";
            this.executionPlan.Size = new System.Drawing.Size(131, 23);
            this.executionPlan.TabIndex = 4;
            this.executionPlan.Text = "Execution Plan";
            this.executionPlan.UseVisualStyleBackColor = true;
            this.executionPlan.Click += new System.EventHandler(this.button1_Click);
            // 
            // mostrarExecutionPlan
            // 
            this.mostrarExecutionPlan.Location = new System.Drawing.Point(150, 353);
            this.mostrarExecutionPlan.Name = "mostrarExecutionPlan";
            this.mostrarExecutionPlan.Size = new System.Drawing.Size(619, 199);
            this.mostrarExecutionPlan.TabIndex = 5;
            this.mostrarExecutionPlan.Text = "";
            // 
            // objetos
            // 
            this.objetos.Location = new System.Drawing.Point(4, 22);
            this.objetos.Name = "objetos";
            this.objetos.Padding = new System.Windows.Forms.Padding(3);
            this.objetos.Size = new System.Drawing.Size(966, 645);
            this.objetos.TabIndex = 6;
            this.objetos.Text = "-- Objetos --";
            this.objetos.UseVisualStyleBackColor = true;
            // 
            // Administrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 604);
            this.Controls.Add(this.ventana);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Administrador";
            this.Text = "Administrador";
            this.Load += new System.EventHandler(this.Administrador_Load);
            this.ventana.ResumeLayout(false);
            this.Informacion.ResumeLayout(false);
            this.Informacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.indices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaEscogida)).EndInit();
            this.info2.ResumeLayout(false);
            this.info2.PerformLayout();
            this.info3.ResumeLayout(false);
            this.info3.PerformLayout();
            this.DdlObject.ResumeLayout(false);
            this.DdlObject.PerformLayout();
            this.edicionTablas.ResumeLayout(false);
            this.edicionTablas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vista)).EndInit();
            this.ejecutarQuerys.ResumeLayout(false);
            this.ejecutarQuerys.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infoSesion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoTablespace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TablaGridEdit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl ventana;
        private System.Windows.Forms.TabPage Informacion;
        private System.Windows.Forms.TabPage info2;
        private System.Windows.Forms.TabPage info3;
        private System.Windows.Forms.TabPage DdlObject;
        private System.Windows.Forms.TabPage edicionTablas;
        private System.Windows.Forms.Label dbname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox tablas;
        private System.Windows.Forms.DataGridView tablaEscogida;
        private System.Windows.Forms.DataGridView indices;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreInd;
        private System.Windows.Forms.DataGridViewTextBoxColumn tabla;
        private System.Windows.Forms.DataGridViewTextBoxColumn columna;
        private System.Windows.Forms.DataGridViewTextBoxColumn unico;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn pk;
        private System.Windows.Forms.DataGridViewTextBoxColumn fk;
        private System.Windows.Forms.DataGridViewTextBoxColumn particio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView vista;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomVista;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoVista;
        private System.Windows.Forms.DataGridViewTextBoxColumn defultVista;
        private System.Windows.Forms.DataGridViewTextBoxColumn nullVista;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TabPage ejecutarQuerys;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox espacioProcedimientos;
        private System.Windows.Forms.RichTextBox espacioTriggers;
        private System.Windows.Forms.RichTextBox espacioFunciones;
        private System.Windows.Forms.RichTextBox espacioPaquetes;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView infoSesion;
        private System.Windows.Forms.DataGridViewTextBoxColumn identificador;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn hostname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Esquema;
        private System.Windows.Forms.DataGridViewTextBoxColumn comandosql;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuario;
        private System.Windows.Forms.DataGridView infoTablespace;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomTablespace;
        private System.Windows.Forms.DataGridViewTextBoxColumn tamanio;
        private System.Windows.Forms.DataGridViewTextBoxColumn espacioUtilizado;
        private System.Windows.Forms.DataGridViewTextBoxColumn espacioDisponible;
        private System.Windows.Forms.Button mostrarDdl;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox tabladdl;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RichTextBox EspacioDDL;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView TablaGridEdit;
        private System.Windows.Forms.ComboBox tablaComboEdit;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button executionPlan;
        private System.Windows.Forms.Button ejecutar;
        private System.Windows.Forms.Button validar;
        private System.Windows.Forms.RichTextBox entradaQuery;
        private System.Windows.Forms.RichTextBox mostrarExecutionPlan;
        private System.Windows.Forms.TabPage objetos;
    }
}