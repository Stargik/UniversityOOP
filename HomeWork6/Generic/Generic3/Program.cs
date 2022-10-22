var cities = new List<string>(3);
cities.Add("New York");
cities.Add("London");
cities.Add("Chicago");
cities.Add("Chicago");
cities.Add("Neyagawa");
var hashCities = new HashSet<string>(cities);
Console.WriteLine(hashCities.Count);
Console.ReadKey();