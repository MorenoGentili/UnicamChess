using System;

namespace Chess.Model
{
    public class Player : IPlayer
    {
        public string Name { get; private set; }
        public int Score { get; set; }

        public Player(string name){
            this.Name = name;
        }
    }
}