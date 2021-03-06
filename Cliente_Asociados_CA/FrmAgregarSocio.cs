﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cliente_Asociados_CA
{
    public partial class FrmAgregarSocio : Form
    {
        public FrmAgregarSocio()
        {
            InitializeComponent();
            cargarGrid();
            cargarComboEstados();
            //CargarEstado();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(txtId.Text);
            var numeroSocio = txtNoSocio.Text;
            var nombre = txtNombre.Text;
            var apellidoP = txtApellidoPaterno.Text;
            var apellidoM = txtApellidoMaterno.Text;
            var fecha = DateTime.Parse(dateFecha.Text);
            var edad = Convert.ToInt32(txtEdad.Text);
            var cel = txtCelular.Text;
            var telf = txtTelefono.Text;
            var añoJub = cmbAñoJub.SelectedItem.ToString();
            var estadoCivil = cmbEstadoCivil.SelectedItem.ToString();
            var tipoSangre = cmbEstadoCivil.SelectedItem.ToString();
            var noImss = txtNoIMS.Text;
            var curp = txtCurp.Text;           
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            pictureImage.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            var imagen = ms.GetBuffer();

            var nombreCompletoE = txtNombreE.Text;
            var direccionE = txtDireccionE.Text;
            var telefonoE = txtTelefonoE.Text;
            var estatus = cmbStatus.SelectedItem.ToString();
            var sexo = cmbSexoHC.SelectedItem.ToString();
            var escolaridad = cmbEscolaridadHC.SelectedItem.ToString();
            
            using (Server_Asociados.ServerAsociadosClient socio = new Server_Asociados.ServerAsociadosClient())
            {
                
                var idEstado = Convert.ToInt32(txtIdEstado.Text);
                var idMunicipio = Convert.ToInt32(txtIdMunicipio.Text);
                var localidad = txtLocalidad.Text;
                var calle = txtCalle.Text;               
                socio.registrarSocio(id, numeroSocio, nombre, apellidoP, apellidoM, fecha, edad, cel, telf, añoJub, estadoCivil,
                    tipoSangre, noImss, curp,idEstado,idMunicipio,localidad,calle, imagen, nombreCompletoE, direccionE, telefonoE, estatus, sexo, escolaridad);
                MessageBox.Show("GUARDADO EXITOSAMENTE");
                limpiarCampos();
                cargarGrid();

            }
        }

        void cargarGrid()
        {
            //using (Server_Asociados.ServerAsociadosClient socio = new Server_Asociados.ServerAsociadosClient())
            //{
            //    dgvSocio.DataSource = socio.allSocios();
            //}



            Server_Asociados.ServerAsociadosClient socio = new Server_Asociados.ServerAsociadosClient();
            Server_Asociados.mostrarSocios s = new Server_Asociados.mostrarSocios();
            s = socio.getSocio();
            DataTable dt = new DataTable();
            dt = s.SocioTab;
            dgvSocio.DataSource = dt;
        }

        private void btnCargarImagen_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.openFileDialog1.ShowDialog();
                if (this.openFileDialog1.FileName.Equals("") == false)
                {

                    pictureImage.Load(this.openFileDialog1.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El archivo seleccionado no es un tipo de imagen válido");
            }
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscarPorNum_Click(object sender, EventArgs e)
        {
            var numSocio = txtBuscarNumSocio.Text;
            Server_Asociados.ServerAsociadosClient socio = new Server_Asociados.ServerAsociadosClient();
            Server_Asociados.getSocioByNoSocio s = new Server_Asociados.getSocioByNoSocio();
            s = socio.getBynoSocio(numSocio);
            DataTable dt = new DataTable();
            dt = s.socioTab;
            dgvSocio.DataSource = dt;
        }

        void cargarComboEstados()
        {
            using (Server_Asociados.ServerAsociadosClient cat = new Server_Asociados.ServerAsociadosClient())
            {
                this.cmbEstado.DataSource = cat.cargarComboEstados();
                cmbEstado.DisplayMember = "nombre";
                CargarDatosEstado();
            }

        }

        

        void cargarComboMunicipios()
        {
            var estado = cmbEstado.SelectedIndex + 1;

            using (Server_Asociados.ServerAsociadosClient cat = new Server_Asociados.ServerAsociadosClient())
            {
                this.cmbMunicipio.DataSource = cat.cargarComboMunicipios(estado);
                cmbMunicipio.DisplayMember = "nombre";
                txtNombreMunicipio.Text = cmbMunicipio.Text;
                CargarDatosMunicipio();


            }

        }

        void limpiarCampos()
        {
            txtNoSocio.Text = txtNombre.Text = txtApellidoMaterno.Text = txtApellidoPaterno.Text 
                = dateFecha.Text = cmbSexoHC.Text = txtEdad.Text = cmbAñoJub.Text=cmbEstadoCivil.Text=
                cmbTipoSangre.Text=txtNoIMS.Text=txtCurp.Text=txtCelular.Text=txtTelefono.Text=
                cmbEscolaridadHC.Text=txtLocalidad.Text=txtCalle.Text=txtNombreE.Text=txtTelefonoE.Text=
                txtDireccionE.Text=cmbStatus.Text="";
         
            txtId.Text = "0";
            pictureImage.Image = null;
            pictureImage.Invalidate();

        }


        private void cmbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            //CargarEstado();
            //CargarMunicipio();
            
            cargarComboMunicipios();
            CargarDatosEstado();
            //CargarDatosMunicipio();
           
        }

       

        const string MySqlConnecionString = "Server=192.168.0.125; Database=asociadosbd; Username=jubiladoUser; Password=1234;";

        static MySqlConnection GetNewConnection()
        {
            var conn = new MySqlConnection(MySqlConnecionString);
            conn.Open();
            return conn;
        }

        void CargarDatosEstado()
        {
            var id = cmbEstado.SelectedIndex+1;
            using (MySqlConnection conn = GetNewConnection())
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "SELECT id, nombre FROM estados WHERE id=@id";
                    cmd.Parameters.AddWithValue("@id", id);
                    MySqlDataReader consulta = cmd.ExecuteReader();
                    if (consulta.Read())
                    {                        
                        txtIdEstado.Text = consulta["id"].ToString();
                        txtNombreEstado.Text = consulta["nombre"].ToString();
                    }

                    conn.Close();


                }
            }
        }

        void CargarDatosMunicipio()
        {
            var id = txtIdEstado.Text ;
            using (MySqlConnection conn = GetNewConnection())
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "SELECT id, nombre FROM municipios WHERE estado_id=@id";
                    cmd.Parameters.AddWithValue("@id", id);
                    MySqlDataReader consulta = cmd.ExecuteReader();
                    if (consulta.Read())
                    {
                        txtIdMunicipio.Text = consulta["id"].ToString();
                        //txtNombreMunicipio.Text = consulta["nombre"].ToString();
                        txtNombreMunicipio.Text = cmbMunicipio.Text;
                    }

                    conn.Close();


                }
            }
        }

        public Image CargarImagen(int id)
        {
            using (MySqlConnection conn = GetNewConnection())
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "SELECT fotoPerfil FROM socio WHERE idSocio=@idSocio";
                    cmd.Parameters.AddWithValue("@idSocio", id);
                    Byte[] imgArr = (Byte[])cmd.ExecuteScalar();
                    imgArr = (Byte[])cmd.ExecuteScalar();
                    using (var stream = new MemoryStream(imgArr))
                    {
                        Image img = Image.FromStream(stream);
                        return img;
                    }
                }
            }
        }

        private void dgvSocio_DoubleClick(object sender, EventArgs e)
        {
            if (dgvSocio.CurrentRow.Index != -1)
            {
                txtId.Text = (dgvSocio.CurrentRow.Cells[0].Value.ToString());
                txtNoSocio.Text = (dgvSocio.CurrentRow.Cells[1].Value.ToString());
                txtNombre.Text = (dgvSocio.CurrentRow.Cells[2].Value.ToString());
                txtApellidoPaterno.Text = (dgvSocio.CurrentRow.Cells[3].Value.ToString());
                txtApellidoMaterno.Text = (dgvSocio.CurrentRow.Cells[4].Value.ToString());
                dateFecha.Text = (dgvSocio.CurrentRow.Cells[5].Value.ToString());
                txtEdad.Text = (dgvSocio.CurrentRow.Cells[6].Value.ToString());
                txtCelular.Text = (dgvSocio.CurrentRow.Cells[7].Value.ToString());
                txtTelefono.Text = (dgvSocio.CurrentRow.Cells[8].Value.ToString());
                cmbAñoJub.Text = (dgvSocio.CurrentRow.Cells[9].Value.ToString());
                cmbEstadoCivil.Text = (dgvSocio.CurrentRow.Cells[10].Value.ToString());
                cmbTipoSangre.Text = (dgvSocio.CurrentRow.Cells[11].Value.ToString());
                txtNoIMS.Text = (dgvSocio.CurrentRow.Cells[12].Value.ToString());
                txtCurp.Text = (dgvSocio.CurrentRow.Cells[13].Value.ToString());
                txtIdEstado.Text = (dgvSocio.CurrentRow.Cells[14].Value.ToString());
                txtIdMunicipio.Text = (dgvSocio.CurrentRow.Cells[15].Value.ToString());
                txtLocalidad.Text = (dgvSocio.CurrentRow.Cells[16].Value.ToString());
                txtCalle.Text = (dgvSocio.CurrentRow.Cells[17].Value.ToString());

                int idSocio = Convert.ToInt32(txtId.Text = (dgvSocio.CurrentRow.Cells[0].Value.ToString()));

                pictureImage.Image = CargarImagen(idSocio);

                txtNombreE.Text = (dgvSocio.CurrentRow.Cells[18].Value.ToString());
                txtTelefonoE.Text = (dgvSocio.CurrentRow.Cells[19].Value.ToString());
                txtDireccionE.Text = (dgvSocio.CurrentRow.Cells[20].Value.ToString());
                cmbStatus.Text = (dgvSocio.CurrentRow.Cells[21].Value.ToString());
                btnGuardar.Text = "ACTUALIZAR";
                btnCargarImagen.Text = "Cambiar Foto";
                cargarGrid();
                CargarDatosMunicipio();
                CargarDatosEstado();



                //int idArtista = Convert.ToInt32(txtId.Text = (dgvArtista.CurrentRow.Cells[4].Value.ToString()));
                //pictureBox1.Image = CargarImagen(idArtista);
                //btnRegistrar.Text = "Actualizar";
                //btnSubirImagen.Text = "Cambiar Foto";
                //cargarGrid();
            }
        }

        private void dateFecha_ValueChanged(object sender, EventArgs e)
        {
            DateTime fechanac = dateFecha.Value;
            int años = System.DateTime.Now.Year - fechanac.Year;
            if (System.DateTime.Now.Subtract(fechanac.AddYears(años)).TotalDays < 0)

                txtEdad.Text = Convert.ToString(años - 1);

            else
                txtEdad.Text = Convert.ToString(años);
        }

        private void cmbMunicipio_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarDatosMunicipio();
        }
    }
}
