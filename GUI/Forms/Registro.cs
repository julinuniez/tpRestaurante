using BE;
using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using GUI.Forms;
using System.IO;
using GUI.forms__CLiente;
using System.Diagnostics.Eventing.Reader;
using GUI.forms__usuarios;

namespace GUI
{        
    public partial class Registro : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=CANCXAN23\\SQLEXPRESS;Initial Catalog=DBSISTEMARESTAURANTE;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter adapter = new SqlDataAdapter();




        BE_Usuario usuario = new BE_Usuario();
        BLL_Usuario bllUsuario = new BLL_Usuario();
        public Registro()
        {
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            usuario.email = txtDocumento.Text;
            usuario.Contraseña = txtContraseña.Text;

            
            new frmLogin().Show();
            this.Hide();
        }

        private void Registro_Load(object sender, EventArgs e)
        {

        }
             
        private void btnSingIn_Click(object sender, EventArgs e)
        {
            usuario.Documento = int.Parse(txtDocumento.Text);
            usuario.NombreCompleto = txtNombre.Text + " " + txtApellido.Text;
            usuario.email = txtEmail.Text;
            usuario.Contraseña = txtContraseña.Text;
            usuario.Categoria = cmbCategoria.Text;

            if (txtContraseña.Text == txtConfirmar.Text)
            {
                bllUsuario.agregarUsuario(usuario);
                MessageBox.Show("Usuario registrado correctamente");
                frmLogin frmLogin = new frmLogin();
                frmLogin.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Hubo un error al registrar el usuario. Porfavor revise los datos");


            cmbCategoria_SelectedIndexChanged();

        }

        private void chMostarContraseña_CheckedChanged(object sender, EventArgs e)
        {
            if (chMostarContraseña.Checked)
            {
                txtContraseña.PasswordChar = '\0';
                txtConfirmar.PasswordChar = '\0';
            }
            else
            {
                txtContraseña.PasswordChar = '•';
                txtConfirmar.PasswordChar = '•';
            }
        }

        public void cmbCategoria_SelectedIndexChanged()
        {

            if (cmbCategoria.SelectedItem.ToString().Equals("Cliente"))
            {
                frm_Cliente formcliente = new frm_Cliente();

                new frm_Cliente().Show();
                this.Hide();
            }
            else if (cmbCategoria.SelectedItem.ToString().Equals("Cocinero"))
            {
               frm_Cocinero frmcocinero = new frm_Cocinero();

                new frm_Cocinero().Show();
                this.Hide();


            }
        }
        
            
        }
    }



          //if (txtContraseña.Text == txtConfirmar.Text)
            

            
        
    

