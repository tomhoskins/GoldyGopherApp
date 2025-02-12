using System.Collections.ObjectModel;
using System.ComponentModel;
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

namespace GoldyGopherUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private BindingList<string> gopherListBinding = new BindingList<string>();

        public MainWindow()
        {
            InitializeComponent();

            gopherListBox.ItemsSource = gopherListBinding;
        }

        // Raised when Button gains focus.
        // Changes opacity of button to indicate focus.
        private void OnGotFocusHandler(object sender, RoutedEventArgs e)
        {
            Button? tb = e.Source as Button;
            if (tb != null)
            {
                tb.Opacity = 0.8; 
            }
        }
        // Raised when Button loses focus.
        // Changes opacity of button back to normal.
        private void OnLostFocusHandler(object sender, RoutedEventArgs e)
        {
            Button? tb = e.Source as Button;
            if (tb != null)
            {
                tb.Opacity = 1;
            }
        }

        private void runButton_Click(object sender, RoutedEventArgs e)
        {
            bool isLowerBoundValid = int.TryParse(lowerBoundText.Text, out int lowerBound);
            bool isUpperBoundValid = int.TryParse(upperBoundText.Text, out int upperBound);
            gopherListBinding.Clear();
            gopherListBinding.Add("Working...");
            if (!isLowerBoundValid || !isUpperBoundValid)
            {
                gopherListBinding.Clear();
                gopherListBinding.Add($"Please enter valid integers between {int.MinValue} and {int.MaxValue} for the lower and upper bounds.");
            }
            else if (!GoldyGopherLibrary.Utilities.ValidateBounds(lowerBound, upperBound))
            {
                gopherListBinding.Clear();
                gopherListBinding.Add("The lower bound must be less than the upper bound.");
            }
            // Double conversions to prevent overflow in range check
            else if (Math.Abs((double)upperBound - (double)lowerBound) > 10000)
            {
                gopherListBinding.Clear();
                gopherListBinding.Add("The difference between the lower and upper bounds must be less than 10000. To run larger datasets, the ConsoleUI can be used to generate a CSV file.");
            }
            else
            {
                gopherListBinding.Clear();
                for (int i = lowerBound; i <= upperBound; i++)
                {
                    gopherListBinding.Add(GoldyGopherLibrary.Utilities.GetGopherStringFromInt(i));
                }
            }
        }
    }
}