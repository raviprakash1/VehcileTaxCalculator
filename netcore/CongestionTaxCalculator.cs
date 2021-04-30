using System;
public class CongestionTaxCalculator
{
    /**
         * Calculate the total toll fee for one day
         *
         * @param vehicle - the vehicle
         * @param dates   - date and time of all passes on one day
         * @return - the total congestion tax for that day
         */

    static void Main()
    {
        while (true) // Loop indefinitely
        {
            Console.Write(Environment.NewLine);
            Console.WriteLine("Enter Vehicle"); // Prompt
            string vehicle = Console.ReadLine(); // Getting string from user
            if (vehicle == "") // Exit condition
            {
                break;
            }
            Console.WriteLine($"You have entered : {vehicle}"); // Getting Input
            var vehicleType = VechileFactory.getVechile(vehicle);
            if (vehicleType != null)
            {
                //Taking random DateTimes
                Random gen = new Random();
                DateTime[] dates = {
                                        DateTime.Now.AddHours(gen.Next(12)), DateTime.Now.AddHours(gen.Next(12)),
                                        DateTime.Now.AddHours(gen.Next(12)), DateTime.Now.AddHours(gen.Next(12)),
                                        DateTime.Now.AddHours(gen.Next(12)) ,DateTime.Now.AddHours(gen.Next(12))
                                  };

                int tax = Calculate.Tax(vehicleType, dates);

                Console.WriteLine($"The total congestion tax for that day is -> {tax}"); //Here we go !!
            }
            else
            {
                Console.WriteLine($"Invalid value... Please try again."); //Here we go !!
            }
        }
    }


}