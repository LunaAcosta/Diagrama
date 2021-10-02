using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diagrama
{
    public partial class datos : Form
    {
        public datos()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Instancia de la clase  Estudiante 

            Estudiante estudiante = new Estudiante();
            Empleado empleado = new Empleado();

            

            MessageBox.Show(estudiante.Carnet() + estudiante.Nombre());
            MessageBox.Show(estudiante.edad());
            MessageBox.Show(empleado.Campo() + empleado.Nombre());
            MessageBox.Show(empleado.edad());





        


        }
        
    }
}
