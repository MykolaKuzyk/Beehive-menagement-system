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
using System.Windows.Threading;

namespace Beehive_menagement_system
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DispatcherTimer timer = new DispatcherTimer();
        private readonly Queen queen;
        public MainWindow()
        {
            InitializeComponent();
            //Commented due to change XAML textBox prop.//statusReport.Text = queen.StatusReport;
            queen = Resources["queen"] as Queen;

        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            work_button_Click_1(this, new RoutedEventArgs());
            ProgreesBar.Value += 1.5;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void worker_type_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }




        private void assign_job_button_Click_1(object sender, RoutedEventArgs e)
        {
            queen.AssignBee(jobSelector.Text);
            //Commented due to change XAML textBox prop.//statusReport.Text = queen.StatusReport;
        }

        private void work_button_Click_1(object sender, RoutedEventArgs e)
        {
            queen.WorkTheNextShift();
            //Commented due to change XAML textBox prop.//statusReport.Text = queen.StatusReport; 
        }


        private void ProgreesBar_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
 
        
            
        }

        private void ProgreesBar_Initialized(object sender, EventArgs e)
        {
            
            timer.Tick += Timer_Tick;
            timer.Interval = TimeSpan.FromSeconds(1.5);
            timer.Start();

         
        }
    }
}
