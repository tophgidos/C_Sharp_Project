using System;

namespace Employees
{
    // Executives have titles
    public enum ExecTitle { CEO, CTO, CFO, VP }

    [Serializable]
    public class Executive : Manager
    {
		#region constructors 
		// Executives start with Gold benefits and 10,000 stock options
		public Executive() : base()
        {
            empBenefits = new GoldBenefitPackage();
            StockOptions = 10000;
        }

		public Executive(string firstname, string lastname, DateTime DOB, float currPay, string ssn, int numbOfOpts = 10000, ExecTitle title = ExecTitle.VP)
          : base(firstname, lastname, DOB, currPay, ssn, numbOfOpts)
        {
			// Title defined by the Executive class.
			Title = title;
            empBenefits = new GoldBenefitPackage();
		}
        #endregion

        public ExecTitle Title { get; set; } = ExecTitle.VP;

		public override void DisplayStats()
		{
			base.DisplayStats();
			Console.WriteLine("Executive Title: {0}", Title);
		}

        // Executives get an extra 1000 bonus and 10,000 stock options on promotion
        // Move GivePromotion
        public override void GivePromotion()
        {
            base.GivePromotion();
            GiveBonus(1000);
            StockOptions += 10000;
        }

		// Methods for adding reports
		public override void AddReport(Employee newReport)
        {
            // Check for proper report to Executive
            if (newReport is Manager || newReport is SalesPerson)
            {
                base.AddReport(newReport);
            }
            else
            {
                // Raise exception for report that is not a Manager or Salesperson
                Exception ex = new AddReportException("Executive report not a Manager or Salesperson");

                // Add Manager custom data dictionary
                ex.Data.Add("Manager", this.Name);

                // Add report that failed to be added, and throw exception
                ex.Data.Add("New Report", newReport.Name);
                throw ex;
            }            
        }
	}
}