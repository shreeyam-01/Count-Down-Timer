namespace Count_Down_Timer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int remainingTime = 60;

        private void startButton_Click(object sender, EventArgs e)
        {
            timer.Start();

        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            timer.Stop();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            timer.Stop();
            remainingTime = 60;
            displayLabel.Text = remainingTime + " Seconds";
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            remainingTime -= 1;
            displayLabel.Text = remainingTime + " Seconds";

            if (remainingTime == -1)
            {
                timer.Stop();
                displayLabel.Text = "TIMES'S UP!";
            }
        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            remainingTime += 1;
            displayLabel.Text = remainingTime + " Seconds";
        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            remainingTime -= 1;
            displayLabel.Text = remainingTime + " Seconds";
        }
    }
}