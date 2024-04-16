namespace ProyectoParcial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gbxRegistroAlumno.Visible = true;
            gbxModificacion.Visible = false;
            gbxConsulta.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gbxRegistroAlumno.Visible = false;
            gbxConsulta.Visible = false;
            gbxModificacion.Visible = false;
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gbxModificacion.Visible = true;
            gbxRegistroAlumno.Visible = false;
            gbxConsulta.Visible = false;
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            gbxModificacion.Visible = false;
            gbxRegistroAlumno.Visible = false;
            gbxConsulta.Visible = true;
        }

        private void modoAdministradorToolStripMenuItem_Click(object sender, EventArgs e)
        {

            login loginForm = new login();
            loginForm.Show();
            this.Hide();

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
