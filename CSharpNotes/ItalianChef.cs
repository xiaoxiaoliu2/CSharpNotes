using System;
namespace CSharpNotes
{
    // italian chef can do anything the normal chef can do
    class ItalianChef : Chef    // subclass, inherit from superclass
	{
        // overridden method
        public override void MakeSpecialDish()
        {
            Console.WriteLine("The Chef makes chicken parm");
        }

        // the specific method italian chef has
        public void MakePasta()
		{
			Console.WriteLine("The Chef makes pasta");
        }
	}
}

