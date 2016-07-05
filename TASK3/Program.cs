using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK3
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            Console.WriteLine("Создание нового пользователя");
            Console.WriteLine("Введите имя:");
            user.FirstName = Console.ReadLine();
            Console.WriteLine("Введите отчество:");
            user.MiddleName = Console.ReadLine();
            Console.WriteLine("Введите фамилию:");
            user.LastName = Console.ReadLine();
            Console.WriteLine("Введите пол (1-жен, 2-муж):");
            string sex = Console.ReadLine();
            switch (sex)
            {
                case "1":
                    user.Sex = Sex.Female;
                    break;
                case "2":
                    user.Sex = Sex.Male;
                    break;
                default:
                    user.Sex = Sex.None;
                    Console.WriteLine("пол неизвестен.");
                    break;

            }
            Console.WriteLine("Введите дату рождения в формате dd-mm-yyyy");
            string dateBirth = Console.ReadLine();
            DateTime birth;
            while (!DateTime.TryParse(dateBirth, out birth) || birth.Year > DateTime.Now.Year)
            {
                Console.WriteLine("Неверно введены данные. Введите дату рождения в формате dd-mm-yyyy");
                dateBirth = Console.ReadLine();
            }
            user.Birthday = birth;
            Console.WriteLine("Успешное создание новой записи");
            Console.WriteLine("{0} {1} год(лет)", user.FullName, user.Age);
            Console.ReadKey();

        }
    }
}
