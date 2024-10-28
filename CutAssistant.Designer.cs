namespace Griffrendor
{
    partial class CutAssistant
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CutAssistant));
            this.videoView = new LibVLCSharp.WinForms.VideoView();
            this.btnPlayPause = new System.Windows.Forms.Button();
            this.trckTimeLine = new System.Windows.Forms.TrackBar();
            this.lblCurrentPosition = new System.Windows.Forms.Label();
            this.lblTotalLength = new System.Windows.Forms.Label();
            this.lblTimeSeperator = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.btnStepForward = new System.Windows.Forms.Button();
            this.btnStepBack = new System.Windows.Forms.Button();
            this.rad025X = new System.Windows.Forms.RadioButton();
            this.grpPlaybackSpeed = new System.Windows.Forms.GroupBox();
            this.rad1X = new System.Windows.Forms.RadioButton();
            this.rad05X = new System.Windows.Forms.RadioButton();
            this.lblStartTime = new System.Windows.Forms.Label();
            this.lblEndTime = new System.Windows.Forms.Label();
            this.btnStartTime = new System.Windows.Forms.Button();
            this.btnEndTime = new System.Windows.Forms.Button();
            this.btnCut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.videoView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trckTimeLine)).BeginInit();
            this.grpPlaybackSpeed.SuspendLayout();
            this.SuspendLayout();
            // 
            // videoView
            // 
            this.videoView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.videoView.BackColor = System.Drawing.Color.Black;
            this.videoView.Location = new System.Drawing.Point(1, 2);
            this.videoView.MediaPlayer = null;
            this.videoView.Name = "videoView";
            this.videoView.Size = new System.Drawing.Size(798, 404);
            this.videoView.TabIndex = 0;
            this.videoView.Text = "videoView";
            // 
            // btnPlayPause
            // 
            this.btnPlayPause.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnPlayPause.Location = new System.Drawing.Point(386, 460);
            this.btnPlayPause.Name = "btnPlayPause";
            this.btnPlayPause.Size = new System.Drawing.Size(30, 23);
            this.btnPlayPause.TabIndex = 1;
            this.btnPlayPause.Text = ">";
            this.toolTip.SetToolTip(this.btnPlayPause, "Play/Pause");
            this.btnPlayPause.UseVisualStyleBackColor = true;
            this.btnPlayPause.Click += new System.EventHandler(this.btnPlayPause_Click);
            // 
            // trckTimeLine
            // 
            this.trckTimeLine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trckTimeLine.Location = new System.Drawing.Point(13, 412);
            this.trckTimeLine.Maximum = 10000;
            this.trckTimeLine.Name = "trckTimeLine";
            this.trckTimeLine.Size = new System.Drawing.Size(775, 45);
            this.trckTimeLine.TabIndex = 2;
            this.trckTimeLine.TickFrequency = 1000;
            this.trckTimeLine.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trckTimeLine.Scroll += new System.EventHandler(this.trckTimeLine_Scroll);
            // 
            // lblCurrentPosition
            // 
            this.lblCurrentPosition.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCurrentPosition.AutoSize = true;
            this.lblCurrentPosition.Location = new System.Drawing.Point(641, 460);
            this.lblCurrentPosition.Name = "lblCurrentPosition";
            this.lblCurrentPosition.Size = new System.Drawing.Size(70, 13);
            this.lblCurrentPosition.TabIndex = 3;
            this.lblCurrentPosition.Text = "00:00:00.000";
            // 
            // lblTotalLength
            // 
            this.lblTotalLength.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalLength.AutoSize = true;
            this.lblTotalLength.Location = new System.Drawing.Point(718, 460);
            this.lblTotalLength.Name = "lblTotalLength";
            this.lblTotalLength.Size = new System.Drawing.Size(70, 13);
            this.lblTotalLength.TabIndex = 4;
            this.lblTotalLength.Text = "00:00:00.000";
            // 
            // lblTimeSeperator
            // 
            this.lblTimeSeperator.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTimeSeperator.AutoSize = true;
            this.lblTimeSeperator.Location = new System.Drawing.Point(708, 460);
            this.lblTimeSeperator.Name = "lblTimeSeperator";
            this.lblTimeSeperator.Size = new System.Drawing.Size(12, 13);
            this.lblTimeSeperator.TabIndex = 5;
            this.lblTimeSeperator.Text = "/";
            // 
            // btnStepForward
            // 
            this.btnStepForward.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnStepForward.Location = new System.Drawing.Point(422, 460);
            this.btnStepForward.Name = "btnStepForward";
            this.btnStepForward.Size = new System.Drawing.Size(30, 23);
            this.btnStepForward.TabIndex = 6;
            this.btnStepForward.Text = ">|";
            this.toolTip.SetToolTip(this.btnStepForward, "Step 1s forward");
            this.btnStepForward.UseVisualStyleBackColor = true;
            this.btnStepForward.Click += new System.EventHandler(this.btnStepForward_Click);
            // 
            // btnStepBack
            // 
            this.btnStepBack.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnStepBack.Location = new System.Drawing.Point(350, 460);
            this.btnStepBack.Name = "btnStepBack";
            this.btnStepBack.Size = new System.Drawing.Size(30, 23);
            this.btnStepBack.TabIndex = 7;
            this.btnStepBack.Text = "|<";
            this.toolTip.SetToolTip(this.btnStepBack, "Step 1s back");
            this.btnStepBack.UseVisualStyleBackColor = true;
            this.btnStepBack.Click += new System.EventHandler(this.btnStepBack_Click);
            // 
            // rad025X
            // 
            this.rad025X.AutoSize = true;
            this.rad025X.Location = new System.Drawing.Point(9, 19);
            this.rad025X.Name = "rad025X";
            this.rad025X.Size = new System.Drawing.Size(53, 17);
            this.rad025X.TabIndex = 9;
            this.rad025X.Text = "0.25X";
            this.rad025X.UseVisualStyleBackColor = true;
            this.rad025X.CheckedChanged += new System.EventHandler(this.rad025X_CheckedChanged);
            // 
            // grpPlaybackSpeed
            // 
            this.grpPlaybackSpeed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.grpPlaybackSpeed.Controls.Add(this.rad1X);
            this.grpPlaybackSpeed.Controls.Add(this.rad05X);
            this.grpPlaybackSpeed.Controls.Add(this.rad025X);
            this.grpPlaybackSpeed.Location = new System.Drawing.Point(625, 476);
            this.grpPlaybackSpeed.Name = "grpPlaybackSpeed";
            this.grpPlaybackSpeed.Size = new System.Drawing.Size(163, 45);
            this.grpPlaybackSpeed.TabIndex = 10;
            this.grpPlaybackSpeed.TabStop = false;
            this.grpPlaybackSpeed.Text = "Playback Speed";
            // 
            // rad1X
            // 
            this.rad1X.AutoSize = true;
            this.rad1X.Checked = true;
            this.rad1X.Location = new System.Drawing.Point(119, 19);
            this.rad1X.Name = "rad1X";
            this.rad1X.Size = new System.Drawing.Size(38, 17);
            this.rad1X.TabIndex = 11;
            this.rad1X.TabStop = true;
            this.rad1X.Text = "1X";
            this.rad1X.UseVisualStyleBackColor = true;
            this.rad1X.CheckedChanged += new System.EventHandler(this.rad1X_CheckedChanged);
            // 
            // rad05X
            // 
            this.rad05X.AutoSize = true;
            this.rad05X.Location = new System.Drawing.Point(68, 19);
            this.rad05X.Name = "rad05X";
            this.rad05X.Size = new System.Drawing.Size(47, 17);
            this.rad05X.TabIndex = 10;
            this.rad05X.Text = "0.5X";
            this.rad05X.UseVisualStyleBackColor = true;
            this.rad05X.CheckedChanged += new System.EventHandler(this.rad05X_CheckedChanged);
            // 
            // lblStartTime
            // 
            this.lblStartTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblStartTime.AutoSize = true;
            this.lblStartTime.Location = new System.Drawing.Point(88, 465);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(58, 13);
            this.lblStartTime.TabIndex = 11;
            this.lblStartTime.Text = "Start Time:";
            // 
            // lblEndTime
            // 
            this.lblEndTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblEndTime.AutoSize = true;
            this.lblEndTime.Location = new System.Drawing.Point(91, 492);
            this.lblEndTime.Name = "lblEndTime";
            this.lblEndTime.Size = new System.Drawing.Size(55, 13);
            this.lblEndTime.TabIndex = 12;
            this.lblEndTime.Text = "End Time:";
            // 
            // btnStartTime
            // 
            this.btnStartTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnStartTime.Location = new System.Drawing.Point(12, 460);
            this.btnStartTime.Name = "btnStartTime";
            this.btnStartTime.Size = new System.Drawing.Size(75, 23);
            this.btnStartTime.TabIndex = 13;
            this.btnStartTime.Text = "Select";
            this.btnStartTime.UseVisualStyleBackColor = true;
            this.btnStartTime.Click += new System.EventHandler(this.btnStartTime_Click);
            // 
            // btnEndTime
            // 
            this.btnEndTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEndTime.Location = new System.Drawing.Point(12, 487);
            this.btnEndTime.Name = "btnEndTime";
            this.btnEndTime.Size = new System.Drawing.Size(75, 23);
            this.btnEndTime.TabIndex = 14;
            this.btnEndTime.Text = "Select";
            this.btnEndTime.UseVisualStyleBackColor = true;
            this.btnEndTime.Click += new System.EventHandler(this.btnEndTime_Click);
            // 
            // btnCut
            // 
            this.btnCut.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCut.Location = new System.Drawing.Point(362, 495);
            this.btnCut.Name = "btnCut";
            this.btnCut.Size = new System.Drawing.Size(75, 23);
            this.btnCut.TabIndex = 15;
            this.btnCut.Text = "CUT!";
            this.btnCut.UseVisualStyleBackColor = true;
            this.btnCut.Click += new System.EventHandler(this.btnCut_Click);
            // 
            // CutAssistant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 524);
            this.Controls.Add(this.btnCut);
            this.Controls.Add(this.btnEndTime);
            this.Controls.Add(this.btnStartTime);
            this.Controls.Add(this.lblEndTime);
            this.Controls.Add(this.lblStartTime);
            this.Controls.Add(this.grpPlaybackSpeed);
            this.Controls.Add(this.btnStepBack);
            this.Controls.Add(this.btnStepForward);
            this.Controls.Add(this.lblTotalLength);
            this.Controls.Add(this.trckTimeLine);
            this.Controls.Add(this.btnPlayPause);
            this.Controls.Add(this.videoView);
            this.Controls.Add(this.lblTimeSeperator);
            this.Controls.Add(this.lblCurrentPosition);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CutAssistant";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cut Assistant";
            this.Load += new System.EventHandler(this.CutAssistant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.videoView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trckTimeLine)).EndInit();
            this.grpPlaybackSpeed.ResumeLayout(false);
            this.grpPlaybackSpeed.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LibVLCSharp.WinForms.VideoView videoView;
        private System.Windows.Forms.Button btnPlayPause;
        private System.Windows.Forms.TrackBar trckTimeLine;
        private System.Windows.Forms.Label lblCurrentPosition;
        private System.Windows.Forms.Label lblTotalLength;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Label lblTimeSeperator;
        private System.Windows.Forms.Button btnStepForward;
        private System.Windows.Forms.Button btnStepBack;
        private System.Windows.Forms.RadioButton rad025X;
        private System.Windows.Forms.GroupBox grpPlaybackSpeed;
        private System.Windows.Forms.RadioButton rad1X;
        private System.Windows.Forms.RadioButton rad05X;
        private System.Windows.Forms.Label lblStartTime;
        private System.Windows.Forms.Label lblEndTime;
        private System.Windows.Forms.Button btnStartTime;
        private System.Windows.Forms.Button btnEndTime;
        private System.Windows.Forms.Button btnCut;
    }
}