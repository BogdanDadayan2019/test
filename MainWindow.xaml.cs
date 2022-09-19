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

        int sum = 0;

        StringBuilder stringBilder = new StringBuilder();

        int first;
        int second;

        public MainWindow()
        {
            InitializeComponent();
            
            //button_sumal.IsEnabled = false; 
        }

        public void CheckSecondChislo()
        {
            if (second <= 0)
            {
                button_sumal.IsEnabled = false;
            }
            else
            {
                button_sumal.IsEnabled = true;
            }
        }

        private void button_plus_Click(object sender, RoutedEventArgs e)

        {
            if(tb_sumal.Text == "")
            {
                first = 0;
            }
            else
            {
                first = Int32.Parse(tb_sumal.Text);
            }
            sum = 0;
            stringBilder.Clear();
            tb_sumal.Text = "0";
            //button_sumal.IsEnabled = true;
            //button_plus.IsEnabled = false;
        }

        private void button_delete_Click(object sender, RoutedEventArgs e)
        {
            tb_sumal.Text = "0";

            stringBilder.Clear();
            sum = 0;
            first = 0;
            second = 0;
        }

        private void button_sumal_Click(object sender, RoutedEventArgs e)
        {
            if(tb_sumal.Text == "")
            {
                second = 0;
            }
            else
            {
                second = Int32.Parse(tb_sumal.Text);
            }
            
            sum = first + second;
            tb_sumal.Text = sum.ToString();

            //button_plus.IsEnabled = true;
            //button_sumal.IsEnabled = false;

            stringBilder.Clear();
            sum = 0;
            first = 0;
            second = 0;
        }

        private void button_1_Click(object sender, RoutedEventArgs e)
        {
            tb_sumal.Text = stringBilder.Append("1").ToString();
        }
        private void button_2_Click(object sender, RoutedEventArgs e)
        {
            tb_sumal.Text = stringBilder.Append("2").ToString();
        }
        private void button_3_Click(object sender, RoutedEventArgs e)
        {
            tb_sumal.Text = stringBilder.Append("3").ToString();
        }

        private void button_4_Click(object sender, RoutedEventArgs e)
        {
            tb_sumal.Text = stringBilder.Append("4").ToString();
        }

        private void button_5_Click(object sender, RoutedEventArgs e)
        {
            tb_sumal.Text = stringBilder.Append("5").ToString();
        }

        private void button_6_Click(object sender, RoutedEventArgs e)
        {
            tb_sumal.Text = stringBilder.Append("6").ToString();
        }

        private void button_7_Click(object sender, RoutedEventArgs e)
        {
            tb_sumal.Text = stringBilder.Append("7").ToString();
        }

        private void button_8_Click(object sender, RoutedEventArgs e)
        {
            tb_sumal.Text = stringBilder.Append("8").ToString();
        }

        private void button_9_Click(object sender, RoutedEventArgs e)
        {
            tb_sumal.Text = stringBilder.Append("9").ToString();
        }

        private void button_0_Click(object sender, RoutedEventArgs e)
        {
            tb_sumal.Text = stringBilder.Append("0").ToString();
        }

        private void button_delete_Click_1(object sender, RoutedEventArgs e)
        {
            tb_sumal.Text = "";
            sum = 0;
            first = 0;
            second = 0;
        }

        private void button_ymnoz_Click(object sender, RoutedEventArgs e)
        {

        }

        private void button_minus_Click(object sender, RoutedEventArgs e)
        {

        }

        private void button_razdel_Click(object sender, RoutedEventArgs e)
        {

        }

        private void tb_sumal_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}