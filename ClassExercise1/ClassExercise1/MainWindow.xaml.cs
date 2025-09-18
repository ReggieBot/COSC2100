// Reggie Brown
// Last Modified: 2025 - 09 - 18
// Class Exercise 1 - Calulator
// Simple calculator in WPF to add and multiply two numbers
// COSC 2100
// Prof. Fabian
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ClassExercise1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // logic for Add button click event
        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double num1 = Convert.ToDouble(Input1TextBox.Text);
                double num2 = Convert.ToDouble(Input2TextBox.Text);
                double sum = num1 + num2;

                // display result to label (parsed to string)
                labelResult.Content = sum.ToString();
            }

            // catch any exceptions and display error message
            // invalid input (non-numeric) will throw exception
            catch (Exception ex)
            {
                labelResult.Content = "Error" + ex.Message;
            }
        }

        // logic for multiply button click event
        private void MultiplyButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double num1 = Convert.ToDouble(Input1TextBox.Text);
                double num2 = Convert.ToDouble(Input2TextBox.Text);
                double product = num1 * num2;

                // display result to label (parsed)
                labelResult.Content = product.ToString();
            }
            catch (Exception ex)
            {
                labelResult.Content = "Error" + ex.Message;
            }
        }

        // logic for resut button click event
        // clear textboxes and resultlabel
        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {
            Input1TextBox.Clear();
            Input2TextBox.Clear();
            labelResult.Content = string.Empty;

            // sets focus back to first input textbox
            Input1TextBox.Focus();
        }

        // logic for exit button click event
        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            // close app
            // method in references
            Application.Current.Shutdown();
        }
    }
}