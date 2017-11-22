using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace consulta_nomina
{
    public partial class inicio : Form
    {
        public inicio()
        {
            InitializeComponent();
        }

        private void buscarNominaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form consulta = new frmbusquedaempleado();
            consulta.Show();
        }

        private void crearEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form crear = new frmEmpleado();
            crear.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit ();
        }
    }
}
