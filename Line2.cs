public class Line2
{
    //  Line slope.
    public double m;

    //  Line horizontal intercept.
    protected double x0;

    //  Line vertical intercept.
    protected double y0;

    public Line2(double m, Vector2 p)
    {
        this.m = m;
        this.x0 = p.x - (p.y/this.m);
        this.y0 = p.y - (this.m*p.x);
    }

    public Line2(Vector2 u, Vector2 v)
    {
        this.m = (v.y - u.y)/(v.x - u.x);
        this.x0 = u.x - (u.y/this.m);
        this.y0 = u.y - (this.m*u.x);
    }

    //  Find a perpendicular line of the given line at
    //  the given point.
    public static Line2 Perpendicular(Line2 s, Vector2 p)
    {
        return new Line2(
            -1/s.m,
            p
        );
    }

    //  Find an intersection between two given lines.
    public static Vector2 Intersection(Line2 s, Line2 t)
    {
        if(s.m == t.m)
        {
            return new Vector2(double.NaN, double.NaN);
        }
        else if(double.IsInfinity(s.m))
        {
            return new Vector2(s.x0, t.m*(s.x0) + t.y0);
        }
        else if(double.IsInfinity(t.m))
        {
            return new Vector2(t.x0, s.m*(t.x0) + s.y0);
        }
        else
        {
            double pX = (t.y0 - s.y0)/(s.m - t.m);
            double pY = (s.m * pX) + s.y0;
            return new Vector2(pX, pY);
        }
    }

    public override string ToString()
    {
        return string.Format("Line2(m: {0}, x0: {1}, y0: {2})", this.m, this.x0, this.y0);
    }
}