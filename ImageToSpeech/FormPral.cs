using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;

namespace ImageToSpeech
{
    public partial class FormPral : Form
    {
        SpeechSynthesizer synth = new SpeechSynthesizer();
        FormUrgencias frmUrge = null;
        FormCuerpo frmCuerpo = null;
        FormCuerpo2 frmCuerpo2 = null;
        FormSentir frmSentir = null;
        FormConfort frmConfort = null;
        FormConfort2 frmConfort2 = null;
        FormComunicaPlus frmComunicaPlus = null;

        public FormPral()
        {
            InitializeComponent();
        }

        private void FormPral_Load(object sender, EventArgs e)
        {
            synth.SetOutputToDefaultAudioDevice();
            synth.Volume = 70;
            Prompt inicio = new Prompt("Panel principal");
            synth.SpeakAsync(inicio);

            synth.Volume = 100;
        }

        private void buttonUrgencias_Click(object sender, EventArgs e)
        {
            if (frmUrge == null)
            {
                //
                // Aun no se ha creado el formulario, lo creamos
                // 
                frmUrge = new FormUrgencias();
                frmUrge.PadreP = this;
                frmUrge.Pral = this;// Comunicamos al formulario quien lo ha creado
            }                           // Mostramos el formulario
            frmUrge.Show();
            frmUrge.BringToFront();
            this.Hide();   
        }


        
        private void buttonCuerpo_Click(object sender, EventArgs e)
        {
            if (frmCuerpo == null)
            {
                frmCuerpo = new FormCuerpo();
                frmCuerpo.Pral = this;
                // Creación de formUrgencias, si no existe, para posibilitar posterior navegación entre formularios
                // La creación de forms desde formPrincipal posibilita la navegación siempre hacia atrás, desde el form
                // seleccionado hasta llegar al principal de nuevo.
                if (frmUrge == null)
                {
                    frmUrge = new FormUrgencias();
                    frmUrge.PadreP = this;
                    frmUrge.Pral = this;
                }
                frmCuerpo.Padre = frmUrge;
            } 
            // Mostramos el form
            frmCuerpo.Show();
            frmCuerpo.BringToFront();
            this.Hide();
        }

        private void buttonSentimientos_Click(object sender, EventArgs e)
        {
            if (frmSentir == null)
            {
                frmSentir = new FormSentir();
                frmSentir.Pral = this;

                // Creación de formCuerpo2, formCuerpo y formUrgencias, si no existen, para posibilitar posterior navegación entre forms.
                if (frmCuerpo2 == null)
                {
                    frmCuerpo2 = new FormCuerpo2();
                    frmCuerpo2.Pral = this;
                }
                frmSentir.Padre = frmCuerpo2;

                if (frmCuerpo == null)
                {
                    frmCuerpo = new FormCuerpo();
                    frmCuerpo.Pral = this;
                }
                frmCuerpo2.Padre = frmCuerpo;

                if (frmUrge == null) 
                {
                    frmUrge = new FormUrgencias();
                    frmUrge.PadreP = this;
                    frmUrge.Pral = this;
                }
                frmCuerpo.Padre = frmUrge;
            }
            frmSentir.Show();
            frmSentir.BringToFront();
            this.Hide();
        }

        private void buttonConfort_Click(object sender, EventArgs e)
        {
            if (frmConfort == null)
            {
                frmConfort = new FormConfort();
                frmConfort.Pral = this;
                // Creación de formSentir, formCuerpo2, formCuerpo y formUrgencias, si no existen, para posibilitar posterior
                // navegación entre forms.
                if (frmSentir == null)
                {
                    frmSentir = new FormSentir();
                    frmSentir.Pral = this;
                }
                frmConfort.Padre = frmSentir;

                if (frmCuerpo2 == null)
                {
                    frmCuerpo2 = new FormCuerpo2();
                    frmCuerpo2.Pral = this;
                }
                frmSentir.Padre = frmCuerpo2;

                if (frmCuerpo == null)
                {
                    frmCuerpo = new FormCuerpo();
                    frmCuerpo.Pral = this;
                }
                frmCuerpo2.Padre = frmCuerpo;

                if (frmUrge == null)
                {
                    frmUrge = new FormUrgencias();
                    frmUrge.PadreP = this;
                    frmUrge.Pral = this;
                }
                frmCuerpo.Padre = frmUrge;
            }
            frmConfort.Show();
            frmConfort.BringToFront();
            this.Hide();
        }

        private void buttonComunica_Click(object sender, EventArgs e)
        {
            if (frmComunicaPlus == null)
            {
                frmComunicaPlus = new FormComunicaPlus();
                frmComunicaPlus.Pral = this;
                // Creación de formConfort2, formComfort, formSentir, formCuerpo2, formCuerpo y formUrgencias, si no existen, 
                // para posibilitar posterior navegación entre forms.
                if (frmConfort2 == null)
                {
                    frmConfort2 = new FormConfort2();
                    frmConfort2.Pral = this;
                }
                frmComunicaPlus.Padre = frmConfort2;

                if (frmConfort == null)
                {
                    frmConfort = new FormConfort();
                    frmConfort.Pral = this;
                }
                frmConfort2.Padre = frmConfort;

                if (frmSentir == null)
                {
                    frmSentir = new FormSentir();
                    frmSentir.Pral = this;
                }
                frmConfort.Padre = frmSentir;

                if (frmCuerpo2 == null)
                {
                    frmCuerpo2 = new FormCuerpo2();
                    frmCuerpo2.Pral = this;
                }
                frmSentir.Padre = frmCuerpo2;

                if (frmCuerpo == null)
                {
                    frmCuerpo = new FormCuerpo();
                    frmCuerpo.Pral = this;
                }
                frmCuerpo2.Padre = frmCuerpo;

                if (frmUrge == null)
                {
                    frmUrge = new FormUrgencias();
                    frmUrge.PadreP = this;
                    frmUrge.Pral = this;
                }
                frmCuerpo.Padre = frmUrge;
            }
            frmComunicaPlus.Show();
            frmComunicaPlus.BringToFront();
            this.Hide();
        }


        #region IMAGENES A VOZ - IMAGES TO SPEECH
        private void buttonAuxilio_Click(object sender, EventArgs e)
        {
            Prompt frase = new Prompt("¡Auxilio!");
            synth.Speak(frase);
        }

        private void buttonSi_Click(object sender, EventArgs e)
        {
            Prompt frase = new Prompt("Sí");
            synth.Speak(frase);
        }

        private void buttonAveces_Click(object sender, EventArgs e)
        {
            Prompt frase = new Prompt("A veces");
            synth.Speak(frase);
        }

        private void buttonNo_Click(object sender, EventArgs e)
        {
            Prompt frase = new Prompt("Nooo");
            synth.Speak(frase);
        }

        #endregion

        private void FormPral_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormCollection Coleccion=Application.OpenForms;

            //for(int i=0;i<Coleccion.Count;i++)
            //    Coleccion[i].Close();

            Application.Exit();
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            FormCollection Coleccion = Application.OpenForms;

            //for (int i = 0; i < Coleccion.Count; i++)
            //    Coleccion[i].Close();

            Application.Exit();
        }

        // cuando formUrgencias se cierre habrá que llamar a este método para que formPrincipal sepa que frmUrge ha sido cerrado
        public void CerrarUrgencias()
        {
            frmUrge = null;
        }

        public void CerrarCuerpo()
        {
            frmCuerpo = null;
        }

        public void CerrarCuerpo2()
        {
            frmCuerpo2 = null;
        }

        public void CerrarSentir()
        {
            frmSentir = null;
        }

        public void CerrarConfort()
        {
            frmConfort = null;
        }

        public void CerrarConfort2()
        {
            frmConfort2 = null;
        }

        public void CerrarComunicaPlus()
        {
            frmComunicaPlus = null;
        }
    }
}
