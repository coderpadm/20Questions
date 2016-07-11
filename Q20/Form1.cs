using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q20
{
    public partial class Form1 : Form
    {
        Question root;

        public Form1()
        {
            InitializeComponent();
            WhatWasIt.Visible = false;
            newQuestionText.Visible = false;

            Question q1 = new Question();
            q1.question = "Is it organic?";
            q1.yes = new Question();
            q1.yes.question = "Is it chocolate?";
            q1.no = new Question();
            q1.no.question = "Is it sand?";
            root = q1;

            //show the question
        }

        

        

        private void YesButton_Click(object sender, EventArgs e)
        {
            //Yes button

            //was this a leaf?
            //  if yes, we guessed it
            // if no,move down the yes branch
            

        }

        private void NoButton_Click(object sender, EventArgs e)
        {
            //No button

            //was this a leaf?
            //  if yes, we don't know it, so get new info
            // if no,move down the no branch
        }
    }
}
