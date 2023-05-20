using System;
namespace Homework8
{
       internal class Teams() // создали класс для создания команд
        {
            Gamers team1, team2;
            public void createTeams(List<Gamers> _teams)          //метод объединения в команды, распределение по командам идет согласно номеру, присвоенному в классе Gamers ( рандомно )
            {
                string nameComand1 = "Team1", // присвоили имена
                    nameComand2 = "Team2";

                int coinTeam1 = 0; int coinTeam2 = 0; int honorTeam1 = 0; int honorTeam2 = 0; int luckinessTeam1 = 0; int luckinessTeam2 = 0; //создали переменные для записи параметров команды
                int parametrsTeam1 = 0, parametrsTeam2 = 0;  // переменная с суммарными параметрами
                foreach (var gamer in _teams)
                {
                    if (gamer._teamNumber % == 0) // у нас _teamNumber в классе Gamers равен либо 0 либо 1 ( рандомайзер создан ) 
                    {
                        team1._name = nameComand1;
                        coinTeam1 += _teams[i]._coin;
                        honorTeam1 += _teams[i]._honour;
                        luckinessTeam1 *= _teams[i]._luckiness;
                        parametrsTeam1 = coinTeam1 + honorTeam1 + luckinessTeam1;
                    }
                    else
                    {
                        team2._name = nameComand1;
                        coinTeam2 += _teams[i]._coin;
                        honorTeam2 += _teams[i]._honour;
                        luckinessTeam2 *= _teams[i]._luckiness;
                        parametrsTeam2 = coinTeam2 + honorTeam2 + luckinessTeam2;

            }
                }


                public void buttleTeams()
        {
            if (parametrsTeam1 > parametrsTeam2)
            {
                global::System.Console.WriteLine($"Победитель {team1._name}.");
            }
            else if (parametrsTeam1 < parametrsTeam2)
            {
                global::System.Console.WriteLine($"Победитель {team2._name}.");
            }
            else if (parametrsTeam1 == parametrsTeam2) 
            {
                if(luckinessTeam1 > luckinessTeam2)
                {
                    global::System.Console.WriteLine($"Победитель {team1._name}.");
                }
                else
                {
                    global::System.Console.WriteLine($"Победитель {team2._name}.");
                }
            }
        }

            }
        }
    }
}
