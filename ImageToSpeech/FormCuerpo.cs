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
    public partial class FormCuerpo : Form
    {
        SpeechSynthesizer synth = new SpeechSynthesizer();
        FormUrgencias padre = null;
        FormCuerpo2 frmCuerpo2 = null;
        FormPral frmPral = null;

        public FormUrgencias Padre
        {
            get { return padre; }
            set { padre = value; }
        }

        public FormPral Pral 
        {
            get { return frmPral; }
            set { frmPral = value; }
        }

        public FormCuerpo()
        {
            InitializeComponent();
        }
        
        private void FormCuerpo_Load(object sender, EventArgs e)
        {
            synth.SetOutputToDefaultAudioDevice();
            synth.Volume = 70;
            Prompt inicio = new Prompt("Panel del cuerpo");
            synth.SpeakAsync(inicio);

            synth.Volume = 100;
        }

        private void buttonAtras_Click(object sender, EventArgs e)
        {
            if (this.Padre == null)
            {
                FormUrgencias frmUrge = new FormUrgencias();
                frmUrge.PadreP = frmPral;
            }
            this.Padre.Show();
            this.Padre.BringToFront();
            this.Hide();
        }

        private void buttonCuerpo2_Click(object sender, EventArgs e)
        {
            if (frmCuerpo2 == null)
            {
                frmCuerpo2 = new FormCuerpo2();
                frmCuerpo2.Padre = this;
                frmCuerpo2.Pral = frmPral;
            }
            frmCuerpo2.Show();
            frmCuerpo2.BringToFront();
            this.Hide();
        }

        #region IMAGENES A VOZ - IMAGES TO SPEECH
        private void buttonMejor_Click(object sender, EventArgs e)
        {
            Prompt frase = new Prompt("Me encuentro mejor");
            synth.Speak(frase);
        }

        private void buttonDolor_Click(object sender, EventArgs e)
        {
            Prompt frase = new Prompt("¡Me duele!");
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
            Prompt frase = new Prompt("¡Nooo!");
            synth.Speak(frase);
        }

        private void buttonPicor_Click(object sender, EventArgs e)
        {
            Prompt frase = new Prompt("¡Me pica!");
            synth.Speak(frase);
        }

        private void buttonWC_Click(object sender, EventArgs e)
        {
            Prompt frase = new Prompt("Quiero ir al baño");
            synth.Speak(frase);
        }

        private void buttonComer_Click(object sender, EventArgs e)
        {
            Prompt frase = new Prompt("Quiero comer");
            synth.Speak(frase);
        }

        private void buttonBeber_Click(object sender, EventArgs e)
        {
            Prompt frase = new Prompt("Quiero beber");
            synth.Speak(frase);
        }

        private void buttonOrinar_Click(object sender, EventArgs e)
        {
            Prompt frase = new Prompt("Quiero orinar");
            synth.Speak(frase);
        }

        private void buttonCaca_Click(object sender, EventArgs e)
        {
            Prompt frase = new Prompt("Quiero hacer caca");
            synth.Speak(frase);
        }

        private void buttonPeor_Click(object sender, EventArgs e)
        {
            Prompt frase = new Prompt("Me encuentro peor");
            synth.Speak(frase);
        }
        #endregion

        private void buttonPartesCuerpo_Click(object sender, EventArgs e)
        {
            FormPartesCuerpo frmPartesCuerpo = new FormPartesCuerpo();
            frmPartesCuerpo.Show();
            frmPartesCuerpo.BringToFront();
        }

        /// <summary>
        /// Si se cierra el formCuerpo quiero que se muestre el formUrgencias -igual que si se hubiese dado al botón atrás-
        /// pero comunicando al formUrgencias que formCuerpo ha sido cerrado, no ocultado, así como comunicándolo también
        /// al formPrincipal.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormCuerpo_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.Padre != null)
            {
                this.Padre.CerrarCuerpo();
            }

            frmPral.Show();
            frmPral.BringToFront();

            //Llamada a este método para comunicar el cierre del formCuerpo a otros formularios
            frmPral.CerrarCuerpo();
        }

        private void buttonInicio_Click(object sender, EventArgs e)
        {
            this.Padre = null;
            this.Close();
        }


        // cuando formCuerpo2 se cierre habrá que llamar a este método para que formCuerpo sepa que frmCuerpo2 ha sido cerrado
        public void CerrarCuerpo2()
        {
            frmCuerpo2 = null;
        }
    }
}
