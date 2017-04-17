using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Логика взаимодействия для AddDepartmentWindow.xaml
    /// </summary>
    public partial class AddDepartmentWindow : Window
    {
        private bool flag = false;

        public AddDepartmentWindow()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            if(flag == false)
            {
                validMessage.Visibility = Visibility.Visible;
            }
            else
            {
                DepartmentController.AddDepartment(departmentName.Text);
                Close();
            }
        }

        private void cancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void departmentName_TextChanged(object sender, TextChangedEventArgs e)
        {
            Regex patternEn = new Regex(@"[A-Z]{1}[a-z]*");
            Regex patternRu = new Regex(@"[А-Я]{1}[а-я]*");

            if (!patternEn.IsMatch(departmentName.Text) && !patternRu.IsMatch(departmentName.Text))
            {
                departmentName.Background = Brushes.Tomato;
                flag = false;
            }
            else
            {
                departmentName.Background = Brushes.White;
                flag = true;
            }
        }
    }
}
