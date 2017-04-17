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
using System.Windows.Shapes;

namespace DesktopHumansDepartment
{
    /// <summary>
    /// Логика взаимодействия для DepartmentsWindow.xaml
    /// </summary>
    public partial class DepartmentsWindow : Window
    {
        public DepartmentsWindow()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            new AddDepartmentWindow().ShowDialog();
        }


        private void info_Click(object sender, RoutedEventArgs e)
        {
            new DepartmentInfoWindow().ShowDialog();
        }

        private void sort_Click(object sender, RoutedEventArgs e)
        {

        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            Owner.Visibility = Visibility.Visible;
            Close();
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
