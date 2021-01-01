using System.Windows;

namespace WPFSOAPClient {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e) {
            SoapReference.Service1Client oClient = new SoapReference.Service1Client();
            string res = oClient.GetData(2);
            MessageBox.Show(res);
        }
    }
}