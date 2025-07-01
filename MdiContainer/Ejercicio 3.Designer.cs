namespace MdiContainer
{
    partial class Impuesto
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
            txtMonto = new TextBox();
            cmbImpuesto = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(218, 49);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(150, 31);
            txtMonto.TabIndex = 0;
            txtMonto.TextChanged += txtMonto_TextChanged;
            // 
            // cmbImpuesto
            // 
            cmbImpuesto.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbImpuesto.FormattingEnabled = true;
            cmbImpuesto.Location = new Point(218, 108);
            cmbImpuesto.Name = "cmbImpuesto";
            cmbImpuesto.Size = new Size(182, 33);
            cmbImpuesto.TabIndex = 1;
            cmbImpuesto.SelectedIndexChanged += cmbImpuesto_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(484, 74);
            label1.Name = "label1";
            label1.Size = new Size(103, 30);
            label1.TabIndex = 2;
            label1.Text = "lblTotal ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(62, 49);
            label2.Name = "label2";
            label2.Size = new Size(117, 32);
            label2.TabIndex = 3;
            label2.Text = "Cantidad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(3, 109);
            label3.Name = "label3";
            label3.Size = new Size(209, 32);
            label3.TabIndex = 4;
            label3.Text = "tipo de impuesto";
            // 
            // Impuesto
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(759, 224);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbImpuesto);
            Controls.Add(txtMonto);
            Name = "Impuesto";
            Text = "Calcular Impuesto";
            Load += Impuesto_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMonto;
        private ComboBox cmbImpuesto;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}