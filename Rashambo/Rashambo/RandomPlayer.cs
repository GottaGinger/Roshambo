using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace Rashambo
{
    internal class RandomPlayer : Player
    {
        public override RashamboEnum GenerateRoshambo()
        {
          
            Random randomEnum = new Random();
            int randomToNum = randomEnum.Next(1, 3);
            return (RashamboEnum)randomToNum;
        }

    }
}
