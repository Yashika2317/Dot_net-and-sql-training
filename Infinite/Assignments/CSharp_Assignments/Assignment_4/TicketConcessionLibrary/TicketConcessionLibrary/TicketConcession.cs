using System;

namespace TicketConcessionLibrary
{
    public class TicketConcession
    {
        public const int TotalFare = 500;

        public static void CalculateConcession(string name, int age)
        {
            if (age <= 5)
            {
                Console.WriteLine($"{name} - Little Champs: Free Ticket - Age: {age}");
            }
            else if (age > 60)
            {
                double concessionAmount = TotalFare * 0.3;
                double discountedFare = TotalFare - concessionAmount;
                Console.WriteLine($"Senior Citizen - {name} - Fare: {discountedFare} - Age: {age}");
            }
            else
            {
                Console.WriteLine($"Ticket Booked - {name} - Fare: {TotalFare} - Age: {age}");
            }
        }
    }
}
