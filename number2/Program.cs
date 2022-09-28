namespace program;
using Car;

class Program
{
    static void Main()
    {
        Car supra = new Car();
        supra.Name = "Supra";
        supra.Engine = "2jz-gte";
        supra.speed = 300;
        Car rs5 = new Car();
        rs5.Name = "Audi Rs5";
        rs5.Engine = "2.9-liter V-6";
        rs5.speed = 250;
        Car sl63 = new Car();
        sl63.Name = "Mercedes sl63";
        sl63.Engine = "4.0-litre V8 twin-turbo";
        sl63.speed = 270;
        CarsCatalog shop = new CarsCatalog();
        shop.arr.Add(supra);
        shop.arr.Add(rs5);
        shop.arr.Add(sl63);
        for (int i = 0; i < shop.arr.Capacity-1; i++)
        {
            Console.WriteLine(shop[i]);
        }
        {
            
        }
    }
}