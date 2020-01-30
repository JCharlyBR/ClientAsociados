namespace Cliente_Asociados_CA
{
    partial class FrmDetalleSocio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDetalleSocio));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.dgvConsultaSocio = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtNombreSocio = new System.Windows.Forms.TextBox();
            this.txtNoSocio = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.dgvBeneficiario = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbCategoriaTaller = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.cmbNombreTaller = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtHorarioTaller = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvEnfermedad = new System.Windows.Forms.DataGridView();
            this.cmbEnfermedadPadecida = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnAgregarEnfermedad = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtCausaDefuncion = new System.Windows.Forms.TextBox();
            this.txtFechaDefuncion = new System.Windows.Forms.TextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnBuscarPorNum = new System.Windows.Forms.Button();
            this.txtBuscarNumSocio = new System.Windows.Forms.TextBox();
            this.btnBuscarPorNombre = new System.Windows.Forms.Button();
            this.txtBuscarNombreSocio = new System.Windows.Forms.TextBox();
            this.dgvTaller = new System.Windows.Forms.DataGridView();
            this.btnAgregarTaller = new System.Windows.Forms.Button();
            this.txtEstatus = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaSocio)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBeneficiario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnfermedad)).BeginInit();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaller)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.label13);
            this.panel2.Location = new System.Drawing.Point(-10, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1163, 38);
            this.panel2.TabIndex = 29;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(482, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(136, 21);
            this.label13.TabIndex = 0;
            this.label13.Text = "Detalle de Socio";
            // 
            // dgvConsultaSocio
            // 
            this.dgvConsultaSocio.AllowUserToAddRows = false;
            this.dgvConsultaSocio.AllowUserToDeleteRows = false;
            this.dgvConsultaSocio.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.dgvConsultaSocio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvConsultaSocio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultaSocio.Location = new System.Drawing.Point(12, 510);
            this.dgvConsultaSocio.Name = "dgvConsultaSocio";
            this.dgvConsultaSocio.ReadOnly = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgvConsultaSocio.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvConsultaSocio.Size = new System.Drawing.Size(1127, 178);
            this.dgvConsultaSocio.TabIndex = 32;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Moccasin;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.dgvBeneficiario);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(366, 53);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(773, 147);
            this.panel3.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(3, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(214, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "BENEFICIARIO REGISTRADO:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Moccasin;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.btnAgregarEnfermedad);
            this.panel4.Controls.Add(this.label14);
            this.panel4.Controls.Add(this.cmbEnfermedadPadecida);
            this.panel4.Controls.Add(this.dgvEnfermedad);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Location = new System.Drawing.Point(529, 208);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(396, 218);
            this.panel4.TabIndex = 34;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Moccasin;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.txtEstatus);
            this.panel5.Controls.Add(this.label10);
            this.panel5.Controls.Add(this.txtNombreSocio);
            this.panel5.Controls.Add(this.txtNoSocio);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Location = new System.Drawing.Point(12, 53);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(345, 147);
            this.panel5.TabIndex = 35;
            // 
            // txtNombreSocio
            // 
            this.txtNombreSocio.Enabled = false;
            this.txtNombreSocio.Location = new System.Drawing.Point(93, 75);
            this.txtNombreSocio.Multiline = true;
            this.txtNombreSocio.Name = "txtNombreSocio";
            this.txtNombreSocio.Size = new System.Drawing.Size(234, 25);
            this.txtNombreSocio.TabIndex = 4;
            // 
            // txtNoSocio
            // 
            this.txtNoSocio.Enabled = false;
            this.txtNoSocio.Location = new System.Drawing.Point(93, 38);
            this.txtNoSocio.Multiline = true;
            this.txtNoSocio.Name = "txtNoSocio";
            this.txtNoSocio.Size = new System.Drawing.Size(68, 25);
            this.txtNoSocio.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label7.Location = new System.Drawing.Point(4, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "Nombre:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label6.Location = new System.Drawing.Point(4, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "No.Socio:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "DATOS SOCIO:";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Moccasin;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.btnAgregarTaller);
            this.panel6.Controls.Add(this.dgvTaller);
            this.panel6.Controls.Add(this.txtHorarioTaller);
            this.panel6.Controls.Add(this.label12);
            this.panel6.Controls.Add(this.cmbNombreTaller);
            this.panel6.Controls.Add(this.textBox4);
            this.panel6.Controls.Add(this.label11);
            this.panel6.Controls.Add(this.label9);
            this.panel6.Controls.Add(this.cmbCategoriaTaller);
            this.panel6.Controls.Add(this.label8);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Location = new System.Drawing.Point(12, 208);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(508, 218);
            this.panel6.TabIndex = 36;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label10.Location = new System.Drawing.Point(4, 111);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 17);
            this.label10.TabIndex = 5;
            this.label10.Text = "Estatus:";
            // 
            // dgvBeneficiario
            // 
            this.dgvBeneficiario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBeneficiario.Location = new System.Drawing.Point(7, 38);
            this.dgvBeneficiario.Name = "dgvBeneficiario";
            this.dgvBeneficiario.Size = new System.Drawing.Size(751, 94);
            this.dgvBeneficiario.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(3, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "TALLER INSCRITO:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label8.Location = new System.Drawing.Point(4, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Categoria:";
            // 
            // cmbCategoriaTaller
            // 
            this.cmbCategoriaTaller.FormattingEnabled = true;
            this.cmbCategoriaTaller.Location = new System.Drawing.Point(93, 32);
            this.cmbCategoriaTaller.Name = "cmbCategoriaTaller";
            this.cmbCategoriaTaller.Size = new System.Drawing.Size(158, 21);
            this.cmbCategoriaTaller.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label9.Location = new System.Drawing.Point(4, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "Nombre:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label11.Location = new System.Drawing.Point(4, 98);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 17);
            this.label11.TabIndex = 9;
            this.label11.Text = "Instructor:";
            // 
            // textBox4
            // 
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(93, 90);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(158, 25);
            this.textBox4.TabIndex = 10;
            // 
            // cmbNombreTaller
            // 
            this.cmbNombreTaller.FormattingEnabled = true;
            this.cmbNombreTaller.Location = new System.Drawing.Point(93, 64);
            this.cmbNombreTaller.Name = "cmbNombreTaller";
            this.cmbNombreTaller.Size = new System.Drawing.Size(158, 21);
            this.cmbNombreTaller.TabIndex = 11;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label12.Location = new System.Drawing.Point(270, 36);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 17);
            this.label12.TabIndex = 12;
            this.label12.Text = "Horario:";
            // 
            // txtHorarioTaller
            // 
            this.txtHorarioTaller.Enabled = false;
            this.txtHorarioTaller.Location = new System.Drawing.Point(273, 65);
            this.txtHorarioTaller.Multiline = true;
            this.txtHorarioTaller.Name = "txtHorarioTaller";
            this.txtHorarioTaller.Size = new System.Drawing.Size(209, 50);
            this.txtHorarioTaller.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(3, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(197, 19);
            this.label5.TabIndex = 14;
            this.label5.Text = "ENFERMEDAD PADECIDA:";
            // 
            // dgvEnfermedad
            // 
            this.dgvEnfermedad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEnfermedad.Location = new System.Drawing.Point(7, 90);
            this.dgvEnfermedad.Name = "dgvEnfermedad";
            this.dgvEnfermedad.Size = new System.Drawing.Size(373, 119);
            this.dgvEnfermedad.TabIndex = 15;
            // 
            // cmbEnfermedadPadecida
            // 
            this.cmbEnfermedadPadecida.FormattingEnabled = true;
            this.cmbEnfermedadPadecida.Location = new System.Drawing.Point(100, 35);
            this.cmbEnfermedadPadecida.Name = "cmbEnfermedadPadecida";
            this.cmbEnfermedadPadecida.Size = new System.Drawing.Size(280, 21);
            this.cmbEnfermedadPadecida.TabIndex = 14;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label14.Location = new System.Drawing.Point(7, 35);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(87, 17);
            this.label14.TabIndex = 16;
            this.label14.Text = "Enfermedad:";
            // 
            // btnAgregarEnfermedad
            // 
            this.btnAgregarEnfermedad.Location = new System.Drawing.Point(267, 61);
            this.btnAgregarEnfermedad.Name = "btnAgregarEnfermedad";
            this.btnAgregarEnfermedad.Size = new System.Drawing.Size(113, 23);
            this.btnAgregarEnfermedad.TabIndex = 17;
            this.btnAgregarEnfermedad.Text = "AGREGAR\r\n";
            this.btnAgregarEnfermedad.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Moccasin;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.txtFechaDefuncion);
            this.panel7.Controls.Add(this.txtCausaDefuncion);
            this.panel7.Controls.Add(this.label17);
            this.panel7.Controls.Add(this.label15);
            this.panel7.Controls.Add(this.label16);
            this.panel7.Location = new System.Drawing.Point(931, 208);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(208, 218);
            this.panel7.TabIndex = 35;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label16.Location = new System.Drawing.Point(3, 4);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(103, 19);
            this.label16.TabIndex = 14;
            this.label16.Text = "DEFUNCIÓN:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label15.Location = new System.Drawing.Point(4, 29);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(49, 17);
            this.label15.TabIndex = 17;
            this.label15.Text = "Fecha:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label17.Location = new System.Drawing.Point(4, 64);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(50, 17);
            this.label17.TabIndex = 18;
            this.label17.Text = "Causa:";
            // 
            // txtCausaDefuncion
            // 
            this.txtCausaDefuncion.Enabled = false;
            this.txtCausaDefuncion.Location = new System.Drawing.Point(7, 84);
            this.txtCausaDefuncion.Multiline = true;
            this.txtCausaDefuncion.Name = "txtCausaDefuncion";
            this.txtCausaDefuncion.Size = new System.Drawing.Size(186, 125);
            this.txtCausaDefuncion.TabIndex = 14;
            this.txtCausaDefuncion.Text = "NO APLICA";
            // 
            // txtFechaDefuncion
            // 
            this.txtFechaDefuncion.Enabled = false;
            this.txtFechaDefuncion.Location = new System.Drawing.Point(50, 29);
            this.txtFechaDefuncion.Multiline = true;
            this.txtFechaDefuncion.Name = "txtFechaDefuncion";
            this.txtFechaDefuncion.Size = new System.Drawing.Size(143, 25);
            this.txtFechaDefuncion.TabIndex = 7;
            this.txtFechaDefuncion.Text = "NO APLICA";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Controls.Add(this.btnBuscarPorNum);
            this.panel8.Controls.Add(this.txtBuscarNumSocio);
            this.panel8.Controls.Add(this.btnBuscarPorNombre);
            this.panel8.Controls.Add(this.txtBuscarNombreSocio);
            this.panel8.Location = new System.Drawing.Point(11, 442);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1129, 51);
            this.panel8.TabIndex = 45;
            // 
            // btnBuscarPorNum
            // 
            this.btnBuscarPorNum.Location = new System.Drawing.Point(652, 16);
            this.btnBuscarPorNum.Name = "btnBuscarPorNum";
            this.btnBuscarPorNum.Size = new System.Drawing.Size(131, 23);
            this.btnBuscarPorNum.TabIndex = 46;
            this.btnBuscarPorNum.Text = "Buscar por Num Socio";
            this.btnBuscarPorNum.UseVisualStyleBackColor = true;
            // 
            // txtBuscarNumSocio
            // 
            this.txtBuscarNumSocio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscarNumSocio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarNumSocio.Location = new System.Drawing.Point(447, 15);
            this.txtBuscarNumSocio.Name = "txtBuscarNumSocio";
            this.txtBuscarNumSocio.Size = new System.Drawing.Size(184, 24);
            this.txtBuscarNumSocio.TabIndex = 45;
            // 
            // btnBuscarPorNombre
            // 
            this.btnBuscarPorNombre.Location = new System.Drawing.Point(220, 17);
            this.btnBuscarPorNombre.Name = "btnBuscarPorNombre";
            this.btnBuscarPorNombre.Size = new System.Drawing.Size(131, 23);
            this.btnBuscarPorNombre.TabIndex = 44;
            this.btnBuscarPorNombre.Text = "Buscar por Nombre";
            this.btnBuscarPorNombre.UseVisualStyleBackColor = true;
            // 
            // txtBuscarNombreSocio
            // 
            this.txtBuscarNombreSocio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscarNombreSocio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarNombreSocio.Location = new System.Drawing.Point(17, 15);
            this.txtBuscarNombreSocio.Name = "txtBuscarNombreSocio";
            this.txtBuscarNombreSocio.Size = new System.Drawing.Size(184, 24);
            this.txtBuscarNombreSocio.TabIndex = 43;
            // 
            // dgvTaller
            // 
            this.dgvTaller.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTaller.Location = new System.Drawing.Point(7, 145);
            this.dgvTaller.Name = "dgvTaller";
            this.dgvTaller.Size = new System.Drawing.Size(485, 64);
            this.dgvTaller.TabIndex = 18;
            // 
            // btnAgregarTaller
            // 
            this.btnAgregarTaller.Location = new System.Drawing.Point(369, 118);
            this.btnAgregarTaller.Name = "btnAgregarTaller";
            this.btnAgregarTaller.Size = new System.Drawing.Size(113, 23);
            this.btnAgregarTaller.TabIndex = 19;
            this.btnAgregarTaller.Text = "AGREGAR TALLER";
            this.btnAgregarTaller.UseVisualStyleBackColor = true;
            // 
            // txtEstatus
            // 
            this.txtEstatus.Enabled = false;
            this.txtEstatus.Location = new System.Drawing.Point(93, 110);
            this.txtEstatus.Multiline = true;
            this.txtEstatus.Name = "txtEstatus";
            this.txtEstatus.Size = new System.Drawing.Size(234, 25);
            this.txtEstatus.TabIndex = 6;
            // 
            // FrmDetalleSocio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1151, 700);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dgvConsultaSocio);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmDetalleSocio";
            this.Text = "FrmDetalleSocio";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaSocio)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBeneficiario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnfermedad)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaller)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dgvConsultaSocio;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNombreSocio;
        private System.Windows.Forms.TextBox txtNoSocio;
        private System.Windows.Forms.DataGridView dgvBeneficiario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtHorarioTaller;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbNombreTaller;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbCategoriaTaller;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAgregarEnfermedad;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cmbEnfermedadPadecida;
        private System.Windows.Forms.DataGridView dgvEnfermedad;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox txtFechaDefuncion;
        private System.Windows.Forms.TextBox txtCausaDefuncion;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btnBuscarPorNum;
        private System.Windows.Forms.TextBox txtBuscarNumSocio;
        private System.Windows.Forms.Button btnBuscarPorNombre;
        private System.Windows.Forms.TextBox txtBuscarNombreSocio;
        private System.Windows.Forms.Button btnAgregarTaller;
        private System.Windows.Forms.DataGridView dgvTaller;
        private System.Windows.Forms.TextBox txtEstatus;
    }
}