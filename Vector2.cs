public class Vector2
{
    //  Abscissa.
    protected double x;
    public double X
    {
        get { return this.x; }
        set { this.x = value; }
    }

    //  Ordinate.
    protected double y;
    public double Y
    {
        get { return this.y; }
        set { this.y = value; }
    }

    public Vector2(double x, double y)
    {
        this.x = x;
        this.y = y;
    }

    //  Compute this vector magnitude.
    public double Magnitude()
    {
        return Math.Sqrt((this.X * this.X) + (this.Y * this.Y));
    }

    public static Vector2 operator +(Vector2 u)
    {
        return u;
    }

    public static Vector2 operator -(Vector2 u)
    {
        return new Vector2(-u.X, -u.Y);
    }

    public static Vector2 operator +(Vector2 u, Vector2 v)
    {
        return new Vector2(u.X + v.X, u.Y + v.Y);
    }

    public static Vector2 operator -(Vector2 u, Vector2 v)
    {
        return u + (-v);
    }

    //  Compute a dot product between two given vector.
    public static double operator *(Vector2 u, Vector2 v)
    {
        return (u.X * v.X) + (u.Y * v.Y);
    }

    //  Compute a product between given scala and vector.
    public static Vector2 operator *(Vector2 u, double k)
    {
        return new Vector2(u.X * k, u.Y * k);
    }

    //  Compute a product between given scala and vector.
    public static Vector2 operator *(double k, Vector2 u)
    {
        return u * k;
    }

    //  Compute a quotient between given scala and vector.
    public static Vector2 operator /(Vector2 u, double k)
    {
        return new Vector2(u.X / k, u.Y / k);
    }

    public static Vector2 Copy(Vector2 u)
    {
        return new Vector2(u.X, u.Y);
    }

    public override string ToString()
    {
        return string.Format("Vector2(x: {0}, y: {1})", this.X, this.Y);
    }
}