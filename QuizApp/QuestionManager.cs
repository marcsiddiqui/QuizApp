using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuizApp.QuizAppDb;

namespace QuizApp
{
    public partial class QuestionManager : Form
    {
        QuizAppDbEntities entities = new QuizAppDbEntities();

        public QuestionManager()
        {
            InitializeComponent();
        }

        private void SaveQuestion_Click(object sender, EventArgs e)
        {
            var hasErrors = false;

            var correctAnswers = new List<string>();

            Question question = new Question();
            question.Question1 = Question.Text;
            question.A = OptionA.Text;
            question.B = OptionB.Text;
            question.C = OptionC.Text;
            question.D = OptionD.Text;

            if (A.Checked)
                correctAnswers.Add(OptionA.Text);
            
            if (B.Checked)
                correctAnswers.Add(OptionB.Text);
            
            if (C.Checked)
                correctAnswers.Add(OptionC.Text);
            
            if (D.Checked)
                correctAnswers.Add(OptionD.Text);

            if (!A.Checked && !B.Checked && !C.Checked && !D.Checked)
            {
                hasErrors = true;
                MessageBox.Show("Please select correct answer", "Error");
            }

            question.Marks = Convert.ToDecimal(Marks.Text);

            if (!hasErrors)
            {

                question.CorrectAnswer = string.Join("~", correctAnswers);

                question.HasMultipleAnswers = correctAnswers.Count > 1;

                entities.Questions.Add(question);
                entities.SaveChanges();

                ClearAll();
            }
        }

        private void A_CheckedChanged(object sender, EventArgs e)
        {
            DecideQuestionMarks();
        }

        private void B_CheckedChanged(object sender, EventArgs e)
        {
            DecideQuestionMarks();
        }

        private void C_CheckedChanged(object sender, EventArgs e)
        {
            DecideQuestionMarks();
        }

        private void D_CheckedChanged(object sender, EventArgs e)
        {
            DecideQuestionMarks();
        }

        public void DecideQuestionMarks()
        {
            double option_a = A.Checked ? 0.5 : 0;
            double option_b = B.Checked ? 0.5 : 0;
            double option_c = C.Checked ? 0.5 : 0;
            double option_d = D.Checked ? 0.5 : 0;
            
            Marks.Text = (option_a + option_b + option_c + option_d).ToString();
        }

        public void ClearAll()
        {
            Question.Text = "";
            OptionA.Text = "";
            OptionB.Text = "";
            OptionC.Text = "";
            OptionD.Text = "";
            Marks.Text = "0";
            A.Checked = false;
            B.Checked = false;
            C.Checked = false;
            D.Checked = false;
        }

        private void ClearAll_Fields_Click(object sender, EventArgs e)
        {
            ClearAll();
        }
    }
}
