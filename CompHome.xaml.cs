// CSD 228 - Assignment 8
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace Employees
{
    public class Employee
    {
        static int NextId = 1;
        public int Id { get; }
        public string FirstName { get; }
        public string LastName { get; }
        public string Name { get { return FirstName + " " + LastName; } }
        public virtual string Role { get { return GetType().ToString().Substring(10); } }

        public Employee() { }
        public Employee(string firstName, string lastName)
        {
            Id = Employee.NextId++;
            FirstName = firstName;
            LastName = lastName;
        }

        public virtual void GetSpareProp1(ref string name, ref string value) { }
    }

    public class Executive : Employee
    {
        public string Title { get; } = "VP";
        public int StockOptions { get; } = 100;

        public Executive() { }
        public Executive(string firstName, string lastName, string title, int stockOptions)
            : base(firstName, lastName)
        {
            Title = title;
            StockOptions = stockOptions;
        }

        public override string Role { get { return base.Role + ", " + Title; } }
        public override void GetSpareProp1(ref string name, ref string value)
        {
            name = "Stock Options:";
            value = string.Format("{0:N0}", StockOptions);
        }
    }

    public class EmployeeList : List<Employee>
    {
        public EmployeeList()
        {
            Add(new Executive("Jane", "Doe", "CEO", 10000));
            Add(new Employee("Bob", "Smith"));
            Add(new Employee("Mike", "Miller"));
        }
    }

    public partial class CompHome : Page
    {
        static EmployeeList empList = new EmployeeList();

        public CompHome()
        {
            InitializeComponent();

            // Select the All radio button
            this.EmployeeTypeRadioButtons.SelectedIndex = 0;

            // Set event handler for radio button changes
            this.EmployeeTypeRadioButtons.SelectionChanged += new SelectionChangedEventHandler(EmployeeTypeRadioButtons_SelectionChanged);

            // Fill the Employees data grid
            dgEmps.ItemsSource = empList;
        }

        private void Details_Click(object sender, RoutedEventArgs e)
        {
            // Show Employee details if one selected
            if (dgEmps.SelectedIndex >= 0)
            {
                this.NavigationService.Navigate(new CompDetails(this.dgEmps.SelectedItem));
            }
        }

        private void Details_DoubleClick(object sender, RoutedEventArgs e)
        {
            // Show Employee details if one selected
            this.NavigationService.Navigate(new CompDetails(this.dgEmps.SelectedItem));
        }

        // Handle changes to Employee type radio buttons
        void EmployeeTypeRadioButtons_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Only choices are All (0) or Executives (1)
            if (this.EmployeeTypeRadioButtons.SelectedIndex == 1)
              dgEmps.ItemsSource = (List<Employee>)empList.FindAll(obj => obj is Executive); 
            else dgEmps.ItemsSource = empList;
        }
    }
}
