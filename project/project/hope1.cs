using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    public partial class hope1 : Form
    {
        public hope1()
        {
            InitializeComponent();
        }
        private IWavePlayer outputDevice;
        private AudioFileReader audioFile;
        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {
        }
        private void hope1_Load(object sender, EventArgs e)
        
            {
                PlayBackgroundMusic(@"hope.mp4");
            }
        private void PlayBackgroundMusic(string filePath)
        {

            axWindowsMediaPlayer1.URL = filePath;

            axWindowsMediaPlayer1.settings.autoStart = true;


            axWindowsMediaPlayer1.settings.setMode("loop", true);

            axWindowsMediaPlayer1.uiMode = "none";

            axWindowsMediaPlayer1.settings.volume = 50;
        }
        private void hope1_FormClosing(object sender, FormClosingEventArgs e)
        {
           
            axWindowsMediaPlayer1.Ctlcontrols.stop();

            
            axWindowsMediaPlayer1.URL = "";
            axWindowsMediaPlayer1.close();
        }
    }
}
