using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diagrama
{

    // Herencia entre estudiant y persona 
    class Estudiante:Persona
    {
        //Propiedad 
        public int _edad { get; set;  }

        // metodos

        public string edad()
        {
            return " 18  años";
        }
        


    }
}
