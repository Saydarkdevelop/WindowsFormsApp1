using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FrmHome : Form
    {
        public FrmHome()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            grpGuardado.Visible = true;

            lbNombre.Text = txtNombre.Text;
            lbApellido.Text = txtApellido.Text;
            lbDireccion.Text = txtDireccion.Text;
            lbCiudad.Text = cbxCiudad.Text;
            lbRut.Text = txtRut.Text;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            grpGuardado.Visible = false;


            txtRut.Text = "";
            txtApellido.Text = "";
            txtDireccion.Text = "";
            txtNombre.Text = "";
            cbxCiudad.Text = "";

        }

        private void grpGuardado_Enter(object sender, EventArgs e)
        {

        }

        private void lbRut_Click(object sender, EventArgs e)
        {

        }
    }
}
