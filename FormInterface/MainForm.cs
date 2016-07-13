using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using Detect;
using Detect.DenseOpticalFlow;

namespace FormInterface
{

    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Shown += MainForm_Shown;
            Closed += MainForm_Closed;
            btnStart.Enabled = btnPauseCont.Enabled = btnStop.Enabled = btnSetParameters.Enabled = false;

            tbxFile.Text = AppDomain.CurrentDomain.BaseDirectory + @"/test_video/vp.mp4";
            tbxFrameInterval.Text = 5.ToString();
            tbxOrientationAngle.Text = 0.ToString();
            tbxVectorGlobalThreshold.Text = 1.ToString();
            tbxWindowSideLength.Text = 10.ToString();
            cbxComputeFlowImage.Checked = true;
            tbxEpsilon.Text = 20.ToString();
            tbxMinPts.Text = 10.ToString();
            tbxPyrScale.Text = 0.5.ToString(CultureInfo.InvariantCulture);
            tbxLevels.Text = 3.ToString();
            tbxWinSize.Text = 10.ToString();
            tbxIterations.Text = 3.ToString();
            tbxPolyN.Text = 7.ToString();
            tbxPolySigma.Text = 1.5.ToString(CultureInfo.InvariantCulture);
        }

        private void MainForm_Closed(object sender, EventArgs e)
        {
            if (Processor != null)
            { btnStop_Click(this, null); }
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {


        }

        private ImageForm frmProcessedImg;
        private ImageForm frmOpticalFlowImg;
        private bool running;

        public VideoProcessor Processor { get; private set; }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = false;
            InitProcessor();
            btnSetParameters_Click(sender, e);
            Processor.BeforeProcessFrame();
            Processor.StartCapture();
            frmProcessedImg.Show(this);
            frmOpticalFlowImg.Show(this);
            running = true;
            btnPauseCont.Enabled = true;
            btnStop.Enabled = true;
            btnSetParameters.Enabled = true;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            btnStop.Enabled = false;
            btnSetParameters.Enabled = false;
            btnPauseCont.Enabled = false;
            Processor.StopCapture();
            btnStart.Enabled = true;
            Processor.Dispose();
            Processor = null;
        }

        private void btnPauseCont_Click(object sender, EventArgs e)
        {
            if (running)
            {
                btnPauseCont.Text = @"Continue";
                Processor.PauseCapture();
                running = false;
            }
            else
            {
                btnPauseCont.Text = @"Pause";
                Processor.StartCapture();
                running = true;
            }

            btnSetParameters.Enabled = true;
            btnStop.Enabled = true;
            btnStart.Enabled = false;
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            var file = openFileDialog1.ShowDialog(this);
            if (file == DialogResult.OK)
            {
                InitProcessor();
            }
        }

        private void InitProcessor()
        {
            tbxFile.Text = openFileDialog1.FileName;
            Processor = new VideoProcessor(tbxFile.Text);
            btnStart.Enabled = true;
            btnSetParameters.Enabled = true;
            frmProcessedImg = new ImageForm();
            frmProcessedImg.Text = @"Processed Image";
            frmProcessedImg.Owner = this;
            frmOpticalFlowImg = new ImageForm();
            frmOpticalFlowImg.Text = @"Optical Flow Vectors";
            frmOpticalFlowImg.Owner = this;

            Processor.ImageProcessed = image =>
            {
                if (!frmProcessedImg.IsDisposed)
                {
                    frmProcessedImg.Invoke(new MethodInvoker(() =>
                      {
                          frmProcessedImg.imageBox1.Image = image;
                          frmProcessedImg.Size = new Size(image.Size.Width + 50, image.Size.Height + 50);
                      }));
                }
            };
            
            Processor.OpticalFlowVectorsProcessed = image =>
            {
                if (cbxComputeFlowImage.Checked && !frmOpticalFlowImg.IsDisposed)
                {
                    frmOpticalFlowImg.Invoke(new MethodInvoker(() =>
                    {
                        frmOpticalFlowImg.imageBox1.Image = image;
                        frmOpticalFlowImg.Size = new Size(image.Size.Width + 50, image.Size.Height + 50);
                    }));
                }
            };
        }

        private void btnSetParameters_Click(object sender, EventArgs e)
        {
            Processor.BeforeProcessFrame = () => Processor.SetParameters(
                Convert.ToInt32(tbxFrameInterval.Text),
                Convert.ToDouble(tbxOrientationAngle.Text),
                Convert.ToDouble(tbxVectorGlobalThreshold.Text),
                Convert.ToInt32(tbxWindowSideLength.Text),
                cbxComputeFlowImage.Checked,
                Convert.ToDouble(tbxEpsilon.Text),
                Convert.ToInt32(tbxMinPts.Text),
                new FarnebackParameters
                {
                    PyrScale = Convert.ToDouble(tbxPyrScale.Text),
                    Levels = Convert.ToInt32(tbxLevels.Text),
                    WinSize = Convert.ToInt32(tbxWinSize.Text),
                    Iterations = Convert.ToInt32(tbxIterations.Text),
                    PolyN = Convert.ToInt32(tbxPolyN.Text),
                    PolySigma = Convert.ToDouble(tbxPolySigma.Text)
                });
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
