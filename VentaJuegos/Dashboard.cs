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
    public partial class Dashboard : Form
    {
        bool admin = true;
        public Dashboard()
        {
            InitializeComponent();
            if (admin)
            {
                btnEmpleados.Visible = true;
                btnReportes.Visible = true;
            }
        }

        private void btnVenta_Click(object sender, EventArgs e)
        {
            ResetearWidth();
            btnVenta.Width = 130;
            Venta venta = new Venta();
            venta.Dock = DockStyle.Fill;
            AddControl(venta);
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            ResetearWidth();
            btnInventario.Width = 130;
            Inventario inventario= new Inventario();
            inventario.Dock = DockStyle.Fill;
            AddControl(inventario);
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            ResetearWidth();
            btnEmpleados.Width = 130;
            Empleados empleados = new Empleados();
            empleados.Dock = DockStyle.Fill;
            AddControl(empleados);
        }

        void AddControl(Control control)
        {
            plMain.Controls.Clear();
            plMain.Controls.Add(control);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
            Login login = new Login();
            login.Show();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            ResetearWidth();
            btnReportes.Width = 130;
            Reportes reportes = new Reportes();
            reportes.Dock = DockStyle.Fill;
            AddControl(reportes);
        }

        void ResetearWidth()
        {
            btnVenta.Width = 120;
            btnInventario.Width = 120;
            btnEmpleados.Width = 120;
            btnReportes.Width = 120;
        }
    }
}
