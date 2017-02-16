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
    public partial class FormConfort2 : Form
    {
        SpeechSynthesizer synth = new SpeechSynthesizer();
        FormComunicaPlus frmComunicaPlus = null;
        FormConfort padre = null;
        FormPral frmPral = null;

        public FormConfort Padre
        {
            get { return padre; }
            set { padre = value; }
        }

        public FormPral Pral
        {
            get { return frmPral; }
            set { frmPral = value; }
        }

        public FormConfort2()
        {
            InitializeComponent();
        }

        private void FormConfort2_Load(object sender, EventArgs e)
        {
            synth.SetOutputToDefaultAudioDevice();
            synth.Volume = 70;
            Prompt inicio = new Prompt("Panel del confort 2");
            synth.SpeakAsync(inicio);

            synth.Volume = 100;
        }

        private void buttonAtras_Click(object sender, EventArgs e)
        {
            if (this.Padre == null)
            {
                FormConfort frmConfort = new FormConfort();
                frmConfort.Pral = frmPral;
            }
            this.Padre.Show();
            this.Padre.BringToFront();
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

        private void buttonRopaInterior_Click(object sender, EventArgs e)
        {
            Prompt frase = new Prompt("Quisiera ropa interior limpia, por favor");
            synth.Speak(frase);
        }

        private void buttonPanial_Click(object sender, EventArgs e)
        {
            Prompt frase = new Prompt("Quisiera cambiar de pañal o compresa, por favor");
            synth.Speak(frase);
        }

        private void buttonPeinar_Click(object sender, EventArgs e)
        {
            Prompt frase = new Prompt("Quisiera peinarme, por favor");
            synth.Speak(frase);
        }

        private void buttonAsear_Click(object sender, EventArgs e)
        {
            Prompt frase = new Prompt("Quisiera asearme, por favor");
            synth.Speak(frase);
        }

        private void buttonAfeitar_Click(object sender, EventArgs e)
        {
            Prompt frase = new Prompt("Quisiera afeitarme, por favor");
            synth.Speak(frase);
        }

        private void buttonFamilia_Click(object sender, EventArgs e)
        {
            Prompt frase = new Prompt("Quisiera que llamasen a mi familia, por favor");
            synth.Speak(frase);
        }

        private void buttonReligion_Click(object sender, EventArgs e)
        {
            Prompt frase = new Prompt("Quisiera atención religiosa, por favor");
            synth.Speak(frase);
        }

        private void buttonLeer_Click(object sender, EventArgs e)
        {
            Prompt frase = new Prompt("Quisiera leer, por favor");
            synth.Speak(frase);
        }
        
        private void buttonTV_Click(object sender, EventArgs e)
        {
            Prompt frase = new Prompt("Quisiera la televisión, por favor");
            synth.Speak(frase);
        }

        private void buttonMovil_Click(object sender, EventArgs e)
        {
            Prompt frase = new Prompt("Quisiera mi móvil, por favor");
            synth.Speak(frase);
        }
        #endregion


        private void FormConfort2_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.Padre != null)
            {
                this.Padre.CerrarConfort2();
            }

            frmPral.Show();
            frmPral.BringToFront();

            //Llamada a este método para comunicar el cierre del formCuerpo a otros formularios
            frmPral.CerrarConfort2();
        }

        private void buttonInicio_Click(object sender, EventArgs e)
        {
            this.Padre = null;
            this.Close();
        }

        private void buttonAdelante_Click(object sender, EventArgs e)
        {
            if (frmComunicaPlus == null)
            {
                frmComunicaPlus = new FormComunicaPlus();
                frmComunicaPlus.Padre = this;
                frmComunicaPlus.Pral = frmPral;
            }
            frmComunicaPlus.Show();
            frmComunicaPlus.BringToFront();
            this.Hide();
        }

        public void CerrarComunicaPlus()
        {
            frmComunicaPlus = null;
        }
    }
}
