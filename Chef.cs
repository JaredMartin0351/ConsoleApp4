using System;

namespace ConsoleApp4
{


	public class Chef
	{
		public Chef()
        {

        
			
		}
		public void MakeChicken()
		{
			Console.WriteLine("The Chef makes chicken");
		}

		public void MakeSalad()
		{
			Console.WriteLine("The Chef makes salad");
		}

		public void MakeSteak()
		{
			Console.WriteLine("The Chef grills steak");
		}

		public virtual void MakeSpecialDish()
        {
			Console.WriteLine("The Chef makes BBQ  ribs");
        }
	}
}