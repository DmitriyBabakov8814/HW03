using static System.Runtime.InteropServices.JavaScript.JSType;

namespace HW03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var data = Anketa();
            ShowAnketa(data);
        }


        static void ShowAnketa((string name, string surname, int age, string[] PetsName, string[] FavColors) data) 
        {
            if(data.PetsName.Length == 0)
            {
                Console.WriteLine("Вот ваши данные\nИмя: {0}\nФамилия: {1}\nВозраст: {2}", data.name, data.surname, data.age);
                Console.Write("Ваши любимые цвета: ");
                for (int i = 0; i < data.FavColors.Length; i++)
                {
                    Console.Write(data.FavColors[i] + " ");
                }
            }
            else
            {
                Console.WriteLine("Вот ваши данные\nИмя: {0}\nФамилия: {1}\nВозраст: {2}", data.name, data.surname, data.age);
                Console.Write("Ваши любимые цвета: ");
                for (int i = 0; i < data.FavColors.Length; i++)
                {
                    Console.Write(data.FavColors[i] + " ");
                }

                Console.Write("\nКлички ваших питомцев: ");
                for (int i = 0; i < data.PetsName.Length; i++)
                {
                    Console.Write(data.PetsName[i] + " ");
                }
            }
        }


        static string[] PetsIsTrue(int kpet)
        {
            string[] PetsName = new string[kpet];

            for (int i = 0; i < kpet; i++)
            {
                
                Console.WriteLine("Введите кличку вашего {0} питомца", i + 1);
                PetsName[i] = Console.ReadLine();
            }
            return PetsName;
        }




        static string[] BestColors(int bcolors)
        {
            string[] FavColors = new string[bcolors];

            for (int i = 0; i < bcolors; i++)
            {
                Console.WriteLine("Введите название вашего {0} любимого цвета", i + 1);
                FavColors[i] = Console.ReadLine();
            }
            return FavColors;
        }



        static (string name, string surname, int age, string[] PetsName, string[] FavColors) Anketa()
        {
            (string name, string surname, int age, string[] PetsName, string[] FavColors) data;

            Console.WriteLine("Введите имя");
            data.name = Console.ReadLine();

            Console.WriteLine("Введите фамилию");
            data.surname = Console.ReadLine();

            Console.WriteLine("Введите ваш возраст");
            string methage = Console.ReadLine();
            data.age = CheckAge(methage);

            Console.WriteLine("Есть ли у вас питомец?\nВведите да или нет");
            string havepet = Console.ReadLine();

            if (havepet == "да")
            {
                Console.WriteLine("Введите количество ваших питомцев");
                string methkpet = Console.ReadLine();
                int kpet = CheckPets(methkpet);
                data.PetsName = PetsIsTrue(kpet);
            }

            else
            {
                data.PetsName = new string[0];
            }

            Console.WriteLine("Введите количество любимых цветов");
            string kcolors = Console.ReadLine();
            int bcolors = CheckColors(kcolors);
            data.FavColors = BestColors(bcolors);

            return data;
        }

        static int CheckAge(string age)
        {
            int a = 0;

            while(true)
            {
                if (int.TryParse(age, out a) && a > 0)
                {
                    return a;
                }
                else
                {
                    Console.WriteLine("Некорректный ввод. Пожалуйста, введите корректное число:");
                    age = Console.ReadLine();
                }
            }
        }

        static int CheckPets(string kpet)
        {
            int a = 0;

            while (true)
            {
                if (int.TryParse(kpet, out a) && a > 0)
                {
                    return a;
                }
                else
                {
                    Console.WriteLine("Некорректный ввод. Пожалуйста, введите корректное число:");
                    kpet = Console.ReadLine();
                }
            }
        }

        static int CheckColors(string favcolors)
        {
            int a = 0;

            while (true)
            {
                if (int.TryParse(favcolors, out a) && a > 0)
                {
                    return a;
                }
                else
                {
                    Console.WriteLine("Некорректный ввод. Пожалуйста, введите корректное число:");
                    favcolors = Console.ReadLine();
                }
            }
        }
    }
}
