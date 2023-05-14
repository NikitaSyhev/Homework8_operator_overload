using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework8
{
    class Gamers
    {
        static private int myRandom()   //метод рандомайзера
        {
            Random random = new Random();
            var currentTime = DateTime.Now.Millisecond;
            int Number = currentTime;
            Number *= Number;
            int _myRandom = 1 + random.Next(Number) % 100;
            return _myRandom;
        }
        public Gamers()  //конструктор
        {
            name = "Gamer";
            coin = 1;
            honor = 100;
        }
        private string name;
        public string _name // свойства
        {
            get { return name; }
            set { name = value; coin = myRandom(); }
        }
        private int coin;

        public int _coin // свойство
        {
            get { return coin; }
        }
        private int honor;// свойство

        public int _honor
        {
            get { return honor; }
            set { honor = value; }
        }

        public static bool operator <(Gamers player1, Gamers player2) // перегрузка операторо
        {
            return player1._coin * player1._honor < player2._coin * player2._honor;
        }
        public static bool operator >(Gamers player1, Gamers player2)
        {
            return player1._coin * player1._honor > player2._coin * player2._honor;
        }
    }
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
                "1-й игрок {0} имеет {2} монет\n" +
                "2-й игрок {1} имеет {3} монет",
                gamer01._name, gamer02._name, gamer01._coin, gamer02._coin); ;
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

