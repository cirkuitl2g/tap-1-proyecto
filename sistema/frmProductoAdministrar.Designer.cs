namespace sistema
{
    partial class frmProductoAdministrar
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
            this.tbCategoria = new System.Windows.Forms.TextBox();
            this.tbTitulo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbCosto = new System.Windows.Forms.TextBox();
            this.tvCategoria = new System.Windows.Forms.TreeView();
            this.rtbDescripcion = new System.Windows.Forms.RichTextBox();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.nudStockMin = new System.Windows.Forms.NumericUpDown();
            this.nudIVA = new System.Windows.Forms.ComboBox();
            this.cbGarantia = new System.Windows.Forms.ComboBox();
            this.tbGanancia = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbMarca = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStockMin)).BeginInit();
            this.SuspendLayout();
            // 
            // tbCategoria
            // 
            this.tbCategoria.Location = new System.Drawing.Point(398, 69);
            this.tbCategoria.Name = "tbCategoria";
            this.tbCategoria.ReadOnly = true;
            this.tbCategoria.Size = new System.Drawing.Size(132, 20);
            this.tbCategoria.TabIndex = 0;
            // 
            // tbTitulo
            // 
            this.tbTitulo.Location = new System.Drawing.Point(398, 95);
            this.tbTitulo.Name = "tbTitulo";
            this.tbTitulo.Size = new System.Drawing.Size(287, 20);
            this.tbTitulo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(340, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Categoria";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(340, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Titulo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(541, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Marca";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(450, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Stock.M";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(340, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Cantidad";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(340, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Descripcion";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(340, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Costo $";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(555, 123);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Garantia";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(476, 150);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "IVA %";
            // 
            // tbCosto
            // 
            this.tbCosto.Location = new System.Drawing.Point(399, 147);
            this.tbCosto.Name = "tbCosto";
            this.tbCosto.Size = new System.Drawing.Size(71, 20);
            this.tbCosto.TabIndex = 18;
            // 
            // tvCategoria
            // 
            this.tvCategoria.AllowDrop = true;
            this.tvCategoria.Location = new System.Drawing.Point(12, 64);
            this.tvCategoria.Name = "tvCategoria";
            this.tvCategoria.Size = new System.Drawing.Size(237, 383);
            this.tvCategoria.TabIndex = 32;
            this.tvCategoria.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvCategoria_AfterSelect);
            // 
            // rtbDescripcion
            // 
            this.rtbDescripcion.Location = new System.Drawing.Point(343, 195);
            this.rtbDescripcion.Name = "rtbDescripcion";
            this.rtbDescripcion.Size = new System.Drawing.Size(342, 133);
            this.rtbDescripcion.TabIndex = 36;
            this.rtbDescripcion.Text = "";
            // 
            // nudCantidad
            // 
            this.nudCantidad.Location = new System.Drawing.Point(398, 121);
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(46, 20);
            this.nudCantidad.TabIndex = 39;
            // 
            // nudStockMin
            // 
            this.nudStockMin.Location = new System.Drawing.Point(503, 121);
            this.nudStockMin.Name = "nudStockMin";
            this.nudStockMin.Size = new System.Drawing.Size(46, 20);
            this.nudStockMin.TabIndex = 41;
            // 
            // nudIVA
            // 
            this.nudIVA.FormattingEnabled = true;
            this.nudIVA.Location = new System.Drawing.Point(517, 142);
            this.nudIVA.Name = "nudIVA";
            this.nudIVA.Size = new System.Drawing.Size(43, 21);
            this.nudIVA.TabIndex = 42;
            // 
            // cbGarantia
            // 
            this.cbGarantia.FormattingEnabled = true;
            this.cbGarantia.Location = new System.Drawing.Point(608, 120);
            this.cbGarantia.Name = "cbGarantia";
            this.cbGarantia.Size = new System.Drawing.Size(77, 21);
            this.cbGarantia.TabIndex = 43;
            // 
            // tbGanancia
            // 
            this.tbGanancia.Location = new System.Drawing.Point(636, 147);
            this.tbGanancia.Name = "tbGanancia";
            this.tbGanancia.Size = new System.Drawing.Size(49, 20);
            this.tbGanancia.TabIndex = 45;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(566, 150);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 44;
            this.label8.Text = "Ganancia %";
            // 
            // cbMarca
            // 
            this.cbMarca.FormattingEnabled = true;
            this.cbMarca.Location = new System.Drawing.Point(584, 68);
            this.cbMarca.Name = "cbMarca";
            this.cbMarca.Size = new System.Drawing.Size(101, 21);
            this.cbMarca.TabIndex = 46;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(343, 344);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 47;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // frmProductoAdministrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.cbMarca);
            this.Controls.Add(this.tbGanancia);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbGarantia);
            this.Controls.Add(this.nudIVA);
            this.Controls.Add(this.nudStockMin);
            this.Controls.Add(this.nudCantidad);
            this.Controls.Add(this.rtbDescripcion);
            this.Controls.Add(this.tvCategoria);
            this.Controls.Add(this.tbCosto);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbTitulo);
            this.Controls.Add(this.tbCategoria);
            this.Name = "frmProductoAdministrar";
            this.Text = "frmProductoAdministrar";
            this.Load += new System.EventHandler(this.frmProductoAgregar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStockMin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbCategoria;
        private System.Windows.Forms.TextBox tbTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbCosto;
        private System.Windows.Forms.TreeView tvCategoria;
        private System.Windows.Forms.RichTextBox rtbDescripcion;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.NumericUpDown nudStockMin;
        private System.Windows.Forms.ComboBox nudIVA;
        private System.Windows.Forms.ComboBox cbGarantia;
        private System.Windows.Forms.TextBox tbGanancia;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbMarca;
        private System.Windows.Forms.Button btnGuardar;
    }
}