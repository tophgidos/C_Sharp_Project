// CSD 228 - Assignment 8
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace Employees
{
    

    public partial class CompHome : Page
    {
        static List<Employee> empList = Program.LoadEmployees();

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
