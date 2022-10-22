
var dictionary = new Dictionary<int, River>();
var dnipro = new River(1, "Dnipro");
dictionary[dnipro.Id] = dnipro;

var key = 2;
//if (dictionary.ContainsKey(key))
//{
//    Console.WriteLine("Річка: {0}", dictionary[key]);
//}
//else
//{
//    Console.WriteLine("Не вдалося знайти річку за ідентифікатором {0}", key);
//}

if (dictionary.TryGetValue(key, out var river))
{
    Console.WriteLine("Річка: {0}", river);
}
else
{
    Console.WriteLine("Не вдалося знайти річку за ідентифікатором {0}", key);
}

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