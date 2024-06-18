namespace Assignment7._4._1_Parking_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var ps = new ParkingSystem(1, 2, 3);

            Console.WriteLine(ps.addCar(1));
            Console.WriteLine(ps.addCar(2));
            Console.WriteLine(ps.addCar(3));
            Console.WriteLine(ps.addCar(1));
            Console.WriteLine(ps.addCar(2));
            Console.WriteLine(ps.addCar(3));
            Console.WriteLine(ps.addCar(1));
            Console.WriteLine(ps.addCar(2));
            Console.WriteLine(ps.addCar(3));
        }
    }
}
