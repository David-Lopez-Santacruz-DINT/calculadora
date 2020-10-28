using System;
using System.Windows;
using System.Windows.Controls;

namespace calculadora
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void b1Button_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            pantallaTextBox.Text += button.Content.ToString();
        }
    }
}
