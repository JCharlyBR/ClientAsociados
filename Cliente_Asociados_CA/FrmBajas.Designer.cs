namespace Cliente_Asociados_CA
{
    partial class FrmBajas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBajas));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnBuscarNombreBen = new System.Windows.Forms.Button();
            this.txtBuscarBeneficiario = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvFallecimientos = new System.Windows.Forms.DataGridView();
            this.transparentControl1 = new TransControl_src.TransparentControl();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFallecimientos)).BeginInit();
            this.transparentControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.label13);
            this.panel2.Location = new System.Drawing.Point(-3, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1154, 38);
            this.panel2.TabIndex = 30;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(431, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(179, 21);
            this.label13.TabIndex = 0;
            this.label13.Text = "Fallecimientos y Bajas ";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnBuscarNombreBen);
            this.panel3.Controls.Add(this.txtBuscarBeneficiario);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(12, 293);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1123, 80);
            this.panel3.TabIndex = 46;
            // 
            // btnBuscarNombreBen
            // 
            this.btnBuscarNombreBen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnBuscarNombreBen.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnBuscarNombreBen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarNombreBen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarNombreBen.ForeColor = System.Drawing.Color.White;
            this.btnBuscarNombreBen.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarNombreBen.Image")));
            this.btnBuscarNombreBen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarNombreBen.Location = new System.Drawing.Point(969, 20);
            this.btnBuscarNombreBen.Name = "btnBuscarNombreBen";
            this.btnBuscarNombreBen.Size = new System.Drawing.Size(129, 37);
            this.btnBuscarNombreBen.TabIndex = 7;
            this.btnBuscarNombreBen.Text = "No: Socio";
            this.btnBuscarNombreBen.UseVisualStyleBackColor = false;
            // 
            // txtBuscarBeneficiario
            // 
            this.txtBuscarBeneficiario.Location = new System.Drawing.Point(780, 20);
            this.txtBuscarBeneficiario.Multiline = true;
            this.txtBuscarBeneficiario.Name = "txtBuscarBeneficiario";
            this.txtBuscarBeneficiario.Size = new System.Drawing.Size(174, 37);
            this.txtBuscarBeneficiario.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(3, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(235, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "Consultar Fallecimientos";
            // 
            // dgvFallecimientos
            // 
            this.dgvFallecimientos.AllowUserToAddRows = false;
            this.dgvFallecimientos.AllowUserToDeleteRows = false;
            this.dgvFallecimientos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.dgvFallecimientos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvFallecimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFallecimientos.Location = new System.Drawing.Point(12, 393);
            this.dgvFallecimientos.Name = "dgvFallecimientos";
            this.dgvFallecimientos.ReadOnly = true;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dgvFallecimientos.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvFallecimientos.Size = new System.Drawing.Size(1127, 297);
            this.dgvFallecimientos.TabIndex = 47;
            // 
            // transparentControl1
            // 
            this.transparentControl1.Controls.Add(this.button1);
            this.transparentControl1.Controls.Add(this.dateTimePicker1);
            this.transparentControl1.Controls.Add(this.textBox2);
            this.transparentControl1.Controls.Add(this.textBox1);
            this.transparentControl1.Controls.Add(this.label4);
            this.transparentControl1.Controls.Add(this.label3);
            this.transparentControl1.Controls.Add(this.label2);
            this.transparentControl1.Controls.Add(this.label1);
            this.transparentControl1.Location = new System.Drawing.Point(12, 55);
            this.transparentControl1.MinimumSize = new System.Drawing.Size(100, 75);
            this.transparentControl1.Name = "transparentControl1";
            this.transparentControl1.Opacity = 0.7D;
            this.transparentControl1.Size = new System.Drawing.Size(1123, 221);
            this.transparentControl1.TabIndex = 48;
            this.transparentControl1.Text = "transparentControl1";
            this.transparentControl1.Transparent = true;
            this.transparentControl1.TransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(201)))), ((int)(((byte)(202)))));
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Navy;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(422, 131);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 35);
            this.button1.TabIndex = 15;
            this.button1.Text = "     REPORTAR";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(422, 76);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(194, 20);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(104, 135);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(194, 31);
            this.textBox2.TabIndex = 13;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(104, 70);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(194, 31);
            this.textBox1.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(28, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "Causa:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(347, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "Fecha:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(28, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "No: Socio:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(24, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "Reportar Fallecimiento ";
            // 
            // FrmBajas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(109)))), ((int)(((byte)(126)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1151, 700);
            this.Controls.Add(this.transparentControl1);
            this.Controls.Add(this.dgvFallecimientos);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmBajas";
            this.Text = "FrmBajas";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFallecimientos)).EndInit();
            this.transparentControl1.ResumeLayout(false);
            this.transparentControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvFallecimientos;
        private System.Windows.Forms.Button btnBuscarNombreBen;
        private System.Windows.Forms.TextBox txtBuscarBeneficiario;
        private TransControl_src.TransparentControl transparentControl1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}