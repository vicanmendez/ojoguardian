using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Librerías Aforge para ver las cámaras
using AForge.Video;
using AForge.Video.DirectShow;



namespace Sistema_de_Seguridad_OjoGuardián
{
    public partial class VentanaPrincipal : Form
    {
        //evaluamos si se presiona la tecla control
        private Boolean controlPresionado = false;
        //Creamos un atributo (variable) para almacenar los dispositivos
        private static FilterInfoCollection dispositivos;
        //Creamos un atributo (variable) para la fuente de video
        private static VideoCaptureDevice fuenteDeVideo;

        public VentanaPrincipal()
        {
            
            InitializeComponent();
            //Traemos la configuración guardada
            
            //El keyboard hook permite detectar las pulsaciones de teclado
            KeyboardHook hk = new KeyboardHook();
            //configuramos evento a realizar si se presiona una telca
            hk.KeyDown += new KeyboardHook.KeyboardHookCallback(hk_KeyDown);
            hk.KeyUp += new KeyboardHook.KeyboardHookCallback(hk_KeyUp);
            hk.Install();

            //Listamos los dispositivos para la fuente de video
            dispositivos = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            //Cargamos los dispositivos al comboBox
            //También puede hacerse con un foreach del array de dispositivos
            
            
            
            for (int i = 0; i < dispositivos.Count; i++)
            {
                comboCamaras.Items.Add(dispositivos[i].Name);
            }
            comboCamaras.SelectedIndex = 0;

            //Mostramos cantidad de camaras
            Properties.Settings.Default.camarasDisponibles = dispositivos.Count;
            lblCantidadCamaras.Text = Properties.Settings.Default.camarasDisponibles.ToString();
            //Ajustemos las cuestiones de diseño referidas a los botones
            btnParar.Enabled = false;
            btnVer.Enabled = true;
           
            
        }

        //Evento que se ejecuta si el usuario cliquea en "Salir"
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String mensaje = "¿Seguro que desea salir (Se detendrá la vigilancia) ?";
            String titulo = "Confirmación";
            MessageBoxButtons botones = MessageBoxButtons.YesNo;
            DialogResult resultado = MessageBox.Show(mensaje, titulo, botones);
            if (resultado == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            } 
            
        }

        //Evento al lanzarse cuando el KeyboardHook detecta que se presiona una tecla 
        private void hk_KeyDown(KeyboardHook.VKeys key)
        {
            labelTeclaPresionada.Text = " " + key.ToString();
            //Si la tecla presionada es la seleccionada para ocultar el programa, entonces lo ocultamos o lo hacemos aparecer (según corresponda)
            if (key.ToString() == "LCONTROL")
            {
                controlPresionado = true;
            }
            //Determinamos si se presionó la tecla H y además se encuentra presionado LCONTROL
            if ((key.ToString() == "KEY_H") && (controlPresionado))
                {
                //lO DESMARCAMOS AL CTRL
                controlPresionado = false;
                    //El atributo "Visible" de la ventana es accesible directamente porque estamos trabajando sobre el mismo objeto 
                    if (Visible == true)
                    {
                    MessageBox.Show("Para evitar errores es conveniente ocultar la ventana sólo después de configurar las cámaras y la vigilancia");
                        Visible = false;
                    }
                    else
                    {
                        Visible = true;
                    }
                }
            }
        

        //Evento que evalúa si se levanta una tecla
        private void hk_KeyUp(KeyboardHook.VKeys key)
        {
            if(key.ToString() == "LCONTROL")
            {
                controlPresionado = true;
            }
        }

        //Si se hace clic en la opción para abrir la carpeta donde se encuentran los videos
            private void abrirCarpetaDeGrabacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Properties.Settings.Default.urlBase);
        }

        private void barraMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label3_Enter(object sender, EventArgs e)
        {

        }

        private void panelPrincipal_Paint(object sender, PaintEventArgs e)
        {

        }

   
    

        //si se cliquea en la opcion de ver las camaras
        private void verCámarasToolStripMenuItem_Click(object sender, EventArgs e)
        {
       

            panelPrincipal.Show();
            //Si hacemos clic en la opción de ver cámaras, ocultamos los otros paneles


        }

        private void sensorDeMovimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Si hacemos clic en la opción para configurar el sensor de movimiento, mostramos la ventana correspondiente

            AjustesSensorMovimiento AjustesMov = new AjustesSensorMovimiento();

            AjustesMov.Show();
        }

        private void grabaciónDeVideoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuAjustesGrabacion ajustesGrabacion = new menuAjustesGrabacion();
            ajustesGrabacion.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

            Visible = false;
        }

        private void panelPrincipal_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnParar.Enabled = true;
            //Establecemos el objeto seleccionado como fuente de video
            
            fuenteDeVideo = new VideoCaptureDevice(dispositivos[comboCamaras.SelectedIndex].MonikerString);
            //Iniciamos la cámara
            fuenteDeVideo.Start();

            //Inicializamos el control
            videoSourcePlayer1.VideoSource = fuenteDeVideo;
            //Iniciamos recepción de imágenes

            videoSourcePlayer1.Start();
            //Habilitamos el botón para grabar
        }

        private void btnParar_Click(object sender, EventArgs e)
        {

            if (videoSourcePlayer1.IsRunning)
            {
                videoSourcePlayer1.SignalToStop();
                fuenteDeVideo.Stop();
            }
            btnParar.Enabled = false;
        }

        private void iniciarVigilanciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Vigilancia.getInstancia())
            {

            } else
            {
                MessageBox.Show("Ya se ha iniciado la vigilancia");
            }
        }
    }
}
