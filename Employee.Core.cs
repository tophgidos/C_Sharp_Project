using System;

namespace Employees
{
    public partial class Employee
    {
        private static int empCount = 0;
        // Field data.
        private string empFirstName;
        private string empLastName;
        private int empID;
        private float currPay;
        private DateTime empDOB;
        private string empSSN;

        #region Constructors
        public Employee() { }

        public Employee(string firstname, string lastname, DateTime DOB, float pay, string ssn)
        {
            empFirstName = firstname;
            empLastName = lastname;
            empDOB = DOB;
            empID = empCount++;
            currPay = pay;
            empSSN = ssn;
        }
        #endregion

        #region Properties 
        public string Name { get { return empFirstName + " " + empLastName; } }
        public string FirstName { get { return empFirstName; } }
        public string LastName { get { return empLastName; } }
        public int Id { get { return empID; } }
        public float Pay { get { return currPay; } }
        public int Age { get
        {
            int age = DateTime.Now.Year - empDOB.Year;
            if (empDOB.DayOfYear < DateTime.Now.DayOfYear)
                --age;
            return age;
        }}

        public string SocialSecurityNumber { get { return empSSN; } }
        public DateTime DOB { get { return empDOB; } }

        public virtual string Role { get { return this.GetType().ToString().Substring(10); } }
        #endregion
    }
}