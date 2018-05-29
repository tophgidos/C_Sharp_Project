using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    [Serializable]
    sealed class PTSalesPerson : SalesPerson
    {
        public PTSalesPerson(string firstname, string lastname, DateTime DOB, float currPay, string ssn, int numbOfSales)
          : base(firstname, lastname, DOB, currPay, ssn, numbOfSales)
        {
        }
        // Assume other members here...
    }
}
