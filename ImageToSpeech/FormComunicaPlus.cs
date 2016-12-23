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
    public partial class FormComunicaPlus : Form
    {
        SpeechSynthesizer synth = new SpeechSynthesizer();
        FormConfort2 padre = null;
        StringBuilder texto = new StringBuilder("");

        public FormConfort2 Padre
        {
            get { return padre; }
            set { padre = value; }
        }
        public FormComunicaPlus()
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

        private void FormComunicaPlus_Load(object sender, EventArgs e)
        {
            synth.SetOutputToDefaultAudioDevice();
            synth.Volume = 70;
            Prompt inicio = new Prompt("Panel comunica plus");
            synth.SpeakAsync(inicio);

            synth.Volume = 100;
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
                FormConfort2 frmConfort2 = new FormConfort2();
                frmConfort2.Show();
                frmConfort2.BringToFront();
                this.Hide();
            }
        }
        
        private void buttonCOMMA_Click(object sender, EventArgs e)
        {
            texto.Append(", ");
            textBox.Text = texto.ToString();
        }

        private void buttonA_Click(object sender, EventArgs e)
        {
            texto.Append("A");
            textBox.Text = texto.ToString();
        }

        private void buttonE_Click(object sender, EventArgs e)
        {
            texto.Append("E");
            textBox.Text = texto.ToString();
        }

        private void buttonI_Click(object sender, EventArgs e)
        {
            texto.Append("I");
            textBox.Text = texto.ToString();
        }

        private void buttonO_Click(object sender, EventArgs e)
        {
            texto.Append("O");
            textBox.Text = texto.ToString();
        }

        private void buttonU_Click(object sender, EventArgs e)
        {
            texto.Append("U");
            textBox.Text = texto.ToString();
        }

        private void buttonB_Click(object sender, EventArgs e)
        {
            texto.Append("B");
            textBox.Text = texto.ToString();
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            texto.Append("C");
            textBox.Text = texto.ToString();
        }

        private void buttonD_Click(object sender, EventArgs e)
        {
            texto.Append("D");
            textBox.Text = texto.ToString();
        }

        private void buttonF_Click(object sender, EventArgs e)
        {
            texto.Append("F");
            textBox.Text = texto.ToString();
        }

        private void buttonG_Click(object sender, EventArgs e)
        {
            texto.Append("G");
            textBox.Text = texto.ToString();
        }

        private void buttonH_Click(object sender, EventArgs e)
        {
            texto.Append("H");
            textBox.Text = texto.ToString();
        }

        private void buttonJ_Click(object sender, EventArgs e)
        {
            texto.Append("J");
            textBox.Text = texto.ToString();
        }

        private void buttonK_Click(object sender, EventArgs e)
        {
            texto.Append("K");
            textBox.Text = texto.ToString();
        }

        private void buttonL_Click(object sender, EventArgs e)
        {
            texto.Append("L");
            textBox.Text = texto.ToString();
        }

        private void buttonM_Click(object sender, EventArgs e)
        {
            texto.Append("M");
            textBox.Text = texto.ToString();
        }

        private void buttonN_Click(object sender, EventArgs e)
        {
            texto.Append("N");
            textBox.Text = texto.ToString();
        }

        private void buttonÑ_Click(object sender, EventArgs e)
        {
            texto.Append("Ñ");
            textBox.Text = texto.ToString();
        }

        private void buttonP_Click(object sender, EventArgs e)
        {
            texto.Append("P");
            textBox.Text = texto.ToString();
        }

        private void buttonQ_Click(object sender, EventArgs e)
        {
            texto.Append("Q");
            textBox.Text = texto.ToString();
        }

        private void buttonR_Click(object sender, EventArgs e)
        {
            texto.Append("R");
            textBox.Text = texto.ToString();
        }

        private void buttonS_Click(object sender, EventArgs e)
        {
            texto.Append("S");
            textBox.Text = texto.ToString();
        }

        private void buttonT_Click(object sender, EventArgs e)
        {
            texto.Append("T");
            textBox.Text = texto.ToString();
        }

        private void buttonV_Click(object sender, EventArgs e)
        {
            texto.Append("V");
            textBox.Text = texto.ToString();
        }

        private void buttonW_Click(object sender, EventArgs e)
        {
            texto.Append("W");
            textBox.Text = texto.ToString();
        }

        private void buttonX_Click(object sender, EventArgs e)
        {
            texto.Append("X");
            textBox.Text = texto.ToString();
        }

        private void buttonY_Click(object sender, EventArgs e)
        {
            texto.Append("Y");
            textBox.Text = texto.ToString();
        }

        private void buttonZ_Click(object sender, EventArgs e)
        {
            texto.Append("Z");
            textBox.Text = texto.ToString();
        }

        private void buttonDOT_Click(object sender, EventArgs e)
        {
            texto.Append(". ");
            textBox.Text = texto.ToString();
        }

        private void buttonSEMICOLON_Click(object sender, EventArgs e)
        {
            texto.Append("; ");
            textBox.Text = texto.ToString();
        }

        private void buttonCOLON_Click(object sender, EventArgs e)
        {
            texto.Append(": ");
            textBox.Text = texto.ToString();
        }

        private void buttonLEFTEXCL_Click(object sender, EventArgs e)
        {
            texto.Append("¡");
            textBox.Text = texto.ToString();
        }

        private void buttonRIGHTEXCL_Click(object sender, EventArgs e)
        {
            texto.Append("!");
            textBox.Text = texto.ToString();
        }

        private void buttonLEFTQUEST_Click(object sender, EventArgs e)
        {
            texto.Append("¿");
            textBox.Text = texto.ToString();
        }

        private void buttonRIGHTQUEST_Click(object sender, EventArgs e)
        {
            texto.Append("?");
            textBox.Text = texto.ToString();
        }

        private void buttonSPACE_Click(object sender, EventArgs e)
        {
            texto.Append(" ");
            textBox.Text=texto.ToString();
        }

        private void buttonBORRAR_Click(object sender, EventArgs e)
        {
            texto.Clear();
            textBox.Clear();
        }

        private void button0_Click(object sender, EventArgs e)
        {
            texto.Append("0");
            textBox.Text = texto.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            texto.Append("1");
            textBox.Text = texto.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            texto.Append("2");
            textBox.Text = texto.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            texto.Append("3");
            textBox.Text = texto.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            texto.Append("4");
            textBox.Text = texto.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            texto.Append("5");
            textBox.Text = texto.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            texto.Append("6");
            textBox.Text = texto.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            texto.Append("7");
            textBox.Text = texto.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            texto.Append("8");
            textBox.Text = texto.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            texto.Append("9");
            textBox.Text = texto.ToString();
        }

        private void buttonLEER_Click(object sender, EventArgs e)
        {
            Prompt frase = new Prompt(texto.ToString());
            synth.Speak(frase);
        }

        private void FormComunicaPlus_FormClosed(object sender, FormClosedEventArgs e)
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
