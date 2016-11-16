using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    [Serializable]
    class Person
    {
        public string firstName;
        public string lastName;
        public string emailId;
        public string pwd;

       public List<string> adsPosted = new List<string>();
       public List<string> bookings = new List<string>();
    }
}
