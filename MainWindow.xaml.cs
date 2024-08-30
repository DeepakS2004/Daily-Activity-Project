using System.ComponentModel.DataAnnotations;
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

namespace Project_5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Activity> list;
        Data odata;
        public MainWindow()
        {
            InitializeComponent();
           
        }

        private void btnadd_Click(object sender, RoutedEventArgs e)
        {
            if (list == null)
            {
                list = new List<Activity>();
            }
            if (txtamt.Text != "" || txtitem.Text != "")
            {
                list.Add(new Activity { Date = dtpc.Text, Item = txtitem.Text, Amount = Convert.ToInt32(txtamt.Text) });
                txtamt.Clear();
                txtitem.Clear();
            }
           
            odata = new Data(list);
             mainframe.Content = odata;
        }
    }

    public class Activity()
    {
        public Object Date { get; set; }
        public string Item { get; set; }
        public int Amount { get; set; }

    }
}