namespace SP_JosueDamacio
{
    partial class FrmModificar
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            btnModificar = new Button();
            dGridBarcos = new DataGridView();
            txtNombreBarco = new TextBox();
            txtTripulacion = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            btnCancelar = new Button();
            cmBoxTipo = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dGridBarcos).BeginInit();
            SuspendLayout();
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(922, 413);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(103, 37);
            btnModificar.TabIndex = 8;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnHecho_Click;
            // 
            // dGridBarcos
            // 
            dGridBarcos.AllowUserToResizeColumns = false;
            dGridBarcos.AllowUserToResizeRows = false;
            dGridBarcos.BackgroundColor = SystemColors.Menu;
            dGridBarcos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = Color.LightBlue;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dGridBarcos.DefaultCellStyle = dataGridViewCellStyle1;
            dGridBarcos.GridColor = Color.FromArgb(192, 192, 255);
            dGridBarcos.Location = new Point(33, 76);
            dGridBarcos.MultiSelect = false;
            dGridBarcos.Name = "dGridBarcos";
            dGridBarcos.RowHeadersVisible = false;
            dGridBarcos.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dGridBarcos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dGridBarcos.Size = new Size(713, 448);
            dGridBarcos.TabIndex = 11;
            dGridBarcos.CellContentClick += dGridBarcos_CellContentClick;
            // 
            // txtNombreBarco
            // 
            txtNombreBarco.Location = new Point(778, 142);
            txtNombreBarco.Name = "txtNombreBarco";
            txtNombreBarco.Size = new Size(247, 23);
            txtNombreBarco.TabIndex = 13;
            // 
            // txtTripulacion
            // 
            txtTripulacion.Location = new Point(778, 286);
            txtTripulacion.Name = "txtTripulacion";
            txtTripulacion.Size = new Size(247, 23);
            txtTripulacion.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(789, 124);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 20;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(789, 195);
            label2.Name = "label2";
            label2.Size = new Size(30, 15);
            label2.TabIndex = 21;
            label2.Text = "Tipo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(789, 268);
            label3.Name = "label3";
            label3.Size = new Size(116, 15);
            label3.TabIndex = 22;
            label3.Text = "Cantidad Tripulacion";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 128, 255);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1079, 10);
            panel1.TabIndex = 26;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(192, 192, 255);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 10);
            panel2.Name = "panel2";
            panel2.Size = new Size(1079, 23);
            panel2.TabIndex = 27;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Silver;
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 545);
            panel3.Name = "panel3";
            panel3.Size = new Size(1079, 23);
            panel3.TabIndex = 28;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(778, 413);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(103, 37);
            btnCancelar.TabIndex = 29;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // cmBoxTipo
            // 
            cmBoxTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmBoxTipo.FormattingEnabled = true;
            cmBoxTipo.Location = new Point(778, 213);
            cmBoxTipo.Name = "cmBoxTipo";
            cmBoxTipo.Size = new Size(247, 23);
            cmBoxTipo.TabIndex = 30;
            // 
            // FrmModificar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1079, 568);
            Controls.Add(cmBoxTipo);
            Controls.Add(btnCancelar);
            Controls.Add(panel3);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtTripulacion);
            Controls.Add(txtNombreBarco);
            Controls.Add(dGridBarcos);
            Controls.Add(btnModificar);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmModificar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MODIFICAR";
            Load += FrmModificarEliminar_Load;
            ((System.ComponentModel.ISupportInitialize)dGridBarcos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnModificar;
        private DataGridView dGridBarcos;
        private TextBox txtNombreBarco;
        private TextBox txtTripulacion;
        private Label label1;
        private Label label2;
        private Label label3;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Button btnCancelar;
        private ComboBox cmBoxTipo;
    }
}