namespace MdiContainer
{
    partial class csDivisa
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
            cmbDe = new ComboBox();
            cmbA = new ComboBox();
            txtCantidad = new TextBox();
            lblResultado = new Label();
            btnConvertir = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // cmbDe
            // 
            cmbDe.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbDe.FormattingEnabled = true;
            cmbDe.Location = new Point(135, 250);
            cmbDe.Name = "cmbDe";
            cmbDe.Size = new Size(182, 33);
            cmbDe.TabIndex = 0;
            // 
            // cmbA
            // 
            cmbA.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbA.FormattingEnabled = true;
            cmbA.Location = new Point(135, 172);
            cmbA.Name = "cmbA";
            cmbA.Size = new Size(182, 33);
            cmbA.TabIndex = 1;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(123, 100);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(221, 31);
            txtCantidad.TabIndex = 2;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResultado.ForeColor = Color.Maroon;
            lblResultado.Location = new Point(162, 344);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(111, 28);
            lblResultado.TabIndex = 3;
            lblResultado.Text = "Resultado";
            // 
            // btnConvertir
            // 
            btnConvertir.BackColor = Color.RosyBrown;
            btnConvertir.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConvertir.Location = new Point(384, 189);
            btnConvertir.Name = "btnConvertir";
            btnConvertir.Size = new Size(145, 55);
            btnConvertir.TabIndex = 4;
            btnConvertir.Text = "Convertir";
            btnConvertir.UseVisualStyleBackColor = false;
            btnConvertir.Click += btnConvertir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DimGray;
            label1.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Maroon;
            label1.Location = new Point(57, 31);
            label1.Name = "label1";
            label1.Size = new Size(378, 32);
            label1.TabIndex = 5;
            label1.Text = "Ingrese la cantidad a convertir";
            // 
            // csDivisa
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnConvertir);
            Controls.Add(lblResultado);
            Controls.Add(txtCantidad);
            Controls.Add(cmbA);
            Controls.Add(cmbDe);
            Name = "csDivisa";
            Text = "Divisa";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbDe;
        private ComboBox cmbA;
        private TextBox txtCantidad;
        private Label lblResultado;
        private Button btnConvertir;
        private Label label1;
    }
}