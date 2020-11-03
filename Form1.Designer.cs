namespace VideoClubSegundaVez
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbtMasculino = new System.Windows.Forms.RadioButton();
            this.rbtFemenino = new System.Windows.Forms.RadioButton();
            this.rbtOtro = new System.Windows.Forms.RadioButton();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtCodigoSocio = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtMontoAlq = new System.Windows.Forms.TextBox();
            this.txtNumeroAlquiler = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpFechaAlq = new System.Windows.Forms.DateTimePicker();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtTituloPeli = new System.Windows.Forms.TextBox();
            this.txtCodigoPeli = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cboGenero = new System.Windows.Forms.ComboBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lblTerror = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.lblFiccion = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.lblComedia = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.lblRecaudacionPromedio = new System.Windows.Forms.Label();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.lblPorcVarones = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.lblMujeresTerrorificas = new System.Windows.Forms.Label();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.lblAlquilerCaro = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dni";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Codigo Socio";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.txtCodigoSocio);
            this.groupBox1.Controls.Add(this.txtDni);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(8, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(254, 199);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cliente";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbtOtro);
            this.groupBox2.Controls.Add(this.rbtFemenino);
            this.groupBox2.Controls.Add(this.rbtMasculino);
            this.groupBox2.Location = new System.Drawing.Point(18, 91);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(229, 49);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sexo";
            // 
            // rbtMasculino
            // 
            this.rbtMasculino.AutoSize = true;
            this.rbtMasculino.Location = new System.Drawing.Point(11, 19);
            this.rbtMasculino.Name = "rbtMasculino";
            this.rbtMasculino.Size = new System.Drawing.Size(73, 17);
            this.rbtMasculino.TabIndex = 0;
            this.rbtMasculino.TabStop = true;
            this.rbtMasculino.Text = "Masculino";
            this.rbtMasculino.UseVisualStyleBackColor = true;
            // 
            // rbtFemenino
            // 
            this.rbtFemenino.AutoSize = true;
            this.rbtFemenino.Location = new System.Drawing.Point(97, 19);
            this.rbtFemenino.Name = "rbtFemenino";
            this.rbtFemenino.Size = new System.Drawing.Size(71, 17);
            this.rbtFemenino.TabIndex = 0;
            this.rbtFemenino.TabStop = true;
            this.rbtFemenino.Text = "Femenino";
            this.rbtFemenino.UseVisualStyleBackColor = true;
            // 
            // rbtOtro
            // 
            this.rbtOtro.AutoSize = true;
            this.rbtOtro.Location = new System.Drawing.Point(181, 19);
            this.rbtOtro.Name = "rbtOtro";
            this.rbtOtro.Size = new System.Drawing.Size(45, 17);
            this.rbtOtro.TabIndex = 0;
            this.rbtOtro.TabStop = true;
            this.rbtOtro.Text = "Otro";
            this.rbtOtro.UseVisualStyleBackColor = true;
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(111, 28);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(117, 20);
            this.txtDni.TabIndex = 0;
            // 
            // txtCodigoSocio
            // 
            this.txtCodigoSocio.Location = new System.Drawing.Point(111, 154);
            this.txtCodigoSocio.Name = "txtCodigoSocio";
            this.txtCodigoSocio.Size = new System.Drawing.Size(117, 20);
            this.txtCodigoSocio.TabIndex = 3;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(111, 59);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(117, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtpFechaAlq);
            this.groupBox3.Controls.Add(this.txtMontoAlq);
            this.groupBox3.Controls.Add(this.txtNumeroAlquiler);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(268, 10);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(180, 127);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Alquiler";
            // 
            // txtMontoAlq
            // 
            this.txtMontoAlq.Location = new System.Drawing.Point(71, 90);
            this.txtMontoAlq.Name = "txtMontoAlq";
            this.txtMontoAlq.Size = new System.Drawing.Size(95, 20);
            this.txtMontoAlq.TabIndex = 2;
            // 
            // txtNumeroAlquiler
            // 
            this.txtNumeroAlquiler.Location = new System.Drawing.Point(71, 28);
            this.txtNumeroAlquiler.Name = "txtNumeroAlquiler";
            this.txtNumeroAlquiler.Size = new System.Drawing.Size(95, 20);
            this.txtNumeroAlquiler.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Numero";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Monto";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Fecha";
            // 
            // dtpFechaAlq
            // 
            this.dtpFechaAlq.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaAlq.Location = new System.Drawing.Point(71, 59);
            this.dtpFechaAlq.Name = "dtpFechaAlq";
            this.dtpFechaAlq.Size = new System.Drawing.Size(95, 20);
            this.dtpFechaAlq.TabIndex = 1;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cboGenero);
            this.groupBox4.Controls.Add(this.txtTituloPeli);
            this.groupBox4.Controls.Add(this.txtCodigoPeli);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Location = new System.Drawing.Point(455, 10);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(213, 127);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Pelicula";
            // 
            // txtTituloPeli
            // 
            this.txtTituloPeli.Location = new System.Drawing.Point(71, 59);
            this.txtTituloPeli.Name = "txtTituloPeli";
            this.txtTituloPeli.Size = new System.Drawing.Size(111, 20);
            this.txtTituloPeli.TabIndex = 1;
            // 
            // txtCodigoPeli
            // 
            this.txtCodigoPeli.Location = new System.Drawing.Point(71, 28);
            this.txtCodigoPeli.Name = "txtCodigoPeli";
            this.txtCodigoPeli.Size = new System.Drawing.Size(111, 20);
            this.txtCodigoPeli.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Codigo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 93);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Genero";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Titulo";
            // 
            // cboGenero
            // 
            this.cboGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGenero.FormattingEnabled = true;
            this.cboGenero.Items.AddRange(new object[] {
            "Terror",
            "Ficcion",
            "Comedia"});
            this.cboGenero.Location = new System.Drawing.Point(71, 90);
            this.cboGenero.Name = "cboGenero";
            this.cboGenero.Size = new System.Drawing.Size(111, 21);
            this.cboGenero.TabIndex = 2;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnRegistrar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnRegistrar.Location = new System.Drawing.Point(268, 143);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(74, 66);
            this.btnRegistrar.TabIndex = 3;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox5.Controls.Add(this.lblTerror);
            this.groupBox5.Location = new System.Drawing.Point(360, 143);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(49, 66);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Terror";
            // 
            // lblTerror
            // 
            this.lblTerror.AutoSize = true;
            this.lblTerror.Location = new System.Drawing.Point(18, 28);
            this.lblTerror.Name = "lblTerror";
            this.lblTerror.Size = new System.Drawing.Size(13, 13);
            this.lblTerror.TabIndex = 0;
            this.lblTerror.Text = "0";
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox6.Controls.Add(this.lblFiccion);
            this.groupBox6.Location = new System.Drawing.Point(424, 143);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(57, 66);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Ficcion";
            // 
            // lblFiccion
            // 
            this.lblFiccion.AutoSize = true;
            this.lblFiccion.Location = new System.Drawing.Point(21, 28);
            this.lblFiccion.Name = "lblFiccion";
            this.lblFiccion.Size = new System.Drawing.Size(13, 13);
            this.lblFiccion.TabIndex = 0;
            this.lblFiccion.Text = "0";
            // 
            // groupBox7
            // 
            this.groupBox7.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox7.Controls.Add(this.lblComedia);
            this.groupBox7.Location = new System.Drawing.Point(494, 143);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(62, 66);
            this.groupBox7.TabIndex = 3;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Comedia";
            // 
            // lblComedia
            // 
            this.lblComedia.AutoSize = true;
            this.lblComedia.Location = new System.Drawing.Point(24, 28);
            this.lblComedia.Name = "lblComedia";
            this.lblComedia.Size = new System.Drawing.Size(13, 13);
            this.lblComedia.TabIndex = 0;
            this.lblComedia.Text = "0";
            // 
            // groupBox8
            // 
            this.groupBox8.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox8.Controls.Add(this.lblRecaudacionPromedio);
            this.groupBox8.Controls.Add(this.label13);
            this.groupBox8.Location = new System.Drawing.Point(8, 215);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(136, 66);
            this.groupBox8.TabIndex = 3;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Recaudacion Promedio";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(31, 28);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(13, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "$";
            // 
            // lblRecaudacionPromedio
            // 
            this.lblRecaudacionPromedio.AutoSize = true;
            this.lblRecaudacionPromedio.Location = new System.Drawing.Point(50, 28);
            this.lblRecaudacionPromedio.Name = "lblRecaudacionPromedio";
            this.lblRecaudacionPromedio.Size = new System.Drawing.Size(13, 13);
            this.lblRecaudacionPromedio.TabIndex = 0;
            this.lblRecaudacionPromedio.Text = "0";
            // 
            // groupBox9
            // 
            this.groupBox9.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox9.Controls.Add(this.lblPorcVarones);
            this.groupBox9.Controls.Add(this.label16);
            this.groupBox9.Location = new System.Drawing.Point(150, 215);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(112, 66);
            this.groupBox9.TabIndex = 3;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "% Socios Varones";
            // 
            // lblPorcVarones
            // 
            this.lblPorcVarones.AutoSize = true;
            this.lblPorcVarones.Location = new System.Drawing.Point(43, 28);
            this.lblPorcVarones.Name = "lblPorcVarones";
            this.lblPorcVarones.Size = new System.Drawing.Size(13, 13);
            this.lblPorcVarones.TabIndex = 0;
            this.lblPorcVarones.Text = "0";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(76, 28);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(15, 13);
            this.label16.TabIndex = 0;
            this.label16.Text = "%";
            // 
            // groupBox10
            // 
            this.groupBox10.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox10.Controls.Add(this.lblMujeresTerrorificas);
            this.groupBox10.Location = new System.Drawing.Point(268, 215);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(119, 66);
            this.groupBox10.TabIndex = 3;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Mujeres Terrorificas";
            // 
            // lblMujeresTerrorificas
            // 
            this.lblMujeresTerrorificas.AutoSize = true;
            this.lblMujeresTerrorificas.Location = new System.Drawing.Point(46, 28);
            this.lblMujeresTerrorificas.Name = "lblMujeresTerrorificas";
            this.lblMujeresTerrorificas.Size = new System.Drawing.Size(13, 13);
            this.lblMujeresTerrorificas.TabIndex = 0;
            this.lblMujeresTerrorificas.Text = "0";
            // 
            // groupBox11
            // 
            this.groupBox11.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox11.Controls.Add(this.lblAlquilerCaro);
            this.groupBox11.Location = new System.Drawing.Point(8, 296);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(198, 96);
            this.groupBox11.TabIndex = 3;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Alquiler Mas Caro";
            // 
            // lblAlquilerCaro
            // 
            this.lblAlquilerCaro.AutoSize = true;
            this.lblAlquilerCaro.Location = new System.Drawing.Point(46, 28);
            this.lblAlquilerCaro.Name = "lblAlquilerCaro";
            this.lblAlquilerCaro.Size = new System.Drawing.Size(10, 13);
            this.lblAlquilerCaro.TabIndex = 0;
            this.lblAlquilerCaro.Text = "-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 406);
            this.Controls.Add(this.groupBox11);
            this.Controls.Add(this.groupBox10);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Video Club";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCodigoSocio;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbtOtro;
        private System.Windows.Forms.RadioButton rbtFemenino;
        private System.Windows.Forms.RadioButton rbtMasculino;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker dtpFechaAlq;
        private System.Windows.Forms.TextBox txtMontoAlq;
        private System.Windows.Forms.TextBox txtNumeroAlquiler;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cboGenero;
        private System.Windows.Forms.TextBox txtTituloPeli;
        private System.Windows.Forms.TextBox txtCodigoPeli;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label lblTerror;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label lblFiccion;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label lblComedia;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label lblRecaudacionPromedio;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Label lblPorcVarones;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.Label lblMujeresTerrorificas;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.Label lblAlquilerCaro;
    }
}

