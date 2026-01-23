using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesChallenge_Roman
{
    internal class Player
    {
        Position _position;
        ConsoleColor _color;

        public Player(int xPos, int yPos, ConsoleColor color)
        {
            _position._xPos = xPos;
            _position._yPos = yPos;
            _color = color;
        }



    }
}
