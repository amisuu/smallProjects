using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace smallConsoleProjects
{
    public class Salon
    {
        public IEnumerable<Reservations> Reservations;
        public IEnumerable<Klient> Clients;

        public void GiveStatus()
        {
            Status status = new Status();
            Guid guid = new Guid();                   
        }

        public void createReservations()
        {
            DateTime dateTime = DateTime.Parse(Console.ReadLine());
            var id = int.Parse(Console.ReadLine());

            var client = Clients.FirstOrDefault(c => c.ID == id);

            if (client == null) Console.WriteLine("Nie znaleziono klienta");

            showAvailableDates(dateTime);

            
            
        }

        public void showAvailableDates(DateTime dateTime)
        {
            var nextMonth = Enumerable.Range(0, 2)
                              .Select(i => DateTime.Now.AddMonths(i - 2))
                              .Select(date => date.ToString("dd/MM/yyyy"));

            nextMonth = (IEnumerable<string>)Reservations.Where(d => d.Data == null);
            var date = dateTime.ToString();
            bool exists = nextMonth.Contains(date);
            if (exists)
            {
                $"Podana data i godzina jest już zajęta".ToString();
            }
            else
            {
                $"Podana data i godzina jest wolna".ToString();
            }
            foreach (var d in nextMonth)
            {
                Console.WriteLine(d.ToString());
            }
        }
    }
}
