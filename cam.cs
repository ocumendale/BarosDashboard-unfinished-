using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;
using ZXing.Aztec;
using System.Windows.Forms;
using ZXing.Windows.Compatibility;



namespace BarosDashboard
{
    public partial class cam : Form
    {
        private FilterInfoCollection CaptureDevice;
        private VideoCaptureDevice FinalFrame;
      
        public cam()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cam_Load(object sender, EventArgs e)
        {
            CaptureDevice = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo device in CaptureDevice)
                comboBox1.Items.Add(device.Name);

            comboBox1.SelectedIndex = 0;
            FinalFrame = new VideoCaptureDevice();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FinalFrame = new VideoCaptureDevice(CaptureDevice[comboBox1.SelectedIndex].MonikerString);
            FinalFrame.NewFrame += new NewFrameEventHandler(FinalFrame_NewFrame);
            FinalFrame.Start();
        }

        private void FinalFrame_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();

        }

        private void cam_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (FinalFrame.IsRunning == true)
            {
                FinalFrame.Stop();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                var reader = new ZXing.BarcodeReader<Bitmap>(null, bmp => new BitmapLuminanceSource(bmp), luminance => new ZXing.Common.HybridBinarizer(luminance));

                Result result = reader.Decode((Bitmap)pictureBox1.Image);
                try
                {
                    if (result != null)
                    {
                        string decoded = result.Text.Trim();
                        if (!string.IsNullOrEmpty(decoded))
                        {
                            textBox1.Text = decoded;
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Handle exception
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Start(); 
        }
    }
}
