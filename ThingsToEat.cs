namespace morning
{
  public class Coffee
  {
    public string Brand;
    public bool Caffeine;
    public string Roast;
    public int Creamer;
    public float Temp;

    public Coffee(string brand, bool caffeine, string roast, int creamer, float temp)
    {
      Brand = brand;
      Caffeine = caffeine;
      Roast = roast;
      Creamer = creamer;
      Temp = temp;
    }
  }

   public class RickCrispy
  {
    public string Snack;

    public RickCrispy(string snack)
    {
      Snack = snack;
    }
  }
}