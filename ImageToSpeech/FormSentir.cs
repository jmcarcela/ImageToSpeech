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
    public partial class FormSentir : Form
    {
        SpeechSynthesizer synth = new SpeechSynthesizer();
        FormCuerpo2 padre = null;
        FormConfort frmConfort = null;
        FormPral frmPral = null;

        public FormCuerpo2 Padre
        {
            get { return padre; }
            set { padre = value; }
        }

        public FormPral Pral
        {
            get { return frmPral; }
            set { frmPral = value; }
        }

        public FormSentir()
        {
            InitializeComponent();
        }

        private void FormSentir_Load(object sender, EventArgs e)
        {
            synth.SetOutputToDefaultAudioDevice();
            synth.Volume = 70;
            Prompt inicio = new Prompt("Panel de sentimientos y sensaciones");
            synth.SpeakAsync(inicio);

            synth.Volume = 100;
        }

        private void buttonAtras_Click(object sender, EventArgs e)
        {
            if (this.Padre == null)
            {
                FormCuerpo2 frmCuerpo2 = new FormCuerpo2();
                frmCuerpo2.Pral = frmPral;
            }
            this.Padre.Show();
            this.Padre.BringToFront();
            this.Hide();
        }

        private void buttonConfort_Click(object sender, EventArgs e)
        {
            if (frmConfort == null)
            {
                frmConfort = new FormConfort();
                frmConfort.Padre = this;
                frmConfort.Pral = frmPral;
            }
            frmConfort.Show();
            frmConfort.BringToFront();
            this.Hide();
        }

        #region IMAGENES A VOZ - IMAGES TO SPEECH
        private void buttonMejor_Click(object sender, EventArgs e)
        {
            Prompt frase = new Prompt("Me encuentro mejor");
            synth.Speak(frase);
        }

        private void buttonPeor_Click(object sender, EventArgs e)
        {
            Prompt frase = new Prompt("Me encuentro peor");
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

        private void buttonEmocion_Click(object sender, EventArgs e)
        {
            Prompt frase = new Prompt("Lloro de emoción");
            synth.Speak(frase);
        }

        private void buttonTriste_Click(object sender, EventArgs e)
        {
            Prompt frase = new Prompt("Estoy triste");
            synth.Speak(frase);
        }

        private void buttonSolo_Click(object sender, EventArgs e)
        {
            Prompt frase = new Prompt("Me encuentro solo");
            synth.Speak(frase);
        }

        private void buttonAburrido_Click(object sender, EventArgs e)
        {
            Prompt frase = new Prompt("Estoy aburrido");
            synth.Speak(frase);
        }

        private void buttonEnfado_Click(object sender, EventArgs e)
        {
            Prompt frase = new Prompt("Estoy enfadado");
            synth.Speak(frase);
        }

        private void buttonInsomnio_Click(object sender, EventArgs e)
        {
            Prompt frase = new Prompt("No puedo dormir");
            synth.Speak(frase);
        }

        private void buttonPreocupacion_Click(object sender, EventArgs e)
        {
            Prompt frase = new Prompt("Estoy preocupado");
            synth.Speak(frase);
        }

        private void buttonMiedo_Click(object sender, EventArgs e)
        {
            Prompt frase = new Prompt("Tengo miedo");
            synth.Speak(frase);
        }
#endregion

        private void FormSentir_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.Padre != null)
            {
                this.Padre.CerrarSentir();
            }

            frmPral.Show();
            frmPral.BringToFront();
            //Llamada a este método para comunicar el cierre del formCuerpo a otros formularios
            frmPral.CerrarSentir();
        }

        public void CerrarConfort()
        {
            frmConfort = null;
        }

        private void buttonInicio_Click(object sender, EventArgs e)
        {
            this.Padre = null;
            this.Close();
        }
    }
}
