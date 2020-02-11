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
    public partial class FrmTaller : Form
    {
        public FrmTaller()
        {
            InitializeComponent();
            cargarComboCategoria();
            cargarGridTaller();
            cargarGridCategoria();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnRegistrarCurso_Click(object sender, EventArgs e)
        {
            var idCurso = Convert.ToInt32(txtIdCurso.Text);
            var nombre = txtNombreTaller.Text;
            var instructor = txtInstructorTaller.Text;
            var categoria = (cmbCategoriaTaller.SelectedIndex+1);
            var horario = txtHorario.Text;

            using (Server_Asociados.ServerAsociadosClient socio = new Server_Asociados.ServerAsociadosClient())
            {
                socio.registrarTaller(idCurso, nombre, horario,instructor,categoria);
                MessageBox.Show("GUARDADO EXITOSAMENTE");
                cargarGridTaller();

            }
        }
        void cargarGridTaller()
        {
            Server_Asociados.ServerAsociadosClient socio = new Server_Asociados.ServerAsociadosClient();
            Server_Asociados.mostrarTaller s = new Server_Asociados.mostrarTaller();
            s = socio.getTaller();
            DataTable dt = new DataTable();
            dt = s.TallerTab;
            dgvTaller.DataSource = dt;
        }
        void cargarGridCategoria()
        {
            Server_Asociados.ServerAsociadosClient socio = new Server_Asociados.ServerAsociadosClient();
            Server_Asociados.mostrarCategoria s = new Server_Asociados.mostrarCategoria();
            s = socio.getCategoria();
            DataTable dt = new DataTable();
            dt = s.CategoriaTab;
            dgvCategorias.DataSource = dt;
        }

        private void btnRegistrarCategoria_Click(object sender, EventArgs e)
        {
            var idCategoria = Convert.ToInt32(txtIdCategoria.Text);
            var nombreCategoria = txtNombreCategoria.Text;
            var descripcion = txtDescripcion.Text;


            using (Server_Asociados.ServerAsociadosClient socio = new Server_Asociados.ServerAsociadosClient())
            {
                socio.registrarCategoria(idCategoria, nombreCategoria, descripcion);
                MessageBox.Show("GUARDADO EXITOSAMENTE");
                cargarGridCategoria();

            }
        }
        void cargarComboCategoria()
        {
            using (Server_Asociados.ServerAsociadosClient cat = new Server_Asociados.ServerAsociadosClient())
            {
                this.cmbCategoriaTaller.DataSource = cat.cargarComboCategoriaT();
                cmbCategoriaTaller.DisplayMember = "nombre";


            }

        }

        private void dgvTaller_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (dgvTaller.CurrentRow.Index != -1)
            {
                txtIdCurso.Text = (dgvTaller.CurrentRow.Cells[0].Value.ToString());
                txtNombreTaller.Text = (dgvTaller.CurrentRow.Cells[1].Value.ToString());
                txtHorario.Text = (dgvTaller.CurrentRow.Cells[2].Value.ToString());
                txtInstructorTaller.Text = (dgvTaller.CurrentRow.Cells[3].Value.ToString());
                cmbCategoriaTaller.Text = (dgvTaller.CurrentRow.Cells[4].Value.ToString());
                btnRegistrarCurso.Text = "ACTUALIZAR";
                cargarGridTaller();
            }
        }

        private void dgvCategorias_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (dgvCategorias.CurrentRow.Index != -1)
            {
                txtIdCategoria.Text = (dgvCategorias.CurrentRow.Cells[0].Value.ToString());
                txtNombreCategoria.Text = (dgvCategorias.CurrentRow.Cells[1].Value.ToString());
                txtDescripcion.Text = (dgvCategorias.CurrentRow.Cells[2].Value.ToString());
               
                btnRegistrarCategoria.Text = "ACTUALIZAR";
                cargarGridCategoria();
            }
        }

        private void btnDeportivas_Click(object sender, EventArgs e)
        {
            CargarDeportivo();
        }
        void CargarDeportivo()
        {
            Server_Asociados.ServerAsociadosClient socio = new Server_Asociados.ServerAsociadosClient();
            Server_Asociados.mostrarTaller mo = new Server_Asociados.mostrarTaller();
            mo = socio.getTallerDeportivo();
            DataTable dt = new DataTable();
            dt = mo.TallerTab;
            dgvTaller.DataSource = dt;
        }

        void CargarCultural()
        {
            Server_Asociados.ServerAsociadosClient socio = new Server_Asociados.ServerAsociadosClient();
            Server_Asociados.mostrarTaller mo = new Server_Asociados.mostrarTaller();
            mo = socio.getTallerCultural();
            DataTable dt = new DataTable();
            dt = mo.TallerTab;
            dgvTaller.DataSource = dt;
        }
        void CargarRecreativo()
        {
            Server_Asociados.ServerAsociadosClient socio = new Server_Asociados.ServerAsociadosClient();
            Server_Asociados.mostrarTaller mo = new Server_Asociados.mostrarTaller();
            mo = socio.getTallerRecreativo();
            DataTable dt = new DataTable();
            dt = mo.TallerTab;
            dgvTaller.DataSource = dt;
        }

        private void btnCulturales_Click(object sender, EventArgs e)
        {
            CargarCultural();
        }

        private void btnRecreativas_Click(object sender, EventArgs e)
        {
            CargarRecreativo();
        }
    }
}
