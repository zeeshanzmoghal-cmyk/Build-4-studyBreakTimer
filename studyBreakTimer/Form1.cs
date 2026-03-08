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

        private void btnFiveMin_Click(object sender, EventArgs e)
        {
            try
            {
                pgbTimerBar.Minimum = 0;
                pgbTimerBar.Maximum = 2738;
                timeFiveMin.Tick += new EventHandler(timerTick);
                timeFiveMin.Start();
                stopWatch.Start();


            }
            catch
            {
                MessageBox.Show("AN ERROR OCCURED");
                txtTimeStartFinish.Clear();
                btnFiveMin.Focus();
            }
        }
        private void btnTenMin_Click(object sender, EventArgs e)
        {
            try
            {
                pgbTimerBar.Minimum = 0;
                pgbTimerBar.Maximum = 5477;
                timeTenMin.Tick += new EventHandler(timerTick);
                timeTenMin.Start();
                stopWatch.Start();


            }
            catch
            {
                MessageBox.Show("AN ERROR OCCURED");
                txtTimeStartFinish.Clear();
                btnFiveMin.Focus();
            }
        }

        private void btnFifteenMin_Click(object sender, EventArgs e)
        {
            try
            {
                pgbTimerBar.Minimum = 0;
                pgbTimerBar.Maximum = 8215;
                timeFifteenMin.Tick += new EventHandler(timerTick);
                timeFifteenMin.Start();
                stopWatch.Start();


            }
            catch
            {
                MessageBox.Show("AN ERROR OCCURED");
                txtTimeStartFinish.Clear();
                btnFiveMin.Focus();
            }
        }

        private void timerTick(object sender, EventArgs e)
        {
            try
            {
                TimeSpan timeSpan = stopWatch.Elapsed;

                if (pgbTimerBar.Value < pgbTimerBar.Maximum)
                {
                    pgbTimerBar.Value++;
                    txtTimeStartFinish.Text = String.Format("{0:00}:{1:00}", timeSpan.Minutes, timeSpan.Seconds); ;
                }
                else
                {
                    timeFiveMin.Stop();
                    timeTenMin.Stop();
                    timeFifteenMin.Stop();
                    stopWatch.Stop();
                    txtTimeStartFinish.Text = "FINISH";
                    stopWatch.Reset();
                    pgbTimerBar.Value = pgbTimerBar.Minimum;
                    this.TopMost = true;
                    MessageBox.Show("BREAK FINISHED! Time to study!");
                    this.TopMost = false;
                }
            }
            catch
            {
                MessageBox.Show("AN ERROR OCCURED");
                txtTimeStartFinish.Clear();
                btnFiveMin.Focus();
            }

        }
    }
}
