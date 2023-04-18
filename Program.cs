internal class Program
{
    private static void Main(string[] args)
    {
        //Group group = new Group();
        Console.WriteLine("1.Group Menu");
        Console.WriteLine("2.Student Menu");
        Console.WriteLine("0.Exit");
        string input=Console.ReadLine();
        Console.WriteLine(input);
        
        while (true)
        {
            switch (input)
            {
                case "1":
                    while (true)
                    {
                        Console.WriteLine("1.Create Group");
                        Console.WriteLine("2.Delete Group");
                        Console.WriteLine("3.Update Group");
                        Console.WriteLine("4.Show all Group");
                    }
                case "2":
                    while (true)
                    {
                        Console.WriteLine("1.Create Group");
                        Console.WriteLine("2.Delete Group");
                        Console.WriteLine("3.Update Group");
                        Console.WriteLine("4.Show all Group");
                    }
                case "3":
                    while (true)
                    {
                        Console.WriteLine("1.Create Group");
                        Console.WriteLine("2.Delete Group");
                        Console.WriteLine("3.Update Group");
                        Console.WriteLine("4.Show all Group");
                    }
            }
                
                
        }
    }
}