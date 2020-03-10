using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Las_Ratas
{
    class CuentaAhorros : CuentaBancaria
    {
        #region Variables G/S
        private double saldo;
        private double dinero;
        private double mes = 1;
        private int comision;
        private List<Movimientos> movimientos;
        public double Saldo { get => saldo; set => saldo = value; }
        public double Mes { get => mes; set => mes = value; }
        public int Comision { get => comision; set => comision = value; }
        internal List<Movimientos> Movimientos { get => movimientos; set => movimientos = value; }

        #endregion

        #region Metodos
        public CuentaAhorros(double saldo = 0) : base()
        {
            this.saldo = saldo;
            movimientos = new List<Movimientos>();
        }
        public override void Deposito(string dinero)
        {
            if (double.TryParse(dinero, out this.dinero))
            {
                if (this.dinero < 0)
                {
                    throw new Exception("Error");
                }
                else
                {
                    saldo += this.dinero;
                    Movimientos depoAhorro = new Movimientos("Ahorro","Deposito",this.dinero);
                    movimientos.Add(depoAhorro);
                }  
            }
            else
            {
                throw new Exception("Error");
            }
        }

        public override void Retiro(string dinero)
        {
            if (double.TryParse(dinero, out this.dinero))
            {
                if (this.dinero > saldo)
                {
                    throw new Exception("Error");
                }
                else
                {
                    if (this.dinero < 0)
                    {
                        throw new Exception("Error");
                    }
                    else
                    {
                        saldo -= this.dinero;
                        Movimientos retAhorro = new Movimientos("Ahorro", "Retiro", this.dinero);
                        movimientos.Add(retAhorro);
                    }   
                }
            }else
                throw new Exception("Error");
        }

        public void Intereses()
        {
            if (mes < 12)
            {
                saldo = saldo * 1.006;
                comision = (int)(saldo * 0.006);
                mes++;
            }
            else
                throw new Exception("Error");            
        }
        #endregion
    }
}
