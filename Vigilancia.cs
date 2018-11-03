using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
//Librería para manejar AVI
using AForge.Video.VFW;
//Librería para detector de movimiento
using AForge.Vision;
using AForge.Vision.Motion;

namespace Sistema_de_Seguridad_OjoGuardián
{
    public partial class Vigilancia : Form
    {
        //Creamos un atributo (variable) para almacenar los dispositivos
        private static FilterInfoCollection dispositivos;
        //Creamos un atributo (variable) para la fuente de video
        private static VideoCaptureDevice fuenteDeVideo;
        //creamos un atributo booleano que determina si se encuentra grabando o no
        private bool estaGrabando;
        //Creamos un objeto AVIWriter con el codec wmv3
        private AVIWriter writer = new AVIWriter("wmv3");
        //Detector de movimiento
        private MotionDetector detectorDeMovimiento;
        //Obtener direccion de la carpeta de destino
        private String archivo = Properties.Settings.Default.urlBase;
        //booleano para indicar que detecte o no movimiento
        private bool detectarMovimiento = Properties.Settings.Default.detectarMovimiento;
        //Booleano que detecta si se quiere o no resaltar áreas
        private bool resaltarMovimiento = Properties.Settings.Default.Resaltar;
        //sensibilidad para el detector de movimiento
        private int sensibilidad = Properties.Settings.Default.Sensibilidad;
     
        //Singleton
        private static Vigilancia instancia;

        public static bool getInstancia()
        {
            if(instancia == null)
            {
                instancia = new Vigilancia();
                instancia.Visible = true;
                return true;
            } else
            {
                return false;
            }
        }
        public Vigilancia()
        {
            InitializeComponent();
            
            estaGrabando = false;
            detectarMovimiento = false;
            
            //Listamos los dispositivos para la fuente de video
            dispositivos = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            //Cargamos los dispositivos al comboBox
            //También puede hacerse con un foreach del array de dispositivos

            for (int i = 0; i < dispositivos.Count; i++)
            {
                comboCamaras.Items.Add(dispositivos[i].Name);
            }
            comboCamaras.SelectedIndex = 0;
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            instancia = null;
            Close();
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            //Establecemos el objeto seleccionado como fuente de video
            fuenteDeVideo = new VideoCaptureDevice(dispositivos[comboCamaras.SelectedIndex].MonikerString);
            //Iniciamos la cámara
            fuenteDeVideo.Start();

            //Inicializamos el control
            videoSourcePlayer1.VideoSource = fuenteDeVideo;
            //Iniciamos recepción de imágenes

            videoSourcePlayer1.Start();
            //Habilitamos el botón para grabar
            btnParar.Enabled = true;
            /*Si el usuario marcó que quería destacar el movimiento, creamos un detector
           * de movimiento con destaque, caso contrario, uno que sólo detecte movimiento sin destacar áreas */
            if (resaltarMovimiento)
            {
                detectorDeMovimiento = new MotionDetector(new SimpleBackgroundModelingDetector(), new MotionAreaHighlighting());
            }
            else
            {
                detectorDeMovimiento = new MotionDetector(new SimpleBackgroundModelingDetector());
            }
            try
            {


                if (videoSourcePlayer1.GetCurrentVideoFrame() != null)
                {

                    int alto = videoSourcePlayer1.Height;
                    int ancho = videoSourcePlayer1.Width;
                    Bitmap image = new Bitmap(ancho, alto);
                    image = videoSourcePlayer1.GetCurrentVideoFrame();

                    
                    archivo += "/test.avi";
                    

                    writer.Open(archivo, image.Width, image.Height);

                    estaGrabando = true;


                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /*Evento que se disp-ara cada vez que se cambia un cuadro del videoSourcePlayer */
        private void videoSourcePlayer1_NewFrame(object sender, ref Bitmap image)
        {
            MessageBox.Show("hola");
            if (!detectarMovimiento) //Si no está detectada la detección de movimiento, grabamos sin fijarnos en el movimiento
            {
                //Si se ha iundicado que grabe, entonces guardará cada cambio en el vídeo
                if (estaGrabando)
                {
                    writer.AddFrame(image);

                }
            }
            else //Si está habilitdada la detección de movimiento
            {
                if (estaGrabando) //Si hemos indicado que grabe
                {
                    //Grabamos si el sistema detecta movimiento
                    int nivelSensibilidad = 1 / (20 * sensibilidad);
                    if (detectorDeMovimiento.ProcessFrame(image) > nivelSensibilidad)
                    {

                        writer.AddFrame(image);
                    }
                }
            }

        }

        private void btnParar_Click(object sender, EventArgs e)
        {
            if (videoSourcePlayer1.IsRunning)
            {
                videoSourcePlayer1.SignalToStop();


            }

            if (estaGrabando)
            {
                writer.Close();
                estaGrabando = false;
                videoSourcePlayer1.Stop();
            }

        }

       
    }
}
