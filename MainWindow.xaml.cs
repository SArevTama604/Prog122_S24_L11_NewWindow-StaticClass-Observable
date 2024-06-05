using System.Collections.ObjectModel;
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

namespace Prog122_S24_L11_NewWindow_StaticClass_Observable
    // <summary>
    // Interaction logic for MainWindow.xaml
    // </summary>

{
    public partial class MainWindow : Window
    {
        private object lbShowNames;
        private object lblBusinessName;

        public MainWindow()
        {
            InitializeComponent();


            Account transferFrom = new Account();
            Account transferTo = new Account();
            Account.TransferMoney(transferFrom, transferTo, 500);

            lbShowNames.ItemsSource = Data.names;




            // Attach the field from our static, Data.cs, class
            lblBusinessName.Content = Data.Business;
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }

        private void btnOpenNewWindow_Click(object sender, RoutedEventArgs e)
        {
    
            MyNewWindow myNew = new MyNewWindow();

            myNew.Show();
        }

        private void btnAddName_Click(object sender, RoutedEventArgs e)
        {
            string name = txtName.Text;
            Data.names.Add(name);
        }
    }
}