using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesChallenge_Roman
{
    internal class Player
    {
        public Position _position;
        public ConsoleColor _color;

        public Player(int xPos, int yPos, ConsoleColor color)
        {
            _position = new Position { _xPos = xPos, _yPos = yPos };
            _color = color;
        }



    }
}
