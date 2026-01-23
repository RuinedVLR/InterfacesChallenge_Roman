using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesChallenge_Roman
{
    internal class Enemy
    {
        Position _position;
        ConsoleColor _color;

        enum MovementState
        {
            aggressive,
            passive,
            random
        };

        MovementState _movementState;

        public void Move()
        {
            if(_movementState == MovementState.aggressive)
            {
                // Move towards player
            }
            else if(_movementState == MovementState.passive)
            {
                // Stay still
            }
            else if(_movementState == MovementState.random)
            {
                // Move randomly
            }
        }

        public void ChangeState()
        {
            ConsoleKeyInfo keyInfo = Console.ReadKey(true);

            if (keyInfo.Key == ConsoleKey.I)
            {
                _movementState = MovementState.aggressive;
            }
            else if (keyInfo.Key == ConsoleKey.O)
            {
                _movementState = MovementState.passive;
            }
            else if (keyInfo.Key == ConsoleKey.P)
            {
                _movementState = MovementState.random;
            }
        }

        public Enemy(int xPos, int yPos, ConsoleColor color)
        {
            _position._xPos = xPos;
            _position._yPos = yPos;
            _color = color;
        }


    }
}
