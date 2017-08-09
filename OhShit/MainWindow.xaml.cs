using System;
using System.Collections.Generic;
using System.Diagnostics;
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



namespace OhShit
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private HotKey _hotKey = null;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void OnHotKeyHandler(HotKey hotKey)
        {
            Process.Start(System.Configuration.ConfigurationManager.AppSettings.Get("cports_command_line"));
        }

        private void OhShit_Initialized(object sender, EventArgs e)
        {
            _hotKey = new HotKey(Key.Back, KeyModifier.Ctrl, OnHotKeyHandler);
        }
    }
}
