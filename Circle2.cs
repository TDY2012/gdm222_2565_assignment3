public class Circle2
{
    //  Center.
    protected Vector2 c;
    public Vector2 C
    {
        get { return this.c; }
    }

    //  Radius.
    protected double r;
    public double R
    {
        get { return this.r; }
    }

    public Circle2(Vector2 c, double r)
    {
        this.c = Vector2.Copy(c);
        this.r = r;
    }

    public override string ToString()
    {
        return string.Format("Circle(c: {0}, r: {1})", this.C, this.R);
    }
}