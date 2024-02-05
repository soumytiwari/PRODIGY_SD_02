namespace Number_Guessing_Game
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
            txtInputGuess = new TextBox();
            lblLow = new Label();
            lblHigh = new Label();
            lblGuessCount = new Label();
            btnGen = new Button();
            btnGuess = new Button();
            txtInputLow = new TextBox();
            txtInputHigh = new TextBox();
            lblStatus = new Label();
            SuspendLayout();
            // 
            // txtInputGuess
            // 
            txtInputGuess.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtInputGuess.Location = new Point(78, 193);
            txtInputGuess.Name = "txtInputGuess";
            txtInputGuess.Size = new Size(165, 39);
            txtInputGuess.TabIndex = 0;
            txtInputGuess.TextAlign = HorizontalAlignment.Center;
            // 
            // lblLow
            // 
            lblLow.AutoSize = true;
            lblLow.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblLow.Location = new Point(78, 48);
            lblLow.Name = "lblLow";
            lblLow.Size = new Size(135, 28);
            lblLow.TabIndex = 1;
            lblLow.Text = "Lower Bound: ";
            // 
            // lblHigh
            // 
            lblHigh.AutoSize = true;
            lblHigh.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblHigh.Location = new Point(518, 44);
            lblHigh.Name = "lblHigh";
            lblHigh.Size = new Size(138, 28);
            lblHigh.TabIndex = 2;
            lblHigh.Text = "Upper Bound: ";
            // 
            // lblGuessCount
            // 
            lblGuessCount.AutoSize = true;
            lblGuessCount.Location = new Point(336, 421);
            lblGuessCount.Name = "lblGuessCount";
            lblGuessCount.Size = new Size(146, 20);
            lblGuessCount.TabIndex = 3;
            lblGuessCount.Text = "You guessed 0 times.";
            // 
            // btnGen
            // 
            btnGen.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnGen.Location = new Point(353, 130);
            btnGen.Name = "btnGen";
            btnGen.Size = new Size(106, 43);
            btnGen.TabIndex = 4;
            btnGen.Text = "Generate";
            btnGen.UseVisualStyleBackColor = true;
            btnGen.Click += btnGen_Click;
            // 
            // btnGuess
            // 
            btnGuess.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuess.Location = new Point(353, 333);
            btnGuess.Name = "btnGuess";
            btnGuess.Size = new Size(110, 43);
            btnGuess.TabIndex = 5;
            btnGuess.Text = "Guess";
            btnGuess.UseVisualStyleBackColor = true;
            btnGuess.Click += btnGuess_Click;
            // 
            // txtInputLow
            // 
            txtInputLow.BackColor = SystemColors.WindowFrame;
            txtInputLow.ForeColor = SystemColors.Window;
            txtInputLow.Location = new Point(219, 48);
            txtInputLow.Name = "txtInputLow";
            txtInputLow.Size = new Size(66, 27);
            txtInputLow.TabIndex = 6;
            txtInputLow.TextAlign = HorizontalAlignment.Center;
            // 
            // txtInputHigh
            // 
            txtInputHigh.BackColor = SystemColors.WindowFrame;
            txtInputHigh.ForeColor = SystemColors.Window;
            txtInputHigh.Location = new Point(662, 44);
            txtInputHigh.Name = "txtInputHigh";
            txtInputHigh.Size = new Size(65, 27);
            txtInputHigh.TabIndex = 7;
            txtInputHigh.TextAlign = HorizontalAlignment.Center;
            // 
            // lblStatus
            // 
            lblStatus.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblStatus.AutoSize = true;
            lblStatus.BorderStyle = BorderStyle.Fixed3D;
            lblStatus.Font = new Font("Sitka Banner", 13.7999992F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblStatus.Location = new Point(518, 196);
            lblStatus.Margin = new Padding(3);
            lblStatus.Name = "lblStatus";
            lblStatus.Padding = new Padding(2);
            lblStatus.Size = new Size(76, 36);
            lblStatus.TabIndex = 8;
            lblStatus.Text = "Status";
            lblStatus.TextAlign = ContentAlignment.MiddleCenter;
            lblStatus.UseCompatibleTextRendering = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(800, 450);
            Controls.Add(lblStatus);
            Controls.Add(txtInputHigh);
            Controls.Add(txtInputLow);
            Controls.Add(btnGuess);
            Controls.Add(btnGen);
            Controls.Add(lblGuessCount);
            Controls.Add(lblHigh);
            Controls.Add(lblLow);
            Controls.Add(txtInputGuess);
            Name = "Form1";
            Text = "Guessing Game";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtInputGuess;
        private Label lblLow;
        private Label lblHigh;
        private Label lblGuessCount;
        private Button btnGen;
        private Button btnGuess;
        private TextBox txtInputLow;
        private TextBox txtInputHigh;
        private Label lblStatus;
    }
}