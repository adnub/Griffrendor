using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Griffrendor
{
    public partial class Griffrendor : Form
    {
        private string[] args;
        private int maxBitRate = 20000; //in kbit/sec
        private String ffmpeg_logfile = "ffmpeg2pass-0.log";
        private String ffmpeg_mbtreefile = "ffmpeg2pass-0.log.mbtree";

        public Griffrendor()
        {
            InitializeComponent();
        }
        private void autoPickOutput()
        {
            int suffixNum = 1;
            string suffix = "";
            do
            {
                txtOutput.Text = Path.GetDirectoryName(txtInput.Text) + "\\" + Path.GetFileNameWithoutExtension(txtInput.Text) + "_rendered" + suffix + ".mp4";
                suffix = "_" + (suffixNum++).ToString();
            } while (File.Exists(txtOutput.Text));
        }

        private void TextBox_KeyPress_DigitsOnly(object sender, KeyPressEventArgs e)
        {
            // Only allow control characters (like backspace) and digits
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Griffrendor_Load(object sender, EventArgs e)
        {
            //Configure textboxes which should only accept numbers
            this.txtFileSize.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress_DigitsOnly);
            this.txtCutStartHours.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress_DigitsOnly);
            this.txtCutStartMinutes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress_DigitsOnly);
            this.txtCutStartSeconds.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress_DigitsOnly);
            this.txtCutStartmsec.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress_DigitsOnly);
            this.txtCutEndHours.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress_DigitsOnly);
            this.txtCutEndMinutes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress_DigitsOnly);
            this.txtCutEndSeconds.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress_DigitsOnly);
            this.txtCutEndmsec.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress_DigitsOnly);
            this.txtFramerate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress_DigitsOnly);
            this.txtResolutionHeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress_DigitsOnly);
            this.txtResolutionWidth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress_DigitsOnly);

            Console.WriteLine("Griffrendor waiting for input.");
            args = Environment.GetCommandLineArgs();
            string fileName = null;
            if (args.Length > 1 &&
                File.Exists(args[1]))
            {
                fileName = args[1];
            }
            else
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Title = "Select Video File To Convert";
                openFileDialog.InitialDirectory = ".";
                openFileDialog.RestoreDirectory = true;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    fileName = openFileDialog.FileName;
                }
                else
                {
                    return;
                }
            }
            txtInput.Text = fileName;
            autoPickOutput();
            this.BringToFront();
            this.Activate();
        }

        private void btnBrowseInput_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = ".";
            openFileDialog.RestoreDirectory = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtInput.Text = openFileDialog.FileName;
                autoPickOutput();
            }
        }

        private void btnBrowseOutput_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = ".";
            saveFileDialog.Filter = "MP4 | *.mp4";
            saveFileDialog.RestoreDirectory = true;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtOutput.Text = saveFileDialog.FileName;
            }
        }

        private void chkCutVideo_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCutVideo.Checked)
            {
                lblCutStart.Enabled = true;
                lblCutEnd.Enabled = true;
                txtCutStartHours.Enabled = true;
                txtCutStartMinutes.Enabled = true;
                txtCutStartSeconds.Enabled = true;
                txtCutStartmsec.Enabled = true;
                txtCutEndHours.Enabled = true;
                txtCutEndMinutes.Enabled = true;
                txtCutEndSeconds.Enabled = true;
                txtCutEndmsec.Enabled = true;
                lblTimeFormat.Enabled = true;
                btnCutAssistant.Enabled = true;
            }
            else
            {
                lblCutStart.Enabled = false;
                lblCutEnd.Enabled = false;
                txtCutStartHours.Enabled = false;
                txtCutStartMinutes.Enabled = false;
                txtCutStartSeconds.Enabled = false;
                txtCutStartmsec.Enabled = false;
                txtCutEndHours.Enabled = false;
                txtCutEndMinutes.Enabled = false;
                txtCutEndSeconds.Enabled = false;
                txtCutEndmsec.Enabled = false ;
                lblTimeFormat.Enabled = false;
                btnCutAssistant.Enabled = false;
            }
        }

        private void chkFrameRate_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFramerate.Checked)
            {
                txtFramerate.Enabled = true;
            }
            else
            {
                txtFramerate.Enabled = false;
            }
        }

        private void chkResolution_CheckedChanged(object sender, EventArgs e)
        {
            if (chkResolution.Checked)
            {
                txtResolutionHeight.Enabled = true;
                txtResolutionWidth.Enabled = true;
            }
            else
            {
                txtResolutionHeight.Enabled = false;
                txtResolutionWidth.Enabled = false;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            string exeDir = Path.GetDirectoryName(Application.ExecutablePath);
            string ffmpeg_path = Path.Combine(exeDir, "ffmpeg\\ffmpeg.exe");
            string ffprobe_path = Path.Combine(exeDir, "ffmpeg\\ffprobe.exe");
            int durationmsec = 0;
            int durationSeconds = 0;
            int durationRemainder = 0;
            int video_bitrate = 0;
            this.SendToBack();

            if (!File.Exists(txtInput.Text))
            {
                MessageBox.Show("Error: Unable to find video file. Make sure the path you selected exists.");
                return;
            }

            if (!File.Exists(ffprobe_path))
            {
                MessageBox.Show("Error: ffprobe not found. Expected path: " + ffprobe_path);
                return;
            }

            if (!File.Exists(ffmpeg_path))
            {
                MessageBox.Show("Error: ffmpeg not found. Expected path: " + ffmpeg_path);
                return;
            }

            //Define ffprobe process to determine video duration
            var proc_ffprobe = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = ffprobe_path,
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true
                }
            };

            //Define ffmpeg process to do the heavy lifiting
            var proc_ffmpeg = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = ffmpeg_path,
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow = false
                }
            };

            //Default parameters
            String ffmpeg_audio = "-an";
            String ffmpeg_starttime = "";
            String ffmpeg_duration = "";
            String ffmpeg_resolution = "";
            String ffmpeg_framerate = "";
            String ffmpeg_preset = "-preset medium";

            if (chkSlowEncode.Checked)
            {
                ffmpeg_preset = "-preset veryslow";
            }

            if (chkCutVideo.Checked)
            {
                int startMiliSeconds = ((int.Parse(txtCutStartHours.Text) * 3600 + int.Parse(txtCutStartMinutes.Text) * 60 + int.Parse(txtCutStartSeconds.Text)) * 1000) + int.Parse(txtCutStartmsec.Text);
                int endMiliSeconds = ((int.Parse(txtCutEndHours.Text) * 3600 + int.Parse(txtCutEndMinutes.Text) * 60 + int.Parse(txtCutEndSeconds.Text)) * 1000) + int.Parse(txtCutEndmsec.Text);
                durationmsec = endMiliSeconds - startMiliSeconds;
                durationSeconds = durationmsec / 1000;
                durationRemainder = durationmsec % 1000;
                ffmpeg_starttime = "-ss " + txtCutStartHours.Text + ":" + txtCutStartMinutes.Text + ":" + txtCutStartSeconds.Text + "." + txtCutStartmsec.Text;
                ffmpeg_duration = "-t " + durationSeconds + "." + durationRemainder;
            }
            else
            {
                //Read video information to get duration if no specific cut is specified.
                try
                {
                    proc_ffprobe.StartInfo.Arguments = "-v error -show_entries format=duration -of default=noprint_wrappers=1:nokey=1 \"" + txtInput.Text + "\"";
                    proc_ffprobe.Start();
                    while (!proc_ffprobe.StandardOutput.EndOfStream)
                    {
                        string line = proc_ffprobe.StandardOutput.ReadLine();
                        durationmsec = ((int)Math.Ceiling(double.Parse(line, new CultureInfo("en-US"))) * 1000);
                        durationSeconds = durationmsec / 1000;
                        durationRemainder = durationmsec % 1000;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Failed to get video duration, are you sure it's a video file?", "Failed to get video duration");
                    return;
                }
            }

            if (durationmsec <= 0)
            {
                MessageBox.Show("Error: Video duration is " + durationmsec.ToString() + " miliseconds. Video file may be incompatible or incorrect input in cut video fields.");
                return;
            }

            //Calculate bitrate in kbit/s
            int int_filesize = int.Parse(txtFileSize.Text);
            video_bitrate = int_filesize * 8000000 / durationmsec;

            if (!chkUncapBitrate.Checked)
            {
                if (video_bitrate > maxBitRate) video_bitrate = maxBitRate;
            }

            if (chkAudio.Checked)
            {
                ffmpeg_audio = "-c:a aac -b:a 128k";
                video_bitrate -= 128;
            }

            if (chkFramerate.Checked)
            {
                ffmpeg_framerate = "-r " + txtFramerate.Text;
            }

            if (chkResolution.Checked)
            {
                ffmpeg_resolution = "-vf scale=" + txtResolutionWidth.Text + ":" + txtResolutionHeight.Text;
            }
            try
            {
                //Perform analysis pass using ffmpeg
                string ffmpegBaseArgs = "-y " + ffmpeg_starttime + " " + ffmpeg_duration + " -i \"" + txtInput.Text + "\" " + ffmpeg_resolution + " -c:v libx264 -b:v " + Convert.ToString(video_bitrate) + "k " + ffmpeg_framerate + " " + ffmpeg_preset;
                proc_ffmpeg.StartInfo.Arguments = ffmpegBaseArgs + " -pass 1 -vsync cfr -f null nul";
                proc_ffmpeg.Start();
                proc_ffmpeg.WaitForExit();
                if (proc_ffmpeg.ExitCode != 0) { MessageBox.Show("ffmpeg pass 1 failed with exit code " + proc_ffmpeg.ExitCode); return; }

                //Perform encoding pass using ffmpeg
                proc_ffmpeg.StartInfo.Arguments = ffmpegBaseArgs + " -pass 2 " + ffmpeg_audio + " \"" + txtOutput.Text + "\"";
                proc_ffmpeg.Start();
                proc_ffmpeg.WaitForExit();
                if (proc_ffmpeg.ExitCode != 0) { MessageBox.Show("ffmpeg pass 2 failed with exit code " + proc_ffmpeg.ExitCode); return; }
            }
            finally
            {
                //Clean up FFMPEG files
                File.Delete(ffmpeg_logfile);
                File.Delete(ffmpeg_mbtreefile);
            }

            MessageBox.Show("Done!");
            this.BringToFront();
            this.Activate();
        }

        private void btnCutAssistant_Click(object sender, EventArgs e)
        {
            //TODO: Add sanity check to see if video source field is filled in.
            CutAssistant cutAssistant = new CutAssistant(txtInput.Text, this);
            cutAssistant.Show();
        }

        public void setCutTimes(int starttime, int endtime)
        {
            int buffer;
            txtCutStartmsec.Text = (starttime % 1000).ToString("000");
            buffer = starttime / 1000;
            txtCutStartSeconds.Text = (buffer % 60).ToString("00");
            buffer = buffer / 60;
            txtCutStartMinutes.Text = (buffer % 60).ToString("00");
            buffer = buffer / 60;
            txtCutStartHours.Text = buffer.ToString("00");

            txtCutEndmsec.Text = (endtime % 1000).ToString("000");
            buffer = endtime / 1000;
            txtCutEndSeconds.Text = (buffer % 60).ToString("00");
            buffer = buffer / 60;
            txtCutEndMinutes.Text = (buffer % 60).ToString("00");
            buffer = buffer / 60;
            txtCutEndHours.Text = buffer.ToString("00");
        }
    }
}
