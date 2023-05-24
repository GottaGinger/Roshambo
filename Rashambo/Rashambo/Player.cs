using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rashambo
{
    abstract class Player
    {
      public string Name { get; set; }
      public RashamboEnum Roshambo {get; set;}

        public abstract RashamboEnum GenerateRoshambo();

    }
}
