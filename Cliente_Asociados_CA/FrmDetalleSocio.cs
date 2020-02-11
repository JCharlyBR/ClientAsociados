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
        }
        void cargarComboCategoria()
        {
            using (Server_Asociados.ServerAsociadosClient cat = new Server_Asociados.ServerAsociadosClient())
            {
                this.cmbCategoriaTaller.DataSource = cat.cargarComboCategoriaT();
                cmbCategoriaTaller.DisplayMember = "nombre";


            }

        }
    }
}
