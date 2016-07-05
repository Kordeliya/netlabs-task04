using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TASK3;

namespace TASK4
{
    public class Employee : User
    {
        /// <summary>
        /// Опыт работы
        /// </summary>
        public int WorkExperience { get; set; }

        /// <summary>
        /// Должность
        /// </summary>
        public string Position { get; set; }
    }
}
