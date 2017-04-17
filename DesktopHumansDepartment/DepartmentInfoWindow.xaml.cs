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
using Controllers;

namespace DesktopHumansDepartment
{
    /// <summary>
    /// Логика взаимодействия для DepartmentInfoWindow.xaml
    /// </summary>
    public partial class DepartmentInfoWindow : Window
    {
        public DepartmentInfoWindow()
        {
            InitializeComponent();            
        }

        private void departmentsGrid_Loaded(object sender, RoutedEventArgs e)
        {
            DataGridUpdate();
        }

        private void delete_Click(object sender, RoutedEventArgs e)
        {
            DepartmentController element = departmentsGrid.SelectedItem as DepartmentController;

            if(element != null)
                DepartmentController.DeleteDepartments(element.DepartmentID);

            DataGridUpdate();
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            new AddDepartmentWindow().ShowDialog();
            DataGridUpdate();
        }

        private void change_Click(object sender, RoutedEventArgs e)
        {
            DepartmentController element = departmentsGrid.SelectedItem as DepartmentController;

            if (element != null)
                new ChangeDepartmentWindow(element.DepartmentID).ShowDialog();

            DataGridUpdate();
        }

        private void DataGridUpdate()
        {
            var departments = DepartmentController.GetDepartments();

            if (departments.Count > 0)
            {
                departmentsGrid.ItemsSource = departments;
                messageLabel.Visibility = Visibility.Hidden;
                departmentsGrid.Visibility = Visibility.Visible;
            }
            else
            {
                departmentsGrid.Visibility = Visibility.Hidden;
                messageLabel.Visibility = Visibility.Visible;
            }
        }
    }
}
