namespace Sistema_de_Seguridad_OjoGuardián
{
    partial class VentanaPrincipal
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
            this.barraMenu = new System.Windows.Forms.MenuStrip();
            this.herramientasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iniciarVigilanciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verCámarasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirCarpetaDeGrabacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cámarasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sensorDeMovimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conexiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notificacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grabaciónDeVideoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.soporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeOjoGuardiánToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.btnParar = new System.Windows.Forms.Button();
            this.videoSourcePlayer1 = new AForge.Controls.VideoSourcePlayer();
            this.btnVer = new System.Windows.Forms.Button();
            this.comboCamaras = new System.Windows.Forms.ComboBox();
            this.labelTeclaPresionada = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCantidadCamaras = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.barraMenu.SuspendLayout();
            this.panelPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // barraMenu
            // 
            this.barraMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.herramientasToolStripMenuItem,
            this.opcionesToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.barraMenu.Location = new System.Drawing.Point(0, 0);
            this.barraMenu.Name = "barraMenu";
            this.barraMenu.Size = new System.Drawing.Size(842, 24);
            this.barraMenu.TabIndex = 0;
            this.barraMenu.Text = "menuStrip1";
            this.barraMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.barraMenu_ItemClicked);
            // 
            // herramientasToolStripMenuItem
            // 
            this.herramientasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iniciarVigilanciaToolStripMenuItem,
            this.verCámarasToolStripMenuItem,
            this.abrirCarpetaDeGrabacionesToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.herramientasToolStripMenuItem.Name = "herramientasToolStripMenuItem";
            this.herramientasToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.herramientasToolStripMenuItem.Text = "Herramientas";
            // 
            // iniciarVigilanciaToolStripMenuItem
            // 
            this.iniciarVigilanciaToolStripMenuItem.Name = "iniciarVigilanciaToolStripMenuItem";
            this.iniciarVigilanciaToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.iniciarVigilanciaToolStripMenuItem.Text = "Iniciar vigilancia";
            this.iniciarVigilanciaToolStripMenuItem.Click += new System.EventHandler(this.iniciarVigilanciaToolStripMenuItem_Click);
            // 
            // verCámarasToolStripMenuItem
            // 
            this.verCámarasToolStripMenuItem.Name = "verCámarasToolStripMenuItem";
            this.verCámarasToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.verCámarasToolStripMenuItem.Text = "Ver cámaras";
            this.verCámarasToolStripMenuItem.Click += new System.EventHandler(this.verCámarasToolStripMenuItem_Click);
            // 
            // abrirCarpetaDeGrabacionesToolStripMenuItem
            // 
            this.abrirCarpetaDeGrabacionesToolStripMenuItem.Name = "abrirCarpetaDeGrabacionesToolStripMenuItem";
            this.abrirCarpetaDeGrabacionesToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.abrirCarpetaDeGrabacionesToolStripMenuItem.Text = "Abrir carpeta de grabaciones";
            this.abrirCarpetaDeGrabacionesToolStripMenuItem.Click += new System.EventHandler(this.abrirCarpetaDeGrabacionesToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.salirToolStripMenuItem.Text = "Salir ";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cámarasToolStripMenuItem,
            this.sensorDeMovimientoToolStripMenuItem,
            this.conexiónToolStripMenuItem,
            this.notificacionesToolStripMenuItem,
            this.grabaciónDeVideoToolStripMenuItem});
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.opcionesToolStripMenuItem.Text = "Ajustes";
            // 
            // cámarasToolStripMenuItem
            // 
            this.cámarasToolStripMenuItem.Name = "cámarasToolStripMenuItem";
            this.cámarasToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.cámarasToolStripMenuItem.Text = "Cámaras";
            // 
            // sensorDeMovimientoToolStripMenuItem
            // 
            this.sensorDeMovimientoToolStripMenuItem.Name = "sensorDeMovimientoToolStripMenuItem";
            this.sensorDeMovimientoToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.sensorDeMovimientoToolStripMenuItem.Text = "Sensor de Movimiento";
            this.sensorDeMovimientoToolStripMenuItem.Click += new System.EventHandler(this.sensorDeMovimientoToolStripMenuItem_Click);
            // 
            // conexiónToolStripMenuItem
            // 
            this.conexiónToolStripMenuItem.Name = "conexiónToolStripMenuItem";
            this.conexiónToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.conexiónToolStripMenuItem.Text = "Conexión";
            // 
            // notificacionesToolStripMenuItem
            // 
            this.notificacionesToolStripMenuItem.Name = "notificacionesToolStripMenuItem";
            this.notificacionesToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.notificacionesToolStripMenuItem.Text = "Notificaciones";
            // 
            // grabaciónDeVideoToolStripMenuItem
            // 
            this.grabaciónDeVideoToolStripMenuItem.Name = "grabaciónDeVideoToolStripMenuItem";
            this.grabaciónDeVideoToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.grabaciónDeVideoToolStripMenuItem.Text = "Grabación de Video";
            this.grabaciónDeVideoToolStripMenuItem.Click += new System.EventHandler(this.grabaciónDeVideoToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.soporteToolStripMenuItem,
            this.acercaDeOjoGuardiánToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // soporteToolStripMenuItem
            // 
            this.soporteToolStripMenuItem.Name = "soporteToolStripMenuItem";
            this.soporteToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.soporteToolStripMenuItem.Text = "Soporte";
            // 
            // acercaDeOjoGuardiánToolStripMenuItem
            // 
            this.acercaDeOjoGuardiánToolStripMenuItem.Name = "acercaDeOjoGuardiánToolStripMenuItem";
            this.acercaDeOjoGuardiánToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.acercaDeOjoGuardiánToolStripMenuItem.Text = "Acerca De OjoGuardián";
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelPrincipal.Controls.Add(this.btnParar);
            this.panelPrincipal.Controls.Add(this.videoSourcePlayer1);
            this.panelPrincipal.Controls.Add(this.btnVer);
            this.panelPrincipal.Controls.Add(this.comboCamaras);
            this.panelPrincipal.Controls.Add(this.labelTeclaPresionada);
            this.panelPrincipal.Controls.Add(this.label1);
            this.panelPrincipal.Controls.Add(this.lblCantidadCamaras);
            this.panelPrincipal.Controls.Add(this.label4);
            this.panelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrincipal.Location = new System.Drawing.Point(0, 24);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(842, 329);
            this.panelPrincipal.TabIndex = 8;
            this.panelPrincipal.Paint += new System.Windows.Forms.PaintEventHandler(this.panelPrincipal_Paint_1);
            // 
            // btnParar
            // 
            this.btnParar.BackColor = System.Drawing.Color.Yellow;
            this.btnParar.Location = new System.Drawing.Point(732, 18);
            this.btnParar.Name = "btnParar";
            this.btnParar.Size = new System.Drawing.Size(78, 21);
            this.btnParar.TabIndex = 7;
            this.btnParar.Text = "Parar";
            this.btnParar.UseVisualStyleBackColor = false;
            this.btnParar.Click += new System.EventHandler(this.btnParar_Click);
            // 
            // videoSourcePlayer1
            // 
            this.videoSourcePlayer1.Location = new System.Drawing.Point(427, 53);
            this.videoSourcePlayer1.Name = "videoSourcePlayer1";
            this.videoSourcePlayer1.Size = new System.Drawing.Size(401, 249);
            this.videoSourcePlayer1.TabIndex = 6;
            this.videoSourcePlayer1.Text = "videoSourcePlayer";
            this.videoSourcePlayer1.VideoSource = null;
            // 
            // btnVer
            // 
            this.btnVer.BackColor = System.Drawing.Color.Yellow;
            this.btnVer.Location = new System.Drawing.Point(636, 16);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(77, 23);
            this.btnVer.TabIndex = 5;
            this.btnVer.Text = "Ver";
            this.btnVer.UseVisualStyleBackColor = false;
            this.btnVer.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboCamaras
            // 
            this.comboCamaras.CausesValidation = false;
            this.comboCamaras.FormattingEnabled = true;
            this.comboCamaras.Location = new System.Drawing.Point(427, 18);
            this.comboCamaras.Name = "comboCamaras";
            this.comboCamaras.Size = new System.Drawing.Size(194, 21);
            this.comboCamaras.TabIndex = 4;
            this.comboCamaras.Text = "Seleccionar cámara";
            // 
            // labelTeclaPresionada
            // 
            this.labelTeclaPresionada.AutoSize = true;
            this.labelTeclaPresionada.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTeclaPresionada.Location = new System.Drawing.Point(51, 156);
            this.labelTeclaPresionada.Name = "labelTeclaPresionada";
            this.labelTeclaPresionada.Size = new System.Drawing.Size(171, 23);
            this.labelTeclaPresionada.TabIndex = 3;
            this.labelTeclaPresionada.Text = "Detectando teclas..";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(47, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ocultar Programa (Ctrl + H)";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblCantidadCamaras
            // 
            this.lblCantidadCamaras.AutoSize = true;
            this.lblCantidadCamaras.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadCamaras.Location = new System.Drawing.Point(341, 13);
            this.lblCantidadCamaras.Name = "lblCantidadCamaras";
            this.lblCantidadCamaras.Size = new System.Drawing.Size(20, 23);
            this.lblCantidadCamaras.TabIndex = 1;
            this.lblCantidadCamaras.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(43, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(292, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Cantidad de cámaras disponibles:";
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 353);
            this.Controls.Add(this.panelPrincipal);
            this.Controls.Add(this.barraMenu);
            this.MainMenuStrip = this.barraMenu;
            this.Name = "VentanaPrincipal";
            this.Text = "OjoGuardián - Menú Principal";
            this.barraMenu.ResumeLayout(false);
            this.barraMenu.PerformLayout();
            this.panelPrincipal.ResumeLayout(false);
            this.panelPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip barraMenu;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cámarasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sensorDeMovimientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem conexiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notificacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grabaciónDeVideoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem soporteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeOjoGuardiánToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem herramientasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iniciarVigilanciaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirCarpetaDeGrabacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verCámarasToolStripMenuItem;
        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.Label lblCantidadCamaras;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTeclaPresionada;
        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.ComboBox comboCamaras;
        private AForge.Controls.VideoSourcePlayer videoSourcePlayer1;
        private System.Windows.Forms.Button btnParar;
    }
}

