namespace MdiContainer
{
    partial class FormMDI
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
            menuStrip1 = new MenuStrip();
            ventanasToolStripMenuItem = new ToolStripMenuItem();
            registroDePersonasToolStripMenuItem = new ToolStripMenuItem();
            registroDePersonasToolStripMenuItem1 = new ToolStripMenuItem();
            conversorDeDivisasToolStripMenuItem = new ToolStripMenuItem();
            conversorDeDivisasToolStripMenuItem1 = new ToolStripMenuItem();
            cálculoDeImpuestosToolStripMenuItem = new ToolStripMenuItem();
            cálculoDeImpuestosToolStripMenuItem1 = new ToolStripMenuItem();
            fibonacciToolStripMenuItem = new ToolStripMenuItem();
            fibonacciToolStripMenuItem1 = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            tssUsuario = new ToolStripStatusLabel();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { ventanasToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 33);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // ventanasToolStripMenuItem
            // 
            ventanasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { registroDePersonasToolStripMenuItem, conversorDeDivisasToolStripMenuItem, cálculoDeImpuestosToolStripMenuItem, fibonacciToolStripMenuItem });
            ventanasToolStripMenuItem.Name = "ventanasToolStripMenuItem";
            ventanasToolStripMenuItem.Size = new Size(99, 29);
            ventanasToolStripMenuItem.Text = "Ventanas";
            // 
            // registroDePersonasToolStripMenuItem
            // 
            registroDePersonasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { registroDePersonasToolStripMenuItem1 });
            registroDePersonasToolStripMenuItem.Name = "registroDePersonasToolStripMenuItem";
            registroDePersonasToolStripMenuItem.Size = new Size(194, 34);
            registroDePersonasToolStripMenuItem.Text = "Ejercicio_1";
            registroDePersonasToolStripMenuItem.Click += registroDePersonasToolStripMenuItem_Click;
            // 
            // registroDePersonasToolStripMenuItem1
            // 
            registroDePersonasToolStripMenuItem1.Name = "registroDePersonasToolStripMenuItem1";
            registroDePersonasToolStripMenuItem1.Size = new Size(279, 34);
            registroDePersonasToolStripMenuItem1.Text = "Registro de Personas";
            registroDePersonasToolStripMenuItem1.Click += registroDePersonasToolStripMenuItem1_Click;
            // 
            // conversorDeDivisasToolStripMenuItem
            // 
            conversorDeDivisasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { conversorDeDivisasToolStripMenuItem1 });
            conversorDeDivisasToolStripMenuItem.Name = "conversorDeDivisasToolStripMenuItem";
            conversorDeDivisasToolStripMenuItem.Size = new Size(194, 34);
            conversorDeDivisasToolStripMenuItem.Text = "Ejercicio_2";
            conversorDeDivisasToolStripMenuItem.Click += conversorDeDivisasToolStripMenuItem_Click;
            // 
            // conversorDeDivisasToolStripMenuItem1
            // 
            conversorDeDivisasToolStripMenuItem1.Name = "conversorDeDivisasToolStripMenuItem1";
            conversorDeDivisasToolStripMenuItem1.Size = new Size(275, 34);
            conversorDeDivisasToolStripMenuItem1.Text = "conversor de divisas";
            conversorDeDivisasToolStripMenuItem1.Click += conversorDeDivisasToolStripMenuItem1_Click;
            // 
            // cálculoDeImpuestosToolStripMenuItem
            // 
            cálculoDeImpuestosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cálculoDeImpuestosToolStripMenuItem1 });
            cálculoDeImpuestosToolStripMenuItem.Name = "cálculoDeImpuestosToolStripMenuItem";
            cálculoDeImpuestosToolStripMenuItem.Size = new Size(194, 34);
            cálculoDeImpuestosToolStripMenuItem.Text = "Ejercicio_3";
            // 
            // cálculoDeImpuestosToolStripMenuItem1
            // 
            cálculoDeImpuestosToolStripMenuItem1.Name = "cálculoDeImpuestosToolStripMenuItem1";
            cálculoDeImpuestosToolStripMenuItem1.Size = new Size(281, 34);
            cálculoDeImpuestosToolStripMenuItem1.Text = "cálculo de impuestos";
            cálculoDeImpuestosToolStripMenuItem1.Click += cálculoDeImpuestosToolStripMenuItem1_Click;
            // 
            // fibonacciToolStripMenuItem
            // 
            fibonacciToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { fibonacciToolStripMenuItem1 });
            fibonacciToolStripMenuItem.Name = "fibonacciToolStripMenuItem";
            fibonacciToolStripMenuItem.Size = new Size(194, 34);
            fibonacciToolStripMenuItem.Text = "Ejercicoi_4";
            // 
            // fibonacciToolStripMenuItem1
            // 
            fibonacciToolStripMenuItem1.Name = "fibonacciToolStripMenuItem1";
            fibonacciToolStripMenuItem1.Size = new Size(188, 34);
            fibonacciToolStripMenuItem1.Text = "Fibonacci";
            fibonacciToolStripMenuItem1.Click += fibonacciToolStripMenuItem1_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(24, 24);
            statusStrip1.Items.AddRange(new ToolStripItem[] { tssUsuario });
            statusStrip1.Location = new Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // tssUsuario
            // 
            tssUsuario.Font = new Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tssUsuario.ForeColor = Color.Red;
            tssUsuario.Name = "tssUsuario";
            tssUsuario.Size = new Size(0, 15);
            // 
            // FormMDI
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "FormMDI";
            Text = "Formularios";
            Load += FormMDI_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private StatusStrip statusStrip1;
        private ToolStripMenuItem ventanasToolStripMenuItem;
        private ToolStripMenuItem registroDePersonasToolStripMenuItem;
        private ToolStripMenuItem conversorDeDivisasToolStripMenuItem;
        private ToolStripMenuItem cálculoDeImpuestosToolStripMenuItem;
        private ToolStripMenuItem fibonacciToolStripMenuItem;
        private ToolStripMenuItem registroDePersonasToolStripMenuItem1;
        private ToolStripMenuItem conversorDeDivisasToolStripMenuItem1;
        private ToolStripMenuItem cálculoDeImpuestosToolStripMenuItem1;
        private ToolStripMenuItem fibonacciToolStripMenuItem1;
        private ToolStripStatusLabel tssUsuario;
    }
}
