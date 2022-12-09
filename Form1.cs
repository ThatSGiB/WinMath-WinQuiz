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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            questionBox.KeyPress += new KeyPressEventHandler(NumTextBox__KeyPress);
            timerBox.KeyPress += new KeyPressEventHandler(NumTextBox__KeyPress);
            submitButton.Click += new EventHandler(SubmitButton__Click);

            nameBox.Validating += new CancelEventHandler(ValidText__Validating);
            questionBox.Validating += new CancelEventHandler(ValidText__Validating);
            timerBox.Validating += new CancelEventHandler(ValidText__Validating);

            nameBox.TextChanged += new EventHandler(NewType__TextChanged);
            questionBox.TextChanged += new EventHandler(NewType__TextChanged);
            timerBox.TextChanged += new EventHandler(NewType__TextChanged);

            difficultyBox.SelectedIndex = 0;
            submitButton.Enabled = false;
        }

        private void NumTextBox__KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar);
        }

        private void ValidText__Validating(object sender, CancelEventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            if (textBox.Text == null)
            {
                this.errorProvider.SetError(textBox, "Please Enter A Valid Response");
                e.Cancel = true;
                textBox.Tag = false;
            }
            else
            {
                this.errorProvider.SetError(textBox, null);
                e.Cancel = false;
                textBox.Tag = true;
            }

            ValidButton();
        }

        private void NewType__TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            if (textBox.Text == null)
            {
                this.errorProvider.SetError(textBox, "Please Enter A Valid Response");
                textBox.Tag = false;
            }
            else
            {
                this.errorProvider.SetError(textBox, null);
                textBox.Tag = true;
            }

            ValidButton();

        }

        private void ValidButton()
        {
            /*this.submitButton.Enabled =
                (bool)nameBox.Tag == true &&
                (bool)questionBox.Tag == true &&
                (bool)timerBox.Tag == true;*/

            if(nameBox.Text != "" && questionBox.Text != "" && timerBox.Text != "")
            {
                submitButton.Enabled = true;
            }

        }
        private void SubmitButton__Click(object sender, EventArgs e)
        {
            if(difficultyBox.Text == "Easy" || difficultyBox.Text == "Medium" || difficultyBox.Text == "Hard")
            {
                Form2 form = new Form2(nameBox.Text, Convert.ToInt32(questionBox.Text), difficultyBox.Text, Convert.ToInt32(timerBox.Text));
                form.ShowDialog();
            }
        }

    }
}
