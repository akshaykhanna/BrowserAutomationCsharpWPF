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



using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace FirefoxAutomation
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

        private void bt_open_browser_Click(object sender, RoutedEventArgs e)
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "https://www.google.co.in";
        }
    }
}
