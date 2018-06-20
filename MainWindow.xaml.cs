//U6Euler7
//Shane Macdonald
//program calculated the first term in the fib sequnce with 1000 digits
//June 19, 2018
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

namespace Euler7
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double term;
        public MainWindow()
        {
            InitializeComponent();
            //binet theorm rearanged with the log of 10^999 already simplified
    
            term = Math.Round((Math.Log(10) * 999 + (Math.Log(5)/2)) / (Math.Log((1 + Math.Sqrt(5)) / 2)));
            MessageBox.Show(term.ToString());
        }
    }
}
