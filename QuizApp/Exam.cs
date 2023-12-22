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

        Question currentQuestion = new Question();

        decimal resultMarks = 0;

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

            CalculateMarks();

            // LINQ = Line Integrated Query
            var question = allQuestions.Where(x => !questionIdsThatAreAlreadyShown.Contains(x.Id)).FirstOrDefault();

            LoadQuestionOnForm(question);
        }

        private void LoadQuestionOnForm(Question question)
        {
            currentQuestion = question;

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

            if (questionIdsThatAreAlreadyShown.Count == allQuestions.Count)
            {
                NextQuestion.Hide();
                SubmitExam.Show();
            }
        }

        private void SubmitExam_Click(object sender, EventArgs e)
        {
            CalculateMarks();

            MessageBox.Show("Your score is " + resultMarks, "Exam Finished");
        }

        private void CalculateMarks()
        {
            if (currentQuestion != null)
            {
                if (currentQuestion.HasMultipleAnswers)
                {
                    var selectedAnswers = new List<string>();
                    if (CheckA.Checked)
                        selectedAnswers.Add(currentQuestion.A);
                    if (CheckB.Checked)
                        selectedAnswers.Add(currentQuestion.B);
                    if (CheckC.Checked)
                        selectedAnswers.Add(currentQuestion.C);
                    if (CheckD.Checked)
                        selectedAnswers.Add(currentQuestion.D);

                    var correctAnswers = currentQuestion.CorrectAnswer.Split('~').ToList();
                    correctAnswers = correctAnswers.OrderBy(x => x).ToList();
                    selectedAnswers = selectedAnswers.OrderBy(x => x).ToList();

                    if (string.Join("~", correctAnswers) == string.Join("~", selectedAnswers))
                        resultMarks = resultMarks + currentQuestion.Marks;
                }
                else
                {
                    var selectedAnswer = "";

                    if (RadioA.Checked)
                        selectedAnswer = currentQuestion.A;
                    else if (RadioB.Checked)
                        selectedAnswer = currentQuestion.B;
                    else if (RadioC.Checked)
                        selectedAnswer = currentQuestion.C;
                    else if (RadioD.Checked)
                        selectedAnswer = currentQuestion.D;

                    resultMarks = selectedAnswer == currentQuestion.CorrectAnswer ? resultMarks + currentQuestion.Marks : resultMarks;
                }
            }
        }
    }
}
