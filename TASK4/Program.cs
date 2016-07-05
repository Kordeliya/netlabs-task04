using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TASK3;

namespace TASK4
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee employee = new Employee();
            Console.WriteLine("Создание новой записи работника");
            Console.WriteLine("Введите имя:");
            employee.FirstName = Console.ReadLine();
            Console.WriteLine("Введите отчество:");
            employee.MiddleName = Console.ReadLine();
            Console.WriteLine("Введите фамилию:");
            employee.LastName = Console.ReadLine();
            Console.WriteLine("Введите пол (1-жен, 2-муж):");
            string sex = Console.ReadLine();
            switch (sex)
            {
                case "1":
                    employee.Sex = Sex.Female;
                    break;
                case "2":
                    employee.Sex = Sex.Male;
                    break;
                default:
                    employee.Sex = Sex.None;
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
            employee.Birthday = birth;
            Console.WriteLine("Введите должность:");
            employee.Position = Console.ReadLine();
            Console.WriteLine("Введите опыт работы(число полных лет):");
            var experience = Console.ReadLine();
            int workExperience;
            while (!Int32.TryParse(experience, out workExperience))
            {
                Console.WriteLine("Неверно введены данные. Введите опыт работы(число полных лет):");
                experience = Console.ReadLine();
            }
            employee.WorkExperience = workExperience;

            Console.WriteLine("Успешное создание новой записи");
            Console.WriteLine("{0} {1} год(лет) с опытом работы {2} года(лет) в должности {3}", employee.FullName, employee.Age,
                                                                                      employee.WorkExperience, employee.Position);
            Console.ReadKey();


        }
    }
}
