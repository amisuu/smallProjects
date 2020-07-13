using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pagination
{
    public class Table
    {
        Dictionary<int, string> firstNames;
        Dictionary<int, string> lastNames;
        Dictionary<int, string> majors;
        List<Student> listOfStudents;

        public List<Student> ListOfStudents { get => listOfStudents; set => listOfStudents = value; }
        public Dictionary<int, string> FirstNames { get => firstNames; }
        public Dictionary<int, string> LastNames { get => lastNames; }
        public Dictionary<int, string> Majors { get => majors; }

        public Table()
        {
            ListOfStudents = new List<Student>();
            GetTable();
        }

        public void GetTable()
        {
            firstNames = new Dictionary<int, string>
            {
                {1, "Marek" },
                {2, "Jarek" },
                {3, "Marcin" },
                {4, "Robert" },
                {5, "Leszek" },
                {6, "Zbyszek" },
                {7, "Jan" },
                {8, "Kamil" },
                {9, "Kuba" },
                {10, "Przemek" },
            };

            lastNames = new Dictionary<int, string>
            {
                {1, "Markowski" },
                {2, "Kowalski" },
                {3, "Pazdzioch" },
                {4, "Kiepski" },
                {5, "Malinowski" },
                {6, "Kobylak" },
                {7, "Walaszek" },
                {8, "Lewandowski" },
                {9, "Wojtyla" },
                {10, "Kabaczek" },
            };

            majors = new Dictionary<int, string>
            {
                {1, "Computer Science" },
                {2, "Biology" },
                {3, "Chemistry" },
                {4, "Mechanical" },
                {5, "Mathematics" },
                {6, "Robotics" },
            };
        }

        public List<Student> CreateList()
        {
            Random rand = new Random();
            for (int i = 0; i < 1000; i++)
            {
                int id = i + 1;
                firstNames.TryGetValue(rand.Next(10), out string firstName);
                lastNames.TryGetValue(rand.Next(10), out string lastName);
                majors.TryGetValue(rand.Next(6), out string major);
                int semester = rand.Next(1,9);

                ListOfStudents.Add(new Student(id, firstName, lastName, major, semester));
            }

            return ListOfStudents;
        }

        public List<Student> ShowRecorsPerPage(int sizeNumber, int pageNumber)
        {
            return listOfStudents.Skip((pageNumber - 1) * sizeNumber).Take(sizeNumber).ToList();
        }

        public void Pagination()
        {
            int elementsPerPage = 0;
            do
            {
                Console.WriteLine("How many elemtns you want to be presentes ?");
                elementsPerPage = int.Parse(Console.ReadLine());

            } while (elementsPerPage < 0);

            int pageNumbers = 0;
            do
            {
                Console.WriteLine("Which page ?");
                pageNumbers = int.Parse(Console.ReadLine());

            } while (pageNumbers < 1);

            var resultList = ShowRecorsPerPage(elementsPerPage, pageNumbers);

            if (resultList is null)
            {
                Console.WriteLine("There is no records to present!");
            }
            else
            {
                resultList.ForEach(y => Console.WriteLine(y.ToString()));
            }

            Console.ReadKey();
        }
    }
}
