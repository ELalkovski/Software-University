using System;
using System.Collections.Generic;
using System.Linq;

namespace _9.Teamwork_projects
{
    public class Team
    {
        public string Name { get; set; }

        public string Creator { get; set; }

        public List<string> Members { get; set; }

        public Team()
        {
            Members = new List<string>();
        }
    }
}
