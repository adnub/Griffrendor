using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Globalization;
 
public class GriffRendor : Form
{
    private Label lblInput;
    private TextBox txtInput;
    private Button btnBrowseInput;
    private Label lblOutput;
    private TextBox txtOutput;
    private Button btnBrowseOutput;
    private Label lblFilesize;
    private TextBox txtFilesize;
    private Button btnStart;
    private CheckBox chkAudio;
    private Label lblOptionalSettings;
    private CheckBox chkCutVideo;
    private Label lblCutStart;
    private TextBox txtCutStartHours;
    private TextBox txtCutStartMinutes;
    private TextBox txtCutStartSeconds;
    private Label lblCutEnd;
    private TextBox txtCutEndHours;
    private TextBox txtCutEndMinutes;
    private TextBox txtCutEndSeconds;
    private CheckBox chkFramerate;
    private TextBox txtFramerate;
    private CheckBox chkResolution;
    private TextBox txtResolutionWidth;
    private TextBox txtResolutionHeigth;
    private CheckBox chkSlowEncode;

    private String strDirSeperator;
    private String ffmpeg_logfile = "ffmpeg2pass-0.log";
    private String ffmpeg_mbtreefile = "ffmpeg2pass-0.log.mbtree";

    private string[] args;

    public GriffRendor (string[] args)
    {
        this.args = args;
        Font font = new Font("Liberation Sans", 12);

        //Set OS specific settings
        if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows)) {
            font = new Font("Arial", 12);
            strDirSeperator = "\\";
        }
        else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux)) {
            font = new Font("Liberation Sans", 12);
            strDirSeperator = "/";
        }

        //Define and build form and controls
        AutoSizeMode = AutoSizeMode.GrowOnly;
        AutoSize = true;
        Text = "GriffRendor";
        FormBorderStyle = FormBorderStyle.Sizable;
        SizeGripStyle = SizeGripStyle.Show;
        MaximizeBox = false;
        SuspendLayout();
        this.Load += new EventHandler(GriffRendor_Load);

        lblInput = new Label();
        lblInput.Text = "Input Video:";
        lblInput.Location = new Point(10,10);
        lblInput.Size = new Size(120,20);
        lblInput.Font = font;
        Controls.Add(lblInput);

        txtInput = new TextBox();
        txtInput.Location = new Point(lblInput.Location.X + lblInput.Size.Width + 10, lblInput.Location.Y);
        txtInput.Size = new Size(600, lblInput.Size.Height);
        Controls.Add(txtInput);

        btnBrowseInput = new Button ();
        btnBrowseInput.Text = "...";
        btnBrowseInput.Location = new Point(750,lblInput.Location.Y);
        btnBrowseInput.Size = new Size(30,20);
        btnBrowseInput.Click += new EventHandler (btnBrowseInput_Click);
        Controls.Add(btnBrowseInput);

        lblOutput = new Label();
        lblOutput.Text = "Output Video:";
        lblOutput.Location = new Point(lblInput.Location.X, lblInput.Location.Y + lblInput.Size.Height + 5);
        lblOutput.Size = new Size(lblInput.Size.Width, lblInput.Size.Height);
        lblOutput.Font = font;
        Controls.Add(lblOutput);

        txtOutput = new TextBox();
        txtOutput.Location = new Point(lblOutput.Location.X + lblOutput.Size.Width + 10, lblOutput.Location.Y);
        txtOutput.Size = new Size(txtInput.Size.Width, lblOutput.Size.Height);
        Controls.Add(txtOutput);

        btnBrowseOutput = new Button ();
        btnBrowseOutput.Text = "...";
        btnBrowseOutput.Location = new Point(750,lblOutput.Location.Y);
        btnBrowseOutput.Size = new Size(30,20);
        btnBrowseOutput.Click += new EventHandler (btnBrowseOutput_Click);
        Controls.Add(btnBrowseOutput);

        lblFilesize = new Label();
        lblFilesize.Text = "Filesize (in MB):";
        lblFilesize.Location = new Point(lblOutput.Location.X, lblOutput.Location.Y + lblOutput.Size.Height + 5);
        lblFilesize.Size = new Size(lblOutput.Size.Width, lblOutput.Size.Height);
        lblFilesize.Font = font;
        Controls.Add(lblFilesize);

        txtFilesize = new TextBox();
        txtFilesize.Location = new Point(lblFilesize.Location.X + lblFilesize.Size.Width + 10, lblFilesize.Location.Y);
        txtFilesize.Size = new Size(100, lblFilesize.Size.Height);
        txtFilesize.Text = Convert.ToString(100);
        Controls.Add(txtFilesize);

        chkAudio = new CheckBox();
        chkAudio.Location = new Point(txtFilesize.Location.X + txtFilesize.Size.Width + 10, txtFilesize.Location.Y);
        chkAudio.Size = new Size(200, txtFilesize.Size.Height);
        chkAudio.Text = "Enable Audio";
        chkAudio.Font = font;
        Controls.Add(chkAudio);

        btnStart = new Button ();
        btnStart.Text = "START!";
        btnStart.Location = new Point(660,lblFilesize.Location.Y);
        btnStart.Size = new Size(120,40);
        btnStart.Font = font;
        btnStart.Click += new EventHandler (btnStart_Click);
        Controls.Add(btnStart);

        lblOptionalSettings = new Label();
        lblOptionalSettings.Text = "Optional settings";
        lblOptionalSettings.Location = new Point(lblFilesize.Location.X, lblFilesize.Location.Y + lblFilesize.Size.Height + 15);
        lblOptionalSettings.Size = new Size(lblFilesize.Size.Width, lblFilesize.Size.Height);
        lblOptionalSettings.Font = font;
        Controls.Add(lblOptionalSettings);

        chkCutVideo = new CheckBox();
        chkCutVideo.Text = "Cut Video";
        chkCutVideo.Location = new Point(lblOptionalSettings.Location.X, lblOptionalSettings.Location.Y + lblOptionalSettings.Size.Height + 5);
        chkCutVideo.Size = new Size(lblOptionalSettings.Size.Width, lblOptionalSettings.Size.Height);
        chkCutVideo.Font = font;
        chkCutVideo.CheckedChanged += new EventHandler(chkCutVideo_CheckedChanged);
        Controls.Add(chkCutVideo);

        lblCutStart = new Label();
        lblCutStart.Text = "Start";
        lblCutStart.Enabled = false;
        lblCutStart.Location = new Point(chkCutVideo.Location.X, chkCutVideo.Location.Y + chkCutVideo.Size.Height + 5);
        lblCutStart.Size = new Size(45, chkCutVideo.Size.Height);
        lblCutStart.Font = font;
        Controls.Add(lblCutStart);

        txtCutStartHours = new TextBox();
        txtCutStartHours.Text = "0";
        txtCutStartHours.Enabled = false;
        txtCutStartHours.Location = new Point(lblCutStart.Location.X + lblCutStart.Size.Width + 5, lblCutStart.Location.Y);
        txtCutStartHours.Size = new Size(25, lblCutStart.Size.Height);
        Controls.Add(txtCutStartHours);

        txtCutStartMinutes = new TextBox();
        txtCutStartMinutes.Text = "0";
        txtCutStartMinutes.Enabled = false;
        txtCutStartMinutes.Location = new Point(txtCutStartHours.Location.X + txtCutStartHours.Size.Width + 5, txtCutStartHours.Location.Y);
        txtCutStartMinutes.Size = new Size(txtCutStartHours.Size.Width, txtCutStartHours.Size.Height);
        Controls.Add(txtCutStartMinutes);

        txtCutStartSeconds = new TextBox();
        txtCutStartSeconds.Text = "0";
        txtCutStartSeconds.Enabled = false;
        txtCutStartSeconds.Location = new Point(txtCutStartMinutes.Location.X + txtCutStartMinutes.Size.Width + 5, txtCutStartMinutes.Location.Y);
        txtCutStartSeconds.Size = new Size(txtCutStartMinutes.Size.Width, txtCutStartMinutes.Size.Height);
        Controls.Add(txtCutStartSeconds);

        lblCutEnd = new Label();
        lblCutEnd.Text = "End";
        lblCutEnd.Enabled = false;
        lblCutEnd.Location = new Point(txtCutStartSeconds.Location.X + txtCutStartSeconds.Size.Width + 10, txtCutStartSeconds.Location.Y);
        lblCutEnd.Size = new Size(35, txtCutStartSeconds.Size.Height);
        lblCutEnd.Font = font;
        Controls.Add(lblCutEnd);

        txtCutEndHours = new TextBox();
        txtCutEndHours.Text = "0";
        txtCutEndHours.Enabled = false;
        txtCutEndHours.Location = new Point(lblCutEnd.Location.X + lblCutEnd.Size.Width + 5, lblCutEnd.Location.Y);
        txtCutEndHours.Size = new Size(txtCutStartSeconds.Size.Width, txtCutStartSeconds.Size.Height);
        Controls.Add(txtCutEndHours);

        txtCutEndMinutes = new TextBox();
        txtCutEndMinutes.Text = "0";
        txtCutEndMinutes.Enabled = false;
        txtCutEndMinutes.Location = new Point(txtCutEndHours.Location.X + txtCutEndHours.Size.Width + 5, txtCutEndHours.Location.Y);
        txtCutEndMinutes.Size = new Size(txtCutEndHours.Size.Width, txtCutEndHours.Size.Height);
        Controls.Add(txtCutEndMinutes);

        txtCutEndSeconds = new TextBox();
        txtCutEndSeconds.Text = "0";
        txtCutEndSeconds.Enabled = false;
        txtCutEndSeconds.Location = new Point(txtCutEndMinutes.Location.X + txtCutEndMinutes.Size.Width + 5, txtCutEndMinutes.Location.Y);
        txtCutEndSeconds.Size = new Size(txtCutEndMinutes.Size.Width, txtCutEndMinutes.Size.Height);
        Controls.Add(txtCutEndSeconds);

        chkFramerate = new CheckBox();
        chkFramerate.Text = "Change Framerate (Unchecked = Same as source)";
        chkFramerate.Location = new Point(lblCutStart.Location.X, lblCutStart.Location.Y + lblCutStart.Size.Height + 15);
        chkFramerate.Size = new Size(400, lblCutStart.Size.Height);
        chkFramerate.Font = font;
        chkFramerate.CheckedChanged += new EventHandler(chkFramerate_CheckedChanged);
        Controls.Add(chkFramerate);

        txtFramerate = new TextBox();
        txtFramerate.Text = "30";
        txtFramerate.Enabled = false;
        txtFramerate.Location = new Point(chkFramerate.Location.X + chkFramerate.Size.Width + 5, chkFramerate.Location.Y);
        txtFramerate.Size = new Size(40, chkFramerate.Size.Height);
        Controls.Add(txtFramerate);

        chkResolution = new CheckBox();
        chkResolution.Text = "Change Resolution (Unchecked = Same as source)";
        chkResolution.Location = new Point(chkFramerate.Location.X, chkFramerate.Location.Y + chkFramerate.Size.Height + 15);
        chkResolution.Size = new Size(400, chkFramerate.Size.Height);
        chkResolution.Font = font;
        chkResolution.CheckedChanged += new EventHandler(chkResolution_CheckedChanged);
        Controls.Add(chkResolution);

        txtResolutionWidth = new TextBox();
        txtResolutionWidth.Text = "1280";
        txtResolutionWidth.Enabled = false;
        txtResolutionWidth.Location = new Point(chkResolution.Location.X + chkResolution.Size.Width + 5, chkResolution.Location.Y);
        txtResolutionWidth.Size = new Size(40, chkResolution.Size.Height);
        Controls.Add(txtResolutionWidth);

        txtResolutionHeigth = new TextBox();
        txtResolutionHeigth.Text = "720";
        txtResolutionHeigth.Enabled = false;
        txtResolutionHeigth.Location = new Point(txtResolutionWidth.Location.X + txtResolutionWidth.Size.Width + 5, txtResolutionWidth.Location.Y);
        txtResolutionHeigth.Size = new Size(40, txtResolutionWidth.Size.Height);
        Controls.Add(txtResolutionHeigth);

        chkSlowEncode = new CheckBox();
        chkSlowEncode.Text = "Slow Encode (Improves quality, but takes way longer to render)";
        chkSlowEncode.Location = new Point(chkResolution.Location.X, chkResolution.Location.Y + chkResolution.Size.Height + 15);
        chkSlowEncode.Size = new Size(500, chkResolution.Size.Height);
        chkSlowEncode.Font = font;
        Controls.Add(chkSlowEncode);

        ResumeLayout(true);
        CenterToScreen();
    }
    
    private void GriffRendor_Load (object sender, EventArgs e) {
        string fileName = null;
        if (args.Length > 0 &&
            File.Exists(args[0])) {
            fileName = args[0];
        } else {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Select Video File To Convert";
            openFileDialog.InitialDirectory = ".";
            openFileDialog.RestoreDirectory = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK) {
                fileName = openFileDialog.FileName;
            } else {
                return;
            }
        }
        txtInput.Text = fileName;
        txtOutput.Text = Path.GetDirectoryName(fileName) + strDirSeperator + Path.GetFileNameWithoutExtension(fileName) + "_rendered.mp4";
    }

    private void btnBrowseInput_Click (object sender, EventArgs e) {
        OpenFileDialog openFileDialog = new OpenFileDialog();
        openFileDialog.InitialDirectory = ".";
        openFileDialog.RestoreDirectory = true;
        if (openFileDialog.ShowDialog() == DialogResult.OK) {
            txtInput.Text = openFileDialog.FileName;
            txtOutput.Text = Path.GetDirectoryName(openFileDialog.FileName) + strDirSeperator + Path.GetFileNameWithoutExtension(openFileDialog.FileName) + "_rendered.mp4";
        }
    }

    private void btnBrowseOutput_Click (object sender, EventArgs e) {
        SaveFileDialog saveFileDialog = new SaveFileDialog();
        saveFileDialog.InitialDirectory = ".";
        saveFileDialog.Filter = "MP4 | *.mp4";
        saveFileDialog.RestoreDirectory = true;
        if (saveFileDialog.ShowDialog() == DialogResult.OK) {
            txtOutput.Text = saveFileDialog.FileName;
        }
    }

    private void chkCutVideo_CheckedChanged (object sender, EventArgs e) {
        if (chkCutVideo.Checked) {
            lblCutStart.Enabled = true;
            lblCutEnd.Enabled = true;
            txtCutStartHours.Enabled = true;
            txtCutStartMinutes.Enabled = true;
            txtCutStartSeconds.Enabled = true;
            txtCutEndHours.Enabled = true;
            txtCutEndMinutes.Enabled = true;
            txtCutEndSeconds.Enabled = true;
        }
        else {
            lblCutStart.Enabled = false;
            lblCutEnd.Enabled = false;
            txtCutStartHours.Enabled = false;
            txtCutStartMinutes.Enabled = false;
            txtCutStartSeconds.Enabled = false;
            txtCutEndHours.Enabled = false;
            txtCutEndMinutes.Enabled = false;
            txtCutEndSeconds.Enabled = false;
        }
    }

    private void chkFramerate_CheckedChanged (object sender, EventArgs e) {
        if (chkFramerate.Checked) {
            txtFramerate.Enabled = true;
        }
        else {
            txtFramerate.Enabled = false;
        }
    }

    private void chkResolution_CheckedChanged (object sender, EventArgs e) {
        if (chkResolution.Checked) {
            txtResolutionHeigth.Enabled = true;
            txtResolutionWidth.Enabled = true;
        }
        else {
            txtResolutionHeigth.Enabled = false;
            txtResolutionWidth.Enabled = false;
        }
    }

    private void btnStart_Click (object sender, EventArgs e) {
        String ffmpeg_path = "";
        String ffprobe_path = "";
        int duration = 0;
        int video_bitrate = 0;

        if (!File.Exists(txtInput.Text)) {
            MessageBox.Show("Error: Unable to find video file. Make sure the path you selected exists.");
            return;
        }

        if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows)) {
            ffmpeg_path = "Windows\\ffmpeg.exe";
            ffprobe_path = "Windows\\ffprobe.exe";
        }
        else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux)) {
            ffmpeg_path = "Linux/ffmpeg";
            ffprobe_path = "Linux/ffprobe";
        }

        if (!File.Exists(ffprobe_path)) {
            MessageBox.Show("Error: ffprobe not found. Expected path: " + ffprobe_path);
            return;
        }

        if (!File.Exists(ffmpeg_path)) {
            MessageBox.Show("Error: ffmpeg not found. Expected path: " + ffmpeg_path);
            return;
        }

        //Define ffprobe process to determine video duration
        var proc_ffprobe = new Process {
            StartInfo = new ProcessStartInfo
            {
                FileName = ffprobe_path,
                UseShellExecute = false,
                RedirectStandardOutput = true,
                CreateNoWindow = false
            }
        };

        //Define ffmpeg process to do the heavy lifiting
        var proc_ffmpeg = new Process {
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

        if (chkSlowEncode.Checked) {
            ffmpeg_preset = "-preset veryslow";
        }

        if (chkCutVideo.Checked) {
            int startSeconds = int.Parse(txtCutStartHours.Text)*3600 + int.Parse(txtCutStartMinutes.Text)*60 + int.Parse(txtCutStartSeconds.Text);
            int endSeconds = int.Parse(txtCutEndHours.Text)*3600 + int.Parse(txtCutEndMinutes.Text)*60 + int.Parse(txtCutEndSeconds.Text);
            duration = endSeconds - startSeconds;
            ffmpeg_starttime = "-ss " + txtCutStartHours.Text + ":" + txtCutStartMinutes.Text + ":" + txtCutStartSeconds.Text;
            ffmpeg_duration = "-t " + duration;
        }
        else{
            //Read video information to get duration if no specific cut is specified.
            proc_ffprobe.StartInfo.Arguments = "-v error -show_entries format=duration -of default=noprint_wrappers=1:nokey=1 \"" + txtInput.Text + "\"";
            proc_ffprobe.Start();
            while (!proc_ffprobe.StandardOutput.EndOfStream) {
                string line = proc_ffprobe.StandardOutput.ReadLine();
                duration = (int)Math.Ceiling(double.Parse(line, new CultureInfo("en-US")));
            }
        }

        if (duration <= 0) {
            MessageBox.Show("Error: Video duration is " + duration.ToString() + " seconds. Video file may be incompatible or incorrect input in cut video fields.");
            return;
        }

        //Calculate bitrate in kbit/s
        int int_filesize = int.Parse(txtFilesize.Text);
        video_bitrate = int_filesize * 8000 / duration;
        if (chkAudio.Checked) {
            ffmpeg_audio = "-c:a aac -b:a 128k";
            video_bitrate -= 128;
        }

        if (chkFramerate.Checked) {
            ffmpeg_framerate = "-r " + txtFramerate.Text;
        }

        if (chkResolution.Checked) {
            ffmpeg_resolution = "-vf scale=" + txtResolutionWidth.Text + ":" + txtResolutionHeigth.Text;
        }
        
        //Perform analysis pass using ffmpeg
        proc_ffmpeg.StartInfo.Arguments = "-y " + ffmpeg_starttime + " " + ffmpeg_duration + " -i \"" + txtInput.Text + "\" " + ffmpeg_resolution + " -c:v libx264 -b:v " + Convert.ToString(video_bitrate) + "k -pass 1 -vsync cfr " + ffmpeg_framerate + " " + ffmpeg_preset + " -f null nul";
        proc_ffmpeg.Start();
        proc_ffmpeg.WaitForExit();

        //Perform encoding pass using ffmpeg
        proc_ffmpeg.StartInfo.Arguments = "-y " + ffmpeg_starttime + " " + ffmpeg_duration + " -i \"" + txtInput.Text + "\" " + ffmpeg_resolution + " -c:v libx264 -b:v " + Convert.ToString(video_bitrate) + "k -pass 2 " + ffmpeg_audio + " " + ffmpeg_framerate + " " + ffmpeg_preset + " \"" + txtOutput.Text + "\"";
        proc_ffmpeg.Start();
        proc_ffmpeg.WaitForExit();

        //Clean up FFMPEG files
        File.Delete(ffmpeg_logfile);
        File.Delete(ffmpeg_mbtreefile);

        MessageBox.Show("Done!");
    }

    [STAThread]
    static public void Main (string[] args)
    {
        Application.Run (new GriffRendor(args));
    }
}