using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoClubSegundaVez
{
    class Pelicula
    {
        private int codigo;
        private string titulo;
        private int genero;
        public Pelicula()
        {
            codigo = 0;
            titulo = "";
            genero = 0;
        }
        public int Genero
        {
            get { return genero; }
            set { genero = value; }
        }
        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }
        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public string GetGenero()
        {
            switch (Genero)
            {
                case 1: return "Terror";
                case 2: return "Ficcion";
                case 3: return "Comedia";
                default: return "No ha seleccionado ningun genero";
            }
        }
        public string ShowInfoPelicula()
        {
            return
                $"Informacion De La Pelicula\n" +
                $"Codigo: {Codigo}\n" +
                $"Titulo: {Titulo}\n" +
                $"Genero: {GetGenero()}";
        }

    }
}
