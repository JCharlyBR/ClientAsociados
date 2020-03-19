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
    public partial class FrmCitasyConsultas : Form
    {
        public FrmCitasyConsultas()
        {
            InitializeComponent();
        }

        private void FrmCitasyConsultas_Load(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void transparentControl2_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(txtId.Text);
            var descripcion = txtDescripcion.Text;


            using (Server_Asociados.ServerAsociadosClient socio = new Server_Asociados.ServerAsociadosClient())
            {


                socio.registrarMed(id, descripcion);
                MessageBox.Show("GUARDADO EXITOSAMENTE");
                limpiarCampos();
                cargarGrid();
            }
        }
        void cargarGrid()
        {
            Server_Asociados.ServerAsociadosClient socio = new Server_Asociados.ServerAsociadosClient();
            Server_Asociados.mostrarMedicamento s = new Server_Asociados.mostrarMedicamento();
            s = socio.getMedicamento();
            DataTable dt = new DataTable();
            dt = s.MedicamentoTab;
            dgvMedicamento.DataSource = dt;
        }

        void limpiarCampos()
        {
            txtDescripcion.Text = "";

            txtId.Text = "0";

        }

        private void dgvMedicamento_DoubleClick(object sender, EventArgs e)
        {
            if (dgvMedicamento.CurrentRow.Index != -1)
            {
                txtId.Text = (dgvMedicamento.CurrentRow.Cells[0].Value.ToString());
                txtDescripcion.Text = (dgvMedicamento.CurrentRow.Cells[1].Value.ToString());
                btnGuardar.Text = "ACTUALIZAR";
                cargarGrid();


            }
        }
    }
   
}
