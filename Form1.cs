using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalRHarris
{
    public partial class Form1 : Form
    {
        //variables for question index and user score
        private int currentQuestionIndex = 0;
        private int score = 0;

        public Form1()
        {
            //initializes first question to start test
            InitializeComponent();
            DisplayQuestion();
            UpdateScoreDisplay();
        }

        private void DisplayQuestion()
        {
            //switch statement setting question number, questoin text, and answer options
            switch (currentQuestionIndex)
            {
                case 0:
                    groupBoxOne.Text = "Question 1";
                    label1.Text = "What is the state bird of North Carolina?";
                    radOneQuestionOne.Text = "Blue Jay";
                    radTwoQuestionOne.Text = "Hermit Thrush";
                    radThreeQuestionOne.Text = "Carolina Chickadee";
                    radFourQuestionOne.Text = "Northern Cardinal";
                    break;
                case 1:
                    groupBoxOne.Text = "Question 2";
                    label1.Text = "What is the longest river in North Carolina?";
                    radOneQuestionOne.Text = "Great Pee Dee River";
                    radTwoQuestionOne.Text = "Catawba River";
                    radThreeQuestionOne.Text = "Roanoke River";
                    radFourQuestionOne.Text = "Tar River";
                    break;
                case 2:
                    groupBoxOne.Text = "Question 3";
                    label1.Text = "North Carolina was the ___ state to join the Union.";
                    radOneQuestionOne.Text = "12th";
                    radTwoQuestionOne.Text = "10th";
                    radThreeQuestionOne.Text = "13th";
                    radFourQuestionOne.Text = "8th";
                    break;
                case 3:
                    groupBoxOne.Text = "Question 4";
                    label1.Text = "Mount Airy inspired the setting for which popular television show?";
                    radOneQuestionOne.Text = "Green Acres";
                    radTwoQuestionOne.Text = "The Andy Griffith Show";
                    radThreeQuestionOne.Text = "The Dick Van Dyke Show";
                    radFourQuestionOne.Text = "Gomer Pyle, U.S.M.C";
                    break;
                case 4:
                    groupBoxOne.Text = "Question 5";
                    label1.Text = "Which of these cities is the capital of North Carolina?";
                    radOneQuestionOne.Text = "Charlotte";
                    radTwoQuestionOne.Text = "Raleigh";
                    radThreeQuestionOne.Text = "Wilmington";
                    radFourQuestionOne.Text = "Greensboro";
                    break;

            }
        }

        private void CheckAnswer()
        {
            int selectedOptionIndex = GetSelectedOptionIndex();

            if (selectedOptionIndex == GetCorrectOptionIndex())
            {
                MessageBox.Show("Correct!");
                score++; //correct answers incremented for final score calculation
            }
            else
            {
                MessageBox.Show("Incorrect!");
            }

            currentQuestionIndex++;
            DisplayQuestion();
            UpdateScoreDisplay(); //updates score display after answering
        }

        //method retrieves index of selected radio button answer
        private int GetSelectedOptionIndex()
        {
            if (radOneQuestionOne.Checked) return 0;
            if (radTwoQuestionOne.Checked) return 1;
            if (radThreeQuestionOne.Checked) return 2;
            if (radFourQuestionOne.Checked) return 3;
            return -1; // No option selected
        }

        //method retrieving index of correct answer (return) for the current question (case)
        private int GetCorrectOptionIndex()
        {
            switch (currentQuestionIndex)
            {
                case 0: return 3; // Northern Cardinal
                case 1: return 2; // Roanoke River
                case 2: return 0; // 12th
                case 3: return 1; // The Andy Griffith Show
                case 4: return 1; // Raleigh
                default: return -1;
            }
        }

        //method for updating score and displaying results/score
        private void UpdateScoreDisplay()
        {
            if (currentQuestionIndex == 5)
            {
                int totalQuestions = 5;
                double percentScore = (double)score / totalQuestions * 100; //calculates score percentage
                labelScore.Text = $"Correct Answers: {score}/{totalQuestions} \n\n ({percentScore:F1}%)"; //displays amount of questions answered correctly and score percentage

                //shows appropriate message based on user's passing/failing score
                if (percentScore >= 70)
                {
                    MessageBox.Show("You passed the test!");
                }
                else
                {
                    MessageBox.Show("You failed. Try again.");
                }
            }
        }
        // Event handler checking for correct/incorrect answer
        private void btnAnswer_Click(object sender, EventArgs e)
        {
            CheckAnswer();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RestartTest()
        {
            currentQuestionIndex = 0;
            score = 0;
            DisplayQuestion();
            UpdateScoreDisplay();
            labelScore.Text = ""; //clear labelScore when test is restarted
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            RestartTest();
        }
    }
}