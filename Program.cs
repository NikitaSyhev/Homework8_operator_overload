using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework8
{
   
    internal class Program
    {
        static void Main(string[] args)
        {
            string name01, name02;
            try // если имена передаем аргументами
            {
                name01 = args[0];
                name02 = args[1];
            }
            catch // имена вводим через консоль
            {
                Console.WriteLine("Введите имя 1-го игрока");
                name01 = Console.ReadLine();
                Console.WriteLine("Введите имя 2-го игрока");
                name02 = Console.ReadLine();
            }
            Gamers gamer01 = new Gamers(); // создаем объект класса
            gamer01._name = name01; // присваиваем имя
            Gamers gamer02 = new Gamers();
            gamer02._name = name02;
            Console.WriteLine(


                //почему то у меня не генериурется доблесть рандомно, точнее герерируется но одинаковая
                "1-й игрок {0} имеет {2} монет, {4} доблести\n" + // добавил вывод доблести
                "2-й игрок {1} имеет {3} монет, {5} доблести",
                gamer01._name, gamer02._name, gamer01._coin, gamer02._coin, gamer01._honor, gamer02._honor); ;
            if (gamer01 > gamer02)
            {
                Console.WriteLine("Игрок {0} успешней игрока {1}", gamer01._name, gamer02._name);
            }
            else
            {
                if (gamer01 < gamer02)
                {
                    Console.WriteLine("Игрок {1} успешней игрока {0}", gamer01._name, gamer02._name);
                }
                else
                {
                    Console.WriteLine("Игрок {1} равен игроку {0}", gamer01._name, gamer02._name);
                }
                Console.ReadLine();

            }
        }
    }
}

