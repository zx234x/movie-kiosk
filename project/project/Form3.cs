using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace project
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        private IWavePlayer outputDevice; 
        private AudioFileReader audioFile;
        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            PlayBackgroundMusic(@"videoplayback.mp4");
        }
        private void PlayBackgroundMusic(string filePath)
        {
            
            axWindowsMediaPlayer1.URL = filePath;
           
            axWindowsMediaPlayer1.settings.autoStart = true;
            

            axWindowsMediaPlayer1.settings.setMode("loop", true);
           
            axWindowsMediaPlayer1.uiMode = "none";

            axWindowsMediaPlayer1.settings.volume = 50;

        }
        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            // 1. 재생을 완전히 정지시킵니다.
            axWindowsMediaPlayer1.Ctlcontrols.stop();

            // 2. 연결된 파일을 해제하고 플레이어 리소스를 정리합니다.
            axWindowsMediaPlayer1.URL = "";
            axWindowsMediaPlayer1.close();
        }
    }
}

