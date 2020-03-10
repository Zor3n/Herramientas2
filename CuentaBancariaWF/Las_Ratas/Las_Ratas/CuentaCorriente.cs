using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Las_Ratas
{
    class CuentaCorriente : CuentaBancaria
    {
        #region Variables
        private double saldo;
        private double dinero;
        private List<Movimientos> movimientos;
        public double Saldo { get => saldo; set => saldo = value; }
        internal List<Movimientos> Movimientos { get => movimientos; set => movimientos = value; }
        #endregion
        #region Metodos
        public CuentaCorriente(double saldo = 0) : base()
        {
            this.saldo = saldo;
            movimientos = new List<Movimientos>();
        }

        public override void Deposito(string dinero)
        {
            if (double.TryParse(dinero, out this.dinero))
            {
                if (this.dinero < 0)
                    throw new Exception("Error");
                else
                {
                    saldo += this.dinero;
                    Movimientos depCorr = new Movimientos("Corriente","Deposito",this.dinero);
                    movimientos.Add(depCorr);
                }
            }
            else
                throw new Exception("Error");
        }

        public override void Retiro(string dinero)
        {
            if (double.TryParse(dinero, out this.dinero))
            {
                if (this.dinero > saldo)
                    throw new Exception("Error");
                else
                {
                    if (this.dinero < 0)
                        throw new Exception("Error");
                    else
                    {
                        saldo -= this.dinero;
                        Movimientos retCorr = new Movimientos("Corriente", "Retiro", this.dinero);
                        movimientos.Add(retCorr);
                    }  
                }
            }
            else
                throw new Exception("Error");
        }
        #endregion
    }
}
