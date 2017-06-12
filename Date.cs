namespace csharp_rps
{
  public class Date
  {
    public string Month;
    public string Day;
    public string Year;

  public Date(int month, string day, string year)
  {
    Year = year;
    Day = day;
    switch (month)
    {
      case 1:
        Month = "January";
        break;
      case 2:
        Month = "Febuary";
        break;
    }
  }
  }
}