using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracker
{
    public class StatusModel
    {
        private string v;

        public StatusModel(string v)
        {
            this.v = v;
        }

        public string Status { get; set; }
    }
}
