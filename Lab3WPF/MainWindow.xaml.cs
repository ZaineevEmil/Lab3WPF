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

namespace Lab3WPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string fontName = ((sender as ComboBox).SelectedItem as TextBlock).Text;
            if (textBox != null)
            {
                textBox.FontFamily = new FontFamily(fontName);
            }
        }

        private void ComboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            if (textBox != null)
            {
                textBox.FontSize = Convert.ToDouble(((sender as ComboBox).SelectedItem as TextBlock).Text);
            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (textBox.FontWeight.ToString() == "Normal")
            {
                textBox.FontWeight = FontWeight.FromOpenTypeWeight(700);
            }
            else
            {
                textBox.FontWeight = FontWeight.FromOpenTypeWeight(400);
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (textBox.FontStyle != FontStyles.Italic)
            {
                textBox.FontStyle = FontStyles.Italic;
            }
            else
            {
                textBox.FontStyle = FontStyles.Normal;
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (textBox.TextDecorations != TextDecorations.Underline)
            {

                textBox.TextDecorations = TextDecorations.Underline;
            }
            else
            {
                textBox.TextDecorations = null;
            }
        }

        private void radioButtons_Click(object sender, RoutedEventArgs e)
        {
            if (radioButtonBlack.IsChecked == true)
            {
                textBox.Foreground = Brushes.Black;
            }
            else
            {
                textBox.Foreground = Brushes.Red;
            }
        }
    }
}
