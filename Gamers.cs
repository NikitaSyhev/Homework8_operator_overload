﻿using System;
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
            set { name = value; coin = myRandom(); honor = myRandom(); } // добавил homor = MyRandom();
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
            if (player1._coin == player2._coin)
            {
                return player1._honor < player2._honor;
            }
            else if (player1._honor == player2._honor)
            {
                return player1._coin < player2._coin;
            }
            else if (player1._coin < player2._coin)
                return player1._honor > player2._honor;
            else if (player1._coin > player2._coin)
            {
                return player1._honor < player2._honor;
            }
            else
                return player1._coin * player1._honor < player2._coin * player2._honor;
        }
        public static bool operator >(Gamers player1, Gamers player2) // перегрузка операторо
        {
            if (player1._coin == player2._coin)
            {
                return player1._honor > player2._honor;
            }
            else if (player1._honor == player2._honor)
            {
                return player1._coin > player2._coin;
            }
            else if (player1._coin < player2._coin)
                return player1._honor < player2._honor;
            else if (player1._coin > player2._coin)
            {
                return player1._honor > player2._honor;
            }
            else
                return player1._coin * player1._honor > player2._coin * player2._honor;
        }
    }
}
