class Program
{
  static void Main()
  {
    Cat cat = new Cat("Barsik", 3, Gender.Male, 4.1);
    Dog dog = new Dog("Bobik", 7, Gender.Male, 22.7);
    Dog dogNoname = new Dog("", 3, Gender.Female, 30.2);
    Eagle eagle = new Eagle("Eagle", 2, Gender.Male, 12.7);
    Penguin penguin = new Penguin("Penguin", 13, Gender.Female, 21.7);

    // set wrong weight
    try
    {
      dog.Weight = 0;
    }
    catch (Exception ex)
    {
      Console.WriteLine(ex.Message);
    }

    // call specific methods
    dogNoname.Bark();
    penguin.Dive();

    Group<Dog> dogsGroup = new Group<Dog>("Dogs", new List<Dog>() { dog, dogNoname });
    Group<Cat> catsGroup = new Group<Cat>("Cats", new List<Cat>() { cat });
    Group<Bird> birdsGroup = new Group<Bird>("Birds", new List<Bird>() { eagle, penguin });

    dogsGroup.GetInfo();
    catsGroup.GetInfo();
    birdsGroup.GetInfo();
  }
}
