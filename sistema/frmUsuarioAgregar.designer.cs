namespace sistema
{
    partial class frmUsuarioAgregar
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
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbApellido = new System.Windows.Forms.TextBox();
            this.tbDireccion = new System.Windows.Forms.TextBox();
            this.dtpFNac = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.tbContraseña = new System.Windows.Forms.TextBox();
            this.tbUsuario = new System.Windows.Forms.TextBox();
            this.cbMostrarContraseña = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(311, 129);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(200, 20);
            this.tbNombre.TabIndex = 2;
            // 
            // tbApellido
            // 
            this.tbApellido.Location = new System.Drawing.Point(311, 158);
            this.tbApellido.Name = "tbApellido";
            this.tbApellido.Size = new System.Drawing.Size(200, 20);
            this.tbApellido.TabIndex = 3;
            // 
            // tbDireccion
            // 
            this.tbDireccion.Location = new System.Drawing.Point(311, 216);
            this.tbDireccion.Name = "tbDireccion";
            this.tbDireccion.Size = new System.Drawing.Size(200, 20);
            this.tbDireccion.TabIndex = 5;
            // 
            // dtpFNac
            // 
            this.dtpFNac.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFNac.Location = new System.Drawing.Point(311, 187);
            this.dtpFNac.Name = "dtpFNac";
            this.dtpFNac.Size = new System.Drawing.Size(200, 20);
            this.dtpFNac.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(199, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(199, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(199, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Direccion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(199, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Fech.Nacimieto";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(202, 271);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(436, 271);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(199, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Contraseña";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(199, 54);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(43, 13);
            this.lblUsuario.TabIndex = 10;
            this.lblUsuario.Text = "Usuario";
            // 
            // tbContraseña
            // 
            this.tbContraseña.Location = new System.Drawing.Point(311, 80);
            this.tbContraseña.Name = "tbContraseña";
            this.tbContraseña.Size = new System.Drawing.Size(200, 20);
            this.tbContraseña.TabIndex = 1;
            this.tbContraseña.UseSystemPasswordChar = true;
            // 
            // tbUsuario
            // 
            this.tbUsuario.Location = new System.Drawing.Point(311, 51);
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.Size = new System.Drawing.Size(200, 20);
            this.tbUsuario.TabIndex = 0;
            // 
            // cbMostrarContraseña
            // 
            this.cbMostrarContraseña.AutoSize = true;
            this.cbMostrarContraseña.Location = new System.Drawing.Point(311, 106);
            this.cbMostrarContraseña.Name = "cbMostrarContraseña";
            this.cbMostrarContraseña.Size = new System.Drawing.Size(118, 17);
            this.cbMostrarContraseña.TabIndex = 12;
            this.cbMostrarContraseña.Text = "Mostrar Contraseña";
            this.cbMostrarContraseña.UseVisualStyleBackColor = true;
            this.cbMostrarContraseña.CheckedChanged += new System.EventHandler(this.cbMostrarContraseña_CheckedChanged);
            // 
            // frmUsuarioAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 462);
            this.Controls.Add(this.cbMostrarContraseña);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.tbContraseña);
            this.Controls.Add(this.tbUsuario);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpFNac);
            this.Controls.Add(this.tbDireccion);
            this.Controls.Add(this.tbApellido);
            this.Controls.Add(this.tbNombre);
            this.Name = "frmUsuarioAgregar";
            this.Text = "frmUsuarioAgregar";
            this.Load += new System.EventHandler(this.frmUsuarioAgregar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbApellido;
        private System.Windows.Forms.TextBox tbDireccion;
        private System.Windows.Forms.DateTimePicker dtpFNac;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox tbContraseña;
        private System.Windows.Forms.TextBox tbUsuario;
        private System.Windows.Forms.CheckBox cbMostrarContraseña;
    }
}