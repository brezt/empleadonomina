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
    public partial class frmBusquedaCargo : Form
    {
        public frmBusquedaCargo()
        {
            InitializeComponent();
        }

        private void frmBusquedaCargo_Load(object sender, EventArgs e)
        {
            Operaciones op = new Operaciones();
            dgvcargo.DataSource = op.ConsultaConResultado("select * from cargo");
        }

        private void bntBuscar_Click(object sender, EventArgs e)
        {
            if (rbtnCargo.Checked == true)
            {
                Operaciones op = new Operaciones();
                dgvcargo.DataSource = op.ConsultaConResultado("select * from cargo where descricargo like '%"+txtBuscar.Text+"%'");
            }

            else if(rbtnId.Checked==true)
            {
                Operaciones op = new Operaciones();
                dgvcargo.DataSource = op.ConsultaConResultado("select * from cargo where idcargo like '%" + txtBuscar.Text + "%'");
            }
            

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (rbtnCargo.Checked == true)
            {
                Operaciones op = new Operaciones();
                dgvcargo.DataSource = op.ConsultaConResultado("select * from cargo where descricargo like '%" + txtBuscar.Text + "%'");
            }

            else if (rbtnId.Checked == true)
            {
                Operaciones op = new Operaciones();
                dgvcargo.DataSource = op.ConsultaConResultado("select * from cargo where idcargo like '%" + txtBuscar.Text + "%'");
            }
        }

        private void btncrear_Click(object sender, EventArgs e)
        {
            frmCargo ca = new frmCargo();
            ca.Show();
        }

        private void dgvcargo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmCargo car = new frmCargo();
            DataGridViewRow rellenar = dgvcargo.Rows[e.RowIndex];
            car.txtId.Text = rellenar.Cells["idcargo"].Value.ToString();
            car.txtdescriccion.Text = rellenar.Cells["descricargo"].Value.ToString();
            car.Show();
        }

        private void dgvcargo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void rbtnId_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtnCargo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnimprimir_Click(object sender, EventArgs e)
        {

        }
    }
}
