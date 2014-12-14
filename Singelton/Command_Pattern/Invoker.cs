using System;

namespace Singelton
{
	public class Invoker
	{
		public ICommand Command { get; set;}
		public Invoker ()
		{
		}

		public void ExecuteCommand(){
			Command.Execute ();
	}
}
}
