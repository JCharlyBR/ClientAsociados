namespace Cliente_Asociados_CA
{
    partial class FrmTaller
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTaller));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.dgvTaller = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnRecreativas = new System.Windows.Forms.Button();
            this.btnCulturales = new System.Windows.Forms.Button();
            this.btnDeportivas = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtIdCategoria = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtNombreCategoria = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRegistrarCategoria = new System.Windows.Forms.Button();
            this.btnEliminarCategoria = new System.Windows.Forms.Button();
            this.cmbCategoriaTaller = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtIdCurso = new System.Windows.Forms.TextBox();
            this.btnEliminarCurso = new System.Windows.Forms.Button();
            this.btnRegistrarCurso = new System.Windows.Forms.Button();
            this.txtHorario = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtInstructorTaller = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreTaller = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvCategorias = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaller)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.label13);
            this.panel2.Location = new System.Drawing.Point(-2, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1154, 38);
            this.panel2.TabIndex = 29;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(431, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(243, 21);
            this.label13.TabIndex = 0;
            this.label13.Text = "Registro y Consulta de Talleres";
            // 
            // dgvTaller
            // 
            this.dgvTaller.AllowUserToAddRows = false;
            this.dgvTaller.AllowUserToDeleteRows = false;
            this.dgvTaller.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.dgvTaller.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTaller.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTaller.Location = new System.Drawing.Point(568, 156);
            this.dgvTaller.Name = "dgvTaller";
            this.dgvTaller.ReadOnly = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgvTaller.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTaller.Size = new System.Drawing.Size(566, 189);
            this.dgvTaller.TabIndex = 31;
            this.dgvTaller.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvTaller_MouseDoubleClick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnRecreativas);
            this.panel3.Controls.Add(this.btnCulturales);
            this.panel3.Controls.Add(this.btnDeportivas);
            this.panel3.Location = new System.Drawing.Point(568, 66);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(566, 80);
            this.panel3.TabIndex = 45;
            // 
            // btnRecreativas
            // 
            this.btnRecreativas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(112)))), ((int)(((byte)(99)))));
            this.btnRecreativas.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(112)))), ((int)(((byte)(99)))));
            this.btnRecreativas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecreativas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecreativas.Location = new System.Drawing.Point(385, 21);
            this.btnRecreativas.Name = "btnRecreativas";
            this.btnRecreativas.Size = new System.Drawing.Size(148, 36);
            this.btnRecreativas.TabIndex = 2;
            this.btnRecreativas.Text = "Actividades Recreativas ";
            this.btnRecreativas.UseVisualStyleBackColor = false;
            this.btnRecreativas.Click += new System.EventHandler(this.btnRecreativas_Click);
            // 
            // btnCulturales
            // 
            this.btnCulturales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.btnCulturales.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.btnCulturales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCulturales.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCulturales.Location = new System.Drawing.Point(209, 21);
            this.btnCulturales.Name = "btnCulturales";
            this.btnCulturales.Size = new System.Drawing.Size(148, 36);
            this.btnCulturales.TabIndex = 1;
            this.btnCulturales.Text = "Actividades Culturales";
            this.btnCulturales.UseVisualStyleBackColor = false;
            this.btnCulturales.Click += new System.EventHandler(this.btnCulturales_Click);
            // 
            // btnDeportivas
            // 
            this.btnDeportivas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(220)))), ((int)(((byte)(111)))));
            this.btnDeportivas.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(220)))), ((int)(((byte)(111)))));
            this.btnDeportivas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeportivas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeportivas.Location = new System.Drawing.Point(33, 21);
            this.btnDeportivas.Name = "btnDeportivas";
            this.btnDeportivas.Size = new System.Drawing.Size(146, 36);
            this.btnDeportivas.TabIndex = 0;
            this.btnDeportivas.Text = "Actividades Deportivas";
            this.btnDeportivas.UseVisualStyleBackColor = false;
            this.btnDeportivas.Click += new System.EventHandler(this.btnDeportivas_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Moccasin;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtIdCategoria);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtDescripcion);
            this.panel1.Controls.Add(this.txtNombreCategoria);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnRegistrarCategoria);
            this.panel1.Controls.Add(this.btnEliminarCategoria);
            this.panel1.Location = new System.Drawing.Point(11, 373);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(542, 216);
            this.panel1.TabIndex = 47;
            // 
            // txtIdCategoria
            // 
            this.txtIdCategoria.Location = new System.Drawing.Point(265, 9);
            this.txtIdCategoria.Name = "txtIdCategoria";
            this.txtIdCategoria.Size = new System.Drawing.Size(51, 20);
            this.txtIdCategoria.TabIndex = 53;
            this.txtIdCategoria.Text = "0";
            this.txtIdCategoria.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(13, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(245, 23);
            this.label6.TabIndex = 52;
            this.label6.Text = "DATOS DE LA CATEGORÍA ";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescripcion.Location = new System.Drawing.Point(103, 107);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(307, 26);
            this.txtDescripcion.TabIndex = 51;
            // 
            // txtNombreCategoria
            // 
            this.txtNombreCategoria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombreCategoria.Location = new System.Drawing.Point(103, 61);
            this.txtNombreCategoria.Multiline = true;
            this.txtNombreCategoria.Name = "txtNombreCategoria";
            this.txtNombreCategoria.Size = new System.Drawing.Size(307, 26);
            this.txtNombreCategoria.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Descripción:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Nombre:";
            // 
            // btnRegistrarCategoria
            // 
            this.btnRegistrarCategoria.BackColor = System.Drawing.Color.SeaGreen;
            this.btnRegistrarCategoria.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.btnRegistrarCategoria.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.btnRegistrarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnRegistrarCategoria.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarCategoria.Location = new System.Drawing.Point(103, 172);
            this.btnRegistrarCategoria.Name = "btnRegistrarCategoria";
            this.btnRegistrarCategoria.Size = new System.Drawing.Size(106, 33);
            this.btnRegistrarCategoria.TabIndex = 13;
            this.btnRegistrarCategoria.Text = "REGISTRAR ";
            this.btnRegistrarCategoria.UseVisualStyleBackColor = false;
            this.btnRegistrarCategoria.Click += new System.EventHandler(this.btnRegistrarCategoria_Click);
            // 
            // btnEliminarCategoria
            // 
            this.btnEliminarCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(51)))));
            this.btnEliminarCategoria.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(51)))));
            this.btnEliminarCategoria.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(51)))));
            this.btnEliminarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnEliminarCategoria.ForeColor = System.Drawing.Color.White;
            this.btnEliminarCategoria.Location = new System.Drawing.Point(304, 172);
            this.btnEliminarCategoria.Name = "btnEliminarCategoria";
            this.btnEliminarCategoria.Size = new System.Drawing.Size(106, 33);
            this.btnEliminarCategoria.TabIndex = 14;
            this.btnEliminarCategoria.Text = "ELIMINAR";
            this.btnEliminarCategoria.UseVisualStyleBackColor = false;
            // 
            // cmbCategoriaTaller
            // 
            this.cmbCategoriaTaller.FormattingEnabled = true;
            this.cmbCategoriaTaller.Items.AddRange(new object[] {
            "DEPORTIVAS",
            "CULTURALES",
            "RECREATIVAS"});
            this.cmbCategoriaTaller.Location = new System.Drawing.Point(94, 130);
            this.cmbCategoriaTaller.Name = "cmbCategoriaTaller";
            this.cmbCategoriaTaller.Size = new System.Drawing.Size(307, 21);
            this.cmbCategoriaTaller.TabIndex = 12;
            this.cmbCategoriaTaller.Text = "-- Seleccione --";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Categoria:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Moccasin;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.txtIdCurso);
            this.panel4.Controls.Add(this.btnEliminarCurso);
            this.panel4.Controls.Add(this.btnRegistrarCurso);
            this.panel4.Controls.Add(this.cmbCategoriaTaller);
            this.panel4.Controls.Add(this.txtHorario);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.txtInstructorTaller);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.txtNombreTaller);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(11, 65);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(542, 280);
            this.panel4.TabIndex = 48;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // txtIdCurso
            // 
            this.txtIdCurso.Location = new System.Drawing.Point(203, 6);
            this.txtIdCurso.Name = "txtIdCurso";
            this.txtIdCurso.Size = new System.Drawing.Size(55, 20);
            this.txtIdCurso.TabIndex = 53;
            this.txtIdCurso.Text = "0";
            this.txtIdCurso.Visible = false;
            // 
            // btnEliminarCurso
            // 
            this.btnEliminarCurso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(51)))));
            this.btnEliminarCurso.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(51)))));
            this.btnEliminarCurso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarCurso.ForeColor = System.Drawing.Color.White;
            this.btnEliminarCurso.Location = new System.Drawing.Point(295, 227);
            this.btnEliminarCurso.Name = "btnEliminarCurso";
            this.btnEliminarCurso.Size = new System.Drawing.Size(106, 33);
            this.btnEliminarCurso.TabIndex = 52;
            this.btnEliminarCurso.Text = "ELIMINAR";
            this.btnEliminarCurso.UseVisualStyleBackColor = false;
            // 
            // btnRegistrarCurso
            // 
            this.btnRegistrarCurso.BackColor = System.Drawing.Color.SeaGreen;
            this.btnRegistrarCurso.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.btnRegistrarCurso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarCurso.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarCurso.Location = new System.Drawing.Point(94, 227);
            this.btnRegistrarCurso.Name = "btnRegistrarCurso";
            this.btnRegistrarCurso.Size = new System.Drawing.Size(106, 33);
            this.btnRegistrarCurso.TabIndex = 51;
            this.btnRegistrarCurso.Text = "REGISTRAR ";
            this.btnRegistrarCurso.UseVisualStyleBackColor = false;
            this.btnRegistrarCurso.Click += new System.EventHandler(this.btnRegistrarCurso_Click);
            // 
            // txtHorario
            // 
            this.txtHorario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHorario.Location = new System.Drawing.Point(94, 170);
            this.txtHorario.Multiline = true;
            this.txtHorario.Name = "txtHorario";
            this.txtHorario.Size = new System.Drawing.Size(307, 38);
            this.txtHorario.TabIndex = 49;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 17);
            this.label7.TabIndex = 50;
            this.label7.Text = "Horario:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label11.Location = new System.Drawing.Point(14, 4);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(182, 23);
            this.label11.TabIndex = 42;
            this.label11.Text = "DATOS DEL CURSO ";
            // 
            // txtInstructorTaller
            // 
            this.txtInstructorTaller.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInstructorTaller.Location = new System.Drawing.Point(94, 85);
            this.txtInstructorTaller.Multiline = true;
            this.txtInstructorTaller.Name = "txtInstructorTaller";
            this.txtInstructorTaller.Size = new System.Drawing.Size(307, 26);
            this.txtInstructorTaller.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // txtNombreTaller
            // 
            this.txtNombreTaller.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombreTaller.Location = new System.Drawing.Point(94, 37);
            this.txtNombreTaller.Multiline = true;
            this.txtNombreTaller.Name = "txtNombreTaller";
            this.txtNombreTaller.Size = new System.Drawing.Size(307, 26);
            this.txtNombreTaller.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Instructor:";
            // 
            // dgvCategorias
            // 
            this.dgvCategorias.AllowUserToAddRows = false;
            this.dgvCategorias.AllowUserToDeleteRows = false;
            this.dgvCategorias.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.dgvCategorias.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategorias.Location = new System.Drawing.Point(568, 373);
            this.dgvCategorias.Name = "dgvCategorias";
            this.dgvCategorias.ReadOnly = true;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dgvCategorias.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCategorias.Size = new System.Drawing.Size(566, 216);
            this.dgvCategorias.TabIndex = 49;
            this.dgvCategorias.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvCategorias_MouseDoubleClick);
            // 
            // FrmTaller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1151, 700);
            this.Controls.Add(this.dgvCategorias);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dgvTaller);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmTaller";
            this.Text = "FrmTaller";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaller)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dgvTaller;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnRecreativas;
        private System.Windows.Forms.Button btnCulturales;
        private System.Windows.Forms.Button btnDeportivas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbCategoriaTaller;
        private System.Windows.Forms.Button btnRegistrarCategoria;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEliminarCategoria;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtHorario;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtInstructorTaller;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombreTaller;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtNombreCategoria;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEliminarCurso;
        private System.Windows.Forms.Button btnRegistrarCurso;
        private System.Windows.Forms.TextBox txtIdCurso;
        private System.Windows.Forms.TextBox txtIdCategoria;
        private System.Windows.Forms.DataGridView dgvCategorias;
    }
}