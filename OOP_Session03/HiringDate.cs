public class HiringDate
{
    // Fields
    public int Day
    {
        get { return Day; }
        set
        {
            Day = value > 1 && value <= 31 ? value : DateTime.Now.Day;
        }
    }
    public int Month
    {
        get {  return Month; }
        set
        {
            Month = value>1&&value<=31?value: DateTime.Now.Month;
        }
    }
    public int Year
    {
        get => Year;
        set => Year = (value >0 && value <= DateTime.Now.Year) ? value : DateTime.Now.Year;
    }

    // Constructor
    public HiringDate(int day, int month, int year)
    {
       Day = day;
       Month= month;
        Year = year;
    }
}