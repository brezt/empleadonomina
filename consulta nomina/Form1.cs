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
    public partial class frmbusquedaempleado : Form
    {
        public frmbusquedaempleado()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bntBuscar_Click(object sender, EventArgs e)
        {
            busqueda();
        }

        public void busqueda() //Fucion para buscar//
        {
            Operaciones op = new Operaciones();
            
            if(rbtnid.Checked==true)
            {
                dgvempleado.DataSource = op.ConsultaConResultado("select * from empleados where idempleado like'%" + txtbuscar.Text.Trim() + "%'");
            }

            if (rbtnnombre.Checked == true)
            {
                dgvempleado.DataSource = op.ConsultaConResultado("select * from empleados where nombreempleado like'%" + txtbuscar.Text.Trim() + "%'");
            }

            if (rbtnapellido.Checked == true)
            {
                dgvempleado.DataSource = op.ConsultaConResultado("select * from empleados where apellidoempleado like'%" + txtbuscar.Text.Trim() + "%'");
            }

            if (rbtncedula.Checked == true)
            {
                dgvempleado.DataSource = op.ConsultaConResultado("select * from empleados where cedulaempleado like'%" + txtbuscar.Text.Trim() + "%'");
            }

            else if (txtbuscar.Text.Length == 0)
            {
                dgvempleado.DataSource = op.ConsultaConResultado("select * from empleados");
            }
            
        }
        private void dgvempleado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvempleado.AllowUserToAddRows = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Operaciones op = new Operaciones();
            op.Conectar();
            
            dgvempleado.DataSource = op.ConsultaConResultado("select * from empleados");
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            busqueda();
        }

        private void btncrear_Click(object sender, EventArgs e)
        {
            frmEmpleado em = new frmEmpleado();
            em.Show();
        }

        private void dgvempleado_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dgvempleado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmEmpleado emp = new frmEmpleado();
            DataGridViewRow rellenar = dgvempleado.Rows[e.RowIndex];
            emp.txtsueldo.Text = rellenar.Cells["sueldoempleado"].Value.ToString();
            emp.cmbcargo.Text = rellenar.Cells["idcargo"].Value.ToString();
            emp.cmbdepartamento.Text = rellenar.Cells["iddepartmento"].Value.ToString();
            emp.cmbestado.Text = rellenar.Cells["idestado"].Value.ToString();
            emp.txtdescriccion.Text = rellenar.Cells["descriempleado"].Value.ToString();
            emp.txtnombre.Text= rellenar.Cells["nombreempleado"].Value.ToString();
            emp.txtapellido.Text = rellenar.Cells["apellidoempleado"].Value.ToString();
            emp.txtcedula.Text = rellenar.Cells["cedulaempleado"].Value.ToString();
            emp.txttelefono.Text = rellenar.Cells["telefonoempleado"].Value.ToString();
            emp.cmbsexo.Text = rellenar.Cells["sexoempleado"].Value.ToString();
            emp.txtdireccion.Text = rellenar.Cells["direccionempleado"].Value.ToString();
            emp.txtfechanacimiento.Text = rellenar.Cells["fechanacimiento"].Value.ToString();
            emp.txtfechaingreso.Text = rellenar.Cells["fechaingreso"].Value.ToString();
            emp.txtid.Text = rellenar.Cells["idempleado"].Value.ToString();

            emp.Show();
        }
    }
}
