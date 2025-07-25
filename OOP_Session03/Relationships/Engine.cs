
    internal class Engine
    {
    public void star()
    {
        Console.WriteLine("star from engine class");
    }
    }
public class Cars
{
    private Engine engine = new Engine();
    public Cars(){
        engine.star();
}
}