using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Zork
{
    public delegate void MyAction();

    public class Command
    {
        public string Name { get; set; }

        public string[] Verbs { get; set; }
        
        public Action<Game> Action { get; set; }

        public Command(string name, IEnumerable<string> verbs, Action<Game> action)
        {          
            Name = name;
            Verbs = verbs.ToArray();
            Action = action;
        }
    }
}
