using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static readonly List<Member> members =
    [
        new Member { FirstName = "Phan Thành Công", LastName = "Đặng", Gender = Gender.Male, DateOfBirth = new DateTime(2000, 6, 15), PhoneNumber = "0375.284.637", Birthplace = "Lâm Đồng", IsGraduated = true },
        new Member { FirstName = "Mỹ Linh", LastName = "Nguyễn", Gender = Gender.Female, DateOfBirth = new DateTime(1995, 6, 2), PhoneNumber = "0375.284.636", Birthplace = "Hà Nội", IsGraduated = true },
        new Member { FirstName = "Mai Phương", LastName = "Trần", Gender = Gender.Female, DateOfBirth = new DateTime(2001, 4, 5), PhoneNumber = "0375.284.635", Birthplace = "Hải Phòng", IsGraduated = false },
        new Member { FirstName = "Thu Hà", LastName = "Phạm", Gender = Gender.Female, DateOfBirth = new DateTime(2002, 1, 1), PhoneNumber = "0375.284.634", Birthplace = "Thái Bình", IsGraduated = false },
        new Member { FirstName = "Minh Quang", LastName = "Nguyễn", Gender = Gender.Male, DateOfBirth = new DateTime(1994, 7, 4), PhoneNumber = "0375.284.633", Birthplace = "Hà Nội", IsGraduated = true },
    ];

    static List<Member> GetMaleMembers()
    {
        return members.Where(m => m.Gender == Gender.Male).ToList();
    }

    static Member GetOldestMember()
    {
        return members.OrderByDescending(m => m.Age).FirstOrDefault();
    }

    static List<string> GetFullNames()
    {
        return members.Select(m => m.FullName).ToList();
    }

    static (List<Member>, List<Member>, List<Member>) GetListsBasedOnBirthYear()
    {
        var membersBornIn2000 = members.Where(m => m.DateOfBirth.Year == 2000).ToList();
        var membersBornAfter2000 = members.Where(m => m.DateOfBirth.Year > 2000).ToList();
        var membersBornBefore2000 = members.Where(m => m.DateOfBirth.Year < 2000).ToList();

        return (membersBornIn2000, membersBornAfter2000, membersBornBefore2000);
    }

    static Member GetFirstPersonBornInHanoi()
    {
        return members.Where(m => m.Birthplace == "Hà Nội").OrderByDescending(m => m.Age).FirstOrDefault();
    }

    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Return a list of members who is male");
            Console.WriteLine("2. Return the oldest one based on age");
            Console.WriteLine("3. Return a list that contains full name only");
            Console.WriteLine("4. Return 3 lists that filter members by birth year 2000");
            Console.WriteLine("5. Return the first person who was born in Hà Nội");
            Console.WriteLine("0. Exit");
            Console.WriteLine("-------");

            try
            {
                Console.Write("Your option: ");
                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        var maleMembers = GetMaleMembers();
                        Console.WriteLine("Male members:");
                        maleMembers.ForEach(m => Console.WriteLine(m.ToString()));
                        Console.WriteLine("-------");
                        break;
                    case 2:
                        var oldestMember = GetOldestMember();
                        Console.WriteLine("Oldest member:");
                        Console.WriteLine(oldestMember.ToString());
                        Console.WriteLine("-------");
                        break;
                    case 3:
                        var fullNames = GetFullNames();
                        Console.WriteLine("Full names:");
                        fullNames.ForEach(name => Console.WriteLine(name));
                        Console.WriteLine("-------");
                        break;
                    case 4:
                        var listsBasedOnBirthYear = GetListsBasedOnBirthYear();
                        Console.WriteLine("Members born in 2000:");
                        listsBasedOnBirthYear.Item1.ForEach(m => Console.WriteLine(m.ToString()));
                        Console.WriteLine("Members born after 2000:");
                        listsBasedOnBirthYear.Item2.ForEach(m => Console.WriteLine(m.ToString()));
                        Console.WriteLine("Members born before 2000:");
                        listsBasedOnBirthYear.Item3.ForEach(m => Console.WriteLine(m.ToString()));
                        Console.WriteLine("-------");
                        break;
                    case 5:
                        var firstPersonBornInHanoi = GetFirstPersonBornInHanoi();
                        Console.WriteLine("First person born in Hà Nội:");
                        Console.WriteLine(firstPersonBornInHanoi.ToString());
                        Console.WriteLine("-------");
                        break;
                    case 0:
                        return;
                    default:
                        Console.WriteLine("Invalid option. Please try again!!!");
                        Console.WriteLine("-------");
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a number!!!");
                Console.WriteLine("-------");
            }
        }
    }
}