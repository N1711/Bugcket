using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracker
{
    public static class User
    {
        public static int Id { get; set; }
        public static string Name { get; set; }
        public static int accessLevel { get; set; }
        public static bool loggedIn { get; set; }
        public static bool bypass { get; set; }
    }
}
