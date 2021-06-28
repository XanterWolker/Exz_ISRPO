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

namespace Экзамен
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        public MainWindow()
        {
            InitializeComponent();
            T_Emp.ItemsSource = db.Table.ToList();
        }

        Database1Entities db = new Database1Entities();

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Add_Employee add_Employee = new Add_Employee();
            add_Employee.Insert(tb_LastName.Text, tb_FirstName.Text, tb_MiddleName.Text);
            T_Emp.ItemsSource = db.Table.ToList();
        }

        private void T_Emp_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
