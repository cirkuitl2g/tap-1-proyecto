namespace sistema
{
    partial class frmCategoria
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
            this.lblId = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblProfundidad = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCargar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.tbTexto = new System.Windows.Forms.TextBox();
            this.btnAñadir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.tbEditar = new System.Windows.Forms.TextBox();
            this.lblIdNodoEditar = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.btnMas = new System.Windows.Forms.Button();
            this.btnMenos = new System.Windows.Forms.Button();
            this.lblPadre = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(293, 431);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(10, 13);
            this.lblId.TabIndex = 22;
            this.lblId.Text = " ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(269, 431);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "ID";
            // 
            // lblProfundidad
            // 
            this.lblProfundidad.AutoSize = true;
            this.lblProfundidad.Location = new System.Drawing.Point(435, 431);
            this.lblProfundidad.Name = "lblProfundidad";
            this.lblProfundidad.Size = new System.Drawing.Size(10, 13);
            this.lblProfundidad.TabIndex = 20;
            this.lblProfundidad.Text = " ";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(570, 431);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(10, 13);
            this.lblNombre.TabIndex = 19;
            this.lblNombre.Text = " ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(365, 431);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Profundidad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(522, 431);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "nombre";
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(387, 181);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(75, 23);
            this.btnCargar.TabIndex = 27;
            this.btnCargar.Text = "Cargar Arbol";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(387, 210);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 26;
            this.btnGuardar.Text = "Guardar ";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(387, 152);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 25;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // tbTexto
            // 
            this.tbTexto.Location = new System.Drawing.Point(472, 93);
            this.tbTexto.Name = "tbTexto";
            this.tbTexto.Size = new System.Drawing.Size(100, 20);
            this.tbTexto.TabIndex = 24;
            // 
            // btnAñadir
            // 
            this.btnAñadir.Location = new System.Drawing.Point(387, 91);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(75, 23);
            this.btnAñadir.TabIndex = 23;
            this.btnAñadir.Text = "añadir";
            this.btnAñadir.UseVisualStyleBackColor = true;
            this.btnAñadir.Click += new System.EventHandler(this.btnAñadir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(387, 123);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 28;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // tbEditar
            // 
            this.tbEditar.Location = new System.Drawing.Point(472, 125);
            this.tbEditar.Name = "tbEditar";
            this.tbEditar.Size = new System.Drawing.Size(100, 20);
            this.tbEditar.TabIndex = 29;
            // 
            // lblIdNodoEditar
            // 
            this.lblIdNodoEditar.AutoSize = true;
            this.lblIdNodoEditar.Location = new System.Drawing.Point(578, 128);
            this.lblIdNodoEditar.Name = "lblIdNodoEditar";
            this.lblIdNodoEditar.Size = new System.Drawing.Size(0, 13);
            this.lblIdNodoEditar.TabIndex = 30;
            // 
            // treeView1
            // 
            this.treeView1.AllowDrop = true;
            this.treeView1.Location = new System.Drawing.Point(12, 91);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(237, 353);
            this.treeView1.TabIndex = 31;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect_);
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            // 
            // btnMas
            // 
            this.btnMas.Location = new System.Drawing.Point(12, 12);
            this.btnMas.Name = "btnMas";
            this.btnMas.Size = new System.Drawing.Size(33, 23);
            this.btnMas.TabIndex = 32;
            this.btnMas.Text = "+";
            this.btnMas.UseVisualStyleBackColor = true;
            this.btnMas.Click += new System.EventHandler(this.btnMas_Click);
            // 
            // btnMenos
            // 
            this.btnMenos.Location = new System.Drawing.Point(59, 12);
            this.btnMenos.Name = "btnMenos";
            this.btnMenos.Size = new System.Drawing.Size(33, 23);
            this.btnMenos.TabIndex = 33;
            this.btnMenos.Text = "-";
            this.btnMenos.UseVisualStyleBackColor = true;
            this.btnMenos.Click += new System.EventHandler(this.btnMenos_Click);
            // 
            // lblPadre
            // 
            this.lblPadre.AutoSize = true;
            this.lblPadre.Location = new System.Drawing.Point(60, 63);
            this.lblPadre.Name = "lblPadre";
            this.lblPadre.Size = new System.Drawing.Size(10, 13);
            this.lblPadre.TabIndex = 35;
            this.lblPadre.Text = " ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "Padre";
            // 
            // frmCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.lblPadre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnMenos);
            this.Controls.Add(this.btnMas);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.lblIdNodoEditar);
            this.Controls.Add(this.tbEditar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.tbTexto);
            this.Controls.Add(this.btnAñadir);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblProfundidad);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "frmCategoria";
            this.Text = "frmCategoria";
            this.Load += new System.EventHandler(this.frmCategoria_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblProfundidad;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox tbTexto;
        private System.Windows.Forms.Button btnAñadir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.TextBox tbEditar;
        private System.Windows.Forms.Label lblIdNodoEditar;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button btnMas;
        private System.Windows.Forms.Button btnMenos;
        private System.Windows.Forms.Label lblPadre;
        private System.Windows.Forms.Label label5;
    }
}