using System;
using System.Collections.Generic;

namespace IceCreamShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Case menu = new Case();
            List<Flavor> availableFlavors = menu.Flavors;
            List<Cone> availableCones = menu.Cones;


            // TODO: Use a Comparer class to sort the 'flavors' array alphabetically by the 'name'
            //  field.

            //availableFlavors.Sort(new FlavorComparer());     or:
            FlavorComparer comparer = new FlavorComparer();
            availableFlavors.Sort(comparer);

            Console.WriteLine("FLAVORS\n");

            foreach (Flavor flavor in availableFlavors)
            {
                Console.WriteLine(flavor.Name);
            }

            Console.WriteLine("\n------------------\n");

            // TODO: Use a Comparator class to sort the 'cones' array in increasing order by the 'cost'
            //  field.

            availableCones.Sort(new ConeComparer());

            Console.WriteLine("CONTAINER/CONE\n");

            foreach (Cone cone in availableCones)
            {
                Console.WriteLine($"{cone.Name}: ${Math.Round(cone.Cost, 2)}");
            }



            // TODO: Print the 'flavors' and 'cones' lists (in a clear manner) to verify the sorting.


        }
    }
}
