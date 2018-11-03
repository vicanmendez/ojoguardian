namespace Sistema_de_Seguridad_OjoGuardián
{
    partial class Vigilancia
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnParar = new System.Windows.Forms.Button();
            this.btnVer = new System.Windows.Forms.Button();
            this.comboCamaras = new System.Windows.Forms.ComboBox();
            this.videoSourcePlayer1 = new AForge.Controls.VideoSourcePlayer();
            this.label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(722, 318);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Comenzar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnParar
            // 
            this.btnParar.BackColor = System.Drawing.Color.Yellow;
            this.btnParar.Location = new System.Drawing.Point(369, 12);
            this.btnParar.Name = "btnParar";
            this.btnParar.Size = new System.Drawing.Size(78, 21);
            this.btnParar.TabIndex = 10;
            this.btnParar.Text = "Parar";
            this.btnParar.UseVisualStyleBackColor = false;
            this.btnParar.Click += new System.EventHandler(this.btnParar_Click);
            // 
            // btnVer
            // 
            this.btnVer.BackColor = System.Drawing.Color.Yellow;
            this.btnVer.Location = new System.Drawing.Point(244, 11);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(108, 23);
            this.btnVer.TabIndex = 9;
            this.btnVer.Text = "Vigilar";
            this.btnVer.UseVisualStyleBackColor = false;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // comboCamaras
            // 
            this.comboCamaras.CausesValidation = false;
            this.comboCamaras.FormattingEnabled = true;
            this.comboCamaras.Location = new System.Drawing.Point(24, 12);
            this.comboCamaras.Name = "comboCamaras";
            this.comboCamaras.Size = new System.Drawing.Size(194, 21);
            this.comboCamaras.TabIndex = 8;
            this.comboCamaras.Text = "Seleccionar cámara";
            // 
            // videoSourcePlayer1
            // 
            this.videoSourcePlayer1.Location = new System.Drawing.Point(24, 59);
            this.videoSourcePlayer1.Name = "videoSourcePlayer1";
            this.videoSourcePlayer1.Size = new System.Drawing.Size(423, 282);
            this.videoSourcePlayer1.TabIndex = 11;
            this.videoSourcePlayer1.Text = "videoSourcePlayer";
            this.videoSourcePlayer1.VideoSource = null;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(609, 151);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(35, 13);
            this.label.TabIndex = 12;
            this.label.Text = "label1";
            // 
            // Vigilancia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 353);
            this.Controls.Add(this.label);
            this.Controls.Add(this.videoSourcePlayer1);
            this.Controls.Add(this.btnParar);
            this.Controls.Add(this.btnVer);
            this.Controls.Add(this.comboCamaras);
            this.Controls.Add(this.button1);
            this.Name = "Vigilancia";
            this.Text = "Vigilancia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnParar;
        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.ComboBox comboCamaras;
        private AForge.Controls.VideoSourcePlayer videoSourcePlayer1;
        private System.Windows.Forms.Label label;
    }
}