namespace Stopwatch
{
  class Program
  {
    static void Main()
    {
      Menu();
    }
    static void Menu()
    {
      Console.Clear();
      Console.WriteLine("S = Segundo => 10s = 10 segundos");
      Console.WriteLine("M = Segundo => 1m = 1 minuto");
      Console.WriteLine("0 = Sair");
      Console.WriteLine("Quanto tempo deseja contar?");
      string userResponse = Console.ReadLine().ToLower();
      char unity = char.Parse(userResponse.Substring(userResponse.Length - 1, 1));
      int time = int.Parse(userResponse.Substring(0, userResponse.Length - 1));
      if (time == 0) System.Environment.Exit(0);
      if (unity == 'm') time *= 60;
      Timer(time);
    }
    static void Timer(int time)
    {
      int currentTime = 0;
      do
      {
        Console.Clear();
        currentTime++;
        Console.WriteLine(currentTime);
        Thread.Sleep(1000);
      } while (currentTime != time);
      Console.Clear();
      Console.WriteLine("Stopwatch finalizado... Voltando para o Menu.");
      Console.ReadKey();
      Menu();
    }
  }
}