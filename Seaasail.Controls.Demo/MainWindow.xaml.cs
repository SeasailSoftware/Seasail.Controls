using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace Seaasail.Controls.Demo
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            List<object> shortticks = new List<object>();

            for (int i = 0; i <= 20; i++)
            {
                shortticks.Add(new object());
            }

            ShoartTick.ItemsSource = shortticks;
        }

        private void Begin(object sender, RoutedEventArgs e)
        {
            Task.Run(() =>
           {
               this.Dispatcher.Invoke(new Action(() =>
               {
                   dashboard.Value = 0;
               }));
               var index = 0;
               while (index < 100)
               {
                   this.Dispatcher.Invoke(new Action(() =>
                   {
                       dashboard.Value++;
                   }));
                   Thread.Sleep(100);
                   index++;
               }

           });
        }
    }
}
