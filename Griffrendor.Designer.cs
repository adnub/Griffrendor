namespace Griffrendor
{
    partial class Griffrendor
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
            this.lblInput = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnBrowseInput = new System.Windows.Forms.Button();
            this.btnBrowseOutput = new System.Windows.Forms.Button();
            this.lblFileSize = new System.Windows.Forms.Label();
            this.txtFileSize = new System.Windows.Forms.TextBox();
            this.chkAudio = new System.Windows.Forms.CheckBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.grpOptionalSettings = new System.Windows.Forms.GroupBox();
            this.lblTimeFormat = new System.Windows.Forms.Label();
            this.txtCutEndmsec = new System.Windows.Forms.TextBox();
            this.txtCutStartmsec = new System.Windows.Forms.TextBox();
            this.chkUncapBitrate = new System.Windows.Forms.CheckBox();
            this.chkSlowEncode = new System.Windows.Forms.CheckBox();
            this.txtResolutionHeight = new System.Windows.Forms.TextBox();
            this.txtResolutionWidth = new System.Windows.Forms.TextBox();
            this.chkResolution = new System.Windows.Forms.CheckBox();
            this.txtFramerate = new System.Windows.Forms.TextBox();
            this.chkFramerate = new System.Windows.Forms.CheckBox();
            this.txtCutEndSeconds = new System.Windows.Forms.TextBox();
            this.txtCutEndMinutes = new System.Windows.Forms.TextBox();
            this.txtCutEndHours = new System.Windows.Forms.TextBox();
            this.lblCutEnd = new System.Windows.Forms.Label();
            this.txtCutStartSeconds = new System.Windows.Forms.TextBox();
            this.txtCutStartMinutes = new System.Windows.Forms.TextBox();
            this.txtCutStartHours = new System.Windows.Forms.TextBox();
            this.lblCutStart = new System.Windows.Forms.Label();
            this.chkCutVideo = new System.Windows.Forms.CheckBox();
            this.btnCutAssistant = new System.Windows.Forms.Button();
            this.grpOptionalSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Location = new System.Drawing.Point(12, 15);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(95, 20);
            this.lblInput.TabIndex = 0;
            this.lblInput.Text = "Input Video:";
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(12, 47);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(107, 20);
            this.lblOutput.TabIndex = 1;
            this.lblOutput.Text = "Output Video:";
            // 
            // txtOutput
            // 
            this.txtOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOutput.Location = new System.Drawing.Point(125, 44);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(637, 26);
            this.txtOutput.TabIndex = 2;
            // 
            // txtInput
            // 
            this.txtInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInput.Location = new System.Drawing.Point(125, 12);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(637, 26);
            this.txtInput.TabIndex = 3;
            // 
            // btnBrowseInput
            // 
            this.btnBrowseInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseInput.Location = new System.Drawing.Point(768, 14);
            this.btnBrowseInput.Name = "btnBrowseInput";
            this.btnBrowseInput.Size = new System.Drawing.Size(30, 24);
            this.btnBrowseInput.TabIndex = 4;
            this.btnBrowseInput.Text = "...";
            this.btnBrowseInput.UseVisualStyleBackColor = true;
            this.btnBrowseInput.Click += new System.EventHandler(this.btnBrowseInput_Click);
            // 
            // btnBrowseOutput
            // 
            this.btnBrowseOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseOutput.Location = new System.Drawing.Point(768, 44);
            this.btnBrowseOutput.Name = "btnBrowseOutput";
            this.btnBrowseOutput.Size = new System.Drawing.Size(30, 26);
            this.btnBrowseOutput.TabIndex = 5;
            this.btnBrowseOutput.Text = "...";
            this.btnBrowseOutput.UseVisualStyleBackColor = true;
            this.btnBrowseOutput.Click += new System.EventHandler(this.btnBrowseOutput_Click);
            // 
            // lblFileSize
            // 
            this.lblFileSize.AutoSize = true;
            this.lblFileSize.Location = new System.Drawing.Point(12, 79);
            this.lblFileSize.Name = "lblFileSize";
            this.lblFileSize.Size = new System.Drawing.Size(191, 20);
            this.lblFileSize.TabIndex = 6;
            this.lblFileSize.Text = "Maximum Filesize (in MB):";
            // 
            // txtFileSize
            // 
            this.txtFileSize.Location = new System.Drawing.Point(203, 76);
            this.txtFileSize.Name = "txtFileSize";
            this.txtFileSize.Size = new System.Drawing.Size(100, 26);
            this.txtFileSize.TabIndex = 7;
            this.txtFileSize.Text = "50";
            // 
            // chkAudio
            // 
            this.chkAudio.AutoSize = true;
            this.chkAudio.Location = new System.Drawing.Point(309, 78);
            this.chkAudio.Name = "chkAudio";
            this.chkAudio.Size = new System.Drawing.Size(123, 24);
            this.chkAudio.TabIndex = 8;
            this.chkAudio.Text = "Enable Audio";
            this.chkAudio.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.Location = new System.Drawing.Point(699, 76);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(99, 34);
            this.btnStart.TabIndex = 9;
            this.btnStart.Text = "START!";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // grpOptionalSettings
            // 
            this.grpOptionalSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpOptionalSettings.Controls.Add(this.btnCutAssistant);
            this.grpOptionalSettings.Controls.Add(this.lblTimeFormat);
            this.grpOptionalSettings.Controls.Add(this.txtCutEndmsec);
            this.grpOptionalSettings.Controls.Add(this.txtCutStartmsec);
            this.grpOptionalSettings.Controls.Add(this.chkUncapBitrate);
            this.grpOptionalSettings.Controls.Add(this.chkSlowEncode);
            this.grpOptionalSettings.Controls.Add(this.txtResolutionHeight);
            this.grpOptionalSettings.Controls.Add(this.txtResolutionWidth);
            this.grpOptionalSettings.Controls.Add(this.chkResolution);
            this.grpOptionalSettings.Controls.Add(this.txtFramerate);
            this.grpOptionalSettings.Controls.Add(this.chkFramerate);
            this.grpOptionalSettings.Controls.Add(this.txtCutEndSeconds);
            this.grpOptionalSettings.Controls.Add(this.txtCutEndMinutes);
            this.grpOptionalSettings.Controls.Add(this.txtCutEndHours);
            this.grpOptionalSettings.Controls.Add(this.lblCutEnd);
            this.grpOptionalSettings.Controls.Add(this.txtCutStartSeconds);
            this.grpOptionalSettings.Controls.Add(this.txtCutStartMinutes);
            this.grpOptionalSettings.Controls.Add(this.txtCutStartHours);
            this.grpOptionalSettings.Controls.Add(this.lblCutStart);
            this.grpOptionalSettings.Controls.Add(this.chkCutVideo);
            this.grpOptionalSettings.Location = new System.Drawing.Point(12, 122);
            this.grpOptionalSettings.Name = "grpOptionalSettings";
            this.grpOptionalSettings.Size = new System.Drawing.Size(789, 202);
            this.grpOptionalSettings.TabIndex = 10;
            this.grpOptionalSettings.TabStop = false;
            this.grpOptionalSettings.Text = "Optional Settings";
            // 
            // lblTimeFormat
            // 
            this.lblTimeFormat.AutoSize = true;
            this.lblTimeFormat.Enabled = false;
            this.lblTimeFormat.Location = new System.Drawing.Point(408, 52);
            this.lblTimeFormat.Name = "lblTimeFormat";
            this.lblTimeFormat.Size = new System.Drawing.Size(129, 20);
            this.lblTimeFormat.TabIndex = 18;
            this.lblTimeFormat.Text = "(hh mm ss msec)";
            // 
            // txtCutEndmsec
            // 
            this.txtCutEndmsec.Enabled = false;
            this.txtCutEndmsec.Location = new System.Drawing.Point(364, 49);
            this.txtCutEndmsec.Name = "txtCutEndmsec";
            this.txtCutEndmsec.Size = new System.Drawing.Size(38, 26);
            this.txtCutEndmsec.TabIndex = 17;
            this.txtCutEndmsec.Text = "000";
            // 
            // txtCutStartmsec
            // 
            this.txtCutStartmsec.Enabled = false;
            this.txtCutStartmsec.Location = new System.Drawing.Point(165, 49);
            this.txtCutStartmsec.Name = "txtCutStartmsec";
            this.txtCutStartmsec.Size = new System.Drawing.Size(38, 26);
            this.txtCutStartmsec.TabIndex = 16;
            this.txtCutStartmsec.Text = "000";
            // 
            // chkUncapBitrate
            // 
            this.chkUncapBitrate.AutoSize = true;
            this.chkUncapBitrate.Location = new System.Drawing.Point(11, 174);
            this.chkUncapBitrate.Name = "chkUncapBitrate";
            this.chkUncapBitrate.Size = new System.Drawing.Size(663, 24);
            this.chkUncapBitrate.TabIndex = 15;
            this.chkUncapBitrate.Text = "Uncap Bitrate (Always generates maximum filesize video. Might break previews in D" +
    "iscord.)";
            this.chkUncapBitrate.UseVisualStyleBackColor = true;
            // 
            // chkSlowEncode
            // 
            this.chkSlowEncode.AutoSize = true;
            this.chkSlowEncode.Location = new System.Drawing.Point(11, 144);
            this.chkSlowEncode.Name = "chkSlowEncode";
            this.chkSlowEncode.Size = new System.Drawing.Size(385, 24);
            this.chkSlowEncode.TabIndex = 14;
            this.chkSlowEncode.Text = "Slow Encode (Improves quality, but is WAY slower)";
            this.chkSlowEncode.UseVisualStyleBackColor = true;
            // 
            // txtResolutionHeight
            // 
            this.txtResolutionHeight.Enabled = false;
            this.txtResolutionHeight.Location = new System.Drawing.Point(458, 114);
            this.txtResolutionHeight.Name = "txtResolutionHeight";
            this.txtResolutionHeight.Size = new System.Drawing.Size(46, 26);
            this.txtResolutionHeight.TabIndex = 13;
            this.txtResolutionHeight.Text = "720";
            // 
            // txtResolutionWidth
            // 
            this.txtResolutionWidth.Enabled = false;
            this.txtResolutionWidth.Location = new System.Drawing.Point(406, 114);
            this.txtResolutionWidth.Name = "txtResolutionWidth";
            this.txtResolutionWidth.Size = new System.Drawing.Size(46, 26);
            this.txtResolutionWidth.TabIndex = 12;
            this.txtResolutionWidth.Text = "1280";
            // 
            // chkResolution
            // 
            this.chkResolution.AutoSize = true;
            this.chkResolution.Location = new System.Drawing.Point(11, 114);
            this.chkResolution.Name = "chkResolution";
            this.chkResolution.Size = new System.Drawing.Size(391, 24);
            this.chkResolution.TabIndex = 11;
            this.chkResolution.Text = "Change Resolution (Unchecked = Same as source)";
            this.chkResolution.UseVisualStyleBackColor = true;
            this.chkResolution.CheckedChanged += new System.EventHandler(this.chkResolution_CheckedChanged);
            // 
            // txtFramerate
            // 
            this.txtFramerate.Enabled = false;
            this.txtFramerate.Location = new System.Drawing.Point(406, 82);
            this.txtFramerate.Name = "txtFramerate";
            this.txtFramerate.Size = new System.Drawing.Size(46, 26);
            this.txtFramerate.TabIndex = 10;
            this.txtFramerate.Text = "30";
            // 
            // chkFramerate
            // 
            this.chkFramerate.AutoSize = true;
            this.chkFramerate.Location = new System.Drawing.Point(11, 84);
            this.chkFramerate.Name = "chkFramerate";
            this.chkFramerate.Size = new System.Drawing.Size(389, 24);
            this.chkFramerate.TabIndex = 9;
            this.chkFramerate.Text = "Change Framerate (Unchecked = Same as source)";
            this.chkFramerate.UseVisualStyleBackColor = true;
            this.chkFramerate.CheckedChanged += new System.EventHandler(this.chkFrameRate_CheckedChanged);
            // 
            // txtCutEndSeconds
            // 
            this.txtCutEndSeconds.Enabled = false;
            this.txtCutEndSeconds.Location = new System.Drawing.Point(327, 49);
            this.txtCutEndSeconds.Name = "txtCutEndSeconds";
            this.txtCutEndSeconds.Size = new System.Drawing.Size(31, 26);
            this.txtCutEndSeconds.TabIndex = 8;
            this.txtCutEndSeconds.Text = "0";
            // 
            // txtCutEndMinutes
            // 
            this.txtCutEndMinutes.Enabled = false;
            this.txtCutEndMinutes.Location = new System.Drawing.Point(290, 49);
            this.txtCutEndMinutes.Name = "txtCutEndMinutes";
            this.txtCutEndMinutes.Size = new System.Drawing.Size(31, 26);
            this.txtCutEndMinutes.TabIndex = 7;
            this.txtCutEndMinutes.Text = "0";
            // 
            // txtCutEndHours
            // 
            this.txtCutEndHours.Enabled = false;
            this.txtCutEndHours.Location = new System.Drawing.Point(253, 49);
            this.txtCutEndHours.Name = "txtCutEndHours";
            this.txtCutEndHours.Size = new System.Drawing.Size(31, 26);
            this.txtCutEndHours.TabIndex = 6;
            this.txtCutEndHours.Text = "0";
            // 
            // lblCutEnd
            // 
            this.lblCutEnd.AutoSize = true;
            this.lblCutEnd.Enabled = false;
            this.lblCutEnd.Location = new System.Drawing.Point(209, 52);
            this.lblCutEnd.Name = "lblCutEnd";
            this.lblCutEnd.Size = new System.Drawing.Size(38, 20);
            this.lblCutEnd.TabIndex = 5;
            this.lblCutEnd.Text = "End";
            // 
            // txtCutStartSeconds
            // 
            this.txtCutStartSeconds.Enabled = false;
            this.txtCutStartSeconds.Location = new System.Drawing.Point(128, 49);
            this.txtCutStartSeconds.Name = "txtCutStartSeconds";
            this.txtCutStartSeconds.Size = new System.Drawing.Size(31, 26);
            this.txtCutStartSeconds.TabIndex = 4;
            this.txtCutStartSeconds.Text = "0";
            // 
            // txtCutStartMinutes
            // 
            this.txtCutStartMinutes.Enabled = false;
            this.txtCutStartMinutes.Location = new System.Drawing.Point(91, 49);
            this.txtCutStartMinutes.Name = "txtCutStartMinutes";
            this.txtCutStartMinutes.Size = new System.Drawing.Size(31, 26);
            this.txtCutStartMinutes.TabIndex = 3;
            this.txtCutStartMinutes.Text = "0";
            // 
            // txtCutStartHours
            // 
            this.txtCutStartHours.Enabled = false;
            this.txtCutStartHours.Location = new System.Drawing.Point(54, 49);
            this.txtCutStartHours.Name = "txtCutStartHours";
            this.txtCutStartHours.Size = new System.Drawing.Size(31, 26);
            this.txtCutStartHours.TabIndex = 2;
            this.txtCutStartHours.Text = "0";
            // 
            // lblCutStart
            // 
            this.lblCutStart.AutoSize = true;
            this.lblCutStart.Enabled = false;
            this.lblCutStart.Location = new System.Drawing.Point(7, 52);
            this.lblCutStart.Name = "lblCutStart";
            this.lblCutStart.Size = new System.Drawing.Size(44, 20);
            this.lblCutStart.TabIndex = 1;
            this.lblCutStart.Text = "Start";
            // 
            // chkCutVideo
            // 
            this.chkCutVideo.AutoSize = true;
            this.chkCutVideo.Location = new System.Drawing.Point(11, 25);
            this.chkCutVideo.Name = "chkCutVideo";
            this.chkCutVideo.Size = new System.Drawing.Size(98, 24);
            this.chkCutVideo.TabIndex = 0;
            this.chkCutVideo.Text = "Cut Video";
            this.chkCutVideo.UseVisualStyleBackColor = true;
            this.chkCutVideo.CheckedChanged += new System.EventHandler(this.chkCutVideo_CheckedChanged);
            // 
            // btnCutAssistant
            // 
            this.btnCutAssistant.Enabled = false;
            this.btnCutAssistant.Location = new System.Drawing.Point(543, 49);
            this.btnCutAssistant.Name = "btnCutAssistant";
            this.btnCutAssistant.Size = new System.Drawing.Size(131, 26);
            this.btnCutAssistant.TabIndex = 19;
            this.btnCutAssistant.Text = "Cut Assistant ...";
            this.btnCutAssistant.UseVisualStyleBackColor = true;
            this.btnCutAssistant.Click += new System.EventHandler(this.btnCutAssistant_Click);
            // 
            // Griffrendor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 334);
            this.Controls.Add(this.grpOptionalSettings);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.chkAudio);
            this.Controls.Add(this.txtFileSize);
            this.Controls.Add(this.lblFileSize);
            this.Controls.Add(this.btnBrowseOutput);
            this.Controls.Add(this.btnBrowseInput);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.lblInput);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(714, 373);
            this.Name = "Griffrendor";
            this.Text = "Griffrendor";
            this.Load += new System.EventHandler(this.Griffrendor_Load);
            this.grpOptionalSettings.ResumeLayout(false);
            this.grpOptionalSettings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnBrowseInput;
        private System.Windows.Forms.Button btnBrowseOutput;
        private System.Windows.Forms.Label lblFileSize;
        private System.Windows.Forms.TextBox txtFileSize;
        private System.Windows.Forms.CheckBox chkAudio;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.GroupBox grpOptionalSettings;
        private System.Windows.Forms.TextBox txtCutEndSeconds;
        private System.Windows.Forms.TextBox txtCutEndMinutes;
        private System.Windows.Forms.TextBox txtCutEndHours;
        private System.Windows.Forms.Label lblCutEnd;
        private System.Windows.Forms.TextBox txtCutStartSeconds;
        private System.Windows.Forms.TextBox txtCutStartMinutes;
        private System.Windows.Forms.TextBox txtCutStartHours;
        private System.Windows.Forms.Label lblCutStart;
        private System.Windows.Forms.CheckBox chkCutVideo;
        private System.Windows.Forms.CheckBox chkResolution;
        private System.Windows.Forms.TextBox txtFramerate;
        private System.Windows.Forms.CheckBox chkFramerate;
        private System.Windows.Forms.CheckBox chkSlowEncode;
        private System.Windows.Forms.TextBox txtResolutionHeight;
        private System.Windows.Forms.TextBox txtResolutionWidth;
        private System.Windows.Forms.CheckBox chkUncapBitrate;
        private System.Windows.Forms.TextBox txtCutStartmsec;
        private System.Windows.Forms.TextBox txtCutEndmsec;
        private System.Windows.Forms.Label lblTimeFormat;
        private System.Windows.Forms.Button btnCutAssistant;
    }
}

