static List<Employee> GetEmployees()
{
  List<Employee> employees = new List<Employee>();
  while (true)
  {
    Console.WriteLine("Please enter a first name: ");
    string? firstName = Console.ReadLine();

    // validation before updating the employees List
    if (firstName == null || firstName == "")
    {
      break;
    }

    Console.WriteLine("Please enter a last name: ");
    string? lastName = Console.ReadLine();

    Console.WriteLine("Please enter an ID: ");
    int id = Int32.Parse(Console.ReadLine());

    Console.WriteLine("Please enter a photo URL: ");
    string? photoUrl = Console.ReadLine();

    if (lastName == null || photoUrl == null) {
      break;
    }

    Employee currentEmployee = new Employee(firstName, lastName, id, photoUrl);

    employees.Add(currentEmployee);
  }

  return employees;
}

List<Employee> employees = GetEmployees();
Util.MakeCSV(employees);
Util.PrintEmployees(employees);
Util.MakeBadges(employees);