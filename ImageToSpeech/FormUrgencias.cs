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
    public partial class FormUrgencias : Form
    {
        SpeechSynthesizer synth = new SpeechSynthesizer();
        FormPral padreP = null;
        FormPral frmPral = null;
        FormCuerpo frmCuerpo = null;

        // Guarda el formulario que lo controla
        public FormPral PadreP
        {
            get { return padreP; }
            set { padreP = value; }
        }

        public FormPral Pral
        {
            get { return frmPral; }
            set { frmPral = value; }
        }

        public FormUrgencias()
        {
            InitializeComponent();
        }

        private void FormUrgencias_Load(object sender, EventArgs e)
        {
            synth.SetOutputToDefaultAudioDevice();
            synth.Volume = 70;
            Prompt inicio = new Prompt("Panel de urgencias");
            synth.SpeakAsync(inicio);

            synth.Volume = 100;
        }
        #region IMAGENES A VOZ - IMAGES TO SPEECH
        private void buttonEnfermera_Click(object sender, EventArgs e)
        {
            Prompt frase = new Prompt("¡Llamen a una enfermera!");
            synth.Speak(frase);
        }

        private void buttonMedico_Click(object sender, EventArgs e)
        {
            Prompt frase = new Prompt("¡Llamen a un médico!");
            synth.Speak(frase);
        }

        private void buttonTragar_Click(object sender, EventArgs e)
        {
            Prompt frase = new Prompt("¡No puedo tragar!");
            synth.Speak(frase);
        }

        private void buttonRespirar_Click(object sender, EventArgs e)
        {
            Prompt frase = new Prompt("¡Socorro! ¡No puedo respirar!");
            synth.Speak(frase);
        }

        private void buttonMareo_Click(object sender, EventArgs e)
        {
            Prompt frase = new Prompt("Me mareo");
            synth.Speak(frase);
        }

        private void buttonVomitar_Click(object sender, EventArgs e)
        {
            Prompt frase = new Prompt("Voy a vomitar");
            synth.Speak(frase);
        }

        private void buttonFiebre_Click(object sender, EventArgs e)
        {
            Prompt frase = new Prompt("Tengo fiebre");
            synth.Speak(frase);
        }

        private void buttonSi_Click(object sender, EventArgs e)
        {
            Prompt frase = new Prompt("Síi");
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

        private void buttonAuxilio_Click(object sender, EventArgs e)
        {
            Prompt frase = new Prompt("¡Auxilio!");
            synth.Speak(frase);
        }
        #endregion 
        private void buttonCuerpo_Click(object sender, EventArgs e)
        {
            if (frmCuerpo==null)
            {
                frmCuerpo = new FormCuerpo();
                frmCuerpo.Padre = this;
                frmCuerpo.Pral = frmPral;
            }
            frmCuerpo.Show();
            frmCuerpo.BringToFront();
            this.Hide();
        }


        /// <summary>
        /// Volver a mostrar formPrincipal.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAtras_Click(object sender, EventArgs e)
        {
            if (this.PadreP != null)
            {
                this.PadreP.Show();
                this.PadreP.BringToFront();
                this.Hide();
            }
            else
            {
                this.PadreP = frmPral;
                this.PadreP.Show();
                this.PadreP.BringToFront();
                this.Hide();
            }
        }


        /// <summary>
        /// Si se cierra el formUrgencias quiero que se muestre el formPrincipal -igual que si se hubiese dado al botón atrás-
        /// pero comunicando al formPrincipal que formUrgencias ha sido cerrado, no ocultado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormUrgencias_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.PadreP != null)
            {
                this.PadreP.Show();
                this.PadreP.BringToFront();
            }
            else
            {
                this.PadreP = frmPral;
                this.PadreP.Show();
                this.PadreP.BringToFront();
            }

            //Llamada a este método para comunicar el cierre del formUrgencias a otros formularios
            this.PadreP.CerrarUrgencias();
        }


        // cuando formCuerpo se cierre habrá que llamar a este método para que formUrgencias sepa que frmCuerpo ha sido cerrado
        public void CerrarCuerpo()
        {
            frmCuerpo = null;
        }
    }
}
