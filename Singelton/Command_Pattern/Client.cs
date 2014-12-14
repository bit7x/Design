using System;

namespace Singelton
{
	public class Client
	{
		public Client ()
		{
		
		}

		public void RunCommand(){

			Invoker invoker = new Invoker ();
			Reciver reciver = new Reciver ();
			ConcreteCommand command = new ConcreteCommand (reciver);
			command.Parameter = "Hi Command Pattern";
			invoker.Command = command;
			invoker.ExecuteCommand ();
	}
}
}
