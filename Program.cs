namespace DocumentApp
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Singleton menuSingleton = Singleton.GetInstance();
      menuSingleton.ShowMenu();
    }
  }
}