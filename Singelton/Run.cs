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
			Console.ReadLine ();

			ProxyClient proxy = new ProxyClient();
			Console.WriteLine("Data from Proxy Client = {0}", proxy.GetData());

			Console.ReadKey();
		}
	}
}

