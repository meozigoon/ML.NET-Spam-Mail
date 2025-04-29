using ML_NET_Spam_Mail;

namespace ML.NET_Spam_Mail
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void InputBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //Load sample data
                var sampleData = new SpamModel.ModelInput()
                {
                    Col1 = InputBox.Text
                };

                //Load model and predict output
                var result = SpamModel.Predict(sampleData);
                ResultLabel.Text = $"Predicted: {result.PredictedLabel}\nham: {result.Score[0]}\nspam: {result.Score[1]}";
            }
        }
    }
}
