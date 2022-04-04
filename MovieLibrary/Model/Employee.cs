using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLibrary.Model
{
    public class Employee
    {
        public String  Name { get; set; }
        public double Payment { get; set; }
        public DateTime Birthdate { get; set; }
        public String Cpf { get; set; }

        public void receiveBorrow(List<Movie> Movies, User)
        {
            // receive a list of movies to see if it is possible to borrow
            // if the user has more than 2 movies it shouldnt take any more movies.
        }

        public void receiveDevolutions(List<Movie> Movies, User)
        {
            // receive the movies that is with the user.
        }
    }
}
