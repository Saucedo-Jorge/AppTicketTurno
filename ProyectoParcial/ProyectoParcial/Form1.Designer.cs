namespace ProyectoParcial
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            registrarToolStripMenuItem = new ToolStripMenuItem();
            modificarToolStripMenuItem = new ToolStripMenuItem();
            modoAdministradorToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            gbxRegistroAlumno = new GroupBox();
            listBox2 = new ListBox();
            btnlimpiarRegistro = new Button();
            btnGuardar = new Button();
            label1 = new Label();
            txtTipoTramiteRegistro = new TextBox();
            lblTramite = new Label();
            txtMunicipioRegistro = new TextBox();
            txtTelefonoregistro = new TextBox();
            txtNEscolarRegistro = new TextBox();
            txtCorreoRegistro = new TextBox();
            txtMatregistro = new TextBox();
            txtPatRegistro = new TextBox();
            txtNombreRegistro = new TextBox();
            txtCurpRegistro = new TextBox();
            lblMaterno = new Label();
            lblMunicipio = new Label();
            lblNvlEscolar = new Label();
            lblCorreo = new Label();
            lblTelefono = new Label();
            lblApPaterno = new Label();
            lblNombre = new Label();
            lblCurp = new Label();
            gbxModificacion = new GroupBox();
            btnGuardarCambios = new Button();
            txtTurno = new TextBox();
            label12 = new Label();
            listBox1 = new ListBox();
            btnlimpio = new Button();
            btnConsulta = new Button();
            label2 = new Label();
            txtTipoTramite = new TextBox();
            label3 = new Label();
            txtMunicipioModificacion = new TextBox();
            TxtTelefonoModifacion = new TextBox();
            txtNEscolarModificacion = new TextBox();
            txtCorreoModificacion = new TextBox();
            txtMaternoModificacion = new TextBox();
            txtPaternoModificacion = new TextBox();
            txtNombreModificacion = new TextBox();
            txtCurp = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            menuStrip1.SuspendLayout();
            gbxRegistroAlumno.SuspendLayout();
            gbxModificacion.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { registrarToolStripMenuItem, modificarToolStripMenuItem, modoAdministradorToolStripMenuItem, salirToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(968, 28);
            menuStrip1.TabIndex = 37;
            menuStrip1.Text = "menuStrip1";
            // 
            // registrarToolStripMenuItem
            // 
            registrarToolStripMenuItem.Name = "registrarToolStripMenuItem";
            registrarToolStripMenuItem.Size = new Size(82, 24);
            registrarToolStripMenuItem.Text = "Registrar";
            registrarToolStripMenuItem.Click += registrarToolStripMenuItem_Click;
            // 
            // modificarToolStripMenuItem
            // 
            modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            modificarToolStripMenuItem.Size = new Size(87, 24);
            modificarToolStripMenuItem.Text = "Modificar";
            modificarToolStripMenuItem.Click += modificarToolStripMenuItem_Click;
            // 
            // modoAdministradorToolStripMenuItem
            // 
            modoAdministradorToolStripMenuItem.Name = "modoAdministradorToolStripMenuItem";
            modoAdministradorToolStripMenuItem.Size = new Size(162, 24);
            modoAdministradorToolStripMenuItem.Text = "Modo Administrador";
            modoAdministradorToolStripMenuItem.Click += modoAdministradorToolStripMenuItem_Click;
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(52, 24);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // gbxRegistroAlumno
            // 
            gbxRegistroAlumno.Controls.Add(listBox2);
            gbxRegistroAlumno.Controls.Add(btnlimpiarRegistro);
            gbxRegistroAlumno.Controls.Add(btnGuardar);
            gbxRegistroAlumno.Controls.Add(label1);
            gbxRegistroAlumno.Controls.Add(txtTipoTramiteRegistro);
            gbxRegistroAlumno.Controls.Add(lblTramite);
            gbxRegistroAlumno.Controls.Add(txtMunicipioRegistro);
            gbxRegistroAlumno.Controls.Add(txtTelefonoregistro);
            gbxRegistroAlumno.Controls.Add(txtNEscolarRegistro);
            gbxRegistroAlumno.Controls.Add(txtCorreoRegistro);
            gbxRegistroAlumno.Controls.Add(txtMatregistro);
            gbxRegistroAlumno.Controls.Add(txtPatRegistro);
            gbxRegistroAlumno.Controls.Add(txtNombreRegistro);
            gbxRegistroAlumno.Controls.Add(txtCurpRegistro);
            gbxRegistroAlumno.Controls.Add(lblMaterno);
            gbxRegistroAlumno.Controls.Add(lblMunicipio);
            gbxRegistroAlumno.Controls.Add(lblNvlEscolar);
            gbxRegistroAlumno.Controls.Add(lblCorreo);
            gbxRegistroAlumno.Controls.Add(lblTelefono);
            gbxRegistroAlumno.Controls.Add(lblApPaterno);
            gbxRegistroAlumno.Controls.Add(lblNombre);
            gbxRegistroAlumno.Controls.Add(lblCurp);
            gbxRegistroAlumno.Location = new Point(43, 79);
            gbxRegistroAlumno.Name = "gbxRegistroAlumno";
            gbxRegistroAlumno.Size = new Size(869, 477);
            gbxRegistroAlumno.TabIndex = 84;
            gbxRegistroAlumno.TabStop = false;
            gbxRegistroAlumno.Text = "Registro del Alumno";
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.Items.AddRange(new object[] { "Padre", "Madre", "Tutor", "Otro" });
            listBox2.Location = new Point(521, 346);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(215, 24);
            listBox2.TabIndex = 106;
            // 
            // btnlimpiarRegistro
            // 
            btnlimpiarRegistro.Location = new Point(732, 410);
            btnlimpiarRegistro.Name = "btnlimpiarRegistro";
            btnlimpiarRegistro.Size = new Size(94, 29);
            btnlimpiarRegistro.TabIndex = 105;
            btnlimpiarRegistro.Text = "Limpiar";
            btnlimpiarRegistro.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(550, 410);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 104;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(416, 348);
            label1.Name = "label1";
            label1.Size = new Size(99, 20);
            label1.TabIndex = 102;
            label1.Text = "Quien solicita";
            // 
            // txtTipoTramiteRegistro
            // 
            txtTipoTramiteRegistro.Location = new Point(152, 341);
            txtTipoTramiteRegistro.Name = "txtTipoTramiteRegistro";
            txtTipoTramiteRegistro.Size = new Size(224, 27);
            txtTipoTramiteRegistro.TabIndex = 101;
            // 
            // lblTramite
            // 
            lblTramite.AutoSize = true;
            lblTramite.Location = new Point(21, 344);
            lblTramite.Name = "lblTramite";
            lblTramite.Size = new Size(114, 20);
            lblTramite.TabIndex = 100;
            lblTramite.Text = "Tipo de Tramite";
            // 
            // txtMunicipioRegistro
            // 
            txtMunicipioRegistro.Location = new Point(512, 265);
            txtMunicipioRegistro.Name = "txtMunicipioRegistro";
            txtMunicipioRegistro.Size = new Size(224, 27);
            txtMunicipioRegistro.TabIndex = 99;
            // 
            // txtTelefonoregistro
            // 
            txtTelefonoregistro.Location = new Point(512, 202);
            txtTelefonoregistro.Name = "txtTelefonoregistro";
            txtTelefonoregistro.Size = new Size(224, 27);
            txtTelefonoregistro.TabIndex = 98;
            // 
            // txtNEscolarRegistro
            // 
            txtNEscolarRegistro.Location = new Point(512, 138);
            txtNEscolarRegistro.Name = "txtNEscolarRegistro";
            txtNEscolarRegistro.Size = new Size(224, 27);
            txtNEscolarRegistro.TabIndex = 97;
            // 
            // txtCorreoRegistro
            // 
            txtCorreoRegistro.Location = new Point(512, 70);
            txtCorreoRegistro.Name = "txtCorreoRegistro";
            txtCorreoRegistro.Size = new Size(224, 27);
            txtCorreoRegistro.TabIndex = 96;
            // 
            // txtMatregistro
            // 
            txtMatregistro.Location = new Point(143, 258);
            txtMatregistro.Name = "txtMatregistro";
            txtMatregistro.Size = new Size(224, 27);
            txtMatregistro.TabIndex = 95;
            // 
            // txtPatRegistro
            // 
            txtPatRegistro.Location = new Point(143, 202);
            txtPatRegistro.Name = "txtPatRegistro";
            txtPatRegistro.Size = new Size(224, 27);
            txtPatRegistro.TabIndex = 94;
            // 
            // txtNombreRegistro
            // 
            txtNombreRegistro.Location = new Point(143, 131);
            txtNombreRegistro.Name = "txtNombreRegistro";
            txtNombreRegistro.Size = new Size(224, 27);
            txtNombreRegistro.TabIndex = 93;
            // 
            // txtCurpRegistro
            // 
            txtCurpRegistro.Location = new Point(143, 63);
            txtCurpRegistro.Name = "txtCurpRegistro";
            txtCurpRegistro.Size = new Size(224, 27);
            txtCurpRegistro.TabIndex = 92;
            // 
            // lblMaterno
            // 
            lblMaterno.AutoSize = true;
            lblMaterno.Location = new Point(70, 265);
            lblMaterno.Name = "lblMaterno";
            lblMaterno.Size = new Size(65, 20);
            lblMaterno.TabIndex = 91;
            lblMaterno.Text = "Materno";
            // 
            // lblMunicipio
            // 
            lblMunicipio.AutoSize = true;
            lblMunicipio.Location = new Point(416, 265);
            lblMunicipio.Name = "lblMunicipio";
            lblMunicipio.Size = new Size(75, 20);
            lblMunicipio.TabIndex = 90;
            lblMunicipio.Text = "Municipio";
            // 
            // lblNvlEscolar
            // 
            lblNvlEscolar.AutoSize = true;
            lblNvlEscolar.Location = new Point(397, 138);
            lblNvlEscolar.Name = "lblNvlEscolar";
            lblNvlEscolar.Size = new Size(94, 20);
            lblNvlEscolar.TabIndex = 89;
            lblNvlEscolar.Text = "Nivel Escolar";
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Location = new Point(437, 70);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(54, 20);
            lblCorreo.TabIndex = 88;
            lblCorreo.Text = "Correo";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(424, 202);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(67, 20);
            lblTelefono.TabIndex = 87;
            lblTelefono.Text = "Telefono";
            // 
            // lblApPaterno
            // 
            lblApPaterno.AutoSize = true;
            lblApPaterno.Location = new Point(76, 202);
            lblApPaterno.Name = "lblApPaterno";
            lblApPaterno.Size = new Size(59, 20);
            lblApPaterno.TabIndex = 86;
            lblApPaterno.Text = "Paterno";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(71, 138);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(64, 20);
            lblNombre.TabIndex = 85;
            lblNombre.Text = "Nombre";
            // 
            // lblCurp
            // 
            lblCurp.AutoSize = true;
            lblCurp.Location = new Point(95, 66);
            lblCurp.Name = "lblCurp";
            lblCurp.Size = new Size(40, 20);
            lblCurp.TabIndex = 84;
            lblCurp.Text = "Curp";
            // 
            // gbxModificacion
            // 
            gbxModificacion.Controls.Add(btnGuardarCambios);
            gbxModificacion.Controls.Add(txtTurno);
            gbxModificacion.Controls.Add(label12);
            gbxModificacion.Controls.Add(listBox1);
            gbxModificacion.Controls.Add(btnlimpio);
            gbxModificacion.Controls.Add(btnConsulta);
            gbxModificacion.Controls.Add(label2);
            gbxModificacion.Controls.Add(txtTipoTramite);
            gbxModificacion.Controls.Add(label3);
            gbxModificacion.Controls.Add(txtMunicipioModificacion);
            gbxModificacion.Controls.Add(TxtTelefonoModifacion);
            gbxModificacion.Controls.Add(txtNEscolarModificacion);
            gbxModificacion.Controls.Add(txtCorreoModificacion);
            gbxModificacion.Controls.Add(txtMaternoModificacion);
            gbxModificacion.Controls.Add(txtPaternoModificacion);
            gbxModificacion.Controls.Add(txtNombreModificacion);
            gbxModificacion.Controls.Add(txtCurp);
            gbxModificacion.Controls.Add(label4);
            gbxModificacion.Controls.Add(label5);
            gbxModificacion.Controls.Add(label6);
            gbxModificacion.Controls.Add(label7);
            gbxModificacion.Controls.Add(label8);
            gbxModificacion.Controls.Add(label9);
            gbxModificacion.Controls.Add(label10);
            gbxModificacion.Controls.Add(label11);
            gbxModificacion.Location = new Point(68, 68);
            gbxModificacion.Name = "gbxModificacion";
            gbxModificacion.Size = new Size(869, 477);
            gbxModificacion.TabIndex = 85;
            gbxModificacion.TabStop = false;
            gbxModificacion.Text = "Modificacion de datos del alumno";
            gbxModificacion.Enter += gbxModificacion_Enter;
            // 
            // btnGuardarCambios
            // 
            btnGuardarCambios.Location = new Point(439, 442);
            btnGuardarCambios.Name = "btnGuardarCambios";
            btnGuardarCambios.Size = new Size(94, 29);
            btnGuardarCambios.TabIndex = 109;
            btnGuardarCambios.Text = "Guardar";
            btnGuardarCambios.UseVisualStyleBackColor = true;
            // 
            // txtTurno
            // 
            txtTurno.Location = new Point(512, 66);
            txtTurno.Name = "txtTurno";
            txtTurno.Size = new Size(125, 27);
            txtTurno.TabIndex = 108;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(444, 69);
            label12.Name = "label12";
            label12.Size = new Size(47, 20);
            label12.TabIndex = 107;
            label12.Text = "Turno";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Items.AddRange(new object[] { "Padre", "Madre", "Tutor ", "Otro" });
            listBox1.Location = new Point(509, 171);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(223, 24);
            listBox1.TabIndex = 106;
            // 
            // btnlimpio
            // 
            btnlimpio.Location = new Point(686, 442);
            btnlimpio.Name = "btnlimpio";
            btnlimpio.Size = new Size(94, 29);
            btnlimpio.TabIndex = 105;
            btnlimpio.Text = "Limpiar";
            btnlimpio.UseVisualStyleBackColor = true;
            // 
            // btnConsulta
            // 
            btnConsulta.Location = new Point(568, 442);
            btnConsulta.Name = "btnConsulta";
            btnConsulta.Size = new Size(94, 29);
            btnConsulta.TabIndex = 104;
            btnConsulta.Text = "Consulta";
            btnConsulta.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(392, 171);
            label2.Name = "label2";
            label2.Size = new Size(99, 20);
            label2.TabIndex = 102;
            label2.Text = "Quien solicita";
            // 
            // txtTipoTramite
            // 
            txtTipoTramite.Location = new Point(143, 168);
            txtTipoTramite.Name = "txtTipoTramite";
            txtTipoTramite.Size = new Size(224, 27);
            txtTipoTramite.TabIndex = 101;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 171);
            label3.Name = "label3";
            label3.Size = new Size(114, 20);
            label3.TabIndex = 100;
            label3.Text = "Tipo de Tramite";
            // 
            // txtMunicipioModificacion
            // 
            txtMunicipioModificacion.Location = new Point(512, 305);
            txtMunicipioModificacion.Name = "txtMunicipioModificacion";
            txtMunicipioModificacion.Size = new Size(224, 27);
            txtMunicipioModificacion.TabIndex = 99;
            // 
            // TxtTelefonoModifacion
            // 
            TxtTelefonoModifacion.Location = new Point(512, 109);
            TxtTelefonoModifacion.Name = "TxtTelefonoModifacion";
            TxtTelefonoModifacion.Size = new Size(224, 27);
            TxtTelefonoModifacion.TabIndex = 98;
            // 
            // txtNEscolarModificacion
            // 
            txtNEscolarModificacion.Location = new Point(512, 395);
            txtNEscolarModificacion.Name = "txtNEscolarModificacion";
            txtNEscolarModificacion.Size = new Size(224, 27);
            txtNEscolarModificacion.TabIndex = 97;
            // 
            // txtCorreoModificacion
            // 
            txtCorreoModificacion.Location = new Point(512, 242);
            txtCorreoModificacion.Name = "txtCorreoModificacion";
            txtCorreoModificacion.Size = new Size(224, 27);
            txtCorreoModificacion.TabIndex = 96;
            // 
            // txtMaternoModificacion
            // 
            txtMaternoModificacion.Location = new Point(143, 298);
            txtMaternoModificacion.Name = "txtMaternoModificacion";
            txtMaternoModificacion.Size = new Size(224, 27);
            txtMaternoModificacion.TabIndex = 95;
            // 
            // txtPaternoModificacion
            // 
            txtPaternoModificacion.Location = new Point(143, 242);
            txtPaternoModificacion.Name = "txtPaternoModificacion";
            txtPaternoModificacion.Size = new Size(224, 27);
            txtPaternoModificacion.TabIndex = 94;
            txtPaternoModificacion.TextChanged += txtPaternoModificacion_TextChanged;
            // 
            // txtNombreModificacion
            // 
            txtNombreModificacion.Location = new Point(141, 387);
            txtNombreModificacion.Name = "txtNombreModificacion";
            txtNombreModificacion.Size = new Size(224, 27);
            txtNombreModificacion.TabIndex = 93;
            // 
            // txtCurp
            // 
            txtCurp.Location = new Point(143, 116);
            txtCurp.Name = "txtCurp";
            txtCurp.Size = new Size(224, 27);
            txtCurp.TabIndex = 92;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(70, 305);
            label4.Name = "label4";
            label4.Size = new Size(65, 20);
            label4.TabIndex = 91;
            label4.Text = "Materno";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(416, 305);
            label5.Name = "label5";
            label5.Size = new Size(75, 20);
            label5.TabIndex = 90;
            label5.Text = "Municipio";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(397, 395);
            label6.Name = "label6";
            label6.Size = new Size(94, 20);
            label6.TabIndex = 89;
            label6.Text = "Nivel Escolar";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(437, 245);
            label7.Name = "label7";
            label7.Size = new Size(54, 20);
            label7.TabIndex = 88;
            label7.Text = "Correo";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(424, 116);
            label8.Name = "label8";
            label8.Size = new Size(67, 20);
            label8.TabIndex = 87;
            label8.Text = "Telefono";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(76, 242);
            label9.Name = "label9";
            label9.Size = new Size(59, 20);
            label9.TabIndex = 86;
            label9.Text = "Paterno";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(71, 387);
            label10.Name = "label10";
            label10.Size = new Size(64, 20);
            label10.TabIndex = 85;
            label10.Text = "Nombre";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(94, 123);
            label11.Name = "label11";
            label11.Size = new Size(40, 20);
            label11.TabIndex = 84;
            label11.Text = "Curp";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(968, 611);
            Controls.Add(gbxRegistroAlumno);
            Controls.Add(gbxModificacion);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Sistema de Tramites";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            gbxRegistroAlumno.ResumeLayout(false);
            gbxRegistroAlumno.PerformLayout();
            gbxModificacion.ResumeLayout(false);
            gbxModificacion.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem registrarToolStripMenuItem;
        private ToolStripMenuItem modificarToolStripMenuItem;
        private ToolStripMenuItem consultarToolStripMenuItem;
        private GroupBox gbxRegistroAlumno;
        private Button btnlimpiarRegistro;
        private Button btnGuardar;
        private TextBox textBox10;
        private Label label1;
        private TextBox textBox9;
        private Label lblTramite;
        private TextBox textBox8;
        private TextBox textBox7;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label lblMaterno;
        private Label lblMunicipio;
        private Label lblNvlEscolar;
        private Label lblCorreo;
        private Label lblTelefono;
        private Label lblApPaterno;
        private Label lblNombre;
        private Label lblCurp;
        private ToolStripMenuItem modoAdministradorToolStripMenuItem;
        private GroupBox gbxModificacion;
        private Button btnlimpio;
        private Button btnConsulta;
        private TextBox textBox11;
        private Label label2;
        private TextBox textBox12;
        private Label label3;
        private TextBox textBox13;
        private TextBox textBox14;
        private TextBox textBox15;
        private TextBox textBox16;
        private TextBox textBox17;
        private TextBox textBox18;
        private TextBox textBox19;
        private TextBox textBox20;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private GroupBox gbxConsulta;
        private Button btnLimpiar;
        private Button btnConsultar;
        private TextBox txtTurno;
        private TextBox txtCurp;
        private Label label17;
        private Label lblCurpConsulta;
        private ToolStripMenuItem salirToolStripMenuItem;
        private Label label12;
        private ListBox listBox1;
        private TextBox txtTipoTramiteRegistro;
        private TextBox txtNEscolarRegistro;
        private TextBox txtCorreoRegistro;
        private TextBox txtMatregistro;
        private TextBox txtPatRegistro;
        private TextBox txtNombreRegistro;
        private TextBox txtCurpRegistro;
        private Button btnGuardarCambios;
        private TextBox txtTipoTramite;
        private TextBox txtMunicipioModificacion;
        private TextBox TxtTelefonoModifacion;
        private TextBox txtNEscolarModificacion;
        private TextBox txtCorreoModificacion;
        private TextBox txtMaternoModificacion;
        private TextBox txtPaternoModificacion;
        private TextBox txtNombreModificacion;
        private ListBox listBox2;
        private TextBox txtMunicipioRegistro;
        private TextBox txtTelefonoregistro;
    }
}
