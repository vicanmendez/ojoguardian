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
    public partial class AjustesSensorMovimiento : Form
    {
        public AjustesSensorMovimiento()
        {
            InitializeComponent();
            //Inicializamos los valores segfún configuración guardada
            if(Properties.Settings.Default.Resaltar == true)
            {
                checkBoxResaltar.Checked = true;
            } else
            {
                checkBoxResaltar.Checked = false;
            }
            trackBarSensibilidad.Value = Properties.Settings.Default.Sensibilidad;
        }

        /*Si se hace clic en "Guardar cambios", guardamos las settings marcadas */
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Sensibilidad = trackBarSensibilidad.Value;
            if (checkBoxResaltar.Checked)
                Properties.Settings.Default.Resaltar = true;
            else
                Properties.Settings.Default.Resaltar = false;
            if (checkBoxActivado.Checked)
                Properties.Settings.Default.detectarMovimiento = true;
            else
                Properties.Settings.Default.detectarMovimiento = false;
            Properties.Settings.Default.Save();
            MessageBox.Show("Cambios guardados");
        }

        /*Si se hace click sobre el botón por defecto se pondrán los parámetros de configuración de manera inicial */
        private void btnReset_Click(object sender, EventArgs e)
        {
            checkBoxActivado.Checked = true;
            trackBarSensibilidad.Value = 2;
            checkBoxResaltar.Checked = false;
        }
    }
}
