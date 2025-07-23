using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracker.models
{
    public class PriorityModel
    {
        public int id { get; set; }
        public string Name { get; set; }

        public PriorityModel(int _id, string _name)
        {
            this.id = _id;
            this.Name = _name;
        }
    }
}
