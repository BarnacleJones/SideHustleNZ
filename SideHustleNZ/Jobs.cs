using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SideHustleNZ
{
    class Jobs
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public Jobs()
        {
            Name = "";
            Description = "";
        }

        public Jobs(string name, string description)
        {
            Name = name;
            Description = description;
        }
    }
}
