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

namespace Assignment6Group4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double presentAmount;
        double futureAmount;
        double duration;
        double roi;
        public MainWindow()
        {
            InitializeComponent();           
        }
        public double CalcPresentValue(double futureAmt,double time, double rateOfInterest)
        {
                double numerator = futureAmt;
                double denomiator = Math.Pow((1 + rateOfInterest), time);
                presentAmount = numerator / denomiator;
                return presentAmount;               
        }

        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            if (Double.TryParse(txtFutureAmt.Text, out futureAmount) &&
                Double.TryParse(txtTime.Text, out duration) &&
                Double.TryParse(txtROI.Text, out roi))
            {
                lblPresentAmt.Content = CalcPresentValue(futureAmount, duration, roi);
            }
                
        }
    }
}
