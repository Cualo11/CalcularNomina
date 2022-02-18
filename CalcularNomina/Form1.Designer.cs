
namespace CalcularNomina
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAlmacenarRegistro = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblIdentificacion = new System.Windows.Forms.Label();
            this.lblAsignacionSaldoDia = new System.Windows.Forms.Label();
            this.lblDiasLaborados = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDiasLaborados = new System.Windows.Forms.TextBox();
            this.txtAsignacionSaldoDia = new System.Windows.Forms.TextBox();
            this.txtIdentificacion = new System.Windows.Forms.TextBox();
            this.btnCalcularSalario = new System.Windows.Forms.Button();
            this.lblTotalVevengado = new System.Windows.Forms.Label();
            this.txtTotalDevengado = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.error1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.error1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(425, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calcular Nomina del Trabajador";
            // 
            // btnAlmacenarRegistro
            // 
            this.btnAlmacenarRegistro.Location = new System.Drawing.Point(29, 162);
            this.btnAlmacenarRegistro.Name = "btnAlmacenarRegistro";
            this.btnAlmacenarRegistro.Size = new System.Drawing.Size(197, 23);
            this.btnAlmacenarRegistro.TabIndex = 1;
            this.btnAlmacenarRegistro.Text = "Guardar el registro del emplado";
            this.btnAlmacenarRegistro.UseVisualStyleBackColor = true;
            this.btnAlmacenarRegistro.Click += new System.EventHandler(this.btnAlmacenarRegistro_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(12, 44);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre";
            // 
            // lblIdentificacion
            // 
            this.lblIdentificacion.AutoSize = true;
            this.lblIdentificacion.Location = new System.Drawing.Point(12, 70);
            this.lblIdentificacion.Name = "lblIdentificacion";
            this.lblIdentificacion.Size = new System.Drawing.Size(70, 13);
            this.lblIdentificacion.TabIndex = 3;
            this.lblIdentificacion.Text = "Identificacion";
            // 
            // lblAsignacionSaldoDia
            // 
            this.lblAsignacionSaldoDia.AutoSize = true;
            this.lblAsignacionSaldoDia.Location = new System.Drawing.Point(12, 94);
            this.lblAsignacionSaldoDia.Name = "lblAsignacionSaldoDia";
            this.lblAsignacionSaldoDia.Size = new System.Drawing.Size(108, 13);
            this.lblAsignacionSaldoDia.TabIndex = 4;
            this.lblAsignacionSaldoDia.Text = "Asignacion Saldo Dia";
            // 
            // lblDiasLaborados
            // 
            this.lblDiasLaborados.AutoSize = true;
            this.lblDiasLaborados.Location = new System.Drawing.Point(12, 121);
            this.lblDiasLaborados.Name = "lblDiasLaborados";
            this.lblDiasLaborados.Size = new System.Drawing.Size(81, 13);
            this.lblDiasLaborados.TabIndex = 5;
            this.lblDiasLaborados.Text = "Dias Laborados";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(126, 34);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 6;
            this.txtNombre.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtDiasLaborados
            // 
            this.txtDiasLaborados.Location = new System.Drawing.Point(126, 118);
            this.txtDiasLaborados.Name = "txtDiasLaborados";
            this.txtDiasLaborados.Size = new System.Drawing.Size(100, 20);
            this.txtDiasLaborados.TabIndex = 7;
            // 
            // txtAsignacionSaldoDia
            // 
            this.txtAsignacionSaldoDia.Location = new System.Drawing.Point(126, 94);
            this.txtAsignacionSaldoDia.Name = "txtAsignacionSaldoDia";
            this.txtAsignacionSaldoDia.Size = new System.Drawing.Size(100, 20);
            this.txtAsignacionSaldoDia.TabIndex = 8;
            // 
            // txtIdentificacion
            // 
            this.txtIdentificacion.Location = new System.Drawing.Point(126, 63);
            this.txtIdentificacion.Name = "txtIdentificacion";
            this.txtIdentificacion.Size = new System.Drawing.Size(100, 20);
            this.txtIdentificacion.TabIndex = 9;
            // 
            // btnCalcularSalario
            // 
            this.btnCalcularSalario.Location = new System.Drawing.Point(29, 191);
            this.btnCalcularSalario.Name = "btnCalcularSalario";
            this.btnCalcularSalario.Size = new System.Drawing.Size(197, 23);
            this.btnCalcularSalario.TabIndex = 10;
            this.btnCalcularSalario.Text = "Calcular Salario";
            this.btnCalcularSalario.UseVisualStyleBackColor = true;
            this.btnCalcularSalario.Click += new System.EventHandler(this.btnCalcularSalario_Click);
            // 
            // lblTotalVevengado
            // 
            this.lblTotalVevengado.AutoSize = true;
            this.lblTotalVevengado.Location = new System.Drawing.Point(26, 226);
            this.lblTotalVevengado.Name = "lblTotalVevengado";
            this.lblTotalVevengado.Size = new System.Drawing.Size(117, 13);
            this.lblTotalVevengado.TabIndex = 11;
            this.lblTotalVevengado.Text = "Valor Total Devengado";
            // 
            // txtTotalDevengado
            // 
            this.txtTotalDevengado.Location = new System.Drawing.Point(163, 220);
            this.txtTotalDevengado.Name = "txtTotalDevengado";
            this.txtTotalDevengado.Size = new System.Drawing.Size(100, 20);
            this.txtTotalDevengado.TabIndex = 12;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(210, 251);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 13;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(29, 251);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 14;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // error1
            // 
            this.error1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 286);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.txtTotalDevengado);
            this.Controls.Add(this.lblTotalVevengado);
            this.Controls.Add(this.btnCalcularSalario);
            this.Controls.Add(this.txtIdentificacion);
            this.Controls.Add(this.txtAsignacionSaldoDia);
            this.Controls.Add(this.txtDiasLaborados);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblDiasLaborados);
            this.Controls.Add(this.lblAsignacionSaldoDia);
            this.Controls.Add(this.lblIdentificacion);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btnAlmacenarRegistro);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.error1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAlmacenarRegistro;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblIdentificacion;
        private System.Windows.Forms.Label lblAsignacionSaldoDia;
        private System.Windows.Forms.Label lblDiasLaborados;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDiasLaborados;
        private System.Windows.Forms.TextBox txtAsignacionSaldoDia;
        private System.Windows.Forms.TextBox txtIdentificacion;
        private System.Windows.Forms.Button btnCalcularSalario;
        private System.Windows.Forms.Label lblTotalVevengado;
        private System.Windows.Forms.TextBox txtTotalDevengado;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.ErrorProvider error1;
    }
}

