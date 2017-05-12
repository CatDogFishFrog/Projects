using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeType
{
    class Program
    {
        static void Main(string[] args)
        {
            string date1, s, f;
            Console.WriteLine("Введите вашу фамилию");
            f=Console.ReadLine();
            Console.WriteLine("\nВведите вашу дату рождения в формате дд.мм.гггг");
            date1 = Console.ReadLine();
            DateTime date2 = Convert.ToDateTime(date1);
            Console.WriteLine("\nВаша фамилия - " + f);
            Console.WriteLine("\nВы родились - " + date2);
            DateTime datenow = DateTime.Now;
            Console.WriteLine("\nСегодня - " + datenow);
            TimeSpan DaysLive = datenow - date2;
            int i = (DaysLive.Days);
            Console.WriteLine("\nВы прожили - " + i + " дней");
            Console.WriteLine("\nСколько еще хотите учится?");
            s = Console.ReadLine();
            datenow = datenow.AddDays(Convert.ToInt32(s));
            Console.WriteLine("\nВы станете умныч " + datenow);
            Console.WriteLine("\nЭто будет " + datenow.DayOfWeek);
            Console.WriteLine("\nНажмите любую клавишу");
            Console.ReadKey();
        }
    }
}
