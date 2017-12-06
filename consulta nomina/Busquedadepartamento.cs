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
    public partial class frmbusquedadepartamento : Form
    {
        public frmbusquedadepartamento()
        {
            InitializeComponent();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)//busqueda en departamento
        {
            if (rbtnCargo.Checked == true)
            {
                Operaciones op = new Operaciones();
                dgvdepartamento.DataSource = op.ConsultaConResultado("select * from deprtamentos where descridepartamento like '%" + txtBuscar.Text + "%'");
            }

            else if (rbtnId.Checked == true)
            {
                Operaciones op = new Operaciones();
                dgvdepartamento.DataSource = op.ConsultaConResultado("select * from deprtamentos where iddepartamento like '%" + txtBuscar.Text + "%'");
            }
        }

        private void bntBuscar_Click(object sender, EventArgs e)
        {
            if (rbtnCargo.Checked == true)
            {
                Operaciones op = new Operaciones();
                dgvdepartamento.DataSource = op.ConsultaConResultado("select * from deprtamentos where descridepartamento like '%" + txtBuscar.Text + "%'");
            }

            else if (rbtnId.Checked == true)
            {
                Operaciones op = new Operaciones();
                dgvdepartamento.DataSource = op.ConsultaConResultado("select * from deprtamentos where iddepartamento like '%" + txtBuscar.Text + "%'");
            }

        }

        private void dgvdepartamento_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //llamar a formulario frmdepartamento en el boton crear 
        private void btncrear_Click(object sender, EventArgs e)
        {
            frmDepartamento dp = new frmDepartamento();
            dp.Show();
        }
    }
}
