using System;

namespace Singelton
{
	public class Run
	{
		public static void Main (string[] args)
		{
			ITarget target = new EmployeeAdapter ();
			ThirdPartyBillingSystem client = new ThirdPartyBillingSystem (target);
			client.showEmployeeList ();
			Console.ReadKey ();
		}
	}
}

