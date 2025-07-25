
    public class Child:Parent
    {
    public int z {  get; set; }
  public  Child(int x,int y,int z) : base(x, y)
    {

    this.z = z;
    }
    public override int Product()
    {
        return x * y * z;
    }
}
