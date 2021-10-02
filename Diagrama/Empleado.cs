using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diagrama
{
    class Empleado
    {
        //propiedades

        private string _campo;

        private string _nombre;

        // Definicion del constructor 
        public Empleado(string campo, string nombre)
        {
            _campo = campo;

            _nombre = nombre;

        }

        public Empleado()
        {
        }


        //Metodos de propiedad
        public void setcampo(string campo)
        {
            _campo = campo;
        }

        public string getcampo()
        {
            return _campo;
        }


        public void setnombre(string nombre)
        {
            _nombre = nombre;
        }

        public string getnombre()
        {
            return _nombre;
        }

        public string Campo()
        {
            return "Campo: Seguridad Social ";
        }

        public string Nombre()
        {
            return " Nombre: Zelayas Chaves, Kevin Alejandro ";
        }

        //Propiedad 
        public int _edad { get; set; }

        // metodos

        public string edad()
        {
            return " 25  años";
        }
    }
}
