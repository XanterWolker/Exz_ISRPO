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
using System.Text.RegularExpressions;

namespace Экзамен
{
    class Add_Employee
    {
        public bool Insert(string LastName, string FirstName, string MiddleName)
        {

            Database1Entities db = new Database1Entities();

            Table table = new Table();
            table.Last_Name = LastName;
            table.First_Name = FirstName;
            table.Middle_Name = MiddleName;

            db.Table.Add(table);
            db.SaveChanges();

            return true;
        }
    }
}
