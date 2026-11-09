namespace Bicigestion2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            cmbTipoBicicleta = new ComboBox();
            label3 = new Label();
            txtDni = new TextBox();
            txtImporte = new TextBox();
            label4 = new Label();
            label5 = new Label();
            dtpFechaAlquiler = new DateTimePicker();
            btnConfirmarCambios = new Button();
            button2 = new Button();
            dgvPendientes = new DataGridView();
            label6 = new Label();
            dgvAlquileres = new DataGridView();
            label7 = new Label();
            btnListar = new Button();
            label8 = new Label();
            txtNuevoImporte = new TextBox();
            label9 = new Label();
            txtIdModificar = new TextBox();
            label10 = new Label();
            btnModificar = new Button();
            dtpNuevaFecha = new DateTimePicker();
            label11 = new Label();
            txtIdEliminar = new TextBox();
            label12 = new Label();
            label13 = new Label();
            btnEliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPendientes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvAlquileres).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 33);
            label1.Name = "label1";
            label1.Size = new Size(128, 20);
            label1.TabIndex = 0;
            label1.Text = "NUEVO ALQUILER";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 71);
            label2.Name = "label2";
            label2.Size = new Size(102, 20);
            label2.TabIndex = 1;
            label2.Text = "Tipo bicicleta:";
            // 
            // cmbTipoBicicleta
            // 
            cmbTipoBicicleta.FormattingEnabled = true;
            cmbTipoBicicleta.Location = new Point(29, 94);
            cmbTipoBicicleta.Name = "cmbTipoBicicleta";
            cmbTipoBicicleta.Size = new Size(151, 28);
            cmbTipoBicicleta.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 125);
            label3.Name = "label3";
            label3.Size = new Size(86, 20);
            label3.TabIndex = 3;
            label3.Text = "DNI cliente:";
            // 
            // txtDni
            // 
            txtDni.Location = new Point(29, 148);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(125, 27);
            txtDni.TabIndex = 4;
            // 
            // txtImporte
            // 
            txtImporte.Location = new Point(29, 203);
            txtImporte.Name = "txtImporte";
            txtImporte.Size = new Size(125, 27);
            txtImporte.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 180);
            label4.Name = "label4";
            label4.Size = new Size(65, 20);
            label4.TabIndex = 5;
            label4.Text = "Importe:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(29, 233);
            label5.Name = "label5";
            label5.Size = new Size(104, 20);
            label5.TabIndex = 7;
            label5.Text = "Fecha alquiler:";
            // 
            // dtpFechaAlquiler
            // 
            dtpFechaAlquiler.Location = new Point(29, 256);
            dtpFechaAlquiler.Name = "dtpFechaAlquiler";
            dtpFechaAlquiler.Size = new Size(250, 27);
            dtpFechaAlquiler.TabIndex = 8;
            // 
            // btnConfirmarCambios
            // 
            btnConfirmarCambios.Location = new Point(29, 354);
            btnConfirmarCambios.Name = "btnConfirmarCambios";
            btnConfirmarCambios.Size = new Size(151, 61);
            btnConfirmarCambios.TabIndex = 9;
            btnConfirmarCambios.Text = "CONFIRMAR CAMBIOS";
            btnConfirmarCambios.UseVisualStyleBackColor = true;
            btnConfirmarCambios.Click += btnConfirmarCambios_Click;
            // 
            // button2
            // 
            button2.Location = new Point(29, 287);
            button2.Name = "button2";
            button2.Size = new Size(151, 61);
            button2.TabIndex = 10;
            button2.Text = "AGREGAR ALQUILER";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // dgvPendientes
            // 
            dgvPendientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPendientes.Location = new Point(385, 39);
            dgvPendientes.Name = "dgvPendientes";
            dgvPendientes.RowHeadersWidth = 51;
            dgvPendientes.Size = new Size(524, 188);
            dgvPendientes.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(385, 16);
            label6.Name = "label6";
            label6.Size = new Size(94, 20);
            label6.TabIndex = 12;
            label6.Text = "PENDIENTES";
            // 
            // dgvAlquileres
            // 
            dgvAlquileres.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAlquileres.Location = new Point(385, 287);
            dgvAlquileres.Name = "dgvAlquileres";
            dgvAlquileres.RowHeadersWidth = 51;
            dgvAlquileres.Size = new Size(524, 188);
            dgvAlquileres.TabIndex = 13;
            dgvAlquileres.CellClick += dgvAlquileres_CellClick;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(385, 264);
            label7.Name = "label7";
            label7.Size = new Size(91, 20);
            label7.TabIndex = 14;
            label7.Text = "ALQUILERES";
            // 
            // btnListar
            // 
            btnListar.Location = new Point(729, 481);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(180, 33);
            btnListar.TabIndex = 15;
            btnListar.Text = "LISTAR";
            btnListar.UseVisualStyleBackColor = true;
            btnListar.Click += btnListar_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(29, 437);
            label8.Name = "label8";
            label8.Size = new Size(87, 20);
            label8.TabIndex = 16;
            label8.Text = "MODIFICAR";
            // 
            // txtNuevoImporte
            // 
            txtNuevoImporte.Location = new Point(30, 535);
            txtNuevoImporte.Name = "txtNuevoImporte";
            txtNuevoImporte.Size = new Size(125, 27);
            txtNuevoImporte.TabIndex = 20;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(30, 512);
            label9.Name = "label9";
            label9.Size = new Size(112, 20);
            label9.TabIndex = 19;
            label9.Text = "Nuevo importe:";
            // 
            // txtIdModificar
            // 
            txtIdModificar.Location = new Point(30, 480);
            txtIdModificar.Name = "txtIdModificar";
            txtIdModificar.Size = new Size(125, 27);
            txtIdModificar.TabIndex = 18;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(30, 457);
            label10.Name = "label10";
            label10.Size = new Size(25, 20);
            label10.TabIndex = 17;
            label10.Text = "Id:";
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(30, 621);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(151, 61);
            btnModificar.TabIndex = 23;
            btnModificar.Text = "MODIFICAR ALQUILER";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // dtpNuevaFecha
            // 
            dtpNuevaFecha.Location = new Point(30, 588);
            dtpNuevaFecha.Name = "dtpNuevaFecha";
            dtpNuevaFecha.Size = new Size(250, 27);
            dtpNuevaFecha.TabIndex = 22;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(29, 565);
            label11.Name = "label11";
            label11.Size = new Size(94, 20);
            label11.TabIndex = 21;
            label11.Text = "Nueva fecha:";
            // 
            // txtIdEliminar
            // 
            txtIdEliminar.Location = new Point(393, 631);
            txtIdEliminar.Name = "txtIdEliminar";
            txtIdEliminar.Size = new Size(125, 27);
            txtIdEliminar.TabIndex = 26;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(393, 608);
            label12.Name = "label12";
            label12.Size = new Size(25, 20);
            label12.TabIndex = 25;
            label12.Text = "Id:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(392, 588);
            label13.Name = "label13";
            label13.Size = new Size(78, 20);
            label13.TabIndex = 24;
            label13.Text = "ELIMINAR:";
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(392, 664);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(151, 61);
            btnEliminar.TabIndex = 27;
            btnEliminar.Text = "ELIMINAR ALQUILER";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1242, 753);
            Controls.Add(btnEliminar);
            Controls.Add(txtIdEliminar);
            Controls.Add(label12);
            Controls.Add(label13);
            Controls.Add(btnModificar);
            Controls.Add(dtpNuevaFecha);
            Controls.Add(label11);
            Controls.Add(txtNuevoImporte);
            Controls.Add(label9);
            Controls.Add(txtIdModificar);
            Controls.Add(label10);
            Controls.Add(label8);
            Controls.Add(btnListar);
            Controls.Add(label7);
            Controls.Add(dgvAlquileres);
            Controls.Add(label6);
            Controls.Add(dgvPendientes);
            Controls.Add(button2);
            Controls.Add(btnConfirmarCambios);
            Controls.Add(dtpFechaAlquiler);
            Controls.Add(label5);
            Controls.Add(txtImporte);
            Controls.Add(label4);
            Controls.Add(txtDni);
            Controls.Add(label3);
            Controls.Add(cmbTipoBicicleta);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPendientes).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvAlquileres).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox cmbTipoBicicleta;
        private Label label3;
        private TextBox txtDni;
        private TextBox txtImporte;
        private Label label4;
        private Label label5;
        private DateTimePicker dtpFechaAlquiler;
        private Button btnConfirmarCambios;
        private Button button2;
        private DataGridView dgvPendientes;
        private Label label6;
        private DataGridView dgvAlquileres;
        private Label label7;
        private Button btnListar;
        private Label label8;
        private TextBox txtNuevoImporte;
        private Label label9;
        private TextBox txtIdModificar;
        private Label label10;
        private Button btnModificar;
        private DateTimePicker dtpNuevaFecha;
        private Label label11;
        private TextBox txtIdEliminar;
        private Label label12;
        private Label label13;
        private Button btnEliminar;
    }
}
