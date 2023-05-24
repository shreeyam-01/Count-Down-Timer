namespace Count_Down_Timer
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
            label1 = new Label();
            displayLabel = new Label();
            startButton = new Button();
            stopButton = new Button();
            resetButton = new Button();
            timer = new System.Windows.Forms.Timer(components);
            minusButton = new Button();
            plusButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(248, 9);
            label1.Name = "label1";
            label1.Size = new Size(420, 61);
            label1.TabIndex = 0;
            label1.Text = "COUNT DOWN TIMER";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // displayLabel
            // 
            displayLabel.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point);
            displayLabel.ForeColor = Color.White;
            displayLabel.Location = new Point(290, 152);
            displayLabel.Name = "displayLabel";
            displayLabel.Size = new Size(337, 61);
            displayLabel.TabIndex = 1;
            displayLabel.Text = "60 Seconds";
            displayLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // startButton
            // 
            startButton.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            startButton.Location = new Point(320, 257);
            startButton.Name = "startButton";
            startButton.Size = new Size(129, 51);
            startButton.TabIndex = 2;
            startButton.Text = "Start";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += startButton_Click;
            // 
            // stopButton
            // 
            stopButton.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            stopButton.Location = new Point(455, 257);
            stopButton.Name = "stopButton";
            stopButton.Size = new Size(129, 51);
            stopButton.TabIndex = 3;
            stopButton.Text = "Stop";
            stopButton.UseVisualStyleBackColor = true;
            stopButton.Click += stopButton_Click;
            // 
            // resetButton
            // 
            resetButton.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            resetButton.Location = new Point(320, 314);
            resetButton.Name = "resetButton";
            resetButton.Size = new Size(264, 51);
            resetButton.TabIndex = 4;
            resetButton.Text = "Reset";
            resetButton.UseVisualStyleBackColor = true;
            resetButton.Click += resetButton_Click;
            // 
            // timer
            // 
            timer.Interval = 1000;
            timer.Tick += timer_Tick;
            // 
            // minusButton
            // 
            minusButton.BackColor = Color.Black;
            minusButton.Font = new Font("Segoe UI Semibold", 25F, FontStyle.Bold, GraphicsUnit.Point);
            minusButton.ForeColor = Color.White;
            minusButton.Location = new Point(613, 152);
            minusButton.Name = "minusButton";
            minusButton.Size = new Size(86, 75);
            minusButton.TabIndex = 5;
            minusButton.Text = "-";
            minusButton.TextAlign = ContentAlignment.TopCenter;
            minusButton.UseVisualStyleBackColor = false;
            minusButton.Click += minusButton_Click;
            // 
            // plusButton
            // 
            plusButton.BackColor = Color.Black;
            plusButton.Font = new Font("Segoe UI Semibold", 22F, FontStyle.Bold, GraphicsUnit.Point);
            plusButton.ForeColor = Color.White;
            plusButton.Location = new Point(198, 152);
            plusButton.Name = "plusButton";
            plusButton.Size = new Size(86, 75);
            plusButton.TabIndex = 6;
            plusButton.Text = "+";
            plusButton.TextAlign = ContentAlignment.TopCenter;
            plusButton.UseVisualStyleBackColor = false;
            plusButton.Click += plusButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(911, 431);
            Controls.Add(plusButton);
            Controls.Add(minusButton);
            Controls.Add(resetButton);
            Controls.Add(stopButton);
            Controls.Add(startButton);
            Controls.Add(displayLabel);
            Controls.Add(label1);
            MaximumSize = new Size(933, 487);
            MinimumSize = new Size(933, 487);
            Name = "Form1";
            Text = "Count Down Timer";
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label displayLabel;
        private Button startButton;
        private Button stopButton;
        private Button resetButton;
        private System.Windows.Forms.Timer timer;
        private Button minusButton;
        private Button plusButton;
    }
}