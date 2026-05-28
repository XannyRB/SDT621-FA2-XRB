using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SectionB_Question1
{
    public class ServiceRequest
    {
        //Properties capturing request specs
        public string RequestType { get; set; }
        public int PriorityLevel { get; set; } //Scale 1 to 5
        public int SeverityLevel { get; set; } //Scale 1 to 10
        public double EstimatedResolutionHours { get; set; } 
        public Resident AssociatedResident { get; set; }
        public bool IsProcessed { get; set; }

        //Constructor
        public ServiceRequest(string requestType, int priorityLevel, int severityLevel, double estimatedResolutionHours, Resident associatedResident)
        {
            RequestType = requestType;
            PriorityLevel = priorityLevel;
            SeverityLevel = severityLevel;
            EstimatedResolutionHours = estimatedResolutionHours;
            AssociatedResident = associatedResident;
            IsProcessed = false; //Default to not processed
        }
    }
}
