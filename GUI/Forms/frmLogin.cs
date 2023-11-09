using GUI.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using BE;


namespace GUI
{
    public partial class frmLogin : Form
    {

        public frmLogin()
        {
            InitializeComponent();
        }

        BLL_Usuario gestor = new BLL_Usuario();



        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnSingIn_Click(object sender, EventArgs e)
        {
            new Registro().Show();
            this.Hide();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        private void btnLogIn_Click(object sender, EventArgs e)
        {
            /*List<BE_Usuario> test = gestor.Listar();*/
            BE_Usuario beusuario = gestor.Listar().Where(U => U.Documento == int.Parse(txtDocumento.Text) && U.Contraseña == txtContraseña.Text).FirstOrDefault();

            if (beusuario != null)
            {
                frmMenuAdmin form = new frmMenuAdmin();
                form.Show();
                this.Hide();
                this.FormClosing += frm_Cerrando;
            }
            else
            {
                MessageBox.Show("No se encontró el usuario");
            }
        }

        private void frm_Cerrando(object sender, FormClosingEventArgs e)
        {
            txtDocumento.Text = "";
            txtContraseña.Text= "";

            this.Show();

        }

        private void chMostarContraseña_CheckedChanged(object sender, EventArgs e)
        {
            if (chMostarContraseña.Checked)
            {
                txtContraseña.PasswordChar = '\0';
            }
            else
            {
                txtContraseña.PasswordChar = '•';     
            }
        }

    }
}
