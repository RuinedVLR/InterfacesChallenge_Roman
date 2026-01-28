using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesChallenge_Roman
{
    internal interface IMoveStrategy
    {
        Position Move(Position currentPosition, Position targetPosition);
    }
}
