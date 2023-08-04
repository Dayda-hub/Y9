using FitnessBL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace FitnessBL.Controller
{
    public class Controller
    {
         
        public User User { get; set; }

        public Controller(User user) 
        {
            if (user == null)
            {
                throw new ArgumentNullException("поле User не может быть пустым");
            }
        }

    }
}
