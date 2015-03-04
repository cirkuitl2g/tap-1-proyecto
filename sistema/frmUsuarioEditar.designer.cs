namespace sistema
{
    partial class frmUsuarioEditar
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
            this.btnReset = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFNac = new System.Windows.Forms.DateTimePicker();
            this.tbDireccion = new System.Windows.Forms.TextBox();
            this.tbApellido = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.cbMostrarContraseña = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.tbContraseña = new System.Windows.Forms.TextBox();
            this.tbUsuario = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(454, 276);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 14;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(220, 276);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 12;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(217, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Direccion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(217, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Fech.Nacimieto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(217, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Apellido";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(217, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Nombre";
            // 
            // dtpFNac
            // 
            this.dtpFNac.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFNac.Location = new System.Drawing.Point(329, 192);
            this.dtpFNac.Name = "dtpFNac";
            this.dtpFNac.Size = new System.Drawing.Size(200, 20);
            this.dtpFNac.TabIndex = 10;
            // 
            // tbDireccion
            // 
            this.tbDireccion.Location = new System.Drawing.Point(329, 221);
            this.tbDireccion.Name = "tbDireccion";
            this.tbDireccion.Size = new System.Drawing.Size(200, 20);
            this.tbDireccion.TabIndex = 11;
            // 
            // tbApellido
            // 
            this.tbApellido.Location = new System.Drawing.Point(329, 163);
            this.tbApellido.Name = "tbApellido";
            this.tbApellido.Size = new System.Drawing.Size(200, 20);
            this.tbApellido.TabIndex = 9;
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(329, 134);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(200, 20);
            this.tbNombre.TabIndex = 8;
            // 
            // cbMostrarContraseña
            // 
            this.cbMostrarContraseña.AutoSize = true;
            this.cbMostrarContraseña.Location = new System.Drawing.Point(329, 106);
            this.cbMostrarContraseña.Name = "cbMostrarContraseña";
            this.cbMostrarContraseña.Size = new System.Drawing.Size(118, 17);
            this.cbMostrarContraseña.TabIndex = 22;
            this.cbMostrarContraseña.Text = "Mostrar Contraseña";
            this.cbMostrarContraseña.UseVisualStyleBackColor = true;
            this.cbMostrarContraseña.CheckedChanged += new System.EventHandler(this.cbMostrarContraseña_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(217, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Contraseña";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(217, 54);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(43, 13);
            this.lblUsuario.TabIndex = 20;
            this.lblUsuario.Text = "Usuario";
            // 
            // tbContraseña
            // 
            this.tbContraseña.Location = new System.Drawing.Point(329, 80);
            this.tbContraseña.Name = "tbContraseña";
            this.tbContraseña.Size = new System.Drawing.Size(200, 20);
            this.tbContraseña.TabIndex = 19;
            this.tbContraseña.UseSystemPasswordChar = true;
            // 
            // tbUsuario
            // 
            this.tbUsuario.Location = new System.Drawing.Point(329, 51);
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.Size = new System.Drawing.Size(200, 20);
            this.tbUsuario.TabIndex = 18;
            // 
            // frmUsuarioEditar
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
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpFNac);
            this.Controls.Add(this.tbDireccion);
            this.Controls.Add(this.tbApellido);
            this.Controls.Add(this.tbNombre);
            this.Name = "frmUsuarioEditar";
            this.Text = "frmUsuarioEditar";
            this.Load += new System.EventHandler(this.frmUsuarioEditar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFNac;
        private System.Windows.Forms.TextBox tbDireccion;
        private System.Windows.Forms.TextBox tbApellido;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.CheckBox cbMostrarContraseña;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox tbContraseña;
        private System.Windows.Forms.TextBox tbUsuario;
    }
}