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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calc
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public char Operator;
        private bool IsDot = false;
        private Calculator calculator = new Calculator();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            if (this.Width == 400)
            {
                button.Content = "≡";
                this.Width = 500;
                this.Main.ColumnDefinitions[5].Width = new GridLength(94);
            }
            else
            {
                button.Content = "≡";
                this.Width = 400;
                this.Main.ColumnDefinitions[5].Width = new GridLength(0);
            }
        }

        private void button_Click_CE(object sender, RoutedEventArgs e)
        {
            TextBox_1.Text = Convert.ToString(calculator.Undo(1));
        }

        private void button_Click_C(object sender, RoutedEventArgs e)
        {
            TextBox_1.Text = "0";
        }

        private void button_Click_Backspace(object sender, RoutedEventArgs e)
        {
            if (TextBox_1.Text == "") { TextBox_1.Text = "0"; }
            TextBox_1.Text = TextBox_1.Text.Substring(0, TextBox_1.Text.Length - 1);
            if (TextBox_1.Text.IndexOf(".") == -1) IsDot = false;
            if (TextBox_1.Text == "") { TextBox_1.Text = "0"; }
        }

        private void button_Click_Plus(object sender, RoutedEventArgs e)
        {
            Operator = '+';
            calculator.arithmeticUnit.register = Convert.ToDouble(TextBox_1.Text);
            TextBox_1.Text = "0";
            IsDot = false;
        }

        private void button_Click_Minus(object sender, RoutedEventArgs e)
        {
            Operator = '-';
            calculator.arithmeticUnit.register = Convert.ToDouble(TextBox_1.Text);
            TextBox_1.Text = "0";
            IsDot = false;
        }

        private void button_Click_Multiply(object sender, RoutedEventArgs e)
        {
            Operator = '*';
            calculator.arithmeticUnit.register = Convert.ToDouble(TextBox_1.Text);
            TextBox_1.Text = "0";
            IsDot = false;
        }

        private void button_Click_Devide(object sender, RoutedEventArgs e)
        {
            Operator = '/';
            calculator.arithmeticUnit.register = Convert.ToDouble(TextBox_1.Text);
            TextBox_1.Text = "0";
            IsDot = false;
        }

        private void button_Click_Sqrt(object sender, RoutedEventArgs e)
        {
            Operator = '√';
            calculator.arithmeticUnit.register = Convert.ToDouble(TextBox_1.Text);
            calculator.arithmeticUnit.Run(Operator);
            TextBox_1.Text = calculator.arithmeticUnit.register.ToString();
        }

        private void button_Click_Pow(object sender, RoutedEventArgs e)
        {
            Operator = '^';
            calculator.arithmeticUnit.register = Convert.ToDouble(TextBox_1.Text);
            TextBox_1.Text = "0";
            IsDot = false;
        }

        private void button_Click_Ln(object sender, RoutedEventArgs e)
        {
            Operator = 'l';
            calculator.arithmeticUnit.register = Convert.ToDouble(TextBox_1.Text);
            calculator.arithmeticUnit.Run(Operator);
            TextBox_1.Text = calculator.arithmeticUnit.register.ToString();
        }

        private void button_Click_Exp(object sender, RoutedEventArgs e)
        {
            Operator = 'e';
            calculator.arithmeticUnit.register = Convert.ToDouble(TextBox_1.Text);
            calculator.arithmeticUnit.Run(Operator);
            TextBox_1.Text = calculator.arithmeticUnit.register.ToString();
        }

        private void button_Click_Equal(object sender, RoutedEventArgs e)
        {
            double operand = Convert.ToDouble(TextBox_1.Text);
            IsDot = false;
            calculator.arithmeticUnit.Run(Operator, operand);
            TextBox_1.Text = calculator.arithmeticUnit.register.ToString();
        }

        private void button_Click_00(object sender, RoutedEventArgs e)
        {
            string str = (string)((Button)e.OriginalSource).Content;
            if (TextBox_1.Text != "0") TextBox_1.Text = TextBox_1.Text + str;
        }
        private void button_Click_0(object sender, RoutedEventArgs e)
        {
            string str = (string)((Button)e.OriginalSource).Content;
            if (TextBox_1.Text != "0") TextBox_1.Text = TextBox_1.Text + str;
        }

        private void button_Click_1(object sender, RoutedEventArgs e)
        {
            string str = (string)((Button)e.OriginalSource).Content;
            if (TextBox_1.Text == "0")
                TextBox_1.Text = str;
            else TextBox_1.Text = TextBox_1.Text + str;
        }

        private void button_Click_2(object sender, RoutedEventArgs e)
        {
            string str = (string)((Button)e.OriginalSource).Content;
            if (TextBox_1.Text == "0")
                TextBox_1.Text = str;
            else TextBox_1.Text = TextBox_1.Text + str;
        }

        private void button_Click_3(object sender, RoutedEventArgs e)
        {
            string str = (string)((Button)e.OriginalSource).Content;
            if (TextBox_1.Text == "0")
                TextBox_1.Text = str;
            else TextBox_1.Text = TextBox_1.Text + str;
        }

        private void button_Click_4(object sender, RoutedEventArgs e)
        {
            string str = (string)((Button)e.OriginalSource).Content;
            if (TextBox_1.Text == "0")
                TextBox_1.Text = str;
            else TextBox_1.Text = TextBox_1.Text + str;
        }

        private void button_Click_5(object sender, RoutedEventArgs e)
        {
            string str = (string)((Button)e.OriginalSource).Content;
            if (TextBox_1.Text == "0")
                TextBox_1.Text = str;
            else TextBox_1.Text = TextBox_1.Text + str;
        }

        private void button_Click_6(object sender, RoutedEventArgs e)
        {
            string str = (string)((Button)e.OriginalSource).Content;
            if (TextBox_1.Text == "0")
                TextBox_1.Text = str;
            else TextBox_1.Text = TextBox_1.Text + str;
        }

        private void button_Click_7(object sender, RoutedEventArgs e)
        {
            string str = (string)((Button)e.OriginalSource).Content;
            if (TextBox_1.Text == "0")
                TextBox_1.Text = str;
            else TextBox_1.Text = TextBox_1.Text + str;
        }

        private void button_Click_8(object sender, RoutedEventArgs e)
        {
            string str = (string)((Button)e.OriginalSource).Content;
            if (TextBox_1.Text == "0")
                TextBox_1.Text = str;
            else TextBox_1.Text = TextBox_1.Text + str;
        }

        private void button_Click_9(object sender, RoutedEventArgs e)
        {
            string str = (string)((Button)e.OriginalSource).Content;
            if (TextBox_1.Text == "0")
                TextBox_1.Text = str;
            else TextBox_1.Text = TextBox_1.Text + str;
        }

        private void button_Click_Dot(object sender, RoutedEventArgs e)
        {
            string str = (string)((Button)e.OriginalSource).Content;
            if (!IsDot)
            {
                TextBox_1.Text = TextBox_1.Text + str;
                IsDot = true;
            }
        }
    }
}
