﻿using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WordTester
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        TestContainer test = null;

        public MainWindow()
        {
            InitializeComponent();
            btnStartTest.IsEnabled = false;
        }

        private void btnBetoltes_Click(object sender, RoutedEventArgs e)
        {

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            try
            {
                test = new TestContainer(ofd.FileName);
            }
            catch (Exception hiba)
            {
                MessageBox.Show($"A program nem tudta a tesztet betölteni! {hiba.Message}");
            }
            lblFileName.Content = ofd.FileName;
            lblWordsNum.Content = test.Count;
           
            sliTestWordsNum.Minimum = 3;
            sliTestWordsNum.Maximum = test.Count;

            int temp = (int)Math.Round(test.Count*0.1);
            sliTestWordsNum.Value = temp < 3 ? 3 : temp;
            btnStartTest.IsEnabled = true;
        }

		private void sliTestWordsNum_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
		{
            lblChosenNum.Content = Math.Round(sliTestWordsNum.Value) + " db";
		}

		private void btnStartTest_Click(object sender, RoutedEventArgs e)
		{
            List<string> wordstest = new List<string>();
            Random rnd = new Random();
			for (int i = 0; i < sliTestWordsNum.Value; i++)
			{
                wordstest.Add(test[rnd.Next(test.Count)]);
			}
            TestWindow twin = new TestWindow(wordstest);
            twin.Show();
            //btnStartTest.IsEnabled = false;
		}
	}
}
