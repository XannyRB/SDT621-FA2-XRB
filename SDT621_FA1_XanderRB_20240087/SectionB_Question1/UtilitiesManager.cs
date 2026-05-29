using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SectionB_Question1
{
    public class UtilitiesManager
    {
        //Algorithm to calculate request urgency score
        //Score formulation based on business priority and severity
        public double CalculateUrgencyScore(ServiceRequest request)
        {
            return (request.PriorityLevel * 2.5) + (request.SeverityLevel * 1.5);
        }

        //Generates a structured processing profile report for and individual item
        public void DiplayRequestReport(ServiceRequest request)
        {
            double urgencyScore = CalculateUrgencyScore(request);
            Console.WriteLine("\n--------------------------------------------------");
            Console.WriteLine("          INDIVIDUAL SERVICE REQUEST REPORT       ");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine($"Account Holder : {request.AssociatedResident.Name}");
            Console.WriteLine($"Account Number : {request.AssociatedResident.AccountNumber}");
            Console.WriteLine($"Service Type   : {request.RequestType}");
            Console.WriteLine($"Priority (1-5) : {request.PriorityLevel}");
            Console.WriteLine($"Severity (1-10): {request.SeverityLevel}");
            Console.WriteLine($"Est. Resolution: {request.EstimatedResolutionHours} Hours");
            Console.WriteLine($"Calculated Urgency Score: {urgencyScore:F2}");
            Console.WriteLine("--------------------------------------------------");
        }
    }
}
