using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace projeto_teste
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7};
            //var impares = list.FindAll(x => x % 2 == 1);

            //foreach (var item in impares)
            //{
            //    Console.WriteLine(item);
            //}

            List<Dog> dogs = new List<Dog>()
            {
                new Dog{Name = "Rex", Age = 4},
                new Dog{Name = "Sean", Age = 0},
                new Dog{Name = "Stacy", Age =3}
            };

            //var names = dogs.Select(x => x.Name);
            //var newDogList = dogs.Select(x => new { Age = x.Age, FirstLetter = x.Name[0] });
            var sortedDogs = dogs.OrderByDescending(x => x.Age);
            foreach (var item in sortedDogs)
            {
                Console.WriteLine(string.Format($"Dog {item.Name} is {item.Age} years old."));
            }

            Console.WriteLine("Tenhamos uma boa noite !");
            Console.WriteLine("Uma noite de pa e tranquila !");

        }
    }
}
