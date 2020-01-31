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
    public partial class FrmBeneficiarios : Form
    {
        public FrmBeneficiarios()
        {
            InitializeComponent();
            cargarComboEstados();
            cargarGrid();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var idBeneficiario = Convert.ToInt32(txtIdBeneficiario.Text);
            var nombre = txtNombreE.Text;
            var apellidoP = txtAPaternoE.Text;
            var apellidoM = txtAMaternoE.Text;
            var fecha = DateTime.Parse(dateFecha.Text);
            var edad = Convert.ToInt32(txtEdadE.Text);
            var cel = txtCelularE.Text;
            var telf = txtTelefonoE.Text;
            var statu = txtStatusE.Text;
            var tipoSangre = cmbTipoSangreE.SelectedItem.ToString();
            var noImss = txtNoImssE.Text;
            var curp = txtCurpE.Text;
            var estadoD = cmbEstado.SelectedIndex.ToString();
            var municipioD = cmbMunicipio.SelectedIndex.ToString();
            var localidadD = txtColonia.Text;
            var calleD = txtCalle.Text;
            var idSocio = Convert.ToInt32(this.txtidSocio.Text);

            using (Server_Asociados.ServerAsociadosClient socio = new Server_Asociados.ServerAsociadosClient())
            {
                socio.registrarBeneficiario(idBeneficiario, nombre, apellidoP, apellidoM, fecha, edad, cel, telf,
                    tipoSangre, noImss, curp, estadoD, municipioD, localidadD, calleD,statu, idSocio);
                MessageBox.Show("GUARDADO EXITOSAMENTE");
               
                

            }


        }
        void cargarComboEstados()
        {
            using (Server_Asociados.ServerAsociadosClient cat = new Server_Asociados.ServerAsociadosClient())
            {
                this.cmbEstado.DataSource = cat.cargarComboEstados();
                cmbEstado.DisplayMember = "nombre";


            }

        }

        void cargarComboMunicipios()
        {
            var estado = cmbEstado.SelectedIndex + 1;

            using (Server_Asociados.ServerAsociadosClient cat = new Server_Asociados.ServerAsociadosClient())
            {
                this.cmbMunicipio.DataSource = cat.cargarComboMunicipios(estado);
                cmbMunicipio.DisplayMember = "nombre";
            }

        }
     

        private void cmbEstado_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            cargarComboMunicipios();
        }
        void cargarGrid()
        {
            Server_Asociados.ServerAsociadosClient socio = new Server_Asociados.ServerAsociadosClient();
            Server_Asociados.mostrarBeneficiario s = new Server_Asociados.mostrarBeneficiario();
            s = socio.getBeneficiario();
            DataTable dt = new DataTable();
            dt = s.BeneficiarioTab;
            dgvConsultaBeneficiario.DataSource = dt;
        }

        private void dgvConsultaBeneficiario_DoubleClick(object sender, EventArgs e)
        {
            if (dgvConsultaBeneficiario.CurrentRow.Index != -1)
            {
                txtIdBeneficiario.Text = (dgvConsultaBeneficiario.CurrentRow.Cells[0].Value.ToString());
                txtNombreE.Text = (dgvConsultaBeneficiario.CurrentRow.Cells[1].Value.ToString());
                txtAPaternoE.Text = (dgvConsultaBeneficiario.CurrentRow.Cells[2].Value.ToString());
                txtAMaternoE.Text = (dgvConsultaBeneficiario.CurrentRow.Cells[3].Value.ToString());
                dateFecha.Text = (dgvConsultaBeneficiario.CurrentRow.Cells[4].Value.ToString());
                txtEdadE.Text = (dgvConsultaBeneficiario.CurrentRow.Cells[5].Value.ToString());
                txtCelularE.Text = (dgvConsultaBeneficiario.CurrentRow.Cells[6].Value.ToString());
                txtTelefonoE.Text = (dgvConsultaBeneficiario.CurrentRow.Cells[7].Value.ToString());
                cmbTipoSangreE.Text = (dgvConsultaBeneficiario.CurrentRow.Cells[8].Value.ToString());
                txtNoImssE.Text = (dgvConsultaBeneficiario.CurrentRow.Cells[9].Value.ToString());
                txtCurpE.Text = (dgvConsultaBeneficiario.CurrentRow.Cells[10].Value.ToString());
                cmbEstado.Text = (dgvConsultaBeneficiario.CurrentRow.Cells[11].Value.ToString());
                cmbMunicipio.Text = (dgvConsultaBeneficiario.CurrentRow.Cells[12].Value.ToString());
                txtColonia.Text = (dgvConsultaBeneficiario.CurrentRow.Cells[13].Value.ToString());
                txtCalle.Text = (dgvConsultaBeneficiario.CurrentRow.Cells[14].Value.ToString());
                txtStatusE.Text = (dgvConsultaBeneficiario.CurrentRow.Cells[15].Value.ToString());
                txtidSocio.Text = (dgvConsultaBeneficiario.CurrentRow.Cells[16].Value.ToString());

                btnGuardar.Text = "ACTUALIZAR";
                cargarGrid();
                CargarNoSocio();
                CargarGridSocios2();
            }

        }
        void CargarGridSocios()
        {
            var num = txtBucarNum.Text;
            Server_Asociados.ServerAsociadosClient socio = new Server_Asociados.ServerAsociadosClient();
            Server_Asociados.getSocioByNoSocio s = new Server_Asociados.getSocioByNoSocio();
            s = socio.getSocioDetalle(num);
            DataTable dt = new DataTable();
            dt = s.socioTab;
            dgvConsultaSocio.DataSource = dt;
        }
        void CargarGridSocios2()
        {
            var num = txtNoSocioE.Text;
            Server_Asociados.ServerAsociadosClient socio = new Server_Asociados.ServerAsociadosClient();
            Server_Asociados.getSocioByNoSocio s = new Server_Asociados.getSocioByNoSocio();
            s = socio.getSocioDetalle(num);
            DataTable dt = new DataTable();
            dt = s.socioTab;
            dgvConsultaSocio.DataSource = dt;
        }

        private void dateFecha_ValueChanged(object sender, EventArgs e)
        {
            DateTime fechanac = dateFecha.Value;
            int años = System.DateTime.Now.Year - fechanac.Year;
            if (System.DateTime.Now.Subtract(fechanac.AddYears(años)).TotalDays < 0)

                txtEdadE.Text = Convert.ToString(años - 1);

            else
                txtEdadE.Text = Convert.ToString(años);
        }

        private void btnBuscarNumero_Click(object sender, EventArgs e)
        {
            CargarGridSocios();
        }

        private void dgvConsultaSocio_DoubleClick(object sender, EventArgs e)
        {
            txtidSocio.Text = (dgvConsultaSocio.CurrentRow.Cells[0].Value.ToString());
            txtNoSocioE.Text = (dgvConsultaSocio.CurrentRow.Cells[1].Value.ToString());
        }
        const string MySqlConnecionString = "Server=192.168.0.125; Database=asociadosbd; Username=jubiladoUser; Password=1234;";
        static MySqlConnection GetNewConnection()
        {
            var conn = new MySqlConnection(MySqlConnecionString);
            conn.Open();
            return conn;
        }
        void CargarNoSocio()
        {
            var id = txtidSocio.Text;
            using (MySqlConnection conn = GetNewConnection())
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "SELECT noSocio FROM socio WHERE idSocio=@idSocio";
                    cmd.Parameters.AddWithValue("@idSocio", id);
                    MySqlDataReader consulta = cmd.ExecuteReader();
                    if (consulta.Read())
                    {
                        txtNoSocioE.Text = consulta["noSocio"].ToString();
                    }
                    conn.Close();

                }
            }
        }
    }
}
