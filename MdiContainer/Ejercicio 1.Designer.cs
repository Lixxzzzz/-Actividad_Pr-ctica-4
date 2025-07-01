namespace MdiContainer
{
    partial class rgtPersonas
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
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtCedula = new TextBox();
            txtTelefono = new TextBox();
            txtCorreo = new TextBox();
            txtDireccion = new TextBox();
            txtCiudad = new TextBox();
            txtpais = new TextBox();
            txtOcupacion = new TextBox();
            dtpFechaNacimiento = new DateTimePicker();
            cbGenero = new ComboBox();
            dataGridView1 = new DataGridView();
            Nombre = new DataGridViewTextBoxColumn();
            Apellido = new DataGridViewTextBoxColumn();
            Cedula = new DataGridViewTextBoxColumn();
            Fecha = new DataGridViewTextBoxColumn();
            Telefono = new DataGridViewTextBoxColumn();
            Correo = new DataGridViewTextBoxColumn();
            Direccion = new DataGridViewTextBoxColumn();
            Ciudad = new DataGridViewTextBoxColumn();
            Pais = new DataGridViewTextBoxColumn();
            Genero = new DataGridViewTextBoxColumn();
            EstadoCivil = new DataGridViewTextBoxColumn();
            Ocupacion = new DataGridViewTextBoxColumn();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            cbEstadoCivil = new ComboBox();
            button1 = new Button();
            btnEliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(110, 32);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(285, 31);
            txtNombre.TabIndex = 0;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(110, 85);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(288, 31);
            txtApellido.TabIndex = 1;
            // 
            // txtCedula
            // 
            txtCedula.Location = new Point(483, 32);
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(224, 31);
            txtCedula.TabIndex = 2;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(110, 197);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(288, 31);
            txtTelefono.TabIndex = 3;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(110, 139);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(288, 31);
            txtCorreo.TabIndex = 4;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(590, 96);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(225, 31);
            txtDireccion.TabIndex = 5;
            // 
            // txtCiudad
            // 
            txtCiudad.Location = new Point(590, 139);
            txtCiudad.Name = "txtCiudad";
            txtCiudad.Size = new Size(225, 31);
            txtCiudad.TabIndex = 6;
            // 
            // txtpais
            // 
            txtpais.Location = new Point(590, 190);
            txtpais.Name = "txtpais";
            txtpais.Size = new Size(225, 31);
            txtpais.TabIndex = 7;
            // 
            // txtOcupacion
            // 
            txtOcupacion.Location = new Point(966, 96);
            txtOcupacion.Name = "txtOcupacion";
            txtOcupacion.Size = new Size(182, 31);
            txtOcupacion.TabIndex = 8;
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Location = new Point(916, 32);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(300, 31);
            dtpFechaNacimiento.TabIndex = 12;
            // 
            // cbGenero
            // 
            cbGenero.FormattingEnabled = true;
            cbGenero.Items.AddRange(new object[] { "F", "M" });
            cbGenero.Location = new Point(966, 191);
            cbGenero.Name = "cbGenero";
            cbGenero.Size = new Size(182, 33);
            cbGenero.TabIndex = 13;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.BackgroundColor = Color.FromArgb(255, 224, 192);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Nombre, Apellido, Cedula, Fecha, Telefono, Correo, Direccion, Ciudad, Pais, Genero, EstadoCivil, Ocupacion });
            dataGridView1.Location = new Point(12, 330);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1880, 321);
            dataGridView1.TabIndex = 14;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 8;
            Nombre.Name = "Nombre";
            Nombre.Width = 150;
            // 
            // Apellido
            // 
            Apellido.HeaderText = "Apellido";
            Apellido.MinimumWidth = 8;
            Apellido.Name = "Apellido";
            Apellido.Width = 150;
            // 
            // Cedula
            // 
            Cedula.HeaderText = "Cedula";
            Cedula.MinimumWidth = 8;
            Cedula.Name = "Cedula";
            Cedula.Width = 150;
            // 
            // Fecha
            // 
            Fecha.HeaderText = "Fecha";
            Fecha.MinimumWidth = 8;
            Fecha.Name = "Fecha";
            Fecha.Width = 150;
            // 
            // Telefono
            // 
            Telefono.HeaderText = "Telefono";
            Telefono.MinimumWidth = 8;
            Telefono.Name = "Telefono";
            Telefono.Width = 150;
            // 
            // Correo
            // 
            Correo.HeaderText = "Correo";
            Correo.MinimumWidth = 8;
            Correo.Name = "Correo";
            Correo.Width = 150;
            // 
            // Direccion
            // 
            Direccion.HeaderText = "Direccion";
            Direccion.MinimumWidth = 8;
            Direccion.Name = "Direccion";
            Direccion.Width = 150;
            // 
            // Ciudad
            // 
            Ciudad.HeaderText = "Ciudad";
            Ciudad.MinimumWidth = 8;
            Ciudad.Name = "Ciudad";
            Ciudad.Width = 150;
            // 
            // Pais
            // 
            Pais.HeaderText = "Pais";
            Pais.MinimumWidth = 8;
            Pais.Name = "Pais";
            Pais.Width = 150;
            // 
            // Genero
            // 
            Genero.HeaderText = "Genero";
            Genero.MinimumWidth = 8;
            Genero.Name = "Genero";
            Genero.Resizable = DataGridViewTriState.True;
            Genero.SortMode = DataGridViewColumnSortMode.NotSortable;
            Genero.Width = 150;
            // 
            // EstadoCivil
            // 
            EstadoCivil.HeaderText = "EstadoCivil";
            EstadoCivil.MinimumWidth = 8;
            EstadoCivil.Name = "EstadoCivil";
            EstadoCivil.Resizable = DataGridViewTriState.True;
            EstadoCivil.SortMode = DataGridViewColumnSortMode.NotSortable;
            EstadoCivil.Width = 150;
            // 
            // Ocupacion
            // 
            Ocupacion.HeaderText = "Ocupacion";
            Ocupacion.MinimumWidth = 8;
            Ocupacion.Name = "Ocupacion";
            Ocupacion.Width = 150;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(26, 32);
            label1.Name = "label1";
            label1.Size = new Size(81, 25);
            label1.TabIndex = 15;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(26, 85);
            label2.Name = "label2";
            label2.Size = new Size(83, 25);
            label2.TabIndex = 16;
            label2.Text = "Apellido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(402, 35);
            label3.Name = "label3";
            label3.Size = new Size(70, 25);
            label3.TabIndex = 17;
            label3.Text = "Cedula";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(720, 35);
            label4.Name = "label4";
            label4.Size = new Size(190, 25);
            label4.TabIndex = 18;
            label4.Text = "Fecha de Nacimiento";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(25, 203);
            label5.Name = "label5";
            label5.Size = new Size(86, 25);
            label5.TabIndex = 19;
            label5.Text = "Teléfono";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(25, 139);
            label6.Name = "label6";
            label6.Size = new Size(69, 25);
            label6.TabIndex = 20;
            label6.Text = "Correo";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(483, 102);
            label7.Name = "label7";
            label7.Size = new Size(92, 25);
            label7.TabIndex = 21;
            label7.Text = "Dirección";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(504, 148);
            label8.Name = "label8";
            label8.Size = new Size(71, 25);
            label8.TabIndex = 22;
            label8.Text = "Ciudad";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(529, 190);
            label9.Name = "label9";
            label9.Size = new Size(46, 25);
            label9.TabIndex = 23;
            label9.Text = "País";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(867, 191);
            label10.Name = "label10";
            label10.Size = new Size(74, 25);
            label10.TabIndex = 24;
            label10.Text = "Género";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(851, 99);
            label11.Name = "label11";
            label11.Size = new Size(103, 25);
            label11.TabIndex = 25;
            label11.Text = "Ocupación";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(844, 148);
            label12.Name = "label12";
            label12.Size = new Size(110, 25);
            label12.TabIndex = 26;
            label12.Text = "Estado Civil";
            // 
            // cbEstadoCivil
            // 
            cbEstadoCivil.FormattingEnabled = true;
            cbEstadoCivil.Items.AddRange(new object[] { "Soltero/a", " Casado/a", " Divorciado/a", " Viudo/a", " Unión libre" });
            cbEstadoCivil.Location = new Point(966, 145);
            cbEstadoCivil.Name = "cbEstadoCivil";
            cbEstadoCivil.Size = new Size(182, 33);
            cbEstadoCivil.TabIndex = 27;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 192, 192);
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(1442, 48);
            button1.Name = "button1";
            button1.Size = new Size(211, 73);
            button1.TabIndex = 28;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Red;
            btnEliminar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.Location = new Point(1442, 166);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(211, 76);
            btnEliminar.TabIndex = 29;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // rgtPersonas
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1924, 663);
            Controls.Add(btnEliminar);
            Controls.Add(button1);
            Controls.Add(cbEstadoCivil);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(cbGenero);
            Controls.Add(dtpFechaNacimiento);
            Controls.Add(txtOcupacion);
            Controls.Add(txtpais);
            Controls.Add(txtCiudad);
            Controls.Add(txtDireccion);
            Controls.Add(txtCorreo);
            Controls.Add(txtTelefono);
            Controls.Add(txtCedula);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Name = "rgtPersonas";
            Text = "Registro de personas";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtCedula;
        private TextBox txtTelefono;
        private TextBox txtCorreo;
        private TextBox txtDireccion;
        private TextBox txtCiudad;
        private TextBox txtpais;
        private TextBox txtOcupacion;
        private DateTimePicker dtpFechaNacimiento;
        private ComboBox cbGenero;
        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private ComboBox cbEstadoCivil;
        private Button button1;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Apellido;
        private DataGridViewTextBoxColumn Cedula;
        private DataGridViewTextBoxColumn Fecha;
        private DataGridViewTextBoxColumn Telefono;
        private DataGridViewTextBoxColumn Correo;
        private DataGridViewTextBoxColumn Direccion;
        private DataGridViewTextBoxColumn Ciudad;
        private DataGridViewTextBoxColumn Pais;
        private DataGridViewTextBoxColumn Genero;
        private DataGridViewTextBoxColumn EstadoCivil;
        private DataGridViewTextBoxColumn Ocupacion;
        private Button btnEliminar;
    }
}