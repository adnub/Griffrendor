using LibVLCSharp.Shared;
using LibVLCSharp.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Griffrendor
{
    public partial class CutAssistant : Form
    {
        public LibVLC _libVLC;
        public MediaPlayer _mediaPlayer;
        public Media _media;
        private string path;

        public CutAssistant(string videoPath)
        {
            InitializeComponent();
            Core.Initialize();
            _libVLC = new LibVLC();
            _mediaPlayer = new MediaPlayer(_libVLC);
            videoView.MediaPlayer = _mediaPlayer;
            path = videoPath;
        }

        private void btnPlayPause_Click(object sender, EventArgs e)
        {
            if (_mediaPlayer.IsPlaying)
            {
                _mediaPlayer.Pause();
                btnPlayPause.Text = ">";
            }
            else
            {
                if ((_mediaPlayer.State == VLCState.Stopped) || (_mediaPlayer.State == VLCState.Error) || (_mediaPlayer.State == VLCState.Ended))
                {
                    _mediaPlayer.Play(_media);
                }
                else
                {
                    _mediaPlayer.Play();
                }
                btnPlayPause.Text = "| |";
            }
        }

        private void CutAssistant_Load(object sender, EventArgs e)
        {
            _media = new Media(_libVLC, new Uri(path));
            _mediaPlayer.Play(_media);
            
            //Working around a bug in the VLC library which doesn't allow to stop on the first frame.
            Thread.Sleep(100);
            _mediaPlayer.Pause();
            _mediaPlayer.SeekTo(TimeSpan.Zero);

            trckTimeLine.Maximum = (int)_mediaPlayer.Length;

            //Attaching trackbar to playback position
            _mediaPlayer.PositionChanged += (s, ev) => trckTimeLine.Invoke(new Action(() =>
            {
                trckTimeLine.Value = (int)(_mediaPlayer.Position * _mediaPlayer.Length);
            }));
        }

        private void trckTimeLine_Scroll(object sender, EventArgs e)
        {
            _mediaPlayer.Position = trckTimeLine.Value / (float)trckTimeLine.Maximum;
        }
    }
}
