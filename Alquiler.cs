using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoClubSegundaVez
{
    class Alquiler
    {
        private int numero;
        private DateTime fecha;
        private double monto;
        public Alquiler()
        {
            numero = 0;
            fecha = DateTime.Today;
            monto = 0;
        }
        public Alquiler(double monto, DateTime fecha, int numero)
        {
            Monto = monto;
            Fecha = fecha;
            Numero = numero;
        }
        public double Monto
        {
            get { return monto; }
            set { monto = value; }
        }
        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }
        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }
        public string ShowInfoAquiler()
        {
            return
                $"Datos Del Alquiler\n" +
                $"Numero: {Numero}\n" +
                $"Fecha: {Fecha}\n" +
                $"Monto: {Monto}";
        }
    }
}
