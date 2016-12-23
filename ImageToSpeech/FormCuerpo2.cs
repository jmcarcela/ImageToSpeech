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
    public partial class FormCuerpo2 : Form
    {
        SpeechSynthesizer synth = new SpeechSynthesizer();
        FormCuerpo padre = null;
        FormSentir frmSentir = null;

        public FormCuerpo Padre
        {
            get { return padre; }
            set { padre = value; }
        }

        public FormCuerpo2()
        {
            InitializeComponent();
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

        private void buttonFrio_Click(object sender, EventArgs e)
        {
            Prompt frase = new Prompt("Tengo frío");
            synth.Speak(frase);
        }

        private void buttonCalor_Click(object sender, EventArgs e)
        {
            Prompt frase = new Prompt("Tengo calor");
            synth.Speak(frase);
        }

        private void buttonGafas_Click(object sender, EventArgs e)
        {
            Prompt frase = new Prompt("Quiero mis gafas");
            synth.Speak(frase);
        }

        private void buttonAudifono_Click(object sender, EventArgs e)
        {
            Prompt frase = new Prompt("Quiero mi audífono");
            synth.Speak(frase);
        }

        private void buttonAndar_Click(object sender, EventArgs e)
        {
            Prompt frase = new Prompt("Quiero caminar");
            synth.Speak(frase);
        }

        private void buttonSentar_Click(object sender, EventArgs e)
        {
            Prompt frase = new Prompt("Me quiero sentar");
            synth.Speak(frase);
        }

        private void buttonIncorporar_Click(object sender, EventArgs e)
        {
            Prompt frase = new Prompt("Quiero incorporarme");
            synth.Speak(frase);
        }

        private void buttonAcostar_Click(object sender, EventArgs e)
        {
            Prompt frase = new Prompt("Quiero acostarme");
            synth.Speak(frase);
        }

        private void buttonCambiarPosicion_Click(object sender, EventArgs e)
        {
            Prompt frase = new Prompt("Quiero cambiar de postura");
            synth.Speak(frase);
        }

        private void buttonDormir_Click(object sender, EventArgs e)
        {
            Prompt frase = new Prompt("Quisiera dormir, por favor");
            synth.Speak(frase);
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
                FormCuerpo frmCuerpo = new FormCuerpo();
                frmCuerpo.Show();
                frmCuerpo.BringToFront();
                this.Hide();
            }
        }

        private void FormCuerpo2_Load(object sender, EventArgs e)
        {
            synth.SetOutputToDefaultAudioDevice();
            synth.Volume = 70;
            Prompt inicio = new Prompt("Panel del cuerpo 2");
            synth.SpeakAsync(inicio);

            synth.Volume = 100;
        }

        private void buttonSentir_Click(object sender, EventArgs e)
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

        private void FormCuerpo2_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormPral frmPral = new FormPral();
            frmPral.Show();
            frmPral.BringToFront();
        }

        private void buttonInicio_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
