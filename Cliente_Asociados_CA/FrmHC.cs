using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cliente_Asociados_CA
{
    public partial class FrmHC : Form
    {
        public FrmHC()
        {
            InitializeComponent();
        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnFragilidad_Click(object sender, EventArgs e)
        {
            panelEncuestaFrail.Visible = true;

        }

        private void btnCancelarTestFrail_Click(object sender, EventArgs e)
        {
            panelEncuestaFrail.Visible = false;
        }
        void Contar1()
        {

            if (rbF1.Checked)
            {
                txtFr1.Text = Convert.ToInt32("1").ToString();
            }
            else if (rbF2.Checked)
            {
                txtFr1.Text = Convert.ToInt32("0").ToString();
            }
        }
        void Contar2()
        {
            if (rbF3.Checked)
            {
                txtFr2.Text = Convert.ToInt32("1").ToString();
            }
            else if (rbF4.Checked)
            {
                txtFr2.Text = Convert.ToInt32("0").ToString();
            }
        }
        void Contar3()
        {
            if (rbF5.Checked)
            {
                txtFr3.Text = Convert.ToInt32("1").ToString();
            }
            else if (rbF6.Checked)
            {
                txtFr3.Text = Convert.ToInt32("0").ToString();
            }

        }
        void Contar4()
        {
            if (rbF7.Checked)
            {
                txtFr4.Text = Convert.ToInt32("1").ToString();
            }
            else if (rbF8.Checked)
            {
                txtFr4.Text = Convert.ToInt32("0").ToString();
            }

        }
        void Contar5()
        {
            if (rbF9.Checked)
            {
                txtFr5.Text = Convert.ToInt32("1").ToString();
            }
            else if (rbF10.Checked)
            {
                txtFr5.Text = Convert.ToInt32("0").ToString();
            }

        }

        private void rbF1_CheckedChanged(object sender, EventArgs e)
        {
            Contar1();
        }

        private void rbF3_CheckedChanged(object sender, EventArgs e)
        {
            Contar2();
        }

        private void rbF5_CheckedChanged(object sender, EventArgs e)
        {
            Contar3();
        }

        private void rbF7_CheckedChanged(object sender, EventArgs e)
        {
            Contar4();
        }

        private void rbF9_CheckedChanged(object sender, EventArgs e)
        {
            Contar5();
        }
        void sumaValorTestFrail()
        {
            int sum;
            int v1 = Convert.ToInt32(txtFr1.Text);
            int v2 = Convert.ToInt32(txtFr2.Text);
            int v3 = Convert.ToInt32(txtFr3.Text);
            int v4 = Convert.ToInt32(txtFr4.Text);
            int v5 = Convert.ToInt32(txtFr5.Text);
            sum = v1 + v2 + v3 + v4 + v5;
            txtCuestionarioFrailHC.Text = sum.ToString();
            txtResultadoTestFrail.Text = sum.ToString();

            if (sum <= 2)
            {
                txtResultadoTestFrail.Text = "PREFRÁGIL";
                txtCuestionarioFrailHC.Text= "PREFRÁGIL";
            }
            else if (sum >= 3)
            {
                txtResultadoTestFrail.Text = "FRÁGIL";
                txtCuestionarioFrailHC.Text = "FRÁGIL";
            }
        }

        private void btnEvaluarTestFrail_Click(object sender, EventArgs e)
        {
           // txtCuestionarioFrailHC.Text = txtResultadoTestFrail.Text;
            panelEncuestaFrail.Visible = false;       
            sumaValorTestFrail();
        }
    }
}
