using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace SectionB_Question1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UtilitiesManager manager = new UtilitiesManager();
            List<Resident> residents = new List<Resident>();
            List<ServiceRequest> requests = new List<ServiceRequest>();

            Console.WriteLine("==================================================");
            Console.WriteLine("    EMFULENI MUNICIPALITY SERVICE SYSTEM          ");
            Console.WriteLine("==================================================");


        //Cature Rsident Profile
        int totalResidents = PromptForInteger("Enter the total number of residents to register: ", 1, 100);
            for (int i = 0; i< totalResidents; i++)
            {
                Console.WriteLine($"\n--- Registering Resident #{i + 1} ---");
                Console.Write("Enter Resident Name: ");
                string name = Console.ReadLine();
                Console.Write("Enter Resident Address: ");
                string address = Console.ReadLine();
                Console.WriteLine("Enter Account Number: ");
                string account = Console.ReadLine();
                double usage = PromptForDouble("Enter Monthly Utility Usage (kWh/kL): ", 0, 100);

                residents.Add(new Resident(name, address, account, usage));
            }

            //Capture Service Requests
            Console.WriteLine("\n==================================================");
            int totalRequests = PromptForInteger("Enter total number of service requests to log: ", 0, 100);
            for (int i = 0; i <totalRequests; i++)
            {
                Console.WriteLine($"\n--- Logging Request #{i + 1} ---");


                //Display options to link request to resident profile context
                Console.WriteLine("Select associated Resident profile index: ");
                for (int r = 0; r< residents.Count; r++)
                {
                    Console.WriteLine($"[{r}] {residents[r].Name} (Acc: {residents[r].AccountNumber})");
                }
                int residentIndex = PromptForInteger("Choice Index: ", 0, residents.Count - 1);
                Resident selectedResident = residents[residentIndex];

                Console.WriteLine("Enter Request Type (e.g. Water leak, Power Outage): ");
                string type = Console.ReadLine();

                //Strict Validation Rules
                int priority = PromptForInteger("Enter Priority Level (1-5): ", 1, 5);
                int severity = PromptForInteger("Enter Severity Level (1-5): ", 1, 5);
                double resolutionHours = PromptForDouble("Enter Estimated Resolution Time (hours): ", 0.5, 720);

                requests.Add(new ServiceRequest(type, priority, severity, resolutionHours, selectedResident));
            }

            //Interactive Queue Processing Simulation Loop
            bool simulationActive = true;
            while (simulationActive)
            {
                Console.WriteLine("\n==================================================");
                Console.WriteLine("             PENDING REQUESTS QUEUE               ");
                Console.WriteLine("==================================================");

                int pendingCount = 0;
                for (int i = 0; i < requests.Count; i++)
                {
                    if (!requests[i].IsProcessed)
                    {
                        double score = manager.CalculateUrgencyScore(requests[i]);
                        Console.WriteLine($"[{i}] Type: {requests[i].RequestType} | Resident: {requests[i].AssociatedResident.Name} | Urgency Score: {score:F2}");
                        pendingCount++;
                    }
                }

                if (pendingCount == 0)
                {
                    Console.WriteLine("All active service logs have been fully processed.");
                    break;
                }

                Console.WriteLine("\nOptions: Enter the index number to process a request, or type '-1' to finish compilation.");
                int choice = PromptForInteger("Select processing target: ", -1, requests.Count - 1);

                if (choice == -1)
                {
                    simulationActive = false;
                }
                else if (requests[choice].IsProcessed)
                {
                    Console.WriteLine("Error: That request item has already been marked resolved");
                }
                else
                {
                    //Update operational state and show real-time report matrics
                    requests[choice].IsProcessed = true;
                    manager.DiplayRequestReport(requests[choice]);
                }

                //Final Summary compilation
                Console.WriteLine("\n==================================================");
                Console.WriteLine("          FINAL MUNICIPAL ACTION SUMMARY         ");
                Console.WriteLine("==================================================");

                ServiceRequest highestUrgency = null;
                double maxScore = -1;
                int resolvedCount = 0;

                foreach (var req in requests)
                {
                    double score = manager.CalculateUrgencyScore(req);
                    if (req.IsProcessed)
                    {
                        Console.WriteLine($"- RESOLVED: {req.RequestType} for {req.AssociatedResident.Name} (Urgency: {score:F2})");
                        resolvedCount++;
                    }

                    if (score > maxScore)
                    {
                        maxScore = score;
                        highestUrgency = req;
                    }
                }

                Console.WriteLine($"\nTotal tickets successfully managed: {resolvedCount} / {requests.Count}");
                if (highestUrgency != null)
                {
                    Console.WriteLine($"Highest Urgency Operational Ticket: {highestUrgency.RequestType} (Score: {maxScore:F2})");
                    Console.WriteLine($"Associated Account Holder: {highestUrgency.AssociatedResident.Name}");
                }
                Console.WriteLine("==================================================");

                Console.WriteLine("\nPress any key to exit operational log view...");
                Console.ReadKey();
            }
        }

        //Helper Methods for Validated User Input
        private static int PromptForInteger(string baselinePrompt, int minimumLimit, int maximumLimit)
        {
            int outputValue;
            while (true)
            {
                Console.WriteLine(baselinePrompt);
                if (int.TryParse(Console.ReadLine(), out outputValue) && outputValue >= minimumLimit && outputValue <= maximumLimit)
                {
                    return outputValue;
                }
                Console.WriteLine($"Invalid input format. Provide an integer value tracing between {minimumLimit} and {maximumLimit}.");
            }
        }

        //Helper utility method to capture and validate decimal configurations
        private static double PromptForDouble(string baselinePrompt, double minimumLimit, double maximumLimit)
        {
            double outputValue;
            while (true)
            {
                Console.WriteLine(baselinePrompt);
                if (double.TryParse(Console.ReadLine(), out outputValue) && outputValue >= minimumLimit && outputValue <= maximumLimit)
                {
                    return outputValue;
                }
                Console.WriteLine($"Invalid numeric configuration layout. Provide a value scaling between {minimumLimit} and {maximumLimit}.");
            }
        }
    }
}
