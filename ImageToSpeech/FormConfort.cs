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
    public partial class FormConfort : Form
    {
        SpeechSynthesizer synth = new SpeechSynthesizer();
        FormConfort2 frmConfort2 = null;
        FormSentir padre = null;
        FormPral frmPral = null;

        public FormSentir Padre
        {
            get { return padre; }
            set { padre = value; }
        }

        public FormPral Pral
        {
            get { return frmPral; }
            set { frmPral = value; }
        }

        public FormConfort()
        {
            InitializeComponent();
        }

        private void buttonAtras_Click(object sender, EventArgs e)
        {
            if (this.Padre != null)
            {
                this.Padre.Show();
                this.Padre.BringToFront();
                this.Hide();
            }
            else
            {
                FormSentir frmSentir = new FormSentir();
                frmSentir.Pral = frmPral;
                frmSentir.Show();
                frmSentir.BringToFront();
                this.Hide();
            }
        }

        private void FormConfort_Load(object sender, EventArgs e)
        {
            synth.SetOutputToDefaultAudioDevice();
            synth.Volume = 70;
            Prompt inicio = new Prompt("Panel del confort");
            synth.SpeakAsync(inicio);

            synth.Volume = 100;
        }

        private void buttonSentir_Click(object sender, EventArgs e)
        {
            if (frmConfort2 == null)
            {
                frmConfort2 = new FormConfort2();
                frmConfort2.Padre = this;
                frmConfort2.Pral = frmPral;
            }
            frmConfort2.Show();
            frmConfort2.BringToFront();
            this.Hide();
        }


        #region IMAGENES A VOZ - IMAGES TO SPEECH
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

        private void buttonFecha_Click(object sender, EventArgs e)
        {
            Prompt frase = new Prompt("¿Qué día es hoy?");
            synth.Speak(frase);
        }

        private void buttonHora_Click(object sender, EventArgs e)
        {
            Prompt frase = new Prompt("¿Qué hora es?");
            synth.Speak(frase);
        }

        private void buttonOcurrido_Click(object sender, EventArgs e)
        {
            Prompt frase = new Prompt("¿Qué ha ocurrido?");
            synth.Speak(frase);
        }

        private void buttonDonde_Click(object sender, EventArgs e)
        {
            Prompt frase = new Prompt("¿Dónde estoy?");
            synth.Speak(frase);
        }

        private void buttonPijama_Click(object sender, EventArgs e)
        {
            Prompt frase = new Prompt("Quisiera un pijama limpio, por favor");
            synth.Speak(frase);
        }

        private void buttonCamison_Click(object sender, EventArgs e)
        {
            Prompt frase = new Prompt("Quisiera un camisón limpio, por favor");
            synth.Speak(frase);
        }

        private void buttonBata_Click(object sender, EventArgs e)
        {
            Prompt frase = new Prompt("Quisiera una bata, por favor");
            synth.Speak(frase);
        }

        private void buttonZapatillas_Click(object sender, EventArgs e)
        {
            Prompt frase = new Prompt("Quisiera unas zapatillas, por favor");
            synth.Speak(frase);
        }

        private void buttonPapel_Click(object sender, EventArgs e)
        {
            Prompt frase = new Prompt("Quisiera papel higiénico o pañuelos, por favor");
            synth.Speak(frase);
        }

        private void buttonSabanas_Click(object sender, EventArgs e)
        {
            Prompt frase = new Prompt("Quisiera sábanas limpias, por favor");
            synth.Speak(frase);
        }
        #endregion

        private void FormConfort_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.Padre != null)
            {
                this.Padre.Show();
                this.Padre.BringToFront();
            }
            else
            {
                frmPral.Show();
                frmPral.BringToFront();
            }
            //Llamada a este método para comunicar el cierre del formCuerpo a otros formularios
            this.Padre.CerrarConfort();
            frmPral.CerrarConfort();
        }

        private void buttonInicio_Click(object sender, EventArgs e)
        {
            frmPral.Show();
            frmPral.BringToFront();
            this.Hide();
        }

        public void CerrarConfort2()
        {
            frmConfort2 = null;
        }
    }
}
