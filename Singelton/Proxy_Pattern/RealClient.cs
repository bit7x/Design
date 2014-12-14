using System;

namespace Singelton
{
	public class RealClient : IClient
	{
		string data;
		public RealClient ()
		{
			Console.WriteLine
			("Real Client : Initialized");
			data = "Real Client Data Installed";
		}


		public string GetData() {
			return data; 
		}
	}
}

