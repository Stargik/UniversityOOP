var river = new River(1, "Dnipro");

river.AddFish("Dorado");
river.AddFish("Salmon");
river.AddFish("Dorado");

river.WriteCountByFish("Dorado");
river.WriteCountByFish("Salmon");
river.WriteCountByFish("Snapper");

Console.ReadKey();

class River
{
    public River(int id, string name)
    {
        Id = id;
        Name = name;
        Fish = new HashSet<string>();
        _fishCount = new Dictionary<string, int>();
    }
    public HashSet<string> Fish { get; private set; }
    public int Id { get; private set; }
    public string Name { get; private set; }
    public Decimal Length { get; set; }
    private Dictionary<string, int> _fishCount;

    public void AddFish(string fishName)
    {
        if (Fish.Add(fishName))
        {
            _fishCount[fishName] = 1;
            return;
        }
        _fishCount[fishName] = _fishCount[fishName] + 1;
    }
    public void WriteCountByFish(string fishName)
    {
        var fishCount = _fishCount.TryGetValue(fishName, out int count) ? count : 0;
        Console.WriteLine($"{fishName} = {fishCount}");
    }
}