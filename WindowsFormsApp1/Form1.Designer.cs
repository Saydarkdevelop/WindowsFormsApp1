namespace WindowsFormsApp1
{
    partial class FrmHome
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Juardar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cbxCiudad = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.apellido3 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.kaka = new System.Windows.Forms.Label();
            this.txtRut = new System.Windows.Forms.TextBox();
            this.ddd = new System.Windows.Forms.Label();
            this.grpGuardado = new System.Windows.Forms.GroupBox();
            this.lbCiudad = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbDireccion = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbApellido = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbRut = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.grpGuardado.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Juardar);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.cbxCiudad);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtDireccion);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtApellido);
            this.groupBox1.Controls.Add(this.apellido3);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.kaka);
            this.groupBox1.Controls.Add(this.txtRut);
            this.groupBox1.Controls.Add(this.ddd);
            this.groupBox1.Location = new System.Drawing.Point(32, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(311, 331);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alumos";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Juardar
            // 
            this.Juardar.Location = new System.Drawing.Point(200, 307);
            this.Juardar.Name = "Juardar";
            this.Juardar.Size = new System.Drawing.Size(75, 23);
            this.Juardar.TabIndex = 11;
            this.Juardar.Text = "guardar";
            this.Juardar.UseVisualStyleBackColor = true;
            this.Juardar.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(76, 305);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "limpiar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbxCiudad
            // 
            this.cbxCiudad.FormattingEnabled = true;
            this.cbxCiudad.Items.AddRange(new object[] {
            "Hola",
            "Soy",
            "Una",
            "Ciudad",
            "Asi",
            "Que",
            "Exis",
            "De"});
            this.cbxCiudad.Location = new System.Drawing.Point(37, 277);
            this.cbxCiudad.Name = "cbxCiudad";
            this.cbxCiudad.Size = new System.Drawing.Size(130, 21);
            this.cbxCiudad.TabIndex = 9;
            this.cbxCiudad.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 261);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "ciudad";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(37, 219);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(130, 20);
            this.txtDireccion.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Direccion";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(37, 163);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(130, 20);
            this.txtApellido.TabIndex = 5;
            // 
            // apellido3
            // 
            this.apellido3.AutoSize = true;
            this.apellido3.Location = new System.Drawing.Point(24, 147);
            this.apellido3.Name = "apellido3";
            this.apellido3.Size = new System.Drawing.Size(44, 13);
            this.apellido3.TabIndex = 4;
            this.apellido3.Text = "Apellido";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(37, 113);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(130, 20);
            this.txtNombre.TabIndex = 3;
            // 
            // kaka
            // 
            this.kaka.AutoSize = true;
            this.kaka.Location = new System.Drawing.Point(24, 97);
            this.kaka.Name = "kaka";
            this.kaka.Size = new System.Drawing.Size(44, 13);
            this.kaka.TabIndex = 2;
            this.kaka.Text = "Nombre";
            // 
            // txtRut
            // 
            this.txtRut.Location = new System.Drawing.Point(37, 62);
            this.txtRut.Name = "txtRut";
            this.txtRut.Size = new System.Drawing.Size(130, 20);
            this.txtRut.TabIndex = 1;
            // 
            // ddd
            // 
            this.ddd.AutoSize = true;
            this.ddd.Location = new System.Drawing.Point(24, 46);
            this.ddd.Name = "ddd";
            this.ddd.Size = new System.Drawing.Size(24, 13);
            this.ddd.TabIndex = 0;
            this.ddd.Text = "Rut";
            this.ddd.Click += new System.EventHandler(this.label1_Click);
            // 
            // grpGuardado
            // 
            this.grpGuardado.Controls.Add(this.lbCiudad);
            this.grpGuardado.Controls.Add(this.label12);
            this.grpGuardado.Controls.Add(this.lbDireccion);
            this.grpGuardado.Controls.Add(this.label10);
            this.grpGuardado.Controls.Add(this.lbApellido);
            this.grpGuardado.Controls.Add(this.label8);
            this.grpGuardado.Controls.Add(this.lbNombre);
            this.grpGuardado.Controls.Add(this.lbRut);
            this.grpGuardado.Controls.Add(this.label5);
            this.grpGuardado.Controls.Add(this.label2);
            this.grpGuardado.Location = new System.Drawing.Point(439, 63);
            this.grpGuardado.Name = "grpGuardado";
            this.grpGuardado.Size = new System.Drawing.Size(308, 133);
            this.grpGuardado.TabIndex = 1;
            this.grpGuardado.TabStop = false;
            this.grpGuardado.Text = "Guardar";
            this.grpGuardado.Enter += new System.EventHandler(this.grpGuardado_Enter);
            // 
            // lbCiudad
            // 
            this.lbCiudad.AutoSize = true;
            this.lbCiudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCiudad.Location = new System.Drawing.Point(202, 62);
            this.lbCiudad.Name = "lbCiudad";
            this.lbCiudad.Size = new System.Drawing.Size(51, 13);
            this.lbCiudad.TabIndex = 10;
            this.lbCiudad.Text = "...........";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(150, 65);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 13);
            this.label12.TabIndex = 9;
            this.label12.Text = "Ciudad";
            // 
            // lbDireccion
            // 
            this.lbDireccion.AutoSize = true;
            this.lbDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDireccion.Location = new System.Drawing.Point(202, 30);
            this.lbDireccion.Name = "lbDireccion";
            this.lbDireccion.Size = new System.Drawing.Size(55, 13);
            this.lbDireccion.TabIndex = 8;
            this.lbDireccion.Text = "............";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(150, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "Direccion";
            // 
            // lbApellido
            // 
            this.lbApellido.AutoSize = true;
            this.lbApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApellido.Location = new System.Drawing.Point(78, 97);
            this.lbApellido.Name = "lbApellido";
            this.lbApellido.Size = new System.Drawing.Size(43, 13);
            this.lbApellido.TabIndex = 6;
            this.lbApellido.Text = ".........";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Apellido";
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombre.Location = new System.Drawing.Point(78, 65);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(47, 13);
            this.lbNombre.TabIndex = 4;
            this.lbNombre.Text = "..........";
            // 
            // lbRut
            // 
            this.lbRut.AutoSize = true;
            this.lbRut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRut.Location = new System.Drawing.Point(78, 30);
            this.lbRut.Name = "lbRut";
            this.lbRut.Size = new System.Drawing.Size(43, 13);
            this.lbRut.TabIndex = 3;
            this.lbRut.Text = ".........";
            this.lbRut.Click += new System.EventHandler(this.lbRut_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Nombre";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Rut";
            // 
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpGuardado);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmHome";
            this.Text = "guardar alumno";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpGuardado.ResumeLayout(false);
            this.grpGuardado.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label apellido3;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label kaka;
        private System.Windows.Forms.TextBox txtRut;
        private System.Windows.Forms.Label ddd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxCiudad;
        private System.Windows.Forms.Button Juardar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox grpGuardado;
        private System.Windows.Forms.Label lbApellido;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbRut;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbCiudad;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbDireccion;
        private System.Windows.Forms.Label label10;
    }
}

