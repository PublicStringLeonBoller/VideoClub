using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoClubSegundaVez
{
    class Cliente : Persona
    {
        private int codigoSocio;
        private Pelicula pelicula;
        private Alquiler alquiler;
        public Cliente():base()
        {
            codigoSocio = 0;
            pelicula = null;
            alquiler = null;
        }

        public Cliente (int sexo, string nombre, int dni, Alquiler alquiler, 
                 Pelicula pelicula, int codigoSocio) : base(sexo,nombre,dni)
        {
            Alquiler = alquiler;
            Pelicula = pelicula;
            CodigoSocio = codigoSocio;
        }

        public Alquiler Alquiler
        {
            get { return alquiler; }
            set { alquiler = value; }
        }
        public Pelicula Pelicula
        {
            get { return pelicula; }
            set { pelicula = value; }
        }
        public int CodigoSocio
        {
            get { return codigoSocio; }
            set { codigoSocio = value; }
        }
        public string ShowInfoCLiente()
        {
            return 
                $"Informacion Del Cliente\n" +
                $"Dni: {Dni}\n" +
                $"Nombre: {Nombre}\n" +
                $"Sexo: {GetSexo()}\n" +
                $"Codigo De Socio: {CodigoSocio}";
        }
        public string ShowClienteYPeliCara()
        {
            return
                $"Nombre: {Nombre}\n" +
                $"Pelicula: {Pelicula.Titulo}\n" +
                $"Monto: {Alquiler.Monto}";
        }
    }
}
