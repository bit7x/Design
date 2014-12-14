using System;

namespace Singelton
{
	public class ConcreteCommand : ICommand
	{
		protected Reciver _reciver;
		public String Parameter{ get; set;}

		public ConcreteCommand (Reciver reciver)
		{
			_reciver = reciver;
		}

		public void Execute(){
			_reciver.Action(Parameter);
		}


	}
}

