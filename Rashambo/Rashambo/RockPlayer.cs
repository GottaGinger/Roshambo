using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Rashambo
{
    internal class RockPlayer : Player
    {
        public override RashamboEnum GenerateRoshambo()
        {
            return RashamboEnum.rock;
        }
    }
}
