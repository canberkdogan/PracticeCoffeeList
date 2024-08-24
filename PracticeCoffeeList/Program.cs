

List<string> coffeeList = new List<string>();
Console.WriteLine("Please enter 5 coffe names--->");

for (int i = 0; i < 5 ; i++)
{
    Console.WriteLine($"Coffe {i + 1}");
    string coffeeName = Console.ReadLine();  
    coffeeList.Add( coffeeName );
}

Console.WriteLine("----------HERE IS YOUR COFFEE--------");

foreach (string coffee in coffeeList)
{

    Console.WriteLine(coffee);
}   



