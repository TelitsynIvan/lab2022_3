using System.Runtime.CompilerServices;

namespace MyVector;

public struct Vector
{
    private int x, y, z;

    public Vector(int ax, int ay, int az)
    {
        x = ax;
        y = ay;
        z = az;
    }
    public static Vector operator +(Vector a, Vector b)
    {
        return new Vector(a.x + b.x, a.y + b.y, a.z + b.z);
    }
    public static Vector operator *(Vector a, Vector b)
    {
        return new Vector(a.x * b.x, a.y * b.y, a.z * b.z);
    }
    public static Vector operator *(Vector a, int b)
    {
        return new Vector(a.x * b, a.y * b, a.z * b);
    }

    decimal Len()
    {
        return System.Convert.ToDecimal(Math.Sqrt(x * x + y * y + z * z));
    }
    public static bool operator >(Vector a, Vector b)
    {
        return a.Len() > b.Len();
    }
    public static bool operator <(Vector a, Vector b)
    {
        return a.Len() < b.Len();
    }
    public static bool operator ==(Vector a, Vector b)
    {
        return a.Len() == b.Len();
    }
    public static bool operator !=(Vector a, Vector b)
    {
        return a.Len() != b.Len();
    }
}