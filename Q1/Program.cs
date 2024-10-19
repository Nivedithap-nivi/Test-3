namespace Q1
{
    public class Program
    {
        static void Main(string[] args)
        {
            IList<Person>pp = new List<Person>();
            pp.Add(new Person ( "Aarya", "A2101", 69 ));
            pp.Add(new Person("Daniel", "D104",40 ));
            pp.Add(new Person ("Ira","H801", 25 ));
            pp.Add(new Person("Jennifer","I1704", 33 ));

            PersonImplementation p1 = new PersonImplementation();
            Console.WriteLine(p1.GetName(pp));
            Console.WriteLine(p1.Average(pp));
            Console.WriteLine(p1.Max(pp));
        }
    }
}
