namespace age3;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Doguldugunuz gunu daxil edin:");
        int birthDay = int.Parse(Console.ReadLine());
        Console.WriteLine("Doguldugunuz ayi daxil edin:");
        int birthMonth = int.Parse(Console.ReadLine());
        Console.WriteLine("Doguldugunuz ili daxil edin");
        int birthYear = int.Parse(Console.ReadLine());
        Console.WriteLine("Tapmaq istediyiniz gunu daxil edin:");
        int day = int.Parse(Console.ReadLine());
        Console.WriteLine("Tapmaq istediyiniz ayi daxil edin:");
        int month = int.Parse(Console.ReadLine());
        Console.WriteLine("Tapmaq istediyiniz ili daxil edin:");
        int year = int.Parse(Console.ReadLine());

        if (year > birthYear && month > birthMonth)
        {
            Console.WriteLine(year - birthYear);
        }

        if (year > birthYear && month < birthMonth)
        {
            Console.WriteLine(year - birthYear - 1);
        }

        if (year > birthYear && month == birthMonth && birthDay < day)
        {
            Console.WriteLine(year - birthYear);
        }

        if (year > birthYear && month == birthMonth && birthDay > day)
        {
            Console.WriteLine(year - birthYear - 1);
        }

        if (year == birthYear && month >= birthMonth)
        {
            Console.WriteLine("Yash tamam olmayib");
        }
        

    }
}

