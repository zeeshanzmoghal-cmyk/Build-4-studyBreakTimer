namespace studyBreakTimer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lblTimer = new Label();
            btnFiveMin = new Button();
            btnTenMin = new Button();
            btnFifteenMin = new Button();
            pgbTimerBar = new ProgressBar();
            txtTimeStartFinish = new TextBox();
            timeFiveMin = new System.Windows.Forms.Timer(components);
            timeTenMin = new System.Windows.Forms.Timer(components);
            timeFifteenMin = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // lblTimer
            // 
            lblTimer.AutoSize = true;
            lblTimer.BackColor = Color.Transparent;
            lblTimer.Font = new Font("Arial Rounded MT Bold", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTimer.Location = new Point(12, 9);
            lblTimer.Name = "lblTimer";
            lblTimer.Size = new Size(636, 39);
            lblTimer.TabIndex = 0;
            lblTimer.Text = "Break from studying? Come back in...";
            // 
            // btnFiveMin
            // 
            btnFiveMin.BackColor = Color.SpringGreen;
            btnFiveMin.Font = new Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnFiveMin.Location = new Point(12, 83);
            btnFiveMin.Name = "btnFiveMin";
            btnFiveMin.Size = new Size(152, 71);
            btnFiveMin.TabIndex = 0;
            btnFiveMin.Text = "5 min";
            btnFiveMin.UseVisualStyleBackColor = false;
            btnFiveMin.Click += btnFiveMin_Click;
            // 
            // btnTenMin
            // 
            btnTenMin.BackColor = Color.LightSkyBlue;
            btnTenMin.Font = new Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTenMin.Location = new Point(257, 83);
            btnTenMin.Name = "btnTenMin";
            btnTenMin.Size = new Size(152, 71);
            btnTenMin.TabIndex = 1;
            btnTenMin.Text = "10 min";
            btnTenMin.UseVisualStyleBackColor = false;
            btnTenMin.Click += btnTenMin_Click;
            // 
            // btnFifteenMin
            // 
            btnFifteenMin.BackColor = Color.LightSalmon;
            btnFifteenMin.Font = new Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnFifteenMin.Location = new Point(491, 83);
            btnFifteenMin.Name = "btnFifteenMin";
            btnFifteenMin.Size = new Size(152, 71);
            btnFifteenMin.TabIndex = 2;
            btnFifteenMin.Text = "15 min";
            btnFifteenMin.UseVisualStyleBackColor = false;
            btnFifteenMin.Click += btnFifteenMin_Click;
            // 
            // pgbTimerBar
            // 
            pgbTimerBar.ForeColor = Color.Gold;
            pgbTimerBar.Location = new Point(12, 210);
            pgbTimerBar.Name = "pgbTimerBar";
            pgbTimerBar.Size = new Size(631, 35);
            pgbTimerBar.TabIndex = 3;
            // 
            // txtTimeStartFinish
            // 
            txtTimeStartFinish.Font = new Font("Arial Rounded MT Bold", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTimeStartFinish.Location = new Point(210, 282);
            txtTimeStartFinish.Name = "txtTimeStartFinish";
            txtTimeStartFinish.ReadOnly = true;
            txtTimeStartFinish.Size = new Size(224, 36);
            txtTimeStartFinish.TabIndex = 3;
            txtTimeStartFinish.TabStop = false;
            // 
            // timeFiveMin
            // 
            timeFiveMin.Enabled = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(655, 333);
            Controls.Add(txtTimeStartFinish);
            Controls.Add(pgbTimerBar);
            Controls.Add(btnFifteenMin);
            Controls.Add(btnTenMin);
            Controls.Add(btnFiveMin);
            Controls.Add(lblTimer);
            Cursor = Cursors.Cross;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Study Break Timer v1.0.1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTimer;
        private Button btnFiveMin;
        private Button btnTenMin;
        private Button btnFifteenMin;
        private ProgressBar pgbTimerBar;
        private TextBox txtTimeStartFinish;
        private System.Windows.Forms.Timer timeFiveMin;
        private System.Windows.Forms.Timer timeTenMin;
        private System.Windows.Forms.Timer timeFifteenMin;
    }
}
