using System.Diagnostics;

namespace studyBreakTimer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Stopwatch stopWatch = new Stopwatch();
        private bool isFiveMinSelected = false;
        private bool isTenMinSelected = false;
        private bool isFifteenMinSelected = false;

        private void btnFiveMin_Click(object sender, EventArgs e)
        {
            try
            {
                // Setting the flag for 5 minutes and calling the timer setup method for 5 minutes
                pgbTimerBar.Value = 0;
                pgbTimerBar.Enabled = true;
                isFiveMinSelected = true;
                fiveMinTimer();

            }
            catch
            {
                // Handling any exceptions that may occur during the timer setup
                MessageBox.Show("AN ERROR OCCURED");
                txtTimeStartFinish.Clear();
                btnFiveMin.Focus();
            }
        }

        public void fiveMinTimer()
        {
            if (isFiveMinSelected)
            {
                // Setting Progress Bar Minimum and Maximum values for 5 minutes (2738 ticks)
                // Starting the timer and stopwatch for 5 minutes
                pgbTimerBar.Minimum = 0;
                pgbTimerBar.Maximum = 300;
                timeFiveMin.Tick += new EventHandler(timerTick);
                timeFiveMin.Start();
                stopWatch.Start();
                // Disabling the buttons to prevent multiple timers from being started simultaneously
                btnFifteenMin.Enabled = false;
                btnTenMin.Enabled = false;
                btnFiveMin.Enabled = false;
            }
            else
            {
                return;
            }
        }

        private void btnTenMin_Click(object sender, EventArgs e)
        {
            try
            {
                // Setting the flag for 10 minutes and calling the timer setup method for 10 minutes
                pgbTimerBar.Value = 0;
                pgbTimerBar.Enabled = true;
                isTenMinSelected = true;
                tenMinTimer();

            }
            catch
            {
                // Handling any exceptions that may occur during the timer setup
                MessageBox.Show("AN ERROR OCCURED");
                txtTimeStartFinish.Clear();
                btnFiveMin.Focus();
            }
        }

        public void tenMinTimer()
        {

            if (isTenMinSelected)
            {
                // Setting Progress Bar Minimum and Maximum values for 10 minutes (5478 ticks)
                // Starting the timer and stopwatch for 10 minutes  5478
                pgbTimerBar.Value = 0;
                pgbTimerBar.Minimum = 0;
                pgbTimerBar.Maximum = 600;
                timeTenMin.Tick += new EventHandler(timerTick);
                timeTenMin.Start();
                stopWatch.Start();
                // Disabling the buttons to prevent multiple timers from being started simultaneously
                btnFifteenMin.Enabled = false;
                btnTenMin.Enabled = false;
                btnFiveMin.Enabled = false;
            }
            else
            {
                return;
            }
        }

        private void btnFifteenMin_Click(object sender, EventArgs e)
        {
            try
            {
                // Setting the flag for 15 minutes and calling the timer setup method for 15 minutes
                pgbTimerBar.Value = 0;
                pgbTimerBar.Enabled = true;
                isFifteenMinSelected = true;
                fifteenMinTimer();

            }
            catch
            {
                // Handling any exceptions that may occur during the timer setup
                MessageBox.Show("AN ERROR OCCURED");
                txtTimeStartFinish.Clear();
                btnFiveMin.Focus();
            }
        }

        public void fifteenMinTimer()
        {
            if (isFifteenMinSelected)
            {
                // Setting Progress Bar Minimum and Maximum values for 15 minutes (8215 ticks)
                // Starting the timer and stopwatch for 15 minutes 
                pgbTimerBar.Value = 0;
                pgbTimerBar.Minimum = 0;
                pgbTimerBar.Maximum = 900;
                timeFifteenMin.Tick += new EventHandler(timerTick);
                timeFifteenMin.Start();
                stopWatch.Start();
                // Disabling the buttons to prevent multiple timers from being started simultaneously
                btnFifteenMin.Enabled = false;
                btnTenMin.Enabled = false;
                btnFiveMin.Enabled = false;
            }
            else
            {
                return;
            }
        }

        private void timerTick(object sender, EventArgs e)
        {
            try
            { 
                TimeSpan timeSpan = stopWatch.Elapsed;


                // Incrementing the progress bar value and updating the time display until the maximum value is reached
                if (pgbTimerBar.Value < pgbTimerBar.Maximum)
                {
                    txtTimeStartFinish.Text = String.Format("{0:00}:{1:00}", timeSpan.Minutes, timeSpan.Seconds);
                    pgbTimerBar.Value = (int)timeSpan.TotalSeconds;
                }
                else
                {
                    // Stopping the timers and stopwatch, resetting the display and progress bar, and showing a message when the break is finished
                    timeFiveMin.Stop();
                    timeTenMin.Stop();
                    timeFifteenMin.Stop();
                    stopWatch.Stop();
                    txtTimeStartFinish.Text = "FINISH";
                    stopWatch.Reset();
                    this.TopMost = true;
                    MessageBox.Show("BREAK FINISHED! Time to study!");
                    btnFifteenMin.Enabled = true;
                    btnTenMin.Enabled = true;
                    btnFiveMin.Enabled = true;
                    pgbTimerBar.Enabled = false;
                    pgbTimerBar.Invalidate();
                    this.TopMost = false;
                }
            }
            catch
            {
                // Handling any exceptions that may occur during the timer tick event
                MessageBox.Show("AN ERROR OCCURED");
                txtTimeStartFinish.Clear();
                btnFiveMin.Focus();
            }

        }
    }
}
