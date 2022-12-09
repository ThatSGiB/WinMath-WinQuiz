namespace WinMath_WinQuiz
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.questLabel = new System.Windows.Forms.Label();
            this.answerLabel = new System.Windows.Forms.Label();
            this.submitBox = new System.Windows.Forms.TextBox();
            this.answerButton = new System.Windows.Forms.Button();
            this.timerBar = new System.Windows.Forms.ToolStripProgressBar();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.timerBar});
            this.statusStrip.Location = new System.Drawing.Point(0, 198);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(435, 22);
            this.statusStrip.TabIndex = 0;
            this.statusStrip.Text = "statusStrip2";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            // 
            // questLabel
            // 
            this.questLabel.AutoSize = true;
            this.questLabel.Location = new System.Drawing.Point(201, 30);
            this.questLabel.Name = "questLabel";
            this.questLabel.Size = new System.Drawing.Size(35, 13);
            this.questLabel.TabIndex = 1;
            this.questLabel.Text = "label2";
            // 
            // answerLabel
            // 
            this.answerLabel.AutoSize = true;
            this.answerLabel.Location = new System.Drawing.Point(54, 85);
            this.answerLabel.Name = "answerLabel";
            this.answerLabel.Size = new System.Drawing.Size(96, 13);
            this.answerLabel.TabIndex = 2;
            this.answerLabel.Text = "Your Answer Here:";
            // 
            // submitBox
            // 
            this.submitBox.Location = new System.Drawing.Point(171, 81);
            this.submitBox.Name = "submitBox";
            this.submitBox.Size = new System.Drawing.Size(100, 20);
            this.submitBox.TabIndex = 3;
            // 
            // answerButton
            // 
            this.answerButton.Location = new System.Drawing.Point(181, 132);
            this.answerButton.Name = "answerButton";
            this.answerButton.Size = new System.Drawing.Size(75, 23);
            this.answerButton.TabIndex = 4;
            this.answerButton.Text = "Submit";
            this.answerButton.UseVisualStyleBackColor = true;
            // 
            // timerBar
            // 
            this.timerBar.Name = "timerBar";
            this.timerBar.Size = new System.Drawing.Size(300, 16);
            // 
            // Form2
            // 
            this.ClientSize = new System.Drawing.Size(435, 220);
            this.Controls.Add(this.answerButton);
            this.Controls.Add(this.submitBox);
            this.Controls.Add(this.answerLabel);
            this.Controls.Add(this.questLabel);
            this.Controls.Add(this.statusStrip);
            this.Name = "Form2";
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.TextBox answerBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label questLabel;
        private System.Windows.Forms.Label answerLabel;
        private System.Windows.Forms.TextBox submitBox;
        private System.Windows.Forms.Button answerButton;
        private System.Windows.Forms.ToolStripProgressBar timerBar;
    }
}