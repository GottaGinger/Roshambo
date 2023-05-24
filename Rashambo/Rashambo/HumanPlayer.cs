using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rashambo
{
    internal class HumanPlayer : Player
    {
        public override RashamboEnum GenerateRoshambo()
        {
            Console.WriteLine("Pick a number: 1: rock 2: paper 3:scissors");
            string respond = Console.ReadLine();
            return (RashamboEnum)int.Parse(respond);
        }

    }
}
