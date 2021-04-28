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

namespace WpfApp1 {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e){
            int count;
            double invoice;

            if (TextBoxR.Text == "" || TextBoxCount.Text == "") {
                MessageBox.Show("Данi були введенi не коректно. Повторіть введення");
            }
            else {
                count = Convert.ToInt32(TextBoxCount.Text);
                invoice = Convert.ToDouble(TextBoxR.Text);
                double result = invoice / count;
                PTextBlockUAH.Text = UAH.UAH_Result(invoice);
                PTextBlockEUR.Text = EUR.EURpov(invoice);
                PTextBlockUSD.Text = USD.USDpov(invoice);
                PTextBlockRUB.Text = RUB.RUBpov(invoice);
                RTextBlockUAH.Text = UAH.UAH_NewResult(result);
                RTextBlockEUR.Text = EUR.EURroz(result);
                RTextBlockUSD.Text = USD.USDroz(result);
                RTextBlockRUB.Text = RUB.RUBroz(invoice);
            }
        }
        private void TextBoxR_PreviewTextInput(object sender, TextCompositionEventArgs e) {
            int val;
            if (!Int32.TryParse(e.Text, out val)) {
                e.Handled = true; 
            }
        }
        private void TextBoxR_PreviewKeyDown(object sender, KeyEventArgs e) {
            if (e.Key == Key.Space) {
                e.Handled = true;
            }
        }
        private void TextBoxCount_PreviewKeyDown(object sender, KeyEventArgs e) {
            if (e.Key == Key.Space) {
                e.Handled = true;
            }
        }
        private void TextBoxCount_PreviewTextInput(object sender, TextCompositionEventArgs e) {
            int val;
            if (!Int32.TryParse(e.Text, out val)) {
                e.Handled = true;
            }
        }
    }
}
