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
    public partial class frmDepartamento : Form
    {
        public frmDepartamento()
        {
            InitializeComponent();
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void btncrear_Click(object sender, EventArgs e)
        {
            if (txtdescriccion.Text == "")
            {

                MessageBox.Show("Por favor escriba el Departamento");


            }
            else
            {
                Operaciones op = new Operaciones();
                op.ConsultasSinResultados("insert into deprtamentos (descridepartamento) values('" + txtdescriccion.Text + "')");
                MessageBox.Show("DATOS GUARDADOS");
                txtdescriccion.Text = "";
            }
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("SEGURO QUE DECEA MODIFICAR ESTE REGISTRO?", "ACTUALIZAR DEPARTAMENTO", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes) ;
            Operaciones dp = new Operaciones();
            dp.ConsultasSinResultados("UPDATE cargo SET descridepartamento ='" + txtdescriccion.Text + "'where iddepartamento = '" + txtId.Text + "'");
        }

        private void frmDepartamento_Load(object sender, EventArgs e)
        {
            if (txtId.Text == "")
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
    }
}
