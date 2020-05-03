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
using WpfApp1.localhost;

namespace WpfApp1
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ExportData exportData = new ExportData();
            exportData.UseDefaultCredentials = true;
            exportData.Url = "http://laptop-g39sihai:7047/BC140/WS/CRONUS%20International%20Ltd./Codeunit/ExportData";
            NAVItems navitems = new NAVItems();
            exportData.ExportItems(ref navitems);
            
            gridview1.DataContext = navitems.NAVItem.ToList();
            List<NAVItem> navitemToList = navitems.NAVItem.ToList();
            foreach (var item in navitemToList)
            {
                bruhs.Text += item.Description;
            }
        }
    }
}
