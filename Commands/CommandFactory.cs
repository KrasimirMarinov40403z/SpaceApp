using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceApp.Commands
{
    class CommandFactory
    {
        public static Command Create(String command)
        {
            switch (command)
            {
                case Command.ADD:
                    return new AddCommand();
                case Command.LIST:
                    return new ListCommand();
                case Command.PRINT:
                    return new PrintCommand();
                case Command.STATS:
                    return new StatsCommand();
                default:
                    return new UnknownCommand();
            }
        }
    }

}
