using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diagrama
{
    class Persona
    {
        //propiedades

        private string _carnet;

        private string _nombre;

        // Definicion del constructor 
        public Persona(string carnet, string nombre)
        {
            _carnet = carnet;

            _nombre = nombre;

        }

        public Persona()
        {
        }


        //Metodos de propiedad
        public void setcampo(string campo)
        {
            _carnet = campo;
        }

        public string getcarnet()
        {
            return _carnet;
        }


        public void setnombre(string nombre)
        {
            _nombre = nombre;
        }

        public string getnombre()
        {
            return _nombre;
        }

        public string Carnet()
        {
            return "Carnet: SMIS083121";
        }

        public string Nombre()
        {
            return " Nombre: Luna Acosta, Kevin Alexander";
        }


    }
}
