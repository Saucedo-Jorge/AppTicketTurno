namespace ProyectoParcial
{
    partial class RegistroAlumno
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
            menuStrip1 = new MenuStrip();
            menuStrip2 = new MenuStrip();
            municipiosToolStripMenuItem = new ToolStripMenuItem();
            registroDeTurnosToolStripMenuItem = new ToolStripMenuItem();
            gbxMunicipios = new GroupBox();
            btnAgregarMunicipio = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            btnLimpiarMunicipio = new Button();
            txtNombreMunicipio = new TextBox();
            txtIdMunicipio = new TextBox();
            label2 = new Label();
            label1 = new Label();
            gbxTurnos = new GroupBox();
            rbtnPendientes = new RadioButton();
            rbtnResueltos = new RadioButton();
            dataGridView1 = new DataGridView();
            salirToolStripMenuItem = new ToolStripMenuItem();
            menuStrip2.SuspendLayout();
            gbxMunicipios.SuspendLayout();
            gbxTurnos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Location = new Point(0, 33);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(762, 24);
            menuStrip1.TabIndex = 62;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            menuStrip2.ImageScalingSize = new Size(20, 20);
            menuStrip2.Items.AddRange(new ToolStripItem[] { municipiosToolStripMenuItem, registroDeTurnosToolStripMenuItem, salirToolStripMenuItem });
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(762, 33);
            menuStrip2.TabIndex = 63;
            menuStrip2.Text = "menuStrip2";
            // 
            // municipiosToolStripMenuItem
            // 
            municipiosToolStripMenuItem.Font = new Font("Segoe UI", 10.8F);
            municipiosToolStripMenuItem.Name = "municipiosToolStripMenuItem";
            municipiosToolStripMenuItem.Size = new Size(112, 29);
            municipiosToolStripMenuItem.Text = "Municipios";
            municipiosToolStripMenuItem.Click += municipiosToolStripMenuItem_Click;
            // 
            // registroDeTurnosToolStripMenuItem
            // 
            registroDeTurnosToolStripMenuItem.Font = new Font("Segoe UI", 10.8F);
            registroDeTurnosToolStripMenuItem.Name = "registroDeTurnosToolStripMenuItem";
            registroDeTurnosToolStripMenuItem.Size = new Size(172, 29);
            registroDeTurnosToolStripMenuItem.Text = "Registro de turnos";
            registroDeTurnosToolStripMenuItem.Click += registroDeTurnosToolStripMenuItem_Click;
            // 
            // gbxMunicipios
            // 
            gbxMunicipios.Controls.Add(btnAgregarMunicipio);
            gbxMunicipios.Controls.Add(btnModificar);
            gbxMunicipios.Controls.Add(btnEliminar);
            gbxMunicipios.Controls.Add(btnLimpiarMunicipio);
            gbxMunicipios.Controls.Add(txtNombreMunicipio);
            gbxMunicipios.Controls.Add(txtIdMunicipio);
            gbxMunicipios.Controls.Add(label2);
            gbxMunicipios.Controls.Add(label1);
            gbxMunicipios.Font = new Font("Segoe UI", 10.8F);
            gbxMunicipios.Location = new Point(48, 93);
            gbxMunicipios.Name = "gbxMunicipios";
            gbxMunicipios.Size = new Size(654, 283);
            gbxMunicipios.TabIndex = 64;
            gbxMunicipios.TabStop = false;
            gbxMunicipios.Text = "Tabla Municipios";
            // 
            // btnAgregarMunicipio
            // 
            btnAgregarMunicipio.Font = new Font("Segoe UI", 10.8F);
            btnAgregarMunicipio.Location = new Point(448, 56);
            btnAgregarMunicipio.Name = "btnAgregarMunicipio";
            btnAgregarMunicipio.Size = new Size(155, 44);
            btnAgregarMunicipio.TabIndex = 7;
            btnAgregarMunicipio.Text = "Agregar";
            btnAgregarMunicipio.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            btnModificar.Font = new Font("Segoe UI", 10.8F);
            btnModificar.Location = new Point(448, 135);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(155, 44);
            btnModificar.TabIndex = 6;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Segoe UI", 10.8F);
            btnEliminar.Location = new Point(448, 211);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(155, 44);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnLimpiarMunicipio
            // 
            btnLimpiarMunicipio.Font = new Font("Segoe UI", 10.8F);
            btnLimpiarMunicipio.Location = new Point(287, 211);
            btnLimpiarMunicipio.Name = "btnLimpiarMunicipio";
            btnLimpiarMunicipio.Size = new Size(155, 44);
            btnLimpiarMunicipio.TabIndex = 4;
            btnLimpiarMunicipio.Text = "Limpiar";
            btnLimpiarMunicipio.UseVisualStyleBackColor = true;
            // 
            // txtNombreMunicipio
            // 
            txtNombreMunicipio.Font = new Font("Segoe UI", 10.8F);
            txtNombreMunicipio.Location = new Point(183, 145);
            txtNombreMunicipio.Name = "txtNombreMunicipio";
            txtNombreMunicipio.Size = new Size(186, 31);
            txtNombreMunicipio.TabIndex = 3;
            // 
            // txtIdMunicipio
            // 
            txtIdMunicipio.Font = new Font("Segoe UI", 10.8F);
            txtIdMunicipio.Location = new Point(183, 72);
            txtIdMunicipio.Name = "txtIdMunicipio";
            txtIdMunicipio.Size = new Size(186, 31);
            txtIdMunicipio.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F);
            label2.Location = new Point(6, 145);
            label2.Name = "label2";
            label2.Size = new Size(161, 25);
            label2.TabIndex = 1;
            label2.Text = "Nombre Municipio";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F);
            label1.Location = new Point(58, 75);
            label1.Name = "label1";
            label1.Size = new Size(113, 25);
            label1.TabIndex = 0;
            label1.Text = "ID Municipio";
            // 
            // gbxTurnos
            // 
            gbxTurnos.Controls.Add(rbtnPendientes);
            gbxTurnos.Controls.Add(rbtnResueltos);
            gbxTurnos.Controls.Add(dataGridView1);
            gbxTurnos.Location = new Point(54, 93);
            gbxTurnos.Name = "gbxTurnos";
            gbxTurnos.Size = new Size(648, 283);
            gbxTurnos.TabIndex = 65;
            gbxTurnos.TabStop = false;
            gbxTurnos.Text = "Tabla Turnos";
            // 
            // rbtnPendientes
            // 
            rbtnPendientes.AutoSize = true;
            rbtnPendientes.Location = new Point(511, 185);
            rbtnPendientes.Name = "rbtnPendientes";
            rbtnPendientes.Size = new Size(101, 24);
            rbtnPendientes.TabIndex = 2;
            rbtnPendientes.TabStop = true;
            rbtnPendientes.Text = "Pendientes";
            rbtnPendientes.UseVisualStyleBackColor = true;
            // 
            // rbtnResueltos
            // 
            rbtnResueltos.AutoSize = true;
            rbtnResueltos.Location = new Point(511, 105);
            rbtnResueltos.Name = "rbtnResueltos";
            rbtnResueltos.Size = new Size(93, 24);
            rbtnResueltos.TabIndex = 1;
            rbtnResueltos.TabStop = true;
            rbtnResueltos.Text = "Resueltos";
            rbtnResueltos.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(41, 56);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(424, 199);
            dataGridView1.TabIndex = 0;
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(52, 29);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // RegistroAlumno
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(762, 503);
            Controls.Add(gbxTurnos);
            Controls.Add(gbxMunicipios);
            Controls.Add(menuStrip1);
            Controls.Add(menuStrip2);
            MainMenuStrip = menuStrip1;
            Name = "RegistroAlumno";
            Text = "                                                                 Modo Administrador";
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            gbxMunicipios.ResumeLayout(false);
            gbxMunicipios.PerformLayout();
            gbxTurnos.ResumeLayout(false);
            gbxTurnos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem municipiosToolStripMenuItem;
        private ToolStripMenuItem registroDeTurnosToolStripMenuItem;
        private GroupBox gbxMunicipios;
        private Label label2;
        private Label label1;
        private Button btnAgregarMunicipio;
        private Button btnModificar;
        private Button btnEliminar;
        private Button btnLimpiarMunicipio;
        private TextBox txtNombreMunicipio;
        private TextBox txtIdMunicipio;
        private GroupBox gbxTurnos;
        private RadioButton rbtnPendientes;
        private RadioButton rbtnResueltos;
        private DataGridView dataGridView1;
        private ToolStripMenuItem salirToolStripMenuItem;
    }
}