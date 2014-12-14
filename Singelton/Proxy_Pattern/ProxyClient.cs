using System;

namespace Singelton
{
	public class ProxyClient : IClient
	{
		RealClient client = new RealClient();
		public ProxyClient(){
			Console.WriteLine("Proxy Client : Initialized");
		}

		public String GetData(){
			return client.GetData();
		}


	}
}

