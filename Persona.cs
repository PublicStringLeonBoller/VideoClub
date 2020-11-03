using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoClubSegundaVez
{
    abstract class Persona
    {
        protected int dni;
        protected string nombre;
        protected int sexo;
        public Persona()
        {
            dni = 0;
            nombre = "";
            sexo = 0;
        }
        public Persona(int sexo, string nombre, int dni)
        {
            Sexo = sexo;
            Nombre = nombre;
            Dni = dni;
        }
        public int Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public int Dni
        {
            get { return dni; }
            set { dni = value; }
        }
        public string GetSexo()
        {
            switch (Sexo)
            {
                case 1: return "Masculino";
                case 2: return "Femenino";
                case 3: return "Otro";
                default: return "No se selecciono un sexo";
            }
        }
        
    }
}
