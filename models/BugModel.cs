using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracker.models
{
    public class BugModel
    {
        public ObjectId Id { get; set; }
        public string? Description { get; set; }
        public string? Version { get; set; }
        public string? Status { get; set; }
        public string? Priority { get; set; }
        public string? DectedBy { get; set; }
        public DateTime DateDetected { get; set; }
        public string? NotesIssue { get; set; }
        public string? NotesFix { get; set; }
    }
}
