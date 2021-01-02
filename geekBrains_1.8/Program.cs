using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geekBrains_1._8
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            string age;
            string activity;

            Console.WriteLine(Properties.Settings.Default.greeting);

            if (string.IsNullOrEmpty(Properties.Settings.Default.name))
            {
                Properties.Settings.Default.name = Console.ReadLine();
                Properties.Settings.Default.age = Console.ReadLine();
                Properties.Settings.Default.activity = Console.ReadLine();
                Properties.Settings.Default.Save();

            }
            name = Properties.Settings.Default.name;
            age = Properties.Settings.Default.age;
            activity = Properties.Settings.Default.activity;

            age = Properties.Settings.Default.age;
            Console.WriteLine($"{name} {age} {activity}");

            Console.ReadLine();
        }
    }
}
