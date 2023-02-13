using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using Emgu.CV;
using Emgu.CV.Structure;


namespace Object_Detection
{
    public partial class Form2 : Form

    {
        private FilterInfoCollection _filter;
        private VideoCaptureDevice _device;

       //////cascades
        private static readonly CascadeClassifier cascadeClassifier1 = new CascadeClassifier("plate cascade 3.xml");/////license plate
        private static readonly CascadeClassifier cascadeClassifier2 = new CascadeClassifier("cars2.xml");  ////vehicle casscade
        private static readonly CascadeClassifier cascadeClassifier3 = new CascadeClassifier("pedestrian cascade.xml");  ////peds casscade
        private static readonly CascadeClassifier cascadeClassifier4 = new CascadeClassifier("face cascade.xml");  ////face casscade

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            _filter = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo device in _filter)
            {
                deviceComboBox.Items.Add(device.Name);
            }
            deviceComboBox.SelectedIndex = 0;
        }





        ///////////////////////////////////////button actions/////////////////////////////

        public void button1_Click(object sender, EventArgs e)
        {
            _device = new VideoCaptureDevice(_filter[deviceComboBox.SelectedIndex].MonikerString);
            _device.NewFrame += DeviceNewFrame1;/////////////////////////////////// plate button
            _device.Start();
        }
        public void doClick()
        {
            button1.PerformClick();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _device = new VideoCaptureDevice(_filter[deviceComboBox.SelectedIndex].MonikerString);
            _device.NewFrame += DeviceNewFrame2;/////////////////////////////////// vehicle button
            _device.Start();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            _device = new VideoCaptureDevice(_filter[deviceComboBox.SelectedIndex].MonikerString);
            _device.NewFrame += DeviceNewFrame3;/////////////////////////////////// pedistrian button
            _device.Start();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            _device = new VideoCaptureDevice(_filter[deviceComboBox.SelectedIndex].MonikerString);
            _device.NewFrame += DeviceNewFrame4;/////////////////////////////////// face button
            _device.Start();
        }











        ///function for plate detection
        private void DeviceNewFrame1(object sender, NewFrameEventArgs eventargs)
        {
            int count = 0;
            Bitmap bitmap1 = (Bitmap)eventargs.Frame.Clone();
            Image<Bgr, byte> grayImage = new Image<Bgr, byte>(bitmap1);
            Rectangle[] rectangles1 = cascadeClassifier1.DetectMultiScale(grayImage, 1.2, 1);

            foreach (Rectangle rectangle in rectangles1)
            {
                count += 1;

                using (Graphics graphics = Graphics.FromImage(bitmap1))
                {
                    using (Pen pen = new Pen(Color.Red, 3))
                    {
                        graphics.DrawRectangle(pen, rectangle);
                    }
                    
                }
                ///save feature
                Bitmap cropped = new Bitmap(rectangle.Width, rectangle.Height, PixelFormat.Format32bppArgb);
                using (Graphics g = Graphics.FromImage(cropped))
                {
                    g.DrawImage(bitmap1, -rectangle.X, -rectangle.Y);
                }
                cropped.Save("resources/plates/" + count.ToString() + ".png");
            }
            pictureBox1.Image = bitmap1;
        }




        ///function for vehicle detection
        private void DeviceNewFrame2(object sender, NewFrameEventArgs eventargs)
        {
            int count = 0;
            Bitmap bitmap2 = (Bitmap)eventargs.Frame.Clone();
            Image<Bgr, byte> grayImage = new Image<Bgr, byte>(bitmap2);
            Rectangle[] rectangles2 = cascadeClassifier2.DetectMultiScale(grayImage, 1.2, 1);

            foreach (Rectangle rectangle in rectangles2)
            {
                count += 1;

                using (Graphics graphics = Graphics.FromImage(bitmap2))
                {
                    using (Pen pen = new Pen(Color.Red, 3))
                    {
                        graphics.DrawRectangle(pen, rectangle);
                    }

                }
                ///save feature
                Bitmap cropped = new Bitmap(rectangle.Width, rectangle.Height, PixelFormat.Format32bppArgb);
                using (Graphics g = Graphics.FromImage(cropped))
                {
                    g.DrawImage(bitmap2, -rectangle.X, -rectangle.Y);
                }
                cropped.Save("resources/vehicle/" + count.ToString() + ".png");
            }
            pictureBox1.Image = bitmap2;
        }




        ///function for pedestrian detection
        private void DeviceNewFrame3(object sender, NewFrameEventArgs eventargs)
        {
            int count = 0;
            Bitmap bitmap3 = (Bitmap)eventargs.Frame.Clone();
            Image<Bgr, byte> grayImage = new Image<Bgr, byte>(bitmap3);
            Rectangle[] rectangles3 = cascadeClassifier3.DetectMultiScale(grayImage, 1.2, 1);

            foreach (Rectangle rectangle in rectangles3)
            {
                count += 1;

                using (Graphics graphics = Graphics.FromImage(bitmap3))
                {
                    using (Pen pen = new Pen(Color.Red, 3))
                    {
                        graphics.DrawRectangle(pen, rectangle);
                    }

                }
                ///save feature
                Bitmap cropped = new Bitmap(rectangle.Width, rectangle.Height, PixelFormat.Format32bppArgb);
                using (Graphics g = Graphics.FromImage(cropped))
                {
                    g.DrawImage(bitmap3, -rectangle.X, -rectangle.Y);
                }
                cropped.Save("resources/pedestrians/" + count.ToString() + ".png");
            }
            pictureBox1.Image = bitmap3;
        }





        ///function for face detection
        private void DeviceNewFrame4(object sender, NewFrameEventArgs eventargs)
        {
            int count = 0;
            Bitmap bitmap4 = (Bitmap)eventargs.Frame.Clone();
            Image<Bgr, byte> grayImage = new Image<Bgr, byte>(bitmap4);
            Rectangle[] rectangles4 = cascadeClassifier4.DetectMultiScale(grayImage, 1.2, 1);

            foreach (Rectangle rectangle in rectangles4)
            {
                count += 1;

                using (Graphics graphics = Graphics.FromImage(bitmap4))
                {
                    using (Pen pen = new Pen(Color.Red, 3))
                    {
                        graphics.DrawRectangle(pen, rectangle);
                    }

                }
                ///save feature
                Bitmap cropped = new Bitmap(rectangle.Width, rectangle.Height, PixelFormat.Format32bppArgb);
                using (Graphics g = Graphics.FromImage(cropped))
                {
                    g.DrawImage(bitmap4, -rectangle.X, -rectangle.Y);
                }
                cropped.Save("resources/face/" + count.ToString() + ".png");
            }


           
            pictureBox1.Image = bitmap4;
        }





        private void button2_Click(object sender, EventArgs e)
        {
            if (_device.IsRunning)
            {
                _device.Stop();
            }
        }

        
    }
}
