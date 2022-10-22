var river = new River(1, "Dnipro");
river.AddFish("Dorado");
river.AddFish("Salmon");
river.AddFish("Dorado");
Console.ReadKey();

class River
{
    public River(int id, string name)
    {
        Id = id;
        Name = name;
        Fish = new HashSet<string>();
    }
    public HashSet<string> Fish { get; private set; }
    public int Id { get; private set; }
    public string Name { get; private set; }
    public Decimal Length { get; set; }
    public void AddFish(string fishName)
    {
        Console.WriteLine(
            Fish.Add(fishName) 
                ? $"Add fish {fishName}"
                : $"Can`t add fish {fishName}");
    }
}