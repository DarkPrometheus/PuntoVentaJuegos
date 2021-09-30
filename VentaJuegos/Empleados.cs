using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VentaJuegos
{
    public partial class Empleados : UserControl
    {
        public Empleados()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ModificarEmpleado modificar = new ModificarEmpleado();
            modificar.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AgregarEmpleado agregar = new AgregarEmpleado();
            agregar.Show();
        }
    }
}
