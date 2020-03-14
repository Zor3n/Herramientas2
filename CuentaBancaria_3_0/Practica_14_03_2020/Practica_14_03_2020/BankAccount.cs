using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_14_03_2020
{
    class BankAccount
    {
        #region Variables
        //Variables
        private string name;
        private string id;
        private float saldoAhorro;
        private float saldoCorriente;
        private float saldoTotal;
        private int mes;
        private float dinero; //Esta variable nos ayudara a decidir si la cantidad ingresada es un nùmero.
        #endregion

        #region Propiedades
        public string Name { get => name; set => name = value; }
        public string Id { get => id; set => id = value; }
        public float SaldoAhorro { get => saldoAhorro; set => saldoAhorro = value; }
        public float SaldoCorriente { get => saldoCorriente; set => saldoCorriente = value; }
        public float SaldoTotal { get => saldoTotal; set => saldoTotal = value; }
        public int Mes { get => mes; set => mes = value; }
        #endregion

        #region Metodos
        public BankAccount()
        {
            this.name = "Carl Johnson";
            this.id = "CJID005";
            this.mes = 1;
            this.saldoAhorro = 0;
            this.saldoCorriente = 0;
            this.saldoTotal = 0;
        }
        public float makeDeposit(string deposito, bool cuenta, Label resultado)
        {
            if (!string.IsNullOrEmpty(deposito))
            {
                if (float.TryParse(deposito,out dinero))
                {
                    if (dinero > 0)
                    {
                        if (cuenta)
                        {
                            saldoAhorro += dinero;
                            resultado.Text = saldoAhorro.ToString("N2");
                            saldoTotal = saldoAhorro + saldoCorriente;
                        }
                        else
                        {
                            saldoCorriente += dinero;
                            resultado.Text = saldoCorriente.ToString("N2");
                            saldoTotal = saldoAhorro + saldoCorriente;
                        }
                    }else
                        throw new Exception("¿Que clase de persona quiere ingresar una cantidad negativa?");
                }
                else
                    throw new Exception("Debe ingresar unos dolares para depositar NO letras parce.");
            }
            else
                throw new Exception("Debe ingresar un deposito parcero.");
            return saldoTotal;
        }
        public float makeWithdrawal(string deposito, bool cuenta, Label resultado)
        {
            if (!string.IsNullOrEmpty(deposito))
            {
                if (float.TryParse(deposito, out dinero))
                {
                    if (dinero > 0)
                    {
                        if (cuenta)
                        {
                            if (dinero > saldoAhorro)
                                throw new Exception("¿Quieres retirar dinero que no tienes? NOP.");
                            else
                            {
                                saldoAhorro -= dinero;
                                resultado.Text = saldoAhorro.ToString("N2");
                                saldoTotal = saldoAhorro + saldoCorriente;
                            }
                        }
                        else
                        {
                            if (dinero > saldoCorriente)
                                throw new Exception("¿Quieres retirar dinero que no tienes? NOP.");
                            else
                            {
                                saldoCorriente -= dinero;
                                resultado.Text = saldoCorriente.ToString("N2");
                                saldoTotal = saldoAhorro + saldoCorriente;
                            }
                        }
                    }
                    else
                        throw new Exception("¿Que clase de persona quiere retirar una cantidad negativa?");
                }
                else
                    throw new Exception("Debe ingresar unos dolares para retirar NO letras parce.");
            }
            else
                throw new Exception("Debe ingresar un valor de retiro parcero.");
            return saldoTotal;
        }

        public float nextMonth(Label mesActual, Label resultado)
        {
            if (mes < 12)
            {
                mes++;
                saldoAhorro = (float)(saldoAhorro + (saldoAhorro * 0.006));
                saldoTotal = saldoAhorro + saldoCorriente;
                mesActual.Text = mes.ToString();
                resultado.Text = saldoAhorro.ToString("N2");
            }
            else
                throw new Exception("Ya se pasò nuestro año");
            return saldoTotal;
        }
        #endregion
    }
}
