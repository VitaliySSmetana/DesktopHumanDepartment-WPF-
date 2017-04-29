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
    /// Логика взаимодействия для MainMenuWindow.xaml
    /// </summary>
    public partial class MainMenuWindow : Window
    {
        public MainMenuWindow()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void search_Click(object sender, RoutedEventArgs e)
        {
            SearchWindow search = new SearchWindow();

            search.Owner = this;
            search.Show();

            Hide();
        }

        private void projects_Click(object sender, RoutedEventArgs e)
        {
            new ProjectsWindow().Show();
            Hide();
        }

        private void employees_Click(object sender, RoutedEventArgs e)
        {
            EmployeesWindow employeesWindow = new EmployeesWindow();

            employeesWindow.Owner = this;
            employeesWindow.Show();

            Hide();
        }

        private void positions_Click(object sender, RoutedEventArgs e)
        {
            new PositionsWindow().Show();
            Hide();
        }

        private void departments_Click(object sender, RoutedEventArgs e)
        {
            DepartmentsWindow departmentsWindow = new DepartmentsWindow();

            departmentsWindow.Owner = this;
            departmentsWindow.Show();

            Hide();
        }
    }
}
