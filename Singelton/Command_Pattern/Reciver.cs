using System;

namespace Singelton
{
	public class Reciver
	{
		public Reciver ()
		{
		}

		public void Action(string message){
			Console.WriteLine ("Action Called With Message : {0}",message);
	}


}
}
