using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Las_Ratas
{
    abstract class CuentaBancaria
    {
        private string nombre;
        private int id;

        public CuentaBancaria()
        {
            this.Nombre = "Carl";
            this.Id = 5500123;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public int Id { get => id; set => id = value; }

        public abstract void Deposito(string dinero);
        public abstract void Retiro(string dinero);
    }
}
