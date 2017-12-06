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
    public partial class frmCrudNomina : Form
    {
        public frmCrudNomina()
        {
            InitializeComponent();
        }

        private void frmCrudNomina_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            btnCrear.Enabled = true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnGenerarNomina_Click(object sender, EventArgs e)
        {
            
            cargarDatos();
            calculos();
        }
        public void cargarDatos()
        {
            Operaciones op = new Operaciones();
            dgvDetalleNomina.DataSource = op.ConsultaConResultado("select empleados.idempleado, empleados.nombreempleado, empleados.apellidoempleado, empleados.sueldoempleado, empleados.cedulaempleado, cargo.descricargo, (empleados.sueldoempleado*0.12) ISR, (empleados.sueldoempleado*0.4) SS, (empleados.sueldoempleado*0.02) Ahorros, ((empleados.sueldoempleado*0.012)+(empleados.sueldoempleado*0.012)+(empleados.sueldoempleado*0.04)+(empleados.sueldoempleado*0.02)) 'Total Deducc', ((empleados.sueldoempleado)-((empleados.sueldoempleado*0.12)+(empleados.sueldoempleado*0.04)+(empleados.sueldoempleado*0.02))) 'Sueldo Neto' from empleados inner join cargo on empleados.idcargo=cargo.idcargo");

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {

            busquedaNomina bn = new busquedaNomina();
            generaNomina();
            
        }
        public void calculos()
        {
                float totalDeducciones = 0;
                float totalNomina = 0;
                 float isrTotal = 0;
            float ssTotal = 0;
            float otrosTotal = 0;
            float netosueldo =0;
            int numeroNomina=0;
           
            

            for (int a = 0; a < dgvDetalleNomina.Rows.Count - 1; a++)
            {

                totalDeducciones += float.Parse(dgvDetalleNomina.Rows[a].Cells["Total Deducc"].Value.ToString());
                totalNomina += float.Parse(dgvDetalleNomina.Rows[a].Cells["sueldoempleado"].Value.ToString());
                isrTotal+= float.Parse(dgvDetalleNomina.Rows[a].Cells["ISR"].Value.ToString());
                ssTotal+= float.Parse(dgvDetalleNomina.Rows[a].Cells["SS"].Value.ToString());
                otrosTotal+= float.Parse(dgvDetalleNomina.Rows[a].Cells["Ahorros"].Value.ToString());
                netosueldo = float.Parse(dgvDetalleNomina.Rows[a].Cells["Sueldo Neto"].Value.ToString());
                numeroNomina = Convert.ToInt32( txtNumeroNomina.Text);


            }

            txtTotalDeducciones.Text = totalDeducciones.ToString();
            txtTotalNomina.Text = totalNomina.ToString();

            float totaldedu = float.Parse(txtTotalDeducciones.Text);
            float totalNom = float.Parse(txtTotalNomina.Text);
            Operaciones op = new Operaciones();

           op.ConsultasSinResultados("insert into cabecera_nomina (codigonomina, fechainicio, fechafin, sueldototal, isrtotal, sstotal, otrosdescuentos, deduciontotal, netotal, nominafecha, status, tipo) values ('"+numeroNomina+"', '"+txtDesde.Text+"', '"+txtHasta.Text+"', '"+totalNom +"', '"+isrTotal+"', '"+ssTotal+"', '"+otrosTotal+"','"+totaldedu+"', '"+netosueldo+"','10/11/2013', '"+cmbStatus.Text+"', '"+cmbTipo.Text+"')");

            
        }

        public bool valida()
        {

            if (cmbTipo.Text == "".Trim())
            {
                MessageBox.Show("POR FAVOR SELECCIONE EL TIPO DE NOMINA");

                return false;
            }

            if (cmbStatus.Text == "".Trim())
            {
                MessageBox.Show("POR FAVOR SELECCIONE EL STATUS");
                
                return false;
            }

           

            if (txtNumeroNomina.Text == "".Trim())
            {
                MessageBox.Show("POR FAVOR ESCRIBA EL NUMERO DE NOMINA");
                txtNumeroNomina.Focus();
                return false;
            }

            return true;
        }


     public float isr = 0;
        public float ss = 0;
        public float otros = 0;
        public float neto = 0;
        public float sueldo = 0;
        public  int idEmpleado = 0;
        public int numeroNomina = 0;

        public void generaNomina()
        {

            Operaciones op = new Operaciones();

            if (valida())
            {
                for (int a = 0; a < dgvDetalleNomina.Rows.Count - 1; a++)
                {

                    idEmpleado = Convert.ToInt32(dgvDetalleNomina.Rows[a].Cells["idempleado"].Value.ToString());
                    isr = float.Parse(dgvDetalleNomina.Rows[a].Cells["ISR"].Value.ToString());
                    ss = float.Parse(dgvDetalleNomina.Rows[a].Cells["SS"].Value.ToString());
                    otros = float.Parse(dgvDetalleNomina.Rows[a].Cells["Ahorros"].Value.ToString());
                    sueldo = float.Parse(dgvDetalleNomina.Rows[a].Cells["sueldoempleado"].Value.ToString());
                    neto = float.Parse(dgvDetalleNomina.Rows[a].Cells["Sueldo Neto"].Value.ToString());
                    numeroNomina = Convert.ToInt16(txtNumeroNomina.Text);

                    op.ConsultasSinResultados("insert into Detalle_nomina (codnomina, idempledo, sueldoempleado, isr, ss, otrosdescuentos, neto) values( '" + numeroNomina + "','" + idEmpleado + "','" + sueldo + "', '" + isr + "', '" + ss + "', '" + otros + "', '" + neto + "')");


                }
                MessageBox.Show("Nomina Guardada");
                this.Close();


            }
        }

        private void dgvDetalleNomina_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
          /*  if (MessageBox.Show("SEGURO QUE DECEA MODIFICAR ESTE REGISTRO?", "ACTUALIZAR NOMINA", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes) ;
            Operaciones op = new Operaciones();
            op.ConsultasSinResultados("UPDATE cabecera_nomina SET tipo ='" + cmbTipo.Text + "', status = '" + cmbStatus.Text + "', fechainicio ='" + txtDesde.Text + "', fechafin ='" + txtHasta.Text + "'WHERE codigonomina like'%" + txtNumeroNomina.Text + "%' ");
*/
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            Operaciones op = new Operaciones();
           

            if (MessageBox.Show("SEGURO QUE DESEA ELIMINAR ESTE REGISTRO?", "ELIMINAR ", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)

            {
                op.ConsultasSinResultados("DELETE FROM cabecera_nomina WHERE codigonomina like'%" + txtNumeroNomina.Text + "%'");
                op.ConsultasSinResultados("DELETE FROM Detalle_nomina WHERE codigonomina ='%" + txtNumeroNomina.Text + "%'");
            }
        }
    }
}
