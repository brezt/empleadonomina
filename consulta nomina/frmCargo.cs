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
    public partial class frmCargo : Form
    {
        public frmCargo()
        {
            InitializeComponent();
        }

        private void btncrear_Click(object sender, EventArgs e)
        {
            if (txtdescriccion.Text == "")
            {

                MessageBox.Show("Por favor escriba el cargo");


            }
            //Conexion a la Base de Datos//
            else
            {
                Operaciones op = new Operaciones();
                op.ConsultasSinResultados("insert into cargo(descricargo) values('" + txtdescriccion.Text + "')");
                MessageBox.Show("DATOS GUARDADOS");
                txtdescriccion.Text = "";
            }
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("SEGURO QUE DECEA MODIFICAR ESTE REGISTRO?", "ACTUALIZAR CARGO", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes) ;
            Operaciones op = new Operaciones();
            op.ConsultasSinResultados("UPDATE cargo SET descricargo ='" + txtdescriccion.Text + "'where idcargo = '"+txtId.Text+"'");

        }

        private void frmCargo_Load(object sender, EventArgs e)
        {
            if(txtId.Text=="")
            {

                btncrear.Enabled = true;
                btnguardar.Enabled = false;
                btneliminar.Enabled = false;
            }
            else
            {
                btncrear.Enabled = false;
                btnguardar.Enabled = true;
                btneliminar.Enabled = true;
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            Operaciones op = new Operaciones();
            frmCargo ca = new frmCargo();

            if (MessageBox.Show("SEGURO QUE DESEA ELIMINAR ESTE REGISTRO?", "ELIMINAR ", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)

            {
                op.ConsultasSinResultados("DELETE FROM cargo WHERE idcargo = '" + txtId.Text + "'");
                txtdescriccion.Text = "";
            }
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtdescriccion_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
