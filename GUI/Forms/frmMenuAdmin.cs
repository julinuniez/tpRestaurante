using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BE;
using FontAwesome.Sharp;

namespace GUI.Forms
{
    public partial class frmMenuAdmin : Form
    {
        private static BE_Usuario usuarioactual;
        private static IconMenuItem menuactivo = null;
        private static Form formularioactivo = null;

        public frmMenuAdmin(/*BE_Usuario objusuari*/)
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //lblUsuario.Text = usuarioactual.NombreCompleto;
        }
         
        private void AbrirFormulario(IconMenuItem menu, Form formulario)
        {
            if(menuactivo != null)
            {
                menuactivo.BackColor = Color.SeaShell;
            }
            menu.BackColor = Color.Silver;
            menuactivo = menu;

            if(formularioactivo != null)
            {
                formularioactivo.Close();
            }
            formularioactivo = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            formulario.BackColor = Color.DarkSalmon;
            //agregar el formulario al contenedor
            panel1.Controls.Add(formulario);
            formulario.Show();


        }
        private void menuUsuario_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frm_Usuario());
        }

        private void submenuCategoria_Click(object sender, EventArgs e)
        {
            AbrirFormulario((menuMantenedor), new frm_Categoria());
        }

        private void submenuProducto_Click(object sender, EventArgs e)
        {
            AbrirFormulario((menuMantenedor), new frm_Producto());
        }

        private void submenuVerDetalle_Click(object sender, EventArgs e)
        {
            AbrirFormulario((menuVentas), new frm_DetalleVenta());
        }

        private void submenuRegistroVenta_Click(object sender, EventArgs e)
        {
            AbrirFormulario((menuVentas), new frm_Venta());
        }

        private void submenuRegistrarCom_Click(object sender, EventArgs e)
        {
            AbrirFormulario((menuCompras), new frm_Compra());
        }

        private void submenuVerDetaleCom_Click(object sender, EventArgs e)
        {
            AbrirFormulario((menuCompras), new frm_DetalleCompra());
        }

        private void menuClientes_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frm_Cliente());
        }

        private void menuProveedores_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frm_Proveedores());
        }

        private void menuReportes_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frm_Reportes());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
