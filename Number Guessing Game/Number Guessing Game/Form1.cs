using System;

namespace Number_Guessing_Game
{
    public partial class Form1 : Form
    {
        Random randomNumber = new Random();
        int number = 0;
        int guess_count = 0;

        public Form1()
        {
            InitializeComponent();
            //SuspendLayout();
            MessageBox.Show("Enter the range in which you want to play guess in and press the 'Generate' button.");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGen_Click(object sender, EventArgs e)
        {
            int low = Convert.ToInt32(txtInputLow.Text);
            int high = Convert.ToInt32(txtInputHigh.Text);
            number = randomNumber.Next(low, high);
            lblStatus.Text = "Number generated!";
            MessageBox.Show("Now enter your guess and press the 'Guess' button.");
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            int i;
            if (!int.TryParse(txtInputGuess.Text, out i))
            {
                MessageBox.Show("Invalid input. Enter a valid one..", "Error");
                return;
            }


            guess_count += 1;
            lblGuessCount.Text = "You guessed " + guess_count + " times.";

            if (i == number)
            {
                lblStatus.Text = "Nice, you guessed it in\n" + guess_count + " count.\nTry another ^_^)";
                txtInputGuess.Text = "";
                txtInputLow.Text = "";
                txtInputHigh.Text = "";
                guess_count = 0;
                lblGuessCount.Text = "You guessed " + guess_count + " times.";
            }
            else if (i < number)
            {
                lblStatus.Text = "Go Higher";
            }
            else
            {
                lblStatus.Text = "Go Lower";
            }
        }
    }
}