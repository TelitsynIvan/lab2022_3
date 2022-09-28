namespace Car;

public class CarsCatalog
{
    public List<Car> arr = new List<Car>();

    public string this[int index]
    {
        get
        {
            return $"{arr[index].Name}, {arr[index].Engine}";
        }
    }
}