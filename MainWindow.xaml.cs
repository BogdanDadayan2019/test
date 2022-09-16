using System;
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
        int first;
        int second; 

        public MainWindow()
        {
            InitializeComponent();
        }



        private void button_2_Click(object sender, RoutedEventArgs e)
        {
            tb_sumal.Text = "2";
        }

        private void button_1_Click(object sender, RoutedEventArgs e)
        {
            tb_sumal.Text = "1";
        }

        private void button_plus_Click(object sender, RoutedEventArgs e)

        {
            first = Int32.Parse(tb_sumal.Text);
            sum = 0;
            tb_sumal.Text = "";

            button_plus.IsEnabled = false;
        }

        private void button_delete_Click(object sender, RoutedEventArgs e)
        {
            tb_sumal.Text = "";
            sum = 0;
            first = 0;
            second = 0;
        }

        private void button_sumal_Click(object sender, RoutedEventArgs e)
        {
            second = Int32.Parse(tb_sumal.Text);
            sum = first + second;
            tb_sumal.Text = sum.ToString();

            button_plus.IsEnabled = true;


            sum = 0;
            first = 0;
            second = 0;
        }

        private void button_3_Click(object sender, RoutedEventArgs e)
        {
            tb_sumal.Text = "3";
        }

        private void button_4_Click(object sender, RoutedEventArgs e)
        {
            tb_sumal.Text = "4";
        }

        private void button_5_Click(object sender, RoutedEventArgs e)
        {
            tb_sumal.Text = "5";
        }

        private void button_6_Click(object sender, RoutedEventArgs e)
        {
            tb_sumal.Text = "6";
        }

        private void button_7_Click(object sender, RoutedEventArgs e)
        {
            tb_sumal.Text = "7";
        }

        private void button_8_Click(object sender, RoutedEventArgs e)
        {
            tb_sumal.Text = "8";
        }

        private void button_9_Click(object sender, RoutedEventArgs e)
        {
            tb_sumal.Text = "9";
        }

        private void button_0_Click(object sender, RoutedEventArgs e)
        {
            tb_sumal.Text = "0";
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
