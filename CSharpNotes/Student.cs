using System;
namespace CSharpNotes
{
	class Student
	{
		public string name;
		public string major;
		public double gpa;

		// create a method, so we can parse argument in the class and return the attributes
		public Student(string aName, string aMajor, double aGpa)
		{
			name = aName;
			major = aMajor;
			gpa = aGpa;
		}

		// create a method, create a bool value
		public bool HasHonors()
		{
			if (gpa >= 3.5)
			{
				return true;
			}
			return false;
		}



	}
}

