using QuizApp.QuizApp_DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizApp
{
    public partial class QuestionManager : Form
    {
        QuizAppEntities quizAppEntities = new QuizAppEntities();

        public QuestionManager()
        {
            InitializeComponent();
        }

        private void SaveQuestion_Click(object sender, EventArgs e)
        {
            var question = new Question();
            question.Question1 = Question.Text;
            question.A = OptionA.Text;
            question.B = OptionB.Text;
            question.C = OptionC.Text;
            question.D = OptionD.Text;
            if (A.Checked)
            {
                question.CorrectAnswer = OptionA.Text;
            }
            else if (B.Checked)
            {
                question.CorrectAnswer = OptionB.Text;
            }
            else if (C.Checked)
            {
                question.CorrectAnswer = OptionC.Text;
            }
            else if (D.Checked)
            {
                question.CorrectAnswer = OptionD.Text;
            }
            else
            {
                MessageBox.Show("Please select the right answer.", "Error");
            }
            quizAppEntities.Questions.Add(question);
            quizAppEntities.SaveChanges();
        }
    }
}
