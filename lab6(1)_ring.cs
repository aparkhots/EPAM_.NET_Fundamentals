using System;

namespace lab_ring
{
    class Ring
    {
        public double innerRadius, outerRadius;
        public double perimetr()
        {
            return Math.PI * (innerRadius + outerRadius) * 2;
        }

        public double square()
        {
            return  Math.PI * ((outerRadius * outerRadius) - (innerRadius * innerRadius));
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter inner radius: ");
            double d1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter outer radius: ");
            double d0 = Convert.ToDouble(Console.ReadLine());

            if (d0 != d1 && d0 > d1 && d1 > 0)
            {
                Ring newRing = new Ring
                {
                    innerRadius = d1,
                    outerRadius = d0
                    
                };

                Console.WriteLine($"Perimetr of ring: {newRing.perimetr()}");
                Console.WriteLine("Square of ring: {0}", newRing.square());
            }
            else Console.WriteLine("this ring can't be created");
        }
    }
}
