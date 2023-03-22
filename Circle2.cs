public class Circle2
{
    //  Center.
    public Vector2 c;

    //  Radius.
    public double r;

    public Circle2(Vector2 c, double r)
    {
        this.c = Vector2.Copy(c);
        this.r = r;
    }

    public override string ToString()
    {
        return string.Format("Circle(c: {0}, r: {1})", this.c, this.r);
    }
}