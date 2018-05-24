using System;
using System.Windows;
using System.Windows.Controls;

namespace Employees
{
    /// <summary>
    /// Interaction logic for CompDetails.xaml
    /// </summary>
    public partial class CompDetails : Page
    {
        public CompDetails()
        {
            InitializeComponent();
        }

        public CompDetails(Object data) : this()
        {
            this.DataContext = data;

            if (data is Employee)
            {
                Employee emp = (Employee)data;
                string name = "";
                string value= "";

                // Set spare prop name and value
                emp.GetSpareProp1(ref name, ref value);
                this.SpareProp1Name.Content = name;
                this.SpareProp1Value.Content = value;

                // Make visible after setting values
                this.SpareProp1Name.Visibility = Visibility.Visible;
                this.SpareProp1Value.Visibility = Visibility.Visible;
            }
        }
    }
}
