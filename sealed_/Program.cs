using System.Security.Cryptography.X509Certificates;

namespace sealed_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car(1, "Cobat", "Chevrolet", 100_000, 0);
            Car car1 = new Car(2, "Lacetti", "Chevrolt", 161_000, 0);
            Car car2 = new Car(3, "Xray", "Lada", 170_000, 0);
            Car car3 = new Car(4, "Prado", "Toyota", 300_000, 0);

            Console.WriteLine(car.CalaulateTotal());
            Console.WriteLine(car1.CalaulateTotal());
            Console.WriteLine(car2.CalaulateTotal());
            Console.WriteLine(car3.CalaulateTotal());

            Console.WriteLine();
            Console.WriteLine();

            //car.TaxPercentage=10;
            //car1.TaxPercentage=10;
            //car2.TaxPercentage=10;
            //car3.TaxPercentage=10;
            Car.TaxPercentage = 10;

            Console.WriteLine(car.CalaulateTotal());
            Console.WriteLine(car1.CalaulateTotal());
            Console.WriteLine(car2.CalaulateTotal());
            Console.WriteLine(car3.CalaulateTotal());
        }
    }
}