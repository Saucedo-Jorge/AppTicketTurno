using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoParcial
{
    public partial class RegistroAlumno : Form
    {
        public RegistroAlumno()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void municipiosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gbxMunicipios.Visible = true;
            gbxTurnos.Visible = false;
        }

        private void registroDeTurnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gbxTurnos.Visible = true;
            gbxMunicipios.Visible = false;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            login log = new login();
            log.Show();
            this.Hide();
        }
    }
}
