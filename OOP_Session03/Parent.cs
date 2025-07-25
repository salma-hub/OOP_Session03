
public class Parent
{
    public int x { get; set; }
    public int y { get; set; }
  public   Parent(int x, int y)
    {
        this.x = x;
        this.y = y;
    }
    public virtual int Product()
    {
        return x * y;
    }
    }

