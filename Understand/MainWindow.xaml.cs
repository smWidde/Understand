using System;
using System.Collections.Generic;
using System.IO;
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

namespace Understand
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        const string path = @"C:\Users";
        public MainWindow()
        {
            InitializeComponent();
            string[] normies = new string[Directory.GetDirectories(path).Length];
            for(int i=0; i<normies.Length; i++)
            {
                normies[i] = Directory.GetDirectories(path)[i].Split('\\')[2];
            }
            Users.ItemsSource = normies;
        }
    }
}
