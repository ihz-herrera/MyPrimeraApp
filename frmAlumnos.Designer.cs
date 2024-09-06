namespace MyPrimeraApp
{
    partial class frmAlumnos
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
            lblNombre = new Label();
            txtNombre = new TextBox();
            btnGuardar = new Button();
            txtApellido = new TextBox();
            lblApellido = new Label();
            label1 = new Label();
            cmbEdad = new ComboBox();
            btnCargar = new Button();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(27, 9);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(64, 20);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(27, 32);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(194, 27);
            txtNombre.TabIndex = 0;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(21, 209);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 3;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(27, 95);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(194, 27);
            txtApellido.TabIndex = 1;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(27, 72);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(66, 20);
            lblApellido.TabIndex = 3;
            lblApellido.Text = "Apellido";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 134);
            label1.Name = "label1";
            label1.Size = new Size(43, 20);
            label1.TabIndex = 4;
            label1.Text = "Edad";
            // 
            // cmbEdad
            // 
            cmbEdad.FormattingEnabled = true;
            cmbEdad.Items.AddRange(new object[] { "12", "13", "14", "15", "16", "17", "18" });
            cmbEdad.Location = new Point(27, 163);
            cmbEdad.Name = "cmbEdad";
            cmbEdad.Size = new Size(194, 28);
            cmbEdad.TabIndex = 2;
            // 
            // btnCargar
            // 
            btnCargar.Location = new Point(124, 209);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(94, 29);
            btnCargar.TabIndex = 5;
            btnCargar.Text = "Cargar";
            btnCargar.UseVisualStyleBackColor = true;
            btnCargar.Click += btnCargar_Click;
            // 
            // frmAlumnos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCargar);
            Controls.Add(cmbEdad);
            Controls.Add(label1);
            Controls.Add(txtApellido);
            Controls.Add(lblApellido);
            Controls.Add(btnGuardar);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Name = "frmAlumnos";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private TextBox txtNombre;
        private Button btnGuardar;
        private TextBox txtApellido;
        private Label lblApellido;
        private Label label1;
        private ComboBox cmbEdad;
        private Button btnCargar;
    }
}
