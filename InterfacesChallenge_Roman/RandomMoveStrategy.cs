using System;

namespace InterfacesChallenge_Roman
{
    internal class RandomMoveStrategy : IMoveStrategy
    {
        Random _rand = new Random();

        public Position Move(Position currentPosition, Position targetPosition)
        {
            // targetPosition ignored
            int xMove = _rand.Next(-1, 2); // -1, 0, 1
            int yMove = _rand.Next(-1, 2); // -1, 0, 1
            currentPosition._xPos += xMove;
            currentPosition._yPos += yMove;
            return currentPosition;
        }
    }
}
