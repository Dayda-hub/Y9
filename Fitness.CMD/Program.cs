using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Fitness.CMD;
using FitnessBL;
using FitnessBL.Model;

namespace Fitness.CMD
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Вас приветствует приложение TraningCodeBloge");
            Console.WriteLine("Введите имя пользователя");

            Gender gender =new Gender("male");

            DateTime date = new DateTime(2001,11,10);
            
            User user = new User("Alex",gender,175,10,date);

            Controller controller  = new Controller(user);

            controller.Save();  
            Console.ReadLine(); 
        }
    }
}
