namespace Program;
using MyVector;

class Program
{
    static void Main()
    {
        Vector one = new Vector(12, 13, 14);
        Vector two = new Vector(15, 16, 17);
        if (two != one)
        {
            Console.WriteLine("ok");
        }
        else
        {
            Console.WriteLine("ko");
        }
    }
}