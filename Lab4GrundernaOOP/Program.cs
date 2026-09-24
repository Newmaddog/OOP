//Namn: Erico Leonardo Alexander Pizarro Gutierrez
//Klass: NET26
namespace Lab4GrundernaOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(5);
            Circle BigCircle = new Circle(6);

            Console.WriteLine($"The little circle's area is: {circle.GetArea()}");
            Console.WriteLine($"The big circle's area is: {BigCircle.GetArea()}");
        }
    }
}
