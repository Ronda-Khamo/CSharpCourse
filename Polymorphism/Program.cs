using System;

namespace QuitApp_V4
{
    interface IQuittable
    {
        void Quit();
    }

    // Contractor implements IQuittable
    class Contractor : IQuittable
    {
        public string ContractorName { get; set; }
        public DateTime ContractEndDate { get; set; }

        public void Quit()
        {
            if (DateTime.Now >= ContractEndDate)
            {
                Console.WriteLine($"{ContractorName}'s contract has ended.");
            }
            else
            {
                Console.WriteLine($"{ContractorName} has voluntarily terminated the contract early.");
            }
        }
    }

    class Program
    {
        static void Main()
        {
            Contractor contractor = new Contractor
            {
                ContractorName = "Ronda Khamo",
                ContractEndDate = DateTime.Now.AddDays(-1) // Already ended
            };

            IQuittable quitter = contractor;

            quitter.Quit();

            Console.ReadLine();
        }
    }
}
