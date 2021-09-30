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
    public partial class Inventario : UserControl
    {
        public Inventario()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ConfirmacionEliminar confirmacion = new ConfirmacionEliminar();
            confirmacion.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ModificarInventario modificar = new ModificarInventario();
            modificar.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            AgregarInventario agregar = new AgregarInventario();
            agregar.Show();
        }
    }
}
