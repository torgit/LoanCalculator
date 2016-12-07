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
using Model;
using Utility;

namespace LoanCalculation
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

        private void comboBox_loanType_Loaded(object sender, RoutedEventArgs e)
        {
            var loanList = new List<LoanType>(){
                new LoanType(LoanTypeDescription.Housing_loan, 3.5)
                , new LoanType(LoanTypeDescription.Car_loan, 8)
            };

            var combo = sender as ComboBox;
            combo.ItemsSource = loanList;
            combo.DisplayMemberPath = "Description";
            combo.SelectedIndex = 0;
        }

        private void comboBox_loanType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedComboItem = sender as ComboBox;
            var selectedLoanType = selectedComboItem.SelectedItem;
        }

        private void comboBox_paymentScheme_Loaded(object sender, RoutedEventArgs e)
        {
            var paybackSchemeList = ReflectiveEnumerator.GetChildOfType(typeof(PaybackScheme));
            var combo = sender as ComboBox;
            combo.ItemsSource = paybackSchemeList;
            combo.DisplayMemberPath = "Name";
            combo.SelectedValuePath = "AssemblyQualifiedName";
            combo.SelectedIndex = 0;
        }

        private void comboBox_paymentScheme_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedComboItem = sender as ComboBox;
            var selectedLoanType = selectedComboItem.SelectedItem;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            var amountText = textBox_amount.Text;
            var yearsText = textBox_time.Text;

            double amount;
            double years;

            bool isValidFormAmount = Double.TryParse(amountText, out amount);
            bool isValidFormYears = Double.TryParse(yearsText, out years);

            bool isValidAmount = isValidFormAmount && amount > 0;
            bool isValidYears = isValidFormYears && years > 0;

            if (isValidAmount && isValidYears)
            {
                var loanType = comboBox_loanType.SelectedItem as LoanType;
                var paymentScheme = comboBox_paymentScheme.SelectedValue.ToString();
                var paymentSchemeType = Type.GetType(paymentScheme);
                var paymentObject = Activator.CreateInstance(paymentSchemeType) as PaybackScheme;

                var result = paymentObject.generatePlan(loanType, amount, years);

                dataGrid_result.ItemsSource = result;
            }
            else
            {
                MessageBox.Show("Invalid input!\nAmount and Payback time should be number with value > 0");
            }

        }

        private void textBox_amount_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void textBox_time_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
