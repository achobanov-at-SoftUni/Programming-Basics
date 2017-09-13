using System;

class PrintCompanyInformation
{
	static void Main()
	{
		Console.WriteLine("Company name: ");
		string companyName = Console.ReadLine();
		Console.WriteLine("Company address: ");
		string companyAddress = Console.ReadLine();
		Console.WriteLine("Phone number: ");
		string phoneNumber = Console.ReadLine();
		Console.WriteLine("Fax number: ");
		string faxNumber = Console.ReadLine();
		Console.WriteLine("Web site: ");
		string webSite = Console.ReadLine();
		Console.WriteLine("Manager first name: ");
		string manageName = Console.ReadLine();
		Console.WriteLine("Manager last name");
		string managerLastName = Console.ReadLine();
		Console.WriteLine("Manager age: ");
		string managerAge = Console.ReadLine();
		Console.WriteLine("Manager phone: ");
		string managerPhoneNumber = Console.ReadLine();

		Console.WriteLine
		(
			@"
			{0}
			Address: {1}
			Tel: {2}
			Fax: {3}
			Web site: {4}
			Manager: {5} {6}(age: {7}, tel: {8})",
			companyName, companyAddress, phoneNumber, faxNumber, 
			webSite, manageName, managerLastName, managerAge, managerPhoneNumber
		);

	}
}