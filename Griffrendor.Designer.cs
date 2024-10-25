﻿namespace Griffrendor
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
            this.chkCutVideo = new System.Windows.Forms.CheckBox();
            this.lblCutStart = new System.Windows.Forms.Label();
            this.txtCutStartHours = new System.Windows.Forms.TextBox();
            this.txtCutStartMinutes = new System.Windows.Forms.TextBox();
            this.txtCutStartSeconds = new System.Windows.Forms.TextBox();
            this.lblCutEnd = new System.Windows.Forms.Label();
            this.txtCutEndSeconds = new System.Windows.Forms.TextBox();
            this.txtCutEndMinutes = new System.Windows.Forms.TextBox();
            this.txtCutEndHours = new System.Windows.Forms.TextBox();
            this.chkFrameRate = new System.Windows.Forms.CheckBox();
            this.txtFrameRate = new System.Windows.Forms.TextBox();
            this.chkResolution = new System.Windows.Forms.CheckBox();
            this.txtResolutionWidth = new System.Windows.Forms.TextBox();
            this.txtResolutionHeight = new System.Windows.Forms.TextBox();
            this.chkSlowEncode = new System.Windows.Forms.CheckBox();
            this.chkUncapBitrate = new System.Windows.Forms.CheckBox();
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
            // 
            // grpOptionalSettings
            // 
            this.grpOptionalSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpOptionalSettings.Controls.Add(this.chkUncapBitrate);
            this.grpOptionalSettings.Controls.Add(this.chkSlowEncode);
            this.grpOptionalSettings.Controls.Add(this.txtResolutionHeight);
            this.grpOptionalSettings.Controls.Add(this.txtResolutionWidth);
            this.grpOptionalSettings.Controls.Add(this.chkResolution);
            this.grpOptionalSettings.Controls.Add(this.txtFrameRate);
            this.grpOptionalSettings.Controls.Add(this.chkFrameRate);
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
            // chkCutVideo
            // 
            this.chkCutVideo.AutoSize = true;
            this.chkCutVideo.Location = new System.Drawing.Point(11, 25);
            this.chkCutVideo.Name = "chkCutVideo";
            this.chkCutVideo.Size = new System.Drawing.Size(98, 24);
            this.chkCutVideo.TabIndex = 0;
            this.chkCutVideo.Text = "Cut Video";
            this.chkCutVideo.UseVisualStyleBackColor = true;
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
            // txtCutStartHours
            // 
            this.txtCutStartHours.Enabled = false;
            this.txtCutStartHours.Location = new System.Drawing.Point(54, 49);
            this.txtCutStartHours.Name = "txtCutStartHours";
            this.txtCutStartHours.Size = new System.Drawing.Size(31, 26);
            this.txtCutStartHours.TabIndex = 2;
            this.txtCutStartHours.Text = "0";
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
            // txtCutStartSeconds
            // 
            this.txtCutStartSeconds.Enabled = false;
            this.txtCutStartSeconds.Location = new System.Drawing.Point(128, 49);
            this.txtCutStartSeconds.Name = "txtCutStartSeconds";
            this.txtCutStartSeconds.Size = new System.Drawing.Size(68, 26);
            this.txtCutStartSeconds.TabIndex = 4;
            this.txtCutStartSeconds.Text = "0.0";
            // 
            // lblCutEnd
            // 
            this.lblCutEnd.AutoSize = true;
            this.lblCutEnd.Enabled = false;
            this.lblCutEnd.Location = new System.Drawing.Point(202, 52);
            this.lblCutEnd.Name = "lblCutEnd";
            this.lblCutEnd.Size = new System.Drawing.Size(38, 20);
            this.lblCutEnd.TabIndex = 5;
            this.lblCutEnd.Text = "End";
            // 
            // txtCutEndSeconds
            // 
            this.txtCutEndSeconds.Enabled = false;
            this.txtCutEndSeconds.Location = new System.Drawing.Point(320, 49);
            this.txtCutEndSeconds.Name = "txtCutEndSeconds";
            this.txtCutEndSeconds.Size = new System.Drawing.Size(68, 26);
            this.txtCutEndSeconds.TabIndex = 8;
            this.txtCutEndSeconds.Text = "0.0";
            // 
            // txtCutEndMinutes
            // 
            this.txtCutEndMinutes.Enabled = false;
            this.txtCutEndMinutes.Location = new System.Drawing.Point(283, 49);
            this.txtCutEndMinutes.Name = "txtCutEndMinutes";
            this.txtCutEndMinutes.Size = new System.Drawing.Size(31, 26);
            this.txtCutEndMinutes.TabIndex = 7;
            this.txtCutEndMinutes.Text = "0";
            // 
            // txtCutEndHours
            // 
            this.txtCutEndHours.Enabled = false;
            this.txtCutEndHours.Location = new System.Drawing.Point(246, 49);
            this.txtCutEndHours.Name = "txtCutEndHours";
            this.txtCutEndHours.Size = new System.Drawing.Size(31, 26);
            this.txtCutEndHours.TabIndex = 6;
            this.txtCutEndHours.Text = "0";
            // 
            // chkFrameRate
            // 
            this.chkFrameRate.AutoSize = true;
            this.chkFrameRate.Location = new System.Drawing.Point(11, 84);
            this.chkFrameRate.Name = "chkFrameRate";
            this.chkFrameRate.Size = new System.Drawing.Size(389, 24);
            this.chkFrameRate.TabIndex = 9;
            this.chkFrameRate.Text = "Change Framerate (Unchecked = Same as source)";
            this.chkFrameRate.UseVisualStyleBackColor = true;
            // 
            // txtFrameRate
            // 
            this.txtFrameRate.Enabled = false;
            this.txtFrameRate.Location = new System.Drawing.Point(406, 82);
            this.txtFrameRate.Name = "txtFrameRate";
            this.txtFrameRate.Size = new System.Drawing.Size(46, 26);
            this.txtFrameRate.TabIndex = 10;
            this.txtFrameRate.Text = "30";
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
            // txtResolutionHeight
            // 
            this.txtResolutionHeight.Enabled = false;
            this.txtResolutionHeight.Location = new System.Drawing.Point(458, 114);
            this.txtResolutionHeight.Name = "txtResolutionHeight";
            this.txtResolutionHeight.Size = new System.Drawing.Size(46, 26);
            this.txtResolutionHeight.TabIndex = 13;
            this.txtResolutionHeight.Text = "720";
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
        private System.Windows.Forms.TextBox txtFrameRate;
        private System.Windows.Forms.CheckBox chkFrameRate;
        private System.Windows.Forms.CheckBox chkSlowEncode;
        private System.Windows.Forms.TextBox txtResolutionHeight;
        private System.Windows.Forms.TextBox txtResolutionWidth;
        private System.Windows.Forms.CheckBox chkUncapBitrate;
    }
}

