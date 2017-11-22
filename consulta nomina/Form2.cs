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
    public partial class frmEmpleado : Form
    {
        public frmEmpleado()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Apellido_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtfechanac_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnedad_Click(object sender, EventArgs e)
        {
            if (txtfechanacimiento.Text == "  /  /")
            {
                MessageBox.Show("ENTRE UNA FECHA DE NACIMIENTO PARA CALCULAR LA EDAD", "SIN FECHA DE NACIMIENTO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtfechanacimiento.Focus();
            }
            else
            {
                string nac = txtfechanacimiento.Text;
                DateTime a = Convert.ToDateTime(nac);
                int edad = DateTime.Today.AddTicks(-a.Ticks).Year - 1;
                txtedad.Text = Convert.ToString(edad + "  AÑOS DE EDAD");
            }

        }

        private void txtfechanacimiento_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnantiguedad_Click(object sender, EventArgs e)
        {
            if (txtfechaingreso.Text == "  /  /")
            {
                MessageBox.Show("ENTRE UNA FECHA DE INGRESO PARA PODER CARCULAR SU ANTIGUEDAD", "SIN FECHA DE INGRESO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtfechaingreso.Focus();
            }
            else
            {
                string ant = txtfechaingreso.Text;
                DateTime a = Convert.ToDateTime(ant);
                int antiguedad = DateTime.Today.AddTicks(-a.Ticks).Year - 1;
                txtantiguedad.Text = Convert.ToString(antiguedad + "  AÑOS DE ANTIGUEDAD");
            }
        }

        private void btncrear_Click(object sender, EventArgs e)
        {
            if (validarcampos())
            {


                Operaciones op = new Operaciones();
                op.ConsultasSinResultados("insert into empleados(sueldoempleado, idcargo, iddepartmento, idestado,descriempleado, nombreempleado, apellidoempleado, cedulaempleado, sexoempleado, direccionempleado,telefonoempleado,fechanacimiento,fechaingreso)values ('" + txtsueldo.Text + "', 1, 2, 1, '" + txtdescriccion.Text + "', '" + txtnombre.Text + "', '" + txtapellido.Text + "', '" + txtcedula.Text + "', '" + cmbsexo.Text + "', '" + txtdireccion.Text + "','" + txttelefono.Text + "', '" + txtfechanacimiento.Text + "', '" + txtfechaingreso.Text + "')");
                MessageBox.Show("DATOS GUARDADOS");
                borrar();
            }
        }
        public void borrar()
        {
            txtnombre.Clear();
            txtapellido.Clear();
            txtsueldo.Clear();
            txtfechanacimiento.Clear();
            txtfechaingreso.Clear();
            txtcedula.Clear();
            txtdireccion.Clear();
            txttelefono.Clear();
            txtdescriccion.Clear();
            txtsueldo.Clear();
            cmbsexo.SelectedIndex = -1;
        }
        private Boolean validarcampos()
        {
            if (txtnombre.Text == "".Trim())
            {
                MessageBox.Show("POR FAVOR ESCRIBA EL NOMBRE", "ESCRIBIR NOMBRE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtnombre.Focus();
                return false;
                                
            }
            if  (txtapellido.Text == "".Trim())
                {
                    MessageBox.Show("POR FAVOR ESCRIBA EL APELLIDO", "ESCRIBIR APELLIDO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtapellido.Focus();
                    return false;

                }
            if (cmbsexo.Text == "".Trim())
            {
                MessageBox.Show("POR FAVOR ESCRIBA EL SEXO", "ESCRIBIR SEXO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbsexo.Focus();
                return false;

            }
            if (txtfechanacimiento.Text == "  /  /")
            {
                MessageBox.Show("POR FAVOR ESCRIBA LA FECHA DE NACIMIENTO", "ESCRIBIR FECHA DE NACIMIENTO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtfechanacimiento.Focus();
                return false;

            }
            if (txtfechaingreso.Text == "  /  /")
            {
                MessageBox.Show("POR FAVOR ESCRIBA LA FECHA DE INGRESO", "ESCRIBIR FECHA DE INGRESO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtfechaingreso.Focus();
                return false;

            }
            if (txtcedula.Text == "   -      -")
            {
                MessageBox.Show("POR FAVOR ESCRIBA LA CEDULA DE IDENTIDAD", "ESCRIBIR CEDULA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtcedula.Focus();
                return false;

            }
            if (txtdireccion.Text == "".Trim())
            {
                MessageBox.Show("POR FAVOR ESCRIBA LA DIRECCION", "ESCRIBIR LA DIRECCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtdireccion.Focus();
                return false;

            }
            if (txttelefono.Text == "   -   -")
            {
                MessageBox.Show("POR FAVOR ESCRIBA EL NUMERO DE TELEFONO", "ESCRIBIR NUMERO DE TELEFONO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txttelefono.Focus();
                return false;

            }
            if (txtsueldo.Text == "".Trim())
            {
                MessageBox.Show("POR FAVOR ESCRIBA EL SUELDO", "ESCRIBIR SUELDO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtsueldo.Focus();
                return false;

            }
            /*if (cmbcargo.Text == "".Trim())
            {
                MessageBox.Show("POR FAVOR ESCRIBA EL CARGO", "ESCRIBIR CARGO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbcargo.Focus();
                return false; 

            
            
            }*/
            else

                return true;

            

        }
        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbntelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("SEGURO QUE DECEA MODIFICAR ESTE REGISTRO?", "ACTUALIZAR EMPLEADO", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes) ;
                Operaciones op = new Operaciones();
            op.ConsultasSinResultados("UPDATE empleados SET sueldoempleado ='" + txtsueldo.Text + "', idcargo = '" + cmbcargo.Text + "', iddepartmento = '" + cmbdepartamento.Text + "', idestado = '" + cmbestado.Text + "', descriempleado = '" + txtdescriccion.Text + "', nombreempleado = '" + txtnombre.Text + "', apellidoempleado = '" + txtapellido.Text + "', cedulaempleado = '" + txtcedula.Text + "', sexoempleado = '" + cmbsexo.Text +"', direccionempleado = '" + txtdireccion.Text + "', telefonoempleado = '" + txttelefono.Text + "', fechanacimiento = '" + txtfechanacimiento.Text + "', fechaingreso = '" + txtfechaingreso.Text + "'WHERE idempleado = '" + txtid.Text + "' ");
        }

        private void frmEmpleado_Load(object sender, EventArgs e)
        {
            Operaciones op = new Operaciones();
            

            if (txtid.Text=="")
            {
                btncrear.Enabled = true;
                btnguardar.Enabled = false;
            }

            else
            {
                btncrear.Enabled = false;
                btnguardar.Enabled = true;

            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            Operaciones op = new Operaciones();
            frmEmpleado emp = new frmEmpleado();

            if (MessageBox.Show("SEGURO QUE DESEA ELIMINAR ESTE REGISTRO?", "ELIMINAR ", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)

            {
                op.ConsultasSinResultados("DELETE FROM empleados WHERE idempleado = '" + txtid.Text + "'");
            }
            }

        private void btnimagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter =

            "Archivo JPG|*.jpg";


            if (fileDialog.ShowDialog() == DialogResult.OK)
            {

                pictureBox1.Image =

                Image.FromFile(fileDialog.FileName);
            }

        }
    }
    
}

