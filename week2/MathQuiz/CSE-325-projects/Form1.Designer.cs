namespace CSE_325_projects
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
            timeLabel = new Label();
            timeLeftLabel = new Label();
            plusLeftLabel = new Label();
            label1 = new Label();
            label2 = new Label();
            plusRightLabel = new Label();
            sum = new NumericUpDown();
            difference = new NumericUpDown();
            minusRightLabel = new Label();
            label4 = new Label();
            label5 = new Label();
            minusLeftLabel = new Label();
            product = new NumericUpDown();
            timesRightLabel = new Label();
            label8 = new Label();
            label9 = new Label();
            timesLeftLabel = new Label();
            quotient = new NumericUpDown();
            dividedRightLabel = new Label();
            label12 = new Label();
            label13 = new Label();
            dividedLeftLabel = new Label();
            startButton = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            dateLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)sum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)difference).BeginInit();
            ((System.ComponentModel.ISupportInitialize)product).BeginInit();
            ((System.ComponentModel.ISupportInitialize)quotient).BeginInit();
            SuspendLayout();
            // 
            // timeLabel
            // 
            timeLabel.BorderStyle = BorderStyle.FixedSingle;
            timeLabel.Font = new Font("Segoe UI", 15.75F);
            timeLabel.Location = new Point(762, 9);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new Size(200, 46);
            timeLabel.TabIndex = 0;
            // 
            // timeLeftLabel
            // 
            timeLeftLabel.AutoSize = true;
            timeLeftLabel.Font = new Font("Segoe UI", 15.75F);
            timeLeftLabel.Location = new Point(594, 10);
            timeLeftLabel.Name = "timeLeftLabel";
            timeLeftLabel.Size = new Size(152, 45);
            timeLeftLabel.TabIndex = 1;
            timeLeftLabel.Text = "Time Left";
            timeLeftLabel.Click += label1_Click;
            // 
            // plusLeftLabel
            // 
            plusLeftLabel.Font = new Font("Segoe UI", 18F);
            plusLeftLabel.Location = new Point(50, 108);
            plusLeftLabel.Name = "plusLeftLabel";
            plusLeftLabel.Size = new Size(115, 50);
            plusLeftLabel.TabIndex = 2;
            plusLeftLabel.Text = "?";
            plusLeftLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 18F);
            label1.Location = new Point(224, 108);
            label1.Name = "label1";
            label1.Size = new Size(115, 50);
            label1.TabIndex = 3;
            label1.Text = "+";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 18F);
            label2.Location = new Point(594, 108);
            label2.Name = "label2";
            label2.Size = new Size(115, 50);
            label2.TabIndex = 4;
            label2.Text = "=";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // plusRightLabel
            // 
            plusRightLabel.Font = new Font("Segoe UI", 18F);
            plusRightLabel.Location = new Point(417, 108);
            plusRightLabel.Name = "plusRightLabel";
            plusRightLabel.Size = new Size(115, 50);
            plusRightLabel.TabIndex = 5;
            plusRightLabel.Text = "?";
            plusRightLabel.TextAlign = ContentAlignment.MiddleCenter;
            plusRightLabel.Click += label3_Click;
            // 
            // sum
            // 
            sum.Font = new Font("Segoe UI", 18F);
            sum.Location = new Point(735, 108);
            sum.Margin = new Padding(2);
            sum.Name = "sum";
            sum.Size = new Size(182, 55);
            sum.TabIndex = 1;
            sum.Enter += answer_Enter;
            // 
            // difference
            // 
            difference.Font = new Font("Segoe UI", 18F);
            difference.Location = new Point(735, 240);
            difference.Margin = new Padding(2);
            difference.Name = "difference";
            difference.Size = new Size(182, 55);
            difference.TabIndex = 2;
            difference.Enter += answer_Enter;
            // 
            // minusRightLabel
            // 
            minusRightLabel.Font = new Font("Segoe UI", 18F);
            minusRightLabel.Location = new Point(417, 240);
            minusRightLabel.Name = "minusRightLabel";
            minusRightLabel.Size = new Size(115, 50);
            minusRightLabel.TabIndex = 10;
            minusRightLabel.Text = "?";
            minusRightLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 18F);
            label4.Location = new Point(594, 240);
            label4.Name = "label4";
            label4.Size = new Size(115, 50);
            label4.TabIndex = 9;
            label4.Text = "=";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 18F);
            label5.Location = new Point(224, 240);
            label5.Name = "label5";
            label5.Size = new Size(115, 50);
            label5.TabIndex = 8;
            label5.Text = "-";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // minusLeftLabel
            // 
            minusLeftLabel.Font = new Font("Segoe UI", 18F);
            minusLeftLabel.Location = new Point(50, 240);
            minusLeftLabel.Name = "minusLeftLabel";
            minusLeftLabel.Size = new Size(115, 50);
            minusLeftLabel.TabIndex = 7;
            minusLeftLabel.Text = "?";
            minusLeftLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // product
            // 
            product.Font = new Font("Segoe UI", 18F);
            product.Location = new Point(735, 373);
            product.Margin = new Padding(2);
            product.Name = "product";
            product.Size = new Size(182, 55);
            product.TabIndex = 3;
            product.Enter += answer_Enter;
            // 
            // timesRightLabel
            // 
            timesRightLabel.Font = new Font("Segoe UI", 18F);
            timesRightLabel.Location = new Point(417, 373);
            timesRightLabel.Name = "timesRightLabel";
            timesRightLabel.Size = new Size(115, 50);
            timesRightLabel.TabIndex = 15;
            timesRightLabel.Text = "?";
            timesRightLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI", 18F);
            label8.Location = new Point(594, 373);
            label8.Name = "label8";
            label8.Size = new Size(115, 50);
            label8.TabIndex = 14;
            label8.Text = "=";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            label9.Font = new Font("Segoe UI", 18F);
            label9.Location = new Point(224, 373);
            label9.Name = "label9";
            label9.Size = new Size(115, 50);
            label9.TabIndex = 13;
            label9.Text = "x";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // timesLeftLabel
            // 
            timesLeftLabel.Font = new Font("Segoe UI", 18F);
            timesLeftLabel.Location = new Point(50, 373);
            timesLeftLabel.Name = "timesLeftLabel";
            timesLeftLabel.Size = new Size(115, 50);
            timesLeftLabel.TabIndex = 12;
            timesLeftLabel.Text = "?";
            timesLeftLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // quotient
            // 
            quotient.Font = new Font("Segoe UI", 18F);
            quotient.Location = new Point(735, 510);
            quotient.Margin = new Padding(2);
            quotient.Name = "quotient";
            quotient.Size = new Size(182, 55);
            quotient.TabIndex = 4;
            quotient.Enter += answer_Enter;
            // 
            // dividedRightLabel
            // 
            dividedRightLabel.Font = new Font("Segoe UI", 18F);
            dividedRightLabel.Location = new Point(417, 510);
            dividedRightLabel.Name = "dividedRightLabel";
            dividedRightLabel.Size = new Size(115, 50);
            dividedRightLabel.TabIndex = 20;
            dividedRightLabel.Text = "?";
            dividedRightLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            label12.Font = new Font("Segoe UI", 18F);
            label12.Location = new Point(594, 510);
            label12.Name = "label12";
            label12.Size = new Size(115, 50);
            label12.TabIndex = 19;
            label12.Text = "=";
            label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            label13.Font = new Font("Segoe UI", 18F);
            label13.Location = new Point(224, 510);
            label13.Name = "label13";
            label13.Size = new Size(115, 50);
            label13.TabIndex = 18;
            label13.Text = "÷";
            label13.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dividedLeftLabel
            // 
            dividedLeftLabel.Font = new Font("Segoe UI", 18F);
            dividedLeftLabel.Location = new Point(50, 510);
            dividedLeftLabel.Name = "dividedLeftLabel";
            dividedLeftLabel.Size = new Size(115, 50);
            dividedLeftLabel.TabIndex = 17;
            dividedLeftLabel.Text = "?";
            dividedLeftLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // startButton
            // 
            startButton.AutoSize = true;
            startButton.Font = new Font("Segoe UI", 14F);
            startButton.Location = new Point(369, 618);
            startButton.Name = "startButton";
            startButton.Size = new Size(218, 52);
            startButton.TabIndex = 0;
            startButton.Text = "Start the quiz";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += startButton_Click;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // dateLabel
            // 
            dateLabel.Font = new Font("Segoe UI", 12F);
            dateLabel.Location = new Point(762, 699);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(200, 32);
            dateLabel.TabIndex = 21;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(974, 740);
            Controls.Add(dateLabel);
            Controls.Add(startButton);
            Controls.Add(quotient);
            Controls.Add(dividedRightLabel);
            Controls.Add(label12);
            Controls.Add(label13);
            Controls.Add(dividedLeftLabel);
            Controls.Add(product);
            Controls.Add(timesRightLabel);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(timesLeftLabel);
            Controls.Add(difference);
            Controls.Add(minusRightLabel);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(minusLeftLabel);
            Controls.Add(sum);
            Controls.Add(plusRightLabel);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(plusLeftLabel);
            Controls.Add(timeLeftLabel);
            Controls.Add(timeLabel);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            Text = "Luke Warner - Math Quiz";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)sum).EndInit();
            ((System.ComponentModel.ISupportInitialize)difference).EndInit();
            ((System.ComponentModel.ISupportInitialize)product).EndInit();
            ((System.ComponentModel.ISupportInitialize)quotient).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label timeLabel;
        private Label timeLeftLabel;
        private Label plusLeftLabel;
        private Label label1;
        private Label label2;
        private Label plusRightLabel;
        private NumericUpDown sum;
        private NumericUpDown difference;
        private Label minusRightLabel;
        private Label label4;
        private Label label5;
        private Label minusLeftLabel;
        private NumericUpDown product;
        private Label timesRightLabel;
        private Label label8;
        private Label label9;
        private Label timesLeftLabel;
        private NumericUpDown quotient;
        private Label dividedRightLabel;
        private Label label12;
        private Label label13;
        private Label dividedLeftLabel;
        private Button startButton;
        private System.Windows.Forms.Timer timer1;
        private Label dateLabel;
    }
}
