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
            this.videoView = new LibVLCSharp.WinForms.VideoView();
            this.btnPlayPause = new System.Windows.Forms.Button();
            this.trckTimeLine = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.videoView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trckTimeLine)).BeginInit();
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
            this.videoView.Size = new System.Drawing.Size(798, 410);
            this.videoView.TabIndex = 0;
            this.videoView.Text = "videoView";
            // 
            // btnPlayPause
            // 
            this.btnPlayPause.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnPlayPause.Location = new System.Drawing.Point(365, 465);
            this.btnPlayPause.Name = "btnPlayPause";
            this.btnPlayPause.Size = new System.Drawing.Size(75, 23);
            this.btnPlayPause.TabIndex = 1;
            this.btnPlayPause.Text = ">";
            this.btnPlayPause.UseVisualStyleBackColor = true;
            this.btnPlayPause.Click += new System.EventHandler(this.btnPlayPause_Click);
            // 
            // trckTimeLine
            // 
            this.trckTimeLine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trckTimeLine.Location = new System.Drawing.Point(13, 419);
            this.trckTimeLine.Maximum = 10000;
            this.trckTimeLine.Name = "trckTimeLine";
            this.trckTimeLine.Size = new System.Drawing.Size(775, 45);
            this.trckTimeLine.TabIndex = 2;
            this.trckTimeLine.TickFrequency = 1000;
            this.trckTimeLine.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trckTimeLine.Scroll += new System.EventHandler(this.trckTimeLine_Scroll);
            // 
            // CutAssistant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 506);
            this.Controls.Add(this.trckTimeLine);
            this.Controls.Add(this.btnPlayPause);
            this.Controls.Add(this.videoView);
            this.Name = "CutAssistant";
            this.Text = "Cut Assistant";
            this.Load += new System.EventHandler(this.CutAssistant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.videoView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trckTimeLine)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LibVLCSharp.WinForms.VideoView videoView;
        private System.Windows.Forms.Button btnPlayPause;
        private System.Windows.Forms.TrackBar trckTimeLine;
    }
}