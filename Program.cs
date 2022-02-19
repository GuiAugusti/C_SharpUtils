// Main


Vector3 playerPosition = Vector3.Up;
playerPosition.DisplayPosition();


struct Vector3
{
    public float x;
    public float y;
    public float z;


    private static readonly Vector3 zeroVector = new Vector3(0f, 0f, 0f);
    private static readonly Vector3 oneVector = new Vector3(1f, 1f, 1f);
    private static readonly Vector3 upVector = new Vector3(0f, 1f, 0f);
    private static readonly Vector3 downVector = new Vector3(0f, -1f, 0f);
    private static readonly Vector3 leftVector = new Vector3(-1f, 0f, 0f);
    private static readonly Vector3 rightVector = new Vector3(1f, 0f, 0f);
    private static readonly Vector3 forwardVector = new Vector3(0f, 0f, 1f);
    private static readonly Vector3 backVector = new Vector3(0f, 0f, -1f);


    public static Vector3 Zero => zeroVector;
    //
    // Summary:
    //     Shorthand for writing Vector3(1, 1, 1).
    public static Vector3 One => oneVector;
    //
    // Summary:
    //     Shorthand for writing Vector3(0, 0, 1).
    public static Vector3 Forward => forwardVector;
    //
    // Summary:
    //     Shorthand for writing Vector3(0, 0, -1).
    public static Vector3 Back => backVector;
    //
    // Summary:
    //     Shorthand for writing Vector3(0, 1, 0).
    public static Vector3 Up => upVector;
    //
    // Summary:
    //     Shorthand for writing Vector3(0, -1, 0).
    public static Vector3 Down => downVector;
    //
    // Summary:
    //     Shorthand for writing Vector3(-1, 0, 0).
    public static Vector3 Left => leftVector;
    //
    // Summary:
    //     Shorthand for writing Vector3(1, 0, 0).
    public static Vector3 Right => rightVector;

    public override bool Equals(object other)
    {
        if (!(other is Vector3))
        {
            return false;
        }

        return Equals((Vector3)other);
    }
    public bool Equals(Vector3 other)
    {
        return x == other.x && y == other.y && z == other.z;
    }
    public override int GetHashCode()
    {
        return x.GetHashCode() ^ (y.GetHashCode() << 2) ^ (z.GetHashCode() >> 2);
    }
    public static Vector3 operator +(Vector3 a, Vector3 b)
    {
        return new Vector3(a.x + b.x, a.y + b.y, a.z + b.z);
    }
    public static Vector3 operator -(Vector3 a, Vector3 b)
    {
        return new Vector3(a.x - b.x, a.y - b.y, a.z - b.z);
    }
    public static Vector3 operator -(Vector3 a)
    {
        return new Vector3(0f - a.x, 0f - a.y, 0f - a.z);
    }
    public static Vector3 operator *(Vector3 a, float d)
    {
        return new Vector3(a.x * d, a.y * d, a.z * d);
    }
    public static Vector3 operator *(float d, Vector3 a)
    {
        return new Vector3(a.x * d, a.y * d, a.z * d);
    }
    public static Vector3 operator /(Vector3 a, float d)
    {
        return new Vector3(a.x / d, a.y / d, a.z / d);
    }
    public static bool operator ==(Vector3 lhs, Vector3 rhs)
    {
        float num = lhs.x - rhs.x;
        float num2 = lhs.y - rhs.y;
        float num3 = lhs.z - rhs.z;
        float num4 = num * num + num2 * num2 + num3 * num3;
        return num4 < 9.99999944E-11f;
    }
    public static bool operator !=(Vector3 lhs, Vector3 rhs)
    {
        return !(lhs == rhs);
    }



    public static Vector3 Normalize(Vector3 value)
    {
        float num = Magnitude(value);
        if (num > 1E-05f)
        {
            return value / num;
        }

        return Zero;
    }

    public static float Magnitude(Vector3 vector)
    {
        return (float)Math.Sqrt(vector.x * vector.x + vector.y * vector.y + vector.z * vector.z);
    }






    public Vector3(float x, float y, float z)
    {
        this.x = x;
        this.y = y;
        this.z = z;
    }

    public void DisplayPosition()
    {
        Console.WriteLine($"X = {this.x}, Y = {this.y}, Z = {this.z}");  
    }
}