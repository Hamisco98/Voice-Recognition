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

namespace Voice_Recgnition_000
{
    public partial class Form1 : Form
    {
        SpeechRecognitionEngine recEngine = new SpeechRecognitionEngine();
        SpeechSynthesizer synthesizer = new SpeechSynthesizer();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnable_Click(object sender, EventArgs e)
        {
            recEngine.RecognizeAsync(RecognizeMode.Multiple);
            btnDisable.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Choices commands = new Choices();
            commands.Add(new string[] { "Hello", "My Name", "Read The Selected text" });
            GrammarBuilder gBulider = new GrammarBuilder();
            gBulider.Append(commands);
            Grammar grammer = new Grammar(gBulider);

            recEngine.LoadGrammarAsync(grammer);
            recEngine.SetInputToDefaultAudioDevice();
            recEngine.SpeechRecognized += recEngine_Speechrecoginition;


        }

        private void recEngine_Speechrecoginition(object sender, SpeechRecognizedEventArgs e)
        {
            switch(e.Result.Text)
            {
                case "Hello":
                    synthesizer.SpeakAsync("Hello, How can i help you?");
                    break;
                case "My Name":
                    screen.Text += "\n Mohamed Hamis";
                    break;
                case "Read The Selected text":
                    synthesizer.SpeakAsync(screen.SelectedText);
                    break;
            }
        }

        private void btnDisable_Click(object sender, EventArgs e)
        {
            recEngine.RecognizeAsyncStop();
            btnEnable.Enabled = false;
        }
    }
}
