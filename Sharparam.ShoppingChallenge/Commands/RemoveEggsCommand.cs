using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sharparam.ShoppingChallenge.Items;

namespace Sharparam.ShoppingChallenge.Commands
{
    public class RemoveEggsCommand : RemoveCommand<Egg>
    {
        public RemoveEggsCommand(ThisPoorGuy guy, int count) : base(guy, count)
        {

        }
    }
}
