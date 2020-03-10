using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Las_Ratas
{
    class Movimientos
    {
        private double cantidad;
        private string movimiento;
        private string cuenta;

        public Movimientos(string cuenta, string movimiento, double cantidad)
        {
            this.cuenta = cuenta;
            this.movimiento = movimiento;
            this.cantidad = cantidad;
        }

        public double Cantidad { get => cantidad; set => cantidad = value; }
        public string Movimiento { get => movimiento; set => movimiento = value; }
        public string Cuenta { get => cuenta; set => cuenta = value; }
    }
}
