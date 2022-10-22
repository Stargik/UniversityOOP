var cities = new List<string>(10);
cities.Add("New York");
cities.Add("London");
cities.Add("Chicago");
cities.Add(null);
cities.Add("Chicago");
cities.Add("Neyagawa");
cities.ForEach(city => Console.WriteLine(city));
Console.ReadKey();