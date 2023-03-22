public class Line2
{
    //  Line slope.
    public double m;

    //  Line vertical intercept.
    public double c;

    public Line2(double m, double c)
    {
        this.m = m;
        this.c = c;
    }

    public Line2(Vector2 u, Vector2 v)
    {
        this.m = (v.y - u.y)/(v.x - u.x);
        this.c = u.y - (m * u.x);
    }

    //  Find a perpendicular line of the given line at
    //  the given point.
    public static Line2 Perpendicular(Line2 s, Vector2 p)
    {
        return new Line2(
            -1/s.m,
            p.y + (p.x/s.m)
        );
    }

    //  Find an intersection between two given lines.
    public static Vector2 Intersection(Line2 s, Line2 t)
    {
        double pX = (t.c - s.c)/(s.m - t.m);
        double pY = (s.m * pX) + s.c;
        return new Vector2(pX, pY);
    }

    public override string ToString()
    {
        return string.Format("Line2(m: {0}, c: {1})", this.m, this.c);
    }
}