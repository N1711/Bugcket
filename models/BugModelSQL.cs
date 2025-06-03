using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracker.models
{
    public class BugModelSQL
    {
        public int? Id { get; set; }
        public string? Description { get; set; }
        public string? Version { get; set; }
        public string? Status { get; set; }
        public string? Priority { get; set; }
        public string? DectedBy { get; set; }
        public DateTime DateDetected { get; set; }
        public string? IssueNotes { get; set; }
        public string? FixNotes { get; set; }

        public BugModelSQL(int id, string description, string version, string status, string priority, string detectedBy, DateTime dateDetected, string issueNotes, string fixNotes) {
            this.Id = id;
            this.Description = description;
            this.Version = version;
            this.Status = status;
            this.Priority = priority;
            this.DectedBy = detectedBy;
            this.DateDetected = dateDetected;
            this.IssueNotes = issueNotes;
            this.FixNotes = fixNotes;
        }
    }
}
