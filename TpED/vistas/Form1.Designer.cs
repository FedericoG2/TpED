namespace TpED
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.checkCliente = new System.Windows.Forms.CheckBox();
            this.txtIngreso = new System.Windows.Forms.TextBox();
            this.btnPersonal = new System.Windows.Forms.RadioButton();
            this.btnCaja = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtCaja = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dataGridCaja = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.atenderCaja = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.dataGridPersonal = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPersonal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.atenderPersonal = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCaja)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPersonal)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Controls.Add(this.txtDNI);
            this.groupBox1.Location = new System.Drawing.Point(12, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(219, 77);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "INGRESO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "DNI";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(138, 27);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 32);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "button1";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(6, 43);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(100, 20);
            this.txtDNI.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(12, 169);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(219, 279);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(213, 262);
            this.dataGridView1.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSiguiente);
            this.groupBox3.Location = new System.Drawing.Point(237, 73);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(168, 77);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "MESA DE INFORMES";
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Location = new System.Drawing.Point(17, 22);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(122, 32);
            this.btnSiguiente.TabIndex = 2;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.checkCliente);
            this.groupBox4.Controls.Add(this.txtIngreso);
            this.groupBox4.Controls.Add(this.btnPersonal);
            this.groupBox4.Controls.Add(this.btnCaja);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.btnAceptar);
            this.groupBox4.Location = new System.Drawing.Point(423, 73);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(383, 124);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "INGRESO";
            // 
            // checkCliente
            // 
            this.checkCliente.AutoSize = true;
            this.checkCliente.Location = new System.Drawing.Point(9, 96);
            this.checkCliente.Name = "checkCliente";
            this.checkCliente.Size = new System.Drawing.Size(73, 17);
            this.checkCliente.TabIndex = 8;
            this.checkCliente.Text = "Es Cliente";
            this.checkCliente.UseVisualStyleBackColor = true;
            // 
            // txtIngreso
            // 
            this.txtIngreso.Location = new System.Drawing.Point(38, 19);
            this.txtIngreso.Name = "txtIngreso";
            this.txtIngreso.Size = new System.Drawing.Size(100, 20);
            this.txtIngreso.TabIndex = 7;
            // 
            // btnPersonal
            // 
            this.btnPersonal.AutoSize = true;
            this.btnPersonal.Location = new System.Drawing.Point(111, 64);
            this.btnPersonal.Name = "btnPersonal";
            this.btnPersonal.Size = new System.Drawing.Size(111, 17);
            this.btnPersonal.TabIndex = 5;
            this.btnPersonal.TabStop = true;
            this.btnPersonal.Text = "Atencion Personal";
            this.btnPersonal.UseVisualStyleBackColor = true;
            // 
            // btnCaja
            // 
            this.btnCaja.AutoSize = true;
            this.btnCaja.Location = new System.Drawing.Point(54, 62);
            this.btnCaja.Name = "btnCaja";
            this.btnCaja.Size = new System.Drawing.Size(51, 17);
            this.btnCaja.TabIndex = 4;
            this.btnCaja.TabStop = true;
            this.btnCaja.Text = "Cajas";
            this.btnCaja.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tramite";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "DNI";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(279, 27);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(84, 38);
            this.btnAceptar.TabIndex = 2;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtCaja
            // 
            this.txtCaja.Location = new System.Drawing.Point(366, 217);
            this.txtCaja.Name = "txtCaja";
            this.txtCaja.Size = new System.Drawing.Size(100, 20);
            this.txtCaja.TabIndex = 1;
            this.txtCaja.TextChanged += new System.EventHandler(this.txtDNI2_TextChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dataGridCaja);
            this.groupBox5.Location = new System.Drawing.Point(290, 251);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(304, 196);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "CAJAS";
            // 
            // dataGridCaja
            // 
            this.dataGridCaja.AllowUserToAddRows = false;
            this.dataGridCaja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCaja.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridCaja.Location = new System.Drawing.Point(6, 42);
            this.dataGridCaja.Name = "dataGridCaja";
            this.dataGridCaja.Size = new System.Drawing.Size(301, 145);
            this.dataGridCaja.TabIndex = 5;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Orden";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Dni";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Cliente";
            this.Column3.Name = "Column3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(287, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Atendiendo a:";
            // 
            // atenderCaja
            // 
            this.atenderCaja.Location = new System.Drawing.Point(521, 234);
            this.atenderCaja.Name = "atenderCaja";
            this.atenderCaja.Size = new System.Drawing.Size(70, 20);
            this.atenderCaja.TabIndex = 4;
            this.atenderCaja.Text = "Atender";
            this.atenderCaja.UseVisualStyleBackColor = true;
            this.atenderCaja.Click += new System.EventHandler(this.atenderCaja_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.dataGridPersonal);
            this.groupBox6.Location = new System.Drawing.Point(618, 251);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(316, 197);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "ATENCION PERSONAL";
            // 
            // dataGridPersonal
            // 
            this.dataGridPersonal.AllowUserToAddRows = false;
            this.dataGridPersonal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPersonal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dataGridPersonal.Location = new System.Drawing.Point(6, 42);
            this.dataGridPersonal.Name = "dataGridPersonal";
            this.dataGridPersonal.Size = new System.Drawing.Size(301, 154);
            this.dataGridPersonal.TabIndex = 5;
            this.dataGridPersonal.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Orden";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Dni";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Cliente";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // txtPersonal
            // 
            this.txtPersonal.Location = new System.Drawing.Point(706, 213);
            this.txtPersonal.Name = "txtPersonal";
            this.txtPersonal.Size = new System.Drawing.Size(100, 20);
            this.txtPersonal.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(627, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Atendiendo a:";
            // 
            // atenderPersonal
            // 
            this.atenderPersonal.Location = new System.Drawing.Point(864, 234);
            this.atenderPersonal.Name = "atenderPersonal";
            this.atenderPersonal.Size = new System.Drawing.Size(70, 20);
            this.atenderPersonal.TabIndex = 21;
            this.atenderPersonal.Text = "Atender";
            this.atenderPersonal.UseVisualStyleBackColor = true;
            this.atenderPersonal.Click += new System.EventHandler(this.atenderPersonal_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 501);
            this.Controls.Add(this.txtPersonal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.atenderPersonal);
            this.Controls.Add(this.txtCaja);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.atenderCaja);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestor de Turnos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCaja)).EndInit();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPersonal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox txtCaja;
        private System.Windows.Forms.RadioButton btnPersonal;
        private System.Windows.Forms.RadioButton btnCaja;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIngreso;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dataGridCaja;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button atenderCaja;
        private System.Windows.Forms.CheckBox checkCliente;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.DataGridView dataGridPersonal;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.TextBox txtPersonal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button atenderPersonal;
    }
}

