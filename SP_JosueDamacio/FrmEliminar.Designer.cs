namespace SP_JosueDamacio
{
    partial class FrmEliminar
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
            panel1 = new Panel();
            panel2 = new Panel();
            txtNombre = new TextBox();
            txtId = new TextBox();
            btnEliminar = new Button();
            btnCancelar = new Button();
            panel3 = new Panel();
            label1 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(192, 192, 255);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 24);
            panel1.Name = "panel1";
            panel1.Size = new Size(322, 41);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Silver;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 427);
            panel2.Name = "panel2";
            panel2.Size = new Size(322, 18);
            panel2.TabIndex = 1;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombre.Location = new Point(39, 122);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(238, 29);
            txtNombre.TabIndex = 2;
            // 
            // txtId
            // 
            txtId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtId.Location = new Point(39, 211);
            txtId.Name = "txtId";
            txtId.Size = new Size(238, 29);
            txtId.TabIndex = 4;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(119, 288);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(119, 344);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(128, 128, 255);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(322, 24);
            panel3.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(192, 255, 255);
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(54, 99);
            label1.Name = "label1";
            label1.Size = new Size(106, 20);
            label1.TabIndex = 8;
            label1.Text = "Nombre Barco";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(192, 255, 255);
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(54, 188);
            label3.Name = "label3";
            label3.Size = new Size(22, 20);
            label3.TabIndex = 10;
            label3.Text = "Id";
            // 
            // FrmEliminar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(322, 445);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(btnCancelar);
            Controls.Add(btnEliminar);
            Controls.Add(txtId);
            Controls.Add(txtNombre);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmEliminar";
            Text = "ELIMINAR";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private TextBox txtNombre;
        private TextBox txtId;
        private Button btnEliminar;
        private Button btnCancelar;
        private Panel panel3;
        private Label label1;
        private Label label3;
    }
}