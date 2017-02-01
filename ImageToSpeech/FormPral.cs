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
        FormSentir frmSentir = null;
        FormConfort frmConfort = null;
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
                frmUrge.PadreP = this; // Comunicamos al formulario quien lo ha creado
            }                           // Mostramos el formulario
            frmUrge.Show();
            frmUrge.BringToFront();
            this.Hide();
            
            //}
            //else
            //{
            //    frmUrge.Show();
            //    frmUrge.BringToFront();
            //    this.Hide();
            //}            
        }

        private void buttonCuerpo_Click(object sender, EventArgs e)
        {
            if (frmCuerpo == null)
            {
                //
                // Aun no se ha creado el formulario, lo creamos
                // 
                frmCuerpo = new FormCuerpo();
                frmCuerpo.Padre = new FormUrgencias(); // Comunicamos al formulario quien lo ha creado
                                                       // Mostramos el formulario
                frmCuerpo.Show();
                frmCuerpo.BringToFront();
                this.Hide();
            }
            else
            {
                frmCuerpo.Show();
                frmCuerpo.BringToFront();
                this.Hide();
            }
        }

        private void buttonSentimientos_Click(object sender, EventArgs e)
        {
            if (frmSentir == null)
            {
                //
                // Aun no se ha creado el formulario, lo creamos
                // 
                frmSentir = new FormSentir();
                frmSentir.Show();
                frmSentir.BringToFront();
                this.Hide();
            }
            else
            {
                frmSentir.Show();
                frmSentir.BringToFront();
                this.Hide();
            }
        }

        private void buttonConfort_Click(object sender, EventArgs e)
        {
            if (frmConfort == null)
            {
                //
                // Aun no se ha creado el formulario, lo creamos
                // 
                frmConfort = new FormConfort();
                frmConfort.Show();
                frmConfort.BringToFront();
                this.Hide();
            }
            else
            {
                frmConfort.Show();
                frmConfort.BringToFront();
                this.Hide();
            }
        }

        private void buttonComunica_Click(object sender, EventArgs e)
        {
            if (frmComunicaPlus == null)
            {
                //
                // Aun no se ha creado el formulario, lo creamos
                // 
                frmComunicaPlus = new FormComunicaPlus();
                frmComunicaPlus.Show();
                frmComunicaPlus.BringToFront();
                this.Hide();
            }
            else
            {
                frmComunicaPlus.Show();
                frmComunicaPlus.BringToFront();
                this.Hide();
            }
        }

        private void buttonAuxilio_Click(object sender, EventArgs e)
        {
            Prompt frase = new Prompt("¡Auxilio!");
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

        private void FormPral_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormCollection Coleccion=Application.OpenForms;

            for(int i=0;i<Coleccion.Count;i++)
                Coleccion[i].Close();

            Application.Exit();
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            FormCollection Coleccion = Application.OpenForms;

            for (int i = 0; i < Coleccion.Count; i++)
                Coleccion[i].Close();

            Application.Exit();
        }
    }
}
