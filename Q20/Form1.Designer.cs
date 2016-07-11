namespace Q20
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
            this.QuestionText = new System.Windows.Forms.Label();
            this.YesButton = new System.Windows.Forms.Button();
            this.NoButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.WhatWasIt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.newQuestionText = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // QuestionText
            // 
            this.QuestionText.AutoSize = true;
            this.QuestionText.Location = new System.Drawing.Point(86, 41);
            this.QuestionText.Name = "QuestionText";
            this.QuestionText.Size = new System.Drawing.Size(51, 20);
            this.QuestionText.TabIndex = 0;
            this.QuestionText.Text = "label1";
            // 
            // YesButton
            // 
            this.YesButton.Location = new System.Drawing.Point(263, 41);
            this.YesButton.Name = "YesButton";
            this.YesButton.Size = new System.Drawing.Size(156, 33);
            this.YesButton.TabIndex = 1;
            this.YesButton.Text = "Yes";
            this.YesButton.UseVisualStyleBackColor = true;
            this.YesButton.Click += new System.EventHandler(this.YesButton_Click);
            // 
            // NoButton
            // 
            this.NoButton.Location = new System.Drawing.Point(263, 89);
            this.NoButton.Name = "NoButton";
            this.NoButton.Size = new System.Drawing.Size(156, 30);
            this.NoButton.TabIndex = 2;
            this.NoButton.Text = "No";
            this.NoButton.UseVisualStyleBackColor = true;
            this.NoButton.Click += new System.EventHandler(this.NoButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "What was it?";
            // 
            // WhatWasIt
            // 
            this.WhatWasIt.Location = new System.Drawing.Point(328, 212);
            this.WhatWasIt.Name = "WhatWasIt";
            this.WhatWasIt.Size = new System.Drawing.Size(100, 26);
            this.WhatWasIt.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 317);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Give me a new question:";
            // 
            // newQuestionText
            // 
            this.newQuestionText.Location = new System.Drawing.Point(94, 359);
            this.newQuestionText.Name = "newQuestionText";
            this.newQuestionText.Size = new System.Drawing.Size(100, 26);
            this.newQuestionText.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(298, 400);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 37);
            this.button1.TabIndex = 7;
            this.button1.Text = "Commit";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 449);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.newQuestionText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.WhatWasIt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NoButton);
            this.Controls.Add(this.YesButton);
            this.Controls.Add(this.QuestionText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label QuestionText;
        private System.Windows.Forms.Button YesButton;
        private System.Windows.Forms.Button NoButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox WhatWasIt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox newQuestionText;
        private System.Windows.Forms.Button button1;
    }
}

