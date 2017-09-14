using System;

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
            string day = Convert.ToString(datenow.DayOfWeek);
            day = translate_day(day);
            Console.WriteLine("\nСегодня - " + datenow + " "+ day);
            TimeSpan DaysLive = datenow - date2;
            int i = (DaysLive.Days);
            Console.WriteLine("\nВы прожили - " + i + " дней");
            Console.WriteLine("\nСколько дней еще хотите учится?");
            s = Console.ReadLine();
            datenow = datenow.AddDays(Convert.ToInt32(s));
            Console.WriteLine("\nВы станете умныч " + datenow);
            day = Convert.ToString(datenow.DayOfWeek);
            day = translate_day(day);
            Console.WriteLine("\nЭто будет " + day);
            Console.WriteLine("\nНажмите любую клавишу");
            Console.ReadKey();
        }

        static String translate_day(string day)
        {
            if (day == "Monday") day = "Понедельник";
            else if (day == "Tuesday") day = "Вторник";
            else if (day == "Wednesday") day = "Среда";
            else if (day == "Thursday") day = "Четверг";
            else if (day == "Friday") day = "Пятница";
            else if (day == "Saturday") day = "Суббота";
            else if (day == "Sunday") day = "Воскресенье";
            return day;
        }
    }
}
