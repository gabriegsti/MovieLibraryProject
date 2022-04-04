using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MovieLibrary.Model
{
    public class User
    {
        private String Name { get; set; }
        private DateTime Birthdate { get; set; }
        public string Cpf { get; set; }
        public int NumberOfRegister { get; set; }
        public List<Movie> moviesBorrowed { get; set; }
        public void borrow(List<Movie> movies)
        {
            //ask a borrow for the employee
        }
        public void giveBack()
        {
            // this user can giveback to a employee who will receive the things 
        }
    }
}
