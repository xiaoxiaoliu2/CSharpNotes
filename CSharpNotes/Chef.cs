using System;
namespace CSharpNotes
{
	class Chef
	{
		public void MakeChicken()
		{
			Console.WriteLine("The Chef makes chicken");
		}

        public void MakeSalad()
        {
            Console.WriteLine("The Chef makes salad");
        }

        // virtual: means this method can be overridden in any subclasses 
        public virtual void MakeSpecialDish()
        {
            Console.WriteLine("The Chef makes bbq ribs");
        }
    }
}

