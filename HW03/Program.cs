namespace HW03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }



        static string[] PetsIsTrue(int kpet)
        {
            string[] PetsName = new string[kpet];

            for (int i = 0; i < kpet; i++)
            {
                if (kpet == 1)
                {
                    Console.WriteLine("Введите кличку вашего питомца");
                }
                else
                {
                    Console.WriteLine("Введите клички ваших питомцев");
                }
                PetsName[i] = Console.ReadLine();
            }
            return PetsName;
        }




        static string[] BestColors(int kpet)
        {
            string[] FavColors = new string[kpet];

            for (int i = 0; i < kpet; i++)
            {
                if (kpet == 1)
                {
                    Console.WriteLine("Введите кличку вашего питомца");
                }
                else
                {
                    Console.WriteLine("Введите клички ваших питомцев");
                }
                pssurname[i] = Console.ReadLine();
            }
            return pssurname;
        }



        static (string name, string surname, int age, string[] PetsName, string[] FavColors) Anketa()
        {
            (string name, string surname, int age, string[] PetsName, string[] FavColors) data;

            Console.WriteLine("Введите имя");
            data.name = Console.ReadLine();
            Console.WriteLine("Введите фамилию");
            data.surname = Console.ReadLine();
            Console.WriteLine("Введите ваш возраст");
            data.age = int.Parse(Console.ReadLine());
            Console.WriteLine("Есть ли у вас питомец?\nВведите да или нет");
            string havepet = Console.ReadLine();
            int kpet = 0;
            if (havepet == "да")
            {
                Console.WriteLine("Введите количество ваших питомцев");
                kpet = int.Parse(Console.ReadLine());
                data.PetsName = PetsIsTrue(kpet);

            }

            Console.WriteLine("Введите количество любимых цветов");

            int bcolors = int.Parse(Console.ReadLine());

            data.FavColors = BestColors(bcolors);

            return data;
        }





    }


    
}
