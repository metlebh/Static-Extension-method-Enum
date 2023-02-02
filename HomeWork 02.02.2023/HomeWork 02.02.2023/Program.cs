using System;

namespace HomeWork_02._02._2023
{
    class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User("Metleb", "Huseynov", "SALAM12", RegistrationMonth.Yanvar);
            Console.WriteLine(user1.GetDetails());

            User user2 = new User("Seymur", "Guliyev", "1232323", RegistrationMonth.Mart);
            Console.WriteLine(user2.GetDetails());

            User user3 = new User("Omer", "Imanli", "adsgadsag", RegistrationMonth.Oktyabr);
            Console.WriteLine(user3.GetDetails());

            //User user4 = new User("Kanan", "Tapdiqli", "asdg", RegistrationMonth.Noyabr);
            //Console.WriteLine(user4.GetDetails());

            //User user5 = new User("Heyder", "Memmedov", "agdsgddsags", RegistrationMonth.Dekabr);
            //Console.WriteLine(user5.GetDetails());
        }
    }
}
