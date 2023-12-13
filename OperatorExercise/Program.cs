namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //int a = 17;
            //int b = 4;

            ////    int sum = 1 + 1;
            ////    int difference = 1 - 1;
            ////    int quotient = 1 / 1;
            ////    int product = 1 * 1;
            ////    int modulo = 1 % 1;

            //// step 2

            //int quotient = a / b;
            //int remainder = a % b;

            //Console.WriteLine($"{a}/{b} is {quotient} remainder {remainder}");

            PrintAreaOfCircle();
        }

        public static void PrintAreaOfCircle()
        {
            Console.WriteLine("What is the area of your cirlcle?");
            double radius = double.Parse(Console.ReadLine());
            Console.WriteLine($"The area of a circle with a radius of {radius} is {AreaOfCircle(radius)}.");
        }
        public static double AreaOfCircle(double radius)
        {
        return Math.PI* Math.Pow(radius, 2);
        }
            
    }
}
