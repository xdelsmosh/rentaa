using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//estebann leall
namespace BancaRota
{
    public partial class Form1 : Form
    {
        Cuenta objCuenta = new Cuenta();
        public Form1()
        {
            InitializeComponent();
            limpiar();
        }

        public void limpiar()
        {
            txtNumeroCuenta.Text = "";
            txtNomCliente.Clear();
            rbCorrienteesteban.Checked = false;
            rbVistaESTEBAN.Checked = false;
            gbTransacciones.Visible = false;
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            gbTransacciones.Visible = true;
            string tipoCuenta = "";
            if (rbVistaESTEBAN.Checked == true)
            {

                tipoCuenta = "1";

            }

            else if(rbCorrienteesteban.Checked == true)
            {
                tipoCuenta = "2";
            }

            objCuenta.NumeroCuenta = txtNumeroCuenta.Text;
            objCuenta.NombreCliente = txtNomCliente.Text;
            objCuenta.TipoCuenta = tipoCuenta;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {   
            int cantidad = int.Parse(txtDeposito.Text);
            objCuenta.Deposito(cantidad);
            lbTransaccionesesteban.Items.Add("N° Vvienda: " + objCuenta.NumeroCuenta + ", MONTO Registrado: $" + cantidad + " CLP.");
        }

        private void btnRetirar_Click(object sender, EventArgs e)
        {
            int cantidad = Convert.ToInt32(txtRetiro.Text);
            if (objCuenta.Retiro(cantidad))
            {
                lbTransaccionesesteban.Items.Add("N° Vivienda: " + objCuenta.NumeroCuenta + ", MONTO Pagado: $" + cantidad + " CLP.");
            }
            else 
            {
                lbTransaccionesesteban.Items.Add("N° Vivienda: " + objCuenta.NumeroCuenta + "--/ OPERACIÓN NO VALIDA /-- (SALDO INSUFICIENTE).");
            }

        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            
            if (rbVistaESTEBAN.Checked == true)
            {
                System.Windows.Forms.MessageBox.Show("ESTADO DEL  PAGO" + "\n" +
                 "N° Vienda: " + objCuenta.NumeroCuenta + "\n" +
                 "Cliente: " + objCuenta.NombreCliente + "\n" +
                 "Tipo Vivienda: " + objCuenta.TipoCuenta + "\n" +
                "DEUDA: " + objCuenta.SaldoCliente.ToString() + " CLP.\n" +
                     DateTime.Now.ToString());

               

            }

            else if (rbCorrienteesteban.Checked == true)
            {
                System.Windows.Forms.MessageBox.Show("ESTADO DEL  PAGO" + "\n" +
                  "N° Vienda: " + objCuenta.NumeroCuenta + "\n" +
                 "Cliente: " + objCuenta.NombreCliente + "\n" +
                "Tipo Vivienda: " + objCuenta.TipoCuenta + "\n" +
                    "DEUDA: " + objCuenta.SaldoCliente.ToString() + " CLP.\n" +
                     DateTime.Now.ToString());

            }

      
        }

        private void rbVista_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lbTransacciones_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}