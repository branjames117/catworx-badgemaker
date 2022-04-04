// string greeting = "Hello";
// greeting = greeting + "World";
// Console.WriteLine("greeting" + greeting);
// Console.WriteLine($"greeting {greeting}");
// Console.WriteLine("greeting: {0}", greeting);

// double side = 3.14;
// double area = side * side;
// Console.WriteLine("The area of a square with side length of {0} is {1}.", side, area);
// Console.WriteLine("Area is a {0}", area.GetType());

// Console.WriteLine(2 * 3);         // Basic Arithmetic: +, -, /, *
// Console.WriteLine(10 % 3);        // Modulus Op => remainder of 10/3
// Console.WriteLine(1 + 2 * 3);     // order of operations
// Console.WriteLine(10 / 3.0);      // int's and doubles
// Console.WriteLine(10 / 3);        // int's 
// Console.WriteLine("12" + "3");    // What happens here?

// int num = 10;
// num += 100;
// Console.WriteLine(num);
// num ++;
// Console.WriteLine(num);

// bool isCold = true;
// Console.WriteLine(isCold ? "drink" : "add ice");  // output: drink
// Console.WriteLine(!isCold ? "drink" : "add ice");  // output: add ice

// string stringNum = "2";
// int intNum = Convert.ToInt16(stringNum);
// Console.WriteLine(intNum);
// Console.WriteLine(intNum.GetType()); // output is System.Int32 for some reason, why isn't it System.Int16? Research later.

// Dictionary<string, int> myScoreBoard = new Dictionary<string, int>();

// myScoreBoard.Add("firstInning", 10);
// myScoreBoard.Add("secondInning", 20);
// myScoreBoard.Add("thirdInning", 30);
// myScoreBoard.Add("fourthInning", 40);
// myScoreBoard.Add("fifthInning", 50);

// Dictionary<string, int> myScoreBoard = new Dictionary<string, int>(){
//     { "firstInning", 10 },
//     { "secondInning", 20},
//     { "thirdInning", 30},
//     { "fourthInning", 40},
//     { "fifthInning", 50}
// };

// Console.WriteLine("----------------");
// Console.WriteLine("  Scoreboard");
// Console.WriteLine("----------------");
// Console.WriteLine("Inning |  Score");
// Console.WriteLine("   1   |    {0}", myScoreBoard["firstInning"]);
// Console.WriteLine("   2   |    {0}", myScoreBoard["secondInning"]);
// Console.WriteLine("   3   |    {0}", myScoreBoard["thirdInning"]);
// Console.WriteLine("   4   |    {0}", myScoreBoard["fourthInning"]);
// Console.WriteLine("   5   |    {0}", myScoreBoard["fifthInning"]);

// string[] favFoods = new string[3]{ "pizza", "doughnuts", "icecream" };
// string firstFood = favFoods[0];
// string secondFood = favFoods[1];
// string thirdFood = favFoods[2];
// Console.WriteLine("I like {0}, {1}, and {2}", firstFood, secondFood, thirdFood);

List<string> employees = new List<string>() { "adam", "amy" };

employees.Add("barbara");
employees.Add("billy");

for (int i = 0 ; i < employees.Count ; i++)
{
  Console.WriteLine(employees[i]);
}