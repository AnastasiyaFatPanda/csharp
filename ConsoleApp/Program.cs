class Program
{
    static void Main()
    {
        Human human = new Human();
        Girl girl = new Girl("Anna", 12, "Sovetskaia 44, kv. 32");
        Boy boy = new Boy("Petr", 14);
        Reflection.TypeInfo<Human>(human);
        Reflection.TypeInfo<Girl>(girl);
        Reflection.TypeInfo<Boy>(boy);
    }

}
