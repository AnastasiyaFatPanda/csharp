namespace ConsoleApp
{
  public class Group<T> where T : IAnimal
  {
    public string groupName;
    public List<T> group;

    public Group(string groupName) : this(groupName, new List<T>()) { }

    public Group(string groupName, List<T> group)
    {
      this.groupName = groupName;
      this.group = group;
    }

    public void GetInfo()
    {
      Console.WriteLine($"Group Name: {groupName}, "
        + $"animals: {String.Join(", ", group.ConvertAll<string>(groupItem => groupItem.Name).ToArray())}");
    }
  }
}
