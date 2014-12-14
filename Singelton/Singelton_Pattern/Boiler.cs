	using System;

	namespace Singelton
	{
		public class Boiler
		{
			private static Boiler instance = new Boiler();

			private Boiler ()
			{
			}

		public static Boiler getInstance(){
			return instance;
		}

		public void Calc(){

			Console.WriteLine ("Hi");

	}
	}
}
