using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Las_Ratas
{
    public partial class Form1 : Form
    {
        CuentaAhorros cuenta = new CuentaAhorros();
        CuentaCorriente cuentaCorriente = new CuentaCorriente();
        double dineroTotal = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblNombre.Text = cuenta.Nombre.ToString();
            lblID.Text = cuenta.Id.ToString();
            lblSaldoAhorro.Text = cuenta.Saldo.ToString("N2");
            lblSaldoCorriente.Text = cuentaCorriente.Saldo.ToString("N2");
            lblMes.Text = cuenta.Mes.ToString();
            lblTotal.Text = dineroTotal.ToString("N2");
        }

        #region CuentaAhorros
        private void btnDepA_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDineroAhorro.Text))
            {
                try
                {
                    cuenta.Deposito(txtDineroAhorro.Text);
                    lblSaldoAhorro.Text = cuenta.Saldo.ToString("N2");
                    dineroTotal += Convert.ToDouble(txtDineroAhorro.Text);
                    lblTotal.Text = dineroTotal.ToString("N2");
                    mostrarMovimiento();
                    MessageBox.Show("¡Deposito exitoso! ¡Tu cuenta tiene ahora mucho màs dinero!");
                }
                catch (Exception)
                {
                    MessageBox.Show("Deposito invalido");
                }
            }else
                MessageBox.Show("Por lo menos, ingresa una cantidad de dinero ome.");
        }
        private void btnRetiroA_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDineroAhorro.Text))
            {
                try
                {
                    cuenta.Retiro(txtDineroAhorro.Text);
                    lblSaldoAhorro.Text = cuenta.Saldo.ToString("N2");
                    dineroTotal -= Convert.ToDouble(txtDineroAhorro.Text);
                    lblTotal.Text = dineroTotal.ToString("N2");
                    mostrarMovimiento();
                    MessageBox.Show("¡Retiro exitoso! tu cuenta esta ahora mucho màs pobre que antes");
                }
                catch (Exception)
                {
                    MessageBox.Show("Retiro invalido");
                }
            }else
                MessageBox.Show("Por lo menos, ingresa una cantidad de dinero ome.");
        }
        private void btnAvanzar_Click(object sender, EventArgs e)
        {
            try
            {
                cuenta.Intereses();
                lblMes.Text = cuenta.Mes.ToString();
                lblSaldoAhorro.Text = cuenta.Saldo.ToString("N2");
                dineroTotal += cuenta.Comision;
                lblTotal.Text = dineroTotal.ToString("N2");
            }
            catch (Exception)
            {
                MessageBox.Show("Solo estubimos 12 meses. Por desgracias, para ti, te hemos robado todo.");
            }
        }
        #endregion

        #region CuentaCorriente
        private void btnDepC_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDineroCorriente.Text))
            {
                try
                {
                    cuentaCorriente.Deposito(txtDineroCorriente.Text);
                    lblSaldoCorriente.Text = cuentaCorriente.Saldo.ToString("N2");
                    dineroTotal += Convert.ToDouble(txtDineroCorriente.Text);
                    lblTotal.Text = dineroTotal.ToString("N2");
                    mostrarMoviminetoCorriente();
                    MessageBox.Show("¡Deposito exitoso! ¡Tu cuenta tiene ahora mucho màs dinero!");
                }
                catch (Exception)
                {
                    MessageBox.Show("Deposito invalido");
                }
            }
            else
                MessageBox.Show("Por lo menos, ingresa una cantidad de dinero ome.");
        }

        private void btnRetiroC_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDineroCorriente.Text))
            {
                try
                {
                    cuentaCorriente.Retiro(txtDineroCorriente.Text);
                    lblSaldoCorriente.Text = cuentaCorriente.Saldo.ToString("N2");
                    dineroTotal -= Convert.ToDouble(txtDineroCorriente.Text);
                    lblTotal.Text = dineroTotal.ToString("N2");
                    mostrarMoviminetoCorriente();
                    MessageBox.Show("¡Retiro exitoso! tu cuenta esta ahora mucho màs pobre que antes");
                }
                catch (Exception)
                {
                    MessageBox.Show("Retiro invalido");
                }
            }
            else
                MessageBox.Show("Por lo menos, ingresa una cantidad de dinero ome.");
        }
        #endregion

        #region Movimientos
        public void mostrarMovimiento()
        {
            dtgvAhorro.Rows.Clear();
            //Colocamos la nueva informacion
            foreach (var x in cuenta.Movimientos)
            {
                //Agregar un nuevo renglon
                int n = dtgvAhorro.Rows.Add();
                dtgvAhorro.Rows[n].Cells[0].Value = x.Cuenta;
                dtgvAhorro.Rows[n].Cells[1].Value = x.Movimiento;
                dtgvAhorro.Rows[n].Cells[2].Value = x.Cantidad;
            }
        }
        public void mostrarMoviminetoCorriente()
        {
            lvCorriente.Items.Clear(); //Limpiamos la lista
            
            foreach (var x in cuentaCorriente.Movimientos)
            {
                ListViewItem item = new ListViewItem(x.Cuenta);
                item.SubItems.Add(x.Movimiento);
                item.SubItems.Add(x.Cantidad.ToString());
                lvCorriente.Items.Add(item);
            }
        }
        #endregion
    }
}
