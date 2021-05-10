using SpaceApp.SpaceObject;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceApp.Commands
{
    interface Command
    {
        public const String EXIT = "exit";

        public const String ADD = "add";

        public const String LIST = "list";

        public const String PRINT = "print";

        public const String STATS = "stats";

        public const String ARG_DELIM = " ";

        public void execute(List<String> args);
    }
}
