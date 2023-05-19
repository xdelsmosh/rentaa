namespace BancaRota
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnNuevoESTEBAN = new System.Windows.Forms.Button();
            this.btnCrearESTEBAN = new System.Windows.Forms.Button();
            this.rbCorrienteesteban = new System.Windows.Forms.RadioButton();
            this.rbVistaESTEBAN = new System.Windows.Forms.RadioButton();
            this.txtNomCliente = new System.Windows.Forms.TextBox();
            this.txtNumeroCuenta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbTransacciones = new System.Windows.Forms.GroupBox();
            this.btnConsultaESTEBAN = new System.Windows.Forms.Button();
            this.lbTransaccionesesteban = new System.Windows.Forms.ListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnRetiraresteban = new System.Windows.Forms.Button();
            this.txtRetiro = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnDepositarESTEBAN = new System.Windows.Forms.Button();
            this.txtDeposito = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.gbTransacciones.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnNuevoESTEBAN);
            this.groupBox1.Controls.Add(this.btnCrearESTEBAN);
            this.groupBox1.Controls.Add(this.txtNumeroCuenta);
            this.groupBox1.Controls.Add(this.rbCorrienteesteban);
            this.groupBox1.Controls.Add(this.rbVistaESTEBAN);
            this.groupBox1.Controls.Add(this.txtNomCliente);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(775, 159);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Cliente";
            // 
            // btnNuevoESTEBAN
            // 
            this.btnNuevoESTEBAN.BackColor = System.Drawing.SystemColors.Info;
            this.btnNuevoESTEBAN.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNuevoESTEBAN.Image = global::BancaRota.Properties.Resources._430088_circle_close_delete_remove_icon;
            this.btnNuevoESTEBAN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevoESTEBAN.Location = new System.Drawing.Point(586, 96);
            this.btnNuevoESTEBAN.Name = "btnNuevoESTEBAN";
            this.btnNuevoESTEBAN.Size = new System.Drawing.Size(174, 51);
            this.btnNuevoESTEBAN.TabIndex = 8;
            this.btnNuevoESTEBAN.Text = "Nuevo";
            this.btnNuevoESTEBAN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevoESTEBAN.UseVisualStyleBackColor = false;
            this.btnNuevoESTEBAN.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnCrearESTEBAN
            // 
            this.btnCrearESTEBAN.BackColor = System.Drawing.SystemColors.Info;
            this.btnCrearESTEBAN.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCrearESTEBAN.Image = global::BancaRota.Properties.Resources._1486485587_add_create_new_maths_math_signs_plus_81172;
            this.btnCrearESTEBAN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCrearESTEBAN.Location = new System.Drawing.Point(586, 23);
            this.btnCrearESTEBAN.Name = "btnCrearESTEBAN";
            this.btnCrearESTEBAN.Size = new System.Drawing.Size(174, 51);
            this.btnCrearESTEBAN.TabIndex = 7;
            this.btnCrearESTEBAN.Text = "Crear";
            this.btnCrearESTEBAN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCrearESTEBAN.UseVisualStyleBackColor = false;
            this.btnCrearESTEBAN.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // rbCorrienteesteban
            // 
            this.rbCorrienteesteban.AutoSize = true;
            this.rbCorrienteesteban.Location = new System.Drawing.Point(439, 110);
            this.rbCorrienteesteban.Name = "rbCorrienteesteban";
            this.rbCorrienteesteban.Size = new System.Drawing.Size(35, 22);
            this.rbCorrienteesteban.TabIndex = 6;
            this.rbCorrienteesteban.TabStop = true;
            this.rbCorrienteesteban.Text = "2";
            this.rbCorrienteesteban.UseVisualStyleBackColor = true;
            // 
            // rbVistaESTEBAN
            // 
            this.rbVistaESTEBAN.AutoSize = true;
            this.rbVistaESTEBAN.Location = new System.Drawing.Point(169, 112);
            this.rbVistaESTEBAN.Name = "rbVistaESTEBAN";
            this.rbVistaESTEBAN.Size = new System.Drawing.Size(35, 22);
            this.rbVistaESTEBAN.TabIndex = 5;
            this.rbVistaESTEBAN.TabStop = true;
            this.rbVistaESTEBAN.Text = "1";
            this.rbVistaESTEBAN.UseVisualStyleBackColor = true;
            this.rbVistaESTEBAN.CheckedChanged += new System.EventHandler(this.rbVista_CheckedChanged);
            // 
            // txtNomCliente
            // 
            this.txtNomCliente.Location = new System.Drawing.Point(169, 29);
            this.txtNomCliente.Name = "txtNomCliente";
            this.txtNomCliente.Size = new System.Drawing.Size(366, 24);
            this.txtNomCliente.TabIndex = 4;
            // 
            // txtNumeroCuenta
            // 
            this.txtNumeroCuenta.Location = new System.Drawing.Point(169, 70);
            this.txtNumeroCuenta.Name = "txtNumeroCuenta";
            this.txtNumeroCuenta.Size = new System.Drawing.Size(366, 24);
            this.txtNumeroCuenta.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ubicación Vivienda";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre Inquilino";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "N° Vivienda";
            // 
            // gbTransacciones
            // 
            this.gbTransacciones.Controls.Add(this.btnConsultaESTEBAN);
            this.gbTransacciones.Controls.Add(this.lbTransaccionesesteban);
            this.gbTransacciones.Controls.Add(this.groupBox4);
            this.gbTransacciones.Controls.Add(this.groupBox3);
            this.gbTransacciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTransacciones.Location = new System.Drawing.Point(12, 191);
            this.gbTransacciones.Name = "gbTransacciones";
            this.gbTransacciones.Size = new System.Drawing.Size(775, 247);
            this.gbTransacciones.TabIndex = 1;
            this.gbTransacciones.TabStop = false;
            this.gbTransacciones.Text = "Estado renta";
            // 
            // btnConsultaESTEBAN
            // 
            this.btnConsultaESTEBAN.BackColor = System.Drawing.Color.Honeydew;
            this.btnConsultaESTEBAN.Location = new System.Drawing.Point(355, 184);
            this.btnConsultaESTEBAN.Name = "btnConsultaESTEBAN";
            this.btnConsultaESTEBAN.Size = new System.Drawing.Size(378, 51);
            this.btnConsultaESTEBAN.TabIndex = 5;
            this.btnConsultaESTEBAN.Text = "Consultar estado de cuenta";
            this.btnConsultaESTEBAN.UseVisualStyleBackColor = false;
            this.btnConsultaESTEBAN.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // lbTransaccionesesteban
            // 
            this.lbTransaccionesesteban.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTransaccionesesteban.FormattingEnabled = true;
            this.lbTransaccionesesteban.HorizontalScrollbar = true;
            this.lbTransaccionesesteban.ItemHeight = 15;
            this.lbTransaccionesesteban.Location = new System.Drawing.Point(314, 23);
            this.lbTransaccionesesteban.Name = "lbTransaccionesesteban";
            this.lbTransaccionesesteban.Size = new System.Drawing.Size(455, 154);
            this.lbTransaccionesesteban.TabIndex = 4;
            this.lbTransaccionesesteban.SelectedIndexChanged += new System.EventHandler(this.lbTransacciones_SelectedIndexChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnRetiraresteban);
            this.groupBox4.Controls.Add(this.txtRetiro);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(10, 141);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(277, 100);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Pago";
            // 
            // btnRetiraresteban
            // 
            this.btnRetiraresteban.Location = new System.Drawing.Point(160, 71);
            this.btnRetiraresteban.Name = "btnRetiraresteban";
            this.btnRetiraresteban.Size = new System.Drawing.Size(111, 23);
            this.btnRetiraresteban.TabIndex = 2;
            this.btnRetiraresteban.Text = "Registrar pago renta";
            this.btnRetiraresteban.UseVisualStyleBackColor = true;
            this.btnRetiraresteban.Click += new System.EventHandler(this.btnRetirar_Click);
            // 
            // txtRetiro
            // 
            this.txtRetiro.Location = new System.Drawing.Point(106, 35);
            this.txtRetiro.Name = "txtRetiro";
            this.txtRetiro.Size = new System.Drawing.Size(165, 21);
            this.txtRetiro.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Monto $";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnDepositarESTEBAN);
            this.groupBox3.Controls.Add(this.txtDeposito);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(10, 23);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(277, 100);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Deuda";
            // 
            // btnDepositarESTEBAN
            // 
            this.btnDepositarESTEBAN.Location = new System.Drawing.Point(160, 71);
            this.btnDepositarESTEBAN.Name = "btnDepositarESTEBAN";
            this.btnDepositarESTEBAN.Size = new System.Drawing.Size(111, 23);
            this.btnDepositarESTEBAN.TabIndex = 2;
            this.btnDepositarESTEBAN.Text = "Registar Renta Vencida";
            this.btnDepositarESTEBAN.UseVisualStyleBackColor = true;
            this.btnDepositarESTEBAN.Click += new System.EventHandler(this.btnDepositar_Click);
            // 
            // txtDeposito
            // 
            this.txtDeposito.Location = new System.Drawing.Point(106, 35);
            this.txtDeposito.MaxLength = 6;
            this.txtDeposito.Name = "txtDeposito";
            this.txtDeposito.Size = new System.Drawing.Size(165, 21);
            this.txtDeposito.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Monto $";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbTransacciones);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.Blue;
            this.Name = "Form1";
            this.Text = "Banca Rota";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbTransacciones.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbCorrienteesteban;
        private System.Windows.Forms.RadioButton rbVistaESTEBAN;
        private System.Windows.Forms.TextBox txtNomCliente;
        private System.Windows.Forms.TextBox txtNumeroCuenta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNuevoESTEBAN;
        private System.Windows.Forms.Button btnCrearESTEBAN;
        private System.Windows.Forms.GroupBox gbTransacciones;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnRetiraresteban;
        private System.Windows.Forms.TextBox txtRetiro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnDepositarESTEBAN;
        private System.Windows.Forms.TextBox txtDeposito;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnConsultaESTEBAN;
        private System.Windows.Forms.ListBox lbTransaccionesesteban;
    }
}

