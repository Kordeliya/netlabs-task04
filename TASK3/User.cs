using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK3
{
    public class User
    {
        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public Sex Sex { get; set; }

        public DateTime Birthday { get; set; }

        public int Age
        {
            get
            {
                return GetAge();
            }
        }

        public string FullName
        {
            get
            {
                return String.Format("{0} {1} {2}",FirstName, MiddleName, LastName);
            }
        }


        private int GetAge()
        {
            int age = DateTime.Today.Year - Birthday.Year
            + (DateTime.Today.Month - Birthday.Month >= 0 ? 0 : -1)
            + (DateTime.Today.Month - Birthday.Month == 0
                && DateTime.Today.Day - Birthday.Day <= 0 ? -1 : 0);

            return age;
        }
    }

    public enum Sex
    {
        None,
        Female,
        Male
    }


}
