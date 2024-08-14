using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringApp.Model
{
    internal class Guest
    {
        public string FirstName {  get; private set; }
        public string LastName { get; private set; }
        public string Message { get; private set; }
        public Guest(string firstName, string lastName, string message) { 
            FirstName = firstName; 
            LastName = lastName;
            Message = message;
        }
        public string GetInfo() { return $"{FirstName} {LastName} {Message}"; }
    }
}
