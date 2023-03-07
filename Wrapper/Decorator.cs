
public class rainDrop
{
    public Bitmap pic;
    public Point pos;
    public virtual Point get_pos() { return new Point(pos.X, pos.Y); }
    public rainDrop(Bitmap file, Point position)
    {
        pos = position;
        pic = file;
    }
    public rainDrop(Point position)
    {
        pos = position; 
        pic = new Bitmap(AppDomain.CurrentDomain.BaseDirectory + "\\drop.png");
    }
}

public class FirstDrop : rainDrop
{
    public FirstDrop(rainDrop d) : base(d.pos)
    {
        pic = new Bitmap(AppDomain.CurrentDomain.BaseDirectory + "\\drop1.png");
    }
}
public class ScndDrop : rainDrop
{

    public ScndDrop(rainDrop d) : base(d.pos)
    {
        pic = new Bitmap(AppDomain.CurrentDomain.BaseDirectory + "\\drop2.png");
    }
}
public class ThrdDrop : rainDrop
{
    public ThrdDrop(rainDrop d) : base(d.pos)
    {
        pic = new Bitmap(AppDomain.CurrentDomain.BaseDirectory + "\\drop3.png");
    }
}
public class dropsline : rainDrop
{
    public override Point get_pos() { return new Point((pos.X +pos.Y/5), pos.Y); }
    public dropsline(rainDrop d) : base(d.pic,d.get_pos()) { }
}
public class sinDrop : rainDrop
{
    public override Point get_pos() { return new Point(pos.X + (int)(Math.Sin(pos.Y*10)*40), pos.Y); }
    public sinDrop(rainDrop d) : base(d.pic, d.get_pos()) { }
}
public class cosDrop : rainDrop
{
    public override Point get_pos() { return new Point(pos.X + (int)(Math.Cos(pos.Y*6)*10), pos.Y); }
    public cosDrop(rainDrop d) : base(d.pic, d.get_pos()) { }
}
