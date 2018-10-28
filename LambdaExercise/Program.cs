using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExercise
{
	public class Employee
	{
		public string fName { get; set; }
		public string lName { get; set; }
		public int iD { get; set; }
	}

	class Program
	{


		public static void Main(string[] args)
		{
			List<Employee> employees = new List<Employee>()
			{
				new Employee{fName = "Becky", lName = "Smith", iD = 01},
				new Employee{fName = "Robert", lName = "White", iD = 02},
				new Employee{fName = "Joe", lName = "Black", iD = 03},
				new Employee{fName = "Jessica", lName = "Moyer", iD = 04},
				new Employee{fName = "Joe", lName = "Miller", iD = 05},
				new Employee{fName = "Luke", lName = "MacDonald", iD = 06},
				new Employee{fName = "Jordan", lName = "Kindway", iD = 07},
				new Employee{fName = "Shannon", lName = "Greaver", iD = 08},
				new Employee{fName = "Jennifer", lName = "Jackson", iD = 09},
				new Employee{fName = "Joe", lName = "Morhey", iD = 10}
			};

			////foreach statement

			//List<Employee> joe = new List<Employee>();
			//foreach (Employee name in employees)
			//{
			//	if (name.fName == "Joe")
			//	{
			//		joe.Add(name);
			//		Console.WriteLine(name.fName + " " + name.lName);
			//	}

			//	Console.ReadLine();

			//}

			//// Lambda Expressions

			List<Employee> joeName = employees.Where(x => x.fName == "Joe").ToList();
			foreach (Employee name in joeName)
			{
				Console.WriteLine(name.fName + " " + name.lName);
			}


			List<Employee> id5 = employees.Where(x => x.iD > 005).ToList();
			foreach (Employee name in id5)
			{
				Console.WriteLine(name.fName + " " + name.lName + " Greater than Five ID.");
			}
			Console.ReadLine();



		}
	}
}
