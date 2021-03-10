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
		int actQuestionNumber;
		int correctAnswer;
		List<string> innerList;
		public TestWindow(List<string> wordPairs)
		{
			innerList = wordPairs;
			InitializeComponent();
			actQuestionNumber = 0;
			correctAnswer = 0;
			NextQuestion();
			pbProcess.Minimum = 0;
			pbProcess.Maximum = innerList.Count + 1;
		}

		private void NextQuestion()
		{
			pbProcess.Value++;
			if (innerList.Count == 0)
			{
				MessageBox.Show("Jó válasz: "+correctAnswer+" Kérdésből:"+ actQuestionNumber);
				return;
			}
			lblQuestion.Content = innerList[0].Split(';')[0];
			actQuestionNumber++;
			txtAnswer.Focus();
		}

		private void rogzit_Click(object sender, RoutedEventArgs e)
		{
			Rogzit();
		}

		private void Rogzit()
		{
			if (innerList[0].Split(';')[1] == txtAnswer.Text)
			{
				correctAnswer++;
			}
			actResult.Content = Math.Round(100d * correctAnswer / actQuestionNumber)+ "%"; //100d implicit típuskényszerítés. a 100 double-ként értelmezett.
			txtAnswer.Text = "";
			innerList.RemoveAt(0);
			NextQuestion();
		}

		private void txtAnswer_KeyUp(object sender, KeyEventArgs e)
		{
			if (e.Key == Key.Enter)
			{
				Rogzit();
			}
		}
	}
}
