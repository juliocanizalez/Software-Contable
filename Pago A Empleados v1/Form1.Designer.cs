﻿namespace SistemaDePagoEmpleados
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtSalarioBruto = new System.Windows.Forms.TextBox();
            this.txtBonificaciones = new System.Windows.Forms.TextBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCalcularSalario = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.resultado = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.cmbMes = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnGenerarBoleta = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtsalarioNeto = new System.Windows.Forms.TextBox();
            this.deducciones = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDeducciones = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtRenta = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAfp = new System.Windows.Forms.TextBox();
            this.txtIsss = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTotalIngresos = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.resultado.SuspendLayout();
            this.deducciones.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.label1.Location = new System.Drawing.Point(327, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cálculo Salarial";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtSalarioBruto
            // 
            this.txtSalarioBruto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSalarioBruto.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalarioBruto.Location = new System.Drawing.Point(144, 24);
            this.txtSalarioBruto.Margin = new System.Windows.Forms.Padding(2);
            this.txtSalarioBruto.Name = "txtSalarioBruto";
            this.txtSalarioBruto.Size = new System.Drawing.Size(90, 25);
            this.txtSalarioBruto.TabIndex = 2;
            this.txtSalarioBruto.TextChanged += new System.EventHandler(this.txtSalarioBruto_TextChanged);
            this.txtSalarioBruto.Leave += new System.EventHandler(this.txtSalarioBruto_Leave);
            // 
            // txtBonificaciones
            // 
            this.txtBonificaciones.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBonificaciones.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBonificaciones.Location = new System.Drawing.Point(144, 63);
            this.txtBonificaciones.Margin = new System.Windows.Forms.Padding(2);
            this.txtBonificaciones.Name = "txtBonificaciones";
            this.txtBonificaciones.Size = new System.Drawing.Size(90, 25);
            this.txtBonificaciones.TabIndex = 3;
            this.txtBonificaciones.Leave += new System.EventHandler(this.txtBonificaciones_Leave);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(712, 9);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(69, 26);
            this.btnCerrar.TabIndex = 9;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(790, 43);
            this.panel1.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Salario Bruto:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 67);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Bonificaciones:";
            // 
            // btnCalcularSalario
            // 
            this.btnCalcularSalario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCalcularSalario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.btnCalcularSalario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalcularSalario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcularSalario.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularSalario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCalcularSalario.Location = new System.Drawing.Point(94, 154);
            this.btnCalcularSalario.Margin = new System.Windows.Forms.Padding(2);
            this.btnCalcularSalario.Name = "btnCalcularSalario";
            this.btnCalcularSalario.Size = new System.Drawing.Size(80, 29);
            this.btnCalcularSalario.TabIndex = 13;
            this.btnCalcularSalario.Text = "calcular";
            this.btnCalcularSalario.UseVisualStyleBackColor = false;
            this.btnCalcularSalario.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.resultado);
            this.panel2.Controls.Add(this.deducciones);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 43);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(790, 439);
            this.panel2.TabIndex = 14;
            // 
            // resultado
            // 
            this.resultado.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.resultado.Controls.Add(this.label12);
            this.resultado.Controls.Add(this.txtCargo);
            this.resultado.Controls.Add(this.cmbMes);
            this.resultado.Controls.Add(this.label11);
            this.resultado.Controls.Add(this.label10);
            this.resultado.Controls.Add(this.txtNombre);
            this.resultado.Controls.Add(this.btnLimpiar);
            this.resultado.Controls.Add(this.btnGenerarBoleta);
            this.resultado.Controls.Add(this.label6);
            this.resultado.Controls.Add(this.txtsalarioNeto);
            this.resultado.Location = new System.Drawing.Point(150, 249);
            this.resultado.Margin = new System.Windows.Forms.Padding(2);
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(458, 179);
            this.resultado.TabIndex = 30;
            this.resultado.Visible = false;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(30, 99);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 20);
            this.label12.TabIndex = 34;
            this.label12.Text = "Cargo:";
            // 
            // txtCargo
            // 
            this.txtCargo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCargo.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCargo.Location = new System.Drawing.Point(137, 96);
            this.txtCargo.Margin = new System.Windows.Forms.Padding(2);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(294, 25);
            this.txtCargo.TabIndex = 33;
            // 
            // cmbMes
            // 
            this.cmbMes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbMes.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMes.FormattingEnabled = true;
            this.cmbMes.Items.AddRange(new object[] {
            "Enero",
            "Febrero",
            "Marzo",
            "Abril",
            "Mayo",
            "Junio",
            "Julio",
            "Agosto",
            "Septiembre",
            "Octubre",
            "Noviembre",
            "Diciembre"});
            this.cmbMes.Location = new System.Drawing.Point(287, 16);
            this.cmbMes.Margin = new System.Windows.Forms.Padding(2);
            this.cmbMes.Name = "cmbMes";
            this.cmbMes.Size = new System.Drawing.Size(144, 27);
            this.cmbMes.TabIndex = 32;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(236, 20);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 20);
            this.label11.TabIndex = 31;
            this.label11.Text = "Mes:";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(30, 61);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 20);
            this.label10.TabIndex = 29;
            this.label10.Text = "Empleado:";
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNombre.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(137, 58);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(294, 25);
            this.txtNombre.TabIndex = 28;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLimpiar.Location = new System.Drawing.Point(287, 136);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(80, 29);
            this.btnLimpiar.TabIndex = 27;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnGenerarBoleta
            // 
            this.btnGenerarBoleta.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnGenerarBoleta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.btnGenerarBoleta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerarBoleta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerarBoleta.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarBoleta.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGenerarBoleta.Location = new System.Drawing.Point(88, 136);
            this.btnGenerarBoleta.Margin = new System.Windows.Forms.Padding(2);
            this.btnGenerarBoleta.Name = "btnGenerarBoleta";
            this.btnGenerarBoleta.Size = new System.Drawing.Size(170, 29);
            this.btnGenerarBoleta.TabIndex = 26;
            this.btnGenerarBoleta.Text = "Generar Boleta";
            this.btnGenerarBoleta.UseVisualStyleBackColor = false;
            this.btnGenerarBoleta.Click += new System.EventHandler(this.btnGenerarBoleta_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(30, 20);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 18);
            this.label6.TabIndex = 21;
            this.label6.Text = "Salario Neto:";
            // 
            // txtsalarioNeto
            // 
            this.txtsalarioNeto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtsalarioNeto.Enabled = false;
            this.txtsalarioNeto.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsalarioNeto.Location = new System.Drawing.Point(137, 18);
            this.txtsalarioNeto.Margin = new System.Windows.Forms.Padding(2);
            this.txtsalarioNeto.Name = "txtsalarioNeto";
            this.txtsalarioNeto.Size = new System.Drawing.Size(95, 25);
            this.txtsalarioNeto.TabIndex = 19;
            // 
            // deducciones
            // 
            this.deducciones.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.deducciones.Controls.Add(this.label8);
            this.deducciones.Controls.Add(this.txtDeducciones);
            this.deducciones.Controls.Add(this.label7);
            this.deducciones.Controls.Add(this.txtRenta);
            this.deducciones.Controls.Add(this.label4);
            this.deducciones.Controls.Add(this.label5);
            this.deducciones.Controls.Add(this.txtAfp);
            this.deducciones.Controls.Add(this.txtIsss);
            this.deducciones.Location = new System.Drawing.Point(378, 40);
            this.deducciones.Margin = new System.Windows.Forms.Padding(2);
            this.deducciones.Name = "deducciones";
            this.deducciones.Size = new System.Drawing.Size(270, 195);
            this.deducciones.TabIndex = 29;
            this.deducciones.Visible = false;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(15, 142);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(149, 18);
            this.label8.TabIndex = 23;
            this.label8.Text = "Total Deducciones:";
            // 
            // txtDeducciones
            // 
            this.txtDeducciones.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDeducciones.Enabled = false;
            this.txtDeducciones.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeducciones.Location = new System.Drawing.Point(164, 139);
            this.txtDeducciones.Margin = new System.Windows.Forms.Padding(2);
            this.txtDeducciones.Name = "txtDeducciones";
            this.txtDeducciones.Size = new System.Drawing.Size(90, 25);
            this.txtDeducciones.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(91, 103);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 20);
            this.label7.TabIndex = 20;
            this.label7.Text = "Renta:";
            // 
            // txtRenta
            // 
            this.txtRenta.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtRenta.Enabled = false;
            this.txtRenta.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRenta.Location = new System.Drawing.Point(164, 100);
            this.txtRenta.Margin = new System.Windows.Forms.Padding(2);
            this.txtRenta.Name = "txtRenta";
            this.txtRenta.Size = new System.Drawing.Size(90, 25);
            this.txtRenta.TabIndex = 18;
            this.txtRenta.TextChanged += new System.EventHandler(this.txtRenta_TextChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(109, 63);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "ISSS:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(107, 28);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "AFP:";
            // 
            // txtAfp
            // 
            this.txtAfp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtAfp.Enabled = false;
            this.txtAfp.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAfp.Location = new System.Drawing.Point(164, 24);
            this.txtAfp.Margin = new System.Windows.Forms.Padding(2);
            this.txtAfp.Name = "txtAfp";
            this.txtAfp.Size = new System.Drawing.Size(90, 25);
            this.txtAfp.TabIndex = 14;
            this.txtAfp.TextChanged += new System.EventHandler(this.txtAfp_TextChanged);
            // 
            // txtIsss
            // 
            this.txtIsss.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtIsss.Enabled = false;
            this.txtIsss.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIsss.Location = new System.Drawing.Point(164, 60);
            this.txtIsss.Margin = new System.Windows.Forms.Padding(2);
            this.txtIsss.Name = "txtIsss";
            this.txtIsss.Size = new System.Drawing.Size(90, 25);
            this.txtIsss.TabIndex = 15;
            this.txtIsss.TextChanged += new System.EventHandler(this.txtIsss_TextChanged);
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel3.Controls.Add(this.btnCalcularSalario);
            this.panel3.Controls.Add(this.txtBonificaciones);
            this.panel3.Controls.Add(this.txtSalarioBruto);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.txtTotalIngresos);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(73, 40);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(260, 195);
            this.panel3.TabIndex = 28;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(28, 110);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 20);
            this.label9.TabIndex = 25;
            this.label9.Text = "Total Ingresos:";
            // 
            // txtTotalIngresos
            // 
            this.txtTotalIngresos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTotalIngresos.Enabled = false;
            this.txtTotalIngresos.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalIngresos.Location = new System.Drawing.Point(144, 105);
            this.txtTotalIngresos.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotalIngresos.Name = "txtTotalIngresos";
            this.txtTotalIngresos.Size = new System.Drawing.Size(90, 25);
            this.txtTotalIngresos.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(790, 482);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.resultado.ResumeLayout(false);
            this.resultado.PerformLayout();
            this.deducciones.ResumeLayout(false);
            this.deducciones.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSalarioBruto;
        private System.Windows.Forms.TextBox txtBonificaciones;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCalcularSalario;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAfp;
        private System.Windows.Forms.TextBox txtIsss;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDeducciones;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtRenta;
        private System.Windows.Forms.TextBox txtsalarioNeto;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnGenerarBoleta;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTotalIngresos;
        private System.Windows.Forms.Panel deducciones;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel resultado;
        private System.Windows.Forms.ComboBox cmbMes;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtCargo;
    }
}