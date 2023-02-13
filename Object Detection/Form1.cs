using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Alturos.Yolo;
using Alturos.Yolo.Model;
using System.Data;
using System.Data.SqlClient;

namespace Object_Detection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void chooseButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog(){Filter = "PNG|*.png|JPEG|*.jpeg|JPG|*.jpg" })
            {
                if (openFileDialog.ShowDialog()==DialogResult.OK)
                {
                    pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
                }                
            }
        }

        private void detectButton_Click(object sender, EventArgs e)
        {


            var configurationDetector = new YoloConfigurationDetector();
            var config = configurationDetector.Detect();
            
            var yoloWrapper = new YoloWrapper(config);


            using (MemoryStream ms = new MemoryStream())
            {
                pictureBox1.Image.Save(ms, ImageFormat.Png);
                var items = yoloWrapper.Detect(ms.ToArray()).ToList();
                yoloItemBindingSource.DataSource = items;

                AddDetails(pictureBox1, items);
            }


        }

        void AddDetails(PictureBox pictureBox,List<YoloItem> items)
        {
            var image = pictureBox.Image;
            var brush = new SolidBrush(Color.Red);
            var graphics = Graphics.FromImage(image);
            
            foreach (var item in items)
            {
                var x = item.X;
                var y = item.Y;
                var width = item.Width;
                var height = item.Height;
                var font = new Font("Arial", width/6, FontStyle.Bold);
                var rectangle =new Rectangle(x,y,width,height);
                var pen = new Pen(Color.Red, 5);
                var point = new Point(x,y);


                graphics.DrawRectangle(pen,rectangle);
                graphics.DrawString(item.Type, font, brush, point);
            }
            pictureBox.Image = image;
        }

        private void insert_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var myForm = new Form2();myForm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
    }

   
