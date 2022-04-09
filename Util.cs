using System.Drawing;

class Util
{
  // method declared as static, meaning it belongs to the class itself instead of individual instances or objects (meaning we don't have to create a new Util object to use it)
  public static void PrintEmployees(List<Employee> employees)
  {
    for (int i = 0; i < employees.Count; i++)
    {
      string template = "{0,-10}\t{1,-20}\t{2}";
      Console.WriteLine(String.Format(template, employees[i].GetId(), employees[i].GetName(), employees[i].GetPhotoUrl()));
    }
  }

  public static void MakeCSV(List<Employee> employees)
  {
    // create a data folder if it does not yet exist
    if (!Directory.Exists("data"))
    {
      Directory.CreateDirectory("data");
    }

    // using in this manner means we only want to temporarily use this resource (StreamWriter) before getting rid off it after the code in the curly brackets finishes
    using (StreamWriter file = new StreamWriter("data/employees.csv"))
    {
      file.WriteLine("ID,Name,PhotoUrl");
    }
  }

  public static void MakeBadges(List<Employee> employees) {
    // create image
    Image newImage = Image.FromFile("badge.png");
    newImage.Save("data/employeeBadge.png");
  }
}