using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinMath_WinQuiz
{
    public partial class Form2 : Form
    {
        int runs;
        readonly string word;
        readonly string level;
        int answer;
        int score = 0;
        readonly int max;
        public Form2(string name, int questions, string difficulty, int time)
        {
            InitializeComponent();

            runs = questions;
            word = name;
            level = difficulty;
            max = questions;

            timerBar.Maximum = time;
            timerBar.Value = time;
            timer.Enabled = true;

            QuestionRunner();
            
            timer.Tick += new EventHandler(TimerMove__Tick);

            answerButton.Click += new EventHandler(AnswerButton__Click);
        }

        

        private void QuestionRunner()
        {
            timer.Start();
            Random random = new Random();

            if(runs > 0)
            {
                GenerateQuestion(random);
                submitBox.Text = "";
            }
            else
            {
                timer.Stop();
                if (score >= max / 2)
                {
                    MessageBox.Show("Congratulations, " + word + ", you won with a score of " + score + "/" + max);
                }
                else
                {
                    MessageBox.Show("I'm sorry, " + word + ", you lost with a score of " + score + "/" + max);
                }
                Close();

            }
            runs--;

        }

        private void GenerateQuestion(Random rand)
        {
            int num1;
            int num2;
            int symbolNum = rand.Next(1, 3);
            string symbolText;

            if(level == "Easy")
            {
                num1 = rand.Next(10, 20);
                num2 = rand.Next(2, 7);
            }
            else if(level == "Medium")
            {
                num1 = rand.Next(20, 40);
                num2 = rand.Next(5, 15);
            }
            else
            {
                num1 = rand.Next(30, 50);
                num2 = rand.Next(7, 20);
            }

            if(symbolNum == 1)
            {
                symbolText = " + ";
                answer = num1 + num2;
                questLabel.Text = num1.ToString() + symbolText + num2.ToString();
            }
            else if(symbolNum == 2)
            {
                symbolText= " - ";
                answer = num1 - num2;
                questLabel.Text = num1.ToString() + symbolText + num2.ToString();
            }
            else
            {
                symbolText= " * ";
                answer = num1 * num2;
                questLabel.Text = num1.ToString() + symbolText + num2.ToString();
            }
        }

        private void TimerMove__Tick(object sender, EventArgs e)
        {
            if (timerBar.Value != timerBar.Minimum)
            {
                timerBar.Value--;
            }
            else if (timerBar.Value == timerBar.Minimum)
            {
                timer.Stop();
                MessageBox.Show("You ran out of time!  The correct answer was " + answer);
                QuestionRunner();
            }
        }

        private void AnswerButton__Click(object sender, EventArgs e)
        {
            timer.Stop();
            timerBar.Value = timerBar.Maximum;
            if(submitBox.Text == answer.ToString())
            {
                MessageBox.Show("Congrats " + word + ", you got it correct!");
                QuestionRunner();
                score++;
            }
            else
            {
                MessageBox.Show("Sorry " + word + ", you got it incorrect, the correct answer was: " + answer);
                QuestionRunner();
            }
        }

    }
}
