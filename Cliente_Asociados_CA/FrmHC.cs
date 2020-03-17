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
    public partial class FrmHC : Form
    {
        public FrmHC()
        {
            InitializeComponent();
            //CargarGrid();
            valorChec1();
            valorChec2();
            valorChec3();
            valorChec4();
            valorChec5();
            valorChec6();
            valorChec7();
            valorChec8();
            valorChec9();
            valorChec10();
            valorChec11();
            valorChec12();
            valorChec13();
            valorChec14();
            valorChec15();
            valorChec16();
            valorChec17();
            valorChec18();
            valorChec19();
            valorChec20();
            valorChec21();
            valorChec22();
            valorChec23();
            valorChec24();
            valorChec25();
            valorChec26();
            valorChec27();
            valorChec28();
            valorChec29();
        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnGuardarHC_Click(object sender, EventArgs e)
        {
            try
            {
                var Id = Convert.ToInt32(txtId.Text);
                var idSocio = Convert.ToInt32(txtNoSocioHC.Text);
                var fecha = (txtFechaHC.Text);
                var hora = txtHoraHC.Text;
                var esc = cmbEscolaridadHC.SelectedItem.ToString();
                var ocuP = txtOcupacionHC.Text;
                var alergias = txtAlergiasHC.Text;
                var nombreC = txtNombreFamHC.Text;
                var parentesco = cmbParentescoFamHC.SelectedItem.ToString();
                var cuidadorP = txtCuidadorPrimHC.Text;
                var telefonoC = txtTelefonoFamHC.Text;
                var svTa = txtTAHC.Text;
                var svFC = txtFcHC.Text;
                var svFR = txtFrHC.Text;
                var svGlucemPre = txtGlucemiaPreHC.Text;
                var svGlucemPost = txtGlucemiaPostHC.Text;
                var svColesterol = txtColesterolHC.Text;
                var svTrigliceridos = txtTrigliceridosHC.Text;
                var svTemperatura = txtTemperaturaHC.Text;
                var svPeso = txtPesoHC.Text;
                var svEstatura = txtEstaturaHC.Text;
                var svCintura = txtCinturaHC.Text;
                var svIMC = txtIMC.Text;
                var resumenI = txtResumenInterrogatorioHC.Text;
                var alcoholismo = cmbAlcoholismoHC.SelectedItem.ToString();
                var tabaquismo = cmbTabaquismoHC.SelectedItem.ToString();
                var toxic = cmbToxicomaniaHC.SelectedItem.ToString();
                var transf = cmbTransfusionesHC.SelectedItem.ToString();
                var cartV = txtCartillaVacunacionHC.Text;
                var gestas = txtGestas.Text;
                var partos = txtPartos.Text;
                var cesareas = txtCesareas.Text;
                var abortos = txtAbortos.Text;
                var medicacionA = txtMedicacionActualHC.Text;
                var padecimientoA = txtPadecimientoActualHC.Text;
                var exploF = txtExploracionFisicaHC.Text;
                var resultadosR = txtResultadosRelevantesHC.Text;
                var cbdAgudo = "null";
                var realizoCBDAgudo = txtRealizoDolorAgudoHC.Text;
                var cbdCronico = "null";
                var realizoCBDCronico = txtRealizoDolorCronicoHC.Text; ;
                var riesgoFr = txtRiesgoFraminHC.Text;
                var riesgoASCVD = txtRiesgoAscvdHC.Text;
                var estudioEC = txtEstudiosCronicosHC.Text;
                var realizoEC = txtRealizoEstudiosCronicosHC.Text;
                var ojoD = txtOjoDerechoHC.Text;
                var oidoD = txtOidoDerechoHC.Text;
                var pruebaS = txtPruebaSusurroHC.Text;
                var ojoI = txtOjoIzquierdoHC.Text;
                var oidoI = txtOidoIzquierdoHC.Text;
                var realizoAlt = txtRealizoAlteracionesHC.Text;
                var examen = txtExamenMmseHC.Text;
                var deterioroG = txtEscalaDeterioroHC.Text;
                var yesavage = txtEscalaGeriatricaHC.Text;
                var pruebaR = txtPruebaRelojHC.Text;
                var escalaM = txtEscalaGeriatricaMaltratoHC.Text;
                var realizoEvM = txtRealizoEvaluacionMaltratoHC.Text;
                var noHorasDuerme = txtNoHorasDuermeHC.Text;
                var duermeD = txtRBT1.Text;
                var sueñoF = txtRBT2.Text;
                var dcs = txtRBT3.Text;
                var ronquidoI = txtRBT4.Text;
                var pausasR = txtRBTN5.Text;
                var cansancioD = txtRBTN6.Text;
                var somDiurna = txtRBTN7.Text;
                var indiceC = txtIndiceCoHC.Text;
                var rEvCor = txtRealizoCormorbilidadesHC.Text;
                var cuestionarioF = txtCuestionarioFrailHC.Text;
                var realizoEvFragilidad = txtRealizoFragilidadHC.Text;
                var escalaSARC = txtEscalaSarcHC.Text;
                var rEvSarc = txtRealizoSarcopenia.Text;
                var criterioSt = txtCriteriosStoppHC.Text;
                var rEvMed = txtRealizoUsoMedHC.Text;
                var usoP = txtUsoProtesisHC.Text;
                var xerost = txtXerostomiaHC.Text;
                var numD = txtNumDientesHC.Text;
                var disfagia = txtDistagiaHC.Text;
                var candidiasis = txtCandidiasisHC.Text;
                var caries = txtCariesHC.Text;
                var rEvSalud = txtRealizoSaludBucalHC.Text;
                var actKatz = txtActBasicasHC.Text;
                var actLawton = txtActInstHC.Text;
                var indiceB = txtIndiceBarthelHC.Text;
                var escalaTin = txtRiesgoCaidasHC.Text;
                var rEvDesempeño = txtRealizoDesFisHC.Text;
                var escalaIn = txtIncontinenciaHC.Text;
                var rEvIncon = txtRealizoIncontinenciaHC.Text;
                var escalaK = txtValoracionFuncionalHC.Text;
                var escalaR = txtRamsayHC.Text;
                var rEvCuidados = txtRealizoCuidadosHC.Text;
                var sgAfasia = txtCHL1.Text;
                var sgCaidas = txtCHL2.Text;
                var sgColapso = txtCHL3.Text;
                var sgDeficit = txtCHL4.Text;
                var sgDepresion = txtCHL5.Text;
                var sgDesnutricion = txtCHL6.Text;
                var sgPatologia = txtCHL7.Text;
                var sgPatologiaD = txtCHL8.Text;
                var sgEstadoT = txtCHL9.Text;
                //var sgImpactacionF = txtCHL10.Text;
                //var sgFragilidad = txtCHL11.Text;
                //var sgHhipotension = txtCHL12.Text;
                var sgIncontinenciaF = txtCHL10.Text;
                var sgIncontinenciaU = txtCHL11.Text;
                var sgAbuso = txtCHL12.Text;
                var sgObesidad = txtCHL13.Text;
                var sgOsteoporosis = txtCHL14.Text;
                var sgPerdidaA = txtCHL15.Text;
                var sgUlceras = txtCHL16.Text;
                var sgPerdidaV = txtCHL17.Text;
                var sgPolifarmacia = txtCHL18.Text;
                var sgRegresion = txtCHL19.Text;
                var sgSxInmovilidad = txtCHL20.Text;
                var sgSxPiernas = txtCHL21.Text;
                var sgTranstornoC = txtCHL22.Text;
                var sgTranstornoS = txtCHL23.Text;
                var sgTranstornoM = txtCHL24.Text;
                var sgTranstornoE = txtCHL25.Text;
                var sgEncarnizamiento = txtCHL26.Text;
                var sgPatologiaSocial = txtCHL27.Text;
                var sgDemencia = txtCHL28.Text;
                var sgDelirum = txtCHL29.Text;
                var pClinicos = txtProblemasCliHC.Text;
                var analisis = txtAnalisisHC.Text;
                var pEstudios = txtPlanEstHC.Text;
                var pronostico = txtPronosticoHC.Text;
                var indicacionT = txtIndicacionTeHC.Text;
                var equipoM = "null";
                var fechaP = (dtpFechaProximaHC.Text);

                using (Server_Asociados.ServerAsociadosClient hc = new Server_Asociados.ServerAsociadosClient())
                {
                    hc.registrarHC(Id, idSocio, fecha, hora, esc, ocuP, alergias, nombreC, parentesco,
                    cuidadorP, telefonoC, svTa, svFC, svFR, svGlucemPre, svGlucemPost, svColesterol,
                    svTrigliceridos, svTemperatura, svPeso, svEstatura, svCintura, svIMC, resumenI,
                    alcoholismo, tabaquismo, toxic, transf, cartV, gestas, partos, cesareas, abortos,
                    medicacionA, padecimientoA, exploF, resultadosR, cbdAgudo, realizoCBDAgudo, cbdCronico, realizoCBDCronico, riesgoFr,
                    riesgoASCVD, estudioEC, realizoEC, ojoD, oidoD, pruebaS, ojoI, oidoI, realizoAlt, examen,
                    deterioroG, yesavage, pruebaR, escalaM, realizoEvM, noHorasDuerme, duermeD, sueñoF, dcs,
                    ronquidoI, pausasR, cansancioD, somDiurna, indiceC, rEvCor, cuestionarioF, realizoEvFragilidad,escalaSARC, rEvSarc, criterioSt,
                    rEvMed, usoP, xerost, numD, disfagia, candidiasis, caries, rEvSalud, actKatz, actLawton, indiceB,
                    escalaTin, rEvDesempeño, escalaIn, rEvIncon, escalaK, escalaR, rEvCuidados, sgAfasia, sgCaidas, sgColapso, sgDeficit, sgDepresion,
                    sgDesnutricion, sgPatologia, sgPatologiaD, sgEstadoT, sgIncontinenciaF, sgIncontinenciaU, sgAbuso, sgObesidad, sgOsteoporosis, sgPerdidaA, sgUlceras, sgPerdidaV,
                    sgPolifarmacia, sgRegresion, sgSxInmovilidad, sgSxPiernas, sgTranstornoC, sgTranstornoS, sgTranstornoM,
                    sgTranstornoE, sgEncarnizamiento, sgPatologiaSocial, sgDemencia, sgDelirum, pClinicos, analisis, pEstudios, pronostico, indicacionT, equipoM,
                  fechaP);
                    MessageBox.Show("DATOS GUARDADOS EXITOSAMENTE SOCIO:  "+txtNoSocioHC.Text);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        void CargarGrid()
        {
            using (MySqlConnection mysqlCon = new MySqlConnection("datasource=192.168.0.125;port=3306;username=jubiladoUser;password=1234;database=asociadosbd;"))
            {
                mysqlCon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("HCViewAll", mysqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dtblBook = new DataTable();
                sqlDa.Fill(dtblBook);
                dgvHC.DataSource = dtblBook;
                //dgvHC.Columns[0].Visible = false;
            }
        }


        const string MySqlConnecionString = "Server=192.168.0.125; Database=asociadosbd; Username=jubiladoUser; Password=1234;";

        static MySqlConnection GetNewConnection()
        {
            var conn = new MySqlConnection(MySqlConnecionString);
            conn.Open();
            return conn;
        }

        void CargarInfSocio()
        {
            var idSocio= txtNoSocioHC.Text;
            using (MySqlConnection conn = GetNewConnection())
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "SELECT nombre,edad,celular, telefono, estadoCivil, direccionE FROM socio WHERE idSocio=@idSocio";
                    cmd.Parameters.AddWithValue("@idSocio", idSocio);
                    MySqlDataReader consulta = cmd.ExecuteReader();
                    if (consulta.Read())
                    {
                        txtNombreHC.Text = consulta["nombre"].ToString();
                        txtEdadHC.Text = consulta["edad"].ToString();
                        txtTelefonoMovilHC.Text = consulta["celular"].ToString();
                        txtTelefonoFijoHC.Text = consulta["telefono"].ToString();
                        txtEstadoCivilHC.Text = consulta["estadoCivil"].ToString();
                        txtDomicilioHC.Text = consulta["direccionE"].ToString();
                    }
                    conn.Close();
                }
            }
        }



        private void txtTAHC_TextChanged(object sender, EventArgs e)
        {

        }

        private void rbtn1_CheckedChanged(object sender, EventArgs e)
        {
            txtRBT1.Text = "SI";
        }

        private void rbtn2_CheckedChanged(object sender, EventArgs e)
        {
            txtRBT1.Text = "NO";
        }

        private void rbtn3_CheckedChanged(object sender, EventArgs e)
        {
            txtRBT2.Text = "SI";
        }

        private void rbtn4_CheckedChanged(object sender, EventArgs e)
        {
            txtRBT2.Text = "NO";
        }

        private void rbtn5_CheckedChanged(object sender, EventArgs e)
        {
            txtRBT3.Text = "SI";
        }

        private void rbtn6_CheckedChanged(object sender, EventArgs e)
        {
            txtRBT3.Text = "NO";
        }

        private void rbtn7_CheckedChanged(object sender, EventArgs e)
        {
            txtRBT4.Text = "SI";
        }

        private void rbtn8_CheckedChanged(object sender, EventArgs e)
        {
            txtRBT4.Text = "NO";
        }

        private void rbtn9_CheckedChanged(object sender, EventArgs e)
        {
            txtRBTN5.Text = "SI";
        }

        private void rbtn10_CheckedChanged(object sender, EventArgs e)
        {
            txtRBTN5.Text = "NO";
        }

        private void rbtn11_CheckedChanged(object sender, EventArgs e)
        {
            txtRBTN6.Text = "SI";
        }

        private void rbtn12_CheckedChanged(object sender, EventArgs e)
        {
            txtRBTN6.Text = "NO";
        }

        private void rbtn13_CheckedChanged(object sender, EventArgs e)
        {
            txtRBTN7.Text = "SI";
        }

        private void rbtn14_CheckedChanged(object sender, EventArgs e)
        {
            txtRBTN7.Text = "NO";
        }

        void valorChec1()
        {
            if (chbAfasiaHC.Checked)
            {
                txtCHL1.Text = "SI";
            }
            else
            {
                txtCHL1.Text = "NO";
            }
        }
        void valorChec2()
        {
            if (chbCaidasHC.Checked)
            {
                txtCHL2.Text = "SI";
            }
            else
            {
                txtCHL2.Text = "NO";
            }
        }
        void valorChec3()
        {
            if (chbColapsoHC.Checked)
            {
                txtCHL3.Text = "SI";
            }
            else
            {
                txtCHL3.Text = "NO";
            }
        }
        void valorChec4()
        {
            if (chbDeficitHC.Checked)
            {
                txtCHL4.Text = "SI";
            }
            else
            {
                txtCHL4.Text = "NO";
            }
        }
        void valorChec5()
        {
            if (chbDepresionHC.Checked)
            {
                txtCHL5.Text = "SI";
            }
            else
            {
                txtCHL5.Text = "NO";
            }
        }
        void valorChec6()
        {
            if (chbDesnutricionHC.Checked)
            {
                txtCHL6.Text = "SI";
            }
            else
            {
                txtCHL6.Text = "NO";
            }
        }
        void valorChec7()
        {
            if (chbPatologiaHC.Checked)
            {
                txtCHL7.Text = "SI";
            }
            else
            {
                txtCHL7.Text = "NO";
            }
        }
        void valorChec8()
        {
            if (chbPatologiaDentalHC.Checked)
            {
                txtCHL8.Text = "SI";
            }
            else
            {
                txtCHL8.Text = "NO";
            }
        }
        void valorChec9()
        {
            if (chbEstadoTerminalHC.Checked)
            {
                txtCHL9.Text = "SI";
            }
            else
            {
                txtCHL9.Text = "NO";
            }
        }
        void valorChec10()
        {
            if (chbInconFecalHC.Checked)
            {
                txtCHL10.Text = "SI";
            }
            else
            {
                txtCHL10.Text = "NO";
            }
        }
        void valorChec11()
        {
            if (chbInconUrinariaHC.Checked)
            {
                txtCHL11.Text = "SI";
            }
            else
            {
                txtCHL11.Text = "NO";
            }
        }
        void valorChec12()
        {
            if (chbAbusoHC.Checked)
            {
                txtCHL12.Text = "SI";
            }
            else
            {
                txtCHL12.Text = "NO";
            }
        }
        void valorChec13()
        {
            if (chbObesidadHC.Checked)
            {
                txtCHL13.Text = "SI";
            }
            else
            {
                txtCHL13.Text = "NO";
            }
        }
        void valorChec14()
        {
            if (chbOsteoporosisHC.Checked)
            {
                txtCHL14.Text = "SI";
            }
            else
            {
                txtCHL14.Text = "NO";
            }
        }
        void valorChec15()
        {
            if (chbPerdidaAutoHC.Checked)
            {
                txtCHL15.Text = "SI";
            }
            else
            {
                txtCHL15.Text = "NO";
            }
        }
        void valorChec16()
        {
            if (chbUlcerasHC.Checked)
            {
                txtCHL16.Text = "SI";
            }
            else
            {
                txtCHL16.Text = "NO";
            }
        }
        void valorChec17()
        {
            if (chbPerdidaVitaHC.Checked)
            {
                txtCHL17.Text = "SI";
            }
            else
            {
                txtCHL17.Text = "NO";
            }
        }
        void valorChec18()
        {
            if (chbPolifarmaciaHC.Checked)
            {
                txtCHL18.Text = "SI";
            }
            else
            {
                txtCHL18.Text = "NO";
            }
        }
        void valorChec19()
        {
            if (chbRegresionHC.Checked)
            {
                txtCHL19.Text = "SI";
            }
            else
            {
                txtCHL19.Text = "NO";
            }
        }
        void valorChec20()
        {
            if (chbSxInmovHC.Checked)
            {
                txtCHL20.Text = "SI";
            }
            else
            {
                txtCHL20.Text = "NO";
            }
        }
        void valorChec21()
        {
            if (chbSxPiernasHC.Checked)
            {
                txtCHL21.Text = "SI";
            }
            else
            {
                txtCHL21.Text = "NO";
            }
        }
        void valorChec22()
        {
            if (chbTranstornoCompHC.Checked)
            {
                txtCHL22.Text = "SI";
            }
            else
            {
                txtCHL22.Text = "NO";
            }
        }
        void valorChec23()
        {
            if (chbTranstornoSueñoHC.Checked)
            {
                txtCHL23.Text = "SI";
            }
            else
            {
                txtCHL23.Text = "NO";
            }
        }
        void valorChec24()
        {
            if (chbTranstornoMarchaHC.Checked)
            {
                txtCHL24.Text = "SI";
            }
            else
            {
                txtCHL24.Text = "NO";
            }
        }
        void valorChec25()
        {
            if (chbTranstornoElecHC.Checked)
            {
                txtCHL25.Text = "SI";
            }
            else
            {
                txtCHL25.Text = "NO";
            }
        }
        void valorChec26()
        {
            if (chbEncarnizamientoHC.Checked)
            {
                txtCHL26.Text = "SI";
            }
            else
            {
                txtCHL26.Text = "NO";
            }
        }
        void valorChec27()
        {
            if (chbPatologiaPiesHC.Checked)
            {
                txtCHL27.Text = "SI";
            }
            else
            {
                txtCHL27.Text = "NO";
            }
        }
        void valorChec28()
        {
            if (chbDemenciaHC.Checked)
            {
                txtCHL28.Text = "SI";
            }
            else
            {
                txtCHL28.Text = "NO";
            }
        }
        void valorChec29()
        {
            if (chbDelirumHC.Checked)
            {
                txtCHL29.Text = "SI";
            }
            else
            {
                txtCHL29.Text = "NO";
            }
        }

        private void chbAfasiaHC_CheckedChanged(object sender, EventArgs e)
        {
            txtCHL1.Text = "SI";
            valorChec1();
        }

        private void chbCaidasHC_CheckedChanged(object sender, EventArgs e)
        {
            txtCHL2.Text = "SI";
            valorChec2();
        }

        private void chbColapsoHC_CheckedChanged(object sender, EventArgs e)
        {
            txtCHL3.Text = "SI";
            valorChec3();
        }

        private void chbDeficitHC_CheckedChanged(object sender, EventArgs e)
        {
            txtCHL4.Text = "SI";
            valorChec4();
        }

        private void chbDepresionHC_CheckedChanged(object sender, EventArgs e)
        {
            txtCHL5.Text = "SI";
            valorChec5();
        }

        private void chbDesnutricionHC_CheckedChanged(object sender, EventArgs e)
        {
            txtCHL6.Text = "SI";
            valorChec6();
        }

        private void chbPatologiaPiesHC_CheckedChanged(object sender, EventArgs e)
        {
            txtCHL7.Text = "SI";
            valorChec7();
        }

        private void chbPatologiaDentalHC_CheckedChanged(object sender, EventArgs e)
        {
            txtCHL8.Text = "SI";
            valorChec8();
        }

        private void chbEstadoTerminalHC_CheckedChanged(object sender, EventArgs e)
        {
            txtCHL9.Text = "SI";
            valorChec9();
        }

        private void chbInconFecalHC_CheckedChanged(object sender, EventArgs e)
        {
            txtCHL10.Text = "SI";
            valorChec10();
        }

        private void chbInconUrinariaHC_CheckedChanged(object sender, EventArgs e)
        {
            txtCHL11.Text = "SI";
            valorChec11();
        }

        private void chbAbusoHC_CheckedChanged(object sender, EventArgs e)
        {
            txtCHL12.Text = "SI";
            valorChec12();
        }

        private void chbObesidadHC_CheckedChanged(object sender, EventArgs e)
        {
            txtCHL13.Text = "SI";
            valorChec13();
        }

        private void chbOsteoporosisHC_CheckedChanged(object sender, EventArgs e)
        {
            txtCHL14.Text = "SI";
            valorChec14();
        }

        private void chbPerdidaAutoHC_CheckedChanged(object sender, EventArgs e)
        {
            txtCHL15.Text = "SI";
            valorChec15();
        }

        private void chbUlcerasHC_CheckedChanged(object sender, EventArgs e)
        {
            txtCHL16.Text = "SI";
            valorChec16();
        }

        private void chbPerdidaVitaHC_CheckedChanged(object sender, EventArgs e)
        {
            txtCHL17.Text = "SI";
            valorChec17();
        }

        private void chbPolifarmaciaHC_CheckedChanged(object sender, EventArgs e)
        {
            txtCHL18.Text = "SI";
            valorChec18();
        }

        private void chbRegresionHC_CheckedChanged(object sender, EventArgs e)
        {
            txtCHL19.Text = "SI";
            valorChec19();
        }

        private void chbSxInmovHC_CheckedChanged(object sender, EventArgs e)
        {
            txtCHL20.Text = "SI";
            valorChec20();
        }

        private void chbSxPiernasHC_CheckedChanged(object sender, EventArgs e)
        {
            txtCHL21.Text = "SI";
            valorChec21();
        }

        private void chbTranstornoCompHC_CheckedChanged(object sender, EventArgs e)
        {
            txtCHL22.Text = "SI";
            valorChec22();
        }

        private void chbTranstornoSueñoHC_CheckedChanged(object sender, EventArgs e)
        {
            txtCHL23.Text = "SI";
            valorChec23();
        }

        private void chbTranstornoMarchaHC_CheckedChanged(object sender, EventArgs e)
        {
            txtCHL24.Text = "SI";
            valorChec24();
        }

        private void chbTranstornoElecHC_CheckedChanged(object sender, EventArgs e)
        {
            txtCHL25.Text = "SI";
            valorChec25();
        }

        private void chbEncarnizamientoHC_CheckedChanged(object sender, EventArgs e)
        {
            txtCHL26.Text = "SI";
            valorChec26();
        }

        private void chbPatologiaHC_CheckedChanged(object sender, EventArgs e)
        {
            txtCHL27.Text = "SI";
            valorChec27();
        }

        private void chbDemenciaHC_CheckedChanged(object sender, EventArgs e)
        {
            txtCHL28.Text = "SI";
            valorChec28();
        }

        private void chbDelirumHC_CheckedChanged(object sender, EventArgs e)
        {
            txtCHL29.Text = "SI";
            valorChec29();
        }

        private void dgvHC_DoubleClick(object sender, EventArgs e)
        {
            if (dgvHC.CurrentRow.Index != -1)
            {
                txtId.Text = (dgvHC.CurrentRow.Cells[0].Value.ToString());
                txtNoSocioHC.Text = (dgvHC.CurrentRow.Cells[1].Value.ToString());
                txtFechaHC.Text = (dgvHC.CurrentRow.Cells[2].Value.ToString());
                txtHoraHC.Text = (dgvHC.CurrentRow.Cells[3].Value.ToString());
                cmbEscolaridadHC.Text = (dgvHC.CurrentRow.Cells[4].Value.ToString());
                txtOcupacionHC.Text = (dgvHC.CurrentRow.Cells[5].Value.ToString());
                txtAlergiasHC.Text = (dgvHC.CurrentRow.Cells[6].Value.ToString());
                txtNombreFamHC.Text = (dgvHC.CurrentRow.Cells[7].Value.ToString());
                cmbParentescoFamHC.Text = (dgvHC.CurrentRow.Cells[8].Value.ToString());
                txtCuidadorPrimHC.Text = (dgvHC.CurrentRow.Cells[9].Value.ToString());
                txtTelefonoFamHC.Text = (dgvHC.CurrentRow.Cells[10].Value.ToString());
                txtTAHC.Text = (dgvHC.CurrentRow.Cells[11].Value.ToString());
                txtFcHC.Text = (dgvHC.CurrentRow.Cells[12].Value.ToString());
                txtFrHC.Text = (dgvHC.CurrentRow.Cells[13].Value.ToString());
                txtGlucemiaPreHC.Text = (dgvHC.CurrentRow.Cells[14].Value.ToString());
                txtGlucemiaPostHC.Text = (dgvHC.CurrentRow.Cells[15].Value.ToString());
                txtColesterolHC.Text = (dgvHC.CurrentRow.Cells[16].Value.ToString());
                txtTrigliceridosHC.Text = (dgvHC.CurrentRow.Cells[17].Value.ToString());
                txtTemperaturaHC.Text = (dgvHC.CurrentRow.Cells[18].Value.ToString());
                txtPesoHC.Text = (dgvHC.CurrentRow.Cells[19].Value.ToString());
                txtEstaturaHC.Text = (dgvHC.CurrentRow.Cells[20].Value.ToString());
                txtCinturaHC.Text = (dgvHC.CurrentRow.Cells[21].Value.ToString());
                txtIMC.Text = (dgvHC.CurrentRow.Cells[22].Value.ToString());
                txtResumenInterrogatorioHC.Text = (dgvHC.CurrentRow.Cells[23].Value.ToString());
                cmbAlcoholismoHC.Text = (dgvHC.CurrentRow.Cells[24].Value.ToString());
                cmbTabaquismoHC.Text = (dgvHC.CurrentRow.Cells[25].Value.ToString());
                cmbToxicomaniaHC.Text = (dgvHC.CurrentRow.Cells[26].Value.ToString());
                cmbTransfusionesHC.Text = (dgvHC.CurrentRow.Cells[27].Value.ToString());
                txtCartillaVacunacionHC.Text = (dgvHC.CurrentRow.Cells[28].Value.ToString());
                txtGestas.Text = (dgvHC.CurrentRow.Cells[29].Value.ToString());
                txtPartos.Text = (dgvHC.CurrentRow.Cells[30].Value.ToString());
                txtCesareas.Text = (dgvHC.CurrentRow.Cells[31].Value.ToString());
                txtAbortos.Text = (dgvHC.CurrentRow.Cells[32].Value.ToString());
                txtMedicacionActualHC.Text = (dgvHC.CurrentRow.Cells[33].Value.ToString());
                txtPadecimientoActualHC.Text = (dgvHC.CurrentRow.Cells[34].Value.ToString());
                txtExploracionFisicaHC.Text = (dgvHC.CurrentRow.Cells[35].Value.ToString());
                txtResultadosRelevantesHC.Text = (dgvHC.CurrentRow.Cells[36].Value.ToString());
                //columna 37
                txtRealizoDolorAgudoHC.Text = (dgvHC.CurrentRow.Cells[38].Value.ToString());
                //columna 39
                txtRealizoDolorCronicoHC.Text = (dgvHC.CurrentRow.Cells[40].Value.ToString());
                txtRiesgoFraminHC.Text = (dgvHC.CurrentRow.Cells[41].Value.ToString());
                txtRiesgoAscvdHC.Text = (dgvHC.CurrentRow.Cells[42].Value.ToString());
                txtRealizoEstudiosCronicosHC.Text = (dgvHC.CurrentRow.Cells[43].Value.ToString());
                txtEstudiosCronicosHC.Text = (dgvHC.CurrentRow.Cells[44].Value.ToString());
                txtOjoDerechoHC.Text = (dgvHC.CurrentRow.Cells[45].Value.ToString());
                txtOidoDerechoHC.Text = (dgvHC.CurrentRow.Cells[46].Value.ToString());
                txtPruebaSusurroHC.Text = (dgvHC.CurrentRow.Cells[47].Value.ToString());
                txtOjoIzquierdoHC.Text = (dgvHC.CurrentRow.Cells[48].Value.ToString());
                txtOidoIzquierdoHC.Text = (dgvHC.CurrentRow.Cells[49].Value.ToString());
                txtRealizoAlteracionesHC.Text = (dgvHC.CurrentRow.Cells[50].Value.ToString());
                txtExamenMmseHC.Text = (dgvHC.CurrentRow.Cells[51].Value.ToString());
                txtEscalaDeterioroHC.Text = (dgvHC.CurrentRow.Cells[52].Value.ToString());
                txtEscalaGeriatricaHC.Text = (dgvHC.CurrentRow.Cells[53].Value.ToString());
                txtPruebaRelojHC.Text = (dgvHC.CurrentRow.Cells[54].Value.ToString());
                txtEscalaGeriatricaMaltratoHC.Text = (dgvHC.CurrentRow.Cells[55].Value.ToString());
                txtRealizoEvaluacionMaltratoHC.Text = (dgvHC.CurrentRow.Cells[56].Value.ToString());
                txtNoHorasDuermeHC.Text = (dgvHC.CurrentRow.Cells[57].Value.ToString());
                if (dgvHC.CurrentRow.Cells[58].Value.ToString() == "SI")
                {
                    rbtn1.Checked = true;
                }
                else
                {
                    rbtn2.Checked = true;
                }
                if (dgvHC.CurrentRow.Cells[59].Value.ToString() == "SI")
                {
                    rbtn3.Checked = true;
                }
                else
                {
                    rbtn4.Checked = true;
                }
                if (dgvHC.CurrentRow.Cells[60].Value.ToString() == "SI")
                {
                    rbtn5.Checked = true;
                }
                else
                {
                    rbtn6.Checked = true;
                }
                if (dgvHC.CurrentRow.Cells[61].Value.ToString() == "SI")
                {
                    rbtn7.Checked = true;
                }
                else
                {
                    rbtn8.Checked = true;
                }
                if (dgvHC.CurrentRow.Cells[62].Value.ToString() == "SI")
                {
                    rbtn9.Checked = true;
                }
                else
                {
                    rbtn10.Checked = true;
                }
                if (dgvHC.CurrentRow.Cells[63].Value.ToString() == "SI")
                {
                    rbtn11.Checked = true;
                }
                else
                {
                    rbtn12.Checked = true;
                }
                if (dgvHC.CurrentRow.Cells[64].Value.ToString() == "SI")
                {
                    rbtn13.Checked = true;
                }
                else
                {
                    rbtn14.Checked = true;
                }
                txtIndiceCoHC.Text = (dgvHC.CurrentRow.Cells[65].Value.ToString());
                txtRealizoCormorbilidadesHC.Text = (dgvHC.CurrentRow.Cells[66].Value.ToString());
                txtCuestionarioFrailHC.Text = (dgvHC.CurrentRow.Cells[67].Value.ToString());
                // columna 68
                txtEscalaSarcHC.Text = (dgvHC.CurrentRow.Cells[69].Value.ToString());
                txtRealizoSarcopenia.Text = (dgvHC.CurrentRow.Cells[70].Value.ToString());
                txtCriteriosStoppHC.Text = (dgvHC.CurrentRow.Cells[71].Value.ToString());
                txtRealizoUsoMedHC.Text = (dgvHC.CurrentRow.Cells[72].Value.ToString());
                txtUsoProtesisHC.Text = (dgvHC.CurrentRow.Cells[73].Value.ToString());
                txtXerostomiaHC.Text = (dgvHC.CurrentRow.Cells[74].Value.ToString());
                txtNumDientesHC.Text = (dgvHC.CurrentRow.Cells[75].Value.ToString());
                txtDistagiaHC.Text = (dgvHC.CurrentRow.Cells[76].Value.ToString());
                txtCandidiasisHC.Text = (dgvHC.CurrentRow.Cells[77].Value.ToString());
                txtCariesHC.Text = (dgvHC.CurrentRow.Cells[78].Value.ToString());
                txtRealizoSaludBucalHC.Text = (dgvHC.CurrentRow.Cells[79].Value.ToString());
                txtActBasicasHC.Text = (dgvHC.CurrentRow.Cells[80].Value.ToString());
                txtActInstHC.Text = (dgvHC.CurrentRow.Cells[81].Value.ToString());
                txtIndiceBarthelHC.Text = (dgvHC.CurrentRow.Cells[82].Value.ToString());
                txtRiesgoCaidasHC.Text = (dgvHC.CurrentRow.Cells[83].Value.ToString());
                txtRealizoDesFisHC.Text = (dgvHC.CurrentRow.Cells[84].Value.ToString());
                txtIncontinenciaHC.Text = (dgvHC.CurrentRow.Cells[85].Value.ToString());
                txtRealizoIncontinenciaHC.Text = (dgvHC.CurrentRow.Cells[86].Value.ToString());
                txtValoracionFuncionalHC.Text = (dgvHC.CurrentRow.Cells[87].Value.ToString());
                txtRamsayHC.Text = (dgvHC.CurrentRow.Cells[88].Value.ToString());                
                txtRealizoCuidadosHC.Text = (dgvHC.CurrentRow.Cells[89].Value.ToString());
                if (dgvHC.CurrentRow.Cells[90].Value.ToString() == "SI")
                {
                    chbAfasiaHC.Checked = true;
                }
                else
                {
                    chbAfasiaHC.Checked = false;
                }
                if (dgvHC.CurrentRow.Cells[91].Value.ToString() == "SI")
                {
                    chbCaidasHC.Checked = true;
                }
                if (dgvHC.CurrentRow.Cells[92].Value.ToString() == "SI")
                {
                    chbColapsoHC.Checked = true;
                }
                if (dgvHC.CurrentRow.Cells[93].Value.ToString() == "SI")
                {
                    chbDeficitHC.Checked = true;
                }
                if (dgvHC.CurrentRow.Cells[94].Value.ToString() == "SI")
                {
                    chbDepresionHC.Checked = true;
                }
                if (dgvHC.CurrentRow.Cells[95].Value.ToString() == "SI")
                {
                    chbDesnutricionHC.Checked = true;
                }
                if (dgvHC.CurrentRow.Cells[96].Value.ToString() == "SI")
                {
                    chbPatologiaHC.Checked = true;
                }
                if (dgvHC.CurrentRow.Cells[97].Value.ToString() == "SI")
                {
                    chbPatologiaDentalHC.Checked = true;
                }
                if (dgvHC.CurrentRow.Cells[98].Value.ToString() == "SI")
                {
                    chbEstadoTerminalHC.Checked = true;
                }
                if (dgvHC.CurrentRow.Cells[99].Value.ToString() == "SI")
                {
                    chbInconFecalHC.Checked = true;
                }
                if (dgvHC.CurrentRow.Cells[100].Value.ToString() == "SI")
                {
                    chbInconUrinariaHC.Checked = true;
                }
                if (dgvHC.CurrentRow.Cells[101].Value.ToString() == "SI")
                {
                    chbAbusoHC.Checked = true;
                }
                if (dgvHC.CurrentRow.Cells[102].Value.ToString() == "SI")
                {
                    chbObesidadHC.Checked = true;
                }
                if (dgvHC.CurrentRow.Cells[103].Value.ToString() == "SI")
                {
                    chbOsteoporosisHC.Checked = true;
                }
                if (dgvHC.CurrentRow.Cells[104].Value.ToString() == "SI")
                {
                    chbPerdidaAutoHC.Checked = true;
                }
                if (dgvHC.CurrentRow.Cells[105].Value.ToString() == "SI")
                {
                    chbUlcerasHC.Checked = true;
                }
                if (dgvHC.CurrentRow.Cells[106].Value.ToString() == "SI")
                {
                    chbPerdidaVitaHC.Checked = true;
                }
                if (dgvHC.CurrentRow.Cells[107].Value.ToString() == "SI")
                {
                    chbPolifarmaciaHC.Checked = true;
                }
                if (dgvHC.CurrentRow.Cells[108].Value.ToString() == "SI")
                {
                    chbRegresionHC.Checked = true;
                }
                if (dgvHC.CurrentRow.Cells[109].Value.ToString() == "SI")
                {
                    chbSxInmovHC.Checked = true;
                }
                if (dgvHC.CurrentRow.Cells[110].Value.ToString() == "SI")
                {
                    chbSxPiernasHC.Checked = true;
                }
                if (dgvHC.CurrentRow.Cells[111].Value.ToString() == "SI")
                {
                    chbTranstornoCompHC.Checked = true;
                }
                if (dgvHC.CurrentRow.Cells[112].Value.ToString() == "SI")
                {
                    chbTranstornoSueñoHC.Checked = true;
                }
                if (dgvHC.CurrentRow.Cells[113].Value.ToString() == "SI")
                {
                    chbTranstornoMarchaHC.Checked = true;
                }
                if (dgvHC.CurrentRow.Cells[114].Value.ToString() == "SI")
                {
                    chbTranstornoElecHC.Checked = true;
                }
                if (dgvHC.CurrentRow.Cells[115].Value.ToString() == "SI")
                {
                    chbEncarnizamientoHC.Checked = true;
                }
                if (dgvHC.CurrentRow.Cells[116].Value.ToString() == "SI")
                {
                    chbPatologiaHC.Checked = true;
                }
                if (dgvHC.CurrentRow.Cells[117].Value.ToString() == "SI")
                {
                    chbDemenciaHC.Checked = true;
                }               
                if (dgvHC.CurrentRow.Cells[118].Value.ToString() == "SI")
                {
                    chbDelirumHC.Checked = true;
                }
                txtProblemasCliHC.Text = (dgvHC.CurrentRow.Cells[119].Value.ToString());
                txtAnalisisHC.Text = (dgvHC.CurrentRow.Cells[120].Value.ToString());
                txtPlanEstHC.Text = (dgvHC.CurrentRow.Cells[121].Value.ToString());
                txtPronosticoHC.Text = (dgvHC.CurrentRow.Cells[122].Value.ToString());
                txtIndicacionTeHC.Text = (dgvHC.CurrentRow.Cells[123].Value.ToString());
                //columna 124
                dtpFechaProximaHC.Text = (dgvHC.CurrentRow.Cells[125].Value.ToString());
            }            
                btnGuardarHC.Text = "ACTUALIZAR";
                CargarInfSocio();
            }

        private void btnBuscarHC_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection mysqlCon = new MySqlConnection("datasource=192.168.0.125;port=3306;username=jubiladoUser;password=1234;database=asociadosbd;"))
                {
                    mysqlCon.Open();
                    MySqlDataAdapter sqlDa = new MySqlDataAdapter("HCViewAll", mysqlCon);
                    sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                    sqlDa.SelectCommand.Parameters.AddWithValue("_idSocio", txtNoSocioSearchHC.Text);
                    DataTable dtblBook = new DataTable();
                    sqlDa.Fill(dtblBook);
                    dgvHC.DataSource = dtblBook;
                    mysqlCon.Close();
                    if (dgvHC.CurrentRow.Cells[0].Value.ToString() == "")
                    {
                        MessageBox.Show("SIN RESULTADOS, VERIFIQUE SU NO. DE SOCIO");
                    }
                }

            }
            catch (Exception ex )
            {
                MessageBox.Show("SIN RESULTADOS, VERIFIQUE SU NO. DE SOCIO ");
            }

        
        }
    }
}
