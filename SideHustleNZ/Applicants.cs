using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SideHustleNZ
{
    class Applicants
    {
        public string Name { get; set; }
        public string Skills { get; set; }
        public string Image { get; set; }

        public Applicants()
        {
            Name = "";
            Skills = "";
            Image = "";
        }

        public Applicants(string name, string skills, string image)
        {
            Name = name;
            Skills = skills;
            Image = image;
        }
    }
}
