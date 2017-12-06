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

        private void cargoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBusquedaCargo bc = new frmBusquedaCargo();
            bc.Show();
        }

        private void cargoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmCargo ca = new frmCargo();
            ca.Show();
        }

        private void noToolStripMenuItem_Click(object sender, EventArgs e)
        {
            busquedaNomina bn = new busquedaNomina();
            bn.Show();
        }

        private void nominaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCrudNomina cn = new frmCrudNomina();
            cn.Show();
        }

        private void departamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDepartamento dp = new frmDepartamento();
            dp.Show();

        }

        private void departamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmbusquedadepartamento bd = new frmbusquedadepartamento();
            bd.Show();
        }

        private void departamentoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmbusquedadepartamento bd = new frmbusquedadepartamento();
            bd.Show();
        }
    }
}
