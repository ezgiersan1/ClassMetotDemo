using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    internal class Musteri
    {
        public string FirstName { get; set; }
        public string Firstname { get; internal set; }
        public string LastName { get; set; }
        public string Lastname { get; internal set; }
        public int Age { get; set; }
        public int MusteriID { get; set; }

    }
}
