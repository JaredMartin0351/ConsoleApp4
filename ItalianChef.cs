using System;
namespace ConsoleApp4
{


	public class ItalianChef : Chef
	{
		public ItalianChef()
		{



		}

		public void MakePasta()
        {
			Console.WriteLine("The Italian Chef makes pasta");
        }

		public override void MakeSpecialDish()
        {
			Console.WriteLine("The Italian Chef makes Chicken Parm");
        }
	}
}
