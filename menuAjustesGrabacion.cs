using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Seguridad_OjoGuardián
{
    public partial class menuAjustesGrabacion : Form
    {
        private String urlGrabaciones;

        public menuAjustesGrabacion()
        {
            InitializeComponent();
            lblDirectorio.Text = Properties.Settings.Default.urlBase;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.urlBase = urlGrabaciones;
            lblDirectorio.Text = urlGrabaciones;
            MessageBox.Show("Se ha cambiado el directorio a:" + urlGrabaciones);
            Properties.Settings.Default.Save();
        }

        private void menuAjustesGrabacion_Load(object sender, EventArgs e)
        {

        }

        //Evento para cambiar el directorio de grabaciones
        private void button2_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                urlGrabaciones = folderBrowserDialog.SelectedPath;
                lblDirectorio.Text = urlGrabaciones;
        }
    }
}
