ShoppingList list = new ShoppingList("items.txt"); //
list.Load();

while (true)
{
    // A menu gets printed out which displays the options to the user. While the bool is true.
    Console.WriteLine();
    list.Print();
    Console.WriteLine();
    Console.WriteLine("1. Lägg till vara");
    Console.WriteLine("2. Ta bort vara");
    Console.WriteLine("3. Spara");
    Console.WriteLine("4. Sök vara");
    Console.WriteLine("5. Avsluta");
    Console.Write("Välj: ");

    int choice;

    while(!int.TryParse(Console.ReadLine(), out choice) ||choice<1||choice>5)
    {
        Console.Write("Välj ett val från menyn eller ange ett heltal!\nVälj:");
    }

    if (choice == 1) // If the choice is 1, The person gets to add
    {
        Console.Write("Namn: ");
        string name = Console.ReadLine();
        Console.Write("Pris: ");
        int price;
        while(!int.TryParse(Console.ReadLine(), out price)|| price < 0)
        {
            Console.WriteLine("Ange ett heltal");
        }
        list.Add(new Item(name, price));
    }
    else if (choice == 2) 
    {
        Console.Write("Nummer: ");

        int number;
        while(!int.TryParse(Console.ReadLine(),out number) || number <1||number >list.Count) // Loops and repeats the question if the number is smaller than 1 or greater than the amount of things on the list.
        {
            Console.Write("Ange nummer av varan du vill ta bort.\nNummer");
        }
        list.RemoveAt(number);
    }
    else if (choice == 3)
    {
        list.Save();
    }
    else if (choice == 4)
    {
        Console.Write("Namn att söka efter: ");
        string wanted = Console.ReadLine();
        Item found = list.Find(wanted);

        if (found == null)
        {
            Console.WriteLine("Varan finns inte i listan.");
        }
        else
        {
            Console.WriteLine($"Hittade: {found}");
        }
    }
    else if (choice == 5)
    {
        break;
    }
}
