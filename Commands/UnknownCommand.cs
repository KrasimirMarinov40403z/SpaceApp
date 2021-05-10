using SpaceApp.SpaceObject;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceApp.Commands
{
    class UnknownCommand : Command
    {
        public void execute(List<String> args)
        {
            Console.WriteLine(Messages.UNKNOWN_COMMAND);
        }
    }
}
