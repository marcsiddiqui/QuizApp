using QuizApp.QuizAppDb;
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
    public partial class Exam : Form
    {
        QuizAppDbEntities entities = new QuizAppDbEntities();
        List<Question> allQuestions = new List<Question>();

        List<int> questionIdsThatAreAlreadyShown = new List<int>();

        int qno = 0;

        public Exam()
        {
            InitializeComponent();
        }

        private void Exam_Load(object sender, EventArgs e)
        {
            allQuestions = entities.Questions.ToList();

            var firstQuestion = allQuestions.FirstOrDefault();

            LoadQuestionOnForm(firstQuestion);
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void NextQuestion_Click(object sender, EventArgs e)
        {
            // LINQ = Line Integrated Query
            var question = allQuestions.Where(x => !questionIdsThatAreAlreadyShown.Contains(x.Id)).FirstOrDefault();

            LoadQuestionOnForm(question);
        }

        private void LoadQuestionOnForm(Question question)
        {
            qno++;
            Qno.Text = "Q.No. # " + qno.ToString();
            Question.Text = question.Question1;
            OptionA.Text = question.A;
            OptionB.Text = question.B;
            OptionC.Text = question.C;
            OptionD.Text = question.D;

            Marks.Text = "Marks: " + question.Marks.ToString();

            questionIdsThatAreAlreadyShown.Add(question.Id);

            if (question.HasMultipleAnswers)
            {
                RadioA.Hide();
                RadioB.Hide();
                RadioC.Hide();
                RadioD.Hide();

                CheckA.Show();
                CheckB.Show();
                CheckC.Show();
                CheckD.Show();
            }
            else
            {
                RadioA.Show();
                RadioB.Show();
                RadioC.Show();
                RadioD.Show();

                CheckA.Hide();
                CheckB.Hide();
                CheckC.Hide();
                CheckD.Hide();
            }

            RadioA.Checked = false;
            RadioB.Checked = false;
            RadioC.Checked = false;
            RadioD.Checked = false;

            CheckA.Checked = false;
            CheckB.Checked = false;
            CheckC.Checked = false;
            CheckD.Checked = false;
        }
    }
}
