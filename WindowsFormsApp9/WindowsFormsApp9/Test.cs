using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp9
{
    public partial class Test : Form
    {
        private List<Question> questions = new List<Question>();
        private int currentQuestionIndex = 0;
        private int correctAnswersCount = 0;

        public Test()
        {
            InitializeComponent();
            InitializeQuestions();
            DisplayQuestion();
        }

        private void InitializeQuestions()
        {

            questions.Add(new Question("Что является ключом к успеху в продажах?", new string[] { "Уверенное знание продукта.", "Быстрое завершение сделки.", "Хороший внешний вид." }, 0));
            questions.Add(new Question("Что поможет вам лучше понять потребности клиента?", new string[] { "Активное слушание.", "Громкий голос.", "Быстрые решения." }, 0));
            questions.Add(new Question("Что является основой успешной сделки?", new string[] { "Реклама.", "Доверие.", "Большие скидки." }, 1));
            questions.Add(new Question("Как следует реагировать на непредвиденные ситуации в продажах?", new string[] { "Паниковать.", "Сохранять спокойствие и профессионализм.", "Прекращать разговор с клиентом." }, 1));
            questions.Add(new Question("Почему важно постоянное обучение для продавца?", new string[] { "Для того чтобы понравиться начальству.", "Чтобы следовать трендам и методикам.", "Чтобы сократить время на работе." }, 1));
        }

        private void DisplayQuestion()
        {
            
            if (currentQuestionIndex < questions.Count)
            {
                Question currentQuestion = questions[currentQuestionIndex];
                label1.Text = currentQuestion.Text;

                for (int i = 0; i < currentQuestion.Options.Length; i++)
                {
                    CheckBox checkBox = new CheckBox();
                    checkBox.Text = currentQuestion.Options[i];
                    checkBox.Tag = i; 
                    checkBox.AutoSize = true;
                    
                    flowLayoutPanel1.Controls.Add(checkBox);
                }
            }
            else
            {
                
                ShowResult();
            }
        }

        private void CheckAnswers()
        {
            
            foreach (CheckBox checkBox in flowLayoutPanel1.Controls)
            {
                if (checkBox.Checked && (int)checkBox.Tag == questions[currentQuestionIndex].CorrectAnswerIndex)
                {
                    correctAnswersCount++;
                    break; 
                }
            }
        }

        private void ShowResult()
        {
            
            MessageBox.Show($"Вы ответили правильно на {correctAnswersCount} из {questions.Count} вопросов.", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (correctAnswersCount == questions.Count)
            {
                MessageBox.Show("Поздравляем! Вы успешно прошли тест.", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

                Obuch_sot obuch_sot = Application.OpenForms.OfType<Obuch_sot>().FirstOrDefault();
                if (obuch_sot != null)
                {
                    obuch_sot.Close();
                }
        }
            else
            {
                MessageBox.Show("Пожалуйста, попробуйте еще раз.", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            correctAnswersCount = 0; 
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            CheckAnswers();
            currentQuestionIndex++;
            flowLayoutPanel1.Controls.Clear(); 
            DisplayQuestion();
        }
    }

    public class Question
    {
        public string Text { get; }
        public string[] Options { get; }
        public int CorrectAnswerIndex { get; }

        public Question(string text, string[] options, int correctAnswerIndex)
        {
            Text = text;
            Options = options;
            CorrectAnswerIndex = correctAnswerIndex;
        }
    }

}


