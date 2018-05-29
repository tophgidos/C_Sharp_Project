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
                string name = "";
                string value = "";

                if (data is Manager)
                {
                    Manager man = (Manager)data;
                    
                    name = "Reports";
                    string options = "Stock Options";

                    // Set spare prop name and value
                    man.GetSpareProp1(ref name, ref value);
                    this.SpareProp1Name.Content = name;
                    this.SpareProp1Value.Content = man.ReportsByName();

                    this.SpareProp2Name.Content = options;
                    this.SpareProp2Value.Content = man.StockOptions;

                    // Make visible after setting values
                    this.SpareProp1Name.Visibility = Visibility.Visible;
                    this.SpareProp1Value.Visibility = Visibility.Visible;

                    this.SpareProp2Name.Visibility = Visibility.Visible;
                    this.SpareProp2Value.Visibility = Visibility.Visible;
                }
                if (data is Executive)
                {
                    Executive exe = (Executive)data;

                    name = "Reports";
                    string options = "Stock Options ";

                    // Set spare prop name and value
                    exe.GetSpareProp1(ref name, ref value);
                    this.SpareProp1Name.Content = name;
                    this.SpareProp1Value.Content = exe.ReportsByName();

                    this.SpareProp2Name.Content = options;
                    this.SpareProp2Value.Content = exe.StockOptions;

                    // Make visible after setting values
                    this.SpareProp1Name.Visibility = Visibility.Visible;
                    this.SpareProp1Value.Visibility = Visibility.Visible;

                    this.SpareProp2Name.Visibility = Visibility.Visible;
                    this.SpareProp2Value.Visibility = Visibility.Visible;
                }
                if (data is Engineer)
                {
                    Engineer eng = (Engineer)data;
                    name = "Highest Degree";

                    // Set spare prop name and value
                    eng.GetSpareProp1(ref name, ref value);
                    this.SpareProp1Name.Content = name;
                    this.SpareProp1Value.Content = eng.HighestDegree;

                    // Make visible after setting values
                    this.SpareProp1Name.Visibility = Visibility.Visible;
                    this.SpareProp1Value.Visibility = Visibility.Visible;
                }
                if (data is SalesPerson)
                {
                    SalesPerson sales = (SalesPerson)data;
                    name = "Number of Sales";

                    // Set spare prop name and value
                    sales.GetSpareProp1(ref name, ref value);
                    this.SpareProp1Name.Content = name;
                    this.SpareProp1Value.Content = sales.SalesNumber;

                    // Make visible after setting values
                    this.SpareProp1Name.Visibility = Visibility.Visible;
                    this.SpareProp1Value.Visibility = Visibility.Visible;
                }
                if (data is PTSalesPerson)
                {
                    PTSalesPerson pTSales = (PTSalesPerson)data;
                    name = "Number of Sales";

                    // Set spare prop name and value
                    pTSales.GetSpareProp1(ref name, ref value);
                    this.SpareProp1Name.Content = name;
                    this.SpareProp1Value.Content = pTSales.SalesNumber;

                    // Make visible after setting values
                    this.SpareProp1Name.Visibility = Visibility.Visible;
                    this.SpareProp1Value.Visibility = Visibility.Visible;
                }
                if (data is SupportPerson)
                {
                    SupportPerson support = (SupportPerson)data;
                    name = "Shift: ";

                    // Set spare prop name and value
                    support.GetSpareProp1(ref name, ref value);
                    this.SpareProp1Name.Content = name;
                    this.SpareProp1Value.Content = support.Shift;

                    // Make visible after setting values
                    this.SpareProp1Name.Visibility = Visibility.Visible;
                    this.SpareProp1Value.Visibility = Visibility.Visible;
                }
            }
        }
    }
}
