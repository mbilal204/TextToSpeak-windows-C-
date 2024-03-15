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

namespace TextToSpeak
{
    public partial class Form1 : Form
    {
        private SpeechSynthesizer synthesizer;
        public Form1()
        {
            InitializeComponent();
            synthesizer = new SpeechSynthesizer();
        }
        private void btnSpeak_Click(object sender, EventArgs e)
        {
            string inputString = txtInput.Text;
            if (!string.IsNullOrEmpty(inputString))
            {
                try
                {
                    synthesizer.SpeakAsync(inputString);

                    // Update status label
                   // lblStatus.Text = "Speaking...";
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else
            {
                MessageBox.Show("Please enter text to speak.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}