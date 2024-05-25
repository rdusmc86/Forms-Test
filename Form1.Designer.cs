namespace FinalRHarris
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxOne = new System.Windows.Forms.GroupBox();
            this.btnAnswerOne = new System.Windows.Forms.Button();
            this.radFourQuestionOne = new System.Windows.Forms.RadioButton();
            this.radThreeQuestionOne = new System.Windows.Forms.RadioButton();
            this.radTwoQuestionOne = new System.Windows.Forms.RadioButton();
            this.radOneQuestionOne = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelScore = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.groupBoxOne.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxOne
            // 
            this.groupBoxOne.Controls.Add(this.btnAnswerOne);
            this.groupBoxOne.Controls.Add(this.radFourQuestionOne);
            this.groupBoxOne.Controls.Add(this.radThreeQuestionOne);
            this.groupBoxOne.Controls.Add(this.radTwoQuestionOne);
            this.groupBoxOne.Controls.Add(this.radOneQuestionOne);
            this.groupBoxOne.Controls.Add(this.label1);
            this.groupBoxOne.Location = new System.Drawing.Point(12, 37);
            this.groupBoxOne.Name = "groupBoxOne";
            this.groupBoxOne.Size = new System.Drawing.Size(416, 200);
            this.groupBoxOne.TabIndex = 0;
            this.groupBoxOne.TabStop = false;
            this.groupBoxOne.Text = "Question 1";
            // 
            // btnAnswerOne
            // 
            this.btnAnswerOne.Location = new System.Drawing.Point(63, 157);
            this.btnAnswerOne.Name = "btnAnswerOne";
            this.btnAnswerOne.Size = new System.Drawing.Size(115, 23);
            this.btnAnswerOne.TabIndex = 5;
            this.btnAnswerOne.Text = "Check Answer";
            this.btnAnswerOne.UseVisualStyleBackColor = true;
            this.btnAnswerOne.Click += new System.EventHandler(this.btnAnswer_Click);
            // 
            // radFourQuestionOne
            // 
            this.radFourQuestionOne.AutoSize = true;
            this.radFourQuestionOne.Location = new System.Drawing.Point(29, 124);
            this.radFourQuestionOne.Name = "radFourQuestionOne";
            this.radFourQuestionOne.Size = new System.Drawing.Size(107, 17);
            this.radFourQuestionOne.TabIndex = 4;
            this.radFourQuestionOne.TabStop = true;
            this.radFourQuestionOne.Text = "Northern Cardinal";
            this.radFourQuestionOne.UseVisualStyleBackColor = true;
            // 
            // radThreeQuestionOne
            // 
            this.radThreeQuestionOne.AutoSize = true;
            this.radThreeQuestionOne.Location = new System.Drawing.Point(29, 101);
            this.radThreeQuestionOne.Name = "radThreeQuestionOne";
            this.radThreeQuestionOne.Size = new System.Drawing.Size(117, 17);
            this.radThreeQuestionOne.TabIndex = 3;
            this.radThreeQuestionOne.TabStop = true;
            this.radThreeQuestionOne.Text = "Carolina Chickadee";
            this.radThreeQuestionOne.UseVisualStyleBackColor = true;
            // 
            // radTwoQuestionOne
            // 
            this.radTwoQuestionOne.AutoSize = true;
            this.radTwoQuestionOne.Location = new System.Drawing.Point(29, 78);
            this.radTwoQuestionOne.Name = "radTwoQuestionOne";
            this.radTwoQuestionOne.Size = new System.Drawing.Size(91, 17);
            this.radTwoQuestionOne.TabIndex = 2;
            this.radTwoQuestionOne.TabStop = true;
            this.radTwoQuestionOne.Text = "Hermit Thrush";
            this.radTwoQuestionOne.UseVisualStyleBackColor = true;
            // 
            // radOneQuestionOne
            // 
            this.radOneQuestionOne.AutoSize = true;
            this.radOneQuestionOne.Location = new System.Drawing.Point(29, 55);
            this.radOneQuestionOne.Name = "radOneQuestionOne";
            this.radOneQuestionOne.Size = new System.Drawing.Size(65, 17);
            this.radOneQuestionOne.TabIndex = 1;
            this.radOneQuestionOne.TabStop = true;
            this.radOneQuestionOne.Text = "Blue Jay";
            this.radOneQuestionOne.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(26, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "What is the North Carolina state bird?";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(123, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(211, 52);
            this.label6.TabIndex = 5;
            this.label6.Text = "Your Score";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelScore
            // 
            this.labelScore.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelScore.Location = new System.Drawing.Point(153, 292);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(148, 64);
            this.labelScore.TabIndex = 6;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(254, 374);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(96, 23);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.Location = new System.Drawing.Point(107, 374);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(94, 23);
            this.btnRestart.TabIndex = 8;
            this.btnRestart.Text = "Retake Test";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 423);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBoxOne);
            this.Name = "Form1";
            this.Text = "N.C. Knowledge Test";
            this.groupBoxOne.ResumeLayout(false);
            this.groupBoxOne.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxOne;
        private System.Windows.Forms.Button btnAnswerOne;
        private System.Windows.Forms.RadioButton radFourQuestionOne;
        private System.Windows.Forms.RadioButton radThreeQuestionOne;
        private System.Windows.Forms.RadioButton radTwoQuestionOne;
        private System.Windows.Forms.RadioButton radOneQuestionOne;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Label label1;
    }
}

