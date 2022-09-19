using System;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace CalcThread
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        int sumOfNumbers = 0;

        StringBuilder stringBilder = new StringBuilder();

        int firstNumber;
        int secondNumber;

        public MainWindow()
        {
            InitializeComponent();

            
        }

        // ~~~~~~~~~~~~~~~Number Buttons~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

        private void ButtonOneNumber_Click(object sender, RoutedEventArgs e)
        {
            stringBilder.Append(ButtonOneNumber.Content);
            TextBlockNumberMain.Text = stringBilder.ToString();
        }

        private void ButtonTwoNumber_Click(object sender, RoutedEventArgs e)
        {
            stringBilder.Append(ButtonTwoNumber.Content);
            TextBlockNumberMain.Text = stringBilder.ToString();
        }

        private void ButtonThreeNumber_Click(object sender, RoutedEventArgs e)
        {
            stringBilder.Append(ButtonThreeNumber.Content);
            TextBlockNumberMain.Text = stringBilder.ToString();
        }

        private void ButtonFourNumber_Click(object sender, RoutedEventArgs e)
        {
            stringBilder.Append(ButtonFourNumber.Content);
            TextBlockNumberMain.Text = stringBilder.ToString();
        }

        private void ButtonFiveNumber_Click(object sender, RoutedEventArgs e)
        {
            stringBilder.Append(ButtonFiveNumber.Content);
            TextBlockNumberMain.Text = stringBilder.ToString();
        }

        private void ButtonSixNumber_Click(object sender, RoutedEventArgs e)
        {
            stringBilder.Append(ButtonSixNumber.Content);
            TextBlockNumberMain.Text = stringBilder.ToString();
        }

        private void ButtonSevenNumber_Click(object sender, RoutedEventArgs e)
        {
            stringBilder.Append(ButtonSevenNumber.Content);
            TextBlockNumberMain.Text = stringBilder.ToString();
        }

        private void ButtonEightNumber_Click(object sender, RoutedEventArgs e)
        {
            stringBilder.Append(ButtonEightNumber.Content);
            TextBlockNumberMain.Text = stringBilder.ToString();
        }

        private void ButtonNineNumber_Click(object sender, RoutedEventArgs e)
        {
            stringBilder.Append(ButtonNineNumber.Content);
            TextBlockNumberMain.Text = stringBilder.ToString();
        }

        private void ButtonZeroNumber_Click(object sender, RoutedEventArgs e)
        {
            stringBilder.Append(ButtonZeroNumber.Content);
            TextBlockNumberMain.Text = stringBilder.ToString();
        }

        private void ButtonDelete_Click(object sender, RoutedEventArgs e)
        {
            firstNumber = 0;
            secondNumber = 0;


            stringBilder.Clear();
            TextBlockNumberMain.Text = "";
            TextBlockNumberSecond.Text = "";

        }

        private void ButtonPlus_Click(object sender, RoutedEventArgs e)
        {

            if (TextBlockNumberMain.Text == "")
            {
                firstNumber = 0;
            }
            else
            {
                firstNumber = Int32.Parse(TextBlockNumberMain.Text);
              
            }

            sumOfNumbers = 0;
            stringBilder.Clear();
            TextBlockNumberMain.Text = "0";

        }

        private void ButtonEquals_Click(object sender, RoutedEventArgs e)
        {

            if (TextBlockNumberMain.Text == "")
            {
                secondNumber = 0;
            }
            else
            {
                secondNumber = Int32.Parse(TextBlockNumberMain.Text);
            }

            sumOfNumbers = secondNumber + firstNumber;
            TextBlockNumberMain.Text = sumOfNumbers.ToString();

            stringBilder.Clear();

            sumOfNumbers = 0;
            firstNumber = 0;
            secondNumber = 0;
        }


        //private void button_sumal_Click(object sender, RoutedEventArgs e)
        //{
        //    if (tb_sumal.Text == "")
        //    {
        //        second = 0;
        //    }
        //    else
        //    {
        //        second = Int32.Parse(tb_sumal.Text);
        //    }

        //    sum = first + second;
        //    tb_sumal.Text = sum.ToString();

        //    //button_plus.IsEnabled = true;
        //    //button_sumal.IsEnabled = false;

        //    stringBilder.Clear();
        //    sum = 0;
        //    first = 0;
        //    second = 0;
        //}
  //    }

    }
}