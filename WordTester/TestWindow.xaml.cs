using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WordTester
{
    /// <summary>
    /// Interaction logic for TestWindow.xaml
    /// </summary>
    public partial class TestWindow : Window
    {
        int currentQuestionNumber;
        int numOfCorrectQuestion;
        TestContainer actTest;
        bool ISfromUKtoHU, IShelpForEveryWord;

        public TestWindow(TestContainer par, bool ISfromUKtoHU, bool IShelpForEveryWord)
        {
            InitializeComponent();
            this.ISfromUKtoHU = ISfromUKtoHU;
            this.IShelpForEveryWord = IShelpForEveryWord;
            this.actTest = par;
            currentQuestionNumber = 0;
            numOfCorrectQuestion = 0;
            NextQuestion();
            pbProcesss.Minimum = 0;
            pbProcesss.Maximum = actTest.RandomCount + 1;

        }

        private void NextQuestion()
        {
            pbProcesss.Value++;
            if (currentQuestionNumber == actTest.RandomCount)
            {
                grCells.IsEnabled = false;
                MessageBox.Show($"Vége! Az eredménye {numOfCorrectQuestion} jó válasz a {currentQuestionNumber} kérdésből");
                grCells.IsEnabled = true;
                this.Close();
                return;
            }
            lblQuestion.Content = ISfromUKtoHU ? actTest.GetRandomWordUK(currentQuestionNumber) : actTest.GetRandomWordHU(currentQuestionNumber);
            currentQuestionNumber++;

            txtAnswer.Focus();
        }

        private void btnAnswer_Click(object sender, RoutedEventArgs e)
        {
            AnswerCheck();
        }

        private void AnswerCheck()
        {
            if (ISfromUKtoHU && actTest.GetRandomWordHU(currentQuestionNumber - 1) == txtAnswer.Text
                || !ISfromUKtoHU && actTest.GetRandomWordUK(currentQuestionNumber - 1) == txtAnswer.Text)
            {
                numOfCorrectQuestion++;
            }
            else
            {
                if (IShelpForEveryWord)
                {
                    MessageBox.Show($"Téves! A helyes válasz: {(ISfromUKtoHU ? actTest.GetRandomWordHU(currentQuestionNumber - 1) : actTest.GetRandomWordUK(currentQuestionNumber - 1))}");
                }
            }
            lblActResult.Content = Math.Round(100d * numOfCorrectQuestion / currentQuestionNumber) + "%";

            txtAnswer.Text = "";
            NextQuestion();
        }

        private void txtAnswer_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                AnswerCheck();
            }
        }
    }
}
