using System;
using System.Collections.Generic;

namespace Singelton
{
	public class ThirdPartyBillingSystem
	{
		private ITarget employeeSource;
		public ThirdPartyBillingSystem(ITarget employeeSource){
			this.employeeSource = employeeSource;

		}

		public void showEmployeeList()
		{
			List<string> employee = employeeSource.GetEmployeeList ();
			Console.WriteLine ("-------##Employee List##------------");
			foreach (var item in employee) {
				Console.Write (item);
			}
		}


	}
}

