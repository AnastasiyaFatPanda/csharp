class Program
{
  static void Main()
  {
    Girl girl = new Girl("Anna", 12, "Sovetskaia 44, kv. 32");
    Boy boy = new Boy("Petr", 14);

    Console.WriteLine("Get info:");
    girl.GetInfo();
    boy.GetInfo();

    Console.WriteLine("\nWho am I?");
    girl.WhoAmI();
    boy.WhoAmI();


    Console.WriteLine("\nCall specific methods:");
    girl.PlayPiano();
    boy.PlayFootbal();
  }

}
