// One item on the shopping list.
class Item
{
    public string Name { get; set; } 
    //get makes it possible for the program to read the code
    //set modifies the code after the reading
    public int Price { get; set; }

    public Item(string name, int price)
    {
        Name = name;
        Price = price;
    }

    public override string ToString()
    {
        return $"{Name} - {Price} kr";
    }
}
