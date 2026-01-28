using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesChallenge_Roman
{
    internal class Enemy
    {
        public Position _position;
        public ConsoleColor _color;

        AgressiveMoveStrategy _aggressiveMoveStrategy = new AgressiveMoveStrategy();
        PassiveMoveStrategy _passiveMoveStrategy = new PassiveMoveStrategy();
        RandomMoveStrategy _randomMoveStrategy = new RandomMoveStrategy();

        IMoveStrategy _moveStrategy;

        public IMoveStrategy CurrentMoveStrategy => _moveStrategy;

        public void ChangeStrategy(ConsoleKeyInfo keyInfo)
        {
            if (keyInfo.Key == ConsoleKey.I)
            {
                _moveStrategy = _aggressiveMoveStrategy;
            }
            else if (keyInfo.Key == ConsoleKey.O)
            {
                _moveStrategy = _passiveMoveStrategy;
            }
            else if (keyInfo.Key == ConsoleKey.P)
            {
                _moveStrategy = _randomMoveStrategy;
            }
        }

        public Enemy(int xPos, int yPos, ConsoleColor color)
        {
            _position = new Position { _xPos = xPos, _yPos = yPos };
            _color = color;
            _moveStrategy = _randomMoveStrategy; //default strategy
        }


    }
}
