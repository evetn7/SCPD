using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace SCPDRadioSounds
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode.ToString() == "A")
               // MessageBox.Show("You just pressed the A button");

            SoundPlayer RadioClicks = new SoundPlayer(@"C:\Users\evetn\source\repos\SCPDRadioSounds\SCPDRadioSounds\Sounds\mic_click_on.wav");
            if (e.KeyCode.ToString() == "B")
                RadioClicks.Play();
               // RadioClicks.Stop();
            
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            SoundPlayer RadioClicks = new SoundPlayer(@"C:\Users\evetn\source\repos\SCPDRadioSounds\SCPDRadioSounds\Sounds\mic_click_off.wav");
            if (e.KeyCode.ToString() == "B")
                RadioClicks.Play();
               // RadioClicks.Stop();
        }
    }
}
