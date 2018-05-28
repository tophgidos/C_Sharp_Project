using System;

namespace Employees
{
	// SupportPerson works a shift
    public enum ShiftName { One, Two, Three }

    [Serializable]
    public class SupportPerson : Employee
    {
        public ShiftName Shift { get; set; } = ShiftName.One;

		#region constructors 
		public SupportPerson() { }

		public SupportPerson(string firstname, string lastname, DateTime DOB, float currPay, string ssn, ShiftName shift)
          : base(firstname, lastname, DOB, currPay, ssn)
        {
            // This property is defined by the SupportPerson class.
            Shift = shift;
		}
		#endregion

		public override void DisplayStats()
		{
			base.DisplayStats();
			Console.WriteLine("Shift: {0}", Shift);
		}
    }
}
