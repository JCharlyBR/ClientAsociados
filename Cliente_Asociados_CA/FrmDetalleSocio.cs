using MySql.Data.MySqlClient;
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
    public partial class FrmDetalleSocio : Form
    {
        public FrmDetalleSocio()
        {
            InitializeComponent();
            cargarComboCategoria();
            //CargarDatosTaller();
            CargarDatosCategoriaTaller();
        }
        void cargarComboCategoria()
        {
            using (Server_Asociados.ServerAsociadosClient cat = new Server_Asociados.ServerAsociadosClient())
            {
                this.cmbCategoriaTaller.DataSource = cat.cargarComboCategoriaT();
                cmbCategoriaTaller.DisplayMember = "nombre";
            }
        }
        void cargarComboTalleres()
        {
            var categoria = Convert.ToInt32(txtNombreC.Text);

            using (Server_Asociados.ServerAsociadosClient cat = new Server_Asociados.ServerAsociadosClient())
            {
                cmbNombreTaller.DataSource = cat.cargarComboTaller(categoria);
                cmbNombreTaller.DisplayMember = "nombre";
               

            }

        }

        private void btnBuscarPorNum_Click(object sender, EventArgs e)
        {
            var noSocio = (txtBuscarNumSocio.Text);
            Server_Asociados.ServerAsociadosClient socio = new Server_Asociados.ServerAsociadosClient();
            Server_Asociados.getSocioByNoSocio s = new Server_Asociados.getSocioByNoSocio();
            s = socio.getSocioDetalle(noSocio);
            DataTable dt = new DataTable();
            dt = s.socioTab;
            dgvConsultaSocio.DataSource = dt;
        }

        void cargarGridBeneficiario()
        {
            var noSocio = Convert.ToInt32(txtIdSocio.Text);
            Server_Asociados.ServerAsociadosClient socio = new Server_Asociados.ServerAsociadosClient();
            Server_Asociados.getBeneficiarioByNoSocio s = new Server_Asociados.getBeneficiarioByNoSocio();
            s = socio.getBeneficiarioDetalle(noSocio);
            DataTable dt = new DataTable();
            dt = s.BeneficiarioTab;
            dgvBeneficiario.DataSource = dt;
        }

        private void dgvConsultaSocio_DoubleClick(object sender, EventArgs e)
        {
            if (dgvConsultaSocio.CurrentRow.Index != -1)
            {
                txtIdSocio.Text = (dgvConsultaSocio.CurrentRow.Cells[0].Value.ToString());
                txtNoSocio.Text = (dgvConsultaSocio.CurrentRow.Cells[1].Value.ToString());
                txtNombreSocio.Text = (dgvConsultaSocio.CurrentRow.Cells[2].Value.ToString());
                txtEstatus.Text = (dgvConsultaSocio.CurrentRow.Cells[3].Value.ToString());
                //dgvConsultaSocio.Columns[0].Visible = false;
                cargarGridBeneficiario();
            }

        }

        private void cmbNombreTaller_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarDatosTaller();
        }

        private void cmbCategoriaTaller_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarDatosCategoriaTaller();
            cargarComboTalleres();
        }

        const string MySqlConnecionString = "Server=192.168.0.125; Database=asociadosbd; Username=jubiladoUser; Password=1234;";

        static MySqlConnection GetNewConnection()
        {
            var conn = new MySqlConnection(MySqlConnecionString);
            conn.Open();
            return conn;
        }

        void CargarDatosCategoriaTaller()
        {
            var id = cmbCategoriaTaller.SelectedIndex + 1;
            using (MySqlConnection conn = GetNewConnection())
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "SELECT idCategoriaTaller from categoriataller WHERE idCategoriaTaller=@id";
                    cmd.Parameters.AddWithValue("@id", id);
                    MySqlDataReader consulta = cmd.ExecuteReader();
                    if (consulta.Read())                    {
                        txtNombreC.Text = consulta["idCategoriaTaller"].ToString();
                       
                        
                    }
                    conn.Close();


                }
            }
        }

        void CargarDatosTaller()
        {
            var id = cmbNombreTaller.SelectedIndex+3;
            using (MySqlConnection conn = GetNewConnection())
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "SELECT Id, horario, instructor FROM taller WHERE idCategoria=@id";
                    cmd.Parameters.AddWithValue("@id", id);
                    MySqlDataReader consulta = cmd.ExecuteReader();
                    if (consulta.Read())
                    {
                        txtIdTaller.Text = consulta["Id"].ToString();
                        txtInstructorTaller.Text = consulta["instructor"].ToString();
                        txtHorarioTaller.Text = consulta["horario"].ToString();
                    }
                    conn.Close();


                }
            }
        }

        private void btnAgregarTaller_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(txtIdDetalleTaller.Text);
            var idSocio = Convert.ToInt32(txtIdSocio.Text);
            var idCategoria = cmbCategoriaTaller.SelectedIndex + 1;
            var idTaller = cmbNombreTaller.SelectedIndex + 1;
            
            using (Server_Asociados.ServerAsociadosClient socio = new Server_Asociados.ServerAsociadosClient())
            {
                socio.registrarDetalleTaller(id, idSocio, idCategoria, idTaller);
                MessageBox.Show("GUARDADO EXITOSAMENTE");
                //limpiarCampos();
                //cargarGrid();

            }
        }
    }
}
