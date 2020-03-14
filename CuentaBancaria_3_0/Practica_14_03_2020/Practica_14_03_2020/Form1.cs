using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Practica_14_03_2020
{
    public partial class frmPrincipal : Form
    {
        BankAccount account = new BankAccount();
        public frmPrincipal()
        {
            InitializeComponent();
            lblNombreCuenta.Text = account.Name;
            lblNumeroID.Text = account.Id;
            lblSaldoTotal.Text = account.SaldoTotal.ToString();
            lblSaldoAhorro.Text = account.SaldoAhorro.ToString();
            lblSaldoCorriente.Text = account.SaldoCorriente.ToString();
            lblMes.Text = account.Mes.ToString();
        }
        #region Deposito
        private void btnDepositoAhorro_Click(object sender, EventArgs e)
        {
            try
            {
                lblSaldoTotal.Text = account.makeDeposit(Interaction.InputBox("¿Cuanto dinero desea ingresar a su cuenta de ahorros?"),
                true, lblSaldoAhorro).ToString("N2");
            }
            catch (Exception mensaje)
            {
                MessageBox.Show(mensaje.Message);
            }
        }
        private void btnDepostioCorriente_Click(object sender, EventArgs e)
        {
            try
            {
                lblSaldoTotal.Text = account.makeDeposit(Interaction.InputBox("¿Cuanto dinero desea ingresar a su cuenta corriente?"),
                false, lblSaldoCorriente).ToString("N2");
            }
            catch (Exception mensaje)
            {
                MessageBox.Show(mensaje.Message);
            }
        }
        #endregion

        #region Retiro
        private void btnRetiroAhorro_Click(object sender, EventArgs e)
        {
            try
            {
                lblSaldoTotal.Text = account.makeWithdrawal(Interaction.InputBox("¿Que cantidad desea retirar de su cuenta de ahorros?"),
                    true,lblSaldoAhorro).ToString("N2");
            }
            catch (Exception mensaje)
            {
                MessageBox.Show(mensaje.Message);
            }
        }
        private void btnRetiroCorriente_Click(object sender, EventArgs e)
        {
            try
            {
                lblSaldoTotal.Text = account.makeWithdrawal(Interaction.InputBox("¿Que cantidad desea retirar de su cuenta corriente?"),
                    false, lblSaldoCorriente).ToString("N2");
            }
            catch (Exception mensaje)
            {
                MessageBox.Show(mensaje.Message);
            }
        }
        #endregion

        #region Mes
        private void btnAvanzarMes_Click(object sender, EventArgs e)
        {
            try
            {
                lblSaldoTotal.Text = account.nextMonth(lblMes,lblSaldoAhorro).ToString("N2");
            }
            catch (Exception mensaje)
            {
                MessageBox.Show(mensaje.Message);
            }
        }
        #endregion
    }
}
