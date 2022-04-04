using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MovieLibrary.Model
{
    public class Borrow
    {
        public int NumberOfRegisterUser { get; set; }
        public int NumberOfRegisterEmployee { get; set; }
        public int NumberOfRegisterMovie { get; set; }
        public DateTime DayOfBorrow { get; set; }
        public DateTime DayOfdevolution { get; set; }

        public void CalculateDevolution()
        {
            //--2 days to receive back--
        }

    }
}
