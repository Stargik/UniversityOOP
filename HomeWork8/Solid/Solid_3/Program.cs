using Solid_3;
using System;

// Порушено принцип Liskov Substitution (Виправлено в цьому прроєкті)

    class Program
    {
        static void Main(string[] args)
        {
            SimmetricSidesTetragon square = new Square();
            square.Width = 5;
            square.Height = 10;

            Console.WriteLine(square.GetArea());

            Console.ReadKey();
        }
    }
