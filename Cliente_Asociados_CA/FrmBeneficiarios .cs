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
            var idSocio = Convert.ToInt32(this.txtNoSocioE.Text);

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
                txtStatusE.Text = (dgvConsultaBeneficiario.CurrentRow.Cells[8].Value.ToString());              
                cmbTipoSangreE.Text = (dgvConsultaBeneficiario.CurrentRow.Cells[9].Value.ToString());
                txtNoImssE.Text = (dgvConsultaBeneficiario.CurrentRow.Cells[10].Value.ToString());
                txtCurpE.Text = (dgvConsultaBeneficiario.CurrentRow.Cells[11].Value.ToString());
                cmbEstado.Text = (dgvConsultaBeneficiario.CurrentRow.Cells[12].Value.ToString());
                cmbEstado.DisplayMember = "nombre";
                cmbMunicipio.Text = (dgvConsultaBeneficiario.CurrentRow.Cells[13].Value.ToString());
                txtColonia.Text = (dgvConsultaBeneficiario.CurrentRow.Cells[14].Value.ToString());
                txtCalle.Text = (dgvConsultaBeneficiario.CurrentRow.Cells[15].Value.ToString());
                txtNoSocioE.Text = (dgvConsultaBeneficiario.CurrentRow.Cells[16].Value.ToString());
                
                btnGuardar.Text = "ACTUALIZAR";
                cargarGrid();
            }

        }
        }
}
