using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using GUI.forms__CLiente;

namespace GUI.Forms
{
    public partial class frm_Cliente : Form
    {
        public frm_Cliente()
        {
            InitializeComponent();
        }

        private void cmbMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMenu.SelectedItem.ToString().Equals("Platos"))
            {
                frm_Platos formplatos = new frm_Platos();

                new frm_Platos().Show();
                this.Hide();
            }
        }
    }
}
