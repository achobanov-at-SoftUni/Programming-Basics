using System;

class EmployeeData
{
	static void Main()
	{
		string name = "Amanda", familyName = "Jonson";
		int age = 27;
		char gender = 'f';
		long id = 8306112507;
		int uen = 27563571;

		Console.WriteLine
		(
			"First name:" + " " + name + "\n" +
			"Last name:" + " "  + familyName + "\n" +
			"Age:" + " " + age + "\n" +
			"Gender" + " " + gender + "\n" + 
			"Personal ID:" + " " + id + "\n" + 
			"Unique Employee number:" + " " + uen
		);
	}	
}