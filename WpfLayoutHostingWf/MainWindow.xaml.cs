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

namespace WpfLayoutHostingWf
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.InitializeFlowLayoutPanel();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button b = (System.Windows.Forms.Button)sender;
            b.Top = 20;
            b.Left = 20;
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            this.host1.Visibility = System.Windows.Visibility.Hidden;
        }
        private void button3_Click(object sender, RoutedEventArgs e)
        {
            this.host1.Visibility = System.Windows.Visibility.Collapsed;
        }


        private void InitializeFlowLayoutPanel()
        {
            System.Windows.Forms.FlowLayoutPanel flp = (System.Windows.Forms.FlowLayoutPanel)this.flowLayoutHost.Child;
            flp.WrapContents = true;
            const int numButtons = 6;
            int i;
            for (i = 0; i <= numButtons; i++)
            {
                System.Windows.Forms.Button b = new System.Windows.Forms.Button();
                b.Text = "Button";
                b.BackColor = System.Drawing.Color.AliceBlue;
                b.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                flp.Controls.Add(b);
            }
        }
        
    }
}
