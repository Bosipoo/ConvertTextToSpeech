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
using System.IO; 

namespace ConvertTextToSpeech
{
    public partial class Form1 : Form
    {
        SpeechSynthesizer synth = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void speak_Click(object sender, EventArgs e)
        {
            try
            {
                switch (cb_voicetype.SelectedIndex)
                {
                    case 0:
                        synth.SelectVoiceByHints(VoiceGender.NotSet);
                        break;
                    case 1:
                        synth.SelectVoiceByHints(VoiceGender.Male);
                        break;
                    case 2:
                        synth.SelectVoiceByHints(VoiceGender.Female);
                        break;
                    case 3:
                        synth.SelectVoiceByHints(VoiceGender.Neutral);
                        break;

                }
                synth.SpeakAsync(textBox1.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pause_Click(object sender, EventArgs e)
        {
            try
            {
                synth.Pause();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            synth = new SpeechSynthesizer();
        }

        private void resume_Click(object sender, EventArgs e)
        {
            try
            {
                synth.Resume();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            try
            {
                using(SaveFileDialog file = new SaveFileDialog())
                {
                    file.Filter = "Wav files|*.wav";
                    file.Title = "Save to Wav File";
                    if(file.ShowDialog() == DialogResult.OK)
                    {
                        FileStream fs = new FileStream(file.FileName, FileMode.Create, FileAccess.Write);
                        synth.SetOutputToWaveStream(fs);
                        synth.Speak(textBox1.Text);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
