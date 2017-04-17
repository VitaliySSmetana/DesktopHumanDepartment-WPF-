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
    /// Логика взаимодействия для ChangeDepartmentWindow.xaml
    /// </summary>
    public partial class ChangeDepartmentWindow : Window
    {
        private bool flag = false;
        private int selectedDepartment;

        public ChangeDepartmentWindow(int id)
        {
            InitializeComponent();

            selectedDepartment = id;
        }

        private void newDepartmentName_TextChanged(object sender, TextChangedEventArgs e)
        {
            Regex patternEn = new Regex(@"[A-Z]{1}[a-z]*");
            Regex patternRu = new Regex(@"[А-Я]{1}[а-я]*");

            if (!patternEn.IsMatch(newDepartmentName.Text) && !patternRu.IsMatch(newDepartmentName.Text))
            {
                newDepartmentName.Background = Brushes.Tomato;
                flag = false;
            }
            else
            {
                newDepartmentName.Background = Brushes.White;
                flag = true;
            }
        }

        private void apply_Click(object sender, RoutedEventArgs e)
        {
            if (flag == false)
            {
                validMessage.Visibility = Visibility.Visible;
            }
            else
            {
                DepartmentController.ChangeDepartment(selectedDepartment, newDepartmentName.Text);
                Close();
            }
        }

        private void cancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
