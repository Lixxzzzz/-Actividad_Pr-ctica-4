namespace MdiContainer
{
    partial class Fibonacci
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
            btnGenerar = new Button();
            txtLimite = new TextBox();
            txtResultado = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnGenerar
            // 
            btnGenerar.BackColor = Color.FromArgb(255, 128, 255);
            btnGenerar.Location = new Point(171, 173);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(177, 74);
            btnGenerar.TabIndex = 0;
            btnGenerar.Text = "Generar";
            btnGenerar.UseVisualStyleBackColor = false;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // txtLimite
            // 
            txtLimite.Location = new Point(144, 105);
            txtLimite.Name = "txtLimite";
            txtLimite.Size = new Size(240, 31);
            txtLimite.TabIndex = 1;
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(30, 314);
            txtResultado.Multiline = true;
            txtResultado.Name = "txtResultado";
            txtResultado.ReadOnly = true;
            txtResultado.Size = new Size(495, 79);
            txtResultado.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(133, 33);
            label1.Name = "label1";
            label1.Size = new Size(265, 38);
            label1.TabIndex = 3;
            label1.Text = "ingresa un número";
            // 
            // Fibonacci
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 0);
            ClientSize = new Size(554, 450);
            Controls.Add(label1);
            Controls.Add(txtResultado);
            Controls.Add(txtLimite);
            Controls.Add(btnGenerar);
            Name = "Fibonacci";
            Text = "Fibonacci";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGenerar;
        private TextBox txtLimite;
        private TextBox txtResultado;
        private Label label1;
    }
}