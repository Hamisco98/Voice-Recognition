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
using System.Speech.Synthesis;
using System.IO;

namespace Voice_Recognition_001
{
    public partial class Form1 : Form
    {

        SpeechRecognitionEngine _recognizer = new SpeechRecognitionEngine();
        SpeechSynthesizer ema = new SpeechSynthesizer();
        SpeechRecognitionEngine startlistening = new SpeechRecognitionEngine();
        Random rnd = new Random();
        int RecTimeOut = 0;
        DateTime timeNow = DateTime.Now;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            

            //Defoult audio source
            _recognizer.SetInputToDefaultAudioDevice();
            _recognizer.LoadGrammarAsync(new Grammar(new GrammarBuilder(new Choices(File.ReadAllLines(@"DefaultCommands.txt")))));
            _recognizer.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(Default_SpeechRecognized);
            _recognizer.SpeechDetected += new EventHandler<SpeechDetectedEventArgs>(_recognizer_SpeechReconized);
            _recognizer.RecognizeAsync(RecognizeMode.Multiple);

            startlistening.SetInputToDefaultAudioDevice();
            startlistening.LoadGrammarAsync(new Grammar(new GrammarBuilder(new Choices(File.ReadAllLines(@"DefaultCommands.txt")))));
            startlistening.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(startlistening_SpeechRecognized);
            
        }

        private void Default_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {

            int renNum;
            string speech = e.Result.Text;

            if(speech == "Hello")
            {
                ema.SpeakAsync("Hello Mohamed.");
            }
            if (speech == "How are you")
            {
                ema.SpeakAsync("I am grate, How about you?");

            }
            if (speech == "really good" || speech == "nice")
            {
                ema.SpeakAsync("wonderfull, so what you want to do today?");
            }
            if (speech == "What tiem is it")
            {
                ema.SpeakAsync(timeNow.ToString("hh mm ss"));
            }
            if (speech == "Stop talking")
            {
                ema.SpeakAsyncCancelAll();
                renNum = rnd.Next(1,2);
                if (renNum == 1)
                {
                    ema.SpeakAsync("Yes sir");
                }
                if (renNum == 2)
                {
                    ema.SpeakAsync("sorry, i will be quiet");
                }
            }
            if(speech == "Stop litening")
            {
                ema.SpeakAsync("if you need me i will be here");
                _recognizer.RecognizeAsyncCancel();
                startlistening.RecognizeAsync(RecognizeMode.Multiple);
            }

            if(speech == "Show Commands")
            {
                string[] commands = (File.ReadAllLines(@"DefaultCommands.txt"));
                lstCommands.Items.Clear();
                lstCommands.SelectionMode = SelectionMode.None;
                lstCommands.Visible = true;
                foreach (string command in commands)
                {
                    lstCommands.Items.Add(command);
                }
            }
            if (speech == "Hide Commands")
            {
                lstCommands.Visible = false;
            }
        }

        private void _recognizer_SpeechReconized(object sender, SpeechDetectedEventArgs e)
        {
            RecTimeOut = 0;
        }

        private void startlistening_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            string speech = e.Result.Text;

            if (speech == "wake up")
            {
                startlistening.RecognizeAsyncCancel();
                ema.SpeakAsync("Yes sir, I am here");
                _recognizer.RecognizeAsync(RecognizeMode.Multiple);
            }
        }

        private void tmrSpeeking_Tick(object sender, EventArgs e)
        {
            if (RecTimeOut == 10)
            {
                _recognizer.RecognizeAsyncCancel();
            }
            else if (RecTimeOut == 11)
            {
                tmrSpeeking.Stop();
                startlistening.RecognizeAsync(RecognizeMode.Multiple);
                RecTimeOut = 0;
            }
        }
    }
}
