class  Program
{
    static void Main(string []arrys)
    {
        int first,second,third;
        Console.WriteLine("Enter the First number");
        first = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the Second number");
        second = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the Third number");
        third = Convert.ToInt32(Console.ReadLine());

        if (first > second & first > third)
        {
            Console.WriteLine("The Largest Number - " + second);
        }
        else if (second > first && second > third)
        {
            Console.WriteLine("The Largest Number - " + second);
        }
        else 
        {
            Console.WriteLine("The Largest Number - " + third);
        }
        Console.WriteLine("The Code is End");
    }


}