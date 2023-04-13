public class Line2
{
    //  Line slope.
    protected double m;
    public double M
    {
        get { return this.m; }
    }

    //  Line horizontal intercept.
    protected double x0;
    public double X0
    {
        get { return this.x0; }
    }

    //  Line vertical intercept.
    protected double y0;
    public double Y0
    {
        get { return this.y0; }
    }

    public Line2(double m, Vector2 p)
    {
        this.m = m;
        this.x0 = p.X - (p.Y/this.M);
        this.y0 = p.Y - (this.M*p.X);
    }

    public Line2(Vector2 u, Vector2 v)
    {
        this.m = (v.Y - u.Y)/(v.X - u.X);
        this.x0 = u.X - (u.Y/this.M);
        this.y0 = u.Y - (this.M*u.X);
    }

    //  Find a perpendicular line of the given line at
    //  the given point.
    public static Line2 Perpendicular(Line2 s, Vector2 p)
    {
        return new Line2(
            -1/s.M,
            p
        );
    }

    //  Find an intersection between two given lines.
    public static Vector2 Intersection(Line2 s, Line2 t)
    {
        if(s.M == t.M)
        {
            return new Vector2(double.NaN, double.NaN);
        }
        else if(double.IsInfinity(s.M))
        {
            return new Vector2(s.X0, t.M*(s.X0) + t.Y0);
        }
        else if(double.IsInfinity(t.M))
        {
            return new Vector2(t.X0, s.M*(t.X0) + s.Y0);
        }
        else
        {
            double pX = (t.Y0 - s.Y0)/(s.M - t.M);
            double pY = (s.M * pX) + s.Y0;
            return new Vector2(pX, pY);
        }
    }

    public override string ToString()
    {
        return string.Format("Line2(m: {0}, x0: {1}, y0: {2})", this.M, this.X0, this.Y0);
    }
}