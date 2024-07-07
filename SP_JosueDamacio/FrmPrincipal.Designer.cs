namespace SP_JosueDamacio
{
    partial class FrmPrincipal
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panHeader = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            menuStrip1 = new MenuStrip();
            añadirToolStripMenuItem = new ToolStripMenuItem();
            añadirToolStripMenuItem1 = new ToolStripMenuItem();
            modificarToolStripMenuItem = new ToolStripMenuItem();
            eliminarToolStripMenuItem = new ToolStripMenuItem();
            coleccionesToolStripMenuItem = new ToolStripMenuItem();
            programadoresToolStripMenuItem = new ToolStripMenuItem();
            ingenierosToolStripMenuItem = new ToolStripMenuItem();
            ordenarlosToolStripMenuItem = new ToolStripMenuItem();
            lstBarcos = new ListBox();
            btnSalir = new Button();
            rbVerLista = new RadioButton();
            rbVerGrilla = new RadioButton();
            dGridBarcos = new DataGridView();
            checkBoxVer = new CheckBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dGridBarcos).BeginInit();
            SuspendLayout();
            // 
            // panHeader
            // 
            panHeader.BackColor = Color.FromArgb(192, 192, 255);
            panHeader.Dock = DockStyle.Top;
            panHeader.Location = new Point(0, 33);
            panHeader.Name = "panHeader";
            panHeader.Size = new Size(800, 27);
            panHeader.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Silver;
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(783, 60);
            panel2.Name = "panel2";
            panel2.Size = new Size(17, 390);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Silver;
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 60);
            panel3.Name = "panel3";
            panel3.Size = new Size(17, 390);
            panel3.TabIndex = 2;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(128, 128, 255);
            menuStrip1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            menuStrip1.Items.AddRange(new ToolStripItem[] { añadirToolStripMenuItem, coleccionesToolStripMenuItem, ordenarlosToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 33);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menu";
            // 
            // añadirToolStripMenuItem
            // 
            añadirToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { añadirToolStripMenuItem1, modificarToolStripMenuItem, eliminarToolStripMenuItem });
            añadirToolStripMenuItem.Name = "añadirToolStripMenuItem";
            añadirToolStripMenuItem.Size = new Size(76, 29);
            añadirToolStripMenuItem.Text = "CRUD";
            // 
            // añadirToolStripMenuItem1
            // 
            añadirToolStripMenuItem1.Name = "añadirToolStripMenuItem1";
            añadirToolStripMenuItem1.Size = new Size(170, 30);
            añadirToolStripMenuItem1.Text = "Añadir";
            añadirToolStripMenuItem1.Click += añadirToolStripMenuItem1_Click;
            // 
            // modificarToolStripMenuItem
            // 
            modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            modificarToolStripMenuItem.Size = new Size(170, 30);
            modificarToolStripMenuItem.Text = "Modificar";
            modificarToolStripMenuItem.Click += modificarToolStripMenuItem_Click_1;
            // 
            // eliminarToolStripMenuItem
            // 
            eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            eliminarToolStripMenuItem.Size = new Size(170, 30);
            eliminarToolStripMenuItem.Text = "Eliminar";
            eliminarToolStripMenuItem.Click += eliminarToolStripMenuItem_Click;
            // 
            // coleccionesToolStripMenuItem
            // 
            coleccionesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { programadoresToolStripMenuItem, ingenierosToolStripMenuItem });
            coleccionesToolStripMenuItem.Name = "coleccionesToolStripMenuItem";
            coleccionesToolStripMenuItem.Size = new Size(102, 29);
            coleccionesToolStripMenuItem.Text = "Acciones";
            // 
            // programadoresToolStripMenuItem
            // 
            programadoresToolStripMenuItem.Name = "programadoresToolStripMenuItem";
            programadoresToolStripMenuItem.Size = new Size(282, 30);
            programadoresToolStripMenuItem.Text = "Reparar";
            // 
            // ingenierosToolStripMenuItem
            // 
            ingenierosToolStripMenuItem.Name = "ingenierosToolStripMenuItem";
            ingenierosToolStripMenuItem.Size = new Size(282, 30);
            ingenierosToolStripMenuItem.Text = "Guardar Registro XML";
            // 
            // ordenarlosToolStripMenuItem
            // 
            ordenarlosToolStripMenuItem.Name = "ordenarlosToolStripMenuItem";
            ordenarlosToolStripMenuItem.Size = new Size(134, 29);
            ordenarlosToolStripMenuItem.Text = "Ordenar Por";
            ordenarlosToolStripMenuItem.Click += ordenarlosToolStripMenuItem_Click;
            // 
            // lstBarcos
            // 
            lstBarcos.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstBarcos.FormattingEnabled = true;
            lstBarcos.ItemHeight = 20;
            lstBarcos.Location = new Point(44, 90);
            lstBarcos.Name = "lstBarcos";
            lstBarcos.Size = new Size(709, 284);
            lstBarcos.TabIndex = 4;
            lstBarcos.Visible = false;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(716, 414);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(61, 27);
            btnSalir.TabIndex = 7;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // rbVerLista
            // 
            rbVerLista.AutoSize = true;
            rbVerLista.Location = new Point(130, 418);
            rbVerLista.Name = "rbVerLista";
            rbVerLista.Size = new Size(97, 19);
            rbVerLista.TabIndex = 8;
            rbVerLista.TabStop = true;
            rbVerLista.Text = "Formato Lista";
            rbVerLista.UseVisualStyleBackColor = true;
            rbVerLista.CheckedChanged += rbVerLista_CheckedChanged;
            // 
            // rbVerGrilla
            // 
            rbVerGrilla.AutoSize = true;
            rbVerGrilla.Location = new Point(242, 418);
            rbVerGrilla.Name = "rbVerGrilla";
            rbVerGrilla.Size = new Size(100, 19);
            rbVerGrilla.TabIndex = 9;
            rbVerGrilla.TabStop = true;
            rbVerGrilla.Text = "Formato Grilla";
            rbVerGrilla.UseVisualStyleBackColor = true;
            rbVerGrilla.CheckedChanged += rbVerGrilla_CheckedChanged;
            // 
            // dGridBarcos
            // 
            dGridBarcos.AllowUserToAddRows = false;
            dGridBarcos.AllowUserToDeleteRows = false;
            dGridBarcos.AllowUserToResizeColumns = false;
            dGridBarcos.AllowUserToResizeRows = false;
            dGridBarcos.BackgroundColor = SystemColors.ButtonHighlight;
            dGridBarcos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = Color.LightSkyBlue;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dGridBarcos.DefaultCellStyle = dataGridViewCellStyle1;
            dGridBarcos.GridColor = SystemColors.Menu;
            dGridBarcos.Location = new Point(84, 90);
            dGridBarcos.MultiSelect = false;
            dGridBarcos.Name = "dGridBarcos";
            dGridBarcos.ReadOnly = true;
            dGridBarcos.RowHeadersVisible = false;
            dGridBarcos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dGridBarcos.Size = new Size(625, 304);
            dGridBarcos.TabIndex = 10;
            // 
            // checkBoxVer
            // 
            checkBoxVer.AutoSize = true;
            checkBoxVer.Location = new Point(44, 418);
            checkBoxVer.Name = "checkBoxVer";
            checkBoxVer.Size = new Size(80, 19);
            checkBoxVer.TabIndex = 11;
            checkBoxVer.Text = "Ver Barcos";
            checkBoxVer.UseVisualStyleBackColor = true;
            checkBoxVer.CheckedChanged += checkBoxVer_CheckedChanged_1;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(800, 450);
            Controls.Add(checkBoxVer);
            Controls.Add(dGridBarcos);
            Controls.Add(rbVerGrilla);
            Controls.Add(rbVerLista);
            Controls.Add(btnSalir);
            Controls.Add(lstBarcos);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panHeader);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = menuStrip1;
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += FrmPrincipal_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dGridBarcos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panHeader;
        private Panel panel2;
        private Panel panel3;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem añadirToolStripMenuItem;
        private ToolStripMenuItem añadirToolStripMenuItem1;
        private ToolStripMenuItem modificarToolStripMenuItem;
        private ToolStripMenuItem coleccionesToolStripMenuItem;
        private ToolStripMenuItem programadoresToolStripMenuItem;
        private ToolStripMenuItem ingenierosToolStripMenuItem;
        private ToolStripMenuItem ordenarlosToolStripMenuItem;
        protected ListBox lstBarcos;
        private Button btnSalir;
        private RadioButton rbVerLista;
        private RadioButton rbVerGrilla;
        private DataGridView dGridBarcos;
        private CheckBox checkBoxVer;
        private ToolStripMenuItem eliminarToolStripMenuItem;
    }
}
