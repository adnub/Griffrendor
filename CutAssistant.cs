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
        private LibVLC _libVLC;
        private MediaPlayer _mediaPlayer;
        private Media _media;
        private Griffrendor mainForm;
        private string path;
        private int startTimems;
        private int endTimems;

        public CutAssistant(string videoPath, Griffrendor callingForm)
        {
            InitializeComponent();
            Core.Initialize();
            _libVLC = new LibVLC();
            _mediaPlayer = new MediaPlayer(_libVLC);
            videoView.MediaPlayer = _mediaPlayer;
            path = videoPath;
            mainForm = callingForm;
        }

        private string milisecondsToTimeString(int totalMiliseconds)
        {
            int hours;
            int minutes;
            int seconds;
            int miliseconds;
            int buffer;

            miliseconds = totalMiliseconds % 1000;
            buffer = totalMiliseconds / 1000;
            seconds = buffer % 60;
            buffer = buffer / 60;
            minutes = buffer % 60;
            hours = buffer / 60;

            return hours.ToString("00") + ":" + minutes.ToString("00") + ":" + seconds.ToString("00") + "." + miliseconds.ToString("000");
        }

        private void btnPlayPause_Click(object sender, EventArgs e)
        {
            if (_mediaPlayer.IsPlaying)
            {
                btnStepForward.Enabled = true;
                btnStepBack.Enabled = true;
                _mediaPlayer.Pause();
                btnPlayPause.Text = ">";
            }
            else
            {
                btnStepBack.Enabled = false;
                btnStepForward.Enabled = false;
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

            //Sometimes it takes a while to initialize. Wait for video to be properly loaded before initializing trackbar and labels.
            while ((int)_mediaPlayer.Length == 0)
            {
                Thread.Sleep(100);
            }
            trckTimeLine.Maximum = (int)_mediaPlayer.Length; //Yeah, I know. Casting to int will break things if the video is too long. But if they're shoving a video in this tool that's more than 600 hours long it's on the user at that point.
            lblTotalLength.Text = milisecondsToTimeString((int)_mediaPlayer.Length);

            //Attaching trackbar to playback position
            _mediaPlayer.PositionChanged += (s, ev) => trckTimeLine.Invoke(new Action(() =>
            {
                trckTimeLine.Value = (int)(_mediaPlayer.Time);
            }));

            _mediaPlayer.TimeChanged += (s, ev) => lblCurrentPosition.Invoke(new Action(() =>
            {
                lblCurrentPosition.Text = milisecondsToTimeString((int)_mediaPlayer.Time);
            }));
            startTimems = 0;
            endTimems = (int)_mediaPlayer.Length;

            lblStartTime.Text = "Start Time: " + milisecondsToTimeString(startTimems);
            lblEndTime.Text = "End Time: " + milisecondsToTimeString(endTimems);
        }

        private void trckTimeLine_Scroll(object sender, EventArgs e)
        {
            _mediaPlayer.Time = trckTimeLine.Value;
            lblCurrentPosition.Text = milisecondsToTimeString((int)_mediaPlayer.Time);
        }

        private void btnStepForward_Click(object sender, EventArgs e)
        {
            _mediaPlayer.Time = _mediaPlayer.Time + 1000;
            trckTimeLine.Value = (int)(_mediaPlayer.Time);
            lblCurrentPosition.Text = milisecondsToTimeString((int)_mediaPlayer.Time);
        }

        private void btnStepBack_Click(object sender, EventArgs e)
        {
            _mediaPlayer.Time = _mediaPlayer.Time - 1000;
            trckTimeLine.Value = (int)(_mediaPlayer.Time);
            lblCurrentPosition.Text = milisecondsToTimeString((int)_mediaPlayer.Time);
        }

        private void rad025X_CheckedChanged(object sender, EventArgs e)
        {
            if(rad025X.Checked)
            {
                _mediaPlayer.SetRate(0.25f);
            }
        }

        private void rad05X_CheckedChanged(object sender, EventArgs e)
        {
            if (rad05X.Checked)
            {
                _mediaPlayer.SetRate(0.5f);
            }
        }

        private void rad1X_CheckedChanged(object sender, EventArgs e)
        {
            if (rad1X.Checked)
            {
                _mediaPlayer.SetRate(1.0f);
            }
        }

        private void btnStartTime_Click(object sender, EventArgs e)
        {
            startTimems = (int)_mediaPlayer.Time;
            if (startTimems > endTimems)
            {
                endTimems = startTimems;
            }
            lblStartTime.Text = "Start Time: " + milisecondsToTimeString(startTimems);
            lblEndTime.Text = "End Time: " + milisecondsToTimeString(endTimems);
        }

        private void btnEndTime_Click(object sender, EventArgs e)
        {
            endTimems = (int)_mediaPlayer.Time;
            if (endTimems < startTimems) {
                startTimems = endTimems;
            }
            lblStartTime.Text = "Start Time: " + milisecondsToTimeString(startTimems);
            lblEndTime.Text = "End Time: " + milisecondsToTimeString(endTimems);
        }

        private void btnCut_Click(object sender, EventArgs e)
        {
            mainForm.setCutTimes(startTimems, endTimems);
            this.Hide();
        }
    }
}
