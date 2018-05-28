using System;

namespace Employees
{
	// Engineers have degrees
    public enum DegreeName { BS, MS, PhD }

    [Serializable]
    public class Engineer : Employee
    {
        public DegreeName HighestDegree { get; set; } = DegreeName.BS;

        #region constructors 
		public Engineer() { }

		public Engineer(string firstname, string lastname, DateTime DOB,
					   float currPay, string ssn, DegreeName degree)
          : base(firstname, lastname, DOB, currPay, ssn)
        {
            // This property is defined by the Engineer class.
            HighestDegree = degree;
		}
		#endregion

		public override void DisplayStats()
		{
			base.DisplayStats();
			Console.WriteLine("Highest Degree: {0}", HighestDegree);
		}
    }
}
