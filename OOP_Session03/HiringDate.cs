public class HireDate
{
    public int Day { get; set; }
    public int Month { get; set; }
    public int Year { get; set; }

    public HireDate(int day, int month, int year)
    {
        if (day < 1 || day > 31) day = 1;
        if (month < 1 || month > 12) month = 1;
        if (year < 1900 || year > DateTime.Now.Year) year = DateTime.Now.Year;

        Day = day;
        Month = month;
        Year = year;
    }
    public override string ToString()
    {
        return $"{Day:D2}/{Month:D2}/{Year}";
    }
}