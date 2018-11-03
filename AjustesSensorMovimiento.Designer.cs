namespace Sistema_de_Seguridad_OjoGuardián
{
    partial class AjustesSensorMovimiento
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
            this.panelSensorDeMovimiento = new System.Windows.Forms.Panel();
            this.checkBoxResaltar = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.trackBarSensibilidad = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBoxActivado = new System.Windows.Forms.CheckBox();
            this.panelSensorDeMovimiento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSensibilidad)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSensorDeMovimiento
            // 
            this.panelSensorDeMovimiento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelSensorDeMovimiento.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelSensorDeMovimiento.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelSensorDeMovimiento.Controls.Add(this.checkBoxActivado);
            this.panelSensorDeMovimiento.Controls.Add(this.label4);
            this.panelSensorDeMovimiento.Controls.Add(this.checkBoxResaltar);
            this.panelSensorDeMovimiento.Controls.Add(this.label3);
            this.panelSensorDeMovimiento.Controls.Add(this.btnGuardar);
            this.panelSensorDeMovimiento.Controls.Add(this.btnReset);
            this.panelSensorDeMovimiento.Controls.Add(this.trackBarSensibilidad);
            this.panelSensorDeMovimiento.Controls.Add(this.label2);
            this.panelSensorDeMovimiento.Controls.Add(this.label1);
            this.panelSensorDeMovimiento.Location = new System.Drawing.Point(1, 2);
            this.panelSensorDeMovimiento.Name = "panelSensorDeMovimiento";
            this.panelSensorDeMovimiento.Size = new System.Drawing.Size(549, 263);
            this.panelSensorDeMovimiento.TabIndex = 2;
            this.panelSensorDeMovimiento.Tag = "";
            // 
            // checkBoxResaltar
            // 
            this.checkBoxResaltar.AutoSize = true;
            this.checkBoxResaltar.Location = new System.Drawing.Point(490, 169);
            this.checkBoxResaltar.Name = "checkBoxResaltar";
            this.checkBoxResaltar.Size = new System.Drawing.Size(15, 14);
            this.checkBoxResaltar.TabIndex = 6;
            this.checkBoxResaltar.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(257, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Resaltar áreas de movimiento";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(349, 214);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(156, 23);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "Guardar cambios";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(43, 214);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(156, 22);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Configuración por defecto";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // trackBarSensibilidad
            // 
            this.trackBarSensibilidad.Location = new System.Drawing.Point(201, 107);
            this.trackBarSensibilidad.Minimum = 1;
            this.trackBarSensibilidad.Name = "trackBarSensibilidad";
            this.trackBarSensibilidad.Size = new System.Drawing.Size(304, 45);
            this.trackBarSensibilidad.TabIndex = 2;
            this.trackBarSensibilidad.Tag = "0";
            this.trackBarSensibilidad.Value = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sensibilidad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(106, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ajustes del sensor de movimiento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(39, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Activado";
            // 
            // checkBoxActivado
            // 
            this.checkBoxActivado.AutoSize = true;
            this.checkBoxActivado.Location = new System.Drawing.Point(490, 68);
            this.checkBoxActivado.Name = "checkBoxActivado";
            this.checkBoxActivado.Size = new System.Drawing.Size(15, 14);
            this.checkBoxActivado.TabIndex = 8;
            this.checkBoxActivado.UseVisualStyleBackColor = true;
            // 
            // AjustesSensorMovimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 263);
            this.Controls.Add(this.panelSensorDeMovimiento);
            this.MaximizeBox = false;
            this.Name = "AjustesSensorMovimiento";
            this.Text = "Configurar Sensor de Movimiento";
            this.panelSensorDeMovimiento.ResumeLayout(false);
            this.panelSensorDeMovimiento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSensibilidad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSensorDeMovimiento;
        private System.Windows.Forms.CheckBox checkBoxResaltar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TrackBar trackBarSensibilidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxActivado;
        private System.Windows.Forms.Label label4;
    }
}