using System.Dynamic;
using ClassLibrary.Models;
namespace RefactoringApp
{
    internal class Program
    {
        static List<Guest> guests = new List<Guest>(); 
        public static void Main(string[] args)  
        {
            GreetGuest();
            GetInfo();
            WriteGuestsInfo();
        }
        public static void GreetGuest() {
            Console.WriteLine("Welcome to Guest hosting app!");
        }

        public static void GetInfo() {
            string firstName = "";
            string lastName = "";
            string message = "";
            string isMoreGuests = "yes";
            while (isMoreGuests == "yes")
            {               
                firstName = GetGuestInfo("Input your first name: ");
                lastName = GetGuestInfo("Input your last name: ");
                message = GetGuestInfo("Input message to host: ");

                Guest guest = new Guest() { FirstName = firstName, LastName = lastName, Message = message };                                
                guests.Add(guest);

                isMoreGuests = GetGuestInfo("Is there more guests? (write yes)?");
                if (isMoreGuests.ToLower() != "yes")
                {
                    break;
                }
            }
        }

        public static void WriteGuestsInfo() {
            foreach (Guest guest in guests)
            {
                Console.WriteLine(guest.GetInfo());
            }
        }

        public static string GetGuestInfo(string msg) {
            string output = "";
            Console.WriteLine(msg);
            output = Console.ReadLine();
            return output;
        }
    }
}
