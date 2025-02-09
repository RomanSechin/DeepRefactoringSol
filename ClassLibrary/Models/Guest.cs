﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Models
{
    public class Guest
    {
        public string FirstName { get;  set; }
        public string LastName { get;  set; }
        public string Message{ get;  set; }        
        public string GetInfo() {
            return $"{FirstName} {LastName} {Message}";
        }
    }
}
