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
            consultarToolStripMenuItem = new ToolStripMenuItem();
            modoAdministradorToolStripMenuItem = new ToolStripMenuItem();
            gbxRegistroAlumno = new GroupBox();
            btnlimpiarRegistro = new Button();
            btnGuardar = new Button();
            textBox10 = new TextBox();
            label1 = new Label();
            textBox9 = new TextBox();
            lblTramite = new Label();
            textBox8 = new TextBox();
            textBox7 = new TextBox();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            lblMaterno = new Label();
            lblMunicipio = new Label();
            lblNvlEscolar = new Label();
            lblCorreo = new Label();
            lblTelefono = new Label();
            lblApPaterno = new Label();
            lblNombre = new Label();
            lblCurp = new Label();
            gbxConsulta = new GroupBox();
            btnLimpiar = new Button();
            btnConsultar = new Button();
            txtTurno = new TextBox();
            txtCurp = new TextBox();
            label17 = new Label();
            lblCurpConsulta = new Label();
            gbxModificacion = new GroupBox();
            btnlimpio = new Button();
            btnConsulta = new Button();
            textBox11 = new TextBox();
            label2 = new Label();
            textBox12 = new TextBox();
            label3 = new Label();
            textBox13 = new TextBox();
            textBox14 = new TextBox();
            textBox15 = new TextBox();
            textBox16 = new TextBox();
            textBox17 = new TextBox();
            textBox18 = new TextBox();
            textBox19 = new TextBox();
            textBox20 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            salirToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            gbxRegistroAlumno.SuspendLayout();
            gbxConsulta.SuspendLayout();
            gbxModificacion.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { registrarToolStripMenuItem, modificarToolStripMenuItem, consultarToolStripMenuItem, modoAdministradorToolStripMenuItem, salirToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(972, 28);
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
            // consultarToolStripMenuItem
            // 
            consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            consultarToolStripMenuItem.Size = new Size(85, 24);
            consultarToolStripMenuItem.Text = "Consultar";
            consultarToolStripMenuItem.Click += consultarToolStripMenuItem_Click;
            // 
            // modoAdministradorToolStripMenuItem
            // 
            modoAdministradorToolStripMenuItem.Name = "modoAdministradorToolStripMenuItem";
            modoAdministradorToolStripMenuItem.Size = new Size(162, 24);
            modoAdministradorToolStripMenuItem.Text = "Modo Administrador";
            modoAdministradorToolStripMenuItem.Click += modoAdministradorToolStripMenuItem_Click;
            // 
            // gbxRegistroAlumno
            // 
            gbxRegistroAlumno.Controls.Add(btnlimpiarRegistro);
            gbxRegistroAlumno.Controls.Add(btnGuardar);
            gbxRegistroAlumno.Controls.Add(textBox10);
            gbxRegistroAlumno.Controls.Add(label1);
            gbxRegistroAlumno.Controls.Add(textBox9);
            gbxRegistroAlumno.Controls.Add(lblTramite);
            gbxRegistroAlumno.Controls.Add(textBox8);
            gbxRegistroAlumno.Controls.Add(textBox7);
            gbxRegistroAlumno.Controls.Add(textBox6);
            gbxRegistroAlumno.Controls.Add(textBox5);
            gbxRegistroAlumno.Controls.Add(textBox4);
            gbxRegistroAlumno.Controls.Add(textBox3);
            gbxRegistroAlumno.Controls.Add(textBox2);
            gbxRegistroAlumno.Controls.Add(textBox1);
            gbxRegistroAlumno.Controls.Add(lblMaterno);
            gbxRegistroAlumno.Controls.Add(lblMunicipio);
            gbxRegistroAlumno.Controls.Add(lblNvlEscolar);
            gbxRegistroAlumno.Controls.Add(lblCorreo);
            gbxRegistroAlumno.Controls.Add(lblTelefono);
            gbxRegistroAlumno.Controls.Add(lblApPaterno);
            gbxRegistroAlumno.Controls.Add(lblNombre);
            gbxRegistroAlumno.Controls.Add(lblCurp);
            gbxRegistroAlumno.Location = new Point(33, 108);
            gbxRegistroAlumno.Name = "gbxRegistroAlumno";
            gbxRegistroAlumno.Size = new Size(869, 477);
            gbxRegistroAlumno.TabIndex = 84;
            gbxRegistroAlumno.TabStop = false;
            gbxRegistroAlumno.Text = "Registro del Alumno";
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
            // textBox10
            // 
            textBox10.Location = new Point(550, 348);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(224, 27);
            textBox10.TabIndex = 103;
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
            // textBox9
            // 
            textBox9.Location = new Point(152, 341);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(224, 27);
            textBox9.TabIndex = 101;
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
            // textBox8
            // 
            textBox8.Location = new Point(512, 265);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(224, 27);
            textBox8.TabIndex = 99;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(512, 202);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(224, 27);
            textBox7.TabIndex = 98;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(512, 138);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(224, 27);
            textBox6.TabIndex = 97;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(512, 70);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(224, 27);
            textBox5.TabIndex = 96;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(143, 258);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(224, 27);
            textBox4.TabIndex = 95;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(143, 202);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(224, 27);
            textBox3.TabIndex = 94;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(143, 131);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(224, 27);
            textBox2.TabIndex = 93;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(143, 63);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(224, 27);
            textBox1.TabIndex = 92;
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
            // gbxConsulta
            // 
            gbxConsulta.Controls.Add(btnLimpiar);
            gbxConsulta.Controls.Add(btnConsultar);
            gbxConsulta.Controls.Add(txtTurno);
            gbxConsulta.Controls.Add(txtCurp);
            gbxConsulta.Controls.Add(label17);
            gbxConsulta.Controls.Add(lblCurpConsulta);
            gbxConsulta.Location = new Point(33, 60);
            gbxConsulta.Name = "gbxConsulta";
            gbxConsulta.Size = new Size(869, 477);
            gbxConsulta.TabIndex = 86;
            gbxConsulta.TabStop = false;
            gbxConsulta.Text = "Consulta de datos del Alumno";
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(497, 182);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(94, 29);
            btnLimpiar.TabIndex = 105;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(223, 179);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(94, 29);
            btnConsultar.TabIndex = 104;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            // 
            // txtTurno
            // 
            txtTurno.Location = new Point(512, 70);
            txtTurno.Name = "txtTurno";
            txtTurno.Size = new Size(224, 27);
            txtTurno.TabIndex = 96;
            // 
            // txtCurp
            // 
            txtCurp.Location = new Point(143, 63);
            txtCurp.Name = "txtCurp";
            txtCurp.Size = new Size(224, 27);
            txtCurp.TabIndex = 92;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(437, 70);
            label17.Name = "label17";
            label17.Size = new Size(47, 20);
            label17.TabIndex = 88;
            label17.Text = "Turno";
            // 
            // lblCurpConsulta
            // 
            lblCurpConsulta.AutoSize = true;
            lblCurpConsulta.Location = new Point(95, 66);
            lblCurpConsulta.Name = "lblCurpConsulta";
            lblCurpConsulta.Size = new Size(40, 20);
            lblCurpConsulta.TabIndex = 84;
            lblCurpConsulta.Text = "Curp";
            // 
            // gbxModificacion
            // 
            gbxModificacion.Controls.Add(btnlimpio);
            gbxModificacion.Controls.Add(btnConsulta);
            gbxModificacion.Controls.Add(textBox11);
            gbxModificacion.Controls.Add(label2);
            gbxModificacion.Controls.Add(textBox12);
            gbxModificacion.Controls.Add(label3);
            gbxModificacion.Controls.Add(textBox13);
            gbxModificacion.Controls.Add(textBox14);
            gbxModificacion.Controls.Add(textBox15);
            gbxModificacion.Controls.Add(textBox16);
            gbxModificacion.Controls.Add(textBox17);
            gbxModificacion.Controls.Add(textBox18);
            gbxModificacion.Controls.Add(textBox19);
            gbxModificacion.Controls.Add(textBox20);
            gbxModificacion.Controls.Add(label4);
            gbxModificacion.Controls.Add(label5);
            gbxModificacion.Controls.Add(label6);
            gbxModificacion.Controls.Add(label7);
            gbxModificacion.Controls.Add(label8);
            gbxModificacion.Controls.Add(label9);
            gbxModificacion.Controls.Add(label10);
            gbxModificacion.Controls.Add(label11);
            gbxModificacion.Location = new Point(33, 66);
            gbxModificacion.Name = "gbxModificacion";
            gbxModificacion.Size = new Size(869, 477);
            gbxModificacion.TabIndex = 85;
            gbxModificacion.TabStop = false;
            gbxModificacion.Text = "Modificacion de datos del alumno";
            // 
            // btnlimpio
            // 
            btnlimpio.Location = new Point(732, 410);
            btnlimpio.Name = "btnlimpio";
            btnlimpio.Size = new Size(94, 29);
            btnlimpio.TabIndex = 105;
            btnlimpio.Text = "Limpiar";
            btnlimpio.UseVisualStyleBackColor = true;
            // 
            // btnConsulta
            // 
            btnConsulta.Location = new Point(550, 410);
            btnConsulta.Name = "btnConsulta";
            btnConsulta.Size = new Size(94, 29);
            btnConsulta.TabIndex = 104;
            btnConsulta.Text = "Guardar";
            btnConsulta.UseVisualStyleBackColor = true;
            // 
            // textBox11
            // 
            textBox11.Location = new Point(550, 348);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(224, 27);
            textBox11.TabIndex = 103;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(416, 348);
            label2.Name = "label2";
            label2.Size = new Size(99, 20);
            label2.TabIndex = 102;
            label2.Text = "Quien solicita";
            // 
            // textBox12
            // 
            textBox12.Location = new Point(152, 341);
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(224, 27);
            textBox12.TabIndex = 101;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 344);
            label3.Name = "label3";
            label3.Size = new Size(114, 20);
            label3.TabIndex = 100;
            label3.Text = "Tipo de Tramite";
            // 
            // textBox13
            // 
            textBox13.Location = new Point(512, 265);
            textBox13.Name = "textBox13";
            textBox13.Size = new Size(224, 27);
            textBox13.TabIndex = 99;
            // 
            // textBox14
            // 
            textBox14.Location = new Point(512, 202);
            textBox14.Name = "textBox14";
            textBox14.Size = new Size(224, 27);
            textBox14.TabIndex = 98;
            // 
            // textBox15
            // 
            textBox15.Location = new Point(512, 138);
            textBox15.Name = "textBox15";
            textBox15.Size = new Size(224, 27);
            textBox15.TabIndex = 97;
            // 
            // textBox16
            // 
            textBox16.Location = new Point(512, 70);
            textBox16.Name = "textBox16";
            textBox16.Size = new Size(224, 27);
            textBox16.TabIndex = 96;
            // 
            // textBox17
            // 
            textBox17.Location = new Point(143, 258);
            textBox17.Name = "textBox17";
            textBox17.Size = new Size(224, 27);
            textBox17.TabIndex = 95;
            // 
            // textBox18
            // 
            textBox18.Location = new Point(143, 202);
            textBox18.Name = "textBox18";
            textBox18.Size = new Size(224, 27);
            textBox18.TabIndex = 94;
            // 
            // textBox19
            // 
            textBox19.Location = new Point(143, 131);
            textBox19.Name = "textBox19";
            textBox19.Size = new Size(224, 27);
            textBox19.TabIndex = 93;
            // 
            // textBox20
            // 
            textBox20.Location = new Point(143, 63);
            textBox20.Name = "textBox20";
            textBox20.Size = new Size(224, 27);
            textBox20.TabIndex = 92;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(70, 265);
            label4.Name = "label4";
            label4.Size = new Size(65, 20);
            label4.TabIndex = 91;
            label4.Text = "Materno";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(416, 265);
            label5.Name = "label5";
            label5.Size = new Size(75, 20);
            label5.TabIndex = 90;
            label5.Text = "Municipio";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(397, 138);
            label6.Name = "label6";
            label6.Size = new Size(94, 20);
            label6.TabIndex = 89;
            label6.Text = "Nivel Escolar";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(437, 70);
            label7.Name = "label7";
            label7.Size = new Size(54, 20);
            label7.TabIndex = 88;
            label7.Text = "Correo";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(424, 202);
            label8.Name = "label8";
            label8.Size = new Size(67, 20);
            label8.TabIndex = 87;
            label8.Text = "Telefono";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(76, 202);
            label9.Name = "label9";
            label9.Size = new Size(59, 20);
            label9.TabIndex = 86;
            label9.Text = "Paterno";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(71, 138);
            label10.Name = "label10";
            label10.Size = new Size(64, 20);
            label10.TabIndex = 85;
            label10.Text = "Nombre";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(95, 66);
            label11.Name = "label11";
            label11.Size = new Size(40, 20);
            label11.TabIndex = 84;
            label11.Text = "Curp";
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(52, 24);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(972, 625);
            Controls.Add(gbxConsulta);
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
            gbxConsulta.ResumeLayout(false);
            gbxConsulta.PerformLayout();
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
    }
}
