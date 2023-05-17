using System;

namespace FootballTeamApp.Models
{
    class Football
    {
        public string PlayerName { get; set; }

        public int Age { get; set; }

        public int PlayerNumber { get; set; }

        public Football(string name,int age,int number) {
            PlayerName = name;
            Age=age;
            PlayerNumber = number;
        }
    }
}
