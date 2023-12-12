using System;
namespace HRAdministrationAPI
{
	
	public interface IEmployee
	{
		// property definitions to the IEmployee interface
		int Id { get; set; }
		string FirstName { get; set; }
		string LastName { get; set; }
		decimal Salary { get; set; }
    }
}

