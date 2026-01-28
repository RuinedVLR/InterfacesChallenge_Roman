using System;

namespace InterfacesChallenge_Roman
{
    internal class AgressiveMoveStrategy : IMoveStrategy
    {
        public Position Move(Position currentPosition, Position targetPosition)
        {
            // move one step toward the target
            int dx = targetPosition._xPos - currentPosition._xPos;
            int dy = targetPosition._yPos - currentPosition._yPos;

            currentPosition._xPos += Math.Sign(dx);
            currentPosition._yPos += Math.Sign(dy);

            return currentPosition;
        }
    }
}
