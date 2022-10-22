var dnipro = new River(1, "Dnipro");
dnipro.AddFish("Dorado");
Console.WriteLine(dnipro.Id);
Console.ReadKey();

class River
{
    private List<string> _fish;
    public River(int id, string name)
    {
        Id = id;
        Name = name;
    }
    public int Id { get; private set; }
    public string Name { get; private set; }
    public Decimal Length { get; set; }
    public void AddFish(string fishName)
    {
        _fish.Add(fishName);
    }
}