using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Recognition;

namespace Object_Detection
{
    public partial class voice : Form
    {
        
            
        SpeechRecognitionEngine recEngine = new SpeechRecognitionEngine();
        public voice()
        {
            InitializeComponent();
        }



        private void voice_Load(object sender, EventArgs e)
        {
            Choices commands = new Choices();
            commands.Add(new string[] { "object detector", "real time", "license plate detect", "clear log" });
            GrammarBuilder gBuilder = new GrammarBuilder();
            gBuilder.Append(commands);
            Grammar grammar = new Grammar(gBuilder);

            recEngine.LoadGrammarAsync(grammar);
            //recEngine.SetInputToDefaultAudioDevice();
            recEngine.SpeechRecognized += recEngine_SpeechRecognized;





        }

        private void recEngine_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            switch (e.Result.Text)
            {
                case "object detector":
                    richTextBox1.Text += "\n-Object detector";
                    ObjDetect();
                    break;
                case "real time":
                    richTextBox1.Text += "\n-Real time detection";
                    RealDetect();
                    break;
                case "license plate detect":
                    richTextBox1.Text += "\n-License plate detection";
                    LicenseDetect();
                    break;
                case "clear log":
                    richTextBox1.Text = String.Empty;
                    richTextBox1.Text = "~Log~";
                    break;
                default:
                    MessageBox.Show("Your voice command is not understood, retry");
                    break;


            }
        }

        //functions to call other forms
        private static void ObjDetect()
        {
            Form1 f1 = new Form1();
            f1.Show();
        }

        private static void RealDetect()
        {
            Form2 f = new Form2();
            f.Show();




        }

        private static void LicenseDetect()
        {
            Form2 f2 = new Form2();
            f2.Show();
            f2.doClick();
            //f2.button1.Click += new EventHandler(f2.button1_Click);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "\nSpeak up please";
            recEngine.RecognizeAsync(RecognizeMode.Multiple);
            richTextBox1.Text += "\nPlease wait, we are recognizing your voice command";



        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ObjDetect();
        }
    }
}
