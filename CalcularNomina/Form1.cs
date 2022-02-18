using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcularNomina
{
    public partial class Form1 : Form
    {
        Emplado myEmplado = new Emplado();
        Nomina myNomina = new Nomina();
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAlmacenarRegistro_Click(object sender, EventArgs e)
        {
            // Valida que se ingrese un dato
            if (txtNombre.Text == "")
            {
                error1.SetError(txtNombre, "Debe ingresar un nombre");
                txtNombre.Focus();
                return;
            }
            error1.SetError(txtNombre, "");

            // validar que solo permita ingresar datos numericos

            decimal AsignacionDia;
            if(!Decimal.TryParse(txtAsignacionSaldoDia.Text,out AsignacionDia))
            {
                error1.SetError(txtAsignacionSaldoDia, "Debe ingresar un numero");
                txtNombre.Focus();
                return;
            }
            error1.SetError(txtAsignacionSaldoDia, "");

            myEmplado.Nombre = txtNombre.Text;
            myEmplado.Identificacion = txtIdentificacion.Text;
            myEmplado.AsignacionDia = Convert.ToDecimal(txtAsignacionSaldoDia.Text);
            myNomina.DiasLaborados = Convert.ToInt32(txtDiasLaborados.Text);
            MessageBox.Show("Se guardo el resistro correctamente");

        }

        private void btnCalcularSalario_Click(object sender, EventArgs e)
        {
            txtTotalDevengado.Text = myNomina.CalcularNomina(Convert.ToInt32(myNomina.DiasLaborados), 
                Convert.ToDecimal(myEmplado.AsignacionDia)).ToString();
            
               
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtIdentificacion.Clear();
            txtAsignacionSaldoDia.Clear();
            txtDiasLaborados.Clear();
            txtTotalDevengado.Clear();
        }
    }
}
