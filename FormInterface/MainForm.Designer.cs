namespace FormInterface
{
    partial class MainForm
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
            this.btnStart = new System.Windows.Forms.Button();
            this.btnPauseCont = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tbxFile = new System.Windows.Forms.TextBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnChoose = new System.Windows.Forms.Button();
            this.tbxWindowSideLength = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxComputeFlowImage = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxPyrScale = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxLevels = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxWinSize = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxIterations = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxPolyN = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbxPolySigma = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbxOrientationAngle = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbxMinPts = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbxEpsilon = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbxVectorGlobalThreshold = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lbxEventLogs = new System.Windows.Forms.ListBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.tbxFrameInterval = new System.Windows.Forms.TextBox();
            this.btnSetParameters = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(10, 54);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnPauseCont
            // 
            this.btnPauseCont.Location = new System.Drawing.Point(91, 54);
            this.btnPauseCont.Name = "btnPauseCont";
            this.btnPauseCont.Size = new System.Drawing.Size(75, 23);
            this.btnPauseCont.TabIndex = 1;
            this.btnPauseCont.Text = "Pause";
            this.btnPauseCont.UseVisualStyleBackColor = true;
            this.btnPauseCont.Click += new System.EventHandler(this.btnPauseCont_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // tbxFile
            // 
            this.tbxFile.Location = new System.Drawing.Point(11, 28);
            this.tbxFile.Name = "tbxFile";
            this.tbxFile.Size = new System.Drawing.Size(302, 20);
            this.tbxFile.TabIndex = 2;
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(173, 53);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 3;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnChoose
            // 
            this.btnChoose.Location = new System.Drawing.Point(319, 26);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(75, 23);
            this.btnChoose.TabIndex = 4;
            this.btnChoose.Text = "Choose File";
            this.btnChoose.UseVisualStyleBackColor = true;
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // tbxWindowSideLength
            // 
            this.tbxWindowSideLength.Location = new System.Drawing.Point(140, 175);
            this.tbxWindowSideLength.Name = "tbxWindowSideLength";
            this.tbxWindowSideLength.Size = new System.Drawing.Size(63, 20);
            this.tbxWindowSideLength.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "WindowSideLength";
            // 
            // cbxComputeFlowImage
            // 
            this.cbxComputeFlowImage.AutoSize = true;
            this.cbxComputeFlowImage.Location = new System.Drawing.Point(593, 55);
            this.cbxComputeFlowImage.Name = "cbxComputeFlowImage";
            this.cbxComputeFlowImage.Size = new System.Drawing.Size(119, 17);
            this.cbxComputeFlowImage.TabIndex = 10;
            this.cbxComputeFlowImage.Text = "ComputeFlowImage";
            this.cbxComputeFlowImage.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(313, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "pyrScale";
            // 
            // tbxPyrScale
            // 
            this.tbxPyrScale.Location = new System.Drawing.Point(377, 127);
            this.tbxPyrScale.Name = "tbxPyrScale";
            this.tbxPyrScale.Size = new System.Drawing.Size(63, 20);
            this.tbxPyrScale.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(313, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "levels";
            // 
            // tbxLevels
            // 
            this.tbxLevels.Location = new System.Drawing.Point(377, 153);
            this.tbxLevels.Name = "tbxLevels";
            this.tbxLevels.Size = new System.Drawing.Size(63, 20);
            this.tbxLevels.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(313, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "winSize";
            // 
            // tbxWinSize
            // 
            this.tbxWinSize.Location = new System.Drawing.Point(377, 179);
            this.tbxWinSize.Name = "tbxWinSize";
            this.tbxWinSize.Size = new System.Drawing.Size(63, 20);
            this.tbxWinSize.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(313, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "iterations";
            // 
            // tbxIterations
            // 
            this.tbxIterations.Location = new System.Drawing.Point(377, 205);
            this.tbxIterations.Name = "tbxIterations";
            this.tbxIterations.Size = new System.Drawing.Size(63, 20);
            this.tbxIterations.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(313, 234);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "polyN";
            // 
            // tbxPolyN
            // 
            this.tbxPolyN.Location = new System.Drawing.Point(377, 231);
            this.tbxPolyN.Name = "tbxPolyN";
            this.tbxPolyN.Size = new System.Drawing.Size(63, 20);
            this.tbxPolyN.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(313, 260);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "polySigma";
            // 
            // tbxPolySigma
            // 
            this.tbxPolySigma.Location = new System.Drawing.Point(377, 257);
            this.tbxPolySigma.Name = "tbxPolySigma";
            this.tbxPolySigma.Size = new System.Drawing.Size(63, 20);
            this.tbxPolySigma.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 152);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 13);
            this.label9.TabIndex = 30;
            this.label9.Text = "orientationAngle";
            // 
            // tbxOrientationAngle
            // 
            this.tbxOrientationAngle.Location = new System.Drawing.Point(140, 149);
            this.tbxOrientationAngle.Name = "tbxOrientationAngle";
            this.tbxOrientationAngle.Size = new System.Drawing.Size(63, 20);
            this.tbxOrientationAngle.TabIndex = 29;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(531, 178);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 28;
            this.label10.Text = "minPts";
            // 
            // tbxMinPts
            // 
            this.tbxMinPts.Location = new System.Drawing.Point(577, 175);
            this.tbxMinPts.Name = "tbxMinPts";
            this.tbxMinPts.Size = new System.Drawing.Size(63, 20);
            this.tbxMinPts.TabIndex = 27;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(531, 152);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "epsilon";
            // 
            // tbxEpsilon
            // 
            this.tbxEpsilon.Location = new System.Drawing.Point(577, 149);
            this.tbxEpsilon.Name = "tbxEpsilon";
            this.tbxEpsilon.Size = new System.Drawing.Size(63, 20);
            this.tbxEpsilon.TabIndex = 25;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(20, 126);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(114, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "vectorGlobalThreshold";
            // 
            // tbxVectorGlobalThreshold
            // 
            this.tbxVectorGlobalThreshold.Location = new System.Drawing.Point(140, 123);
            this.tbxVectorGlobalThreshold.Name = "tbxVectorGlobalThreshold";
            this.tbxVectorGlobalThreshold.Size = new System.Drawing.Size(63, 20);
            this.tbxVectorGlobalThreshold.TabIndex = 23;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(93, 13);
            this.label13.TabIndex = 31;
            this.label13.Text = "Capture Video File";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(316, 98);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(114, 13);
            this.label14.TabIndex = 32;
            this.label14.Text = "Farneback Parameters";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(103, 98);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(77, 13);
            this.label15.TabIndex = 33;
            this.label15.Text = "OF Parameters";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(531, 123);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(107, 13);
            this.label16.TabIndex = 34;
            this.label16.Text = "DBSCAN Parameters";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(531, 9);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(100, 13);
            this.label17.TabIndex = 35;
            this.label17.Text = "General Parameters";
            // 
            // lbxEventLogs
            // 
            this.lbxEventLogs.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbxEventLogs.FormattingEnabled = true;
            this.lbxEventLogs.Location = new System.Drawing.Point(0, 310);
            this.lbxEventLogs.Name = "lbxEventLogs";
            this.lbxEventLogs.Size = new System.Drawing.Size(784, 251);
            this.lbxEventLogs.TabIndex = 36;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(7, 294);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(61, 13);
            this.label18.TabIndex = 37;
            this.label18.Text = "Event Logs";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(468, 32);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(71, 13);
            this.label19.TabIndex = 39;
            this.label19.Text = "FrameInterval";
            // 
            // tbxFrameInterval
            // 
            this.tbxFrameInterval.Location = new System.Drawing.Point(593, 29);
            this.tbxFrameInterval.Name = "tbxFrameInterval";
            this.tbxFrameInterval.Size = new System.Drawing.Size(100, 20);
            this.tbxFrameInterval.TabIndex = 38;
            // 
            // btnSetParameters
            // 
            this.btnSetParameters.Location = new System.Drawing.Point(491, 281);
            this.btnSetParameters.Name = "btnSetParameters";
            this.btnSetParameters.Size = new System.Drawing.Size(219, 23);
            this.btnSetParameters.TabIndex = 40;
            this.btnSetParameters.Text = "Set Parameters";
            this.btnSetParameters.UseVisualStyleBackColor = true;
            this.btnSetParameters.Click += new System.EventHandler(this.btnSetParameters_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnSetParameters);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.tbxFrameInterval);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.lbxEventLogs);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbxOrientationAngle);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbxMinPts);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tbxEpsilon);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tbxVectorGlobalThreshold);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbxPolySigma);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbxPolyN);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbxIterations);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbxWinSize);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbxLevels);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxPyrScale);
            this.Controls.Add(this.cbxComputeFlowImage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxWindowSideLength);
            this.Controls.Add(this.btnChoose);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.tbxFile);
            this.Controls.Add(this.btnPauseCont);
            this.Controls.Add(this.btnStart);
            this.Name = "MainForm";
            this.Text = "Video Motion Detection";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnPauseCont;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox tbxFile;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnChoose;
        private System.Windows.Forms.TextBox tbxWindowSideLength;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbxComputeFlowImage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxPyrScale;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxLevels;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxWinSize;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxIterations;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbxPolyN;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbxPolySigma;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbxOrientationAngle;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbxMinPts;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbxEpsilon;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbxVectorGlobalThreshold;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ListBox lbxEventLogs;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox tbxFrameInterval;
        private System.Windows.Forms.Button btnSetParameters;
    }
}

