namespace SP_JosueDamacio
{
    partial class FrmAñadir
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
            label1 = new Label();
            btnAñadir = new Button();
            btnCancelar = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            cmBoxOperacion = new ComboBox();
            label6 = new Label();
            label7 = new Label();
            cmBoxTipo = new ComboBox();
            txtNombre = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(75, 87);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 4;
            label1.Text = "Nombre";
            // 
            // btnAñadir
            // 
            btnAñadir.Location = new Point(52, 468);
            btnAñadir.Name = "btnAñadir";
            btnAñadir.Size = new Size(132, 46);
            btnAñadir.TabIndex = 14;
            btnAñadir.Text = "Añadir";
            btnAñadir.UseVisualStyleBackColor = true;
            btnAñadir.Click += btnAñadir_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(282, 468);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(132, 46);
            btnCancelar.TabIndex = 15;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 128, 255);
            panel1.Location = new Point(0, -4);
            panel1.Name = "panel1";
            panel1.Size = new Size(481, 20);
            panel1.TabIndex = 16;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(192, 192, 255);
            panel2.Location = new Point(-9, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(490, 38);
            panel2.TabIndex = 17;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Silver;
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 578);
            panel3.Name = "panel3";
            panel3.Size = new Size(478, 18);
            panel3.TabIndex = 18;
            // 
            // cmBoxOperacion
            // 
            cmBoxOperacion.DropDownStyle = ComboBoxStyle.DropDownList;
            cmBoxOperacion.FormattingEnabled = true;
            cmBoxOperacion.Location = new Point(75, 297);
            cmBoxOperacion.Name = "cmBoxOperacion";
            cmBoxOperacion.Size = new Size(317, 23);
            cmBoxOperacion.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(75, 279);
            label6.Name = "label6";
            label6.Size = new Size(62, 15);
            label6.TabIndex = 7;
            label6.Text = "Operación";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(75, 183);
            label7.Name = "label7";
            label7.Size = new Size(30, 15);
            label7.TabIndex = 8;
            label7.Text = "Tipo";
            // 
            // cmBoxTipo
            // 
            cmBoxTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmBoxTipo.FormattingEnabled = true;
            cmBoxTipo.Location = new Point(75, 201);
            cmBoxTipo.Name = "cmBoxTipo";
            cmBoxTipo.Size = new Size(317, 23);
            cmBoxTipo.TabIndex = 9;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(75, 115);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(317, 23);
            txtNombre.TabIndex = 0;
            // 
            // FrmAñadir
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(478, 596);
            Controls.Add(cmBoxTipo);
            Controls.Add(label7);
            Controls.Add(panel3);
            Controls.Add(label6);
            Controls.Add(panel2);
            Controls.Add(cmBoxOperacion);
            Controls.Add(panel1);
            Controls.Add(btnCancelar);
            Controls.Add(btnAñadir);
            Controls.Add(label1);
            Controls.Add(txtNombre);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmAñadir";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button btnAñadir;
        private Button btnCancelar;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private ComboBox cmBoxOperacion;
        private Label label6;
        private Label label7;
        private ComboBox cmBoxTipo;
        private TextBox txtNombre;
    }
}